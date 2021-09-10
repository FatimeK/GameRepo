using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GameManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu sistemden silindi");
        }

        public void Register(Gamer gamer)
        {
            Console.WriteLine("Oyuncu başarıyla kaydedildi");
        }

        public void Update(Gamer gamer)
        {
            throw new NotImplementedException("Oyuncu bilgileri güncellendi");
        }

        public bool Validate(Gamer gamer)
        {
            
            
                //if gamer exist in e devlet db;
             return true;


            
        }
    }
}
