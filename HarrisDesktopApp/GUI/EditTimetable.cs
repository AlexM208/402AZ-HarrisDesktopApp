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
    public partial class EditTimetable : Form
    {
        public EditTimetable()
        {
            InitializeComponent();
        }

        private void EditTimetable_Load(object sender, EventArgs e)
        {

        }

        private void btnClickBack(object sender, EventArgs e)
        {
            AdminHomePage adminp1 = new AdminHomePage();
            adminp1.StartPosition = FormStartPosition.CenterScreen;
            adminp1.Show();
            this.Hide();            
        }
    }
}
