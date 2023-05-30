using OpenAI.API;
using OpenAI.API.Completions;
using OpenAI.API.Models;

namespace Partner.Core.Services
{
    public class PartnerCoreService : IPartnerCore
    {
        private string OPEN_AI_KEY;
        private int? MAX_TOKENS = 60;
        private double? TEMPERATURE = 60;
        private Model MODEL = Model.DavinciText;

        public PartnerCoreService(string open_ai_key, int? maxtokens, double? temperature, Model? Model)
        {
            this.OPEN_AI_KEY = open_ai_key;
            this.MAX_TOKENS     = maxtokens is null     ? this.MAX_TOKENS   : maxtokens;
            this.TEMPERATURE    = temperature is null   ? this.TEMPERATURE  : temperature;
            this.MODEL          = Model is null         ? this.MODEL        : Model;
        }
        public async Task<string>? MakeATask(string Prompt)
        {
            OpenAIAPI openai = new OpenAIAPI(new APIAuthentication(this.OPEN_AI_KEY));

            var response = await openai.Completions.CreateCompletionAsync(
                new CompletionRequest(
                    prompt: Prompt,
                    model: this.MODEL,
                    max_tokens: this.MAX_TOKENS,
                    temperature: this.TEMPERATURE,
                    numOutputs: 1
                    )
                );

            string Result = response.Completions[0].Text.Trim();
            return Result;
        }

        }

    public interface IPartnerCore
    {
        Task<string>? MakeATask(string Prompt);
    }
}
