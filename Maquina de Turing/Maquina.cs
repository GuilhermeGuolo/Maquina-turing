using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Maquina_de_Turing
{
    public partial class Maquina : Form
    {

        //String fita = "";



        List<Estado> listaEstados = new List<Estado>();
        List<String> estadosFinais = new List<String>();

        List<Transicao> listaTransicoes = new List<Transicao>();

        Estado estado_inicial = new Estado(">",false,0);

        public Maquina()
        {
            InitializeComponent();
            listaEstados.Add(estado_inicial);

            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
       {

        }

 

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < listaEstados.Count; i++)
            {
                Console.WriteLine(listaEstados[i].EstadoAtual+"\t"+listaEstados[i].LinhaEstado);
            }

            for (int i = 0; i < listaTransicoes.Count; i++)
            {
                Console.WriteLine(listaTransicoes[i].Estado.EstadoAtual + listaTransicoes[i].Digito + listaTransicoes[i].Direcao);
            }
        }

        private void BotaoIniciar_Maquina(object sender, EventArgs e)//reseta os campos e estruturas
        {
            int linha = 0;
            int coluna = 0;
            int posicaoFita = 0;
            listaEstados.Clear();
            estadosFinais.Clear();
            listaTransicoes.Clear();
            listaEstados.Add(estado_inicial);
            GuardaFinais();//chama o metodo estados finais 
            IniciarTeste(linha, coluna,posicaoFita);//chama o metodo de funcionamento
        }

        public void GuardaFinais()
        {
            String[] guarda_finais = textBox_Estados_finais.Text.Split(',');
            for (int k = 0; k < guarda_finais.Length; k++)
            {
                estadosFinais.Add(guarda_finais[k]);
                Console.WriteLine(estadosFinais[k]);
            }

        }

        public void IniciarTeste(int linha,int coluna,int posicaoFita)
        {
            Boolean isFinal = false;
            
            List<Char> listafita = new List<char>();
            String fita = fitaText.Text;
            for(int j = 0; j<fita.Length; j++)//adiciona os elementos da fita dentro da lista<Char>
            {
                listafita.Add(fita[j]);
            }
            
            while (isFinal != true )
            {




                if (datagrid_transicoes.Rows[linha].Cells[coluna].Value != null)
                {
                    String[] transicaoString = datagrid_transicoes.Rows[linha].Cells[coluna].Value.ToString().Split(',');

                    if (estadosFinais.Contains(transicaoString[0]))
                    {
                        isFinal = true;
                    }

                    Estado novoEstado = new Estado(transicaoString[0], isFinal, listaEstados.Count);
                    if (!listaEstados.Contains(novoEstado))
                    {
                        listaEstados.Add(novoEstado);
                    }



                    Transicao novaTransicao = new Transicao();
                    novaTransicao.Estado = novoEstado;
                    novaTransicao.Linha = linha;
                    novaTransicao.Coluna = coluna;
                    novaTransicao.Digito = transicaoString[1];
                    novaTransicao.Direcao = transicaoString[2];

                    listaTransicoes.Add(novaTransicao);


                    if (posicaoFita > listafita.Count - 1)//ve isso aqui
                    {
                        listafita.Add(novaTransicao.Digito[0]);
                    }
                    else
                    {
                        listafita[posicaoFita] = novaTransicao.Digito[0];//cria um novo espaço na lista se a posiçao for maior que a mesma
                    }
                    //acreddito q ta aqui
                    if (novaTransicao.Direcao.Equals("D"))
                    {
                        posicaoFita++;//problema em estabelecer a coluna
                    }
                    else
                    {
                        posicaoFita--;//////
                    }

                    for (int g = 0; g < datagrid_transicoes.Columns.Count; g++)
                    {

                        if (posicaoFita <= listafita.Count - 1)
                        {

                            if (listafita[posicaoFita] == datagrid_transicoes.Columns[g].HeaderText[0])
                            {
                                coluna = datagrid_transicoes.Columns[g].Index;
                                break;
                            }
                        }
                        else
                        {
                            listafita.Add(' ');

                            if (listafita[posicaoFita] == datagrid_transicoes.Columns[g].HeaderText[0])
                            {
                                coluna = datagrid_transicoes.Columns[g].Index;
                                break;
                            }

                        }

                    }

                    for(int i = 0; i < listaEstados.Count; i++)
                    {
                        if(listaEstados[i].EstadoAtual == transicaoString[0])
                        {
                            linha = listaEstados[i].LinhaEstado;
                        }
                    }


                    
                   // linha = novoEstado.LinhaEstado; //atribui a linha o valor da linha do novoEstado 
                                                    // System.Threading.Thread.Sleep(1500);//espera por 1,5 segundos ate a proxima iteração

                }
                else break;
            }

            if (isFinal == true)
            {
                MessageBox.Show("Fita Reconhecida!");
            }
            else
            {
                MessageBox.Show("Fita não Reconhecida!");
            }


            AtribuiFita(listafita);


        }



        public Boolean verificaFinal(String[] transicaoString,Boolean isFinal)
        {
            if (estadosFinais.Contains(transicaoString[0]))
            {
                isFinal = true;
            }
            return isFinal;
        }

        public void EstruturasClear()
        {
            listaEstados.Clear();
            estadosFinais.Clear();
            listaEstados.Add(estado_inicial);
        }


        public void AtribuiFita(List<Char> listachar)
        {
            String fita = "";
            for (int i = 0; i < listachar.Count; i++)
            {
                fita += listachar[i];
            }

            fitaText.Text = fita;
        }

        private void comoFunciona_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Digite a fita mantendo o caractere >.\n" +
                "Digite o Estado final para ser o ponto de parada da máquina.\n" +
                "Digite as transições nas células da própria tabela como se fosse fazer no papel.");
        }
    }

}
