﻿using DataLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface IOptimizePackaging
    {
        List<IUnitOfMeasure> Optimize(int numberOfUnits);
    }
}
