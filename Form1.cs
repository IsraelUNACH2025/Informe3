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
    public partial class Form1 : Form
    {
        ListPeliculas listPeliculas = new ListPeliculas();
        public Form1()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Peliculas pelicula = new Peliculas();
            pelicula.Titulo = txtTitulos.Text;
            pelicula.AnioEstreno = Convert.ToInt32(mtxtanioPublicacion.Text);
            pelicula.Director = txtDirector.Text;
            listPeliculas.Agregar(pelicula);
            MessageBox.Show("Datos Guardados");
            Limpiar();


        }


        public void Limpiar()
        {
            txtDirector.Text = "";
            txtTitulos.Text = "";
            mtxtanioPublicacion.Text = "";
        }


        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ListPeliculas=listPeliculas;
            form2.Show();
        }

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = listPeliculas.Lista;
        }

       
    }
}

