using ChainOfResponsability2.Entities.Interfaces;

namespace ChainOfResponsability2.Services.Interfaces
{
    public interface IHandler
    {
        IHandler setNext(IHandler handler);
        void ProcessPurchase(IPurchase compra);
    }
}
