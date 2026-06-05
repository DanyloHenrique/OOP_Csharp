// See https://aka.ms/new-console-template for more information
using ModelInstituicao;
using ModelDepartamento;
using ModelEndereco;
using ModelDisciplina;
using ModelGraduacao;
using ModelLatoSensu;
using ModelStrictoSensu;
using RepositoryCurso;

var endereco = new Endereco(rua: "São Francisco Xavie", numero: "524", bairro: "Maracanã");
var uerj = new Instituicao(nome: "Universidade do Estado do Rio de Janeiro", endereco: endereco);

Departamento dptoEnsino = new Departamento("Computação");

// criando cursos de graduacao e pos graduacao (latosensu e strictosensu)
var graducao = new Graduacao("Ciências da Computação", 3200, 8);
var latoSensu = new LatoSensu("Sistemas de Computadores", 3200, 300, "Desenvolvimento de Sistemas");
var strictoSenso = new StrictoSensu("Sistemas Computacionais Para Matemática Ciêntifica", 3200, 200);

// instancia de repositorio
var repositoryCursos = new RepositorioCurso();
repositoryCursos.Gravar(graducao);
repositoryCursos.Gravar(latoSensu);
repositoryCursos.Gravar(strictoSenso);

Console.WriteLine();
Console.WriteLine("Cursos gravados");
foreach (var curso in repositoryCursos.ObterTodos())
{
    Console.WriteLine($"==> {curso.Nome} ({curso.GetType()})");
}



graducao.RegistrarDisciplina(new Disciplina("Estrutura de dados 1", 80));
graducao.RegistrarDisciplina("Orientação a Objetos 1", 60);
graducao.RegistrarDisciplina("Orientação a Objetos 2", 60);


Console.WriteLine($"Universidade: {uerj.Nome}");
Console.WriteLine($"Localizada em: {uerj.Endereco.Rua}, {uerj.Endereco.Numero} - {uerj.Endereco.Bairro}");

Console.WriteLine($"== Cursos no departamento de {dptoEnsino.Nome} ==");
foreach (var curso in dptoEnsino.Cursos)
{
    Console.WriteLine($"==> {curso.Nome} - {curso.CargaHoraria}h");
}

// Console.WriteLine($"O curso {cursoCC.Nome} possui {cursoCC.Disciplinas.Count} disciplinas:");
// foreach (var d in cursoCC.Disciplinas)
// {
//     Console.WriteLine($"==> {d.Nome} ({d.CargaHoraria})");
// }
