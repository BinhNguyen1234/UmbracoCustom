﻿using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoRedirectUrl
{
    public Guid Id { get; set; }

    public Guid ContentKey { get; set; }

    public DateTime CreateDateUtc { get; set; }

    public string Url { get; set; } = null!;

    public string? Culture { get; set; }

    public string UrlHash { get; set; } = null!;

    public virtual UmbracoNode ContentKeyNavigation { get; set; } = null!;
}