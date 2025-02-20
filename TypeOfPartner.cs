using System;
using System.Collections.Generic;

namespace PR4;

public partial class TypeOfPartner
{
    public short Id { get; set; }

    public string TypeNamePartner { get; set; } = null!;

    // навигационные свойства
    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
    //public object TypeProduct { get; internal set; }
}
