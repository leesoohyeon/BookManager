using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_allBookCount.Text = "";
            label_allUserCount.Text = "";
            label_allBorrowedBook.Text = "";
            label_allDelayedBook.Text = "";

            label_allBookCount.Text = DataManager.Books.Count.ToString();
            label_allUserCount.Text = DataManager.Users.Count.ToString();

            //대출중인 도서의 수
            //where이라는 메소드(List에서쓰임)
            //where 안에 메소드가 매개변수로 들어감(람다)
            //x : Book에 있는 값들, 만약 책이 3권들어가면 x는 3개

            //Books에 있는 값들을 하나하나 읽어가면서, isBorrowed값이 true인 것의 갯수(=Count())를 세션 string으로 변환(ToString())
            label_allBorrowedBook.Text = DataManager.Books.Where(x => x.isBorrowed).Count().ToString();

            //연체중인 도서의 수
            //빌린 상태+빌리고나서 7일이 지난 것
            label_allDelayedBook.Text = DataManager.Books.Where(
                delegate (Book x) { return x.isBorrowed && x.BorrowedAt.AddDays(7)<DateTime.Now; }).Count().ToString();
            //where안에 들어가는 메소드, 매개변수는 Book 타입 변수, 1개, 반환값은 bool

            //데이터 그리드 뷰 설정
            //길이가 0인 List를 DataGridView에 집어넣고, Cell을 클릭하면 프로그램이 튕기는 오류있음
            if(DataManager.Users.Count > 0)
                dataGridView_UserManager.DataSource = DataManager.Users;
            if(DataManager.Books.Count > 0)
                dataGridView_BookManager.DataSource = DataManager.Books;
            dataGridView_BookManager.CellClick += Book_GridView_CellClick; //cell을 눌렀을 때 이벤트를 코드상으로 추가함
        }

        private void Book_GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dataGridView_BookManager.CurrentRow.DataBoundItem as Book; //내가 출력한 걸 Book으로 형변환
            textBox_Isbn.Text = book.Isbn;
            textBox_BookName.Text = book.Name;
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog(); //모달 //이 창을 꺼야지 그 밑에 코드들도 수행 됨

            //도서관리 창에서 책을 수정하는 지우든 추가하든 했을 것이다.
            DataManager.Load(); //Save한 값을 다시 호출해서 DataManager에 있는 List를 리셋함
            dataGridView_BookManager.DataSource = null;
            if(DataManager.Books.Count>0)
                dataGridView_BookManager.DataSource= DataManager.Books;
        }

        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            DataManager.Load();
            dataGridView_UserManager.DataSource = null;
            if(DataManager.Users.Count>0)
                dataGridView_UserManager.DataSource= DataManager.Users;
        }

        private void timer_Now_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH:mm:ss");
        }

        private void dataGridView_UserManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = dataGridView_UserManager.CurrentRow.DataBoundItem as User;
            textBox_Id.Text = user.Id.ToString();
        }

        private void button_Borrow_Click(object sender, EventArgs e)
        {
            if(textBox_Isbn.Text.Trim() =="") //양옆공백제거시에도 아무것도 없을 때
                MessageBox.Show("isbn입력하세요.");
            else if(textBox_Id.Text.Trim() =="")
                MessageBox.Show("사용자 id 입력하세요.");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
                    if(book.isBorrowed)
                        MessageBox.Show("이미 빌린 도서입니다.");
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox_Id.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView_BookManager.DataSource = null;
                        dataGridView_BookManager.DataSource = DataManager.Books;
                        DataManager.Save();
                        MessageBox.Show($"{book.Name}이/가 {user.Name}님께 대여되었습니다.");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("존재하지 않는 도서 혹은 사용자입니다.");
                }
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            if(textBox_Isbn.Text.Trim() =="")
                MessageBox.Show("isbn입력하세요");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_Isbn.Text);
                    if (book.isBorrowed)
                    {
                        DateTime oldDay = book.BorrowedAt;
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        dataGridView_BookManager.DataSource = null;
                        dataGridView_BookManager.DataSource = DataManager.Books;
                        DataManager.Save();

                        TimeSpan timeDiff = DateTime.Now - oldDay; //반납일 이랑 빌린날 뺀다.
                        if(timeDiff.Days > 7)
                            MessageBox.Show(book.Name+"은 연체상태로 반납");
                        else
                            MessageBox.Show(book.Name+"정상 반납");
                    }
                    else
                    {
                        MessageBox.Show("대여 상태가 아닙니다.");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("존재하지 않는 도서입니다.");
                }
            }
        }


    }
}
