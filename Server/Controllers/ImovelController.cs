using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
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
        var imoveis = await banco.Imovel.ToListAsync();
        return Ok(imoveis);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<IActionResult> Get([FromQuery] string id)
    {
        var imovel = await banco.Imovel.SingleOrDefaultAsync(x => x.IdImovel == Convert.ToInt32(id));
        return Ok(imovel);
    }

    [HttpGet]
    [Route("List/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id){
        var imoveis = await banco.Imovel.FindAsync(id);
        return Ok(imoveis);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Imovel imovel){
        try
        {
            var novoImovel = new Imovel{
                TipoImovel = imovel.TipoImovel,
                IdPessoa = 1,//imovel.IdPessoa,
                Matricula = imovel.Matricula,
                Descricao = imovel.Descricao,
                CEP = imovel.CEP,
                Logradouro = imovel.Logradouro,
                Bairro = imovel.Bairro,
                Numero = imovel.Numero,
                Cidade = imovel.Cidade,
                Complemento = imovel.Complemento,
                UF = imovel.UF,
                Valor = imovel.Valor,
                Status = imovel.Status,

                QtdeQuartos = imovel.QtdeQuartos,
                QtdeBanheiros = imovel.QtdeBanheiros,
                Estacionamento = imovel.Estacionamento,
                Metragem = imovel.Metragem,
                Mobiliado = imovel.Mobiliado
            };

            banco.Add(novoImovel);
            await banco.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }
    }

    [HttpPut]
    [Route("Edit")]
    public async Task<ActionResult> Put([FromBody] Imovel imovel){
        try
        {
            var id = imovel.IdImovel;
            var imov = await banco.Imovel.FindAsync(id);
            if(imov == null){
                return NotFound();
            }

            banco.Entry(imovel).State = EntityState.Modified;

            await banco.SaveChangesAsync();
            return Ok();
        }
        catch (Exception e)
        {
            return View(e);
        }

    }

    [HttpDelete]
    [Route("Delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id){
        var imovel = await banco.Imovel.FindAsync(id);
        if(imovel == null){
            return NotFound();
        }

        banco.Imovel.Remove(imovel);
        await banco.SaveChangesAsync();
        return Ok();
    }
}