using System;
using Foundation;
using ObjCRuntime;
using UIKit;
namespace CSComScore
{
	// @interface SCORAnalytics : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORAnalytics
	{
		// +(NSString *)version;
		[Static]
		[Export("version")]
		string Version { get; }

		// +(SCORLogLevel)logLevel;
		// +(void)setLogLevel:(SCORLogLevel)level;
		[Static]
		[Export("logLevel")]
		SCORLogLevel LogLevel { get; set; }

		// +(void)notifyViewEvent;
		[Static]
		[Export("notifyViewEvent")]
		void NotifyViewEvent();

		// +(void)notifyViewEventWithEventInfo:(SCOREventInfo *)eventInfo;
		[Static]
		[Export("notifyViewEventWithEventInfo:")]
		void NotifyViewEventWithEventInfo(SCOREventInfo eventInfo);

		// +(void)notifyViewEventWithLabels:(NSDictionary *)labels;
		[Static]
		[Export("notifyViewEventWithLabels:")]
		void NotifyViewEventWithLabels(NSDictionary labels);

		// +(void)notifyHiddenEvent;
		[Static]
		[Export("notifyHiddenEvent")]
		void NotifyHiddenEvent();

		// +(void)notifyHiddenEventWithEventInfo:(SCOREventInfo *)eventInfo;
		[Static]
		[Export("notifyHiddenEventWithEventInfo:")]
		void NotifyHiddenEventWithEventInfo(SCOREventInfo eventInfo);

		// +(void)notifyHiddenEventWithLabels:(NSDictionary *)labels;
		[Static]
		[Export("notifyHiddenEventWithLabels:")]
		void NotifyHiddenEventWithLabels(NSDictionary labels);

		// +(void)aggregateWithLabels:(NSDictionary *)labels;
		[Static]
		[Export("aggregateWithLabels:")]
		void AggregateWithLabels(NSDictionary labels);

		// +(void)aggregateWithEventInfo:(SCOREventInfo *)eventInfo;
		[Static]
		[Export("aggregateWithEventInfo:")]
		void AggregateWithEventInfo(SCOREventInfo eventInfo);

		// +(NSDictionary *)trackingProperties;
		[Static]
		[Export("trackingProperties")]
		NSDictionary TrackingProperties();

		// +(void)notifyUserInteraction;
		[Static]
		[Export("notifyUserInteraction")]
		void NotifyUserInteraction();

		// +(void)notifyUxActive;
		[Static]
		[Export("notifyUxActive")]
		void NotifyUxActive();

		// +(void)notifyUxInactive;
		[Static]
		[Export("notifyUxInactive")]
		void NotifyUxInactive();

		// +(void)notifyEnterForeground;
		[Static]
		[Export("notifyEnterForeground")]
		void NotifyEnterForeground();

		// +(void)notifyExitForeground;
		[Static]
		[Export("notifyExitForeground")]
		void NotifyExitForeground();

		// +(void)updateUsageProperties;
		[Static]
		[Export("updateUsageProperties")]
		void UpdateUsageProperties();

		// +(void)flushOfflineCache;
		[Static]
		[Export("flushOfflineCache")]
		void FlushOfflineCache();

		// +(SCORConfiguration *)configuration;
		[Static]
		[Export("configuration")]
		SCORConfiguration Configuration();

		// +(void)start;
		[Static]
		[Export("start")]
		void Start();

		// +(void)clearOfflineCache;
		[Static]
		[Export("clearOfflineCache")]
		void ClearOfflineCache();

		// +(void)clearInternalData;
		[Static]
		[Export("clearInternalData")]
		void ClearInternalData();

		// +(void)getActivationCategoriesWithKey:(NSString *)key url:(NSString *)url publisherConfiguration:(SCORPublisherConfiguration *)publisherConfiguration block:(void (^)(NSArray *))callback;
		[Static]
		[Export("getActivationCategoriesWithKey:url:publisherConfiguration:block:")]
		void GetActivationCategoriesWithKey(string key, string url, SCORPublisherConfiguration publisherConfiguration, Action<NSArray> callback);
	}

	// @protocol SCORConfigurationDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SCORConfigurationDelegate
	{
		// @required -(void)configurationChangedWithConfigurationType:(SCORConfigurationType)configurationType;
		[Abstract]
		[Export("configurationChangedWithConfigurationType:")]
		void ConfigurationChangedWithConfigurationType(SCORConfigurationType configurationType);
	}

