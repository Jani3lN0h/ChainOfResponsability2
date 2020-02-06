using ChainOfResponsability2.Services.Interfaces;

namespace ChainOfResponsability2.Services
{
    public class Client
    {
        public IHandler ConfigurarAutorizadoresCompra()
        {
            var handlerCoordinador = new CoordinatorHandler();
            var handlerManager = new ManagerHandler();
            var handlerSubdirector = new SubDirectorHandler();
            var handlerDirector = new DirectorHandler();

            handlerCoordinador.setNext(handlerManager).setNext(handlerSubdirector).setNext(handlerDirector);
            return handlerCoordinador;
        }
    }
}
