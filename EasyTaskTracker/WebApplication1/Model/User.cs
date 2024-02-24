using EasyTaskTracker.Model;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
    public List<TrackerTask> Tasks { get; internal set; }
}
