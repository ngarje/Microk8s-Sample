using MediatR;
using MicroK8s.Api.Database.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace MicroK8s.Api.Receiver
{
    public sealed class CountryUpdateCommand : IRequest
    {
        public CountryEntity Country { get; set; }
    }

    public sealed class CountryUpdateCommandHandler : IRequestHandler<CountryUpdateCommand>
    {
        private readonly ICountryUpdateRepository _context;
        public CountryUpdateCommandHandler(ICountryUpdateRepository context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CountryUpdateCommand request, CancellationToken cancellationToken)
        {
            _context.UpdateCountry(request.Country);
            return Unit.Value;
        }
    }
}
