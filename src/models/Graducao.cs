using ModelCurso;
using ModelTurma;

namespace ModelGraduacao;

// usando herança
//graduacao é um tipo de Curso
public class Graduacao(string nome, int cargaHoraria, Turma primeiraTurma int semestres) : Curso(nome, cargaHoraria, primeiraTurma)
{
    public int Semestres {get;set;} = semestres;
}