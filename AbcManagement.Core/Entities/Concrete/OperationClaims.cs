﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcManagement.Core.Entities.Concrete
{
    public class OperationClaims:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
