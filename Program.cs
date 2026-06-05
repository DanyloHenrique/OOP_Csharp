// See https://aka.ms/new-console-template for more information
using ModelInstituicao;
using ModelDepartamento;
using ModelEndereco;
using ModelDisciplina;
using ModelGraduacao;
using ModelLatoSensu;
using ModelStrictoSensu;
using RepositoryCurso;
using ModelCurso;
using ModelTurma;
using ModelAluno;
using ModelMatricula;
using ModelProfessor;
using ModelCoordenacao;

var endereco = new Endereco(rua: "São Francisco Xavie", numero: "524", bairro: "Maracanã");

var uerj = new Instituicao(nome: "Universidade do Estado do Rio de Janeiro", endereco: endereco);
Departamento uComp = new Departamento("Computação");
uerj.RegistrarDepartamento(uComp);

Graduacao cc = new Graduacao("Ciências da Computação", 3200, 8);
uComp.RegistrarCurso(cc);
Disciplina ed1 = new Disciplina("Estrutura de Dados 1", 80, cc);
cc.RegistrarDisciplina(ed1);

Turma turma01 = new Turma(codigoTurma: "01", capacidadeMaxima: 60, periodoCurso: PeriodoCursoEnum.Primeiro, turnoTurma: TurnoTurmaEnum.Matutino, curso: cc);
cc.RegistrarTurma(turma01);

Console.Write($"curso graduacao: {cc.Nome}, que possui as disciplinas: ");
foreach (var disciplina in cc.Disciplinas)
{
    Console.Write(disciplina.Nome);
}

Console.WriteLine("\nE as turmas: ");
foreach(var turma in cc.Turmas)
{
    Console.Write($"código: {turma.CodigoTurma} - Do {turma.PeriodoCurso} perído e com capacidade de {turma.CapacidadeMaxima} alunos ");
}
Console.WriteLine();

Aluno aluno01 = new Aluno("Danylo Henrique", cc);
cc.RegistrarAluno(aluno01);


Matricula matricula01 =  new Matricula(aluno: aluno01, turma: turma01, disciplina: ed1);
turma01.RegistrarMatricula(matricula01);
aluno01.AdicionarMatricula(matricula01);
ed1.RegistarMatricula(matricula01);

Console.WriteLine("==> Matrículas: ");
Console.WriteLine($"{matricula01.Turma.CodigoTurma}, {matricula01.Aluno.Nome}, {matricula01.Disciplinas.Nome}");


Professor professor01 = new Professor("Junior Henrique", DateTime.UtcNow, cc);
Professor professor02 = new Professor("pelé Henrique", DateTime.UtcNow, cc);
Coordenacao coordenador01 = new Coordenacao(professor01, DateTime.UtcNow, cc);
cc.RegistrarProfessor(professor01);
cc.RegistrarProfessor(professor02);


Console.WriteLine($"Professor do curso {cc}: ");
foreach(var professor in cc.Professores)
    Console.WriteLine($"{professor.Nome} - data de contratação: {professor.Contratacao}");
