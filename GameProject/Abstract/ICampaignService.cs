﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Concrete;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
