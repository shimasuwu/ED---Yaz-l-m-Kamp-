using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICrediManager personalFinanceCredit = new PersonalFinanceCredit();
            ApplicationManager applicationManager = new ApplicationManager();
            IloggerService databaseLoggerService = new DBLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();


        }
    }
}
