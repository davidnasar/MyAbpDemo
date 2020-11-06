using MyDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MyDemoController : AbpController
    {
        protected MyDemoController()
        {
            LocalizationResource = typeof(MyDemoResource);
        }
    }
}