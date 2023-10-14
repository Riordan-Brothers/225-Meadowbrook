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

namespace UserModule_INFUSION_PROCESSOR_V1_1__AVPA_
{
    public class UserModuleClass_INFUSION_PROCESSOR_V1_1__AVPA_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.StringInput VANTAGE_RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput KEYPAD_MODULE_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput TASK_MODULE_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput THERMOSTAT_MODULE_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LOAD_MODULE_TX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput BLIND_MODULE_TX__DOLLAR__;
        object VANTAGE_RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                CrestronString VANTAGE_6_CHAR__DOLLAR__;
                VANTAGE_6_CHAR__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
                
                CrestronString VANTAGE_7_CHAR__DOLLAR__;
                VANTAGE_7_CHAR__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 7, this );
                
                
                __context__.SourceCodeLine = 87;
                VANTAGE_6_CHAR__DOLLAR__  .UpdateValue ( Functions.Left ( VANTAGE_RX__DOLLAR__ ,  (int) ( 6 ) )  ) ; 
                __context__.SourceCodeLine = 88;
                VANTAGE_7_CHAR__DOLLAR__  .UpdateValue ( Functions.Left ( VANTAGE_RX__DOLLAR__ ,  (int) ( 7 ) )  ) ; 
                __context__.SourceCodeLine = 90;
                if ( Functions.TestForTrue  ( ( (Functions.BoolToInt (VANTAGE_6_CHAR__DOLLAR__ == "S:LED ") | Functions.BoolToInt (VANTAGE_7_CHAR__DOLLAR__ == "R:GETLE")))  ) ) 
                    { 
                    __context__.SourceCodeLine = 93;
                    KEYPAD_MODULE_TX__DOLLAR__  .UpdateValue ( VANTAGE_RX__DOLLAR__  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 95;
                    if ( Functions.TestForTrue  ( ( (Functions.BoolToInt (VANTAGE_6_CHAR__DOLLAR__ == "S:TASK") | Functions.BoolToInt (VANTAGE_7_CHAR__DOLLAR__ == "R:GETTA")))  ) ) 
                        { 
                        __context__.SourceCodeLine = 97;
                        TASK_MODULE_TX__DOLLAR__  .UpdateValue ( VANTAGE_RX__DOLLAR__  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 99;
                        if ( Functions.TestForTrue  ( ( (Functions.BoolToInt (VANTAGE_6_CHAR__DOLLAR__ == "S:LOAD") | Functions.BoolToInt (VANTAGE_7_CHAR__DOLLAR__ == "R:GETLO")))  ) ) 
                            { 
                            __context__.SourceCodeLine = 101;
                            LOAD_MODULE_TX__DOLLAR__  .UpdateValue ( VANTAGE_RX__DOLLAR__  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 103;
                            if ( Functions.TestForTrue  ( ( ((Functions.BoolToInt (VANTAGE_7_CHAR__DOLLAR__ == "R:BLIND") | Functions.BoolToInt (VANTAGE_7_CHAR__DOLLAR__ == "R:GETBL")) | Functions.BoolToInt (VANTAGE_7_CHAR__DOLLAR__ == "S:BLIND")))  ) ) 
                                { 
                                __context__.SourceCodeLine = 105;
                                BLIND_MODULE_TX__DOLLAR__  .UpdateValue ( VANTAGE_RX__DOLLAR__  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 107;
                                if ( Functions.TestForTrue  ( ( (((Functions.BoolToInt (VANTAGE_6_CHAR__DOLLAR__ == "S:TEMP") | Functions.BoolToInt (VANTAGE_6_CHAR__DOLLAR__ == "S:THER")) | Functions.BoolToInt (VANTAGE_6_CHAR__DOLLAR__ == "R:THER")) | Functions.BoolToInt (VANTAGE_7_CHAR__DOLLAR__ == "R:GETTH")))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 109;
                                    THERMOSTAT_MODULE_TX__DOLLAR__  .UpdateValue ( VANTAGE_RX__DOLLAR__  ) ; 
                                    } 
                                
                                }
                            
                            }
                        
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
        
        VANTAGE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( VANTAGE_RX__DOLLAR____AnalogSerialInput__, 254, this );
        m_StringInputList.Add( VANTAGE_RX__DOLLAR____AnalogSerialInput__, VANTAGE_RX__DOLLAR__ );
        
        KEYPAD_MODULE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( KEYPAD_MODULE_TX__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( KEYPAD_MODULE_TX__DOLLAR____AnalogSerialOutput__, KEYPAD_MODULE_TX__DOLLAR__ );
        
        TASK_MODULE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TASK_MODULE_TX__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( TASK_MODULE_TX__DOLLAR____AnalogSerialOutput__, TASK_MODULE_TX__DOLLAR__ );
        
        THERMOSTAT_MODULE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( THERMOSTAT_MODULE_TX__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( THERMOSTAT_MODULE_TX__DOLLAR____AnalogSerialOutput__, THERMOSTAT_MODULE_TX__DOLLAR__ );
        
        LOAD_MODULE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LOAD_MODULE_TX__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( LOAD_MODULE_TX__DOLLAR____AnalogSerialOutput__, LOAD_MODULE_TX__DOLLAR__ );
        
        BLIND_MODULE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( BLIND_MODULE_TX__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( BLIND_MODULE_TX__DOLLAR____AnalogSerialOutput__, BLIND_MODULE_TX__DOLLAR__ );
        
        
        VANTAGE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( VANTAGE_RX__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_INFUSION_PROCESSOR_V1_1__AVPA_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint VANTAGE_RX__DOLLAR____AnalogSerialInput__ = 0;
    const uint KEYPAD_MODULE_TX__DOLLAR____AnalogSerialOutput__ = 0;
    const uint TASK_MODULE_TX__DOLLAR____AnalogSerialOutput__ = 1;
    const uint THERMOSTAT_MODULE_TX__DOLLAR____AnalogSerialOutput__ = 2;
    const uint LOAD_MODULE_TX__DOLLAR____AnalogSerialOutput__ = 3;
    const uint BLIND_MODULE_TX__DOLLAR____AnalogSerialOutput__ = 4;
    
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
