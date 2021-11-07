using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
