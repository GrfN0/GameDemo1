using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo1.Abstract
{
    interface IEntityService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);
    }
}
