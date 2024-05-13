using System;
using System.Collections.Generic;

namespace Recipe_Task.Models;

public partial class Role
{
    public decimal RoleId { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<Login> Logins { get; set; } = new List<Login>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
