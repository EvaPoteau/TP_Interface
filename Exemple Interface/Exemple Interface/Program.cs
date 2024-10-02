using System;
namespace ExempleInterface
{
    interface IExemple
    {
        string nom { get; set; }
        string NomMajuscule();
    }
    public class Exemple : IExemple
    {
        public string nom { get; set; }
        public Exemple(string nom)
        {
            this.nom = nom;
        }
        public string NomMajuscule()
        {
            return this.nom.ToUpper();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            IExemple exemple = new Exemple("toto");

        }
    }
}
