﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Drafter.Models
{
    interface IMultiPartModel
    {
        int PartNumber { get; set; }
        string PartNumberString { get; }
    }
}
