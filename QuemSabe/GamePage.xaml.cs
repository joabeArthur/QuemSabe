namespace QuemSabe;

public partial class GamePage : ContentPage
{
	Gerenciador gerenciador;
	Questao questao;

	public GamePage()
	{
		InitializeComponent();

		gerenciador = new Gerenciador(PerguntaLabel, Resposta1, Resposta2, Resposta3, Resposta4, Resposta5);
		
		gerenciador.ProximaQuestao();
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

