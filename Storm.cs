// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm{
    public string Essence {get; private set;}
    public bool IsStrong {get; private set;}
    public string Caster {get; private set;}

    public Storm(string esc, bool str, string cst){
      this.Essence = esc;
      this.IsStrong = str;
      this.Caster = cst;
    }

    public string Announce(){
      string strong;
      if(this.IsStrong == true){
        strong = "strong";
      }
      else{
        strong = "weak";
      }
      return $"{this.Caster} cast a {strong} {this.Essence} storm!";
    }

  }

}
