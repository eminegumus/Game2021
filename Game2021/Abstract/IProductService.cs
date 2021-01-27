using System;
using System.Collections.Generic;
using System.Text;
using Game2021.Entities;

namespace Game2021.Abstract
{
    public interface IProductService<T>
    {
        void Sell(T entitiy);
    }
}
