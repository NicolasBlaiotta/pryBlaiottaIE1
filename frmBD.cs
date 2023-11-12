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
    public partial class frmBD : Form
    {
        public frmBD()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             void ruta()
            {
                // Especifica la ruta del archivo que deseas leer

                string filePath = "\\datosproveedores";


                // Declarar un objeto StreamReader
                StreamReader reader = null;

                try
                {
                    // Abre el archivo para lectura
                    reader = new StreamReader(filePath);

                    // Lee el contenido del archivo línea por línea
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line); // Imprime cada línea en la consola
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer el archivo: " + ex.Message);
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
        }
    }


}
