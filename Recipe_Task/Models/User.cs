using System;
using System.Collections.Generic;

namespace Recipe_Task.Models;

public partial class User
{
    public decimal UserId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string Email { get; set; } = null!;

    public string? Password { get; set; }

    public string? ImagePath { get; set; }

    public decimal? RoleId { get; set; }

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<RecipeUser> RecipeUsers { get; set; } = new List<RecipeUser>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<Testimonial> TestimonialEmailNavigations { get; set; } = new List<Testimonial>();

    public virtual ICollection<Testimonial> TestimonialUsers { get; set; } = new List<Testimonial>();
}
