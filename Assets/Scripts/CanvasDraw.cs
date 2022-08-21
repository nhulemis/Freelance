using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI.Extensions;
using ProBuilder2.Common;



public class CanvasDraw : MonoBehaviour
{
    [Serializable]
public struct table{
    public List<Vector2> enemuPos;
}
    #region //----> Variable
    private RaksTouch touch;
    public List<Vector2> touchPositions = new List<Vector2>();
    public table[] EnemyWingsPointPosition=new table[2];
    public UILineTextureRenderer linerenderer;
    public float twoPointMaxDis = 75f;
    public int index;
    public Material material;
    public static CanvasDraw instance;
    [HideInInspector]
    public GameObject currentDrawcar;
    private RectTransform rectTransform;
    #endregion
    #region //----> Unity Method
    void Awake(){
        if(instance==null)
         instance=this;
         else if(instance!=this){
            Destroy(this.gameObject);
         }
    }
    private void Start()
    {
        touch = GetComponent<RaksTouch>();
        rectTransform = transform as RectTransform;
       


        
    }

    private void Update()
    {
        
            if (touch.isEvent )
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    FirstLinePoint();
                }
                if (Input.GetKey(KeyCode.Mouse0) && touchPositions.Count<=13)
                {
                    UpdateLine();
                }
            }
            else
            {
                if (Input.GetKeyUp(KeyCode.Mouse0))
                {
                    if (touchPositions.Count > 13)
                    {
                        UiManager.instance.showPlayButton();
                        BeybladeController.instance.clear();
                        CrateCar(touchPositions);
                    }
                    else
                    {
                        Time.timeScale = 1;
                    }
                }
            }
        
    }
    #endregion
    public void addWings(EnemyHolder enemy){
        GameObject createCar = new GameObject();
        createEnemyWings(ref createCar,EnemyWingsPointPosition[0].enemuPos,true,enemy);
        GameObject createCar2 = new GameObject();
        createEnemyWings(ref createCar2,EnemyWingsPointPosition[0].enemuPos,false,enemy);
        createCar2.transform.localEulerAngles=new Vector3(90,180,0);
        createCar.transform.localEulerAngles=new Vector3(90,0,0);

    }
    private void FirstLinePoint()
    {
        Time.timeScale = 0.3f;
        touchPositions.Clear();
       // EnemyWingsPointPosition.Clear();
        Vector2 firstPosition = touch.startPosition.InversePoint(linerenderer.transform);
        touchPositions.Add(firstPosition);
              EnemyWingsPointPosition[index].enemuPos.Add(firstPosition);
        linerenderer.Points = touchPositions.ToArray();
    }

    private void UpdateLine()
    {
        Vector2 touchPos = touch.currentPosition.InversePoint(linerenderer.transform);

        var heightClamp = rectTransform.rect.height / 2f;
        var widthClamp = RCanvas.canvasSize.x / 2f;
        touchPos = new Vector2(Mathf.Clamp(touchPos.x, widthClamp * -1f, widthClamp), Mathf.Clamp(touchPos.y, heightClamp * -1f, heightClamp));

        float distance = Vector2.Distance(touchPositions[touchPositions.Count - 1], touchPos);
        if (distance > twoPointMaxDis)
        {
            touchPositions.Add(touchPos);
           // EnemyWingsPointPosition.Add(touchPos);
         EnemyWingsPointPosition[index].enemuPos.Add(touchPos);

            linerenderer.Points = touchPositions.ToArray();
        }
    }
      private void CrateCar(List<Vector2> points)
    {
        GameObject createCar = new GameObject();
        createblade(ref createCar,points);
        GameObject createCar2 = new GameObject();
        createblade(ref createCar2,points,false);
        createCar2.transform.localEulerAngles=new Vector3(90,180,0);
        createCar.transform.localEulerAngles=new Vector3(90,0,0);

            // WheelPlacement(createCar.transform, pathObject);
     //   NewDrawCarPlace(createCar);
      //  CarReset();
        Time.timeScale = 1;
    }
    private void createblade(ref GameObject createCar,List<Vector2> points,bool Right=true){
        var carObject = createCar.AddComponent<pb_Object>();
        createCar.AddComponent<pb_Entity>();
        pb_BezierShape pathObject = createCar.AddComponent<pb_BezierShape>();
        List<pb_BezierPoint> beizers = BeizerListCreate(points);
        pathObject.m_Points = beizers;
        pathObject.m_Radius = 15;
        pathObject.Refresh();
        createCar.transform.localScale = new Vector3(0.004f, 0.016f, 0.017f);
        carObject.ToMesh();
        Mesh m = createCar.GetComponent<MeshFilter>().sharedMesh;
        MeshRenderer mr = createCar.GetComponent<MeshRenderer>();
        MeshCollider mc = createCar.AddComponent<MeshCollider>();
        mc.sharedMesh = m;
        mc.convex = true;
        mr.sharedMaterial = material;
        if(flip)
          Right=!Right;
        if(Right){
           createCar.transform.parent = BeybladeController.instance.rightTrans;
           createCar.transform.localPosition = BeybladeController.instance.right();
        }else{            
           createCar.transform.parent = BeybladeController.instance.leftTrans;
           createCar.transform.localPosition = BeybladeController.instance.left();
        }
       
       
    }
    private void createEnemyWings(ref GameObject createCar,List<Vector2> points,bool Right, EnemyHolder enemyC){
        var carObject = createCar.AddComponent<pb_Object>();
        createCar.AddComponent<pb_Entity>();
        pb_BezierShape pathObject = createCar.AddComponent<pb_BezierShape>();
        List<pb_BezierPoint> beizers = BeizerListCreate(points);
        pathObject.m_Points = beizers;
        pathObject.m_Radius = 15;
        pathObject.Refresh();
        createCar.transform.localScale = new Vector3(0.004f, 0.016f, 0.017f);
        carObject.ToMesh();
        Mesh m = createCar.GetComponent<MeshFilter>().sharedMesh;
        MeshRenderer mr = createCar.GetComponent<MeshRenderer>();
        MeshCollider mc = createCar.AddComponent<MeshCollider>();
        mc.sharedMesh = m;
        mc.convex = true;
        mr.sharedMaterial = material;
         if(Right){
           createCar.transform.parent = enemyC.rightTrans;
           createCar.transform.localPosition = enemyC.right();
        }else{            
           createCar.transform.parent = enemyC.leftTrans;
           createCar.transform.localPosition = enemyC.left();
        }

    }
  bool flip=false;
    private List<pb_BezierPoint> BeizerListCreate(List<Vector2> points)
    {
         print("Point zero"+points[0]);
         Vector2 point0=points[0];
        
        List<pb_BezierPoint> beizerPoints = new List<pb_BezierPoint>();
        if(point0.x>=0){
        for (int i = 0; i < points.Count; i++)
        {
            flip=false;
            beizerPoints.Add(new pb_BezierPoint(points[i]-point0, points[i]-point0, points[i]-point0, Quaternion.identity));
        }
        }else{
           point0=points[0];
        for (int i = 0; i < points.Count; i++)
        {
            //flip=true;
            print("kldkecde");
            beizerPoints.Add(new pb_BezierPoint(-points[i]+point0,-points[i]+point0, -points[i]+point0, Quaternion.identity));
        }
        }
        return beizerPoints;
    
       
    }
   

     }