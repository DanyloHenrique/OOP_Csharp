using ModelCurso;

namespace ModelProfessor;

public class Professor(string nome, DateTime contratacao)
{
    public string Nome { get; set; } = nome;
    public DateTime Contratacao { get; set; } = contratacao;

    public HashSet<Curso> Cursos { get; } = [];

    public void RegistrarCurso(Curso newCurso)
    {
        Cursos.Add(newCurso);
    }

    public Professor(string nome, DateTime contratacao, Curso curso) : this(nome, contratacao)
    {
        this.Nome = nome;
        this.Contratacao = contratacao;
        this.Cursos = [curso];
    } 

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return 11 + Nome == null ? 0 : Nome.GetHashCode();
    }
}