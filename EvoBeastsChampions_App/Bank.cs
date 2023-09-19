namespace EvoBeastsChampions_App
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void Bank_Load(object sender, EventArgs e)
        {
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            pictureBoxBackgroundPhoto.Image = Image.FromFile("C:\\Users\\fiore\\OneDrive\\Imágenes\\imagenes editar\\espacio.gif");
            pictureBoxBackgroundPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}