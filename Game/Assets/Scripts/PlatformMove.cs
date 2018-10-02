using UnityEngine;

public class PlatformMove : MonoBehaviour {

    public GameObject platform;
    public GameObject text;
    Finish sas = new Finish();

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {

            if (Input.GetKey(KeyCode.DownArrow))
                platform.transform.localEulerAngles += new Vector3(-0.5f, 0f, 0f);

            if (Input.GetKey(KeyCode.UpArrow))
                platform.transform.localEulerAngles += new Vector3(0.5f, 0f, 0f);

            if (Input.GetKey(KeyCode.LeftArrow))
                platform.transform.localEulerAngles += new Vector3(0f, 0f, 0.5f);

            if (Input.GetKey(KeyCode.RightArrow))
                platform.transform.localEulerAngles += new Vector3(0f, 0f, -0.5f);
        }
}
