using GameProject1.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        
        
    }
}
