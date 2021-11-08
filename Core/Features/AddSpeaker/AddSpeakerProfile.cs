using AutoMapper;

namespace Core.Features.AddSpeaker
{
	public class AddSpeakerProfile : Profile
	{
		public AddSpeakerProfile()
		{
			CreateMap<Core.Models.Speaker, Contracts.V1.GraphQL.TheSpeaker>()
				.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
				.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
				.ForMember(dest => dest.Bio, opt => opt.MapFrom(src => src.Bio))
				.ForMember(dest => dest.WebSite, opt => opt.MapFrom(src => src.WebSite))
				.ReverseMap();


			CreateMap<Contracts.V1.GraphQL.TheSpeaker, Core.Models.Speaker>();
		}
	}
}
