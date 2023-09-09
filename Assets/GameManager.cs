using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	#region Variables: Debug

	[SerializeField] private bool hideCursor;

	#endregion
	
	private void Start()
	{
		Cursor.visible = !hideCursor;
	}
}
