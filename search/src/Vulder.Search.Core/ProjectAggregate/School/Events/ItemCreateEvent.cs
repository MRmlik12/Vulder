using Vulder.Search.SharedKernel;

namespace Vulder.Search.Core.ProjectAggregate.School.Events
{
    public class ItemCreateEvent : BaseDomainEvent
    {
        public ItemCreateEvent(School school)
        {
            School = school;
        }

        public School School { get; set; }
    }
}