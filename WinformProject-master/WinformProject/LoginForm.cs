using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinformProject.Forms;
using WinformProject.OnerForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinformProject
{
    public partial class LoginForm : Form
    {
        //마우스로 폼 이동을 위한 포인트 변수
        private Point point = new Point();

        //DB Connect를 위한 정보
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "projectdb"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connection = "";
        public LoginForm()
        {
            InitializeComponent();

            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);

            //폼 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //로그인 버튼 클릭 시 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //로그인 상태 변수, 비로그인 상태는 0, 사장이 로그인 성공시 1, 손님이 로그인 성공 시 2
                    int login_status = 0;
                    //txtid의 텍스트 값 저장 변수
                    string loginid = txtId.Text;
                    //txtpw의 텍스트 값 저장 변수
                    string loginpw = txtPw.Text;

                    //user테이블에 id를 조건으로 조회
                    string selectQuery = string.Format("SELECT * FROM user WHERE id = '{0}';", loginid);

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    //입력값을 받기위한 Reader 입력값을 받은 걸 userAccount변수에 저장
                    MySqlDataReader userAccount = Selectcommand.ExecuteReader();

                    //userAccount가 Read 되고 있을 동안
                    while (userAccount.Read())
                    {
                        //loginid값이 user테이블에 id값과, loginpw값이 user테이블에 password값과 일치 한다면
                        if (loginid == (string)userAccount["id"] && loginpw == (string)userAccount["password"])
                        {
                            //사장 로그인 성공시 로그인 상태 변수를 1로 변경
                            if ((int)userAccount["index"] == 1)
                            {
                                login_status = 1;
                            }
                            //손님 로그인 성공시 로그인 상태 변수를 1로 변경
                            else if ((int)userAccount["index"] == 2)
                            {
                                login_status = 2;
                            }
                        }
                    }
                    mysql.Close();

                    //사장 로그인 성공 시 
                    if (login_status == 1)
                    {
                        MessageBox.Show("사장님 반갑습니다 !");
                        this.Visible = false;
                        OnerMainForm onerMainForm = new OnerMainForm(txtId.Text);
                        onerMainForm.ShowDialog();
                    }
                    //손님 로그인 성공 시
                    else if (login_status == 2)
                    {
                        MessageBox.Show(txtId.Text + " 손님 반갑습니다 !");
                        this.Visible = false;
                        GuestMainForm guestMainForm = new GuestMainForm(txtId.Text);
                        guestMainForm.ShowDialog();
                    }
                    //로그인 실패 시
                    else
                    {
                        MessageBox.Show("아이디 비밀번호를 확인해주세요.");
                    }
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        //폼 로드 시 
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //현재 DB연결 확인용
            using (MySqlConnection mysql = new MySqlConnection(_connection))
            {
                mysql.Open();
                if (mysql.State == ConnectionState.Open)
                {
                    lbldb.Text = "DB Connected";
                }
                else
                {
                    lbldb.Text = "DB DisConnected";
                }
            }

            //폼 로드 시 비밀번호 안보이게 설정
            txtPw.UseSystemPasswordChar = true;
        }

        //닫기버튼 클릭 시
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //마우스 왼쪽 버튼 클릭 시 현재 좌표 저장
        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        //마우스를 움직일 시 좌표를 계산하여 폼의 좌표로 지정
        private void panelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        //회원가입 버튼 클릭 시 회원가입 폼 띄우기
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        //비밀번호 보이게 체크 시 설정
        private void checkPw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPw.Checked == true)
            {
                txtPw.UseSystemPasswordChar = false;
            }
            else
            {
                txtPw.UseSystemPasswordChar = true;
            }
        }

        //폼에서 엔터키 눌렸을때 로그인 버튼 클릭 처리
        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        //비밀번호 입력 칸에서 엔터키 눌렸을때 로그인 버튼 클릭 처리
        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        //아이디 입력 칸에서 엔터키 눌렸을때 로그인 버튼 클릭 처리
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
