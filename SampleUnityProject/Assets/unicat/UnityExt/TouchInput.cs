// TouchInput.cs

using UnityEngine;

namespace unicat
{
	public delegate void InputDelegate(TouchPhase phase, Vector3 position);

	public class TouchInput
    {
        public static void proc(InputDelegate d)
        {
			if (Application.platform == RuntimePlatform.Android) {	
				if (Input.touchCount > 0) {
					Touch touch = Input.GetTouch(0);
					d(touch.phase, touch.position);
				}
			} else if (Application.platform == RuntimePlatform.IPhonePlayer) {
			} else { // mac
				if (true == Input.GetMouseButtonDown(0)) {
					d(TouchPhase.Began, Input.mousePosition);
				} else if ( true == Input.GetMouseButtonUp(0)) {
					d(TouchPhase.Ended, Input.mousePosition);
				} else if (true == Input.GetMouseButton(0)) {			
					d(TouchPhase.Moved, Input.mousePosition);
				} else {
				}
			}
        }
    }
}
