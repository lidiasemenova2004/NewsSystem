using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNewsSystem
{
    public partial class  NewsAddingForm : Form
    {
        string autor;
        Session session;
        public  NewsAddingForm(string autor)
        {
            InitializeComponent();
            this.autor = autor;
            session = new Session();
            bool flag = session.SearchUserName(autor);
            if (flag)
            {
                ShowListNewsToAutorbutton.Visible = true;
                Help_To_Redact.Visible = true;
            }
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            session.EndWork();
        }
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            this.Hide();
            registration.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (List_News_To_Autor.SelectedItem == null)
                session.SaveNews("",Title_Text.Text, Description_Text.Text, autor);
            else
                session.SaveNews(List_News_To_Autor.SelectedItem.ToString(), 
                "", Description_Text.Text, "");
            Description_Text.Text = "";
            Title_Text.Text = "";
        }

        private void ShowTheNewsbutton_Click(object sender, EventArgs e)
        {
            Description_Text.Text = session.ShowNewsDescription(List_News_To_Autor.SelectedItem.ToString());
        }

        private void ShowListNewsToAutorbutton_Click(object sender, EventArgs e)
        {
            List_News_To_Autor.Visible = true;
            ShowTheNewsbutton.Visible = true;
            List_News_To_Autor.Items.Clear();
            List_News_To_Autor.Items.AddRange(session.ShowNewsInformation("по автору", autor).ToArray());
        }
    }
}
