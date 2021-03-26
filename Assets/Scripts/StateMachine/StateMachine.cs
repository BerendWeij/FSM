using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateMachine : MonoBehaviour {

	private Dictionary<StateId, State> _states = new Dictionary<StateId, State> ();
	
	private State _currentState;
	
	void Update () {
		if (_currentState == null) 
			return;
		
		_currentState.Reason();
		_currentState.Act();
	}

	public void SetState(StateId stateId) {

		if(!_states.ContainsKey(stateId))
			return;

		if(_currentState != null)
			_currentState.Leave();

		_currentState = _states[stateId];

		_currentState.Enter();
	}

	public void AddState(StateId stateId, State state) {
		_states.Add( stateId, state );
	}

}
