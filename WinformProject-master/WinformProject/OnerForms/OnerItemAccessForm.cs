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
    public partial class OnerItemAccessForm : Form
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

        public OnerItemAccessForm(string userid)
        {
            InitializeComponent();
            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);
            user = userid;
        }

        //폼 로드 시
        private void OnerItemAccessForm_Load(object sender, EventArgs e)
        {
            LoadData();

            //폼 로드시 상품 선택 전까지 안보이게 설정
            lblitemcode.Visible = false;
            lblitemcontent.Visible = false;
            lblpricetest.Visible = false;
            lblcounttest.Visible = false;
            lblitemname.Visible = false;
            lblpricesend.Visible = false;
            btnAddcount.Visible = false;
            btnDelitem.Visible = false;
            lbldefault.Visible = false;
            lbldefaultname.Visible = false;
            lblsale.Visible = false;
            lblsalename.Visible = false;
            lblpricecosttest.Visible = false;
            label5.Visible = false;
            label1.Visible = false;
            btnadditem.Visible = false;
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

        //해당 상품 상품명 조회
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

        //datagrid에 셀 선택 클릭 이벤트
        private void dgShopping_CellClick(object sender, DataGridViewCellEventArgs e)
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
            //상품설명 가져오기
            LoaditemContent();
            //상품원가 가져오기
            Loaditempricecost();
            //상품판매가 가져오기
            Loaditemprice();

            //셀 선택 시 해당 상품 상품명,가격,상품설명,수량 보이게 설정
            lblitemcontent.Visible = true;
            btnAddcount.Visible = true;
            btnDelitem.Visible = true;
            lbldefault.Visible = true;
            lbldefaultname.Visible = true;
            lblsalename.Visible = true;
            lblsale.Visible = true;
            label5.Visible = true;
            label1.Visible = true;
            btnadditem.Visible = true;
        }

        //datagridview 상품원가, 상품가격 셀에 천단위 콤마 표시
        private void dgShopping_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgShopping.Columns[3].DefaultCellStyle.Format = "###,##0";
            dgShopping.Columns[4].DefaultCellStyle.Format = "###,##0";
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

        //검색 버튼 클릭시 searchdata호출 후 combobox 비움
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string SearchText = comsubject.Text.ToString();
            searchData(SearchText);
            comsubject.Text = "";
        }

        //상품삭제 버튼 클릭 시 처리
        private void btnDelitem_Click(object sender, EventArgs e)
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    if (lblitemcode.Text == "")
                    {
                        MessageBox.Show("삭제 할 항목을 찾지 못했습니다.");
                    }
                    else
                    {
                        //SQL서버 연결
                        mysql.Open();
                        //item테이블에 itemcode를 기준으로 상품 삭제
                        string deleteQuery = "delete from item where itemcode ='" + this.lblitemcode.Text + "';";
                        //MYSQL에 deleteQuery 전송, mysql로 연결 시도 정보들을 deletecommand 변수에 저장
                        MySqlCommand deletecommand = new MySqlCommand(deleteQuery, mysql);
                        MySqlDataReader myReader;
                        myReader = deletecommand.ExecuteReader();
                        MessageBox.Show("상품 삭제 완료");
                        LoadData();
                        while (myReader.Read())
                        {
                        }
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
        
        //재고추가 버튼 클릭 시 처리
        private void btnAddcount_Click(object sender, EventArgs e)
        {
            OnerItemCountAddForm onerItemCountAddForm= new OnerItemCountAddForm(user);
            onerItemCountAddForm.ShowDialog();
            LoadData();
        }

        //원가 조회
        public void Loaditempricecost()
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

                    //조회해서 받은 상품 가격을 string형 total변수에 저장
                    string total = (string)selectcommand.ExecuteScalar();

                    //label에 천단위 콤바 표시를 위한 string.format
                    int price = Convert.ToInt32(total);
                    string pricetotall = string.Format("{0}", price.ToString("#,##0"));

                    MySqlDataReader myReader;
                    myReader = selectcommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        //tostring으로 총 가격 값 받아오기
                        lbldefault.Text = pricetotall.ToString();
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

        //판매가격 조회
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
                    string selectQuery = "SELECT itemprice from item where itemcode = '" + this.lblitemcode.Text + "';";

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand selectcommand = new MySqlCommand(selectQuery, mysql);

                    //조회해서 받은 상품 가격을 string형 total변수에 저장
                    string total = (string)selectcommand.ExecuteScalar();

                    //label에 천단위 콤바 표시를 위한 string.format
                    int price = Convert.ToInt32(total);
                    string pricetotall = string.Format("{0}", price.ToString("#,##0"));

                    MySqlDataReader myReader;
                    myReader = selectcommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        //tostring으로 총 가격 값 받아오기
                        lblsale.Text = pricetotall.ToString();
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

        //상품추가 버튼 클릭 시 처리
        private void btnadditem_Click(object sender, EventArgs e)
        {
            OnerItemAddForm onerItemAddForm = new OnerItemAddForm(user);
            onerItemAddForm.ShowDialog();
            LoadData();
        }
    }
}
