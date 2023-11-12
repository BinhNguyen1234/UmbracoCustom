using CMS.Enum;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using Umbraco.Cms.Web.Common.ApplicationBuilder;

namespace CMS.Filters
{
    public class ApiFilter : UmbracoPipelineFilter
    {
        public ApiFilter() : base("api")
        {
            Endpoints = HandleEndPoint;
        }
        private void HandleEndPoint(IApplicationBuilder app)
        {
            app.Map("/api", app =>
            {
                app.UseRouting();
                app.UseAuthorization();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers(); 
                });
            });
        }
    }
}
