using Microsoft.EntityFrameworkCore;
using UsuarioAPI.Models;

namespace UsuarioAPI.Context
{
    public class APIdbContext:DbContext
    {
        public APIdbContext(DbContextOptions<APIdbContext>options): base(options) 
        {
            
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
