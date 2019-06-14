using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Block2 : MonoBehaviour {
    public int score = 0;
    public void Change () {
        if (Vector3.Distance (transform.position, GameManager2.Instance.empty) <= 3.8f) {
            var temp = transform.position;
            transform.position = GameManager2.Instance.empty; //交换位置
            GameManager2.Instance.SwapEmpty (temp); //每次交换都需要根据空方块的位置,进行判定是否已经完成游戏
        }
    }
    public void OnMouseDown () {
        //判断与空方块的距离,如果不是与空方块相邻的物体这不能交换
        if (!GameManager2.Instance.finish && GameManager2.Instance.isStart) {
            if (Vector3.Distance (transform.position, GameManager2.Instance.empty) <= 3.8f) {
                var temp = transform.position;
                transform.position = GameManager2.Instance.empty; //交换位置
                GameManager2.Instance.SwapEmpty (temp); //每次交换都需要根据空方块的位置,进行判定是否已经完成游戏
            }
        }
    }

}