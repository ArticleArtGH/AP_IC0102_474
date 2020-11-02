using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sL
{

    public partial class Form1 : Form
    {
        class List_Main
        {
            public static void LabelDynamic(Panel panel, string text, int width,
                int height, int left, int top)
            {
                Label lbl = new Label();
                lbl.Text = text;
                lbl.Width = width;
                lbl.Height = height;
                lbl.Left = left;
                lbl.Top = top;
                lbl.BackColor = Color.White;
                lbl.ForeColor = Color.Black;
                panel.Controls.Add(lbl);
            }

            public static void ButtonDynamic(Panel panel, string text, int width,
                int height, int left, int top)
            {
                Button btn = new Button();
                btn.Text = text;
                btn.Text = text;
                btn.Width = width;
                btn.Height = height;
                btn.Left = left;
                btn.Top = top;
                btn.BackColor = Color.Gray;
                btn.ForeColor = Color.Black;
                panel.Controls.Add(btn);
            }

            public static void TextDynamic(Panel panel, string text, int width,
                int height, int left, int top)
            {
                TextBox txt = new TextBox();
                txt.Text = text;
                txt.Width = width;
                txt.Height = height;
                txt.Left = left;
                txt.Top = top;
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
                panel.Controls.Add(txt);
            }

            public static Panel PanelDynamic(/*Panel panel,*/ int left, int top)
            {
                Panel pnl = new Panel();
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.Width = 300;
                pnl.Height = 50;
                pnl.BackColor = Color.White;
                pnl.ForeColor = Color.Black;
                pnl.Left = left;
                pnl.Top = top;
                //pnl.Controls.Add(panel);
                return pnl;
            }

            //public static void ClassDynamic(Panel panel, string titleLbl,
            //    string changeBtn, string txtBtn, string delBtn, int left,
            //    int top)
            public static void ClassDynamic(Panel panel, int left,
                int top)
            {
                Panel pnl = PanelDynamic(left, top);
                LabelDynamic(pnl, "Title", 50, 30, 10, 10);
                ButtonDynamic(pnl, "Change", 60, 30, 60, 10);
                TextDynamic(pnl, "Comments", 100, 30, 120, 10);
                ButtonDynamic(pnl, "Delete", 50, 30, 220, 10);
                panel.Controls.Add(pnl);
            }
        }

        //Label lbl = new Label();
        //Button btn = new Button();
        //TextBox txt = new TextBox();
        //Panel pnl = new Panel();
        int left = 0, top = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button_add_Click(object sender, EventArgs e)
        {
            List_Main.ClassDynamic(this.panel_Main, left, top);
            top += 60;

            ////gb.FlatStyle = FlatStyle.Flat;
            //pnl.Text = "Anime";
            //pnl.Location = new Point(10, 10);

            //lbl.Text = "Title1";
            //lbl.Location = new Point(10, 10);
            //pnl.Controls.Add(lbl);

            //btn.Text = "Change";
            //btn.Location = new Point(50, 10);
            //pnl.Controls.Add(btn);

            //txt.Size = new Size(30, 25);
            //txt.Location = new Point(100, 10);
            //pnl.Controls.Add(txt);

            //btn.Text = "Delete";
            //btn.Location = new Point(130,10 );
            //pnl.Controls.Add(btn);

            //this.tableLayoutPanel_main.Controls.Add(pnl);


        }
    }
}
