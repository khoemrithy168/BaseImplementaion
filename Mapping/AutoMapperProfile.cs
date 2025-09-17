using AutoMapper;

namespace hrm_api.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // Ringpull
        // CreateMap<BatchRingpull, GetBatchRingpullDTO>();
        // CreateMap<GetBatchRingpullDTO, BatchRingpull>();
        // CreateMap<RingpullBatchDTO, BatchRingpull>();
        //
        // CreateMap<BatchPrize, BatchPrizeDTO>();
        // CreateMap<BatchPrize, BatchPrizeRelease>();
        // CreateMap<BatchPrizeRelease, BatchPrize>();
        // CreateMap<Quotations, QuotationCreationDto>();
        // CreateMap<QuotationCreationDto, Quotations>();
        // CreateMap<QuotationItems, QuotationItemCreationDto>();
        // CreateMap<QuotationItemCreationDto, QuotationItems>();
        // CreateMap<Plan, PlanDto>();
        // CreateMap<PlanDto, Plan>();
    }
}