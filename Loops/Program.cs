// Programa simples para calcular a quantidade de alunos em um ônibus
bool isInputValid;
int studentsNumber;

// Evita input de caracteres não-numéricos
do
{
    Console.Write("Quantos alunos precisam entrar no ônibus?\n> ");
    isInputValid = Int32.TryParse(Console.ReadLine(), out studentsNumber);
} while (!isInputValid);

Console.Clear();
Console.WriteLine("Alunos no ônibus: 0 | Alunos faltando: " + studentsNumber);

// Faz o programa rodar até todos os alunos estarem dentro do ônibus
int studentsInBus = 0;
while (studentsInBus < studentsNumber)
{
    Console.Write("Pressione 'enter' para confirmar novo aluno. ");
    Console.ReadKey(true);
    Console.Clear();

    studentsInBus++;
    int studentsMissing = studentsNumber - studentsInBus;

    Console.WriteLine($"Alunos no ônibus: {studentsInBus} | Alunos faltando: {studentsMissing}");
}

Console.Write("Todos os alunos estão dentro do ônibus. Pressione 'enter' para terminar o programa. ");
Console.Read();