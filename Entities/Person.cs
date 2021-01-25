using System;
using System.Collections.Generic;
using System.Text;
using GameDemo1.Abstract;

namespace GameDemo1.Entities
{
    class Person : IEntity

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public int DateOfBirth { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
