using System;
using System.Net;

using EntitiesServices;

namespace EvoBeastsChampions_App
{
    public partial class CanNotLogin : Form
    {
        private string imageCanNotLoginURL = "https://i.pinimg.com/564x/4d/d3/6b/4dd36b5734c8aaa6b754fcf71366af39.jpg";
        private Image imageCanNotLogin;
        private FormHandler formHandler;
        private UserValidation _userValidation;
        private Random random;
        private string randomNumberStr;

        public CanNotLogin()
        {
            InitializeComponent();
            formHandler = new FormHandler();
            _userValidation = new UserValidation();
            random = new Random();
        }

        private void CanNotLogin_Load(object sender, EventArgs e)
        {
            CustomizeForm();
        }

        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            switch(await _userValidation.SendCode(txbEmail.Text))
            {
                case UserValidation.ValidationStatus.Success:
                    randomNumberStr = random.Next(1000, 2000).ToString();
                    MessageBox.Show($"El codigo es: {randomNumberStr}");
                    break;

                case UserValidation.ValidationStatus.DoesNotExist:
                    MessageBox.Show("El email ingresado no existe.");
                    break;

                case UserValidation.ValidationStatus.InvalidEmail:
                    MessageBox.Show("El email ingresado no es válido.");
                    break;
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            switch(_userValidation.ValidateCode(randomNumberStr, txbCode.Text, txbEmail.Text))
            {
                case UserValidation.ValidationStatus.Success:
                    Form passwordConfirmation = new PasswordConfirmation(txbEmail.Text);
                    passwordConfirmation.Show();
                    break;

                case UserValidation.ValidationStatus.IsEmpty:
                    MessageBox.Show("Escriba el código primero.");
                    break;

                case UserValidation.ValidationStatus.DoesNotExist:
                    MessageBox.Show("El código ingresado es incorrecto.");
                    break;
            }
        }

        private void CustomizeForm()
        {
            imageCanNotLogin = LoadImageFromInternet(imageCanNotLoginURL);
            BackgroundImage = imageCanNotLogin;
            BackgroundImageLayout = ImageLayout.Stretch;
            panelLogin.BackColor = Color.FromArgb(150, 255, 255, 255);
        }

        private Image LoadImageFromInternet(string imageURL)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(imageURL);
                using (var stream1 = new System.IO.MemoryStream(data))
                {
                    Image image = Image.FromStream(stream1);
                    BackgroundImage = image;
                    return image;
                }
            }
        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHandler.OpenForm<Login>();
            formHandler.HideForm<CanNotLogin>();
        }
    }
}