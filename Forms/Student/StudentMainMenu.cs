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
    
    public partial class StudentMainMenu : Forms
    {
        private SystemUser Student = GlobalUser;



        public StudentMainMenu()
        {
            InitializeComponent();
            InitStudentDate(Student);
            LoadTable();
        }

        private void InitStudentDate(SystemUser student)
        {
            DateTime dateOfBirth = Convert.ToDateTime(student.BirthDate);
            DateTime dateNow = DateTime.Today;

            int differenceInYears = Convert.ToInt32(DateTime.Now.ToString("yyyy")) - Convert.ToInt32(dateOfBirth.ToString("yyyy"));

            int age = differenceInYears;

            if (dateNow.AddYears(-1 * differenceInYears).Date < dateOfBirth.Date)
            {
                age -= 1;
            }
            
            StudentFirstName.Text = student.FirstName;
            StudentSecondName.Text = student.LastName;
            StudentAge.Text = Convert.ToString(age);

            StudentCity.Text = student.City;

            StudentCareer.Text = DB.Careers.FirstOrDefault(x => x.CareerId == student.CareerId).CareerName;
        }

        private void LoadTable()
        {
            var users = DB.SystemUsers.ToList();
            SubjectsDataGrid.DataSource = users;
        }

        private void SubjectsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CloseSession_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
