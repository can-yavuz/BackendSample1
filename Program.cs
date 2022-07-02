using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend

{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Id = "12345678910";
            player1.Name = "Can";
            player1.Surname = "Yavuz";
            player1.Age = 21;

            Player player2 = new Player();
            player2.Id = "12345678910";
            player2.Name = "Sergio";
            player2.Surname = "Ramos";
            player2.Age = 36;

            PlayerManager playerManager = new PlayerManager();
            playerManager.UpdateSettings(player1);
            playerManager.SignUp(player2);
            playerManager.DeleteLogs(player1);

            Console.WriteLine("\t");
    

            ISalesManager saleManager = new SaleManager();
            ISalesManager campaignSaleManager = new CampaignSaleManager();
            ISalesManager summerCampaignSaleManager = new SummerCampaignSaleManager();

            saleManager.Sale(player1);
            campaignSaleManager.Sale(player2);
            summerCampaignSaleManager.Sale(player1);
        }
    }
}