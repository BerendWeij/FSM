using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum StateId
{
	NullStateId,
	Wandering,
	Alerting,
	Fleeing,
	Attacking
}

public class Guard : MonoBehaviour {

	private StateMachine _stateMachine;

	void Start () {
		_stateMachine = GetComponent<StateMachine>();
		
		_stateMachine.AddState( StateId.Alerting, GetComponent<AlertState>() );
		_stateMachine.AddState( StateId.Wandering, GetComponent<WanderState>() );
		_stateMachine.AddState( StateId.Fleeing, GetComponent<FleeState>() );
		
		

		_stateMachine.SetState( StateId.Wandering );
	}

}