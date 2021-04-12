using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstact
{
    interface ISalesService
    {
        void Add(Gamer gamer, Game game, Campaign campaign);
        void Update(Gamer gamer, Game game, Campaign campaign);
        void Delete(Gamer gamer, Game game, Campaign campaign);
    }
}
