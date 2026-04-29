# Hello!
### Welcome to my Dynamic Weather and Day Time System made for Unreal Engine 5.7

![Starting Image](https://github.com/gkaufman2026/WeatherUEPlugin/blob/6a5ff2732c95bd962d0c3854311bc5935df97683/Images/RainforestV3.png)
<div align="center"> Rainforest by 3D Configuration (https://www.fab.com/listings/a6667192-5b12-451c-8941-1b0a7825c972)</div>

## Summary
Developed as a tool for artists and designers, encouraging quick iteration without the requirement for extensive coding knowledge. Whether being decoupled functionality for the Day Night Cycle or the Dynamic Weather System. Depending on desired functionality or visualization, data is handled in respective Data Tables, with a vast majority of options to create the desired experience for your game. But if more functionality is required, event-based functionality and hooks are already developed and available.

## Feature List
* BPL_Weather: Blueprint Function Library, possible helper functions that may be of use! 
* AC_DayTime: Used as the central hub for how time gets produced in-game
    - Custom Start Time
    - Event-Based Incrementation: Completely decoupled and does not rely on tick at all!
    - Pause/Resume
    - Update Time Scale
    - Event Dispatchers for OnHourPassed, OnDayPassed, OnTimeUpdated
    - String Helper Functions (12/24 hour format)
    - Math Helper Functions (Get Passed Time in Hours or Minutes, Get Current Day Percentage, Get Duration In Seconds) 
* BP_DayNightManager
    - Creates functions or events based on the Day Cycle Data Table for custom visual functionality
    - Rotates the Sun based on the Time Percentage
    - Update Text Renderers for Time & Cycle Stages
    - Using the Sky Atmosphere Component allows for a wide variety of parameters to be controlled and manipulated for the day cycle
  
![Day Night Cycle](https://github.com/gkaufman2026/WeatherUEPlugin/blob/25b9564cec1388118dbcac979abdaabd4e33c123/Images/DayNightCycle.gif)
![Day Night Data Table](https://github.com/gkaufman2026/WeatherUEPlugin/blob/25b9564cec1388118dbcac979abdaabd4e33c123/Images/DT_DayCycle.png)

* GS_Weather
    - Event hooks for AC_DayTime
* BP_WeatherController
    - Enabling/Disabling Randomization of Weather using events
    - Stores current and previous weather states for interpolation
    - Handles Creating/Clearing of weather state VFX (Niagara Particle System & Transform)
    - Offers Material Color, Scalar Parameters for Dynamic Material Instances (PLANS FOR TEXTURE AND VECTOR SUPPORT)
    - Creates functions or events based on the Weather Info Data Table for custom visual functionality
 
![Weather](https://github.com/gkaufman2026/WeatherUEPlugin/blob/c752d645f8e783f3d01a604bc69b815c8ce8373d/Images/Weather.gif)
![Weather Data Table Rain](https://github.com/gkaufman2026/WeatherUEPlugin/blob/9b52af41eb812893c60811423f8c55186c622ed7/Images/DT_WeatherInfo_Rain.png)
![Weather Data Table Thunder](https://github.com/gkaufman2026/WeatherUEPlugin/blob/9b52af41eb812893c60811423f8c55186c622ed7/Images/DT_WeatherInfo_Thunder.png)
![Weather Control Options](https://github.com/gkaufman2026/WeatherUEPlugin/blob/9b52af41eb812893c60811423f8c55186c622ed7/Images/Weather%20Controller%20Options.png)
