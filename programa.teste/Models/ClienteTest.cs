using Microsoft.VisualStudio.TestTools.UnitTesting;
using programa.Models;

namespace Programa.Teste.Models;

[TestClass]
class ClienteTest
{
    [TestMethod]
    public void TestandopropriedadesDaClasse()
    {
        var cliente = new Cliente();
        cliente.Id = "37827382";
        cliente.Nome = "Marcela";
        cliente.Email = "Ma@email.com";
        cliente.Telefone = "5599999999999";

        Assert.AreEqual("37827382",cliente.Id);
        Assert.AreEqual("Marcela",cliente.Telefone);
        Assert.AreEqual("Ma@email.com",cliente.Email);
        Assert.AreEqual("5599999999999",cliente.Telefone);
    }
}