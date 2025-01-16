using System.ComponentModel;

namespace ATM_System
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonBulance = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userAccNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.buttonTransfer);
            this.GroupBox1.Controls.Add(this.buttonBulance);
            this.GroupBox1.Controls.Add(this.buttonWithdraw);
            this.GroupBox1.Controls.Add(this.buttonDeposit);
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(46, 194);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(525, 320);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Transaction";
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonTransfer.Location = new System.Drawing.Point(280, 181);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(204, 96);
            this.buttonTransfer.TabIndex = 16;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = false;
            this.buttonTransfer.Click += new System.EventHandler(this.buttonTransfer_Click);
            // 
            // buttonBulance
            // 
            this.buttonBulance.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonBulance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBulance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonBulance.Location = new System.Drawing.Point(34, 41);
            this.buttonBulance.Name = "buttonBulance";
            this.buttonBulance.Size = new System.Drawing.Size(204, 96);
            this.buttonBulance.TabIndex = 13;
            this.buttonBulance.Text = "Balance";
            this.buttonBulance.UseVisualStyleBackColor = false;
            this.buttonBulance.Click += new System.EventHandler(this.buttonBulance_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonWithdraw.Location = new System.Drawing.Point(34, 181);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(204, 96);
            this.buttonWithdraw.TabIndex = 15;
            this.buttonWithdraw.Text = "Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonDeposit.Location = new System.Drawing.Point(280, 41);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(204, 96);
            this.buttonDeposit.TabIndex = 14;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.userAccNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.userName);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.GroupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(142, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 580);
            this.panel1.TabIndex = 19;
            // 
            // userAccNo
            // 
            this.userAccNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAccNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userAccNo.Location = new System.Drawing.Point(210, 114);
            this.userAccNo.Name = "userAccNo";
            this.userAccNo.Size = new System.Drawing.Size(361, 47);
            this.userAccNo.TabIndex = 14;
            this.userAccNo.Text = "Name";
            this.userAccNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(74, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 47);
            this.label6.TabIndex = 13;
            this.label6.Text = "Acc No.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cancelButton.Location = new System.Drawing.Point(600, 426);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(118, 45);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userName.Location = new System.Drawing.Point(164, 67);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(518, 47);
            this.userName.TabIndex = 11;
            this.userName.Text = "Name";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datetime
            // 
            this.datetime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datetime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.datetime.Location = new System.Drawing.Point(373, 0);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(367, 47);
            this.datetime.TabIndex = 10;
            this.datetime.Text = "Date";
            this.datetime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(74, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 47);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hello, ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBulance;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Label userAccNo;
        private System.Windows.Forms.Label label6;
    }
}