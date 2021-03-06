﻿using AgendaSis.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaSis.Tests.Implementation.Contexto
{
    public class BaseContext
    {
        protected MeuContexto meuContexto;
        protected void PegaContexto()
        {
            this.meuContexto = PegaContextoEmMemoria();
        }

        private MeuContexto PegaContextoEmMemoria()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<MeuContexto>();
            var options = builder.UseInMemoryDatabase("teste")
                                 .UseInternalServiceProvider(serviceProvider)
                                 .Options;
            var ctx = new MeuContexto(options);
            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();
            return ctx;
        }
    }
}
