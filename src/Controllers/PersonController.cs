using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public Person Get()
    {
        Person pessoa = new Person();
        Contract novoContrato = new Contract();
        Contract novoContrato2 = new Contract("abc123", 50.46);
        pessoa.Contratos.Add(novoContrato);
        pessoa.Contratos.Add(novoContrato2);
        return pessoa;
    }

    [HttpPost]
    public Person Post([FromBody]Person pessoa)
    {
        return pessoa;
    }

    [HttpPatch("{id}")]
    public string Update([FromRoute]int id, [FromBody]Person pessoa)
    {
        return "Dados do id " + id + " atualizados";
    }

    [HttpDelete("{id}")]
    public string Delete([FromRoute]int id)
    {
        return "Deletado Pessoa de id " + id;
    }
}
