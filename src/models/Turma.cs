using ModelCurso;

namespace ModelTurma;

public class Turma
{
    private Curso _Curso;

    public string CodigoTurma {get; set;}
    public PeriodoCursoEnum PeriodoCurso {get; set;}
    public TurnoTurmaEnum TurnoTurma {get;set;}
    public Curso Curso {get {return _Curso;} }

    public void RegistrarCurso(Curso curso)
    {
        this._Curso = curso;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
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