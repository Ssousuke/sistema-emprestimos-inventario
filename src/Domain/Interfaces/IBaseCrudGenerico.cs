namespace Domain.Interfaces
{
    public interface IBaseCrudGenerico<T> where T : class
    {
        Task<IEnumerable<T>> BuscarTodos();
        Task<T> BuscarPorReferencia(string referencia);
        Task<T> Criar(T entity);
        Task<T> Atualizar(T entity);
        Task<bool> Deletar(int id);
    }
}
