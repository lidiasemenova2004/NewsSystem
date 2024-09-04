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
    public partial class ViewingForm : Form
    {
        Session session;
        public ViewingForm()
        {
            InitializeComponent();
            Choice_Type_Search.Items.AddRange(new string[3] {"по автору", 
                "по заголовку", "по слову в описании" });
            session = new Session();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            session.EndWork();
        }
        private void Resetbutton_Click(object sender, EventArgs e)
        {
            SelectingTheOperatingForm selecting = new SelectingTheOperatingForm();
            this.Hide();
            selecting.Show();
        }
        private void ShowTheListNewsbutton_Click(object sender, EventArgs e)
        {
            List_News.Items.Clear();
            List_News.Items.AddRange(session.ShowNewsAtDate
                (Convert.ToString(Choice_Date.Text)).ToArray());
            List_News.ClearSelected();
        }
        private void Searchbutton_Click(object sender, EventArgs e)
        {
            List_News.Items.Clear();
            List_News.Items.AddRange(session.ShowNewsInformation
                (Convert.ToString(Choice_Type_Search.Text), Convert.ToString(Search_Informations.Text)).ToArray());
            List_News.ClearSelected();
        }
        private void ShowTheNewsDescrbutton_Click(object sender, EventArgs e)
        {
            Description_News.Text = session.ShowNewsDescription(List_News.SelectedItem.ToString());
        }
        private void AddedVoiseForNewsbutton_Click(object sender, EventArgs e)
        {
            if (List_News.SelectedItem != null)
            {
                session.AddedVoise(List_News.SelectedItem.ToString());
                List_News.Items.Clear();
                List_News.Items.AddRange(session.ShowTopNews().ToArray());
                List_News.ClearSelected();
            }
        }
        private void TopNewsbutton_Click(object sender, EventArgs e)
        {
            List_News.Items.Clear();
            List_News.Items.AddRange(session.ShowTopNews().ToArray());
            List_News.ClearSelected();
        }
    }
}
