using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Forms;

namespace Projeto1.Classes
{
    internal class RetanguloImg
    {
        int larguraBordaRetangulo = 9;

        public RetanguloImg(int posX, int posY, int sizeX, int sizeY, PictureBox nomeImg, bool mouseDentro)
        {
            if (mouseDentro == true) //se mouse estiver dentro da imagem
            {
                //FAZ NOVO RETANGULO -> BORDA
                Rectangle retangulo = new Rectangle(posX, posY, sizeX, sizeY); //novo retangulo
                Pen pen = new Pen(Color.Black, larguraBordaRetangulo); //grossura borda
                Graphics g = nomeImg.CreateGraphics(); //fazer operações de desenho dentro do picturebox "nomeImg"
                g.DrawRectangle(pen, retangulo);

                //LIBERA DA MEMÓRIA
                pen.Dispose();
                g.Dispose();
            }
            else
            {
                nomeImg.Invalidate(); //remove o retangulo   
            }
            
        }
    }
}
