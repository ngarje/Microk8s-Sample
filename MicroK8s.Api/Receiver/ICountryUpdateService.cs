using AgileObjects.AgileMapper;
using MediatR;
using MicroK8s.Api.Database.Context;
using MicroK8s.Api.Database.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using System;

namespace MicroK8s.Api.Receiver
{
    public interface ICountryUpdateService
    {
        void UpdateCountry(UpdateCountryModel model);
    }

    public class CountryUpdateService : ICountryUpdateService
    {
        private readonly IMediator _mediator;
        public CountryUpdateService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async void UpdateCountry(UpdateCountryModel model)
        {
            var countryEntity = Mapper.Map(model).ToANew<CountryEntity>();
            await _mediator.Send(new CountryUpdateCommand()
            {
                Country = countryEntity
            });
        }
    }

    public interface ICountryUpdateRepository
    {
        void UpdateCountry(CountryEntity model);
    }

    public class CountryUpdateRepository : ICountryUpdateRepository
    {
        private readonly EfContext _context;
        private readonly IDistributedCache _cacheManager;
        public CountryUpdateRepository(EfContext mediator, IDistributedCache cacheManager)
        {
            _context = mediator;
            _cacheManager = cacheManager;
        }
        public async void UpdateCountry(CountryEntity model)
        {
            var countryEntity = await _context.CountryTable.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (countryEntity != null)
            {
                countryEntity.Name = model.Name;
                countryEntity.Code = model.Code;
                countryEntity.ModifiedDate = DateTime.UtcNow;
                await _context.SaveChangesAsync();
                string cacheKey = "country-list";
                await _cacheManager.RemoveAsync(cacheKey);
            }
        }
    }
}
