using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Application=Başvuru
    class ApplicationManager
    {
        //Method Injection
        public void DoApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            //Başvuran Bilgilerini Değerlendirme
            //
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void DoCreditPreinformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
