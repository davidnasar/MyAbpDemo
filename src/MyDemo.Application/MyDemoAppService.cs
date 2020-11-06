using System;
using System.Collections.Generic;
using System.Text;
using MyDemo.Localization;
using Volo.Abp.Application.Services;

namespace MyDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class MyDemoAppService : ApplicationService
    {
        protected MyDemoAppService()
        {
            LocalizationResource = typeof(MyDemoResource);
        }
    }
}
