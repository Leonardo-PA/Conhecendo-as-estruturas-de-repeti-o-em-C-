using ConhecendoEstruturasdeRepitiçãoemC_.Models;


//Utilizando o FOR

int numero = 5;

Console.WriteLine($"{numero} x 1 = {numero * 1}");
 for(int contador1 = 0; contador1 <= 10; contador1++)//condição que mantem nosso loop em está de funcionamento, até obter o valor verdadeiro.
 {
     Console.WriteLine($"{numero} x {contador1} = {numero * contador1}");
 }


//Utilizando o WHILE

 int numero1 = 5;
 int contador = 1;

 while(contador <= 10 )//o While verifica se a condição é verdadeira
  {
      Console.WriteLine($"{contador}° Execusão: {numero1} x {contador} = {numero1 * contador}");
      contador ++;

      if (contador == 6)// exemplo de uso de condição do break
      {
         break;
      }
  }


// Utilizando o DO WHILE

 int soma = 0, numero2 = 0;//pode declarar varias variaveis do mesmo tipo em uma unica linha, sempre do mesmo tipo.

 do
 {
     Console.WriteLine("Digite um numero: (Digite 0 para parar)");
     numero2 = Convert.ToInt32(Console.ReadLine ());

    soma += numero2;//pretendemos manter o valor da variavel soma e somar mais um numero que for digitado.

 } while(numero2 != 0);

 Console.WriteLine($"Total da soma dos numeros digitado é: {soma}");



// construindo um menu interativo: 

string opcao;
bool exibirMenu = true;

while(exibirMenu)//para segunda opção a baixo inserir um TRUE no WHILE
{
    Console.Clear();//usando clear ele limpa o nosso menu, só que funciona de uma maneira muito rapida. 
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar cliente");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break; 

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false; //para encerrar o exibir menu. 
            //Environment.Exit(0);//função para quebrar o loop.
            break;

        default: 
        Console.WriteLine("Opção invalida");
        break;
    }
}

Console.WriteLine("O programa se encerrou ");