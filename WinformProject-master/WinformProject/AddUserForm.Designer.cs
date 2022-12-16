namespace WinformProject
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblPw = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.checkPw = new System.Windows.Forms.CheckBox();
            this.lbldb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(258, 7);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(20, 20);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 13;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.btnclose);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(284, 33);
            this.panelLogin.TabIndex = 14;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            this.panelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseMove);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DimGray;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(93, 248);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(94, 35);
            this.btnAddUser.TabIndex = 19;
            this.btnAddUser.Text = "회원가입";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblPw
            // 
            this.lblPw.AutoSize = true;
            this.lblPw.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPw.ForeColor = System.Drawing.Color.White;
            this.lblPw.Location = new System.Drawing.Point(27, 172);
            this.lblPw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPw.Name = "lblPw";
            this.lblPw.Size = new System.Drawing.Size(33, 20);
            this.lblPw.TabIndex = 18;
            this.lblPw.Text = "PW";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(28, 114);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 20);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID";
            // 
            // txtPw
            // 
            this.txtPw.BackColor = System.Drawing.Color.Gray;
            this.txtPw.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPw.ForeColor = System.Drawing.Color.White;
            this.txtPw.Location = new System.Drawing.Point(31, 194);
            this.txtPw.Margin = new System.Windows.Forms.Padding(2);
            this.txtPw.Name = "txtPw";
            this.txtPw.PlaceholderText = "PassWord";
            this.txtPw.Size = new System.Drawing.Size(215, 27);
            this.txtPw.TabIndex = 16;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Gray;
            this.txtId.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(31, 136);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.PlaceholderText = "Id";
            this.txtId.Size = new System.Drawing.Size(215, 27);
            this.txtId.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(28, 55);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gray;
            this.txtName.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(31, 77);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Name";
            this.txtName.Size = new System.Drawing.Size(215, 27);
            this.txtName.TabIndex = 20;
            // 
            // checkPw
            // 
            this.checkPw.AutoSize = true;
            this.checkPw.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkPw.ForeColor = System.Drawing.Color.White;
            this.checkPw.Location = new System.Drawing.Point(137, 222);
            this.checkPw.Name = "checkPw";
            this.checkPw.Size = new System.Drawing.Size(110, 19);
            this.checkPw.TabIndex = 22;
            this.checkPw.Text = "Show Password";
            this.checkPw.UseVisualStyleBackColor = true;
            this.checkPw.CheckedChanged += new System.EventHandler(this.checkPw_CheckedChanged);
            // 
            // lbldb
            // 
            this.lbldb.AutoSize = true;
            this.lbldb.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldb.ForeColor = System.Drawing.Color.White;
            this.lbldb.Location = new System.Drawing.Point(202, 296);
            this.lbldb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldb.Name = "lbldb";
            this.lbldb.Size = new System.Drawing.Size(22, 13);
            this.lbldb.TabIndex = 23;
            this.lbldb.Text = "DB";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.lbldb);
            this.Controls.Add(this.checkPw);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblPw);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panelLogin);
            this.Name = "AddUserForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox btnclose;
        private Panel panelLogin;
        private Button btnAddUser;
        private Label lblPw;
        private Label lblId;
        private TextBox txtPw;
        private TextBox txtId;
        private Label lblName;
        private TextBox txtName;
        private CheckBox checkPw;
        private Label lbldb;
    }
}