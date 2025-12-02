namespace Labitoria.JD.UserManager
{
    partial class DetailsForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            lblUserId = new Label();
            lblPassword = new Label();
            lblUsername = new Label();
            lblFullName = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 26);
            label4.Name = "label4";
            label4.Size = new Size(419, 53);
            label4.TabIndex = 11;
            label4.Text = "User Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Bold);
            label3.Location = new Point(59, 356);
            label3.Name = "label3";
            label3.Size = new Size(194, 32);
            label3.TabIndex = 10;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F, FontStyle.Bold);
            label2.Location = new Point(59, 274);
            label2.Name = "label2";
            label2.Size = new Size(194, 32);
            label2.TabIndex = 9;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 190);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 8;
            label1.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 12F, FontStyle.Bold);
            label5.Location = new Point(97, 117);
            label5.Name = "label5";
            label5.Size = new Size(154, 32);
            label5.TabIndex = 12;
            label5.Text = "UserID:";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Lucida Console", 12F);
            lblUserId.Location = new Point(265, 117);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(223, 32);
            lblUserId.TabIndex = 16;
            lblUserId.Text = "12012010102";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Lucida Console", 12F);
            lblPassword.Location = new Point(265, 356);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(166, 32);
            lblPassword.TabIndex = 15;
            lblPassword.Text = "passw0rd";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Lucida Console", 12F);
            lblUsername.Location = new Point(265, 274);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(204, 32);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "junedelmar";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Lucida Console", 12F);
            lblFullName.Location = new Point(265, 190);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(413, 32);
            lblFullName.TabIndex = 13;
            lblFullName.Text = "June Delmar Labitoria";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(251, 425);
            button1.Name = "button1";
            button1.Size = new Size(194, 64);
            button1.TabIndex = 17;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(711, 501);
            Controls.Add(button1);
            Controls.Add(lblUserId);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblFullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label lblUserId;
        private Label lblPassword;
        private Label lblUsername;
        private Label lblFullName;
        private Button button1;
    }
}