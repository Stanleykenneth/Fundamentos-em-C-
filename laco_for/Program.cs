
using System;

string opcao;

while(true){

    Console.Clear();
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de Cliente");
            break;

        case "2":
            Console.WriteLine("Buscade Cliente");  
            break;

        case "3":
            Console.WriteLine("Apagar Cliente");
            break;

        case "4": 
            Console.WriteLine("Encerrar");  
            Environment.Exit(0);
            break;        
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}


// for(int i = 10; i >= 1; i--){

//     Console.WriteLine();
//     for(int j = 1; j <=10; j++){

//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
// }