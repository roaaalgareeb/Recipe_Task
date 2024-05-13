using System;
using System.Collections.Generic;

namespace Recipe_Task.Models;

public partial class Login
{
    public decimal LoginId { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public decimal? RoleId { get; set; }

    public decimal? UserId { get; set; }

    public virtual Role? Role { get; set; }
}
