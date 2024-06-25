namespace ConsoleApp9.Model;

public class Car
{
    public string Model { get; set; }
    public string Marka { get; set; }
    public int Year { get; set; }

    public override string ToString()
    => $"{Marka}-{Model}-{Year}";
}
