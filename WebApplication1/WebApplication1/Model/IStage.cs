namespace EasyTaskTracker.Model
{

    public enum StageEnum
    {
        ToDo,
        InProgress,
        Done
    }

    public interface IStage
    {  
        StageEnum Name { get; set; }


    }
}