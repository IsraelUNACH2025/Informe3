namespace Informe3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.dgvPersonasLetras = new System.Windows.Forms.DataGridView();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCadenaDireccion = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasLetras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Inicial del Titulo:";
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(297, 28);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCadena.TabIndex = 1;
            // 
            // dgvPersonasLetras
            // 
            this.dgvPersonasLetras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonasLetras.Location = new System.Drawing.Point(158, 197);
            this.dgvPersonasLetras.Name = "dgvPersonasLetras";
            this.dgvPersonasLetras.Size = new System.Drawing.Size(410, 132);
            this.dgvPersonasLetras.TabIndex = 2;
            this.dgvPersonasLetras.Visible = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(467, 28);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar Director:";
            // 
            // txtCadenaDireccion
            // 
            this.txtCadenaDireccion.Location = new System.Drawing.Point(297, 77);
            this.txtCadenaDireccion.Name = "txtCadenaDireccion";
            this.txtCadenaDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtCadenaDireccion.TabIndex = 5;
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(467, 78);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(75, 23);
            this.btnComprobar.TabIndex = 6;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar Peliculas con su año par:";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(467, 127);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 359);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.txtCadenaDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dgvPersonasLetras);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonasLetras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.DataGridView dgvPersonasLetras;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCadenaDireccion;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAbrir;
    }
}