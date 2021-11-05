
namespace Presentacion
{
    partial class RegistarAlimentos
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
            this.ContenedorRegistarAlimentos = new System.Windows.Forms.Panel();
            this.botonGuardarAlimentos = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textAlimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCalorias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCarbohidratos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textProteinas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textLiquidos = new System.Windows.Forms.TextBox();
            this.ContenedorRegistarAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonGuardarAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContenedorRegistarAlimentos
            // 
            this.ContenedorRegistarAlimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(195)))));
            this.ContenedorRegistarAlimentos.Controls.Add(this.label5);
            this.ContenedorRegistarAlimentos.Controls.Add(this.textLiquidos);
            this.ContenedorRegistarAlimentos.Controls.Add(this.label4);
            this.ContenedorRegistarAlimentos.Controls.Add(this.textProteinas);
            this.ContenedorRegistarAlimentos.Controls.Add(this.label3);
            this.ContenedorRegistarAlimentos.Controls.Add(this.textCarbohidratos);
            this.ContenedorRegistarAlimentos.Controls.Add(this.label2);
            this.ContenedorRegistarAlimentos.Controls.Add(this.textCalorias);
            this.ContenedorRegistarAlimentos.Controls.Add(this.label1);
            this.ContenedorRegistarAlimentos.Controls.Add(this.textAlimento);
            this.ContenedorRegistarAlimentos.Controls.Add(this.dataGridView1);
            this.ContenedorRegistarAlimentos.Controls.Add(this.botonGuardarAlimentos);
            this.ContenedorRegistarAlimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorRegistarAlimentos.Location = new System.Drawing.Point(0, 0);
            this.ContenedorRegistarAlimentos.Name = "ContenedorRegistarAlimentos";
            this.ContenedorRegistarAlimentos.Size = new System.Drawing.Size(800, 450);
            this.ContenedorRegistarAlimentos.TabIndex = 0;
            // 
            // botonGuardarAlimentos
            // 
            this.botonGuardarAlimentos.Image = global::Presentacion.Properties.Resources.salvar;
            this.botonGuardarAlimentos.Location = new System.Drawing.Point(365, 125);
            this.botonGuardarAlimentos.Name = "botonGuardarAlimentos";
            this.botonGuardarAlimentos.Size = new System.Drawing.Size(65, 65);
            this.botonGuardarAlimentos.TabIndex = 0;
            this.botonGuardarAlimentos.TabStop = false;
            this.botonGuardarAlimentos.Click += new System.EventHandler(this.botonGuardarAlimentos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 181);
            this.dataGridView1.TabIndex = 1;
            // 
            // textAlimento
            // 
            this.textAlimento.Location = new System.Drawing.Point(71, 64);
            this.textAlimento.Name = "textAlimento";
            this.textAlimento.Size = new System.Drawing.Size(125, 20);
            this.textAlimento.TabIndex = 2;
            this.textAlimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAlimento_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Alimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calorias";
            // 
            // textCalorias
            // 
            this.textCalorias.Location = new System.Drawing.Point(71, 120);
            this.textCalorias.Name = "textCalorias";
            this.textCalorias.Size = new System.Drawing.Size(60, 20);
            this.textCalorias.TabIndex = 4;
            this.textCalorias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCalorias_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(67, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Carbohidratos";
            // 
            // textCarbohidratos
            // 
            this.textCarbohidratos.Location = new System.Drawing.Point(71, 170);
            this.textCarbohidratos.Name = "textCarbohidratos";
            this.textCarbohidratos.Size = new System.Drawing.Size(60, 20);
            this.textCarbohidratos.TabIndex = 6;
            this.textCarbohidratos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCarbohidratos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(200, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Proteinas";
            // 
            // textProteinas
            // 
            this.textProteinas.Location = new System.Drawing.Point(204, 120);
            this.textProteinas.Name = "textProteinas";
            this.textProteinas.Size = new System.Drawing.Size(60, 20);
            this.textProteinas.TabIndex = 8;
            this.textProteinas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textProteinas_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(200, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Liquidos";
            // 
            // textLiquidos
            // 
            this.textLiquidos.Location = new System.Drawing.Point(204, 170);
            this.textLiquidos.Name = "textLiquidos";
            this.textLiquidos.Size = new System.Drawing.Size(60, 20);
            this.textLiquidos.TabIndex = 10;
            this.textLiquidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLiquidos_KeyPress);
            // 
            // RegistarAlimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContenedorRegistarAlimentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistarAlimentos";
            this.Text = "RegistarAlimentos";
            this.ContenedorRegistarAlimentos.ResumeLayout(false);
            this.ContenedorRegistarAlimentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.botonGuardarAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContenedorRegistarAlimentos;
        private System.Windows.Forms.PictureBox botonGuardarAlimentos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textLiquidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textProteinas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCarbohidratos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCalorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAlimento;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}