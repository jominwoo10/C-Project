using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinformProject.Forms
{
    public partial class GuestCartForm : Form
    {
        //DB Connect를 위한 정보
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "projectdb"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connection = ""; 
        string user; //login폼에서 로그인 시 로그인 되어있는 userid를 받기위한 변수
        int selectedRow; //datagridview에서 해당 셀 선택시 row값 저장 변수

        //로그인 폼에서 메인폼으로 넘겨준 userid값을 guestcartform으로 받기위한 매개변수
        public GuestCartForm(string userid)
        {
            InitializeComponent();
            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);
            user = userid; //uesr변수에 로그인된 userid값 저장
            
        }

        //폼 로드시 datagridview 불로오고 유저에 따른 보유 금액 가져오기
        private void GuestCartForm_Load(object sender, EventArgs e)
        {
            lblsub.Visible = false;
            lblsub2.Visible = false;
            lbladmin.Visible = false;
            lbladminmoney.Visible = false;
            lblminus.Visible = false;
            lblminus.Text = "";
            lblitemcartcount.Visible = false;
            lblitemcount.Visible= false;
            LoadData();
            LoadUserMoney();
            LoadAdminMoney();
        }

        //datagridview에 데이터 가져오기
        public void LoadData()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {

                    //SQL서버 연결
                    mysql.Open();

                    //usercart 테이블 데이터 조회
                    string selectQuery = string.Format("SELECT itemname,itemprice,itemcount,itemtotalprice from usercart;");

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = Selectcommand;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dgCart.DataSource = bSource;

                    sda.Update(dbdataset);

                    mysql.Close();

                    //칼럼헤더 이름 지정
                    dgCart.Columns[0].HeaderText = "상품명";
                    dgCart.Columns[1].HeaderText = "상품가격";
                    dgCart.Columns[2].HeaderText = "담은수량";
                    dgCart.Columns[3].HeaderText = "총 가격";

                    //datagridview에 총가격값 받아오는 변수
                    int totalprice;
                    //실제 가격 차감을 위한 변수
                    int to = 0;

                    //datagridview 행만큼 
                    for (int i = 0; i < dgCart.Rows.Count; i++)
                    {
                        //문자열로 된 상품가격을 받아 와 int형으로 변환
                        totalprice = Convert.ToInt32(dgCart.Rows[i].Cells[3].FormattedValue.ToString());
                        //총 가격을 구하기 위한 합계
                        to += totalprice;
                    }

                    //추 후 계산시 가격 차감을 위해 format전 데이터를 label에 가지고 있기
                    lblsub.Text = Convert.ToString(to);
                    //총 가격을 천단위 콤마를 넣기위한 string.format
                    string pricetotal = string.Format("{0}", to.ToString("#,##0"));
                    //총 가격 label에 tostring 출력 
                    lblCalmoney.Text = pricetotal.ToString();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //계산하기 버튼 실행 시 처리
        private void btnCal_Click(object sender, EventArgs e)
        {
            //계산시 필요한 변수
            int sub1 = 0;
            int sub2 = 0;
            int subtotal = 0;

            //상품 총 금액을 string형으로 되어있는 label값을 convert.toint 사용하여 int형으로 받아오기
            sub1 = Convert.ToInt32(lblsub.Text);
            //유저 보유 금액을 string형으로 되어있는 label값을 convert.toint 사용하여 int형으로 받아오기
            sub2 = Convert.ToInt32(lblsub2.Text);

            //보유 금액보다 상품 총 가격이 더 클시
            if(sub1 > sub2)
            {
                //상품 구입 불가
                MessageBox.Show("잔액이 부족합니다.");
            }
            //유저가 보유한 돈이 더 많을 시 
            else
            {
                //구입 완료
                MessageBox.Show("상품 계산이 완료되었습니다.");
                
                //상품가격만큼 사장 보유금액 증가를 위한 try catch
                try
                {
                    //DB연결하여 SQL사용하기 위함
                    using (MySqlConnection mysql = new MySqlConnection(_connection))
                    {
                        int adminmoney = Convert.ToInt32(lbladminmoney.Text);
                        int totaladminmoney;
                        
                        //사장 보유금액 + 상품가격
                        totaladminmoney = adminmoney + sub1;

                        //SQL서버 연결
                        mysql.Open();

                        //admin계정에 totaladminmoney금액을 갱신
                        string UpdateQuery = string.Format("UPDATE user set money = '{0}' where id = '{1}';", totaladminmoney, lbladmin.Text);

                        //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                        MySqlCommand updatecommand = new MySqlCommand(UpdateQuery, mysql);
                        MySqlDataReader myReader;

                        myReader = updatecommand.ExecuteReader();

                        while (myReader.Read())
                        {
                        }
                        mysql.Close();
                    }
                }
                //예외 발생 시 해당 정보를 메시지박스로 출력
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }

                //물품구입 후 user보유금액 차감 및 장바구니 비워주기
                try
                {
                    //DB연결하여 SQL사용하기 위함
                    using (MySqlConnection mysql = new MySqlConnection(_connection))
                    {
                        //유저보유금액 - 상품금액을 저장
                        subtotal = sub2 - sub1;

                        //int형으로 되어있는 차감 금액을 다시 string형으로 저장
                        string usernextmoney = Convert.ToString(subtotal);

                        //유저 보유 돈에 천단위 콤마를 넣기위한 string.format
                        string suerboxmoney = string.Format("{0}", subtotal.ToString("#,##0"));
                        //SQL서버 연결
                        mysql.Open();

                        //user테이블에 상품금액을 차감시킨 보유금액을 로그인 되어있는 userid로 갱신
                        string updateQuery = string.Format("UPDATE user set money = '{0}' where id = '{1}';", usernextmoney, user);

                        //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                        MySqlCommand Updatecommand = new MySqlCommand(updateQuery, mysql);
                        MySqlDataReader myReader;


                        myReader = Updatecommand.ExecuteReader();
                        MessageBox.Show("보유 금액이" + suerboxmoney + " 원 남았습니다.");

                        while (myReader.Read())
                        {
                        }
                        //장바구니 비워주기
                        CartEmpty();
                        //비워준 장바구니 불러오기
                        LoadData();
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

        //유저 보유금액 조회
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
                    string selectQuery = string.Format("SELECT money from user where id = '{0}';",user);

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 Selectcommand 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    //Select조회 해서 얻은 유저 보유머니를 int형 money변수에 저장
                    int money = (int)Selectcommand.ExecuteScalar();

                    //label에 넣기위해 convert.tostring을 통해 string로 형변환
                    lblsub2.Text = Convert.ToString(money);

                    //유저 보유 돈에 천단위 콤마를 넣기위한 string.format
                    string usertomoney = string.Format("{0}", money.ToString("#,##0"));

                    //유저 보유 금액에 string.format한 usertomoney값 입력
                    lblUsermoney.Text = usertomoney.ToString();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //사장 보유금액 조회
        public void LoadAdminMoney()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //uesr 테이블 admin 보유금액을 조회
                    string selectQuery = string.Format("SELECT money from user where id = '{0}';", lbladmin.Text);

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 Selectcommand 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    //Select조회 해서 얻은 admin 보유머니를 int형 adminmoney변수에 저장
                    int adminmoney = (int)Selectcommand.ExecuteScalar();
                   
                    //lbladminmoney에 adminmoney값 저장
                    lbladminmoney.Text = adminmoney.ToString();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //상품구입 처리 시 장바구니 비워주기
        public void CartEmpty()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //usercart테이블 비우기
                    string Query = string.Format("TRUNCATE TABLE usercart;");

                    //MYSQL에 Query 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand command = new MySqlCommand(Query, mysql);
                    command.ExecuteNonQuery();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //장바구니 비우기
        private void btnclear_Click(object sender, EventArgs e)
        {
            CartEmpty();
            MessageBox.Show("장바구니를 비웠습니다");
            LoadData();
        }

        //해당 상품 삭제
        private void btnminus_Click(object sender, EventArgs e)
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //선택 상품이 없다면 삭제불가
                    if (lblminus.Text == "")
                    {
                        MessageBox.Show("삭제 할 항목을 찾지 못했습니다.");
                    }
                    else
                    {
                        //SQL서버 연결
                        mysql.Open();
                        //item테이블에 itemname을 기준으로 상품 삭제
                        string deleteQuery = string.Format("delete from usercart where itemname = '{0}'", this.lblminus.Text);
                        //MYSQL에 deleteQuery 전송, mysql로 연결 시도 정보들을 deletecommand 변수에 저장
                        MySqlCommand deletecommand = new MySqlCommand(deleteQuery, mysql);
                        MySqlDataReader myReader;
                        myReader = deletecommand.ExecuteReader();
                        MessageBox.Show("해당 상품 장바구니에서 제외 완료");
                        while (myReader.Read())
                        {
                        }
                        LoadData();
                        mysql.Close();
                    }
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //datagridview 셀 선택시 해당 행 상품이름 저장
        private void dgCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgCart.Rows[selectedRow];

            //해당 행 셀 선택시 상품 이름 저장
            lblminus.Text = row.Cells[0].Value.ToString();
            LoadItemCount();
        }

        public void LoadItemCount()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //uesr 테이블 보유금액을 현재 접속한 id를 조건으로 조회
                    string selectQuery = string.Format("SELECT itemallcount from item where itemname = '{0}';", this.lblminus.Text);

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 Selectcommand 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    //Select조회 해서 얻은 유저 보유머니를 int형 money변수에 저장
                    int itemcount = (int)Selectcommand.ExecuteScalar();

                    //label에 넣기위해 convert.tostring을 통해 string로 형변환
                    lblitemcount.Text = Convert.ToString(itemcount);
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
