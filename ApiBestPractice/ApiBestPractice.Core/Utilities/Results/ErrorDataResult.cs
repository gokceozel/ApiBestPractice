﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.Core.Utilities.Results
{
   public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,bool success,string message):base(data,false,message)
        {

        }
        public ErrorDataResult(T data,bool success):base(data,false)
        {

        }
    }
}