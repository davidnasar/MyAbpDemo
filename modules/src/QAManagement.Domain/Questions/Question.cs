using JetBrains.Annotations;
using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace QAManagement.Questions
{
    public class Question : AuditedAggregateRoot<int>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        [NotNull]
        public string Code { get; set; }
        [NotNull]
        public string DisplayName { get; set; }
        [CanBeNull]
        public string Description { get; set; }
    }
}
