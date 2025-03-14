using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log("esta madre se hace una sola vez");


        
    }
    void Update()
    {
        Vector3 norm = VectoN(target1.transform.position);
        Debug.Log(norm);
        float dist = Distance(target1.transform.position, target2.transform.position);
        if (dist < 1)
        {
            Debug.Log("esta chocando");
        }
        Debug.Log("distancia" + dist);

        float proP = prodPunt(target1.transform.position, target2.transform.position);
        Debug.Log("producto punto " + proP);
    }
    public float Distance(Vector3 post1, Vector3 post2)
    {
        float x = post1.x - post2.x;
        float y = post1.y - post2.y;
        float z = post1.z - post2.z;

        float x2 = x * x;
        float y2 = y * y;
        float z2 = z * z;

        float sum = x2 + y2 + z2;
        float sqrt = Mathf.Sqrt(sum);

        return (sqrt);
    }

    public Vector3 VectoN(Vector3 pos)
    {
        float x = pos.x * pos.x;
        float y = pos.x * pos.y;
        float z = pos.x * pos.z;

        float sum = x + y + z;
        float sqrt = Mathf.Sqrt(sum);

        float xno = pos.x / sqrt;
        float yno = pos.y / sqrt;
        float zno = pos.z / sqrt;

        Vector3 norm = new Vector3(xno, yno, zno);
        return norm;
    }
    public float prodPunt(Vector3 post11, Vector3 post12)
    {
        float xp = post11.x * post12.x;
        float yp = post11.y * post12.y;
        float zp = post11.z * post12.z;

        float sump = xp + yp + zp;
        return sump;
    }
    
    
}



   
    

