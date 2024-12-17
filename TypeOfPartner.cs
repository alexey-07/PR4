﻿using System;
using System.Collections.Generic;

namespace PR4;

public partial class TypeOfPartner
{
    public short Id { get; set; }

    public string TypeOfPartner1 { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
