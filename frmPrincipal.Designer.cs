namespace pryBlaiottaIE
{
    partial class frmPrincipal
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo3");
            this.ventanaCarpetas = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAbrirCarpetas = new System.Windows.Forms.Button();
            this.lblEjemplo = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnAbrirCarpetas
            // 
            this.btnAbrirCarpetas.Location = new System.Drawing.Point(104, 73);
            this.btnAbrirCarpetas.Name = "btnAbrirCarpetas";
            this.btnAbrirCarpetas.Size = new System.Drawing.Size(87, 23);
            this.btnAbrirCarpetas.TabIndex = 0;
            this.btnAbrirCarpetas.Text = "Abrir carpetas";
            this.btnAbrirCarpetas.UseVisualStyleBackColor = true;
            this.btnAbrirCarpetas.Click += new System.EventHandler(this.btnAbrirCarpetas_Click);
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Location = new System.Drawing.Point(111, 125);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(0, 13);
            this.lblEjemplo.TabIndex = 1;
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(104, 158);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoNombre.TabIndex = 2;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(104, 216);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(87, 23);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar Archivo";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(321, 60);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Nodo0";
            treeNode2.Name = "Nodo1";
            treeNode2.Text = "Nodo1";
            treeNode3.Name = "Nodo2";
            treeNode3.Text = "Nodo2";
            treeNode4.Name = "Nodo3";
            treeNode4.Text = "Nodo3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 354);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.btnAbrirCarpetas);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog ventanaCarpetas;
        private System.Windows.Forms.Button btnAbrirCarpetas;
        private System.Windows.Forms.Label lblEjemplo;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TreeView treeView1;
    }
}