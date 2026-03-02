using System;
using System.Collections.Generic;

namespace it_company.Models;

public partial class Project
{
    public int Id { get; set; }

    public string NameProject { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateOnly DateOfStart { get; set; }

    public int IdUser { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<UserInProject> UserInProjects { get; set; } = new List<UserInProject>();
}
