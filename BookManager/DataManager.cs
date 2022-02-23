using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookManager
{
    public class DataManager
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();
        
        //DataManager에 접근하는 그 순간 바로 호출되는 것(인스턴스 만들기 전에 생김)
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                //Books.xml이라는 파일을 읽어 들이고, 그 안에 있는 텍스트들을 booksOutput에 담는다.
                string booksOutput = File.ReadAllText(@"./Books.xml");
                //그 텍스트 값들을 XML 데이터 양식으로 변경.
                XElement booksXElement = XElement.Parse(booksOutput);

                Books = (from item in booksXElement.Descendants("book")
                         select new Book()
                         {
                             Isbn = item.Element("isbn").Value,
                             Name = item.Element("name").Value,
                             Publisher = item.Element("publisher").Value,
                             Page=int.Parse(item.Element("page").Value),
                             BorrowedAt = DateTime.Parse(item.Element("borrowedAt").Value),
                             isBorrowed = item.Element("isBorrowed").Value !="0" ? true :false,
                             UserId = int.Parse(item.Element("userId").Value),
                             UserName = item.Element("userName").Value
                         }).ToList<Book>();
                string userOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(userOutput);
                Users.Clear();
                foreach (var item in usersXElement.Descendants("user"))
                {
                    User temp = new User();
                    temp.Name = item.Element("name").Value;
                    temp.Id = int.Parse(item.Element("id").Value);
                    Users.Add(temp); //읽어온 내용을 Users에 담아줘야 한다.
                }
            }
            catch (Exception e) //파일을 못 읽어들이면 Save 호출 후 Load다시 호출
            {

                System.Windows.Forms.MessageBox.Show("파일 누락!");
                Save();
                Load();
            }
        }

        public static void Save()
        {
            string booksOutput = "";
            booksOutput += "<books>\n";

            foreach(var item in Books)
            {
                booksOutput += "<book>\n";

                booksOutput += $"    <isbn>{item.Isbn}</isbn>\n";
                booksOutput += $"    <name>{item.Name}</name>\n";
                booksOutput += $"    <publisher>{item.Publisher}</publisher>\n";
                booksOutput += $"    <page>{item.Page}</page>\n";
                booksOutput += $"    <borrowedAt>{item.BorrowedAt}</borrowedAt>\n";
                booksOutput += $"    <isBorrowed>"+(item.isBorrowed ? 1:0)+"</isBorrowed>\n";
                booksOutput += $"    <userId>{item.UserId}</userId>\n";
                booksOutput += $"    <userName>{item.UserName}</userName>\n";

                booksOutput += "</book>\n";
            }

            booksOutput += "</books>";

            File.WriteAllText(@"./Books.xml",booksOutput);

            string usersOutput = "";
            usersOutput += "<users>\n";

            foreach(var item in Users)
            {
                usersOutput += "<user>\n";
                usersOutput += $"   <id>{item.Id}</id>\n";
                usersOutput += $"   <name>{item.Name}</name>\n";
                usersOutput += "</user>";
            }

            usersOutput += "</users>\n";
            File.WriteAllText(@"./Users.xml", usersOutput);
        }
    }
}
