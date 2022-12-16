using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinformProject.OnerForms
{
    public partial class OnerGuestAccessForm : Form
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

        public OnerGuestAccessForm(string userid)
        {
            InitializeComponent();
            user = userid;
            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);
        }
        public void LoadData()
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //user테이블 데이터 조회
                    string selectQuery = string.Format("SELECT name,id,password,money from user;");

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = Selectcommand;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dgGuest.DataSource = bSource;
                    sda.Update(dbdataset);

                    mysql.Close();
                    dgGuest.Columns[0].HeaderText = "이름";
                    dgGuest.Columns[1].HeaderText = "아이디";
                    dgGuest.Columns[2].HeaderText = "비밀번호";
                    dgGuest.Columns[3].HeaderText = "보유금액";
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
        //폼 로드시 데이터 조회
        private void OnerGuestAccessForm_Load(object sender, EventArgs e)
        {
            lblClick.Visible = false;
            //datagridview에 깜빡임 해결을 위한 클래스 사용
            dgGuest.DoubleBuffered(true);
            LoadData();
        }

        //ID검색 기준 데이터 조회
        public void searchData(string searchvalue)
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //user테이블 데이터 where문으로 id입력값으로 조회
                    string selectQuery = "SELECT name, id, password,money from user WHERE name LIKE '%" + searchvalue + "%'";

                    //MYSQL에 SelectQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand Selectcommand = new MySqlCommand(selectQuery, mysql);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(Selectcommand);

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgGuest.DataSource = table;

                    dgGuest.Columns[0].HeaderText = "이름";
                    dgGuest.Columns[1].HeaderText = "아이디";
                    dgGuest.Columns[2].HeaderText = "비밀번호";
                    dgGuest.Columns[3].HeaderText = "보유금액";
                    mysql.Close();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //검색버튼 클릭 시 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SearchText = txtSearchName.Text.ToString();
            searchData(SearchText);
            txtSearchName.Text = "";
        }

        //검색 텍스트에서 엔터 클릭시 돋보기버튼 기능
        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnSearch_Click(sender, e);
            }
        }

        //보유 금액에 천단위 콤마 표시
        private void gdGuest_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgGuest.Columns[3].DefaultCellStyle.Format = "#,###,##0";       
        }

        //클릭시 현재 데이터 삭제를 위한 클릭이벤트
        private void gdGuest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dgGuest.Rows[selectedRow];
            //셀 선택시 해당 행의 id값을 label에 저장
            lblClick.Text = row.Cells[1].Value.ToString();
        }

        //회원 삭제 버튼 클릭 시 처리
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    if (lblClick.Text == "")
                    {
                        MessageBox.Show("삭제 할 항목을 찾지 못했습니다.");
                    }
                    else
                    {
                        //SQL서버 연결
                        mysql.Open();
                        //user테이블에 id를 기준으로 삭제
                        string deleteQuery = "delete from user where id ='" + this.lblClick.Text + "';";
                        //MYSQL에 deleteQuery 전송, mysql로 연결 시도 정보들을 deletecommand 변수에 저장
                        MySqlCommand deletecommand = new MySqlCommand(deleteQuery, mysql);
                        MySqlDataReader myReader;
                        myReader = deletecommand.ExecuteReader();
                        MessageBox.Show("회원 삭제 완료");
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
    }
}
