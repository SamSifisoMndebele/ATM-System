namespace ATM_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datetime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pinBox = new System.Windows.Forms.TextBox();
            this.accountNoBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pinBox);
            this.panel1.Controls.Add(this.accountNoBox);
            this.panel1.Location = new System.Drawing.Point(142, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 580);
            this.panel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(104, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "PIN :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.continueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.continueBtn.Location = new System.Drawing.Point(445, 346);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(166, 45);
            this.continueBtn.TabIndex = 6;
            this.continueBtn.Text = "CONTINUE";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
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
            // pinBox
            // 
            this.pinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.pinBox.Location = new System.Drawing.Point(310, 243);
            this.pinBox.Multiline = true;
            this.pinBox.Name = "pinBox";
            this.pinBox.Size = new System.Drawing.Size(301, 47);
            this.pinBox.TabIndex = 1;
            this.pinBox.TextChanged += new System.EventHandler(this.pinBox_TextChanged);
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 641);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox accountNoBox;
        private System.Windows.Forms.TextBox pinBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button continueBtn;

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.Label datetime;
    }
}

