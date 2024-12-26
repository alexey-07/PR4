using System;
using System.Collections.Generic;

namespace PR4;

public partial class Product
{
    public int Id { get; set; }

    public short IdTypeProduct { get; set; }

    public string NameProduct { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinimumCostForApartner { get; set; }

    public virtual TypeProduct TypeProduct { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
