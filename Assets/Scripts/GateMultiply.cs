using UnityEngine;
using System.Collections;

public class GateMultiply : Gate2Args {
	GateMultiply() : base() {
	}

	protected override string GetTitle() {
		return "Gate Multiply";
	}

	public override void Forward() {
		output = input1 * input2;
		Debug.Log ("Mul Forward : " + input1.ToString("G") + " * " + input2.ToString("G") + " = " + output.ToString("G"));
	}

	public override float ForwardProof(float x, float y) {
		return x * y;
	}

	public override void Backward(float x) {
	}
}
