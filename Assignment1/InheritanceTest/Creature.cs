using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
	public enum Sort
	{
		Human,
		Animal,
		Insect,
	}
	//Actually a part of the advanced course.  
	//This class must be derived - cannot be instantiated.
	public abstract class Creature
	{
		private Sort theSort;

        public Creature() { }
		public Creature(Sort typ)
		{
			theSort = typ;
		}

		//Note: Implmenttion is not done here but in the sub-class.
		//i subklassen 
		public abstract string GetSkill();
	}
}
