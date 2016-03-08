using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimulationManager : MonoBehaviour {
	public float min;
	public float max;

//	private GateAdd gateAdd;
//	private GateMultiply gateMultiply;
//	private List<Gate2Args> gateList;
	public Gate2Args[] gateList;

	public void Load() {
		foreach (Gate2Args gate in gateList) {
			gate.InitRandomValues(min, max);
			gate.UpdateText();
		}
	}

	public void RunSimulation() {
		foreach (Gate2Args gate in gateList) {
			gate.UpdateText();
		}
	}
}

