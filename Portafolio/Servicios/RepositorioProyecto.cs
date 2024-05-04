using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyecto: IRepositorioProyectos
    {

      
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto()
            {
                Titulo = "Metodo Consultores",
                Descripcion = "Desarrollador Full-Stack para el Sistema Web de la Empresa, Implementado en Laravel.",
                Link = "https://www.metodoconsultores.cl",
                ImagenUrl = "/imagenes/Metodo.png",
            },
                new Proyecto()
            {
                Titulo = "Coasin Logicalis",
                Descripcion = "Soporte Tecnico Terreno N1, Encargargado de los equipos tecnologicos de Codelco division RT.",
                Link = "https://www.codelco.com/",
                ImagenUrl = "/Imagenes/Codelco-RT.png",
            },
                new Proyecto()
            {
                Titulo = "Vantaz Group",
                Descripcion = "Consultor Junior en Proyectos Tecnológicos para la Minera BHP.",
                Link = "https://vantaz.com/",
                ImagenUrl = "/Imagenes/Vantaz.png",
            },
                new Proyecto()
            {
                Titulo = "PcFactory",
                Descripcion = "Soporte Técnico a Medio Tiempo, Responsable de la Revisión y Reparación de Productos Adquiridos en la Tienda.",
                Link = "https://www.pcfactory.cl/",
                ImagenUrl = "/Imagenes/pcFactory.png",
            }

            };
        }
    }


}
