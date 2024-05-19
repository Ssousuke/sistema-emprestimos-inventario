using Domain.Models;

namespace Domain.Interfaces
{
    public interface EquipamentoRepository
    {
        Task<Equipamento> AtualizarNomeEquipamento(string nome, int id);
        Task<Equipamento> AtualizarCategoria(Categoria categoria, int id);
        Task<bool> RemoverEquipamento(int quantidade, int id);
        Task<bool> AdicionarEquipamento(int quantidade, int id);
    }
}
