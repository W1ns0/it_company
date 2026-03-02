using System;
using System.Collections.Generic;

namespace it_company.Models;

public partial class UserInProject
{
    public int Id { get; set; }

    public int IdProject { get; set; }

    public int IdUser { get; set; }

    public int IdRoleInProject { get; set; }

    public virtual Project Project { get; set; } = null!;

    public virtual RoleInProject RoleInProject { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
