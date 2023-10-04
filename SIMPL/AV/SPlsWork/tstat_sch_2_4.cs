using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace CrestronModule_TSTAT_SCH_2_4
{
    public class CrestronModuleClass_TSTAT_SCH_2_4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput WEEKDAY_WAKE;
        Crestron.Logos.SplusObjects.DigitalInput WEEKDAY_LEAVE;
        Crestron.Logos.SplusObjects.DigitalInput WEEKDAY_RETURN;
        Crestron.Logos.SplusObjects.DigitalInput WEEKDAY_SLEEP;
        Crestron.Logos.SplusObjects.DigitalInput WEEKEND_WAKE;
        Crestron.Logos.SplusObjects.DigitalInput WEEKEND_LEAVE;
        Crestron.Logos.SplusObjects.DigitalInput WEEKEND_RETURN;
        Crestron.Logos.SplusObjects.DigitalInput WEEKEND_SLEEP;
        Crestron.Logos.SplusObjects.DigitalInput AWAY;
        Crestron.Logos.SplusObjects.DigitalInput TIME_UP;
        Crestron.Logos.SplusObjects.DigitalInput TIME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput HOUR_UP;
        Crestron.Logos.SplusObjects.DigitalInput HOUR_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput MINUTE_UP;
        Crestron.Logos.SplusObjects.DigitalInput MINUTE_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput HEAT_SETPOINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput HEAT_SETPOINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput COOL_SETPOINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput COOL_SETPOINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput SLAB_SETPOINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput SLAB_SETPOINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_SETPOINT_UP;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_SETPOINT_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput REMOVE_SCHEDULE;
        Crestron.Logos.SplusObjects.DigitalInput RESET_SCHEDULES;
        Crestron.Logos.SplusObjects.DigitalInput TEMP_SCALE;
        Crestron.Logos.SplusObjects.DigitalInput HALF_DEGREE_C_STEPS;
        Crestron.Logos.SplusObjects.DigitalInput RUN_PROGRAM;
        Crestron.Logos.SplusObjects.DigitalInput RUN_AWAY;
        Crestron.Logos.SplusObjects.DigitalInput RUN_HOLD;
        Crestron.Logos.SplusObjects.DigitalInput SINGLE_BUTTON_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput SINGLE_BUTTON_ADJUST;
        Crestron.Logos.SplusObjects.DigitalInput USE_DEFAULT_SCHEDULE_TIMES;
        Crestron.Logos.SplusObjects.DigitalInput SUNDAY_NIGHT_IS_WEEKDAY;
        Crestron.Logos.SplusObjects.DigitalInput FRIDAY_NIGHT_IS_WEEKEND;
        Crestron.Logos.SplusObjects.DigitalInput AWAYDAY_INC;
        Crestron.Logos.SplusObjects.DigitalInput AWAYDAY_DEC;
        Crestron.Logos.SplusObjects.DigitalInput AWAYSCHED_INC;
        Crestron.Logos.SplusObjects.DigitalInput SLAB_SP_ENABLED;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_MODE_ENABLED;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_HEAT_SP;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_COOL_SP;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_SLAB_SP;
        Crestron.Logos.SplusObjects.AnalogInput CURRENT_AUTO_SP;
        Crestron.Logos.SplusObjects.AnalogInput INSTANCE_ID;
        Crestron.Logos.SplusObjects.StringInput PATH__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogInput SCHEDULEDHEATSETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput SCHEDULEDCOOLSETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput SCHEDULEDSLABSETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput SCHEDULEDAUTOSETPOINT;
        Crestron.Logos.SplusObjects.AnalogInput DEADBAND;
        Crestron.Logos.SplusObjects.DigitalOutput SCHEDULE_DUE;
        Crestron.Logos.SplusObjects.DigitalOutput PM_FB;
        Crestron.Logos.SplusObjects.DigitalOutput RUN;
        Crestron.Logos.SplusObjects.DigitalOutput AWAY_MODE_FB;
        Crestron.Logos.SplusObjects.DigitalOutput HOLD_MODE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_SCHEDULE;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_DAYOFWEEK;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SCHEDULE_TIME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SINGLE_BUTTON_SELECT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput SINGLE_BUTTON_ADJUST__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AWAY_SCHEDULE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AWAY_DATE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AWAY_SCHEDULE_SHORT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput AWAY_DATE_SHORT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SCHEDULE_SETPOINT__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SETPOINT;
        SCHEDULE [] G_SCHED;
        ushort G_ISINGLEBUTTONSELECTCAT = 0;
        ushort G_ISINGLEBUTTONSELECTSCHED = 0;
        ushort G_ISINGLEBUTTONADJUSTDIR = 0;
        ushort G_BIGNORESINGLEBUTTONRELEASE = 0;
        uint G_TODAYJDAY = 0;
        private uint CREATEDATEL (  SplusExecutionContext __context__, ushort IMONTH , ushort IDAY , ushort IYEAR ) 
            { 
            
            __context__.SourceCodeLine = 294;
            return (uint)( (((IMONTH * 1000000) + (IDAY * 10000)) + IYEAR)) ; 
            
            }
            
        private ushort GETDAYFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 300;
            return (ushort)( (Mod( LDATE , 1000000 ) / 10000)) ; 
            
            }
            
        private ushort GETMONTHFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 306;
            return (ushort)( (LDATE / 1000000)) ; 
            
            }
            
        private ushort GETYEARFROMLONG (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            
            __context__.SourceCodeLine = 312;
            return (ushort)( Mod( LDATE , 10000 )) ; 
            
            }
            
        private uint GETJDAY (  SplusExecutionContext __context__, uint LDATE ) 
            { 
            ushort PRVYEAR = 0;
            
            ushort LEAPYEAR = 0;
            
            ushort TEMPYEAR = 0;
            
            ushort TEMPMONTH = 0;
            
            ushort TEMPDAY = 0;
            
            ushort JDAY = 0;
            
            ushort LEAPS = 0;
            
            
            __context__.SourceCodeLine = 327;
            TEMPDAY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 328;
            TEMPMONTH = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 329;
            TEMPYEAR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( LDATE ) ) ) ; 
            __context__.SourceCodeLine = 332;
            PRVYEAR = (ushort) ( (TEMPYEAR - 1) ) ; 
            __context__.SourceCodeLine = 333;
            LEAPS = (ushort) ( ((((PRVYEAR / 4) - (PRVYEAR / 100)) + (PRVYEAR / 400)) - 484) ) ; 
            __context__.SourceCodeLine = 336;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 4 ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 100 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 400 ) == 0) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 337;
                LEAPYEAR = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 339;
                LEAPYEAR = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 341;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)TEMPMONTH);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 344;
                        JDAY = (ushort) ( TEMPDAY ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 346;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , (28 + LEAPYEAR) ) ) ; 
                        __context__.SourceCodeLine = 347;
                        JDAY = (ushort) ( (TEMPDAY + 31) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 350;
                        JDAY = (ushort) ( (TEMPDAY + 59) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 352;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 353;
                        JDAY = (ushort) ( (TEMPDAY + 90) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 356;
                        JDAY = (ushort) ( (TEMPDAY + 120) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 358;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 359;
                        JDAY = (ushort) ( (TEMPDAY + 151) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 362;
                        JDAY = (ushort) ( (TEMPDAY + 181) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                        {
                        __context__.SourceCodeLine = 364;
                        JDAY = (ushort) ( (TEMPDAY + 212) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 366;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 367;
                        JDAY = (ushort) ( (TEMPDAY + 243) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                        {
                        __context__.SourceCodeLine = 370;
                        JDAY = (ushort) ( (TEMPDAY + 273) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 372;
                        TEMPDAY = (ushort) ( Functions.Min( TEMPDAY , 30 ) ) ; 
                        __context__.SourceCodeLine = 373;
                        JDAY = (ushort) ( (TEMPDAY + 304) ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                        {
                        __context__.SourceCodeLine = 376;
                        JDAY = (ushort) ( (TEMPDAY + 334) ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 379;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (LEAPYEAR == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMPMONTH != 1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (TEMPMONTH != 2) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 380;
                JDAY = (ushort) ( (JDAY + 1) ) ; 
                }
            
            __context__.SourceCodeLine = 382;
            JDAY = (ushort) ( ((JDAY + ((PRVYEAR - 1996) * 365)) + LEAPS) ) ; 
            __context__.SourceCodeLine = 384;
            return (uint)( JDAY) ; 
            
            }
            
        private uint GETGDATE (  SplusExecutionContext __context__, uint JDAY ) 
            { 
            uint TEMPDAY = 0;
            
            uint TEMPMONTH = 0;
            
            uint TEMPYEAR = 0;
            
            uint REMCENTS = 0;
            
            uint REMQUADS = 0;
            
            uint REMYEARS = 0;
            
            uint LEAPYEAR = 0;
            
            
            __context__.SourceCodeLine = 401;
            TEMPMONTH = (uint) ( 0 ) ; 
            __context__.SourceCodeLine = 403;
            REMCENTS = (uint) ( (JDAY / 36524) ) ; 
            __context__.SourceCodeLine = 404;
            JDAY = (uint) ( (JDAY - (36524 * REMCENTS)) ) ; 
            __context__.SourceCodeLine = 405;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 406;
                TEMPYEAR = (uint) ( (1996 + (100 * REMCENTS)) ) ; 
                __context__.SourceCodeLine = 407;
                TEMPDAY = (uint) ( 365 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 410;
                REMQUADS = (uint) ( (JDAY / 1461) ) ; 
                __context__.SourceCodeLine = 411;
                JDAY = (uint) ( (JDAY - (1461 * REMQUADS)) ) ; 
                __context__.SourceCodeLine = 412;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 413;
                    TEMPYEAR = (uint) ( ((1996 + (100 * REMCENTS)) + (4 * REMQUADS)) ) ; 
                    __context__.SourceCodeLine = 414;
                    TEMPDAY = (uint) ( (365 + 1) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 417;
                    REMYEARS = (uint) ( (JDAY / 365) ) ; 
                    __context__.SourceCodeLine = 418;
                    JDAY = (uint) ( (JDAY - (365 * REMYEARS)) ) ; 
                    __context__.SourceCodeLine = 419;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( JDAY < 1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 420;
                        TEMPYEAR = (uint) ( (((1996 + (100 * REMCENTS)) + (4 * REMQUADS)) + REMYEARS) ) ; 
                        __context__.SourceCodeLine = 422;
                        TEMPDAY = (uint) ( 365 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 425;
                        TEMPYEAR = (uint) ( ((((1 + 1996) + (100 * REMCENTS)) + (4 * REMQUADS)) + REMYEARS) ) ; 
                        __context__.SourceCodeLine = 427;
                        TEMPDAY = (uint) ( JDAY ) ; 
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 434;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 4 ) == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 100 ) != 0) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Mod( TEMPYEAR , 400 ) == 0) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 435;
                LEAPYEAR = (uint) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 437;
                LEAPYEAR = (uint) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 439;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY < 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 441;
                TEMPMONTH = (uint) ( 12 ) ; 
                __context__.SourceCodeLine = 442;
                TEMPDAY = (uint) ( 31 ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 444;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= 31 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 446;
                    TEMPMONTH = (uint) ( 1 ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 448;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 59) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 450;
                        TEMPMONTH = (uint) ( 2 ) ; 
                        __context__.SourceCodeLine = 451;
                        TEMPDAY = (uint) ( (TEMPDAY - 31) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 453;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 90) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 455;
                            TEMPMONTH = (uint) ( 3 ) ; 
                            __context__.SourceCodeLine = 456;
                            TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 59) ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 458;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 120) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 460;
                                TEMPMONTH = (uint) ( 4 ) ; 
                                __context__.SourceCodeLine = 461;
                                TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 90) ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 463;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 151) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 465;
                                    TEMPMONTH = (uint) ( 5 ) ; 
                                    __context__.SourceCodeLine = 466;
                                    TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 120) ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 468;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 181) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 470;
                                        TEMPMONTH = (uint) ( 6 ) ; 
                                        __context__.SourceCodeLine = 471;
                                        TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 151) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 473;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 212) ))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 475;
                                            TEMPMONTH = (uint) ( 7 ) ; 
                                            __context__.SourceCodeLine = 476;
                                            TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 181) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 478;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 243) ))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 480;
                                                TEMPMONTH = (uint) ( 8 ) ; 
                                                __context__.SourceCodeLine = 481;
                                                TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 212) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 483;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 273) ))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 485;
                                                    TEMPMONTH = (uint) ( 9 ) ; 
                                                    __context__.SourceCodeLine = 486;
                                                    TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 243) ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 488;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 304) ))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 490;
                                                        TEMPMONTH = (uint) ( 10 ) ; 
                                                        __context__.SourceCodeLine = 491;
                                                        TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 273) ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 493;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( TEMPDAY <= (LEAPYEAR + 334) ))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 495;
                                                            TEMPMONTH = (uint) ( 11 ) ; 
                                                            __context__.SourceCodeLine = 496;
                                                            TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 304) ) ; 
                                                            } 
                                                        
                                                        else 
                                                            { 
                                                            __context__.SourceCodeLine = 500;
                                                            TEMPMONTH = (uint) ( 12 ) ; 
                                                            __context__.SourceCodeLine = 501;
                                                            TEMPDAY = (uint) ( ((TEMPDAY - LEAPYEAR) - 334) ) ; 
                                                            } 
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 504;
            return (uint)( CREATEDATEL( __context__ , (ushort)( Functions.LowWord( (uint)( TEMPMONTH ) ) ) , (ushort)( Functions.LowWord( (uint)( TEMPDAY ) ) ) , (ushort)( Functions.LowWord( (uint)( TEMPYEAR ) ) ) )) ; 
            
            }
            
        private CrestronString GETFILENAME (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SFILENAME;
            SFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            
            __context__.SourceCodeLine = 512;
            SFILENAME  .UpdateValue ( PATH__DOLLAR__ + "tstat_" + Functions.ItoA (  (int) ( INSTANCE_ID  .UshortValue ) ) + ".dat"  ) ; 
            __context__.SourceCodeLine = 514;
            return ( SFILENAME ) ; 
            
            }
            
        private ushort ROUNDEDDIVIDE (  SplusExecutionContext __context__, ushort IOPERAND , ushort IDIVISOR ) 
            { 
            ushort IQUOTIENT = 0;
            ushort IREMAINDER = 0;
            
            
            __context__.SourceCodeLine = 536;
            IQUOTIENT = (ushort) ( (IOPERAND / IDIVISOR) ) ; 
            __context__.SourceCodeLine = 537;
            IREMAINDER = (ushort) ( Mod( IOPERAND , IDIVISOR ) ) ; 
            __context__.SourceCodeLine = 539;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IREMAINDER < (IDIVISOR / 2) ))  ) ) 
                {
                __context__.SourceCodeLine = 540;
                return (ushort)( IQUOTIENT) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 542;
                return (ushort)( (IQUOTIENT + 1)) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETRAWTEMP (  SplusExecutionContext __context__, ushort ITEMPSCALE , ushort ISCALEDTEMP ) 
            { 
            
            __context__.SourceCodeLine = 560;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMPSCALE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 562;
                return (ushort)( ROUNDEDDIVIDE( __context__ , (ushort)( ((ISCALEDTEMP - 320) * 5) ) , (ushort)( 9 ) )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 565;
                return (ushort)( ISCALEDTEMP) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETSCALEDTEMP (  SplusExecutionContext __context__, ushort ITEMPSCALE , ushort IRAWTEMP ) 
            { 
            ushort ISCALEDTEMP = 0;
            
            
            __context__.SourceCodeLine = 588;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMPSCALE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 590;
                ISCALEDTEMP = (ushort) ( (ROUNDEDDIVIDE( __context__ , (ushort)( (IRAWTEMP * 9) ) , (ushort)( 5 ) ) + 320) ) ; 
                __context__.SourceCodeLine = 591;
                return (ushort)( (ROUNDEDDIVIDE( __context__ , (ushort)( ISCALEDTEMP ) , (ushort)( 10 ) ) * 10)) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 595;
                if ( Functions.TestForTrue  ( ( HALF_DEGREE_C_STEPS  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 596;
                    return (ushort)( (ROUNDEDDIVIDE( __context__ , (ushort)( IRAWTEMP ) , (ushort)( 5 ) ) * 5)) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 598;
                    return (ushort)( (ROUNDEDDIVIDE( __context__ , (ushort)( IRAWTEMP ) , (ushort)( 10 ) ) * 10)) ; 
                    }
                
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString GETDISPLAYTEMP (  SplusExecutionContext __context__, ushort ITEMPSCALE , ushort IRAWTEMP ) 
            { 
            short ISCALEDTEMP = 0;
            
            CrestronString STEMP;
            STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
            
            ushort IINTPART = 0;
            ushort IFRACPART = 0;
            
            
            __context__.SourceCodeLine = 624;
            ISCALEDTEMP = (short) ( GETSCALEDTEMP( __context__ , (ushort)( ITEMPSCALE ) , (ushort)( IRAWTEMP ) ) ) ; 
            __context__.SourceCodeLine = 626;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITEMPSCALE == 0) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ITEMPSCALE == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (HALF_DEGREE_C_STEPS  .Value == 0) )) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 628;
                return ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( ISCALEDTEMP ) , (ushort)( 10 ) ) ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 633;
                IINTPART = (ushort) ( (ISCALEDTEMP / 10) ) ; 
                __context__.SourceCodeLine = 634;
                IFRACPART = (ushort) ( Mod( ISCALEDTEMP , 10 ) ) ; 
                __context__.SourceCodeLine = 636;
                if ( Functions.TestForTrue  ( ( IFRACPART)  ) ) 
                    {
                    __context__.SourceCodeLine = 637;
                    STEMP  .UpdateValue ( Functions.ItoA (  (int) ( IINTPART ) ) + "." + Functions.ItoA (  (int) ( IFRACPART ) )  ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 639;
                    STEMP  .UpdateValue ( Functions.ItoA (  (int) ( IINTPART ) ) + ".0"  ) ; 
                    }
                
                __context__.SourceCodeLine = 641;
                return ( STEMP ) ; 
                } 
            
            
            return ""; // default return value (none specified in module)
            }
            
        private ushort GETAUTOSETPOINT (  SplusExecutionContext __context__, ushort ITEMPSCALE , ushort ISCHEDULE ) 
            { 
            ushort IQUOTIENT = 0;
            ushort IREMAINDER = 0;
            ushort IHEAT = 0;
            ushort ICOOL = 0;
            
            
            __context__.SourceCodeLine = 652;
            IHEAT = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( ITEMPSCALE ) , (ushort)( G_SCHED[ ISCHEDULE ].ISETPOINT[ 0 ] ) ) ) ; 
            __context__.SourceCodeLine = 653;
            ICOOL = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( ITEMPSCALE ) , (ushort)( G_SCHED[ ISCHEDULE ].ISETPOINT[ 1 ] ) ) ) ; 
            __context__.SourceCodeLine = 654;
            IQUOTIENT = (ushort) ( ((IHEAT + ICOOL) / 20) ) ; 
            __context__.SourceCodeLine = 655;
            IREMAINDER = (ushort) ( Mod( (IHEAT + ICOOL) , 20 ) ) ; 
            __context__.SourceCodeLine = 661;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IREMAINDER < 10 ))  ) ) 
                {
                __context__.SourceCodeLine = 662;
                return (ushort)( (IQUOTIENT * 10)) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 664;
                return (ushort)( ((IQUOTIENT + 1) * 10)) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort ADJUSTTEMP (  SplusExecutionContext __context__, ushort ITEMPSCALE , short IRAWTEMP , ushort IDIR , short IMINRAWTEMP , short IMAXRAWTEMP ) 
            { 
            short IADJUSTEDRAWTEMP = 0;
            
            ushort ITEMPINDEGF = 0;
            
            ushort IADJUST = 0;
            
            
            __context__.SourceCodeLine = 689;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ITEMPSCALE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 693;
                ITEMPINDEGF = (ushort) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( IRAWTEMP ) ) ) , (ushort)( 10 ) ) ) ; 
                __context__.SourceCodeLine = 695;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIR == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 696;
                    ITEMPINDEGF = (ushort) ( (ITEMPINDEGF + 1) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 697;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIR == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 698;
                        ITEMPINDEGF = (ushort) ( (ITEMPINDEGF - 1) ) ; 
                        }
                    
                    }
                
                __context__.SourceCodeLine = 700;
                IADJUSTEDRAWTEMP = (short) ( GETRAWTEMP( __context__ , (ushort)( 0 ) , (ushort)( (ITEMPINDEGF * 10) ) ) ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 705;
                if ( Functions.TestForTrue  ( ( HALF_DEGREE_C_STEPS  .Value)  ) ) 
                    {
                    __context__.SourceCodeLine = 706;
                    IADJUST = (ushort) ( 5 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 708;
                    IADJUST = (ushort) ( 10 ) ; 
                    }
                
                __context__.SourceCodeLine = 710;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIR == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 711;
                    IADJUSTEDRAWTEMP = (short) ( (IRAWTEMP + IADJUST) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 712;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDIR == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 713;
                        IADJUSTEDRAWTEMP = (short) ( (IRAWTEMP - IADJUST) ) ; 
                        }
                    
                    }
                
                } 
            
            __context__.SourceCodeLine = 717;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IADJUSTEDRAWTEMP > IMAXRAWTEMP ))  ) ) 
                {
                __context__.SourceCodeLine = 718;
                return (ushort)( IMAXRAWTEMP) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 719;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IADJUSTEDRAWTEMP < IMINRAWTEMP ))  ) ) 
                    {
                    __context__.SourceCodeLine = 720;
                    return (ushort)( IMINRAWTEMP) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 722;
                    return (ushort)( IADJUSTEDRAWTEMP) ; 
                    }
                
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private CrestronString GETDISPLAYTIME (  SplusExecutionContext __context__, short IHOUR , ushort IMINUTE ) 
            { 
            ushort IDISPLAYHOUR = 0;
            
            CrestronString STIME;
            STIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8, this );
            
            
            __context__.SourceCodeLine = 740;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IHOUR == -1))  ) ) 
                { 
                __context__.SourceCodeLine = 742;
                return ( "--:--" ) ; 
                } 
            
            __context__.SourceCodeLine = 745;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR > 23 ))  ) ) 
                {
                __context__.SourceCodeLine = 746;
                IHOUR = (short) ( (IHOUR - 24) ) ; 
                }
            
            __context__.SourceCodeLine = 748;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IHOUR , 12 ) == 0))  ) ) 
                {
                __context__.SourceCodeLine = 749;
                IDISPLAYHOUR = (ushort) ( 12 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 751;
                IDISPLAYHOUR = (ushort) ( Mod( IHOUR , 12 ) ) ; 
                }
            
            __context__.SourceCodeLine = 753;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHOUR < 12 ))  ) ) 
                {
                __context__.SourceCodeLine = 754;
                MakeString ( STIME , "{0,2:d}:{1:d2} AM", (short)IDISPLAYHOUR, (short)IMINUTE) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 756;
                MakeString ( STIME , "{0,2:d}:{1:d2} PM", (short)IDISPLAYHOUR, (short)IMINUTE) ; 
                }
            
            __context__.SourceCodeLine = 758;
            return ( STIME ) ; 
            
            }
            
        
        private ushort DAYTYPE (  SplusExecutionContext __context__, ushort IDAY ) 
            { 
            
            __context__.SourceCodeLine = 790;
            if ( Functions.TestForTrue  ( ( Mod( IDAY , 6 ))  ) ) 
                {
                __context__.SourceCodeLine = 791;
                return (ushort)( 0) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 793;
                return (ushort)( 1) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETSCHEDULEMINUTES (  SplusExecutionContext __context__, SCHEDULE SCHED ) 
            { 
            
            __context__.SourceCodeLine = 811;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCHED.IHOUR != -1))  ) ) 
                {
                __context__.SourceCodeLine = 812;
                return (ushort)( ((SCHED.IHOUR * 60) + SCHED.IMINUTE)) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 814;
                return (ushort)( 9999) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort ISSCHEDULEBEFORETIME (  SplusExecutionContext __context__, SCHEDULE SCHED , ushort ICOMPARETIMEINMINUTES ) 
            { 
            ushort ISCHEDTIMEINMINUTES = 0;
            
            
            __context__.SourceCodeLine = 836;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SCHED.IHOUR != -1))  ) ) 
                { 
                __context__.SourceCodeLine = 838;
                ISCHEDTIMEINMINUTES = (ushort) ( GETSCHEDULEMINUTES( __context__ , SCHED ) ) ; 
                __context__.SourceCodeLine = 840;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICOMPARETIMEINMINUTES >= ISCHEDTIMEINMINUTES ))  ) ) 
                    {
                    __context__.SourceCodeLine = 841;
                    return (ushort)( 1) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 844;
            return (ushort)( 0) ; 
            
            }
            
        private ushort GETSLEEPSCHEDULE (  SplusExecutionContext __context__, ushort IDAY ) 
            { 
            ushort IDAYTYPE = 0;
            
            
            __context__.SourceCodeLine = 864;
            IDAYTYPE = (ushort) ( DAYTYPE( __context__ , (ushort)( IDAY ) ) ) ; 
            __context__.SourceCodeLine = 866;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYTYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 868;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FRIDAY_NIGHT_IS_WEEKEND  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (IDAY == 5) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 869;
                    return (ushort)( 7) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 871;
                    return (ushort)( 3) ; 
                    }
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 875;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( SUNDAY_NIGHT_IS_WEEKDAY  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (IDAY == 0) )) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 876;
                    return (ushort)( 3) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 878;
                    return (ushort)( 7) ; 
                    }
                
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort DOESSCHEDULEOCCURONDAY (  SplusExecutionContext __context__, ushort ISCHEDULE , ushort IDAY ) 
            { 
            ushort IDAYTYPE = 0;
            
            
            __context__.SourceCodeLine = 907;
            IDAYTYPE = (ushort) ( DAYTYPE( __context__ , (ushort)( IDAY ) ) ) ; 
            __context__.SourceCodeLine = 909;
            switch ((int)ISCHEDULE)
            
                { 
                case 0 : 
                case 1 : 
                case 2 : 
                
                    {
                    __context__.SourceCodeLine = 914;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYTYPE == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 915;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 917;
                        return (ushort)( 0) ; 
                        }
                    
                    }
                
                goto case 4 ;
                case 4 : 
                goto case 5 ;
                case 5 : 
                goto case 6 ;
                case 6 : 
                
                    {
                    __context__.SourceCodeLine = 922;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYTYPE == 1))  ) ) 
                        {
                        __context__.SourceCodeLine = 923;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 925;
                        return (ushort)( 0) ; 
                        }
                    
                    }
                
                goto case 3 ;
                case 3 : 
                
                    {
                    __context__.SourceCodeLine = 928;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETSLEEPSCHEDULE( __context__ , (ushort)( IDAY ) ) == 3))  ) ) 
                        {
                        __context__.SourceCodeLine = 929;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 931;
                        return (ushort)( 0) ; 
                        }
                    
                    }
                
                goto case 7 ;
                case 7 : 
                
                    {
                    __context__.SourceCodeLine = 934;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETSLEEPSCHEDULE( __context__ , (ushort)( IDAY ) ) == 7))  ) ) 
                        {
                        __context__.SourceCodeLine = 935;
                        return (ushort)( 1) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 937;
                        return (ushort)( 0) ; 
                        }
                    
                    }
                
                break;
                } 
                
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort GETCURRENTSCHEDULE (  SplusExecutionContext __context__, ushort IHOUR , ushort IMINUTE , ushort IDAY ) 
            { 
            ushort IPREVIOUSDAY = 0;
            
            ushort [] ISCHEDTOTEST;
            ISCHEDTOTEST  = new ushort[ 4 ];
            
            ushort IPREVDAYSLEEPSCHED = 0;
            
            ushort IDAYTYPE = 0;
            
            ushort ICURRENTTIMEINMINUTES = 0;
            
            
            __context__.SourceCodeLine = 966;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 0 ].IHOUR == -1) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 1 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 2 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 3 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 4 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 5 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 6 ].IHOUR == -1) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (G_SCHED[ 7 ].IHOUR == -1) )) ))  ) ) 
                {
                __context__.SourceCodeLine = 974;
                return (ushort)( 65535) ; 
                }
            
            __context__.SourceCodeLine = 976;
            ICURRENTTIMEINMINUTES = (ushort) ( ((IHOUR * 60) + IMINUTE) ) ; 
            __context__.SourceCodeLine = 977;
            IDAYTYPE = (ushort) ( DAYTYPE( __context__ , (ushort)( IDAY ) ) ) ; 
            __context__.SourceCodeLine = 980;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IDAYTYPE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 982;
                ISCHEDTOTEST [ 0] = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 983;
                ISCHEDTOTEST [ 1] = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 984;
                ISCHEDTOTEST [ 2] = (ushort) ( 2 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 988;
                ISCHEDTOTEST [ 0] = (ushort) ( 4 ) ; 
                __context__.SourceCodeLine = 989;
                ISCHEDTOTEST [ 1] = (ushort) ( 5 ) ; 
                __context__.SourceCodeLine = 990;
                ISCHEDTOTEST [ 2] = (ushort) ( 6 ) ; 
                } 
            
            __context__.SourceCodeLine = 994;
            ISCHEDTOTEST [ 3] = (ushort) ( GETSLEEPSCHEDULE( __context__ , (ushort)( IDAY ) ) ) ; 
            __context__.SourceCodeLine = 997;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETSCHEDULEMINUTES( __context__ , G_SCHED[ ISCHEDTOTEST[ 3 ] ] ) >= 720 ))  ) ) 
                {
                __context__.SourceCodeLine = 998;
                if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ ISCHEDTOTEST[ 3 ] ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 998;
                    return (ushort)( ISCHEDTOTEST[ 3 ]) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 1001;
            if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ ISCHEDTOTEST[ 2 ] ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1001;
                return (ushort)( ISCHEDTOTEST[ 2 ]) ; 
                }
            
            __context__.SourceCodeLine = 1002;
            if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ ISCHEDTOTEST[ 1 ] ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1002;
                return (ushort)( ISCHEDTOTEST[ 1 ]) ; 
                }
            
            __context__.SourceCodeLine = 1003;
            if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ ISCHEDTOTEST[ 0 ] ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1003;
                return (ushort)( ISCHEDTOTEST[ 0 ]) ; 
                }
            
            __context__.SourceCodeLine = 1008;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDAY > 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 1009;
                IPREVIOUSDAY = (ushort) ( (IDAY - 1) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1011;
                IPREVIOUSDAY = (ushort) ( 6 ) ; 
                }
            
            __context__.SourceCodeLine = 1014;
            IPREVDAYSLEEPSCHED = (ushort) ( GETSLEEPSCHEDULE( __context__ , (ushort)( IPREVIOUSDAY ) ) ) ; 
            __context__.SourceCodeLine = 1017;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETSCHEDULEMINUTES( __context__ , G_SCHED[ IPREVDAYSLEEPSCHED ] ) < 720 ))  ) ) 
                {
                __context__.SourceCodeLine = 1018;
                if ( Functions.TestForTrue  ( ( ISSCHEDULEBEFORETIME( __context__ , G_SCHED[ IPREVDAYSLEEPSCHED ] , (ushort)( ICURRENTTIMEINMINUTES ) ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1018;
                    return (ushort)( IPREVDAYSLEEPSCHED) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 1022;
            return (ushort)( GETCURRENTSCHEDULE( __context__ , (ushort)( 23 ) , (ushort)( 59 ) , (ushort)( IPREVIOUSDAY ) )) ; 
            
            }
            
        private void UPDATECURRENTSCHEDULESETPOINTS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1040;
            
            __context__.SourceCodeLine = 1044;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 65535))  ) ) 
                { 
                __context__.SourceCodeLine = 1046;
                SETPOINT [ (0 + 1)]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( G_SCHED[ _SplusNVRAM.G_ICURRENTSCHEDULE ].ISETPOINT[ 0 ] ) ) ) ; 
                __context__.SourceCodeLine = 1047;
                SETPOINT [ (1 + 1)]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( G_SCHED[ _SplusNVRAM.G_ICURRENTSCHEDULE ].ISETPOINT[ 1 ] ) ) ) ; 
                __context__.SourceCodeLine = 1048;
                SETPOINT [ (3 + 1)]  .Value = (ushort) ( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_ICURRENTSCHEDULE ) ) ) ; 
                __context__.SourceCodeLine = 1049;
                SETPOINT [ (2 + 1)]  .Value = (ushort) ( GETSCALEDTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( G_SCHED[ _SplusNVRAM.G_ICURRENTSCHEDULE ].ISETPOINT[ 2 ] ) ) ) ; 
                } 
            
            
            }
            
        private void RESTOREDEFAULTSCHEDULETIME (  SplusExecutionContext __context__, ushort ISCHEDULE ) 
            { 
            
            __context__.SourceCodeLine = 1077;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)ISCHEDULE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1079;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 6 ) ; 
                        __context__.SourceCodeLine = 1079;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1080;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 8 ) ; 
                        __context__.SourceCodeLine = 1080;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1081;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 17 ) ; 
                        __context__.SourceCodeLine = 1081;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1082;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 22 ) ; 
                        __context__.SourceCodeLine = 1082;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1083;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 6 ) ; 
                        __context__.SourceCodeLine = 1083;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1084;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 8 ) ; 
                        __context__.SourceCodeLine = 1084;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1085;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 17 ) ; 
                        __context__.SourceCodeLine = 1085;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1086;
                        G_SCHED [ ISCHEDULE] . IHOUR = (short) ( 22 ) ; 
                        __context__.SourceCodeLine = 1086;
                        G_SCHED [ ISCHEDULE] . IMINUTE = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void UPDATESCHEDULETIME (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1105;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
                { 
                __context__.SourceCodeLine = 1107;
                SCHEDULE_TIME__DOLLAR__  .UpdateValue ( "--:--"  ) ; 
                __context__.SourceCodeLine = 1108;
                return ; 
                } 
            
            __context__.SourceCodeLine = 1111;
            SCHEDULE_TIME__DOLLAR__  .UpdateValue ( GETDISPLAYTIME (  __context__ , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE ))  ) ; 
            
            }
            
        private void UPDATEAWAYMESSAGE (  SplusExecutionContext __context__ ) 
            { 
            CrestronString MNTH;
            MNTH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 9, this );
            
            CrestronString MNTH_SHORT;
            MNTH_SHORT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
            
            ushort MN = 0;
            ushort DY = 0;
            ushort YR = 0;
            
            uint TEMP = 0;
            
            
            __context__.SourceCodeLine = 1129;
            TEMP = (uint) ( GETGDATE( __context__ , (uint)( _SplusNVRAM.G_LTARGETJDAY ) ) ) ; 
            __context__.SourceCodeLine = 1131;
            MN = (ushort) ( GETMONTHFROMLONG( __context__ , (uint)( TEMP ) ) ) ; 
            __context__.SourceCodeLine = 1132;
            DY = (ushort) ( GETDAYFROMLONG( __context__ , (uint)( TEMP ) ) ) ; 
            __context__.SourceCodeLine = 1133;
            YR = (ushort) ( GETYEARFROMLONG( __context__ , (uint)( TEMP ) ) ) ; 
            __context__.SourceCodeLine = 1135;
            switch ((int)MN)
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 1137;
                    MNTH  .UpdateValue ( "January"  ) ; 
                    __context__.SourceCodeLine = 1138;
                    MNTH_SHORT  .UpdateValue ( "Jan."  ) ; 
                    __context__.SourceCodeLine = 1139;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 1140;
                    MNTH  .UpdateValue ( "February"  ) ; 
                    __context__.SourceCodeLine = 1141;
                    MNTH_SHORT  .UpdateValue ( "Feb."  ) ; 
                    __context__.SourceCodeLine = 1142;
                    break ; 
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 1143;
                    MNTH  .UpdateValue ( "March"  ) ; 
                    __context__.SourceCodeLine = 1144;
                    MNTH_SHORT  .UpdateValue ( "Mar."  ) ; 
                    __context__.SourceCodeLine = 1145;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 1146;
                    MNTH  .UpdateValue ( "April"  ) ; 
                    __context__.SourceCodeLine = 1147;
                    MNTH_SHORT  .UpdateValue ( "Apr."  ) ; 
                    __context__.SourceCodeLine = 1148;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 1149;
                    MNTH  .UpdateValue ( "May"  ) ; 
                    __context__.SourceCodeLine = 1150;
                    MNTH_SHORT  .UpdateValue ( "May"  ) ; 
                    __context__.SourceCodeLine = 1151;
                    break ; 
                    } 
                
                goto case 6 ;
                case 6 : 
                
                    { 
                    __context__.SourceCodeLine = 1152;
                    MNTH  .UpdateValue ( "June"  ) ; 
                    __context__.SourceCodeLine = 1153;
                    MNTH_SHORT  .UpdateValue ( "Jun."  ) ; 
                    __context__.SourceCodeLine = 1154;
                    break ; 
                    } 
                
                goto case 7 ;
                case 7 : 
                
                    { 
                    __context__.SourceCodeLine = 1155;
                    MNTH  .UpdateValue ( "July"  ) ; 
                    __context__.SourceCodeLine = 1156;
                    MNTH_SHORT  .UpdateValue ( "Jul."  ) ; 
                    __context__.SourceCodeLine = 1157;
                    break ; 
                    } 
                
                goto case 8 ;
                case 8 : 
                
                    { 
                    __context__.SourceCodeLine = 1158;
                    MNTH  .UpdateValue ( "August"  ) ; 
                    __context__.SourceCodeLine = 1159;
                    MNTH_SHORT  .UpdateValue ( "Aug."  ) ; 
                    __context__.SourceCodeLine = 1160;
                    break ; 
                    } 
                
                goto case 9 ;
                case 9 : 
                
                    { 
                    __context__.SourceCodeLine = 1161;
                    MNTH  .UpdateValue ( "September"  ) ; 
                    __context__.SourceCodeLine = 1162;
                    MNTH_SHORT  .UpdateValue ( "Sept."  ) ; 
                    __context__.SourceCodeLine = 1163;
                    break ; 
                    } 
                
                goto case 10 ;
                case 10 : 
                
                    { 
                    __context__.SourceCodeLine = 1164;
                    MNTH  .UpdateValue ( "October"  ) ; 
                    __context__.SourceCodeLine = 1165;
                    MNTH_SHORT  .UpdateValue ( "Oct."  ) ; 
                    __context__.SourceCodeLine = 1166;
                    break ; 
                    } 
                
                goto case 11 ;
                case 11 : 
                
                    { 
                    __context__.SourceCodeLine = 1167;
                    MNTH  .UpdateValue ( "November"  ) ; 
                    __context__.SourceCodeLine = 1168;
                    MNTH_SHORT  .UpdateValue ( "Nov."  ) ; 
                    __context__.SourceCodeLine = 1169;
                    break ; 
                    } 
                
                goto case 12 ;
                case 12 : 
                
                    { 
                    __context__.SourceCodeLine = 1170;
                    MNTH  .UpdateValue ( "December"  ) ; 
                    __context__.SourceCodeLine = 1171;
                    MNTH_SHORT  .UpdateValue ( "Dec."  ) ; 
                    __context__.SourceCodeLine = 1172;
                    break ; 
                    } 
                
                goto default;
                default : 
                
                    { 
                    __context__.SourceCodeLine = 1173;
                    MNTH  .UpdateValue ( "Error"  ) ; 
                    __context__.SourceCodeLine = 1174;
                    MNTH_SHORT  .UpdateValue ( "Err."  ) ; 
                    } 
                break;
                
                } 
                
            
            __context__.SourceCodeLine = 1177;
            switch ((int)_SplusNVRAM.G_IAWAYMSGINDEX)
            
                { 
                case 0 : 
                
                    { 
                    __context__.SourceCodeLine = 1181;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: None."  ) ; 
                    __context__.SourceCodeLine = 1182;
                    AWAY_DATE__DOLLAR__  .UpdateValue ( "Maintain Away Setpoint."  ) ; 
                    __context__.SourceCodeLine = 1184;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "None"  ) ; 
                    __context__.SourceCodeLine = 1185;
                    AWAY_DATE_SHORT__DOLLAR__  .UpdateValue ( "Maintain"  ) ; 
                    __context__.SourceCodeLine = 1186;
                    break ; 
                    } 
                
                goto case 1 ;
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 1191;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: Wake"  ) ; 
                    __context__.SourceCodeLine = 1192;
                    MakeString ( AWAY_DATE__DOLLAR__ , "on {0} {1:d}, {2:d} ", MNTH , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 1194;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "Wake"  ) ; 
                    __context__.SourceCodeLine = 1195;
                    MakeString ( AWAY_DATE_SHORT__DOLLAR__ , "{0} {1:d}, {2:d} ", MNTH_SHORT , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 1196;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 1201;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: Leave"  ) ; 
                    __context__.SourceCodeLine = 1202;
                    MakeString ( AWAY_DATE__DOLLAR__ , "on {0} {1:d}, {2:d} ", MNTH , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 1204;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "Leave"  ) ; 
                    __context__.SourceCodeLine = 1205;
                    MakeString ( AWAY_DATE_SHORT__DOLLAR__ , "{0} {1:d}, {2:d} ", MNTH_SHORT , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 1206;
                    break ; 
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 1211;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: Return"  ) ; 
                    __context__.SourceCodeLine = 1212;
                    MakeString ( AWAY_DATE__DOLLAR__ , "on {0} {1:d}, {2:d} ", MNTH , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 1214;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "Return"  ) ; 
                    __context__.SourceCodeLine = 1215;
                    MakeString ( AWAY_DATE_SHORT__DOLLAR__ , "{0} {1:d}, {2:d} ", MNTH_SHORT , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 1216;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 1221;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Next Schedule: Sleep"  ) ; 
                    __context__.SourceCodeLine = 1222;
                    MakeString ( AWAY_DATE__DOLLAR__ , "on {0} {1:d}, {2:d} ", MNTH , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 1224;
                    AWAY_SCHEDULE_SHORT__DOLLAR__  .UpdateValue ( "Sleep"  ) ; 
                    __context__.SourceCodeLine = 1225;
                    MakeString ( AWAY_DATE_SHORT__DOLLAR__ , "{0} {1:d}, {2:d} ", MNTH_SHORT , (short)DY, (short)YR) ; 
                    __context__.SourceCodeLine = 1226;
                    break ; 
                    } 
                
                goto default;
                default : 
                
                    { 
                    __context__.SourceCodeLine = 1229;
                    AWAY_SCHEDULE__DOLLAR__  .UpdateValue ( "Error"  ) ; 
                    } 
                break;
                
                } 
                
            
            
            }
            
        private void INITAWAYDATE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1243;
            G_TODAYJDAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (ushort)( Functions.GetMonthNum() ) , (ushort)( Functions.GetDateNum() ) , (ushort)( Functions.GetYearNum() ) ) ) ) ) ; 
            __context__.SourceCodeLine = 1244;
            _SplusNVRAM.G_LTARGETJDAY = (uint) ( G_TODAYJDAY ) ; 
            __context__.SourceCodeLine = 1245;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( 0 ) ; 
            
            }
            
        private void DOAWAYMODE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1257;
            
            __context__.SourceCodeLine = 1261;
            _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( 8 ) ; 
            __context__.SourceCodeLine = 1262;
            CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
            __context__.SourceCodeLine = 1263;
            AWAY_MODE_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1264;
            HOLD_MODE_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1265;
            _SplusNVRAM.G_IPREVSETPTS [ 0] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( CURRENT_HEAT_SP  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1266;
            _SplusNVRAM.G_IPREVSETPTS [ 1] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( CURRENT_COOL_SP  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1267;
            _SplusNVRAM.G_IPREVSETPTS [ 2] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( CURRENT_SLAB_SP  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1268;
            _SplusNVRAM.G_IPREVSETPTS [ 3] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( CURRENT_AUTO_SP  .UshortValue ) ) ) ; 
            __context__.SourceCodeLine = 1270;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            __context__.SourceCodeLine = 1271;
            Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
            __context__.SourceCodeLine = 1273;
            UPDATEAWAYMESSAGE (  __context__  ) ; 
            
            }
            
        private void LOADSCHEDULES (  SplusExecutionContext __context__ ) 
            { 
            short IRESULT = 0;
            
            short IHANDLE = 0;
            
            ushort ISCHED = 0;
            
            FILE_INFO FI;
            FI  = new FILE_INFO();
            FI .PopulateDefaults();
            
            ushort IVERSION = 0;
            
            ushort ITEMP = 0;
            
            ushort IRECALLHOLDMODE = 0;
            
            ushort IRECALLAWAYMODE = 0;
            
            CrestronString SREADFILENAME;
            CrestronString SWRITEFILENAME;
            SREADFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            SWRITEFILENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
            
            ushort IREADHANDLE = 0;
            ushort IWRITEHANDLE = 0;
            ushort INT = 0;
            
            
            __context__.SourceCodeLine = 1302;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 1303;
            SWRITEFILENAME  .UpdateValue ( GETFILENAME (  __context__  )  ) ; 
            __context__.SourceCodeLine = 1305;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( SWRITEFILENAME , ref FI ) != 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1307;
                SREADFILENAME  .UpdateValue ( "\\NVRAM\\" + "tstat_" + Functions.ItoA (  (int) ( INSTANCE_ID  .UshortValue ) ) + ".dat"  ) ; 
                __context__.SourceCodeLine = 1309;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FindFirst( SREADFILENAME , ref FI ) != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1311;
                    FindClose ( ) ; 
                    __context__.SourceCodeLine = 1312;
                    EndFileOperations ( ) ; 
                    __context__.SourceCodeLine = 1313;
                    return ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1318;
                    IREADHANDLE = (ushort) ( FileOpen( SREADFILENAME ,(ushort) (0 | 32768) ) ) ; 
                    __context__.SourceCodeLine = 1319;
                    IWRITEHANDLE = (ushort) ( FileOpen( SWRITEFILENAME ,(ushort) ((2 | 256) | 32768) ) ) ; 
                    __context__.SourceCodeLine = 1321;
                    while ( Functions.TestForTrue  ( ( Functions.Not( FileEOF( (short)( IREADHANDLE ) ) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1323;
                        ReadInteger (  (short) ( IREADHANDLE ) ,  ref INT) ; 
                        __context__.SourceCodeLine = 1324;
                        WriteInteger (  (short) ( IWRITEHANDLE ) ,  (ushort) ( INT ) ) ; 
                        __context__.SourceCodeLine = 1321;
                        } 
                    
                    __context__.SourceCodeLine = 1327;
                    FileClose (  (short) ( IREADHANDLE ) ) ; 
                    __context__.SourceCodeLine = 1328;
                    FileClose (  (short) ( IWRITEHANDLE ) ) ; 
                    __context__.SourceCodeLine = 1330;
                    FileDelete ( SREADFILENAME ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1335;
            IRECALLAWAYMODE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1337;
            
            __context__.SourceCodeLine = 1341;
            IHANDLE = (short) ( FileOpen( SWRITEFILENAME ,(ushort) (0 | 32768) ) ) ; 
            __context__.SourceCodeLine = 1343;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1346;
                IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref IVERSION ) ) ; 
                __context__.SourceCodeLine = 1347;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVERSION > 2 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1349;
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 1356;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVERSION >= 2 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 1358;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref IRECALLHOLDMODE ) ) ; 
                        __context__.SourceCodeLine = 1359;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref IRECALLAWAYMODE ) ) ; 
                        __context__.SourceCodeLine = 1361;
                        if ( Functions.TestForTrue  ( ( IRECALLHOLDMODE)  ) ) 
                            {
                            __context__.SourceCodeLine = 1362;
                            HOLD_MODE_FB  .Value = (ushort) ( 1 ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1364;
                            HOLD_MODE_FB  .Value = (ushort) ( 0 ) ; 
                            }
                        
                        } 
                    
                    __context__.SourceCodeLine = 1367;
                    ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                    ushort __FN_FOREND_VAL__1 = (ushort)7; 
                    int __FN_FORSTEP_VAL__1 = (int)1; 
                    for ( ISCHED  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ISCHED  >= __FN_FORSTART_VAL__1) && (ISCHED  <= __FN_FOREND_VAL__1) ) : ( (ISCHED  <= __FN_FORSTART_VAL__1) && (ISCHED  >= __FN_FOREND_VAL__1) ) ; ISCHED  += (ushort)__FN_FORSTEP_VAL__1) 
                        { 
                        __context__.SourceCodeLine = 1370;
                        
                        __context__.SourceCodeLine = 1373;
                        IRESULT = (short) ( ReadSignedInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].IHOUR ) ) ; 
                        __context__.SourceCodeLine = 1374;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].IMINUTE ) ) ; 
                        __context__.SourceCodeLine = 1375;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].ISETPOINT[ 0 ] ) ) ; 
                        __context__.SourceCodeLine = 1376;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].ISETPOINT[ 1 ] ) ) ; 
                        __context__.SourceCodeLine = 1377;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVERSION >= 2 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1378;
                            IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ ISCHED ].ISETPOINT[ 2 ] ) ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1367;
                        } 
                    
                    __context__.SourceCodeLine = 1383;
                    
                    __context__.SourceCodeLine = 1387;
                    IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ 8 ].ISETPOINT[ 0 ] ) ) ; 
                    __context__.SourceCodeLine = 1388;
                    IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ 8 ].ISETPOINT[ 1 ] ) ) ; 
                    __context__.SourceCodeLine = 1389;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVERSION >= 2 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1390;
                        IRESULT = (short) ( ReadInteger( (short)( IHANDLE ) , ref G_SCHED[ 8 ].ISETPOINT[ 2 ] ) ) ; 
                        }
                    
                    __context__.SourceCodeLine = 1393;
                    if ( Functions.TestForTrue  ( ( IRECALLAWAYMODE)  ) ) 
                        {
                        __context__.SourceCodeLine = 1394;
                        DOAWAYMODE (  __context__  ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1396;
                        AWAY_MODE_FB  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    } 
                
                __context__.SourceCodeLine = 1399;
                FileClose (  (short) ( IHANDLE ) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1402;
                Print( "ERROR: Unable to open file '{0}' for read. (Error code {1:d})\r\n", GETFILENAME (  __context__  ) , (short)IHANDLE) ; 
                }
            
            __context__.SourceCodeLine = 1404;
            FindClose ( ) ; 
            __context__.SourceCodeLine = 1405;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 1407;
            
            
            }
            
        private void SAVESCHEDULES (  SplusExecutionContext __context__ ) 
            { 
            short IRESULT = 0;
            
            short IHANDLE = 0;
            
            ushort ISCHED = 0;
            
            ushort IVER = 0;
            
            ushort Z = 0;
            
            
            __context__.SourceCodeLine = 1434;
            StartFileOperations ( ) ; 
            __context__.SourceCodeLine = 1436;
            IHANDLE = (short) ( FileOpen( GETFILENAME( __context__ ) ,(ushort) (((1 | 512) | 256) | 32768) ) ) ; 
            __context__.SourceCodeLine = 1438;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IHANDLE >= 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1440;
                IVER = (ushort) ( 2 ) ; 
                __context__.SourceCodeLine = 1441;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( IVER ) ) ) ; 
                __context__.SourceCodeLine = 1443;
                Z = (ushort) ( HOLD_MODE_FB  .Value ) ; 
                __context__.SourceCodeLine = 1444;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( Z ) ) ) ; 
                __context__.SourceCodeLine = 1445;
                Z = (ushort) ( AWAY_MODE_FB  .Value ) ; 
                __context__.SourceCodeLine = 1446;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( Z ) ) ) ; 
                __context__.SourceCodeLine = 1448;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)7; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( ISCHED  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (ISCHED  >= __FN_FORSTART_VAL__1) && (ISCHED  <= __FN_FOREND_VAL__1) ) : ( (ISCHED  <= __FN_FORSTART_VAL__1) && (ISCHED  >= __FN_FOREND_VAL__1) ) ; ISCHED  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 1451;
                    IRESULT = (short) ( WriteSignedInteger( (short)( IHANDLE ) , (short)( G_SCHED[ ISCHED ].IHOUR ) ) ) ; 
                    __context__.SourceCodeLine = 1452;
                    IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ ISCHED ].IMINUTE ) ) ) ; 
                    __context__.SourceCodeLine = 1453;
                    IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ ISCHED ].ISETPOINT[ 0 ] ) ) ) ; 
                    __context__.SourceCodeLine = 1454;
                    IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ ISCHED ].ISETPOINT[ 1 ] ) ) ) ; 
                    __context__.SourceCodeLine = 1455;
                    IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ ISCHED ].ISETPOINT[ 2 ] ) ) ) ; 
                    __context__.SourceCodeLine = 1448;
                    } 
                
                __context__.SourceCodeLine = 1459;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ 8 ].ISETPOINT[ 0 ] ) ) ) ; 
                __context__.SourceCodeLine = 1460;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ 8 ].ISETPOINT[ 1 ] ) ) ) ; 
                __context__.SourceCodeLine = 1461;
                IRESULT = (short) ( WriteInteger( (short)( IHANDLE ) , (ushort)( G_SCHED[ 8 ].ISETPOINT[ 2 ] ) ) ) ; 
                __context__.SourceCodeLine = 1463;
                FileClose (  (short) ( IHANDLE ) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1467;
                Print( "ERROR: Unable to open file '{0}' for write. (Error code {1:d})\r\n", GETFILENAME (  __context__  ) , (short)IHANDLE) ; 
                }
            
            __context__.SourceCodeLine = 1470;
            EndFileOperations ( ) ; 
            __context__.SourceCodeLine = 1472;
            
            
            }
            
        object WEEKDAY_WAKE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 1484;
                _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 1484;
                SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekday Wake"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object WEEKDAY_LEAVE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 1485;
            _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1485;
            SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekday Leave"  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object WEEKDAY_RETURN_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1486;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 2 ) ; 
        __context__.SourceCodeLine = 1486;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekday Return"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKDAY_SLEEP_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1487;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 3 ) ; 
        __context__.SourceCodeLine = 1487;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekday Sleep"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKEND_WAKE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1488;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 4 ) ; 
        __context__.SourceCodeLine = 1488;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekend Wake"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKEND_LEAVE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1489;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 5 ) ; 
        __context__.SourceCodeLine = 1489;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekend Leave"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKEND_RETURN_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1490;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 6 ) ; 
        __context__.SourceCodeLine = 1490;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekend Return"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKEND_SLEEP_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1491;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 7 ) ; 
        __context__.SourceCodeLine = 1491;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Weekend Sleep"  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WEEKDAY_WAKE_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1496;
        UPDATESCHEDULETIME (  __context__  ) ; 
        __context__.SourceCodeLine = 1497;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 1498;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 1499;
        SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 2 ] ))  ) ; 
        __context__.SourceCodeLine = 1500;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1501;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1503;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (ushort)( 10 ) ) ) )  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AWAY_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1509;
        _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 8 ) ; 
        __context__.SourceCodeLine = 1510;
        SCHEDULE_NAME__DOLLAR__  .UpdateValue ( "Away"  ) ; 
        __context__.SourceCodeLine = 1512;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ 8 ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 1513;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ 8 ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 1514;
        SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ 8 ].ISETPOINT[ 2 ] ))  ) ; 
        __context__.SourceCodeLine = 1515;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1516;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1518;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (ushort)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 1520;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_UP_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1526;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 1527;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 1529;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 1531;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1534;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( Mod( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR + 1) , 24 ) ) ; 
            }
        
        __context__.SourceCodeLine = 1536;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_DOWN_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1541;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 1542;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 1544;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 1546;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1550;
            if ( Functions.TestForTrue  ( ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR)  ) ) 
                {
                __context__.SourceCodeLine = 1551;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR - 1) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1553;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( 23 ) ; 
                }
            
            } 
        
        __context__.SourceCodeLine = 1556;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TIME_UP_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1561;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 1562;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 1564;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 1566;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1570;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE + 15) == 60))  ) ) 
                {
                __context__.SourceCodeLine = 1571;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( Mod( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR + 1) , 24 ) ) ; 
                }
            
            __context__.SourceCodeLine = 1572;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( Mod( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE + 15) , 60 ) ) ; 
            __context__.SourceCodeLine = 1575;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - Mod( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE , 15 )) ) ; 
            } 
        
        __context__.SourceCodeLine = 1578;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TIME_DOWN_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1583;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 1584;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 1586;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 1588;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1592;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1594;
                if ( Functions.TestForTrue  ( ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR)  ) ) 
                    {
                    __context__.SourceCodeLine = 1595;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR - 1) ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 1597;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( 23 ) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 1600;
            if ( Functions.TestForTrue  ( ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE)  ) ) 
                {
                __context__.SourceCodeLine = 1601;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - 15) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1603;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (60 - 15) ) ; 
                }
            
            __context__.SourceCodeLine = 1606;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - Mod( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE , 15 )) ) ; 
            } 
        
        __context__.SourceCodeLine = 1609;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MINUTE_UP_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1614;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 1615;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 1617;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 1619;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1623;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( Mod( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE + 15) , 60 ) ) ; 
            __context__.SourceCodeLine = 1626;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - Mod( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE , 15 )) ) ; 
            } 
        
        __context__.SourceCodeLine = 1629;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MINUTE_DOWN_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1634;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 1635;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 1637;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IHOUR == -1))  ) ) 
            { 
            __context__.SourceCodeLine = 1639;
            RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE )) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1643;
            if ( Functions.TestForTrue  ( ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE)  ) ) 
                {
                __context__.SourceCodeLine = 1644;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - 15) ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1646;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (60 - 15) ) ; 
                }
            
            __context__.SourceCodeLine = 1649;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IMINUTE = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE - Mod( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].IMINUTE , 15 )) ) ; 
            } 
        
        __context__.SourceCodeLine = 1652;
        UPDATESCHEDULETIME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HEAT_SETPOINT_UP_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TEMPDEG = 0;
        
        
        __context__.SourceCodeLine = 1658;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 1 ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
        __context__.SourceCodeLine = 1659;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1661;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) ) > (GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) ) - DEADBAND  .UshortValue) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1663;
                TEMPDEG = (ushort) ( (GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) ) + DEADBAND  .UshortValue) ) ; 
                __context__.SourceCodeLine = 1664;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( 0 ) , (ushort)( TEMPDEG ) ) ) ; 
                __context__.SourceCodeLine = 1665;
                SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1670;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] > (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] + DEADBAND  .UshortValue) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1672;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + DEADBAND  .UshortValue) ) ; 
                __context__.SourceCodeLine = 1673;
                SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 1676;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 1678;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1679;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1681;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (ushort)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 1683;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 1684;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1685;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1686;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HEAT_SETPOINT_DOWN_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1692;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 0 ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
        __context__.SourceCodeLine = 1694;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 1696;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1697;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1699;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (ushort)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 1701;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 1702;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1703;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1704;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COOL_SETPOINT_UP_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1709;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 1 ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
        __context__.SourceCodeLine = 1711;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 1713;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1714;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1716;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (ushort)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 1718;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 1719;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1720;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1721;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COOL_SETPOINT_DOWN_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TEMPDEG = 0;
        
        
        __context__.SourceCodeLine = 1727;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 0 ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
        __context__.SourceCodeLine = 1728;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1730;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) ) < (GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) ) + DEADBAND  .UshortValue) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1732;
                TEMPDEG = (ushort) ( (GETSCALEDTEMP( __context__ , (ushort)( 0 ) , (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) ) - DEADBAND  .UshortValue) ) ; 
                __context__.SourceCodeLine = 1733;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( GETRAWTEMP( __context__ , (ushort)( 0 ) , (ushort)( TEMPDEG ) ) ) ; 
                __context__.SourceCodeLine = 1734;
                SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1739;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] < (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + DEADBAND  .UshortValue) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1741;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] - DEADBAND  .UshortValue) ) ; 
                __context__.SourceCodeLine = 1742;
                SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 1746;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 1748;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1749;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1751;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (ushort)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 1753;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 1754;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1755;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1756;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLAB_SETPOINT_UP_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1761;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 2] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 2 ] ) , (ushort)( 1 ) , (short)( 33 ) , (short)( 490 ) ) ) ; 
        __context__.SourceCodeLine = 1763;
        SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 2 ] ))  ) ; 
        __context__.SourceCodeLine = 1765;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 1766;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SLAB_SETPOINT_DOWN_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1771;
        G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 2] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 2 ] ) , (ushort)( 0 ) , (short)( 33 ) , (short)( 490 ) ) ) ; 
        __context__.SourceCodeLine = 1773;
        SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 2 ] ))  ) ; 
        __context__.SourceCodeLine = 1775;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 1776;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_SETPOINT_UP_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1781;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + 1) <= 316 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] + 1) <= 372 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 1783;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 1 ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
            __context__.SourceCodeLine = 1784;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 1 ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1788;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] + 2) <= 316 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1790;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 1 ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
                __context__.SourceCodeLine = 1791;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 1 ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1793;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] + 2) <= 372 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1795;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 1 ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
                    __context__.SourceCodeLine = 1796;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 1 ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
                    } 
                
                }
            
            } 
        
        __context__.SourceCodeLine = 1800;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 1801;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 1803;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1804;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1806;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (ushort)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 1811;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 1812;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1813;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1814;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_SETPOINT_DOWN_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1821;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] - 1) >= 33 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] - 1) >= 150 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 1823;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 0 ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
            __context__.SourceCodeLine = 1824;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 0 ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 1828;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] - 2) >= 33 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1830;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 0 ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
                __context__.SourceCodeLine = 1831;
                G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ) , (ushort)( 0 ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1833;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] - 2) >= 150 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1835;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 0 ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
                    __context__.SourceCodeLine = 1836;
                    G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ) , (ushort)( 0 ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
                    } 
                
                }
            
            } 
        
        __context__.SourceCodeLine = 1840;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 1841;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 1843;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMP_SCALE  .Value == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1844;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ))  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1846;
            SCHEDULE_SETPOINT__DOLLAR__ [ (3 + 1)]  .UpdateValue ( Functions.ItoA (  (int) ( ROUNDEDDIVIDE( __context__ , (ushort)( GETAUTOSETPOINT( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( _SplusNVRAM.G_IEDITSCHEDULE ) ) ) , (ushort)( 10 ) ) ) )  ) ; 
            }
        
        __context__.SourceCodeLine = 1850;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
            {
            __context__.SourceCodeLine = 1851;
            UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1852;
            if ( Functions.TestForTrue  ( ( AWAY_MODE_FB  .Value)  ) ) 
                {
                __context__.SourceCodeLine = 1853;
                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                }
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REMOVE_SCHEDULE_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1858;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE == 8))  ) ) 
            {
            __context__.SourceCodeLine = 1859;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 1861;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IEDITSCHEDULE != 8))  ) ) 
            { 
            __context__.SourceCodeLine = 1863;
            G_SCHED [ _SplusNVRAM.G_IEDITSCHEDULE] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 1864;
            UPDATESCHEDULETIME (  __context__  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOUR_UP_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1879;
        CreateWait ( "WAIT_SAVE" , 300 , WAIT_SAVE_Callback ) ;
        __context__.SourceCodeLine = 1880;
        RetimeWait ( (int)300, "WAIT_SAVE" ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void WAIT_SAVE_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 1879;
            SAVESCHEDULES (  __context__  ) ; 
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object TEMP_SCALE_OnChange_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1886;
        SCHEDULE_SETPOINT__DOLLAR__ [ (0 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 0 ] ))  ) ; 
        __context__.SourceCodeLine = 1887;
        SCHEDULE_SETPOINT__DOLLAR__ [ (1 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 1 ] ))  ) ; 
        __context__.SourceCodeLine = 1888;
        SCHEDULE_SETPOINT__DOLLAR__ [ (2 + 1)]  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ _SplusNVRAM.G_IEDITSCHEDULE ].ISETPOINT[ 2 ] ))  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TEMP_SCALE_OnChange_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1895;
        UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RUN_PROGRAM_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort BSAVENEEDED = 0;
        
        
        __context__.SourceCodeLine = 1902;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (AWAY_MODE_FB  .Value != 0) ) || Functions.TestForTrue ( Functions.BoolToInt (HOLD_MODE_FB  .Value != 0) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 1903;
            BSAVENEEDED = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1905;
            BSAVENEEDED = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 1907;
        AWAY_MODE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1908;
        HOLD_MODE_FB  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 1909;
        _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) ) ; 
        __context__.SourceCodeLine = 1910;
        CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
        __context__.SourceCodeLine = 1911;
        CURRENT_DAYOFWEEK  .Value = (ushort) ( Functions.GetDayOfWeekNum() ) ; 
        __context__.SourceCodeLine = 1912;
        UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
        __context__.SourceCodeLine = 1913;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 65535))  ) ) 
            {
            __context__.SourceCodeLine = 1914;
            Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
            }
        
        __context__.SourceCodeLine = 1916;
        if ( Functions.TestForTrue  ( ( BSAVENEEDED)  ) ) 
            {
            __context__.SourceCodeLine = 1917;
            SAVESCHEDULES (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RUN_AWAY_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort BSAVENEEDED = 0;
        
        
        __context__.SourceCodeLine = 1925;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (AWAY_MODE_FB  .Value == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 1927;
            BSAVENEEDED = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 1928;
            INITAWAYDATE (  __context__  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 1932;
            BSAVENEEDED = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 1934;
        DOAWAYMODE (  __context__  ) ; 
        __context__.SourceCodeLine = 1936;
        if ( Functions.TestForTrue  ( ( BSAVENEEDED)  ) ) 
            {
            __context__.SourceCodeLine = 1937;
            SAVESCHEDULES (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RUN_HOLD_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort BSAVENEEDED = 0;
        
        
        __context__.SourceCodeLine = 1945;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HOLD_MODE_FB  .Value == 0))  ) ) 
            {
            __context__.SourceCodeLine = 1946;
            BSAVENEEDED = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1948;
            BSAVENEEDED = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 1950;
        HOLD_MODE_FB  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 1952;
        if ( Functions.TestForTrue  ( ( BSAVENEEDED)  ) ) 
            {
            __context__.SourceCodeLine = 1953;
            SAVESCHEDULES (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SINGLE_BUTTON_SELECT_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString STEXT;
        STEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
        
        CrestronString SVALUE;
        SVALUE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
        
        ushort MOD_VALUE = 0;
        
        
        __context__.SourceCodeLine = 1964;
        if ( Functions.TestForTrue  ( ( SLAB_SP_ENABLED  .Value)  ) ) 
            {
            __context__.SourceCodeLine = 1965;
            MOD_VALUE = (ushort) ( 4 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1967;
            MOD_VALUE = (ushort) ( 3 ) ; 
            }
        
        __context__.SourceCodeLine = 1969;
        G_ISINGLEBUTTONSELECTCAT = (ushort) ( Mod( (G_ISINGLEBUTTONSELECTCAT + 1) , MOD_VALUE ) ) ; 
        __context__.SourceCodeLine = 1971;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ISINGLEBUTTONSELECTCAT == 0))  ) ) 
            {
            __context__.SourceCodeLine = 1972;
            G_ISINGLEBUTTONSELECTSCHED = (ushort) ( Mod( (G_ISINGLEBUTTONSELECTSCHED + 1) , 9 ) ) ; 
            }
        
        __context__.SourceCodeLine = 1976;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (G_ISINGLEBUTTONSELECTCAT == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (G_ISINGLEBUTTONSELECTSCHED == 8) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 1977;
            G_ISINGLEBUTTONSELECTCAT = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 1979;
        switch ((int)G_ISINGLEBUTTONSELECTSCHED)
        
            { 
            case 0 : 
            
                { 
                __context__.SourceCodeLine = 1981;
                STEXT  .UpdateValue ( "Wkday Wake: "  ) ; 
                __context__.SourceCodeLine = 1981;
                break ; 
                } 
            
            goto case 1 ;
            case 1 : 
            
                { 
                __context__.SourceCodeLine = 1982;
                STEXT  .UpdateValue ( "Wkday Leave: "  ) ; 
                __context__.SourceCodeLine = 1982;
                break ; 
                } 
            
            goto case 2 ;
            case 2 : 
            
                { 
                __context__.SourceCodeLine = 1983;
                STEXT  .UpdateValue ( "Wkday Return: "  ) ; 
                __context__.SourceCodeLine = 1983;
                break ; 
                } 
            
            goto case 3 ;
            case 3 : 
            
                { 
                __context__.SourceCodeLine = 1984;
                STEXT  .UpdateValue ( "Wkday Sleep: "  ) ; 
                __context__.SourceCodeLine = 1984;
                break ; 
                } 
            
            goto case 4 ;
            case 4 : 
            
                { 
                __context__.SourceCodeLine = 1985;
                STEXT  .UpdateValue ( "Wkend Wake: "  ) ; 
                __context__.SourceCodeLine = 1985;
                break ; 
                } 
            
            goto case 5 ;
            case 5 : 
            
                { 
                __context__.SourceCodeLine = 1986;
                STEXT  .UpdateValue ( "Wkend Leave: "  ) ; 
                __context__.SourceCodeLine = 1986;
                break ; 
                } 
            
            goto case 6 ;
            case 6 : 
            
                { 
                __context__.SourceCodeLine = 1987;
                STEXT  .UpdateValue ( "Wkend Return: "  ) ; 
                __context__.SourceCodeLine = 1987;
                break ; 
                } 
            
            goto case 7 ;
            case 7 : 
            
                { 
                __context__.SourceCodeLine = 1988;
                STEXT  .UpdateValue ( "Wkend Sleep: "  ) ; 
                __context__.SourceCodeLine = 1988;
                break ; 
                } 
            
            goto case 8 ;
            case 8 : 
            
                { 
                __context__.SourceCodeLine = 1989;
                STEXT  .UpdateValue ( "Away: "  ) ; 
                __context__.SourceCodeLine = 1989;
                break ; 
                } 
            
            break;
            } 
            
        
        __context__.SourceCodeLine = 1992;
        switch ((int)G_ISINGLEBUTTONSELECTCAT)
        
            { 
            case 0 : 
            
                { 
                __context__.SourceCodeLine = 1996;
                STEXT  .UpdateValue ( STEXT + "Time"  ) ; 
                __context__.SourceCodeLine = 1997;
                SVALUE  .UpdateValue ( GETDISPLAYTIME (  __context__ , (short)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IHOUR ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IMINUTE ))  ) ; 
                __context__.SourceCodeLine = 1998;
                break ; 
                } 
            
            goto case 1 ;
            case 1 : 
            
                { 
                __context__.SourceCodeLine = 2003;
                STEXT  .UpdateValue ( STEXT + "Heat"  ) ; 
                __context__.SourceCodeLine = 2004;
                SVALUE  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 0 ] ))  ) ; 
                __context__.SourceCodeLine = 2005;
                break ; 
                } 
            
            goto case 2 ;
            case 2 : 
            
                { 
                __context__.SourceCodeLine = 2009;
                STEXT  .UpdateValue ( STEXT + "Cool"  ) ; 
                __context__.SourceCodeLine = 2010;
                SVALUE  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 1 ] ))  ) ; 
                __context__.SourceCodeLine = 2011;
                break ; 
                } 
            
            goto case 3 ;
            case 3 : 
            
                { 
                __context__.SourceCodeLine = 2015;
                STEXT  .UpdateValue ( STEXT + "Slab"  ) ; 
                __context__.SourceCodeLine = 2016;
                SVALUE  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 2 ] ))  ) ; 
                __context__.SourceCodeLine = 2017;
                break ; 
                } 
            
            break;
            } 
            
        
        __context__.SourceCodeLine = 2022;
        SINGLE_BUTTON_SELECT__DOLLAR__  .UpdateValue ( STEXT  ) ; 
        __context__.SourceCodeLine = 2023;
        SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( SVALUE  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SINGLE_BUTTON_ADJUST_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2030;
        CreateWait ( "SBA_WAIT_1" , 50 , SBA_WAIT_1_Callback ) ;
        __context__.SourceCodeLine = 2048;
        CreateWait ( "SBA_WAIT_2" , 200 , SBA_WAIT_2_Callback ) ;
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public void SBA_WAIT_1_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 2032;
            if ( Functions.TestForTrue  ( ( SINGLE_BUTTON_ADJUST  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2034;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ISINGLEBUTTONADJUSTDIR == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2036;
                    G_ISINGLEBUTTONADJUSTDIR = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 2037;
                    SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( "Direction = UP"  ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2041;
                    G_ISINGLEBUTTONADJUSTDIR = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 2042;
                    SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( "Direction = DOWN"  ) ; 
                    } 
                
                __context__.SourceCodeLine = 2044;
                G_BIGNORESINGLEBUTTONRELEASE = (ushort) ( 1 ) ; 
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

public void SBA_WAIT_2_CallbackFn( object stateInfo )
{

    try
    {
        Wait __LocalWait__ = (Wait)stateInfo;
        SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
        __LocalWait__.RemoveFromList();
        
            
            __context__.SourceCodeLine = 2051;
            if ( Functions.TestForTrue  ( ( SINGLE_BUTTON_ADJUST  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 2053;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ISINGLEBUTTONSELECTCAT == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2055;
                    G_SCHED [ G_ISINGLEBUTTONSELECTSCHED] . IHOUR = (short) ( -1 ) ; 
                    __context__.SourceCodeLine = 2056;
                    SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( "Schedule Removed"  ) ; 
                    __context__.SourceCodeLine = 2057;
                    G_BIGNORESINGLEBUTTONRELEASE = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    
}

object SINGLE_BUTTON_ADJUST_OnRelease_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        short IADJUST = 0;
        
        short ITIMEINMINUTES = 0;
        
        
        __context__.SourceCodeLine = 2070;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_BIGNORESINGLEBUTTONRELEASE == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 2072;
            G_BIGNORESINGLEBUTTONRELEASE = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2073;
            switch ((int)G_ISINGLEBUTTONSELECTCAT)
            
                { 
                case 0 : 
                
                    { 
                    __context__.SourceCodeLine = 2077;
                    SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTIME (  __context__ , (short)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IHOUR ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IMINUTE ))  ) ; 
                    __context__.SourceCodeLine = 2078;
                    break ; 
                    } 
                
                goto case 1 ;
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 2083;
                    SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 0 ] ))  ) ; 
                    __context__.SourceCodeLine = 2084;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 2089;
                    SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 1 ] ))  ) ; 
                    __context__.SourceCodeLine = 2090;
                    break ; 
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 2095;
                    SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 2 ] ))  ) ; 
                    __context__.SourceCodeLine = 2096;
                    break ; 
                    } 
                
                break;
                } 
                
            
            __context__.SourceCodeLine = 2099;
            Functions.TerminateEvent (); 
            } 
        
        __context__.SourceCodeLine = 2102;
        CancelWait ( "SBA_WAIT_1" ) ; 
        __context__.SourceCodeLine = 2103;
        CancelWait ( "SBA_WAIT_2" ) ; 
        __context__.SourceCodeLine = 2105;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_ISINGLEBUTTONADJUSTDIR == 0))  ) ) 
            {
            __context__.SourceCodeLine = 2106;
            IADJUST = (short) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2108;
            IADJUST = (short) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 2110;
        switch ((int)G_ISINGLEBUTTONSELECTCAT)
        
            { 
            case 0 : 
            
                { 
                __context__.SourceCodeLine = 2115;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IHOUR == -1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2117;
                    RESTOREDEFAULTSCHEDULETIME (  __context__ , (ushort)( G_ISINGLEBUTTONSELECTSCHED )) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2121;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IADJUST == 0))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2123;
                        ITIMEINMINUTES = (short) ( (GETSCHEDULEMINUTES( __context__ , G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ] ) - 15) ) ; 
                        __context__.SourceCodeLine = 2124;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ITIMEINMINUTES < 0 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 2125;
                            ITIMEINMINUTES = (short) ( (1440 - 15) ) ; 
                            }
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 2129;
                        ITIMEINMINUTES = (short) ( Mod( (GETSCHEDULEMINUTES( __context__ , G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ] ) + 15) , 1440 ) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 2133;
                    ITIMEINMINUTES = (short) ( (ITIMEINMINUTES - Mod( ITIMEINMINUTES , 15 )) ) ; 
                    __context__.SourceCodeLine = 2135;
                    G_SCHED [ G_ISINGLEBUTTONSELECTSCHED] . IHOUR = (short) ( (ITIMEINMINUTES / 60) ) ; 
                    __context__.SourceCodeLine = 2136;
                    G_SCHED [ G_ISINGLEBUTTONSELECTSCHED] . IMINUTE = (ushort) ( Mod( ITIMEINMINUTES , 60 ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 2139;
                SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTIME (  __context__ , (short)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IHOUR ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IMINUTE ))  ) ; 
                __context__.SourceCodeLine = 2140;
                break ; 
                } 
            
            goto case 1 ;
            case 1 : 
            
                { 
                __context__.SourceCodeLine = 2146;
                G_SCHED [ G_ISINGLEBUTTONSELECTSCHED] . ISETPOINT [ 0] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 0 ] ) , (ushort)( IADJUST ) , (short)( 33 ) , (short)( 316 ) ) ) ; 
                __context__.SourceCodeLine = 2147;
                SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 0 ] ))  ) ; 
                __context__.SourceCodeLine = 2149;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
                    {
                    __context__.SourceCodeLine = 2150;
                    UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                    }
                
                __context__.SourceCodeLine = 2152;
                break ; 
                } 
            
            goto case 2 ;
            case 2 : 
            
                { 
                __context__.SourceCodeLine = 2158;
                G_SCHED [ G_ISINGLEBUTTONSELECTSCHED] . ISETPOINT [ 1] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 1 ] ) , (ushort)( IADJUST ) , (short)( 150 ) , (short)( 372 ) ) ) ; 
                __context__.SourceCodeLine = 2159;
                SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 1 ] ))  ) ; 
                __context__.SourceCodeLine = 2161;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
                    {
                    __context__.SourceCodeLine = 2162;
                    UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                    }
                
                __context__.SourceCodeLine = 2164;
                break ; 
                } 
            
            goto case 3 ;
            case 3 : 
            
                { 
                __context__.SourceCodeLine = 2170;
                G_SCHED [ G_ISINGLEBUTTONSELECTSCHED] . ISETPOINT [ 2] = (ushort) ( ADJUSTTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (short)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 2 ] ) , (ushort)( IADJUST ) , (short)( 33 ) , (short)( 490 ) ) ) ; 
                __context__.SourceCodeLine = 2171;
                SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTEMP (  __context__ , (ushort)( TEMP_SCALE  .Value ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].ISETPOINT[ 2 ] ))  ) ; 
                __context__.SourceCodeLine = 2173;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GETCURRENTSCHEDULE( __context__ , (ushort)( Functions.GetHourNum() ) , (ushort)( Functions.GetMinutesNum() ) , (ushort)( Functions.GetDayOfWeekNum() ) ) == _SplusNVRAM.G_IEDITSCHEDULE))  ) ) 
                    {
                    __context__.SourceCodeLine = 2174;
                    UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                    }
                
                __context__.SourceCodeLine = 2176;
                break ; 
                } 
            
            break;
            } 
            
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AWAYDAY_INC_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2184;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IAWAYMSGINDEX == 0))  ) ) 
            {
            __context__.SourceCodeLine = 2185;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( (_SplusNVRAM.G_IAWAYMSGINDEX + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 2187;
        _SplusNVRAM.G_LTARGETJDAY = (uint) ( (_SplusNVRAM.G_LTARGETJDAY + 1) ) ; 
        __context__.SourceCodeLine = 2189;
        UPDATEAWAYMESSAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AWAYDAY_DEC_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2194;
        _SplusNVRAM.G_LTARGETJDAY = (uint) ( (_SplusNVRAM.G_LTARGETJDAY - 1) ) ; 
        __context__.SourceCodeLine = 2196;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_LTARGETJDAY <= G_TODAYJDAY ))  ) ) 
            { 
            __context__.SourceCodeLine = 2198;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2199;
            _SplusNVRAM.G_LTARGETJDAY = (uint) ( G_TODAYJDAY ) ; 
            } 
        
        __context__.SourceCodeLine = 2202;
        UPDATEAWAYMESSAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AWAYSCHED_INC_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 2207;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_IAWAYMSGINDEX < 4 ))  ) ) 
            {
            __context__.SourceCodeLine = 2208;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( (_SplusNVRAM.G_IAWAYMSGINDEX + 1) ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 2211;
            _SplusNVRAM.G_IAWAYMSGINDEX = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 2213;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_LTARGETJDAY <= G_TODAYJDAY ))  ) ) 
            {
            __context__.SourceCodeLine = 2214;
            _SplusNVRAM.G_LTARGETJDAY = (uint) ( (G_TODAYJDAY + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 2216;
        UPDATEAWAYMESSAGE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULEDCOOLSETPOINT_OnChange_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TEMPSP = 0;
        
        
        __context__.SourceCodeLine = 2223;
        TEMPSP = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( SCHEDULEDCOOLSETPOINT  .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 2225;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( TEMPSP <= 372 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( TEMPSP >= 150 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (AWAY_MODE_FB  .Value == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (HOLD_MODE_FB  .Value == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2227;
            SETPOINT [ (1 + 1)]  .Value = (ushort) ( SCHEDULEDCOOLSETPOINT  .UshortValue ) ; 
            __context__.SourceCodeLine = 2228;
            Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULEDHEATSETPOINT_OnChange_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TEMPSP = 0;
        
        
        __context__.SourceCodeLine = 2236;
        TEMPSP = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( SCHEDULEDHEATSETPOINT  .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 2238;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( TEMPSP <= 316 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( TEMPSP >= 33 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (AWAY_MODE_FB  .Value == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (HOLD_MODE_FB  .Value == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2240;
            SETPOINT [ (0 + 1)]  .Value = (ushort) ( SCHEDULEDHEATSETPOINT  .UshortValue ) ; 
            __context__.SourceCodeLine = 2241;
            Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULEDSLABSETPOINT_OnChange_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TEMPSP = 0;
        
        
        __context__.SourceCodeLine = 2249;
        TEMPSP = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( SCHEDULEDSLABSETPOINT  .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 2251;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( TEMPSP <= 490 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( TEMPSP >= 33 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (AWAY_MODE_FB  .Value == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (HOLD_MODE_FB  .Value == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2253;
            SETPOINT [ (2 + 1)]  .Value = (ushort) ( SCHEDULEDSLABSETPOINT  .UshortValue ) ; 
            __context__.SourceCodeLine = 2254;
            Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCHEDULEDAUTOSETPOINT_OnChange_40 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TEMPSP = 0;
        
        
        __context__.SourceCodeLine = 2262;
        TEMPSP = (ushort) ( GETRAWTEMP( __context__ , (ushort)( TEMP_SCALE  .Value ) , (ushort)( SCHEDULEDAUTOSETPOINT  .UshortValue ) ) ) ; 
        __context__.SourceCodeLine = 2264;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( TEMPSP <= 372 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( TEMPSP >= 33 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (AWAY_MODE_FB  .Value == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (HOLD_MODE_FB  .Value == 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2266;
            SETPOINT [ (3 + 1)]  .Value = (ushort) ( SCHEDULEDAUTOSETPOINT  .UshortValue ) ; 
            __context__.SourceCodeLine = 2267;
            Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    short IERRCODE = 0;
    
    FILE_INFO FIDATAFILE;
    FIDATAFILE  = new FILE_INFO();
    FIDATAFILE .PopulateDefaults();
    
    ushort ICURRENTHOUR = 0;
    ushort ICURRENTMIN = 0;
    ushort ICURRENTTIME = 0;
    ushort ICURRENTDAY = 0;
    
    ushort ILASTCHECKEDTIME = 0;
    ushort ILASTCHECKEDDAY = 0;
    
    ushort I = 0;
    ushort IOFFSET = 0;
    
    ushort INEWSCHEDULE = 0;
    
    ushort WKENDOFFSET = 0;
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 2282;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_ICURRENTSCHEDULE > 8 ))  ) ) 
            {
            __context__.SourceCodeLine = 2283;
            _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( 65535 ) ; 
            }
        
        __context__.SourceCodeLine = 2287;
        G_SCHED [ 0] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2288;
        G_SCHED [ 0] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2289;
        G_SCHED [ 0] . ISETPOINT [ 0] = (ushort) ( 220 ) ; 
        __context__.SourceCodeLine = 2290;
        G_SCHED [ 0] . ISETPOINT [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2291;
        G_SCHED [ 0] . ISETPOINT [ 2] = (ushort) ( 220 ) ; 
        __context__.SourceCodeLine = 2294;
        G_SCHED [ 1] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2295;
        G_SCHED [ 1] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2296;
        G_SCHED [ 1] . ISETPOINT [ 0] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2297;
        G_SCHED [ 1] . ISETPOINT [ 1] = (ushort) ( 290 ) ; 
        __context__.SourceCodeLine = 2298;
        G_SCHED [ 1] . ISETPOINT [ 2] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2301;
        G_SCHED [ 2] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2302;
        G_SCHED [ 2] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2303;
        G_SCHED [ 2] . ISETPOINT [ 0] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2304;
        G_SCHED [ 2] . ISETPOINT [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2305;
        G_SCHED [ 2] . ISETPOINT [ 2] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2308;
        G_SCHED [ 3] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2309;
        G_SCHED [ 3] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2310;
        G_SCHED [ 3] . ISETPOINT [ 0] = (ushort) ( 190 ) ; 
        __context__.SourceCodeLine = 2311;
        G_SCHED [ 3] . ISETPOINT [ 1] = (ushort) ( 240 ) ; 
        __context__.SourceCodeLine = 2312;
        G_SCHED [ 3] . ISETPOINT [ 2] = (ushort) ( 190 ) ; 
        __context__.SourceCodeLine = 2316;
        G_SCHED [ 4] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2317;
        G_SCHED [ 4] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2318;
        G_SCHED [ 4] . ISETPOINT [ 0] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2319;
        G_SCHED [ 4] . ISETPOINT [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2320;
        G_SCHED [ 4] . ISETPOINT [ 2] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2323;
        G_SCHED [ 5] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2324;
        G_SCHED [ 5] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2325;
        G_SCHED [ 5] . ISETPOINT [ 0] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2326;
        G_SCHED [ 5] . ISETPOINT [ 1] = (ushort) ( 290 ) ; 
        __context__.SourceCodeLine = 2327;
        G_SCHED [ 5] . ISETPOINT [ 2] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2330;
        G_SCHED [ 6] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2331;
        G_SCHED [ 6] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2332;
        G_SCHED [ 6] . ISETPOINT [ 0] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2333;
        G_SCHED [ 6] . ISETPOINT [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2334;
        G_SCHED [ 6] . ISETPOINT [ 2] = (ushort) ( 210 ) ; 
        __context__.SourceCodeLine = 2337;
        G_SCHED [ 7] . IHOUR = (short) ( -1 ) ; 
        __context__.SourceCodeLine = 2338;
        G_SCHED [ 7] . IMINUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2339;
        G_SCHED [ 7] . ISETPOINT [ 0] = (ushort) ( 190 ) ; 
        __context__.SourceCodeLine = 2340;
        G_SCHED [ 7] . ISETPOINT [ 1] = (ushort) ( 240 ) ; 
        __context__.SourceCodeLine = 2341;
        G_SCHED [ 7] . ISETPOINT [ 2] = (ushort) ( 190 ) ; 
        __context__.SourceCodeLine = 2344;
        G_SCHED [ 8] . ISETPOINT [ 0] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2345;
        G_SCHED [ 8] . ISETPOINT [ 1] = (ushort) ( 290 ) ; 
        __context__.SourceCodeLine = 2346;
        G_SCHED [ 8] . ISETPOINT [ 2] = (ushort) ( 170 ) ; 
        __context__.SourceCodeLine = 2349;
        _SplusNVRAM.G_IPREVSETPTS [ 0] = (ushort) ( 220 ) ; 
        __context__.SourceCodeLine = 2350;
        _SplusNVRAM.G_IPREVSETPTS [ 1] = (ushort) ( 250 ) ; 
        __context__.SourceCodeLine = 2351;
        _SplusNVRAM.G_IPREVSETPTS [ 2] = (ushort) ( 220 ) ; 
        __context__.SourceCodeLine = 2353;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.G_IEDITSCHEDULE < 0 ) ) || Functions.TestForTrue ( Functions.BoolToInt ( _SplusNVRAM.G_IEDITSCHEDULE > 7 ) )) ))  ) ) 
            {
            __context__.SourceCodeLine = 2354;
            _SplusNVRAM.G_IEDITSCHEDULE = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 2356;
        G_BIGNORESINGLEBUTTONRELEASE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2357;
        G_ISINGLEBUTTONSELECTCAT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2358;
        G_ISINGLEBUTTONSELECTSCHED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2359;
        G_ISINGLEBUTTONADJUSTDIR = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2360;
        SINGLE_BUTTON_SELECT__DOLLAR__  .UpdateValue ( "Wkday Wake: Time"  ) ; 
        __context__.SourceCodeLine = 2362;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 2365;
        if ( Functions.TestForTrue  ( ( USE_DEFAULT_SCHEDULE_TIMES  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 2368;
            G_SCHED [ 0] . IHOUR = (short) ( 6 ) ; 
            __context__.SourceCodeLine = 2369;
            G_SCHED [ 1] . IHOUR = (short) ( 8 ) ; 
            __context__.SourceCodeLine = 2370;
            G_SCHED [ 2] . IHOUR = (short) ( 17 ) ; 
            __context__.SourceCodeLine = 2371;
            G_SCHED [ 3] . IHOUR = (short) ( 22 ) ; 
            __context__.SourceCodeLine = 2374;
            G_SCHED [ 4] . IHOUR = (short) ( 6 ) ; 
            __context__.SourceCodeLine = 2375;
            G_SCHED [ 5] . IHOUR = (short) ( 8 ) ; 
            __context__.SourceCodeLine = 2376;
            G_SCHED [ 6] . IHOUR = (short) ( 17 ) ; 
            __context__.SourceCodeLine = 2377;
            G_SCHED [ 7] . IHOUR = (short) ( 22 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2382;
            G_SCHED [ 0] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2383;
            G_SCHED [ 1] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2384;
            G_SCHED [ 2] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2385;
            G_SCHED [ 3] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2388;
            G_SCHED [ 4] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2389;
            G_SCHED [ 5] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2390;
            G_SCHED [ 6] . IHOUR = (short) ( -1 ) ; 
            __context__.SourceCodeLine = 2391;
            G_SCHED [ 7] . IHOUR = (short) ( -1 ) ; 
            } 
        
        __context__.SourceCodeLine = 2395;
        LOADSCHEDULES (  __context__  ) ; 
        __context__.SourceCodeLine = 2397;
        Functions.Delay (  (int) ( 100 ) ) ; 
        __context__.SourceCodeLine = 2400;
        SINGLE_BUTTON_ADJUST__DOLLAR__  .UpdateValue ( GETDISPLAYTIME (  __context__ , (short)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IHOUR ), (ushort)( G_SCHED[ G_ISINGLEBUTTONSELECTSCHED ].IMINUTE ))  ) ; 
        __context__.SourceCodeLine = 2402;
        CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
        __context__.SourceCodeLine = 2403;
        G_TODAYJDAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (ushort)( Functions.GetMonthNum() ) , (ushort)( Functions.GetDateNum() ) , (ushort)( Functions.GetYearNum() ) ) ) ) ) ; 
        __context__.SourceCodeLine = 2405;
        ILASTCHECKEDTIME = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
        __context__.SourceCodeLine = 2406;
        ILASTCHECKEDDAY = (ushort) ( Functions.ToInteger( -( 1 ) ) ) ; 
        __context__.SourceCodeLine = 2411;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 2414;
            ICURRENTHOUR = (ushort) ( Functions.GetHourNum() ) ; 
            __context__.SourceCodeLine = 2415;
            ICURRENTDAY = (ushort) ( Functions.GetDayOfWeekNum() ) ; 
            __context__.SourceCodeLine = 2417;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ICURRENTHOUR >= 12 ))  ) ) 
                {
                __context__.SourceCodeLine = 2418;
                PM_FB  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 2420;
                PM_FB  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 2422;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ICURRENTDAY != CURRENT_DAYOFWEEK  .Value))  ) ) 
                { 
                __context__.SourceCodeLine = 2424;
                CURRENT_DAYOFWEEK  .Value = (ushort) ( ICURRENTDAY ) ; 
                __context__.SourceCodeLine = 2425;
                G_TODAYJDAY = (uint) ( GETJDAY( __context__ , (uint)( CREATEDATEL( __context__ , (ushort)( Functions.GetMonthNum() ) , (ushort)( Functions.GetDateNum() ) , (ushort)( Functions.GetYearNum() ) ) ) ) ) ; 
                } 
            
            __context__.SourceCodeLine = 2428;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_ICURRENTSCHEDULE != 8))  ) ) 
                { 
                __context__.SourceCodeLine = 2431;
                ICURRENTMIN = (ushort) ( Functions.GetMinutesNum() ) ; 
                __context__.SourceCodeLine = 2432;
                ICURRENTTIME = (ushort) ( ((ICURRENTHOUR * 60) + ICURRENTMIN) ) ; 
                __context__.SourceCodeLine = 2434;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ILASTCHECKEDTIME != ICURRENTTIME) ) || Functions.TestForTrue ( Functions.BoolToInt (ILASTCHECKEDDAY != ICURRENTDAY) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2436;
                    
                    __context__.SourceCodeLine = 2441;
                    INEWSCHEDULE = (ushort) ( GETCURRENTSCHEDULE( __context__ , (ushort)( ICURRENTHOUR ) , (ushort)( ICURRENTMIN ) , (ushort)( ICURRENTDAY ) ) ) ; 
                    __context__.SourceCodeLine = 2443;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INEWSCHEDULE == 65535))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2445;
                        _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( 65535 ) ; 
                        __context__.SourceCodeLine = 2446;
                        CURRENT_SCHEDULE  .Value = (ushort) ( 65535 ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 2448;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (G_SCHED[ INEWSCHEDULE ].IHOUR != -1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2452;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INEWSCHEDULE != _SplusNVRAM.G_ICURRENTSCHEDULE))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2454;
                                _SplusNVRAM.G_ICURRENTSCHEDULE = (ushort) ( INEWSCHEDULE ) ; 
                                __context__.SourceCodeLine = 2455;
                                CURRENT_SCHEDULE  .Value = (ushort) ( _SplusNVRAM.G_ICURRENTSCHEDULE ) ; 
                                __context__.SourceCodeLine = 2456;
                                UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                                __context__.SourceCodeLine = 2457;
                                Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 2463;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (GETSCHEDULEMINUTES( __context__ , G_SCHED[ _SplusNVRAM.G_ICURRENTSCHEDULE ] ) == ICURRENTTIME) ) && Functions.TestForTrue ( DOESSCHEDULEOCCURONDAY( __context__ , (ushort)( _SplusNVRAM.G_ICURRENTSCHEDULE ) , (ushort)( ICURRENTDAY ) ) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2465;
                                    UPDATECURRENTSCHEDULESETPOINTS (  __context__  ) ; 
                                    __context__.SourceCodeLine = 2466;
                                    Functions.Pulse ( 10, SCHEDULE_DUE ) ; 
                                    } 
                                
                                }
                            
                            } 
                        
                        }
                    
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2473;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_IAWAYMSGINDEX != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2475;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _SplusNVRAM.G_LTARGETJDAY < G_TODAYJDAY ))  ) ) 
                        {
                        __context__.SourceCodeLine = 2476;
                        Functions.Pulse ( 10, RUN ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 2478;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.G_LTARGETJDAY == G_TODAYJDAY))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2480;
                            ICURRENTMIN = (ushort) ( Functions.GetMinutesNum() ) ; 
                            __context__.SourceCodeLine = 2481;
                            ICURRENTTIME = (ushort) ( ((ICURRENTHOUR * 60) + ICURRENTMIN) ) ; 
                            __context__.SourceCodeLine = 2483;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (ILASTCHECKEDTIME != ICURRENTTIME) ) || Functions.TestForTrue ( Functions.BoolToInt (ILASTCHECKEDDAY != ICURRENTDAY) )) ))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2486;
                                INEWSCHEDULE = (ushort) ( GETCURRENTSCHEDULE( __context__ , (ushort)( ICURRENTHOUR ) , (ushort)( ICURRENTMIN ) , (ushort)( ICURRENTDAY ) ) ) ; 
                                __context__.SourceCodeLine = 2489;
                                switch ((int)ICURRENTDAY)
                                
                                    { 
                                    case 0 : 
                                    
                                        { 
                                        __context__.SourceCodeLine = 2493;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( SUNDAY_NIGHT_IS_WEEKDAY  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.G_IAWAYMSGINDEX == 4) )) ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 2494;
                                            WKENDOFFSET = (ushort) ( 0 ) ; 
                                            }
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 2496;
                                            WKENDOFFSET = (ushort) ( 4 ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 2498;
                                        break ; 
                                        } 
                                    
                                    goto case 5 ;
                                    case 5 : 
                                    
                                        { 
                                        __context__.SourceCodeLine = 2503;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( FRIDAY_NIGHT_IS_WEEKEND  .Value ) && Functions.TestForTrue ( Functions.BoolToInt (_SplusNVRAM.G_IAWAYMSGINDEX == 4) )) ))  ) ) 
                                            {
                                            __context__.SourceCodeLine = 2504;
                                            WKENDOFFSET = (ushort) ( 4 ) ; 
                                            }
                                        
                                        __context__.SourceCodeLine = 2506;
                                        break ; 
                                        } 
                                    
                                    goto case 6 ;
                                    case 6 : 
                                    
                                        { 
                                        __context__.SourceCodeLine = 2511;
                                        WKENDOFFSET = (ushort) ( 4 ) ; 
                                        __context__.SourceCodeLine = 2512;
                                        break ; 
                                        } 
                                    
                                    goto default;
                                    default : 
                                    
                                        { 
                                        __context__.SourceCodeLine = 2515;
                                        WKENDOFFSET = (ushort) ( 0 ) ; 
                                        } 
                                    break;
                                    
                                    } 
                                    
                                
                                __context__.SourceCodeLine = 2518;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (INEWSCHEDULE != 3) ) && Functions.TestForTrue ( Functions.BoolToInt (INEWSCHEDULE != 7) )) ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2520;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( INEWSCHEDULE >= ((_SplusNVRAM.G_IAWAYMSGINDEX + WKENDOFFSET) - 1) ))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 2521;
                                        Functions.Pulse ( 10, RUN ) ; 
                                        }
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 2524;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( INEWSCHEDULE >= ((_SplusNVRAM.G_IAWAYMSGINDEX + WKENDOFFSET) - 1) ) ) && Functions.TestForTrue ( PM_FB  .Value )) ))  ) ) 
                                        {
                                        __context__.SourceCodeLine = 2525;
                                        Functions.Pulse ( 10, RUN ) ; 
                                        }
                                    
                                    }
                                
                                } 
                            
                            } 
                        
                        }
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 2531;
            ILASTCHECKEDTIME = (ushort) ( ICURRENTTIME ) ; 
            __context__.SourceCodeLine = 2532;
            ILASTCHECKEDDAY = (ushort) ( ICURRENTDAY ) ; 
            __context__.SourceCodeLine = 2534;
            Functions.Delay (  (int) ( 1000 ) ) ; 
            __context__.SourceCodeLine = 2411;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.G_IPREVSETPTS  = new ushort[ 4 ];
    G_SCHED  = new SCHEDULE[ 9 ];
    for( uint i = 0; i < 9; i++ )
    {
        G_SCHED [i] = new SCHEDULE( this, true );
        G_SCHED [i].PopulateCustomAttributeList( false );
        
    }
    
    WEEKDAY_WAKE = new Crestron.Logos.SplusObjects.DigitalInput( WEEKDAY_WAKE__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKDAY_WAKE__DigitalInput__, WEEKDAY_WAKE );
    
    WEEKDAY_LEAVE = new Crestron.Logos.SplusObjects.DigitalInput( WEEKDAY_LEAVE__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKDAY_LEAVE__DigitalInput__, WEEKDAY_LEAVE );
    
    WEEKDAY_RETURN = new Crestron.Logos.SplusObjects.DigitalInput( WEEKDAY_RETURN__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKDAY_RETURN__DigitalInput__, WEEKDAY_RETURN );
    
    WEEKDAY_SLEEP = new Crestron.Logos.SplusObjects.DigitalInput( WEEKDAY_SLEEP__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKDAY_SLEEP__DigitalInput__, WEEKDAY_SLEEP );
    
    WEEKEND_WAKE = new Crestron.Logos.SplusObjects.DigitalInput( WEEKEND_WAKE__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKEND_WAKE__DigitalInput__, WEEKEND_WAKE );
    
    WEEKEND_LEAVE = new Crestron.Logos.SplusObjects.DigitalInput( WEEKEND_LEAVE__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKEND_LEAVE__DigitalInput__, WEEKEND_LEAVE );
    
    WEEKEND_RETURN = new Crestron.Logos.SplusObjects.DigitalInput( WEEKEND_RETURN__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKEND_RETURN__DigitalInput__, WEEKEND_RETURN );
    
    WEEKEND_SLEEP = new Crestron.Logos.SplusObjects.DigitalInput( WEEKEND_SLEEP__DigitalInput__, this );
    m_DigitalInputList.Add( WEEKEND_SLEEP__DigitalInput__, WEEKEND_SLEEP );
    
    AWAY = new Crestron.Logos.SplusObjects.DigitalInput( AWAY__DigitalInput__, this );
    m_DigitalInputList.Add( AWAY__DigitalInput__, AWAY );
    
    TIME_UP = new Crestron.Logos.SplusObjects.DigitalInput( TIME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_UP__DigitalInput__, TIME_UP );
    
    TIME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( TIME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( TIME_DOWN__DigitalInput__, TIME_DOWN );
    
    HOUR_UP = new Crestron.Logos.SplusObjects.DigitalInput( HOUR_UP__DigitalInput__, this );
    m_DigitalInputList.Add( HOUR_UP__DigitalInput__, HOUR_UP );
    
    HOUR_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( HOUR_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( HOUR_DOWN__DigitalInput__, HOUR_DOWN );
    
    MINUTE_UP = new Crestron.Logos.SplusObjects.DigitalInput( MINUTE_UP__DigitalInput__, this );
    m_DigitalInputList.Add( MINUTE_UP__DigitalInput__, MINUTE_UP );
    
    MINUTE_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( MINUTE_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( MINUTE_DOWN__DigitalInput__, MINUTE_DOWN );
    
    HEAT_SETPOINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( HEAT_SETPOINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( HEAT_SETPOINT_UP__DigitalInput__, HEAT_SETPOINT_UP );
    
    HEAT_SETPOINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( HEAT_SETPOINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( HEAT_SETPOINT_DOWN__DigitalInput__, HEAT_SETPOINT_DOWN );
    
    COOL_SETPOINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( COOL_SETPOINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( COOL_SETPOINT_UP__DigitalInput__, COOL_SETPOINT_UP );
    
    COOL_SETPOINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( COOL_SETPOINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( COOL_SETPOINT_DOWN__DigitalInput__, COOL_SETPOINT_DOWN );
    
    SLAB_SETPOINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( SLAB_SETPOINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( SLAB_SETPOINT_UP__DigitalInput__, SLAB_SETPOINT_UP );
    
    SLAB_SETPOINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( SLAB_SETPOINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( SLAB_SETPOINT_DOWN__DigitalInput__, SLAB_SETPOINT_DOWN );
    
    AUTO_SETPOINT_UP = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_SETPOINT_UP__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_SETPOINT_UP__DigitalInput__, AUTO_SETPOINT_UP );
    
    AUTO_SETPOINT_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_SETPOINT_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_SETPOINT_DOWN__DigitalInput__, AUTO_SETPOINT_DOWN );
    
    REMOVE_SCHEDULE = new Crestron.Logos.SplusObjects.DigitalInput( REMOVE_SCHEDULE__DigitalInput__, this );
    m_DigitalInputList.Add( REMOVE_SCHEDULE__DigitalInput__, REMOVE_SCHEDULE );
    
    RESET_SCHEDULES = new Crestron.Logos.SplusObjects.DigitalInput( RESET_SCHEDULES__DigitalInput__, this );
    m_DigitalInputList.Add( RESET_SCHEDULES__DigitalInput__, RESET_SCHEDULES );
    
    TEMP_SCALE = new Crestron.Logos.SplusObjects.DigitalInput( TEMP_SCALE__DigitalInput__, this );
    m_DigitalInputList.Add( TEMP_SCALE__DigitalInput__, TEMP_SCALE );
    
    HALF_DEGREE_C_STEPS = new Crestron.Logos.SplusObjects.DigitalInput( HALF_DEGREE_C_STEPS__DigitalInput__, this );
    m_DigitalInputList.Add( HALF_DEGREE_C_STEPS__DigitalInput__, HALF_DEGREE_C_STEPS );
    
    RUN_PROGRAM = new Crestron.Logos.SplusObjects.DigitalInput( RUN_PROGRAM__DigitalInput__, this );
    m_DigitalInputList.Add( RUN_PROGRAM__DigitalInput__, RUN_PROGRAM );
    
    RUN_AWAY = new Crestron.Logos.SplusObjects.DigitalInput( RUN_AWAY__DigitalInput__, this );
    m_DigitalInputList.Add( RUN_AWAY__DigitalInput__, RUN_AWAY );
    
    RUN_HOLD = new Crestron.Logos.SplusObjects.DigitalInput( RUN_HOLD__DigitalInput__, this );
    m_DigitalInputList.Add( RUN_HOLD__DigitalInput__, RUN_HOLD );
    
    SINGLE_BUTTON_SELECT = new Crestron.Logos.SplusObjects.DigitalInput( SINGLE_BUTTON_SELECT__DigitalInput__, this );
    m_DigitalInputList.Add( SINGLE_BUTTON_SELECT__DigitalInput__, SINGLE_BUTTON_SELECT );
    
    SINGLE_BUTTON_ADJUST = new Crestron.Logos.SplusObjects.DigitalInput( SINGLE_BUTTON_ADJUST__DigitalInput__, this );
    m_DigitalInputList.Add( SINGLE_BUTTON_ADJUST__DigitalInput__, SINGLE_BUTTON_ADJUST );
    
    USE_DEFAULT_SCHEDULE_TIMES = new Crestron.Logos.SplusObjects.DigitalInput( USE_DEFAULT_SCHEDULE_TIMES__DigitalInput__, this );
    m_DigitalInputList.Add( USE_DEFAULT_SCHEDULE_TIMES__DigitalInput__, USE_DEFAULT_SCHEDULE_TIMES );
    
    SUNDAY_NIGHT_IS_WEEKDAY = new Crestron.Logos.SplusObjects.DigitalInput( SUNDAY_NIGHT_IS_WEEKDAY__DigitalInput__, this );
    m_DigitalInputList.Add( SUNDAY_NIGHT_IS_WEEKDAY__DigitalInput__, SUNDAY_NIGHT_IS_WEEKDAY );
    
    FRIDAY_NIGHT_IS_WEEKEND = new Crestron.Logos.SplusObjects.DigitalInput( FRIDAY_NIGHT_IS_WEEKEND__DigitalInput__, this );
    m_DigitalInputList.Add( FRIDAY_NIGHT_IS_WEEKEND__DigitalInput__, FRIDAY_NIGHT_IS_WEEKEND );
    
    AWAYDAY_INC = new Crestron.Logos.SplusObjects.DigitalInput( AWAYDAY_INC__DigitalInput__, this );
    m_DigitalInputList.Add( AWAYDAY_INC__DigitalInput__, AWAYDAY_INC );
    
    AWAYDAY_DEC = new Crestron.Logos.SplusObjects.DigitalInput( AWAYDAY_DEC__DigitalInput__, this );
    m_DigitalInputList.Add( AWAYDAY_DEC__DigitalInput__, AWAYDAY_DEC );
    
    AWAYSCHED_INC = new Crestron.Logos.SplusObjects.DigitalInput( AWAYSCHED_INC__DigitalInput__, this );
    m_DigitalInputList.Add( AWAYSCHED_INC__DigitalInput__, AWAYSCHED_INC );
    
    SLAB_SP_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( SLAB_SP_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( SLAB_SP_ENABLED__DigitalInput__, SLAB_SP_ENABLED );
    
    AUTO_MODE_ENABLED = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_MODE_ENABLED__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_MODE_ENABLED__DigitalInput__, AUTO_MODE_ENABLED );
    
    SCHEDULE_DUE = new Crestron.Logos.SplusObjects.DigitalOutput( SCHEDULE_DUE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCHEDULE_DUE__DigitalOutput__, SCHEDULE_DUE );
    
    PM_FB = new Crestron.Logos.SplusObjects.DigitalOutput( PM_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( PM_FB__DigitalOutput__, PM_FB );
    
    RUN = new Crestron.Logos.SplusObjects.DigitalOutput( RUN__DigitalOutput__, this );
    m_DigitalOutputList.Add( RUN__DigitalOutput__, RUN );
    
    AWAY_MODE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( AWAY_MODE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( AWAY_MODE_FB__DigitalOutput__, AWAY_MODE_FB );
    
    HOLD_MODE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( HOLD_MODE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( HOLD_MODE_FB__DigitalOutput__, HOLD_MODE_FB );
    
    CURRENT_HEAT_SP = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_HEAT_SP__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_HEAT_SP__AnalogSerialInput__, CURRENT_HEAT_SP );
    
    CURRENT_COOL_SP = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_COOL_SP__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_COOL_SP__AnalogSerialInput__, CURRENT_COOL_SP );
    
    CURRENT_SLAB_SP = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_SLAB_SP__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_SLAB_SP__AnalogSerialInput__, CURRENT_SLAB_SP );
    
    CURRENT_AUTO_SP = new Crestron.Logos.SplusObjects.AnalogInput( CURRENT_AUTO_SP__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CURRENT_AUTO_SP__AnalogSerialInput__, CURRENT_AUTO_SP );
    
    INSTANCE_ID = new Crestron.Logos.SplusObjects.AnalogInput( INSTANCE_ID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INSTANCE_ID__AnalogSerialInput__, INSTANCE_ID );
    
    SCHEDULEDHEATSETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( SCHEDULEDHEATSETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCHEDULEDHEATSETPOINT__AnalogSerialInput__, SCHEDULEDHEATSETPOINT );
    
    SCHEDULEDCOOLSETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( SCHEDULEDCOOLSETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCHEDULEDCOOLSETPOINT__AnalogSerialInput__, SCHEDULEDCOOLSETPOINT );
    
    SCHEDULEDSLABSETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( SCHEDULEDSLABSETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCHEDULEDSLABSETPOINT__AnalogSerialInput__, SCHEDULEDSLABSETPOINT );
    
    SCHEDULEDAUTOSETPOINT = new Crestron.Logos.SplusObjects.AnalogInput( SCHEDULEDAUTOSETPOINT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCHEDULEDAUTOSETPOINT__AnalogSerialInput__, SCHEDULEDAUTOSETPOINT );
    
    DEADBAND = new Crestron.Logos.SplusObjects.AnalogInput( DEADBAND__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DEADBAND__AnalogSerialInput__, DEADBAND );
    
    CURRENT_SCHEDULE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_SCHEDULE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_SCHEDULE__AnalogSerialOutput__, CURRENT_SCHEDULE );
    
    CURRENT_DAYOFWEEK = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_DAYOFWEEK__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_DAYOFWEEK__AnalogSerialOutput__, CURRENT_DAYOFWEEK );
    
    SETPOINT = new InOutArray<AnalogOutput>( 4, this );
    for( uint i = 0; i < 4; i++ )
    {
        SETPOINT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SETPOINT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SETPOINT__AnalogSerialOutput__ + i, SETPOINT[i+1] );
    }
    
    PATH__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PATH__DOLLAR____AnalogSerialInput__, 100, this );
    m_StringInputList.Add( PATH__DOLLAR____AnalogSerialInput__, PATH__DOLLAR__ );
    
    SCHEDULE_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SCHEDULE_NAME__DOLLAR____AnalogSerialOutput__, SCHEDULE_NAME__DOLLAR__ );
    
    SCHEDULE_TIME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_TIME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SCHEDULE_TIME__DOLLAR____AnalogSerialOutput__, SCHEDULE_TIME__DOLLAR__ );
    
    SINGLE_BUTTON_SELECT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SINGLE_BUTTON_SELECT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SINGLE_BUTTON_SELECT__DOLLAR____AnalogSerialOutput__, SINGLE_BUTTON_SELECT__DOLLAR__ );
    
    SINGLE_BUTTON_ADJUST__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( SINGLE_BUTTON_ADJUST__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( SINGLE_BUTTON_ADJUST__DOLLAR____AnalogSerialOutput__, SINGLE_BUTTON_ADJUST__DOLLAR__ );
    
    AWAY_SCHEDULE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AWAY_SCHEDULE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AWAY_SCHEDULE__DOLLAR____AnalogSerialOutput__, AWAY_SCHEDULE__DOLLAR__ );
    
    AWAY_DATE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AWAY_DATE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AWAY_DATE__DOLLAR____AnalogSerialOutput__, AWAY_DATE__DOLLAR__ );
    
    AWAY_SCHEDULE_SHORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AWAY_SCHEDULE_SHORT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AWAY_SCHEDULE_SHORT__DOLLAR____AnalogSerialOutput__, AWAY_SCHEDULE_SHORT__DOLLAR__ );
    
    AWAY_DATE_SHORT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( AWAY_DATE_SHORT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( AWAY_DATE_SHORT__DOLLAR____AnalogSerialOutput__, AWAY_DATE_SHORT__DOLLAR__ );
    
    SCHEDULE_SETPOINT__DOLLAR__ = new InOutArray<StringOutput>( 4, this );
    for( uint i = 0; i < 4; i++ )
    {
        SCHEDULE_SETPOINT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SCHEDULE_SETPOINT__DOLLAR____AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SCHEDULE_SETPOINT__DOLLAR____AnalogSerialOutput__ + i, SCHEDULE_SETPOINT__DOLLAR__[i+1] );
    }
    
    WAIT_SAVE_Callback = new WaitFunction( WAIT_SAVE_CallbackFn );
    SBA_WAIT_1_Callback = new WaitFunction( SBA_WAIT_1_CallbackFn );
    SBA_WAIT_2_Callback = new WaitFunction( SBA_WAIT_2_CallbackFn );
    
    WEEKDAY_WAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_0, false ) );
    WEEKDAY_LEAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_LEAVE_OnPush_1, false ) );
    WEEKDAY_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_RETURN_OnPush_2, false ) );
    WEEKDAY_SLEEP.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_SLEEP_OnPush_3, false ) );
    WEEKEND_WAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKEND_WAKE_OnPush_4, false ) );
    WEEKEND_LEAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKEND_LEAVE_OnPush_5, false ) );
    WEEKEND_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKEND_RETURN_OnPush_6, false ) );
    WEEKEND_SLEEP.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKEND_SLEEP_OnPush_7, false ) );
    WEEKDAY_WAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_8, false ) );
    WEEKDAY_LEAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_8, false ) );
    WEEKDAY_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_8, false ) );
    WEEKDAY_SLEEP.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_8, false ) );
    WEEKEND_WAKE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_8, false ) );
    WEEKEND_LEAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_8, false ) );
    WEEKEND_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_8, false ) );
    WEEKEND_SLEEP.OnDigitalPush.Add( new InputChangeHandlerWrapper( WEEKDAY_WAKE_OnPush_8, false ) );
    AWAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( AWAY_OnPush_9, false ) );
    HOUR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_10, false ) );
    HOUR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_DOWN_OnPush_11, false ) );
    TIME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_UP_OnPush_12, false ) );
    TIME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( TIME_DOWN_OnPush_13, false ) );
    MINUTE_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( MINUTE_UP_OnPush_14, false ) );
    MINUTE_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MINUTE_DOWN_OnPush_15, false ) );
    HEAT_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HEAT_SETPOINT_UP_OnPush_16, false ) );
    HEAT_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HEAT_SETPOINT_DOWN_OnPush_17, false ) );
    COOL_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( COOL_SETPOINT_UP_OnPush_18, false ) );
    COOL_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( COOL_SETPOINT_DOWN_OnPush_19, false ) );
    SLAB_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( SLAB_SETPOINT_UP_OnPush_20, false ) );
    SLAB_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SLAB_SETPOINT_DOWN_OnPush_21, false ) );
    AUTO_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_SETPOINT_UP_OnPush_22, false ) );
    AUTO_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_SETPOINT_DOWN_OnPush_23, false ) );
    REMOVE_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( REMOVE_SCHEDULE_OnPush_24, false ) );
    HOUR_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    HOUR_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    MINUTE_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    MINUTE_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    TIME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    TIME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    AUTO_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    AUTO_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    HEAT_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    HEAT_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    COOL_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    COOL_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    REMOVE_SCHEDULE.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    SINGLE_BUTTON_ADJUST.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    SLAB_SETPOINT_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    SLAB_SETPOINT_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOUR_UP_OnPush_25, false ) );
    TEMP_SCALE.OnDigitalChange.Add( new InputChangeHandlerWrapper( TEMP_SCALE_OnChange_26, false ) );
    HALF_DEGREE_C_STEPS.OnDigitalChange.Add( new InputChangeHandlerWrapper( TEMP_SCALE_OnChange_26, false ) );
    TEMP_SCALE.OnDigitalChange.Add( new InputChangeHandlerWrapper( TEMP_SCALE_OnChange_27, false ) );
    HALF_DEGREE_C_STEPS.OnDigitalChange.Add( new InputChangeHandlerWrapper( TEMP_SCALE_OnChange_27, false ) );
    RUN_PROGRAM.OnDigitalPush.Add( new InputChangeHandlerWrapper( RUN_PROGRAM_OnPush_28, false ) );
    RUN_AWAY.OnDigitalPush.Add( new InputChangeHandlerWrapper( RUN_AWAY_OnPush_29, false ) );
    RUN_HOLD.OnDigitalPush.Add( new InputChangeHandlerWrapper( RUN_HOLD_OnPush_30, false ) );
    SINGLE_BUTTON_SELECT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SINGLE_BUTTON_SELECT_OnPush_31, false ) );
    SINGLE_BUTTON_ADJUST.OnDigitalPush.Add( new InputChangeHandlerWrapper( SINGLE_BUTTON_ADJUST_OnPush_32, false ) );
    SINGLE_BUTTON_ADJUST.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SINGLE_BUTTON_ADJUST_OnRelease_33, false ) );
    AWAYDAY_INC.OnDigitalPush.Add( new InputChangeHandlerWrapper( AWAYDAY_INC_OnPush_34, false ) );
    AWAYDAY_DEC.OnDigitalPush.Add( new InputChangeHandlerWrapper( AWAYDAY_DEC_OnPush_35, false ) );
    AWAYSCHED_INC.OnDigitalPush.Add( new InputChangeHandlerWrapper( AWAYSCHED_INC_OnPush_36, false ) );
    SCHEDULEDCOOLSETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCHEDULEDCOOLSETPOINT_OnChange_37, false ) );
    SCHEDULEDHEATSETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCHEDULEDHEATSETPOINT_OnChange_38, false ) );
    SCHEDULEDSLABSETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCHEDULEDSLABSETPOINT_OnChange_39, false ) );
    SCHEDULEDAUTOSETPOINT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCHEDULEDAUTOSETPOINT_OnChange_40, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_TSTAT_SCH_2_4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction WAIT_SAVE_Callback;
