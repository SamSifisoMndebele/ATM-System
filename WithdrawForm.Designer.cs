namespace ATM_System
{
    partial class WithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datetime = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.amount50 = new System.Windows.Forms.Button();
            this.amount100 = new System.Windows.Forms.Button();
            this.amount200 = new System.Windows.Forms.Button();
            this.amount500 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.amount500);
            this.panel1.Controls.Add(this.amount200);
            this.panel1.Controls.Add(this.amount100);
            this.panel1.Controls.Add(this.amount50);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.amountBox);
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(142, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 580);
            this.panel1.TabIndex = 4;
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
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.continueBtn.Location = new System.Drawing.Point(445, 497);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(166, 45);
            this.continueBtn.TabIndex = 6;
            this.continueBtn.Text = "CONTINUE";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cancelBtn.Location = new System.Drawing.Point(310, 497);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(118, 45);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(104, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Own Amount :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.amountBox.Location = new System.Drawing.Point(310, 414);
            this.amountBox.Multiline = true;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(301, 47);
            this.amountBox.TabIndex = 0;
            // 
            // amount50
            // 
            this.amount50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.amount50.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount50.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.amount50.Location = new System.Drawing.Point(138, 108);
            this.amount50.Name = "amount50";
            this.amount50.Size = new System.Drawing.Size(216, 108);
            this.amount50.TabIndex = 10;
            this.amount50.Text = "R 50";
            this.amount50.UseVisualStyleBackColor = false;
            this.amount50.Click += new System.EventHandler(this.amount50_Click);
            // 
            // amount100
            // 
            this.amount100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.amount100.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount100.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.amount100.Location = new System.Drawing.Point(395, 108);
            this.amount100.Name = "amount100";
            this.amount100.Size = new System.Drawing.Size(216, 108);
            this.amount100.TabIndex = 11;
            this.amount100.Text = "R100";
            this.amount100.UseVisualStyleBackColor = false;
            this.amount100.Click += new System.EventHandler(this.amount100_Click);
            // 
            // amount200
            // 
            this.amount200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.amount200.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount200.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.amount200.Location = new System.Drawing.Point(138, 254);
            this.amount200.Name = "amount200";
            this.amount200.Size = new System.Drawing.Size(216, 108);
            this.amount200.TabIndex = 12;
            this.amount200.Text = "R 200";
            this.amount200.UseVisualStyleBackColor = false;
            this.amount200.Click += new System.EventHandler(this.amount200_Click);
            // 
            // amount500
            // 
            this.amount500.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.amount500.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount500.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.amount500.Location = new System.Drawing.Point(395, 254);
            this.amount500.Name = "amount500";
            this.amount500.Size = new System.Drawing.Size(216, 108);
            this.amount500.TabIndex = 13;
            this.amount500.Text = "R 500";
            this.amount500.UseVisualStyleBackColor = false;
            this.amount500.Click += new System.EventHandler(this.amount500_Click);
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WithdrawForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WithdrawForm";
            this.Load += new System.EventHandler(this.WithdrawForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button amount50;
        private System.Windows.Forms.Button amount500;
        private System.Windows.Forms.Button amount200;
        private System.Windows.Forms.Button amount100;
    }
}