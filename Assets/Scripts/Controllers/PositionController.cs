using UnityEngine;
using System.Collections;

public class PositionController {

	public static Vector3 MiddlePosition (float zPosition = 0) {
		var position = new Vector3 (3, 3, zPosition);
		return position;
	}

	public static Vector3 LeftPosition (float zPosition = 0) {
		var position = new Vector3 (-10, 3, zPosition);
		return position;
	}

	public static Vector3 RightPosition (float zPosition = 0) {
		var position = new Vector3 (20, 3, zPosition);
		return position;
	}
}