using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBackend
{
    internal class PlayerManager
    {
        public void SignUp(Player player)
        {
            Console.WriteLine("Oyuncunun kaydı yapıldı.");
        }

        public void UpdateSettings(Player player)
        {
            Console.WriteLine("Oyuncunun kayıtları güncellendi.");
        }

        public void DeleteLogs(Player player)
        {
            Console.WriteLine("Oyuncunun logları silindi.");
        }

    }
}
