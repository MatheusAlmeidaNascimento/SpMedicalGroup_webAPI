using spmedical_webAPI.Context;
using spmedical_webAPI.Domains;
using spmedical_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_webAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        SPMedicalGroupContext ctx = new SPMedicalGroupContext();

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
