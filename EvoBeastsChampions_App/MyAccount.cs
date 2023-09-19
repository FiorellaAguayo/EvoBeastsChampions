using System.Net;
using Entities;

namespace EvoBeastsChampions_App
{
    public partial class MyAccount : Form
    {
        private User _user;
        public MyAccount(User user)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            _user = user;
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            pictureBoxBackgroundPhoto.Image = Image.FromFile("C:\\Users\\fiore\\OneDrive\\Imágenes\\imagenes editar\\espacio.gif");
            pictureBoxBackgroundPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            
            UploadUserData();
            UploadStandardImages();
        }

        private void UploadUserData()
        {
            pictureBoxProfile.Image = LoadImageFromInternet(_user.ProfilePicture);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;

            txbAlias.Text = _user.Alias;
            txbEmail.Text = _user.Email;
            txbPassword.Text = _user.Password;
            txbPassword.UseSystemPasswordChar = true;
        }

        private void UploadStandardImages()
        {
            pbPictureOne.Image = LoadImageFromInternet("https://i.pinimg.com/564x/1e/70/72/1e7072d287263b864790261cb336a2c8.jpg");
            pbPictureOne.SizeMode = PictureBoxSizeMode.Zoom;

            pbPictureTwo.Image = LoadImageFromInternet("https://i.pinimg.com/236x/00/d7/4c/00d74c0fd53d0b38a7681127d85ac1bb.jpg");
            pbPictureTwo.SizeMode = PictureBoxSizeMode.Zoom;

            pbPictureThree.Image = LoadImageFromInternet("https://i.pinimg.com/236x/4e/68/b5/4e68b5df90dc47e49bd024b7071d25bb.jpg");
            pbPictureThree.SizeMode = PictureBoxSizeMode.Zoom;

            pbPictureFour.Image = LoadImageFromInternet("https://i.pinimg.com/236x/33/1b/c5/331bc5c9ea41223f54346edd077e00c0.jpg");
            pbPictureFour.SizeMode = PictureBoxSizeMode.Zoom;

            pbPictureFive.Image = LoadImageFromInternet("https://i.pinimg.com/236x/3c/c6/1e/3cc61eadcba5e70cc941c754a0c2b2ee.jpg");
            pbPictureFive.SizeMode = PictureBoxSizeMode.Zoom;

            pbPictureSix.Image = LoadImageFromInternet("https://i.pinimg.com/236x/d8/b3/f3/d8b3f37502d89fbf9e0e1913550b4a87.jpg");
            pbPictureSix.SizeMode = PictureBoxSizeMode.Zoom;
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
    }
}