private WaitFunction SBA_WAIT_1_Callback;
private WaitFunction SBA_WAIT_2_Callback;


const uint WEEKDAY_WAKE__DigitalInput__ = 0;
const uint WEEKDAY_LEAVE__DigitalInput__ = 1;
const uint WEEKDAY_RETURN__DigitalInput__ = 2;
const uint WEEKDAY_SLEEP__DigitalInput__ = 3;
const uint WEEKEND_WAKE__DigitalInput__ = 4;
const uint WEEKEND_LEAVE__DigitalInput__ = 5;
const uint WEEKEND_RETURN__DigitalInput__ = 6;
const uint WEEKEND_SLEEP__DigitalInput__ = 7;
const uint AWAY__DigitalInput__ = 8;
const uint TIME_UP__DigitalInput__ = 9;
const uint TIME_DOWN__DigitalInput__ = 10;
const uint HOUR_UP__DigitalInput__ = 11;
const uint HOUR_DOWN__DigitalInput__ = 12;
const uint MINUTE_UP__DigitalInput__ = 13;
const uint MINUTE_DOWN__DigitalInput__ = 14;
const uint HEAT_SETPOINT_UP__DigitalInput__ = 15;
const uint HEAT_SETPOINT_DOWN__DigitalInput__ = 16;
const uint COOL_SETPOINT_UP__DigitalInput__ = 17;
const uint COOL_SETPOINT_DOWN__DigitalInput__ = 18;
const uint SLAB_SETPOINT_UP__DigitalInput__ = 19;
const uint SLAB_SETPOINT_DOWN__DigitalInput__ = 20;
const uint AUTO_SETPOINT_UP__DigitalInput__ = 21;
const uint AUTO_SETPOINT_DOWN__DigitalInput__ = 22;
const uint REMOVE_SCHEDULE__DigitalInput__ = 23;
const uint RESET_SCHEDULES__DigitalInput__ = 24;
const uint TEMP_SCALE__DigitalInput__ = 25;
const uint HALF_DEGREE_C_STEPS__DigitalInput__ = 26;
const uint RUN_PROGRAM__DigitalInput__ = 27;
const uint RUN_AWAY__DigitalInput__ = 28;
const uint RUN_HOLD__DigitalInput__ = 29;
const uint SINGLE_BUTTON_SELECT__DigitalInput__ = 30;
const uint SINGLE_BUTTON_ADJUST__DigitalInput__ = 31;
const uint USE_DEFAULT_SCHEDULE_TIMES__DigitalInput__ = 32;
const uint SUNDAY_NIGHT_IS_WEEKDAY__DigitalInput__ = 33;
const uint FRIDAY_NIGHT_IS_WEEKEND__DigitalInput__ = 34;
const uint AWAYDAY_INC__DigitalInput__ = 35;
const uint AWAYDAY_DEC__DigitalInput__ = 36;
const uint AWAYSCHED_INC__DigitalInput__ = 37;
const uint SLAB_SP_ENABLED__DigitalInput__ = 38;
const uint AUTO_MODE_ENABLED__DigitalInput__ = 39;
const uint CURRENT_HEAT_SP__AnalogSerialInput__ = 0;
const uint CURRENT_COOL_SP__AnalogSerialInput__ = 1;
const uint CURRENT_SLAB_SP__AnalogSerialInput__ = 2;
const uint CURRENT_AUTO_SP__AnalogSerialInput__ = 3;
const uint INSTANCE_ID__AnalogSerialInput__ = 4;
const uint PATH__DOLLAR____AnalogSerialInput__ = 5;
const uint SCHEDULEDHEATSETPOINT__AnalogSerialInput__ = 6;
const uint SCHEDULEDCOOLSETPOINT__AnalogSerialInput__ = 7;
const uint SCHEDULEDSLABSETPOINT__AnalogSerialInput__ = 8;
const uint SCHEDULEDAUTOSETPOINT__AnalogSerialInput__ = 9;
const uint DEADBAND__AnalogSerialInput__ = 10;
const uint SCHEDULE_DUE__DigitalOutput__ = 0;
const uint PM_FB__DigitalOutput__ = 1;
const uint RUN__DigitalOutput__ = 2;
const uint AWAY_MODE_FB__DigitalOutput__ = 3;
const uint HOLD_MODE_FB__DigitalOutput__ = 4;
const uint CURRENT_SCHEDULE__AnalogSerialOutput__ = 0;
const uint CURRENT_DAYOFWEEK__AnalogSerialOutput__ = 1;
const uint SCHEDULE_NAME__DOLLAR____AnalogSerialOutput__ = 2;
const uint SCHEDULE_TIME__DOLLAR____AnalogSerialOutput__ = 3;
const uint SINGLE_BUTTON_SELECT__DOLLAR____AnalogSerialOutput__ = 4;
const uint SINGLE_BUTTON_ADJUST__DOLLAR____AnalogSerialOutput__ = 5;
const uint AWAY_SCHEDULE__DOLLAR____AnalogSerialOutput__ = 6;
const uint AWAY_DATE__DOLLAR____AnalogSerialOutput__ = 7;
const uint AWAY_SCHEDULE_SHORT__DOLLAR____AnalogSerialOutput__ = 8;
const uint AWAY_DATE_SHORT__DOLLAR____AnalogSerialOutput__ = 9;
const uint SCHEDULE_SETPOINT__DOLLAR____AnalogSerialOutput__ = 10;
const uint SETPOINT__AnalogSerialOutput__ = 14;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort G_IEDITSCHEDULE = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort G_IAWAYMSGINDEX = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort [] G_IPREVSETPTS;
            [SplusStructAttribute(3, false, true)]
            public ushort G_ICURRENTSCHEDULE = 0;
            [SplusStructAttribute(4, false, true)]
            public uint G_LTARGETJDAY = 0;
            
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}

[SplusStructAttribute(-1, true, false)]
public class SCHEDULE : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public short  IHOUR = 0;
    
    [SplusStructAttribute(1, false, false)]
    public ushort  IMINUTE = 0;
    
    [SplusStructAttribute(2, false, false)]
    public ushort  [] ISETPOINT;
    
    
    public SCHEDULE( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        ISETPOINT  = new ushort[ 3 ];
        
        
    }
    
}

}
