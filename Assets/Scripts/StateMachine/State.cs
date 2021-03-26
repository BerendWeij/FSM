using UnityEngine;
using System.Collections;

public abstract class State : MonoBehaviour {
	
	
	public virtual void Enter ()
	{
		// dit is al een concrete method
	}

	public virtual void Leave ()
	{
		// dit is al een concrete method
	}

	public abstract void Act ();

	public abstract void Reason ();

}

