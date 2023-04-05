using Atividade1;
using MyLib.JSONFile;
public static class Program
{
    //Testing
    public static void Main()
    {
        Aluno saved_aluno = new Aluno("Daniel", "696969", 9, 2);

        JSON.Save(saved_aluno, ".\\Saves", "aluno");

        Aluno loaded_aluno = JSON.Load<Aluno>(".\\Saves\\aluno.json");

        loaded_aluno.Print();
        Console.ReadKey();
    }
}
