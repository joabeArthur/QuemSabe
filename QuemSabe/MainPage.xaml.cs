namespace QuemSabe;

public partial class MainPage : ContentPage
{
	Gerenciador gerenciador;

//==================================================================\\

	public MainPage()
	{
		InitializeComponent();
		gerenciador = new Gerenciador(PerguntasLabel,BotaoA, BotaoB, BotaoC, BotaoD, BotaoE);
		
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

