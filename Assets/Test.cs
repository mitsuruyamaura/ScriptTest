using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour {

	void Start(){
        //  5つの要素の配列を初期化する
        int[] array = { 50, 100, 35, 88, 42};

        //  配列の要素数だけ処理を繰り返す
        for (int i = 0; i < array.Length; i++){
            //  配列の要素を順番に表示する
            Debug.Log(array[i]);
        }

        //  for文を使い、配列の各要素の値を逆順に表示する
        for (int i = 4; array.Length > i;i--){
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
