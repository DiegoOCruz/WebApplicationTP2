using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using WebApplicationTP2.Models;

namespace WebApplicationTP2.Pages
{
    public class PessoaModel : PageModel
    {
        public Pessoa p;
        public List<Pessoa> pessoaList { get; set; }
        public void OnGet()
        {
            pessoaList = new List<Pessoa>();
            pessoaList.Add(new Pessoa { Nome = "Diego", Idade = 34, Cpf = "123.456.789-10" });
            pessoaList.Add(new Pessoa { Nome = "Maria", Idade = 28, Cpf = "987.654.321-00" });
            pessoaList.Add(new Pessoa { Nome = "João", Idade = 40, Cpf = "456.789.123-45" });
            pessoaList.Add(new Pessoa { Nome = "Ana", Idade = 25, Cpf = "789.123.456-78" });
            pessoaList.Add(new Pessoa { Nome = "Carlos", Idade = 50, Cpf = "321.654.987-00" });
            pessoaList.Add(new Pessoa { Nome = "Julia", Idade = 22, Cpf = "654.321.987-10" });
            pessoaList.Add(new Pessoa { Nome = "Pedro", Idade = 37, Cpf = "987.654.321-01" });
            pessoaList.Add(new Pessoa { Nome = "Mariana", Idade = 31, Cpf = "789.123.456-12" });
            pessoaList.Add(new Pessoa { Nome = "Lucas", Idade = 29, Cpf = "321.654.987-23" });
            pessoaList.Add(new Pessoa { Nome = "Laura", Idade = 35, Cpf = "654.321.987-34" });

        }
    }
}
