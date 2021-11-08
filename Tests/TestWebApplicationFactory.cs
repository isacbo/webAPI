using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tests
{
	public class TestWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup> where TStartup : class
	{
		private readonly IConfiguration _configuration;

		private readonly IServiceCollection _services;

		

		public TestWebApplicationFactory(IServiceCollection services)
			: this((IConfiguration)new ConfigurationBuilder().Build(), services)
		{
			 
		}

		
		public TestWebApplicationFactory(IConfiguration configuration, IServiceCollection services)
		{
			_configuration = configuration;
			_services = services;
		}


	}
}
