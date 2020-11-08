using System;
using System.Threading.Tasks;
using DirectBusiness.Server;
using DirectBusiness.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class PessoaController : Controller{
    private readonly AppDbContext banco;

    public PessoaController(AppDbContext db){
        this.banco = db;
    }

    [HttpGet]
    [Route("List")]
    public async Task<IActionResult> Get(){
        var pessoas = await banco.Pessoa.ToListAsync();
        return Ok(pessoas);
    }

    [HttpGet]
    [Route("List/{id}")]
    public async Task<IActionResult> GetById([FromRoute] int id){
        var pessoa = await banco.Pessoa.FindAsync(id);
        return Ok(pessoa);
    }

    [HttpPost]
    [Route("Create")]
    public async Task<ActionResult> Post([FromBody] Pessoa pessoa){
        try
        {
            var novaPessoa = new Pessoa{
                Email = pessoa.Email,
                Renda = pessoa.Renda,
                Telefone = pessoa.Telefone,
                CEP = pessoa.CEP,
                Endereco = pessoa.Endereco,
                Bairro = pessoa.Bairro,
                Numero = pessoa.Numero,
                Cidade = pessoa.Cidade,
                Complemento = pessoa.Complemento,
                Uf = pessoa.Uf,
                Login = pessoa.Login,
                Senha = pessoa.Senha
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
    public async Task<ActionResult> Put([FromBody] Pessoa pessoa){
        try
        {
            var id = pessoa.IdPessoa;
            var pes = await banco.Pessoa.FindAsync(id);
            if(pes == null){
                return NotFound();
            }

            banco.Entry(pessoa).State = EntityState.Modified;

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
        var pessoa = await banco.Pessoa.FindAsync(id);
        if(pessoa == null){
            return NotFound();
        }

        banco.Pessoa.Remove(pessoa);
        await banco.SaveChangesAsync();
        return Ok();
    }
}