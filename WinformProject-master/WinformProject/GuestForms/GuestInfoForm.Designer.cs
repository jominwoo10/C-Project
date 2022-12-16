namespace WinformProject.Forms
{
    partial class GuestInfoForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblmoney = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbluserid = new System.Windows.Forms.Label();
            this.lblusermoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmoneyadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WinformProject.Properties.Resources.free_icon_font_comment_user_5074233;
            this.pictureBox1.Location = new System.Drawing.Point(350, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblname
            // 
            this.lblname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblname.Location = new System.Drawing.Point(308, 178);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(69, 25);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "이름 : ";
            // 
            // lblid
            // 
            this.lblid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblid.Location = new System.Drawing.Point(310, 234);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(51, 25);
            this.lblid.TabIndex = 2;
            this.lblid.Text = "ID : ";
            // 
            // lblmoney
            // 
            this.lblmoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmoney.AutoSize = true;
            this.lblmoney.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmoney.Location = new System.Drawing.Point(310, 289);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(107, 25);
            this.lblmoney.TabIndex = 3;
            this.lblmoney.Text = "보유금액 : ";
            // 
            // lblusername
            // 
            this.lblusername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblusername.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusername.Location = new System.Drawing.Point(428, 178);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(100, 25);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "test";
            this.lblusername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbluserid
            // 
            this.lbluserid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluserid.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbluserid.Location = new System.Drawing.Point(418, 234);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(110, 25);
            this.lbluserid.TabIndex = 6;
            this.lbluserid.Text = "test1";
            this.lbluserid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblusermoney
            // 
            this.lblusermoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblusermoney.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusermoney.Location = new System.Drawing.Point(404, 289);
            this.lblusermoney.Name = "lblusermoney";
            this.lblusermoney.Size = new System.Drawing.Size(100, 25);
            this.lblusermoney.TabIndex = 7;
            this.lblusermoney.Text = "1,000,000";
            this.lblusermoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(502, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "원";
            // 
            // btnmoneyadd
            // 
            this.btnmoneyadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmoneyadd.BackColor = System.Drawing.Color.Black;
            this.btnmoneyadd.FlatAppearance.BorderSize = 0;
            this.btnmoneyadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmoneyadd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmoneyadd.ForeColor = System.Drawing.Color.White;
            this.btnmoneyadd.Location = new System.Drawing.Point(535, 291);
            this.btnmoneyadd.Name = "btnmoneyadd";
            this.btnmoneyadd.Size = new System.Drawing.Size(40, 21);
            this.btnmoneyadd.TabIndex = 9;
            this.btnmoneyadd.Text = "충전";
            this.btnmoneyadd.UseVisualStyleBackColor = false;
            this.btnmoneyadd.Click += new System.EventHandler(this.btnmoneyadd_Click);
            // 
            // GuestInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmoneyadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblusermoney);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblmoney);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GuestInfoForm";
            this.Text = "내정보";
            this.Load += new System.EventHandler(this.GuestinfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblname;
        private Label lblid;
        private Label lblmoney;
        private Label lblusername;
        private Label lbluserid;
        private Label lblusermoney;
        private Label label1;
        private Button btnmoneyadd;
    }
}