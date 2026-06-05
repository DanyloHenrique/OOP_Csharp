using ModelAluno;
using ModelDisciplina;
using ModelTurma;

namespace ModelMatricula;

public class Matricula(Aluno aluno, Turma turma, Disciplina disciplina)
{
    public Aluno Aluno { get; } = aluno;
    public Turma Turma { get; set; } = turma;
    public Disciplina Disciplinas { get; } = disciplina;

    public override bool Equals(object? obj)
    {
        if (obj is Matricula m)
        {
            return this.Aluno.Equals(m.Aluno) && this.Turma.Equals(m.Turma) && this.Disciplinas.Nome.Equals(m.Disciplinas.Nome);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.Aluno, this.Turma, this.Disciplinas);
    }
}