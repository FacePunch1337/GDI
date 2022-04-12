using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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




        void Timer_Tick(UInt32 id, UInt32 msg, ref UInt32 userCtx, UInt32 rsv1, UInt32 rsv2)
        {
            try
            {
                Invoke((Action)IncLabel);
            }
            finally
            {
                TimeKillEvent(timerId);
                timerId = TimeSetEvent(uDelay, uResolution, Timer_Tick, ref dwUser, TIME_ONESHOT);
            }

        }



        void IncLabel()
        {
            this.Text = (int.Parse(this.Text) + 1).ToString();
        }
        #endregion

        static public GDIForm form = new GDIForm();

        Ball ball;
        int mouse_pos_X;
        int mouse_pos_Y;

        public GDIForm()
        {
            InitializeComponent();
         




        }



        private void GDIForm_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawRectangle(ball.clearPen, ball.X, ball.Y, ball.W, ball.H);
            //e.Graphics.FillEllipse(ballBrush, ball.X, ball.Y, ball.W, ball.H);

            ball.Move();

            e.Graphics.DrawRectangle(ball.ballPen, ball.X, ball.Y, ball.W, ball.H);
            //e.Graphics.FillEllipse(ballBrush, ball.X, ball.Y, ball.W, ball.H);


        }

        private void GDIForm_Load(object sender, EventArgs e)
        {
            /* this.Text = "1";
             uDelay = 10;
             uResolution = 3;

             timerId = TimeSetEvent(uDelay, uResolution, Timer_Tick ,ref dwUser, TIME_ONESHOT);*/
            ball = new Ball
            {
                X = form.ClientSize.Width / 2,
                Y = form.ClientSize.Height / 2,
                W = 20,
                H = 20,
                Vx = -2,
                Vy = -2,
                clearBrush = new SolidBrush(form.BackColor),
                ballBrush = new SolidBrush(Color.Tomato),
                clearPen = new Pen(form.BackColor),
                ballPen = new Pen(Color.Tomato, 3)
            };


            
            timer1.Start();


        }

        private void GDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TimeKillEvent(timerId);
            timer1.Stop();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            Invalidate();

        }

        class Ball
        {

            public SolidBrush clearBrush { get; set; }
            public SolidBrush ballBrush { get; set; }
            public Pen clearPen { get; set; }
            public Pen ballPen { get; set; }
            public Point Position { get; set; }
           
            public int X { get; set; }
            public int Y { get; set; }
            public int W { get; set; }
            public int H { get; set; }
            public int Vx { get; set; }
            public int Vy { get; set; }
            public Cursor Cursor { get; private set; }
            public int Location { get; private set; }

            public void Move()
            {

                X += Vx;
                Y += Vy;
                if (X < 0)
                {
                    X = 0;
                    Vx = -Vx;
                }
                if (Y < 0)
                {
                    Y = 0;
                    Vy = -Vy;
                }

                //Проверям X с учётом размера шара по ширине окна
                if (X + W > form.ClientSize.Width)
                {
                    X = form.ClientSize.Width - W;
                    Vx = -Vx;
                }
                //Проверям Y с учётом размера шара по высоте окна
                if (Y + H > form.ClientSize.Height)
                {
                    Y = form.ClientSize.Height - H;
                    Vy = -Vy;
                }


            }

         

       
        }


    }



}
