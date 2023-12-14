using System;
using System.Drawing;
using System.Windows.Forms;
using GTA;
using GTA.Native;

public class TimeRelatedPop : Script
{

    public TimeRelatedPop()
    {
        Tick += OnTick;
    }

    private void OnTick(object sender, EventArgs e)
    {
        int hours = Function.Call<int>(Hash.GET_CLOCK_HOURS);
        float population = 1.0f;
        switch (hours)
        {
            case 0:
            case 1:
                population = 0.1f;
                break;
            case 2:
            case 3:
                population = 0.2f;
                break;
            case 4:
            case 5:
                population = 0.3f;
                break;
            case 6:
            case 7:
                population = 0.4f;
                break;
            case 8:
            case 9:
                population = 0.5f;
                break;
            case 10:
            case 11:
                population = 0.6f;
                break;
            case 12:
            case 13:
                population = 0.7f;
                break;
            case 14:
            case 15:
                population = 0.9f;
                break;
            case 16:
            case 17:
                population = 1.0f;
                break;
            case 18:
            case 19:
                population = 0.6f;
                break;
            case 20:
            case 21:
                population = 0.3f;
                break;
            case 22:
            case 23:
                population = 0.2f;
                break;
        }

        Function.Call(Hash.SET_PED_DENSITY_MULTIPLIER_THIS_FRAME, population);
        Function.Call(Hash.SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME, population);
        Function.Call(Hash.SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME, population);
        Function.Call(Hash.SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME, population);
    }
}