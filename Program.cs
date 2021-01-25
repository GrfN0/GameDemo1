using System;
using System.Collections.Generic;
using GameDemo1.Abstract;
using GameDemo1.Concrete;
using GameDemo1.Entities;

namespace GameDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerService fileLogger = new FileLoggerService();
            ILoggerService databaseLogger = new DatabaseLoggerService();

            IEntityService playerManager = new PlayerManager(new List<ILoggerService> { databaseLogger, fileLogger });

            Person Samet = new Player() { FirstName = "Samet", LastName = "Yılmaz", DateOfBirth = 2000, NationalityId = "123456789" };

            playerManager.Add(Samet);

        }
    }
}
