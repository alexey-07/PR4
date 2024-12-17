using System;
using System.Collections.Generic;

namespace PR4;

public partial class TypeProduct
{
    public short Id { get; set; }

    public string TypeProduct1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
