
namespace GDI.Forms
{
    partial class ProcessForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.link_3 = new System.Windows.Forms.LinkLabel();
            this.link_2 = new System.Windows.Forms.LinkLabel();
            this.link_1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNotePadLog = new System.Windows.Forms.Button();
            this.buttonNotePadStop = new System.Windows.Forms.Button();
            this.buttonNotePadStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.treeViewProcesses = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.link_3);
            this.groupBox1.Controls.Add(this.link_2);
            this.groupBox1.Controls.Add(this.link_1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonNotePadLog);
            this.groupBox1.Controls.Add(this.buttonNotePadStop);
            this.groupBox1.Controls.Add(this.buttonNotePadStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дочерние процессы";
            // 
            // link_3
            // 
            this.link_3.AutoSize = true;
            this.link_3.Location = new System.Drawing.Point(9, 114);
            this.link_3.Name = "link_3";
            this.link_3.Size = new System.Drawing.Size(124, 13);
            this.link_3.TabIndex = 7;
            this.link_3.TabStop = true;
            this.link_3.Text = "https://mystat.itstep.org/";
            this.link_3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_3_LinkClicked);
            // 
            // link_2
            // 
            this.link_2.AutoSize = true;
            this.link_2.Location = new System.Drawing.Point(9, 89);
            this.link_2.Name = "link_2";
            this.link_2.Size = new System.Drawing.Size(95, 13);
            this.link_2.TabIndex = 6;
            this.link_2.TabStop = true;
            this.link_2.Text = "https://github.com";
            this.link_2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_2_LinkClicked);
            // 
            // link_1
            // 
            this.link_1.AutoSize = true;
            this.link_1.Location = new System.Drawing.Point(9, 66);
            this.link_1.Name = "link_1";
            this.link_1.Size = new System.Drawing.Size(131, 13);
            this.link_1.TabIndex = 5;
            this.link_1.TabStop = true;
            this.link_1.Text = "https://www.youtube.com";
            this.link_1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // buttonNotePadLog
            // 
            this.buttonNotePadLog.Location = new System.Drawing.Point(190, 29);
            this.buttonNotePadLog.Name = "buttonNotePadLog";
            this.buttonNotePadLog.Size = new System.Drawing.Size(49, 23);
            this.buttonNotePadLog.TabIndex = 3;
            this.buttonNotePadLog.Text = "info";
            this.buttonNotePadLog.UseVisualStyleBackColor = true;
            this.buttonNotePadLog.Click += new System.EventHandler(this.buttonNotePadLog_Click);
            // 
            // buttonNotePadStop
            // 
            this.buttonNotePadStop.Location = new System.Drawing.Point(135, 29);
            this.buttonNotePadStop.Name = "buttonNotePadStop";
            this.buttonNotePadStop.Size = new System.Drawing.Size(49, 23);
            this.buttonNotePadStop.TabIndex = 2;
            this.buttonNotePadStop.Text = "stop";
            this.buttonNotePadStop.UseVisualStyleBackColor = true;
            this.buttonNotePadStop.Click += new System.EventHandler(this.buttonNotePadStop_Click);
            // 
            // buttonNotePadStart
            // 
            this.buttonNotePadStart.Location = new System.Drawing.Point(80, 29);
            this.buttonNotePadStart.Name = "buttonNotePadStart";
            this.buttonNotePadStart.Size = new System.Drawing.Size(49, 23);
            this.buttonNotePadStart.TabIndex = 1;
            this.buttonNotePadStart.Text = "start";
            this.buttonNotePadStart.UseVisualStyleBackColor = true;
            this.buttonNotePadStart.Click += new System.EventHandler(this.buttonNotePadStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notepad.exe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.treeViewProcesses);
            this.groupBox2.Location = new System.Drawing.Point(344, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Системные процессы";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(255, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // treeViewProcesses
            // 
            this.treeViewProcesses.Location = new System.Drawing.Point(137, 19);
            this.treeViewProcesses.Name = "treeViewProcesses";
            this.treeViewProcesses.Size = new System.Drawing.Size(301, 407);
            this.treeViewProcesses.TabIndex = 0;
            this.treeViewProcesses.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewProcesses_NodeMouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonNotePadStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNotePadStop;
        private System.Windows.Forms.Button buttonNotePadLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TreeView treeViewProcesses;
        private System.Windows.Forms.LinkLabel link_1;
        private System.Windows.Forms.LinkLabel link_3;
        private System.Windows.Forms.LinkLabel link_2;
        private System.Windows.Forms.Timer timer1;
    }
}