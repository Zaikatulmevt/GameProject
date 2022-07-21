using GameProject1.Abstracts;
using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Concrete
{
    public class SellManager : ISellService
    {
        public SellManager()
        {

        }

        private Campaign _campaign;
        public SellManager(Campaign campaign)
        {
            _campaign = campaign;
        }


        public void Sell(Game game, Gamer gamer)
        {
            if (_campaign==null)
            {
                Console.WriteLine($"{game.GameName} isimli oyuncuya belirlenen fiyattan ({game.Price}) satılmıştır.");
            }
            else
            {
                Console.WriteLine($"{game.GameName} isimli oyuna {_campaign.DiscountRate} oranında indirim uygulanmıştır");
            }
        }
    }
}
