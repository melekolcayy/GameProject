using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void SaleGame(Game game, Player player, Campaign campaign);

    }
}
