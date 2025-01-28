using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informe3
{
    public partial class Form2 : Form
    {
        public ListPeliculas ListPeliculas { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dgvPersonasLetras.Visible = true;
            dgvPersonasLetras.DataSource = ListPeliculas.TituloEmpieza(txtCadena.Text);

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            string cadenaDirector = txtCadenaDireccion.Text;
            List<Peliculas> directorIgual = ListPeliculas.IgualDirector(cadenaDirector);
            dgvPersonasLetras.Visible = true;
            dgvPersonasLetras.DataSource = directorIgual;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            dgvPersonasLetras.Visible = true;
            List<Peliculas> AnioPar = ListPeliculas.AnioPar();
            dgvPersonasLetras.DataSource = AnioPar;
        }
    }



}