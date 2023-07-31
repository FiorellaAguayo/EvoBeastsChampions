using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace EvoBeastsChampions_App
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            // Crear un VerticalLabel
            VerticalLabel verticalLabel = new VerticalLabel();
            verticalLabel.Text = "Texto Vertical";
            verticalLabel.Font = new Font("Arial", 12, FontStyle.Regular);

            // Ajustar la ubicación del VerticalLabel según tus necesidades
            verticalLabel.Location = new Point(78, 340);

            // Agregar el VerticalLabel al formulario MDI
            this.Controls.Add(verticalLabel);
        }
    }
}