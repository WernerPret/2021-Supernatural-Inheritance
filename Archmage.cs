// Archmage.cs
using System;

namespace MagicalInheritance
{
  class Archmage : Mage
  {
    public Archmage(string str) : base(str){
      
    }
    
    public override Storm CastRainStorm(){
      Storm blab = new Storm("rain", true, this.Title);
      return blab;
    }

    public Storm CastLightningStorm(){
      Storm flab = new Storm("lightning", true, this.Title);
      return flab;
    }

  }
}
