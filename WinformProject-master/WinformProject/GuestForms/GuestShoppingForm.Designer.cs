namespace WinformProject.Forms
{
    partial class GuestShoppingForm
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
            this.dgShopping = new System.Windows.Forms.DataGridView();
            this.picitemimage = new System.Windows.Forms.PictureBox();
            this.lblitemcode = new System.Windows.Forms.Label();
            this.comsubject = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblpricename = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.numcount = new System.Windows.Forms.NumericUpDown();
            this.lblitemcontent = new System.Windows.Forms.Label();
            this.btnaddcart = new System.Windows.Forms.Button();
            this.lblpricetest = new System.Windows.Forms.Label();
            this.lblcounttest = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lblpricesend = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblitemcount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgShopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picitemimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgShopping
            // 
            this.dgShopping.AllowUserToAddRows = false;
            this.dgShopping.AllowUserToDeleteRows = false;
            this.dgShopping.AllowUserToOrderColumns = true;
            this.dgShopping.AllowUserToResizeColumns = false;
            this.dgShopping.AllowUserToResizeRows = false;
            this.dgShopping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgShopping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgShopping.BackgroundColor = System.Drawing.Color.White;
            this.dgShopping.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgShopping.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgShopping.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgShopping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgShopping.ColumnHeadersHeight = 40;
            this.dgShopping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgShopping.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgShopping.EnableHeadersVisualStyles = false;
            this.dgShopping.Location = new System.Drawing.Point(24, 42);
            this.dgShopping.MultiSelect = false;
            this.dgShopping.Name = "dgShopping";
            this.dgShopping.ReadOnly = true;
            this.dgShopping.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgShopping.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgShopping.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgShopping.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgShopping.RowTemplate.Height = 25;
            this.dgShopping.Size = new System.Drawing.Size(467, 304);
            this.dgShopping.TabIndex = 1;
            this.dgShopping.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShopping_CellClick);
            this.dgShopping.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgShopping_CellFormatting);
            // 
            // picitemimage
            // 
            this.picitemimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picitemimage.Location = new System.Drawing.Point(556, 24);
            this.picitemimage.Name = "picitemimage";
            this.picitemimage.Size = new System.Drawing.Size(139, 129);
            this.picitemimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picitemimage.TabIndex = 2;
            this.picitemimage.TabStop = false;
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.Location = new System.Drawing.Point(25, 335);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(55, 15);
            this.lblitemcode.TabIndex = 3;
            this.lblitemcode.Text = "클릭여부";
            // 
            // comsubject
            // 
            this.comsubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comsubject.FormattingEnabled = true;
            this.comsubject.Items.AddRange(new object[] {
            "간편식사",
            "식품",
            "음료",
            "과자류",
            "생활용품"});
            this.comsubject.Location = new System.Drawing.Point(298, 10);
            this.comsubject.Name = "comsubject";
            this.comsubject.Size = new System.Drawing.Size(121, 23);
            this.comsubject.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Image = global::WinformProject.Properties.Resources.search2;
            this.btnsearch.Location = new System.Drawing.Point(419, 11);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(30, 20);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lblpricename
            // 
            this.lblpricename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpricename.AutoSize = true;
            this.lblpricename.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpricename.Location = new System.Drawing.Point(572, 278);
            this.lblpricename.Name = "lblpricename";
            this.lblpricename.Size = new System.Drawing.Size(47, 17);
            this.lblpricename.TabIndex = 6;
            this.lblpricename.Text = "가격 : ";
            this.lblpricename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblprice
            // 
            this.lblprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblprice.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblprice.Location = new System.Drawing.Point(593, 278);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(104, 17);
            this.lblprice.TabIndex = 7;
            this.lblprice.Text = "1,000,000원";
            this.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcount
            // 
            this.lblcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcount.Location = new System.Drawing.Point(572, 246);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(47, 17);
            this.lblcount.TabIndex = 8;
            this.lblcount.Text = "개수 : ";
            this.lblcount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numcount
            // 
            this.numcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numcount.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numcount.Location = new System.Drawing.Point(641, 244);
            this.numcount.Name = "numcount";
            this.numcount.Size = new System.Drawing.Size(51, 25);
            this.numcount.TabIndex = 10;
            this.numcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numcount.ValueChanged += new System.EventHandler(this.numcount_ValueChanged);
            // 
            // lblitemcontent
            // 
            this.lblitemcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblitemcontent.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblitemcontent.Location = new System.Drawing.Point(529, 163);
            this.lblitemcontent.Name = "lblitemcontent";
            this.lblitemcontent.Size = new System.Drawing.Size(194, 78);
            this.lblitemcontent.TabIndex = 11;
            this.lblitemcontent.Text = "상품설명";
            // 
            // btnaddcart
            // 
            this.btnaddcart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddcart.BackColor = System.Drawing.Color.Black;
            this.btnaddcart.FlatAppearance.BorderSize = 0;
            this.btnaddcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddcart.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnaddcart.ForeColor = System.Drawing.Color.White;
            this.btnaddcart.Location = new System.Drawing.Point(564, 323);
            this.btnaddcart.Name = "btnaddcart";
            this.btnaddcart.Size = new System.Drawing.Size(136, 37);
            this.btnaddcart.TabIndex = 12;
            this.btnaddcart.Text = "장바구니 담기";
            this.btnaddcart.UseVisualStyleBackColor = false;
            this.btnaddcart.Click += new System.EventHandler(this.btnaddcart_Click);
            // 
            // lblpricetest
            // 
            this.lblpricetest.AutoSize = true;
            this.lblpricetest.Location = new System.Drawing.Point(78, 335);
            this.lblpricetest.Name = "lblpricetest";
            this.lblpricetest.Size = new System.Drawing.Size(79, 15);
            this.lblpricetest.TabIndex = 13;
            this.lblpricetest.Text = "상품가격저장";
            // 
            // lblcounttest
            // 
            this.lblcounttest.AutoSize = true;
            this.lblcounttest.Location = new System.Drawing.Point(163, 335);
            this.lblcounttest.Name = "lblcounttest";
            this.lblcounttest.Size = new System.Drawing.Size(55, 15);
            this.lblcounttest.TabIndex = 14;
            this.lblcounttest.Text = "수량저장";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Location = new System.Drawing.Point(219, 335);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(67, 15);
            this.lblitemname.TabIndex = 15;
            this.lblitemname.Text = "상품명저장";
            // 
            // lblpricesend
            // 
            this.lblpricesend.AutoSize = true;
            this.lblpricesend.Location = new System.Drawing.Point(288, 336);
            this.lblpricesend.Name = "lblpricesend";
            this.lblpricesend.Size = new System.Drawing.Size(55, 15);
            this.lblpricesend.TabIndex = 16;
            this.lblpricesend.Text = "가격저장";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(693, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "원";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "num카운트개수";
            // 
            // lblitemcount
            // 
            this.lblitemcount.AutoSize = true;
            this.lblitemcount.Location = new System.Drawing.Point(29, 307);
            this.lblitemcount.Name = "lblitemcount";
            this.lblitemcount.Size = new System.Drawing.Size(79, 15);
            this.lblitemcount.TabIndex = 19;
            this.lblitemcount.Text = "상품수량조회";
            // 
            // GuestShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 372);
            this.Controls.Add(this.lblitemcount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpricename);
            this.Controls.Add(this.lblpricesend);
            this.Controls.Add(this.lblitemname);
            this.Controls.Add(this.lblcounttest);
            this.Controls.Add(this.lblpricetest);
            this.Controls.Add(this.btnaddcart);
            this.Controls.Add(this.lblitemcontent);
            this.Controls.Add(this.numcount);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.comsubject);
            this.Controls.Add(this.lblitemcode);
            this.Controls.Add(this.picitemimage);
            this.Controls.Add(this.dgShopping);
            this.Name = "GuestShoppingForm";
            this.Text = "쇼핑하기";
            this.Load += new System.EventHandler(this.GuestShoppingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picitemimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgShopping;
        private PictureBox picitemimage;
        private Label lblitemcode;
        private ComboBox comsubject;
        private Button btnsearch;
        private Label lblpricename;
        private Label lblprice;
        private Label lblcount;
        private NumericUpDown numcount;
        private Label lblitemcontent;
        private Button btnaddcart;
        private Label lblpricetest;
        private Label lblcounttest;
        private Label lblitemname;
        private Label lblpricesend;
        private Label label1;
        private Label label2;
        private Label lblitemcount;
    }
}