using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalC_
{
    public partial class FormListas : Form
    {
        private Nodo cabeza;  // Referencia al primer nodo de la lista enlazada

        public FormListas()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string nuevaTarea = txtNuevaTarea.Text;
            if (!string.IsNullOrWhiteSpace(nuevaTarea))
            {
                // Agrega la tarea a la lista enlazada
                AgregarTarea(nuevaTarea);

                // Actualiza el ListBox con la lista actualizada de tareas
                ActualizarListBoxTareas();

                txtNuevaTarea.Clear();
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (listBoxTareas.SelectedIndex != -1)
            {
                // Elimina la tarea de la lista enlazada
                EliminarTarea(listBoxTareas.SelectedIndex);

                // Actualiza el ListBox con la lista actualizada de tareas
                ActualizarListBoxTareas();
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            // Limpia la lista de tareas
            cabeza = null;

            // Actualiza el ListBox con la lista vacía de tareas
            ActualizarListBoxTareas();
        }

        private void AgregarTarea(string valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            nuevoNodo.Siguiente = cabeza;
            cabeza = nuevoNodo;
        }

        private void EliminarTarea(int indice)
        {
            if (cabeza == null)
                return;

            if (indice == 0)
            {
                cabeza = cabeza.Siguiente;
            }
            else
            {
                Nodo actual = cabeza;
                for (int i = 0; i < indice - 1 && actual.Siguiente != null; i++)
                {
                    actual = actual.Siguiente;
                }

                if (actual.Siguiente != null)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                }
            }
        }

        private void ActualizarListBoxTareas()
        {
            listBoxTareas.Items.Clear();

            Nodo actual = cabeza;
            while (actual != null)
            {
                listBoxTareas.Items.Add(actual.Valor);
                actual = actual.Siguiente;
            }
        }
        public class Nodo
        {
            public string Valor { get; set; }
            public Nodo Siguiente { get; set; }

            public Nodo(string valor)
            {
                Valor = valor;
                Siguiente = null;
            }
        }
    }
}
