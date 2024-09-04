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
    public partial class RegistrationForm : Form
    {
        Session session;
        public RegistrationForm()
        {
            InitializeComponent();
            session = new Session();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            session.EndWork();
        }
        private void Continue_button_Click(object sender, EventArgs e)
        {
            if ((Autor.Text != "") & (!Autor.Text.ToString().Contains('_')))
            {
                NewsAddingForm newsAdding = new NewsAddingForm(Convert.ToString(Autor.Text));
                this.Hide();
                newsAdding.Show();
            }
            else if (Autor.Text == "") Help_Header.ForeColor = Color.Red;
            else if (Autor.Text.ToString().Contains('_')) Helper.ForeColor = Color.Red;
        }
        private void Reset_button_Click(object sender, EventArgs e)
        {
            SelectingTheOperatingForm selecting_The_Operating_Mode = new SelectingTheOperatingForm();
            this.Hide();
            selecting_The_Operating_Mode.Show();
        }
    }
}
