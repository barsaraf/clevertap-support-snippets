// Note : For MPNS, you need to supply a channelName. You can use your mobile application name
// as channelName or else it will default to ‘CleverTap’. If you are using authenticated notifications,
// then pass serviceName which is the Subject Name / Common Name in the certificate uploaded to MPNS
CleverTapApi instance = CleverTapApi.GetInstance();
instance.SendMPNSNotificationUri(string channelUri)