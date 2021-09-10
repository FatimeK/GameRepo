using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SellManager : ISellService
    {
        public void ApplyCampain(Game game, Gamer gamer,Campaign campaign)
        {
            Console.WriteLine(gamer.Name + " oyuncusu " + game.GameName + " oyununu satın aldı ve " +campaign.CampaignName + " adlı kampanyadan faydalandı");
        }

        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " oyuncusu "+game.GameName +"oyununu satın aldı");
        }
    }
}
