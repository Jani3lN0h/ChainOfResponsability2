using ChainOfResponsability2.Entities.Interfaces;
using System;

namespace ChainOfResponsability2.Services
{
    public class ManagerHandler : Handler
    {
        public override void ProcessPurchase(IPurchase compra)
        {
            if (compra.dAmount > 5000 && compra.dAmount <= 10000)
            {
                Console.WriteLine(string.Format("{0} \"AUTORIZADA\" por el Gerente.", compra.cConcept));
            }
            else
            {

                base.ProcessPurchase(compra);
            }
        }
    }
}