	// @interface SCORClientConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORClientConfiguration
	{
		// @property (readonly) NSString * publisherUniqueDeviceId;
		[Export("publisherUniqueDeviceId")]
		string PublisherUniqueDeviceId { get; }

		// @property (readonly) NSString * applicationName;
		[Export("applicationName")]
		string ApplicationName { get; }

		// @property (readonly) NSString * applicationVersion;
		[Export("applicationVersion")]
		string ApplicationVersion { get; }

		// @property (copy, nonatomic) NSDictionary * startLabels;
		[Export("startLabels", ArgumentSemantic.Copy)]
		NSDictionary StartLabels { get; set; }

		// @property (readonly) NSString * liveEndpointURL;
		[Export("liveEndpointURL")]
		string LiveEndpointURL { get; }

		// @property (readonly) SCORLiveTransmissionMode liveTransmissionMode;
		[Export("liveTransmissionMode")]
		SCORLiveTransmissionMode LiveTransmissionMode { get; }

		// @property (readonly) NSArray * labelOrder;
		[Export("labelOrder")]
		NSObject[] LabelOrder { get; }

		// @property (readonly) SCORUsagePropertiesAutoUpdateMode usagePropertiesAutoUpdateMode;
		[Export("usagePropertiesAutoUpdateMode")]
		SCORUsagePropertiesAutoUpdateMode UsagePropertiesAutoUpdateMode { get; }

		// @property (readonly) int usagePropertiesAutoUpdateInterval;
		[Export("usagePropertiesAutoUpdateInterval")]
		int UsagePropertiesAutoUpdateInterval { get; }

		// @property (readonly) BOOL keepAliveMeasurement;
		[Export("keepAliveMeasurement")]
		bool KeepAliveMeasurement { get; }

		// @property (readonly) BOOL secureTransmission;
		[Export("secureTransmission")]
		bool SecureTransmission { get; }

		// @property (readonly) BOOL uncaughtExceptionTracking;
		[Export("uncaughtExceptionTracking")]
		bool UncaughtExceptionTracking { get; }

		// -(NSDictionary *)persistentLabels;
		// -(void)setPersistentLabels:(NSDictionary *)persistentLabels;
		[Export("persistentLabels")]
		NSDictionary PersistentLabels { get; set; }

		// -(void)setPersistentLabelWithName:(NSString *)name value:(NSString *)value;
		[Export("setPersistentLabelWithName:value:")]
		void SetPersistentLabelWithName(string name, string value);

		// -(void)removePersistentLabelWithName:(NSString *)name;
		[Export("removePersistentLabelWithName:")]
		void RemovePersistentLabelWithName(string name);

		// -(void)removeAllPersistentLabels;
		[Export("removeAllPersistentLabels")]
		void RemoveAllPersistentLabels();

		// -(NSString *)persistentLabelWithName:(NSString *)name;
		[Export("persistentLabelWithName:")]
		string PersistentLabelWithName(string name);

		// -(BOOL)containsPersistentLabel:(NSString *)labelName;
		[Export("containsPersistentLabel:")]
		bool ContainsPersistentLabel(string labelName);

		// -(void)addDelegate:(id<SCORConfigurationDelegate>)delegate;
		[Export("addDelegate:")]
		void AddDelegate(SCORConfigurationDelegate @delegate);

		// -(void)removeDelegate:(id<SCORConfigurationDelegate>)delegate;
		[Export("removeDelegate:")]
		void RemoveDelegate(SCORConfigurationDelegate @delegate);
	}

	// @interface SCORClientConfigurationBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORClientConfigurationBuilder
	{
		// @property (copy) NSString * liveEndpointURL;
		[Export("liveEndpointURL")]
		string LiveEndpointURL { get; set; }

		// @property (nonatomic) SCORLiveTransmissionMode liveTransmissionMode;
		[Export("liveTransmissionMode", ArgumentSemantic.Assign)]
		SCORLiveTransmissionMode LiveTransmissionMode { get; set; }

		// @property (copy) NSDictionary * persistentLabels;
		[Export("persistentLabels", ArgumentSemantic.Copy)]
		NSDictionary PersistentLabels { get; set; }

		// @property (copy) NSDictionary * startLabels;
		[Export("startLabels", ArgumentSemantic.Copy)]
		NSDictionary StartLabels { get; set; }

		// @property (copy) NSArray * labelOrder;
		[Export("labelOrder", ArgumentSemantic.Copy)]
		NSObject[] LabelOrder { get; set; }

		// @property (copy) NSString * applicationName;
		[Export("applicationName")]
		string ApplicationName { get; set; }

		// @property (copy) NSString * applicationVersion;
		[Export("applicationVersion")]
		string ApplicationVersion { get; set; }

		// @property (nonatomic) SCORUsagePropertiesAutoUpdateMode usagePropertiesAutoUpdateMode;
		[Export("usagePropertiesAutoUpdateMode", ArgumentSemantic.Assign)]
		SCORUsagePropertiesAutoUpdateMode UsagePropertiesAutoUpdateMode { get; set; }

		// @property (nonatomic) int usagePropertiesAutoUpdateInterval;
		[Export("usagePropertiesAutoUpdateInterval")]
		int UsagePropertiesAutoUpdateInterval { get; set; }

		// @property (nonatomic) BOOL keepAliveMeasurement;
		[Export("keepAliveMeasurement")]
		bool KeepAliveMeasurement { get; set; }

		// @property (nonatomic) BOOL secureTransmission;
		[Export("secureTransmission")]
		bool SecureTransmission { get; set; }

		// @property (nonatomic) BOOL uncaughtExceptionTracking;
		[Export("uncaughtExceptionTracking")]
		bool UncaughtExceptionTracking { get; set; }
	}

