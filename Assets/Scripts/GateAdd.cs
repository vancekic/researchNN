using UnityEngine;
using System.Collections;

public class GateAdd : Gate2Args {
	GateAdd() : base() {
	}

	protected override string GetTitle() {
		return "Gate Add";
	}

	public override void Forward() {
		output = input1 + input2;
		Debug.Log ("Add Forward : " + input1.ToString("G") + " + " + input2.ToString("G") + " = " + output.ToString("G"));
	}

	public override float ForwardProof(float x, float y) {
		return x + y;
	}

	public override void Backward(float x) {
	}
}
