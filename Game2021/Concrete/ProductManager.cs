using System;
using System.Collections.Generic;
using System.Text;
using Game2021.Abstract;
using Game2021.Entities;

namespace Game2021.Concrete
{
    public class ProductManager :IProductService<User>
    {
        public void Sell(User user)
        {
            Console.WriteLine(user.FirstName+" Selled!");
        }

        public void Sell(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+"Salled");
        }
    }

}
