using ChainOfResponsability2.Entities.Interfaces;

namespace ChainOfResponsability2.Entities
{
    public class Purchase:IPurchase
    {
        public string cConcept { set; get; }
        public double dAmount { set; get; }

    }
}
