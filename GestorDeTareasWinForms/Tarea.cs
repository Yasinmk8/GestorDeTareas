using System;
using System.Collections.Generic;

namespace GestorDeTareasWinForms
{
    // Esta clase representa una tarea
    public class Tarea
    {
        // Guarda el nombre de la tarea
        public string Nombre { get; set; }

        // Guarda la descripción de la tarea
        public string Descripcion { get; set; }

        // Guarda la fecha de vencimiento
        public DateTime FechaVencimiento { get; set; }

        // Indica si la tarea está completada o no
        public bool Completada { get; set; }

        public bool PrioridadAlta { get; set; }
        public string Categoria { get; set; }

        public List<string> Etiquetas { get; set; } = new List<string>();

        // Devuelve el texto que se mostrará en la lista
        public override string ToString()
        {
            string estado = Completada ? "Completada" : "Pendiente";
            string prioridad = PrioridadAlta ? "Alta" : "Normal";
            return $"{Nombre} | {Categoria} | {prioridad} | {FechaVencimiento.ToShortDateString()} | {estado}";
        }
    }
}