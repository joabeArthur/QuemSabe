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
    public int NivelResposta;
    public int Pontuacao;
    public Label labelPergunta;
    public Label labelNivel;
    private Button BotaoResposta1;
    private Button BotaoResposta2;
    private Button BotaoResposta3;
    private Button BotaoResposta4;
    private Button BotaoResposta5;

    //===================================================================\\

    public void ConfiguraDesenho(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
    {
        labelPergunta = labelpergunta;
        BotaoResposta1 = button1;
        BotaoResposta2 = button2;
        BotaoResposta3 = button3;
        BotaoResposta4 = button4;
        BotaoResposta5 = button5;
    }

    public void Desenhar()
    {
        labelPergunta.Text = Perguntas;
        BotaoResposta1.Text = Resposta1;
        BotaoResposta2.Text = Resposta2;
        BotaoResposta3.Text = Resposta3;
        BotaoResposta4.Text = Resposta4;
        BotaoResposta5.Text = Resposta5;
    }
    
    public Questao()
    {

    }

    public Questao(Label labelpergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5)
    {
        labelPergunta = labelpergunta;
        this.BotaoResposta1 = BotaoResposta1;
        this.BotaoResposta2 = BotaoResposta2;
        this.BotaoResposta3 = BotaoResposta3;
        this.BotaoResposta4 = BotaoResposta4;
        this.BotaoResposta5 = BotaoResposta5;
    }

    private Button QualBotao(int RespostaSelecionada)
    {
        if (RespostaSelecionada == 1)
        {
            return BotaoResposta1;
        }
        else if (RespostaSelecionada == 2)
        {
            return BotaoResposta2;
        }
        else if (RespostaSelecionada == 3)
        {
            return BotaoResposta3;
        }
        else if (RespostaSelecionada == 4)
        {
            return BotaoResposta4;
        }
        else if (RespostaSelecionada == 5)
        {
            return BotaoResposta5;
        }
        else
        {
            return null;
        }
    }

    public bool VerificaQuestao(int RespostaSelecionada){
        if(RespostaCorreta == RespostaSelecionada){
            var button = QualBotao(RespostaSelecionada);
            button.BackgroundColor = Colors.Green;
            return true;
        }
        else{
            var buttonCorreto = QualBotao(RespostaCorreta);
            var buttonIncorreto = QualBotao(RespostaSelecionada);
            buttonCorreto.BackgroundColor = Colors.Green;
            buttonIncorreto.BackgroundColor = Colors.Red; 
            return false;
        }
    }

}