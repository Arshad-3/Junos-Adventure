using Newtonsoft.Json;
using Unity.Mathematics;
using Unity.Services.Leaderboards;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DragonController : MonoBehaviour
{
    [SerializeField] private float followSpeed;
    [SerializeField] private float flySpeed;
    [SerializeField] private float leanAngle;
    [SerializeField] private GameObject beacon;

    private FixedJoystick joystick;
    private BoxCollider coll;
    private Rigidbody rb;

    

    private bool follow = true;
    public bool Follow
    {
        get { return follow; }
        set { follow = value; }
    }

    private void OnEnable()
    {
        joystick = FindAnyObjectByType<FixedJoystick>();
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<BoxCollider>();
        
    }

    private void Awake()
    {
        GameManager.instance.Time = 0;
        GameManager.instance.WaypointsCollected = 0;
    }
    private async void Start()
    {
        
    }

    private void Update()
    {
        GameManager.instance.Time += Time.deltaTime;

        if((GameManager.instance.WaypointsCollected/2) >= 7)
        {
            if (GameManager.instance.Time< GameManager.instance.LowestTime)
            {
                GameManager.instance.LowestTime = GameManager.instance.Time;
                LeaderboardsService.Instance.AddPlayerScoreAsync(GameManager.instance.leaderboardId, GameManager.instance.LowestTime);
            }
        }
    }

    private void FixedUpdate()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
        rb.velocity = Vector3.zero;
        if (follow) 
        {
            Vector3 beaconPosition = new Vector3(beacon.transform.position.x, transform.position.y, beacon.transform.position.z);
            //transform.position = Vector3.Lerp(transform.position,beaconPosition, followSpeed*Time.deltaTime);

            Vector3 direction = beaconPosition - transform.position;
            rb.velocity = direction * flySpeed;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, 5f* Time.deltaTime);
            Vector3 lean = new Vector3(leanAngle, transform.eulerAngles.y, transform.eulerAngles.z);
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, lean, 20*Time.deltaTime);

        }
        else
        {
            Vector3 noLean = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles,noLean,20*Time.deltaTime);
            rb.velocity = Vector3.zero;
        }
        Vector3 vertical = new Vector3(transform.position.x,Camera.main.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, vertical, followSpeed*Time.deltaTime);
        IsVisible();
        
        /*float x = joystick.Horizontal;
        float y = joystick.Vertical;
        Vector3 movement= beacon.transform.TransformDirection(new Vector3(x,0,y)).normalized;
        rb.velocity = movement * flySpeed;
        if (x != 0 && y != 0)
        {
            transform.eulerAngles = new Vector3(lean, Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
        }
        */
            
    }
    private void IsVisible()
    {

        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);

        if (!GeometryUtility.TestPlanesAABB(planes, coll.bounds))
        {
            follow = true;
        }
            
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("beacon"))
        {
            follow = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("beacon"))
        {
            follow = true;
        }
    }

}
