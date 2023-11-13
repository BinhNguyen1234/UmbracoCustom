using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoCreatedPackageSchema
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Value { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public Guid PackageId { get; set; }
}
