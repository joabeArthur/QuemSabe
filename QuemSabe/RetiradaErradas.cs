namespace QuemSabe;

public class RetiradaErradas : IAjuda
{
    Questao questao = new Questao();
    public override void RealizarAjuda(Questao questao)
    {
        switch (questao.NivelResposta)
        {
            case 1:
            BotaoResposta2.IsVisible = false;
            BotaoResposta3.IsVisible = false;
            BotaoResposta5.IsVisible = false;
            break;
            case 2:
            BotaoResposta1.IsVisible = false;
            BotaoResposta3.IsVisible = false;
            BotaoResposta4.IsVisible = false;
            break;
            case 3: 
            BotaoResposta2.IsVisible = false;
            BotaoResposta4.IsVisible = false;
            BotaoResposta5.IsVisible = false;
            break;
            case 4:
            BotaoResposta2.IsVisible = false;
            BotaoResposta1.IsVisible = false;
            BotaoResposta4.IsVisible = false;
            break;
            case 5:
            BotaoResposta1.IsVisible = false;
            BotaoResposta3.IsVisible = false;
            BotaoResposta5.IsVisible = false;
            break;
        }
    }
}