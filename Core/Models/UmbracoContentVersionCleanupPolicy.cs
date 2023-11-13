using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoContentVersionCleanupPolicy
{
    public int ContentTypeId { get; set; }

    public bool PreventCleanup { get; set; }

    public int? KeepAllVersionsNewerThanDays { get; set; }

    public int? KeepLatestVersionPerDayForDays { get; set; }

    public DateTime Updated { get; set; }

    public virtual CmsContentType ContentType { get; set; } = null!;
}
