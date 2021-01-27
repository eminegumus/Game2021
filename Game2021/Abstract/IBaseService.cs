using System;
using System.Collections.Generic;
using System.Text;
using Game2021.Entities;

namespace Game2021.Abstract
{
   public interface IBaseService<T>
   {
        void Save(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
   }
}
