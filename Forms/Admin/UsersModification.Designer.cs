
namespace UniversityTest
{
    partial class UsersModification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseSession = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Quit = new System.Windows.Forms.Button();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditById = new System.Windows.Forms.Button();
            this.FindById = new System.Windows.Forms.Button();
            this.AddNew = new System.Windows.Forms.Button();
            this.UserIdEditText = new System.Windows.Forms.TextBox();
            this.BirthDateText = new System.Windows.Forms.TextBox();
            this.CareerIdText = new System.Windows.Forms.TextBox();
            this.CityText = new System.Windows.Forms.TextBox();
            this.RoleIdText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.NicknameText = new System.Windows.Forms.TextBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.UserIdDeleteText = new System.Windows.Forms.TextBox();
            this.DeleteById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseSession
            // 
            this.CloseSession.Location = new System.Drawing.Point(670, 386);
            this.CloseSession.Name = "CloseSession";
            this.CloseSession.Size = new System.Drawing.Size(95, 23);
            this.CloseSession.TabIndex = 1;
            this.CloseSession.Text = "Close Session";
            this.CloseSession.UseVisualStyleBackColor = true;
            this.CloseSession.Click += new System.EventHandler(this.CloseSession_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityTest.Properties.Resources.LogoIntecPNG;
            this.pictureBox1.Location = new System.Drawing.Point(746, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(670, 415);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(95, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit programm";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Location = new System.Drawing.Point(12, 12);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.Size = new System.Drawing.Size(607, 426);
            this.UsersDataGrid.TabIndex = 4;
            this.UsersDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectsDataGrid_CellContentClick);
            this.UsersDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectsDataGrid_CellDoubleClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(691, 357);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(52, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.DeleteById);
            this.panel1.Controls.Add(this.EditById);
            this.panel1.Controls.Add(this.FindById);
            this.panel1.Controls.Add(this.AddNew);
            this.panel1.Controls.Add(this.UserIdDeleteText);
            this.panel1.Controls.Add(this.UserIdEditText);
            this.panel1.Controls.Add(this.BirthDateText);
            this.panel1.Controls.Add(this.CareerIdText);
            this.panel1.Controls.Add(this.CityText);
            this.panel1.Controls.Add(this.RoleIdText);
            this.panel1.Controls.Add(this.PasswordText);
            this.panel1.Controls.Add(this.NicknameText);
            this.panel1.Controls.Add(this.LastNameText);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.FirstNameText);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(625, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 339);
            this.panel1.TabIndex = 7;
            // 
            // EditById
            // 
            this.EditById.Location = new System.Drawing.Point(94, 363);
            this.EditById.Name = "EditById";
            this.EditById.Size = new System.Drawing.Size(35, 23);
            this.EditById.TabIndex = 8;
            this.EditById.Text = "Edit";
            this.EditById.UseVisualStyleBackColor = true;
            this.EditById.Click += new System.EventHandler(this.EditById_Click);
            // 
            // FindById
            // 
            this.FindById.Location = new System.Drawing.Point(55, 363);
            this.FindById.Name = "FindById";
            this.FindById.Size = new System.Drawing.Size(35, 23);
            this.FindById.TabIndex = 8;
            this.FindById.Text = "Find";
            this.FindById.UseVisualStyleBackColor = true;
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(4, 363);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(41, 23);
            this.AddNew.TabIndex = 8;
            this.AddNew.Text = "Add";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // UserIdEditText
            // 
            this.UserIdEditText.Location = new System.Drawing.Point(77, 337);
            this.UserIdEditText.Name = "UserIdEditText";
            this.UserIdEditText.Size = new System.Drawing.Size(52, 20);
            this.UserIdEditText.TabIndex = 7;
            // 
            // BirthDateText
            // 
            this.BirthDateText.Location = new System.Drawing.Point(7, 291);
            this.BirthDateText.Name = "BirthDateText";
            this.BirthDateText.Size = new System.Drawing.Size(100, 20);
            this.BirthDateText.TabIndex = 7;
            // 
            // CareerIdText
            // 
            this.CareerIdText.Location = new System.Drawing.Point(7, 213);
            this.CareerIdText.Name = "CareerIdText";
            this.CareerIdText.Size = new System.Drawing.Size(100, 20);
            this.CareerIdText.TabIndex = 7;
            // 
            // CityText
            // 
            this.CityText.Location = new System.Drawing.Point(7, 252);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(100, 20);
            this.CityText.TabIndex = 7;
            this.CityText.TextChanged += new System.EventHandler(this.CityText_TextChanged);
            // 
            // RoleIdText
            // 
            this.RoleIdText.Location = new System.Drawing.Point(7, 174);
            this.RoleIdText.Name = "RoleIdText";
            this.RoleIdText.Size = new System.Drawing.Size(100, 20);
            this.RoleIdText.TabIndex = 7;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(7, 135);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 7;
            // 
            // NicknameText
            // 
            this.NicknameText.Location = new System.Drawing.Point(7, 100);
            this.NicknameText.Name = "NicknameText";
            this.NicknameText.Size = new System.Drawing.Size(100, 20);
            this.NicknameText.TabIndex = 7;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(7, 61);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(100, 20);
            this.LastNameText.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Edit by static Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Add";
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(7, 20);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(100, 20);
            this.FirstNameText.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Career ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nickname";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 423);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Delete by static Id";
            // 
            // UserIdDeleteText
            // 
            this.UserIdDeleteText.Location = new System.Drawing.Point(36, 420);
            this.UserIdDeleteText.Name = "UserIdDeleteText";
            this.UserIdDeleteText.Size = new System.Drawing.Size(52, 20);
            this.UserIdDeleteText.TabIndex = 7;
            // 
            // DeleteById
            // 
            this.DeleteById.Location = new System.Drawing.Point(94, 418);
            this.DeleteById.Name = "DeleteById";
            this.DeleteById.Size = new System.Drawing.Size(46, 23);
            this.DeleteById.TabIndex = 8;
            this.DeleteById.Text = "Delete";
            this.DeleteById.UseVisualStyleBackColor = true;
            this.DeleteById.Click += new System.EventHandler(this.DeleteById_Click);
            // 
            // UsersModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UsersDataGrid);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CloseSession);
            this.Name = "UsersModification";
            this.Text = "UsersModification";
            this.Load += new System.EventHandler(this.UsersModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseSession;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CareerIdText;
        private System.Windows.Forms.TextBox RoleIdText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox NicknameText;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.Button EditById;
        private System.Windows.Forms.Button FindById;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.TextBox UserIdEditText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BirthDateText;
        private System.Windows.Forms.TextBox CityText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DeleteById;
        private System.Windows.Forms.TextBox UserIdDeleteText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}