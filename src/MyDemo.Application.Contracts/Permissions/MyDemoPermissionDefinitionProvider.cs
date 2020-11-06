using MyDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MyDemo.Permissions
{
    public class MyDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MyDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(MyDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MyDemoResource>(name);
        }
    }
}
