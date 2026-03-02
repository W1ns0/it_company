using System;
using System.Collections.Generic;

namespace it_company.Models;

public partial class RoleInProject
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public virtual ICollection<UserInProject> UserInProjects { get; set; } = new List<UserInProject>();
}
