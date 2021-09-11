
namespace UniversityTest
{
    partial class AdminMainMenu
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
            this.UsersModification = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseSession
            // 
            this.CloseSession.Location = new System.Drawing.Point(693, 386);
            this.CloseSession.Name = "CloseSession";
            this.CloseSession.Size = new System.Drawing.Size(95, 23);
            this.CloseSession.TabIndex = 0;
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UsersModification
            // 
            this.UsersModification.Location = new System.Drawing.Point(12, 12);
            this.UsersModification.Name = "UsersModification";
            this.UsersModification.Size = new System.Drawing.Size(126, 23);
            this.UsersModification.TabIndex = 0;
            this.UsersModification.Text = "Users modification";
            this.UsersModification.UseVisualStyleBackColor = true;
            this.UsersModification.Click += new System.EventHandler(this.UsersModification_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(693, 415);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(95, 23);
            this.Quit.TabIndex = 0;
            this.Quit.Text = "Quit programm";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.QuitProgramm_Click);
            // 
            // AdminMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsersModification);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.CloseSession);
            this.Name = "AdminMainMenu";
            this.Text = "AdminMainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseSession;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button UsersModification;
        private System.Windows.Forms.Button Quit;
    }
}