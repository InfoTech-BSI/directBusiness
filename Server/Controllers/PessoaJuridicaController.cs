using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class PessoaJuridicaController : Controller{
    private readonly AppDbContext banco;

    public PessoaJuridicaController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var pes_juridica = await banco.PessoaJuridica.ToListAsync();
        return Ok(pes_juridica);
    }

    [HttpGet]
    [Route("List/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id){
        var pes_juridica = await banco.PessoaJuridica.FindAsync(id);
        return Ok(pes_juridica);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] PessoaJuridica pessoaJuridica){
        try
        {
            var novaPessoa = new PessoaJuridica{
                IdPessoa = pessoaJuridica.IdPessoa,
                RazaoSocial = pessoaJuridica.RazaoSocial,
                CNPJ = pessoaJuridica.CNPJ
            };

            banco.Add(novaPessoa);
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
    public async Task<ActionResult> Put([FromBody] PessoaJuridica pessoaJuridica){
        try
        {
            var id = pessoaJuridica.Id;
            var pes = await banco.PessoaJuridica.FindAsync(id);
            if(pes == null){
                return NotFound();
            }

            banco.Entry(pessoaJuridica).State = EntityState.Modified;

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
        var pessoa = await banco.PessoaJuridica.FindAsync(id);
        if(pessoa == null){
            return NotFound();
        }

        banco.PessoaJuridica.Remove(pessoa);
        await banco.SaveChangesAsync();
        return Ok();
    }
}