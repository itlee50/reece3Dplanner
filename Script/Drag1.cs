using UnityEngine;
using System.Collections;

public class Drag1 : MonoBehaviour
{
     Vector3 dist;
      float posX;
      float posY;

      void OnMouseDown()
      {
          Debug.Log("dawddawddawd");
          Cursor.visible = true;
          dist = Camera.main.WorldToScreenPoint(transform.position);
          posX = Input.mousePosition.x - dist.x;
          posY = Input.mousePosition.y - dist.y;

      }
      void OnMouseDrag()
      {
          Debug.Log("dawddawddawd");
          Vector3 curPos = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
          Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
      }
 /* 
    void Start()
    {
        StartCoroutine(OnMouseDown());
    }

    IEnumerator OnMouseDown()
    {
        Debug.Log("dawdawdwadawd");
        //将物体由世界坐标系转换为屏幕坐标系
        Vector3 screenSpace = Camera.main.WorldToScreenPoint(transform.position);//三维物体坐标转屏幕坐标
        //完成两个步骤 1.由于鼠标的坐标系是2维，需要转换成3维的世界坐标系 
        //    //             2.只有3维坐标情况下才能来计算鼠标位置与物理的距离，offset即是距离
        //将鼠标屏幕坐标转为三维坐标，再算出物体位置与鼠标之间的距离
        Vector3 offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
        while (Input.GetMouseButton(0))
        {
            //得到现在鼠标的2维坐标系位置
            Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
            //将当前鼠标的2维位置转换成3维位置，再加上鼠标的移动量
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
            //curPosition就是物体应该的移动向量赋给transform的position属性
            transform.position = curPosition;
            yield return new WaitForFixedUpdate(); //这个很重要，循环执行
        }
    }
     */ 

}