	// @interface SCORConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORConfiguration
	{
		// @property SCORLiveTransmissionMode liveTransmissionMode;
		[Export("liveTransmissionMode", ArgumentSemantic.Assign)]
		SCORLiveTransmissionMode LiveTransmissionMode { get; set; }

		// @property (readonly) NSArray * partnerConfigurations;
		[Export("partnerConfigurations")]
		NSObject[] PartnerConfigurations { get; }

		// @property (readonly) NSArray * publisherConfigurations;
		[Export("publisherConfigurations")]
		NSObject[] PublisherConfigurations { get; }

		// @property (readonly) int usagePropertiesAutoUpdateInterval;
		[Export("usagePropertiesAutoUpdateInterval")]
		int UsagePropertiesAutoUpdateInterval { get; }

		// @property (readonly) NSArray * labelOrder;
		[Export("labelOrder")]
		NSObject[] LabelOrder { get; }

		// @property (readonly) NSString * liveEndpointURL;
		[Export("liveEndpointURL")]
		string LiveEndpointURL { get; }

		// @property (copy) NSString * applicationName;
		[Export("applicationName")]
		string ApplicationName { get; set; }

		// @property (copy) NSString * applicationVersion;
		[Export("applicationVersion")]
		string ApplicationVersion { get; set; }

		// @property (copy) NSDictionary * startLabels;
		[Export("startLabels", ArgumentSemantic.Copy)]
		NSDictionary StartLabels { get; set; }

		// @property BOOL keepAliveMeasurement;
		[Export("keepAliveMeasurement")]
		bool KeepAliveMeasurement { get; set; }

		// @property (readonly) BOOL secureTransmission;
		[Export("secureTransmission")]
		bool SecureTransmission { get; }

		// @property (readonly) SCORUsagePropertiesAutoUpdateMode usagePropertiesAutoUpdateMode;
		[Export("usagePropertiesAutoUpdateMode")]
		SCORUsagePropertiesAutoUpdateMode UsagePropertiesAutoUpdateMode { get; }

		// @property (readonly) BOOL uncaughtExceptionTracking;
		[Export("uncaughtExceptionTracking")]
		bool UncaughtExceptionTracking { get; }

		// @property (readonly) BOOL enabled;
		[Export("enabled")]
		bool Enabled { get; }

		// -(NSDictionary *)persistentLabels;
		// -(void)setPersistentLabels:(NSDictionary *)persistentLabels;
		[Export("persistentLabels")]
		NSDictionary PersistentLabels { get; set; }

		// -(void)setPersistentLabelWithName:(NSString *)name value:(NSString *)value;
		[Export("setPersistentLabelWithName:value:")]
		void SetPersistentLabelWithName(string name, string value);

		// -(NSString *)persistentLabelWithName:(NSString *)name;
		[Export("persistentLabelWithName:")]
		string PersistentLabelWithName(string name);

		// -(BOOL)containsPersistentLabel:(NSString *)labelName;
		[Export("containsPersistentLabel:")]
		bool ContainsPersistentLabel(string labelName);

		// -(void)removePersistentLabelWithName:(NSString *)name;
		[Export("removePersistentLabelWithName:")]
		void RemovePersistentLabelWithName(string name);

		// -(void)removeAllPersistentLabels;
		[Export("removeAllPersistentLabels")]
		void RemoveAllPersistentLabels();

		// -(void)addClientWithConfiguration:(SCORClientConfiguration *)clientConfiguration;
		[Export("addClientWithConfiguration:")]
		void AddClientWithConfiguration(SCORClientConfiguration clientConfiguration);

		// -(SCORPartnerConfiguration *)partnerConfigurationWithPartnerId:(NSString *)partnerId;
		[Export("partnerConfigurationWithPartnerId:")]
		SCORPartnerConfiguration PartnerConfigurationWithPartnerId(string partnerId);

		// -(SCORPublisherConfiguration *)publisherConfigurationWithPublisherId:(NSString *)publisherId;
		[Export("publisherConfigurationWithPublisherId:")]
		SCORPublisherConfiguration PublisherConfigurationWithPublisherId(string publisherId);

		// -(void)disable;
		[Export("disable")]
		void Disable();

		// -(void)addDelegate:(id<SCORConfigurationDelegate>)delegate;
		[Export("addDelegate:")]
		void AddDelegate(SCORConfigurationDelegate @delegate);

		// -(void)removeDelegate:(id<SCORConfigurationDelegate>)delegate;
		[Export("removeDelegate:")]
		void RemoveDelegate(SCORConfigurationDelegate @delegate);
	}

	// @interface SCOREventInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface SCOREventInfo
	{
		// -(void)dealloc;
		[Export("dealloc")]
		void Dealloc();

		// -(SCOREventInfo *)copy;
		[Export("copy")]
		SCOREventInfo Copy { get; }

		// -(void)setLabelWithName:(NSString *)name value:(NSString *)value;
		[Export("setLabelWithName:value:")]
		void SetLabelWithName(string name, string value);

		// -(NSString *)labelWithName:(NSString *)name;
		[Export("labelWithName:")]
		string LabelWithName(string name);

		// -(NSString *)labelWithName:(NSString *)name publisherId:(NSString *)publisherId;
		[Export("labelWithName:publisherId:")]
		string LabelWithName(string name, string publisherId);

		// -(void)removePublisherWithId:(NSString *)publisherId;
		[Export("removePublisherWithId:")]
		void RemovePublisherWithId(string publisherId);

		// -(void)removeLabelWithName:(NSString *)name;
		[Export("removeLabelWithName:")]
		void RemoveLabelWithName(string name);

		// -(void)setLabels:(NSDictionary *)labels publisherId:(NSString *)publisherId;
		[Export("setLabels:publisherId:")]
		void SetLabels(NSDictionary labels, string publisherId);

		// -(void)setLabelWithName:(NSString *)name value:(NSString *)value publisherId:(NSString *)publisherId;
		[Export("setLabelWithName:value:publisherId:")]
		void SetLabelWithName(string name, string value, string publisherId);

		// -(void)setPublisherWithId:(NSString *)publisherId;
		[Export("setPublisherWithId:")]
		void SetPublisherWithId(string publisherId);

		// -(void)removeLabelWithName:(NSString *)name publisherId:(NSString *)publisherId;
		[Export("removeLabelWithName:publisherId:")]
		void RemoveLabelWithName(string name, string publisherId);

		// -(NSDictionary *)labels;
		// -(void)setLabels:(NSDictionary *)labels;
		[Export("labels")]
		NSDictionary Labels { get; set; }

		// -(void)removeAllLabels;
		[Export("removeAllLabels")]
		void RemoveAllLabels();

		// -(void)removeAllLabelsWithPublisherId:(NSString *)publisherId;
		[Export("removeAllLabelsWithPublisherId:")]
		void RemoveAllLabelsWithPublisherId(string publisherId);

		// -(NSDictionary *)labelsWithPublisherId:(NSString *)publisherId;
		[Export("labelsWithPublisherId:")]
		NSDictionary LabelsWithPublisherId(string publisherId);
	}

	// @interface SCORPartnerConfiguration : SCORClientConfiguration
	[BaseType(typeof(SCORClientConfiguration))]
	interface SCORPartnerConfiguration
	{
		// @property (readonly, copy, nonatomic) NSString * partnerId;
		[Export("partnerId")]
		string PartnerId { get; }

		// @property (readonly, copy, nonatomic) NSString * externalClientId;
		[Export("externalClientId")]
		string ExternalClientId { get; }

		// +(SCORPartnerConfiguration *)partnerConfigurationWithBuilderBlock:(void (^)(SCORPartnerConfigurationBuilder *))block;
		[Static]
		[Export("partnerConfigurationWithBuilderBlock:")]
		SCORPartnerConfiguration PartnerConfigurationWithBuilderBlock(Action<SCORPartnerConfigurationBuilder> block);

