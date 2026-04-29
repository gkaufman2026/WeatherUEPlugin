# Hello!
### Welcome to my Dynamic Weather and Day Time System made for Unreal Engine 5.7

![Starting Image](https://github.com/gkaufman2026/WeatherUEPlugin/blob/6a5ff2732c95bd962d0c3854311bc5935df97683/Images/RainforestV3.png)
<div align="center"> Rainforest by 3D Configuration (https://www.fab.com/listings/a6667192-5b12-451c-8941-1b0a7825c972)</div>

## Summary
Developed as a tool for artists and designers, encouraging quick iteration without the requirement for extensive coding knowledge. Whether being decoupled functionality for the Day Night Cycle or the Dynamic Weather System. Depending on desired functionality or visualization, data is handled in respective Data Tables, with a vast majority of options to create the desired experience for your game. But if more functionality is required, event-based functionality and hooks are already developed and available.

## Feature List
* AC_DayTime: Used as the central hub for how time gets produced in-game
    - Custom Start Time
    - Event-Based Incrementation: Completely decoupled and does not rely on tick at all!
    - Pause/Resume
    - Update Time Scale
    - Event Dispatchers for OnHourPassed, OnDayPassed, OnTimeUpdated
    - String Helper Functions (12/24 hour format)
    - Math Helper Functions (Get Passed Time in Hours or Minutes, Get Current Day Percentage, Get Duration In Seconds)

![Starting Image](https://github.com/gkaufman2026/WeatherUEPlugin/blob/6a5ff2732c95bd962d0c3854311bc5935df97683/Images/RainforestV3.png)
![Starting Image](https://github.com/gkaufman2026/WeatherUEPlugin/blob/6a5ff2732c95bd962d0c3854311bc5935df97683/Images/RainforestV3.png)
 
* BP_DayNightManager
    - Creates functions or events based on the Day Cycle Data Table for custom visual functionality
    - Rotates the Sun based on the Time Percentage
    - Update Text Renderers for Time & Cycle Stages
    - Using the Sky Atmosphere Component allows for a wide variety of parameters to be controlled and manipulated for the day cycle

![Starting Image](https://github.com/gkaufman2026/WeatherUEPlugin/blob/6a5ff2732c95bd962d0c3854311bc5935df97683/Images/RainforestV3.png)
![Starting Image](https://github.com/gkaufman2026/WeatherUEPlugin/blob/6a5ff2732c95bd962d0c3854311bc5935df97683/Images/RainforestV3.png)
 
* GS_Weather
    - Event hooks for AC_DayTime
* BP_WeatherController
    - Enabling/Disabling Randomization of Weather using events
    - Stores current and previous weather states for interpolation
    - Handles Creating/Clearing of weather state VFX (Niagara Particle System & Transform)
    - Offers Material Color, Scalar Parameters for Dynamic Material Instances (PLANS FOR TEXTURE AND VECTOR SUPPORT)
    - Creates functions or events based on the Weather Info Data Table for custom visual functionality
* BPL_Weather: Blueprint Function Library, possible helper functions that may be of use! 

##
