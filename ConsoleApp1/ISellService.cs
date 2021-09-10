using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface ISellService
    {
        void Sell(Game game, Gamer gamer);
        void ApplyCampain(Game game, Gamer gamer,Campaign campaign);
    }
}
