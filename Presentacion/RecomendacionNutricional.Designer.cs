
namespace Presentacion
{
    partial class RecomendacionNutricional
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
            this.ContenedorRecomendacioNutricional = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextRecomendacionNutricional = new System.Windows.Forms.RichTextBox();
            this.TextRecomendacionAlimentario = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonGuardarRecomendacion = new System.Windows.Forms.PictureBox();
            this.textIdentificacionRecomendacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNombrePaciente = new System.Windows.Forms.TextBox();
            this.botonBuscarPaciente = new System.Windows.Forms.Button();
            this.ContenedorRecomendacioNutricional.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonGuardarRecomendacion)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorRecomendacioNutricional
            // 
            this.ContenedorRecomendacioNutricional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ContenedorRecomendacioNutricional.Controls.Add(this.botonBuscarPaciente);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.textNombrePaciente);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label4);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label3);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.textIdentificacionRecomendacion);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.botonGuardarRecomendacion);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.TextRecomendacionAlimentario);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label2);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.TextRecomendacionNutricional);
            this.ContenedorRecomendacioNutricional.Controls.Add(this.label1);
            this.ContenedorRecomendacioNutricional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorRecomendacioNutricional.Location = new System.Drawing.Point(0, 0);
            this.ContenedorRecomendacioNutricional.Name = "ContenedorRecomendacioNutricional";
            this.ContenedorRecomendacioNutricional.Size = new System.Drawing.Size(800, 450);
            this.ContenedorRecomendacioNutricional.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recomendacion Nutricional";
            // 
            // TextRecomendacionNutricional
            // 
            this.TextRecomendacionNutricional.Location = new System.Drawing.Point(70, 105);
            this.TextRecomendacionNutricional.Name = "TextRecomendacionNutricional";
            this.TextRecomendacionNutricional.Size = new System.Drawing.Size(299, 222);
            this.TextRecomendacionNutricional.TabIndex = 1;
            this.TextRecomendacionNutricional.Text = "";
            // 
            // TextRecomendacionAlimentario
            // 
            this.TextRecomendacionAlimentario.Location = new System.Drawing.Point(427, 105);
            this.TextRecomendacionAlimentario.Name = "TextRecomendacionAlimentario";
            this.TextRecomendacionAlimentario.Size = new System.Drawing.Size(299, 222);
            this.TextRecomendacionAlimentario.TabIndex = 3;
            this.TextRecomendacionAlimentario.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(471, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recomendacion Alimentaria";
            // 
            // botonGuardarRecomendacion
            // 
            this.botonGuardarRecomendacion.Image = global::Presentacion.Properties.Resources.salvar;
            this.botonGuardarRecomendacion.Location = new System.Drawing.Point(661, 355);
            this.botonGuardarRecomendacion.Name = "botonGuardarRecomendacion";
            this.botonGuardarRecomendacion.Size = new System.Drawing.Size(65, 65);
            this.botonGuardarRecomendacion.TabIndex = 4;
            this.botonGuardarRecomendacion.TabStop = false;
            this.botonGuardarRecomendacion.Click += new System.EventHandler(this.botonGuardarRecomendacion_Click);
            // 
            // textIdentificacionRecomendacion
            // 
            this.textIdentificacionRecomendacion.Location = new System.Drawing.Point(70, 42);
            this.textIdentificacionRecomendacion.Name = "textIdentificacionRecomendacion";
            this.textIdentificacionRecomendacion.Size = new System.Drawing.Size(123, 20);
            this.textIdentificacionRecomendacion.TabIndex = 5;
            this.textIdentificacionRecomendacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdentificacionRecomendacion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(83, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(361, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paciente";
            // 
            // textNombrePaciente
            // 
            this.textNombrePaciente.Enabled = false;
            this.textNombrePaciente.Location = new System.Drawing.Point(297, 42);
            this.textNombrePaciente.Name = "textNombrePaciente";
            this.textNombrePaciente.Size = new System.Drawing.Size(197, 20);
            this.textNombrePaciente.TabIndex = 8;
            // 
            // botonBuscarPaciente
            // 
            this.botonBuscarPaciente.Location = new System.Drawing.Point(576, 40);
            this.botonBuscarPaciente.Name = "botonBuscarPaciente";
            this.botonBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.botonBuscarPaciente.TabIndex = 9;
            this.botonBuscarPaciente.Text = "Buscar";
            this.botonBuscarPaciente.UseVisualStyleBackColor = true;
            this.botonBuscarPaciente.Click += new System.EventHandler(this.botonBuscarPaciente_Click);
            // 
            // RecomendacionNutricional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContenedorRecomendacioNutricional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecomendacionNutricional";
            this.Text = "RecomendacionNutricional";
            this.ContenedorRecomendacioNutricional.ResumeLayout(false);
            this.ContenedorRecomendacioNutricional.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonGuardarRecomendacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContenedorRecomendacioNutricional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TextRecomendacionAlimentario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TextRecomendacionNutricional;
        private System.Windows.Forms.PictureBox botonGuardarRecomendacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdentificacionRecomendacion;
        private System.Windows.Forms.TextBox textNombrePaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonBuscarPaciente;
    }
}