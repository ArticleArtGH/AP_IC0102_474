using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rendering_SDF_Raymarching
{
    public partial class Form_Main : Form
    {
        Bitmap bmp;
        Graphics gr;
        float[,] matrixMap = new float[128, 128];

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(128, 128);
            

            for (int i = 0; i < matrixMap.GetLength(0); i++)
            {
                for (int j = 0; j < matrixMap.GetLength(1); j++)
                {
                    bmp.SetPixel(i, j, Color.FromArgb(0, 128,128,128));
                }
            }

            //gr = Graphics.FromImage(bmp);
            
            //gr.DrawImage(bmp, new Point(128, 128));
            //pictureBox_Map.Invalidate();
            //gr = pictureBox_Map.CreateGraphics();
            pictureBox_Map.Image = bmp;
            //gr.DrawImage(pictureBox_Map);
        }

        private void pictureBox_Map_Click(object sender, EventArgs e)
        {

        }
    }
}
