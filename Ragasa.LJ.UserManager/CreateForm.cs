using usermanager_ni_sir;

namespace Labitoria.JD.UserManager
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool isInvalidInput = string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password);

            if (isInvalidInput)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UserRepository repository = new UserRepository();
                bool isUserAdded = repository.Add(username, password, email);

                if (isUserAdded)
                {
                    MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
