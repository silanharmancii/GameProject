﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Campaign:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
