using AutoMapper;
using CMS.Enum;
using CMS.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NUglify.Helpers;
using StackExchange.Profiling.Internal;
using System;
using System.Linq;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Services.Implement;
using Umbraco.Cms.Web.Common.Authorization;

namespace CmsCore.ControllerCustom
{
    
    [ApiRouteAtribute("[controller]/[action]")]
    [ApiController]
    public class TestController : Controller
    {
        private IContentService _contentService;
        private readonly IMapper _mapper;
        public TestController(IContentService contentService, IMapper mapper)
        {
            this._mapper = mapper;
            this._contentService = contentService;
        }
        [HttpGet]
        public IActionResult name()
        {
            var res = this._contentService.GetById(1096)?.Properties;
            var tt = res?.Select(x => this._mapper.Map<RouteConfigVM>(x));
            return Ok(tt);
        }
        [HttpGet]
        public IActionResult Age()
        {
            return Ok("25");
        }
    }  
}
