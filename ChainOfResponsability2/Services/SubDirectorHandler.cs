using ChainOfResponsability2.Entities.Interfaces;
using System;

namespace ChainOfResponsability2.Services
{
    public class SubDirectorHandler:Handler
    {
        public override void ProcessPurchase(IPurchase compra)
        {
            if (compra.dAmount > 10000 && compra.dAmount <= 15000)
            {
                Console.WriteLine(string.Format("{0} \"AUTORIZADA\" por el Subdirector.", compra.cConcept));
            }
            else
            {
                base.ProcessPurchase(compra);
            }
        }
    }
}
