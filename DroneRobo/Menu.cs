using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DroneRobo;
using BracosDrone;

namespace MenuUI
{
    internal class Menu
    {
        private int opcao;
        Drone drone = new Drone();
        BracoEsquerdo bracoEsq = new BracoEsquerdo();
        BracoDireito bracoDir = new BracoDireito();
        public Menu()
        {

            while (this.opcao != 5)
            {
                try
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Que ação deseja realizar com o drone?\n" +
                        "1 - Controlar\n" +
                        "2 - Controlar Câmera\n" +
                        "3 - Braços\n" +
                        "4 - Informações\n" +
                        "5 - Sair do sistema");
                    Console.Write("Selecione um dos números: ");
                    this.opcao = int.Parse(Console.ReadLine());

                    switch (this.opcao)
                    {
                        case 1:
                            this.controlar();
                            break;
                        case 2:
                            this.controlarCamera();
                            break;
                        case 3:
                            this.controlarBracos();
                            break;
                        case 4:
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Status do Drone");
                            Console.WriteLine("--------------------------------");
                            this.drone.status();
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Status do Braço Esquerdo");
                            Console.WriteLine("--------------------------------");
                            this.bracoEsq.status();
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Status do Braço Direito");
                            Console.WriteLine("--------------------------------");
                            this.bracoDir.status();
                            break;
                        case 5:
                            System.Environment.Exit(1);
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Por favor, digite um número válido. Error:" + e.Message);
                }
            }
        }

        private void controlar()
        {

            while (this.opcao != 12)
            {
                try
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Controlando drone...\n" +
                    "1 - Ajustar altura\n" +
                    "2 - Subir\n" +
                    "3 - Descer\n" +
                    "4 - Ajustar velocidade\n" +
                    "5 - Acelerar\n" +
                    "6 - Desacelerar\n" +
                    "7 - Ajustar Direção\n" +
                    "8 - Virar à esquerda\n" +
                    "9 - Virar à direita\n" +
                    "10 - Aproximar de Objeto mais próximo\n" +
                    "11 - Desaproximar de Objeto mais próximo\n" +
                    "12 - Retornar");
                    Console.Write("Selecione um dos números: ");
                    this.opcao = int.Parse(Console.ReadLine());

                    switch (this.opcao)
                    {
                        case 1:
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Digite até que altura o drone deve ir. (Min.: 0.5m; Max.: 25m)");
                            drone.ajustarAltura(float.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.WriteLine("=========================================================================================================");
                            drone.subir();
                            break;
                        case 3:
                            Console.WriteLine("=========================================================================================================");
                            drone.descer();
                            break;
                        case 4:
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Digite até que velocidade o drone deve ir. (Min.: 0m/s; Max.: 15m/s)");
                            drone.ajustarVelocidade(float.Parse(Console.ReadLine()));
                            break;
                        case 5:
                            Console.WriteLine("=========================================================================================================");
                            drone.acelerar();
                            break;
                        case 6:
                            Console.WriteLine("=========================================================================================================");
                            drone.desacelerar();
                            break;
                        case 7:
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Digite até que grau o drone deve rodar");
                            drone.ajustarDirecao(int.Parse(Console.ReadLine()));
                            break;
                        case 8:
                            Console.WriteLine("=========================================================================================================");
                            drone.virarEsq();
                            break;
                        case 9:
                            Console.WriteLine("=========================================================================================================");
                            drone.virarDir();
                            break;
                        case 10:
                            Console.WriteLine("=========================================================================================================");
                            drone.aproximarObjeto();
                            break;
                        case 11:
                            Console.WriteLine("=========================================================================================================");
                            drone.desaproximarObjeto();
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Por favor, digite um número válido. Error:" + e.Message);
                }
            }
        }

