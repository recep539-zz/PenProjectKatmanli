﻿using Pen.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pen.UI.Models
{
    public class CoverTypeModel
    {
        public Covertype covertype { get; set; }
        public string? Title { get; set; }
        public string? BtnClass { get; set; }
        public string? BtnVal { get; set; }
    }
}
