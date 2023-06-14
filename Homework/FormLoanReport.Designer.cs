namespace Homework
{
    partial class FormLoanReport
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
            this.labMonthPaymentResult = new System.Windows.Forms.Label();
            this.textREMonthPaymentResult = new System.Windows.Forms.TextBox();
            this.labLoanRate = new System.Windows.Forms.Label();
            this.textRELoanRate = new System.Windows.Forms.TextBox();
            this.labLoanYear = new System.Windows.Forms.Label();
            this.textRELoanYear = new System.Windows.Forms.TextBox();
            this.labLoanAmount = new System.Windows.Forms.Label();
            this.textRELoanAmount = new System.Windows.Forms.TextBox();
            this.labTotalPaymentResult = new System.Windows.Forms.Label();
            this.textRETotalPaymentResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labMonthPaymentResult
            // 
            this.labMonthPaymentResult.AutoSize = true;
            this.labMonthPaymentResult.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMonthPaymentResult.Location = new System.Drawing.Point(253, 269);
            this.labMonthPaymentResult.Name = "labMonthPaymentResult";
            this.labMonthPaymentResult.Size = new System.Drawing.Size(55, 16);
            this.labMonthPaymentResult.TabIndex = 26;
            this.labMonthPaymentResult.Text = "月付款";
            // 
            // textREMonthPaymentResult
            // 
            this.textREMonthPaymentResult.Location = new System.Drawing.Point(340, 263);
            this.textREMonthPaymentResult.Name = "textREMonthPaymentResult";
            this.textREMonthPaymentResult.ReadOnly = true;
            this.textREMonthPaymentResult.Size = new System.Drawing.Size(100, 22);
            this.textREMonthPaymentResult.TabIndex = 25;
            // 
            // labLoanRate
            // 
            this.labLoanRate.AutoSize = true;
            this.labLoanRate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanRate.Location = new System.Drawing.Point(253, 224);
            this.labLoanRate.Name = "labLoanRate";
            this.labLoanRate.Size = new System.Drawing.Size(79, 16);
            this.labLoanRate.TabIndex = 24;
            this.labLoanRate.Text = "年利率(%)";
            // 
            // textRELoanRate
            // 
            this.textRELoanRate.Location = new System.Drawing.Point(340, 218);
            this.textRELoanRate.Name = "textRELoanRate";
            this.textRELoanRate.ReadOnly = true;
            this.textRELoanRate.Size = new System.Drawing.Size(100, 22);
            this.textRELoanRate.TabIndex = 23;
            // 
            // labLoanYear
            // 
            this.labLoanYear.AutoSize = true;
            this.labLoanYear.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanYear.Location = new System.Drawing.Point(253, 168);
            this.labLoanYear.Name = "labLoanYear";
            this.labLoanYear.Size = new System.Drawing.Size(71, 16);
            this.labLoanYear.TabIndex = 22;
            this.labLoanYear.Text = "期限(年)";
            // 
            // textRELoanYear
            // 
            this.textRELoanYear.Location = new System.Drawing.Point(340, 162);
            this.textRELoanYear.Name = "textRELoanYear";
            this.textRELoanYear.ReadOnly = true;
            this.textRELoanYear.Size = new System.Drawing.Size(100, 22);
            this.textRELoanYear.TabIndex = 21;
            // 
            // labLoanAmount
            // 
            this.labLoanAmount.AutoSize = true;
            this.labLoanAmount.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanAmount.Location = new System.Drawing.Point(253, 119);
            this.labLoanAmount.Name = "labLoanAmount";
            this.labLoanAmount.Size = new System.Drawing.Size(71, 16);
            this.labLoanAmount.TabIndex = 20;
            this.labLoanAmount.Text = "貸款金額";
            // 
            // textRELoanAmount
            // 
            this.textRELoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRELoanAmount.Location = new System.Drawing.Point(340, 113);
            this.textRELoanAmount.Name = "textRELoanAmount";
            this.textRELoanAmount.ReadOnly = true;
            this.textRELoanAmount.Size = new System.Drawing.Size(100, 22);
            this.textRELoanAmount.TabIndex = 19;
            // 
            // labTotalPaymentResult
            // 
            this.labTotalPaymentResult.AutoSize = true;
            this.labTotalPaymentResult.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPaymentResult.Location = new System.Drawing.Point(253, 311);
            this.labTotalPaymentResult.Name = "labTotalPaymentResult";
            this.labTotalPaymentResult.Size = new System.Drawing.Size(55, 16);
            this.labTotalPaymentResult.TabIndex = 27;
            this.labTotalPaymentResult.Text = "總付款";
            // 
            // textRETotalPaymentResult
            // 
            this.textRETotalPaymentResult.Location = new System.Drawing.Point(340, 311);
            this.textRETotalPaymentResult.Name = "textRETotalPaymentResult";
            this.textRETotalPaymentResult.ReadOnly = true;
            this.textRETotalPaymentResult.Size = new System.Drawing.Size(100, 22);
            this.textRETotalPaymentResult.TabIndex = 28;
            // 
            // FormLoanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textRETotalPaymentResult);
            this.Controls.Add(this.labTotalPaymentResult);
            this.Controls.Add(this.labMonthPaymentResult);
            this.Controls.Add(this.textREMonthPaymentResult);
            this.Controls.Add(this.labLoanRate);
            this.Controls.Add(this.textRELoanRate);
            this.Controls.Add(this.labLoanYear);
            this.Controls.Add(this.textRELoanYear);
            this.Controls.Add(this.labLoanAmount);
            this.Controls.Add(this.textRELoanAmount);
            this.Name = "FormLoanReport";
            this.Text = "報告輸出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMonthPaymentResult;
        private System.Windows.Forms.TextBox textREMonthPaymentResult;
        private System.Windows.Forms.Label labLoanRate;
        private System.Windows.Forms.TextBox textRELoanRate;
        private System.Windows.Forms.Label labLoanYear;
        private System.Windows.Forms.TextBox textRELoanYear;
        private System.Windows.Forms.Label labLoanAmount;
        private System.Windows.Forms.TextBox textRELoanAmount;
        private System.Windows.Forms.Label labTotalPaymentResult;
        private System.Windows.Forms.TextBox textRETotalPaymentResult;
    }
}