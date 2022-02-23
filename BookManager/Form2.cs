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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (DataManager.Books.Count > 0)
                dataGridView_Book.DataSource = DataManager.Books;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            bool existBook = false;

            foreach (var item in DataManager.Books)
            {
                if(item.Isbn == textBox_Isbn.Text)
                {
                    existBook = true;
                    break;
                }
            }
            if(existBook)
                MessageBox.Show("이미 존재하는 도서!");
            else
            {
                Book book = new Book();
                book.Isbn = textBox_Isbn.Text;
                book.Name = textBox_BookName.Text;
                book.Publisher = textBox_publisher.Text;
                book.Page = int.Parse(textBox_page.Text);
                DataManager.Books.Add(book);

                dataGridView_Book.DataSource = null;
                dataGridView_Book.DataSource = DataManager.Books;
                DataManager.Save();
            }
        }

        private void Button_Modify_Click(object sender, EventArgs e)
        {
            Book book = null; //book은 아무것도 가리키지 않음
            for(int i = 0; i < DataManager.Books.Count; i++)
            {
                if(DataManager.Books[i].Isbn == textBox_Isbn.Text)
                {
                    book = DataManager.Books[i]; //Books의 i번째를 가리키게 됨(얕은 복사 = 참조복사)
                    book.Name = textBox_BookName.Text; //book의 값이 변경되면 Books의 i번째꺼가 값이 변경됨
                    book.Publisher = textBox_publisher.Text;
                    book.Page = int.Parse(textBox_page.Text);

                    dataGridView_Book.DataSource=null;
                    dataGridView_Book.DataSource = DataManager.Books;
                    DataManager.Save();
                }
            }
            if(book == null)
                MessageBox.Show("존재하지 않는 도서입니다.");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            for(int i = 0;i < DataManager.Books.Count; i++)
            {
                if(DataManager.Books[i].Isbn == textBox_Isbn.Text)
                {
                    DataManager.Books.RemoveAt(i);
                    existBook = true;
                }
            }
            if(existBook == false)
                MessageBox.Show("없는 책입니다.");
            else
            {
                dataGridView_Book.DataSource = null;
                if (DataManager.Books.Count > 0)
                    dataGridView_Book.DataSource = DataManager.Books;
                DataManager.Save();
            }
        }

        private void dataGridView_Book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dataGridView_Book.CurrentRow.DataBoundItem as Book;
            textBox_Isbn.Text = book.Isbn;
            textBox_BookName.Text = book.Name;
            textBox_publisher.Text = book.Publisher;
            textBox_page.Text = book.Page.ToString();
        }
    }
}