		// -(instancetype)initWithBuilder:(SCORPartnerConfigurationBuilder *)builder;
		[Export("initWithBuilder:")]
		IntPtr Constructor(SCORPartnerConfigurationBuilder builder);
	}

	// @interface SCORPartnerConfigurationBuilder : SCORClientConfigurationBuilder
	[BaseType(typeof(SCORClientConfigurationBuilder))]
	interface SCORPartnerConfigurationBuilder
	{
		// @property (copy) NSString * partnerId;
		[Export("partnerId")]
		string PartnerId { get; set; }

		// @property (copy) NSString * externalClientId;
		[Export("externalClientId")]
		string ExternalClientId { get; set; }

		// -(SCORPartnerConfiguration *)build;
		[Export("build")]
		SCORPartnerConfiguration Build { get; }
	}

	// @interface SCORPublisherConfiguration : SCORClientConfiguration
	[BaseType(typeof(SCORClientConfiguration))]
	interface SCORPublisherConfiguration
	{
		// @property (readonly, copy, nonatomic) NSString * publisherId;
		[Export("publisherId")]
		string PublisherId { get; }

		// @property (readonly, copy, nonatomic) NSString * publisherSecret;
		[Export("publisherSecret")]
		string PublisherSecret { get; }

		// +(SCORPublisherConfiguration *)publisherConfigurationWithBuilderBlock:(void (^)(SCORPublisherConfigurationBuilder *))block;
		[Static]
		[Export("publisherConfigurationWithBuilderBlock:")]
		SCORPublisherConfiguration PublisherConfigurationWithBuilderBlock(Action<SCORPublisherConfigurationBuilder> block);

		// -(instancetype)initWithBuilder:(SCORPublisherConfigurationBuilder *)builder;
		[Export("initWithBuilder:")]
		IntPtr Constructor(SCORPublisherConfigurationBuilder builder);
	}

	// @interface SCORPublisherConfigurationBuilder : SCORClientConfigurationBuilder
	[BaseType(typeof(SCORClientConfigurationBuilder))]
	interface SCORPublisherConfigurationBuilder
	{
		// @property (copy) NSString * publisherId;
		[Export("publisherId")]
		string PublisherId { get; set; }

		// @property (copy) NSString * publisherSecret;
		[Export("publisherSecret")]
		string PublisherSecret { get; set; }

		// -(SCORPublisherConfiguration *)build;
		[Export("build")]
		SCORPublisherConfiguration Build { get; }
	}

	// @interface SCORStreamingConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORStreamingConfiguration
	{
		// @property (readonly) NSArray * restrictedPublishersList;
		[Export("restrictedPublishersList")]
		NSObject[] RestrictedPublishersList { get; }

		// @property (readonly) BOOL systemClockJumpDetection;
		[Export("systemClockJumpDetection")]
		bool SystemClockJumpDetection { get; }

		// +(SCORStreamingConfiguration *)streamingConfigurationWithBuilderBlock:(void (^)(SCORStreamingConfigurationBuilder *))block;
		[Static]
		[Export("streamingConfigurationWithBuilderBlock:")]
		SCORStreamingConfiguration StreamingConfigurationWithBuilderBlock(Action<SCORStreamingConfigurationBuilder> block);

		// -(instancetype)initWithBuilder:(SCORStreamingConfigurationBuilder *)builder;
		[Export("initWithBuilder:")]
		IntPtr Constructor(SCORStreamingConfigurationBuilder builder);
	}

	// @interface SCORStreamingConfigurationBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORStreamingConfigurationBuilder
	{
		// @property (copy) NSArray * restrictedPublishersList;
		[Export("restrictedPublishersList", ArgumentSemantic.Copy)]
		NSObject[] RestrictedPublishersList { get; set; }

		// @property (nonatomic) BOOL systemClockJumpDetection;
		[Export("systemClockJumpDetection")]
		bool SystemClockJumpDetection { get; set; }

		// -(SCORStreamingConfiguration *)build;
		[Export("build")]
		SCORStreamingConfiguration Build { get; }
	}

	// @interface SCORReducedRequirementsStreamingAnalytics : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORReducedRequirementsStreamingAnalytics
	{
		// -(void)playVideoAdvertisementWithMetadata:(NSDictionary *)metadata andMediaType:(SCORAdType)mediaType;
		[Export("playVideoAdvertisementWithMetadata:andMediaType:")]
		void PlayVideoAdvertisementWithMetadata(NSDictionary metadata, SCORAdType mediaType);

		// -(void)playAudioAdvertisementWithMetadata:(NSDictionary *)metadata andMediaType:(SCORAdType)mediaType;
		[Export("playAudioAdvertisementWithMetadata:andMediaType:")]
		void PlayAudioAdvertisementWithMetadata(NSDictionary metadata, SCORAdType mediaType);

		// -(void)playVideoContentPartWithMetadata:(NSDictionary *)metadata andMediaType:(SCORContentType)mediaType;
		[Export("playVideoContentPartWithMetadata:andMediaType:")]
		void PlayVideoContentPartWithMetadata(NSDictionary metadata, SCORContentType mediaType);

		// -(void)playAudioContentPartWithMetadata:(NSDictionary *)metadata andMediaType:(SCORContentType)mediaType;
		[Export("playAudioContentPartWithMetadata:andMediaType:")]
		void PlayAudioContentPartWithMetadata(NSDictionary metadata, SCORContentType mediaType);

		// -(void)stop;
		[Export("stop")]
		void Stop();
	}

