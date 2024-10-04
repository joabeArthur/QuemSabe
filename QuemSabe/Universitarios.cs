using Microsoft.VisualBasic;

namespace QuemSabe;

public class  Universitarios : IAjuda
{
    
    public override void RealizarAjuda(Questao questao)
    {
    var porcetagem = 100;

    for (int creu = 0; creu < 5; creu++)
    {
        int numRandomico = 0;

        if (porcetagem > 0)
        {
            numRandomico = Random.Shared.Next(0, porcetagem);
            porcetagem -= numRandomico;
        }

        switch (creu)
        {
            case 0:
            BotaoResposta1.Text += "-" + numRandomico.ToString() + "%";
            break;
            case 1:
            BotaoResposta2.Text += "-" + numRandomico.ToString() + "%";
            break;
            case 2:
            BotaoResposta3.Text += "-" + numRandomico.ToString() + "%";
            break;
            case 3:
            BotaoResposta4.Text += "-" + numRandomico.ToString() + "%";
            break;
            case 4:
            BotaoResposta5.Text += "-" + numRandomico.ToString() + "%";
            break;
        }
    }
    }
}