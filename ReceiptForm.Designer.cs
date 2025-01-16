namespace ATM_System
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.newBalance = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.accountNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tranAmount = new System.Windows.Forms.Label();
            this.tranLabel = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblnewbal = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.status);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.newBalance);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.accountNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tranAmount);
            this.panel1.Controls.Add(this.tranLabel);
            this.panel1.Controls.Add(this.balance);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblnewbal);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.okBtn);
            this.panel1.Location = new System.Drawing.Point(142, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 580);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(256, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 47);
            this.label1.TabIndex = 35;
            this.label1.Text = "Receipt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newBalance
            // 
            this.newBalance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newBalance.Location = new System.Drawing.Point(368, 368);
            this.newBalance.Name = "newBalance";
            this.newBalance.Size = new System.Drawing.Size(200, 47);
            this.newBalance.TabIndex = 34;
            this.newBalance.Text = "Balance";
            this.newBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(80, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(287, 47);
            this.label12.TabIndex = 33;
            this.label12.Text = "New Account Balance :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountNo
            // 
            this.accountNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountNo.Location = new System.Drawing.Point(368, 227);
            this.accountNo.Name = "accountNo";
            this.accountNo.Size = new System.Drawing.Size(200, 47);
            this.accountNo.TabIndex = 32;
            this.accountNo.Text = "Account";
            this.accountNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(80, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 47);
            this.label3.TabIndex = 31;
            this.label3.Text = "Account No. :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tranAmount
            // 
            this.tranAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tranAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tranAmount.Location = new System.Drawing.Point(368, 321);
            this.tranAmount.Name = "tranAmount";
            this.tranAmount.Size = new System.Drawing.Size(200, 47);
            this.tranAmount.TabIndex = 30;
            this.tranAmount.Text = "Balance";
            this.tranAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tranLabel
            // 
            this.tranLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tranLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tranLabel.Location = new System.Drawing.Point(80, 321);
            this.tranLabel.Name = "tranLabel";
            this.tranLabel.Size = new System.Drawing.Size(287, 47);
            this.tranLabel.TabIndex = 29;
            this.tranLabel.Text = "Amount Withdraw :";
            this.tranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.balance.Location = new System.Drawing.Point(368, 274);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(200, 47);
            this.balance.TabIndex = 28;
            this.balance.Text = "Balance";
            this.balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(86, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(281, 47);
            this.label9.TabIndex = 27;
            this.label9.Text = "Balance :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblnewbal
            // 
            this.lblnewbal.AutoSize = true;
            this.lblnewbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewbal.Location = new System.Drawing.Point(272, 393);
            this.lblnewbal.Name = "lblnewbal";
            this.lblnewbal.Size = new System.Drawing.Size(0, 18);
            this.lblnewbal.TabIndex = 23;
            // 
            // datetime
            // 
            this.datetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datetime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.datetime.Location = new System.Drawing.Point(373, 0);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(367, 47);
            this.datetime.TabIndex = 9;
            this.datetime.Text = "Date";
            this.datetime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.okBtn.Location = new System.Drawing.Point(288, 443);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(145, 59);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(86, 133);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(575, 47);
            this.status.TabIndex = 36;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lblnewbal;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label tranAmount;
        private System.Windows.Forms.Label tranLabel;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label newBalance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label accountNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status;
    }
}