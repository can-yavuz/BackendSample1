using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend
{
    internal class CampaignSaleManager : ISalesManager
    {
        public void Sale(Player player)
        {
            Console.WriteLine("Oyuncuya kampanyalı satış yapıldı.");
        }
    }
}
