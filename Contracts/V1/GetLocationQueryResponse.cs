using System;

namespace Contracts.V1
{
	public class GetLocationQueryResponse 
	{
		public Guid Uid { get; set; }
		public Location Location { get; set; }
	}
}
