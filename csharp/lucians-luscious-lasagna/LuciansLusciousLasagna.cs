public class Lasagna
{

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int _elapsed)
    {
        var _remaining = ExpectedMinutesInOven() - _elapsed;
        return _remaining;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        var _preparationTime = layers * 2;
        return _preparationTime;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layerNumber, int _elapsed)
    {
        var _totalElapsedTime = PreparationTimeInMinutes(layerNumber) + (ExpectedMinutesInOven()-RemainingMinutesInOven(_elapsed));
        return _totalElapsedTime;
    } 
}
