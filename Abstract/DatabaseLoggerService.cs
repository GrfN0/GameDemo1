using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Abstract
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add()
        {
            Console.WriteLine("Veritabanına eklendi.");
        }

        public void Add(IEntity person)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            Console.WriteLine("Veritabanından silindi.");
        }

        public void Delete(IEntity person)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Veritabanında güncellendi.");
        }

        public void Update(IEntity person)
        {
            throw new NotImplementedException();
        }
    }
}
