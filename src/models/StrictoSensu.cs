using ModelPosGraduacao;

namespace ModelStrictoSensu;

public class StrictoSensu(string nome, int cargaHoraria, int creditos) : PosGraduacao(nome, cargaHoraria, creditos)
{
    public IList<string> LinhasDePesquisa {get;} = [];
}