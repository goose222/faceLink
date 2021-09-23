using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using myCsvReader;
using System.Data;

public class link : MonoBehaviour
{
    int blendShapeCount;
    SkinnedMeshRenderer skinnedMeshRenderer;
    Mesh skinnedMesh;
    // Start is called before the first frame update
    public SkinnedMeshRenderer faceware_rig;
    //string[] arkit_name = new string[52];
    public string[] arkit_name;
    public string[] faceware_name;
    int timeCount = 0;
    CSVhelper mycsvHelper;
    DataTable dt = new DataTable();

    void Awake ()
    {
	//mycsvHelper = new CSVhelper();
        skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        skinnedMesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
    }

    void Start()
    {
	//Debug.Log(mycsvHelper);
	mycsvHelper = new CSVhelper();
	//Debug.Log(mycsvHelper);

        dt = mycsvHelper.csv2dt("data.csv",0, dt);
	//Debug.Log(dt);

        blendShapeCount = skinnedMesh.blendShapeCount;
        
        arkit_name = new string[52];
        arkit_name[0] = "eyeBlinkLeft";
        arkit_name[1] = "eyeLookDownLeft";
        arkit_name[2] = "eyeLookInLeft";
        arkit_name[3] = "eyeLookOutLeft";
        arkit_name[4] = "eyeLookUpLeft";
        arkit_name[5] = "eyeSquintLeft";
        arkit_name[6] = "eyeWideLeft";
        arkit_name[7] = "eyeBlinkRight";
        arkit_name[8] = "eyeLookDownRight";
        arkit_name[9] = "eyeLookInRight";
        arkit_name[10] = "eyeLookOutRight";
        arkit_name[11] = "eyeLookUpRight";
        arkit_name[12] = "eyeSquintRight";
        arkit_name[13] = "eyeWideRight";
        arkit_name[14] = "jawForward";
        arkit_name[15] = "jawLeft";
        arkit_name[16] = "jawRight";
        arkit_name[17] = "jawOpen";
        arkit_name[18] = "mouthClose";
        arkit_name[19] = "mouthFunnel";
        arkit_name[20] = "mouthPucker";
        arkit_name[21] = "mouthRight";
        arkit_name[22] = "mouthLeft";
        arkit_name[23] = "mouthSmileLeft";
        arkit_name[24] = "mouthSmileRight";
        arkit_name[25] = "mouthFrownRight";
        arkit_name[26] = "mouthFrownLeft";
        arkit_name[27] = "mouthDimpleLeft";
        arkit_name[28] = "mouthDimpleRight";
        arkit_name[29] = "mouthStretchLeft";
        arkit_name[30] = "mouthStretchRight";
        arkit_name[31] = "mouthRollLower";
        arkit_name[32] = "mouthRollUpper";
        arkit_name[33] = "mouthShrugLower";
        arkit_name[34] = "mouthShrugUpper";
        arkit_name[35] = "mouthPressLeft";
        arkit_name[36] = "mouthPressRight";
        arkit_name[37] = "mouthLowerDownLeft";
        arkit_name[38] = "mouthLowerDownRight";
        arkit_name[39] = "mouthUpperUpLeft";
        arkit_name[40] = "mouthUpperUpRight";
        arkit_name[41] = "browDownLeft";
        arkit_name[42] = "browDownRight";
        arkit_name[43] = "browInnerUp";
        arkit_name[44] = "browOuterUpLeft";
        arkit_name[45] = "browOuterUpRight";
        arkit_name[46] = "cheekPuff";
        arkit_name[47] = "cheekSquintLeft";
        arkit_name[48] = "cheekSquintRight";
        arkit_name[49] = "noseSneerLeft";
        arkit_name[50] = "noseSneerRight";
        arkit_name[51] = "tongueOut";

        faceware_name = new string[52];
        faceware_name[0] = "EyeBlinkLeft";
        faceware_name[1] = "EyeLookDownLeft";
        faceware_name[2] = "EyeLookInLeft";
        faceware_name[3] = "EyeLookOutLeft";
        faceware_name[4] = "EyeLookUpLeft";
        faceware_name[5] = "EyeSquintLeft";
        faceware_name[6] = "EyeWideLeft";
        faceware_name[7] = "EyeBlinkRight";
        faceware_name[8] = "EyeLookDownRight";
        faceware_name[9] = "EyeLookInRight";
        faceware_name[10] = "EyeLookOutRight";
        faceware_name[11] = "EyeLookUpRight";
        faceware_name[12] = "EyeSquintRight";
        faceware_name[13] = "EyeWideRight";
        faceware_name[14] = "JawForward";
        faceware_name[15] = "JawLeft";
        faceware_name[16] = "JawRight";
        faceware_name[17] = "JawOpen";
        faceware_name[18] = "MouthClose";
        faceware_name[19] = "MouthFunnel";
        faceware_name[20] = "MouthPucker";
        faceware_name[21] = "MouthRight";
        faceware_name[22] = "MouthLeft";
        faceware_name[23] = "MouthSmileLeft";
        faceware_name[24] = "MouthSmileRight";
        faceware_name[25] = "MouthFrownRight";
        faceware_name[26] = "MouthFrownLeft";
        faceware_name[27] = "MouthDimpleLeft";
        faceware_name[28] = "MouthDimpleRight";
        faceware_name[29] = "MouthStretchLeft";
        faceware_name[30] = "MouthStretchRight";
        faceware_name[31] = "MouthRollLower";
        faceware_name[32] = "MouthRollUpper";
        faceware_name[33] = "MouthShrugLower";
        faceware_name[34] = "MouthShrugUpper";
        faceware_name[35] = "MouthPressLeft";
        faceware_name[36] = "MouthPressRight";
        faceware_name[37] = "MouthLowerDownLeft";
        faceware_name[38] = "MouthLowerDownRight";
        faceware_name[39] = "MouthUpperUpLeft";
        faceware_name[40] = "MouthUpperUpRight";
        faceware_name[41] = "BrowDownLeft";
        faceware_name[42] = "BrowDownRight";
        faceware_name[43] = "BrowInnerUp";
        faceware_name[44] = "BrowOuterUpLeft";
        faceware_name[45] = "BrowOuterUpRight";
        faceware_name[46] = "CheekPuff";
        faceware_name[47] = "CheekSquintLeft";
        faceware_name[48] = "CheekSquintRight";
        faceware_name[49] = "NoseSneerLeft";
        faceware_name[50] = "NoseSneerRight";
        faceware_name[51] = "TongueOut";
    }

    // Update is called once per frame
    void Update()
    {
	timeCount++;
	if (timeCount > 300){
	    timeCount=0;
	};
        for (int i = 0; i<52; i++){
            int arkit_index = skinnedMesh.GetBlendShapeIndex("BS_Node."+arkit_name[i]);
            int faceware_index = faceware_rig.sharedMesh.GetBlendShapeIndex("VictorBlendshapes."+faceware_name[i]);
            float faceware_weight = faceware_rig.GetBlendShapeWeight(faceware_index);//通过read csv完成
            
	    Debug.Log( dt.Rows[0][faceware_name[i]]);
	    float csv_weight = float.Parse(dt.Rows[timeCount][faceware_name[i]] as string);
            Debug.Log(csv_weight);
            //skinnedMeshRenderer.SetBlendShapeWeight(arkit_index, csv_weight);
            skinnedMeshRenderer.SetBlendShapeWeight(arkit_index, csv_weight*100);
        }
    }
}
