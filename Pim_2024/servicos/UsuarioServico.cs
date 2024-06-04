using Pim_2024.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_2024.servicos
{
    public class UsuarioServico
    {
        public bool Entrar(Usuario usuario)
        {
            if(usuario == null) return false;
            if(usuario.login == "kkk") return false;
            return true;
        }
    }
}
