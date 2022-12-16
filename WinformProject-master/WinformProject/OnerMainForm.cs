using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformProject.OnerForms;

namespace WinformProject
{
    public partial class OnerMainForm : Form
    {
        private Button cartButton;
        private Form actviteForm;
        bool sidebarExpand;
        private Point point = new Point();
        string user;

        public OnerMainForm(string userid)
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            user = userid;
            //폼 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None; // 이거를 쓰면 화면 테두리에 붙일시 속성 적용 x
        }

        //버튼 활성화(눌림)
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (cartButton != (Button)btnSender)
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
            foreach (Control previousBtn in panel2.Controls)
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
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (actviteForm != null)
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

        //폼 로드 시
        private void OnerMainForm_Load(object sender, EventArgs e)
        {
            DateTimer.Start();
        }

        // 상단 우측 버튼 중 첫번째 버튼 창 숨기기
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // 상단 우측 버튼 중 중간 버튼 창 크기 최대, 원상태
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // 상단 우측 버튼 중 마지막 버튼 창 닫기
        private void btnClo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //서브 폼 활성화 시 X버튼 클릭
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (actviteForm != null)
                actviteForm.Close();
            Reset();
        }

        //내 정보 버튼 클릭 시 처리
        private void btnMyinfo_Click(object sender, EventArgs e)
        {
            OnerInfoForm onerInfoForm = new OnerInfoForm(user);
            OpenChildForm(onerInfoForm, sender);
        }

        //회원 관리 버튼 클릭 시 처리
        private void btnGuest_Click(object sender, EventArgs e)
        {
            OnerGuestAccessForm onerGuestAccessForm = new OnerGuestAccessForm(user);
            OpenChildForm(onerGuestAccessForm, sender);
        }

        //상품 관리 버튼 클릭 시 처리
        private void btnItem_Click(object sender, EventArgs e)
        {
            OnerItemAccessForm onerItemAccessForm = new OnerItemAccessForm(user);
            OpenChildForm(onerItemAccessForm, sender);
        }

        //사이드 바 버튼 클릭시 실행 
        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        //마우스를 움직일 시 좌표를 계산하여 폼의 좌표로 지정
        private void panelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        //마우스 왼쪽 버튼 클릭 시 현재 좌표 저장
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
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
    }
}
