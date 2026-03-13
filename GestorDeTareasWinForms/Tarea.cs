using System;

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

        // Devuelve el texto que se mostrará en la lista
        public bool PrioridadAlta { get; set; }
        public string Categoria { get; set; }
        public override string ToString()
        {
            string estado = Completada ? "Completada" : "Pendiente";
            string prioridad = PrioridadAlta ? "Alta" : "Normal";
            return $"{Nombre} | {Categoria} | {prioridad} | {FechaVencimiento.ToShortDateString()} | {estado}";
        }
    }
}