using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Abstracts
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void Upgrade(Game game);


    }
}
