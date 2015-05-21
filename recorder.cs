using UnityEngine;
using System.Collections;

public class recorder : MonoBehaviour {
	
	bool isRecord = true;
	float[] samples;

	void Start(){

	}

	void OnGUI(){
		if(isRecord){
			if(GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-50,200,100), "Record")){ // 開始錄音
				isRecord = !isRecord;
				audio.clip = Microphone.Start("MyMicrophone", true, 1000, 44100); // 錄音1000秒，44100 Hz 格式
			}
		}else{
			// 暫停錄音，並撥放錄音
			print("sample = " + audio.clip.samples);	//44100 000 
			if(GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-50,200,100), "Close & Play")){
				isRecord = !isRecord;
				Microphone.End("MyMicrophone");
				audio.Play();
			}
		}
		if(GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-150,200,100), "Get Data")){
			samples = new float[audio.clip.samples * audio.clip.channels];
			audio.clip.GetData(samples, 0);
			int i = 0;
			print ("sample freq = "+audio.clip.frequency);	//44100
			print ("channel " + audio.clip.channels);
			print("sample = " + audio.clip.samples);	//44100 000 
			//print ("length = "+samples.Length);
 			while (i < 10){
				samples[i] = samples[i] * 0.5F;
				++i;
				print(i + ": " + samples[i]);
			}
			audio.clip.SetData(samples, 0);
		}

	}
	
}
