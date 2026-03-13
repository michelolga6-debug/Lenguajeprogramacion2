using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Data.Entity;

namespace Practica_4
{
    public partial class Form1 : Form
    {
        // Tu conexión (asegúrate de que este nombre sea el que sale en tu App.config)
        Unidad1Entities db = new Unidad1Entities();

        // Declaramos los controles
        DataGridView dgvProductos = new DataGridView();
        ComboBox comboBoxCategorias = new ComboBox();
        Button btnMostrar = new Button();
        Button btnInsertar = new Button();
        Button btnEliminar = new Button();

        public Form1()
        {
            this.Text = "UFHEC - Práctica 4 (ORM)";
            this.Size = new Size(800, 500);
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            // Configurar Tabla
            dgvProductos.Location = new Point(20, 20);
            dgvProductos.Size = new Size(740, 250);
            this.Controls.Add(dgvProductos);

            // Configurar ComboBox (Requisito de la práctica)
            comboBoxCategorias.Location = new Point(20, 300);
            comboBoxCategorias.Width = 200;
            comboBoxCategorias.DataSource = db.Categorias.ToList();
            comboBoxCategorias.DisplayMember = "NombreCategoria";
            comboBoxCategorias.ValueMember = "CategoriaID";
            this.Controls.Add(comboBoxCategorias);

            // Botón Mostrar
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.Location = new Point(250, 300);
            btnMostrar.Click += (s, e) => { dgvProductos.DataSource = db.Productos.ToList(); };
            this.Controls.Add(btnMostrar);

            // Botón Insertar (Ejemplo rápido)
            btnInsertar.Text = "Insertar Nuevo";
            btnInsertar.Location = new Point(350, 300);
            btnInsertar.Click += btnInsertar_Click;
            this.Controls.Add(btnInsertar);

            // Botón Eliminar
            btnEliminar.Text = "Eliminar Seleccionado";
            btnEliminar.Location = new Point(450, 300);
            btnEliminar.Width = 150;
            btnEliminar.Click += btnEliminar_Click;
            this.Controls.Add(btnEliminar);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Insertar un producto de prueba usando el ID del ComboBox
            var p = new Productos
            {
                NombreProducto = "Producto Nuevo",
                Precio = 100,
                Stock = 10,
                CategoriaID = (int)comboBoxCategorias.SelectedValue
            };
            db.Productos.Add(p);
            db.SaveChanges();
            dgvProductos.DataSource = db.Productos.ToList();
            MessageBox.Show("¡Insertado usando ORM!");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int id = (int)dgvProductos.CurrentRow.Cells[0].Value;
                var p = db.Productos.Find(id);
                db.Productos.Remove(p);
                db.SaveChanges();
                dgvProductos.DataSource = db.Productos.ToList();
            }
        }
    }
}