# cs4330-FinalProject Documentation

### Comparison of C# and Java.

### Team: 
  - Peter Eckelmann
  
---

# Language purpose/genesis -------------------------
  ### C#
  C# more or less came about as a reaction by Microsoft to Java. Rather than jumping onto the Java bandwagon they enlisted the help of Anders Hejlsberg to architect and develop the language.
    
  ### Java
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/01%20-%20Language%20purpose/Language%20purpose-JavaPlaceHolder.txt)

# Unique features of the language -------------------------
  ### C#
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/02%20-%20Unique%20features/Unique%20features-C%23PlaceHolder.txt)
    
  ### Java
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/02%20-%20Unique%20features/Unique%20features-JavaPlaceHolder.txt)

# Name spaces
#### ([source for explanations and examples below](http://www.javacamp.org/javavscsharp/namespace.html))
  ### C#
  Namespaces are used to organize programs,both as an "internal" organization system for a program, and as an "external" organization system.
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/03%20-%20Name%20spaces/Name%20spaces.cs)
    
  ### Java
  Packages are used to organize files or public types to avoid type conflicts. Package constructs can be mapped to a file system.
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/03%20-%20Name%20spaces/Name%20spaces.java)

# Types
  ### C#
  Reference and value types are supported, as well as creating new value types.
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/04%20-%20Types/Types.cs)
    
  ### Java
  Reference and value types are supposter, but not the creation of new value types.
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/04%20-%20Types/Types.java)

# Classes
  ### C#
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/05%20-%20Classes/Classes.cs)
    
  ### Java
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/05%20-%20Classes/Classes.java)

# Instance reference name in data type (class)
  ### C#
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/06%20-%20Instance%20reference%20name%20in%20data%20type%20(class)/Instance%20Referenec%20Name.cs)
    
  ### Java
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/06%20-%20Instance%20reference%20name%20in%20data%20type%20(class)/Instance%20Reference%20Name.java)

# Properties
  ### C#
  Supports user written getters and setters, as well as it has built in ones. Also supports backing variables, and computed properties.
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/07%20-%20Properties/Properties.cs)
    
  ### Java
  Supports user written getters and setters, but does not have built in getters and setters. As well, it does not have backing variables or computed properties, at least not out of the box.
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/07%20-%20Properties/Properties.java)

# Interfaces / Protocols
  Neither C# or Java support multiple inheritance, but allow for that kind of behavior through interfaces given that a class can implement multiple interfaces, as well as an interface can extend other interfaces.

  ### C#
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/08%20-%20Interfaces/Interfaces.cs)
    
  ### Java
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/08%20-%20Interfaces/Interfaces.java)

# Inheritance / Extension
  As stated above in Interfaces / Protocols, neither C# or Java support multiple inheritance.

  #### C#
  Supports extensions of existing classes/interfaces unlike Java.
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/09%20-%20Inheritence%20-%20extension/Inheritence%20-%20Extension.cs)
   
  ### Java
  Does not support extensions.
   - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/09%20-%20Inheritence%20-%20extension/Inheritence%20-%20Extension.java)

# Reflection
  ### C#
  Supports access to attributes in a program's metadata, examining and instantiating types in an assembly, building new types at runtime, performing lat binding, and accessing methods on types created at run time.
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/10%20-%20Reflection/Reflection.cs)
    
  ### Java
  Some of the abilities of reflection in java are: obtaining information on methods of a class, class constructors, class fields, invoking methods by name, creating new objects, and changing values of fields.
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/10%20-%20Reflection/Reflection.java)

# Memory management
  ### C#
  Uses garbage collection from the .NET Framework. The majority of objects created and used are taken care of by the garbage collector alleviating the need for the user to keep track of memory management. However, there are still what are called 'unamaged resources' (according to the [.Net Documentation](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged)) that the user has to take care of, ie. "objects that wrap operating system resources, such as files, windows, network connections, or database connections." ([.Net Documentation](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged))
  There are two ways provided in the documentation to deal with these unmanaged resources: implementing IDisposable.Dispose and insure that your unmanaged resources are released in the event that dispose is not called, by either using a safe handle to wrap the unmanaged resources, or overriding the Object.Finalize method. The safe handle approach is the recommened technique.
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/11%20-%20Memory%20management/Memory%20management.cs)
    
  ### Java
  Uses garbage collection. Memory is used through a heap split into two parts, the young generation and the old generation. Newly created objects, as well as ones that are not very old, are kept in the young generation, which is also split into three parts: Eden space, and two Survivor Memory spaces. When the Eden space is filled, minor garbage collection (Minor GC) is called. This will move objects from the Eden space, as well as all the objects in a survivor space, to another survivor space so that one of the two survivor spaces is always empty. Eventually, objects that have survived several rounds of Minor GC are eventually moved to the old generation memory space. Primarily when the old generation space is full, major garbage collection (Major GC) is performed to try and reclaim space in the old generation.

