
// *****************************************************************
// Practica 09
// Integrantes: Jordy Mayorga, Joel Leon
// Fecha de realización: 11/12/2024
// Fecha de entrega: 18/12/2024
// Resultados: 
// * La práctica de ASP.NET MVC permitió desarrollar una aplicación funcional para la gestión de asignaturas, 
//   implementando operaciones CRUD (Crear, Leer, Actualizar y Eliminar) de forma eficiente. Se añadieron 
//   validaciones en los modelos para garantizar la integridad de los datos, controladores para manejar la 
//   lógica de negocio, y vistas personalizadas para la interacción con el usuario. Además, se integró 
//   Entity Framework para la gestión de la base de datos, logrando una aplicación organizada, modular y 
//   preparada para futuros requerimientos o escalabilidad. 
// Conclusiones: 
// * Se puede concluir que, la implementación de ASP.NET MVC permite estructurar aplicaciones web de forma 
//   organizada y modular, separando las responsabilidades entre Modelos, Vistas y Controladores. Esto facilita 
//   el mantenimiento del código, la reutilización de componentes y la escalabilidad del proyecto.
// * En conclusión, el uso de Entity Framework proporciona una forma eficiente de gestionar la interacción con 
//   bases de datos, permitiendo realizar operaciones CRUD y migraciones de manera sencilla. Esto mejora la 
//   productividad y reduce el tiempo necesario para implementar cambios en los modelos de datos. 
// Recomendaciones: 
// * Se recomienda, implementar validaciones exhaustivas tanto en el modelo como en el controlador para 
//   garantizar la integridad de los datos. Además, realizar pruebas funcionales completas para verificar 
//   el correcto comportamiento de todas las funcionalidades, especialmente en los escenarios de error.
// * Es recomendable, personalizar las vistas y mensajes de validación para ofrecer una interfaz más amigable 
//   e intuitiva al usuario final. Utilizar hojas de estilo (CSS) y frameworks de diseño como Bootstrap puede 
//   mejorar significativamente la apariencia y usabilidad de la aplicación.
// *****************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace GestorAsignaturas.Models
{
    public class Asignatura
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la asignatura es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre de la asingnatura no puede superar los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El codigo de la asignatura es obligatorio.")]
        [StringLength(7, ErrorMessage = "El codigo de la asingnatura no puede superar los 7 caracteres.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El número de créditos de la  es obligatorio.")]
        [Range(0, 15, ErrorMessage = "El número de créditos debe estar entre 0 y 15.")]
        public int Creditos { get; set; }

        [Required(ErrorMessage = "El componente CD es obligatorio.")]
        [Range(1, 45, ErrorMessage = "El componente CD debe estar entre 1 y 45.")]
        public int CD { get; set; } // Componente de Clase Directa

        [Range(0, 45, ErrorMessage = "El componente CP debe estar entre 0 y 45.")]
        public int CP { get; set; } // Componente de Clase Práctica (puede ser 0)

        [Required(ErrorMessage = "El componente AA es obligatorio.")]
        [Range(1, 45, ErrorMessage = "El componente AA debe estar entre 1 y 45.")]
        public int AA { get; set; } // Componente de Autoaprendizaje

        // Propiedad calculada para las horas totales
        public int Horas
        {
            get
            {
                return CD + CP + AA;
            }
        }

    }
}
