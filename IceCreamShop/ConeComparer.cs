﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            double diff = x.Cost - y.Cost;
            if (diff == 0)
            {
                return 0;
            }
            if (diff < 0)
            {
                return -1;
            }
            return 1;
            
            
            
        }
    }
}
