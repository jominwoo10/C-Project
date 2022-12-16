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

namespace WinformProject.OnerForms
{
    public partial class OnerItemCountAddForm : Form
    {
        //DB Connect를 위한 정보
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "projectdb"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connection = "";
        int selectedRow;
        string user;

        public OnerItemCountAddForm(string userid)
        {
            InitializeComponent();
            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);
            user = userid;
        }

        //폼 로드 시 
        private void OnerItemCountAddForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadAdminMoney();

            lbladminmoney.Visible = false;
            lblitemcode.Visible = false;
            lbladdcount.Visible = false;
            lblpricetest.Visible = false;
            lblcounttest.Visible = false;
            lblitemname .Visible = false;
            lblpricecosttest.Visible = false;
            lblpricesend.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            lbladminpr.Visible = false;
            lblprice.Visible = false;
            lblpricename.Visible = false;
            lblcountname.Visible = false;
            numcountadd.Visible = false;
            lblpricetotal.Visible = false;
            btnAddcount.Visible = false;
        }

        //상품 이미지 가져오기
        public void LoadImage()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();
                    //user테이블 데이터 조회
                    string selectQuery = "SELECT image from item where itemcode = '" + this.lblitemcode.Text + "';";


                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader myReader;
                    myReader = Selectcommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        byte[] imgg = (byte[])(myReader["image"]);
                        if (imgg == null)
                            picitemimage.Image = null;
                        else
                        {
                            MemoryStream mstream = new MemoryStream(imgg);
                            picitemimage.Image = System.Drawing.Image.FromStream(mstream);
                        }
                    }
                    mysql.Close();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //맨처음 datagrid에 데이터 조회 
        public void LoadData()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {

                    //SQL서버 연결
                    mysql.Open();

                    //item 테이블 데이터 조회
                    string selectQuery = string.Format("SELECT itemcode,itemname,itemallcount,itempricecost, itemprice from item;");

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = Selectcommand;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dgShopping.DataSource = bSource;

                    sda.Update(dbdataset);

                    mysql.Close();

                    dgShopping.Columns[0].HeaderText = "상품코드";
                    dgShopping.Columns[1].HeaderText = "상품명";
                    dgShopping.Columns[2].HeaderText = "상품수량";
                    dgShopping.Columns[3].HeaderText = "상품원가";
                    dgShopping.Columns[4].HeaderText = "판매가격";
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //admin 보유금액 조회
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
                    string selectQuery = string.Format("SELECT money from user where id = '{0}';", user);

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 Selectcommand 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    //Select조회 해서 얻은 admin 보유머니를 int형 adminmoney변수에 저장
                    int adminmoney = (int)Selectcommand.ExecuteScalar();

                    //lbladminmoney에 adminmoney값 저장
                    lbladminmoney.Text = adminmoney.ToString();


                    string viewadminmoney = string.Format("{0}", adminmoney.ToString("#,##0"));
                    lbladminpr.Text = viewadminmoney.ToString();

                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //combobox를 이용하여 검색
        public void searchData(string searchvalue)
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //item테이블 데이터 where문으로 콤보박스값으로 조회
                    string selectQuery = "SELECT itemcode,itemname,itemallcount,itempricecost,itemprice from item WHERE itemsubject LIKE '%" + searchvalue + "%'";

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(Selectcommand);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgShopping.DataSource = table;

                    dgShopping.Columns[0].HeaderText = "상품코드";
                    dgShopping.Columns[1].HeaderText = "상품명";
                    dgShopping.Columns[2].HeaderText = "상품수량";
                    dgShopping.Columns[3].HeaderText = "상품원가";
                    dgShopping.Columns[4].HeaderText = "판매가격";
                    mysql.Close();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //datagridview 셀 클릭 시 처리
        private void dgShopping_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgShopping.Rows[selectedRow];

            //해당 행 셀 선택시 상품 코드 저장
            lblitemcode.Text = row.Cells[0].Value.ToString();
            //해당 행 셀 선택시 상품 이름 저장
            lblitemname.Text = row.Cells[1].Value.ToString();
            //해당 행 셀 선택시 상품 수량 저장
            lblcounttest.Text = row.Cells[2].Value.ToString();
            //해당 행 셀 선택시 상품 원가 저장
            lblpricecosttest.Text = row.Cells[3].Value.ToString();
            //해당 행 셀 선택시 상품 가격 저장
            lblpricetest.Text = row.Cells[4].Value.ToString();

            //이미지 가져오기
            LoadImage();
            //상품 가격 불러오기
            Loaditemprice();
            //다른 셀 클릭 시 수량 1개로 초기화
            numcountadd.Value = 1;

            //셀 선택 시 해당 상품 상품명,가격,상품설명,수량 보이게 설정
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            lbladminpr.Visible = true;
            lblprice.Visible = true;
            lblpricename.Visible = true;
            lblcountname.Visible = true;
            numcountadd.Visible = true;
            lblpricetotal.Visible = true;
            btnAddcount.Visible = true;
        }

        //검색버튼 클릭 시 처리
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string SearchText = comsubject.Text.ToString();
            searchData(SearchText);
            comsubject.Text = "";
        }

        //아이템 원가 조회
        public void Loaditemprice()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {

                    //SQL서버 연결
                    mysql.Open();
                    //item테이블에서 원가 조회
                    string selectQuery = "SELECT itempricecost from item where itemcode = '" + this.lblitemcode.Text + "';";

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand selectcommand = new MySqlCommand(selectQuery, mysql);

                    //조회해서 받은 상품 가격을 int형 total변수에 저장
                    string total = (string)selectcommand.ExecuteScalar();

                    //label에 천단위 콤바 표시를 위한 string.format
                    int price = Convert.ToInt32(total);
                    string pricetotall = string.Format("{0}", price.ToString("#,##0"));
                    
                    

                    //numericupdown으로 총 가격 계산을 위한 decimal변수선언 후 연산
                    decimal num = numcountadd.Value;
                    //numeric 값 임시 저장
                    lbladdcount.Text = Convert.ToString(num);

                    decimal total2 = Convert.ToDecimal(total);
                    decimal pricetotal = num * total2;


                    //db반영을 위해 int형 변수로 수량 값 저장
                    int numcountaddsend = Convert.ToInt32(num);
                    //총가격 int형으로 임시 저장
                    int viewprice = Convert.ToInt32(pricetotal);
                    //총가격 string형으로 임시 저장
                    lblpricetest.Text = Convert.ToString(pricetotal);

                    //label에 천단위 콤바 표시를 위한 string.format
                    string pricetotal2 = string.Format("{0}", pricetotal.ToString("#,##0"));

                    MySqlDataReader myReader;
                    myReader = selectcommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        //tostring으로 총 가격 값 받아오기
                        lblprice.Text = pricetotall.ToString();
                        lblpricetotal.Text = pricetotal2.ToString();
                    }
                    mysql.Close();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //numeric콤보박스 값 변경 시 처리
        private void numcountadd_ValueChanged(object sender, EventArgs e)
        {
            //변경 시 마다 가격 불러오기
            Loaditemprice();
        }

        //재고추가 버튼 클릭 시 재고 추가, admin 보유금액 차감
        private void btnAddcount_Click(object sender, EventArgs e)
        {
            int adminmoney = Convert.ToInt32(lbladminmoney.Text);
            int sub1 = Convert.ToInt32(lblpricetest.Text);
            int totaladminmoney;

            //admin 보유 금액보다 상품 총 가격이 더 클시
            if (sub1 > adminmoney)
            {
                //상품 구입 불가
                MessageBox.Show("잔액이 부족합니다.");
            }

            //admin이 보유한 돈이 더 많을 시 
            else
            {
                //재고추가 시 잔여 재고에서 추가한 만큼 더해주기
                try
                {
                    //DB연결하여 SQL사용하기 위함
                    using (MySqlConnection mysql = new MySqlConnection(_connection))
                    {
                        //numeric 수량 int형 변수에 저장
                        int numericcount = Convert.ToInt32(lbladdcount.Text);
                        //보유 수량 int형 변수에 저장
                        int itemcount = Convert.ToInt32(lblcounttest.Text);
                        //numeric수량 + 보유수량 처리
                        int additemcount = numericcount + itemcount;

                        //SQL서버 연결
                        mysql.Open();

                        //admin계정에 totaladminmoney금액을 갱신
                        string UpdateQuery = string.Format("UPDATE item set itemallcount = '{0}' where itemcode = '{1}';", additemcount, lblitemcode.Text);

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
                //admin 보유 금액에서 재고추가 시 총 금액 차감
                try
                {
                    //DB연결하여 SQL사용하기 위함
                    using (MySqlConnection mysql = new MySqlConnection(_connection))
                    {
                        //사장 보유금액 + 상품가격
                        totaladminmoney = adminmoney - sub1;
                        //messagebox에 띄울 string.format 처리
                        string totaladminmsgbox = string.Format("{0}", totaladminmoney.ToString("#,##0"));

                        //SQL서버 연결
                        mysql.Open();

                        //admin계정에 totaladminmoney금액을 갱신
                        string UpdateQuery = string.Format("UPDATE user set money = '{0}' where id = '{1}';", totaladminmoney, user);

                        //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                        MySqlCommand updatecommand = new MySqlCommand(UpdateQuery, mysql);
                        MySqlDataReader myReader;

                        myReader = updatecommand.ExecuteReader();

                        while (myReader.Read())
                        {
                        }
                        mysql.Close();
                        MessageBox.Show("해당 상품의 재고를 추가하였습니다");
                        MessageBox.Show("사장님 남은 금액은 " + totaladminmsgbox + " 원 입니다.");
                        this.Close();
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
}
