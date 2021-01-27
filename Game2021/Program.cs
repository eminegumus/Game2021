using System;
using Game2021.Concrete;
using Game2021.Entities;

namespace Game2021
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserCheckManager());
            ProductManager productManager=new ProductManager();
            CampaignManager campaignManager=new CampaignManager();
            User user = new User()
            {
                FirstName = "Emine",
                LastName = "Gümüşmadenoğlu",
                Id = 1,
                NationalityId = 17779046450,
                YearOfBirth = 1986
            };

            Campaign campaign = new Campaign()
            {
                CampaignName = "Yılbaşı Fırsatı",
                DiscountRate = 15,
                Id = 1
            };



            userManager.Save(user);
            userManager.Update(user);
            userManager.Delete(user);

            campaignManager.Save(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Console.ReadLine();
        }

    }
}
