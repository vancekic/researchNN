using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gate2Args : Gate {
	protected float input1; /* {get; set; } */
	protected float input2;
	private float epsilon;

	protected Text input1Text;
	protected Text input2Text;
	protected Text outputText;
	protected Text proofText;
	protected Text titleText;

	public Gate2Args() : base() {
		epsilon = 0.0000001f;
		input1 = 0.0f;
		input2 = 0.0f;
	}

	public void InitRandomValues(float min, float max) {
		input1 = Random.Range(min, max);
		input2 = Random.Range(min, max);
	}

	public void UpdateText() {
		// set output in order to compute derivative
		Forward();

		// update text
		Text[] arr = transform.GetComponentsInChildren<Text>();
		arr[0].text = input1.ToString("G");
		arr[1].text = input2.ToString("G");
		arr[2].text = output.ToString("G");
		arr[3].text = GetProof().ToString("G");
		arr[4].text = GetTitle();
	}

	protected virtual string GetTitle() {
		return "";
	}

	public virtual float ForwardProof(float x, float y) {
		return 0.0f;
	}
		
	public float GetProof() {
		// compute derivatives for the 2 args
		float xph = ForwardProof(input1 + epsilon, input2);
		float xderivative = (xph - output) / epsilon;
		Debug.Log ("input1 derivative = " + xderivative.ToString());

		float yph = ForwardProof(input1, input2 + epsilon);
		float yderivative = (yph - output) / epsilon;
		Debug.Log("input2 derivative = " + yderivative.ToString());

		float step_size = 0.01f;
		return ForwardProof(input1 + step_size*xderivative, input2 + step_size*yderivative);
	}

}
