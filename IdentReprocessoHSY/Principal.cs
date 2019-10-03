using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentReprocessoHSY
{
    public partial class Principal : Form
    {    
        public Principal()
        {
            InitializeComponent();

        }
   
        public void Lotear()
        {
            try
            {               
                int num = 0;
                int dia = Convert.ToInt16(DateTime.Parse(boxInicio.Text).Day);
                int mes = Convert.ToInt16(DateTime.Parse(boxInicio.Text).Month);
                int ano = Convert.ToInt16(DateTime.Parse(boxInicio.Text).Year);
                string[] letra = new string[32] { "","A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "R", 
                                              "A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "R", "S" };

                switch (mes)
                {
                    case 1:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 75;
                                }
                                else
                                {
                                    num = 76;
                                }
                                break;
                        }
                        break;

                    case 2:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 77;
                                }
                                else
                                {
                                    num = 78;
                                }
                                break;
                        }
                        break;

                    case 3:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 79;
                                }
                                else
                                {
                                    num = 80;
                                }
                                break;
                        }
                        break;

                    case 4:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 81;
                                }
                                else
                                {
                                    num = 82;
                                }
                                break;
                        }
                        break;

                    case 5:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 83;
                                }
                                else
                                {
                                    num = 84;
                                }
                                break;
                        }
                        break;

                    case 6:
                        switch (ano)
                        {
                            case 2016:
                                if (dia<= 15)
                                {
                                    num = 85;
                                }
                                else
                                {
                                    num = 86;
                                }
                                break;
                        }
                        break;

                    case 7:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 87;
                                }
                                else
                                {
                                    num = 88;
                                }
                                break;
                        }
                        break;

                    case 8:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 89;
                                }
                                else
                                {
                                    num = 90;
                                }
                                break;
                        }
                        break;

                    case 9:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 91;
                                }
                                else
                                {
                                    num = 92;
                                }
                                break;
                        }
                        break;

                    case 10:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 93;
                                }
                                else
                                {
                                    num = 94;
                                }
                                break;
                        }
                        break;

                    case 11:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 95;
                                }
                                else
                                {
                                    num = 96;
                                }
                                break;
                        }
                        break;

                    case 12:
                        switch (ano)
                        {
                            case 2016:
                                if (dia <= 15)
                                {
                                    num = 97;
                                }
                                else
                                {
                                    num = 98;
                                }
                                break;
                        }
                        break;
                }
                switch (mes)
                {
                    case 1:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 11;
                                }
                                else
                                {
                                    num = 12;
                                }
                                break;
                        }
                        break;

                    case 2:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 13;
                                }
                                else
                                {
                                    num = 14;
                                }
                                break;
                        }
                        break;

                    case 3:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 15;
                                }
                                else
                                {
                                    num = 16;
                                }
                                break;
                        }
                        break;

                    case 4:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 17;
                                }
                                else
                                {
                                    num = 18;
                                }
                                break;
                        }
                        break;

                    case 5:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 19;
                                }
                                else
                                {
                                    num = 20;
                                }
                                break;
                        }
                        break;

                    case 6:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 21;
                                }
                                else
                                {
                                    num = 22;
                                }
                                break;
                        }
                        break;

                    case 7:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 23;
                                }
                                else
                                {
                                    num = 24;
                                }
                                break;
                        }
                        break;

                    case 8:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 25;
                                }
                                else
                                {
                                    num = 26;
                                }
                                break;
                        }
                        break;

                    case 9:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 27;
                                }
                                else
                                {
                                    num = 28;
                                }
                                break;
                        }
                        break;

                    case 10:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 29;
                                }
                                else
                                {
                                    num = 30;
                                }
                                break;
                        }
                        break;

                    case 11:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 31;
                                }
                                else
                                {
                                    num = 32;
                                }
                                break;
                        }
                        break;

                    case 12:
                        switch (ano)
                        {
                            case 2017:
                                if (dia <= 15)
                                {
                                    num = 33;
                                }
                                else
                                {
                                    num = 34;
                                }
                                break;
                        }
                        break;
                }
                switch (mes)
                {
                    case 1:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 35;
                                }
                                else
                                {
                                    num = 36;
                                }
                                break;
                        }
                        break;

                    case 2:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 37;
                                }
                                else
                                {
                                    num = 38;
                                }
                                break;
                        }
                        break;

                    case 3:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 39;
                                }
                                else
                                {
                                    num = 40;
                                }
                                break;
                        }
                        break;

                    case 4:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 41;
                                }
                                else
                                {
                                    num = 42;
                                }
                                break;
                        }
                        break;

                    case 5:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 43;
                                }
                                else
                                {
                                    num = 44;
                                }
                                break;
                        }
                        break;

                    case 6:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 45;
                                }
                                else
                                {
                                    num = 46;
                                }
                                break;
                        }
                        break;

                    case 7:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 47;
                                }
                                else
                                {
                                    num = 48;
                                }
                                break;
                        }
                        break;

                    case 8:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 49;
                                }
                                else
                                {
                                    num = 50;
                                }
                                break;
                        }
                        break;

                    case 9:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 51;
                                }
                                else
                                {
                                    num = 52;
                                }
                                break;
                        }
                        break;

                    case 10:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 53;
                                }
                                else
                                {
                                    num = 54;
                                }
                                break;
                        }
                        break;

                    case 11:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 55;
                                }
                                else
                                {
                                    num = 56;
                                }
                                break;
                        }
                        break;

                    case 12:
                        switch (ano)
                        {
                            case 2018:
                                if (dia <= 15)
                                {
                                    num = 57;
                                }
                                else
                                {
                                    num = 58;
                                }
                                break;
                        }

                        break;

                }
                switch (mes)
                {
                    case 1:
                        switch (ano)
                        {
                            case 2019:
                                if (dia <= 15)
                                {
                                    num = 59;
                                }
                                else
                                {
                                    num = 60;
                                }
                                break;
                        }
                        break;

                    case 2:
                        switch (ano)
                        {
                            case 2019:
                                if (dia <= 15)
                                {
                                    num = 61;
                                }
                                else
                                {
                                    num = 62;
                                }
                                break;
                        }
                        break;

                    case 3:
                        switch (ano)
                        {
                            case 2019:
                                if (dia <= 15)
                                {
                                    num = 63;
                                }
                                else
                                {
                                    num = 64;
                                }
                                break;
                        }
                        break;

                    case 4:
                        switch (ano)
                        {
                            case 2019:
                                if (dia <= 15)
                                {
                                    num = 65;
                                }
                                else
                                {
                                    num = 66;
                                }
                                break;
                        }
                        break;

                    case 5:
                        switch (ano)
                        {
                            case 2019:
                                if (dia <= 15)
                                {
                                    num = 67;
                                }
                                else
                                {
                                    num = 68;
                                }
                                break;
                        }
                        break;

                    case 6:
                        switch (ano)
                        {
                            case 2019:
                                if (dia <= 15)
                                {
                                    num = 69;
                                }
                                else
                                {
                                    num = 70;
                                }
                                break;
                        }
                        break;

                    case 7:
                        switch (ano)
                        {
                            case 2019:
                                if (dia <= 15)
                                {
                                    num = 71;
                                }
                                else
                                {
                                    num = 72;
                                }
                                break;
                        }
                        break;

                    case 8:
                        switch (ano)
                        {
                            case 2019:
                                if (dia <= 15)
                                {
                                    num = 73;
                                }
                                else
                                {
                                    num = 74;
                                }
                                break;                     
                        }
                        break;
                }

                if (dia <= 15)
                {
                    boxLote.Text = num + letra[dia] + "28";
                }
                else
                {
                    boxLote.Text = num + letra[dia] + "28";
                }

            }
            catch
            {
                MessageBox.Show("Preencha Data e Hora de Início Corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Calcular()
        {
            try
            {
                boxValidade1.Text = DateTime.Parse(boxInicio.Text).AddDays(Convert.ToInt32(boxDias1.Text)).ToString();
                boxValidade2.Text = DateTime.Parse(boxInicio.Text).AddDays(Convert.ToInt32(boxDias2.Text)).ToString();
                Lotear();
            }
            catch
            {
                MessageBox.Show("Preencha Data, Hora de Início e Prazo de Validade Corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpar()
        {
            boxCodigo.Text = "";
            boxProduto.Text = "";
            boxCobertura.Text = "";
            boxAgregado.Text = "";
            boxAroma.Text = "";
            boxLinha.Text = "";
            boxLote.Text = "";
            boxPeso.Text = "";
            boxInicio.Text = "";
            boxFinal.Text = "";
            boxValidade1.Text = "";
            boxValidade2.Text = "";
            boxDias2.Text = "";
        }

        public void Preencher()
        {
            try
            {
                switch (boxCodigo.Text)
                {
                    //Vazio
                    case "":
                        Limpar();
                        break;

                        // PRODUTOS BINDLER 2 \\

                    //Barra Ao Leite Exp. 92g
                    case "40001":
                        boxProduto.Text = "Barra ao Leite Exp. 92g";
                        boxCobertura.Text = "302415";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                        //Barra Ao Leite 92g
                    case "40002":
                        boxProduto.Text = "Barra ao Leite 92g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                        //Barra Branco 92g
                    case "40004":
                        boxProduto.Text = "Barra Branco 92g";
                        boxCobertura.Text = "305071";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                        //Barra Extra Cremosa 92g
                    case "40006":
                        boxProduto.Text = "Barra Extra Cremosa 92g";
                        boxCobertura.Text = "302279";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                        //Barra Meio Amargo 92g
                    case "40008":
                        boxProduto.Text = "Barra Meio Amargo 92g";
                        boxCobertura.Text = "302130";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;
                       
                    //Barra CNC 87g
                    case "40010":
                        boxProduto.Text = "Barra CNC 87g";
                        boxCobertura.Text = "305071";
                        boxAgregado.Text = "115069";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Ovomaltine 87g
                    case "40012":
                        boxProduto.Text = "Barra Ovomaltine 87g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "115287";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra CNCHOC 87g
                    case "40014":
                        boxProduto.Text = "Barra CNCHOC 87g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "115069";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Amendoim 85g
                    case "40016":
                        boxProduto.Text = "Barra Amendoim 85g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "115249";
                        boxAroma.Text = "115255";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Crunchers 85g
                    case "40018":
                        boxProduto.Text = "Barra Crunchers 85g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "110051";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;


                    // PRODUTOS BINDLER 1 \\
                 
                    //Barra Dark Tradicional 100g
                    case "88349":
                        boxProduto.Text = "Barra Dark Tradicional 100g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Menta 100g
                    case "88352":
                        boxProduto.Text = "Barra Dark Menta 100g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "115196";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra ao Leite 40g
                    case "88715":
                        boxProduto.Text = "Barra ao Leite 40g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra CNC 40g
                    case "88717":
                        boxProduto.Text = "Barra CNC 40g";
                        boxCobertura.Text = "305071";
                        boxAgregado.Text = "115069";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Aerado 100g
                    case "88778":
                        boxProduto.Text = "Barra Aerado 100g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Aerado 100g
                    case "88812":
                        boxProduto.Text = "Barra Aerado Exp. 100g";
                        boxCobertura.Text = "302415";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Laranja 100g
                    case "88826":
                        boxProduto.Text = "Barra Dark Laranja 100g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "115171";
                        boxAroma.Text = "115258";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Cranberry 100g
                    case "88828":
                        boxProduto.Text = "Barra Dark Cranberry 100g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "115257";
                        boxAroma.Text = "115257";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra ao Leite 20g
                    case "88873":
                        boxProduto.Text = "Barra ao Leite 20g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra CNC 20g
                    case "88875":
                        boxProduto.Text = "Barra CNC 20g";
                        boxCobertura.Text = "305071";
                        boxAgregado.Text = "115069";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                        //Barra Ovomaltine 20g
                    case "88877":
                        boxProduto.Text = "Barra Ovomaltine 20g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "115287";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Tradicional 20g
                    case "88919":
                        boxProduto.Text = "Barra Dark Tradicional 20g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Cranberry 20g
                    case "88950":
                        boxProduto.Text = "Barra Dark Cranberry 20g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "115257";
                        boxAroma.Text = "115257";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;


                    //Barra ao Leite Exp. 20g
                    case "88954":
                        boxProduto.Text = "Barra ao Leite Exp. 20g";
                        boxCobertura.Text = "302415";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Café 100g
                    case "40028":
                        boxProduto.Text = "Barra Dark Café 100g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "115290";
                        boxAroma.Text = "115291";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Caramelo 100g
                    case "40048":
                        boxProduto.Text = "Barra Dark Caramelo 100g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "115282";
                        boxAroma.Text = "115283";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    default:
                        MessageBox.Show("Produto não cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                String impressora = Properties.Settings.Default.Impressora;
                Int16 copias = Convert.ToInt16(boxCopias.Text);
                Boolean teste = Properties.Settings.Default.Teste;
                                               
                if (teste == true)
                {
                    printPreviewDialog1.ShowDialog();
                }
                else
                {
                    printDocument1.PrinterSettings.PrinterName = impressora;
                    printDocument1.PrinterSettings.Copies = copias;
                    printDocument1.Print();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                // Create pen.
                Pen blackPen = new Pen(Color.Black, 1);
                Pen blackPen2 = new Pen(Color.Black, 2);
                Pen blackPen3 = new Pen(Color.Black, 3);


                // Tamanho e Posição dos Retângulos.
                Rectangle[] rect = {
          new Rectangle(15, 5, 340, 528), //Descrição
          new Rectangle(15, 43, 340, 72), //Produto
          new Rectangle(15, 115, 113, 25),  //Desc. Cobertura 
          new Rectangle(128, 115, 113, 25),  //Desc. Agregado 
          new Rectangle(241, 115, 113, 25),  //Desc. Aroma 
          new Rectangle(15, 140, 113, 43),    //Cobertura 
          new Rectangle(128, 140, 113, 43),  //Agregado
          new Rectangle(241, 140, 113, 43), //Aroma
          new Rectangle(15, 183, 113, 25),  //Desc. Linha 
          new Rectangle(128, 183, 113, 25),  //Desc. Lote 
          new Rectangle(241, 183, 113, 25),  //Desc. Peso
          new Rectangle(15, 208, 113, 45),    //Linha 
          new Rectangle(128, 208, 113, 45),  //Lote
          new Rectangle(241, 208, 113, 45), //Peso
          new Rectangle(15, 255, 177, 43),  //Data Inicio Desc.
          new Rectangle(192, 255, 163, 43), //Data Inicio
          new Rectangle(15, 298, 177, 43),  //Data Final Desc.
          new Rectangle(192, 298, 163, 43), //Data Final
          new Rectangle(15, 343, 340, 34), //Normalmente até
          new Rectangle(15, 377, 340, 87), //Atenção
          new Rectangle(128, 396, 113, 30), //Data 1
          new Rectangle(241, 396, 113, 30), //Data 2
          new Rectangle(15, 464, 340, 34), //Resultado Análise
          new Rectangle(15, 500, 43, 32), //Após
          new Rectangle(58, 500, 96, 32), //Vencimento
          new Rectangle(154, 500, 200, 32), //Ultimo 
          //new Rectangle(15, 533, 220, 32), //Obs 
                               };

                //Criar os Retângulos
                for (int i = 0; i <= 25; i++)
                {
                    if (i == 19)
                    {
                        e.Graphics.DrawRectangle(blackPen3, rect[0]);
                        e.Graphics.DrawRectangle(blackPen2, rect[19]);
                        i++;
                    }
                    e.Graphics.DrawRectangle(blackPen, rect[i]);
                }
                Font letra = new Font("Calibri", 24, FontStyle.Bold, GraphicsUnit.Pixel);
                Font letras = new Font("Calibri", 22, FontStyle.Regular, GraphicsUnit.Pixel);
                Font letrapppp = new Font("Calibri", 14, FontStyle.Regular, GraphicsUnit.Pixel);
                Font letrapb = new Font("Calibri", 14, FontStyle.Bold, GraphicsUnit.Pixel);
                Font letrapunder = new Font("Calibri", 14, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Pixel);
                Font letrapbb = new Font("Calibri", 16, FontStyle.Regular, GraphicsUnit.Pixel);
                Font letradata = new Font("Calibri", 17, FontStyle.Bold, GraphicsUnit.Pixel);
                StringFormat alinhamento = new StringFormat();
                alinhamento.Alignment = StringAlignment.Center;



                e.Graphics.DrawString("IDENTIFICAÇÃO DE REPROCESSO", letra, Brushes.Black, 185, 12, alinhamento);
                e.Graphics.DrawString("Descrição do Reprocesso", letrapbb, Brushes.Black, 105, 50, alinhamento);
                e.Graphics.DrawString(boxProduto.Text.ToUpper(), letra, Brushes.Black, 185, 75, alinhamento);
                e.Graphics.DrawString("Cobertura", letrapbb, Brushes.Black, 70, 118, alinhamento);
                e.Graphics.DrawString(boxCobertura.Text.ToUpper(), letras, Brushes.Black, 72, 150, alinhamento);
                e.Graphics.DrawString("Agregado", letrapbb, Brushes.Black, 185, 118, alinhamento);
                e.Graphics.DrawString(boxAgregado.Text.ToUpper(), letras, Brushes.Black, 185, 150, alinhamento);
                if (boxCodigo.Text == "40016")
                {
                    e.Graphics.DrawString("Agregado", letrapbb, Brushes.Black, 300, 118, alinhamento);
                }
                else
                {
                    e.Graphics.DrawString("Aroma", letrapbb, Brushes.Black, 300, 118, alinhamento);
                }
                e.Graphics.DrawString(boxAroma.Text.ToUpper(), letras, Brushes.Black, 297, 150, alinhamento);
                e.Graphics.DrawString("Linha", letrapbb, Brushes.Black, 70, 186, alinhamento);
                e.Graphics.DrawString(boxLinha.Text.ToUpper(), letras, Brushes.Black, 72, 218, alinhamento);
                e.Graphics.DrawString("Lote", letrapbb, Brushes.Black, 185, 186, alinhamento);
                e.Graphics.DrawString(boxLote.Text.ToUpper(), letras, Brushes.Black, 185, 218, alinhamento);
                e.Graphics.DrawString("Peso", letrapbb, Brushes.Black, 300, 186, alinhamento);
                if (boxPeso.Text == "")
                {
                    e.Graphics.DrawString("         KG", letras, Brushes.Black, 297, 218, alinhamento);
                }
                else
                {
                    e.Graphics.DrawString(boxPeso.Text.ToUpper() + " KG", letras, Brushes.Black, 297, 218, alinhamento);
                }
                e.Graphics.DrawString("Data e hora de início do \nabastecimento", letrapppp, Brushes.Black, 105, 260, alinhamento);
                e.Graphics.DrawString(boxInicio.Text, letradata, Brushes.Black, 255, 268, alinhamento);
                e.Graphics.DrawString("Data e hora de término do \nabastecimento", letrapppp, Brushes.Black, 105, 302, alinhamento);

                if (boxFinal.Text == "            /  /            :")
                {
                    e.Graphics.DrawString("         /    /                  :", letradata, Brushes.Black, 255, 310, alinhamento);
                }
                else
                {
                    e.Graphics.DrawString(boxFinal.Text, letradata, Brushes.Black, 255, 310, alinhamento);
                }
                e.Graphics.DrawString("Utilizar o produto normalmente até:", letrapppp, Brushes.Black, 135, 352, alinhamento);
                e.Graphics.DrawString(boxValidade1.Text, letradata, Brushes.Black, 300, 350, alinhamento);
                e.Graphics.DrawString("ATENÇÃO!", letrapb, Brushes.Black, 180, 378, alinhamento);
                e.Graphics.DrawString("Entre as datas de:", letrapb, Brushes.Black, 75, 403, alinhamento);
                e.Graphics.DrawString(boxValidade1.Text, letradata, Brushes.Black, 186, 401, alinhamento);
                e.Graphics.DrawString(boxValidade2.Text, letradata, Brushes.Black, 300, 401, alinhamento);
                e.Graphics.DrawString("Antes do consumo avisar o facilitador ou gestor para \navaliação", letrapb, Brushes.Black, 180, 428, alinhamento);
                e.Graphics.DrawString("Resultado da análise sensorial:  (   )OK  /  (   )Não OK", letrapppp, Brushes.Black, 185, 474, alinhamento);
                e.Graphics.DrawString("Após", letrapppp, Brushes.Black, 37, 509, alinhamento);
                e.Graphics.DrawString(boxValidade2.Text, letradata, Brushes.Black, 107, 507, alinhamento);
                e.Graphics.DrawString("NÃO UTILIZAR ESTE REPROCESSO.", letrapunder, Brushes.Black, 254, 509, alinhamento);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void boxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Preencher();

        }

        private void boxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Preencher();
            }
        }



        private void Principal_Load(object sender, EventArgs e)
        {           
            boxCopias.Text = Properties.Settings.Default.Copias.ToString();
            boxDias1.Text = Properties.Settings.Default.Valadade1.ToString();
            boxDias2.Text = Properties.Settings.Default.Valadade2.ToString();
        }
    }
}
