using Contracts.V1;
using System;

namespace Core.Services
{
	public class LocationService : ILocationService
	{
		public Location Get()
		{
			return new Location
			{
				X = 10, Y = 20, Z = 30
			};
		}
	}
}
