using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService
    //bir clasın içinde başka bir class kullanılacaksa onu newleme
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Oyuncu eklendi");
            }
            else
            {
                Console.WriteLine("kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi");
        }
    }
}
