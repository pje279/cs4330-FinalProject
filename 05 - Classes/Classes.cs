public class Person
{
    // Field
    private string name;

    // Constructor that takes no arguments.
    public Person()
    {
        name = "unknown";
    }

    // Constructor that takes one argument.
    public Person(string nm)
    {
        name = nm;
    }

    // Method
    public void SetName(string newName)
    {
        name = newName;
    }
}
