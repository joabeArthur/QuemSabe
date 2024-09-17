namespace QuemSabe;

public class QuemSabe
{
    public int IdPage = 1;
    public int PerguntasId = 1;
    public string Perguntas;
	public string Resposta1;
	public string Resposta2;
	public string Resposta3;
	public string Resposta4;
    public string Resposta5;
	public bool RespostaCorreta;

//==================================================================\\
	private int NivelId { get; set; }
	private Button RespostaButton1;
	private Button RespostaButton2;
	private Button RespostaButton3;
	private Button RespostaButton4;
    private Button RespostaButton5;

//===================================================================\\
    public void Desenhar()
    {
        Resposta1 = RespostaButton1;
        Resposta2 = RespostaButton2;
        Resposta3 = RespostaButton3;
        Resposta4 = RespostaButton4;
        Resposta5 = RespostaButton5;
    }

   /* public void ACERTO(int oo)
    {
        PerguntasId == 
    }

    public void */
}