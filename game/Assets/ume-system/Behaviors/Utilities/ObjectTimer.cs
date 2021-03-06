using UnityEngine;


namespace UME
{
	public class ObjectTimer : MonoBehaviour {

		private float m_time = 0f;
		public bool complete = false;


		// Use this for initialization
		void Awake () {
			complete = false;
		}
		public void init(float value){
			m_time = value;
			complete = false;
		}
		void Update () {
			m_time -= Time.deltaTime;
			if (m_time <= 0.0f) {
				complete = true;
			}
		}
			
	}
}