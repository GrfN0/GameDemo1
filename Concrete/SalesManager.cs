using System;
using System.Collections.Generic;
using System.Text;
using GameDemo1.Abstract;

namespace GameDemo1.Concrete
{
    class SalesManager : ISalesService

    {
        public void Discount()
        {
            Console.WriteLine("Kupon indirimi uygulandı.");
        }
    }
}
