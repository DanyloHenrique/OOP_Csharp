using ModelCurso;

namespace ModelPosGraduacao;

// usando herança
//pos graducao é um tipo de Curso, mas abstract então não pode ser instanciada
//servira de base para classe LatoSensu e StrictSensu
abstract public class PosGraduacao(string nome, int cargaHoraria, int creditos) : Curso(nome, cargaHoraria)
{
    public int Creditos {get;set;} = creditos;

}