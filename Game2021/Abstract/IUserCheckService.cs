using System;
using System.Collections.Generic;
using System.Text;
using Game2021.Entities;
using MernisService;

namespace Game2021.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user)
        {
            //MernisService.KPSPublicSoapClient client = new KPSPublicSoapClient();
            //client.TCKimlikNoDogrulaAsync(user.NationalityId, user.FirstName.ToUpper(), user.LastName.ToUpper(), user.YearOfBirth);
            return true;
        }
    }
}
