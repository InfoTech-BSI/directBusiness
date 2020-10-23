using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class MidiaController : Controller{
    private readonly AppDbContext banco;

    public MidiaController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var midias = await banco.Midia.ToListAsync();
        return Ok(midias);
    }

    [HttpGet]
    [Route("List/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id){
        var midias = await banco.Midia.FindAsync(id);
        return Ok(midias);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Midia midia){
        try
        {
            var novaMidia = new Midia{
                IdImovel = midia.IdImovel,
                Link = midia.Link
            };

            banco.Add(novaMidia);
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
    public async Task<ActionResult> Put([FromBody] Midia midia){
        try
        {
            var id = midia.IdMidia;
            var mid = await banco.Midia.FindAsync(id);
            if(mid == null){
                return NotFound();
            }

            banco.Entry(midia).State = EntityState.Modified;

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
        var midia = await banco.Midia.FindAsync(id);
        if(midia == null){
            return NotFound();
        }

        banco.Midia.Remove(midia);
        await banco.SaveChangesAsync();
        return Ok();
    }
}