using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
        Storm storm = new Storm("wind", false, "Zul'rajas");
        Console.WriteLine(storm.Announce());

        Pupil werner = new Pupil("Werner");
        Console.WriteLine(werner.CastWindStorm().Announce());

        Mage wernadius = new Mage("Wernadius");
        Console.WriteLine(wernadius.CastRainStorm().Announce());

        Archmage werndalf = new Archmage("Werndalf");
        Console.WriteLine(werndalf.CastRainStorm().Announce());
        Console.WriteLine(werndalf.CastLightningStorm().Announce());

    }
  }
}