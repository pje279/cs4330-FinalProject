// Using GetType to obtain type information:  
int i = 42;  
System.Type type = i.GetType();  
System.Console.WriteLine(type); 

//Output:
//System.Int32

// Using Reflection to get information from an Assembly:  
System.Reflection.Assembly info = typeof(System.Int32).Assembly;  
System.Console.WriteLine(info); 

//Output:
//mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
