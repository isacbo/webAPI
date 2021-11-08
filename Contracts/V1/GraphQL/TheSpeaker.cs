namespace Contracts.V1.GraphQL
{
	public class TheSpeaker
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Bio { get; set; }
		public virtual string WebSite { get; set; }
	}
}
