using Atividade1;
using MyLib.JSONFile;
public static class Program
{
    //Testing
    public static void Main()
    {
        List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno("Daniel", "450678"),
            new Aluno("Náthan", "456845"),
            new Aluno("Ryan", "978789"),
        };

        JSON.Save(alunos, ".\\Saves", "aluno");

        List<Aluno> loaded_alunos = JSON.Load<List<Aluno>>(".\\Saves\\aluno.json");

        foreach(Aluno a in loaded_alunos)
            a.Print();

        Console.WriteLine(JSON.ConvertoToJson(loaded_alunos));
        Console.ReadKey();
    }
}
