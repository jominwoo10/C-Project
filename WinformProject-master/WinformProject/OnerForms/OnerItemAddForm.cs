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
using System.IO;    

namespace WinformProject.OnerForms
{
    public partial class OnerItemAddForm : Form
    {
        string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
        int _port = 3306; //DB 서버 포트
        string _database = "projectdb"; //DB 이름
        string _id = "root"; //계정 아이디
        string _pw = "1234"; //계정 비밀번호
        string _connection = "";
        string user; //login폼에서 로그인 시 로그인 되어있는 userid를 받기위한 변수
        int selectedRow; //datagridview에서 해당 셀 선택시 row값 저장 변수

        public OnerItemAddForm(string userid)
        {
            InitializeComponent();
            //DB연결
            _connection = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};CharSet=utf8;", _server, _port, _database, _id, _pw);
            user = userid;
        }

        //이미지 불러오기 클릭 시 처리
        private void btn_loadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if(dlg.ShowDialog() == DialogResult.OK )
            {
                string picLoc = dlg.FileName.ToString();
                txt_imagepath.Text = picLoc;
                pictureBox1.ImageLocation = picLoc;
            }
        }

        //상품 추가 버튼 클릭 시 처리
        private void btnAdditem_Click(object sender, EventArgs e)
        {
            //이미지 저장을 위한 처리
            byte[] imageBt = null;
            FileStream fileStream = new FileStream(this.txt_imagepath.Text,FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            imageBt = binaryReader.ReadBytes((int)fileStream.Length);

            //상품분류 콤보박스 값 선택시 label에 저장
            this.label5.Text = this.combosubject.Text.ToString();

            //원가 계산을 위한 처리
            double pricecost = Convert.ToDouble(this.txtitemprice.Text);
            //원가 = 판매가격의 40%차감 금액
            double sendpricecost = pricecost * 0.6;
            this.label6.Text= sendpricecost.ToString();
            //상품추가시 수량은 기본 1개
            int count = 1;

            try
            {
                //DB연결하여 SQL사용하기 위함
                using (MySqlConnection mysql = new MySqlConnection(_connection))
                {
                    //SQL서버 연결
                    mysql.Open();

                    //item테이블에 상품 추가
                    string insertQuery = "INSERT INTO item(itemname,itemexplanation,itemsubject,itemprice,itempricecost,itemallcount,image)" +
                        "VALUES ('" + this.txtitemname.Text + "','" + this.txtitemcontent.Text + "','" + this.label5.Text + "'," +
                        "'" + this.txtitemprice.Text + "','" + this.label6.Text +"','" + count + "',@IMG)";

                    //MYSQL에 insertQuery 전송, mysql로 연결 시도 정보들을 command 변수에 저장
                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    MySqlDataReader myReader;

                    command.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                    myReader = command.ExecuteReader();

                    MessageBox.Show("상품 원가는 판매가의 40%로 자동 설정됩니다.");
                    MessageBox.Show("상품 추가 완료!");

                    while(myReader.Read())
                    {
                    }
                    this.Close();
                }
            }
            //예외 발생 시 해당 정보를 메시지박스로 출력
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        //폼 로드 시
        private void OnerItemAddForm_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
        }
    }
}
