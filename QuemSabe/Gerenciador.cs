using System;

namespace QuemSabe;

public class Gerenciador : Questao
{
    List<Questao> ListasQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();

    Questao questaoAtual;

    void CriarQuestoes(Label labelPergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5)
    {
        var w1 = new Questao();
        w1.Perguntas = "Vacas podem subir escadas?";
        w1.Resposta1 = "sim";
        w1.Resposta2 = "não";
        w1.Resposta3 = "isso importa?";
        w1.Resposta4 = "com ajuda?";
        w1.Resposta5 = "Nenhuma";
        w1.RespostaCorreta = 2;
        w1.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w1);

        var w2 = new Questao();
        w2.Perguntas = "Quantos pedaços de pizza você pode comer no rodizio antes de ser expulso?";
        w2.Resposta1 = "50";
        w2.Resposta2 = "90";
        w2.Resposta3 = "isso importa?";
        w2.Resposta4 = "300";
        w2.Resposta5 = "o cuzinhero";
        w2.RespostaCorreta = 5;
        w2.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w2);

        var w3 = new Questao();
        w3.Perguntas = "O sol nasce em qual direção?";
        w3.Resposta1 = "Oeste";
        w3.Resposta2 = "Leste";
        w3.Resposta3 = "Norte";
        w3.Resposta4 = "Sul";
        w3.Resposta5 = "Centro";
        w3.RespostaCorreta = 2;
        w3.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w3);

        var w4 = new Questao();
        w4.Perguntas = "Qual é a capital da França?";
        w4.Resposta1 = "Berlim";
        w4.Resposta2 = "Paris";
        w4.Resposta3 = "Londres";
        w4.Resposta4 = "Roma";
        w4.Resposta5 = "Madrid";
        w4.RespostaCorreta = 2;
        w4.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w4);

        var w5 = new Questao();
        w5.Perguntas = "Quantos planetas existem no sistema solar?";
        w5.Resposta1 = "Oito";
        w5.Resposta2 = "Sete";
        w5.Resposta3 = "Nove";
        w5.Resposta4 = "Seis";
        w5.Resposta5 = "Dez";
        w5.RespostaCorreta = 1;
        w5.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w5);

        var w6 = new Questao();
        w6.Perguntas = "Quantos lados tem um triângulo?";
        w6.Resposta1 = "Dois";
        w6.Resposta2 = "Três";
        w6.Resposta3 = "Quatro";
        w6.Resposta4 = "Cinco";
        w6.Resposta5 = "Seis";
        w6.RespostaCorreta = 2;
        w6.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w6);

        var w7 = new Questao();
        w7.Perguntas = "Qual a cor do céu durante o dia?";
        w7.Resposta1 = "Azul";
        w7.Resposta2 = "Vermelho";
        w7.Resposta3 = "Verde";
        w7.Resposta4 = "Amarelo";
        w7.Resposta5 = "Roxo";
        w7.RespostaCorreta = 1;
        w7.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w7);

        var w8 = new Questao();
        w8.Perguntas = "O que é H2O?";
        w8.Resposta1 = "Água";
        w8.Resposta2 = "Vinho";
        w8.Resposta3 = "Fogo";
        w8.Resposta4 = "Ar";
        w8.Resposta5 = "Nenhuma";
        w8.RespostaCorreta = 1;
        w8.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w8);

        var w9 = new Questao();
        w9.Perguntas = "Quantos segundos tem um minuto?";
        w9.Resposta1 = "50";
        w9.Resposta2 = "60";
        w9.Resposta3 = "70";
        w9.Resposta4 = "80";
        w9.Resposta5 = "90";
        w9.RespostaCorreta = 2;
        w9.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w9);

        var w10 = new Questao();
        w10.Perguntas = "Quantos dias tem um ano bissexto?";
        w10.Resposta1 = "365";
        w10.Resposta2 = "366";
        w10.Resposta3 = "364";
        w10.Resposta4 = "367";
        w10.Resposta5 = "363";
        w10.RespostaCorreta = 2;
        w10.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w10);

        var w11 = new Questao();
        w11.Perguntas = "Qual o maior planeta do sistema solar?";
        w11.Resposta1 = "Júpiter";
        w11.Resposta2 = "Saturno";
        w11.Resposta3 = "Marte";
        w11.Resposta4 = "Vênus";
        w11.Resposta5 = "Terra";
        w11.RespostaCorreta = 1;
        w11.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w11);

        var w12 = new Questao();
        w12.Perguntas = "Qual é a língua oficial do Brasil?";
        w12.Resposta1 = "Inglês";
        w12.Resposta2 = "Espanhol";
        w12.Resposta3 = "Francês";
        w12.Resposta4 = "Português";
        w12.Resposta5 = "Italiano";
        w12.RespostaCorreta = 4;
        w12.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w12);

        var w13 = new Questao();
        w13.Perguntas = "Quantos continentes existem no mundo?";
        w13.Resposta1 = "Cinco";
        w13.Resposta2 = "Seis";
        w13.Resposta3 = "Sete";
        w13.Resposta4 = "Oito";
        w13.Resposta5 = "Quatro";
        w13.RespostaCorreta = 3;
        w13.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w13);

        var w14 = new Questao();
        w14.Perguntas = "Qual é o menor país do mundo?";
        w14.Resposta1 = "Monaco";
        w14.Resposta2 = "San Marino";
        w14.Resposta3 = "Vaticano";
        w14.Resposta4 = "Malta";
        w14.Resposta5 = "Andorra";
        w14.RespostaCorreta = 3;
        w14.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w14);

        var w15 = new Questao();
        w15.Perguntas = "Qual é o maior oceano da Terra?";
        w15.Resposta1 = "Atlântico";
        w15.Resposta2 = "Índico";
        w15.Resposta3 = "Pacífico";
        w15.Resposta4 = "Ártico";
        w15.Resposta5 = "Antártico";
        w15.RespostaCorreta = 3;
        w15.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w15);

        var w16 = new Questao();
        w16.Perguntas = "Qual é o animal mais rápido do mundo?";
        w16.Resposta1 = "Guepardo";
        w16.Resposta2 = "Falcão-peregrino";
        w16.Resposta3 = "Leão";
        w16.Resposta4 = "Cavalo";
        w16.Resposta5 = "Águia";
        w16.RespostaCorreta = 2;
        w16.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w16);

        var w17 = new Questao();
        w17.Perguntas = "Quantas cordas tem um violão?";
        w17.Resposta1 = "Quatro";
        w17.Resposta2 = "Cinco";
        w17.Resposta3 = "Seis";
        w17.Resposta4 = "Sete";
        w17.Resposta5 = "Oito";
        w17.RespostaCorreta = 3;
        w17.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w17);

        var w18 = new Questao();
        w18.Perguntas = "Qual é o país mais populoso do mundo?";
        w18.Resposta1 = "Estados Unidos";
        w18.Resposta2 = "Índia";
        w18.Resposta3 = "China";
        w18.Resposta4 = "Brasil";
        w18.Resposta5 = "Rússia";
        w18.RespostaCorreta = 3;
        w18.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w18);

        var w19 = new Questao();
        w19.Perguntas = "Quem pintou a Mona Lisa?";
        w19.Resposta1 = "Leonardo da Vinci";
        w19.Resposta2 = "Michelangelo";
        w19.Resposta3 = "Van Gogh";
        w19.Resposta4 = "Picasso";
        w19.Resposta5 = "Rembrandt";
        w19.RespostaCorreta = 1;
        w19.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w19);

        var w20 = new Questao();
        w20.Perguntas = "Qual é a fórmula química do sal de cozinha?";
        w20.Resposta1 = "NaCl";
        w20.Resposta2 = "H2O";
        w20.Resposta3 = "CO2";
        w20.Resposta4 = "O2";
        w20.Resposta5 = "KCl";
        w20.RespostaCorreta = 1;
        w20.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w20);

        var w21 = new Questao();
        w21.Perguntas = "Em que continente fica o Egito?";
        w21.Resposta1 = "Europa";
        w21.Resposta2 = "África";
        w21.Resposta3 = "Ásia";
        w21.Resposta4 = "América do Sul";
        w21.Resposta5 = "América do Norte";
        w21.RespostaCorreta = 2;
        w21.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w21);

        var w22 = new Questao();
        w22.Perguntas = "Quantos graus tem um ângulo reto?";
        w22.Resposta1 = "45";
        w22.Resposta2 = "60";
        w22.Resposta3 = "90";
        w22.Resposta4 = "180";
        w22.Resposta5 = "360";
        w22.RespostaCorreta = 3;
        w22.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w22);

        var w23 = new Questao();
        w23.Perguntas = "Quem foi o primeiro homem a pisar na Lua?";
        w23.Resposta1 = "Buzz Aldrin";
        w23.Resposta2 = "Neil Armstrong";
        w23.Resposta3 = "Yuri Gagarin";
        w23.Resposta4 = "John Glenn";
        w23.Resposta5 = "Michael Collins";
        w23.RespostaCorreta = 2;
        w23.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w23);

        var w24 = new Questao();
        w24.Perguntas = "Em que ano ocorreu a independência do Brasil?";
        w24.Resposta1 = "1808";
        w24.Resposta2 = "1822";
        w24.Resposta3 = "1888";
        w24.Resposta4 = "1900";
        w24.Resposta5 = "1824";
        w24.RespostaCorreta = 2;
        w24.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w24);

        var w25 = new Questao();
        w25.Perguntas = "Qual o estado brasileiro conhecido como 'terra do sol nascente'?";
        w25.Resposta1 = "Bahia";
        w25.Resposta2 = "Ceará";
        w25.Resposta3 = "Paraíba";
        w25.Resposta4 = "Pernambuco";
        w25.Resposta5 = "Rio Grande do Norte";
        w25.RespostaCorreta = 3;
        w25.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w25);

        var w26 = new Questao();
        w26.Perguntas = "Quem foi o inventor do avião?";
        w26.Resposta1 = "Santos Dumont";
        w26.Resposta2 = "Wright Brothers";
        w26.Resposta3 = "Galileu Galilei";
        w26.Resposta4 = "Isaac Newton";
        w26.Resposta5 = "Leonardo da Vinci";
        w26.RespostaCorreta = 1;
        w26.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w26);

        var w27 = new Questao();
        w27.Perguntas = "Qual é o maior deserto do mundo?";
        w27.Resposta1 = "Saara";
        w27.Resposta2 = "Gobi";
        w27.Resposta3 = "Atacama";
        w27.Resposta4 = "Antártico";
        w27.Resposta5 = "Kalahari";
        w27.RespostaCorreta = 4;
        w27.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w27);

        var w28 = new Questao();
        w28.Perguntas = "Qual é a capital da Austrália?";
        w28.Resposta1 = "Sydney";
        w28.Resposta2 = "Melbourne";
        w28.Resposta3 = "Canberra";
        w28.Resposta4 = "Perth";
        w28.Resposta5 = "Brisbane";
        w28.RespostaCorreta = 3;
        w28.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w28);

        var w29 = new Questao();
        w29.Perguntas = "Qual é a moeda usada no Japão?";
        w29.Resposta1 = "Dólar";
        w29.Resposta2 = "Euro";
        w29.Resposta3 = "Iene";
        w29.Resposta4 = "Won";
        w29.Resposta5 = "Libra";
        w29.RespostaCorreta = 3;
        w29.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w29);

        var w30 = new Questao();
        w30.Perguntas = "Quem escreveu 'Dom Casmurro'?";
        w30.Resposta1 = "José de Alencar";
        w30.Resposta2 = "Jorge Amado";
        w30.Resposta3 = "Machado de Assis";
        w30.Resposta4 = "Monteiro Lobato";
        w30.Resposta5 = "Clarice Lispector";
        w30.RespostaCorreta = 3;
        w30.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w30);

        var w31 = new Questao();
        w31.Perguntas = "Qual é o símbolo químico do ouro?";
        w31.Resposta1 = "Ag";
        w31.Resposta2 = "Au";
        w31.Resposta3 = "Pb";
        w31.Resposta4 = "Fe";
        w31.Resposta5 = "Hg";
        w31.RespostaCorreta = 2;
        w31.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w31);

        var w32 = new Questao();
        w32.Perguntas = "Qual é a cor da bandeira da França?";
        w32.Resposta1 = "Azul, branco e vermelho";
        w32.Resposta2 = "Verde e branco";
        w32.Resposta3 = "Azul e branco";
        w32.Resposta4 = "Preto e vermelho";
        w32.Resposta5 = "Amarelo e vermelho";
        w32.RespostaCorreta = 1;
        w32.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w32);

        var w33 = new Questao();
        w33.Perguntas = "Qual é o gás mais abundante na atmosfera?";
        w33.Resposta1 = "Oxigênio";
        w33.Resposta2 = "Nitrogênio";
        w33.Resposta3 = "Dióxido de carbono";
        w33.Resposta4 = "Hidrogênio";
        w33.Resposta5 = "Ozônio";
        w33.RespostaCorreta = 2;
        w33.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w33);

        var w34 = new Questao();
        w34.Perguntas = "Em qual continente fica o Brasil?";
        w34.Resposta1 = "Europa";
        w34.Resposta2 = "Ásia";
        w34.Resposta3 = "América do Sul";
        w34.Resposta4 = "América do Norte";
        w34.Resposta5 = "África";
        w34.RespostaCorreta = 3;
        w34.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w34);

        var w35 = new Questao();
        w35.Perguntas = "Quem foi o primeiro presidente dos Estados Unidos?";
        w35.Resposta1 = "Abraham Lincoln";
        w35.Resposta2 = "Thomas Jefferson";
        w35.Resposta3 = "George Washington";
        w35.Resposta4 = "John Adams";
        w35.Resposta5 = "James Madison";
        w35.RespostaCorreta = 3;
        w35.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w35);

        var w36 = new Questao();
        w36.Perguntas = "Qual é o menor osso do corpo humano?";
        w36.Resposta1 = "Fêmur";
        w36.Resposta2 = "Estape";
        w36.Resposta3 = "Tíbia";
        w36.Resposta4 = "Úmero";
        w36.Resposta5 = "Vértebra";
        w36.RespostaCorreta = 2;
        w36.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w36);

        var w37 = new Questao();
        w37.Perguntas = "Qual é a montanha mais alta do mundo?";
        w37.Resposta1 = "K2";
        w37.Resposta2 = "Everest";
        w37.Resposta3 = "Kilimanjaro";
        w37.Resposta4 = "Aconcágua";
        w37.Resposta5 = "Makalu";
        w37.RespostaCorreta = 2;
        w37.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w37);

        var w38 = new Questao();
        w38.Perguntas = "Quantas letras tem o alfabeto?";
        w38.Resposta1 = "24";
        w38.Resposta2 = "25";
        w38.Resposta3 = "26";
        w38.Resposta4 = "27";
        w38.Resposta5 = "28";
        w38.RespostaCorreta = 3;
        w38.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w38);

        var w39 = new Questao();
        w39.Perguntas = "Qual é a fórmula química do gás carbônico?";
        w39.Resposta1 = "CO2";
        w39.Resposta2 = "O2";
        w39.Resposta3 = "H2O";
        w39.Resposta4 = "N2O";
        w39.Resposta5 = "CH4";
        w39.RespostaCorreta = 1;
        w39.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w39);

        var w40 = new Questao();
        w40.Perguntas = "Qual é o órgão responsável por bombear o sangue no corpo humano?";
        w40.Resposta1 = "Fígado";
        w40.Resposta2 = "Rim";
        w40.Resposta3 = "Cérebro";
        w40.Resposta4 = "Pulmão";
        w40.Resposta5 = "Coração";
        w40.RespostaCorreta = 5;
        w40.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w40);

        var w41 = new Questao();
        w41.Perguntas = "Em que estado brasileiro está localizada a cidade de Ouro Preto?";
        w41.Resposta1 = "Bahia";
        w41.Resposta2 = "Minas Gerais";
        w41.Resposta3 = "São Paulo";
        w41.Resposta4 = "Rio de Janeiro";
        w41.Resposta5 = "Pernambuco";
        w41.RespostaCorreta = 2;
        w41.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w41);

        var w42 = new Questao();
        w42.Perguntas = "Qual foi o primeiro país a ganhar a Copa do Mundo de Futebol?";
        w42.Resposta1 = "Brasil";
        w42.Resposta2 = "Alemanha";
        w42.Resposta3 = "Argentina";
        w42.Resposta4 = "Uruguai";
        w42.Resposta5 = "Itália";
        w42.RespostaCorreta = 4;
        w42.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w42);

        var w43 = new Questao();
        w43.Perguntas = "Quantos anéis existem no símbolo dos Jogos Olímpicos?";
        w43.Resposta1 = "Três";
        w43.Resposta2 = "Quatro";
        w43.Resposta3 = "Cinco";
        w43.Resposta4 = "Seis";
        w43.Resposta5 = "Sete";
        w43.RespostaCorreta = 3;
        w43.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w43);

        var w44 = new Questao();
        w44.Perguntas = "Em que ano foi fundada a ONU?";
        w44.Resposta1 = "1940";
        w44.Resposta2 = "1945";
        w44.Resposta3 = "1950";
        w44.Resposta4 = "1960";
        w44.Resposta5 = "1970";
        w44.RespostaCorreta = 2;
        w44.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w44);

        var w45 = new Questao();
        w45.Perguntas = "Qual o nome do famoso cientista que formulou a teoria da relatividade?";
        w45.Resposta1 = "Isaac Newton";
        w45.Resposta2 = "Nikola Tesla";
        w45.Resposta3 = "Albert Einstein";
        w45.Resposta4 = "Galileu Galilei";
        w45.Resposta5 = "Stephen Hawking";
        w45.RespostaCorreta = 3;
        w45.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w45);

        var w46 = new Questao();
        w46.Perguntas = "Em que ano o Brasil foi descoberto pelos portugueses?";
        w46.Resposta1 = "1400";
        w46.Resposta2 = "1450";
        w46.Resposta3 = "1500";
        w46.Resposta4 = "1550";
        w46.Resposta5 = "1600";
        w46.RespostaCorreta = 3;
        w46.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w46);

        var w47 = new Questao();
        w47.Perguntas = "O céu é azul?";
        w47.Resposta1 = "sim";
        w47.Resposta2 = "não";
        w47.Resposta3 = "depende do dia";
        w47.Resposta4 = "só à noite";
        w47.Resposta5 = "Nenhuma";
        w47.RespostaCorreta = 1;
        w47.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w47);

        var w48 = new Questao();
        w48.Perguntas = "Peixes podem viver fora da água?";
        w48.Resposta1 = "sim";
        w48.Resposta2 = "não";
        w48.Resposta3 = "só por um tempo";
        w48.Resposta4 = "depende da espécie";
        w48.Resposta5 = "Nenhuma";
        w48.RespostaCorreta = 2;
        w48.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w48);

        var w49 = new Questao();
        w49.Perguntas = "As plantas precisam de luz para crescer?";
        w49.Resposta1 = "sim";
        w49.Resposta2 = "não";
        w49.Resposta3 = "só algumas";
        w49.Resposta4 = "depende do tipo";
        w49.Resposta5 = "Nenhuma";
        w49.RespostaCorreta = 1;
        w49.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w49);

        var w50 = new Questao();
        w50.Perguntas = "O sol é uma estrela?";
        w50.Resposta1 = "sim";
        w50.Resposta2 = "não";
        w50.Resposta3 = "depende do ponto de vista";
        w50.Resposta4 = "só à noite";
        w50.Resposta5 = "Nenhuma";
        w50.RespostaCorreta = 1;
        w50.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w50);

        var w51 = new Questao();
        w51.Perguntas = "Os humanos podem voar?";
        w51.Resposta1 = "sim";
        w51.Resposta2 = "não";
        w51.Resposta3 = "só com ajuda";
        w51.Resposta4 = "depende da tecnologia";
        w51.Resposta5 = "Nenhuma";
        w51.RespostaCorreta = 2;
        w51.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w51);

        var w52 = new Questao();
        w52.Perguntas = "A água é composta por hidrogênio e oxigênio?";
        w52.Resposta1 = "sim";
        w52.Resposta2 = "não";
        w52.Resposta3 = "só se estiver pura";
        w52.Resposta4 = "depende da temperatura";
        w52.Resposta5 = "Nenhuma";
        w52.RespostaCorreta = 1;
        w52.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w52);

        var w53 = new Questao();
        w53.Perguntas = "Os gatos podem ver no escuro?";
        w53.Resposta1 = "sim";
        w53.Resposta2 = "não";
        w53.Resposta3 = "só em baixa luz";
        w53.Resposta4 = "depende da raça";
        w53.Resposta5 = "Nenhuma";
        w53.RespostaCorreta = 1;
        w53.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w53);

        var w54 = new Questao();
        w54.Perguntas = "O chocolate é tóxico para os cães?";
        w54.Resposta1 = "sim";
        w54.Resposta2 = "não";
        w54.Resposta3 = "só em grandes quantidades";
        w54.Resposta4 = "depende do tipo de chocolate";
        w54.Resposta5 = "Nenhuma";
        w54.RespostaCorreta = 1;
        w54.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w54);

        var w55 = new Questao();
        w55.Perguntas = "Os morcegos são mamíferos?";
        w55.Resposta1 = "sim";
        w55.Resposta2 = "não";
        w55.Resposta3 = "só em algumas culturas";
        w55.Resposta4 = "depende da espécie";
        w55.Resposta5 = "Nenhuma";
        w55.RespostaCorreta = 1;
        w55.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w55);

        var w56 = new Questao();
        w56.Perguntas = "As abelhas fazem mel?";
        w56.Resposta1 = "sim";
        w56.Resposta2 = "não";
        w56.Resposta3 = "só em certas épocas";
        w56.Resposta4 = "depende da flor";
        w56.Resposta5 = "Nenhuma";
        w56.RespostaCorreta = 1;
        w56.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w56);

        var w57 = new Questao();
        w57.Perguntas = "O coração é um músculo?";
        w57.Resposta1 = "sim";
        w57.Resposta2 = "não";
        w57.Resposta3 = "só em algumas pessoas";
        w57.Resposta4 = "depende da saúde";
        w57.Resposta5 = "Nenhuma";
        w57.RespostaCorreta = 1;
        w57.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w57);

        var w58 = new Questao();
        w58.Perguntas = "As zebras são brancas com listras pretas?";
        w58.Resposta1 = "sim";
        w58.Resposta2 = "não";
        w58.Resposta3 = "só em algumas espécies";
        w58.Resposta4 = "depende da luz";
        w58.Resposta5 = "Nenhuma";
        w58.RespostaCorreta = 1;
        w58.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w58);

        var w59 = new Questao();
        w59.Perguntas = "A lua é um planeta?";
        w59.Resposta1 = "sim";
        w59.Resposta2 = "não";
        w59.Resposta3 = "só se for vista de longe";
        w59.Resposta4 = "depende do contexto";
        w59.Resposta5 = "Nenhuma";
        w59.RespostaCorreta = 2;
        w59.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w59);

        var w60 = new Questao();
        w60.Perguntas = "A eletricidade pode ser armazenada?";
        w60.Resposta1 = "sim";
        w60.Resposta2 = "não";
        w60.Resposta3 = "só em alguns casos";
        w60.Resposta4 = "depende da fonte";
        w60.Resposta5 = "Nenhuma";
        w60.RespostaCorreta = 1;
        w60.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w60);

        var w61 = new Questao();
        w61.Perguntas = "As tartarugas vivem mais que os humanos?";
        w61.Resposta1 = "sim";
        w61.Resposta2 = "não";
        w61.Resposta3 = "só algumas";
        w61.Resposta4 = "depende da espécie";
        w61.Resposta5 = "Nenhuma";
        w61.RespostaCorreta = 1;
        w61.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w61);

        var w62 = new Questao();
        w62.Perguntas = "A superfície da Terra é 70% água?";
        w62.Resposta1 = "sim";
        w62.Resposta2 = "não";
        w62.Resposta3 = "só nos oceanos";
        w62.Resposta4 = "depende do local";
        w62.Resposta5 = "Nenhuma";
        w62.RespostaCorreta = 1;
        w62.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w62);

        var w63 = new Questao();
        w63.Perguntas = "O fogo é um elemento?";
        w63.Resposta1 = "sim";
        w63.Resposta2 = "não";
        w63.Resposta3 = "só em algumas culturas";
        w63.Resposta4 = "depende do contexto";
        w63.Resposta5 = "Nenhuma";
        w63.RespostaCorreta = 2;
        w63.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w63);

        var w64 = new Questao();
        w64.Perguntas = "Os delfins são peixes?";
        w64.Resposta1 = "sim";
        w64.Resposta2 = "não";
        w64.Resposta3 = "só na água";
        w64.Resposta4 = "depende do local";
        w64.Resposta5 = "Nenhuma";
        w64.RespostaCorreta = 2;
        w64.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w64);

        var w65 = new Questao();
        w65.Perguntas = "As cobras têm pernas?";
        w65.Resposta1 = "sim";
        w65.Resposta2 = "não";
        w65.Resposta3 = "só quando jovens";
        w65.Resposta4 = "depende da espécie";
        w65.Resposta5 = "Nenhuma";
        w65.RespostaCorreta = 2;
        w65.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w65);

        var w66 = new Questao();
        w66.Perguntas = "Os humanos podem respirar debaixo d'água?";
        w66.Resposta1 = "sim";
        w66.Resposta2 = "não";
        w66.Resposta3 = "só com equipamento";
        w66.Resposta4 = "depende do treinamento";
        w66.Resposta5 = "Nenhuma";
        w66.RespostaCorreta = 2;
        w66.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w66);

        var w67 = new Questao();
        w67.Perguntas = "As formigas podem levantar até 50 vezes seu peso?";
        w67.Resposta1 = "sim";
        w67.Resposta2 = "não";
        w67.Resposta3 = "só algumas espécies";
        w67.Resposta4 = "depende do tamanho";
        w67.Resposta5 = "Nenhuma";
        w67.RespostaCorreta = 1;
        w67.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w67);

        var w68 = new Questao();
        w68.Perguntas = "A luz viaja mais rápido que o som?";
        w68.Resposta1 = "sim";
        w68.Resposta2 = "não";
        w68.Resposta3 = "só em algumas condições";
        w68.Resposta4 = "depende do meio";
        w68.Resposta5 = "Nenhuma";
        w68.RespostaCorreta = 1;
        w68.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w68);

        var w69 = new Questao();
        w69.Perguntas = "A Terra é o terceiro planeta do sistema solar?";
        w69.Resposta1 = "sim";
        w69.Resposta2 = "não";
        w69.Resposta3 = "só se contarmos a partir do sol";
        w69.Resposta4 = "depende do que consideramos";
        w69.Resposta5 = "Nenhuma";
        w69.RespostaCorreta = 1;
        w69.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w69);

        var w70 = new Questao();
        w70.Perguntas = "As estrelas são feitas de gás?";
        w70.Resposta1 = "sim";
        w70.Resposta2 = "não";
        w70.Resposta3 = "só algumas";
        w70.Resposta4 = "depende da estrela";
        w70.Resposta5 = "Nenhuma";
        w70.RespostaCorreta = 1;
        w70.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w70);

        var w71 = new Questao();
        w71.Perguntas = "O leite é uma bebida feita de frutas?";
        w71.Resposta1 = "sim";
        w71.Resposta2 = "não";
        w71.Resposta3 = "só se for com sabor";
        w71.Resposta4 = "depende do tipo";
        w71.Resposta5 = "Nenhuma";
        w71.RespostaCorreta = 2;
        w71.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w71);

        var w72 = new Questao();
        w72.Perguntas = "As árvores podem viver por milhares de anos?";
        w72.Resposta1 = "sim";
        w72.Resposta2 = "não";
        w72.Resposta3 = "só algumas espécies";
        w72.Resposta4 = "depende do ambiente";
        w72.Resposta5 = "Nenhuma";
        w72.RespostaCorreta = 1;
        w72.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w72);

        var w73 = new Questao();
        w73.Perguntas = "O fogo precisa de oxigênio para queimar?";
        w73.Resposta1 = "sim";
        w73.Resposta2 = "não";
        w73.Resposta3 = "só em alta temperatura";
        w73.Resposta4 = "depende do material";
        w73.Resposta5 = "Nenhuma";
        w73.RespostaCorreta = 1;
        w73.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w73);

        var w74 = new Questao();
        w74.Perguntas = "Os leões vivem em matilhas?";
        w74.Resposta1 = "sim";
        w74.Resposta2 = "não";
        w74.Resposta3 = "só em alguns lugares";
        w74.Resposta4 = "depende da espécie";
        w74.Resposta5 = "Nenhuma";
        w74.RespostaCorreta = 1;
        w74.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w74);

        var w75 = new Questao();
        w75.Perguntas = "A eletricidade é uma forma de energia?";
        w75.Resposta1 = "sim";
        w75.Resposta2 = "não";
        w75.Resposta3 = "só em certas condições";
        w75.Resposta4 = "depende da fonte";
        w75.Resposta5 = "Nenhuma";
        w75.RespostaCorreta = 1;
        w75.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w75);

        var w76 = new Questao();
        w76.Perguntas = "Os pinguins podem voar?";
        w76.Resposta1 = "sim";
        w76.Resposta2 = "não";
        w76.Resposta3 = "só em situações extremas";
        w76.Resposta4 = "depende da espécie";
        w76.Resposta5 = "Nenhuma";
        w76.RespostaCorreta = 2;
        w76.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w76);

        var w77 = new Questao();
        w77.Perguntas = "As nuvens são feitas de água?";
        w77.Resposta1 = "sim";
        w77.Resposta2 = "não";
        w77.Resposta3 = "só em dias de chuva";
        w77.Resposta4 = "depende da altitude";
        w77.Resposta5 = "Nenhuma";
        w77.RespostaCorreta = 1;
        w77.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w77);

        var w78 = new Questao();
        w78.Perguntas = "As avestruzes podem voar?";
        w78.Resposta1 = "sim";
        w78.Resposta2 = "não";
        w78.Resposta3 = "só se forem treinadas";
        w78.Resposta4 = "depende da espécie";
        w78.Resposta5 = "Nenhuma";
        w78.RespostaCorreta = 2;
        w78.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w78);

        var w79 = new Questao();
        w79.Perguntas = "O aquecimento global é causado por atividades humanas?";
        w79.Resposta1 = "sim";
        w79.Resposta2 = "não";
        w79.Resposta3 = "só em parte";
        w79.Resposta4 = "depende da região";
        w79.Resposta5 = "Nenhuma";
        w79.RespostaCorreta = 1;
        w79.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w79);

        var w80 = new Questao();
        w80.Perguntas = "Os tubarões são peixes?";
        w80.Resposta1 = "sim";
        w80.Resposta2 = "não";
        w80.Resposta3 = "só em algumas condições";
        w80.Resposta4 = "depende da espécie";
        w80.Resposta5 = "Nenhuma";
        w80.RespostaCorreta = 1;
        w80.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w80);

        var w81 = new Questao();
        w81.Perguntas = "O núcleo da Terra é sólido?";
        w81.Resposta1 = "sim";
        w81.Resposta2 = "não";
        w81.Resposta3 = "só em algumas partes";
        w81.Resposta4 = "depende da temperatura";
        w81.Resposta5 = "Nenhuma";
        w81.RespostaCorreta = 1;
        w81.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w81);

        var w82 = new Questao();
        w82.Perguntas = "O corpo humano tem 206 ossos?";
        w82.Resposta1 = "sim";
        w82.Resposta2 = "não";
        w82.Resposta3 = "só na idade adulta";
        w82.Resposta4 = "depende da pessoa";
        w82.Resposta5 = "Nenhuma";
        w82.RespostaCorreta = 1;
        w82.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w82);

        var w83 = new Questao();
        w83.Perguntas = "Os morcegos são cegos?";
        w83.Resposta1 = "sim";
        w83.Resposta2 = "não";
        w83.Resposta3 = "só em algumas espécies";
        w83.Resposta4 = "depende da situação";
        w83.Resposta5 = "Nenhuma";
        w83.RespostaCorreta = 2;
        w83.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w83);

        var w84 = new Questao();
        w84.Perguntas = "As orcas são baleias?";
        w84.Resposta1 = "sim";
        w84.Resposta2 = "não";
        w84.Resposta3 = "só em alguns contextos";
        w84.Resposta4 = "depende do local";
        w84.Resposta5 = "Nenhuma";
        w84.RespostaCorreta = 1;
        w84.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w84);

        var w85 = new Questao();
        w85.Perguntas = "Os cogumelos são plantas?";
        w85.Resposta1 = "sim";
        w85.Resposta2 = "não";
        w85.Resposta3 = "só em algumas definições";
        w85.Resposta4 = "depende da espécie";
        w85.Resposta5 = "Nenhuma";
        w85.RespostaCorreta = 2;
        w85.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w85);

        var w86 = new Questao();
        w86.Perguntas = "A Grande Muralha da China é visível do espaço?";
        w86.Resposta1 = "sim";
        w86.Resposta2 = "não";
        w86.Resposta3 = "só com telescópio";
        w86.Resposta4 = "depende do clima";
        w86.Resposta5 = "Nenhuma";
        w86.RespostaCorreta = 2;
        w86.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w86);

        var w87 = new Questao();
        w87.Perguntas = "Os camelos armazenam água em suas corcovas?";
        w87.Resposta1 = "sim";
        w87.Resposta2 = "não";
        w87.Resposta3 = "só em situações extremas";
        w87.Resposta4 = "depende da espécie";
        w87.Resposta5 = "Nenhuma";
        w87.RespostaCorreta = 2;
        w87.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w87);

        var w88 = new Questao();
        w88.Perguntas = "O ácido é sempre corrosivo?";
        w88.Resposta1 = "sim";
        w88.Resposta2 = "não";
        w88.Resposta3 = "só em altas concentrações";
        w88.Resposta4 = "depende do tipo";
        w88.Resposta5 = "Nenhuma";
        w88.RespostaCorreta = 3;
        w88.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w88);

        var w89 = new Questao();
        w89.Perguntas = "As abelhas são importantes para a polinização?";
        w89.Resposta1 = "sim";
        w89.Resposta2 = "não";
        w89.Resposta3 = "só em algumas plantas";
        w89.Resposta4 = "depende da região";
        w89.Resposta5 = "Nenhuma";
        w89.RespostaCorreta = 1;
        w89.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w89);

        var w90 = new Questao();
        w90.Perguntas = "Os relâmpagos nunca atingem o mesmo lugar duas vezes?";
        w90.Resposta1 = "sim";
        w90.Resposta2 = "não";
        w90.Resposta3 = "só em áreas planas";
        w90.Resposta4 = "depende do clima";
        w90.Resposta5 = "Nenhuma";
        w90.RespostaCorreta = 2;
        w90.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w90);

        var w91 = new Questao();
        w91.Perguntas = "O corpo humano pode se regenerar completamente?";
        w91.Resposta1 = "sim";
        w91.Resposta2 = "não";
        w91.Resposta3 = "só em algumas partes";
        w91.Resposta4 = "depende da saúde";
        w91.Resposta5 = "Nenhuma";
        w91.RespostaCorreta = 3;
        w91.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w91);

        var w92 = new Questao();
        w92.Perguntas = "Os pássaros migratórios voam em formação?";
        w92.Resposta1 = "sim";
        w92.Resposta2 = "não";
        w92.Resposta3 = "só em algumas espécies";
        w92.Resposta4 = "depende do clima";
        w92.Resposta5 = "Nenhuma";
        w92.RespostaCorreta = 1;
        w92.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w92);

        var w93 = new Questao();
        w93.Perguntas = "A água do mar é mais salgada que a água doce?";
        w93.Resposta1 = "sim";
        w93.Resposta2 = "não";
        w93.Resposta3 = "só em algumas partes do mundo";
        w93.Resposta4 = "depende da época";
        w93.Resposta5 = "Nenhuma";
        w93.RespostaCorreta = 1;
        w93.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w93);

        var w94 = new Questao();
        w94.Perguntas = "O som viaja mais rápido na água do que no ar?";
        w94.Resposta1 = "sim";
        w94.Resposta2 = "não";
        w94.Resposta3 = "só em baixas temperaturas";
        w94.Resposta4 = "depende da profundidade";
        w94.Resposta5 = "Nenhuma";
        w94.RespostaCorreta = 1;
        w94.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w94);

        var w95 = new Questao();
        w95.Perguntas = "As tartarugas têm conchas duras?";
        w95.Resposta1 = "sim";
        w95.Resposta2 = "não";
        w95.Resposta3 = "só as marinhas";
        w95.Resposta4 = "depende da espécie";
        w95.Resposta5 = "Nenhuma";
        w95.RespostaCorreta = 1;
        w95.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w95);

        var w96 = new Questao();
        w96.Perguntas = "O espaço é totalmente vazio?";
        w96.Resposta1 = "sim";
        w96.Resposta2 = "não";
        w96.Resposta3 = "só em algumas regiões";
        w96.Resposta4 = "depende do que consideramos vazio";
        w96.Resposta5 = "Nenhuma";
        w96.RespostaCorreta = 2;
        w96.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w96);

        var w97 = new Questao();
        w97.Perguntas = "As células humanas têm núcleos?";
        w97.Resposta1 = "sim";
        w97.Resposta2 = "não";
        w97.Resposta3 = "só as células musculares";
        w97.Resposta4 = "depende do tipo celular";
        w97.Resposta5 = "Nenhuma";
        w97.RespostaCorreta = 1;
        w97.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w97);

        var w98 = new Questao();
        w98.Perguntas = "Os crustáceos têm exoesqueleto?";
        w98.Resposta1 = "sim";
        w98.Resposta2 = "não";
        w98.Resposta3 = "só algumas espécies";
        w98.Resposta4 = "depende do ambiente";
        w98.Resposta5 = "Nenhuma";
        w98.RespostaCorreta = 1;
        w98.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w98);

        var w99 = new Questao();
        w99.Perguntas = "Os sapos podem viver tanto na água quanto em terra?";
        w99.Resposta1 = "sim";
        w99.Resposta2 = "não";
        w99.Resposta3 = "só em algumas fases da vida";
        w99.Resposta4 = "depende da espécie";
        w99.Resposta5 = "Nenhuma";
        w99.RespostaCorreta = 1;
        w99.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w99);

        var w100 = new Questao();
        w100.Perguntas = "As montanhas se formam por atividade tectônica?";
        w100.Resposta1 = "sim";
        w100.Resposta2 = "não";
        w100.Resposta3 = "só em algumas regiões";
        w100.Resposta4 = "depende da idade";
        w100.Resposta5 = "Nenhuma";
        w100.RespostaCorreta = 1;
        w100.ConfiguraDesenho(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
        ListasQuestoes.Add(w100);

     

    }

    public void ProximaQuestao()
    {
        var NumRodomico = Random.Shared.Next(0, ListasQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(NumRodomico))
        {
            NumRodomico = Random.Shared.Next(0, ListasQuestoes.Count);

            ListaQuestoesRespondidas.Add(NumRodomico);
            questaoAtual = ListasQuestoes[NumRodomico];
            questaoAtual.Desenhar();
        }
    }

    public void AdicionaPergunta(Questao questao)
  {
    ListasQuestoes.Add(questao);
  }

    public async void VerificaCerta(int certa)
    {
        if (questaoAtual.VerificaQuestao(certa))
        {
            await Task.Delay(1000);
            ProximaQuestao();
        }
    }

    public Gerenciador(Label labelPergunta, Button BotaoResposta1, Button BotaoResposta2, Button BotaoResposta3, Button BotaoResposta4, Button BotaoResposta5)
    {
        CriarQuestoes(labelPergunta, BotaoResposta1, BotaoResposta2, BotaoResposta3, BotaoResposta4, BotaoResposta5);
    }


}
