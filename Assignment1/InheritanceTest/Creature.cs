using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	public enum Kind
	{
		Human,
		Animal,
		Insect,
	}
	//Actually a part of the advanced course.  
	//This class must be derived - cannot be instantiated.
	public abstract class Creature
	{
		private Kind kind;

        public Creature() { }
		public Creature(Kind kind)
		{
			this.kind = kind;
		}

		//Note: Implmenttion is not done here but in the sub-class.
		//i subklassen 
		public abstract string GetSkill();
	}
}
