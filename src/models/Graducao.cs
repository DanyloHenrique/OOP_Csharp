using ModelCurso;
using ModelDisciplina;
using ModelTurma;

namespace ModelGraduacao;

// usando herança
//graduacao é um tipo de Curso
public class Graduacao(string nome, int cargaHoraria, int semestres) : Curso(nome, cargaHoraria)
{
    public int Semestres {get;set;} = semestres;

    public override void RegistrarDisciplina(Disciplina newDisciplina)
    {
        if(Disciplinas.Count < 24)
            Disciplinas.Add(newDisciplina);
    }
}