using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Abstracts
{
    public interface ISellService
    {
        void Sell(Game game, Gamer gamer);
    }
}
