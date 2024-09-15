namespace FirstProjectTutorial
{
    partial class Admin
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
            panel1 = new Panel();
            logout = new Button();
            checkin = new Button();
            rewards = new Button();
            rooms = new Button();
            panel2 = new Panel();
            roomPanel = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            roomPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(logout);
            panel1.Controls.Add(checkin);
            panel1.Controls.Add(rewards);
            panel1.Controls.Add(rooms);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 961);
            panel1.TabIndex = 2;
            // 
            // logout
            // 
            logout.Location = new Point(88, 926);
            logout.Name = "logout";
            logout.Size = new Size(75, 23);
            logout.TabIndex = 0;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // checkin
            // 
            checkin.Location = new Point(33, 289);
            checkin.Name = "checkin";
            checkin.Size = new Size(200, 65);
            checkin.TabIndex = 2;
            checkin.Text = "Check-In";
            checkin.UseVisualStyleBackColor = true;
            // 
            // rewards
            // 
            rewards.Location = new Point(33, 462);
            rewards.Name = "rewards";
            rewards.Size = new Size(200, 65);
            rewards.TabIndex = 1;
            rewards.Text = "Rewards";
            rewards.UseVisualStyleBackColor = true;
            // 
            // rooms
            // 
            rooms.Location = new Point(33, 129);
            rooms.Name = "rooms";
            rooms.Size = new Size(200, 65);
            rooms.TabIndex = 0;
            rooms.Text = "Rooms";
            rooms.UseVisualStyleBackColor = true;
            rooms.Click += rooms_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(273, 798);
            panel2.Name = "panel2";
            panel2.Size = new Size(961, 163);
            panel2.TabIndex = 3;
            // 
            // roomPanel
            // 
            roomPanel.Controls.Add(panel3);
            roomPanel.Controls.Add(label1);
            roomPanel.Location = new Point(273, 0);
            roomPanel.Name = "roomPanel";
            roomPanel.Size = new Size(961, 801);
            roomPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 216);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(961, 798);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(499, 224);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1234, 961);
            Controls.Add(roomPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin";
            panel1.ResumeLayout(false);
            roomPanel.ResumeLayout(false);
            roomPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button logout;
        private Button checkin;
        private Button rewards;
        private Button rooms;
        private Panel roomPanel;
        private Label label1;
        private Panel panel3;
        private Label label2;
    }
}