	// @protocol SCORStreamingAnalyticsProtocol <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SCORStreamingAnalyticsProtocol
	{
		// @required @property (readonly) NSDictionary * labels;
		[Abstract]
		[Export("labels")]
		NSDictionary Labels { get; }

		// @required @property (readonly) SCORStreamingPlaybackSession * playbackSession;
		[Abstract]
		[Export("playbackSession")]
		SCORStreamingPlaybackSession PlaybackSession { get; }

		// @required -(BOOL)notifyPlayWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyPlayWithPosition:labels:")]
		bool NotifyPlayWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyPlayWithPosition:(long)position;
		[Abstract]
		[Export("notifyPlayWithPosition:")]
		bool NotifyPlayWithPosition(nint position);

		// @required -(BOOL)notifyPlayWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyPlayWithLabels:")]
		bool NotifyPlayWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyPlay;
		[Abstract]
		[Export("notifyPlay")]
		bool NotifyPlay { get; }

		// @required -(BOOL)notifyPauseWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyPauseWithPosition:labels:")]
		bool NotifyPauseWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyPauseWithPosition:(long)position;
		[Abstract]
		[Export("notifyPauseWithPosition:")]
		bool NotifyPauseWithPosition(nint position);

		// @required -(BOOL)notifyPauseWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyPauseWithLabels:")]
		bool NotifyPauseWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyPause;
		[Abstract]
		[Export("notifyPause")]

		bool NotifyPause { get; }

		// @required -(BOOL)notifyEndWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyEndWithPosition:labels:")]
		bool NotifyEndWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyEndWithPosition:(long)position;
		[Abstract]
		[Export("notifyEndWithPosition:")]
		bool NotifyEndWithPosition(nint position);

		// @required -(BOOL)notifyEndWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyEndWithLabels:")]
		bool NotifyEndWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyEnd;
		[Abstract]
		[Export("notifyEnd")]

		bool NotifyEnd { get; }

		// @required -(BOOL)notifyBufferStartWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyBufferStartWithPosition:labels:")]
		bool NotifyBufferStartWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyBufferStartWithPosition:(long)position;
		[Abstract]
		[Export("notifyBufferStartWithPosition:")]
		bool NotifyBufferStartWithPosition(nint position);

		// @required -(BOOL)notifyBufferStartWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyBufferStartWithLabels:")]
		bool NotifyBufferStartWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyBufferStart;
		[Abstract]
		[Export("notifyBufferStart")]

		bool NotifyBufferStart { get; }

		// @required -(BOOL)notifyBufferStopWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyBufferStopWithPosition:labels:")]
		bool NotifyBufferStopWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyBufferStopWithPosition:(long)position;
		[Abstract]
		[Export("notifyBufferStopWithPosition:")]
		bool NotifyBufferStopWithPosition(nint position);

		// @required -(BOOL)notifyBufferStopWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyBufferStopWithLabels:")]
		bool NotifyBufferStopWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyBufferStop;
		[Abstract]
		[Export("notifyBufferStop")]

		bool NotifyBufferStop { get; }

		// @required -(BOOL)notifyLoadWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyLoadWithPosition:labels:")]
		bool NotifyLoadWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyLoadWithPosition:(long)position;
		[Abstract]
		[Export("notifyLoadWithPosition:")]
		bool NotifyLoadWithPosition(nint position);

		// @required -(BOOL)notifyLoadWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyLoadWithLabels:")]
		bool NotifyLoadWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyLoad;
		[Abstract]
		[Export("notifyLoad")]

		bool NotifyLoad { get; }

		// @required -(BOOL)notifyEngageWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyEngageWithPosition:labels:")]
		bool NotifyEngageWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyEngageWithPosition:(long)position;
		[Abstract]
		[Export("notifyEngageWithPosition:")]
		bool NotifyEngageWithPosition(nint position);

		// @required -(BOOL)notifyEngageWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyEngageWithLabels:")]
		bool NotifyEngageWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyEngage;
		[Abstract]
		[Export("notifyEngage")]

		bool NotifyEngage { get; }

		// @required -(BOOL)notifySeekStartWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifySeekStartWithPosition:labels:")]
		bool NotifySeekStartWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifySeekStartWithPosition:(long)position;
		[Abstract]
		[Export("notifySeekStartWithPosition:")]
		bool NotifySeekStartWithPosition(nint position);

		// @required -(BOOL)notifySeekStartWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifySeekStartWithLabels:")]
		bool NotifySeekStartWithLabels(NSDictionary labels);

		// @required -(BOOL)notifySeekStart;
		[Abstract]
		[Export("notifySeekStart")]

		bool NotifySeekStart { get; }

		// @required -(BOOL)notifySkipAdWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifySkipAdWithPosition:labels:")]
		bool NotifySkipAdWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifySkipAdWithPosition:(long)position;
		[Abstract]
		[Export("notifySkipAdWithPosition:")]
		bool NotifySkipAdWithPosition(nint position);

		// @required -(BOOL)notifySkipAdWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifySkipAdWithLabels:")]
		bool NotifySkipAdWithLabels(NSDictionary labels);

		// @required -(BOOL)notifySkipAd;
		[Abstract]
		[Export("notifySkipAd")]

		bool NotifySkipAd { get; }

		// @required -(BOOL)notifyCustomEventWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyCustomEventWithPosition:labels:")]
		bool NotifyCustomEventWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyCustomEventWithPosition:(long)position;
		[Abstract]
		[Export("notifyCustomEventWithPosition:")]
		bool NotifyCustomEventWithPosition(nint position);

		// @required -(BOOL)notifyCustomEventWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyCustomEventWithLabels:")]
		bool NotifyCustomEventWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyCustomEvent;
		[Abstract]
		[Export("notifyCustomEvent")]

		bool NotifyCustomEvent { get; }

		// @required -(BOOL)notifyCallToActionWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyCallToActionWithPosition:labels:")]
		bool NotifyCallToActionWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyCallToActionWithPosition:(long)position;
		[Abstract]
		[Export("notifyCallToActionWithPosition:")]
		bool NotifyCallToActionWithPosition(nint position);

		// @required -(BOOL)notifyCallToActionWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyCallToActionWithLabels:")]
		bool NotifyCallToActionWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyCallToAction;
		[Abstract]
		[Export("notifyCallToAction")]

		bool NotifyCallToAction { get; }

		// @required -(BOOL)notifyErrorWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyErrorWithPosition:labels:")]
		bool NotifyErrorWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyErrorWithPosition:(long)position;
		[Abstract]
		[Export("notifyErrorWithPosition:")]
		bool NotifyErrorWithPosition(nint position);

		// @required -(BOOL)notifyErrorWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyErrorWithLabels:")]
		bool NotifyErrorWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyError;
		[Abstract]
		[Export("notifyError")]

		bool NotifyError { get; }

		// @required -(BOOL)notifyTransferPlaybackWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyTransferPlaybackWithPosition:labels:")]
		bool NotifyTransferPlaybackWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyTransferPlaybackWithPosition:(long)position;
		[Abstract]
		[Export("notifyTransferPlaybackWithPosition:")]
		bool NotifyTransferPlaybackWithPosition(nint position);

		// @required -(BOOL)notifyTransferPlaybackWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyTransferPlaybackWithLabels:")]
		bool NotifyTransferPlaybackWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyTransferPlayback;
		[Abstract]
		[Export("notifyTransferPlayback")]

		bool NotifyTransferPlayback { get; }

		// @required -(BOOL)notifyDRMFailWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyDRMFailWithPosition:labels:")]
		bool NotifyDRMFailWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyDRMFailWithPosition:(long)position;
		[Abstract]
		[Export("notifyDRMFailWithPosition:")]
		bool NotifyDRMFailWithPosition(nint position);

		// @required -(BOOL)notifyDRMFailWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyDRMFailWithLabels:")]
		bool NotifyDRMFailWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyDRMFail;
		[Abstract]
		[Export("notifyDRMFail")]

		bool NotifyDRMFail { get; }

		// @required -(BOOL)notifyDRMApproveWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyDRMApproveWithPosition:labels:")]
		bool NotifyDRMApproveWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyDRMApproveWithPosition:(long)position;
		[Abstract]
		[Export("notifyDRMApproveWithPosition:")]
		bool NotifyDRMApproveWithPosition(nint position);

		// @required -(BOOL)notifyDRMApproveWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyDRMApproveWithLabels:")]
		bool NotifyDRMApproveWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyDRMApprove;
		[Abstract]
		[Export("notifyDRMApprove")]

		bool NotifyDRMApprove { get; }

		// @required -(BOOL)notifyDRMDenyWithPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyDRMDenyWithPosition:labels:")]
		bool NotifyDRMDenyWithPosition(nint position, NSDictionary labels);

		// @required -(BOOL)notifyDRMDenyWithPosition:(long)position;
		[Abstract]
		[Export("notifyDRMDenyWithPosition:")]
		bool NotifyDRMDenyWithPosition(nint position);

		// @required -(BOOL)notifyDRMDenyWithLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyDRMDenyWithLabels:")]
		bool NotifyDRMDenyWithLabels(NSDictionary labels);

		// @required -(BOOL)notifyDRMDeny;
		[Abstract]
		[Export("notifyDRMDeny")]

		bool NotifyDRMDeny { get; }

		// @required -(BOOL)notifyChangeBitrate:(NSInteger)newBitrate position:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeBitrate:position:labels:")]
		bool NotifyChangeBitrate(nint newBitrate, nint position, NSDictionary labels);

		// @required -(BOOL)notifyChangeBitrate:(NSInteger)newBitrate position:(long)position;
		[Abstract]
		[Export("notifyChangeBitrate:position:")]
		bool NotifyChangeBitrate(nint newBitrate, nint position);

		// @required -(BOOL)notifyChangeBitrate:(NSInteger)newBitrate labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeBitrate:labels:")]
		bool NotifyChangeBitrate(nint newBitrate, NSDictionary labels);

		// @required -(BOOL)notifyChangeBitrate:(NSInteger)newBitrate;
		[Abstract]
		[Export("notifyChangeBitrate:")]
		bool NotifyChangeBitrate(nint newBitrate);

		// @required -(BOOL)notifyChangePlaybackRate:(NSInteger)newPlaybackRate withPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangePlaybackRate:withPosition:labels:")]
		bool NotifyChangePlaybackRate(nint newPlaybackRate, nint position, NSDictionary labels);

		// @required -(BOOL)notifyChangePlaybackRate:(NSInteger)newPlaybackRate position:(long)position;
		[Abstract]
		[Export("notifyChangePlaybackRate:position:")]
		bool NotifyChangePlaybackRate(nint newPlaybackRate, nint position);

		// @required -(BOOL)notifyChangePlaybackRate:(NSInteger)newPlaybackRate labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangePlaybackRate:labels:")]
		bool NotifyChangePlaybackRate(nint newPlaybackRate, NSDictionary labels);

		// @required -(BOOL)notifyChangePlaybackRate:(NSInteger)newRate;
		[Abstract]
		[Export("notifyChangePlaybackRate:")]
		bool NotifyChangePlaybackRate(nint newRate);

		// @required -(BOOL)notifyChangeVolume:(NSInteger)newVolume withPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeVolume:withPosition:labels:")]
		bool NotifyChangeVolume(nint newVolume, nint position, NSDictionary labels);

		// @required -(BOOL)notifyChangeVolume:(NSInteger)newVolume position:(long)position;
		[Abstract]
		[Export("notifyChangeVolume:position:")]
		bool NotifyChangeVolume(nint newVolume, nint position);

		// @required -(BOOL)notifyChangeVolume:(NSInteger)newVolume labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeVolume:labels:")]
		bool NotifyChangeVolume(nint newVolume, NSDictionary labels);

		// @required -(BOOL)notifyChangeVolume:(NSInteger)newVolume;
		[Abstract]
		[Export("notifyChangeVolume:")]
		bool NotifyChangeVolume(nint newVolume);

		// @required -(BOOL)notifyChangeWindowState:(NSString *)newState withPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeWindowState:withPosition:labels:")]
		bool NotifyChangeWindowState(string newState, nint position, NSDictionary labels);

		// @required -(BOOL)notifyChangeWindowState:(NSString *)newState position:(long)position;
		[Abstract]
		[Export("notifyChangeWindowState:position:")]
		bool NotifyChangeWindowState(string newState, nint position);

		// @required -(BOOL)notifyChangeWindowState:(NSString *)newState labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeWindowState:labels:")]
		bool NotifyChangeWindowState(string newState, NSDictionary labels);

		// @required -(BOOL)notifyChangeWindowState:(NSString *)newState;
		[Abstract]
		[Export("notifyChangeWindowState:")]
		bool NotifyChangeWindowState(string newState);

		// @required -(BOOL)notifyChangeAudioTrack:(NSString *)newAudioTrack withPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeAudioTrack:withPosition:labels:")]
		bool NotifyChangeAudioTrack(string newAudioTrack, nint position, NSDictionary labels);

		// @required -(BOOL)notifyChangeAudioTrack:(NSString *)newAudioTrack position:(long)position;
		[Abstract]
		[Export("notifyChangeAudioTrack:position:")]
		bool NotifyChangeAudioTrack(string newAudioTrack, nint position);

		// @required -(BOOL)notifyChangeAudioTrack:(NSString *)newAudioTrack labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeAudioTrack:labels:")]
		bool NotifyChangeAudioTrack(string newAudioTrack, NSDictionary labels);

		// @required -(BOOL)notifyChangeAudioTrack:(NSString *)newAudioTrack;
		[Abstract]
		[Export("notifyChangeAudioTrack:")]
		bool NotifyChangeAudioTrack(string newAudioTrack);

		// @required -(BOOL)notifyChangeVideoTrack:(NSString *)newVideoTrack withPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeVideoTrack:withPosition:labels:")]
		bool NotifyChangeVideoTrack(string newVideoTrack, nint position, NSDictionary labels);

		// @required -(BOOL)notifyChangeVideoTrack:(NSString *)newVideoTrack position:(long)position;
		[Abstract]
		[Export("notifyChangeVideoTrack:position:")]
		bool NotifyChangeVideoTrack(string newVideoTrack, nint position);

		// @required -(BOOL)notifyChangeVideoTrack:(NSString *)newVideoTrack labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeVideoTrack:labels:")]
		bool NotifyChangeVideoTrack(string newVideoTrack, NSDictionary labels);

		// @required -(BOOL)notifyChangeVideoTrack:(NSString *)newVideoTrack;
		[Abstract]
		[Export("notifyChangeVideoTrack:")]
		bool NotifyChangeVideoTrack(string newVideoTrack);

		// @required -(BOOL)notifyChangeSubtitleTrack:(NSString *)newSubtitle withPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeSubtitleTrack:withPosition:labels:")]
		bool NotifyChangeSubtitleTrack(string newSubtitle, nint position, NSDictionary labels);

		// @required -(BOOL)notifyChangeSubtitleTrack:(NSString *)newSubtitle position:(long)position;
		[Abstract]
		[Export("notifyChangeSubtitleTrack:position:")]
		bool NotifyChangeSubtitleTrack(string newSubtitle, nint position);

		// @required -(BOOL)notifyChangeSubtitleTrack:(NSString *)newSubtitle labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeSubtitleTrack:labels:")]
		bool NotifyChangeSubtitleTrack(string newSubtitle, NSDictionary labels);

		// @required -(BOOL)notifyChangeSubtitleTrack:(NSString *)newSubtitle;
		[Abstract]
		[Export("notifyChangeSubtitleTrack:")]
		bool NotifyChangeSubtitleTrack(string newSubtitle);

		// @required -(BOOL)notifyChangeCDN:(NSString *)newCDN withPosition:(long)position labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeCDN:withPosition:labels:")]
		bool NotifyChangeCDN(string newCDN, nint position, NSDictionary labels);

		// @required -(BOOL)notifyChangeCDN:(NSString *)newCDN position:(long)position;
		[Abstract]
		[Export("notifyChangeCDN:position:")]
		bool NotifyChangeCDN(string newCDN, nint position);

		// @required -(BOOL)notifyChangeCDN:(NSString *)newCDN labels:(NSDictionary *)labels;
		[Abstract]
		[Export("notifyChangeCDN:labels:")]
		bool NotifyChangeCDN(string newCDN, NSDictionary labels);

		// @required -(BOOL)notifyChangeCDN:(NSString *)newCDN;
		[Abstract]
		[Export("notifyChangeCDN:")]
		bool NotifyChangeCDN(string newCDN);

		// @required -(void)setLabelWithName:(NSString *)name value:(NSString *)value;
		[Abstract]
		[Export("setLabelWithName:value:")]
		void SetLabelWithName(string name, string value);

		// @required -(void)setLabels:(NSDictionary *)labels;
		[Abstract]
		[Export("setLabels:")]
		void SetLabels(NSDictionary labels);

		// @required -(NSString *)valueForLabel:(NSString *)name;
		[Abstract]
		[Export("valueForLabel:")]
		string ValueForLabel(string name);

		// @required -(BOOL)containsLabel:(NSString *)labelName;
		[Abstract]
		[Export("containsLabel:")]
		bool ContainsLabel(string labelName);
	}

