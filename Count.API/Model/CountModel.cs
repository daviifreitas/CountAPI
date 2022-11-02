using System.ComponentModel.DataAnnotations.Schema;

namespace Count.API.Model
{
    [Table("us_moment_present")]
    public class CountModel
    {
        public int Id { get; set; }
        public DateTime Created_at { get; set; }
    }
}
