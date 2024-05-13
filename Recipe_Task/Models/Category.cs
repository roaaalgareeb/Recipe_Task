using System;
using System.Collections.Generic;

namespace Recipe_Task.Models;

public partial class Category
{
    public decimal CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
