using Common;
using Core.Infrastructure;
using Core.Services;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Core
{
	public static class ServiceCollectionExtensions
	{
		public static void AddCore(this IServiceCollection services)
		{
			services.AddMediatR(Assembly.GetExecutingAssembly());
			
			services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

			services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

			services.AddScoped<ILocationService, LocationService>();

			services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=conferences.db"), ServiceLifetime.Scoped);
		}
	}
}