using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoUserGroup2App
{
    public int UserGroupId { get; set; }

    public string App { get; set; } = null!;

    public virtual UmbracoUserGroup UserGroup { get; set; } = null!;
}
