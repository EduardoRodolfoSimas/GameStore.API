using System.ComponentModel.DataAnnotations.Schema;

namespace GameStore.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public DateOnly ReleaseDate { get; set; }

    }
}
