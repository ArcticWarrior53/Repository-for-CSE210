public class Hybrid : BadGuy 
{
    public List<String> _abilitiesA;
    public List<String> _abilitiesB;

    public void HybridDescription()
    {
        Console.WriteLine("Put description here");
    }

    public List<String> getHybridAbilities()
    {
        return _abilitiesA;
    }
}