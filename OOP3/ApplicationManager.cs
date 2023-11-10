using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void Apply(CreditManager cm, List<IloggerService> loggerServices)
        {
            cm.Calculate();

            foreach (var ls in loggerServices)
            {
                ls.Log();
            }
        }
        public void ProvideCreditInformation(List<CreditManager> loans)
        {
            foreach (var c in loans)
            {
                c.Calculate();
            }
        }
    }
}
