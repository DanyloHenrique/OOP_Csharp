using ModelPosGraduacao;

namespace ModelLatoSensu;

public class LatoSensu(string nome, int cargaHoraria, int creditos, string areaGraduacao) : PosGraduacao(nome, cargaHoraria, creditos)
{
    private string AreaGraduacao {get; set;} = areaGraduacao;

}