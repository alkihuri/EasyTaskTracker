using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

public class TrackerTask
{  
    public long ID { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool IsComplete { get; set; } 
    public DateTime? DueDate { get; set; } 
      
    public User? AssignedUser { get; set; }  
  
}
 