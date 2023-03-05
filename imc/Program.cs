internal class Program
{
    static float CalculaIMC(float peso, float altura)
    {
        return peso / (altura * altura);
    }

    static void ClassificaRisco(string sexo, float imc)
    {
        if(sexo.ToLower() == "m")
        {
            if(imc < 20.7)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if ((imc >= 20.7) && (imc <= 26.4))
            {
                Console.WriteLine("Peso ideal");
            }
            else if ((imc >= 26.5) && (imc <= 27.8))
            {
                Console.WriteLine("Pouco acima do peso");
            }
            else if ((imc >= 27.9) && (imc <= 21.1))
            {
                Console.WriteLine("Acima do peso");
            }
            else if ((imc >= 31.2))
            {
                Console.WriteLine("Obesidade");
            }
        }
        else if (sexo.ToLower() == "f")
        {
            if (imc < 19.1)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if ((imc >= 19.1) && (imc <= 25.8))
            {
                Console.WriteLine("Peso ideal");
            }
            else if ((imc >= 25.9) && (imc <= 27.3))
            {
                Console.WriteLine("Pouco acima do peso");
            }
            else if ((imc >= 27.4) && (imc <= 32.3))
            {
                Console.WriteLine("Acima do peso");
            }
            else if ((imc >= 32.4))
            {
                Console.WriteLine("Obesidade");
            }
        }
        else
        {
            Console.WriteLine("Informe apenas M ou F");
        }
    }

    private static void Main(string[] args)
    {
        float altura, peso, imc;
        string sexo;

        Console.WriteLine("Informe sua altura: ");
        altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe seu peso: ");
        peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe seu sexo: ");
        sexo = Console.ReadLine();

        imc = CalculaIMC(peso, altura);

        ClassificaRisco(sexo, imc);
    }
}