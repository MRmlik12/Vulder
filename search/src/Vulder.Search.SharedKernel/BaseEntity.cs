using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Vulder.Search.SharedKernel
{
    public abstract class BaseEntity
    {
        [BsonId]
        public string Id { get; set; }

        public List<BaseDomainEvent> Events { get; set; } = new();
    }
}