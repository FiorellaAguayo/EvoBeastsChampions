using Entities;

namespace EvoBeastsChampions_App
{
    public partial class FormMain : Form
    {
        private User _user;

        public FormMain(User user)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            _user = user;
        }

        private void CustomizeForm()
        {
            pictureBoxBackgroundPhoto.Image = Image.FromFile("C:\\Users\\fiore\\OneDrive\\Imágenes\\imagenes editar\\espacio.gif");
            pictureBoxBackgroundPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CustomizeForm();
        }
    }
}