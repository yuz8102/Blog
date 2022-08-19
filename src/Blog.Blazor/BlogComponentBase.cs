﻿using Blog.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Blog.Blazor;

public abstract class BlogComponentBase : AbpComponentBase
{
    protected BlogComponentBase()
    {
        LocalizationResource = typeof(BlogResource);
    }
}
