using Mapster;
using MiddleTemplate.Application.Models;
using MiddleTemplate.Data.Entities;

namespace MiddleTemplate.Application.Mappings;

public class TeasMappingRegister : IRegister
{
    private const decimal BtcRate = 0.000034m;

    public void Register(TypeAdapterConfig config)
    {
        // m -> member
        // s -> source
        config.NewConfig<Tea, TeaModel>()
            .Map(m => m.PriceUSD, s => s.Price)
            .Map(m => m.PriceBTC, s => s.Price * BtcRate);
    }
}