using go_horse_voos_comerciais.Infraestrutura.Repositories;

namespace go_horse_voos_comerciais.Domain.Voo;

public class VoosRepository : Repository<Voo>
{
    public VoosRepository(ApiGhvcDbContext context) : base(context) { }
}