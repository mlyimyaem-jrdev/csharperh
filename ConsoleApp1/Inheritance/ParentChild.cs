namespace ConsoleApp1.Inheritance;

public class ParentChild
{
    static void Main(string[] args)
    {
        string lastname = "Sy";
        string midname = "Ang";
        Child eldest = new Child(lastname,"Elsa",midname);
        Child midChild = new Child(lastname,"Mona",midname);
        Child youngestChild = new Child(lastname,"Bert",midname);
        // eldest.Name = "Elsa";
        // midChild.Name = "Mona";
        // youngestChild.Name = "Bert";
        System.Console.WriteLine(eldest.Name);
        System.Console.WriteLine(midChild.Name);
        System.Console.WriteLine(youngestChild.Name);
        midChild.changeLastname("Ayala");
        System.Console.WriteLine(eldest.Name);
        System.Console.WriteLine(midChild.Name);
        System.Console.WriteLine(youngestChild.Name);

    }
}
class GrandParent
{
    public GrandParent(string midname)
    {
        Midname = midname;
    }
    public string Midname
    {get;set;}
}

class Parent: GrandParent
{
    public Parent(string lastname,string midname): base(midname)
    {
        Lastname = lastname;
    }
    public string Lastname
    {get;set;}


}

class Child : Parent
{
    private string _name;

    public Child(string lastname,string firstname,string midname) : base(lastname,midname)
    {
        Name = firstname;
    }

    public string Name
    {
        get{ return $"{_name} {base.Midname}, {base.Lastname}";}
        set{ this._name = value;}
        
    }
    public void changeLastname(string newLastname)
    {
        Midname = base.Lastname;
        base.Lastname = newLastname;
    }
}