using System;
using System.Collections.Generic;

namespace Variant9.DB;

public partial class User
{
    public int Id { get; set; }

    public string SecondName { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public int RoleId { get; set; }

    public virtual Role Role { get; set; } = null!;
}
