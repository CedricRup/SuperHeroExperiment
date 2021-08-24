using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace Oracle
{
    public sealed class Driver
    {
        private string? rootURI;

        public Driver(string? rootUri)
        {
            rootURI = rootUri;
        }

        public Task<IFlurlResponse> RegisterHero(Registration registration)
        {
            return rootURI
                .AppendPathSegment("registration")
                .PostJsonAsync(new
                {
                    name =
                        registration.Name,
                    secret =
                        registration.Secret
                });
        }

        public Task<IFlurlResponse> RegisterEvent(Event @event)
        {
            return rootURI
                .AppendPathSegment("registration")
                .PostJsonAsync(new
                {
                    @event
                });
        }

        public Task<IFlurlResponse> GetInterventionPlan()
        {
            return rootURI
                .AppendPathSegment("interventionPlan")
                .GetAsync();
        }
    }
}