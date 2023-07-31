using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoBeastsChampions_App
{
    public class VerticalLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            // Rotar el gráfico 90 grados en sentido antihorario
            e.Graphics.RotateTransform(-90f);

            // Establecer la posición del texto girado
            float x = -Height; // La altura será el ancho porque estamos girando 90 grados
            float y = 0;

            // Dibujar el texto
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), x, y, sf);
            }
        }
    }
}
