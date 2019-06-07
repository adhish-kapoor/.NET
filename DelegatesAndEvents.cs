//Delegates in C# allows user to change dynamically the reference to the method in a class. 
//A delegate is an object that can refer to a method in a class. 

//A delegate is a reference type variable, which holds the reference to a method. 
//The reference can be changed at the run time by the user. Delegates are used to pass methods as arguments to other methods

// Instantiating and using Delegates

The signature of the delegate is as shown below:

   delegate result – type identifier ( [ parameters] );

Where,

· result type: The result type that matches the return type of the function

· identifier: The delegate name

· parameters: The Parameters that the function takes from the user

public void DelegateFunction ( string Passvalue) 
{
    //Method to implement
}
//Delegate declaration
public delegate void MyDelegate(string ArgValue)
public void UseMethod()
{
    //Delegate Instantiation
    MyDelegate DelegateObject = new MyDelegate(DelegateFunction);
}

The delegate holds the address of the DelegateFunction() method. The DelegateObject is of type MyDelegate.
The address of the method is assigned to the object by passing the function name to the delegate constructor.

//Example of mathematical operations
class MathOperation
{
    public static double MultiplyByTwo(double value)
    {
        return value * 2;
    }
    public static double Square( double value )
    {
        return value * value;
    }
}
delegate double DoubleOp(double x);
class Program
{
    static void Main( string[ ] args )
    {
        Doubleop[ ] operations = 
        {
            MathOperation.MutilplyByTwo, MathOperation.Square
        };
        for ( int i =0; i<operations.Length; i++)
        {
            Console.WriteLine(“Using Operations [ {0} ] :”, i );
            display(operations[1], 2.0 );
            display(operations[i], 7.3);
            Console.Read();
        }
    }
    static void display(DoubleOp action, double value)
    {
        double result = action (value);
        Console.WriteLine("Value is {0}, result of operation is {1}", value, result);
        Console.Read();
    }
}

// Types of Delegates

Single – cast Delegate
A single cast delegate can call only one method at a time. 
It is derived from System.Delegate class. It contains reference of a single method at one time.

In the above example, the single cast delegate is used. 
The methods MultiplyByTwo and Square are referred by the delegate, DoubleOp, one at a time.

Multicast Delegate
A multicast delegate can call multiple methods at the same time. They are derived from the System.MulticastDelegate class. 
It contains an invocation list of multiple methods.
Multicast delegates hold the reference of more than one method.

public delegate void ShowDelegate();
class Program
{
    public static void display1()
    {
        Console.WriteLine("The first display method is invoked");
    }
    public static void display2()
    {
        Console.WriteLine("The second display method is invoked");
    }
     
    static void Main ( string[ ] args )
    {
        ShowDelegate s = new ShowDelegate(display1);
        ShowDleegate s1= new ShowDelegate(display2);
        s = s1+s2;
        s1();                                        //output "The second display method is invoked"
        Console.Read();
    }
}
=================
// Using delegates with events
An event in C# is a way for a class to provide the notifications to clients of that class about the performed action.
  The events are declared and raised inside a class. 
  They are associated with the event handlers using delegates within the same class or different classes.
  They are a part of the class and the same class is used to publish events.
  Events use the publisher and subscriber model. 
   
// Properties 
  Properties are used to provide accessibility of classes variables in an application or outside an application.
  A property is a combination of variable and a method.   
     
     class Program
{
    private int srno = 1;
    private string name = “John”;
    private string subject = “Maths”;
    public int Srno
    {
        get
        {
            return srno;
        }
        set
        {
            srno = value;
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
         {
            name = value;
        }
}
public string Subject
{
    get
    {
        return subject;
    }
    set
    {
        subject = value;
    }
}
public override string ToString()
{
    return “Srno=”+Srno+”,Name=”+Name+”,Subject=”+Subject;
}
class Demo
{
    static void Main ( string[ ] args )
    {
        Program p =new Program();
        p.Srno = 1;
        p.Name = “Mark”;
        p.Subject = “Science”;
        Console.WriteLine(“Student Info:{0}”, p); //Srno=1,Name=Mark,Subject=Science
        Console.Read();
    }
}
}
     
// Create Read – Only Property
Properties in C# can be made read only. The get accessor in the property is used for the implementation of the code. 
User can only access the variables but it cannot assign values to it.
   
   class Camp
{
    int students = -1;
    string location = string.Empty;
    public Camp(int st1, string loc1)
    {
        students =st1;
        location = loc1;
    }
    public int st1
    {
        get
        {
            return students;
        }
    }
    public string loc1
    {
        get
        {
            return location;
        }
    }
    class Demo
    {
        static void Main ( string [ ] args )
        {
            Camp c = new Camp(100,"ASR");
            Console.WriteLine(“Students : {0}, Location {1}”, c.st1, c.loc1);  // Students:100, Location:ASR
            Console.Read();
        }
    }
}
