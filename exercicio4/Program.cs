/*
 * Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções.
 * Dessa forma, crie um programa em C# que represente uma lista de asteroides que deveriam ser 'inseridos' no jogo.
 * Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
 * um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5). 
 * Para esses atributos privados, gerar os métodos de acesso(propriedades getter e setter). 
 * Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros
 * de um objeto tipo Asteroide, e um terceiro que constrói um asteroide com posição x e posição y. 
 * O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. 
 * Nesse programa principal, construir um método de classe que exiba todos os asteróides da lista.
 */

using exercicio4;
/// <summary>
/// cria uma lista de asteroides
/// </summary>

List<Asteroides> listaAsteroides = new List<Asteroides>();

/// <summary>
/// define as variaveis
/// </summary>

int posicaox;
int posicaoy;
int tamanhoAsteroide;
int velocidadeAsteroide;
int energiaAsteroide;

for (int i = 0; i < 10; i++)
{

    Console.Clear();
    Console.Write("Digite a posição X: ");
    posicaox = int.Parse(Console.ReadLine());

    Console.Write("Digite a posição y: ");
    posicaoy = int.Parse(Console.ReadLine());

    Console.Write("Digite o tamanho do Asteroide de 1 a 10: ");
    tamanhoAsteroide = int.Parse(Console.ReadLine());

    Console.Write("Digite a velocidade do Asteroide de 1 a 5: ");
    velocidadeAsteroide = int.Parse(Console.ReadLine());

    Console.Write("Digite a energia do Asteroide de 1 a 5: ");
    energiaAsteroide = int.Parse(Console.ReadLine());

    listaAsteroides.Add(new Asteroides(posicaox, posicaoy, tamanhoAsteroide, velocidadeAsteroide, energiaAsteroide));


}



Asteroides.mostrarLista(listaAsteroides);


