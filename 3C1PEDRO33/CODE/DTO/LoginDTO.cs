using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1PEDRO33.CODE.DTO
{
    internal class LoginDTO
    {
        private int iD;
        private string senha;
        private string usuario;

        public int ID { get => iD; set => iD = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
