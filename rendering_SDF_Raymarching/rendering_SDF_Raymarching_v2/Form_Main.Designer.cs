﻿namespace rendering_SDF_Raymarching
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.timer_RealTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Map = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_RealTime
            // 
            this.timer_RealTime.Enabled = true;
            this.timer_RealTime.Interval = 16;
            this.timer_RealTime.Tick += new System.EventHandler(this.timer_RealTime_Tick);
            // 
            // pictureBox_Map
            // 
            this.pictureBox_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Map.Location = new System.Drawing.Point(90, 100);
            this.pictureBox_Map.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_Map.Name = "pictureBox_Map";
            this.pictureBox_Map.Size = new System.Drawing.Size(128, 128);
            this.pictureBox_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Map.TabIndex = 0;
            this.pictureBox_Map.TabStop = false;
            this.pictureBox_Map.Click += new System.EventHandler(this.pictureBox_Map_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 329);
            this.Controls.Add(this.pictureBox_Map);
            this.MinimumSize = new System.Drawing.Size(324, 368);
            this.Name = "Form_Main";
            this.Padding = new System.Windows.Forms.Padding(90, 100, 90, 101);
            this.Text = "Рэндеринг_SDF_Raymarching";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_RealTime;
        private System.Windows.Forms.PictureBox pictureBox_Map;
    }
}

