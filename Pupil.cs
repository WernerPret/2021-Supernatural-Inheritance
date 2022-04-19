// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil{
    public string Title {get; private set;}

    public Pupil(string tit){
      this.Title = tit;
    }

    public virtual Storm CastWindStorm(){
      Storm bla = new Storm("wind", false, this.Title);
      return bla;
    }


  }

}
