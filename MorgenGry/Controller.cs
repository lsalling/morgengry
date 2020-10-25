using System;
using System.Collections.Generic;
using System.Text;

namespace MorgenGry
{
    public class Controller
    {
        private ValuableRepository valuableRepo;

        public ValuableRepository Valuablerepo
        {
            get { return this.valuableRepo; }
        }

        public Controller()
        {
            this.valuableRepo = new ValuableRepository();
        }

        public void AddToList(IValuable valuable)
        {
            valuableRepo.AddValuable(valuable);
        }
    }
}
