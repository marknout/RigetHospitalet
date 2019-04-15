using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventScript : MonoBehaviour
{
    public Camera cam;
    public LayerMask mask;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            //if (!Physics.Raycast(ray, out hit, Mathf.Infinity, obstacleMask))
            //{

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, mask))
            {
                TreeLeaves tl = hit.collider.GetComponent<TreeLeaves>();
                if (tl != null)
                {
                    tl.DoTheLeaves();
                }

                SeaSplash sp = hit.collider.GetComponent<SeaSplash>();
                if (sp != null)
                {
                    sp.DoTheRipple(hit.point);
                }

               DandilionScript ds = hit.collider.GetComponent<DandilionScript>();
                if (ds != null)
                {
                    ds.DoTheSeeds();
                }

                SmokeEnabler sm= hit.collider.GetComponent<SmokeEnabler>();
                if (sm != null)
                {
                    sm.DoTheSmoke();
                }
                SwitchSprite sw = hit.collider.GetComponent<SwitchSprite>();
                if (sw != null)
                {
                    sw.DoTheSwitch();
                }
            }
            //}
        }
    }
}
