namespace UrbanPancake.Library
{
    public interface IMenuItem
    {
        string Choice { get; set; }
        int ExecuteChoice();
    }
}
