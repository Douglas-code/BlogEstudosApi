using BlogEstudos.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model.Services
{
    public class PublicacaoService
    {
        private readonly DataContext _context;

        public PublicacaoService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<ICollection<Publicacao>> SelectAllPublicacoes(int usuarioId) 
        {
            var publicacoes = await _context.Publicacoes.Where(x => x.Id > 0 && x.UsuarioId == usuarioId)
                .Include(x => x.Usuario)
                .Include(x => x.Materia)
                .ToListAsync();

            foreach (var p in publicacoes)
            {
                p.Usuario.Login = "";
                p.Usuario.Senha = "";
            }

            if (publicacoes == null)
                throw new Exception("Ocorreu um erro!");

            return publicacoes;
        } 

        public async Task CriarPublicaoAsync(Publicacao publicacao)
        {
            try
            {
                _context.Publicacoes.Add(publicacao);
                await _context.SaveChangesAsync();
            }
            catch (Exception )
            {
                throw new Exception("Erro ao cadastrar");
            }
        }
    }
}
