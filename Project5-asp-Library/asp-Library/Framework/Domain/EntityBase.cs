﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Domain
{
    public class EntityBase
    {
        public long id { get; set; }

        public DateTime CreateionDate { get; set; }

        public EntityBase()
        {
            CreateionDate = DateTime.Now;
        }
    }
}
