using Core.Models;

namespace Core.Infrastructure
{
    public record AddSpeakerInput(string Name, string Bio, string WebSite)
	{
	}

	public class AddSpeakerPayload
	{
		public Speaker Speaker { get; set; }
		public AddSpeakerPayload(Speaker speaker)
		{
			Speaker = speaker;
		}
	}
}
