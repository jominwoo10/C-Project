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
            //폼 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None; // 이거를 쓰면 화면 테두리에 붙일시 속성 적용 x

            //밑에 3개를 쓰면 화면 테두리 속성 사용 가능한데 타이틀 바 위에 흰색 여백이 생김
            //this.Text = String.Empty;
            //this.ControlBox = false;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //마우스로 타이틀 바 잡고 이동하기 위해 씀
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //색상 랜덤 출력

        //버튼 활성화(눌림)
        private void ActivateButton(object btnSender) 
        {
            if(btnSender != null)
            {
                if(cartButton != (Button)btnSender)
                {
                    DisableButton();
                    cartButton = (Button)btnSender;
                    cartButton.ForeColor = Color.White;
                    cartButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        //버튼 비활성화(안눌림)  / FlowLayoutPanel은 .Controls속성이 안먹혀 하나하나 다 설정해 줬음
        private void DisableButton() 
        {
            foreach(Control previousBtn in panel2.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DimGray;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
            foreach (Control previousBtn in panel3.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DimGray;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
            foreach (Control previousBtn in panel4.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DimGray;
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        
        //서브폼 오픈 
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

        // 서브 폼 띄운 후 닫기 버튼을 눌렀을 때
        private void Reset() 
        {
            DisableButton(); // 버튼 비활성화
            lblTitle.Text = "HOME"; //타이틀 바 HOME으로 다시 적용
            cartButton = null;
            btnCloseChildForm.Visible = false;
        }

        // 상단 우측 버튼 중 마지막 버튼 창 닫기
        private void btnClose_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        // 상단 우측 버튼 중 중간 버튼 창 크기 최대, 원상태
        private void btnMaximize_Click(object sender, EventArgs e) 
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // 상단 우측 버튼 중 첫번째 버튼 창 숨기기
        private void btnMinimize_Click(object sender, EventArgs e) 
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //서브 폼 활성화 시 X버튼 클릭 
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (actviteForm != null)
                actviteForm.Close();
            Reset();
        }

        //내정보 버튼 클릭 시 처리 
        private void btnMyinfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GuestInfoForm(user), sender);
        }

        //쇼핑하기 버튼 클릭 시 처리
        private void btnShopping_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GuestShoppingForm(), sender);
        }

        //장바구니 버튼 클릭 시  처리
        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GuestCartForm(user), sender);
        }

        //사이드 바 버튼 클릭시 실행 
        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        // 마우스로 타이틀바를 잡고 이동시킬 수 있게 
        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle,0x112, 0xf012, 0);
        }

        //마우스 왼쪽 버튼 클릭 시 현재 좌표 저장
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        //마우스를 움직일 시 좌표를 계산하여 폼의 좌표로 지정
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }
        
        //Control 깜빡이 방지
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        //사이드바 버튼 클릭
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

        // lblDate에 현재날짜시간 표시, F:자세한 전체 날짜/시간
        private void DateTimer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("F");
        }

        //현재시간 출력을 위한 타이머
        private void GuestMainForm_Load(object sender, EventArgs e)
        {
            lblusername.Text = user;
            DateTimer.Start();
        }
    }
}