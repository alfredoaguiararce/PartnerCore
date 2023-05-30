using OpenAI.API.Models;

namespace Partner.Core.Models;
public class PartnerCoreConfiguration
{
    public string? OPENAI_KEY { get; set; }
    public int? MAX_TOKENS { get; set; }
    public double? TEMPERATURE { get; set; }
    public Model? MODEL { get; set; }
}
