﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Straight.Core
{
    public interface IIdentifiable
    {
        Guid Id { get; }
    }
}
