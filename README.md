# LibraryCalc07
Biblioteca de operações matemáticas

[![Build status](https://ci.appveyor.com/api/projects/status/6iouk0qbunrfl25b/branch/master?svg=true)](https://ci.appveyor.com/project/JaymeAlves/librarycalc07/branch/master)

![Nuget](https://img.shields.io/nuget/dt/LibraryCalc00.svg)

## How to install
Install-Package LibraryCalc07 -Version 1.0.2

## How to use

```cs
static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            var result = calculadora.Soma(2, 2);

            Console.WriteLine(result);
        }
```
