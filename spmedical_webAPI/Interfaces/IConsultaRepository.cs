using spmedical_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedical_webAPI.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> ListarMinhas(int idUsuario);

        void Inscrever(Consulta inscricao);

        void AprovarRecusar(int idConsulta, string status);
    }
}
