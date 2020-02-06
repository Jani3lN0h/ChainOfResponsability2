using ChainOfResponsability2.Entities.Interfaces;
using System;

namespace ChainOfResponsability2.Services
{
    public class DirectorHandler:Handler
    {
        public override void ProcessPurchase(IPurchase compra)
        {
            if (compra.dAmount > 15000 && compra.dAmount <= 50000)
            {
                Console.WriteLine(string.Format("{0} \"AUTORIZADA\" por el Director.", compra.cConcept));
            }
            else
            {
                Console.WriteLine(string.Format("{0} \"DENEGADA\".", compra.cConcept));
            }
        }
    }
}
