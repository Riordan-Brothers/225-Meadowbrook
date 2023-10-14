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

namespace UserModule_INFUSION_LOAD_MODULE_V1_1__AVPA_
{
    public class UserModuleClass_INFUSION_LOAD_MODULE_V1_1__AVPA_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput POLL;
        Crestron.Logos.SplusObjects.AnalogInput LEVEL;
        Crestron.Logos.SplusObjects.AnalogInput RAMP_TIME;
        Crestron.Logos.SplusObjects.StringInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput VID__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput LVL_FB;
        Crestron.Logos.SplusObjects.StringOutput LVL_FB__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        object POLL_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 81;
                TX__DOLLAR__  .UpdateValue ( "GETLOAD " + VID__DOLLAR__ + "\u000D\u000A"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object LEVEL_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort ILVL = 0;
            
            
            __context__.SourceCodeLine = 87;
            ILVL = (ushort) ( LEVEL  .UshortValue ) ; 
            __context__.SourceCodeLine = 100;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( RAMP_TIME  .UshortValue > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 102;
                TX__DOLLAR__  .UpdateValue ( "RAMPLOAD " + VID__DOLLAR__ + " " + Functions.ItoA (  (int) ( ILVL ) ) + " " + Functions.ItoA (  (int) ( RAMP_TIME  .UshortValue ) ) + "\u000D\u000A"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 107;
                TX__DOLLAR__  .UpdateValue ( "LOAD " + VID__DOLLAR__ + " " + Functions.ItoA (  (int) ( LEVEL  .UshortValue ) ) + "\u000D\u000A"  ) ; 
                } 
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object RX__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString STR;
        CrestronString S1;
        STR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 150, this );
        S1  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
        
        ushort IPOS = 0;
        ushort IDECPOS = 0;
        
        CrestronString MSG__DOLLAR__;
        MSG__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
        
        CrestronString LVL__DOLLAR__;
        LVL__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
        
        
        __context__.SourceCodeLine = 122;
        STR  .UpdateValue ( RX__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 124;
        MSG__DOLLAR__  .UpdateValue ( "S:LOAD " + VID__DOLLAR__ + " "  ) ; 
        __context__.SourceCodeLine = 125;
        IPOS = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 126;
        IPOS = (ushort) ( Functions.Find( MSG__DOLLAR__ , STR ) ) ; 
        __context__.SourceCodeLine = 129;
        if ( Functions.TestForTrue  ( ( IPOS)  ) ) 
            { 
            __context__.SourceCodeLine = 132;
            IPOS = (ushort) ( (IPOS + Functions.Length( MSG__DOLLAR__ )) ) ; 
            __context__.SourceCodeLine = 133;
            IDECPOS = (ushort) ( Functions.Find( "." , STR , IPOS ) ) ; 
            __context__.SourceCodeLine = 135;
            LVL__DOLLAR__  .UpdateValue ( Functions.Mid ( STR ,  (int) ( IPOS ) ,  (int) ( (IDECPOS - IPOS) ) )  ) ; 
            __context__.SourceCodeLine = 137;
            LVL_FB__DOLLAR__  .UpdateValue ( LVL__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 138;
            LVL_FB  .Value = (ushort) ( Functions.Atoi( LVL__DOLLAR__ ) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 142;
            MSG__DOLLAR__  .UpdateValue ( "R:GETLOAD " + VID__DOLLAR__ + " "  ) ; 
            __context__.SourceCodeLine = 143;
            IPOS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 144;
            IPOS = (ushort) ( Functions.Find( MSG__DOLLAR__ , STR ) ) ; 
            __context__.SourceCodeLine = 147;
            if ( Functions.TestForTrue  ( ( IPOS)  ) ) 
                { 
                __context__.SourceCodeLine = 149;
                IPOS = (ushort) ( (IPOS + Functions.Length( MSG__DOLLAR__ )) ) ; 
                __context__.SourceCodeLine = 150;
                IDECPOS = (ushort) ( Functions.Find( "." , STR , IPOS ) ) ; 
                __context__.SourceCodeLine = 152;
                LVL__DOLLAR__  .UpdateValue ( Functions.Mid ( STR ,  (int) ( IPOS ) ,  (int) ( (IDECPOS - IPOS) ) )  ) ; 
                __context__.SourceCodeLine = 153;
                LVL_FB__DOLLAR__  .UpdateValue ( LVL__DOLLAR__  ) ; 
                __context__.SourceCodeLine = 154;
                LVL_FB  .Value = (ushort) ( Functions.Atoi( LVL__DOLLAR__ ) ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    POLL = new Crestron.Logos.SplusObjects.DigitalInput( POLL__DigitalInput__, this );
    m_DigitalInputList.Add( POLL__DigitalInput__, POLL );
    
    LEVEL = new Crestron.Logos.SplusObjects.AnalogInput( LEVEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( LEVEL__AnalogSerialInput__, LEVEL );
    
    RAMP_TIME = new Crestron.Logos.SplusObjects.AnalogInput( RAMP_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( RAMP_TIME__AnalogSerialInput__, RAMP_TIME );
    
    LVL_FB = new Crestron.Logos.SplusObjects.AnalogOutput( LVL_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LVL_FB__AnalogSerialOutput__, LVL_FB );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RX__DOLLAR____AnalogSerialInput__, 150, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    VID__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( VID__DOLLAR____AnalogSerialInput__, 10, this );
    m_StringInputList.Add( VID__DOLLAR____AnalogSerialInput__, VID__DOLLAR__ );
    
    LVL_FB__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LVL_FB__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LVL_FB__DOLLAR____AnalogSerialOutput__, LVL_FB__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    
    POLL.OnDigitalPush.Add( new InputChangeHandlerWrapper( POLL_OnPush_0, false ) );
    LEVEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( LEVEL_OnChange_1, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_INFUSION_LOAD_MODULE_V1_1__AVPA_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint POLL__DigitalInput__ = 0;
const uint LEVEL__AnalogSerialInput__ = 0;
const uint RAMP_TIME__AnalogSerialInput__ = 1;
const uint RX__DOLLAR____AnalogSerialInput__ = 2;
const uint VID__DOLLAR____AnalogSerialInput__ = 3;
const uint LVL_FB__AnalogSerialOutput__ = 0;
const uint LVL_FB__DOLLAR____AnalogSerialOutput__ = 1;
const uint TX__DOLLAR____AnalogSerialOutput__ = 2;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
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


}
