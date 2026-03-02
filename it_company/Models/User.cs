using System;
using System.Collections.Generic;

namespace it_company.Models;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public int IdRole { get; set; }

    public string Email { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<UserInProject> UserInProjects { get; set; } = new List<UserInProject>();
}
