using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Assets.Scripts;

public class SpinCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Bitmap File path
    	string path = Application.dataPath + "/Resource/test.bmp";
	// Convert a C# string to a byte array
	Byte[] pathBytes = System.Text.Encoding.ASCII.GetBytes(path);
	
	//Bitmap File width
	const int WIDTH = 1920;
	const int HEIGHT = 1080;
	const int BITS_PER_PIXEL = 32;
	const int BMP_HEADER_SIZE = 54;
        const int BUFFER_SIZE = WIDTH * HEIGHT * (BITS_PER_PIXEL/8) + BMP_HEADER_SIZE;
        
        Byte[] buffer = new Byte[BUFFER_SIZE];
        int result = ExternalLibAttempt.getImage(pathBytes, buffer);
        Debug.Log("read result = " + result); // 0 is success; not 0 is fail
    }

    // Update is called once per frame
    void Update()
    {

    }
}
