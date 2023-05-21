using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree.Logic.Models.Genres
{
    public class GenreDTO
    {
        /// <summary>
        /// Идентификатор жанра
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название жанра
        /// </summary>
        public string? Title { get; set; }
    }
}
