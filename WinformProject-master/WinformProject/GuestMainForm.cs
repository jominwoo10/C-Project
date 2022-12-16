using Microsoft.VisualBasic.ApplicationServices;
using Org.BouncyCastle.Bcpg;
using System.Runtime.InteropServices;

namespace WinformProject
{
    public partial class GuestMainForm : Form
    {
        private Button cartButton;
        private Form actviteForm;
        bool sidebarExpand;
        private Point point = new Point();
        string user;

        public GuestMainForm(string userid)
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            user = userid;
            //�� �׵θ� ����
            this.FormBorderStyle = FormBorderStyle.None; // �̰Ÿ� ���� ȭ�� �׵θ��� ���Ͻ� �Ӽ� ���� x

            //�ؿ� 3���� ���� ȭ�� �׵θ� �Ӽ� ��� �����ѵ� Ÿ��Ʋ �� ���� ��� ������ ����
            //this.Text = String.Empty;
            //this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //���콺�� Ÿ��Ʋ �� ��� �̵��ϱ� ���� ��
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //���� ���� ���

        //��ư Ȱ��ȭ(����)
        private void ActivateButton(object btnSender) 
        {
            if(btnSender != null)
            {
                if(cartButton != (Button)btnSender)
                {
                    DisableButton();
                    cartButton = (Button)btnSender;
                    cartButton.ForeColor = Color.White;
                    cartButton.Font = new System.Drawing.Font("���� ���", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        //��ư ��Ȱ��ȭ(�ȴ���)  / FlowLayoutPanel�� .Controls�Ӽ��� �ȸ��� �ϳ��ϳ� �� ������ ����
        private void DisableButton() 
        {
            foreach(Control previousBtn in panel2.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DimGray;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("���� ���", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
            foreach (Control previousBtn in panel3.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DimGray;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("���� ���", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
            foreach (Control previousBtn in panel4.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DimGray;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("���� ���", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        
        //������ ���� 
        private void OpenChildForm(Form childForm,object btnSender) 
        {
            if(actviteForm!= null)
            {
                actviteForm.Close();
            }
            ActivateButton(btnSender);
            actviteForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        // ���� �� ��� �� �ݱ� ��ư�� ������ ��
        private void Reset() 
        {
            DisableButton(); // ��ư ��Ȱ��ȭ
            lblTitle.Text = "HOME"; //Ÿ��Ʋ �� HOME���� �ٽ� ����
            cartButton = null;
            btnCloseChildForm.Visible = false;
        }

        // ��� ���� ��ư �� ������ ��ư â �ݱ�
        private void btnClose_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        // ��� ���� ��ư �� �߰� ��ư â ũ�� �ִ�, ������
        private void btnMaximize_Click(object sender, EventArgs e) 
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // ��� ���� ��ư �� ù��° ��ư â �����
        private void btnMinimize_Click(object sender, EventArgs e) 
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //���� �� Ȱ��ȭ �� X��ư Ŭ�� 
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (actviteForm != null)
                actviteForm.Close();
            Reset();
        }

        //������ ��ư Ŭ�� �� ó�� 
        private void btnMyinfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GuestInfoForm(user), sender);
        }

        //�����ϱ� ��ư Ŭ�� �� ó��
        private void btnShopping_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GuestShoppingForm(), sender);
        }

        //��ٱ��� ��ư Ŭ�� ��  ó��
        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GuestCartForm(user), sender);
        }

        //���̵� �� ��ư Ŭ���� ���� 
        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        // ���콺�� Ÿ��Ʋ�ٸ� ��� �̵���ų �� �ְ� 
        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle,0x112, 0xf012, 0);
        }

        //���콺 ���� ��ư Ŭ�� �� ���� ��ǥ ����
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        //���콺�� ������ �� ��ǥ�� ����Ͽ� ���� ��ǥ�� ����
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }
        
        //Control ������ ����
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        //���̵�� ��ư Ŭ��
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        // lblDate�� ���糯¥�ð� ǥ��, F:�ڼ��� ��ü ��¥/�ð�
        private void DateTimer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("F");
        }

        //����ð� ����� ���� Ÿ�̸�
        private void GuestMainForm_Load(object sender, EventArgs e)
        {
            lblusername.Text = user;
            DateTimer.Start();
        }
    }
}