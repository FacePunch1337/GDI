
namespace GDI
{
    partial class GDIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelBallCoord = new System.Windows.Forms.Label();
            this.labelMouseCoord = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelMissed = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.pictureRestart = new System.Windows.Forms.PictureBox();
            this.pictureQuit = new System.Windows.Forms.PictureBox();
            this.picturePause = new System.Windows.Forms.PictureBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.timerBallSpawn = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePause)).BeginInit();
            this.panelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelBallCoord
            // 
            this.labelBallCoord.AutoSize = true;
            this.labelBallCoord.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBallCoord.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBallCoord.Location = new System.Drawing.Point(203, 294);
            this.labelBallCoord.Name = "labelBallCoord";
            this.labelBallCoord.Size = new System.Drawing.Size(25, 13);
            this.labelBallCoord.TabIndex = 0;
            this.labelBallCoord.Text = "0.0";
            // 
            // labelMouseCoord
            // 
            this.labelMouseCoord.AutoSize = true;
            this.labelMouseCoord.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMouseCoord.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMouseCoord.Location = new System.Drawing.Point(203, 307);
            this.labelMouseCoord.Name = "labelMouseCoord";
            this.labelMouseCoord.Size = new System.Drawing.Size(25, 13);
            this.labelMouseCoord.TabIndex = 1;
            this.labelMouseCoord.Text = "0.0";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.labelTimer.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTimer.Location = new System.Drawing.Point(3, 10);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(55, 13);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "00:00:00";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScore.Location = new System.Drawing.Point(64, 10);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(55, 13);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "Score: 0";
            // 
            // labelMissed
            // 
            this.labelMissed.AutoSize = true;
            this.labelMissed.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMissed.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMissed.Location = new System.Drawing.Point(125, 10);
            this.labelMissed.Name = "labelMissed";
            this.labelMissed.Size = new System.Drawing.Size(61, 13);
            this.labelMissed.TabIndex = 4;
            this.labelMissed.Text = "Missed: 0";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGameOver.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameOver.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGameOver.Location = new System.Drawing.Point(52, 141);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(152, 34);
            this.labelGameOver.TabIndex = 5;
            this.labelGameOver.Text = "Game Over";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameOver.Visible = false;
            // 
            // pictureRestart
            // 
            this.pictureRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureRestart.Enabled = false;
            this.pictureRestart.ImageLocation = "";
            this.pictureRestart.InitialImage = null;
            this.pictureRestart.Location = new System.Drawing.Point(112, 195);
            this.pictureRestart.Name = "pictureRestart";
            this.pictureRestart.Size = new System.Drawing.Size(32, 31);
            this.pictureRestart.TabIndex = 6;
            this.pictureRestart.TabStop = false;
            this.pictureRestart.Click += new System.EventHandler(this.pictureRestart_Click);
            // 
            // pictureQuit
            // 
            this.pictureQuit.Enabled = false;
            this.pictureQuit.Location = new System.Drawing.Point(112, 241);
            this.pictureQuit.Name = "pictureQuit";
            this.pictureQuit.Size = new System.Drawing.Size(32, 31);
            this.pictureQuit.TabIndex = 7;
            this.pictureQuit.TabStop = false;
            this.pictureQuit.Click += new System.EventHandler(this.pictureQuit_Click);
            // 
            // picturePause
            // 
            this.picturePause.Location = new System.Drawing.Point(214, 3);
            this.picturePause.Name = "picturePause";
            this.picturePause.Size = new System.Drawing.Size(32, 31);
            this.picturePause.TabIndex = 8;
            this.picturePause.TabStop = false;
            this.picturePause.Click += new System.EventHandler(this.picturePause_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDisplay.Controls.Add(this.labelTimer);
            this.panelDisplay.Controls.Add(this.picturePause);
            this.panelDisplay.Controls.Add(this.labelScore);
            this.panelDisplay.Controls.Add(this.labelMissed);
            this.panelDisplay.Location = new System.Drawing.Point(2, 8);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(251, 31);
            this.panelDisplay.TabIndex = 0;
            // 
            // timerBallSpawn
            // 
            this.timerBallSpawn.Interval = 5000;
            this.timerBallSpawn.Tick += new System.EventHandler(this.timerBallSpawn_Tick);
            // 
            // GDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(255, 357);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.pictureQuit);
            this.Controls.Add(this.pictureRestart);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelMouseCoord);
            this.Controls.Add(this.labelBallCoord);
            this.DoubleBuffered = true;
            this.Name = "GDIForm";
            this.Text = "GDIForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GDIForm_FormClosing);
            this.Load += new System.EventHandler(this.GDIForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GDIForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GDIForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GDIForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GDIForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePause)).EndInit();
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelBallCoord;
        private System.Windows.Forms.Label labelMouseCoord;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelMissed;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.PictureBox pictureRestart;
        private System.Windows.Forms.PictureBox pictureQuit;
        private System.Windows.Forms.PictureBox picturePause;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Timer timerBallSpawn;
    }
}