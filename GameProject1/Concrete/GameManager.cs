using GameProject1.Abstracts;
using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli oyun güncellendi");
        }

        public void Upgrade(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli oyun yükseltildi");
        }
    }
}
