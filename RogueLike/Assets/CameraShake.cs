using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

private Vector3 initialPosition;
   private void Start()
	{
		initialPosition = transform.localPosition;
	}


 public IEnumerator Shake(float duration, float magnitude)
	{
		float elapsedTime = 0f;

		while (elapsedTime < duration)
		{
			float xOffset = Random.Range(-1f, 1f) * magnitude;
			float yOffset = Random.Range(-1f, 1f) * magnitude;

			transform.localPosition = initialPosition + new Vector3(xOffset, yOffset, 0f);

			elapsedTime += Time.deltaTime;

			yield return null;
		}

		transform.localPosition = initialPosition;
	}
}
