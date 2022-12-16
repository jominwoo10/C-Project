namespace WinformProject.OnerForms
{
    partial class OnerItemAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_loadimage = new System.Windows.Forms.Button();
            this.txt_imagepath = new System.Windows.Forms.TextBox();
            this.btnAdditem = new System.Windows.Forms.Button();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtitemcontent = new System.Windows.Forms.TextBox();
            this.combosubject = new System.Windows.Forms.ComboBox();
            this.txtitemprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(237, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "상품명";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "상품설명";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(222, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "상품분류";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(222, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "상품가격";
            // 
            // btn_loadimage
            // 
            this.btn_loadimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadimage.BackColor = System.Drawing.Color.Black;
            this.btn_loadimage.FlatAppearance.BorderSize = 0;
            this.btn_loadimage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadimage.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_loadimage.ForeColor = System.Drawing.Color.White;
            this.btn_loadimage.Location = new System.Drawing.Point(534, 26);
            this.btn_loadimage.Name = "btn_loadimage";
            this.btn_loadimage.Size = new System.Drawing.Size(131, 63);
            this.btn_loadimage.TabIndex = 5;
            this.btn_loadimage.Text = "이미지 불러오기";
            this.btn_loadimage.UseVisualStyleBackColor = false;
            this.btn_loadimage.Click += new System.EventHandler(this.btn_loadimage_Click);
            // 
            // txt_imagepath
            // 
            this.txt_imagepath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_imagepath.Location = new System.Drawing.Point(237, 150);
            this.txt_imagepath.Name = "txt_imagepath";
            this.txt_imagepath.Size = new System.Drawing.Size(225, 23);
            this.txt_imagepath.TabIndex = 6;
            // 
            // btnAdditem
            // 
            this.btnAdditem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdditem.BackColor = System.Drawing.Color.Black;
            this.btnAdditem.FlatAppearance.BorderSize = 0;
            this.btnAdditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdditem.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdditem.ForeColor = System.Drawing.Color.White;
            this.btnAdditem.Location = new System.Drawing.Point(534, 264);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(131, 63);
            this.btnAdditem.TabIndex = 7;
            this.btnAdditem.Text = "상품 추가";
            this.btnAdditem.UseVisualStyleBackColor = false;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // txtitemname
            // 
            this.txtitemname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtitemname.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtitemname.Location = new System.Drawing.Point(310, 189);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(146, 25);
            this.txtitemname.TabIndex = 8;
            // 
            // txtitemcontent
            // 
            this.txtitemcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtitemcontent.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtitemcontent.Location = new System.Drawing.Point(310, 224);
            this.txtitemcontent.Name = "txtitemcontent";
            this.txtitemcontent.Size = new System.Drawing.Size(146, 25);
            this.txtitemcontent.TabIndex = 9;
            // 
            // combosubject
            // 
            this.combosubject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combosubject.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.combosubject.FormattingEnabled = true;
            this.combosubject.Items.AddRange(new object[] {
            "간편식사",
            "음료",
            "생활용품",
            "식품",
            "과자류"});
            this.combosubject.Location = new System.Drawing.Point(310, 261);
            this.combosubject.Name = "combosubject";
            this.combosubject.Size = new System.Drawing.Size(146, 25);
            this.combosubject.TabIndex = 10;
            // 
            // txtitemprice
            // 
            this.txtitemprice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtitemprice.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtitemprice.Location = new System.Drawing.Point(310, 300);
            this.txtitemprice.Name = "txtitemprice";
            this.txtitemprice.PlaceholderText = "콤마없이 입력";
            this.txtitemprice.Size = new System.Drawing.Size(146, 25);
            this.txtitemprice.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "상품분류";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "원가계산";
            // 
            // OnerItemAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 372);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtitemprice);
            this.Controls.Add(this.combosubject);
            this.Controls.Add(this.txtitemcontent);
            this.Controls.Add(this.txtitemname);
            this.Controls.Add(this.btnAdditem);
            this.Controls.Add(this.txt_imagepath);
            this.Controls.Add(this.btn_loadimage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OnerItemAddForm";
            this.Text = "상품 추가";
            this.Load += new System.EventHandler(this.OnerItemAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_loadimage;
        private TextBox txt_imagepath;
        private Button btnAdditem;
        private TextBox txtitemname;
        private TextBox txtitemcontent;
        private ComboBox combosubject;
        private TextBox txtitemprice;
        private Label label5;
        private Label label6;
    }
}