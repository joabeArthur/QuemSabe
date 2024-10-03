namespace QuemSabe;

public class RetiradaErradas : IAjuda
{
    public void RealizarAjuda(Questao questao)
    {
        switch (questao.VerificaQuestao)
        {
            case 1:
            BotaoResposta2 = false;
            BotaoResposta3 = false;
            BotaoResposta5 = false;
            break;
            case 2:
            BotaoResposta1 = false;
            BotaoResposta3 = false;
            BotaoResposta4 = false;
            break;
            case 3: 
            BotaoResposta2 = false;
            BotaoResposta4 = false;
            BotaoResposta5 = false;
            break;
            case 4:
            BotaoResposta2 = false;
            BotaoResposta1 = false;
            BotaoResposta4 = false;
            break;
            case 5:
            BotaoResposta1 = false;
            BotaoResposta3 = false;
            BotaoResposta5 = false;
            break;
        }
    }
}