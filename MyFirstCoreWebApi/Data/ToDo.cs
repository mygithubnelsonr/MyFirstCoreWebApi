﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstCoreWebApi.Data
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public bool IsDone { get; set; }
    }
}
