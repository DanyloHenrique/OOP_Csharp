namespace IRepository;

public interface IRepository<T>
{
    T? ObterPorId(string nome);
    IEnumerable<T> ObterTodos();
    void Gravar(T objeto);
    void Remover(T objeto);
}