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
        //float[,] matrixMap = new float[128, 128];
        Random rnd = new Random();
        //byte[,] arrPix = new byte[128, 128];
        byte obj_id = 0;
        float scale = 1;//1px = 1meter
        float light = 10;
        int wMap = 128;
        int hMap = 128;

        public struct Object
        {
            public float x, y, r;
            public byte id;
        }

        List<Object> objects = new List<Object>();//Создание коллекции для объектов


        public Form_Main()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;
            this.timer_RealTime.Enabled = true;
            //this.MouseClick += new MouseEventHandler(this.Mouse_Click);
            this.MouseWheel += new MouseEventHandler(this.pictureBox_Map_Wheel);

            //for (byte i = 0; i < /*arrPix.GetLength(0)wMap*/matrixMap.GetLength(0); i++)
            //{
            //    for (byte j = 0; j < /*arrPix.GetLength(1)hMap*/matrixMap.GetLength(1); j++)
            //    {
            //        //arrPix[i, j] = 0;
            //        matrixMap[i, j] = 0;
            //        bmp.SetPixel(i, j, Color.FromArgb(255, 0, 0, 0));
            //    }
            //}
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_RealTime_Tick(object sender, EventArgs e)
        {
            //for (int i = 0; i < matrixMap.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrixMap.GetLength(1); j++)
            //    {
            //        matrixMap[i, j] = 0;
            //    }
            //}
                light*=scale;
                int cA = 255, cR = 0, cG = 0, cB = 0;

                for (int i = 0; i < wMap; i++)
                {
                    for (int j = 0; j < hMap; j++)
                    {
                        float d = 0;//, min_d = -1;
                        byte o = 0;

                        foreach (Object obj in objects)
                        {
                            d = (float)(Math.Sqrt(Math.Pow(Math.Abs(i - obj.x), 2) + Math.Pow(Math.Abs(j - obj.y), 2)))
                            * scale;
                            //if (min_d>d||min_d == -1)
                            //{
                            //    min_d = d;
                            //    o = (byte)(obj.id-1);
                            //}
                            //}
                            //if (objects.Count > 0)
                            //{
                            if (d <= obj.r)
                            {
                                if (obj.id == 1)
                                {
                                    cA = 255; cR = 255; cG = 0; cB = 0;
                                }
                                else if (obj.id == 2)
                                {
                                    cA = 255; cR = 0; cG = 0; cB = 255;
                                }
                                else
                                {
                                    cA = 255; cR = 255; cG = 255; cB = 0;
                                }
                            }
                            else if (d <= obj.r + light)
                            {
                                if (obj.id == 1)
                                {
                                    cA = (byte)d; cR = 255; cG = 0; cB = 0;
                                }
                                else if (objects[o].id == 2)
                                {
                                    cA = (byte)d; cR = 0; cG = 0; cB = 255;
                                }
                                else
                                {
                                    cA = (byte)d; cR = 255; cG = 255; cB = 0;
                                }
                            }
                            else
                            {
                                cA = 255; cR = 0; cG = 0; cB = 0;
                            }
                        }
                        bmp.SetPixel(i, j, Color.FromArgb(cA, cR, cG, cB));
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
                scale+=1;
            }
            else
            {
                if(scale != 0)
                scale-=1;
            }
        }
    }
}
