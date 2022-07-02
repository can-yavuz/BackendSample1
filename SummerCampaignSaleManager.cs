using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend
{
    internal class SummerCampaignSaleManager : ISalesManager
    {
        public void Sale(Player player)
        {
            Console.WriteLine("Yaz kampanyalı satış yapıldı.");
        }
    }
}
