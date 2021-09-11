
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
            this.SubjectsDataGrid = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseSession
            // 
            this.CloseSession.Location = new System.Drawing.Point(693, 386);
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
            this.Quit.Location = new System.Drawing.Point(693, 415);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(95, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit programm";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // SubjectsDataGrid
            // 
            this.SubjectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsDataGrid.Location = new System.Drawing.Point(12, 12);
            this.SubjectsDataGrid.Name = "SubjectsDataGrid";
            this.SubjectsDataGrid.Size = new System.Drawing.Size(607, 426);
            this.SubjectsDataGrid.TabIndex = 4;
            this.SubjectsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectsDataGrid_CellContentClick);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(736, 357);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(52, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // UsersModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubjectsDataGrid);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CloseSession);
            this.Name = "UsersModification";
            this.Text = "UsersModification";
            this.Load += new System.EventHandler(this.UsersModification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseSession;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.DataGridView SubjectsDataGrid;
        private System.Windows.Forms.Button Back;
    }
}