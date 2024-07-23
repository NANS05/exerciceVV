namespace AlgoVV;

public class Seance
{
    public bool Allonge;
    public bool Assis;
    public DateOnly Date;
    public string SessionId;
    
    public Seance(DateOnly date, string sessionId, bool allonge, bool assis)
    {
        this.Allonge = allonge;
        this.Assis = assis;
        this.Date = date;
        this.SessionId = sessionId;
    }
}