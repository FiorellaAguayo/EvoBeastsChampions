namespace EvoBeastsChampions_App
{
    public partial class Login : Form
    {
        private string logoLogin = "C:\\Users\\fiore\\OneDrive\\Escritorio\\EvoBeastsChampions_App\\EvoBeastsChampions_App\\photos\\logoLogin.jpg";
        private string iconArrow = "C:\\Users\\fiore\\OneDrive\\Escritorio\\EvoBeastsChampions_App\\EvoBeastsChampions_App\\photos\\right-arrow.jpg";

        private Size originalPbEnterSize;
        private Size originalPbBlockPasswordSize;

        private FormHandler formHandler;

        public Login()
        {
            InitializeComponent();
            formHandler = new FormHandler();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CustomizeForm();
            txbPassword.UseSystemPasswordChar = true;
        }

        private void PbEnter_Click(object sender, EventArgs e)
        {
            formHandler.OpenForm<Main>();
            Hide();
        }

        private void CustomizeForm()
        {
            BackgroundImage = Image.FromFile(logoLogin);
            BackgroundImageLayout = ImageLayout.Stretch;
            PbEnter.Image = Image.FromFile(iconArrow);
            panelLogin.BackColor = Color.FromArgb(150, 255, 255, 255);

            originalPbEnterSize = PbEnter.Size;
            originalPbBlockPasswordSize = PbBlockPassword.Size;
        }

        private void pbBlockPassword_Click(object sender, EventArgs e)
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
            PbEnter.Size = originalPbEnterSize;
            AdjustLocationOfPbEnter(5, 5);
        }

        private void pbBlockPassword_MouseLeave(object sender, EventArgs e)
        {
            PbBlockPassword.Size = originalPbBlockPasswordSize;
            AdjustLocationOfPbBlockPassword(3, 3);
        }

        private void IncreaseSizeOfPbEnter(int width, int height)
        {
            PbEnter.Size = new Size(originalPbEnterSize.Width + width, originalPbEnterSize.Height + height);
            PbEnter.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void IncreaseSizeOfPbBlockPassword(int width, int height)
        {
            PbBlockPassword.Size = new Size(originalPbBlockPasswordSize.Width + width, originalPbBlockPasswordSize.Height + height);
            PbBlockPassword.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void AdjustLocationOfPbEnter(int locationX, int locationY)
        {
            PbEnter.Location = new Point(PbEnter.Location.X + locationX, PbEnter.Location.Y + locationY);
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

        private void lblLinkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formHandler.OpenForm<CreateAccount>();
            formHandler.HideForm<Login>();
        }
    }
}