using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class CaracteristicaImovelController : Controller{
    private readonly AppDbContext banco;

    public CaracteristicaImovelController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var caracteristicas = await banco.CaracteristicaImovel.ToListAsync();
        return Ok(caracteristicas);
    }

    [HttpGet]
    [Route("List/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id){
        var caracteristicas = await banco.CaracteristicaImovel.FindAsync(id);
        return Ok(caracteristicas);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] CaracteristicaImovel caracteristicas){
        try
        {
            var novaCaracteristicaImovel = new CaracteristicaImovel{
                IdImovel = caracteristicas.IdImovel,
                QtdeQuartos = caracteristicas.QtdeQuartos,
                QtdeBanheiros = caracteristicas.QtdeBanheiros,
                Estacionamento = caracteristicas.Estacionamento,
                Metragem = caracteristicas.Metragem,
                //Pets = caracteristicas.Pets,
                Mobiliado = caracteristicas.Mobiliado,
                //Apartamento = caracteristicas.Apartamento
            };

            banco.Add(novaCaracteristicaImovel);
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
    public async Task<ActionResult> Put([FromBody] CaracteristicaImovel caracteristica){
        try
        {
            var id = caracteristica.IdCarac;
            var carac = await banco.CaracteristicaImovel.FindAsync(id);
            if(carac == null){
                return NotFound();
            }

            banco.Entry(caracteristica).State = EntityState.Modified;

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
        var caracteristica = await banco.CaracteristicaImovel.FindAsync(id);
        if(caracteristica == null){
            return NotFound();
        }

        banco.CaracteristicaImovel.Remove(caracteristica);
        await banco.SaveChangesAsync();
        return Ok();
    }
}