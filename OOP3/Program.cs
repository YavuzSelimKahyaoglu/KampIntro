using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager demandCreditManager = new DemandCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager houseCreditManager = new HouseCreditManager();
            ICreditManager artisanCreditManager = new ArtisanCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService> {smsLoggerService,fileLoggerService,databaseLoggerService };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(artisanCreditManager,loggerServices);

            List<ICreditManager> credits = new List<ICreditManager> { demandCreditManager,houseCreditManager,transportCreditManager};

            //applicationManager.DoCreditPreinformation(credits);
        }
    }
}
