using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class RecipeDB
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Servings { get; set; }
        public virtual List<DirectionDB> Directions { get; set; } = new List<DirectionDB>();
    }
}