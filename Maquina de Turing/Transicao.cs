using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_de_Turing
{
    class Transicao
    {
        Estado estado;
        String digito;
        String direcao;
        int linha;
        int coluna;
        

        public String Digito { get => digito; set => digito = value; }
        public String Direcao { get => direcao; set => direcao = value; }
        public int Coluna { get => coluna; set => coluna = value; }
        public int Linha { get => linha; set => linha = value; }
        internal Estado Estado { get => estado; set => estado = value; }
    }
}
