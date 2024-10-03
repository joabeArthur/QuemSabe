namespace QuemSabe;

public abstract class IAjuda
{
    protected Button BotaoResposta1;
    protected Button BotaoResposta2;
    protected Button BotaoResposta3;
    protected Button BotaoResposta4;
    protected Button BotaoResposta5;
    protected Frame FrameAjuda;

    public void ConfiguraDesenho(Button BotaoReposta1, Button BotaoReposta2, Button BotaoReposta3, Button BotaoReposta4, Button BotaoReposta5)
    {
        this.BotaoResposta1 = BotaoReposta1;
        this.BotaoResposta2 = BotaoReposta2;
        this.BotaoResposta3 = BotaoReposta3;
        this.BotaoResposta4 = BotaoReposta4;
        this.BotaoResposta5 = BotaoReposta5;
    }

    public void ConfiguraDesenho(Frame FrameAjuda)
    {
        this.FrameAjuda = FrameAjuda;
    }

    public abstract void RealizarAjuda(Questao questao);
    
}