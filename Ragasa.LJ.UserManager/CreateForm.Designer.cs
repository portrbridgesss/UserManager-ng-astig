namespace Labitoria.JD.UserManager
{
    partial class CreateForm
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
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnSave = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Lucida Console", 12F);
            txtEmail.Location = new Point(148, 58);
            txtEmail.Margin = new Padding(2, 1, 2, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(163, 23);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 12F);
            label1.Location = new Point(28, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 16);
            label1.TabIndex = 1;
            label1.Text = "Full Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 12F);
            label2.Location = new Point(38, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 16);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Lucida Console", 12F);
            txtUsername.Location = new Point(148, 98);
            txtUsername.Margin = new Padding(2, 1, 2, 1);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(163, 23);
            txtUsername.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F);
            label3.Location = new Point(38, 136);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 16);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Lucida Console", 12F);
            txtPassword.Location = new Point(148, 136);
            txtPassword.Margin = new Padding(2, 1, 2, 1);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(163, 23);
            txtPassword.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Lucida Console", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(205, 172);
            btnSave.Margin = new Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 22);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(199, 27);
            label4.TabIndex = 7;
            label4.Text = "Create User";
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(342, 202);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CreateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create User";
            Load += CreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private TextBox txtPassword;
        private Button btnSave;
        private Label label4;
    }
}
