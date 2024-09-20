namespace QuemSabe;

public partial class GamePage : ContentPage
{
	Gerenciador gerenciador;

	public GamePage()
	{
		InitializeComponent();

		gerenciador = new Gerenciador(PerguntasLabel, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
		
		gerenciador.ProximaQuestao();
	}

	void BotaoAClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaQuestao(1);
	}	

	void BotaoBClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaQuestao(2);
	}

	void BotaoCClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaQuestao(3);
	}

	void BotaoDClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaQuestao(4);
	}

	void BotaoEClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaQuestao(5);
	}


}

