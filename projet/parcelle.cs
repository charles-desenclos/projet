using System;
using System.Collections.Generic;
using System.Text;

namespace projet
{
    class parcelle
    {
        int parcelles;
        public parcelle (int P )
        {
            parcelles = P;
            if (parcelles > 4)
            {
                Console.WriteLine("Parcelle a : {0} unites", parcelles);
            }
        }
    }
}
