void HandleCustomEvent(object sender, CustomEventArgs a)  
{  
   // Do something useful here.  
} 

//C# 2.0 syntax
publisher.RaiseCustomEvent += HandleCustomEvent; 

//C# 1.0 syntax - is equivalent to 2.0 syntax
publisher.RaiseCustomEvent += new CustomEventHandler(HandleCustomEvent);

/**********Using a lambda**********/
public Form1()  
{  
    InitializeComponent();  
    // Use a lambda expression to define an event handler.  
    this.Click += (s,e) => { MessageBox.Show(  
       ((MouseEventArgs)e).Location.ToString());};  
}

/**********Using an anonymous method**********/
publisher.RaiseCustomEvent += delegate(object o, CustomEventArgs e)  
{  
  string s = o.ToString() + " " + e.ToString();  
  Console.WriteLine(s);  
}; 
