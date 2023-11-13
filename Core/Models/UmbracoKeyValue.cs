using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoKeyValue
{
    public string Key { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime Updated { get; set; }
}
