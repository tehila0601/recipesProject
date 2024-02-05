﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class Measure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ingredient> IngredientsLst { get; set; }

    }
}
