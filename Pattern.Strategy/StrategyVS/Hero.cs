using System.Net.Security;

namespace Pattern.Strategy.StrategyVS;

public class Hero : IHero
{
    private ISuperPower _power;

    public Hero() : this(new Regular()) { }

    public Hero(ISuperPower power) => _power = power;

    public void ChangeSuperPower(ISuperPower power) => _power = power;

    public string DoHeroStuff() => _power.ExercisePower();
}


public class SpiderMan : Hero
{
    public SpiderMan() : base(new WaveWeb())
    {
    }
}

public class SuperMan : Hero
{
    public SuperMan() : base(new Fly())
    {
    }
}

public class Batman : Hero
{
    public Batman() : base(new Fight())
    {
    }
}