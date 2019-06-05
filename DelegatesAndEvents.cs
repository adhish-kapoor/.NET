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
