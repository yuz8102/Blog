using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Blog.Blazor.Server;

[Dependency(ReplaceServices = true)]
public class BlogBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Blog";
}
