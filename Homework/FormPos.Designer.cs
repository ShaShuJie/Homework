namespace Homework
{
    partial class FormPos
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
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.btnPistol = new System.Windows.Forms.Button();
            this.btnRifle = new System.Windows.Forms.Button();
            this.buttonPen = new System.Windows.Forms.Button();
            this.groupBoxTotalPrice = new System.Windows.Forms.GroupBox();
            this.labShowPayment = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.labShowList = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxPayMethod = new System.Windows.Forms.GroupBox();
            this.labCreditCard = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxTotalPrice.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.groupBoxPayMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.label4);
            this.groupBoxMenu.Controls.Add(this.label3);
            this.groupBoxMenu.Controls.Add(this.label2);
            this.groupBoxMenu.Controls.Add(this.label1);
            this.groupBoxMenu.Controls.Add(this.btnShotgun);
            this.groupBoxMenu.Controls.Add(this.btnPistol);
            this.groupBoxMenu.Controls.Add(this.btnRifle);
            this.groupBoxMenu.Controls.Add(this.buttonPen);
            this.groupBoxMenu.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxMenu.Location = new System.Drawing.Point(614, 12);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(160, 409);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "$10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "$1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "$100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "$10";
            // 
            // btnShotgun
            // 
            this.btnShotgun.BackgroundImage = global::Homework.Properties.Resources.shotgun;
            this.btnShotgun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShotgun.Location = new System.Drawing.Point(6, 214);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(91, 78);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            // 
            // btnPistol
            // 
            this.btnPistol.BackgroundImage = global::Homework.Properties.Resources.pisto;
            this.btnPistol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPistol.ForeColor = System.Drawing.Color.Black;
            this.btnPistol.Location = new System.Drawing.Point(6, 121);
            this.btnPistol.Name = "btnPistol";
            this.btnPistol.Size = new System.Drawing.Size(91, 78);
            this.btnPistol.TabIndex = 2;
            this.btnPistol.Text = "Pistol";
            this.btnPistol.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPistol.UseVisualStyleBackColor = true;
            this.btnPistol.Click += new System.EventHandler(this.btnPistol_Click);
            // 
            // btnRifle
            // 
            this.btnRifle.BackgroundImage = global::Homework.Properties.Resources.rifle;
            this.btnRifle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRifle.Location = new System.Drawing.Point(6, 310);
            this.btnRifle.Name = "btnRifle";
            this.btnRifle.Size = new System.Drawing.Size(91, 78);
            this.btnRifle.TabIndex = 1;
            this.btnRifle.Text = "Rifle";
            this.btnRifle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRifle.UseVisualStyleBackColor = true;
            this.btnRifle.Click += new System.EventHandler(this.btnRifle_Click);
            // 
            // buttonPen
            // 
            this.buttonPen.BackgroundImage = global::Homework.Properties.Resources.pen;
            this.buttonPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPen.Location = new System.Drawing.Point(6, 26);
            this.buttonPen.Name = "buttonPen";
            this.buttonPen.Size = new System.Drawing.Size(91, 78);
            this.buttonPen.TabIndex = 0;
            this.buttonPen.Text = "Pen ";
            this.buttonPen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonPen.UseVisualStyleBackColor = true;
            this.buttonPen.Click += new System.EventHandler(this.buttonPen_Click);
            // 
            // groupBoxTotalPrice
            // 
            this.groupBoxTotalPrice.Controls.Add(this.labShowPayment);
            this.groupBoxTotalPrice.Controls.Add(this.groupBox3);
            this.groupBoxTotalPrice.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxTotalPrice.Location = new System.Drawing.Point(620, 427);
            this.groupBoxTotalPrice.Name = "groupBoxTotalPrice";
            this.groupBoxTotalPrice.Size = new System.Drawing.Size(224, 73);
            this.groupBoxTotalPrice.TabIndex = 1;
            this.groupBoxTotalPrice.TabStop = false;
            this.groupBoxTotalPrice.Text = "總金額  Total Price";
            // 
            // labShowPayment
            // 
            this.labShowPayment.AutoSize = true;
            this.labShowPayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowPayment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labShowPayment.Location = new System.Drawing.Point(0, 26);
            this.labShowPayment.MinimumSize = new System.Drawing.Size(200, 30);
            this.labShowPayment.Name = "labShowPayment";
            this.labShowPayment.Size = new System.Drawing.Size(200, 30);
            this.labShowPayment.TabIndex = 4;
            this.labShowPayment.Text = "$0";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(6, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 107);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.labShowList);
            this.groupBoxList.Controls.Add(this.btnClear);
            this.groupBoxList.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxList.Location = new System.Drawing.Point(780, 12);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(276, 409);
            this.groupBoxList.TabIndex = 2;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "購物清單List";
            // 
            // labShowList
            // 
            this.labShowList.AutoSize = true;
            this.labShowList.BackColor = System.Drawing.Color.Transparent;
            this.labShowList.Location = new System.Drawing.Point(3, 20);
            this.labShowList.MinimumSize = new System.Drawing.Size(260, 350);
            this.labShowList.Name = "labShowList";
            this.labShowList.Size = new System.Drawing.Size(260, 350);
            this.labShowList.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxPayMethod
            // 
            this.groupBoxPayMethod.Controls.Add(this.labCreditCard);
            this.groupBoxPayMethod.Controls.Add(this.btnCreditCard);
            this.groupBoxPayMethod.Controls.Add(this.btnCash);
            this.groupBoxPayMethod.Controls.Add(this.groupBox4);
            this.groupBoxPayMethod.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBoxPayMethod.Location = new System.Drawing.Point(850, 432);
            this.groupBoxPayMethod.Name = "groupBoxPayMethod";
            this.groupBoxPayMethod.Size = new System.Drawing.Size(206, 68);
            this.groupBoxPayMethod.TabIndex = 3;
            this.groupBoxPayMethod.TabStop = false;
            this.groupBoxPayMethod.Text = "付款方式";
            // 
            // labCreditCard
            // 
            this.labCreditCard.AutoSize = true;
            this.labCreditCard.Location = new System.Drawing.Point(102, 40);
            this.labCreditCard.Name = "labCreditCard";
            this.labCreditCard.Size = new System.Drawing.Size(87, 16);
            this.labCreditCard.TabIndex = 6;
            this.labCreditCard.Text = "信用卡九折";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(105, 16);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(75, 23);
            this.btnCreditCard.TabIndex = 5;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(6, 16);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(75, 23);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.Location = new System.Drawing.Point(6, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 107);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Homework.Properties.Resources.Gunslotsofguns;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 478);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1069, 516);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxPayMethod);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBoxTotalPrice);
            this.Controls.Add(this.groupBoxMenu);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FormPos";
            this.Text = "Pos";
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.groupBoxTotalPrice.ResumeLayout(false);
            this.groupBoxTotalPrice.PerformLayout();
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.groupBoxPayMethod.ResumeLayout(false);
            this.groupBoxPayMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.Button btnPistol;
        private System.Windows.Forms.Button btnRifle;
        private System.Windows.Forms.Button buttonPen;
        private System.Windows.Forms.GroupBox groupBoxTotalPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.GroupBox groupBoxPayMethod;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labShowPayment;
        private System.Windows.Forms.Label labCreditCard;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labShowList;
    }
}