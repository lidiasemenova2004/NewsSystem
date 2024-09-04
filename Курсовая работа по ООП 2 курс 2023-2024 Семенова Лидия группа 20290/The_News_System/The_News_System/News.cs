using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNewsSystem
{
    internal class News
    {
        string title;
        string date;
        string autor;
        string description;
        int voises;
        public News(string title, string date, string autor, string description, int voises)
        {
            this.title = title;
            this.date = date;
            this.autor = autor;
            this.description = description;
            this.voises = voises;
        }
        public string GetNewsDescription() {  return description; }
        public string GetTitle() { return title; }
        public string GetDate() { return date; }
        public string GetAutor() {  return autor; }
        public bool SearchWordInNews(string wold)
        {
            if (description.Contains(wold))
                return true;
            return false;
        }
        public void AddedVoice() { voises += 1; }
        public int GetVoises() {  return voises; }
        public string GetInformation()
        {
            string temp = voises + "\t" + date + "\t" + autor + "\t" + title;
            return temp;
        }
        public void RewriteDescription(string description)
        {
            this.description = description;
        }
        public string GetAllInformation()
        {
            string temp = title + "_" + date + "_" + autor 
                + "_" + description + "_" + voises;
            return temp;
        }
    }
}
