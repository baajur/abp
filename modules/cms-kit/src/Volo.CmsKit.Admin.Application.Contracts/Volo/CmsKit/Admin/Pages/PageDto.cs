﻿using System;
using Volo.Abp.Application.Dtos;

namespace Volo.CmsKit.Admin.Pages
{
    public class PageDto : AuditedEntityDto<Guid>
    {
        public string Title { get; set; }

        public string Slug { get; set; }
        
        public string Description { get; set; }
    }
}