using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogEstudos.Model.Services
{
    public class ArquivosService
    {
        public static IWebHostEnvironment _environment;

        public ArquivosService(IWebHostEnvironment environment) 
        {
            _environment = environment;
        }

        public async Task<string> UploadAsync(IFormFile file, int publicacao_id)
        { 
            if(file.Length > 0)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Arquivos\\" + $"\\{publicacao_id}\\"))
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Arquivos\\" + $"\\{publicacao_id}\\");

                    using(FileStream fileStream = File.Create(_environment.WebRootPath + "\\Arquivos\\" +
                        $"\\{publicacao_id}\\" + file.FileName)) 
                    {
                        await file.CopyToAsync(fileStream);
                        fileStream.Flush();
                        return "\\Arquivos\\" + $"\\{publicacao_id}\\" + file.FileName;
                    }
                }
                catch(Exception e)
                {
                    return e.Message;
                }
            }
            else
            {
                return "Erro ao enviar arquivo";
            }
        }
    }
}
