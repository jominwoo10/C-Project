namespace WinformProject.Forms
{
    partial class GuestCartForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgCart = new System.Windows.Forms.DataGridView();
            this.lblmoney = new System.Windows.Forms.Label();
            this.lblUsermoney = new System.Windows.Forms.Label();
            this.lblcal = new System.Windows.Forms.Label();
            this.lblCalmoney = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblbwon1 = new System.Windows.Forms.Label();
            this.lblwon2 = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.lblsub2 = new System.Windows.Forms.Label();
            this.lbladmin = new System.Windows.Forms.Label();
            this.lbladminmoney = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.lblminus = new System.Windows.Forms.Label();
            this.lblitemcount = new System.Windows.Forms.Label();
            this.lblitemcartcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCart
            // 
            this.dgCart.AllowUserToAddRows = false;
            this.dgCart.AllowUserToDeleteRows = false;
            this.dgCart.AllowUserToOrderColumns = true;
            this.dgCart.AllowUserToResizeColumns = false;
            this.dgCart.AllowUserToResizeRows = false;
            this.dgCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCart.BackgroundColor = System.Drawing.Color.White;
            this.dgCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCart.ColumnHeadersHeight = 40;
            this.dgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCart.EnableHeadersVisualStyles = false;
            this.dgCart.Location = new System.Drawing.Point(44, 12);
            this.dgCart.MultiSelect = false;
            this.dgCart.Name = "dgCart";
            this.dgCart.ReadOnly = true;
            this.dgCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCart.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCart.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCart.RowTemplate.Height = 25;
            this.dgCart.Size = new System.Drawing.Size(696, 241);
            this.dgCart.TabIndex = 2;
            this.dgCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCart_CellClick);
            // 
            // lblmoney
            // 
            this.lblmoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmoney.AutoSize = true;
            this.lblmoney.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblmoney.Location = new System.Drawing.Point(478, 248);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(88, 20);
            this.lblmoney.TabIndex = 3;
            this.lblmoney.Text = "보유 금액 : ";
            // 
            // lblUsermoney
            // 
            this.lblUsermoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsermoney.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsermoney.Location = new System.Drawing.Point(593, 249);
            this.lblUsermoney.Name = "lblUsermoney";
            this.lblUsermoney.Size = new System.Drawing.Size(90, 20);
            this.lblUsermoney.TabIndex = 4;
            this.lblUsermoney.Text = "100,000";
            this.lblUsermoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcal
            // 
            this.lblcal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcal.AutoSize = true;
            this.lblcal.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcal.Location = new System.Drawing.Point(479, 283);
            this.lblcal.Name = "lblcal";
            this.lblcal.Size = new System.Drawing.Size(88, 20);
            this.lblcal.TabIndex = 5;
            this.lblcal.Text = "결제 금액 : ";
            // 
            // lblCalmoney
            // 
            this.lblCalmoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCalmoney.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalmoney.Location = new System.Drawing.Point(593, 283);
            this.lblCalmoney.Name = "lblCalmoney";
            this.lblCalmoney.Size = new System.Drawing.Size(90, 20);
            this.lblCalmoney.TabIndex = 6;
            this.lblCalmoney.Text = "0";
            this.lblCalmoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCal
            // 
            this.btnCal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCal.BackColor = System.Drawing.Color.Black;
            this.btnCal.FlatAppearance.BorderSize = 0;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCal.ForeColor = System.Drawing.Color.White;
            this.btnCal.Location = new System.Drawing.Point(642, 316);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(58, 51);
            this.btnCal.TabIndex = 7;
            this.btnCal.Text = "계산  하기";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblbwon1
            // 
            this.lblbwon1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbwon1.AutoSize = true;
            this.lblbwon1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblbwon1.Location = new System.Drawing.Point(677, 249);
            this.lblbwon1.Name = "lblbwon1";
            this.lblbwon1.Size = new System.Drawing.Size(26, 21);
            this.lblbwon1.TabIndex = 8;
            this.lblbwon1.Text = "원";
            // 
            // lblwon2
            // 
            this.lblwon2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblwon2.AutoSize = true;
            this.lblwon2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblwon2.Location = new System.Drawing.Point(677, 282);
            this.lblwon2.Name = "lblwon2";
            this.lblwon2.Size = new System.Drawing.Size(26, 21);
            this.lblwon2.TabIndex = 9;
            this.lblwon2.Text = "원";
            // 
            // lblsub
            // 
            this.lblsub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsub.AutoSize = true;
            this.lblsub.Location = new System.Drawing.Point(219, 348);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(38, 15);
            this.lblsub.TabIndex = 10;
            this.lblsub.Text = "빼기1";
            // 
            // lblsub2
            // 
            this.lblsub2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsub2.AutoSize = true;
            this.lblsub2.Location = new System.Drawing.Point(263, 348);
            this.lblsub2.Name = "lblsub2";
            this.lblsub2.Size = new System.Drawing.Size(38, 15);
            this.lblsub2.TabIndex = 11;
            this.lblsub2.Text = "빼기2";
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Location = new System.Drawing.Point(56, 348);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(41, 15);
            this.lbladmin.TabIndex = 12;
            this.lbladmin.Text = "admin";
            // 
            // lbladminmoney
            // 
            this.lbladminmoney.AutoSize = true;
            this.lbladminmoney.Location = new System.Drawing.Point(124, 348);
            this.lbladminmoney.Name = "lbladminmoney";
            this.lbladminmoney.Size = new System.Drawing.Size(78, 15);
            this.lbladminmoney.TabIndex = 13;
            this.lbladminmoney.Text = "adminmoney";
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.BackColor = System.Drawing.Color.Black;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(559, 316);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(58, 51);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "바구니 비우기";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnminus
            // 
            this.btnminus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminus.BackColor = System.Drawing.Color.Black;
            this.btnminus.FlatAppearance.BorderSize = 0;
            this.btnminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminus.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnminus.ForeColor = System.Drawing.Color.White;
            this.btnminus.Location = new System.Drawing.Point(479, 316);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(58, 51);
            this.btnminus.TabIndex = 15;
            this.btnminus.Text = "상품  빼기";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // lblminus
            // 
            this.lblminus.AutoSize = true;
            this.lblminus.Location = new System.Drawing.Point(57, 321);
            this.lblminus.Name = "lblminus";
            this.lblminus.Size = new System.Drawing.Size(55, 15);
            this.lblminus.TabIndex = 16;
            this.lblminus.Text = "상품삭제";
            // 
            // lblitemcount
            // 
            this.lblitemcount.AutoSize = true;
            this.lblitemcount.Location = new System.Drawing.Point(123, 317);
            this.lblitemcount.Name = "lblitemcount";
            this.lblitemcount.Size = new System.Drawing.Size(55, 15);
            this.lblitemcount.TabIndex = 17;
            this.lblitemcount.Text = "전체수량";
            // 
            // lblitemcartcount
            // 
            this.lblitemcartcount.AutoSize = true;
            this.lblitemcartcount.Location = new System.Drawing.Point(184, 317);
            this.lblitemcartcount.Name = "lblitemcartcount";
            this.lblitemcartcount.Size = new System.Drawing.Size(55, 15);
            this.lblitemcartcount.TabIndex = 18;
            this.lblitemcartcount.Text = "담은수량";
            // 
            // GuestCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 372);
            this.Controls.Add(this.lblitemcartcount);
            this.Controls.Add(this.lblitemcount);
            this.Controls.Add(this.lblminus);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lbladminmoney);
            this.Controls.Add(this.lbladmin);
            this.Controls.Add(this.lblsub2);
            this.Controls.Add(this.lblsub);
            this.Controls.Add(this.lblwon2);
            this.Controls.Add(this.lblbwon1);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblCalmoney);
            this.Controls.Add(this.lblcal);
            this.Controls.Add(this.lblUsermoney);
            this.Controls.Add(this.lblmoney);
            this.Controls.Add(this.dgCart);
            this.Name = "GuestCartForm";
            this.Text = "장바구니";
            this.Load += new System.EventHandler(this.GuestCartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgCart;
        private Label lblmoney;
        private Label lblUsermoney;
        private Label lblcal;
        private Label lblCalmoney;
        private Button btnCal;
        private Label lblbwon1;
        private Label lblwon2;
        private Label lblsub;
        private Label lblsub2;
        private Label lbladmin;
        private Label lbladminmoney;
        private Button btnclear;
        private Button btnminus;
        private Label lblminus;
        private Label lblitemcount;
        private Label lblitemcartcount;
    }
}