using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Vulder.Search.Core.ProjectAggregate.School.Events;
using Vulder.Search.Core.Services;

namespace Vulder.Search.Core.ProjectAggregate.School.Handlers
{
    public class ItemDeleteNotificationHandler : INotificationHandler<ItemDeleteEvent>
    {
        private readonly SchoolsCollectionService _service;

        public ItemDeleteNotificationHandler(SchoolsCollectionService service)
        {
            _service = service;
        }

        public Task Handle(ItemDeleteEvent domainEvent, CancellationToken cancellationToken)
        {
            return _service.Delete(domainEvent.School.Id);
        }
    }
}