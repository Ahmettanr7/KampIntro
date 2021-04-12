using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstact;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void Add(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Ürün Fiyatı : " + game.GamePrice);
            Console.WriteLine("İndirimli Ürün Fiyatı : " + campaign.CampaignGo);
            Console.WriteLine("İndirim Tutarı : " + (game.GamePrice-campaign.CampaignGo));
            Console.WriteLine("'{0}' oyunu '{1}' Kullanıcısına '{2}' kampanyası ile {3} TL karşılığında  satıldı",
    game.GameName, gamer.FirstName, campaign.CampaignName, campaign.CampaignGo);

        }

        public void Delete(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Satış Silindi");
        }

        public void Update(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("Satış Güncellendi");
        }
    }
}
