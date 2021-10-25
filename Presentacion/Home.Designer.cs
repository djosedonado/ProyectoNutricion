
namespace Presentacion
{
    partial class Home
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
            this.panelHome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.panelHome.Controls.Add(this.pictureBox2);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(957, 617);
            this.panelHome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.HomeImagen1;
            this.pictureBox1.Location = new System.Drawing.Point(180, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 499);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.Logo_NutriSoft;
            this.pictureBox2.Location = new System.Drawing.Point(375, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 92);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 617);
            this.Controls.Add(this.panelHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}