using Data.AppContext;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class CategoriaRepository : IBaseCrudGenerico<Categoria>
    {
        private readonly Context context;

        public CategoriaRepository(Context context)
        {
            this.context = context;
        }

        public async Task<Categoria> Atualizar(Categoria entity)
        {
            try
            {
                var result = context.Categorias.Update(entity);
                await context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Categoria> BuscarPorReferencia(string referencia)
            => await context.Categorias.SingleOrDefaultAsync(c => c.NomeCategoria.ToLower().Contains(referencia.ToLower()));

        public async Task<IEnumerable<Categoria>> BuscarTodos() =>
               await context.Categorias.OrderByDescending(x => x.DataCriacao).ToListAsync();

        public async Task<Categoria> Criar(Categoria entity)
        {
            try
            {
                var result = await context.Categorias.AddAsync(entity);
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
                var result = await context.Categorias.SingleAsync(c => c.Id == id);
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
