﻿// #region Copyright
// /* 
// ============================================================
// PatternsExamples - Adapters.cs
// All samples copyright 5/26/2013 Phil Japikse, www.skimedic.com
// see License.txt for license information
// ============================================================
// */
// Phil Japikse
// #endregion    

#region Copyright

#endregion

using System;

namespace PatternsExamples.B_Structural.A_Adapter
{
    public class MooseAdapter : ICharacter
    {
        private readonly IMoose _moose;

        public MooseAdapter(IMoose moose)
        {
            _moose = moose;
        }

        public int Chase() => _moose.Run();

	    public int Flee() => _moose.Run();

	    public int Attack() => _moose.Charge();
    }

    public class FlyingSquirrelAdapter : ICharacter
    {
        private readonly IFlyingSquirrel _flyingSquirrel;

        public FlyingSquirrelAdapter(IFlyingSquirrel flyingSquirrel)
        {
            _flyingSquirrel = flyingSquirrel;
        }

        public int Chase() => _flyingSquirrel.Fly();

	    public int Flee() => _flyingSquirrel.Fly();

	    public int Attack() => _flyingSquirrel.DropAcorns();
    }

    public class BadGuyAdapter : ICharacter
    {
        private readonly IBadGuy _badGuy;

        public BadGuyAdapter(IBadGuy badGuy)
        {
            _badGuy = badGuy;
        }

        public int Chase() => _badGuy.Drive();

	    public int Flee()
        {
            throw new Exception("Bad guys don't flee!");
        }

        public int Attack() => _badGuy.Shoot();
    }
}