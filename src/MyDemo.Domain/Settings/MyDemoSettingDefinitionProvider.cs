using Volo.Abp.Settings;

namespace MyDemo.Settings
{
    public class MyDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MyDemoSettings.MySetting1));
        }
    }
}
