using System;
using System.Collections.Generic;

namespace PR4;

public partial class Partner
{
    public int Id { get; set; }

    public short IdTypeOfPartner { get; set; }

    public string NameProduct { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public string DirectorsName { get; set; } = null!;

    public string MobilePhone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public float Rating { get; set; }

    // навигационные свойства

    public virtual TypeOfPartner TypeOfPartner { get; set; } = null!;

    public virtual ICollection<PartnersProduct> PartnersProducts { get; set; } = new List<PartnersProduct>();
}
