using Peoples_Senai_Manhã.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peoples_Senai_Manhã.Interfaces
{
    public interface IPeoples
    {
        List<PeoplesDomain> ListarUsers();

        PeoplesDomain ListarUserId(int id);

        void Cadastrar(PeoplesDomain novoPeople);

        void AtualizarIdCorpo(PeoplesDomain novoPeople);

        void AtualizarIdUrl(int Id, PeoplesDomain novoPeople);
    }
}
