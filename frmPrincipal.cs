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
            PopulateTreeView();
        }
        
        class Program
        {
            static void ruta()
            {
                // Especifica la ruta del archivo que deseas leer
                string filePath = "C:\\Users\\Nico\\datosproveedores";

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

            DirectoryInfo info = new DirectoryInfo(Application.StartupPath);
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
            CargarDatosDesdeArchivo("C:\\Users\\Nico\\datosproveedores");
            TreeNode newSelected = e.Node;
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;

            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                Console.WriteLine($"{file.Name}");
                if (file.Name == "datosproveedores")
                {

                    CargarDatosDesdeArchivo(file.FullName);
                }
            }

         
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
                FileInfo[] fileInfos = subDir.GetFiles();
                foreach (FileInfo file in fileInfos)
                {
                    TreeNode fileNode = new TreeNode(file.Name, 1,1);
                    fileNode.Tag = file;
                    aNode.Nodes.Add(fileNode);
                }
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
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string leerLinea;
            string Archivo = Convert.ToString(treeView1.SelectedNode.FullPath);

                string[] pathParts = Archivo.Split('\\');
                string newPath = String.Join("\\", pathParts.Skip(1));
                CargarDatosDesdeArchivo(newPath);


            
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
                    int delimeter = 9;
            string[] columnas = reader.ReadLine().Split(Convert.ToChar(delimeter));

            // Agregar las columnas al DataTable
            foreach (string columna in columnas)
            {
                dataTable.Columns.Add(columna);
            }

            // Leer las filas de datos y agregarlas al DataTable
            while (!reader.EndOfStream)
            {
                string[] filaDatos = reader.ReadLine().Split(Convert.ToChar(delimeter));
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
            string rutaArchivo = "C:\\Users\\Nico\\datosproveedores";
            CargarDatosDesdeArchivo(rutaArchivo);
        }

    }
}