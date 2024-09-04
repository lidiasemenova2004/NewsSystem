using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheNewsSystem
{
    internal class AllNews
    {
        List<News> news;
        public AllNews()
        {
            news = ReadListNewsForFile("../../../News.txt");
        }
        public List<News> ReadListNewsForFile(string path)
        {
            List<News> list = new List<News>();
            string[] temporary = File.ReadAllLines(path);
            for (int i = 0; i < temporary.Length; i++)
            {
                string[] str = temporary[i].Split('_');
                News nws = new News(str[0], str[1], str[2], str[3], int.Parse(str[4]));
                list.Add(nws);
            }
            return list;
        }
        public void Add(News nws)
        {
            news.Add(nws);
        }
        public List<string> SearchNews(string date, string parametr, string information)
        {
            List<string> list = new List<string>();
            if (date != "")
            {
                foreach (News nws in news)
                {
                    if (date == nws.GetDate())
                    {
                        list.Add(nws.GetInformation());
                    }
                }
            }
            else if (parametr == "по автору")
            {
                foreach (News nws in news)
                {
                    if (information == nws.GetAutor())
                    {
                        list.Add(nws.GetInformation());
                    }
                }
            }
            else if (parametr == "по заголовку")
            {
                foreach (News nws in news)
                {
                    if (information == nws.GetTitle())
                    {
                        list.Add(nws.GetInformation());
                    }
                }
            }
            else
            {
                foreach (News nws in news)
                {
                    if (nws.SearchWordInNews(information))
                    {
                        list.Add(nws.GetInformation());
                    }
                }
            }
            return list;
        }
        public string SearchDescription(string information)
        {
            string term = "";
            foreach (News nws in news)
            {
                if (nws.GetInformation() == information)
                {
                    term = nws.GetNewsDescription();
                    break;
                }
            }
            return term;
        }
        public void AddedVoise(string information)
        {
            foreach (News nws in news)
            {
                if (nws.GetInformation() == information)
                {
                    nws.AddedVoice();
                    break;
                }
            }
        }
        public List<string> SortForVoises()
        {
            List<string> list = new List<string>();
            var orderedNews = news.OrderByDescending(n => n.GetVoises());
            foreach (News nws in orderedNews)
            {
                list.Add(nws.GetInformation());
            }
            return list;
        }
        public bool SearchAutor(string autor)
        {
            foreach (News item in news)
            {
                if (item.GetAutor() == autor)
                    return true;
            }
            return false;
        }
        public void RedactNews(string information, string description)
        {
            foreach (News item in news)
            {
                if (item.GetInformation() == information)
                {
                    item.RewriteDescription(description);
                    break;
                }
            }
        }
        public void WriteNewsInFile()
        {
            List<string> list = new List<string>();
            foreach(News item in news)
            {
                list.Add(item.GetAllInformation());
            }
            File.WriteAllLines("../../../News.txt", list.ToArray());
        }
    }
}
