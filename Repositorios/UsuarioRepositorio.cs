using WebAPIs.Data;
using WebAPIs.Models;
using WebAPIs.Repositorios.Interfaces;

namespace WebAPIs.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTaferasDBContext _dbContext;
        public UsuarioRepositorio(SistemaTaferasDBContext sistemaTaferasDBContext) 
        {
            _dbContext = sistemaTaferasDBContext;


        }


        public Task<UsuarioModel> BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }


    }
}
