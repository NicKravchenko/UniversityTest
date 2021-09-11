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
    public partial class Login : Forms
    {
        private int ticks;

        public Login()
        {
            InitializeComponent();
            WrongData.Visible = false;

            UsernameName.Text = "admin";
            UsernamePassword.Text = "password";
        }

        private void DoLogin()
        {
            WrongData.Visible = false;

            ticks = 0;

            var user = DB.SystemUsers.FirstOrDefault(x => x.NickName == UsernameName.Text && x.UserPassword == UsernamePassword.Text);
            GlobalUser = user;

            if (user == null)
            {
                UsernameName.Text = "";
                UsernamePassword.Text = "";

                WrongData.Visible = true;

                WrongDataTimer.Start();
            }
            else
            {
                ValidateUserRole(user);
            }
            
        }

        private void ValidateUserRole(SystemUser user)
        {
            switch (user.RoleId)
            {
                case 1:
                    AdminMainMenu adminMainMenu = new AdminMainMenu();
                    adminMainMenu.Show();
                    this.Hide();

                    break;

                case 2:
                    StudentMainMenu studentMainMenu = new StudentMainMenu();
                    studentMainMenu.Show();

                    this.Hide();

                    break;

                case 3:
                    Console.WriteLine();
                    break;

                default:
                    break;
            }
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                DoLogin();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void WrongDataTimer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks > 3)
            {
                WrongData.Visible = false;
                WrongDataTimer.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UsernameName_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void UsernamePassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void UsernameName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoLogin();
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
