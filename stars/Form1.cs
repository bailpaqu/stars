using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
            StarField(100);
        }

        private void StarField(int y)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            int x = 0;
            int xcoord, ycoord, size, rcolor, gcolor, bcolor;
            Random ranNum = new Random();

            while (x <= y)
            {
                rcolor = ranNum.Next(1, 255);
                gcolor = ranNum.Next(1, 255);
                bcolor = ranNum.Next(1, 255);

                drawBrush.Color = Color.FromArgb(rcolor, bcolor, gcolor);

                xcoord = ranNum.Next(1, 300);
                ycoord = ranNum.Next(1, 300);
                size = ranNum.Next(1, 10);

                formGraphics.FillRectangle(drawBrush, xcoord, ycoord, size, size);

                x++;
            }
        }
    }
}
