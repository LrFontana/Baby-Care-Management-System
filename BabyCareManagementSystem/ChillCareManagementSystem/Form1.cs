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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // CLick Event para la etiqueta "INGRESAR"
        private void BotonDeIngresar_Click(object sender, EventArgs e)
        {
            Subscripcion subscripcion = new Subscripcion();
            subscripcion.Show();
            this.Hide();
        }
    }
}
