using GameProject1.Abstracts;
using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
