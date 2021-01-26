using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface SaleService
    {
        void Sale(Gamer gamer, Game game);
        void CampaignSale(Campaign campaign, Game game, Gamer gamer);
    }
}
