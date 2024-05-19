using Domain.Models;

namespace Domain.Interfaces
{
    public interface CategoriaRepository
    {
        Task<Categoria> AtualizarCategoria(string nome, int id);
    }
}
