using GameProject1.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public string OccupiedBy { get; set; }

    }
}
