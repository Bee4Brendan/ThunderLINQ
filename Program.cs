// See httpusing System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class NBA_Player
{
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private string College { get; set; }
    private int Number { get; set; }
    private int Age { get; set; }
    public enum Position { PG, SG, G, SF, PF, F, C }
    private Position Pos { get; set; }
    private string Height { get; set; }
    private int Weight { get; set; }
    private double Pts { get; set; }
    private double Ast { get; set; }
    private double Reb { get; set; }


    public NBA_Player(string first, string last, string college, int number, Position pos, int age, string height, int weight, double pts, double ast, double reb)
    {
        this.FirstName = first;
        this.LastName = last;
        this.College = college;
        this.Number = number;
        this.Pos = pos;
        this.Age = age;
        this.Height = height;
        this.Weight = weight;
        this.Pts = pts;
        this.Ast = ast;
        this.Reb = reb;
    }

    public string GetName()
    {
        return FirstName + " " + LastName;
    }

    public string GetCollege()
    {
        return this.College;
    }

    public void SetPosition(NBA_Player.Position pos)
    {
        this.Pos = pos;
    }

    public NBA_Player.Position GetPosition()
    {
        return this.Pos;
    }

    public int GetNumber()
    {
        return this.Number;
    }

    public int GetAge()
    {
        return this.Age;
    }

    public string GetHeight()
    {
        return this.Height;
    }

    public double GetRealHeight()
    {
        int feet, inches;
        double realHeight;

        int.TryParse(this.Height.Substring(0, 1), out feet);
        int.TryParse(this.Height.Substring(3, 1), out inches);

        if(inches == 1) int.TryParse(this.Height.Substring(3, 2), out inches);

        realHeight = (feet * 12) + inches;

        return realHeight;
    }

    public int GetWeight()
    {
        return this.Weight;
    }

    public double GetPoints()
    {
        return this.Pts;
    }

    public double GetAssists()
    {
        return this.Ast;
    }

    public double GetRebounds()
    {
        return this.Reb;
    }
}
internal class NBA
{
    private static void Main(string[] args)
    {
        NBA nba = new();

        // The Oklahoma City Thunder Team
        List<NBA_Player> OKC_THUNDER = new();

        // Load the Players and Start the queries
        nba.DraftPlayers(OKC_THUNDER);
        nba.Start(OKC_THUNDER);
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> This method "signs" the players to the Oklahoma City Thunder
     */
    public void DraftPlayers(List<NBA_Player> team)
    {
        // updated 7/8/2023
        team.Add(new NBA_Player("Shai", "Gilgeous-Alexander", "Kentucky", 2, NBA_Player.Position.PG, 24, "6' 6\"", 195, 31.4, 5.5, 4.8));
        team.Add(new NBA_Player("Davis", "Bertans", "--", 44, NBA_Player.Position.SF, 30, "6' 10\"", 225, 0.0, 0.0, 0.0));
        team.Add(new NBA_Player("Luguentz", "Dort", "Arizona State", 5, NBA_Player.Position.G, 24, "6' 4\"", 220, 13.7, 2.1, 4.6));
        team.Add(new NBA_Player("Chet", "Holmgren", "Gonzaga", 7, NBA_Player.Position.PF, 21, "7' 1\"", 208, 0.0, 0.0, 0.0));
        team.Add(new NBA_Player("Dario", "Saric", "--", 9, NBA_Player.Position.PF, 29, "6' 10\"", 225, 7.4, .9, 3.3));
        team.Add(new NBA_Player("Josh", "Giddey", "Australia", 3, NBA_Player.Position.SG, 20, "6' 8\"", 216, 16.6, 6.2, 7.9));
        team.Add(new NBA_Player("Ousmane", "Dieng", "--", 13, NBA_Player.Position.F, 20, "6' 9\"", 220, 4.9, 1.2, 2.7));
        team.Add(new NBA_Player("Jalen", "Williams", "Santa Clara", 8, NBA_Player.Position.F, 22, "6' 6\"", 218, 14.1, 3.3, 4.5));
        team.Add(new NBA_Player("Aleksej", "Pokusevski", "--", 17, NBA_Player.Position.F, 21, "7' 0\"", 190, 8.1, 1.9, 4.7));
        team.Add(new NBA_Player("Tre", "Mann", "Florida", 23, NBA_Player.Position.PG, 22, "6' 3\"", 184, 7.7, 1.8, 2.3));
        team.Add(new NBA_Player("Kenrich", "Williams", "TCU", 34, NBA_Player.Position.SF, 28, "6' 6\"", 210, 8.0, 2.0, 4.9));
        team.Add(new NBA_Player("Jaylin", "Williams", "Arkansas", 6, NBA_Player.Position.F, 20, "6' 9\"", 245, 5.9, 1.6, 4.9));
        team.Add(new NBA_Player("Jeremiah", "Robinson-Earl", "Villanova", 50, NBA_Player.Position.PF, 22, "6' 8\"", 240, 6.8, 1.0, 4.2));
        team.Add(new NBA_Player("Lindy", "Waters III", "Oklahoma State", 12, NBA_Player.Position.F, 25, "6' 6\"", 210, 5.2, .7, 1.8));
        team.Add(new NBA_Player("Isaiah", "Joe", "Arkansas", 11, NBA_Player.Position.SG, 23, "6' 3\"", 165, 9.5, 1.2, 2.4));
        team.Add(new NBA_Player("Aaron", "Wiggins", "Maryland", 21, NBA_Player.Position.SG, 24, "6' 5\"", 190, 6.8, 1.1, 3.0));
        team.Add(new NBA_Player("Jared", "Butler", "Baylor", 14, NBA_Player.Position.SG, 22, "6' 3\"", 193, 6.2, 1.3, .7));
        team.Add(new NBA_Player("Olivier", "Sarr", "Kentucky", 30, NBA_Player.Position.C, 24, "7' 0\"", 240, 4.0, .4, 3.4));
        team.Add(new NBA_Player("Cason", "Wallace", "Kentucky", 22, NBA_Player.Position.G, 19, "6' 4\"", 193, 0.0, 0.0, 0.0));
        team.Add(new NBA_Player("Keyontae", "Johnson", "Kansas State", 18, NBA_Player.Position.F, 24, "6' 6\"", 235, 0, 0, 0));
        team.Add(new NBA_Player("Vasilije", "Micic", "Serbia", 98, NBA_Player.Position.G, 29, "6' 5\"", 203, 13.1, 4.8, 2.4));
        team.Add(new NBA_Player("Victor", "Oladipo", "Indiana", 4, NBA_Player.Position.SG, 31, "6' 4\"", 213, 10.7, 3.5, 3.0));
        team.Add(new NBA_Player("KJ", "Williams", "LSU", 12, NBA_Player.Position.F, 23, "6' 10\"", 250, 0.0, 0.0, 0.0));
    }

    public void Start(List<NBA_Player> team)
    {
        string input;
        PrintMenu();
        input = Console.ReadLine();

        try
        {
            // Null check
            while (!String.IsNullOrEmpty(input) && !input[0].Equals('X'))
            {
                // Makes sure it's not case sensitive 
                switch (input[0].ToString().ToUpper())
                {
                    case "G":
                        GetRosterByAge(team);
                        break;
                    case "N":
                        GetRosterByNumber(team);
                        break;
                    case "1":
                        GetRosterByPosition(team);
                        break;
                    case "7":
                        GetSevenFooters(team);
                        break;
                    case "A":
                        GetAlphabeticalRosterByFirstName(team);
                        break;
                    case "K":
                        GetKentuckyPlayers(team);
                        break;
                    case "P":
                        GetPoints(team);
                        break;
                    case "S":
                        GetAssists(team);
                        break;
                    case "B":
                        GetRebounds(team);
                        break;
                    case "W":
                        GetWilliams(team);
                        break;
                    case "T":
                        GetWeights(team);
                        break;
                    case "H":
                        GetHeights(team);
                        break;
                    case "X":
                        return;
                }

                PrintMenu();
                
                input = Console.ReadLine();
            }
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("You must enter a Key to continue... or Press 'X' to Exit");
                Start(team);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("Try Again, \n" + e.Message);
        }

    }

    public void PrintMenu()
    {
        Console.WriteLine("\n Press one of the following options then Press 'ENTER' or Press 'X' to Exit \n");
        Console.WriteLine("\t 'G' - Roster By Age             \n\t 'N' - Roster By Jersey Number    \n\t '7' - Seven Foot+ Players      \n" +
                          "\t '1' = Roster By Position        \n\t 'A' - Roster in Alphabetical     \n\t 'K' - Kentucky Players         \n\t 'P' - Most Points Descending     \n" +
                          "\t 'S' - Most Assists Descending   \n\t 'B' - Most Rebounds Descending   \n\t 'W' - Williams Players         \n" +
                          "\t 'T' - Roster By Weight          \n\t 'H' - Roster By Height           \n\t 'X' - EXIT                     \n\t");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> Default Order, which is Sorted by Salary in Descending order by USD $ </summary>
     */
    public void PrintRoster(IEnumerable<NBA_Player> team, String message)
    {
        Console.WriteLine("-------------------------------------------- | Oklahoma City Thunder Roster " + message + " | ---------------------------------------------\n");
        Console.WriteLine("{0,-30} {1,-30} {2,-8} {3,-10} {4,-4} {5,-8:N1} {6,-8} {7,-8} {8,-8} {9,-8}", "Name", "College", "Number", "Position", "Age", "Height", "Weight", "Points", "Assists", "Rebounds");

        // List by Order Added
        foreach (var player in team)
        {
            //                 Name    College  Number  Pos    Age    Height   Weight   PTS    AST    REB
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-30} {1,-30} {2,-8} {3,-10} {4,-4} {5,-8:N1} {6,-8} {7,-8} {8,-8} {9,-8}", player.GetName(), player.GetCollege(), player.GetNumber(), player.GetPosition(), player.GetAge(), player.GetHeight(), player.GetWeight(), player.GetPoints(), player.GetAssists(), player.GetRebounds());
        }

        Console.WriteLine("\n\n\n");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> Sorts and prints the team by Age in Ascending Order </summary>
     */
    public void GetRosterByAge(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> rosterByAge = team.OrderBy(player => player.GetAge());
        PrintRoster(rosterByAge, "(By Age)");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> Sorts and prints the team by Jersey Number in Ascending Order
     */
    public void GetRosterByNumber(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> rosterByNumber = team.OrderBy(player => player.GetNumber());
        PrintRoster(rosterByNumber, "(By #)");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> Sorts and prints the team by Position
     */
    public void GetRosterByPosition(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> rosterByPosition = team.OrderBy(player => player.GetPosition());
        PrintRoster(rosterByPosition, "(By Position)");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> This method finds and prints the team's players that are seven feet tall or above (7'0"+) </summary>
     */
    public void GetSevenFooters(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> sevenFooters = team.FindAll(player => player.GetHeight().ElementAt(0) == '7');
        IEnumerable<NBA_Player> query =
            from player in team
            where player.GetHeight().ElementAt(0) == '7'
            select player;

        PrintRoster(query, "(Seven Footers)");
    }

    /*
     * <param> The team that is being sorted </param>
     * <summary> This method sorts and prints the team's roster in Alphabetical order </summary>
     */
    public void GetAlphabeticalRosterByFirstName(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> alphabeticalRoster = team.OrderBy(player => player.GetName());
        PrintRoster(alphabeticalRoster, "(Alphabetical [first name])");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> This method finds and prints the team's players that went to Kentucky University for college </summary>
     */
    public void GetKentuckyPlayers(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> kentuckyRoster = team.FindAll(player => player.GetCollege().Contains("Kentucky"));
        PrintRoster(kentuckyRoster, "(Kentucky Players)");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> This method finds and prints the team's players that are Williams </summary>
     */
    public void GetWilliams(List<NBA_Player> team)
    {
        // IEnumerable<NBA_Player> q = team.FindAll(player => player.getName().Contains("William"));
        // Regex pattern for any William
        Regex regex = new("([W][i][l]+[i][a][m][s]?)");
        var query =
            from player in team
            where regex.IsMatch(player.GetName())
            select player;

        PrintRoster(query, "(Williamses)");
    }

    public void GetWeights(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> rosterByWeight = team.OrderByDescending(player => player.GetWeight());
        PrintRoster(rosterByWeight, "(By Weight)");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> This method sorts and prints the team's roster by Points scored in the 2022-23 Season (Descending) </summary>
     */
    public void GetPoints(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> rosterByPoints = team.OrderByDescending(player => player.GetPoints());
        PrintRoster(rosterByPoints, "(By Most Points)");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> This method sorts and prints the team's roster by Assists scored in the 2022-23 Season (Descending) </summary>
     */
    public void GetAssists(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> rosterByAssists = team.OrderByDescending(player => player.GetAssists());
        PrintRoster(rosterByAssists, "(By Most Assists)");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> This method sorts and prints the team's roster by Rebounds scored in the 2022-23 Season (Descending) </summary>
     */
    public void GetRebounds(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> rosterByRebounds = team.OrderByDescending(player => player.GetRebounds());
        PrintRoster(rosterByRebounds, "(By Most Rebounds)");
    }

    /*
     * <param> The team that is being referenced </param>
     * <summary> This method sorts and prints the team's roster by Height (Descending) </summary>
     */
    public void GetHeights(List<NBA_Player> team)
    {
        IEnumerable<NBA_Player> rosterByHeight = team.OrderByDescending(player => player.GetRealHeight());
        PrintRoster(rosterByHeight, "(By Height)");
    }
}