using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
        //public virtual ICollection<Recipe> RecipesEditedByTheUser { get; set; }
        //public virtual ICollection<Comment> CommentsEditedByTheUser { get; set; }

    }
}
