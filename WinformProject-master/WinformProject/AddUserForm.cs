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

namespace WinformProject
{
    public partial class AddUserForm : Form
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

        public AddUserForm()
        {
            InitializeComponent();

            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);

            //폼 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //마우스를 움직일 시 좌표를 계산하여 폼의 좌표로 지정
        private void panelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        //마우스 왼쪽 버튼 클릭 시 현재 좌표 저장
        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        //현재 폼 닫기
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //회원가입 시 DB에 저장
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //user 테이블에 name,id,password 데이터 삽입을 위한 SQL문
                    string insertQuery = string.Format("INSERT INTO user(name,id,password) VALUES ('{0}','{1}','{2}');", txtName.Text, txtId.Text, txtPw.Text);

                    //MYSQL에 insertQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);

                    //회원가입 비 정상 시 
                    if (command.ExecuteNonQuery() != 1)
                    { 
                        MessageBox.Show("회원가입 실패. DB연결 확인 바람");
                    }
                    //정상 회원가입 시
                    else
                    {
                        MessageBox.Show(txtName.Text + "님 회원가입 완료 !");
                        //SQL연결 끊기
                        mysql.Close();
                        //로그인 폼으로 돌아가기 위한 현재 폼 닫기
                        this.Close();
                    }
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //비밀번호 확인 클릭시 보이게 설정
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

        //현재 DB연결 확인용
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection mysql = new MySqlConnection(_connection))
            {
                //db연결 잘 되있는지 확인
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
            txtPw.UseSystemPasswordChar = true;
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
