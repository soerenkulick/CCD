﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCD.Nback
{
    public interface IUiAdapter
    {
        void SetDataContext(object neuerContext);
    }
}
