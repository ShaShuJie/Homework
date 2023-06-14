namespace Homework
{
    partial class FormHello
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labEntryInfo = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.labAge = new System.Windows.Forms.Label();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labEntryInfo);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.btnSayHello);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.labAge);
            this.groupBox1.Controls.Add(this.textGender);
            this.groupBox1.Controls.Add(this.textAge);
            this.groupBox1.Controls.Add(this.labGender);
            this.groupBox1.Location = new System.Drawing.Point(1, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 289);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // labEntryInfo
            // 
            this.labEntryInfo.AutoSize = true;
            this.labEntryInfo.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEntryInfo.Location = new System.Drawing.Point(31, 28);
            this.labEntryInfo.Name = "labEntryInfo";
            this.labEntryInfo.Size = new System.Drawing.Size(154, 24);
            this.labEntryInfo.TabIndex = 7;
            this.labEntryInfo.Text = "輸入下列資訊";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(20, 89);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(39, 16);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名";
            // 
            // btnSayHello
            // 
            this.btnSayHello.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSayHello.Location = new System.Drawing.Point(50, 233);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(99, 30);
            this.btnSayHello.TabIndex = 6;
            this.btnSayHello.Text = "加入高桌會";
            this.btnSayHello.UseVisualStyleBackColor = true;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(64, 86);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 0;
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAge.Location = new System.Drawing.Point(20, 193);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(39, 16);
            this.labAge.TabIndex = 5;
            this.labAge.Text = "年齡";
            // 
            // textGender
            // 
            this.textGender.Location = new System.Drawing.Point(64, 133);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(100, 22);
            this.textGender.TabIndex = 2;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(64, 183);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 22);
            this.textAge.TabIndex = 4;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.Location = new System.Drawing.Point(20, 143);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(39, 16);
            this.labGender.TabIndex = 3;
            this.labGender.Text = "性別";
            // 
            // FormHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework.Properties.Resources._771253;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHello";
            this.Text = "加入高桌會";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labEntryInfo;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.TextBox textGender;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label labGender;
    }
}