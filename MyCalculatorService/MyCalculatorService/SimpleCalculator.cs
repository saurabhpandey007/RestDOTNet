﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorService
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class SimpleCalculator : ISimpleCalculator
    {
      public int Add(int num1, int num2)
      {
         return num1 + num2;
      }
    }
}
