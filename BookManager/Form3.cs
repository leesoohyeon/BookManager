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
    public partial class Form3 : Form
    {
        //디자인창 말고 코드상에서 모든 이벤트를 다추가해보자.
        public Form3()
        {
            InitializeComponent();

            if(DataManager.Users.Count > 0)
                dataGridView_User.DataSource = DataManager.Users;

            dataGridView_User.CellClick += user_cellclick;

            //sender랑 e가 뭔지 정해져있지 않음.
            //다만 Click에 추가할 이벤트의 첫번째 메소드는 object이고 두번째는 EventArgs이다.
            button_Add.Click += (Sender, e) =>
            {
                if(DataManager.Users.Exists((x)=>x.Id == int.Parse(textBox_Id.Text)))
                    MessageBox.Show("ID 이미 있음");
                else //새로운 아이디일 경우
                {
                    //생성자는 아니고, 생서암과 동시에 멤버값 할당해주는 것
                    User user = new User() { Id=int.Parse(textBox_Id.Text), Name=textBox_Name.Text };
                    DataManager.Users.Add(user);

                    dataGridView_User.DataSource = null;
                    dataGridView_User.DataSource = DataManager.Users;
                    DataManager.Save(); //유저가 추가된 정보를 Save한다. 기존의 Users.xml에 덮어씌움
                }
            };

            button_Modify.Click += delegate (object sender, EventArgs e)
            {
                try
                {
                    User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox_Id.Text));
                    user.Name = textBox_Name.Text;

                    //만약에 책이 있고, 그 책을 빌린 사람이 Id가 1번인데, 1번의 이름을 바꿧다면
                    //그 이름 정보도 같이 바꿔줘야함
                    try
                    {
                        Book book = DataManager.Books.Single((x) => x.UserId == int.Parse(textBox_Id.Text));
                        book.UserName = textBox_Name.Text;
                    }
                    catch (Exception)
                    { 
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(textBox_Id.Text+"는 없는 아이디예요.");
                }
                dataGridView_User.DataSource = null;
                dataGridView_User.DataSource = DataManager.Users;
                DataManager.Save();
            };

            button_Delete.Click += btn_delete;
        }

        private void btn_delete(object sender, EventArgs e)
        {
            try
            {
                //Single로 내가 지우고자 하는 유저를 찾는다.
                // 그 주소값을 이용해서 Remove한다.
                //Single안 쓰면 for문 하나하나 찾아서 인덱스 단위로 지워야 됨
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox_Id.Text));
                DataManager.Users.Remove(user);

                dataGridView_User.DataSource = null;
                if(DataManager.Users.Count > 0)
                    dataGridView_User.DataSource= DataManager.Users;
                DataManager.Save();
            }
            catch (Exception)
            {

                MessageBox.Show("해당 아이디의 사용자는 없습니다.");
            }
        }

        private void user_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            User user = dataGridView_User.CurrentRow.DataBoundItem as User;
            textBox_Id.Text = user.Id.ToString();
            textBox_Name.Text = user.Name;
        }
    }
}
