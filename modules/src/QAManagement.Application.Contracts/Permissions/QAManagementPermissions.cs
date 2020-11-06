using Volo.Abp.Reflection;

namespace QAManagement.Permissions
{
    public class QAManagementPermissions
    {
        public const string GroupName = "QAManagement";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(QAManagementPermissions));
        }
    }
}