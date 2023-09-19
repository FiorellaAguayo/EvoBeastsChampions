using EntitiesServices;

namespace EvoBeastsChampions_App
{
    public partial class PasswordConfirmation : Form
    {
        private FormHandler formHandler;
        private UserValidation _userValidation;
        private string _email;

        public PasswordConfirmation(string email)
        {
            InitializeComponent();
            formHandler = new FormHandler();
            _userValidation = new UserValidation();
            _email = email;
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (await _userValidation.ChangePassword(_email, txbPasswordOne.Text, txbPasswordTwo.Text))
            {
                MessageBox.Show("Se confirmó la nueva contraseña.");
                formHandler.HideForm<PasswordConfirmation>();
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formHandler.HideForm<PasswordConfirmation>();
        }
    }
}