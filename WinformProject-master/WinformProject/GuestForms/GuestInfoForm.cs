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
using WinformProject.GuestForms;

namespace WinformProject.Forms
{
    public partial class GuestInfoForm : Form
    {
        //DB Connect를 위한 정보
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "projectdb"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connection = "";
        string user; //login폼에서 로그인 시 로그인 되어있는 userid를 받기위한 변수

        public GuestInfoForm(string userid)
        {
            InitializeComponent();
            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);
            user = userid; //uesr변수에 로그인된 userid값 저장
        }

        private void GuestinfoForm_Load(object sender, EventArgs e)
        {
            LoadUserName();
            LoadUserID();
            LoadUserMoney();
        }

        //유저id 가져오기
        public void LoadUserID()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //uesr 테이블 id를 현재 접속한 id를 조건으로 조회
                    string selectQuery = string.Format("SELECT id from user where id = '{0}';", user);

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 Selectcommand 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    //Select조회 해서 얻은 유저 보유머니를 int형 money변수에 저장
                    string userid = (string)Selectcommand.ExecuteScalar();

                    //userid label에 userid값 넣기
                    lbluserid.Text = userid;
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //유저 이름 가져오기
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
                    lblusername.Text = username;
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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

        private void btnmoneyadd_Click(object sender, EventArgs e)
        {
            GuestMoneyAddForm guestMoneyAddForm = new GuestMoneyAddForm(user);
            guestMoneyAddForm.ShowDialog();
            LoadUserMoney();
        }
    }
}
