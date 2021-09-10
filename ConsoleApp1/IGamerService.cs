using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IGamerService
    {
        void Register(Gamer gamer);
        void Update(Gamer gamer);

        void Delete(Gamer gamer);

        bool Validate(Gamer gamer);

    }
}
