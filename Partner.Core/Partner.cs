using Microsoft.Extensions.DependencyInjection;
using Partner.Core.Models;
using Partner.Core.Services;
using OpenAI.API.Models;

namespace Partner.Core
{
    public static class Partner
    {
        public static void PartnerCore(this IServiceCollection Services, PartnerCoreConfiguration coreConfiguration)
        {

            // Use this method to inject servcices from the library 
            string? open_ai_key = coreConfiguration.OPENAI_KEY;
            int? maxtokens = coreConfiguration.MAX_TOKENS;
            double? temperature = coreConfiguration.TEMPERATURE;
            Model? Model = coreConfiguration.MODEL;

            if (open_ai_key is null) throw new InvalidOperationException("Please provide your OPEN AI Key");

            Services.AddScoped<IPartnerCore>(service => new PartnerCoreService(open_ai_key, maxtokens, temperature, Model));
        }
    }
}
