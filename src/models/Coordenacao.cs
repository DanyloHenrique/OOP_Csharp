using ModelCurso;
using ModelProfessor;

namespace ModelCoordenacao;

public class Coordenacao(string nome, DateTime contratacao, DateTime inicio, Curso cursoCoordenacao) : Professor(nome, contratacao)
{
    public DateTime Inicio {get;set;} = inicio;
    public Curso CursoCoordenado {get; private set;} = cursoCoordenacao;

    public Coordenacao(Professor professorExistente, DateTime inicio, Curso cursoCoordenacao) : this(professorExistente.Nome, professorExistente.Contratacao, inicio, cursoCoordenacao)
    {
        foreach(var curso in professorExistente.Cursos)
            this.RegistrarCurso(curso);
    }

    public void AlterarCurso(Curso novoCurso)
    {
        this.CursoCoordenado = novoCurso;
    }
}
