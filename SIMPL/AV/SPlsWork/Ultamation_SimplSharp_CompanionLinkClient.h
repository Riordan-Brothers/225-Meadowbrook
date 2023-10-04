namespace Ultamation.Licensing;
        // class declarations
         class ClientCredentials;
         class LicenceManifest;
         class ModuleCredentials;
         class RemoteCredentials;
     class ClientCredentials 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING GUID[];
        STRING PrivateKey[];
        STRING MAC[];
        STRING ClientName[];
    };

     class LicenceManifest 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ClientCredentials Client;
    };

     class ModuleCredentials 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING ModuleId[];
        STRING LicenceKey[];
    };

     class RemoteCredentials 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING GUID[];
        STRING PublicKey[];
        STRING LicenceKey[];
    };

namespace Ultamation.SimplSharp.CompanionLink;
        // class declarations
         class CLinkClient;
         class CLinkSPlus;
         class HidAction;
         class HidCommand;
     class CLinkClient 
    {
        // class delegates
        delegate FUNCTION CLinkLogDelegate ( STRING msg );

        // class events

        // class functions
        FUNCTION Identify ( STRING atvName , STRING licPath );
        FUNCTION Dispose ();
        FUNCTION ConnectionReset ();
        FUNCTION Navigate ( HidCommand nav , HidAction act );
        FUNCTION Tap ( HidCommand nav );
        FUNCTION RequestAppList ();
        STRING_FUNCTION GetAppNameByIndex ( SIGNED_LONG_INTEGER idx );
        FUNCTION LaunchAppByName ( STRING appName );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER AppListCount;
        DelegateProperty CLinkLogDelegate Logger;
    };

     class CLinkSPlus 
    {
        // class delegates
        delegate FUNCTION SPlusCallback ( );

        // class events

        // class functions
        FUNCTION Initialise ( SIMPLSHARPSTRING name );
        FUNCTION ResetConnection ();
        FUNCTION Up ( INTEGER press );
        FUNCTION Down ( INTEGER press );
        FUNCTION Left ( INTEGER press );
        FUNCTION Right ( INTEGER press );
        FUNCTION Select ( INTEGER press );
        FUNCTION Menu ( INTEGER press );
        FUNCTION Tv ( INTEGER press );
        FUNCTION VolumeUp ( INTEGER press );
        FUNCTION VolumeDown ( INTEGER press );
        FUNCTION Siri ( INTEGER press );
        FUNCTION Screensaver ( INTEGER press );
        FUNCTION Sleep ( INTEGER press );
        FUNCTION Wake ( INTEGER press );
        FUNCTION PlayPause ( INTEGER press );
        FUNCTION ChannelUp ( INTEGER press );
        FUNCTION ChannelDown ( INTEGER press );
        FUNCTION Guide ( INTEGER press );
        FUNCTION PageUp ( INTEGER press );
        FUNCTION PageDown ( INTEGER press );
        SIMPLSHARPSTRING_FUNCTION GetAppName ( INTEGER zbIdx );
        FUNCTION LaunchAppByName ( SIMPLSHARPSTRING appName );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER GetAppListSize;
        DelegateProperty SPlusCallback UpdateClientStatus;
        INTEGER ConfigIsLoaded;
        INTEGER InTrialMode;
        INTEGER LicenceKeyIsOk;
        INTEGER AppleTvFound;
        INTEGER AppleTvConnected;
        INTEGER AppleTvVerified;
        INTEGER AppleTvSessionActive;
        DelegateProperty SPlusCallback UpdateAppList;
        INTEGER DebugIsOn;
    };

    static class HidAction // enum
    {
        static SIGNED_LONG_INTEGER Press;
        static SIGNED_LONG_INTEGER Release;
    };

    static class HidCommand // enum
    {
        static SIGNED_LONG_INTEGER Up;
        static SIGNED_LONG_INTEGER Down;
        static SIGNED_LONG_INTEGER Left;
        static SIGNED_LONG_INTEGER Right;
        static SIGNED_LONG_INTEGER Menu;
        static SIGNED_LONG_INTEGER Select;
        static SIGNED_LONG_INTEGER TV;
        static SIGNED_LONG_INTEGER VolumeUp;
        static SIGNED_LONG_INTEGER VolumeDown;
        static SIGNED_LONG_INTEGER Siri;
        static SIGNED_LONG_INTEGER Screensaver;
        static SIGNED_LONG_INTEGER Sleep;
        static SIGNED_LONG_INTEGER Wake;
        static SIGNED_LONG_INTEGER PlayPause;
        static SIGNED_LONG_INTEGER ChannelUp;
        static SIGNED_LONG_INTEGER ChannelDown;
        static SIGNED_LONG_INTEGER Guide;
        static SIGNED_LONG_INTEGER PageUp;
        static SIGNED_LONG_INTEGER PageDown;
    };

namespace ultacl;
        // class declarations
         class a;
     class a 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION a ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

