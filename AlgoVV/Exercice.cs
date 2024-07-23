namespace AlgoVV;

public class Exercice
{
    public int Niveau;
    public bool Allonge;
    public bool Assis;
    public DateOnly Date;
    public string SessionId;
    public Seance seance;
    public Pratique pratique;

    public Exercice(int niveau, bool allonge, bool assis, DateOnly date, string sessionId)
    {
        this.Niveau = niveau;
        this.Allonge = allonge;
        this.Allonge = assis;
        this.Date = date;
        this.SessionId = sessionId;
    }
}