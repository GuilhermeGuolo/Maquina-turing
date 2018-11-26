using System;

namespace Maquina_de_Turing
{
    class Estado
    {
        String estadoProximo;
        Boolean isFinal;
        int linhaEstado;

        public Estado(string estadoProximo, bool isFinal, int linhaEstado)
        {
            this.estadoProximo = estadoProximo;
            this.isFinal = isFinal;
            this.linhaEstado = linhaEstado;
            
        }

        public string EstadoAtual { get => estadoProximo; set => estadoProximo = value; }
        public bool IsFinal { get => isFinal; set => isFinal = value; }
        public int LinhaEstado { get => linhaEstado; set => linhaEstado = value; }

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            Estado p = (Estado)obj;
            return (estadoProximo == p.estadoProximo) && (isFinal == p.isFinal);
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(estadoProximo);
        }
    }
}
