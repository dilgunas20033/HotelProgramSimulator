namespace FirstProjectTutorial
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            signinButton = new Button();
            email = new TextBox();
            password = new TextBox();
            checkBox1 = new CheckBox();
            timeShown = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(943, 30);
            label1.Name = "label1";
            label1.Size = new Size(279, 38);
            label1.TabIndex = 1;
            label1.Text = "Hotel Simulator ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(855, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 77);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(350, 961);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(67, 507);
            button1.Name = "button1";
            button1.Size = new Size(205, 95);
            button1.TabIndex = 6;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 403);
            label3.Name = "label3";
            label3.Size = new Size(277, 75);
            label3.TabIndex = 5;
            label3.Text = ",Easy way to book rooms\r\n,view rewards\r\n !and more\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 321);
            label2.Name = "label2";
            label2.Size = new Size(193, 45);
            label2.TabIndex = 4;
            label2.Text = "Sign Up \r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(594, 288);
            label4.Name = "label4";
            label4.Size = new Size(379, 38);
            label4.TabIndex = 4;
            label4.Text = "Login to You Account!!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(459, 382);
            label5.Name = "label5";
            label5.Size = new Size(97, 18);
            label5.TabIndex = 5;
            label5.Text = "Username:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(459, 547);
            label6.Name = "label6";
            label6.Size = new Size(92, 18);
            label6.TabIndex = 6;
            label6.Text = "Password:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // signinButton
            // 
            signinButton.Location = new Point(683, 675);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(177, 33);
            signinButton.TabIndex = 7;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = true;
            signinButton.Click += button2_Click;
            signinButton.KeyPress += signinButton_KeyPress;
            // 
            // email
            // 
            email.Location = new Point(459, 403);
            email.Name = "email";
            email.Size = new Size(611, 23);
            email.TabIndex = 8;
            email.KeyPress += email_KeyPress;
            // 
            // password
            // 
            password.Location = new Point(459, 568);
            password.Name = "password";
            password.Size = new Size(611, 23);
            password.TabIndex = 9;
            password.UseSystemPasswordChar = true;
            password.KeyPress += password_KeyPress;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(1076, 569);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(110, 20);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show Password";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // timeShown
            // 
            timeShown.AutoSize = true;
            timeShown.Location = new Point(1076, 937);
            timeShown.Name = "timeShown";
            timeShown.Size = new Size(0, 15);
            timeShown.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1234, 961);
            Controls.Add(timeShown);
            Controls.Add(checkBox1);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(signinButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Light", 9F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button signinButton;
        private TextBox email;
        private CheckBox checkBox1;
        private TextBox password;
        private Label timeShown;
        private System.Windows.Forms.Timer timer1;
        private ErrorProvider errorProvider1;
        private NotifyIcon notifyIcon1;
    }
}
