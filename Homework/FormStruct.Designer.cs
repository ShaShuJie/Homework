namespace Homework
{
    partial class FormStruct
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
            this.labName = new System.Windows.Forms.Label();
            this.labCH = new System.Windows.Forms.Label();
            this.labEN = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCH = new System.Windows.Forms.TextBox();
            this.textEN = new System.Windows.Forms.TextBox();
            this.labShow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHLScore = new System.Windows.Forms.Button();
            this.textME = new System.Windows.Forms.TextBox();
            this.labME = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labHLScore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(79, 77);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(47, 16);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // labCH
            // 
            this.labCH.AutoSize = true;
            this.labCH.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCH.Location = new System.Drawing.Point(79, 120);
            this.labCH.Name = "labCH";
            this.labCH.Size = new System.Drawing.Size(47, 16);
            this.labCH.TabIndex = 1;
            this.labCH.Text = "國文:";
            // 
            // labEN
            // 
            this.labEN.AutoSize = true;
            this.labEN.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEN.Location = new System.Drawing.Point(79, 163);
            this.labEN.Name = "labEN";
            this.labEN.Size = new System.Drawing.Size(47, 16);
            this.labEN.TabIndex = 2;
            this.labEN.Text = "英文:";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(80, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(146, 241);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(115, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(132, 77);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(129, 22);
            this.textName.TabIndex = 5;
            // 
            // textCH
            // 
            this.textCH.Location = new System.Drawing.Point(132, 120);
            this.textCH.Name = "textCH";
            this.textCH.Size = new System.Drawing.Size(128, 22);
            this.textCH.TabIndex = 6;
            // 
            // textEN
            // 
            this.textEN.Location = new System.Drawing.Point(132, 163);
            this.textEN.Name = "textEN";
            this.textEN.Size = new System.Drawing.Size(129, 22);
            this.textEN.TabIndex = 7;
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Location = new System.Drawing.Point(19, 23);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(0, 12);
            this.labShow.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labShow);
            this.groupBox1.Location = new System.Drawing.Point(397, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 210);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // btnHLScore
            // 
            this.btnHLScore.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHLScore.Location = new System.Drawing.Point(397, 382);
            this.btnHLScore.Name = "btnHLScore";
            this.btnHLScore.Size = new System.Drawing.Size(168, 23);
            this.btnHLScore.TabIndex = 10;
            this.btnHLScore.Text = "最高分/最低分科目";
            this.btnHLScore.UseVisualStyleBackColor = true;
            this.btnHLScore.Click += new System.EventHandler(this.btnHLScore_Click);
            // 
            // textME
            // 
            this.textME.Location = new System.Drawing.Point(132, 204);
            this.textME.Name = "textME";
            this.textME.Size = new System.Drawing.Size(129, 22);
            this.textME.TabIndex = 12;
            // 
            // labME
            // 
            this.labME.AutoSize = true;
            this.labME.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labME.Location = new System.Drawing.Point(79, 204);
            this.labME.Name = "labME";
            this.labME.Size = new System.Drawing.Size(47, 16);
            this.labME.TabIndex = 11;
            this.labME.Text = "數學:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labHLScore);
            this.groupBox2.Location = new System.Drawing.Point(397, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 106);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "最高分/最低分科目";
            // 
            // labHLScore
            // 
            this.labHLScore.AutoSize = true;
            this.labHLScore.Location = new System.Drawing.Point(19, 23);
            this.labHLScore.Name = "labHLScore";
            this.labHLScore.Size = new System.Drawing.Size(0, 12);
            this.labHLScore.TabIndex = 8;
            // 
            // FormStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textME);
            this.Controls.Add(this.labME);
            this.Controls.Add(this.btnHLScore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEN);
            this.Controls.Add(this.textCH);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labEN);
            this.Controls.Add(this.labCH);
            this.Controls.Add(this.labName);
            this.Name = "FormStruct";
            this.Text = "成績";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCH;
        private System.Windows.Forms.Label labEN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCH;
        private System.Windows.Forms.TextBox textEN;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHLScore;
        private System.Windows.Forms.TextBox textME;
        private System.Windows.Forms.Label labME;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labHLScore;
    }
}