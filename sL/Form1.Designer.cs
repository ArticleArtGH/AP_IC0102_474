namespace sL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel_btn = new System.Windows.Forms.TableLayoutPanel();
            this.button_add = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel_main.SuspendLayout();
            this.tableLayoutPanel_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 1;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.Controls.Add(this.tableLayoutPanel_btn, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.panel_Main, 0, 0);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 2;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.4F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.6F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(324, 375);
            this.tableLayoutPanel_main.TabIndex = 0;
            // 
            // tableLayoutPanel_btn
            // 
            this.tableLayoutPanel_btn.ColumnCount = 2;
            this.tableLayoutPanel_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_btn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_btn.Controls.Add(this.button_add, 0, 0);
            this.tableLayoutPanel_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel_btn.Location = new System.Drawing.Point(3, 320);
            this.tableLayoutPanel_btn.Name = "tableLayoutPanel_btn";
            this.tableLayoutPanel_btn.RowCount = 1;
            this.tableLayoutPanel_btn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_btn.Size = new System.Drawing.Size(318, 52);
            this.tableLayoutPanel_btn.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(3, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 46);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(3, 3);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(318, 303);
            this.panel_Main.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 375);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_btn;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_Main;
    }
}

