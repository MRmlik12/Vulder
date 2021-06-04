using Vulder.Search.SharedKernel;

namespace Vulder.Search.Core.ProjectAggregate.School.Events
{
    public class ItemDeleteEvent : BaseDomainEvent
    {
        public ItemDeleteEvent(School school)
        {
            School = school;
        }

        public School School { get; set; }
    }
}