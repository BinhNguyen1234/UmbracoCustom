﻿using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoDataType
{
    public int NodeId { get; set; }

    public string PropertyEditorAlias { get; set; } = null!;

    public string DbType { get; set; } = null!;

    public string? Config { get; set; }

    public virtual ICollection<CmsPropertyType> CmsPropertyTypes { get; set; } = new List<CmsPropertyType>();

    public virtual UmbracoNode Node { get; set; } = null!;
}