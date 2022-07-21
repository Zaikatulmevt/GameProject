using GameProject1.Concrete;
using GameProject1.Entities;
using System;

namespace GameProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            CampaignManager campaignManager = new CampaignManager();

            Campaign campaign = new Campaign();
            campaign.CampaignName = "New Year Discount";
            campaign.DiscountRate = 37;
            campaign.Id = 1;


            Game game = new Game();
            game.GameName = "Call Of Duty";
            game.Id = 1;
            game.Price = 145;
            game.OccupiedBy = "46 GB";


            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Metehan Melih ";
            gamer.LastName = "Yapan";
            gamer.NationalityId = "53455377234";
            gamer.NickName = "Zaikatulmevt";
            gamer.DateOfBirth = new DateTime(2002,09,04);


        }
    }
}
