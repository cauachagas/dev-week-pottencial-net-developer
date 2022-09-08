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
        pessoa.Contratos.Add(novoContrato);
        return pessoa;
    }
}
