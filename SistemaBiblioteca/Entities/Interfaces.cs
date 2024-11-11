using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Entities
{
    public class Interfaces
    {
        public interface ILibro
        {
          
            
              
            
        }
    }
    public interface IUsuario
    {
        public void AggUsuario();



        public void ModificarUsuario();


        public void EliminarUsuario();


        public void ObtenerUsuario();


        public void ObtenerUsuarioId();
        
        
    }
    public interface IPrestamo
    {
        public void RegistrarPrestamo();


        public void RegistrarDevoluciones();


        public void ObtenerPrestamoPorUsuario();

        public void ObtenerTodosLosPrestamos();
        
    }
}
