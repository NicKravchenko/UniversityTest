
namespace UniversityTest
{
    partial class StudentMainMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentCity = new System.Windows.Forms.Label();
            this.StudentCareer = new System.Windows.Forms.Label();
            this.StudentFirstName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentAge = new System.Windows.Forms.Label();
            this.StudentSecondName = new System.Windows.Forms.Label();
            this.StudentAgeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseSession = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityTest.Properties.Resources.LogoIntecPNG;
            this.pictureBox1.Location = new System.Drawing.Point(746, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Second name:";
            // 
            // SubjectsDataGrid
            // 
            this.SubjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsDataGrid.Location = new System.Drawing.Point(12, 171);
            this.SubjectsDataGrid.Name = "SubjectsDataGrid";
            this.SubjectsDataGrid.Size = new System.Drawing.Size(518, 232);
            this.SubjectsDataGrid.TabIndex = 2;
            this.SubjectsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectsDataGrid_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentCity);
            this.groupBox1.Controls.Add(this.StudentCareer);
            this.groupBox1.Controls.Add(this.StudentFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StudentAge);
            this.groupBox1.Controls.Add(this.StudentSecondName);
            this.groupBox1.Controls.Add(this.StudentAgeText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // StudentCity
            // 
            this.StudentCity.AutoSize = true;
            this.StudentCity.Location = new System.Drawing.Point(128, 29);
            this.StudentCity.Name = "StudentCity";
            this.StudentCity.Size = new System.Drawing.Size(33, 13);
            this.StudentCity.TabIndex = 1;
            this.StudentCity.Text = "name";
            this.StudentCity.Click += new System.EventHandler(this.label5_Click);
            // 
            // StudentCareer
            // 
            this.StudentCareer.AutoSize = true;
            this.StudentCareer.Location = new System.Drawing.Point(273, 29);
            this.StudentCareer.Name = "StudentCareer";
            this.StudentCareer.Size = new System.Drawing.Size(33, 13);
            this.StudentCareer.TabIndex = 1;
            this.StudentCareer.Text = "name";
            this.StudentCareer.Click += new System.EventHandler(this.label5_Click);
            // 
            // StudentFirstName
            // 
            this.StudentFirstName.AutoSize = true;
            this.StudentFirstName.Location = new System.Drawing.Point(6, 29);
            this.StudentFirstName.Name = "StudentFirstName";
            this.StudentFirstName.Size = new System.Drawing.Size(33, 13);
            this.StudentFirstName.TabIndex = 1;
            this.StudentFirstName.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "City:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Career:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // StudentAge
            // 
            this.StudentAge.AutoSize = true;
            this.StudentAge.Location = new System.Drawing.Point(3, 101);
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.Size = new System.Drawing.Size(13, 13);
            this.StudentAge.TabIndex = 1;
            this.StudentAge.Text = "0";
            // 
            // StudentSecondName
            // 
            this.StudentSecondName.AutoSize = true;
            this.StudentSecondName.Location = new System.Drawing.Point(6, 64);
            this.StudentSecondName.Name = "StudentSecondName";
            this.StudentSecondName.Size = new System.Drawing.Size(73, 13);
            this.StudentSecondName.TabIndex = 1;
            this.StudentSecondName.Text = "Second name";
            // 
            // StudentAgeText
            // 
            this.StudentAgeText.AutoSize = true;
            this.StudentAgeText.Location = new System.Drawing.Point(3, 88);
            this.StudentAgeText.Name = "StudentAgeText";
            this.StudentAgeText.Size = new System.Drawing.Size(29, 13);
            this.StudentAgeText.TabIndex = 1;
            this.StudentAgeText.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "All students:";
            // 
            // CloseSession
            // 
            this.CloseSession.Location = new System.Drawing.Point(693, 386);
            this.CloseSession.Name = "CloseSession";
            this.CloseSession.Size = new System.Drawing.Size(95, 23);
            this.CloseSession.TabIndex = 4;
            this.CloseSession.Text = "Close Session";
            this.CloseSession.UseVisualStyleBackColor = true;
            this.CloseSession.Click += new System.EventHandler(this.CloseSession_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(693, 415);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(95, 23);
            this.Quit.TabIndex = 5;
            this.Quit.Text = "Quit programm";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // StudentMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.CloseSession);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubjectsDataGrid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StudentMainMenu";
            this.Text = "StudentMainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView SubjectsDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StudentFirstName;
        private System.Windows.Forms.Label StudentSecondName;
        private System.Windows.Forms.Label StudentAge;
        private System.Windows.Forms.Label StudentAgeText;
        private System.Windows.Forms.Label StudentCareer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label StudentCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseSession;
        private System.Windows.Forms.Button Quit;
    }
}