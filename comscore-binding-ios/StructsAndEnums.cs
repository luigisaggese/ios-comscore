using System;
using ObjCRuntime;

[Native]
public enum SCORLogLevel : ulong
{
	None = 30000,
	Error = 30001,
	Warning = 30002,
	Debug = 30003,
	Verbose = 30004
}

[Native]
public enum SCORApplicationState : ulong
{
	Foreground,
	BackgroundUxActive,
	Inactive
}

public enum SCORLiveTransmissionMode : ulong
{
	Cache = 20003,
	Lan = 20002,
	Standard = 20001
}

[Native]
public enum SCORUsagePropertiesAutoUpdateMode : ulong
{
	Disabled = 20502,
	ForegroundAndBackground = 20501,
	ForegroundOnly = 20500
}

[Native]
public enum SCORConfigurationType : ulong
{
	PersistentLabels = 20300,
	Partner = 20301,
	Publisher = 20302,
	KeepAliveMeasurement = 20303,
	LiveTransmissionMode = 20304,
	OfflineCacheMode = 20305,
	Disable = 20306,
	Start = 20307
}

[Native]
public enum SCORExtensionType : ulong
{
	Today,
	Share,
	Action,
	PhotoEditing,
	DocumentProvider,
	CustomKeyboard,
	WatchApp,
	AudioUnit,
	Unknown
}

[Native]
public enum SCOROfflineCacheMode : ulong
{
	Disabled = 20104,
	Lan = 20103,
	ManualFlush = 20102,
	Enabled = 20101
}

public enum SCORSessionState : ulong
{
	Inactive,
	Application,
	User,
	ActiveUser
}

[Native]
public enum SCORTrackingProperty : ulong
{
	FirstInstallId = 20400,
	CurrentInstallId = 20401,
	DeviceModel = 20402,
	CrossPublisherDeviceId = 20403,
	CurrentApplicationVersion = 20404,
	PreviousApplicationVersion = 20405,
	RunCount = 20406,
	IsJailbroken = 20407,
	ColdStartId = 20408,
	ColdStartCount = 20409
}

[Native]
public enum SCORAdType : ulong
{
	LinearOnDemandPreRoll = 211,
	LinearOnDemandMidRoll = 212,
	LinearOnDemandPostRoll = 213,
	LinearLive = 221,
	BrandedOnDemandPreRoll = 231,
	BrandedOnDemandMidRoll = 232,
	BrandedOnDemandPostRoll = 233,
	BrandedOnDemandContent = 234,
	BrandedOnDemandLive = 235,
	Other = 200
}

[Native]
public enum SCORContentType : ulong
{
	LongFormOnDemand = 112,
	ShortFormOnDemand = 111,
	Live = 113,
	UserGeneratedLongFormOnDemand = 122,
	UserGeneratedShortFormOnDemand = 121,
	UserGeneratedLive = 123,
	Bumper = 199,
	Other = 100
}

[Native]
public enum SCORStreamingState : ulong
{
	Undefined,
	Idle,
	PlaybackNotStarted,
	Playing,
	Paused,
	BufferingBeforePlayback,
	BufferingDuringPlayback,
	BufferingDuringSeeking,
	BufferingDuringPause,
	SeekingBeforePlayback,
	SeekingDuringPlayback,
	SeekingDuringBuffering,
	SeekingDuringPause,
	PausedDuringBuffering
}
