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
        class Program
        {
            static void ruta()
            {
                // Especifica la ruta del archivo que deseas leer
                string filePath = "C:\\Proveedores";

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
                    // Asegúrate de cerrar el StreamReader cuando hayas terminado con él
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        void treeView1_NodeMouseClick(object sender,
    TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void GetDirectories(DirectoryInfo[] subDirs,
            TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void btnAbrirCarpetas_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void ventanaCarpetas_HelpRequest(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarDatosDesdeArchivo(string rutaArchivo)
{
    try
    {
        // Crear un DataTable para almacenar los datos
        DataTable dataTable = new DataTable();

        // Leer el archivo CSV
        using (StreamReader reader = new StreamReader(rutaArchivo))
        {
            string[] columnas = reader.ReadLine().Split(',');

            // Agregar las columnas al DataTable
            foreach (string columna in columnas)
            {
                dataTable.Columns.Add(columna);
            }

            // Leer las filas de datos y agregarlas al DataTable
            while (!reader.EndOfStream)
            {
                string[] filaDatos = reader.ReadLine().Split(',');
                dataTable.Rows.Add(filaDatos);
            }
        }

        // Asignar el DataTable como origen de datos del DataGridView
        dataGridView1.DataSource = dataTable;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "C:\\Proveedores";
            CargarDatosDesdeArchivo(rutaArchivo);
        }

    }
}