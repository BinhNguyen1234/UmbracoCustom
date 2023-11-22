﻿using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoDomain
{
    public int Id { get; set; }

    public int? DomainDefaultLanguage { get; set; }

    public int? DomainRootStructureId { get; set; }

    public string DomainName { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual UmbracoNode? DomainRootStructure { get; set; }
}