namespace ModelInstituicao;

using ModelDepartamento;
using ModelEndereco;

class Instituicao(string nome, Endereco endereco)
{
    public string Nome { get; set; } = nome;
    public Endereco Endereco { get; set; } = endereco;

    public Departamento[] ListaDepartamentos { get; } = new Departamento[10];
    private int qtdDepartamentos = 0;
    public void RegistrarDepartamento(Departamento novoDepartamento)
    {
        if (qtdDepartamentos < 10)
        {
            ListaDepartamentos[qtdDepartamentos++] = novoDepartamento;
        }
    }

    public int ObterQuantidadeDepartamentos()
    {
        return qtdDepartamentos;
    }

    public Departamento DepartamentoPorIndice(int indice)
    {
        return ListaDepartamentos[indice];
    }
}