using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class TipoContratoController : Controller{
    private readonly AppDbContext banco;

    public TipoContratoController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var tipoContratos = await banco.TipoContrato.ToListAsync();
        return Ok(tipoContratos);
    }

    [HttpGet]
    [Route("List/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id){
        var tipoContratos = await banco.TipoContrato.FindAsync(id);
        return Ok(tipoContratos);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] TipoContrato tipoContrato){
        try
        {
            var novoTipoContrato = new TipoContrato{
                Descricao = tipoContrato.Descricao
            };

            banco.Add(novoTipoContrato);
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
    public async Task<ActionResult> Put([FromBody] TipoContrato tipoContrato){
        try
        {
            var id = tipoContrato.IdTipoContrato;
            var tipo = await banco.TipoContrato.FindAsync(id);
            if(tipo == null){
                return NotFound();
            }

            banco.Entry(tipoContrato).State = EntityState.Modified;

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
        var tipo = await banco.TipoContrato.FindAsync(id);
        if(tipo == null){
            return NotFound();
        }

        banco.TipoContrato.Remove(tipo);
        await banco.SaveChangesAsync();
        return Ok();
    }
}