using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject.Concrete
{

    class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckPlayerRealPerson(Player player)
        {
            if (player.NationalityId == "12345678910")
            {
                return true;
            }
            else
            {
                throw new Exception("Invalid User! please check your information! ");
            }
        }
    }
}
