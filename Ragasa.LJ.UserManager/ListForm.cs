using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usermanager_ni_sir;

namespace Labitoria.JD.UserManager
{
    public partial class ListForm : Form
    {

        UserRepository userRepository = new UserRepository();
        public ListForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateForm form = new CreateForm();
            form.ShowDialog();


        }



        private void ListForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to UserManager");
            LoadUsersToDataGridView();
        }

        private void LoadUsersToDataGridView()
        {
            List<UserModel> users = userRepository.GetAll();
            dgViewUsers.DataSource = users;
        }


        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadUsersToDataGridView();
        }
    }
}
