using Pattern.Strategy.StrategyVS;

namespace Pattern.StrategyTests;

[Collection("StrategyTests")]
public class StrategyTests
{
    [Fact]
    public void ShouldReturnSuperPower()
    {
        IHero spiderMan = new SpiderMan();
        IHero superMan = new SuperMan();
        IHero Batman = new Batman();

        Assert.Equal(new WaveWeb().ExercisePower(), spiderMan.DoHeroStuff());
        Assert.Equal(new Fly().ExercisePower(), superMan.DoHeroStuff());
        Assert.Equal(new Fight().ExercisePower(), Batman.DoHeroStuff());
    }

    [Fact]
    public void ShouldReturnChangedSuperPower()
    {
        IHero spiderMan = new SpiderMan();
        Assert.Equal(new WaveWeb().ExercisePower(), spiderMan.DoHeroStuff());
        spiderMan.ChangeSuperPower(new Fight());
        Assert.Equal(new Fight().ExercisePower(), spiderMan.DoHeroStuff());
        spiderMan.ChangeSuperPower(new Fly());
        Assert.Equal(new Fly().ExercisePower(), spiderMan.DoHeroStuff());
    }
}
