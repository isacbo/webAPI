using Contracts.V1;
using Core.Services;
using FluentAssertions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using Tests.FakeServices;
using WebAPI;

namespace Tests.Features.GetLocation
{

	public class GetLocationTests
	{
		[Test]
		public async Task Should_Return_Expected_Location()
		{
			var services = new ServiceCollection().AddSingleton<ILocationService, LocationService>();
			using var factory = new TestWebApplicationFactory<Startup>(services);
			using var client = factory.CreateClient();
			var guid = Guid.NewGuid();
			var response = await client.GetAsync($"/v1/Location/{guid}");

			var responseBody = await response.Content.ReadAsStringAsync();
			var location = JsonSerializer.Deserialize<GetLocationQueryResponse>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

			location.Uid.Should().Be(guid);
			location.Location.X.Should().Be(0);
			location.Location.Y.Should().Be(0);
			location.Location.Z.Should().Be(0);
		}

		[Test]
		public async Task Should_Use_ExceptionHandler_When_Exception_Is_Throwed()
		{
			var services = new ServiceCollection();

			services.AddSingleton<ILocationService, FakeLocationService>();
			
			using var factory = new TestWebApplicationFactory<Startup>(
				new ConfigurationBuilder().Build(), 
				services);

			services.AddSingleton<ILocationService, FakeLocationService>();

			using var client = factory.CreateClient();
			var guid = Guid.NewGuid();
			var response = await client.GetAsync($"/v1/Location/{guid}");

			var responseBody = await response.Content.ReadAsStringAsync();
			var location = JsonSerializer.Deserialize<GetLocationQueryResponse>(responseBody, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

			location.Uid.Should().Be(guid);
			location.Location.X.Should().Be(0);
			location.Location.Y.Should().Be(0);
			location.Location.Z.Should().Be(0);
		}
	}
}
