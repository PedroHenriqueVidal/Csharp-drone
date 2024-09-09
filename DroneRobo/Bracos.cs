using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneRobo;
using MenuUI;
namespace BracosDrone;

public class Bracos
{
    public bool bracoEmRepouso;
    protected bool bracoOcupado;
    protected bool cotoveloEmRepouso;
    protected bool cotoveloContraido;
    protected int rotacaoPulso = 0;

    public Bracos()
    {
        bracoEmRepouso = true;
        bracoOcupado = false;
        cotoveloEmRepouso = true;
        cotoveloContraido = false;
    }

    public void status()
    {
        Console.WriteLine($"Braço em repouso: {bracoEmRepouso}\n" +
            $"Braço ocupado: {bracoOcupado}\n" +
            $"Cotovelo em repouso: {cotoveloEmRepouso}\n" +
            $"Cotovelo contraido: {cotoveloContraido}\n" +
            $"Rotação do Pulso: {rotacaoPulso}");
    }

    public void ativarOuDesativarBraco()
    {
        if (bracoEmRepouso == true && bracoOcupado == false && )
        {
            Console.WriteLine("Braço foi para modo 'em atividade'");
            bracoEmRepouso = false;
        }
        else if (bracoEmRepouso == false && bracoOcupado == true)
        {
            Console.WriteLine("Incapaz de desligar braço enquanto ocupado");
        }
        else
        {
            Console.WriteLine("Braço foi para modo de repouso");
        }
    }

    public void ativarOuDesativarCotovelo()
    {
        if (cotoveloEmRepouso == true && cotoveloContraido == false)
        {
            Console.WriteLine("Cotovelo foi para modo 'em atividade'");
            cotoveloEmRepouso = false;
        }
        else if (cotoveloEmRepouso == false && cotoveloContraido == true)
        {
            Console.WriteLine("Incapaz de desligar cotovelo enquanto contraido");
        }
        else
        {
            Console.WriteLine("Cotovelo foi para modo de repouso");
            cotoveloEmRepouso = true;
        }
    }

    public void contrairOuEstenderCotovelo()
    {
        if (cotoveloEmRepouso == false && cotoveloContraido == false)
        {
            Console.WriteLine("Contraiu cotovelo");
            cotoveloContraido = true;
        }
        else if (cotoveloEmRepouso == true && cotoveloContraido == false)
        {
            Console.WriteLine("Incapaz de contrair enquanto o cotovelo está em repouso");
        }
        else
        {
            Console.WriteLine("Estendeu cotovelo");
            cotoveloContraido = false;
        }
    }

    public void ajustarPulso(int novaRotacao)
    {
        rotacaoPulso = novaRotacao % 360;
        if (rotacaoPulso < 0)
        {
            rotacaoPulso += 360;
        }
        Console.WriteLine($"Direcionado horizontalmente a câmera para {rotacaoPulso}° graus");
    }

    public void girarPulsoPosit()
    {
        rotacaoPulso += 5;
        rotacaoPulso = rotacaoPulso % 360;
        Console.WriteLine($"{rotacaoPulso}° graus");
    }

    public void girarPulsoNegiv()
    {
        rotacaoPulso -= 5;
        if (rotacaoPulso < 0)
        { rotacaoPulso += 360; }
        Console.WriteLine($"{rotacaoPulso}° graus");
    }

    public void armazenar()
    {
        if (bracoOcupado == true && cotoveloEmRepouso == true)
        {
            Console.WriteLine("Objeto foi armazenado");
            bracoOcupado = false;
        }
        else
        {
            Console.WriteLine("Não é possível armazenar, observe se o cotovelo está em repouso e braço ocupado");
        }

    }

    public void pegar()
    {
        if (cotoveloContraido ==  true && bracoOcupado == false)
        {
            Console.WriteLine("Drone pegou o objeto");
            bracoOcupado = true;
        }
        else
        {
            Console.WriteLine("Não foi possível pegar, cotovelo deve estar contraído e braço desocupado");
        }
    }
}

public class BracoEsquerdo : Bracos
{
    public void bater()
    {
        if (cotoveloContraido == true && bracoOcupado == false)
        {
            Console.WriteLine("Drone bateu com o martelo pequeno para quebrar o objeto");
        }
        else
        {
            Console.WriteLine("Não foi possível bater com o martelo pequeno,\nobserve se o cotovelo está contraído e o braço desocupado");
        }
    }
}

public class BracoDireito : Bracos
{
    public void cortar()
    {
        if (cotoveloContraido == true && bracoOcupado == false)
        {
            Console.WriteLine("Drone usou a tesoura para cortar o objeto");
        }
        else
        {
            Console.WriteLine("Não foi possível cortar objeto,\nobserve se o cotovelo está contraído e o braço desocupado");
        }
    }

    public void coletar()
    {
        if (cotoveloEmRepouso == true && bracoOcupado == false)
        {
            Console.WriteLine("Drone coletou o objeto não sólido");
            bracoOcupado = true;
        }
        else
        {
            Console.WriteLine("Não foi possível coletar, verifique se o cotovelo está em repouso");
        }
    }
}
