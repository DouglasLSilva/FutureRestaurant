using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu.API.Domain
{
    public class MenuItem
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

    }
}
