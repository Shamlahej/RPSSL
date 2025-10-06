# Vi laver en Main()-funktion og en hjælper-metode, som skal tjekke hvem der vinder.

class Program
{
    static void Main(string[] args)
    {

# Her laver vi to løkker som kører alle kombinationer af spiller 1 og spiller 2's valg igennem. 
# '++' betyder bare at vi går videre til næste mulighed i enum’en (f.eks. fra Rock til Paper).
        
        for (var p1 = Throw.Spock; (int) p1 < 5; ++p1)
        {
            for (var p2 = Throw.Spock; (int) p2 < 5; ++p2)
            {
# Vi viser først hvad spiller 1 og spiller 2 har valgt. Så viser vi hvem der vandt (eller om det blev uafgjort).

                Console.WriteLine($"If p1: {p1} and p2: {p2}  => ");
                Console.WriteLine(GetWinState(p1, p2));
            }
        }
    }
    
# Her laver vi en enum med alle de valg man kan tage i spillet "Rock, Paper, Scissors, Lizard, Spock". 
# Enum betyder bare, at vi giver navn til en række faste værdier (0,1,2,3,4).

    internal enum Throw
    {
        Rock,
        Paper,
        Scissors,
        Lizard,
        Spock
    }
# Her laver vi en enum til selve udfaldet af spillet: uafgjort, vinder eller taber.

    internal enum WinState
    {
        Tie,
        Wins,
        Loses
    }
    
# Udover Main(), laver vi en metode der er vores hjælper værktøj. Dette er med til at "aflæse" vores "hånd" og finde resultatet.
    
    private static WinState GetWinState(Throw player1, Throw player2) 
        
# Her laver vi en simpel udregning: spiller2 minus spiller1.
# Resultatet af det tal fortæller os, om det er uafgjort, vundet eller tabt.

    {
        var Score = player2 - player1;
        switch (Score)
        {
# Alle cases og mulige udbytte. Så dette fortæller os om hvad vores resultat giver af udbytte. 
# Eks. -4 = win.
# Der er 3 mulige outcomes: Win, Lose, Tie. 
         
            case 0 :
                return WinState.Tie;
            case -4 or -2 or 1 or 3:
                return WinState.Wins;
            case -3 or -1 or 2 or 4:
                return WinState.Loses;
 
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
# Jeg lavede det da det var activity i undervisningen så derfor lavede jeg ikke GUI til den, da vi kun havde fået kort introduktion til GUI. 
