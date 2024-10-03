namespace QuemSabe;

public partial class GamePage : ContentPage
{
	Gerenciador gerenciador;
	Questao questao;
	RetiradaErradas retirarErradas;
	public GamePage()
	{
		InitializeComponent();

		retirarErradas = new RetiradaErradas();
		gerenciador = new Gerenciador(labelNivel, labelPontuacao, PerguntaLabel, Resposta1, Resposta2, Resposta3, Resposta4, Resposta5);
		gerenciador.ProximaQuestao();
	}

	void AjudaTirarBTN(object creu, EventArgs e)
	{
		var ajuda = new RetiradaErradas();
		ajuda.ConfiguraDesenho(Resposta1, Resposta2, Resposta3, Resposta4, Resposta5);
		ajuda.RealizarAjuda(gerenciador.GetQuestaoAtual());
		(creu as Button).IsVisible = false;
	}

	void PulaPraViado(object creu, EventArgs e)
	{
		gerenciador.ProximaQuestao();
		(creu as Button).IsVisible = true;
	}

	void BotaoAClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaCerta(1);
	}	

	void BotaoBClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaCerta(2);
	}

	void BotaoCClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaCerta(3);
	}

	void BotaoDClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaCerta(4);
	}

	void BotaoEClicado(object sender, EventArgs args)
	{
		gerenciador.VerificaCerta(5);
	}


}

