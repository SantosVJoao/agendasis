using AgendaSis.Infra.Repositorios;
using AgendaSis.Tests.Builders;
using AgendaSis.Tests.Implementation.Contexto;
using Xunit;

namespace AgendaSis.Tests.Implementation.Repositories
{
    public class SalaRepositoryTest : BaseContext
    {
        private readonly SalaRepository _salaRepo;
        public SalaRepositoryTest()
        {
            _salaRepo = new SalaRepository(meuContexto);
        }
        [Fact]
        public async void deve_criar_uma_nova_sala()
        {
            var sala = new SalaBuilder()
                           .ComNome("Bobol")
                           .ComCapacidade(5)
                           .ComAndar(5)
                           .Build();
            await _salaRepo.CreateAsync(sala);
            Assert.Equal(1, sala.Id);
        }
    }
}
