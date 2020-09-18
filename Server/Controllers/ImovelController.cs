using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class ImovelController : Controller{
    private readonly AppDbContext banco;

    public ImovelController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var imoveis = await banco.imoveis.ToListAsync();
        return Ok(imoveis);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Imovel imovel){
        try
        {
            var novoImovel = new Imovel{
                idImovel = imovel.IdImovel,
                IdTipoImovel = imovel.IdTipoImovel,
                IdPessoa = imovel.IdPessoa,
                Matricula = imovel.Matricula,
                Descricao = imovel.Descricao,
                Logradouro = imovel.Logradouro,
                Bairro = imovel.Bairro,
                Numero = imovel.Numero,
                Cidade = imovel.Cidade,
                Complemento = imovel.Complemento,
                UF = imovel.UF,
                Valor = imovel.Valor,
                Status = imovel.Status,
            }
        }
        catch (Exception e)
        {
            
            return View(e);
        }
    }
}