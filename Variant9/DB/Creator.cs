using System;
using System.Collections.Generic;

namespace Variant9.DB;

public partial class Creator
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Good> Goods { get; set; } = new List<Good>();
}
