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

            FirstNameText.Text = "Mercedes";
            LastNameText.Text = "Perez";

            BirthDateText.Text = "6/17/1994";

            CityText.Text = "Santo Domingo";

            NicknameText.Text = "MercedesPerez";
            PasswordText.Text = "parol";

            RoleIdText.Text = "2";
            CareerIdText.Text = "1";
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

        private void AddNew_Click(object sender, EventArgs e)
        {
            var user = new SystemUser();

            user.FirstName = FirstNameText.Text;
            user.LastName = LastNameText.Text;
            user.BirthDate = Convert.ToDateTime(BirthDateText.Text);
            user.City = CityText.Text;
            user.NickName = NicknameText.Text;
            user.UserPassword = PasswordText.Text;

            user.RoleId = Int16.Parse(RoleIdText.Text);
            user.CareerId = Int16.Parse(CareerIdText.Text);

            user.RegisterDate = DateTime.Now;

            
            DB.SystemUsers.Add(user);
            DB.SaveChanges();
        }

        private void CityText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
