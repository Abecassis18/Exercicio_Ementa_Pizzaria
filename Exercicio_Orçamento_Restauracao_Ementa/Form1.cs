using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Orçamento_Restauracao_Ementa
{
    public partial class Form1 : Form
    {
        double adulto, crianca, dieta;
        public Form1()
        {
            InitializeComponent();
            valoresIniciais();
            StartPosition = FormStartPosition.CenterScreen;
            ntfMyNotify.Visible = true;
            ntfMyNotify.BalloonTipText = "Programa em Execução.";
            ntfMyNotify.ShowBalloonTip(6000);
        }

        private void valoresIniciais()
        {
            //foreach (object objeto in this.Controls)
            // {
            //    if(objeto is Label)
            //    {
            //        ((Label)objeto).Text = 0.ToString("C2");
            //    }
            // }
            lblValorAdulto.Text = 0.ToString("C2");
            lblValorCrianca.Text = 0.ToString("C2");
            lblValorDieta.Text = 0.ToString("C2");

            lblPrecoTotal.Text = 0.ToString("C2");
            lblSinal.Text = 0.ToString("C2");
            lblPagamentoDia.Text = 0.ToString("C2");

            nudAdultos.Value = 0;
            nudCriancas.Value = 0;
            nudDieta.Value = 0;

            cboEmenta.Text = "Selecionar";//Ou podes setar um valor vazio com o SelectedIndex=-1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void nudAdultos_ValueChanged(object sender, EventArgs e)
        {
            //int quantidadeAdultos;
            //quantidadeAdultos = int.Parse(nudAdultos.Text); Fazendo dessa maneira parece logico mas da erro na hora de calcular. Usamos assim quando o user insere o valor manuelamente.
            adulto = valorTotal("adulto", cboEmenta.Text, (int)nudAdultos.Value);//Aqui apanhamos o valor inicial do numericUpDown e convertemos para int.
            lblValorAdulto.Text = adulto.ToString();
        }

        private void nudCriancas_ValueChanged(object sender, EventArgs e)
        {
            //int quantidadeCriancas = 0;
            //quantidadeCriancas = int.Parse(nudCriancas.Text);
            crianca = valorTotal("crianca", cboEmenta.Text, (int)nudCriancas.Value);
            lblValorCrianca.Text = crianca.ToString();
        }

        private void nudDieta_ValueChanged(object sender, EventArgs e)
        {
            int quantidadeDieta = 0;
            quantidadeDieta = (int)nudDieta.Value;
            dieta = quantidadeDieta * 56;
            //dieta = valorTotal("dieta", cboEmenta.Text, quantidadeDieta); Não chamamos a função pq aqui não tem diferença se é criança ou Adulto.
            lblValorDieta.Text = dieta.ToString();
        }

        private double valorTotal(string tipodePessoa, string ementa, int quantidadePessoas)
        {
            double total =0;

            switch (ementa)
            {
              case "DELUXE":
                    if(tipodePessoa =="adulto")
                        {
                            total = 90 * quantidadePessoas;
                        }
                    else if(tipodePessoa == "crianca")
                        {
                        total = 40 * quantidadePessoas;
                        }
                    break;

                case "PORTUGUESA":
                    if (tipodePessoa == "adulto")
                    {
                        total = 100 * quantidadePessoas;
                    }
                    else if (tipodePessoa == "crianca")
                    {
                        total = 70 * quantidadePessoas;
                    }
                    break;

                case "PRESTIGIO":
                    if (tipodePessoa == "adulto")
                    {
                        total = 75 * quantidadePessoas;
                    }
                    else if (tipodePessoa == "crianca")
                    {
                        total = 33 * quantidadePessoas;
                    }
                    break;

                case "RODIZIO":
                    if (tipodePessoa == "adulto")
                    {
                        total = 120 * quantidadePessoas;
                    }
                    else if (tipodePessoa == "crianca")
                    {
                        total = 45 * quantidadePessoas;
                    }
                    break;

                case "SOBERBA":
                    if (tipodePessoa == "adulto")
                    {
                        total = 95 * quantidadePessoas;
                    }
                    else if (tipodePessoa == "crianca")
                    {
                        total = 40 * quantidadePessoas;
                    }
                    break;                                  
            }
            
            return total;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precoTotal, sinalReserva, pagamentoDia = 0;

            if(cboEmenta.Text != "")//Se no iniciar tivesse usado o selectedIndex aqui tambem usaria.
            {
                precoTotal = adulto + crianca + dieta;
                lblPrecoTotal.Text = precoTotal.ToString();

                sinalReserva = precoTotal * 0.3;
                lblSinal.Text = sinalReserva.ToString();

                pagamentoDia = precoTotal - sinalReserva;
                lblPagamentoDia.Text = pagamentoDia.ToString();
            }
        }

        private void btnLimparValores_Click(object sender, EventArgs e)
        {
            valoresIniciais();
        }
    }
}