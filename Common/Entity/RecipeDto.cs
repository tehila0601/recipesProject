using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entity
{
    public enum eDifficulty { hard, medium, easy }

    public class RecipeDto
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int DurationOfPreparation { get; set; }
        public eDifficulty LevelOfDifficulty { get; set; }

        //public int LevelOfDifficulty { get; set; }
        public int NumOfPieces { get; set; }
        public int CategoryId { get; set; }
        public int EditorId { get; set; }
        public DateTime UploadTime { get; set; }
    }
}
