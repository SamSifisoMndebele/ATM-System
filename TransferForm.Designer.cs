namespace ATM_System
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datetime = new System.Windows.Forms.Label();
            this.sendBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.accountNoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.amountBox);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.sendBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.accountNoBox);
            this.panel1.Location = new System.Drawing.Point(142, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 580);
            this.panel1.TabIndex = 3;
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
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sendBtn.Location = new System.Drawing.Point(445, 346);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(166, 45);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.clearBtn.Location = new System.Drawing.Point(310, 346);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(118, 45);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(104, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account No. :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountNoBox
            // 
            this.accountNoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNoBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.accountNoBox.Location = new System.Drawing.Point(310, 171);
            this.accountNoBox.Multiline = true;
            this.accountNoBox.Name = "accountNoBox";
            this.accountNoBox.Size = new System.Drawing.Size(301, 47);
            this.accountNoBox.TabIndex = 0;
            this.accountNoBox.TextChanged += new System.EventHandler(this.accountNoBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(104, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 47);
            this.label3.TabIndex = 12;
            this.label3.Text = "Amount :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.amountBox.Location = new System.Drawing.Point(310, 255);
            this.amountBox.Multiline = true;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(301, 47);
            this.amountBox.TabIndex = 11;
            this.amountBox.TextChanged += new System.EventHandler(this.amountBox_TextChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cancelBtn.Location = new System.Drawing.Point(310, 412);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(118, 45);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TransferForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountNoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button cancelBtn;
    }
}