namespace ModelDisciplina;

public class Disciplina(string nome, int cargaHoraria)
{
    public string Nome {get;set;} = nome;
    public int CargaHoraria {get;set;} = cargaHoraria;

    public override bool Equals(object? obj)
    {
        if(obj is Disciplina)
        {
            Disciplina d = obj as Disciplina;
            return this.Nome.Equals(d.Nome);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return 11 + this.Nome == null ? 0 : this.Nome.GetHashCode();
    }

}