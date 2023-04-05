
namespace Atividade1
{
    public class Aluno
    {
        public string nome {get; set; }
        public string RA {get; set; }
        public float nota_prova {get; set; }
        public float nota_trabalho {get; set; }
        public float nota_final {get; set; }

        public Aluno()
        {
            nome = "";
            RA = "";
            nota_prova = 0;
            nota_trabalho = 0;
            nota_final = 0;
        }

        public Aluno(string nome, string RA)
        {
            this.nome = nome;
            this.RA = RA;
            nota_prova = 0;
            nota_trabalho = 0;
            nota_final = 0;
        }

        public Aluno(string nome, string RA, float nota_prova, float nota_trabalho)
        {
            this.nome = nome;
            this.RA = RA;
            this.nota_prova = nota_prova;
            this.nota_trabalho = nota_trabalho;
            nota_final = nota_prova + nota_trabalho;
        }

        public void Print()
        {
            Console.WriteLine(
                $"Nome: {nome}" +
                $"\nRA: {RA}" +
                $"\nNota da prova: {nota_prova}" +
                $"\nNota do Trabalho: {nota_trabalho}" +
                $"\nNota final: {nota_final}"
            );
        }
    }
}
