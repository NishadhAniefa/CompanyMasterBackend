using Company.Portal.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Company.Portal.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PortalController : AbpController
    {
        protected PortalController()
        {
            LocalizationResource = typeof(PortalResource);
        }
    }
}