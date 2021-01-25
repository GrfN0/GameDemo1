using System;
using System.Collections.Generic;
using System.Text;
using GameDemo1.Abstract;

namespace GameDemo1.Concrete
{
    class PlayerManager : IEntityService

    {
        private List<ILoggerService> lists;

        public PlayerManager(List<ILoggerService> lists)
        {
            this.lists = lists;
        }

        public void Add(IEntity person)
        {
            Console.WriteLine("Kullanıcı Eklendi.");
        }

        public void Delete(IEntity person)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(IEntity person)
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }
    }
}
