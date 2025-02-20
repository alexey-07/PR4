using System;
using System.Collections.Generic;

namespace PR4;

public partial class TypeOfProduct
{
    public short Id { get; set; }

    public string TypeNameProduct { get; set; } = null!;

    // навигационные свойства
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    //public string TypeProduct { get; internal set; }
}
