using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Abstract
{
    class FileLoggerService : ILoggerService
    {
        public void Add()
        {
            Console.WriteLine("Dosyaya eklendi.");
        }

        public void Add(IEntity person)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            Console.WriteLine("Dosyadan silindi.");
        }

        public void Delete(IEntity person)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Console.WriteLine("Dosyada güncellendi.");
        }

        public void Update(IEntity person)
        {
            throw new NotImplementedException();
        }
    }
}
