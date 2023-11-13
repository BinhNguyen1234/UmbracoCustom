﻿using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class CmsDictionary
{
    public int Pk { get; set; }

    public Guid Id { get; set; }

    public Guid? Parent { get; set; }

    public string Key { get; set; } = null!;

    public virtual ICollection<CmsLanguageText> CmsLanguageTexts { get; set; } = new List<CmsLanguageText>();

    public virtual ICollection<CmsDictionary> InverseParentNavigation { get; set; } = new List<CmsDictionary>();

    public virtual CmsDictionary? ParentNavigation { get; set; }
}
