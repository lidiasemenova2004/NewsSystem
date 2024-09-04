using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace TheNewsSystem
{
    public partial class SelectingTheOperatingForm : Form
    {
        Session session;
        public SelectingTheOperatingForm()
        {
            InitializeComponent();
            session = new Session();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            session.EndWork();
        }

        private void Viewing_Mode_button_Click(object sender, EventArgs e)
        {
            ViewingForm viewing = new ViewingForm();
            this.Hide();
            viewing.Show();
        }

        private void News_Adding_Mode_button_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            this.Hide();
            registration.Show();
        }
    }
}
