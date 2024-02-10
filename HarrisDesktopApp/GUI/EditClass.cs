using HarrisDesktopApp.DBOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarrisDesktopApp.GUI
{
    public partial class EditClass : Form
    {
        private AdminOperations adminOperations = new AdminOperations();
        public EditClass()
        {
            InitializeComponent();
        }
        private void EditClass_Load(object sender, EventArgs e)
        {
            dataGridViewClass.DataSource = adminOperations.GetClass();

        }

        private void LoadClass()
        {
            dataGridViewClass.DataSource = adminOperations.GetClass();
        }



        private void btnClickBack(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();
        }

        private void btnClickRefresh(object sender, EventArgs e)
        {
            LoadClass();
        }
    }
}
