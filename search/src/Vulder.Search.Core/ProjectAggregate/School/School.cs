using System;
using System.ComponentModel.DataAnnotations;
using Vulder.Search.SharedKernel;
using Vulder.Search.SharedKernel.Interface;

namespace Vulder.Search.Core.ProjectAggregate.School
{
    public class School : BaseEntity, IAggregateRoot
    {
        [Required] public string Id { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string Url { get; set; }

        public void GenerateId()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}