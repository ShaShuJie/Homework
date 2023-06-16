namespace Homework
{
    partial class FormHome
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnguess = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnOpenPos = new System.Windows.Forms.Button();
            this.btnOpenLoan = new System.Windows.Forms.Button();
            this.btnOpenHello = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.AutoScrollMinSize = new System.Drawing.Size(300, 600);
            this.splitContainer2.Panel1.BackgroundImage = global::Homework.Properties.Resources.homeleft;
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.btnPicture);
            this.splitContainer2.Panel1.Controls.Add(this.btnguess);
            this.splitContainer2.Panel1.Controls.Add(this.btnStruct);
            this.splitContainer2.Panel1.Controls.Add(this.btnPaint);
            this.splitContainer2.Panel1.Controls.Add(this.btnCountDown);
            this.splitContainer2.Panel1.Controls.Add(this.btnCal);
            this.splitContainer2.Panel1.Controls.Add(this.btnOpenPos);
            this.splitContainer2.Panel1.Controls.Add(this.btnOpenLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnOpenHello);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer2.Panel1MinSize = 300;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackgroundImage = global::Homework.Properties.Resources.homeright;
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2MinSize = 500;
            this.splitContainer2.Size = new System.Drawing.Size(1484, 796);
            this.splitContainer2.SplitterDistance = 395;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnPicture
            // 
            this.btnPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPicture.Location = new System.Drawing.Point(46, 301);
            this.btnPicture.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnPicture.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(298, 30);
            this.btnPicture.TabIndex = 8;
            this.btnPicture.Text = "Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnguess
            // 
            this.btnguess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnguess.Location = new System.Drawing.Point(46, 265);
            this.btnguess.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnguess.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnguess.Name = "btnguess";
            this.btnguess.Size = new System.Drawing.Size(298, 30);
            this.btnguess.TabIndex = 7;
            this.btnguess.Text = "猜數字";
            this.btnguess.UseVisualStyleBackColor = true;
            this.btnguess.Click += new System.EventHandler(this.btnguess_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStruct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStruct.Location = new System.Drawing.Point(46, 229);
            this.btnStruct.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnStruct.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(298, 30);
            this.btnStruct.TabIndex = 6;
            this.btnStruct.Text = "成績";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPaint.Location = new System.Drawing.Point(46, 193);
            this.btnPaint.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnPaint.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(298, 30);
            this.btnPaint.TabIndex = 5;
            this.btnPaint.Text = "小畫家";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnCountDown
            // 
            this.btnCountDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCountDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCountDown.Location = new System.Drawing.Point(46, 121);
            this.btnCountDown.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnCountDown.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(298, 30);
            this.btnCountDown.TabIndex = 4;
            this.btnCountDown.Text = "倒數計時器";
            this.btnCountDown.UseVisualStyleBackColor = true;
            this.btnCountDown.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnCal
            // 
            this.btnCal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCal.Location = new System.Drawing.Point(46, 157);
            this.btnCal.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnCal.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(298, 30);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "計算機";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnOpenPos
            // 
            this.btnOpenPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenPos.Location = new System.Drawing.Point(46, 85);
            this.btnOpenPos.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnOpenPos.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnOpenPos.Name = "btnOpenPos";
            this.btnOpenPos.Size = new System.Drawing.Size(298, 30);
            this.btnOpenPos.TabIndex = 2;
            this.btnOpenPos.Text = "Pos";
            this.btnOpenPos.UseVisualStyleBackColor = true;
            this.btnOpenPos.Click += new System.EventHandler(this.btnOpenPos_Click);
            // 
            // btnOpenLoan
            // 
            this.btnOpenLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenLoan.Location = new System.Drawing.Point(46, 49);
            this.btnOpenLoan.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnOpenLoan.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnOpenLoan.Name = "btnOpenLoan";
            this.btnOpenLoan.Size = new System.Drawing.Size(298, 30);
            this.btnOpenLoan.TabIndex = 1;
            this.btnOpenLoan.Text = "Loan";
            this.btnOpenLoan.UseVisualStyleBackColor = true;
            this.btnOpenLoan.Click += new System.EventHandler(this.btnOpenLoan_Click);
            // 
            // btnOpenHello
            // 
            this.btnOpenHello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenHello.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenHello.Location = new System.Drawing.Point(46, 13);
            this.btnOpenHello.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.btnOpenHello.MinimumSize = new System.Drawing.Size(200, 30);
            this.btnOpenHello.Name = "btnOpenHello";
            this.btnOpenHello.Size = new System.Drawing.Size(298, 30);
            this.btnOpenHello.TabIndex = 0;
            this.btnOpenHello.Text = "Hello";
            this.btnOpenHello.UseVisualStyleBackColor = true;
            this.btnOpenHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.splitContainer1.Panel1.BackgroundImage = global::Homework.Properties.Resources.hometop;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Enabled = false;
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1484, 1000);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormHome";
            this.Text = "Home";
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnOpenLoan;
        private System.Windows.Forms.Button btnOpenHello;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnOpenPos;
        private System.Windows.Forms.Button btnStruct;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnguess;
        private System.Windows.Forms.Button btnPicture;
    }
}

