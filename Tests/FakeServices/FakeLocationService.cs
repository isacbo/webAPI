using Contracts.V1;
using Core.Services;
using System;

namespace Tests.FakeServices
{
	public class FakeLocationService : ILocationService
	{
		public Location Get()
		{
			throw new Exception("Something went wrong fetching location data");
		}
	}
}
