using System;
namespace programa.Models;

public struct ContaCorrente
{
    public string IdCliente { get; set; }
    public double Valor { get; set; }
    public DateTime Data { get; set; }
}