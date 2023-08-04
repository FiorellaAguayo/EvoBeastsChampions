using System.Net;

namespace EvoBeastsChampions_App
{
    public partial class CreateAccount : Form
    {
        FormHandler formHandler;
        private string imageLoginURL = "https://i.pinimg.com/564x/06/4a/0b/064a0b904c5ce585ad9652ee225a7115.jpg";
        private string imageIconURL = "https://i.pinimg.com/564x/fc/9a/d4/fc9ad433f59946522ed14a2bca208641.jpg";

        private Image imageLogin;
        private Image imageIcon;

        private Size originalPbEnterSize;
        private Size originalPbBlockPasswordSize;

        public CreateAccount()
        {
            InitializeComponent();
            formHandler = new FormHandler();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            CustomizeForm();
            txbPassword.UseSystemPasswordChar = true;
        }

        private void PbEnterCreateAccount_Click(object sender, EventArgs e)
        {
            formHandler.OpenForm<Main>();
            formHandler.HideForm<CreateAccount>();
        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHandler.OpenForm<Login>();
            formHandler.HideForm<CreateAccount>();
        }

        private void CustomizeForm()
        {
            imageLogin = LoadImageFromInternet(imageLoginURL);
            imageIcon = LoadImageFromInternet(imageIconURL);

            BackgroundImage = imageLogin;
            PbEnterCreateAccount.Image = imageIcon;
            BackgroundImageLayout = ImageLayout.Stretch;
            panelLogin.BackColor = Color.FromArgb(150, 255, 255, 255);

            originalPbEnterSize = PbEnterCreateAccount.Size;
            originalPbBlockPasswordSize = PbBlockPassword.Size;
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

        private void PbBlockPassword_Click(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }

        private void PbEnter_MouseEnter(object sender, EventArgs e)
        {
            IncreaseSizeOfPbEnter(13, 13);
            AdjustLocationOfPbEnter(-5, -5);
        }

        private void PbBlockPassword_MouseEnter(object sender, EventArgs e)
        {
            IncreaseSizeOfPbBlockPassword(3, 3);
            AdjustLocationOfPbBlockPassword(-3, -3);
        }

        private void PbEnter_MouseLeave(object sender, EventArgs e)
        {
            PbEnterCreateAccount.Size = originalPbEnterSize;
            AdjustLocationOfPbEnter(5, 5);
        }

        private void PbBlockPassword_MouseLeave(object sender, EventArgs e)
        {
            PbBlockPassword.Size = originalPbBlockPasswordSize;
            AdjustLocationOfPbBlockPassword(3, 3);
        }

        private void IncreaseSizeOfPbEnter(int width, int height)
        {
            PbEnterCreateAccount.Size = new Size(originalPbEnterSize.Width + width, originalPbEnterSize.Height + height);
            PbEnterCreateAccount.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void IncreaseSizeOfPbBlockPassword(int width, int height)
        {
            PbBlockPassword.Size = new Size(originalPbBlockPasswordSize.Width + width, originalPbBlockPasswordSize.Height + height);
            PbBlockPassword.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void AdjustLocationOfPbEnter(int locationX, int locationY)
        {
            PbEnterCreateAccount.Location = new Point(PbEnterCreateAccount.Location.X + locationX, PbEnterCreateAccount.Location.Y + locationY);
        }

        private void AdjustLocationOfPbBlockPassword(int locationX, int locationY)
        {
            PbBlockPassword.Location = new Point(PbBlockPassword.Location.X + locationX, PbBlockPassword.Location.Y + locationY);
        }

        private void lblLinkCanNotLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHandler.OpenForm<CanNotLogin>();
            formHandler.HideForm<Login>();
        }
    }
}