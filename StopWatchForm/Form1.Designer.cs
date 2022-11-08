namespace StopWatchForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButStop = new System.Windows.Forms.Button();
            this.ButPR = new System.Windows.Forms.Button();
            this.ButStart = new System.Windows.Forms.Button();
            this.TextSec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextMin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextHour = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButStop
            // 
            this.ButStop.Enabled = false;
            this.ButStop.Font = new System.Drawing.Font("Roboto", 12F);
            this.ButStop.Location = new System.Drawing.Point(286, 82);
            this.ButStop.Name = "ButStop";
            this.ButStop.Size = new System.Drawing.Size(111, 47);
            this.ButStop.TabIndex = 2;
            this.ButStop.Text = "Stop";
            this.ButStop.UseVisualStyleBackColor = true;
            this.ButStop.Click += new System.EventHandler(this.ButStop_Click);
            // 
            // ButPR
            // 
            this.ButPR.Enabled = false;
            this.ButPR.Font = new System.Drawing.Font("Roboto", 12F);
            this.ButPR.Location = new System.Drawing.Point(151, 82);
            this.ButPR.Name = "ButPR";
            this.ButPR.Size = new System.Drawing.Size(111, 47);
            this.ButPR.TabIndex = 1;
            this.ButPR.Text = "Pause";
            this.ButPR.UseVisualStyleBackColor = true;
            this.ButPR.Click += new System.EventHandler(this.ButPR_Click);
            // 
            // ButStart
            // 
            this.ButStart.Font = new System.Drawing.Font("Roboto", 12F);
            this.ButStart.Location = new System.Drawing.Point(12, 82);
            this.ButStart.Name = "ButStart";
            this.ButStart.Size = new System.Drawing.Size(111, 47);
            this.ButStart.TabIndex = 0;
            this.ButStart.Text = "Start";
            this.ButStart.UseVisualStyleBackColor = true;
            this.ButStart.Click += new System.EventHandler(this.ButStart_Click);
            // 
            // TextSec
            // 
            this.TextSec.Font = new System.Drawing.Font("Roboto", 20F);
            this.TextSec.Location = new System.Drawing.Point(155, 17);
            this.TextSec.Name = "TextSec";
            this.TextSec.Size = new System.Drawing.Size(51, 29);
            this.TextSec.TabIndex = 4;
            this.TextSec.Text = "0";
            this.TextSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 20F);
            this.label3.Location = new System.Drawing.Point(69, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextMin
            // 
            this.TextMin.Font = new System.Drawing.Font("Roboto", 20F);
            this.TextMin.Location = new System.Drawing.Point(87, 17);
            this.TextMin.Name = "TextMin";
            this.TextMin.Size = new System.Drawing.Size(53, 29);
            this.TextMin.TabIndex = 6;
            this.TextMin.Text = "0";
            this.TextMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 20F);
            this.label5.Location = new System.Drawing.Point(139, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = ":";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextHour
            // 
            this.TextHour.Font = new System.Drawing.Font("Roboto", 20F);
            this.TextHour.Location = new System.Drawing.Point(21, 17);
            this.TextHour.Name = "TextHour";
            this.TextHour.Size = new System.Drawing.Size(53, 29);
            this.TextHour.TabIndex = 8;
            this.TextHour.Text = "0";
            this.TextHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.TextSec);
            this.groupBox1.Controls.Add(this.TextHour);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextMin);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(94, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 214);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of last time";
            // 
            // ListBox
            // 
            this.ListBox.Font = new System.Drawing.Font("Roboto", 16F);
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 25;
            this.ListBox.Location = new System.Drawing.Point(6, 20);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(373, 179);
            this.ListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButStart);
            this.Controls.Add(this.ButPR);
            this.Controls.Add(this.ButStop);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 400);
            this.MinimumSize = new System.Drawing.Size(425, 400);
            this.Name = "Form1";
            this.Text = "Stop Watch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButStop;
        private System.Windows.Forms.Button ButPR;
        private System.Windows.Forms.Button ButStart;
        private System.Windows.Forms.Label TextSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TextMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TextHour;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ListBox;
    }
}

