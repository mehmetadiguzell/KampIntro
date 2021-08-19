using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidateManager());
            gamerManager.Add(new Gamer
            {
               BirthYear=1985,
               FirstName="Ali", 
               LastName="Serdar", 
               IdentityNumber=12345
            });
        }
    }
}
