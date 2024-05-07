namespace Pattern.Strategy.StrategyVS;

public interface IHero
{
    string DoHeroStuff();

    void ChangeSuperPower(ISuperPower power);
}
