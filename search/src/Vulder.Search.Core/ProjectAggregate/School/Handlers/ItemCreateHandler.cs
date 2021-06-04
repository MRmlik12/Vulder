using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Vulder.Search.Core.ProjectAggregate.School.Events;
using Vulder.Search.Core.Services;

namespace Vulder.Search.Core.ProjectAggregate.School.Handlers
{
    public class ItemCreateHandler : INotificationHandler<ItemCreateEvent>
    {
        private readonly SchoolsCollectionService _service;

        public ItemCreateHandler(SchoolsCollectionService service)
        {
            _service = service;
        }

        public Task Handle(ItemCreateEvent domainEvent, CancellationToken cancellationToken)
        {
            return _service.Create(domainEvent.School);
        }
    }
}