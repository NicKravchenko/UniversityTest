
namespace UniversityTest
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.loginbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameName = new System.Windows.Forms.TextBox();
            this.UsernamePassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WrongData = new System.Windows.Forms.Label();
            this.WrongDataTimer = new System.Windows.Forms.Timer(this.components);
            this.Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(181, 320);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // UsernameName
            // 
            this.UsernameName.Location = new System.Drawing.Point(141, 187);
            this.UsernameName.Name = "UsernameName";
            this.UsernameName.Size = new System.Drawing.Size(152, 20);
            this.UsernameName.TabIndex = 2;
            this.UsernameName.TextChanged += new System.EventHandler(this.UsernameName_TextChanged);
            this.UsernameName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UsernameName_PreviewKeyDown);
            // 
            // UsernamePassword
            // 
            this.UsernamePassword.Location = new System.Drawing.Point(141, 254);
            this.UsernamePassword.Name = "UsernamePassword";
            this.UsernamePassword.Size = new System.Drawing.Size(152, 20);
            this.UsernamePassword.TabIndex = 2;
            this.UsernamePassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.UsernamePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsernamePassword_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityTest.Properties.Resources.LogoIntecPNG;
            this.pictureBox1.Location = new System.Drawing.Point(168, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WrongData
            // 
            this.WrongData.AutoSize = true;
            this.WrongData.ForeColor = System.Drawing.Color.Red;
            this.WrongData.Location = new System.Drawing.Point(142, 291);
            this.WrongData.Name = "WrongData";
            this.WrongData.Size = new System.Drawing.Size(151, 13);
            this.WrongData.TabIndex = 1;
            this.WrongData.Text = "Wrong username or password!";
            // 
            // WrongDataTimer
            // 
            this.WrongDataTimer.Interval = 1000;
            this.WrongDataTimer.Tick += new System.EventHandler(this.WrongDataTimer_Tick);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(351, 415);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(95, 23);
            this.Quit.TabIndex = 4;
            this.Quit.Text = "Quit programm";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernamePassword);
            this.Controls.Add(this.UsernameName);
            this.Controls.Add(this.WrongData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbutton);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameName;
        private System.Windows.Forms.TextBox UsernamePassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WrongData;
        private System.Windows.Forms.Timer WrongDataTimer;
        private System.Windows.Forms.Button Quit;
    }
}