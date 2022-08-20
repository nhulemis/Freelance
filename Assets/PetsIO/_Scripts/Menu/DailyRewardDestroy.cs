using UnityEngine;

namespace PetsIO._Scripts.Menu
{
    public class DailyRewardDestroy : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int curDay = (int)System.DateTime.Now.Day;
            int oldDay = PlayerPrefs.GetInt("giftDay");

            if (curDay == oldDay)
            {
                Destroy(this.gameObject);
            }
        }

    }
}
