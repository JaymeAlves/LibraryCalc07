using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc07
{
    /// <summary>
    /// Calculadora que realiza as 4 Operações básicas: Soma, Subtração, Multiplicação e Divisão
    /// </summary>
    public interface ICalculadora
    {
        /// <summary>
        /// Retorna a Divisão de x por y
        /// </summary>
        /// <param name="x">Inteiro</param>
        /// <param name="y">Inteiro</param>
        /// <returns>Retorna o resultado como float</returns>
        int Soma(int x, int y);

        /// <summary>
        /// Realiza a Multiplicação de x e y
        /// </summary>
        /// <param name="x">Valor inteiro</param>
        /// <param name="y">Valor inteiro</param>
        /// <returns>Retorna um inteiro</returns>
        int Subtracao(int x, int y);

        /// <summary>
        /// Realizza a Soma de x e y
        /// </summary>
        /// <param name="x">Valor inteiro</param>
        /// <param name="y">Valor inteiro</param>
        /// <returns>retorna um inteiro</returns>
        int Divisao(int x, int y);

        /// <summary>
        /// realiza a Subtração de x e y 
        /// </summary>
        /// <param name="x">Valor inteiro</param>
        /// <param name="y">Valor inteiro</param>
        /// <returns>retorna um inteiro (x-y)</returns>
        int Multiplicacao(int x, int y);

        int Soma(int x, int y, int z);
        int Subtracao(int x, int y, int z);
        int Multiplicacao(int x, int y, int z);
    }
}
