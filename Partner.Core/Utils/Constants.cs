
namespace Partner.Core.Utils;

public class Constants
{
    private readonly string PROMP_TASK = "";
    private readonly string START_TAG = "<start_answer>";
    private readonly string END_TAG = "<end_answer>";
    public Constants() { }

    public string GetPromptTask()
    {
        return this.PROMP_TASK;
    }

    public string GetStartTag()
    {
        return this.START_TAG;
    }
    public string GetEndTag()
    {
        return this.END_TAG;
    }

}
