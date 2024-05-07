namespace Pattern.Strategy.StrategyVS;

public interface ISuperPower
{
    string ExercisePower();
}

public class Regular : ISuperPower
{
    public string ExercisePower() => "Run Away";
}

public class Fly : ISuperPower
{
    public string ExercisePower() => "Up, Up, and Away!";
}

public class Fight : ISuperPower
{
    public string ExercisePower() => "Catches Thieves Like Flies!";
}

public class WaveWeb : ISuperPower
{
    public string ExercisePower() => "KaBaam!";
}