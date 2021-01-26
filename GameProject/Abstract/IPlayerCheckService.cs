using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Concrete;

namespace GameProject.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckPlayerRealPerson(Player player);
    }
}
