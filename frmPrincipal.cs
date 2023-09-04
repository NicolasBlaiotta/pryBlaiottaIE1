using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryBlaiottaIE
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirCarpetas_Click(object sender, EventArgs e)
        {
            ventanaCarpetas.ShowDialog();

            // como seleccionar carpeta
            lblEjemplo.Text = ventanaCarpetas.SelectedPath;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //para la ruta del archivo
            string ruta = lblEjemplo.Text;
            //nombre del archivo
            ruta += txtNuevoNombre.Text;

            StreamWriter manejoArchivo = new StreamWriter(ruta);

            MessageBox.Show("Archivo creado" + txtNuevoNombre.Text);
        }
    }
}
