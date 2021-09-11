using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityTest
{
    public partial class AdminMainMenu : Forms
    {

        private SystemUser Admin = GlobalUser;

        public AdminMainMenu()
        {
            InitializeComponent();

        }

        private void UsersModification_Click(object sender, EventArgs e)
        {
            UsersModification userModification = new UsersModification();
            userModification.Show();

            this.Close();
        }

        private void CloseSession_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Close();
        }

        private void QuitProgramm_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
