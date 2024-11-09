using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class Deck
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Card> Cards { get; set; }
        public DeckType Type { get; set; }
    }
}
