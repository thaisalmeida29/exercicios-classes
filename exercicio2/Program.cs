/*Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

Regras que deverão ser seguidas para a implementação do programa:

Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
*/

using exercicio2;
string nome, tipo;
int qntdCachorro = 0, qntdGato = 0, qntdPeixe = 0;


List<Animal> listaAnimais = new List<Animal>();

while (true)
{


    for (int i = 0; i <= 5; i++)
    {
        Console.Clear();
        Console.WriteLine("Tipo do animal valido (Cachorro,Gato ou Peixe)");
        Console.Write("Digite o nome do seu animal: ");
        nome = Console.ReadLine();
        Console.Write("Qual o tipo do seu animal? ");
        tipo = Console.ReadLine();
        listaAnimais.Add(new Animal(nome, tipo));

        if (tipo == "Cachorro")
        {
            qntdCachorro++;
        }
        else if (tipo == "Gato")
        {
            qntdGato++;
        }
        else if (tipo == "Cachorro")
        {
            qntdPeixe++;
        }
    }
}

Console.WriteLine($"A quantidade de Cachorros é: {qntdCachorro}");
Console.WriteLine($"A quantidade de Gatos é: {qntdGato}");
Console.WriteLine($"A quantidade de Peixes é: {qntdPeixe}");

