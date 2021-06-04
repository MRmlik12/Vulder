using System.Collections.Generic;

namespace Vulder.Search.SharedKernel
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }

        public List<BaseDomainEvent> Events { get; set; } = new();
    }
}