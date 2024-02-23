using MVC_flori;

internal class Program
{
    public static void Main(string[] args)
    {
        FloriService service = new FloriService();

        service.LoadData();

        service.AfisareFlori();
    }
}