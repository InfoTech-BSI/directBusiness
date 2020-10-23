using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class ControllerController : Controller{
    private readonly AppDbContext banco;

    public ControllerController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var imoveis = await banco.Contrato.ToListAsync();
        return Ok(imoveis);
    }

    [HttpGet]
    [Route("List/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id){
        var imoveis = await banco.Contrato.FindAsync(id);
        return Ok(imoveis);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Contrato contrato){
        try
        {
            var novoContrato = new Contrato{
                IdTipoContrato = contrato.IdTipoContrato,
                IdImovel = contrato.IdImovel,
                IdProprietario = contrato.IdProprietario,
                IdInteressado = contrato.IdInteressado,
                DataInicio = contrato.DataInicio,
                DataFim = contrato.DataFim,
                ValorNegociado = contrato.ValorNegociado,
                Texto = contrato.Texto
            };

            banco.Add(novoContrato);
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
    public async Task<ActionResult> Put([FromBody] Contrato contrato){
        try
        {
            var id = contrato.IdContrato;
            var con = await banco.Contrato.FindAsync(id);
            if(con == null){
                return NotFound();
            }

            banco.Entry(contrato).State = EntityState.Modified;

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
        var contrato = await banco.Contrato.FindAsync(id);
        if(contrato == null){
            return NotFound();
        }

        banco.Contrato.Remove(contrato);
        await banco.SaveChangesAsync();
        return Ok();
    }
}