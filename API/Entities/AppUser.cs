namespace API.Entities;

public class AppUser
{
    //Id will by convention be used as the primary key for the database by entety framwork 
    //if it shold be called anything else it needs to have [key] above, if it is a int it will be aouto incemented.
    public int Id { get; set; } 

    public required string UserName { get; set; }
}
