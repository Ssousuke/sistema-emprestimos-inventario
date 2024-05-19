using Data.AppContext;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class EquipamentoRepository(Context context) : IBaseCrudGenerico<Equipamento>
    {
        public async Task<Equipamento> Atualizar(Equipamento entity)
        {
            try
            {
                var result = context.Equipamentos.Update(entity);
                await context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Equipamento> BuscarPorReferencia(string referencia) =>
               await context.Equipamentos.SingleAsync(c => c.NomeEquipamento.ToLower().Contains(referencia.ToLower()));

        public async Task<IEnumerable<Equipamento>> BuscarTodos() =>
               await context.Equipamentos.ToListAsync();

        public async Task<Equipamento> Criar(Equipamento entity)
        {
            try
            {
                var result = await context.Equipamentos.AddAsync(entity);
                await context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> Deletar(int id)
        {
            try
            {
                var result = await context.Equipamentos.SingleAsync(c => c.Id == id);
                context.Remove(result);
                return await context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
