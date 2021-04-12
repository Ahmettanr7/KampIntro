using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {


       public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "AHMET" && gamer.LastName == "TANRIKULU"
                && gamer.IdentityNumber == 12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
