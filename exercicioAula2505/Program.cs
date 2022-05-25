
using exercicioAula2505;

string t, a;
int pag, ano, ed;

Console.Write("Digite o titulo do livro: ");
t = Console.ReadLine();
Console.Write("Digite o autor do livro: ");
a = Console.ReadLine();
Console.Write("Digite a quantidade de paginas: ");
pag = int.Parse(Console.ReadLine());
Console.Write("Digite o ano: ");
ano = int.Parse(Console.ReadLine());
Console.Write("Digite a edição: ");
ed = int.Parse(Console.ReadLine());
Livro l = new Livro(t,a,pag,ano,ed);
l.apresentarInfoLivro();


