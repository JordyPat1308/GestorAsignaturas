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
using System.Data.Entity;
using GestorAsignaturas.Models;


namespace GestorAsignaturas.DAL
{
    public class GestorData : DbContext
    {
        public DbSet<Asignatura> Asignaturas { get; set; }

    }
}