﻿using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class CmsTemplate
{
    public int Pk { get; set; }

    public int NodeId { get; set; }

    public string? Alias { get; set; }

    public virtual ICollection<CmsDocumentType> CmsDocumentTypes { get; set; } = new List<CmsDocumentType>();

    public virtual UmbracoNode Node { get; set; } = null!;

    public virtual ICollection<UmbracoDocumentVersion> UmbracoDocumentVersions { get; set; } = new List<UmbracoDocumentVersion>();
}
