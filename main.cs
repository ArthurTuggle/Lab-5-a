using System;


public class Employee{
    
    
    String firstname;
    String lastname;
    String id;
    int age;
    String address;
    String phoneNumber;
    String title;
    double yearlySalary;
    String employeeStatus;
    
    
    public Employee(){
        firstname = "Unknown";
        lastname = "Unknown";
        id = "Unknown";
        age = 0;
        employeeStatus = "active";
    }
    
  
    public Employee(String firstname, String lastname, String id, int age){
        this.firstname = firstname;
        this.lastname = lastname;
        this.id = id;
        this.age = age;
        employeeStatus = "active";
    }
    
    
    public void Intro(){
        Console.WriteLine(firstname+" "+lastname+" (age "+age+" years) having ID "+id+" is "+employeeStatus+".");
    }
}


public class MainClass
{   
    
        public static void Main()
        {
            
                Employee e1 = new Employee();
                e1.Intro();
        
            
            Employee e2 = new Employee("John", "smith", "1234", 45);
            e2.Intro();
        }
}