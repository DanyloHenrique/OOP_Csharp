using ModelCurso;
using ModelMatricula;

namespace ModelAluno;

public class Aluno(string nome, Curso cursoInicial)
{    
    public string Nome { get; set; } = nome;
    public List<Curso> Cursos { get; set; } = [cursoInicial];
    public List<Matricula> Matriculas { get; } = [];

    public void MatricularCurso(Curso newCurso)
    {
        if (!Cursos.Contains(newCurso))
        {
            Cursos.Add(newCurso);
        }
    }

    public void AdicionarMatricula(Matricula newMatricula)
    {
        if (!Matriculas.Contains(newMatricula))
        {
            Matriculas.Add(newMatricula);
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj is Aluno a)
        {
            return this.Nome.Equals(a.Nome);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.Nome);
    }

}