using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class PessoaFisicaController : Controller{
    private readonly AppDbContext banco;

    public PessoaFisicaController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var pes_fisicas = await banco.PessoaFisica.ToListAsync();
        return Ok(pes_fisicas);
    }

    [HttpGet]
    [Route("List/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id){
        var pes_fisicas = await banco.PessoaFisica.FindAsync(id);
        return Ok(pes_fisicas);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] PessoaFisica pessoaFisica){
        try
        {
            Pessoa pessoa = new Pessoa();
            pessoa = pessoaFisica.Pessoa;

            var novaPessoa = new PessoaFisica{
                EstadoCivil = pessoaFisica.EstadoCivil,
                RG = pessoaFisica.RG,
                CPF = pessoaFisica.CPF,
                DataNascimento = pessoaFisica.DataNascimento,
                Nome = pessoaFisica.Nome,
                Pessoa = pessoa
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
    public async Task<ActionResult> Put([FromBody] PessoaFisica pessoaFisica){
        try
        {
            var id = pessoaFisica.Id;
            var pes = await banco.PessoaFisica.FindAsync(id);
            if(pes == null){
                return NotFound();
            }

            banco.Entry(pessoaFisica).State = EntityState.Modified;

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
        var pessoa = await banco.PessoaFisica.FindAsync(id);
        if(pessoa == null){
            return NotFound();
        }

        banco.PessoaFisica.Remove(pessoa);
        await banco.SaveChangesAsync();
        return Ok();
    }
}