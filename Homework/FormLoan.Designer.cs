namespace Homework
{
    partial class FormLoan
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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTotalPayment = new System.Windows.Forms.Button();
            this.btnMonthPayment = new System.Windows.Forms.Button();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.textDownPayment = new System.Windows.Forms.TextBox();
            this.labLoanRate = new System.Windows.Forms.Label();
            this.textLoanRate = new System.Windows.Forms.TextBox();
            this.labLoanYear = new System.Windows.Forms.Label();
            this.textLoanYear = new System.Windows.Forms.TextBox();
            this.labLoanAmount = new System.Windows.Forms.Label();
            this.textLoanAmount = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(201, 21);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 21;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTotalPayment
            // 
            this.btnTotalPayment.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotalPayment.Location = new System.Drawing.Point(104, 21);
            this.btnTotalPayment.Name = "btnTotalPayment";
            this.btnTotalPayment.Size = new System.Drawing.Size(75, 23);
            this.btnTotalPayment.TabIndex = 20;
            this.btnTotalPayment.Text = "總付款";
            this.btnTotalPayment.UseVisualStyleBackColor = true;
            this.btnTotalPayment.Click += new System.EventHandler(this.btnTotalPayment_Click);
            // 
            // btnMonthPayment
            // 
            this.btnMonthPayment.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonthPayment.Location = new System.Drawing.Point(6, 21);
            this.btnMonthPayment.Name = "btnMonthPayment";
            this.btnMonthPayment.Size = new System.Drawing.Size(75, 23);
            this.btnMonthPayment.TabIndex = 19;
            this.btnMonthPayment.Text = "月付";
            this.btnMonthPayment.UseVisualStyleBackColor = true;
            this.btnMonthPayment.Click += new System.EventHandler(this.btnMonthPayment_Click);
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.Location = new System.Drawing.Point(26, 178);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(55, 16);
            this.labDownPayment.TabIndex = 18;
            this.labDownPayment.Text = "頭期款";
            // 
            // textDownPayment
            // 
            this.textDownPayment.Location = new System.Drawing.Point(113, 172);
            this.textDownPayment.Name = "textDownPayment";
            this.textDownPayment.Size = new System.Drawing.Size(151, 30);
            this.textDownPayment.TabIndex = 17;
            // 
            // labLoanRate
            // 
            this.labLoanRate.AutoSize = true;
            this.labLoanRate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanRate.Location = new System.Drawing.Point(26, 133);
            this.labLoanRate.Name = "labLoanRate";
            this.labLoanRate.Size = new System.Drawing.Size(79, 16);
            this.labLoanRate.TabIndex = 16;
            this.labLoanRate.Text = "年利率(%)";
            // 
            // textLoanRate
            // 
            this.textLoanRate.Location = new System.Drawing.Point(113, 127);
            this.textLoanRate.Name = "textLoanRate";
            this.textLoanRate.Size = new System.Drawing.Size(151, 30);
            this.textLoanRate.TabIndex = 15;
            // 
            // labLoanYear
            // 
            this.labLoanYear.AutoSize = true;
            this.labLoanYear.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanYear.Location = new System.Drawing.Point(26, 77);
            this.labLoanYear.Name = "labLoanYear";
            this.labLoanYear.Size = new System.Drawing.Size(71, 16);
            this.labLoanYear.TabIndex = 14;
            this.labLoanYear.Text = "期限(年)";
            // 
            // textLoanYear
            // 
            this.textLoanYear.Location = new System.Drawing.Point(113, 71);
            this.textLoanYear.Name = "textLoanYear";
            this.textLoanYear.Size = new System.Drawing.Size(151, 30);
            this.textLoanYear.TabIndex = 13;
            // 
            // labLoanAmount
            // 
            this.labLoanAmount.AutoSize = true;
            this.labLoanAmount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanAmount.Location = new System.Drawing.Point(26, 28);
            this.labLoanAmount.Name = "labLoanAmount";
            this.labLoanAmount.Size = new System.Drawing.Size(71, 16);
            this.labLoanAmount.TabIndex = 12;
            this.labLoanAmount.Text = "貸款金額";
            // 
            // textLoanAmount
            // 
            this.textLoanAmount.Location = new System.Drawing.Point(113, 22);
            this.textLoanAmount.Name = "textLoanAmount";
            this.textLoanAmount.Size = new System.Drawing.Size(151, 30);
            this.textLoanAmount.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labDownPayment);
            this.groupBox1.Controls.Add(this.textDownPayment);
            this.groupBox1.Controls.Add(this.labLoanRate);
            this.groupBox1.Controls.Add(this.textLoanRate);
            this.groupBox1.Controls.Add(this.labLoanYear);
            this.groupBox1.Controls.Add(this.textLoanYear);
            this.groupBox1.Controls.Add(this.labLoanAmount);
            this.groupBox1.Controls.Add(this.textLoanAmount);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 222);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "輸入數值";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMonthPayment);
            this.groupBox2.Controls.Add(this.btnTotalPayment);
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 62);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "計算";
            // 
            // FormLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework.Properties.Resources.LOAN;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLoan";
            this.Text = "貸款計算";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTotalPayment;
        private System.Windows.Forms.Button btnMonthPayment;
        private System.Windows.Forms.Label labDownPayment;
        public System.Windows.Forms.TextBox textDownPayment;
        private System.Windows.Forms.Label labLoanRate;
        public System.Windows.Forms.TextBox textLoanRate;
        private System.Windows.Forms.Label labLoanYear;
        public System.Windows.Forms.TextBox textLoanYear;
        private System.Windows.Forms.Label labLoanAmount;
        public System.Windows.Forms.TextBox textLoanAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}