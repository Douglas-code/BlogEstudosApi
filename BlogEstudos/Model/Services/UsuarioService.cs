using BlogEstudos.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model.Services
{
    public class UsuarioService
    {
        private readonly DataContext _context;
        
        public UsuarioService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public bool TestaSeCamposForamPrencehidos(Usuario usuario)
        {
            if(usuario.Login != string.Empty && usuario.Nome != string.Empty && usuario.Senha != string.Empty) 
            {
                return true;
            }

            return false;
        }

        public Usuario EscoderSenha(Usuario usuario)
        {
            usuario.Senha = "";

            return usuario;
        }

        public async Task InsertUsuarioAsync(Usuario usuario)
        {
            if (!TestaSeCamposForamPrencehidos(usuario))
                throw new Exception("Preencha os campos");

            try
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw new Exception("Erro ao cadastrar funcionario");
            }   
        }

        public async Task<Usuario> Login(string login, string senha)
        {
            Usuario usuario = await _context.Usuarios.Where(x => x.Login == login && x.Senha == senha)
                .FirstOrDefaultAsync();

            if (usuario == null)
                throw new Exception("Usuario ou senha incorretos");

            usuario = EscoderSenha(usuario);

            return usuario;
        }
    }
}
