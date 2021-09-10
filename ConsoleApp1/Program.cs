using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game SeaOfThieves = new Game() { GameName = "SeaOfThieves", Price = 60, Id = 1 };
            Game RedDeadRedemption = new Game { GameName = "RedDeadRedemption", Price = 60, Id = 2 };
            Game Varolant = new Game { GameName = "Varolant", Price = 60, Id = 3 };
            Game Ark = new Game { GameName = "Ark", Price = 60, Id = 4 };
            List<Game> games = new List<Game> { SeaOfThieves, RedDeadRedemption, Ark, Varolant };

            Gamer gamer1 = new Gamer { Id = 0, Name = "X", Surname = "KARA", RepublicNumber = "12345678912", BirthYear = "2000" };
            Gamer gamer2 = new Gamer { Id = 0, Name = "Y", Surname = "ARAS", RepublicNumber = "12345645452", BirthYear = "2000" };
            List<Gamer> gamers = new List<Gamer>();
            gamers.Add(gamer1);
            gamers.Add(gamer2);

            Campaign campaign = new Campaign() { Id = 0, CampaignName = "Summer Campaing", CampaingTime = 1 };

            IGamerService gamerService = new GameManager();
            ISellService sellService = new SellManager();

            if(gamerService.Validate(gamer1) == true)
            {
                gamerService.Register(gamer1);
                sellService.ApplyCampain(SeaOfThieves, gamer1, campaign);
            }
            
            
        }

        
        
    }
}