	// @protocol SCORStreamingDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SCORStreamingDelegate
	{
		// @optional -(void)onStateChanged:(SCORStreamingState)oldState newState:(SCORStreamingState)newState eventLabels:(NSDictionary *)eventLabels timeDelta:(NSTimeInterval)timeDelta;
		[Export("onStateChanged:newState:eventLabels:timeDelta:")]
		void NewState(SCORStreamingState oldState, SCORStreamingState newState, NSDictionary eventLabels, double timeDelta);
	}


	// @interface SCORStreamingAsset : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORStreamingAsset
	{
		// @property (readonly) NSDictionary * labels;
		[Export("labels")]
		NSDictionary Labels { get; }

		// @property (readonly) NSInteger clipNumber;
		[Export("clipNumber")]
		nint ClipNumber { get; }

		// @property (nonatomic) _Bool autoCalculatePositions;
		[Export("autoCalculatePositions")]
		bool AutoCalculatePositions { get; set; }

		// -(void)setLabelWithName:(NSString *)labelName withValue:(NSString *)value;
		[Export("setLabelWithName:withValue:")]
		void SetLabelWithName(string labelName, string value);

		// -(void)setLabels:(NSDictionary *)labels;
		[Export("setLabels:")]
		void SetLabels(NSDictionary labels);

		// -(void)removeLabelWithName:(NSString *)name;
		[Export("removeLabelWithName:")]
		void RemoveLabelWithName(string name);

		// -(NSString *)label:(NSString *)labelName;
		[Export("label:")]
		string Label(string labelName);

		// -(BOOL)containsLabel:(NSString *)labelName;
		[Export("containsLabel:")]
		bool ContainsLabel(string labelName);

		// -(void)addStackWithPublisherId:(NSString *)publisherId labels:(NSDictionary *)labels;
		[Export("addStackWithPublisherId:labels:")]
		void AddStackWithPublisherId(string publisherId, NSDictionary labels);

		// -(void)removeStackWithPublisherId:(NSString *)publisherId;
		[Export("removeStackWithPublisherId:")]
		void RemoveStackWithPublisherId(string publisherId);
	}

