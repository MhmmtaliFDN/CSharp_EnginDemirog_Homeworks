using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Homework2
{
    class SaleManager
    {
        public void Sale(Player player, Game game, Campaign campaign = default)
        {
            if (campaign != default)
            {
                double Discount = game.Price - campaign.Discount;
                Console.WriteLine("Sayın " + player.FirstName + ", aldığınız oyun (" + game.Name + ") geçerli olan " + campaign.CampaignName + " kampanyası ile " +
                    game.Price + " TL'den " + Discount + " TL'ye düşmüştür.");
            }
            else
            {
                Console.WriteLine("Sayın " + player.FirstName + ", aldığınız oyunun (" + game.Name + ") fiyatı: " + game.Price + " TL'dir.");
            }
        }
    }
}
