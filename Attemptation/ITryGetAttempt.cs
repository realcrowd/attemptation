﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attemptation
{
    public interface ITryGetAttempt : ITryAttempt
    {
        object Result { get; set; }
    }
}
