//Properties with backing fields/ computed properties
class TimePeriod
{
   private double seconds;

   public double Hours
   {
       get { return seconds / 3600; }
       set { 
          if (value < 0 || value > 24)
             throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} must be between 0 and 24.");

          seconds = value * 3600; 
       }
   }
}

//Expression body definitions
public class SaleItem
{
   string name;
   decimal cost;
   
   public SaleItem(string name, decimal cost)
   {
      this.name = name;
      this.cost = cost;
   }

   public string Name 
   {
      get => name;
      set => name = value;
   }

   public decimal Price
   {
      get => cost;
      set => cost = value; 
   }
}

//Auto-implemented properties
public class SaleItem
{
   public string Name 
   { get; set; }

   public decimal Price
   { get; set; }
}
