using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureviewer
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// constructor de la clase pictures, iniciliza componentes.
        /// 
        /// </summary>
        public Form1()
        {
            int number;
            number = 10;
            number = number - 5;
            number = number * 3;
                                  
            InitializeComponent();
         //  this.Text = number.ToString();

        }
        /// <summary>
        /// REsumen que hace
        /// </summary>
        /// <param name="sender">Alguna ifo</param>
        /// <param name="e"></param>
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void showimage_Click(object sender, EventArgs e)
        {
            
            /* comentario de multiples
             * lineas..
             */

             if(openFileDialog1.ShowDialog()== DialogResult.OK)

            {
              // carga la imagen al picture box
                 pictureBox1.Load(openFileDialog1.FileName);
            }
          
            {

            }

        }

        private void setcolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void deleteimagen_Click(object sender, EventArgs e)
        {
            pictureBox1.Image  = null; 
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
