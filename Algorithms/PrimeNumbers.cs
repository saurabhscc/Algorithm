﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class PrimeNumbers
    {
        int flag = 0;
        public void FindPrimeNumber()
        {
            //traverse 
            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    if (i % j == 0)
                    {
                        flag++;
                    }
                }
                if (flag == 2)
                {
                    Console.WriteLine(i + " ");
                }
                flag = 0;
            }
        }
    }
}
