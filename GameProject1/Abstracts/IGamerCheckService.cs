using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Abstracts
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
