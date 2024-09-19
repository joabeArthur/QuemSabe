namespace QuemSabe;

public class Questao
{
    public int IdPage = 0;
    public int PerguntasId = 0;
    public string? Perguntas;
    public string? Resposta1;
    public string? Resposta2;
    public string? Resposta3;
    public string? Resposta4;
    public string? Resposta5;
    public int RespostaCorreta;

    //==================================================================\\
    private int NivelId { get; set; }
    public Label labelPergunta;
    private Button BotaoA;
    private Button BotaoB;
    private Button BotaoC;
    private Button BotaoD;
    private Button BotaoE;

    //===================================================================\\

    public Questao()
    {

    }

    public Questao(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
    {
        BotaoA = button1;
        BotaoB = button2;
        BotaoC = button3;
        BotaoD = button4;
        BotaoE = button5;
    }

    public void ConfiguraDesenho(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
    {
        labelPergunta = labelpergunta;
        BotaoA = button1;
        BotaoB = button2;
        BotaoC = button3;
        BotaoD = button4;
        BotaoE = button5;
    }
    public void Desenhar()
    {
        labelPergunta.Text = Perguntas;
        BotaoA.Text = Resposta1;
        BotaoB.Text = Resposta2;
        BotaoC.Text = Resposta3;
        BotaoD.Text = Resposta4;
        BotaoE.Text = Resposta5;
    }

    private Button QualBotao(int RespostaSelecionada)
    {
        if (RespostaSelecionada == 1)
        {
            return BotaoA;
        }
        else if (RespostaSelecionada == 2)
        {
            return BotaoB;
        }
        else if (RespostaSelecionada == 3)
        {
            return BotaoC;
        }
        else if (RespostaSelecionada == 4)
        {
            return BotaoD;
        }
        else if (RespostaSelecionada == 5)
        {
            return BotaoE;
        }
        else
        {
            return null;
        }
    }
    public bool VerificaQuestao(int QuestaoSelecionada)
    {
        if (RespostaCorreta == QuestaoSelecionada)
        {
            var Button = QualBotao(QuestaoSelecionada);
            Button.BackgroundColor = Colors.Green;
            return true;
        }
        else
        {
            var ButtonCorreto = QualBotao(RespostaCorreta);
            var ButtonIncorreto = QualBotao(QuestaoSelecionada);
            ButtonCorreto.BackgroundColor = Colors.Yellow;
            ButtonIncorreto.BackgroundColor = Colors.Red;
            return false;
        }
    }

}