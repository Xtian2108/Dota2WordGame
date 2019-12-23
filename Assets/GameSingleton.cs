using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;


namespace BizzyBeeGames.WordGame
{
    public class GameSingleton : MonoBehaviour
    {

        private static GameSingleton _instance;
        public Sprite divisonActual;
        public Sprite[] divisiones;
        public Image rankTier;


        public float totales;
        public float completos;
        public int porcentajecompletado;
        public GameObject showvideo;

        public static GameSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<GameSingleton>();
                    if (_instance == null)
                    {
                        GameObject go = new GameObject();
                        go.name = typeof(GameSingleton).Name;
                        _instance = go.AddComponent<GameSingleton>();
                        DontDestroyOnLoad(go);
                    }
                }
                return _instance;
            }
        }

        // Use this for initialization
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {

            if (porcentajecompletado <= 10)
            {
                divisonActual = divisiones[0];
            }
            else if (porcentajecompletado > 10 && porcentajecompletado < 20)
            {
                divisonActual = divisiones[1];

            }
            else if (porcentajecompletado > 20 && porcentajecompletado < 30)
            {
                divisonActual = divisiones[2];

            }
            else if (porcentajecompletado > 30 && porcentajecompletado < 40)
            {
                divisonActual = divisiones[3];

            }
            else if (porcentajecompletado > 40 && porcentajecompletado < 50)
            {
                divisonActual = divisiones[4];

            }
            else if (porcentajecompletado > 50 && porcentajecompletado < 60)
            {
                divisonActual = divisiones[5];

            }
            else if (porcentajecompletado > 60 && porcentajecompletado < 70)
            {
                divisonActual = divisiones[6];

            }
            else if (porcentajecompletado > 70 && porcentajecompletado < 80)
            {
                divisonActual = divisiones[7];

            }
            else if (porcentajecompletado > 80 && porcentajecompletado < 90)
            {
                divisonActual = divisiones[8];
            }
            else if (porcentajecompletado > 90 && porcentajecompletado < 110)
            {
                divisonActual = divisiones[9];
            }

            rankTier.sprite = divisonActual;

            porcentajecompletado = Mathf.RoundToInt((float)completos / (float)totales * 100f);

        }

        public IEnumerator MostrarTutorial()
        {       
            showvideo.SetActive(true);
            yield return new WaitForSeconds(10f);
            showvideo.SetActive(false);
        }

    }
}
