﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealGetter.Lib.Interfaces
{
    public interface IStudent
    {
        int StudentId { get;  }

        IStudentInfo CurrentStudentInfo { get; }


    }
}
