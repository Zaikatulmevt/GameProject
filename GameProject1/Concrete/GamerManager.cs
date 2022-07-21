using GameProject1.Abstracts;
using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.NickName + " isimli oyuncu oyuna eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.NickName + " isimli oyuncu oyundan silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.NickName + " isimli oyuncu güncellendi");
        }
    }
}
