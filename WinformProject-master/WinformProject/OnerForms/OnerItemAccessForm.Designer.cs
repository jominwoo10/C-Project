namespace WinformProject.OnerForms
{
    partial class OnerItemAccessForm
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.comsubject = new System.Windows.Forms.ComboBox();
            this.picitemimage = new System.Windows.Forms.PictureBox();
            this.lblitemcontent = new System.Windows.Forms.Label();
            this.lblpricesend = new System.Windows.Forms.Label();
            this.lblitemname = new System.Windows.Forms.Label();
            this.lblcounttest = new System.Windows.Forms.Label();
            this.lblpricetest = new System.Windows.Forms.Label();
            this.lblitemcode = new System.Windows.Forms.Label();
            this.btnAddcount = new System.Windows.Forms.Button();
            this.btnDelitem = new System.Windows.Forms.Button();
            this.lbldefaultname = new System.Windows.Forms.Label();
            this.lblsalename = new System.Windows.Forms.Label();
            this.lbldefault = new System.Windows.Forms.Label();
            this.lblsale = new System.Windows.Forms.Label();
            this.lblpricecosttest = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadditem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgShopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picitemimage)).BeginInit();
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
            this.dgShopping.Location = new System.Drawing.Point(12, 42);
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
            this.dgShopping.Size = new System.Drawing.Size(505, 304);
            this.dgShopping.TabIndex = 2;
            this.dgShopping.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShopping_CellClick);
            this.dgShopping.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgShopping_CellFormatting);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Image = global::WinformProject.Properties.Resources.search2;
            this.btnsearch.Location = new System.Drawing.Point(490, 13);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(30, 20);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
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
            this.comsubject.Location = new System.Drawing.Point(369, 12);
            this.comsubject.Name = "comsubject";
            this.comsubject.Size = new System.Drawing.Size(121, 23);
            this.comsubject.TabIndex = 6;
            // 
            // picitemimage
            // 
            this.picitemimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picitemimage.Location = new System.Drawing.Point(557, 24);
            this.picitemimage.Name = "picitemimage";
            this.picitemimage.Size = new System.Drawing.Size(139, 129);
            this.picitemimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picitemimage.TabIndex = 8;
            this.picitemimage.TabStop = false;
            // 
            // lblitemcontent
            // 
            this.lblitemcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblitemcontent.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblitemcontent.Location = new System.Drawing.Point(530, 168);
            this.lblitemcontent.Name = "lblitemcontent";
            this.lblitemcontent.Size = new System.Drawing.Size(200, 87);
            this.lblitemcontent.TabIndex = 12;
            this.lblitemcontent.Text = "상품설명";
            // 
            // lblpricesend
            // 
            this.lblpricesend.AutoSize = true;
            this.lblpricesend.Location = new System.Drawing.Point(315, 336);
            this.lblpricesend.Name = "lblpricesend";
            this.lblpricesend.Size = new System.Drawing.Size(55, 15);
            this.lblpricesend.TabIndex = 21;
            this.lblpricesend.Text = "가격저장";
            // 
            // lblitemname
            // 
            this.lblitemname.AutoSize = true;
            this.lblitemname.Location = new System.Drawing.Point(246, 335);
            this.lblitemname.Name = "lblitemname";
            this.lblitemname.Size = new System.Drawing.Size(67, 15);
            this.lblitemname.TabIndex = 20;
            this.lblitemname.Text = "상품명저장";
            // 
            // lblcounttest
            // 
            this.lblcounttest.AutoSize = true;
            this.lblcounttest.Location = new System.Drawing.Point(190, 335);
            this.lblcounttest.Name = "lblcounttest";
            this.lblcounttest.Size = new System.Drawing.Size(55, 15);
            this.lblcounttest.TabIndex = 19;
            this.lblcounttest.Text = "수량저장";
            // 
            // lblpricetest
            // 
            this.lblpricetest.AutoSize = true;
            this.lblpricetest.Location = new System.Drawing.Point(105, 335);
            this.lblpricetest.Name = "lblpricetest";
            this.lblpricetest.Size = new System.Drawing.Size(79, 15);
            this.lblpricetest.TabIndex = 18;
            this.lblpricetest.Text = "상품가격저장";
            // 
            // lblitemcode
            // 
            this.lblitemcode.AutoSize = true;
            this.lblitemcode.Location = new System.Drawing.Point(52, 335);
            this.lblitemcode.Name = "lblitemcode";
            this.lblitemcode.Size = new System.Drawing.Size(55, 15);
            this.lblitemcode.TabIndex = 17;
            this.lblitemcode.Text = "클릭여부";
            // 
            // btnAddcount
            // 
            this.btnAddcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddcount.BackColor = System.Drawing.Color.Black;
            this.btnAddcount.FlatAppearance.BorderSize = 0;
            this.btnAddcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddcount.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddcount.ForeColor = System.Drawing.Color.White;
            this.btnAddcount.Location = new System.Drawing.Point(530, 313);
            this.btnAddcount.Name = "btnAddcount";
            this.btnAddcount.Size = new System.Drawing.Size(47, 47);
            this.btnAddcount.TabIndex = 23;
            this.btnAddcount.Text = "재고추가";
            this.btnAddcount.UseVisualStyleBackColor = false;
            this.btnAddcount.Click += new System.EventHandler(this.btnAddcount_Click);
            // 
            // btnDelitem
            // 
            this.btnDelitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelitem.BackColor = System.Drawing.Color.Black;
            this.btnDelitem.FlatAppearance.BorderSize = 0;
            this.btnDelitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelitem.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelitem.ForeColor = System.Drawing.Color.White;
            this.btnDelitem.Location = new System.Drawing.Point(678, 313);
            this.btnDelitem.Name = "btnDelitem";
            this.btnDelitem.Size = new System.Drawing.Size(52, 47);
            this.btnDelitem.TabIndex = 24;
            this.btnDelitem.Text = "상품삭제";
            this.btnDelitem.UseVisualStyleBackColor = false;
            this.btnDelitem.Click += new System.EventHandler(this.btnDelitem_Click);
            // 
            // lbldefaultname
            // 
            this.lbldefaultname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldefaultname.AutoSize = true;
            this.lbldefaultname.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldefaultname.Location = new System.Drawing.Point(561, 254);
            this.lbldefaultname.Name = "lbldefaultname";
            this.lbldefaultname.Size = new System.Drawing.Size(66, 15);
            this.lbldefaultname.TabIndex = 25;
            this.lbldefaultname.Text = "상품 원가 :";
            // 
            // lblsalename
            // 
            this.lblsalename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsalename.AutoSize = true;
            this.lblsalename.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsalename.Location = new System.Drawing.Point(561, 282);
            this.lblsalename.Name = "lblsalename";
            this.lblsalename.Size = new System.Drawing.Size(70, 15);
            this.lblsalename.TabIndex = 26;
            this.lblsalename.Text = "판매 가격 : ";
            // 
            // lbldefault
            // 
            this.lbldefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldefault.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldefault.Location = new System.Drawing.Point(605, 254);
            this.lbldefault.Name = "lbldefault";
            this.lbldefault.Size = new System.Drawing.Size(89, 15);
            this.lbldefault.TabIndex = 27;
            this.lbldefault.Text = "10,000원";
            this.lbldefault.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblsale
            // 
            this.lblsale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsale.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsale.Location = new System.Drawing.Point(605, 282);
            this.lblsale.Name = "lblsale";
            this.lblsale.Size = new System.Drawing.Size(89, 15);
            this.lblsale.TabIndex = 27;
            this.lblsale.Text = "13,000원";
            this.lblsale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblpricecosttest
            // 
            this.lblpricecosttest.AutoSize = true;
            this.lblpricecosttest.Location = new System.Drawing.Point(369, 335);
            this.lblpricecosttest.Name = "lblpricecosttest";
            this.lblpricecosttest.Size = new System.Drawing.Size(55, 15);
            this.lblpricecosttest.TabIndex = 28;
            this.lblpricecosttest.Text = "원가저장";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(692, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "원";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(692, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "원";
            // 
            // btnadditem
            // 
            this.btnadditem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadditem.BackColor = System.Drawing.Color.Black;
            this.btnadditem.FlatAppearance.BorderSize = 0;
            this.btnadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadditem.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnadditem.ForeColor = System.Drawing.Color.White;
            this.btnadditem.Location = new System.Drawing.Point(605, 313);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(52, 47);
            this.btnadditem.TabIndex = 45;
            this.btnadditem.Text = "상품추가";
            this.btnadditem.UseVisualStyleBackColor = false;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // OnerItemAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 372);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblpricecosttest);
            this.Controls.Add(this.lblsalename);
            this.Controls.Add(this.lbldefaultname);
            this.Controls.Add(this.lblsale);
            this.Controls.Add(this.lbldefault);
            this.Controls.Add(this.btnDelitem);
            this.Controls.Add(this.btnAddcount);
            this.Controls.Add(this.lblpricesend);
            this.Controls.Add(this.lblitemname);
            this.Controls.Add(this.lblcounttest);
            this.Controls.Add(this.lblpricetest);
            this.Controls.Add(this.lblitemcode);
            this.Controls.Add(this.lblitemcontent);
            this.Controls.Add(this.picitemimage);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.comsubject);
            this.Controls.Add(this.dgShopping);
            this.Controls.Add(this.label5);
            this.Name = "OnerItemAccessForm";
            this.Text = "상품관리";
            this.Load += new System.EventHandler(this.OnerItemAccessForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picitemimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgShopping;
        private Button btnsearch;
        private ComboBox comsubject;
        private PictureBox picitemimage;
        private Label lblitemcontent;
        private Label lblpricesend;
        private Label lblitemname;
        private Label lblcounttest;
        private Label lblpricetest;
        private Label lblitemcode;
        private Button btnAddcount;
        private Button btnDelitem;
        private Label lbldefaultname;
        private Label lblsalename;
        private Label lbldefault;
        private Label lblsale;
        private Label lblpricecosttest;
        private Label label5;
        private Label label1;
        private Button btnadditem;
    }
}