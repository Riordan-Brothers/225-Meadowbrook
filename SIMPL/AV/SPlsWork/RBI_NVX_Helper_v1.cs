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

namespace UserModule_RBI_NVX_HELPER_V1
{
    public class UserModuleClass_RBI_NVX_HELPER_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput CLEARSOURCE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCESELECT;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> SOURCESTREAM;
        Crestron.Logos.SplusObjects.AnalogOutput STREAMOUTNUMFB;
        Crestron.Logos.SplusObjects.StringOutput STREAMOUT;
        object CLEARSOURCE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 30;
                STREAMOUT  .UpdateValue ( ""  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SOURCESELECT_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 37;
            I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 39;
            STREAMOUT  .UpdateValue ( SOURCESTREAM [ I ]  ) ; 
            __context__.SourceCodeLine = 40;
            STREAMOUTNUMFB  .Value = (ushort) ( I ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    CLEARSOURCE = new Crestron.Logos.SplusObjects.DigitalInput( CLEARSOURCE__DigitalInput__, this );
    m_DigitalInputList.Add( CLEARSOURCE__DigitalInput__, CLEARSOURCE );
    
    SOURCESELECT = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCESELECT[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCESELECT__DigitalInput__ + i, SOURCESELECT__DigitalInput__, this );
        m_DigitalInputList.Add( SOURCESELECT__DigitalInput__ + i, SOURCESELECT[i+1] );
    }
    
    STREAMOUTNUMFB = new Crestron.Logos.SplusObjects.AnalogOutput( STREAMOUTNUMFB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( STREAMOUTNUMFB__AnalogSerialOutput__, STREAMOUTNUMFB );
    
    SOURCESTREAM = new InOutArray<StringInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SOURCESTREAM[i+1] = new Crestron.Logos.SplusObjects.StringInput( SOURCESTREAM__AnalogSerialInput__ + i, SOURCESTREAM__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( SOURCESTREAM__AnalogSerialInput__ + i, SOURCESTREAM[i+1] );
    }
    
    STREAMOUT = new Crestron.Logos.SplusObjects.StringOutput( STREAMOUT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( STREAMOUT__AnalogSerialOutput__, STREAMOUT );
    
    
    CLEARSOURCE.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEARSOURCE_OnPush_0, false ) );
    for( uint i = 0; i < 24; i++ )
        SOURCESELECT[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SOURCESELECT_OnPush_1, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_RBI_NVX_HELPER_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint CLEARSOURCE__DigitalInput__ = 0;
const uint SOURCESELECT__DigitalInput__ = 1;
const uint SOURCESTREAM__AnalogSerialInput__ = 0;
const uint STREAMOUTNUMFB__AnalogSerialOutput__ = 0;
const uint STREAMOUT__AnalogSerialOutput__ = 1;

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
