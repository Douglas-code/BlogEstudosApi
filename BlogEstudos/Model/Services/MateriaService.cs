using BlogEstudos.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model.Services
{
    public class MateriaService
    {
        private readonly DataContext _context;

        public MateriaService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<ICollection<Materia>> SelectAllMateriasAsync() 
        {
            var materias = await _context.Materias.Where(x => x.Id > 0).ToListAsync();

            if (materias == null)
                throw new Exception("Ocorreu um Erro!");

            return materias;
        }
    }
}
