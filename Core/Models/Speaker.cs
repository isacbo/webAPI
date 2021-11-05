using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class Speaker
    {
        //https://github.com/ChilliCream/graphql-workshop/blob/master/docs/1-creating-a-graphql-server-project.md
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Bio { get; set; }

        [StringLength(1000)]
        public virtual string WebSite { get; set; }
    }
}
