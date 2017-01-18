//Login system that allows 3 attempts

public class Exercise3{
    public static void Main(){
        string user = "admin";
        string pass = "password";
        int atmpt = 1;
        bool result = false;
        
        System.Console.WriteLine("Enter Username:");
        string userGuess = System.Console.ReadLine();
        System.Console.WriteLine("Enter Password:");
        string passGuess = System.Console.ReadLine();
        
        if( (user != userGuess )||(pass != passGuess) ){
            while( result==false ){
                if(atmpt > 3){
                    System.Console.WriteLine("Too Many Attempts!");
                    break;
                } else{
                    atmpt ++;
                    System.Console.WriteLine("Enter Username:");
                    userGuess = System.Console.ReadLine();
                    System.Console.WriteLine("Enter Password:");
                    passGuess = System.Console.ReadLine();
                    
                    if((user==userGuess)&&(pass==passGuess)){
                        result = true;
                    }
                }
            }
        } else{
            result = true;
        }
        
        if(result){
            System.Console.WriteLine("Access Granted");
        } else{
            System.Console.WriteLine("Access Denied");
        }
    }
}
