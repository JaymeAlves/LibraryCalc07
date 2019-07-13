using System;
using Xunit;

namespace LibraryCalc07.Testes
{
    public class Calculadoratestes
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(112, 0)]
        public void SomaSucesso(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Soma(x, y);

            Assert.True((x + y) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(112, 0)]
        public void SubtracaoSucesso(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Subtracao(x, y);

            Assert.True((x - y) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(112, 0)]
        public void MultiplicaoSucesso(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Multiplicacao(x, y);

            Assert.True((x * y) == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(23, 21)]
        [InlineData(112, 1)]
        public void DivisaoSucesso(int x, int y)
        {
            var calculadora = new Calculadora();
            
            var resultado = calculadora.Divisao(x, y);

            var resultadoEsperado = (x / y);

            Assert.True(resultadoEsperado == resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(112, 0)]
        public void SomaErro(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Soma(x, y);

            Assert.False((x + y) != resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(112, 0)]
        public void SubtracaoErro(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Subtracao(x, y);

            Assert.False((x - y) != resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(-23, 21)]
        [InlineData(112, 0)]
        public void MultiplicaoErro(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Multiplicacao(x, y);

            Assert.False((x * y) != resultado);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(10, 21)]
        [InlineData(23, 21)]
        [InlineData(112, 1)]
        public void DivisaoErro(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Divisao(x, y);

            var resultadoEsperado = (x / y);

            Assert.False(resultadoEsperado != resultado);
        }

        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(10, 21, 5 )]
        [InlineData(-23, 21,3 )]
        [InlineData(112, 0, 192)]
        public void Soma3Sucesso(int x, int y, int z)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Soma(x, y, z);

            Assert.True((x + y + z) == resultado);
        }

        [Theory]
        [InlineData(1, 2, 41)]
        [InlineData(10, 21, -1)]
        [InlineData(-23, 21, 93)]
        [InlineData(112, 0, -13)]
        public void Soma3Erro(int x, int y, int z)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Soma(x, y, z);

            Assert.False((x + y + z) != resultado);
        }
    }
}
