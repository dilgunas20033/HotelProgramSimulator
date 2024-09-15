namespace FirstProjectTutorial
{
    partial class ErrorSignin
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
            components = new System.ComponentModel.Container();
            okay = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // okay
            // 
            okay.Location = new Point(145, 82);
            okay.Name = "okay";
            okay.Size = new Size(75, 23);
            okay.TabIndex = 0;
            okay.Text = "Close";
            okay.UseVisualStyleBackColor = true;
            okay.Click += okay_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 44);
            label1.Name = "label1";
            label1.Size = new Size(179, 15);
            label1.TabIndex = 1;
            label1.Text = "Username or Password left blank";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ErrorSignin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 161);
            Controls.Add(label1);
            Controls.Add(okay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ErrorSignin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ErrorSignin";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okay;
        private ErrorProvider errorProvider1;
        private Label label1;
    }
}