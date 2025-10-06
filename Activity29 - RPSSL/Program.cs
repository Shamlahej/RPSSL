class Program
{
    static void Main(string[] args)
    {
        
        for (var p1 = Throw.Spock; (int) p1 < 5; ++p1)
        {
            for (var p2 = Throw.Spock; (int) p2 < 5; ++p2)
            {

                Console.WriteLine($"If p1: {p1} and p2: {p2}  => ");
                Console.WriteLine(GetWinState(p1, p2));
            }
        }
    }
    
    internal enum Throw
    {
        Rock,
        Paper,
        Scissors,
        Lizard,
        Spock
    }

    internal enum WinState
    {
        Tie,
        Wins,
        Loses
    }
    
    private static WinState GetWinState(Throw player1, Throw player2) 

    {
        var Score = player2 - player1;
        switch (Score)
        {
            
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
