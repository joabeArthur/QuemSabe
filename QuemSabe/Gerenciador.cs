namespace QuemSabe;

public class Gerenciador
{
    List <questao> ListasQuestoes = new List <questao>();
    List<int>  ListaQuestoesRespondidas = new List<int>();

    Questao questaoAtual;

    public Gerenciador(Label labelPergunta, Button Resposta1, Button Resposta2, Button Resposta3, Button Resposta4, Button Resposta5)
    {
        CriarQuestoes(labelPergunta, Resposta1, Resposta2, Resposta3, Resposta4, Resposta5);
    }

    void CriarQuestoes(Label labelPergunta, Button Resposta1, Button Resposta2, Button Resposta3, Button Resposta4, Button Resposta5)
    {
        var w1 = new Questao();
        w1.Perguntas = "Vacas podem subir escadas?";
        w1.Resposta1 = "sim";
        w1.Resposta2 = "não";
        w1.Resposta3 = "isso importa?";
        w1.Resposta4 = "com ajuda?";
        w1.Resposta5 = "Nenhuma";
    }
}

