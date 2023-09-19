using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoBeastsChampions_App
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void Store_Load(object sender, EventArgs e)
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
