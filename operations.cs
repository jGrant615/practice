//Perform specified operation

public class Operations{
    public static void Main(){
        System.Console.WriteLine("Enter first Digit:");
        int v1 = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Enter Operation to Perform (+-*/%):");
        char op = char.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Enter Second Digit:");
        int v2 = int.Parse(System.Console.ReadLine());
        int result = 0;
        
        if(op == '+'){
            result = v1+v2;
        }else if(op == '-'){
            result = v1-v2;
        }else if(op == '*'){
            result = v1*v2;
        }else if(op == '/'){
            result = v1/v2;
        } else if(op == '%'){
            result = v1%v2;
        } else{
            System.Console.WriteLine("Invalid Operation!");
        }
        
        System.Console.WriteLine("Result = {0}", result);
        
    }//CLOSE MAIN
}
