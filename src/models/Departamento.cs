using ModelCurso;
namespace ModelDepartamento;

public class Departamento
{
    public string Nome {get; set;}
    public IList<Curso> Cursos {get;} = [];

    //construtor
    public Departamento(string nome)
    {
        this.Nome = nome;
    }

    public void RegistrarCurso(Curso novoCurso)
    {
        Cursos.Add(novoCurso);
    }

    public int ObterQuantidadeCursos()
    {
        return Cursos.Count;
    }
    public Curso ObterCursoPorIndice(int indice)
    {
        return Cursos[indice];
    }

}