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

                if (dia <= 15)
                {
                    num = (mes * 2) + (ano - 2020) + 15 + (ano - 2021) * 23;
                    num = num + 1;
                    boxLote.Text = num + letra[dia] + "28";
                }
                else
                {
                    num = (mes * 2) + (ano - 2020) + 15 + (ano - 2021) * 23;
                    num = num + 2;
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
                MessageBox.Show("Preencha Data, e Hora de Início Corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                boxCodigo.Text = boxCodigo.Text.TrimStart('0');

                switch (boxCodigo.Text)
                {
                    case "5275":
                        if (boxInicio.ReadOnly == true && btnGerar.Enabled == false)
                        {
                            boxInicio.ReadOnly = false;
                            btnGerar.Enabled = true;
                            boxCodigo.Text = "";
                        }
                        else
                        {
                            boxInicio.ReadOnly = true;
                            btnGerar.Enabled = false;
                            boxCodigo.Text = "";
                        }
                        break;

                    //ADMIN
                    case "7578":
                        if (boxInicio.ReadOnly == true && btnGerar.Enabled == false)
                        {
                            boxInicio.ReadOnly = false;
                            btnGerar.Enabled = true;
                            boxCodigo.Text = "";
                            boxProduto.ReadOnly = false;
                            boxCobertura.ReadOnly = false;
                            boxAgregado.ReadOnly = false;
                            boxAroma.ReadOnly = false;
                            boxLinha.ReadOnly = false;
                            boxLote.ReadOnly = false;
                            boxDias1.ReadOnly = false;
                            boxDias2.ReadOnly = false;

                        }
                        else
                        {
                            boxInicio.ReadOnly = true;
                            btnGerar.Enabled = false;
                            boxCodigo.Text = "";
                            boxProduto.ReadOnly = true;
                            boxCobertura.ReadOnly = true;
                            boxAgregado.ReadOnly = true;
                            boxAroma.ReadOnly = true;
                            boxLinha.ReadOnly = true;
                            boxLote.ReadOnly = true;
                            boxDias1.ReadOnly = true;
                            boxDias2.ReadOnly = true;
                        }
                        break;

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
                        boxAgregado.Text = "115179";
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
                        boxAgregado.Text = "115249 \n115255";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Crocante 85g
                    case "40038":
                        boxProduto.Text = "Barra Crocante 85g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "110051";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Cristal 87g
                    case "40115":
                        boxProduto.Text = "Barra Cristal 87g";
                        boxCobertura.Text = "302130";
                        boxAgregado.Text = "115308";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Pink Lemonade 92g
                    case "40175":
                        boxProduto.Text = "Barra Pink Lemonade 92g";
                        boxCobertura.Text = "305071";
                        boxAgregado.Text = "115308 \n110062";
                        boxAroma.Text = "115326";
                        boxLinha.Text = "Bindler 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    // PRODUTOS BINDLER 1 \\

                    //Barra Dark Trad. 85g
                    case "40091":
                        boxProduto.Text = "Barra Dark Trad. 85g";
                        boxCobertura.Text = "302445";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Menta 85g
                    case "40093":
                        boxProduto.Text = "Barra Dark Menta 85g";
                        boxCobertura.Text = "302445";
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

                    //Barra Aerada 100g
                    case "88778":
                        boxProduto.Text = "Barra Aerada 100g";
                        boxCobertura.Text = "351056";
                        boxAgregado.Text = "115190";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Aerada Exp. 100g
                    case "88812":
                        boxProduto.Text = "Barra Aerada Exp. 100g";
                        boxCobertura.Text = "302415";
                        boxAgregado.Text = "115190";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Laranja 85g
                    case "40095":
                        boxProduto.Text = "Barra Dark Laranja 85g";
                        boxCobertura.Text = "302445";
                        boxAgregado.Text = "115301";
                        boxAroma.Text = "115258";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Cranberry 85g
                    case "40097":
                        boxProduto.Text = "Barra Dark Cranberry 85g";
                        boxCobertura.Text = "302445";
                        boxAgregado.Text = "115302";
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

                    //Barra Dark Trad. 20g
                    case "88919":
                        boxProduto.Text = "Barra Dark Trad. 20g";
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
                        boxAgregado.Text = "115256";
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

                    //Barra Dark Aerada 100g
                    case "40018":
                        boxProduto.Text = "Barra Dark Aerada 100g";
                        boxCobertura.Text = "302255";
                        boxAgregado.Text = "115190";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Café 85g
                    case "40099":
                        boxProduto.Text = "Barra Dark Café 85g";
                        boxCobertura.Text = "302445";
                        boxAgregado.Text = "115290 \n115309";
                        boxAroma.Text = "115316";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Aerada 85g
                    case "40041":
                        boxProduto.Text = "Barra Dark Aerada 85g";
                        boxCobertura.Text = "302445";
                        boxAgregado.Text = "115190";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Aerada 85g
                    case "40045":
                        boxProduto.Text = "Barra Aerada 85g";
                        boxCobertura.Text = "302461";
                        boxAgregado.Text = "115190";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Aerada Exp. 85g
                    case "40046":
                        boxProduto.Text = "Barra Aerada Exp. 85g";
                        boxCobertura.Text = "302466";
                        boxAgregado.Text = "115190";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark Caramelo 85g
                    case "40101":
                        boxProduto.Text = "Barra Dark Caramelo 85g";
                        boxCobertura.Text = "302445";
                        boxAgregado.Text = "115283";
                        boxAroma.Text = "115315";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Duo Cookies 87g
                    case "40113":
                        boxProduto.Text = "Barra Duo Cookies 87g";
                        boxCobertura.Text = "351056 \n305071";
                        boxAgregado.Text = "115069";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Barra Dark 73% 85g
                    case "40166":
                        boxProduto.Text = "Barra Dark 73% 85g";
                        boxCobertura.Text = "302434";
                        boxAgregado.Text = "115290";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Bindler 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "90";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;



                    // PRODUTOS FLEX 2 \\



                    //Cereal CNC 22g
                    case "88621":
                        boxProduto.Text = "Cereal CNC 22g";
                        boxCobertura.Text = "302168";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal CNC 22g
                    case "88966":
                        boxProduto.Text = "Cereal CNC 22g";
                        boxCobertura.Text = "302168";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal CNCHOC 22g
                    case "88618":
                        boxProduto.Text = "Cereal CNCHOC";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal CNCHOC
                    case "88964":
                        boxProduto.Text = "Cereal CNCHOC 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal Morango 22g
                    case "88627":
                        boxProduto.Text = "Cereal Morango 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal Morango
                    case "88968":
                        boxProduto.Text = "Cereal Morango 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal Banana 22g
                    case "88637":
                        boxProduto.Text = "Cereal Banana 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal Banana 22g
                    case "88971":
                        boxProduto.Text = "Cereal Banana 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal Coco 22g
                    case "88630":
                        boxProduto.Text = "Cereal Coco 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal Coco 22g
                    case "88969":
                        boxProduto.Text = "Cereal Coco 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal Brigadeiro 22g
                    case "88624":
                        boxProduto.Text = "Cereal Brigadeiro 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Cereal Brigadeiro
                    case "88967":
                        boxProduto.Text = "Cereal Brigadeiro 22g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Go Paçoca 11g
                    case "40026":
                        boxProduto.Text = "Go Paçoca 11g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "40";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Go Paçoca 25g
                    case "40020":
                        boxProduto.Text = "Go Paçoca 25g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "40";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Go Paçoca 25g
                    case "40023":
                        boxProduto.Text = "Go Paçoca 25g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "40";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Go Brigadeiro 25g
                    case "40022":
                        boxProduto.Text = "Go Brigadeiro 25g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "40";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Go Brigadeiro 25g
                    case "40024":
                        boxProduto.Text = "Go Brigadeiro 25g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "40";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Crunchers Frut. Verm. 120g
                    case "40029":
                        boxProduto.Text = "Crunchers Frut. Verm. 120g";
                        boxCobertura.Text = "302168";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "40";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Crunchers Amendoim 120g
                    case "40030":
                        boxProduto.Text = "Crunchers Amendoim 120g";
                        boxCobertura.Text = "302313";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Flex 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "40";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;



                    // Produtos Wafer 2 \\


                    //Hersheys Mais ao Leite 115g
                    case "88553":
                        boxProduto.Text = "Hersheys Mais ao Leite 115g";
                        boxCobertura.Text = "302411";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Hersheys Mais CNC 115g
                    case "88554":
                        boxProduto.Text = "Hersheys Mais CNC 115g";
                        boxCobertura.Text = "302412";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Hersheys Mais Amendoim 115g
                    case "88923":
                        boxProduto.Text = "Hsy Mais Amendoim 115g";
                        boxCobertura.Text = "302411";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Hsy Mais Triplo Choc 115g
                    case "40037":
                        boxProduto.Text = "Hsy Mais Triplo Choc 115g";
                        boxCobertura.Text = "302411";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Hersheys Mais ao Leite 102g
                    case "40067":
                        boxProduto.Text = "Hersheys Mais ao Leite 102g";
                        boxCobertura.Text = "302411";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Hersheys Mais CNC 115g
                    case "40068":
                        boxProduto.Text = "Hersheys Mais CNC 102g";
                        boxCobertura.Text = "302412";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Hersheys Mais Amendoim 102g
                    case "40069":
                        boxProduto.Text = "Hsy Mais Amendoim 102g";
                        boxCobertura.Text = "302411";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Hsy Mais Triplo Choc 102g
                    case "40070":
                        boxProduto.Text = "Hsy Mais Triplo Choc 102g";
                        boxCobertura.Text = "302411";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 2";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;


                    // Produtos Wafer 1 \\

                    //Hsy Mais Mini ao Leite
                    case "88734":
                        boxProduto.Text = "Hsy Mais Mini ao Leite";
                        boxCobertura.Text = "302411";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Hsy Mais Mini Cnc
                    case "88735":
                        boxProduto.Text = "Hsy Mais Mini ao Leite";
                        boxCobertura.Text = "302412";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "Wafer 1";
                        boxDias1.Text = "28";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    // Produtos IoIo \\

                    //Ioio Crem Choc
                    case "88406":
                        boxProduto.Text = "Ioio Crem Choc";
                        boxCobertura.Text = "302276";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "IoIo";
                        boxDias1.Text = "30";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Ioio Crem Misto
                    case "88407":
                        boxProduto.Text = "Ioio Crem Misto";
                        boxCobertura.Text = "302276 \n302277";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "IoIo";
                        boxDias1.Text = "30";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Ioio Mix Choc
                    case "88463":
                        boxProduto.Text = "Ioio Mix Choc";
                        boxCobertura.Text = "302276";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "IoIo";
                        boxDias1.Text = "30";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Ioio Mix Misto
                    case "88400":
                        boxProduto.Text = "Ioio Mix Misto";
                        boxCobertura.Text = "302276 \n302277";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "IoIo";
                        boxDias1.Text = "30";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Ioio Mix Choc
                    case "88462":
                        boxProduto.Text = "Ioio Mix Choc";
                        boxCobertura.Text = "302276";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "IoIo";
                        boxDias1.Text = "30";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    //Ioio Mix Misto
                    case "88397":
                        boxProduto.Text = "Ioio Mix Misto";
                        boxCobertura.Text = "302276 \n302277";
                        boxAgregado.Text = "N/A";
                        boxAroma.Text = "N/A";
                        boxLinha.Text = "IoIo";
                        boxDias1.Text = "30";
                        boxDias2.Text = "60";
                        boxInicio.Text = DateTime.Now.ToString();
                        Calcular();
                        break;

                    default:
                        MessageBox.Show("Código não cadastrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (String.IsNullOrEmpty(Convert.ToString(boxProduto.Text)))
                {
                    MessageBox.Show("Preencha todos os campos corretamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String impressora = Properties.Settings.Default.Impressora;
                    Int16 copias = Convert.ToInt16(boxCopias.Text);
                    //Boolean adm = true;

                    //if (adm == true)
                    //{
                   //     printPreviewDialog1.ShowDialog();
                   // }
                    //else
                    //{
                        if (MessageBox.Show("Deseja imprimir " + copias + " etiqueta(s) ?", "Identificação de Reprocesso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            printDocument1.PrinterSettings.PrinterName = impressora;
                            printDocument1.PrinterSettings.Copies = copias;
                            printDocument1.Print();
                        }
                    //}
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
          new Rectangle(15, 5, 340, 560), //Descrição
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
          new Rectangle(15, 500, 340, 32), //Obs 
          new Rectangle(15, 534, 43, 32), //Após
          new Rectangle(58, 534, 96, 32), //Vencimento
          new Rectangle(154, 534, 200, 32), //Não Uitlizar esse reprocesso    
         };

                //Criar os Retângulos
                for (int i = 0; i <= 26; i++)
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
                Font letrapamed = new Font("Calibri", 20, FontStyle.Regular, GraphicsUnit.Pixel);
                StringFormat alinhamento = new StringFormat();
                alinhamento.Alignment = StringAlignment.Center;



                e.Graphics.DrawString("IDENTIFICAÇÃO DE REPROCESSO", letra, Brushes.Black, 185, 12, alinhamento);
                e.Graphics.DrawString("Descrição do Reprocesso" + " - " + boxCodigo.Text, letrapbb, Brushes.Black, 126, 50, alinhamento);
                e.Graphics.DrawString(boxProduto.Text.ToUpper(), letra, Brushes.Black, 185, 75, alinhamento);
                e.Graphics.DrawString("Cobertura", letrapbb, Brushes.Black, 70, 118, alinhamento);

                if (boxProduto.Text == "Ioio Crem Misto" | boxProduto.Text == "Ioio Mix Misto" | boxProduto.Text == "Ioio Mix Misto" | boxProduto.Text == "Barra Duo Cookies 87g")
                {
                    e.Graphics.DrawString(boxCobertura.Text.ToUpper(), letrapamed, Brushes.Black, 72, 137, alinhamento);
                }
                else
                {
                    e.Graphics.DrawString(boxCobertura.Text.ToUpper(), letras, Brushes.Black, 72, 150, alinhamento);
                }
                e.Graphics.DrawString("Agregado", letrapbb, Brushes.Black, 185, 118, alinhamento);

                if (boxProduto.Text == "Barra Amendoim 85g" | boxProduto.Text == "Barra Dark Café 85g" | boxProduto.Text == "Barra Pink Lemonade 92g")
                {
                    e.Graphics.DrawString(boxAgregado.Text.ToUpper(), letrapamed, Brushes.Black, 185, 137, alinhamento);
                }
                else
                {
                    e.Graphics.DrawString(boxAgregado.Text.ToUpper(), letras, Brushes.Black, 185, 150, alinhamento);
                }

                e.Graphics.DrawString("Aroma", letrapbb, Brushes.Black, 300, 118, alinhamento);
                e.Graphics.DrawString(boxAroma.Text.ToUpper(), letras, Brushes.Black, 297, 150, alinhamento);
                e.Graphics.DrawString("Linha", letrapbb, Brushes.Black, 70, 186, alinhamento);
                e.Graphics.DrawString(boxLinha.Text.ToUpper(), letras, Brushes.Black, 72, 218, alinhamento);
                e.Graphics.DrawString("Lote", letrapbb, Brushes.Black, 185, 186, alinhamento);
                e.Graphics.DrawString(boxLote.Text.ToUpper(), letra, Brushes.Black, 185, 217, alinhamento);
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
                e.Graphics.DrawString("Obs.:", letrapppp, Brushes.Black, 37, 509, alinhamento);
                e.Graphics.DrawString("Após", letrapppp, Brushes.Black, 37, 542, alinhamento);
                e.Graphics.DrawString(boxValidade2.Text, letradata, Brushes.Black, 107, 540, alinhamento);
                e.Graphics.DrawString("NÃO UTILIZAR ESTE REPROCESSO.", letrapunder, Brushes.Black, 254, 542, alinhamento);
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
            boxDias1.Text = Properties.Settings.Default.Validade1.ToString();
            boxDias2.Text = Properties.Settings.Default.Validade2.ToString();

            if (Properties.Settings.Default.Adm == true)
            {
                btnGerar.Enabled = true;
                boxInicio.ReadOnly = false;
            }
        }

        private void boxInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && boxInicio.ReadOnly == false)
            {
                Calcular();
            }
        }

    }
}
