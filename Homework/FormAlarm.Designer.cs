namespace Homework
{
    partial class FormAlarm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.labSecond = new System.Windows.Forms.Label();
            this.labMinute = new System.Windows.Forms.Label();
            this.labHour = new System.Windows.Forms.Label();
            this.textBoxSecond = new System.Windows.Forms.TextBox();
            this.textBoxMinute = new System.Windows.Forms.TextBox();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.btnCountdown = new System.Windows.Forms.Button();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.labCurrentTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.labSecond);
            this.groupBox1.Controls.Add(this.labMinute);
            this.groupBox1.Controls.Add(this.labHour);
            this.groupBox1.Controls.Add(this.textBoxSecond);
            this.groupBox1.Controls.Add(this.textBoxMinute);
            this.groupBox1.Controls.Add(this.textBoxHour);
            this.groupBox1.Controls.Add(this.btnCountdown);
            this.groupBox1.Location = new System.Drawing.Point(488, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(173, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // labSecond
            // 
            this.labSecond.AutoSize = true;
            this.labSecond.Location = new System.Drawing.Point(7, 95);
            this.labSecond.Name = "labSecond";
            this.labSecond.Size = new System.Drawing.Size(42, 12);
            this.labSecond.TabIndex = 6;
            this.labSecond.Text = "Second:";
            // 
            // labMinute
            // 
            this.labMinute.AutoSize = true;
            this.labMinute.Location = new System.Drawing.Point(7, 69);
            this.labMinute.Name = "labMinute";
            this.labMinute.Size = new System.Drawing.Size(38, 12);
            this.labMinute.TabIndex = 5;
            this.labMinute.Text = "Minute";
            // 
            // labHour
            // 
            this.labHour.AutoSize = true;
            this.labHour.Location = new System.Drawing.Point(7, 45);
            this.labHour.Name = "labHour";
            this.labHour.Size = new System.Drawing.Size(32, 12);
            this.labHour.TabIndex = 4;
            this.labHour.Text = "Hour:";
            // 
            // textBoxSecond
            // 
            this.textBoxSecond.Location = new System.Drawing.Point(65, 92);
            this.textBoxSecond.Name = "textBoxSecond";
            this.textBoxSecond.Size = new System.Drawing.Size(100, 22);
            this.textBoxSecond.TabIndex = 3;
            // 
            // textBoxMinute
            // 
            this.textBoxMinute.Location = new System.Drawing.Point(65, 64);
            this.textBoxMinute.Name = "textBoxMinute";
            this.textBoxMinute.Size = new System.Drawing.Size(100, 22);
            this.textBoxMinute.TabIndex = 2;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(65, 36);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(100, 22);
            this.textBoxHour.TabIndex = 1;
            // 
            // btnCountdown
            // 
            this.btnCountdown.Location = new System.Drawing.Point(173, 64);
            this.btnCountdown.Name = "btnCountdown";
            this.btnCountdown.Size = new System.Drawing.Size(75, 23);
            this.btnCountdown.TabIndex = 0;
            this.btnCountdown.Text = "倒數計時";
            this.btnCountdown.UseVisualStyleBackColor = true;
            this.btnCountdown.Click += new System.EventHandler(this.btnCountdown_Click);
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Enabled = true;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // labCurrentTime
            // 
            this.labCurrentTime.AutoSize = true;
            this.labCurrentTime.Location = new System.Drawing.Point(17, 47);
            this.labCurrentTime.Name = "labCurrentTime";
            this.labCurrentTime.Size = new System.Drawing.Size(65, 12);
            this.labCurrentTime.TabIndex = 1;
            this.labCurrentTime.Text = "CurrentTime";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labCurrentTime);
            this.groupBox2.Location = new System.Drawing.Point(489, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "現在時間";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Homework.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(8, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 248);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // FormAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormAlarm";
            this.Text = "倒數計時器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.Label labCurrentTime;
        private System.Windows.Forms.Button btnCountdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labSecond;
        private System.Windows.Forms.Label labMinute;
        private System.Windows.Forms.Label labHour;
        private System.Windows.Forms.TextBox textBoxSecond;
        private System.Windows.Forms.TextBox textBoxMinute;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}