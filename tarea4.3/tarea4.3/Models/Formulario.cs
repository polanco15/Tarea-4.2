using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace tarea4._3.Models
{
    public class Formulario
    {
        [Required(ErrorMessage = "La cedula es obligatoria")]
        public long  Cedula { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get; set; }
        [Range(16, 99)]
        public int Edad { get; set; }

        public long Telefono { get; set; }
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        public string Correo { get; set; }
        public string Genero { get; set; }
        public string Puesto { get; set; }
        public HttpPostedFileBase Foto { get; set; }
        public HttpPostedFileBase Curriculum { get; set; }
    }
    public enum Sexo
    {
        Masculino,
        Femenino
    }
    public enum puesto
    {
        Director_del_hotel,
        Asistente_director_general,
        Director_de_personal,
        Director_contabilidad,
        Director_Marketing,
        Director_ingenieria,
        Director_compras,
        Director_Restaurante,
        Jefe_Reservas,
        Jefe_eventos,
        Encagardas_Limpieza,
        Jefe_recepcion,
        Encargado_seguridad,
        Jefe_gimnasio,
        Jefe_servicio_Telefononico,
        Chef,
        Cocineros,
        Lavaplatos,
        Camareros,
        Musicos_Animadores

    }
}