# Comparisons of references and values
  ### C#
  The == operator returns true and false for value types if the are the same or different respectively, as well as for the value of strings, but returns true or false if the addresses are the same or not respectively for all reference types other than string.
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/12%20-%20Comparisons%20of%20references%20and%20values/Comparisons%20of%20references%20and%20values.cs)
    
  ### Java
  The == operator compares the values of value types, and returns true or false depending on the result, but for reference types (ie. objects, including strings (unlike C#)) it compares the addresses of the objects. To determine the equality of the value of referenece types, the equals() method must be used.
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/12%20-%20Comparisons%20of%20references%20and%20values/Comparisons%20of%20references%20and%20values.java)

# Null/nil references
  Both C# and Java allow for reference types to be null, as well the user can check if something is null and then handle it manually, throw an exception, or if nothing is done to prevent/handle a null reference, the program itself with throw a null reference exception which will crash the program if it is not explicitly handled in the code.

  ### C#
  Uses 'null.'
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/13%20-%20Null%20references/Null%20references.cs)
    
  ### Java
  Uses 'Null.'
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/13%20-%20Null%20references/Null%20references.java)

# Errors and exception handling
  C# and Java both implement exceptions and exception handling in the form of try, catch, finally blocks, and the ability for users to throw, or rethrow exceptions.

  ### C#
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/14%20-%20Errors%20and%20exception%20handling/Errors%20and%20exception%20handling.cs)
    
  ### Java
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/14%20-%20Errors%20and%20exception%20handling/Errors%20and%20exception%20handling.java)

# Lambda expressions, closures, or functions as types
  ### C#
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/15%20-%20Lambda%20expressions,%20closures,%20or%20functions%20as%20types/Lambda%20expressions,%20closures,%20or%20functions%20as%20types.cs)
    
  ### Java
  As of Java 8, lambdas are supported.
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/15%20-%20Lambda%20expressions,%20closures,%20or%20functions%20as%20types/Lambda%20expressions,%20closures,%20or%20functions%20as%20types.java)

# Implementation of listeners and event handlers -------------------------
  ### C#
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/16%20-%20Implementation%20of%20listeners%20and%20event%20handlers/Implementation%20of%20listeners%20and%20event%20handlers.cs)
    
  ### Java -------------------------
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/16%20-%20Implementation%20of%20listeners%20and%20event%20handlers/Implementation%20of%20listeners%20and%20event%20handlers.java)

# Singleton
  ### C#
  The [documentation for C#](https://msdn.microsoft.com/en-us/library/ff650316.aspx) lists three ways of creating a singleton, two of which are shown in the code example linked below. The first way listed is not included because it has the issue of not being safe for multithreaded environments, as well, "[because] the instance is created inside the Instance property method, the class can exercise additional functionality (for example, instantiating a subclass), even though it may introduce unwelcome dependencies." (from the [C# documentation](https://msdn.microsoft.com/en-us/library/ff650316.aspx))
  
  Two version are given, because while the static initialization approach is the preferred, and generally sufficient one, the "potential downside of this approach is that you have less control over the mechanics of the instantiation." (from the [C# documentation](https://msdn.microsoft.com/en-us/library/ff650316.aspx)) because the .NET Framework performs the initialization and not the user.
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/17%20-%20Singleton/Singleton.cs)
    
  ### Java
  As stated [here](https://sourcemaking.com/design_patterns/singleton/java/1), for the code example linked below, "The technique is known as the initialization on demand holder idiom, is as lazy as possible, and works in all known versions of Java. It takes advantage of language guarantees about class initialization, and will therefore work correctly in all Java-compliant compilers and virtual machines.

The inner class is referenced no earlier (and therefore loaded no earlier by the class loader) than the moment that getInstance() is called. Thus, this solution is thread-safe without requiring special language constructs (i.e. volatile or synchronized)."
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/17%20-%20Singleton/Singleton.java)

# Procedural programming
  C# and Java do not support procedural programming. Everything has to be in a class, including main.

# Functional programming
  ### C#
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/19%20-%20Functional%20programming/Functional%20programming.cs)
    
  ### Java
  As of Java 8, functional programming is now supported.
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/19%20-%20Functional%20programming/Functional%20programming.java)

# Multithreading
  ### C#
  C# accomplishes multitasking through the use of threading and the .NET Framwork [System.Threading](https://docs.microsoft.com/en-us/dotnet/api/system.threading?view=netframework-4.7.2) namespace. "By default, a C# program has one thread. However, auxiliary threads can be created and used to execute code in parallel with the primary thread. These threads are often called worker threads." ([C# documentation](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/threading/))
  - [C# example](https://github.com/pje279/cs4330-FinalProject/blob/master/20%20-%20Multithreading/Multithreading.cs)
  
  ### Java
  Java also accomplishes multitasking through the use of threading. There are however, two ways of using threads in Java: implementing the Runnable interface, or extending the Thread class.
  - [Java example](https://github.com/pje279/cs4330-FinalProject/blob/master/20%20-%20Multithreading/Multithreading.java)
