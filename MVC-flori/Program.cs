using MVC_flori;

internal class Program
{
    public static void Main(string[] args)
    {
        FloriService service = new FloriService();

        View view = new View();
        service.LoadData();


        view.play();
    }
}