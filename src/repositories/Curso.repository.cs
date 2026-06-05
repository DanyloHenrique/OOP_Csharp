using System.Linq;
using ModelCurso;
using IRepository;


namespace RepositoryCurso;

class RepositorioCurso : IRepository<Curso>
{
    public HashSet<Curso> Cursos { get; } = [];

    public void Gravar(Curso curso)
    {
        Cursos.Add(curso);
    }

    public Curso? ObterPorId(string nome)
    {
        return Cursos.FirstOrDefault(item => item.Nome.Equals(nome));
    }

    public IEnumerable<Curso> ObterTodos()
    {
        return Cursos;
    }

    public void Remover(Curso curso)
    {
        Cursos.Remove(curso);
    }
}