	// @interface SCORStreamingPlaybackSession : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORStreamingPlaybackSession
	{
		// @property (readonly) NSDictionary * labels;
		[Export("labels")]
		NSDictionary Labels { get; }

		// @property (readonly) SCORStreamingAsset * asset;
		[Export("asset")]
		SCORStreamingAsset Asset { get; }

		// -(void)setLabelWithName:(NSString *)labelName value:(NSString *)value;
		[Export("setLabelWithName:value:")]
		void SetLabelWithName(string labelName, string value);

		// -(void)setLabels:(NSDictionary *)labels;
		[Export("setLabels:")]
		void SetLabels(NSDictionary labels);

		// -(void)removeLabelWithName:(NSString *)name;
		[Export("removeLabelWithName:")]
		void RemoveLabelWithName(string name);

		// -(NSString *)label:(NSString *)labelName;
		[Export("label:")]
		string Label(string labelName);

		// -(BOOL)containsLabel:(NSString *)labelName;
		[Export("containsLabel:")]
		bool ContainsLabel(string labelName);

		// -(NSString *)playbackSessionID;
		[Export("playbackSessionID")]

		string PlaybackSessionID { get; }

		// -(void)setAssetWithLabels:(NSDictionary *)labels;
		[Export("setAssetWithLabels:")]
		void SetAssetWithLabels(NSDictionary labels);

		// -(void)setAssetWithLabels:(NSDictionary *)labels loop:(BOOL)loop;
		[Export("setAssetWithLabels:loop:")]
		void SetAssetWithLabels(NSDictionary labels, bool loop);
	}

