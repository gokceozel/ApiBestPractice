﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBestPractice.Core.Utilities.Results
{
    public interface IResult
    {  
        bool Success { get; }
        string Message { get; }
    }
}
