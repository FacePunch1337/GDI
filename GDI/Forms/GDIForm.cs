using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class GDIForm : Form
    {
        #region
        // https://docs.microsoft.com/en-us/previous-versions/ff728861(v=vs.85)
        delegate void TimerCallback(UInt32 uTimerID, UInt32 uMsg, ref UInt32 dwUser, UInt32 dw1, UInt32 dw2);



        // https://docs.microsoft.com/en-us/previous-versions/dd757634(v=vs.85)
        [DllImport("winmm.dll", SetLastError = true, EntryPoint = "timeSetEvent")]
        static extern UInt32 TimeSetEvent(UInt32 uDelay, UInt32 uResolution, TimerCallback lpTimeProc, ref UInt32 dwUser, UInt32 eventType);



        [DllImport("winmm.dll", SetLastError = true, EntryPoint = "timeKillEvent")]
        static extern void TimeKillEvent(UInt32 uTimerId);



        const int TIME_ONESHOT = 0;
        const int TIME_PERIODIC = 1;



        private uint uDelay, uResolution;
        private UInt32 timerId;

        private UInt32 dwUser = 0;
        TimerCallback timerCallback;
        GCHandle timerHandle;



        void Timer_Tick(UInt32 id, UInt32 msg, ref UInt32 userCtx, UInt32 rsv1, UInt32 rsv2)
        {
            try
            {
                if (!this.IsDisposed) this.Invoke((Action)IncLabel);
            }
            catch
            {

            }

        }


        void IncLabel()
        {

            if (!this.IsDisposed)
            {
                this.Text = (int.Parse(this.Text) + 1).ToString();

            }

        }

        void StartMmTimer()
        {
            this.Text = "1";
            uDelay = 10;
            uResolution = 10;
            timerCallback = new TimerCallback(Timer_Tick);
            timerHandle = GCHandle.Alloc(timerCallback);

            timerId = TimeSetEvent(uDelay, uResolution, timerCallback, ref dwUser, TIME_PERIODIC);
        }
        void StopMmTimer()
        {
            TimeKillEvent(timerId);
            timerHandle.Free();
        }
        #endregion
        static private GDIForm form = new GDIForm();
        static private GDIForm parent;
        static private bool pause = false;
        private Random random;
        private int mouse_pos_X;
        private int mouse_pos_Y;
        private List<Ball> balls = new List<Ball>();
        private RocketMoveDirections rocketMove = RocketMoveDirections.None;
        private Rocket rocket;
        private int score;
        private int missed;
        
        
        

        public GDIForm()
        {
            InitializeComponent();
            random = new Random();
            parent = this;
            score = 0;
            missed = 0;
            
            rocket = new Rocket
            {
                X = this.Width / 2,
                H = 15,
                W = 50,
                Brush = new SolidBrush(Color.Tomato)
            };



        }

        public void Score()
        {

            labelScore.Text = $"Score: {score}";
            labelMissed.Text = $"Missed: {missed}";
        }


        private void GDIForm_Paint(object sender, PaintEventArgs e)
        {

            foreach (Ball ball in balls)
            {

                e.Graphics.DrawRectangle(ball.clearPen, ball.X, ball.Y, ball.W, ball.H);
                //e.Graphics.FillEllipse(ballBrush, ball.X, ball.Y, ball.W, ball.H);

                ball.Move(panelDisplay);

                e.Graphics.DrawRectangle(ball.ballPen, ball.X, ball.Y, ball.W, ball.H);
                //e.Graphics.FillEllipse(ballBrush, ball.X, ball.Y, ball.W, ball.H);
            }

            switch (rocketMove)
            {
                case RocketMoveDirections.Left:
                    e.Graphics.FillRectangle(rocket.Brush, rocket.X, this.ClientSize.Height - rocket.H, rocket.W, rocket.H);
                    rocket.V = -10;
                    rocket.Move();
                    e.Graphics.FillRectangle(rocket.Brush, rocket.X, this.ClientSize.Height - rocket.H, rocket.W, rocket.H);
                    break;
                case RocketMoveDirections.Right:
                    e.Graphics.FillRectangle(rocket.Brush, rocket.X, this.ClientSize.Height - rocket.H, rocket.W, rocket.H);
                    rocket.V = 10;
                    rocket.Move();
                    break;
                case RocketMoveDirections.None:
                    break;

            }

            e.Graphics.FillRectangle(rocket.Brush, rocket.X, this.ClientSize.Height - rocket.H, rocket.W, rocket.H);

            Ball toRemove = null;
            foreach (Ball ball in balls)
            {
                if (ball.Y >= this.ClientSize.Height)
                {
                    toRemove = ball;
                }
                else if (ball.Y + ball.H >= this.ClientSize.Height - rocket.H && ball.Y + ball.H <= this.ClientSize.Height)
                {
                    if (ball.X + ball.W / 2 >= rocket.X && ball.X + ball.W / 2 <= rocket.X + rocket.W)
                    {
                        score += 1;
                        ball.Vy = -ball.Vy;
                        ball.Y = this.ClientSize.Height - rocket.H - ball.H;
                    }

                }

            }
            if (toRemove != null)
            {
                missed += 1;
                balls.Remove(toRemove);
            }
            
        }

        private void GDIForm_Load(object sender, EventArgs e)
        {
            GameLoad();
        }

        private void GDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //StopMmTimer();
            timer.Stop();
        }

        private void GDIForm_MouseMove(object sender, MouseEventArgs e)
        {
            mouse_pos_X = Convert.ToInt32(Control.MousePosition.X);
            mouse_pos_Y = Convert.ToInt32(Control.MousePosition.Y);
            labelMouseCoord.Text = $"{mouse_pos_X}.{mouse_pos_Y}";
        }


        class Ball
        {


            public SolidBrush clearBrush { get; set; }
            public SolidBrush ballBrush { get; set; }
            public Pen clearPen { get; set; }
            public Pen ballPen { get; set; }

            public Label labelMouseCoord { get; set; }

            public int PositionX { get; set; }
            public int PositionY { get; set; }

            public int X { get; set; }
            public int Y { get; set; }
            public int W { get; set; }
            public int H { get; set; }
            public int Vx { get; set; }
            public int Vy { get; set; }

            public void Move(Panel panel)
            {

                X += Vx;
                Y += Vy;
                if (X < 0)
                {
                    X = 0;
                    Vx = -Vx;


                }
                //Проверям Y с учётом размера панели по высоте окна
                if (Y < panel.Height)
                {
                    Y = panel.Height + 1;
                    Vy = -Vy;

                }

                //Проверям X с учётом размера шара по ширине окна
                if (X + W > form.ClientSize.Width)
                {
                    X = form.ClientSize.Width - W;
                    Vx = -Vx;

                }
                //Проверям Y с учётом размера шара по высоте окна
                /* if (Y + H > form.ClientSize.Height)
                 {

                     Y = form.ClientSize.Height - H;
                     Vy = -Vy;
                 }*/

                PositionX = X;
                PositionY = Y;


            }

        }

        class Rocket
        {
            public int X { get; set; }
            public int W { get; set; }
            public int H { get; set; }
            public int V { get; set; }

            public Brush Brush { get; set; }

            public void Move()
            {
                X += V;
                if (X < 0)
                {
                    X = 0;
                    V = -V;
                }
                if (X + W >= parent?.ClientSize.Width)
                {
                    X = parent.ClientSize.Width - W;
                    V = -V;
                }

            }
        }

        private void GDIForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                rocketMove = RocketMoveDirections.Left;
            }
            if (e.KeyCode == Keys.Right)
            {
                rocketMove = RocketMoveDirections.Right;
            }
        }

        private void GDIForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && rocketMove == RocketMoveDirections.Left)
            {
                rocketMove = RocketMoveDirections.None;
            }
            if (e.KeyCode == Keys.Right && rocketMove == RocketMoveDirections.Right)
            {
                rocketMove = RocketMoveDirections.None;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (balls.Count > 0)
            {
                labelBallCoord.Text = $"{balls[0].PositionX}.{balls[0].PositionY}";
                
            }
            else
            {
                timer.Stop();
                timerBallSpawn.Stop();
                labelGameOver.Visible = true;
                pictureQuit.Enabled = true;
                pictureQuit.Visible = true;
                pictureRestart.Enabled = true;
                pictureRestart.Visible = true;

            }

            picturePause.Image = Image.FromFile("icons-pause.bmp");
            Score();
            Invalidate();
        }

        enum RocketMoveDirections
        {
            None,
            Left,
            Right
        }



        

        //Метод спавна шарика
        private void SpawnBall()
        {
            for (int ball_index = 0; ball_index < 1; ball_index++)
            {

                balls.Add(new Ball
                {

                    X = form.ClientSize.Width / 6 + random.Next(form.ClientSize.Width),
                    W = 20,
                    H = 20,

                    Vx = random.Next(1, 10),
                    Vy = random.Next(1, 10),

                    clearBrush = new SolidBrush(form.BackColor),
                    ballBrush = new SolidBrush(Color.Tomato),
                    clearPen = new Pen(form.BackColor),
                    ballPen = new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)))
                });
            }


        }

        //Переопределённый метод спавна принимающий кол-во шариков
        private void SpawnBall(int amount)
        {
            for (int ball_index = 0; ball_index < amount; ball_index++)
            {
                SpawnBall();
            }
        }

        //Метод загрузки игры
        private void GameLoad()
        {
            timerBallSpawn.Start();
            labelGameOver.Visible = false;
            pictureRestart.Visible = false;
            pictureRestart.Enabled = false;
            pictureQuit.Visible = false;
            pictureQuit.Enabled = false;

            score = 0;
            missed = 0;

            pictureRestart.Image = Image.FromFile("icons-restart.bmp");
            pictureQuit.Image = Image.FromFile("icons-quit.bmp");

            SpawnBall(1);
            timer.Start();
        }

        //Событие таймера на спавн шариков
        private void timerBallSpawn_Tick(object sender, EventArgs e)
        {
            SpawnBall();
        }



        private void picturePause_Click(object sender, EventArgs e)
        {


            if (pause == false)
            {
                pause = true;
                timer.Stop();
                picturePause.Image = Image.FromFile("icons-resume.bmp");


            }
            else
            {
                pause = false;
                timer.Start();
                picturePause.Image = Image.FromFile("icons-pause.bmp");
            }



        }

        private void pictureRestart_Click(object sender, EventArgs e)
        {
            GameLoad();
        }

        private void pictureQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }



}
