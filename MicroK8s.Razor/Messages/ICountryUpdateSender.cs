using MicroK8s.Razor.Models;

namespace MicroK8s.Razor.Messages
{
    public interface ICountryUpdateSender
    {
        void SendCountry(CountryModel country);
    }
}
