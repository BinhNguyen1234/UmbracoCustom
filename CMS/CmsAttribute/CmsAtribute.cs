using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.CmsAttribute
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ValidateRoute : Attribute
    {
        public ValidateRoute() { 
        
        }
    }
}
