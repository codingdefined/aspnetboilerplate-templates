using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace MyApp
{
    [AutoMapFrom(typeof(SteemitPost))]
    public class SteemitPostDto : CreationAuditedEntityDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Tags { get; set; }
    }
}
