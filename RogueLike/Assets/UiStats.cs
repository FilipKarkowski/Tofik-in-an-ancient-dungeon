using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiStats : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] private Text strengthTxt;
	[SerializeField] private Text defenceTxt;
	[SerializeField] private Text speedTxt;
	[SerializeField] private PlayerStats ps;

	// Update is called once per frame
	void Update()
	{
		StatsUpdate();
	}
	
	private void StatsUpdate()
	{
		strengthTxt.text = ps.strength.ToString();
		defenceTxt.text = ps.defence.ToString();
		speedTxt.text = ps.moveSpeed.ToString();
	}
}