	// @interface  (SCORClientConfiguration)
	[Category]
	[BaseType(typeof(SCORClientConfiguration))]
	interface SCORClientConfiguration_
	{

	}

	// @interface  (SCORClientConfigurationBuilder)
	[Category]
	[BaseType(typeof(SCORClientConfigurationBuilder))]
	interface SCORClientConfigurationBuilder_
	{


	}

	// @interface  (SCORConfiguration)
	[Category]
	[BaseType(typeof(SCORConfiguration))]
	interface SCORConfiguration_
	{

	}

	// @interface SCORVCE : NSObject
	[BaseType(typeof(NSObject))]
	interface SCORVCE
	{
		// +(NSString *)sdkVersion;
		[Static]
		[Export("sdkVersion")]

		string SdkVersion { get; }

		// +(void)disable;
		[Static]
		[Export("disable")]
		void Disable();

		// +(BOOL)enabled;
		[Static]
		[Export("enabled")]

		bool Enabled { get; }

		// +(instancetype)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		SCORVCE SharedInstance();

		// -(void)addPartnerID:(NSString *)partnerID;
		[Export("addPartnerID:")]
		void AddPartnerID(string partnerID);

		// -(void)addPublisherID:(NSString *)publisherID;
		[Export("addPublisherID:")]
		void AddPublisherID(string publisherID);

		// -(void)discoverAndTrackAds;
		[Export("discoverAndTrackAds")]
		void DiscoverAndTrackAds();

		// -(void)discoverAndTrackAdClassNames:(NSArray *)classNamesArray;
		[Export("discoverAndTrackAdClassNames:")]
		void DiscoverAndTrackAdClassNames(NSObject[] classNamesArray);

		// -(void)manualTrack;
		[Export("manualTrack")]
		void ManualTrack();

		// -(void)nativeTrack;
		[Export("nativeTrack")]
		void NativeTrack();

		// -(void)trackAdView:(UIView *)adView;
		[Export("trackAdView:")]
		void TrackAdView(UIView adView);

		// -(void)trackAdViewArray:(NSArray *)adViewArray;
		[Export("trackAdViewArray:")]
		void TrackAdViewArray(NSObject[] adViewArray);

		// -(void)trackNativeView:(UIView *)nativeDisplayView withTrackingURL:(NSURL *)displayImpressionURL;
		[Export("trackNativeView:withTrackingURL:")]
		void TrackNativeView(UIView nativeDisplayView, NSUrl displayImpressionURL);

		// -(void)trackNativeView:(UIView *)nativeView forEventName:(NSString *)videoEventName withEventURL:(NSURL *)url withParamsDict:(NSDictionary *)dict;
		[Export("trackNativeView:forEventName:withEventURL:withParamsDict:")]
		void TrackNativeView(UIView nativeView, string videoEventName, NSUrl url, NSDictionary dict);

		// -(void)stopTrackingNativeView:(UIView *)nativeView;
		[Export("stopTrackingNativeView:")]
		void StopTrackingNativeView(UIView nativeView);
	}

	// @interface  (SCORAnalytics)
	[Category]
	[BaseType(typeof(SCORAnalytics))]
	interface SCORAnalytics_
	{
		// +(NSString *)vceVersion;
		[Static]
		[Export("vceVersion")]

		string VceVersion { get; }

		// +(SCORVCE *)sharedVCEInstance;
		[Static]
		[Export("sharedVCEInstance")]

		SCORVCE SharedVCEInstance { get; }
	}

}