        private void controlarCamera()
        {

            while (this.opcao != 9)
            {
                try
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Controlando câmera do drone...\n" +
                    "1 - Ajustar ângulo da câmera verticalmente\n" +
                    "2 - Subir ângulo da câmera\n" +
                    "3 - Descer ângulo da câmera\n" +
                    "4 - Ajustar ângulo da câmera hotizontalmente\n" +
                    "5 - Virar câmera para a esquerda\n" +
                    "6 - Virar câmera para a direita\n" +
                    "7 - Captura de Foto\n" +
                    "8 - Captura de Tela\n" +
                    "9 - retornar");
                    Console.Write("Selecione um dos números: ");
                    this.opcao = int.Parse(Console.ReadLine());

                    switch (this.opcao)
                    {
                        case 1:
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Digite novo eixo y da câmera");
                            drone.alterarCameraY(int.Parse(Console.ReadLine()));
                            break;
                        case 2:
                            Console.WriteLine("=========================================================================================================");
                            drone.subirCamera();
                            break;
                        case 3:
                            Console.WriteLine("=========================================================================================================");
                            drone.descerCamera();
                            break;
                        case 4:
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Digite novo eixo x da câmera");
                            drone.alterarCameraX(int.Parse(Console.ReadLine()));
                            break;
                        case 5:
                            Console.WriteLine("=========================================================================================================");
                            drone.virarEsqCamera();
                            break;
                        case 6:
                            Console.WriteLine("=========================================================================================================");
                            drone.virarDirCamera();
                            break;
                        case 7:
                            Console.WriteLine("=========================================================================================================");
                            drone.capturarFoto();
                            break;
                        case 8:
                            Console.WriteLine("=========================================================================================================");
                            drone.capturarVideo();
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Por favor, digite um número válido Error:" + e.Message);
                }
            }
        }

        private void controlarBracos()
        {
            while (this.opcao != 4)
            {
                try
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Qual dos braços você deseja controlar?\n" +
                        "1 - Braço Esquerdo\n" +
                        "2 - Braço Direito\n" +
                        "4 - Retornar");
                    Console.Write("Selecione um dos números: ");
                    this.opcao = int.Parse(Console.ReadLine());

                    switch (this.opcao)
                    {
                        case 1:
                            Console.WriteLine("=========================================================================================================");
                            this.controlarBracoEsq();
                            break;
                        case 2:
                            Console.WriteLine("=========================================================================================================");
                            this.controlarBracoDir();
                            break;
                        

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Por favor, digite um número válido Error:" + e.Message);
                }
            }
        }

        private void controlarBracoEsq()
        {
            while (this.opcao != 10)
            {
                try
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Controlando braço esquerdo\n" +
                        "1 - Por ou tirar o braço no modo em repouso\n" +
                        "2 - Por ou tirar o cotovelo no modo em repouso\n" +
                        "3 - Contrair ou estender cotovelo\n" +
                        "4 - Ajustar pulso do drone\n" +
                        "5 - Girar pulso positivamente\n" +
                        "6 - Girar pulso negativamente\n" +
                        "7 - Bater em objeto com martelo pequeno\n" +
                        "8 - Pegar objeto com pinça\n" +
                        "9 - Armazenar objeto\n" +
                        "10 - Retornar");
                    Console.Write("Selecione um dos números: ");
                    this.opcao = int.Parse(Console.ReadLine());

                    switch (this.opcao)
                    {
                        case 1:
                            Console.WriteLine("=========================================================================================================");
                            bracoEsq.ativarOuDesativarBraco();
                            break;
                        case 2:
                            Console.WriteLine("=========================================================================================================");
                            bracoEsq.ativarOuDesativarCotovelo();
                            break;
                        case 3:
                            Console.WriteLine("=========================================================================================================");
                            bracoEsq.contrairOuEstenderCotovelo();
                            break;
                        case 4:
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Digite até que grau o pulso do drone deve girar em graus");
                            bracoEsq.ajustarPulso(int.Parse(Console.ReadLine()));
                            break;
                        case 5:
                            Console.WriteLine("=========================================================================================================");
                            bracoEsq.girarPulsoPosit();
                            break;
                        case 6:
                            Console.WriteLine("=========================================================================================================");
                            bracoEsq.girarPulsoNegiv();
                            break;
                        case 7:
                            Console.WriteLine("=========================================================================================================");
                            bracoEsq.bater();
                            break;
                        case 8:
                            Console.WriteLine("=========================================================================================================");
                            bracoEsq.pegar();
                            break;
                        case 9:
                            Console.WriteLine("=========================================================================================================");
                            bracoEsq.armazenar();
                            break;


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Por favor, digite um número válido Error:" + e.Message);
                }
            }
        }

        private void controlarBracoDir()
        {
            while (this.opcao != 11)
            {
                try
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Controlando braço direito\n" +
                        "1 - Por ou tirar o braço no modo em repouso\n" +
                        "2 - Por ou tirar o cotovelo no modo em repouso\n" +
                        "3 - Contrair ou estender cotovelo\n" +
                        "4 - Ajustar pulso do drone\n" +
                        "5 - Girar pulso positivamente\n" +
                        "6 - Girar pulso negativamente\n" +
                        "7 - Cortar objeto com tesoura\n" +
                        "8 - Coletar com pá objeto não sólido\n" +
                        "9 - Pegar objeto com pinça\n" +
                        "10 - Armazenar objeto\n" +
                        "11 - Retornar");
                    Console.Write("Selecione um dos números: ");
                    this.opcao = int.Parse(Console.ReadLine());

                    switch (this.opcao)
                    {
                        case 1:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.ativarOuDesativarBraco();
                            break;
                        case 2:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.ativarOuDesativarCotovelo();
                            break;
                        case 3:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.contrairOuEstenderCotovelo();
                            break;
                        case 4:
                            Console.WriteLine("=========================================================================================================");
                            Console.WriteLine("Digite até que grau o pulso do drone deve girar em graus");
                            bracoDir.ajustarPulso(int.Parse(Console.ReadLine()));
                            break;
                        case 5:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.girarPulsoPosit();
                            break;
                        case 6:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.girarPulsoNegiv();
                            break;
                        case 7:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.cortar();
                            break;
                        case 8:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.coletar();
                            break;
                        case 9:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.pegar();
                            break;
                        case 10:
                            Console.WriteLine("=========================================================================================================");
                            bracoDir.armazenar();
                            break;


                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("=========================================================================================================");
                    Console.WriteLine("Por favor, digite um número válido Error:" + e.Message);
                }
            }
        }
    }
}
