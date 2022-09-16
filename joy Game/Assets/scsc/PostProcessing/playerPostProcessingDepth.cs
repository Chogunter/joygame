using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class playerPostProcessingDepth : MonoBehaviour
{
    [SerializeField] PostProcessVolume postprocessvolume1;
    PostProcessProfile postprocessvolume1profile;
    DepthOfField postprocessvolume1profileDepth;
    Vignette postprocessvolume1profileVignette;

    [SerializeField] GameObject Player;
    Player_Hp playerhp;
    void Start()
    {
        playerhp = Player.GetComponent<Player_Hp>();
        postprocessvolume1profile = postprocessvolume1.profile;
        postprocessvolume1profile.TryGetSettings<DepthOfField>(out postprocessvolume1profileDepth);
        postprocessvolume1profile.TryGetSettings<Vignette>(out postprocessvolume1profileVignette);
    }



    RaycastHit hit;
    [SerializeField] float MaxDistance;
    [SerializeField] float discultime;
    [SerializeField] float time;
    [SerializeField] float diss;
    [SerializeField] float focus;
    float timelate;
    [SerializeField] float hptimeup;
    [SerializeField] float hptimedown;
    [SerializeField] float hpincrisis;
    [SerializeField] float culHp;
    [SerializeField] float intensityHp;

    void Update()
    {
        time += Time.deltaTime;
        timelate += Time.deltaTime;
        if (time > discultime)
        {
            time = 0;
            timelate = 0;
            diss = gethitdis();
        }
        focus = postprocessvolume1profileDepth.focusDistance.value;
        postprocessvolume1profileDepth.focusDistance.value = Mathf.Lerp(postprocessvolume1profileDepth.focusDistance.value, diss, timelate);
        culHp = playerhp.PlayerHp;
        if (culHp <= hpincrisis)
        {
            hptimeup += Time.deltaTime / 10;
            hptimedown = 0;
            postprocessvolume1profileVignette.intensity.value = Mathf.Lerp(postprocessvolume1profileVignette.intensity.value, intensityHp, hptimeup);
        }
        else if(postprocessvolume1profileVignette.intensity.value != 0)
        {
            hptimedown += Time.deltaTime / 10;
            hptimeup = 0;
            postprocessvolume1profileVignette.intensity.value = Mathf.Lerp(postprocessvolume1profileVignette.intensity.value, 0, hptimedown);
        }
        else
        {
            hptimeup = 0;
            hptimedown = 0;
        }
    }
    FloatParameter gethitdis()
    {
        float dissss;
        if (Physics.Raycast(transform.position, transform.forward, out hit, MaxDistance))
        {
            dissss = Vector3.Distance(transform.position, hit.point);
            FloatParameter aaa = new FloatParameter();
            aaa.value = dissss;
            return aaa;
        }
        dissss = MaxDistance;
        FloatParameter aaab = new FloatParameter();
        aaab.value = dissss;
        return aaab;
    }
}
