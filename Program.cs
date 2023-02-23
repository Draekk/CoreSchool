// See https://aka.ms/new-console-template for more information
CoreSchool school = new CoreSchool();
school.name = "Platzi Academy";
school.address = "En internet";
school.fYear = 2012;
Console.WriteLine("Timbre");
school.timbrar();

class CoreSchool
{
    public string name {get; set;}
    public string address {get; set;}
    public int fYear {get; set;}
    public string ceo {get; set;}

    public void timbrar(){
        //Todo
        Console.Beep(10000, 3000);
    }
}