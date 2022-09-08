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
    public Person Post(Person pessoa)
    {
        return pessoa;
    }

    [HttpPatch("{id}")]
    public string Update(int id)
    {
        return "Dados do id " + id + " atualizados";
    }
}
