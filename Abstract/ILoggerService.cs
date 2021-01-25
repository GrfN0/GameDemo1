using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Abstract
{
    interface ILoggerService
    {
        void Add(IEntity person);
        void Update(IEntity person);
        void Delete(IEntity person);

    }
}
