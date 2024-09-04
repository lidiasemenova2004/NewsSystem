using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TheNewsSystem
{
    internal class Session
    {
        AllNews news;
        public Session() 
        {
            news = new AllNews();
        }
        public List<string> ShowNewsAtDate(string date)
        {
            List<string> list = news.SearchNews(date, "","");
            return list;
        }
        public void SaveNews(string information, string title, string description, string autor)
        {
            if (information != "")
            {
                news.RedactNews(information, description);
            }
            else
            {
                news.Add(new News(title, DateTime.Now.ToShortDateString(), autor, description, 0));
            }
            news.WriteNewsInFile();
        }
        public List<string> ShowTopNews()
        {
            List<string> list = news.SortForVoises();
            return list;
        }
        public bool SearchUserName(string autor)
        {
            bool flag = news.SearchAutor(autor);
            return flag;
        }
        public List<string> ShowNewsInformation(string parametr, string information)
        {
            List<string> list = news.SearchNews("", parametr, information);
            return list;
        }
        public string ShowNewsDescription(string information)
        {
            string term = news.SearchDescription(information);
            return term;
        }
        public void AddedVoise(string information)
        {
            news.AddedVoise(information);
            news.WriteNewsInFile();
        }
        public void EndWork()
        {
            news.WriteNewsInFile();
            Application.Exit();
        }
    }
}
 