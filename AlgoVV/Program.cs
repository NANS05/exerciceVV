// See https://aka.ms/new-console-template for more information

using AlgoVV;

Console.WriteLine("Program Start");

var calculator = new ExercicesManager("C:\\Users\\Nans Maurel\\iCloudDrive\\Downloads\\Enregistrement.csv");
    
calculator.CheckSeances();

calculator.CheckPratiques();

foreach (var exercice in calculator.Exercices)
{
    Console.Write($"exercice : {exercice.SessionId}, {exercice.Date}, ");
    if (exercice.pratique != null)
    {
        Console.WriteLine("");
    }
    Console.WriteLine({exercice.pratique != null ? exercice.pratique.Checked : ""});
}

Console.WriteLine("Stop");