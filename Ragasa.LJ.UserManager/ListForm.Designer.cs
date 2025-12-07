namespace Labitoria.JD.UserManager
{
    partial class ListForm
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
            dgViewUsers = new DataGridView();
            label4 = new Label();
            btnSave = new Button();
            button1 = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dgViewUsers
            // 
            dgViewUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dgViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewUsers.Location = new Point(6, 95);
            dgViewUsers.Margin = new Padding(2, 1, 2, 1);
            dgViewUsers.Name = "dgViewUsers";
            dgViewUsers.RowHeadersWidth = 82;
            dgViewUsers.Size = new Size(418, 177);
            dgViewUsers.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 14);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 27);
            label4.TabIndex = 8;
            label4.Text = "User List";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.AliceBlue;
            btnSave.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.Gray;
            btnSave.Location = new Point(320, 66);
            btnSave.Margin = new Padding(2, 1, 2, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 22);
            btnSave.TabIndex = 9;
            btnSave.Text = "New";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(160, 280);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(104, 30);
            button1.TabIndex = 10;
            button1.Text = "Details";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.AliceBlue;
            btnRefresh.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnRefresh.FlatAppearance.BorderSize = 2;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Lucida Console", 9.75F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Gray;
            btnRefresh.Location = new Point(212, 66);
            btnRefresh.Margin = new Padding(2, 1, 2, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(104, 22);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // ListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 326);
            Controls.Add(btnRefresh);
            Controls.Add(button1);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(dgViewUsers);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ListForm";
            Text = "ListForm";
            Load += ListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgViewUsers;
        private Label label4;
        private Button btnSave;
        private Button button1;
        private Button btnRefresh;
    }
}