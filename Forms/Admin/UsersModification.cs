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

            NicknameText.Text = "Babe";
            PasswordText.Text = "parol";

            RoleIdText.Text = "2";
            CareerIdText.Text = "1";
        }

        private void LoadTable()
        {
            var users = DB.SystemUsers.ToList();
            UsersDataGrid.DataSource = users;
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

            DB.SystemUsers.Add(SetUser(user));
            DB.SaveChanges();

            LoadTable();

        }

        private SystemUser SetUser(SystemUser user)
        {
            int _null;

            user.FirstName = FirstNameText.Text;
            user.LastName = LastNameText.Text;

            user.BirthDate = Convert.ToDateTime(BirthDateText.Text);

            user.City = CityText.Text;

            user.NickName = NicknameText.Text;
            user.UserPassword = PasswordText.Text;

            user.RoleId = Int16.Parse(RoleIdText.Text);
            user.CareerId = int.TryParse(CareerIdText.Text, out _null) ? (int?)_null : null;

            //user.CareerId = Int16.TryParse(CareerIdText.Text, out null);

            user.RegisterDate = DateTime.Now;

            return user;
        }


        private void FillDataByUserId(Int32 userId)
        {
            SystemUser user = new SystemUser();

            user = DB.SystemUsers.FirstOrDefault(x => x.UserId == userId);

            UserIdEditText.Text = Convert.ToString(user.UserId);
            UserIdDeleteText.Text = Convert.ToString(user.UserId);

            FirstNameText.Text = user.FirstName;
            LastNameText.Text = user.LastName;

            BirthDateText.Text = Convert.ToString(user.BirthDate);

            CityText.Text = user.City;

            NicknameText.Text = user.NickName;
            PasswordText.Text = user.UserPassword;

            RoleIdText.Text = Convert.ToString(user.RoleId);
            CareerIdText.Text = Convert.ToString(user.CareerId);
        }

        private void CityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubjectsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (UsersDataGrid.CurrentRow.Index != -1)
            {
                var userId =Convert.ToInt32(UsersDataGrid.CurrentRow.Cells["UserId"].Value);

                FillDataByUserId(userId);
            }
        }

        private void EditById_Click(object sender, EventArgs e)
        {
            int idToEdit = Convert.ToInt32(UserIdEditText.Text);

            var query =
                from user in DB.SystemUsers
                where user.UserId == idToEdit
                select user;

            foreach (SystemUser user in query)
            {
                SetUser(user);
            }

            DB.SaveChanges();

            LoadTable();
        }

        private void DeleteById_Click(object sender, EventArgs e)
        {
            int parseHelper = -1;
            int userIdToDelete;

            if (Int32.TryParse(UserIdDeleteText.Text, out parseHelper) == true)
            {
                userIdToDelete = Int32.Parse(UserIdDeleteText.Text);
            }
            else
            {
                userIdToDelete = -1;
            }


            var user = DB.SystemUsers.FirstOrDefault(x => x.UserId == userIdToDelete);

            if (user != null)
            {
                DB.SystemUsers.Remove(user);

                DB.SaveChanges();

                LoadTable();
            }
            else
            {
                UserIdDeleteText.Text = "Not_Exist";
            }
        }
    }
}
