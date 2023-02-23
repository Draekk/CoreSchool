// See https://aka.ms/new-console-template for more information
CoreSchool school = new CoreSchool("Platzi Academy", "Web", 2012, "Freddy Vega");
Console.WriteLine("Timbre");
school.timbrar();

class CoreSchool
{
    string name;
    string address;
    int fYear;
    string ceo;

    public CoreSchool(string name, string address, int fYear, string ceo)
    {
        this.name = name;
        this.address = address;
        this.fYear = fYear;
        this.ceo = ceo;
    }

    public void timbrar(){
        //Todo
        Console.Beep(10000, 3000);
    }
}