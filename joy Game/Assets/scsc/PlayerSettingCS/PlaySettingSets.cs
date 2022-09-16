using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PlaySettingSets : MonoBehaviour
{
    [SerializeField] string optionSavePath;

    [SerializeField] Slider mousedegreeSlider;
    [SerializeField] Text mousedegree_Text;
    [SerializeField] float mousedegree_; //3
    [SerializeField] Slider ViewingAnglelider;
    [SerializeField] Text ViewingAngle_Text;
    [SerializeField] float ViewingAngle_; //60
    [SerializeField] Slider Volumelider;
    [SerializeField] Text Volume_text;
    [SerializeField] float Volume_; //75
    [SerializeField] Text TutorialOntext;
    [SerializeField] bool TutorialOn_; //true

    string check = "✔";
    string off = "✘";
    string AppPATH;
    string path;

    public class OptionSaves
    {
        public float mousedegree;
        public float ViewingAngle;
        public float Volume;
        public bool TutorialOn;
    }

    private void OnEnable()
    {
        Loads();
    }

    void Loads()
    {
        AppPATH = Application.persistentDataPath;
        PlayerPrefs.SetString("OptionPath", optionSavePath);
        path = Path.Combine(AppPATH, optionSavePath, "Option.json");
        FileInfo fi = new FileInfo(path);
        if (!fi.Exists)
        {
            return;
            //Directory.CreateDirectory(Path.Combine(AppPATH, optionSavePath));
        }
        string saves = File.ReadAllText(path);
        OptionSaves saveclass = JsonUtility.FromJson<OptionSaves>(saves);

        mousedegreeSlider.value = saveclass.mousedegree;
        Volumelider.value = saveclass.Volume;
        TutorialOn_ = saveclass.TutorialOn;
        ViewingAnglelider.value = saveclass.ViewingAngle;

        if (TutorialOn_)
        {
            TutorialOntext.text = check;
        }
        else
        {
            TutorialOntext.text = off;
        }
    }

    public void Save()
    {
        AppPATH = Application.persistentDataPath;
        PlayerPrefs.SetString("OptionPath", optionSavePath);
        path = Path.Combine(AppPATH, optionSavePath, "Option.json");
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(Path.Combine(AppPATH, optionSavePath));
        }
        OptionSaves saveclass = new OptionSaves();

        saveclass.mousedegree = mousedegree_;
        saveclass.Volume = Volume_;
        saveclass.TutorialOn = TutorialOn_;
        saveclass.ViewingAngle = ViewingAngle_;

        string finalsaves = JsonUtility.ToJson(saveclass, true);
        File.WriteAllText(path, finalsaves);

    }

    private void Update()
    {
        mousedegree_ = Mathf.Round(mousedegreeSlider.value * 10f) * 0.1f;
        ViewingAngle_ = Mathf.Round(ViewingAnglelider.value * 10f) * 0.1f;
        Volume_ = Mathf.Round(Volumelider.value * 10f) * 0.1f;

        mousedegree_Text.text = mousedegree_.ToString();
        ViewingAngle_Text.text = ViewingAngle_.ToString();
        Volume_text.text = Volume_.ToString();
    }


    public void TutorialCheck()
    {
        TutorialOn_ = !TutorialOn_;
        if (TutorialOn_)
        {
            TutorialOntext.text = check;
        }
        else
        {
            TutorialOntext.text = off;
        }
    }

}
