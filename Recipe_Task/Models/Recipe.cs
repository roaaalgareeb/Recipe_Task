using System;
using System.Collections.Generic;

namespace Recipe_Task.Models;

public partial class Recipe
{
    public decimal RecipeId { get; set; }

    public string? RecipeName { get; set; }

    public string? Ingredients { get; set; }

    public string? Instructions { get; set; }

    public decimal? CategoryId { get; set; }

    public string? Email { get; set; }

    public string? Isaccepted { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public string? ImagePath1 { get; set; }

    public virtual Category? Category { get; set; }

    public virtual RecipeUser? RecipeUser { get; set; }
}
