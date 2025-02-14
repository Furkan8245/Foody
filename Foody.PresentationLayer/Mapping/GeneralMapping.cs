using AutoMapper;
using Foody.DtoLayer.Dtos.AboutDtos;
using Foody.DtoLayer.Dtos.ReviewDtos;
using Foody.DtoLayer.Dtos.SliderDtos;
using Foody.EntitiyLayer.Concrete;

namespace Foody.PresentationLayer.Mapping
{
	public class GeneralMapping:Profile
	{
        public GeneralMapping()
        {
            CreateMap<ResultAboutDto,About>().ReverseMap();
            CreateMap<CreateAboutDto, About>().ReverseMap();
            CreateMap<GetByIdAboutDto,About>().ReverseMap();
            CreateMap<UpdateAboutDto,About>().ReverseMap();

            CreateMap<ResultSliderDto, Slider>().ReverseMap();
            CreateMap<CreateSliderDto, Slider>().ReverseMap();
            CreateMap<GetByIdSliderDto, Slider>().ReverseMap();
            CreateMap<UpdateSliderDto, Slider>().ReverseMap();

            CreateMap<ResultReviewDto,Review>().ReverseMap();

        }
    }
}
