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
        Bitmap bmp = new Bitmap(128, 128);
        float[,] matrixMap = new float[128, 128];
        Random rnd = new Random();
        //byte[,] arrPix = new byte[128, 128];
        byte obj_id = 0;
        float scale = 1;//1px = 1meter
        int wMap = 128;
        int hMap = 128;

        public struct Object
        {
            public float x, y, r;
            public byte id;
        }

        //void ArrPix()
        //{
        //    //Заполнение массива
            



        //    //Добавление объекта в массив

        //}
        List<Object> objects = new List<Object>();//Создание коллекции для объектов


        public Form_Main()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;
            this.timer_RealTime.Enabled = true;
            //this.MouseClick += new MouseEventHandler(this.Mouse_Click);
            this.MouseWheel += new MouseEventHandler(this.pictureBox_Map_Wheel);

            for (byte i = 0; i < /*arrPix.GetLength(0)wMap*/matrixMap.GetLength(0); i++)
            {
                for (byte j = 0; j < /*arrPix.GetLength(1)hMap*/matrixMap.GetLength(1); j++)
                {
                    //arrPix[i, j] = 0;
                    matrixMap[i, j] = 0;
                    bmp.SetPixel(i, j, Color.FromArgb(255, 0, 0, 0));
                }
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_RealTime_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < matrixMap.GetLength(0); i++)
            {
                for (int j = 0; j < matrixMap.GetLength(1); j++)
                {
                    matrixMap[i, j] = 0;
                }
            }

            if (objects.Count > 0)
            {

                foreach (Object obj in objects)
                {
                    


                    

                    //for (byte i = 0; i < wMap/*arrPix.GetLength(0)*/; i++)
                    //{
                    //    for (byte j = 0; j < hMap/*arrPix.GetLength(1)*/; j++)
                    //    {
                            //if (//arrPix[i,j] != 0)
                            //{
                            

                    //float dn = 0, n = 0, r = /*obj.r;*/1;
                    //byte x = 0, y = 0;

                    //dn = 1 / r;
                    ////for (dn = r; dn < 1 / r; dn+=dn)
                    ////{
                    //n = 0;
                    //while (n < 2 * Math.PI)
                    //{
                    //    for (r=r; r < obj.r; r++)
                    //    {
                    //    x = (byte)Math.Round((double)(obj.x + r * Math.Cos(n)));
                    //    y = (byte)Math.Round((double)(obj.y + r * Math.Sin(n)));

                    //    //arrPix[x, y] = obj.id;
                    //    }
                    //    r = 1;
                    //    n += dn;
                    //    bmp.SetPixel(x, y, Color.FromArgb(cA, cR, cG, cB));
                    //}
                    ////}

                    float dn = 0, n = 0, r = /*obj.r;*/1;
                    byte x = 0, y = 0;

                    
                    //for (dn = r; dn < 1 / r; dn+=dn)
                    //{
                    
                    for (r = 0; r < obj.r; r++)
                    {
                        dn = (float)(1/Math.Pow(r,2));
                        n = 0;
                        while (n < 2 * Math.PI)
                        {

                            //x = (byte)Math.Round((double)(obj.x + r* Math.Cos(n)*scale));
                            //y = (byte)Math.Round((double)(obj.y + r* Math.Sin(n)*scale));
                            ////x = (byte)(Math.Sqrt(obj.x) * + r*Math.Cos(n) * scale);
                            x = (byte)(obj.x+Math.Cos(n)*scale);
                            y = (byte)(Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2)));

                            matrixMap[x, y] = obj.id;
                            //arrPix[x, y] = obj.id;
                            //r += 1;
                            n += 0.1f;//dn/scale;
                            //bmp.SetPixel(x, y, Color.FromArgb(cA, cR, cG, cB));
                        }
                    }
                    //}
                    int cA = 0, cR = 0, cG = 0, cB = 0;

                    for (int i = 0; i < matrixMap.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrixMap.GetLength(1); j++)
                        {
                            if (matrixMap[i,j] == 0)
                            {
                                cA = 255; cR = 0; cG = 0; cB = 0;
                            }
                            else if (matrixMap[i,j] == 1)
                            {
                                cA = 255; cR = 255; cG = 0; cB = 0;
                            }
                            else if (matrixMap[i, j] == 2)/*arrPix[i, j] == 2)*/
                            {
                                cA = 255; cR = 0; cG = 0; cB = 255;
                            }
                            else
                            {
                                cA = 255; cR = 255; cG = 255; cB = 0;
                            }
                            
                            bmp.SetPixel(i, j, Color.FromArgb(cA, cR, cG, cB));
                        }
                    }

                    //}
                    //}
                    //}
                }
            }
            pictureBox_Map.Image = bmp;
            pictureBox_Map.Invalidate();
        }

        private void pictureBox_Map_Click(object sender, EventArgs e)
        {
            Object obj;
            obj.x = Convert.ToByte(((System.Windows.Forms.MouseEventArgs)e).Location.X);
            obj.y = Convert.ToByte(((System.Windows.Forms.MouseEventArgs)e).Location.Y);
            obj.r = 10;
            obj.id = obj_id++;
            obj.id++;
            objects.Add(obj);
        }

        private void pictureBox_Map_Wheel(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                scale++;
            }
            else
            {
                if(scale != 0)
                scale--;
            }
        }

        //public void Mouse_Click(object sender, MouseEventArgs e)
        //{
        //    for(int i = 80; i<=112; i++)
        //    {
        //        for(int j = 80; j<=112; j++)
        //        {
        //            bmp.SetPixel(i, j, Color.FromArgb(255, 255, 0, 0));
        //        }
        //    }

        //    //pictureBox_Map.Image = bmp;
        //    //pictureBox_Map.Invalidate();
        //}
    }
}
