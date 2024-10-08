namespace QuemSabe;

public partial class GamePage : ContentPage
{
	Gerenciador gerenciador;
	Questao questao;
	RetiradaErradas retirarErradas;

	int p = 0;
	public GamePage()
	{
		InitializeComponent();

		retirarErradas = new RetiradaErradas();
		gerenciador = new Gerenciador(labelNivel, labelPontuacao, PerguntaLabel, Resposta1, Resposta2, Resposta3, Resposta4, Resposta5);
		gerenciador.ProximaQuestao();
		PulaPergunta.Text = "Arregar 3X";
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

		if (p == 0)
		{
				(creu as Button).IsVisible = true;
				PulaPergunta.Text = "Arregar 2X";
				p++;
		}
		else if (p == 1)
		{
			(creu as Button).IsVisible = true;
				PulaPergunta.Text = "Arregar 1X";
				p++;
		}
		else 
		{
			(creu as Button).IsVisible = false;
		}
	}

	void Universitarios(object creu, EventArgs e)
	{
		var burro = new Universitarios();
		burro.ConfiguraDesenho(Resposta1, Resposta2, Resposta3, Resposta4, Resposta5);
		burro.RealizarAjuda(gerenciador.GetQuestaoAtual());	
		(creu as Button).IsVisible = false;
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

