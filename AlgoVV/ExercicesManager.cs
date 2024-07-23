using System.Globalization;

namespace AlgoVV;

public class ExercicesManager
{
    public List<Exercice> Exercices = new List<Exercice>();
    
    public ExercicesManager(string filePath)
    {
        
        using (var reader = new StreamReader(filePath))
        {
            // Skip header line
            string headerLine = reader.ReadLine();
            
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');

                int niveau;
                bool allonge;
                bool assis;
                DateOnly date;
                string sessionId = values[4].Trim('"');

                int.TryParse(values[1].Trim('"'), out niveau);
                bool.TryParse(values[2].Trim('"'), out allonge);
                bool.TryParse(values[3].Trim('"'), out assis);
                DateOnly.TryParse(values[5].Trim('"'), out date);
                
                
                Exercice exercice = new Exercice(niveau, allonge, assis, date, sessionId);
                
                Exercices.Add(exercice);
            }
        }

    }
    
    public void CheckSeances()
    {
        var allongeNiveau = 0;
        var assisNiveau = 0;
        var prevSession = Exercices[0].SessionId;
        DateOnly prevDate = Exercices[0].Date;

        foreach (var exercice in Exercices)
        {
            if (prevDate != exercice.Date || prevSession != exercice.SessionId)
            {
                allongeNiveau = 0;
                assisNiveau = 0;
            }
            if (exercice.Allonge)
            {
                allongeNiveau = exercice.Niveau;
            }

            if (exercice.Assis)
            {
                assisNiveau = exercice.Niveau;
            }

            if (allongeNiveau >= 2)
            {
                exercice.seance = new Seance(exercice.Date, exercice.SessionId, true, false);
                allongeNiveau = allongeNiveau - 2;
            }

            if (assisNiveau >= 2)
            {
                exercice.seance = new Seance(exercice.Date, exercice.SessionId, false, true);
                assisNiveau = assisNiveau - 2;
            }
        }
    }

    public void CheckPratiques()
    {
        var allonge = false;
        var assis = false;

        foreach (var exercice in Exercices)
        {
            if (exercice.seance != null && exercice.seance.Allonge)
            {
                allonge = exercice.seance.Allonge;
            }
            if (exercice.seance != null && exercice.seance.Assis)
            {
                assis = exercice.seance.Assis;
            }

            if (allonge && assis)
            {
                exercice.pratique = new Pratique();
                allonge = false;
                assis = false;
            }
            
        }
    }

    
    public void CountSerie()
    {
        List<String> validSessionsId
            
        foreach (var exercice in Exercices)
        {
            if (exercice.pratique)
            {
                
            }
        }
    }
}