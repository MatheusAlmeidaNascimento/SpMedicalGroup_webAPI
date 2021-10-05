using Microsoft.EntityFrameworkCore;
using spmedical_webAPI.Context;
using spmedical_webAPI.Domains;
using spmedical_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_webAPI.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {

        SPMedicalGroupContext ctx = new SPMedicalGroupContext();
        public void AprovarRecusar(int idConsulta, string status)
        {
            throw new NotImplementedException();
        }

        public void Inscrever(Consulta inscricao)
        {
            inscricao.IdSituacao = 3;

            ctx.Consulta.Add(inscricao);

            ctx.SaveChanges();
        }

        public List<Consulta> ListarMinhas(int idUsuario)
        {
            return ctx.Consulta
                
                .Include(p => p.IdPacienteNavigation)
                .Include(e => e.IdMedicoNavigation)
                .Where(p => p.IdConsulta == idUsuario)
                .ToList();
        }   
    }
}
