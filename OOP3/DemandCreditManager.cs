using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DemandCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi Hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
