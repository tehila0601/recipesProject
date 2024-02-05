using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public enum eDifficulty { hard, medium, easy }

    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public int DurationOfPreparation { get; set; }
        public eDifficulty LevelOfDifficulty { get; set; }

        //public int LevelOfDifficulty { get; set; }
        public int NumOfPieces { get; set; }
        public DateTime UploadTime { get; set; }

        [ForeignKey("CtegoryId")]
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("EditorId")]
        public virtual User Editor { get; set; }

        public int EditorId { get; set; }



        public virtual ICollection<Ingredient> Ingredients { get; set; }


        //public virtual ICollection<Comment> Comments { get; set; }

    }
}
