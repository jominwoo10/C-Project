using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinformProject.Forms
{
    public partial class GuestShoppingForm : Form
    {
        //DB Connect를 위한 정보
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "projectdb"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connection = "";
        int selectedRow;

        public GuestShoppingForm()
        {
            InitializeComponent();
            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);
        }

        //상품설명 가져오는 함수
        public void LoaditemContent()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {

                    //SQL서버 연결
                    mysql.Open();
                    //item테이블에서 상품설명만 조회
                    string selectQuery = "SELECT itemexplanation from item where itemcode = '" + this.lblitemcode.Text + "';";

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand selectcommand = new MySqlCommand(selectQuery, mysql);

                    //SQL문으로 조회한 상품설명을 string 변수에 저장
                    string itemcontent = (string)selectcommand.ExecuteScalar();

                    MySqlDataReader myReader;
                    myReader = selectcommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        //string변수를 상품설명 label에 저장
                        lblitemcontent.Text = itemcontent;
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

        //상품 총 가격 계산하는 함수
        public void Loaditemtotalprice()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {

                    //SQL서버 연결
                    mysql.Open();
                    //item테이블에서 상품설명만 조회
                    string selectQuery = "SELECT itemprice from item where itemcode = '" + this.lblitemcode.Text + "';";

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand selectcommand = new MySqlCommand(selectQuery, mysql);

                    //조회해서 받은 상품 가격을 int형 total변수에 저장
                    string total = (string)selectcommand.ExecuteScalar();

                    lblpricetest.Text = total;

                    //numericupdown으로 총 가격 계산을 위한 decimal변수선언 후 연산
                    decimal num = numcount.Value;
                    decimal total2 = Convert.ToDecimal(total);
                    decimal pricetotal = num * total2;

                    //label에 천단위 콤바 표시를 위한 string.format
                    string pricetotall = string.Format("{0}", pricetotal.ToString("#,##0"));

                    MySqlDataReader myReader;
                    myReader = selectcommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        //tostring으로 총 가격 값 받아오기
                        lblprice.Text = pricetotall.ToString();
                        lblpricesend.Text = pricetotal.ToString();
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

        //mysql에 상품 이미지를 가져오는 법
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
                    string selectQuery = string.Format("SELECT itemcode,itemname,itemallcount,itemprice from item;");

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
                    dgShopping.Columns[3].HeaderText = "상품가격";
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //폼 로드 시
        private void GuestShoppingForm_Load(object sender, EventArgs e)
        {
            LoadData();

            //폼 로드시 상품 선택 전까지 안보이게 설정
            lblitemcode.Visible = false;
            lblitemcontent.Visible = false;
            lblprice.Visible = false;
            lblpricename.Visible = false;
            lblcount.Visible = false;
            lblpricetest.Visible = false;
            lblcounttest.Visible = false;
            lblitemname.Visible = false;
            lblpricesend.Visible = false;
            numcount.Visible = false;
            btnaddcart.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            lblitemcode.Visible = false;
            lblitemcount.Visible = false;
        }

        //datagrid에 셀 선택 클릭 이벤트
        private void dgShopping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgShopping.Rows[selectedRow];

            //해당 행 셀 선택시 상품 코드 저장
            lblitemcode.Text = row.Cells[0].Value.ToString();
            //해당 행 셀 선택시 상품 이름 저장
            lblitemname.Text = row.Cells[1].Value.ToString();

            lblitemcount.Text = row.Cells[2].Value.ToString();
            //해당 행 셀 선택시 상품 가격 저장
            lblcounttest.Text = row.Cells[3].Value.ToString();

            //이미지 가져오기
            LoadImage();
            //상품설명 가져오기
            LoaditemContent();
            //상품 총 가격 계산하기
            Loaditemtotalprice();

            //셀 선택 시 해당 상품 상품명,가격,상품설명,수량 보이게 설정
            lblitemcontent.Visible = true;
            lblprice.Visible = true;
            lblpricename.Visible = true;
            lblcount.Visible = true;
            numcount.Visible = true;
            btnaddcart.Visible = true;
            label1.Visible = true;

            //다른 셀 클릭 시 수량 1개로 초기화
            numcount.Value = 1;

        }

        //상품가격 셀에 천단위 콤마 표시
        private void dgShopping_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgShopping.Columns[3].DefaultCellStyle.Format = "###,##0";
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
                    string selectQuery = "SELECT itemcode,itemname,itemallcount,itemprice from item WHERE itemsubject LIKE '%" + searchvalue + "%'";

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(Selectcommand);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgShopping.DataSource = table;

                    dgShopping.Columns[0].HeaderText = "상품코드";
                    dgShopping.Columns[1].HeaderText = "상품명";
                    dgShopping.Columns[2].HeaderText = "상품수량";
                    dgShopping.Columns[3].HeaderText = "상품가격";
                    mysql.Close();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //장바구니담기 클릭 시 처리
        private void itemAddCart()
        {
            //상품 재고 수량 
            int itemcount = Convert.ToInt32(lblitemcount.Text);
            label2.Text = Convert.ToString(numcount.Value);
            //장바구니 담는 수량
            int buycount = Convert.ToInt32(label2.Text);

            //상품 재고 수량이 구입 수량이랑 크거나 같을 시 장바구니 담기 가능
            if (itemcount >= buycount)
            {
                //장바구니 테이블에 값 저장
                try
                {
                    //DB연결하여 SQL사용하기 위함
                    using (MySqlConnection mysql = new MySqlConnection(_connection))
                    {
                        //SQL서버 연결
                        mysql.Open();
                        //usercart테이블에 상품 담기
                        string insertQuery = string.Format("Insert into usercart(itemname, itemprice, itemcount, itemtotalprice) VALUES ('{0}','{1}','{2}','{3}');", lblitemname.Text, lblpricetest.Text, numcount.Value, lblpricesend.Text);
                        //MYSQL에 insertQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                        MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                        if (command.ExecuteNonQuery() != 1)
                        {
                            MessageBox.Show("상품 장바구니 담기 실패 !");
                        }
                        else
                        {
                            MessageBox.Show("상품을 장바구니에 담았습니다 !");
                            //SQL연결 끊기
                            mysql.Close();
                        }
                    }
                }
                //예외 발생 시 해당 정보를 메시지박스로 출력
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                //잔여 수량에서 구입 수량 차감
                try
                {
                    //DB연결하여 SQL사용하기 위함
                    using (MySqlConnection mysql = new MySqlConnection(_connection))
                    {
                        int senditemcount = itemcount - buycount;
                        //SQL서버 연결
                        mysql.Open();

                        //item테이블에 수량 갱신
                        string UpdateQuery = string.Format("UPDATE item set itemallcount = '{0}' where itemcode = '{1}';", senditemcount, lblitemcode.Text);

                        //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                        MySqlCommand updatecommand = new MySqlCommand(UpdateQuery, mysql);
                        MySqlDataReader myReader;

                        myReader = updatecommand.ExecuteReader();

                        while (myReader.Read())
                        {
                        }
                        mysql.Close();
                        LoadData();
                    }
                }
                //예외 발생 시 해당 정보를 메시지박스로 출력
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("해당 상품의 재고가 부족합니다.");
            }
        }

        //검색 버튼 클릭시 searchdata호출 후 combobox 비움
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string SearchText = comsubject.Text.ToString();
            searchData(SearchText);
            comsubject.Text = "";
        }

        //numeric 값 변경시 이벤트 처리
        private void numcount_ValueChanged(object sender, EventArgs e)
        {
            Loaditemtotalprice();
        }

        //상품담기 버튼 클릭시 함수 실행
        private void btnaddcart_Click(object sender, EventArgs e)
        {
            itemAddCart();
        }

    }
}
