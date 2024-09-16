namespace QuemSabe;

public partial class MainPage : ContentPage
{
	public string Perguntas;
	public string Resposta1;
	public string Resposta2;
	public string Resposta3;
	public string Resposta4;
	public int RespostaCorreata { get; set; }

//==================================================================\\
	private int NivelId { get; set; }
	private int Resposta1Id { get; set; }
	private int Resposta2Id { get; set; }
	private int Resposta3Id { get; set; }
	private int Resposta4Id { get; set; }
	private int RespostaCorretaId { get; set; }

//==================================================================\\

	List<pergunta> pergunta = new List<pergunta>;  

//==================================================================\\

	public MainPage()
	{
		InitializeComponent();

		pergunta.Add("Quantas linhas tem cu?");
		pergunta.Add("Vacas conseguem subir escadas?");
		pergunta.Add("Quem se mexer é gay?")
	}

//==================================================================\\


}

