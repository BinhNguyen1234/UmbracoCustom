using System;
using System.Collections.Generic;

namespace Core.Models;

public partial class UmbracoUserGroup2NodePermission
{
    public int UserGroupId { get; set; }

    public int NodeId { get; set; }

    public string Permission { get; set; } = null!;

    public virtual UmbracoNode Node { get; set; } = null!;

    public virtual UmbracoUserGroup UserGroup { get; set; } = null!;
}
