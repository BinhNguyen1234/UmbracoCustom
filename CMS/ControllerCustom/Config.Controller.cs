using AutoMapper;
using CMS.Enum;
using CMS.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NUglify.Helpers;
using StackExchange.Profiling.Internal;
using System;
using System.Linq;
using System.Reflection;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;


namespace CmsCore.ControllerCustom
{
    
    [ApiRouteAtribute("[controller]/[action]")]
    [ApiController]
    public class Config : Controller
    {
        private IContentService _contentService;
        private readonly IMapper _mapper;
        private IContent? _content;
        public Config(IContentService contentService, IMapper mapper)
        {
            this._mapper = mapper;
            this._contentService = contentService;
            this._content = this._contentService.GetRootContent().FirstOrDefault(x => x.Name != null && x.Name.Equals(this.GetType().Name));
        }
        [HttpGet]
        public IActionResult Route()
        {
            var res2 = this._contentService.GetRootContent();
            var a = MethodBase.GetCurrentMethod()?.Name;
            return Ok(_content);
        }
        [HttpGet]
        public IActionResult Age()
        {
            return Ok("25");
        }
    }  
}
