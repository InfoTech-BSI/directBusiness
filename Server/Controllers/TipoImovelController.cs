using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class TipoImovelController : Controller{
    private readonly AppDbContext banco;

    public TipoImovelController(AppDbContext db){
        this.banco = db;
    }

    // [HttpGet]
    // [Route("List")]
    // public async Task<IActionResult> Get(){
    //     var tipoImoveis = await banco.TipoImovel.ToListAsync();
    //     return Ok(tipoImoveis);
    // }

    // [HttpGet]
    // [Route("List/{id}")]
    // public async Task<IActionResult> GetById([FromRoute] int id){
    //     var tipoImovel = await banco.TipoImovel.FindAsync(id);
    //     return Ok(tipoImovel);
    // }

    // [HttpPost]
    // [Route("Create")]
    // public async Task<ActionResult> Post([FromBody] TipoImovel tipoImovel){
    //     try
    //     {
    //         var novoTipoImovel = new TipoImovel{
    //             Descricao = tipoImovel.Descricao
    //         };

    //         banco.Add(novoTipoImovel);
    //         await banco.SaveChangesAsync();
    //         return Ok();
    //     }
    //     catch (Exception e)
    //     {
    //         return View(e);
    //     }
    // }

    // [HttpPut]
    // [Route("Edit")]
    // public async Task<ActionResult> Put([FromBody] TipoImovel tipoImovel){
    //     try
    //     {
    //         var id = tipoImovel.IdTipoImovel;
    //         var tipo = await banco.TipoImovel.FindAsync(id);
    //         if(tipo == null){
    //             return NotFound();
    //         }

    //         banco.Entry(tipoImovel).State = EntityState.Modified;

    //         await banco.SaveChangesAsync();
    //         return Ok();
    //     }
    //     catch (Exception e)
    //     {
    //         return View(e);
    //     }

    // }

    // [HttpDelete]
    // [Route("Delete/{id}")]
    // public async Task<IActionResult> Delete([FromRoute] int id){
    //     var tipo = await banco.TipoImovel.FindAsync(id);
    //     if(tipo == null){
    //         return NotFound();
    //     }

    //     banco.TipoImovel.Remove(tipo);
    //     await banco.SaveChangesAsync();
    //     return Ok();
    // }
}