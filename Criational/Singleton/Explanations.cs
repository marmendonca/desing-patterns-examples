namespace DesingPatternsExamples.Criational.Singleton;

public class Explanations
{
    // Definição
    // O Singleton é um padrão de projeto criacional que permite a você garantir que uma classe tenha apenas uma instância,
    // enquanto provê um ponto de acesso global para essa instância.
    
    // Prós
    // 1 - Você pode ter certeza que uma classe só terá uma única instância.
    // 2 - Você ganha um ponto de acesso global para aquela instância.
    // 3 - O objeto singleton é inicializado somente quando for pedido pela primeira vez.
    
    // Contras
    // 1 - Viola o princípio de responsabilidade única. O padrão resolve dois problemas de uma só vez.
    // 2 - O padrão Singleton pode mascarar um design ruim, por exemplo, quando os componentes do programa sabem muito sobre cada um.
    // 3 - O padrão requer tratamento especial em um ambiente multithreaded para que múltiplas threads não 
    //      possam criar um objeto singleton várias vezes.
    //      Pode ser difícil realizar testes unitários do código cliente do Singleton porque muitos frameworks de teste dependem de herança quando produzem objetos simulados.
    //      Já que o construtor da classe singleton é privado e sobrescrever métodos estáticos é impossível na maioria das linguagem, você terá que
    //      pensar em uma maneira criativa de simular o singleton. Ou apenas não escreva os testes. Ou não use o padrão Singleton.
        
}