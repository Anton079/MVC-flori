using MVC_flori;

internal class Program
{
    public static void Main(string[] args)
    {
        FloriService service = new FloriService();

        service.LoadData();
        View view = new View();

        Flori buchetNou = new Flori();
        buchetNou.pret = 150;
        buchetNou.fire = 40;
        buchetNou.flori = "Orhidee";


        service.AfisareFlori();
    }
}