namespace SistemaBiblioteca.Entities
{
    public class Categorie
    {
        public string Id_Categorie { get; set; }
        public string Name { get; set; }

        private static int counterCategorie = 1;

        public Categorie(string name)
        {
            Id_Categorie = GetId_Categorie();
            Name = name;
        }

        private string GetId_Categorie()
        {
            string id = $"C{counterCategorie.ToString("D3")}";
            IncrementCounter();
            return id;
        }

        private static void IncrementCounter()
        {
            counterCategorie++;
        }

        public static void InitializeCounter(int maxId)
        {
            counterCategorie = maxId + 1;
        }
    }
}
