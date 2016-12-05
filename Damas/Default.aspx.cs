using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    bool isAlvo = false, isTurnoVermelho = true, isRainha = false; //true para vermelho, falso para preto
    static String pecaSelecionada = ""; //ATIVA ----------------
    //StringBuilder sb = new StringBuilder();
    Dictionary<String, ImageButton> ImageButtons = new Dictionary<String, ImageButton>();
    static List<ImageButton> ImageButtonsAlvos = new List<ImageButton>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
        ImageButtons.Add("11", ImageButton11);
        ImageButtons.Add("13", ImageButton13);
        ImageButtons.Add("15", ImageButton15);
        ImageButtons.Add("17", ImageButton17);
        ImageButtons.Add("22", ImageButton22);
        ImageButtons.Add("24", ImageButton24);
        ImageButtons.Add("26", ImageButton26);
        ImageButtons.Add("28", ImageButton28);
        ImageButtons.Add("31", ImageButton31);
        ImageButtons.Add("33", ImageButton33);
        ImageButtons.Add("35", ImageButton35);
        ImageButtons.Add("37", ImageButton37);
        ImageButtons.Add("42", ImageButton42);
        ImageButtons.Add("44", ImageButton44);
        ImageButtons.Add("46", ImageButton46);
        ImageButtons.Add("48", ImageButton48);
        ImageButtons.Add("51", ImageButton51);
        ImageButtons.Add("53", ImageButton53);
        ImageButtons.Add("55", ImageButton55);
        ImageButtons.Add("57", ImageButton57);
        ImageButtons.Add("62", ImageButton62);
        ImageButtons.Add("64", ImageButton64);
        ImageButtons.Add("66", ImageButton66);
        ImageButtons.Add("68", ImageButton68);
        ImageButtons.Add("71", ImageButton71);
        ImageButtons.Add("73", ImageButton73);
        ImageButtons.Add("75", ImageButton75);
        ImageButtons.Add("77", ImageButton77);
        ImageButtons.Add("82", ImageButton82);
        ImageButtons.Add("84", ImageButton84);
        ImageButtons.Add("86", ImageButton86);
        ImageButtons.Add("88", ImageButton88);
    }

    /*public void carregarpecas()
    {
        for (int i=1; i<=8; i=i++)
        {
            if ( (i%2)!=0 )
            {
                for (int j=1; i<=8; i=i+2)
                {
                    sb.Append("~/Imagens/");
                    Dictionary<String, int> ImageButtons2 = new Dictionary<string, int>();
                }
            }
            else
            {
                for (int j=2; i<=8; i=i+2)
                {
                    ;
                }
            }

        }
    }*/

    public void Button1_Click(object sender, EventArgs e)
    {
        ativarPecas("~/Imagens/preto.png");
    }

    public void ativarPecas(String corPecas)
    {
        foreach (ImageButton Peca in ImageButtons.Values)
        {
            Peca.Enabled = true;
            /*if (Peca.ImageUrl.Equals(corPecas))
            {
                Peca.Enabled = true;
            }
            else
            {
                Peca.Enabled = false;
            }*/
        }
    }

    //MOVIMENTO(S) POSSÍVEL(EIS) DE SER(EM) FEITO(S) PELA PEÇA.
    //Caso verdadeiro, o return será usado para desabilitar as outras peças dessa cor que não participarão da jogada.
    public String ativarMovimentosPossiveis(String atualPos)
    {
        String alvoPos = "", aposComerPos = "";
        int lin = Convert.ToInt32(atualPos[0].ToString()), col = Convert.ToInt32(atualPos[1].ToString());
        bool posAtivada = false;

        //APENAS DAMA
        if ((lin + 1) <= 8)
        {
            //DIREÇÃO SULDOESTE
            if ((col - 1) > 0)
            {
                alvoPos = (lin + 1).ToString() + (col - 1).ToString();
                //Possível movimentar para próxima casa suldoeste?
                if (ImageButtons[alvoPos].ImageUrl == "~/Imagens/vazio.png")
                {
                    ImageButtons[alvoPos].Enabled = true;
                    ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                    posAtivada = true;
                }
                //Possível comer peça na próxima casa suldoeste?
                else if (((lin + 2) <= 8) && ((col - 2) > 0))
                {
                    aposComerPos = (lin + 2).ToString() + (col - 2).ToString();
                    if (ImageButtons[aposComerPos].ImageUrl == "~/Imagens/vazio.png") //Tem casa vazia após peça alvo?
                    {
                        //Caso a peça atual seja vermelha
                        if ((ImageButtons[atualPos].ImageUrl == "~/Imagens/vermelho.png") && (ImageButtons[alvoPos].ImageUrl == "~/Imagens/preto.png"))
                        {
                            ImageButtons[alvoPos].Enabled = true;
                            ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                            posAtivada = true;
                        }
                        //Caso a peça atual seja preta
                        else if ((ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png") && (ImageButtons[alvoPos].ImageUrl == "~/Imagens/vermelho.png"))
                        {
                            ImageButtons[alvoPos].Enabled = true;
                            ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                            posAtivada = true;
                        }
                    }
                }
            }
            //DIREÇÃO SULDESTE
            if ((col + 1) <= 8)
            {
                alvoPos = (lin + 1).ToString() + (col + 1).ToString();
                //Possível movimentar para próxima casa suldeste?
                if (ImageButtons[alvoPos].ImageUrl == "~/Imagens/vazio.png")
                {
                    ImageButtons[alvoPos].Enabled = true;
                    ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                    posAtivada = true;
                }
                //Possível comer peça na próxima casa suldeste?
                else if (((lin + 2) <= 8) && ((col + 2) <= 8))
                {
                    aposComerPos = (lin + 2).ToString() + (col + 2).ToString();
                    if (ImageButtons[aposComerPos].ImageUrl == "~/Imagens/vazio.png") //Tem casa vazia após peça alvo?
                    {
                        //Caso a peça atual seja vermelha
                        if ((ImageButtons[atualPos].ImageUrl == "~/Imagens/vermelho.png") && (ImageButtons[alvoPos].ImageUrl == "~/Imagens/preto.png"))
                        {
                            ImageButtons[alvoPos].Enabled = true;
                            ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                            posAtivada = true;
                        }
                        //Caso a peça atual seja preta
                        else if ((ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png") && (ImageButtons[alvoPos].ImageUrl == "~/Imagens/vermelho.png"))
                        {
                            ImageButtons[alvoPos].Enabled = true;
                            ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                            posAtivada = true;
                        }
                    }
                }
            }
        }
        //AMBOS PEÃO E DAMA
        if ((lin - 1) > 0)
        {
            //DIREÇÃO NOROESTE
            if ((col - 1) > 0) //Movimentar para noroeste, checar possibilidade.
            {
                alvoPos = (lin - 1).ToString() + (col - 1).ToString();
                //Possível movimentar para próxima casa noroeste?
                if (ImageButtons[alvoPos].ImageUrl == "~/Imagens/vazio.png")
                {
                    ImageButtons[alvoPos].Enabled = true;
                    ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                    posAtivada = true;
                }
                //Possível comer peça na próxima casa noroeste?
                else if (((lin - 2) > 0) && ((col - 2) > 0))
                {
                    aposComerPos = (lin - 2).ToString() + (col - 2).ToString();
                    if (ImageButtons[aposComerPos].ImageUrl == "~/Imagens/vazio.png") //Tem casa vazia após peça alvo?
                    {
                        //Caso a peça atual seja vermelha
                        if ((ImageButtons[atualPos].ImageUrl == "~/Imagens/vermelho.png") && (ImageButtons[alvoPos].ImageUrl == "~/Imagens/preto.png"))
                        {
                            ImageButtons[alvoPos].Enabled = true;
                            ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                            posAtivada = true;
                        }
                        //Caso a peça atual seja preta
                        else if ((ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png") && (ImageButtons[alvoPos].ImageUrl == "~/Imagens/vermelho.png"))
                        {
                            ImageButtons[alvoPos].Enabled = true;
                            ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                            posAtivada = true;
                        }
                    }
                }
            }
            //DIREÇÃO NORDESTE
            if ((col + 1) <= 8) //Movimentar para nordeste, checar possibilidade.
            {
                alvoPos = (lin - 1).ToString() + (col + 1).ToString();
                //Possível movimentar para próxima casa nordeste?
                if (ImageButtons[alvoPos].ImageUrl == "~/Imagens/vazio.png")
                {
                    ImageButtons[alvoPos].Enabled = true;
                    ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                    posAtivada = true;
                }
                //Possível comer peça na próxima casa nordeste?
                if (((lin - 2) > 0) && ((col + 2) <= 8))
                {
                    aposComerPos = (lin - 2).ToString() + (col + 2).ToString();
                    if (ImageButtons[aposComerPos].ImageUrl == "~/Imagens/vazio.png") //Tem casa vazia após peça alvo?
                    {
                        //Caso a peça atual seja vermelha
                        if ((ImageButtons[atualPos].ImageUrl == "~/Imagens/vermelho.png") && (ImageButtons[alvoPos].ImageUrl == "~/Imagens/preto.png"))
                        {
                            ImageButtons[alvoPos].Enabled = true;
                            ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                            posAtivada = true;
                        }
                        //Caso a peça atual seja preta
                        else if ((ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png") && (ImageButtons[alvoPos].ImageUrl == "~/Imagens/vermelho.png"))
                        {
                            ImageButtons[alvoPos].Enabled = true;
                            ImageButtonsAlvos.Add(ImageButtons[alvoPos]);
                            posAtivada = true;
                        }
                    }
                }
            }
        }
        if (posAtivada)
        {
            return atualPos;
        }
        else
            return "";
    }

    //posAtiva É A PEÇA QUE SE MOVIMENTARÁ. atualPos SERÁ O ALVO OU LUGAR VAZIO.
    //Se atualPos é VAZIO, então a posAtiva ficará VAZIO e a peça que se encontrava nela ocupará a atualPos
    //Se atualPos possui peça COR_OPOSTA da peça na posAtiva, então a posAtiva e atualPos ficará VAZIO, e a peça que se encontrava na posAtiva ocupará uma cada depois da atualPos
    public bool comerPeca(String pecaAtivada, String atualPos)
    {
        bool comeu = false;

        if (!pecaAtivada.Equals(""))
        {
            int lin = Convert.ToInt32(pecaAtivada[0].ToString()), col = Convert.ToInt32(pecaAtivada[1].ToString());
            int op = 0;

            //A opção encontrada será o sentido que a pecaAtivada se movimentará.
            if (((lin + 1).ToString() + (col - 1).ToString()) == atualPos)
            {
                op = 1; //sudoeste
            }
            else
            {
                if (((lin + 1).ToString() + (col + 1).ToString()) == atualPos)
                {
                    op = 2; //sudeste
                }
                else
                {
                    if (((lin - 1).ToString() + (col - 1).ToString()) == atualPos)
                    {
                        op = 3; //noroeste
                    }
                    else
                    {
                        if (((lin - 1).ToString() + (col + 1).ToString()) == atualPos)
                        {
                            op = 4; //nordeste
                        }
                        else
                        {
                            op = 0; //zera a variável pra não ter risco de possuir valor de alguma iteração antiga
                        }
                    }
                }
            }

            switch (op)
            {
                //SUDOESTE
                case 1:
                    {
                        if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/vermelho.png")
                        {
                            if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                            {
                                ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                ImageButtons[atualPos].ImageUrl = "~/Imagens/vermelho.png";
                                comeu = true;
                            }
                            else
                            {
                                if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                                {
                                    ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[(lin + 2).ToString() + (col - 2).ToString()].ImageUrl = "~/Imagens/vermelho.png";
                                    comeu = true;
                                }
                            }
                            //ativarPecas("~/Imagens/preto.png");
                        }
                        else
                        {
                            if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/preto.png")
                            {
                                if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                                {
                                    ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[atualPos].ImageUrl = "~/Imagens/preto.png";
                                    comeu = true;
                                }
                                else
                                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vermelho.png")
                                    {
                                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                                        ImageButtons[(lin + 2).ToString() + (col - 2).ToString()].ImageUrl = "~/Imagens/preto.png";
                                        comeu = true;
                                    }
                            }
                            //ativarPecas("~/Imagens/vermelho.png");
                        }
                        break;
                    }
                //SUDESTE
                case 2:
                    {
                        if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/vermelho.png")
                        {
                            if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                            {
                                ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                ImageButtons[atualPos].ImageUrl = "~/Imagens/vermelho.png";
                                comeu = true;
                            }
                            else
                            {
                                if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                                {
                                    ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[(lin + 2).ToString() + (col + 2).ToString()].ImageUrl = "~/Imagens/vermelho.png";
                                    comeu = true;
                                }
                            }
                            //ativarPecas("~/Imagens/preto.png");
                        }
                        else
                        {
                            if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/preto.png")
                            {
                                if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                                {
                                    ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[atualPos].ImageUrl = "~/Imagens/preto.png";
                                    comeu = true;
                                }
                                else
                                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vermelho.png")
                                    {
                                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                                        ImageButtons[(lin + 2).ToString() + (col + 2).ToString()].ImageUrl = "~/Imagens/preto.png";
                                        comeu = true;
                                    }
                            }
                            //ativarPecas("~/Imagens/vermelho.png");
                        }
                        break;
                    }
                //NOROESTE
                case 3:
                    {
                        if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/vermelho.png")
                        {
                            if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                            {
                                ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                ImageButtons[atualPos].ImageUrl = "~/Imagens/vermelho.png";
                                comeu = true;
                            }
                            else
                            {
                                if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                                {
                                    ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[(lin - 2).ToString() + (col - 2).ToString()].ImageUrl = "~/Imagens/vermelho.png";
                                    comeu = true;
                                }
                            }
                            //ativarPecas("~/Imagens/preto.png");
                        }
                        else
                        {
                            if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/preto.png")
                            {
                                if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                                {
                                    ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[atualPos].ImageUrl = "~/Imagens/preto.png";
                                    comeu = true;
                                }
                                else
                                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vermelho.png")
                                    {
                                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                                        ImageButtons[(lin - 2).ToString() + (col - 2).ToString()].ImageUrl = "~/Imagens/preto.png";
                                        comeu = true;
                                    }
                            }
                            //ativarPecas("~/Imagens/vermelho.png");
                        }
                        break;
                    }
                //NORDESTE
                case 4:
                    {
                        if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/vermelho.png")
                        {
                            if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                            {
                                ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                ImageButtons[atualPos].ImageUrl = "~/Imagens/vermelho.png";
                                comeu = true;
                            }
                            else
                            {
                                if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                                {
                                    ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[(lin - 2).ToString() + (col + 2).ToString()].ImageUrl = "~/Imagens/vermelho.png";
                                    comeu = true;
                                }
                            }
                            //ativarPecas("~/Imagens/preto.png");
                        }
                        else
                        {
                            if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/preto.png")
                            {
                                if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                                {
                                    ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                    ImageButtons[atualPos].ImageUrl = "~/Imagens/preto.png";
                                    comeu = true;
                                }
                                else
                                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vermelho.png")
                                    {
                                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                                        ImageButtons[(lin - 2).ToString() + (col + 2).ToString()].ImageUrl = "~/Imagens/preto.png";
                                        comeu = true;
                                    }
                            }
                            //ativarPecas("~/Imagens/vermelho.png");
                        }
                        break;
                    }
                //NENHUMA DAS OPÇÕES
                default:
                    {
                        break;
                    }
            }

            /*//SUDOESTE
            if (((lin + 1).ToString() + (col - 1).ToString()) == atualPos)
            {
                if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/vermelho.png")
                {
                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                    {
                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vermelho.png";
                        comeu = true;
                    }
                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                    {
                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[(lin + 2).ToString() + (col - 2).ToString()].ImageUrl = "~/Imagens/vermelho.png";
                        comeu = true;
                    }
                    //ativarPecas("~/Imagens/preto.png");
                }
                else
                    if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/preto.png")
                    {
                        if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                        {
                            ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[atualPos].ImageUrl = "~/Imagens/preto.png";
                            comeu = true;
                        }
                        if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                        {
                            ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[(lin + 2).ToString() + (col - 2).ToString()].ImageUrl = "~/Imagens/preto.png";
                            comeu = true;
                        }
                        //ativarPecas("~/Imagens/vermelho.png");
                    }
            }

            //SUDESTE            
            if (((lin + 1).ToString() + (col + 1).ToString()) == atualPos)
            {
                if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/vermelho.png")
                {
                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                    {
                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vermelho.png";
                        comeu = true;
                    }
                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                    {
                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[(lin + 2).ToString() + (col + 2).ToString()].ImageUrl = "~/Imagens/vermelho.png";
                        comeu = true;
                    }
                    //ativarPecas("~/Imagens/preto.png");
                }
                else
                    if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/preto.png")
                    {
                        if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                        {
                            ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[atualPos].ImageUrl = "~/Imagens/preto.png";
                            comeu = true;
                        }
                        if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                        {
                            ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[(lin + 2).ToString() + (col + 2).ToString()].ImageUrl = "~/Imagens/preto.png";
                            comeu = true;
                        }
                        //ativarPecas("~/Imagens/vermelho.png");
                    }
            }

            //NOROESTE
            if (((lin - 1).ToString() + (col - 1).ToString()) == atualPos)
            {
                if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/vermelho.png")
                {
                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                    {
                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vermelho.png";
                        comeu = true;
                    }
                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                    {
                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[(lin - 2).ToString() + (col - 2).ToString()].ImageUrl = "~/Imagens/vermelho.png";
                        comeu = true;
                    }
                    //ativarPecas("~/Imagens/preto.png");
                }
                else
                    if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/preto.png")
                    {
                        if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                        {
                            ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[atualPos].ImageUrl = "~/Imagens/preto.png";
                            comeu = true;
                        }
                        if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                        {
                            ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[(lin - 2).ToString() + (col - 2).ToString()].ImageUrl = "~/Imagens/preto.png";
                            comeu = true;
                        }
                        //ativarPecas("~/Imagens/vermelho.png");
                    }
            }

            //NORDESTE
            if (((lin - 1).ToString() + (col + 1).ToString()) == atualPos)
            {
                if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/vermelho.png")
                {
                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                    {
                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vermelho.png";
                        comeu = true;
                    }
                    if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                    {
                        ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                        ImageButtons[(lin - 2).ToString() + (col + 2).ToString()].ImageUrl = "~/Imagens/vermelho.png";
                        comeu = true;
                    }
                    //ativarPecas("~/Imagens/preto.png");
                }
                else
                    if (ImageButtons[pecaAtivada].ImageUrl == "~/Imagens/preto.png")
                    {
                        if (ImageButtons[atualPos].ImageUrl == "~/Imagens/vazio.png")
                        {
                            ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[atualPos].ImageUrl = "~/Imagens/preto.png";
                            comeu = true;
                        }
                        if (ImageButtons[atualPos].ImageUrl == "~/Imagens/preto.png")
                        {
                            ImageButtons[pecaAtivada].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[atualPos].ImageUrl = "~/Imagens/vazio.png";
                            ImageButtons[(lin - 2).ToString() + (col + 2).ToString()].ImageUrl = "~/Imagens/preto.png";
                            comeu = true;
                        }
                        //ativarPecas("~/Imagens/vermelho.png");
                    }
            }*/
        }
        return comeu;
    }

    //SELECIONARÁ UMA PEÇA CASO NÃO EXISTA NENHUMA OUTRA JÁ ATIVA, OU, FARÁ A JOGADA CASO HAJA ALGUMA PEÇA ATIVA E A MOVIMENTAÇÃO SEJA POSSÍVEL
    public String jogar(String posicao, String pecaAtivada)
    {
        if (comerPeca(pecaAtivada, posicao)) //Caso exista alguma peça selecionada:
        {
            pecaAtivada = "";
        }
        else
        {
            pecaAtivada = ativarMovimentosPossiveis(posicao);
        }
        return pecaAtivada;
    }

    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("11", pecaSelecionada);
    }
    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("13", pecaSelecionada);
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("15", pecaSelecionada);
    }
    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("17", pecaSelecionada);
    }
    protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("22", pecaSelecionada);
    }
    protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("24", pecaSelecionada);
    }
    protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("26", pecaSelecionada);
    }
    protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("28", pecaSelecionada);
    }
    protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("31", pecaSelecionada);
    }
    protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("33", pecaSelecionada);
    }
    protected void ImageButton35_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("35", pecaSelecionada);
    }
    protected void ImageButton37_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("37", pecaSelecionada);
    }
    protected void ImageButton42_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("42", pecaSelecionada);
    }
    protected void ImageButton44_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("44", pecaSelecionada);
    }
    protected void ImageButton46_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("46", pecaSelecionada);
    }
    protected void ImageButton48_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("48", pecaSelecionada);
    }
    protected void ImageButton51_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("51", pecaSelecionada);
    }
    protected void ImageButton53_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("53", pecaSelecionada);
        /*if (pecaSelecionada.Equals("")) //Se verdadeiro, então nenhuma peça ainda foi selecionada.
        {
            pecaSelecionada = ativarMovimentosPossiveis("53"); //A peça da posição atual será selecionada.
        }
        else
        {
            if (comerPeca(pecaSelecionada, "53")) //Caso não exista alguma peça selecionada:
            {
                pecaSelecionada = "";
                ativarPecas("~/Imagens/preto.png");
            }
        }*/
    }
    protected void ImageButton55_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("55", pecaSelecionada);
    }
    protected void ImageButton57_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("57", pecaSelecionada);
    }
    protected void ImageButton62_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("62", pecaSelecionada);
    }
    protected void ImageButton64_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("64", pecaSelecionada);
        /*if (pecaSelecionada.Equals("")) //Se verdadeiro, então nenhuma peça ainda foi selecionada.
        {
            pecaSelecionada = ativarMovimentosPossiveis("64"); //A peça da posição atual será selecionada.
        }
        else
        {
            if (comerPeca(pecaSelecionada, "64")) //Caso não exista alguma peça selecionada:
            {
                pecaSelecionada = "";
                ativarPecas("~/Imagens/vermelho.png");
            }
        }*/
    }
    protected void ImageButton66_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("66", pecaSelecionada);
    }
    protected void ImageButton68_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("68", pecaSelecionada);
    }
    protected void ImageButton71_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("71", pecaSelecionada);
    }
    protected void ImageButton73_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("73", pecaSelecionada);
    }
    protected void ImageButton75_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("75", pecaSelecionada);
    }
    protected void ImageButton77_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("77", pecaSelecionada);
    }
    protected void ImageButton82_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("82", pecaSelecionada);
    }
    protected void ImageButton84_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("84", pecaSelecionada);
    }
    protected void ImageButton86_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("86", pecaSelecionada);
    }
    protected void ImageButton88_Click(object sender, ImageClickEventArgs e)
    {
        pecaSelecionada = jogar("88", pecaSelecionada);
    }

    public void ativarPeca()
    {

    }

    public void promocao()
    {

    }
}