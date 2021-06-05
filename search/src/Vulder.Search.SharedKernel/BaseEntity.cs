using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vulder.Search.SharedKernel
{
    public abstract class BaseEntity
    {
        public string Id { get; set; }

        public List<BaseDomainEvent> Events { get; set; } = new();
    }
}