namespace Heliocentric
{
  public class AlignmentCalculator
  {
    public int EarthCurrentDay;
    public int MarsCurrentDay;
    public int DaysTillAligned;
    const int FirstDayYear = 0;

    public AlignmentCalculator(int earth, int mars)
    {
      EarthCurrentDay = earth;
      MarsCurrentDay = mars;
      DaysTillAligned = CalculateWhenPlanetsAlign();
    }

    public int CalculateWhenPlanetsAlign()
    {
      // how many loops until they are both at 0
      int numberIterations = 0;

      while (!(MarsCurrentDay == FirstDayYear) || !(EarthCurrentDay == FirstDayYear))
      {
        // increase the day by 1
        EarthCurrentDay++;
        MarsCurrentDay++;

        // current day is remainder of day/year
        EarthCurrentDay %= 365;
        MarsCurrentDay %= 687;
        numberIterations++;
      }

      return numberIterations;
    }
  }
}
