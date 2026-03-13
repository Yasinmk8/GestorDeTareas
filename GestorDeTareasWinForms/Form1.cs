using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorDeTareasWinForms
{
    public partial class Form1 : Form
    {
        private List<Tarea> tareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Trabajo");
            cmbCategoria.Items.Add("Personal");
            cmbCategoria.Items.Add("Estudios");
            cmbCategoria.SelectedIndex = 0;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debes introducir un nombre y una descripción.");
                return;
            }

            Tarea nuevaTarea = new Tarea
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                FechaVencimiento = dtpFecha.Value,
                Completada = false,
                PrioridadAlta = chkPrioridadAlta.Checked,
                Categoria = cmbCategoria.SelectedItem.ToString()
            };

            tareas.Add(nuevaTarea);
            ActualizarLista();
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.");
                return;
            }

            tareas.RemoveAt(lstTareas.SelectedIndex);
            ActualizarLista();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una tarea para marcarla como completada.");
                return;
            }

            tareas[lstTareas.SelectedIndex].Completada = true;
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstTareas.Items.Clear();

            foreach (Tarea tarea in tareas)
            {
                lstTareas.Items.Add(tarea);
            }

            ActualizarContador();
        }

        private void ActualizarContador()
        {
            lblContadorTareas.Text = "Total de tareas: " + tareas.Count;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            chkPrioridadAlta.Checked = false;
            cmbCategoria.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
        }

   

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnLimpiarCampos_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}