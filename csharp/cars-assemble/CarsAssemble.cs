using System;

static class AssemblyLine
{
    public static double ProductionRatePerHour(int speed)
    {
        double production = 0.0;
        if (speed==0)
        {
            production=0;
        }

        if(speed>0 && speed <=4)
        {
            production=speed*221;
        }
        if (speed>4 && speed<=8)
        {
            production = speed * 221 * 0.9;
        }

        if (speed == 9)
        {
            production = speed * 221 * 0.8;
        }

        if (speed == 10)
        {
            production = speed * 221 * 0.77;
        }

        return production;
    }

    public static int WorkingItemsPerMinute(int speed)
    {

        int productionPerMinute = 0;
        if (speed == 0)
        {
            productionPerMinute = 0;
        }

        if (speed > 0 && speed <= 4)
        {
            productionPerMinute = speed * 221/60;
        }
        if (speed > 4 && speed <= 8)
        {
            productionPerMinute = (int)(speed * 221 * 0.9/60);
        }

        if (speed == 9)
        {
            productionPerMinute = (int)(speed * 221 * 0.8/60);
        }

        if (speed == 10)
        {
            productionPerMinute = (int)(speed * 221 * 0.77/60);
        }

        return productionPerMinute;
    }
}
