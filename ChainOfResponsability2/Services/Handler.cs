using ChainOfResponsability2.Entities.Interfaces;
using ChainOfResponsability2.Services.Interfaces;

namespace ChainOfResponsability2.Services
{
    public abstract class Handler : IHandler
    {
        private IHandler nextHandler;

        public virtual void ProcessPurchase(IPurchase compra)
        {
            if (nextHandler != null)
            {
                nextHandler.ProcessPurchase(compra);
            }
        }

        public IHandler setNext(IHandler handler)
        {
            nextHandler = handler;
            
            return nextHandler;
        }
    }
}
