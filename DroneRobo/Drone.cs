using BracosDrone;
namespace DroneRobo;


public class Drone
{
    private double altura;
    private double velocidade;
    private int direcao;
    private int cameraX;
    private int cameraY;
    private bool gravando;
    private bool parado;
    public bool aproximado;

    public Drone()
    {
        altura = 0.5;
        velocidade = 0;
        direcao = 0;
        cameraX = 0;
        cameraY = 0;
        gravando = false;
        parado = true;
        aproximado = false;
    }

    public void status()
    {
        Console.WriteLine($"Altura: {this.altura}m\n" +
            $"Velocidade: {this.velocidade}m/s\n" +
            $"Direção: {this.direcao}° graus\n" +
            $"Câmera:\n" +
            $"Eixo x da câmera: {cameraX}° graus\n" +
            $"Eixo y da Cãmera: {cameraY}° graus\n" +
            $"Gravando: {gravando}");
    }
    public void ajustarAltura(double novaAltura)
    {
        if (!aproximado)
        {
            if (novaAltura > 25)
            {
                novaAltura = 25;
            }
            else if (novaAltura < 0.5)
            {
                novaAltura = 0.5;
            }
            this.altura = novaAltura;
            Console.WriteLine($"O drone foi para {this.altura} metros de altura");
        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void subir()
    {

        if (!aproximado)
        {
            if (altura <= 24.5)
            {
                altura += 0.5;
                Console.WriteLine($"Subiu para {altura} metros de altura");
            }
            else if (altura > 24.5 && altura < 25)
            {
                altura += 25 - altura;
                Console.WriteLine($"Subiu para {altura} metros de altura");
            }
            else
            {
                Console.WriteLine("O drone está no limite máximo de altura");
            }

        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void descer()
    {

        if (!aproximado)
        {
            if (altura >= 1)
            {
                altura -= 0.5;
                Console.WriteLine($"Desceu para {altura} metros de altura");
            }
            else if (altura < 1 && altura > 0.5)
            {
                altura -= altura - 0.5;
                Console.WriteLine($"Desceu para {altura} metros de altura");
            }
            else
            {
                Console.WriteLine("O drone está no limite mínimo de altura");
            }
        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void ajustarVelocidade(double novaVelocidade)
    {
        if (!aproximado)
        {
            velocidade = novaVelocidade;
            if (velocidade > 0) { parado = false; } else { parado = true; }
            if (novaVelocidade > 15)
            {
                velocidade = 15;
            }
            else if (novaVelocidade < 0)
            {
                velocidade = 0;
                parado = true;
            }
            Console.WriteLine($"velocidade foi para {velocidade} m/s");
        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void acelerar()
    {

        if (!aproximado)
        {
            if (velocidade <= 14.5)
            {
                velocidade += 0.5;
                Console.WriteLine($"Acelerou para {velocidade} m/s");
                if (velocidade > 0) { parado = false; }
            }
            else if (altura > 14.5 && altura < 15)
            {
                velocidade += 15 - velocidade;
                Console.WriteLine($"Acelerou para {velocidade} m/s");
            }
            else
            {
                Console.WriteLine("O drone está no limite máximo de velocidade");
            }
        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void desacelerar()
    {

        if (!aproximado)
        {
            if (velocidade >= 0.5)
            {
                velocidade -= 0.5;
                Console.WriteLine($"Desacelerou para {velocidade} m/s");
                if (velocidade == 0) { parado = true; }
            }
            else if (velocidade < 0.5 && velocidade > 0)
            {
                velocidade -= velocidade;
                Console.WriteLine($"Desacelerou para {velocidade} m/s");
                if (velocidade == 0) { parado = true; }
            }
            else
            {
                Console.WriteLine("O drone está no limite mínimo de velocidade");
            }
        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void ajustarDirecao(int novaDirecao)
    {
        if (!aproximado)
        {
            direcao = novaDirecao % 360;
            if (direcao < 0)
            {
                direcao += 360;
            }
            Console.WriteLine($"Direcionado para {direcao}° graus");

        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void virarEsq()
    {

        if (!aproximado)
        {
            direcao -= 5;
            if (direcao < 0)
            { direcao += 360; }
            Console.WriteLine($"Direcionado para {direcao}° graus");
        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void virarDir()
    {

        if (!aproximado)
        {
            direcao += 5;
            direcao = direcao % 360;
            Console.WriteLine($"Direcionado para {direcao}° graus");
        }
        else
        {
            Console.WriteLine("Incapaz de realizar essa ação enquanto aproximado de um objeto");
        }
    }

    public void alterarCameraX(int novaCameraX)
    {
        cameraX = novaCameraX % 360;
        if (cameraX < 0)
        {
            cameraX += 360;
        }
        Console.WriteLine($"Direcionado horizontalmente a câmera para {cameraX}° graus");
    }

    public void virarEsqCamera()
    {
        cameraX -= 5;
        if (cameraX < 0)
        { cameraX += 360; }
        Console.WriteLine($"Virou à esquerda com a camera para {cameraX}° graus");
    }

    public void virarDirCamera()
    {
        cameraX += 5;
        cameraX = cameraX % 360;
        Console.WriteLine($"Virou à direita com a camera para {cameraX}° graus");
    }

    public void alterarCameraY(int novaCameraY)
    {
        cameraY = novaCameraY % 360;
        if (cameraY < 0)
        {
            cameraY += 360;
        }
        Console.WriteLine($"Direcionado verticalmente a câmera para {cameraY}° graus");
    }

    public void subirCamera()
    {
        cameraY -= 5;
        if (cameraY < 0)
        { cameraY += 360; }
        Console.WriteLine($"Subiu a camera para {cameraY}° graus");
    }

    public void descerCamera()
    {
        cameraY += 5;
        cameraY = cameraY % 360;
        Console.WriteLine($"Desceu a camera para {cameraY}° graus");
    }

    public void capturarFoto()
    {
        Console.WriteLine("O drone capturou uma imagem com sua câmera");
    }

    public void capturarVideo()
    {
        if (gravando)
        {
            Console.WriteLine("O drone já está fazendo uma captura de vídeo");
            Console.WriteLine("Parando captura de vídeo...");
            this.gravando = false;
        }
        else
        {
            Console.WriteLine("O drone começou a fazer uma captura de vídeo");
            this.gravando = true;
        }
    }


    public void aproximarObjeto()
    {
        if (parado == true && aproximado == false)
        {
            aproximado = true;
            Console.WriteLine("O drone está próximo ao objeto");
        }
        else
        {
            Console.WriteLine("Drone já está próximo ao objeto");
        }
    }

    public void desaproximarObjeto()
    {
        if (aproximado)
        {
            aproximado = false;
            Console.WriteLine("O drone se afastou do objeto");
        }
        else
        {
            Console.WriteLine("Drone já se afastou do objeto");
        }
    }

}