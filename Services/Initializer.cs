using team3.Data;

namespace team3.Services;

/// <summary>
/// Class to put placeholder tasks in the database for testing purposes.
/// </summary>
public class Initializer
{
    private readonly ApplicationDbContext _db;

    public Initializer(ApplicationDbContext db)
    {
        _db = db;
    }
    
    public void SeedDatabase()
    {
        _db.Database.EnsureCreated();

        // If there are any students then assume the database is already
        // seeded.
        if (_db.TaskList.Any()) return;
        
        var tasks = new List<Tasks>
        {
           new Tasks
            { Id = 1, Location = "Flagpoles next to memorial hall",
               Question = "When was the leadership and excellence memorial for our fallen soldier students dedicated?",
               Answer = "11/11/03" },
           new Tasks
            { Id = 2, Location = "Sam Wilson Hall",
               Question = "Who is listed on the bench outside the front of Sam Wilson Hall?",
               Answer = "Douglas Dotterweich" },
           new Tasks
            { Id = 3, Location = "ETSU Book Store (Culp Center)",
               Question = "How many visible pillars are in the ETSU Book Store?",
               Answer = "3" },
           new Tasks
            { Id = 4, Location = "Special Services Lab (Sherrod Library)",
               Question = "What room number is the Special Services Lab in Sherrod Library?",
               Answer = "318" },
           new Tasks
            { Id = 5, Location = "Sherrod Library",
               Question = "How many printers are available to students on the first floor of the Sherrod Library?",
               Answer = "5" },
           new Tasks
            { Id = 6, Location = "Brown Hall",
               Question = "Who is the third author of the paper posted on the wall on the fourth floor of Brown Hall called 'Purification and Characterization of Bioactive Metabolites?'",
               Answer = "Sean Fox" },
           new Tasks
            { Id = 7, Location = "Tri-Hall Field",
               Question = "How many swings are located within Tri-Hall field?",
               Answer = "4" },
           new Tasks
            { Id = 8, Location = "Counseling Center (Culp Center)",
               Question = "What room number is the counseling center in the Culp Center?",
               Answer = "326" },
           new Tasks
            { Id = 9, Location = "Culp Center",
               Question = "How many restaurants are in the Culp Center?",
               Answer = "5" },
           new Tasks
            { Id = 10, Location = "Health Clinic (Roy S. Nicks Hall)",
               Question = "What floor is the health clinic located in Roy S. Nicks Halls?",
               Answer = "1" }
        };

        _db.TaskList.AddRange(tasks);
        _db.SaveChanges();
    }
}
