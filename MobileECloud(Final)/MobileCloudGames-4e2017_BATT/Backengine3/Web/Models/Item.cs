namespace Web.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string NomePersonagem { get; set; }

        public string Detalhes { get; set; }

        public int Vida { get; set; }

        public int Dano { get; set; }

        public bool Hostil { get; set; }

        // Relacionamento item -- TipoItem
        public int TipoItemID { get; set; }

        public virtual TipoItem _TipoItem { get; set; }

    }
}