using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChillCareManagementSystem
{
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
        }

        //Click event para la etiqueta "BEBES".
        private void label8_Click(object sender, EventArgs e)
        {
            Bebes bebes = new Bebes();
            bebes.Show();
            this.Hide();
        }

        //Click event para la etiqueta "PADRES".
        private void label10_Click(object sender, EventArgs e)
        {
            Padres padres = new Padres();
            padres.Show();
            this.Hide();
        }

        //Click event para la etiqueta "COMIDAS".
        private void label12_Click(object sender, EventArgs e)
        {
            Comidas comidas = new Comidas();
            comidas.Show();
            this.Hide();
        }

        //Click event para la etiqueta "SUBSCRIPCIONES".
        private void label13_Click(object sender, EventArgs e)
        {
            Subscripcion subscripcion = new Subscripcion();
            subscripcion.Show();
            this.Hide();
        }

        //Click event para la etiqueta "CERRAR SESION".
        private void label9_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
