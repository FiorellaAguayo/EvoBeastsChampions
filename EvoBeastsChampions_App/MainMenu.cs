using System.Net;
using Entities;

namespace EvoBeastsChampions_App
{
    public partial class MainMenu : Form
    {
        private Image imageMenu;
        private Form activeForm;
        private User _user;

        public MainMenu(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            CustomizeForm();
            OpenChildForm(new FormMain(_user));   
        }

        private void CustomizeForm()
        {
            panelMenu.BackColor = Color.FromArgb(0, 255, 255, 255);
            panelUp.BackColor = Color.FromArgb(100, 255, 255, 255);

            imageMenu = LoadGifFromUrl("https://i.pinimg.com/originals/1a/a2/00/1aa2008c04d15f46d38b797cb1452ed4.gif");

            BackgroundImage = imageMenu;
            BackgroundImageLayout = ImageLayout.Stretch;

            pbProfile.Image = LoadImageFromInternet(_user.ProfilePicture);
            pbProfile.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private Image LoadImageFromInternet(string imageURL)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] data = webClient.DownloadData(imageURL);
                using (var stream1 = new System.IO.MemoryStream(data))
                {
                    Image image = Image.FromStream(stream1);
                    return image;
                }
            }
        }

        private Image LoadGifFromUrl(string url)
        {
            Image image = null;

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] gifBytes = webClient.DownloadData(url);
                    using (MemoryStream stream = new MemoryStream(gifBytes))
                    {
                        image = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el GIF: " + ex.Message);
            }

            return image;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForms.Controls.Add(childForm);
            panelChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButtonMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormMain(_user));
        }

        private void iconButtonStore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Store());
        }

        private void iconButtonMyEvoBeasts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyEvobeasts());
        }

        private void iconButtonBank_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Bank());
        }

        private void iconButtonMyAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyAccount(_user));
        }
    }
}