﻿using AgendaSis.Tests.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AgendaSis.Tests.Implementation.Domain.Entidades
{
    public class SalaTest
    {
        [Fact]
        public void deve_atualizar_os_valores_da_instancia_da_sala()
        {
            var sala = new SalaBuilder()
                           .ComId(2)
                           .ComNome("joao")
                           .ComCapacidade(5)
                           .ComAndar(5)
                           .Build();
            var nome = "Python";
            var capacidade = 7;
            var andar = 4;
            sala.ChangeValues(nome, capacidade, andar);
            Assert.Equal(nome, sala.Nome);
            Assert.Equal(capacidade, sala.Capacidade);
            Assert.Equal(andar, sala.Andar);
        }
    }
}
