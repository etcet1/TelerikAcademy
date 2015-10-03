using System;

/* 10.A marketing firm wants to keep record of its employees. Each record would have the following characteristics – 
 * first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
 * Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.
 */

class EmplyeesRecord
{
    static void Main()
    {
        string firstName;
        string familyName;
        int personalId;
        int employeeId;
        char gender;
        int submittedId;

        firstName = "Gergana";
        familyName = "Petrova";
        personalId = 45732896;
        employeeId = 27561234;
        gender = 'f';
        Console.WriteLine("Plese enter below the employee ID (use 27561234)");
        submittedId = int.Parse(Console.ReadLine());
        if (submittedId>=27560000 && submittedId<=27569999)
        {
            if (submittedId == 27561234)
            {
            /* There is a small check if the submitted ID is equal to the one that we have typed in. 
             * Using ternary operator to display "male" or "female" depending on the "gender" variable.
             */
            Console.WriteLine("Employee ID: {0}\nName: {1} {2}\nGender: {3}\nPersonal ID: {4}", employeeId, firstName, familyName, gender == 'm' ? "male" : "female", personalId);
            }
            else
            {
                Console.WriteLine("Employee with ID {0} doesn\'t exist", submittedId);   
            }
        }
        else
        {
            Console.WriteLine("Invalid ID number");   
        }
    }
}
