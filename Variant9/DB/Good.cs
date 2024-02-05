using System;
using System.Collections.Generic;

namespace Variant9.DB;

public partial class Good
{
    public int Id { get; set; }

    public string Articul { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int UnitId { get; set; }

    public int Cost { get; set; }

    public int MaxSaleProc { get; set; }

    public int CreatorId { get; set; }

    public int ProviderId { get; set; }

    public int CategoryId { get; set; }

    public int CurrentSale { get; set; }

    public int Amount { get; set; }

    public string Discription { get; set; } = null!;

    public string? Picture { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Creator Creator { get; set; } = null!;

    public virtual Provider Provider { get; set; } = null!;

    public virtual Unit Unit { get; set; } = null!;
}
