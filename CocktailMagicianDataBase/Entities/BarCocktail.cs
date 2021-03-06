﻿using CocktailMagician.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailMagician.Data.Entities
{
   public class BarCocktail :EntitiesDetails
    {
        public Guid Id { get; set; }
        public Guid BarId { get; set; }
        public Bar Bar { get; set; }
        public Guid CocktailId { get; set; }
        public Cocktail Cocktail { get; set; }
    }
}
