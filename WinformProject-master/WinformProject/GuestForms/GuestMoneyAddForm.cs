using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinformProject.GuestForms
{
    public partial class GuestMoneyAddForm : Form
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
        string user; //login폼에서 로그인 시 로그인 되어있는 userid를 받기위한 변수

        public GuestMoneyAddForm(string userid)
        {
            InitializeComponent();
            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);
            user = userid; //uesr변수에 로그인된 userid값 저장

            //폼 테두리 제거
            this.FormBorderStyle = FormBorderStyle.None;
        }

        //마우스 왼쪽 버튼 클릭 시 현재 좌표 저장
        private void panelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        //유저 보유금액 가져오기
        public void LoadUserMoney()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //uesr 테이블 보유금액을 현재 접속한 id를 조건으로 조회
                    string selectQuery = string.Format("SELECT money from user where id = '{0}';", user);

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 Selectcommand 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    //Select조회 해서 얻은 유저 보유머니를 int형 money변수에 저장
                    int money = (int)Selectcommand.ExecuteScalar();

                    //천단위 콤마를 찍기전 데이터를 label에 임시 저장
                    label5.Text = Convert.ToString(money);

                    //유저 보유 돈에 천단위 콤마를 넣기위한 string.format
                    string usertomoney = string.Format("{0}", money.ToString("#,##0"));

                    //유저 보유 금액에 string.format한 usertomoney값 입력
                    lblusermoney.Text = usertomoney.ToString();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //로그인 된 유저 ID 가져오기
        public void LoadUserName()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //uesr 테이블 이름을 현재 접속한 id를 조건으로 조회
                    string selectQuery = string.Format("SELECT name from user where id = '{0}';", user);

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 Selectcommand 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    //Select조회 해서 얻은 유저 보유머니를 int형 money변수에 저장
                    string username = (string)Selectcommand.ExecuteScalar();

                    //username label에 username값 넣기
                    lblusername.Text = username + " 님";
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //닫기버튼 클릭시 폼 닫기
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //마우스를 움직일 시 좌표를 계산하여 폼의 좌표로 지정
        private void panelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new Point(this.Left - (point.X - e.X), this.Top - (point.Y - e.Y));
            }
        }

        //폼 로드시
        private void GuestMoneyAddForm_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;

            //유저 보유금액 불러오기
            LoadUserMoney();
            //유저 이름 불러오기
            LoadUserName();
        }

        //콤보박스 선택시 처리
        public void SelectedCombobox()
        {
            //콤보박스에서 5천원을 선택 했다면
            if(comaddmoney.SelectedIndex == 0)
            {
                label4.Text = "5000";
            }
            //콤보박스에서 만원을 선택 했다면
            else if (comaddmoney.SelectedIndex == 1)
            {
                label4.Text = "10000";
            }
            //콤보박스에서 삼만원을 선택 했다면
            else if (comaddmoney.SelectedIndex == 2)
            {
                label4.Text = "30000";
            }
            //콤보박스에서 오만원을 선택 했다면
            else if (comaddmoney.SelectedIndex == 3)
            {
                label4.Text = "50000";
            }
            ////콤보박스에서 십만원을 선택 했다면
            else
            {
                label4.Text = "100000";
            }
        }

        //콤보박스에서 아이템 선택시 마다 처리
        private void comaddmoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCombobox();
        }

        //충전하기 버튼을 클릭 시
        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            //현재 유저 보유금액 저장
            int usermoney = Convert.ToInt32(label5.Text);
            //추가할 금액 저장
            int addmoney = Convert.ToInt32(label4.Text);
            //보유금액 + 추가할 금액
            int addtotalmoney = usermoney + addmoney;
            //update를 위한 string형으로 변환
            string sendmoney = Convert.ToString(addtotalmoney);

            //메시지박스로 띄워주기 위한 변수
            string addmoneytext = string.Format("{0}", addmoney.ToString("#,##0"));
            string sendmoneytext = string.Format("{0}", addtotalmoney.ToString("#,##0"));

            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //user 테이블에 money 데이터를 현재 접속한 id를 기준으로 갱신
                    string updateQuery = string.Format("UPDATE user set money = '{0}' where id = '{1}';", sendmoney, user);

                    //MYSQL에 updatecommand 전송, mysql로 연결 시도 정보들을 Updatecommand 변수에 저장
                    MySqlCommand Updatecommand = new MySqlCommand(updateQuery, mysql);

                    MySqlDataReader myReader;
                    myReader = Updatecommand.ExecuteReader();

                    MessageBox.Show(addmoneytext + "원을 충전하여 보유 금액은 " + sendmoneytext + "원 입니다.");

                    while (myReader.Read())
                    {
                    }
                    //업데이트 후 업데이트된 유저 보유금액을 불러오기
                    LoadUserMoney();

                    mysql.Close();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
