using ModelCurso;
using ModelMatricula;

namespace ModelTurma;

public class Turma(string codigoTurma, int capacidadeMaxima, PeriodoCursoEnum periodoCurso, TurnoTurmaEnum turnoTurma, Curso curso)
{
    private Curso _Curso = curso;

    public string CodigoTurma { get; set; } = codigoTurma;
    public int CapacidadeMaxima { get; set; } = capacidadeMaxima;
    public PeriodoCursoEnum PeriodoCurso { get; set; } = periodoCurso;
    public TurnoTurmaEnum TurnoTurma { get; set; } = turnoTurma;
    public Curso Curso { get { return _Curso; } }

    public HashSet<Matricula> Matriculas { get; set; } = [];

    public void RegistrarCurso(Curso curso)
    {
        this._Curso = curso;
    }

    public void RegistrarMatricula(Matricula matricula)
    {
        if (this.Matriculas.Count >= this.CapacidadeMaxima)
        {
            throw new Exception("Turma sem vagas disponíveis.");
        }
        Matriculas.Add(matricula);
        matricula.Turma = this;

    }

    public override bool Equals(object? obj)
    {
        if (obj is Turma t)
        {
            return this.CodigoTurma.Equals(t.CodigoTurma);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.CodigoTurma);
    }
}

public enum PeriodoCursoEnum
{
    Primeiro, Segundo, Terceiro, Quarto, Quinto, Sexto, Setimo, Oitavo
}

public enum TurnoTurmaEnum
{
    Matutino = 1, Vespertino = 3, Noturno
}