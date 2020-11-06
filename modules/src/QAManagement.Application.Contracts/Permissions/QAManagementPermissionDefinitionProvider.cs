using QAManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace QAManagement.Permissions
{
    public class QAManagementPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(QAManagementPermissions.GroupName, L("Permission:QAManagement"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<QAManagementResource>(name);
        }
    }
}