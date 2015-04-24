﻿using UnityEngine;
using System.Collections;

public enum EDamageType
{
//Physical
	//Physical,
	Slashing,
	Piercing,
	Crushing,
	
//Magic
	Magic,
	/*Fire,
	Frost,
	Poison,
	Ligthing,*/
	
	True
}

internal class DamageWrapper
{
	#region Inspector Properties
	internal EDamageType type;
	internal int amount;
	internal Reduction arpen;
	//public bool isRanged = false;
	#endregion

	#region Properties
	#endregion

	#region Methods
	/*internal DamageWrapper(EDamageType a_type, 
					int a_amount,
	                Reduction a_arpen
	                //bool a_isRanged,
					)
	{
		type = a_type;
		amount = a_amount;
		arpen = a_arpen;
		//isRanged = a_isRanged;
	}*/
	#endregion
}

internal class DamageReport
{
	internal int applied;
	internal int reducedByArmor;
	internal int final;
	
	public static DamageReport operator + (DamageReport x, DamageReport y)
	{
		DamageReport report = new DamageReport();
		report.applied = x.applied + y.applied;
		report.reducedByArmor = x.reducedByArmor + y.reducedByArmor;
		report.final = x.final + y.final;
		return report;
	}
	
	public override string ToString ()
	{
		return applied.ToString() + " - " + reducedByArmor.ToString() + " = " + final.ToString();
	}
}