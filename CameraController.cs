using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    //プレイヤーの指定
    public GameObject Player_1;
    public GameObject Player_2;

    //サブカメラ
    public Camera Player_Camera_1X;
    public Camera Player_Camera_0X;
    public Camera Player_Camera_1Y;
    public Camera Player_Camera_0Y;

    //三次元位置
    private static float THIS_POSITION_X;
    private static float THIS_POSITION_Y;
    private static float THIS_POSITION_Z;

    // Use this for initialization
    void Start () {
        THIS_POSITION_Z = Player_1.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {

        //カメラワーク計算

        //オブジェクト1がオブジェクト2より手前にあるのならば
        if (Player_1.transform.position.z > Player_2.transform.position.z)
        {
            THIS_POSITION_Z = Player_2.transform.position.z;
        }

        //オブジェクト2がオブジェクト1より手前にあるのならば
        else if (Player_1.transform.position.z < Player_2.transform.position.z)
        {
            THIS_POSITION_Z = Player_1.transform.position.z;
        }

        //オブジェクト1とオブジェクト2が同じ位置にあるのならば
        else if (Player_1.transform.position.z == Player_2.transform.position.z)
        {
            THIS_POSITION_Z = Player_1.transform.position.z;
        }

        //カメラの位置
        this.transform.position = new Vector3(
            this.transform.position.x,
            this.transform.position.y,
            THIS_POSITION_Z
        );

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (MainCamera.enabled)
            {
                MainCamera.enabled = false;
                AimCamera.enabled = true;
            }
            else
            {
                MainCamera.enabled = true;
                AimCamera.enabled = false;
            }

        }*/
    }
}
