using System;
using System.Collections.Generic;

namespace PR4;

public partial class PartnersProduct
{
    public int Id { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public string Count { get; set; } = null!;

    public DateTimeOffset SalesDate { get; set; }

    public virtual Partner Partner { get; set; } = null!;

    /*public virtual Product Partner { get; set; } = null!;*/
}
