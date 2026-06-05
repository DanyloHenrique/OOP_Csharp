using ModelCurso;

namespace ModelGraduacao;

// usando herança
//graduacao é um tipo de Curso
public class Graduacao(string nome, int cargaHoraria, int semestres) : Curso(nome, cargaHoraria)
{
    public int Semestres {get;set;} = semestres;
}