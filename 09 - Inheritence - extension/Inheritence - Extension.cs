/****************Inheritence****************/
//Base class or Parent class.  
class Shape  
{  
    public double Width;  
    public double Height;  
    public void ShowDim()  
    {  
        Console.WriteLine("Width and height are " +  
        Width + " and " + Height);  
    }  
}  
// Triangle is derived from Shape.  
//Derived class or Child class.  
class Triangle : Shape  
{  
    public string Style; // style of triangle  
    // Return area of triangle.  
    public double Area()  
    {  
        return Width * Height / 2;  
    }  
    // Display a triangle's style.  
    public void ShowStyle()  
    {  
        Console.WriteLine("Triangle is " + Style);  
    }  
} 

/****************Extension/****************/
//This example adds an extension to string
public static class ExtensionMethods
{
    public static string UppercaseFirstLetter(this string value)
    {
        // Uppercase the first letter in the string.
        if (value.Length > 0)
        {
            char[] array = value.ToCharArray();
            array[0] = char.ToUpper(array[0]);
            return new string(array);
        }
        return value;
    }
}
