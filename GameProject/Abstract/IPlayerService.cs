using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Concrete;

namespace GameProject.Abstract
{
   public interface IPlayerService
    {
        void Save(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
