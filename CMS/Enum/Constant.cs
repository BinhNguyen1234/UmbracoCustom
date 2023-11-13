
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Enum
{
    public class Api
    {
        public static readonly string preFix = "/api";
    }
    public class ApiRouteAtribute : RouteAttribute
    {
        public ApiRouteAtribute([StringSyntax("Route")] string template) : base($"{Api.preFix}/{template}")
        {
        }
    }
}
