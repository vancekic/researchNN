using UnityEngine;
using System;

public class Gate : MonoBehaviour
{
	protected float output;
	public Gate ()
	{
		output = 0.0f;
	}

	virtual public void Forward() {
	}

	virtual public void Backward(float x) {
	}
}

