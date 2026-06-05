using System.Data;
using ModelCurso;

namespace ModelProfessor;

public class Professor(string nome, DateTime contratacao)
{
    public string Nome { get; set; } = nome;
    public DateTime Contratacao { get; set; } = contratacao;

    public HashSet<Curso> Cursos { get; } = [];

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
    public override int GetHashCode()
    {
        return 11 + Nome == null ? 0 : Nome.GetHashCode();
    }
}