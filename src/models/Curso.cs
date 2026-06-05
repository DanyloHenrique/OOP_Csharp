using ModelAluno;
using ModelCoordenacao;
using ModelDisciplina;
using ModelProfessor;
using ModelTurma;

namespace ModelCurso;

// criando classe usando construtor primário

/*um construtor primário colocando todos os parâmetros de construtor
 em parênteses após o nome do tipo. Um construtor primário indica
  que esses parâmetros são necessários para qualquer instância do tipo.*/

abstract public class Curso(string nome, int cargaHoraria)
{
    public string Nome { get; set; } = nome;
    public int CargaHoraria { get; set; } = cargaHoraria;
    public HashSet<Disciplina> Disciplinas { get; } = [];
    public List<Turma> Turmas { get; } = [];
    public HashSet<Aluno> Alunos { get; } = [];
    public HashSet<Professor> Professores {get;} = [];
    public Coordenacao? Coordenador {get; set;}

    // disciplinas
    public void RegistrarDisciplina(Disciplina newDisciplina)
    {
        Disciplinas.Add(newDisciplina);
    }
    public void RegistrarDisciplina(string nomeDisciplina, int cargaHorariaDisciplina)
    {
        Disciplina novaDisciplina = new Disciplina(nomeDisciplina, cargaHorariaDisciplina, this);
        Disciplinas.Add(novaDisciplina);
    }

    public int ObterQuantidadeDisciplinasDoCurso()
    {
        return Disciplinas.Count;
    }
    public Disciplina ObterDisciplinaPorNome(string nome)
    {
        return Disciplinas.FirstOrDefault(item => item.Nome.Equals(nome));
    }

    // turmas
    public void RegistrarTurma(Turma newTurma)
    {
        Turmas.Add(newTurma);
    }

    public int ObterQuantidadeTurmasDoCurso()
    {
        return Turmas.Count;
    }

    public Turma ObterTurmaPorCodigo(string codigoTurma)
    {
        return Turmas.FirstOrDefault(item => item.CodigoTurma.Equals(codigoTurma));
    }

    public void RegistrarAluno(Aluno newAluno)
    {
        Alunos.Add(newAluno);
    }

    public void RegistrarProfessor(Professor newProfessor)
    {
        Professores.Add(newProfessor);
    }

    public void DefinirCoordenador(Coordenacao newCoordenador)
    {
        this.Coordenador = newCoordenador;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Curso)
        {
            Curso c = obj as Curso;
            return this.Nome.Equals(c.Nome);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return (11 + this.Nome == null ? 0 : this.Nome.GetHashCode());
    }
}
