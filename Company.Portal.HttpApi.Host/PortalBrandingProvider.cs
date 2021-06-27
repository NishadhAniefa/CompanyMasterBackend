using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Company.Portal
{
    [Dependency(ReplaceServices = true)]
    public class PortalBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Portal";
    }
}
