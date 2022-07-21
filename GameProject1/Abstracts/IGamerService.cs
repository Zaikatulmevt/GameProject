using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Abstracts
{
     public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
