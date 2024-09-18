namespace QuemSabe;

public class QuemSabe
{
    public int IdPage = 1;
    public int PerguntasId = 1;
    public string? Perguntas;
	public string? Resposta1;
	public string? Resposta2;
	public string? Resposta3;
	public string? Resposta4;
    public string? Resposta5;
	public bool RespostaCorreta;

//==================================================================\\
	private int NivelId { get; set; }
    public Label labelPergunta;
	private Button RespostaButton1;
	private Button RespostaButton2;
	private Button RespostaButton3;
	private Button RespostaButton4;
    private Button RespostaButton5;

//===================================================================\\
    public void Desenhar()
    {
        BotaoA.Text = RespostaButton1;
        BotaoB.Text = RespostaButton2;
        BotaoC.Text = RespostaButton3;
        BotaoD.Text = RespostaButton4;
        BotaoE.Text = RespostaButton5;
    }

   /* public void ACERTO(int oo)
    {
        PerguntasId == 
    }

    public void */
}