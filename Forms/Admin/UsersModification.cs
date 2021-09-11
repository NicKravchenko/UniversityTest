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
    public partial class UsersModification : Forms
    {
        private SystemUser Admin = GlobalUser;

        public UsersModification()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable()
        {
            var users = DB.SystemUsers.ToList();
            SubjectsDataGrid.DataSource = users;
        }

        private void UsersModification_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminMainMenu adminMainMenu = new AdminMainMenu();
            adminMainMenu.Show();

            this.Close();
        }

        private void CloseSession_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Close();
        }



        private void Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SubjectsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
