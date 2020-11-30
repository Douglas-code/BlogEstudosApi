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

        public async Task<ICollection<Publicacao>> SelectPublicacoes(int usuarioId)
        {
            var materias = await _context.UsuariosMaterias.Where(x => x.UsuarioId == usuarioId).Select(x => x.MateriaId).ToListAsync();

            var publi = await _context.Publicacoes.Where(x => x.Id > 0)
                   .Include(x => x.Usuario)
                   .Include(x => x.Materia)
                   .ToListAsync();

            List<Publicacao> publicacoes = new List<Publicacao>();

            foreach (var mt in materias)
            {
                publicacoes.AddRange(publi.Where(x => x.MateriaId == mt).ToList());
            }

            return publicacoes;
        }

        public async Task CriarPublicaoAsync(Publicacao publicacao)
        { 
            try
            {
                publicacao.DataPublicacao = DateTime.Now;
                _context.Publicacoes.Add(publicacao);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao cadastrar");
            }
        }
    }
}
