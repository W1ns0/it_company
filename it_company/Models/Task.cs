using System;
using System.Collections.Generic;

namespace it_company.Models;

public partial class Task
{
    public int Id { get; set; }

    public string NameTask { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int IdStatus { get; set; }

    public int IdPriority { get; set; }

    public int IdUserInProject { get; set; }

    public DateOnly DateOfCreate { get; set; }

    public DateOnly DateOfEnd { get; set; }

    public virtual Priority Priority { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual UserInProject UserInProject { get; set; } = null!;
}
