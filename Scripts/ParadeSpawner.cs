using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParadeSpawner : MonoBehaviour
{
    public GameObject MusicNeMutlu, MusicSlavianka, MusicKizilOrdu, MusicRedAlert, BasicSoldier, PlaneFlyOver, Trucks, Flagger, Helis, MCamera, President;
    public float InfantrySpawnerTimer = 0f, PlaneSpawnerTimer = 0f, CamX = 15f, CamY = 0f, CamZoom = 60;
    public Camera MCam;
    public bool LookR = false, LookL = false, LookU = false, LookD = false, ZoomIn = false, ZoomOut = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.D) && CamY < 30f) {
            LookL = false;
            LookR = true;
        }
        if (Input.GetKeyDown(KeyCode.A) && CamY > -30f)
        {
            LookL = true;
            LookR = false;
        }
        if (Input.GetKeyDown(KeyCode.W) && CamX > 0f)
        {
            LookU = true;
            LookD = false;
        }
        if (Input.GetKeyDown(KeyCode.S) && CamX < 40f)
        {
            LookU = false;
            LookD = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && CamZoom > 10) {
            ZoomIn = true;
            ZoomOut = false;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && CamZoom < 60)
        {
            ZoomIn = false;
            ZoomOut = true;
        }
        /////////////////////////////////
        if (Input.GetKeyUp(KeyCode.D))
        {
            LookR = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            LookL = false;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            LookU = false;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            LookD = false;
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            ZoomIn = false;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            ZoomOut = false;
        }
        ////////////////////////////////
        if (CamX > 40f || CamX < 0f) {
            LookR = false;
            LookL = false;
        }
        if (CamY > 15f || CamY < -15f)
        {
            LookU = false;
            LookD = false;
        }
        if (CamZoom > 60f || CamZoom < 10f)
        {
            ZoomIn = false;
            ZoomOut = false;
        }
        ////////////////////////////////
        if (CamX > 40f) {
            CamX = 40f;
        }
        if (CamX < 0f)
        {
            CamX = 0f;
        }
        if (CamY > 30f)
        {
            CamY = 30f;
        }
        if (CamY < -30f)
        {
            CamY = -30f;
        }
        if (CamZoom > 60f)
        {
            CamZoom = 60f;
        }
        if (CamZoom < 10f)
        {
            CamZoom = 10f;
        }
        ////////////////////////////////
        if (LookL) {
            CamY -= 0.2f;
        }
        if (LookR)
        {
            CamY += 0.2f;
        }
        if (LookU)
        {
            CamX -= 0.2f;
        }
        if (LookD)
        {
            CamX += 0.2f;
        }
        if (ZoomIn) {
            CamZoom -= 0.2f;
        }
        if (ZoomOut)
        {
            CamZoom += 0.2f;
        }*/
        //////////////////////////////////
        /*MCamera.transform.rotation =  Quaternion.Euler(new Vector3(CamX, CamY, 0f));
        MCam.fieldOfView = CamZoom;*/
        InfantrySpawnerTimer -= Time.deltaTime;
        PlaneSpawnerTimer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Z) && InfantrySpawnerTimer <= 0f) {
            GameObject go =  Instantiate(BasicSoldier, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(go, 80f);
            InfantrySpawnerTimer = 10f;
        }
        if (Input.GetKeyDown(KeyCode.X) && InfantrySpawnerTimer <= 0f)
        {
            GameObject go = Instantiate(Trucks, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, -90, 0)));
            Destroy(go, 80f);
            InfantrySpawnerTimer = 20f;
        }
        if (Input.GetKeyDown(KeyCode.V) && InfantrySpawnerTimer <= 0f)
        {
            GameObject go = Instantiate(President, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 90, 0)));
            Destroy(go, 80f);
            InfantrySpawnerTimer = 30f;
        }
        if (Input.GetKeyDown(KeyCode.C) && InfantrySpawnerTimer <= 0f)
        {
            GameObject go = Instantiate(Flagger, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            Destroy(go, 80f);
            InfantrySpawnerTimer = 10f;
        }
        if (Input.GetKeyDown(KeyCode.N) && PlaneSpawnerTimer <= 0f)
        {
            GameObject go = Instantiate(PlaneFlyOver, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 90, 0)));
            Destroy(go, 2.8f);
            PlaneSpawnerTimer = 3f;
        }
        if (Input.GetKeyDown(KeyCode.M) && PlaneSpawnerTimer <= 0f)
        {
            GameObject go = Instantiate(Helis, new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
            Destroy(go, 7f);
            PlaneSpawnerTimer = 8f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            MusicNeMutlu.SetActive(false);
            MusicSlavianka.SetActive(false);
            MusicKizilOrdu.SetActive(false);
            MusicRedAlert.SetActive(false);
            MusicNeMutlu.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MusicNeMutlu.SetActive(false);
            MusicSlavianka.SetActive(false);
            MusicKizilOrdu.SetActive(false);
            MusicRedAlert.SetActive(false);
            MusicSlavianka.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MusicNeMutlu.SetActive(false);
            MusicSlavianka.SetActive(false);
            MusicKizilOrdu.SetActive(false);
            MusicRedAlert.SetActive(false);
            MusicKizilOrdu.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MusicNeMutlu.SetActive(false);
            MusicSlavianka.SetActive(false);
            MusicKizilOrdu.SetActive(false);
            MusicRedAlert.SetActive(false);
            MusicRedAlert.SetActive(true);
        }
    }
}
