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

namespace UserModule_RBI_HTML_FORMATTING_HELPER_V1
{
    public class UserModuleClass_RBI_HTML_FORMATTING_HELPER_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        InOutArray<Crestron.Logos.SplusObjects.StringInput> LABEL;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> FORMATTEDLABEL;
        StringParameter SIZE;
        StringParameter FACE;
        StringParameter COLOR;
        object LABEL_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 25;
                FORMATTEDLABEL [ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ )]  .UpdateValue ( "<FONT size= \u0022" + SIZE + "\u0022 face=\u0022" + FACE + "\u0022 color=\u0022#" + COLOR + "\u0022>" + LABEL [ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] + "</FONT>"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        LABEL = new InOutArray<StringInput>( 24, this );
        for( uint i = 0; i < 24; i++ )
        {
            LABEL[i+1] = new Crestron.Logos.SplusObjects.StringInput( LABEL__AnalogSerialInput__ + i, LABEL__AnalogSerialInput__, 50, this );
            m_StringInputList.Add( LABEL__AnalogSerialInput__ + i, LABEL[i+1] );
        }
        
        FORMATTEDLABEL = new InOutArray<StringOutput>( 24, this );
        for( uint i = 0; i < 24; i++ )
        {
            FORMATTEDLABEL[i+1] = new Crestron.Logos.SplusObjects.StringOutput( FORMATTEDLABEL__AnalogSerialOutput__ + i, this );
            m_StringOutputList.Add( FORMATTEDLABEL__AnalogSerialOutput__ + i, FORMATTEDLABEL[i+1] );
        }
        
        SIZE = new StringParameter( SIZE__Parameter__, this );
        m_ParameterList.Add( SIZE__Parameter__, SIZE );
        
        FACE = new StringParameter( FACE__Parameter__, this );
        m_ParameterList.Add( FACE__Parameter__, FACE );
        
        COLOR = new StringParameter( COLOR__Parameter__, this );
        m_ParameterList.Add( COLOR__Parameter__, COLOR );
        
        
        for( uint i = 0; i < 24; i++ )
            LABEL[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( LABEL_OnChange_0, true ) );
            
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_RBI_HTML_FORMATTING_HELPER_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint LABEL__AnalogSerialInput__ = 0;
    const uint FORMATTEDLABEL__AnalogSerialOutput__ = 0;
    const uint SIZE__Parameter__ = 10;
    const uint FACE__Parameter__ = 11;
    const uint COLOR__Parameter__ = 12;
    
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
