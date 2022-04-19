// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil
  {
      public Mage(string str) : base(str){

      }

      public virtual Storm CastRainStorm(){
        Storm braa = new Storm("rain", false, this.Title);
        return braa;
      }
  }
}
