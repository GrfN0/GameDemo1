using System;
using System.Collections.Generic;
using System.Text;
using GameDemo1.Abstract;

namespace GameDemo1.Concrete
{
    class PlatformManager : IPlatformService
    {
        public void BuyGame()
        {
            Console.WriteLine("Sepetteki ürün alındı.");
        }

        public void TradeGame()
        {
            Console.WriteLine("Takas isteği gönderildi.");
        }
    }
}
