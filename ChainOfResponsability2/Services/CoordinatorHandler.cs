using ChainOfResponsability2.Entities.Interfaces;
using System;

namespace ChainOfResponsability2.Services
{
    public class CoordinatorHandler : Handler
    {
        public override void ProcessPurchase(IPurchase compra)
        {
            if (compra.dAmount <= 5000)
            {
                Console.WriteLine(string.Format("{0} \"AUTORIZADA\" por el Coordinador.", compra.cConcept));
            }
            else
            {
                base.ProcessPurchase(compra);
            }
        }
    }
}
