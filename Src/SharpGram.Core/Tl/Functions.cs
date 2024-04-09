using SharpGram.Core.Models.Types;using SharpGram.Tl.Types;using SharpGram.Core.Conversions;using SharpGram.Core.Contracts;using Tel = SharpGram.Tl.Constructors;
// ReSharper disable IdentifierTypo PartialTypeWithSinglePart InconsistentNaming CheckNamespace MemberCanBePrivate.Global ClassNeverInstantiated.Global PropertyCanBeMadeInitOnly.Global UnusedAutoPropertyAccessor.Global CollectionNeverUpdated.Global

namespace SharpGram.Tl.Functions {
namespace Account {
        public sealed class AccountInitTakeoutSession : TlFunction<AccountTakeoutBase> {
            public static readonly byte[] Identifier = [176,234,243,142,];
            public bool Contacts {get;set;}
            public bool MessageUsers {get;set;}
            public bool MessageChats {get;set;}
            public bool MessageMegagroups {get;set;}
            public bool MessageChannels {get;set;}
            public bool Files {get;set;}
            public long? FileMaxSize {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (FileMaxSize is not null ? 32 : 0) ).TlSerialize());
                if(FileMaxSize is not null) bytes.AddRange(FileMaxSize.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountRegisterDevice : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [122,1,134,236,];
            public bool NoMuted {get;set;}
            public int TokenType {get;set;}
            public required string Token {get;set;}
            public bool AppSandbox {get;set;}
            public required byte[] Secret {get;set;}
            public required List<long> OtherUids {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(TokenType.TlSerialize());
                bytes.AddRange(Token.TlSerialize());
                bytes.AddRange(Secret.TlSerialize());
                bytes.AddRange(OtherUids.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdateTheme : TlFunction<ThemeBase> {
            public static readonly byte[] Identifier = [204,12,244,43,];
            public required string Format {get;set;}
            public required InputThemeBase Theme {get;set;}
            public string? Slug {get;set;}
            public string? Title {get;set;}
            public InputDocumentBase? Document {get;set;}
            public List<InputThemeSettingsBase>? Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Slug is not null ? 1 : 0) | (Title is not null ? 2 : 0) | (Document is not null ? 4 : 0) | (Settings is not null ? 8 : 0) ).TlSerialize());
                bytes.AddRange(Format.TlSerialize());
                bytes.AddRange(Theme.TlSerialize());
                if(Slug is not null) bytes.AddRange(Slug.TlSerialize());
                if(Title is not null) bytes.AddRange(Title.TlSerialize());
                if(Document is not null) bytes.AddRange(Document.TlSerialize());
                if(Settings is not null) bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSaveAutoSaveSettings : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [97,131,155,214,];
            public bool Users {get;set;}
            public bool Chats {get;set;}
            public bool Broadcasts {get;set;}
            public InputPeerBase? Peer {get;set;}
            public required AutoSaveSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Peer is not null ? 8 : 0) ).TlSerialize());
                if(Peer is not null) bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountAcceptAuthorization : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [115,76,237,243,];
            public long BotId {get;set;}
            public required string Scope {get;set;}
            public required string PublicKey {get;set;}
            public required List<SecureValueHashBase> ValueHashes {get;set;}
            public required SecureCredentialsEncryptedBase Credentials {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(BotId.TlSerialize());
                bytes.AddRange(Scope.TlSerialize());
                bytes.AddRange(PublicKey.TlSerialize());
                bytes.AddRange(ValueHashes.TlSerialize());
                bytes.AddRange(Credentials.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUploadWallPaper : TlFunction<WallPaperBase> {
            public static readonly byte[] Identifier = [3,143,154,227,];
            public bool ForChat {get;set;}
            public required InputFileBase File {get;set;}
            public required string MimeType {get;set;}
            public required WallPaperSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(File.TlSerialize());
                bytes.AddRange(MimeType.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUploadTheme : TlFunction<DocumentBase> {
            public static readonly byte[] Identifier = [51,179,61,28,];
            public required InputFileBase File {get;set;}
            public InputFileBase? Thumb {get;set;}
            public required string FileName {get;set;}
            public required string MimeType {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Thumb is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(File.TlSerialize());
                if(Thumb is not null) bytes.AddRange(Thumb.TlSerialize());
                bytes.AddRange(FileName.TlSerialize());
                bytes.AddRange(MimeType.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountCreateTheme : TlFunction<ThemeBase> {
            public static readonly byte[] Identifier = [0,68,46,101,];
            public required string Slug {get;set;}
            public required string Title {get;set;}
            public InputDocumentBase? Document {get;set;}
            public List<InputThemeSettingsBase>? Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Document is not null ? 4 : 0) | (Settings is not null ? 8 : 0) ).TlSerialize());
                bytes.AddRange(Slug.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                if(Document is not null) bytes.AddRange(Document.TlSerialize());
                if(Settings is not null) bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountInstallTheme : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [59,187,39,199,];
            public bool Dark {get;set;}
            public InputThemeBase? Theme {get;set;}
            public string? Format {get;set;}
            public BaseThemeBase? BaseTheme {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Theme is not null ? 2 : 0) | (Format is not null ? 4 : 0) | (BaseTheme is not null ? 8 : 0) ).TlSerialize());
                if(Theme is not null) bytes.AddRange(Theme.TlSerialize());
                if(Format is not null) bytes.AddRange(Format.TlSerialize());
                if(BaseTheme is not null) bytes.AddRange(BaseTheme.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountChangeAuthorizationSettings : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [98,132,244,64,];
            public bool Confirmed {get;set;}
            public long Hash {get;set;}
            public bool EncryptedRequestsDisabled {get;set;}
            public bool CallRequestsDisabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdateProfile : TlFunction<UserBase> {
            public static readonly byte[] Identifier = [117,87,81,120,];
            public string? FirstName {get;set;}
            public string? LastName {get;set;}
            public string? About {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (FirstName is not null ? 1 : 0) | (LastName is not null ? 2 : 0) | (About is not null ? 4 : 0) ).TlSerialize());
                if(FirstName is not null) bytes.AddRange(FirstName.TlSerialize());
                if(LastName is not null) bytes.AddRange(LastName.TlSerialize());
                if(About is not null) bytes.AddRange(About.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetNotifyExceptions : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [121,116,87,83,];
            public bool CompareSound {get;set;}
            public bool CompareStories {get;set;}
            public InputNotifyPeerBase? Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Peer is not null ? 1 : 0) ).TlSerialize());
                if(Peer is not null) bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSaveAutoDownloadSettings : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [51,98,243,118,];
            public bool Low {get;set;}
            public bool High {get;set;}
            public required AutoDownloadSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountReportProfilePhoto : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [245,198,140,250,];
            public required InputPeerBase Peer {get;set;}
            public required InputPhotoBase PhotoId {get;set;}
            public required ReportReasonBase Reason {get;set;}
            public required string Message {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(PhotoId.TlSerialize());
                bytes.AddRange(Reason.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdateColor : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [93,161,239,124,];
            public bool ForProfile {get;set;}
            public int? Color {get;set;}
            public long? BackgroundEmojiId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Color is not null ? 4 : 0) | (BackgroundEmojiId is not null ? 1 : 0) ).TlSerialize());
                if(Color is not null) bytes.AddRange(Color.TlSerialize());
                if(BackgroundEmojiId is not null) bytes.AddRange(BackgroundEmojiId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUnregisterDevice : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [6,50,13,106,];
            public int TokenType {get;set;}
            public required string Token {get;set;}
            public required List<long> OtherUids {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(TokenType.TlSerialize());
                bytes.AddRange(Token.TlSerialize());
                bytes.AddRange(OtherUids.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountReportPeer : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [134,61,186,197,];
            public required InputPeerBase Peer {get;set;}
            public required ReportReasonBase Reason {get;set;}
            public required string Message {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Reason.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountDeleteAccount : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [116,207,192,162,];
            public required string Reason {get;set;}
            public InputCheckPasswordSRPBase? Password {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Password is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Reason.TlSerialize());
                if(Password is not null) bytes.AddRange(Password.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountChangePhone : TlFunction<UserBase> {
            public static readonly byte[] Identifier = [219,46,195,112,];
            public required string PhoneNumber {get;set;}
            public required string PhoneCodeHash {get;set;}
            public required string PhoneCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                bytes.AddRange(PhoneCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetAuthorizationForm : TlFunction<AccountAuthorizationFormBase> {
            public static readonly byte[] Identifier = [122,89,41,169,];
            public long BotId {get;set;}
            public required string Scope {get;set;}
            public required string PublicKey {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(BotId.TlSerialize());
                bytes.AddRange(Scope.TlSerialize());
                bytes.AddRange(PublicKey.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountVerifyPhone : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [246,167,211,77,];
            public required string PhoneNumber {get;set;}
            public required string PhoneCodeHash {get;set;}
            public required string PhoneCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                bytes.AddRange(PhoneCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSaveWallPaper : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [55,91,90,108,];
            public required InputWallPaperBase Wallpaper {get;set;}
            public bool Unsave {get;set;}
            public required WallPaperSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Wallpaper.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUploadRingtone : TlFunction<DocumentBase> {
            public static readonly byte[] Identifier = [162,131,26,131,];
            public required InputFileBase File {get;set;}
            public required string FileName {get;set;}
            public required string MimeType {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(File.TlSerialize());
                bytes.AddRange(FileName.TlSerialize());
                bytes.AddRange(MimeType.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdateNotifySettings : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [147,91,190,132,];
            public required InputNotifyPeerBase Peer {get;set;}
            public required InputPeerNotifySettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSetPrivacy : TlFunction<AccountPrivacyRulesBase> {
            public static readonly byte[] Identifier = [232,28,248,201,];
            public required InputPrivacyKeyBase Key {get;set;}
            public required List<InputPrivacyRuleBase> Rules {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Key.TlSerialize());
                bytes.AddRange(Rules.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSendChangePhoneCode : TlFunction<AuthSentCodeBase> {
            public static readonly byte[] Identifier = [229,74,87,130,];
            public required string PhoneNumber {get;set;}
            public required CodeSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdatePasswordSettings : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [47,16,155,165,];
            public required InputCheckPasswordSRPBase Password {get;set;}
            public required AccountPasswordInputSettingsBase NewSettings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Password.TlSerialize());
                bytes.AddRange(NewSettings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSendConfirmPhoneCode : TlFunction<AuthSentCodeBase> {
            public static readonly byte[] Identifier = [136,170,63,27,];
            public required string Hash {get;set;}
            public required CodeSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountConfirmPhone : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [195,120,33,95,];
            public required string PhoneCodeHash {get;set;}
            public required string PhoneCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                bytes.AddRange(PhoneCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetTmpPassword : TlFunction<AccountTmpPasswordBase> {
            public static readonly byte[] Identifier = [81,11,158,68,];
            public required InputCheckPasswordSRPBase Password {get;set;}
            public int Period {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Password.TlSerialize());
                bytes.AddRange(Period.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSaveSecureValue : TlFunction<SecureValueBase> {
            public static readonly byte[] Identifier = [29,227,159,137,];
            public required InputSecureValueBase Value {get;set;}
            public long SecureSecretId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Value.TlSerialize());
                bytes.AddRange(SecureSecretId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSendVerifyPhoneCode : TlFunction<AuthSentCodeBase> {
            public static readonly byte[] Identifier = [249,86,163,165,];
            public required string PhoneNumber {get;set;}
            public required CodeSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSendVerifyEmailCode : TlFunction<AccountSentEmailCodeBase> {
            public static readonly byte[] Identifier = [187,55,224,152,];
            public required EmailVerifyPurposeBase Purpose {get;set;}
            public required string Email {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Purpose.TlSerialize());
                bytes.AddRange(Email.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountVerifyEmail : TlFunction<AccountEmailVerifiedBase> {
            public static readonly byte[] Identifier = [207,164,45,3,];
            public required EmailVerifyPurposeBase Purpose {get;set;}
            public required EmailVerificationBase Verification {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Purpose.TlSerialize());
                bytes.AddRange(Verification.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountFinishTakeoutSession : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [238,82,38,29,];
            public bool Success {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountInstallWallPaper : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [105,87,237,254,];
            public required InputWallPaperBase Wallpaper {get;set;}
            public required WallPaperSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Wallpaper.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSaveTheme : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [108,16,87,242,];
            public required InputThemeBase Theme {get;set;}
            public bool Unsave {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Theme.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetTheme : TlFunction<ThemeBase> {
            public static readonly byte[] Identifier = [236,105,88,58,];
            public required string Format {get;set;}
            public required InputThemeBase Theme {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Format.TlSerialize());
                bytes.AddRange(Theme.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetThemes : TlFunction<AccountThemesBase> {
            public static readonly byte[] Identifier = [88,228,6,114,];
            public required string Format {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Format.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSetContentSettings : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [107,177,116,181,];
            public bool SensitiveEnabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSaveRingtone : TlFunction<AccountSavedRingtoneBase> {
            public static readonly byte[] Identifier = [3,91,234,61,];
            public required InputDocumentBase Id {get;set;}
            public bool Unsave {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountToggleUsername : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [118,179,214,88,];
            public required string Username {get;set;}
            public bool Active {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Username.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetNotifySettings : TlFunction<PeerNotifySettingsBase> {
            public static readonly byte[] Identifier = [49,173,179,18,];
            public required InputNotifyPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdateStatus : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [44,86,40,102,];
            public bool Offline {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetWallPapers : TlFunction<AccountWallPapersBase> {
            public static readonly byte[] Identifier = [54,125,150,7,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountCheckUsername : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [108,216,20,39,];
            public required string Username {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Username.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdateUsername : TlFunction<UserBase> {
            public static readonly byte[] Identifier = [124,221,11,62,];
            public required string Username {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Username.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetPrivacy : TlFunction<AccountPrivacyRulesBase> {
            public static readonly byte[] Identifier = [80,201,219,218,];
            public required InputPrivacyKeyBase Key {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Key.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSetAccountTTL : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [94,72,66,36,];
            public required AccountDaysTTLBase Ttl {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Ttl.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdateDeviceLocked : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [50,53,223,56,];
            public int Period {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Period.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountResetAuthorization : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [188,243,119,223,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetPasswordSettings : TlFunction<AccountPasswordSettingsBase> {
            public static readonly byte[] Identifier = [249,234,212,156,];
            public required InputCheckPasswordSRPBase Password {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Password.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountResetWebAuthorization : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [239,185,1,45,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetSecureValue : TlFunction<TlList<SecureValueBase>> {
            public static readonly byte[] Identifier = [194,91,102,115,];
            public required List<SecureValueTypeBase> Types {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Types.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountDeleteSecureValue : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [75,188,128,184,];
            public required List<SecureValueTypeBase> Types {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Types.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountConfirmPasswordEmail : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [32,25,223,143,];
            public required string Code {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Code.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSetContactSignUpNotification : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [97,63,244,207,];
            public bool Silent {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetWallPaper : TlFunction<WallPaperBase> {
            public static readonly byte[] Identifier = [234,219,141,252,];
            public required InputWallPaperBase Wallpaper {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Wallpaper.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetMultiWallPapers : TlFunction<TlList<WallPaperBase>> {
            public static readonly byte[] Identifier = [220,113,173,101,];
            public required List<InputWallPaperBase> Wallpapers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Wallpapers.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSetGlobalPrivacySettings : TlFunction<GlobalPrivacySettingsBase> {
            public static readonly byte[] Identifier = [194,170,218,30,];
            public required GlobalPrivacySettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetChatThemes : TlFunction<AccountThemesBase> {
            public static readonly byte[] Identifier = [137,222,56,214,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountSetAuthorizationTTL : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [160,154,137,191,];
            public int AuthorizationTtlDays {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(AuthorizationTtlDays.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetSavedRingtones : TlFunction<AccountSavedRingtonesBase> {
            public static readonly byte[] Identifier = [136,34,144,225,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountUpdateEmojiStatus : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [107,222,211,251,];
            public required EmojiStatusBase EmojiStatus {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(EmojiStatus.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetDefaultEmojiStatuses : TlFunction<AccountEmojiStatusesBase> {
            public static readonly byte[] Identifier = [134,51,117,214,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetRecentEmojiStatuses : TlFunction<AccountEmojiStatusesBase> {
            public static readonly byte[] Identifier = [5,129,87,15,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountReorderUsernames : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [171,14,80,239,];
            public required List<string> Order {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Order.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetDefaultProfilePhotoEmojis : TlFunction<EmojiListBase> {
            public static readonly byte[] Identifier = [40,3,117,226,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetDefaultGroupPhotoEmojis : TlFunction<EmojiListBase> {
            public static readonly byte[] Identifier = [174,96,88,145,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountInvalidateSignInCodes : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [186,232,138,202,];
            public required List<string> Codes {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Codes.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetDefaultBackgroundEmojis : TlFunction<EmojiListBase> {
            public static readonly byte[] Identifier = [206,185,10,166,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetChannelDefaultEmojiStatuses : TlFunction<AccountEmojiStatusesBase> {
            public static readonly byte[] Identifier = [213,167,39,119,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetChannelRestrictedStatusEmojis : TlFunction<EmojiListBase> {
            public static readonly byte[] Identifier = [213,224,169,53,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AccountResetNotifySettings : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [71,23,126,219,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetAccountTTL : TlFunction<AccountDaysTTLBase> {
            public static readonly byte[] Identifier = [29,113,252,8,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetAuthorizations : TlFunction<AccountAuthorizationsBase> {
            public static readonly byte[] Identifier = [88,193,32,227,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetPassword : TlFunction<AccountPasswordBase> {
            public static readonly byte[] Identifier = [245,48,138,84,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetWebAuthorizations : TlFunction<AccountWebAuthorizationsBase> {
            public static readonly byte[] Identifier = [111,109,46,24,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountResetWebAuthorizations : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [148,37,45,104,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetAllSecureValues : TlFunction<TlList<SecureValueBase>> {
            public static readonly byte[] Identifier = [125,188,136,178,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountResendPasswordEmail : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [21,42,127,122,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountCancelPasswordEmail : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [182,213,203,193,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetContactSignUpNotification : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [40,199,7,159,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountResetWallPapers : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [4,152,59,187,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetAutoDownloadSettings : TlFunction<AccountAutoDownloadSettingsBase> {
            public static readonly byte[] Identifier = [63,11,218,86,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetContentSettings : TlFunction<AccountContentSettingsBase> {
            public static readonly byte[] Identifier = [174,77,155,139,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetGlobalPrivacySettings : TlFunction<GlobalPrivacySettingsBase> {
            public static readonly byte[] Identifier = [246,76,43,235,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountResetPassword : TlFunction<AccountResetPasswordResultBase> {
            public static readonly byte[] Identifier = [27,206,8,147,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountDeclinePasswordReset : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [246,9,148,76,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountClearRecentEmojiStatuses : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [174,26,32,24,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountGetAutoSaveSettings : TlFunction<AccountAutoSaveSettingsBase> {
            public static readonly byte[] Identifier = [218,188,203,173,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AccountDeleteAutoSaveExceptions : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [32,0,188,83,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Auth {
        public sealed class AuthSignIn : TlFunction<AuthAuthorizationBase> {
            public static readonly byte[] Identifier = [81,169,82,141,];
            public required string PhoneNumber {get;set;}
            public required string PhoneCodeHash {get;set;}
            public string? PhoneCode {get;set;}
            public EmailVerificationBase? EmailVerification {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (PhoneCode is not null ? 1 : 0) | (EmailVerification is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                if(PhoneCode is not null) bytes.AddRange(PhoneCode.TlSerialize());
                if(EmailVerification is not null) bytes.AddRange(EmailVerification.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthRequestFirebaseSms : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [80,75,70,137,];
            public required string PhoneNumber {get;set;}
            public required string PhoneCodeHash {get;set;}
            public string? SafetyNetToken {get;set;}
            public string? IosPushSecret {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (SafetyNetToken is not null ? 1 : 0) | (IosPushSecret is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                if(SafetyNetToken is not null) bytes.AddRange(SafetyNetToken.TlSerialize());
                if(IosPushSecret is not null) bytes.AddRange(IosPushSecret.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthSendCode : TlFunction<AuthSentCodeBase> {
            public static readonly byte[] Identifier = [79,36,119,166,];
            public required string PhoneNumber {get;set;}
            public int ApiId {get;set;}
            public required string ApiHash {get;set;}
            public required CodeSettingsBase Settings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(ApiId.TlSerialize());
                bytes.AddRange(ApiHash.TlSerialize());
                bytes.AddRange(Settings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthSignUp : TlFunction<AuthAuthorizationBase> {
            public static readonly byte[] Identifier = [39,228,238,128,];
            public required string PhoneNumber {get;set;}
            public required string PhoneCodeHash {get;set;}
            public required string FirstName {get;set;}
            public required string LastName {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                bytes.AddRange(FirstName.TlSerialize());
                bytes.AddRange(LastName.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthBindTempAuthKey : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [5,42,212,205,];
            public long PermAuthKeyId {get;set;}
            public long Nonce {get;set;}
            public int ExpiresAt {get;set;}
            public required byte[] EncryptedMessage {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PermAuthKeyId.TlSerialize());
                bytes.AddRange(Nonce.TlSerialize());
                bytes.AddRange(ExpiresAt.TlSerialize());
                bytes.AddRange(EncryptedMessage.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthImportBotAuthorization : TlFunction<AuthAuthorizationBase> {
            public static readonly byte[] Identifier = [44,255,163,103,];
            public int Flags {get;set;}
            public int ApiId {get;set;}
            public required string ApiHash {get;set;}
            public required string BotAuthToken {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Flags.TlSerialize());
                bytes.AddRange(ApiId.TlSerialize());
                bytes.AddRange(ApiHash.TlSerialize());
                bytes.AddRange(BotAuthToken.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthRecoverPassword : TlFunction<AuthAuthorizationBase> {
            public static readonly byte[] Identifier = [112,108,9,55,];
            public required string Code {get;set;}
            public AccountPasswordInputSettingsBase? NewSettings {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (NewSettings is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Code.TlSerialize());
                if(NewSettings is not null) bytes.AddRange(NewSettings.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthExportLoginToken : TlFunction<AuthLoginTokenBase> {
            public static readonly byte[] Identifier = [254,133,224,183,];
            public int ApiId {get;set;}
            public required string ApiHash {get;set;}
            public required List<long> ExceptIds {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ApiId.TlSerialize());
                bytes.AddRange(ApiHash.TlSerialize());
                bytes.AddRange(ExceptIds.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthImportWebTokenAuthorization : TlFunction<AuthAuthorizationBase> {
            public static readonly byte[] Identifier = [169,115,184,45,];
            public int ApiId {get;set;}
            public required string ApiHash {get;set;}
            public required string WebAuthToken {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ApiId.TlSerialize());
                bytes.AddRange(ApiHash.TlSerialize());
                bytes.AddRange(WebAuthToken.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthImportAuthorization : TlFunction<AuthAuthorizationBase> {
            public static readonly byte[] Identifier = [173,125,122,165,];
            public long Id {get;set;}
            public required byte[] Bytes {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(Bytes.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthResendCode : TlFunction<AuthSentCodeBase> {
            public static readonly byte[] Identifier = [191,169,241,62,];
            public required string PhoneNumber {get;set;}
            public required string PhoneCodeHash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthCancelCode : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [120,5,4,31,];
            public required string PhoneNumber {get;set;}
            public required string PhoneCodeHash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthResetLoginEmail : TlFunction<AuthSentCodeBase> {
            public static readonly byte[] Identifier = [147,1,150,126,];
            public required string PhoneNumber {get;set;}
            public required string PhoneCodeHash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PhoneNumber.TlSerialize());
                bytes.AddRange(PhoneCodeHash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthExportAuthorization : TlFunction<AuthExportedAuthorizationBase> {
            public static readonly byte[] Identifier = [205,255,191,229,];
            public int DcId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(DcId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthCheckPassword : TlFunction<AuthAuthorizationBase> {
            public static readonly byte[] Identifier = [22,77,139,209,];
            public required InputCheckPasswordSRPBase Password {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Password.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthDropTempAuthKeys : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [136,161,72,142,];
            public required List<long> ExceptAuthKeys {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ExceptAuthKeys.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthImportLoginToken : TlFunction<AuthLoginTokenBase> {
            public static readonly byte[] Identifier = [228,92,172,149,];
            public required byte[] Token {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Token.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthAcceptLoginToken : TlFunction<AuthorizationBase> {
            public static readonly byte[] Identifier = [77,173,148,232,];
            public required byte[] Token {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Token.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthCheckRecoveryPassword : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [121,191,54,13,];
            public required string Code {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Code.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class AuthLogOut : TlFunction<AuthLoggedOutBase> {
            public static readonly byte[] Identifier = [25,186,114,62,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AuthResetAuthorizations : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [26,13,171,159,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class AuthRequestPasswordRecovery : TlFunction<AuthPasswordRecoveryBase> {
            public static readonly byte[] Identifier = [102,188,151,216,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Bots {
        public sealed class BotsSetBotInfo : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [35,49,207,16,];
            public InputUserBase? Bot {get;set;}
            public required string LangCode {get;set;}
            public string? Name {get;set;}
            public string? About {get;set;}
            public string? Description {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Bot is not null ? 4 : 0) | (Name is not null ? 8 : 0) | (About is not null ? 1 : 0) | (Description is not null ? 2 : 0) ).TlSerialize());
                if(Bot is not null) bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                if(Name is not null) bytes.AddRange(Name.TlSerialize());
                if(About is not null) bytes.AddRange(About.TlSerialize());
                if(Description is not null) bytes.AddRange(Description.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsSetBotCommands : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [90,22,23,5,];
            public required BotCommandScopeBase Scope {get;set;}
            public required string LangCode {get;set;}
            public required List<BotCommandBase> Commands {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Scope.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                bytes.AddRange(Commands.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsGetBotInfo : TlFunction<BotsBotInfoBase> {
            public static readonly byte[] Identifier = [253,20,217,220,];
            public InputUserBase? Bot {get;set;}
            public required string LangCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Bot is not null ? 1 : 0) ).TlSerialize());
                if(Bot is not null) bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsToggleUsername : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [115,169,60,5,];
            public required InputUserBase Bot {get;set;}
            public required string Username {get;set;}
            public bool Active {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(Username.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsInvokeWebViewCustomMethod : TlFunction<DataJSONBase> {
            public static readonly byte[] Identifier = [231,197,127,8,];
            public required InputUserBase Bot {get;set;}
            public required string CustomMethod {get;set;}
            public required DataJSONBase Params {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(CustomMethod.TlSerialize());
                bytes.AddRange(Params.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsSendCustomRequest : TlFunction<DataJSONBase> {
            public static readonly byte[] Identifier = [237,105,39,170,];
            public required string CustomMethod {get;set;}
            public required DataJSONBase Params {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(CustomMethod.TlSerialize());
                bytes.AddRange(Params.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsAnswerWebhookJSONQuery : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [77,63,33,230,];
            public long QueryId {get;set;}
            public required DataJSONBase Data {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(QueryId.TlSerialize());
                bytes.AddRange(Data.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsResetBotCommands : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [249,224,141,61,];
            public required BotCommandScopeBase Scope {get;set;}
            public required string LangCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Scope.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsGetBotCommands : TlFunction<TlList<BotCommandBase>> {
            public static readonly byte[] Identifier = [214,13,76,227,];
            public required BotCommandScopeBase Scope {get;set;}
            public required string LangCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Scope.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsSetBotMenuButton : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [79,213,4,69,];
            public required InputUserBase UserId {get;set;}
            public required BotMenuButtonBase Button {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(Button.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsReorderUsernames : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [194,177,9,151,];
            public required InputUserBase Bot {get;set;}
            public required List<string> Order {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(Order.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsGetBotMenuButton : TlFunction<BotMenuButtonBase> {
            public static readonly byte[] Identifier = [40,235,96,156,];
            public required InputUserBase UserId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(UserId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsSetBotBroadcastDefaultAdminRights : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [225,100,132,120,];
            public required ChatAdminRightsBase AdminRights {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(AdminRights.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsSetBotGroupDefaultAdminRights : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [234,201,94,146,];
            public required ChatAdminRightsBase AdminRights {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(AdminRights.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsCanSendMessage : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [230,244,89,19,];
            public required InputUserBase Bot {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Bot.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class BotsAllowSendMessage : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [239,227,50,241,];
            public required InputUserBase Bot {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Bot.TlSerialize());
                return bytes.ToArray();
            }
        }
}
namespace Channels {
        public sealed class ChannelsCreateChannel : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [7,103,0,145,];
            public bool Broadcast {get;set;}
            public bool Megagroup {get;set;}
            public bool ForImport {get;set;}
            public bool Forum {get;set;}
            public required string Title {get;set;}
            public required string About {get;set;}
            public InputGeoPointBase? GeoPoint {get;set;}
            public string? Address {get;set;}
            public int? TtlPeriod {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (GeoPoint is not null ? 4 : 0) | (Address is not null ? 4 : 0) | (TtlPeriod is not null ? 16 : 0) ).TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                bytes.AddRange(About.TlSerialize());
                if(GeoPoint is not null) bytes.AddRange(GeoPoint.TlSerialize());
                if(Address is not null) bytes.AddRange(Address.TlSerialize());
                if(TtlPeriod is not null) bytes.AddRange(TtlPeriod.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetAdminLog : TlFunction<ChannelsAdminLogResultsBase> {
            public static readonly byte[] Identifier = [128,244,221,51,];
            public required InputChannelBase Channel {get;set;}
            public required string Q {get;set;}
            public ChannelAdminLogEventsFilterBase? EventsFilter {get;set;}
            public List<InputUserBase>? Admins {get;set;}
            public long MaxId {get;set;}
            public long MinId {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (EventsFilter is not null ? 1 : 0) | (Admins is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Q.TlSerialize());
                if(EventsFilter is not null) bytes.AddRange(EventsFilter.TlSerialize());
                if(Admins is not null) bytes.AddRange(Admins.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(MinId.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsCreateForumTopic : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [36,2,12,244,];
            public required InputChannelBase Channel {get;set;}
            public required string Title {get;set;}
            public int? IconColor {get;set;}
            public long? IconEmojiId {get;set;}
            public long RandomId {get;set;}
            public InputPeerBase? SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (IconColor is not null ? 1 : 0) | (IconEmojiId is not null ? 8 : 0) | (SendAs is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                if(IconColor is not null) bytes.AddRange(IconColor.TlSerialize());
                if(IconEmojiId is not null) bytes.AddRange(IconEmojiId.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                if(SendAs is not null) bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetForumTopics : TlFunction<MessagesForumTopicsBase> {
            public static readonly byte[] Identifier = [209,96,229,13,];
            public required InputChannelBase Channel {get;set;}
            public string? Q {get;set;}
            public int OffsetDate {get;set;}
            public int OffsetId {get;set;}
            public int OffsetTopic {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Q is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                if(Q is not null) bytes.AddRange(Q.TlSerialize());
                bytes.AddRange(OffsetDate.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(OffsetTopic.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsEditForumTopic : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [133,161,223,244,];
            public required InputChannelBase Channel {get;set;}
            public int TopicId {get;set;}
            public string? Title {get;set;}
            public long? IconEmojiId {get;set;}
            public bool Closed {get;set;}
            public bool Hidden {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Title is not null ? 1 : 0) | (IconEmojiId is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(TopicId.TlSerialize());
                if(Title is not null) bytes.AddRange(Title.TlSerialize());
                if(IconEmojiId is not null) bytes.AddRange(IconEmojiId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetParticipants : TlFunction<ChannelsChannelParticipantsBase> {
            public static readonly byte[] Identifier = [208,217,206,119,];
            public required InputChannelBase Channel {get;set;}
            public required ChannelParticipantsFilterBase Filter {get;set;}
            public int Offset {get;set;}
            public int Limit {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Filter.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsExportMessageLink : TlFunction<ExportedMessageLinkBase> {
            public static readonly byte[] Identifier = [235,173,63,230,];
            public bool Grouped {get;set;}
            public bool Thread {get;set;}
            public required InputChannelBase Channel {get;set;}
            public int Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsUpdateColor : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [113,54,170,216,];
            public bool ForProfile {get;set;}
            public required InputChannelBase Channel {get;set;}
            public int? Color {get;set;}
            public long? BackgroundEmojiId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Color is not null ? 4 : 0) | (BackgroundEmojiId is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                if(Color is not null) bytes.AddRange(Color.TlSerialize());
                if(BackgroundEmojiId is not null) bytes.AddRange(BackgroundEmojiId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsEditAdmin : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [2,137,60,211,];
            public required InputChannelBase Channel {get;set;}
            public required InputUserBase UserId {get;set;}
            public required ChatAdminRightsBase AdminRights {get;set;}
            public required string Rank {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(AdminRights.TlSerialize());
                bytes.AddRange(Rank.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsDeleteHistory : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [71,150,170,155,];
            public bool ForEveryone {get;set;}
            public required InputChannelBase Channel {get;set;}
            public int MaxId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsReorderPinnedForumTopics : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [143,161,80,41,];
            public bool Force {get;set;}
            public required InputChannelBase Channel {get;set;}
            public required List<int> Order {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Order.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsReportSpam : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [21,131,74,244,];
            public required InputChannelBase Channel {get;set;}
            public required InputPeerBase Participant {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Participant.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetAdminedPublicChannels : TlFunction<MessagesChatsBase> {
            public static readonly byte[] Identifier = [175,54,176,248,];
            public bool ByLocation {get;set;}
            public bool CheckLimit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsEditBanned : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [129,205,230,150,];
            public required InputChannelBase Channel {get;set;}
            public required InputPeerBase Participant {get;set;}
            public required ChatBannedRightsBase BannedRights {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Participant.TlSerialize());
                bytes.AddRange(BannedRights.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsEditCreator : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [31,205,56,143,];
            public required InputChannelBase Channel {get;set;}
            public required InputUserBase UserId {get;set;}
            public required InputCheckPasswordSRPBase Password {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(Password.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsEditLocation : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [109,63,230,88,];
            public required InputChannelBase Channel {get;set;}
            public required InputGeoPointBase GeoPoint {get;set;}
            public required string Address {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(GeoPoint.TlSerialize());
                bytes.AddRange(Address.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleUsername : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [5,65,242,80,];
            public required InputChannelBase Channel {get;set;}
            public required string Username {get;set;}
            public bool Active {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Username.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsUpdatePinnedForumTopic : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [38,144,45,108,];
            public required InputChannelBase Channel {get;set;}
            public int TopicId {get;set;}
            public bool Pinned {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(TopicId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsReadHistory : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [55,73,16,204,];
            public required InputChannelBase Channel {get;set;}
            public int MaxId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsDeleteMessages : TlFunction<MessagesAffectedMessagesBase> {
            public static readonly byte[] Identifier = [78,253,193,132,];
            public required InputChannelBase Channel {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetMessages : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [35,154,140,173,];
            public required InputChannelBase Channel {get;set;}
            public required List<InputMessageBase> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetParticipant : TlFunction<ChannelsChannelParticipantBase> {
            public static readonly byte[] Identifier = [198,108,171,160,];
            public required InputChannelBase Channel {get;set;}
            public required InputPeerBase Participant {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Participant.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsEditTitle : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [208,236,109,86,];
            public required InputChannelBase Channel {get;set;}
            public required string Title {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsEditPhoto : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [201,87,46,241,];
            public required InputChannelBase Channel {get;set;}
            public required InputChatPhotoBase Photo {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Photo.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsCheckUsername : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [44,189,230,16,];
            public required InputChannelBase Channel {get;set;}
            public required string Username {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Username.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsUpdateUsername : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [222,179,20,53,];
            public required InputChannelBase Channel {get;set;}
            public required string Username {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Username.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsInviteToChannel : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [108,58,159,25,];
            public required InputChannelBase Channel {get;set;}
            public required List<InputUserBase> Users {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Users.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleSignatures : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [6,182,105,31,];
            public required InputChannelBase Channel {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsSetStickers : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [249,164,140,234,];
            public required InputChannelBase Channel {get;set;}
            public required InputStickerSetBase Stickerset {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Stickerset.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsReadMessageContents : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [56,220,181,234,];
            public required InputChannelBase Channel {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsTogglePreHistoryHidden : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [76,185,187,234,];
            public required InputChannelBase Channel {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsSetDiscussionGroup : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [178,43,88,64,];
            public required InputChannelBase Broadcast {get;set;}
            public required InputChannelBase Group {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Broadcast.TlSerialize());
                bytes.AddRange(Group.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleSlowMode : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [240,158,212,237,];
            public required InputChannelBase Channel {get;set;}
            public int Seconds {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Seconds.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsViewSponsoredMessage : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [148,219,174,190,];
            public required InputChannelBase Channel {get;set;}
            public required byte[] RandomId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsDeleteParticipantHistory : TlFunction<MessagesAffectedHistoryBase> {
            public static readonly byte[] Identifier = [219,68,117,54,];
            public required InputChannelBase Channel {get;set;}
            public required InputPeerBase Participant {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Participant.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleJoinToSend : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [128,149,203,228,];
            public required InputChannelBase Channel {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleJoinRequest : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [182,133,41,76,];
            public required InputChannelBase Channel {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsReorderUsernames : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [29,237,92,180,];
            public required InputChannelBase Channel {get;set;}
            public required List<string> Order {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Order.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleForum : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [41,139,41,164,];
            public required InputChannelBase Channel {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetForumTopicsByID : TlFunction<MessagesForumTopicsBase> {
            public static readonly byte[] Identifier = [185,30,131,176,];
            public required InputChannelBase Channel {get;set;}
            public required List<int> Topics {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Topics.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsDeleteTopicHistory : TlFunction<MessagesAffectedHistoryBase> {
            public static readonly byte[] Identifier = [45,95,67,52,];
            public required InputChannelBase Channel {get;set;}
            public int TopMsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(TopMsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleAntiSpam : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [235,228,243,104,];
            public required InputChannelBase Channel {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsReportAntiSpamFalsePositive : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [147,166,80,168,];
            public required InputChannelBase Channel {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleParticipantsHidden : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [84,120,110,106,];
            public required InputChannelBase Channel {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsClickSponsoredMessage : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [147,188,175,24,];
            public required InputChannelBase Channel {get;set;}
            public required byte[] RandomId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsToggleViewForumAsMessages : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [21,187,56,151,];
            public required InputChannelBase Channel {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsUpdateEmojiStatus : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [168,230,211,240,];
            public required InputChannelBase Channel {get;set;}
            public required EmojiStatusBase EmojiStatus {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(EmojiStatus.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetChannels : TlFunction<MessagesChatsBase> {
            public static readonly byte[] Identifier = [187,107,127,10,];
            public required List<InputChannelBase> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetFullChannel : TlFunction<MessagesChatFullBase> {
            public static readonly byte[] Identifier = [9,106,115,8,];
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsJoinChannel : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [197,36,181,36,];
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsLeaveChannel : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [149,170,54,248,];
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsDeleteChannel : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [227,31,17,192,];
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetLeftChannels : TlFunction<MessagesChatsBase> {
            public static readonly byte[] Identifier = [192,236,65,131,];
            public int Offset {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Offset.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsConvertToGigagroup : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [105,12,41,11,];
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetSponsoredMessages : TlFunction<MessagesSponsoredMessagesBase> {
            public static readonly byte[] Identifier = [191,15,33,236,];
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetSendAs : TlFunction<ChannelsSendAsPeersBase> {
            public static readonly byte[] Identifier = [238,112,199,13,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsDeactivateAllUsernames : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [211,93,36,10,];
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetChannelRecommendations : TlFunction<MessagesChatsBase> {
            public static readonly byte[] Identifier = [151,13,183,131,];
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetGroupsForDiscussion : TlFunction<MessagesChatsBase> {
            public static readonly byte[] Identifier = [120,211,218,245,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class ChannelsGetInactiveChannels : TlFunction<MessagesInactiveChatsBase> {
            public static readonly byte[] Identifier = [238,49,232,17,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Chatlists {
        public sealed class ChatlistsEditExportedInvite : TlFunction<ExportedChatlistInviteBase> {
            public static readonly byte[] Identifier = [61,182,61,101,];
            public required InputChatlistBase Chatlist {get;set;}
            public required string Slug {get;set;}
            public string? Title {get;set;}
            public List<InputPeerBase>? Peers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Title is not null ? 2 : 0) | (Peers is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Chatlist.TlSerialize());
                bytes.AddRange(Slug.TlSerialize());
                if(Title is not null) bytes.AddRange(Title.TlSerialize());
                if(Peers is not null) bytes.AddRange(Peers.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsExportChatlistInvite : TlFunction<ChatlistsExportedChatlistInviteBase> {
            public static readonly byte[] Identifier = [142,71,114,132,];
            public required InputChatlistBase Chatlist {get;set;}
            public required string Title {get;set;}
            public required List<InputPeerBase> Peers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Chatlist.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                bytes.AddRange(Peers.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsDeleteExportedInvite : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [94,92,156,113,];
            public required InputChatlistBase Chatlist {get;set;}
            public required string Slug {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Chatlist.TlSerialize());
                bytes.AddRange(Slug.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsJoinChatlistInvite : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [154,227,177,166,];
            public required string Slug {get;set;}
            public required List<InputPeerBase> Peers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Slug.TlSerialize());
                bytes.AddRange(Peers.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsJoinChatlistUpdates : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [245,248,137,224,];
            public required InputChatlistBase Chatlist {get;set;}
            public required List<InputPeerBase> Peers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Chatlist.TlSerialize());
                bytes.AddRange(Peers.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsLeaveChatlist : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [58,225,250,116,];
            public required InputChatlistBase Chatlist {get;set;}
            public required List<InputPeerBase> Peers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Chatlist.TlSerialize());
                bytes.AddRange(Peers.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsGetExportedInvites : TlFunction<ChatlistsExportedInvitesBase> {
            public static readonly byte[] Identifier = [131,218,3,206,];
            public required InputChatlistBase Chatlist {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Chatlist.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsCheckChatlistInvite : TlFunction<ChatlistsChatlistInviteBase> {
            public static readonly byte[] Identifier = [255,15,193,65,];
            public required string Slug {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Slug.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsGetChatlistUpdates : TlFunction<ChatlistsChatlistUpdatesBase> {
            public static readonly byte[] Identifier = [33,149,65,137,];
            public required InputChatlistBase Chatlist {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Chatlist.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsHideChatlistUpdates : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [251,134,228,102,];
            public required InputChatlistBase Chatlist {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Chatlist.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ChatlistsGetLeaveChatlistSuggestions : TlFunction<TlList<PeerBase>> {
            public static readonly byte[] Identifier = [20,215,188,253,];
            public required InputChatlistBase Chatlist {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Chatlist.TlSerialize());
                return bytes.ToArray();
            }
        }
}
namespace Contacts {
        public sealed class ContactsGetTopPeers : TlFunction<ContactsTopPeersBase> {
            public static readonly byte[] Identifier = [182,120,52,151,];
            public bool Correspondents {get;set;}
            public bool BotsPm {get;set;}
            public bool BotsInline {get;set;}
            public bool PhoneCalls {get;set;}
            public bool ForwardUsers {get;set;}
            public bool ForwardChats {get;set;}
            public bool Groups {get;set;}
            public bool Channels {get;set;}
            public int Offset {get;set;}
            public int Limit {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsAddContact : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [208,99,244,232,];
            public bool AddPhonePrivacyException {get;set;}
            public required InputUserBase Id {get;set;}
            public required string FirstName {get;set;}
            public required string LastName {get;set;}
            public required string Phone {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(FirstName.TlSerialize());
                bytes.AddRange(LastName.TlSerialize());
                bytes.AddRange(Phone.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsBlockFromReplies : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [44,150,168,41,];
            public bool DeleteMessage {get;set;}
            public bool DeleteHistory {get;set;}
            public bool ReportSpam {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsGetBlocked : TlFunction<ContactsBlockedBase> {
            public static readonly byte[] Identifier = [128,143,134,154,];
            public bool MyStoriesFrom {get;set;}
            public int Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsGetLocated : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [68,188,72,211,];
            public bool Background {get;set;}
            public required InputGeoPointBase GeoPoint {get;set;}
            public int? SelfExpires {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (SelfExpires is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(GeoPoint.TlSerialize());
                if(SelfExpires is not null) bytes.AddRange(SelfExpires.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsSetBlocked : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [118,92,198,148,];
            public bool MyStoriesFrom {get;set;}
            public required List<InputPeerBase> Id {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsBlock : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [52,135,46,46,];
            public bool MyStoriesFrom {get;set;}
            public required InputPeerBase Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsUnblock : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [40,211,80,181,];
            public bool MyStoriesFrom {get;set;}
            public required InputPeerBase Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsSearch : TlFunction<ContactsFoundBase> {
            public static readonly byte[] Identifier = [216,18,248,17,];
            public required string Q {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Q.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsResetTopPeerRating : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [172,115,227,26,];
            public required TopPeerCategoryBase Category {get;set;}
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Category.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsGetContactIDs : TlFunction<TlList<TlInt>> {
            public static readonly byte[] Identifier = [157,102,220,122,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsGetContacts : TlFunction<ContactsContactsBase> {
            public static readonly byte[] Identifier = [18,158,214,93,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsImportContacts : TlFunction<ContactsImportedContactsBase> {
            public static readonly byte[] Identifier = [229,11,128,44,];
            public required List<InputContactBase> Contacts {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Contacts.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsDeleteContacts : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [0,14,106,9,];
            public required List<InputUserBase> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsDeleteByPhones : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [158,253,19,16,];
            public required List<string> Phones {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Phones.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsResolveUsername : TlFunction<ContactsResolvedPeerBase> {
            public static readonly byte[] Identifier = [163,203,60,249,];
            public required string Username {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Username.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsToggleTopPeers : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [218,189,20,133,];
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class ContactsAcceptContact : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [15,162,49,248,];
            public required InputUserBase Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsResolvePhone : TlFunction<ContactsResolvedPeerBase> {
            public static readonly byte[] Identifier = [68,67,249,138,];
            public required string Phone {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Phone.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsImportContactToken : TlFunction<UserBase> {
            public static readonly byte[] Identifier = [136,87,0,19,];
            public required string Token {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Token.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsEditCloseFriends : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [240,5,103,186,];
            public required List<long> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class ContactsGetStatuses : TlFunction<TlList<ContactStatusBase>> {
            public static readonly byte[] Identifier = [238,83,163,196,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class ContactsResetSaved : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [241,55,149,135,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class ContactsGetSaved : TlFunction<TlList<SavedContactBase>> {
            public static readonly byte[] Identifier = [159,227,241,130,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class ContactsExportContactToken : TlFunction<ExportedContactTokenBase> {
            public static readonly byte[] Identifier = [39,64,101,248,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Folders {
        public sealed class FoldersEditPeerFolders : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [171,208,71,104,];
            public required List<InputFolderPeerBase> FolderPeers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(FolderPeers.TlSerialize());
                return bytes.ToArray();
            }
        }
}
namespace Help {
        public sealed class HelpEditUserInfo : TlFunction<HelpUserInfoBase> {
            public static readonly byte[] Identifier = [112,27,185,102,];
            public required InputUserBase UserId {get;set;}
            public required string Message {get;set;}
            public required List<MessageEntityBase> Entities {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                bytes.AddRange(Entities.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpSetBotUpdatesStatus : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [205,207,34,236,];
            public int PendingUpdatesCount {get;set;}
            public required string Message {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(PendingUpdatesCount.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpDismissSuggestion : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [161,186,13,245,];
            public required InputPeerBase Peer {get;set;}
            public required string Suggestion {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Suggestion.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetCountriesList : TlFunction<HelpCountriesListBase> {
            public static readonly byte[] Identifier = [168,135,87,115,];
            public required string LangCode {get;set;}
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangCode.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetAppUpdate : TlFunction<HelpAppUpdateBase> {
            public static readonly byte[] Identifier = [125,90,45,82,];
            public required string Source {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Source.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetRecentMeUrls : TlFunction<HelpRecentMeUrlsBase> {
            public static readonly byte[] Identifier = [20,241,192,61,];
            public required string Referer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Referer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpAcceptTermsOfService : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [154,247,114,238,];
            public required DataJSONBase Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetDeepLinkInfo : TlFunction<HelpDeepLinkInfoBase> {
            public static readonly byte[] Identifier = [95,199,237,63,];
            public required string Path {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Path.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetAppConfig : TlFunction<HelpAppConfigBase> {
            public static readonly byte[] Identifier = [84,248,227,97,];
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpSaveAppLog : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [72,247,2,111,];
            public required List<InputAppEventBase> Events {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Events.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetPassportConfig : TlFunction<HelpPassportConfigBase> {
            public static readonly byte[] Identifier = [8,173,97,198,];
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetUserInfo : TlFunction<HelpUserInfoBase> {
            public static readonly byte[] Identifier = [211,8,138,3,];
            public required InputUserBase UserId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(UserId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpHidePromoData : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [149,28,37,30,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetPeerColors : TlFunction<HelpPeerColorsBase> {
            public static readonly byte[] Identifier = [47,244,128,218,];
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetPeerProfileColors : TlFunction<HelpPeerColorsBase> {
            public static readonly byte[] Identifier = [253,169,207,171,];
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetConfig : TlFunction<ConfigBase> {
            public static readonly byte[] Identifier = [107,24,249,196,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetNearestDc : TlFunction<NearestDcBase> {
            public static readonly byte[] Identifier = [38,48,179,31,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetInviteText : TlFunction<HelpInviteTextBase> {
            public static readonly byte[] Identifier = [67,35,57,77,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetSupport : TlFunction<HelpSupportBase> {
            public static readonly byte[] Identifier = [205,8,223,156,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetCdnConfig : TlFunction<CdnConfigBase> {
            public static readonly byte[] Identifier = [66,147,2,82,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetTermsOfServiceUpdate : TlFunction<HelpTermsOfServiceUpdateBase> {
            public static readonly byte[] Identifier = [209,31,165,44,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetSupportName : TlFunction<HelpSupportNameBase> {
            public static readonly byte[] Identifier = [44,231,96,211,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetPromoData : TlFunction<HelpPromoDataBase> {
            public static readonly byte[] Identifier = [33,116,151,192,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class HelpGetPremiumPromo : TlFunction<HelpPremiumPromoBase> {
            public static readonly byte[] Identifier = [212,147,27,184,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Langpack {
        public sealed class LangpackGetStrings : TlFunction<TlList<LangPackStringBase>> {
            public static readonly byte[] Identifier = [3,56,234,239,];
            public required string LangPack {get;set;}
            public required string LangCode {get;set;}
            public required List<string> Keys {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangPack.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                bytes.AddRange(Keys.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class LangpackGetDifference : TlFunction<LangPackDifferenceBase> {
            public static readonly byte[] Identifier = [165,74,152,205,];
            public required string LangPack {get;set;}
            public required string LangCode {get;set;}
            public int FromVersion {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangPack.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                bytes.AddRange(FromVersion.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class LangpackGetLangPack : TlFunction<LangPackDifferenceBase> {
            public static readonly byte[] Identifier = [10,51,242,242,];
            public required string LangPack {get;set;}
            public required string LangCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangPack.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class LangpackGetLanguage : TlFunction<LangPackLanguageBase> {
            public static readonly byte[] Identifier = [2,101,89,106,];
            public required string LangPack {get;set;}
            public required string LangCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangPack.TlSerialize());
                bytes.AddRange(LangCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class LangpackGetLanguages : TlFunction<TlList<LangPackLanguageBase>> {
            public static readonly byte[] Identifier = [143,151,198,66,];
            public required string LangPack {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangPack.TlSerialize());
                return bytes.ToArray();
            }
        }
}
namespace Messages {
        public sealed class MessagesSendMessage : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [111,9,13,40,];
            public bool NoWebpage {get;set;}
            public bool Silent {get;set;}
            public bool Background {get;set;}
            public bool ClearDraft {get;set;}
            public bool Noforwards {get;set;}
            public bool UpdateStickersetsOrder {get;set;}
            public bool InvertMedia {get;set;}
            public required InputPeerBase Peer {get;set;}
            public InputReplyToBase? ReplyTo {get;set;}
            public required string Message {get;set;}
            public long RandomId {get;set;}
            public ReplyMarkupBase? ReplyMarkup {get;set;}
            public List<MessageEntityBase>? Entities {get;set;}
            public int? ScheduleDate {get;set;}
            public InputPeerBase? SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ReplyTo is not null ? 1 : 0) | (ReplyMarkup is not null ? 4 : 0) | (Entities is not null ? 8 : 0) | (ScheduleDate is not null ? 1024 : 0) | (SendAs is not null ? 8192 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(ReplyTo is not null) bytes.AddRange(ReplyTo.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                if(ReplyMarkup is not null) bytes.AddRange(ReplyMarkup.TlSerialize());
                if(Entities is not null) bytes.AddRange(Entities.TlSerialize());
                if(ScheduleDate is not null) bytes.AddRange(ScheduleDate.TlSerialize());
                if(SendAs is not null) bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendMedia : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [61,194,204,114,];
            public bool Silent {get;set;}
            public bool Background {get;set;}
            public bool ClearDraft {get;set;}
            public bool Noforwards {get;set;}
            public bool UpdateStickersetsOrder {get;set;}
            public bool InvertMedia {get;set;}
            public required InputPeerBase Peer {get;set;}
            public InputReplyToBase? ReplyTo {get;set;}
            public required InputMediaBase Media {get;set;}
            public required string Message {get;set;}
            public long RandomId {get;set;}
            public ReplyMarkupBase? ReplyMarkup {get;set;}
            public List<MessageEntityBase>? Entities {get;set;}
            public int? ScheduleDate {get;set;}
            public InputPeerBase? SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ReplyTo is not null ? 1 : 0) | (ReplyMarkup is not null ? 4 : 0) | (Entities is not null ? 8 : 0) | (ScheduleDate is not null ? 1024 : 0) | (SendAs is not null ? 8192 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(ReplyTo is not null) bytes.AddRange(ReplyTo.TlSerialize());
                bytes.AddRange(Media.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                if(ReplyMarkup is not null) bytes.AddRange(ReplyMarkup.TlSerialize());
                if(Entities is not null) bytes.AddRange(Entities.TlSerialize());
                if(ScheduleDate is not null) bytes.AddRange(ScheduleDate.TlSerialize());
                if(SendAs is not null) bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSearch : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [41,233,180,167,];
            public required InputPeerBase Peer {get;set;}
            public required string Q {get;set;}
            public InputPeerBase? FromId {get;set;}
            public InputPeerBase? SavedPeerId {get;set;}
            public int? TopMsgId {get;set;}
            public required MessagesFilterBase Filter {get;set;}
            public int MinDate {get;set;}
            public int MaxDate {get;set;}
            public int OffsetId {get;set;}
            public int AddOffset {get;set;}
            public int Limit {get;set;}
            public int MaxId {get;set;}
            public int MinId {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (FromId is not null ? 1 : 0) | (SavedPeerId is not null ? 4 : 0) | (TopMsgId is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Q.TlSerialize());
                if(FromId is not null) bytes.AddRange(FromId.TlSerialize());
                if(SavedPeerId is not null) bytes.AddRange(SavedPeerId.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                bytes.AddRange(Filter.TlSerialize());
                bytes.AddRange(MinDate.TlSerialize());
                bytes.AddRange(MaxDate.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(AddOffset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(MinId.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesForwardMessages : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [196,187,97,198,];
            public bool Silent {get;set;}
            public bool Background {get;set;}
            public bool WithMyScore {get;set;}
            public bool DropAuthor {get;set;}
            public bool DropMediaCaptions {get;set;}
            public bool Noforwards {get;set;}
            public required InputPeerBase FromPeer {get;set;}
            public required List<int> Id {get;set;}
            public required List<long> RandomId {get;set;}
            public required InputPeerBase ToPeer {get;set;}
            public int? TopMsgId {get;set;}
            public int? ScheduleDate {get;set;}
            public InputPeerBase? SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (TopMsgId is not null ? 512 : 0) | (ScheduleDate is not null ? 1024 : 0) | (SendAs is not null ? 8192 : 0) ).TlSerialize());
                bytes.AddRange(FromPeer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(ToPeer.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                if(ScheduleDate is not null) bytes.AddRange(ScheduleDate.TlSerialize());
                if(SendAs is not null) bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendInlineBotResult : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [186,104,188,247,];
            public bool Silent {get;set;}
            public bool Background {get;set;}
            public bool ClearDraft {get;set;}
            public bool HideVia {get;set;}
            public required InputPeerBase Peer {get;set;}
            public InputReplyToBase? ReplyTo {get;set;}
            public long RandomId {get;set;}
            public long QueryId {get;set;}
            public required string Id {get;set;}
            public int? ScheduleDate {get;set;}
            public InputPeerBase? SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ReplyTo is not null ? 1 : 0) | (ScheduleDate is not null ? 1024 : 0) | (SendAs is not null ? 8192 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(ReplyTo is not null) bytes.AddRange(ReplyTo.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(QueryId.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                if(ScheduleDate is not null) bytes.AddRange(ScheduleDate.TlSerialize());
                if(SendAs is not null) bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendMultiMedia : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [135,137,110,69,];
            public bool Silent {get;set;}
            public bool Background {get;set;}
            public bool ClearDraft {get;set;}
            public bool Noforwards {get;set;}
            public bool UpdateStickersetsOrder {get;set;}
            public bool InvertMedia {get;set;}
            public required InputPeerBase Peer {get;set;}
            public InputReplyToBase? ReplyTo {get;set;}
            public required List<InputSingleMediaBase> MultiMedia {get;set;}
            public int? ScheduleDate {get;set;}
            public InputPeerBase? SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ReplyTo is not null ? 1 : 0) | (ScheduleDate is not null ? 1024 : 0) | (SendAs is not null ? 8192 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(ReplyTo is not null) bytes.AddRange(ReplyTo.TlSerialize());
                bytes.AddRange(MultiMedia.TlSerialize());
                if(ScheduleDate is not null) bytes.AddRange(ScheduleDate.TlSerialize());
                if(SendAs is not null) bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesRequestWebView : TlFunction<WebViewResultBase> {
            public static readonly byte[] Identifier = [193,194,157,38,];
            public bool FromBotMenu {get;set;}
            public bool Silent {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required InputUserBase Bot {get;set;}
            public string? Url {get;set;}
            public string? StartParam {get;set;}
            public DataJSONBase? ThemeParams {get;set;}
            public required string Platform {get;set;}
            public InputReplyToBase? ReplyTo {get;set;}
            public InputPeerBase? SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Url is not null ? 2 : 0) | (StartParam is not null ? 8 : 0) | (ThemeParams is not null ? 4 : 0) | (ReplyTo is not null ? 1 : 0) | (SendAs is not null ? 8192 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Bot.TlSerialize());
                if(Url is not null) bytes.AddRange(Url.TlSerialize());
                if(StartParam is not null) bytes.AddRange(StartParam.TlSerialize());
                if(ThemeParams is not null) bytes.AddRange(ThemeParams.TlSerialize());
                bytes.AddRange(Platform.TlSerialize());
                if(ReplyTo is not null) bytes.AddRange(ReplyTo.TlSerialize());
                if(SendAs is not null) bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSearchGlobal : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [154,88,198,75,];
            public int? FolderId {get;set;}
            public required string Q {get;set;}
            public required MessagesFilterBase Filter {get;set;}
            public int MinDate {get;set;}
            public int MaxDate {get;set;}
            public int OffsetRate {get;set;}
            public required InputPeerBase OffsetPeer {get;set;}
            public int OffsetId {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (FolderId is not null ? 1 : 0) ).TlSerialize());
                if(FolderId is not null) bytes.AddRange(FolderId.TlSerialize());
                bytes.AddRange(Q.TlSerialize());
                bytes.AddRange(Filter.TlSerialize());
                bytes.AddRange(MinDate.TlSerialize());
                bytes.AddRange(MaxDate.TlSerialize());
                bytes.AddRange(OffsetRate.TlSerialize());
                bytes.AddRange(OffsetPeer.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesEditMessage : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [120,23,247,72,];
            public bool NoWebpage {get;set;}
            public bool InvertMedia {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public string? Message {get;set;}
            public InputMediaBase? Media {get;set;}
            public ReplyMarkupBase? ReplyMarkup {get;set;}
            public List<MessageEntityBase>? Entities {get;set;}
            public int? ScheduleDate {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Message is not null ? 2048 : 0) | (Media is not null ? 16384 : 0) | (ReplyMarkup is not null ? 4 : 0) | (Entities is not null ? 8 : 0) | (ScheduleDate is not null ? 32768 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                if(Message is not null) bytes.AddRange(Message.TlSerialize());
                if(Media is not null) bytes.AddRange(Media.TlSerialize());
                if(ReplyMarkup is not null) bytes.AddRange(ReplyMarkup.TlSerialize());
                if(Entities is not null) bytes.AddRange(Entities.TlSerialize());
                if(ScheduleDate is not null) bytes.AddRange(ScheduleDate.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetInlineBotResults : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [25,164,18,187,];
            public bool Gallery {get;set;}
            public bool Private {get;set;}
            public long QueryId {get;set;}
            public required List<InputBotInlineResultBase> Results {get;set;}
            public int CacheTime {get;set;}
            public string? NextOffset {get;set;}
            public InlineBotSwitchPMBase? SwitchPm {get;set;}
            public InlineBotWebViewBase? SwitchWebview {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (NextOffset is not null ? 4 : 0) | (SwitchPm is not null ? 8 : 0) | (SwitchWebview is not null ? 16 : 0) ).TlSerialize());
                bytes.AddRange(QueryId.TlSerialize());
                bytes.AddRange(Results.TlSerialize());
                bytes.AddRange(CacheTime.TlSerialize());
                if(NextOffset is not null) bytes.AddRange(NextOffset.TlSerialize());
                if(SwitchPm is not null) bytes.AddRange(SwitchPm.TlSerialize());
                if(SwitchWebview is not null) bytes.AddRange(SwitchWebview.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetReplies : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [12,211,221,34,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public int OffsetId {get;set;}
            public int OffsetDate {get;set;}
            public int AddOffset {get;set;}
            public int Limit {get;set;}
            public int MaxId {get;set;}
            public int MinId {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(OffsetDate.TlSerialize());
                bytes.AddRange(AddOffset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(MinId.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetDialogs : TlFunction<MessagesDialogsBase> {
            public static readonly byte[] Identifier = [79,203,244,160,];
            public bool ExcludePinned {get;set;}
            public int? FolderId {get;set;}
            public int OffsetDate {get;set;}
            public int OffsetId {get;set;}
            public required InputPeerBase OffsetPeer {get;set;}
            public int Limit {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (FolderId is not null ? 2 : 0) ).TlSerialize());
                if(FolderId is not null) bytes.AddRange(FolderId.TlSerialize());
                bytes.AddRange(OffsetDate.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(OffsetPeer.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetHistory : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [197,230,35,68,];
            public required InputPeerBase Peer {get;set;}
            public int OffsetId {get;set;}
            public int OffsetDate {get;set;}
            public int AddOffset {get;set;}
            public int Limit {get;set;}
            public int MaxId {get;set;}
            public int MinId {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(OffsetDate.TlSerialize());
                bytes.AddRange(AddOffset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(MinId.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesEditInlineBotMessage : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [186,125,85,131,];
            public bool NoWebpage {get;set;}
            public bool InvertMedia {get;set;}
            public required InputBotInlineMessageIDBase Id {get;set;}
            public string? Message {get;set;}
            public InputMediaBase? Media {get;set;}
            public ReplyMarkupBase? ReplyMarkup {get;set;}
            public List<MessageEntityBase>? Entities {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Message is not null ? 2048 : 0) | (Media is not null ? 16384 : 0) | (ReplyMarkup is not null ? 4 : 0) | (Entities is not null ? 8 : 0) ).TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                if(Message is not null) bytes.AddRange(Message.TlSerialize());
                if(Media is not null) bytes.AddRange(Media.TlSerialize());
                if(ReplyMarkup is not null) bytes.AddRange(ReplyMarkup.TlSerialize());
                if(Entities is not null) bytes.AddRange(Entities.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSaveDraft : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [6,184,243,127,];
            public bool NoWebpage {get;set;}
            public bool InvertMedia {get;set;}
            public InputReplyToBase? ReplyTo {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required string Message {get;set;}
            public List<MessageEntityBase>? Entities {get;set;}
            public InputMediaBase? Media {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ReplyTo is not null ? 16 : 0) | (Entities is not null ? 8 : 0) | (Media is not null ? 32 : 0) ).TlSerialize());
                if(ReplyTo is not null) bytes.AddRange(ReplyTo.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                if(Entities is not null) bytes.AddRange(Entities.TlSerialize());
                if(Media is not null) bytes.AddRange(Media.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetUnreadMentions : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [144,231,7,241,];
            public required InputPeerBase Peer {get;set;}
            public int? TopMsgId {get;set;}
            public int OffsetId {get;set;}
            public int AddOffset {get;set;}
            public int Limit {get;set;}
            public int MaxId {get;set;}
            public int MinId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (TopMsgId is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(AddOffset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(MinId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesEditExportedChatInvite : TlFunction<MessagesExportedChatInviteBase> {
            public static readonly byte[] Identifier = [117,47,202,189,];
            public bool Revoked {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required string Link {get;set;}
            public int? ExpireDate {get;set;}
            public int? UsageLimit {get;set;}
            public bool RequestNeeded {get;set;}
            public string? Title {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ExpireDate is not null ? 1 : 0) | (UsageLimit is not null ? 2 : 0) | (Title is not null ? 16 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Link.TlSerialize());
                if(ExpireDate is not null) bytes.AddRange(ExpireDate.TlSerialize());
                if(UsageLimit is not null) bytes.AddRange(UsageLimit.TlSerialize());
                if(Title is not null) bytes.AddRange(Title.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetChatInviteImporters : TlFunction<MessagesChatInviteImportersBase> {
            public static readonly byte[] Identifier = [78,221,4,223,];
            public bool Requested {get;set;}
            public required InputPeerBase Peer {get;set;}
            public string? Link {get;set;}
            public string? Q {get;set;}
            public int OffsetDate {get;set;}
            public required InputUserBase OffsetUser {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Link is not null ? 2 : 0) | (Q is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(Link is not null) bytes.AddRange(Link.TlSerialize());
                if(Q is not null) bytes.AddRange(Q.TlSerialize());
                bytes.AddRange(OffsetDate.TlSerialize());
                bytes.AddRange(OffsetUser.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetUnreadReactions : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [91,73,35,50,];
            public required InputPeerBase Peer {get;set;}
            public int? TopMsgId {get;set;}
            public int OffsetId {get;set;}
            public int AddOffset {get;set;}
            public int Limit {get;set;}
            public int MaxId {get;set;}
            public int MinId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (TopMsgId is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(AddOffset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(MinId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesRequestSimpleWebView : TlFunction<SimpleWebViewResultBase> {
            public static readonly byte[] Identifier = [10,80,70,26,];
            public bool FromSwitchWebview {get;set;}
            public bool FromSideMenu {get;set;}
            public required InputUserBase Bot {get;set;}
            public string? Url {get;set;}
            public string? StartParam {get;set;}
            public DataJSONBase? ThemeParams {get;set;}
            public required string Platform {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Url is not null ? 8 : 0) | (StartParam is not null ? 16 : 0) | (ThemeParams is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Bot.TlSerialize());
                if(Url is not null) bytes.AddRange(Url.TlSerialize());
                if(StartParam is not null) bytes.AddRange(StartParam.TlSerialize());
                if(ThemeParams is not null) bytes.AddRange(ThemeParams.TlSerialize());
                bytes.AddRange(Platform.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetSavedHistory : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [77,65,154,61,];
            public required InputPeerBase Peer {get;set;}
            public int OffsetId {get;set;}
            public int OffsetDate {get;set;}
            public int AddOffset {get;set;}
            public int Limit {get;set;}
            public int MaxId {get;set;}
            public int MinId {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(OffsetDate.TlSerialize());
                bytes.AddRange(AddOffset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(MinId.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeleteHistory : TlFunction<MessagesAffectedHistoryBase> {
            public static readonly byte[] Identifier = [42,146,143,176,];
            public bool JustClear {get;set;}
            public bool Revoke {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int MaxId {get;set;}
            public int? MinDate {get;set;}
            public int? MaxDate {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (MinDate is not null ? 4 : 0) | (MaxDate is not null ? 8 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                if(MinDate is not null) bytes.AddRange(MinDate.TlSerialize());
                if(MaxDate is not null) bytes.AddRange(MaxDate.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesExportChatInvite : TlFunction<ExportedChatInviteBase> {
            public static readonly byte[] Identifier = [213,229,44,160,];
            public bool LegacyRevokePermanent {get;set;}
            public bool RequestNeeded {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int? ExpireDate {get;set;}
            public int? UsageLimit {get;set;}
            public string? Title {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ExpireDate is not null ? 1 : 0) | (UsageLimit is not null ? 2 : 0) | (Title is not null ? 16 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(ExpireDate is not null) bytes.AddRange(ExpireDate.TlSerialize());
                if(UsageLimit is not null) bytes.AddRange(UsageLimit.TlSerialize());
                if(Title is not null) bytes.AddRange(Title.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetGameScore : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [192,236,248,142,];
            public bool EditMessage {get;set;}
            public bool Force {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public required InputUserBase UserId {get;set;}
            public int Score {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(Score.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetExportedChatInvites : TlFunction<MessagesExportedChatInvitesBase> {
            public static readonly byte[] Identifier = [246,163,181,162,];
            public bool Revoked {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required InputUserBase AdminId {get;set;}
            public int? OffsetDate {get;set;}
            public string? OffsetLink {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (OffsetDate is not null ? 4 : 0) | (OffsetLink is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(AdminId.TlSerialize());
                if(OffsetDate is not null) bytes.AddRange(OffsetDate.TlSerialize());
                if(OffsetLink is not null) bytes.AddRange(OffsetLink.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesProlongWebView : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [131,26,216,176,];
            public bool Silent {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required InputUserBase Bot {get;set;}
            public long QueryId {get;set;}
            public InputReplyToBase? ReplyTo {get;set;}
            public InputPeerBase? SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ReplyTo is not null ? 1 : 0) | (SendAs is not null ? 8192 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(QueryId.TlSerialize());
                if(ReplyTo is not null) bytes.AddRange(ReplyTo.TlSerialize());
                if(SendAs is not null) bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesRequestAppWebView : TlFunction<AppWebViewResultBase> {
            public static readonly byte[] Identifier = [60,59,90,140,];
            public bool WriteAllowed {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required InputBotAppBase App {get;set;}
            public string? StartParam {get;set;}
            public DataJSONBase? ThemeParams {get;set;}
            public required string Platform {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (StartParam is not null ? 2 : 0) | (ThemeParams is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(App.TlSerialize());
                if(StartParam is not null) bytes.AddRange(StartParam.TlSerialize());
                if(ThemeParams is not null) bytes.AddRange(ThemeParams.TlSerialize());
                bytes.AddRange(Platform.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetChatWallPaper : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [225,202,250,143,];
            public bool ForBoth {get;set;}
            public bool Revert {get;set;}
            public required InputPeerBase Peer {get;set;}
            public InputWallPaperBase? Wallpaper {get;set;}
            public WallPaperSettingsBase? Settings {get;set;}
            public int? Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Wallpaper is not null ? 1 : 0) | (Settings is not null ? 4 : 0) | (Id is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(Wallpaper is not null) bytes.AddRange(Wallpaper.TlSerialize());
                if(Settings is not null) bytes.AddRange(Settings.TlSerialize());
                if(Id is not null) bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetSavedDialogs : TlFunction<MessagesSavedDialogsBase> {
            public static readonly byte[] Identifier = [26,210,129,83,];
            public bool ExcludePinned {get;set;}
            public int OffsetDate {get;set;}
            public int OffsetId {get;set;}
            public required InputPeerBase OffsetPeer {get;set;}
            public int Limit {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(OffsetDate.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(OffsetPeer.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendEncryptedFile : TlFunction<MessagesSentEncryptedMessageBase> {
            public static readonly byte[] Identifier = [29,72,89,85,];
            public bool Silent {get;set;}
            public required InputEncryptedChatBase Peer {get;set;}
            public long RandomId {get;set;}
            public required byte[] Data {get;set;}
            public required InputEncryptedFileBase File {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(Data.TlSerialize());
                bytes.AddRange(File.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetInlineBotResults : TlFunction<MessagesBotResultsBase> {
            public static readonly byte[] Identifier = [157,153,78,81,];
            public required InputUserBase Bot {get;set;}
            public required InputPeerBase Peer {get;set;}
            public InputGeoPointBase? GeoPoint {get;set;}
            public required string Query {get;set;}
            public required string Offset {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (GeoPoint is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(GeoPoint is not null) bytes.AddRange(GeoPoint.TlSerialize());
                bytes.AddRange(Query.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetBotCallbackAnswer : TlFunction<MessagesBotCallbackAnswerBase> {
            public static readonly byte[] Identifier = [7,202,66,147,];
            public bool Game {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public byte[]? Data {get;set;}
            public InputCheckPasswordSRPBase? Password {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Data is not null ? 1 : 0) | (Password is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                if(Data is not null) bytes.AddRange(Data.TlSerialize());
                if(Password is not null) bytes.AddRange(Password.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetBotCallbackAnswer : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [10,19,143,213,];
            public bool Alert {get;set;}
            public long QueryId {get;set;}
            public string? Message {get;set;}
            public string? Url {get;set;}
            public int CacheTime {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Message is not null ? 1 : 0) | (Url is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(QueryId.TlSerialize());
                if(Message is not null) bytes.AddRange(Message.TlSerialize());
                if(Url is not null) bytes.AddRange(Url.TlSerialize());
                bytes.AddRange(CacheTime.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetInlineGameScore : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [100,159,173,21,];
            public bool EditMessage {get;set;}
            public bool Force {get;set;}
            public required InputBotInlineMessageIDBase Id {get;set;}
            public required InputUserBase UserId {get;set;}
            public int Score {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(Score.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesUpdatePinnedMessage : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [236,247,170,210,];
            public bool Silent {get;set;}
            public bool Unpin {get;set;}
            public bool PmOneside {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesAcceptUrlAuth : TlFunction<UrlAuthResultBase> {
            public static readonly byte[] Identifier = [37,113,44,177,];
            public bool WriteAllowed {get;set;}
            public InputPeerBase? Peer {get;set;}
            public int? MsgId {get;set;}
            public int? ButtonId {get;set;}
            public string? Url {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Peer is not null ? 2 : 0) | (MsgId is not null ? 2 : 0) | (ButtonId is not null ? 2 : 0) | (Url is not null ? 4 : 0) ).TlSerialize());
                if(Peer is not null) bytes.AddRange(Peer.TlSerialize());
                if(MsgId is not null) bytes.AddRange(MsgId.TlSerialize());
                if(ButtonId is not null) bytes.AddRange(ButtonId.TlSerialize());
                if(Url is not null) bytes.AddRange(Url.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetPollVotes : TlFunction<MessagesVotesListBase> {
            public static readonly byte[] Identifier = [14,56,110,184,];
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public byte[]? Option {get;set;}
            public string? Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Option is not null ? 1 : 0) | (Offset is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                if(Option is not null) bytes.AddRange(Option.TlSerialize());
                if(Offset is not null) bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetSearchResultsCalendar : TlFunction<MessagesSearchResultsCalendarBase> {
            public static readonly byte[] Identifier = [189,246,163,106,];
            public required InputPeerBase Peer {get;set;}
            public InputPeerBase? SavedPeerId {get;set;}
            public required MessagesFilterBase Filter {get;set;}
            public int OffsetId {get;set;}
            public int OffsetDate {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (SavedPeerId is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(SavedPeerId is not null) bytes.AddRange(SavedPeerId.TlSerialize());
                bytes.AddRange(Filter.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(OffsetDate.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetSearchResultsPositions : TlFunction<MessagesSearchResultsPositionsBase> {
            public static readonly byte[] Identifier = [16,47,127,156,];
            public required InputPeerBase Peer {get;set;}
            public InputPeerBase? SavedPeerId {get;set;}
            public required MessagesFilterBase Filter {get;set;}
            public int OffsetId {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (SavedPeerId is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(SavedPeerId is not null) bytes.AddRange(SavedPeerId.TlSerialize());
                bytes.AddRange(Filter.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendReaction : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [212,120,13,211,];
            public bool Big {get;set;}
            public bool AddToRecent {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public List<ReactionBase>? Reaction {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Reaction is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                if(Reaction is not null) bytes.AddRange(Reaction.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetMessageReactionsList : TlFunction<MessagesMessageReactionsListBase> {
            public static readonly byte[] Identifier = [72,63,27,70,];
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public ReactionBase? Reaction {get;set;}
            public string? Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Reaction is not null ? 1 : 0) | (Offset is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                if(Reaction is not null) bytes.AddRange(Reaction.TlSerialize());
                if(Offset is not null) bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendEncrypted : TlFunction<MessagesSentEncryptedMessageBase> {
            public static readonly byte[] Identifier = [21,122,250,68,];
            public bool Silent {get;set;}
            public required InputEncryptedChatBase Peer {get;set;}
            public long RandomId {get;set;}
            public required byte[] Data {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(Data.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetArchivedStickers : TlFunction<MessagesArchivedStickersBase> {
            public static readonly byte[] Identifier = [146,118,241,87,];
            public bool Masks {get;set;}
            public bool Emojis {get;set;}
            public long OffsetId {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetSearchCounters : TlFunction<TlList<Tel.MessagesSearchCounterNs.MessagesSearchCounter>> {
            public static readonly byte[] Identifier = [0,243,188,27,];
            public required InputPeerBase Peer {get;set;}
            public InputPeerBase? SavedPeerId {get;set;}
            public int? TopMsgId {get;set;}
            public required List<MessagesFilterBase> Filters {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (SavedPeerId is not null ? 4 : 0) | (TopMsgId is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(SavedPeerId is not null) bytes.AddRange(SavedPeerId.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                bytes.AddRange(Filters.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesRequestUrlAuth : TlFunction<UrlAuthResultBase> {
            public static readonly byte[] Identifier = [70,180,143,25,];
            public InputPeerBase? Peer {get;set;}
            public int? MsgId {get;set;}
            public int? ButtonId {get;set;}
            public string? Url {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Peer is not null ? 2 : 0) | (MsgId is not null ? 2 : 0) | (ButtonId is not null ? 2 : 0) | (Url is not null ? 4 : 0) ).TlSerialize());
                if(Peer is not null) bytes.AddRange(Peer.TlSerialize());
                if(MsgId is not null) bytes.AddRange(MsgId.TlSerialize());
                if(ButtonId is not null) bytes.AddRange(ButtonId.TlSerialize());
                if(Url is not null) bytes.AddRange(Url.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesToggleStickerSets : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [234,47,5,181,];
            public bool Uninstall {get;set;}
            public bool Archive {get;set;}
            public bool Unarchive {get;set;}
            public required List<InputStickerSetBase> Stickersets {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Stickersets.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesTranslateText : TlFunction<MessagesTranslatedTextBase> {
            public static readonly byte[] Identifier = [48,48,24,99,];
            public InputPeerBase? Peer {get;set;}
            public List<int>? Id {get;set;}
            public List<TextWithEntitiesBase>? Text {get;set;}
            public required string ToLang {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Peer is not null ? 1 : 0) | (Id is not null ? 1 : 0) | (Text is not null ? 2 : 0) ).TlSerialize());
                if(Peer is not null) bytes.AddRange(Peer.TlSerialize());
                if(Id is not null) bytes.AddRange(Id.TlSerialize());
                if(Text is not null) bytes.AddRange(Text.TlSerialize());
                bytes.AddRange(ToLang.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeleteSavedHistory : TlFunction<MessagesAffectedHistoryBase> {
            public static readonly byte[] Identifier = [43,16,152,110,];
            public required InputPeerBase Peer {get;set;}
            public int MaxId {get;set;}
            public int? MinDate {get;set;}
            public int? MaxDate {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (MinDate is not null ? 4 : 0) | (MaxDate is not null ? 8 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                if(MinDate is not null) bytes.AddRange(MinDate.TlSerialize());
                if(MaxDate is not null) bytes.AddRange(MaxDate.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetTyping : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [226,62,148,88,];
            public required InputPeerBase Peer {get;set;}
            public int? TopMsgId {get;set;}
            public required SendMessageActionBase Action {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (TopMsgId is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                bytes.AddRange(Action.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReport : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [78,171,83,137,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public required ReportReasonBase Reason {get;set;}
            public required string Message {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(Reason.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeleteChatUser : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [171,92,24,162,];
            public bool RevokeHistory {get;set;}
            public long ChatId {get;set;}
            public required InputUserBase UserId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(ChatId.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesCreateChat : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [24,168,52,0,];
            public required List<InputUserBase> Users {get;set;}
            public required string Title {get;set;}
            public int? TtlPeriod {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (TtlPeriod is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Users.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                if(TtlPeriod is not null) bytes.AddRange(TtlPeriod.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesStartBot : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [120,115,223,230,];
            public required InputUserBase Bot {get;set;}
            public required InputPeerBase Peer {get;set;}
            public long RandomId {get;set;}
            public required string StartParam {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(StartParam.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReorderStickerSets : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [57,119,51,120,];
            public bool Masks {get;set;}
            public bool Emojis {get;set;}
            public required List<long> Order {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Order.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSaveRecentSticker : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [248,24,39,57,];
            public bool Attached {get;set;}
            public required InputDocumentBase Id {get;set;}
            public bool Unsave {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReorderPinnedDialogs : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [55,223,26,59,];
            public bool Force {get;set;}
            public int FolderId {get;set;}
            public required List<InputDialogPeerBase> Order {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(FolderId.TlSerialize());
                bytes.AddRange(Order.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetBotShippingResults : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [250,114,246,229,];
            public long QueryId {get;set;}
            public string? Error {get;set;}
            public List<ShippingOptionBase>? ShippingOptions {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Error is not null ? 1 : 0) | (ShippingOptions is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(QueryId.TlSerialize());
                if(Error is not null) bytes.AddRange(Error.TlSerialize());
                if(ShippingOptions is not null) bytes.AddRange(ShippingOptions.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetBotPrecheckoutResults : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [149,221,194,9,];
            public bool Success {get;set;}
            public long QueryId {get;set;}
            public string? Error {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Error is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(QueryId.TlSerialize());
                if(Error is not null) bytes.AddRange(Error.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSearchStickerSets : TlFunction<MessagesFoundStickerSetsBase> {
            public static readonly byte[] Identifier = [138,91,112,53,];
            public bool ExcludeFeatured {get;set;}
            public required string Q {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Q.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesUploadImportedMedia : TlFunction<MessageMediaBase> {
            public static readonly byte[] Identifier = [146,32,134,42,];
            public required InputPeerBase Peer {get;set;}
            public long ImportId {get;set;}
            public required string FileName {get;set;}
            public required InputMediaBase Media {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(ImportId.TlSerialize());
                bytes.AddRange(FileName.TlSerialize());
                bytes.AddRange(Media.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesHideChatJoinRequest : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [21,232,231,127,];
            public bool Approved {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required InputUserBase UserId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesHideAllChatJoinRequests : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [234,244,133,224,];
            public bool Approved {get;set;}
            public required InputPeerBase Peer {get;set;}
            public string? Link {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Link is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(Link is not null) bytes.AddRange(Link.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesToggleBotInAttachMenu : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [105,157,245,105,];
            public bool WriteAllowed {get;set;}
            public required InputUserBase Bot {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Bot.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendWebViewData : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [200,66,2,220,];
            public required InputUserBase Bot {get;set;}
            public long RandomId {get;set;}
            public required string ButtonText {get;set;}
            public required string Data {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(ButtonText.TlSerialize());
                bytes.AddRange(Data.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesRateTranscribedAudio : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [47,7,29,127,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public long TranscriptionId {get;set;}
            public bool Good {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                bytes.AddRange(TranscriptionId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendBotRequestedPeer : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [96,208,178,145,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public int ButtonId {get;set;}
            public required List<InputPeerBase> RequestedPeers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                bytes.AddRange(ButtonId.TlSerialize());
                bytes.AddRange(RequestedPeers.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSearchEmojiStickerSets : TlFunction<MessagesFoundStickerSetsBase> {
            public static readonly byte[] Identifier = [76,73,180,146,];
            public bool ExcludeFeatured {get;set;}
            public required string Q {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Q.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeleteMessages : TlFunction<MessagesAffectedMessagesBase> {
            public static readonly byte[] Identifier = [210,149,142,229,];
            public bool Revoke {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesAddChatUser : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [227,83,71,242,];
            public long ChatId {get;set;}
            public required InputUserBase UserId {get;set;}
            public int FwdLimit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ChatId.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(FwdLimit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesRequestEncryption : TlFunction<EncryptedChatBase> {
            public static readonly byte[] Identifier = [67,175,77,246,];
            public required InputUserBase UserId {get;set;}
            public int RandomId {get;set;}
            public required byte[] GA {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(GA.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesAcceptEncryption : TlFunction<EncryptedChatBase> {
            public static readonly byte[] Identifier = [21,4,188,61,];
            public required InputEncryptedChatBase Peer {get;set;}
            public required byte[] GB {get;set;}
            public long KeyFingerprint {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(GB.TlSerialize());
                bytes.AddRange(KeyFingerprint.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDiscardEncryption : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [160,174,147,243,];
            public bool DeleteHistory {get;set;}
            public int ChatId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(ChatId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendEncryptedService : TlFunction<MessagesSentEncryptedMessageBase> {
            public static readonly byte[] Identifier = [164,57,212,50,];
            public required InputEncryptedChatBase Peer {get;set;}
            public long RandomId {get;set;}
            public required byte[] Data {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(Data.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetWebPagePreview : TlFunction<MessageMediaBase> {
            public static readonly byte[] Identifier = [204,176,104,139,];
            public required string Message {get;set;}
            public List<MessageEntityBase>? Entities {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Entities is not null ? 8 : 0) ).TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                if(Entities is not null) bytes.AddRange(Entities.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetMessagesViews : TlFunction<MessagesMessageViewsBase> {
            public static readonly byte[] Identifier = [225,211,132,87,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public bool Increment {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesEditChatAdmin : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [194,209,91,168,];
            public long ChatId {get;set;}
            public required InputUserBase UserId {get;set;}
            public bool IsAdmin {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ChatId.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetDocumentByHash : TlFunction<DocumentBase> {
            public static readonly byte[] Identifier = [31,6,242,177,];
            public required byte[] Sha256 {get;set;}
            public long Size {get;set;}
            public required string MimeType {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Sha256.TlSerialize());
                bytes.AddRange(Size.TlSerialize());
                bytes.AddRange(MimeType.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetRecentStickers : TlFunction<MessagesRecentStickersBase> {
            public static readonly byte[] Identifier = [59,64,169,157,];
            public bool Attached {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetGameHighScores : TlFunction<MessagesHighScoresBase> {
            public static readonly byte[] Identifier = [157,100,34,232,];
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public required InputUserBase UserId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetCommonChats : TlFunction<MessagesChatsBase> {
            public static readonly byte[] Identifier = [4,161,12,228,];
            public required InputUserBase UserId {get;set;}
            public long MaxId {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesToggleDialogPin : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [87,226,49,167,];
            public bool Pinned {get;set;}
            public required InputDialogPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendScreenshotNotification : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [23,88,64,161,];
            public required InputPeerBase Peer {get;set;}
            public required InputReplyToBase ReplyTo {get;set;}
            public long RandomId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(ReplyTo.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReadMentions : TlFunction<MessagesAffectedHistoryBase> {
            public static readonly byte[] Identifier = [77,191,229,54,];
            public required InputPeerBase Peer {get;set;}
            public int? TopMsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (TopMsgId is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetRecentLocations : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [224,64,42,112,];
            public required InputPeerBase Peer {get;set;}
            public int Limit {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesMarkDialogUnread : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [143,217,134,194,];
            public bool Unread {get;set;}
            public required InputDialogPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendVote : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [132,97,234,16,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public required List<byte[]> Options {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                bytes.AddRange(Options.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesUpdateDialogFilter : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [74,160,212,26,];
            public int Id {get;set;}
            public DialogFilterBase? Filter {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Filter is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                if(Filter is not null) bytes.AddRange(Filter.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetOldFeaturedStickers : TlFunction<MessagesFeaturedStickersBase> {
            public static readonly byte[] Identifier = [161,148,208,126,];
            public int Offset {get;set;}
            public int Limit {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReadDiscussion : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [244,169,49,247,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public int ReadMaxId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                bytes.AddRange(ReadMaxId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesUnpinAllMessages : TlFunction<MessagesAffectedHistoryBase> {
            public static readonly byte[] Identifier = [168,185,34,238,];
            public required InputPeerBase Peer {get;set;}
            public int? TopMsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (TopMsgId is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesInitHistoryImport : TlFunction<MessagesHistoryImportBase> {
            public static readonly byte[] Identifier = [59,12,9,52,];
            public required InputPeerBase Peer {get;set;}
            public required InputFileBase File {get;set;}
            public int MediaCount {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(File.TlSerialize());
                bytes.AddRange(MediaCount.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReadReactions : TlFunction<MessagesAffectedHistoryBase> {
            public static readonly byte[] Identifier = [142,127,170,84,];
            public required InputPeerBase Peer {get;set;}
            public int? TopMsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (TopMsgId is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(TopMsgId is not null) bytes.AddRange(TopMsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSearchSentMedia : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [160,49,126,16,];
            public required string Q {get;set;}
            public required MessagesFilterBase Filter {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Q.TlSerialize());
                bytes.AddRange(Filter.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReportReaction : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [118,192,100,63,];
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public required InputPeerBase ReactionPeer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(ReactionPeer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesTogglePeerTranslations : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [121,181,124,228,];
            public bool Disabled {get;set;}
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesToggleSavedDialogPin : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [222,187,129,172,];
            public bool Pinned {get;set;}
            public required InputDialogPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReorderPinnedSavedDialogs : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [135,101,113,139,];
            public bool Force {get;set;}
            public required List<InputDialogPeerBase> Order {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Order.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReadHistory : TlFunction<MessagesAffectedMessagesBase> {
            public static readonly byte[] Identifier = [58,109,48,14,];
            public required InputPeerBase Peer {get;set;}
            public int MaxId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesEditChatTitle : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [253,63,120,115,];
            public long ChatId {get;set;}
            public required string Title {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ChatId.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesEditChatPhoto : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [116,214,221,53,];
            public long ChatId {get;set;}
            public required InputChatPhotoBase Photo {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ChatId.TlSerialize());
                bytes.AddRange(Photo.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetDhConfig : TlFunction<MessagesDhConfigBase> {
            public static readonly byte[] Identifier = [80,137,207,38,];
            public int Version {get;set;}
            public int RandomLength {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Version.TlSerialize());
                bytes.AddRange(RandomLength.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetEncryptedTyping : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [237,81,20,121,];
            public required InputEncryptedChatBase Peer {get;set;}
            public bool Typing {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReadEncryptedHistory : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [10,105,75,127,];
            public required InputEncryptedChatBase Peer {get;set;}
            public int MaxDate {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MaxDate.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetStickers : TlFunction<MessagesStickersBase> {
            public static readonly byte[] Identifier = [161,211,165,213,];
            public required string Emoticon {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Emoticon.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetStickerSet : TlFunction<MessagesStickerSetBase> {
            public static readonly byte[] Identifier = [116,236,160,200,];
            public required InputStickerSetBase Stickerset {get;set;}
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Stickerset.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesInstallStickerSet : TlFunction<MessagesStickerSetInstallResultBase> {
            public static readonly byte[] Identifier = [96,228,143,199,];
            public required InputStickerSetBase Stickerset {get;set;}
            public bool Archived {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Stickerset.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSaveGif : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [203,48,122,50,];
            public required InputDocumentBase Id {get;set;}
            public bool Unsave {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetMessageEditData : TlFunction<MessagesMessageEditDataBase> {
            public static readonly byte[] Identifier = [54,141,166,253,];
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesClearRecentStickers : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [45,96,153,137,];
            public bool Attached {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetInlineGameHighScores : TlFunction<MessagesHighScoresBase> {
            public static readonly byte[] Identifier = [27,94,99,15,];
            public required InputBotInlineMessageIDBase Id {get;set;}
            public required InputUserBase UserId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetWebPage : TlFunction<MessagesWebPageBase> {
            public static readonly byte[] Identifier = [163,146,150,141,];
            public required string Url {get;set;}
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Url.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesUploadMedia : TlFunction<MessageMediaBase> {
            public static readonly byte[] Identifier = [177,194,155,81,];
            public required InputPeerBase Peer {get;set;}
            public required InputMediaBase Media {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Media.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesFaveSticker : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [91,197,255,185,];
            public required InputDocumentBase Id {get;set;}
            public bool Unfave {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesUploadEncryptedFile : TlFunction<EncryptedFileBase> {
            public static readonly byte[] Identifier = [151,196,87,80,];
            public required InputEncryptedChatBase Peer {get;set;}
            public required InputEncryptedFileBase File {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(File.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetPollResults : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [59,100,187,115,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesEditChatAbout : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [151,7,246,222,];
            public required InputPeerBase Peer {get;set;}
            public required string About {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(About.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesEditChatDefaultBannedRights : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [65,107,134,165,];
            public required InputPeerBase Peer {get;set;}
            public required ChatBannedRightsBase BannedRights {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(BannedRights.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetEmojiKeywordsDifference : TlFunction<EmojiKeywordsDifferenceBase> {
            public static readonly byte[] Identifier = [175,182,8,21,];
            public required string LangCode {get;set;}
            public int FromVersion {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangCode.TlSerialize());
                bytes.AddRange(FromVersion.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetScheduledHistory : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [11,118,22,245,];
            public required InputPeerBase Peer {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetScheduledMessages : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [100,4,187,189,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendScheduledMessages : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [10,133,56,189,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeleteScheduledMessages : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [22,43,174,89,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetDiscussionMessage : TlFunction<MessagesDiscussionMessageBase> {
            public static readonly byte[] Identifier = [253,114,105,68,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeletePhoneCallHistory : TlFunction<MessagesAffectedFoundMessagesBase> {
            public static readonly byte[] Identifier = [9,228,203,249,];
            public bool Revoke {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesStartHistoryImport : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [68,243,61,180,];
            public required InputPeerBase Peer {get;set;}
            public long ImportId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(ImportId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetExportedChatInvite : TlFunction<MessagesExportedChatInviteBase> {
            public static readonly byte[] Identifier = [92,111,116,115,];
            public required InputPeerBase Peer {get;set;}
            public required string Link {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Link.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeleteRevokedExportedChatInvites : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [213,123,152,86,];
            public required InputPeerBase Peer {get;set;}
            public required InputUserBase AdminId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(AdminId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeleteExportedChatInvite : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [43,164,100,212,];
            public required InputPeerBase Peer {get;set;}
            public required string Link {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Link.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetHistoryTTL : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [228,95,14,184,];
            public required InputPeerBase Peer {get;set;}
            public int Period {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Period.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetChatTheme : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [63,225,59,230,];
            public required InputPeerBase Peer {get;set;}
            public required string Emoticon {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Emoticon.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetMessageReadParticipants : TlFunction<TlList<ReadParticipantDateBase>> {
            public static readonly byte[] Identifier = [79,196,193,49,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesToggleNoForwards : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [162,175,30,177,];
            public required InputPeerBase Peer {get;set;}
            public bool Enabled {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSaveDefaultSendAs : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [150,223,253,204,];
            public required InputPeerBase Peer {get;set;}
            public required InputPeerBase SendAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(SendAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetMessagesReactions : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [230,144,186,139,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetChatAvailableReactions : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [113,103,177,254,];
            public required InputPeerBase Peer {get;set;}
            public required ChatReactionsBase AvailableReactions {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(AvailableReactions.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSendWebViewResultMessage : TlFunction<WebViewMessageSentBase> {
            public static readonly byte[] Identifier = [245,20,67,10,];
            public required string BotQueryId {get;set;}
            public required InputBotInlineResultBase Result {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(BotQueryId.TlSerialize());
                bytes.AddRange(Result.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesTranscribeAudio : TlFunction<MessagesTranscribedAudioBase> {
            public static readonly byte[] Identifier = [73,154,158,38,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetTopReactions : TlFunction<MessagesReactionsBase> {
            public static readonly byte[] Identifier = [186,37,129,187,];
            public int Limit {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetRecentReactions : TlFunction<MessagesReactionsBase> {
            public static readonly byte[] Identifier = [178,29,70,57,];
            public int Limit {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Limit.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetExtendedMedia : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [20,8,248,132,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSearchCustomEmoji : TlFunction<EmojiListBase> {
            public static readonly byte[] Identifier = [215,192,17,44,];
            public required string Emoticon {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Emoticon.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetBotApp : TlFunction<MessagesBotAppBase> {
            public static readonly byte[] Identifier = [195,197,253,52,];
            public required InputBotAppBase App {get;set;}
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(App.TlSerialize());
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetMessages : TlFunction<MessagesMessagesBase> {
            public static readonly byte[] Identifier = [6,101,198,99,];
            public required List<InputMessageBase> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReceivedMessages : TlFunction<TlList<ReceivedNotifyMessageBase>> {
            public static readonly byte[] Identifier = [192,84,169,5,];
            public int MaxId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(MaxId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReportSpam : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [219,146,21,207,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetPeerSettings : TlFunction<MessagesPeerSettingsBase> {
            public static readonly byte[] Identifier = [162,166,217,239,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetChats : TlFunction<MessagesChatsBase> {
            public static readonly byte[] Identifier = [143,82,233,73,];
            public required List<long> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetFullChat : TlFunction<MessagesChatFullBase> {
            public static readonly byte[] Identifier = [52,11,176,174,];
            public long ChatId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ChatId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReceivedQueue : TlFunction<TlList<TlLong>> {
            public static readonly byte[] Identifier = [102,187,165,85,];
            public int MaxQts {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(MaxQts.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReportEncryptedSpam : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [15,140,12,75,];
            public required InputEncryptedChatBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReadMessageContents : TlFunction<MessagesAffectedMessagesBase> {
            public static readonly byte[] Identifier = [119,63,167,54,];
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetAllStickers : TlFunction<MessagesAllStickersBase> {
            public static readonly byte[] Identifier = [168,161,160,184,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesCheckChatInvite : TlFunction<ChatInviteBase> {
            public static readonly byte[] Identifier = [187,177,173,62,];
            public required string Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesImportChatInvite : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [28,5,80,108,];
            public required string Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesUninstallStickerSet : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [222,85,110,249,];
            public required InputStickerSetBase Stickerset {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Stickerset.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesMigrateChat : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [25,83,135,162,];
            public long ChatId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ChatId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetSavedGifs : TlFunction<MessagesSavedGifsBase> {
            public static readonly byte[] Identifier = [53,150,240,92,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetPeerDialogs : TlFunction<MessagesPeerDialogsBase> {
            public static readonly byte[] Identifier = [253,188,112,228,];
            public required List<InputDialogPeerBase> Peers {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peers.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetFeaturedStickers : TlFunction<MessagesFeaturedStickersBase> {
            public static readonly byte[] Identifier = [20,11,120,100,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesReadFeaturedStickers : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [38,129,17,91,];
            public required List<long> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetMaskStickers : TlFunction<MessagesAllStickersBase> {
            public static readonly byte[] Identifier = [184,130,15,100,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetAttachedStickers : TlFunction<TlList<StickerSetCoveredBase>> {
            public static readonly byte[] Identifier = [204,103,91,204,];
            public required InputStickeredMediaBase Media {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Media.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetPinnedDialogs : TlFunction<MessagesPeerDialogsBase> {
            public static readonly byte[] Identifier = [242,77,185,214,];
            public int FolderId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(FolderId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetFavedStickers : TlFunction<MessagesFavedStickersBase> {
            public static readonly byte[] Identifier = [169,170,241,4,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetOnlines : TlFunction<ChatOnlinesBase> {
            public static readonly byte[] Identifier = [80,224,43,110,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetEmojiKeywords : TlFunction<EmojiKeywordsDifferenceBase> {
            public static readonly byte[] Identifier = [98,224,160,53,];
            public required string LangCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetEmojiKeywordsLanguages : TlFunction<TlList<EmojiLanguageBase>> {
            public static readonly byte[] Identifier = [178,99,153,78,];
            public required List<string> LangCodes {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangCodes.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetEmojiURL : TlFunction<EmojiURLBase> {
            public static readonly byte[] Identifier = [38,12,177,213,];
            public required string LangCode {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(LangCode.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesHidePeerSettingsBar : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [56,177,172,79,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesUpdateDialogFiltersOrder : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [228,193,99,197,];
            public required List<int> Order {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Order.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesDeleteChat : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [80,238,208,91,];
            public long ChatId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ChatId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesCheckHistoryImport : TlFunction<MessagesHistoryImportParsedBase> {
            public static readonly byte[] Identifier = [243,25,254,67,];
            public required string ImportHead {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ImportHead.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetAdminsWithInvites : TlFunction<MessagesChatAdminsWithInvitesBase> {
            public static readonly byte[] Identifier = [239,230,32,57,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesCheckHistoryImportPeer : TlFunction<MessagesCheckedHistoryImportPeerBase> {
            public static readonly byte[] Identifier = [3,15,198,93,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetAvailableReactions : TlFunction<MessagesAvailableReactionsBase> {
            public static readonly byte[] Identifier = [172,160,222,24,];
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetDefaultReaction : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [22,160,71,79,];
            public required ReactionBase Reaction {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Reaction.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetAttachMenuBots : TlFunction<AttachMenuBotsBase> {
            public static readonly byte[] Identifier = [203,194,252,22,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetAttachMenuBot : TlFunction<AttachMenuBotsBotBase> {
            public static readonly byte[] Identifier = [146,97,33,119,];
            public required InputUserBase Bot {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Bot.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetCustomEmojiDocuments : TlFunction<TlList<DocumentBase>> {
            public static readonly byte[] Identifier = [84,15,171,217,];
            public required List<long> DocumentId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(DocumentId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetEmojiStickers : TlFunction<MessagesAllStickersBase> {
            public static readonly byte[] Identifier = [143,161,252,251,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetFeaturedEmojiStickers : TlFunction<MessagesFeaturedStickersBase> {
            public static readonly byte[] Identifier = [54,103,207,14,];
            public long Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesSetDefaultHistoryTTL : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [69,20,181,158,];
            public int Period {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Period.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetEmojiGroups : TlFunction<MessagesEmojiGroupsBase> {
            public static readonly byte[] Identifier = [91,206,136,116,];
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetEmojiStatusGroups : TlFunction<MessagesEmojiGroupsBase> {
            public static readonly byte[] Identifier = [205,86,205,46,];
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetEmojiProfilePhotoGroups : TlFunction<MessagesEmojiGroupsBase> {
            public static readonly byte[] Identifier = [243,72,165,33,];
            public int Hash {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Hash.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetAllDrafts : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [101,141,63,106,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetSplitRanges : TlFunction<TlList<MessageRangeBase>> {
            public static readonly byte[] Identifier = [8,126,255,28,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetDialogUnreadMarks : TlFunction<TlList<DialogPeerBase>> {
            public static readonly byte[] Identifier = [34,78,226,34,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class MessagesClearAllDrafts : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [156,238,88,126,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetDialogFilters : TlFunction<TlList<DialogFilterBase>> {
            public static readonly byte[] Identifier = [109,217,158,241,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetSuggestedDialogFilters : TlFunction<TlList<DialogFilterSuggestedBase>> {
            public static readonly byte[] Identifier = [44,212,156,162,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class MessagesClearRecentReactions : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [180,239,254,157,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetDefaultHistoryTTL : TlFunction<DefaultHistoryTTLBase> {
            public static readonly byte[] Identifier = [136,113,139,101,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class MessagesGetPinnedSavedDialogs : TlFunction<MessagesSavedDialogsBase> {
            public static readonly byte[] Identifier = [224,148,61,214,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Payments {
        public sealed class PaymentsSendPaymentForm : TlFunction<PaymentsPaymentResultBase> {
            public static readonly byte[] Identifier = [47,82,3,45,];
            public long FormId {get;set;}
            public required InputInvoiceBase Invoice {get;set;}
            public string? RequestedInfoId {get;set;}
            public string? ShippingOptionId {get;set;}
            public required InputPaymentCredentialsBase Credentials {get;set;}
            public long? TipAmount {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (RequestedInfoId is not null ? 1 : 0) | (ShippingOptionId is not null ? 2 : 0) | (TipAmount is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(FormId.TlSerialize());
                bytes.AddRange(Invoice.TlSerialize());
                if(RequestedInfoId is not null) bytes.AddRange(RequestedInfoId.TlSerialize());
                if(ShippingOptionId is not null) bytes.AddRange(ShippingOptionId.TlSerialize());
                bytes.AddRange(Credentials.TlSerialize());
                if(TipAmount is not null) bytes.AddRange(TipAmount.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsValidateRequestedInfo : TlFunction<PaymentsValidatedRequestedInfoBase> {
            public static readonly byte[] Identifier = [43,241,200,182,];
            public bool Save {get;set;}
            public required InputInvoiceBase Invoice {get;set;}
            public required PaymentRequestedInfoBase Info {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Invoice.TlSerialize());
                bytes.AddRange(Info.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsGetPaymentForm : TlFunction<PaymentsPaymentFormBase> {
            public static readonly byte[] Identifier = [187,141,20,55,];
            public required InputInvoiceBase Invoice {get;set;}
            public DataJSONBase? ThemeParams {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (ThemeParams is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Invoice.TlSerialize());
                if(ThemeParams is not null) bytes.AddRange(ThemeParams.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsClearSavedInfo : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [193,112,61,216,];
            public bool Credentials {get;set;}
            public bool Info {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsLaunchPrepaidGiveaway : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [32,143,245,95,];
            public required InputPeerBase Peer {get;set;}
            public long GiveawayId {get;set;}
            public required InputStorePaymentPurposeBase Purpose {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(GiveawayId.TlSerialize());
                bytes.AddRange(Purpose.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsGetPaymentReceipt : TlFunction<PaymentsPaymentReceiptBase> {
            public static readonly byte[] Identifier = [204,209,120,36,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsAssignAppStoreTransaction : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [125,116,237,128,];
            public required byte[] Receipt {get;set;}
            public required InputStorePaymentPurposeBase Purpose {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Receipt.TlSerialize());
                bytes.AddRange(Purpose.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsAssignPlayMarketTransaction : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [211,80,253,223,];
            public required DataJSONBase Receipt {get;set;}
            public required InputStorePaymentPurposeBase Purpose {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Receipt.TlSerialize());
                bytes.AddRange(Purpose.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsGetPremiumGiftCodeOptions : TlFunction<TlList<PremiumGiftCodeOptionBase>> {
            public static readonly byte[] Identifier = [84,186,87,39,];
            public InputPeerBase? BoostPeer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (BoostPeer is not null ? 1 : 0) ).TlSerialize());
                if(BoostPeer is not null) bytes.AddRange(BoostPeer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsGetGiveawayInfo : TlFunction<PaymentsGiveawayInfoBase> {
            public static readonly byte[] Identifier = [37,148,35,244,];
            public required InputPeerBase Peer {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsGetBankCardData : TlFunction<PaymentsBankCardDataBase> {
            public static readonly byte[] Identifier = [121,215,121,46,];
            public required string Number {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Number.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsExportInvoice : TlFunction<PaymentsExportedInvoiceBase> {
            public static readonly byte[] Identifier = [101,176,145,15,];
            public required InputMediaBase InvoiceMedia {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(InvoiceMedia.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsCanPurchasePremium : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [182,158,193,159,];
            public required InputStorePaymentPurposeBase Purpose {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Purpose.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsCheckGiftCode : TlFunction<PaymentsCheckedGiftCodeBase> {
            public static readonly byte[] Identifier = [193,180,81,142,];
            public required string Slug {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Slug.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsApplyGiftCode : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [84,104,226,246,];
            public required string Slug {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Slug.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PaymentsGetSavedInfo : TlFunction<PaymentsSavedInfoBase> {
            public static readonly byte[] Identifier = [75,130,125,34,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Phone {
        public sealed class PhoneEditGroupCallParticipant : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [191,58,39,165,];
            public required InputGroupCallBase Call {get;set;}
            public required InputPeerBase Participant {get;set;}
            public bool Muted {get;set;}
            public int? Volume {get;set;}
            public bool RaiseHand {get;set;}
            public bool VideoStopped {get;set;}
            public bool VideoPaused {get;set;}
            public bool PresentationPaused {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Volume is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(Participant.TlSerialize());
                if(Volume is not null) bytes.AddRange(Volume.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneJoinGroupCall : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [123,255,50,177,];
            public bool Muted {get;set;}
            public bool VideoStopped {get;set;}
            public required InputGroupCallBase Call {get;set;}
            public required InputPeerBase JoinAs {get;set;}
            public string? InviteHash {get;set;}
            public required DataJSONBase Params {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (InviteHash is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(JoinAs.TlSerialize());
                if(InviteHash is not null) bytes.AddRange(InviteHash.TlSerialize());
                bytes.AddRange(Params.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneRequestCall : TlFunction<PhonePhoneCallBase> {
            public static readonly byte[] Identifier = [237,150,255,66,];
            public bool Video {get;set;}
            public required InputUserBase UserId {get;set;}
            public int RandomId {get;set;}
            public required byte[] GAHash {get;set;}
            public required PhoneCallProtocolBase Protocol {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                bytes.AddRange(GAHash.TlSerialize());
                bytes.AddRange(Protocol.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneDiscardCall : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [192,193,203,178,];
            public bool Video {get;set;}
            public required InputPhoneCallBase Peer {get;set;}
            public int Duration {get;set;}
            public required PhoneCallDiscardReasonBase Reason {get;set;}
            public long ConnectionId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Duration.TlSerialize());
                bytes.AddRange(Reason.TlSerialize());
                bytes.AddRange(ConnectionId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneCreateGroupCall : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [216,198,205,72,];
            public bool RtmpStream {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int RandomId {get;set;}
            public string? Title {get;set;}
            public int? ScheduleDate {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Title is not null ? 1 : 0) | (ScheduleDate is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                if(Title is not null) bytes.AddRange(Title.TlSerialize());
                if(ScheduleDate is not null) bytes.AddRange(ScheduleDate.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneToggleGroupCallRecord : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [8,199,40,241,];
            public bool Start {get;set;}
            public bool Video {get;set;}
            public required InputGroupCallBase Call {get;set;}
            public string? Title {get;set;}
            public bool VideoPortrait {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Title is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Call.TlSerialize());
                if(Title is not null) bytes.AddRange(Title.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneSetCallRating : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [39,214,234,89,];
            public bool UserInitiative {get;set;}
            public required InputPhoneCallBase Peer {get;set;}
            public int Rating {get;set;}
            public required string Comment {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Rating.TlSerialize());
                bytes.AddRange(Comment.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneGetGroupParticipants : TlFunction<PhoneGroupParticipantsBase> {
            public static readonly byte[] Identifier = [171,216,88,197,];
            public required InputGroupCallBase Call {get;set;}
            public required List<InputPeerBase> Ids {get;set;}
            public required List<int> Sources {get;set;}
            public required string Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(Ids.TlSerialize());
                bytes.AddRange(Sources.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneConfirmCall : TlFunction<PhonePhoneCallBase> {
            public static readonly byte[] Identifier = [34,23,254,46,];
            public required InputPhoneCallBase Peer {get;set;}
            public required byte[] GA {get;set;}
            public long KeyFingerprint {get;set;}
            public required PhoneCallProtocolBase Protocol {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(GA.TlSerialize());
                bytes.AddRange(KeyFingerprint.TlSerialize());
                bytes.AddRange(Protocol.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneToggleGroupCallSettings : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [61,180,187,116,];
            public bool ResetInviteHash {get;set;}
            public required InputGroupCallBase Call {get;set;}
            public bool JoinMuted {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Call.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneAcceptCall : TlFunction<PhonePhoneCallBase> {
            public static readonly byte[] Identifier = [160,180,210,59,];
            public required InputPhoneCallBase Peer {get;set;}
            public required byte[] GB {get;set;}
            public required PhoneCallProtocolBase Protocol {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(GB.TlSerialize());
                bytes.AddRange(Protocol.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneExportGroupCallInvite : TlFunction<PhoneExportedGroupCallInviteBase> {
            public static readonly byte[] Identifier = [127,100,170,230,];
            public bool CanSelfUnmute {get;set;}
            public required InputGroupCallBase Call {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Call.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneSaveCallDebug : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [126,221,122,39,];
            public required InputPhoneCallBase Peer {get;set;}
            public required DataJSONBase Debug {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Debug.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneSendSignalingData : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [131,147,122,255,];
            public required InputPhoneCallBase Peer {get;set;}
            public required byte[] Data {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Data.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneLeaveGroupCall : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [249,119,3,80,];
            public required InputGroupCallBase Call {get;set;}
            public int Source {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(Source.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneInviteToGroupCall : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [96,49,57,123,];
            public required InputGroupCallBase Call {get;set;}
            public required List<InputUserBase> Users {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(Users.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneGetGroupCall : TlFunction<PhoneGroupCallBase> {
            public static readonly byte[] Identifier = [219,69,24,4,];
            public required InputGroupCallBase Call {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneCheckGroupCall : TlFunction<TlList<TlInt>> {
            public static readonly byte[] Identifier = [119,249,156,181,];
            public required InputGroupCallBase Call {get;set;}
            public required List<int> Sources {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(Sources.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneEditGroupCallTitle : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [10,172,166,28,];
            public required InputGroupCallBase Call {get;set;}
            public required string Title {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneToggleGroupCallStartSubscription : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [230,52,156,33,];
            public required InputGroupCallBase Call {get;set;}
            public bool Subscribed {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneSaveDefaultGroupCallJoinAs : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [140,31,94,87,];
            public required InputPeerBase Peer {get;set;}
            public required InputPeerBase JoinAs {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(JoinAs.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneJoinGroupCallPresentation : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [196,107,234,203,];
            public required InputGroupCallBase Call {get;set;}
            public required DataJSONBase Params {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                bytes.AddRange(Params.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneGetGroupCallStreamRtmpUrl : TlFunction<PhoneGroupCallStreamRtmpUrlBase> {
            public static readonly byte[] Identifier = [191,171,179,222,];
            public required InputPeerBase Peer {get;set;}
            public bool Revoke {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneSaveCallLog : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [134,135,36,65,];
            public required InputPhoneCallBase Peer {get;set;}
            public required InputFileBase File {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(File.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneReceivedCall : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [97,79,213,23,];
            public required InputPhoneCallBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneDiscardGroupCall : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [53,113,119,122,];
            public required InputGroupCallBase Call {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneGetGroupCallJoinAs : TlFunction<PhoneJoinAsPeersBase> {
            public static readonly byte[] Identifier = [58,33,124,239,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneStartScheduledGroupCall : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [66,227,128,86,];
            public required InputGroupCallBase Call {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneLeaveGroupCallPresentation : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [68,209,80,28,];
            public required InputGroupCallBase Call {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneGetGroupCallStreamChannels : TlFunction<PhoneGroupCallStreamChannelsBase> {
            public static readonly byte[] Identifier = [64,25,178,26,];
            public required InputGroupCallBase Call {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Call.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhoneGetCallConfig : TlFunction<DataJSONBase> {
            public static readonly byte[] Identifier = [169,31,69,85,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Photos {
        public sealed class PhotosUploadContactProfilePhoto : TlFunction<PhotosPhotoBase> {
            public static readonly byte[] Identifier = [113,74,76,225,];
            public bool Suggest {get;set;}
            public bool Save {get;set;}
            public required InputUserBase UserId {get;set;}
            public InputFileBase? File {get;set;}
            public InputFileBase? Video {get;set;}
            public double? VideoStartTs {get;set;}
            public VideoSizeBase? VideoEmojiMarkup {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (File is not null ? 1 : 0) | (Video is not null ? 2 : 0) | (VideoStartTs is not null ? 4 : 0) | (VideoEmojiMarkup is not null ? 32 : 0) ).TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                if(File is not null) bytes.AddRange(File.TlSerialize());
                if(Video is not null) bytes.AddRange(Video.TlSerialize());
                if(VideoStartTs is not null) bytes.AddRange(VideoStartTs.TlSerialize());
                if(VideoEmojiMarkup is not null) bytes.AddRange(VideoEmojiMarkup.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhotosUploadProfilePhoto : TlFunction<PhotosPhotoBase> {
            public static readonly byte[] Identifier = [181,163,136,3,];
            public bool Fallback {get;set;}
            public InputUserBase? Bot {get;set;}
            public InputFileBase? File {get;set;}
            public InputFileBase? Video {get;set;}
            public double? VideoStartTs {get;set;}
            public VideoSizeBase? VideoEmojiMarkup {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Bot is not null ? 32 : 0) | (File is not null ? 1 : 0) | (Video is not null ? 2 : 0) | (VideoStartTs is not null ? 4 : 0) | (VideoEmojiMarkup is not null ? 16 : 0) ).TlSerialize());
                if(Bot is not null) bytes.AddRange(Bot.TlSerialize());
                if(File is not null) bytes.AddRange(File.TlSerialize());
                if(Video is not null) bytes.AddRange(Video.TlSerialize());
                if(VideoStartTs is not null) bytes.AddRange(VideoStartTs.TlSerialize());
                if(VideoEmojiMarkup is not null) bytes.AddRange(VideoEmojiMarkup.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhotosUpdateProfilePhoto : TlFunction<PhotosPhotoBase> {
            public static readonly byte[] Identifier = [57,32,232,9,];
            public bool Fallback {get;set;}
            public InputUserBase? Bot {get;set;}
            public required InputPhotoBase Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Bot is not null ? 2 : 0) ).TlSerialize());
                if(Bot is not null) bytes.AddRange(Bot.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhotosGetUserPhotos : TlFunction<PhotosPhotosBase> {
            public static readonly byte[] Identifier = [168,50,205,145,];
            public required InputUserBase UserId {get;set;}
            public int Offset {get;set;}
            public long MaxId {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PhotosDeletePhotos : TlFunction<TlList<TlLong>> {
            public static readonly byte[] Identifier = [47,127,207,135,];
            public required List<InputPhotoBase> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
}
namespace Premium {
        public sealed class PremiumGetBoostsList : TlFunction<PremiumBoostsListBase> {
            public static readonly byte[] Identifier = [96,118,246,96,];
            public bool Gifts {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required string Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PremiumApplyBoost : TlFunction<PremiumMyBoostsBase> {
            public static readonly byte[] Identifier = [70,167,125,107,];
            public List<int>? Slots {get;set;}
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Slots is not null ? 1 : 0) ).TlSerialize());
                if(Slots is not null) bytes.AddRange(Slots.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PremiumGetUserBoosts : TlFunction<PremiumBoostsListBase> {
            public static readonly byte[] Identifier = [31,77,133,57,];
            public required InputPeerBase Peer {get;set;}
            public required InputUserBase UserId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PremiumGetBoostsStatus : TlFunction<PremiumBoostsStatusBase> {
            public static readonly byte[] Identifier = [97,31,47,4,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class PremiumGetMyBoosts : TlFunction<PremiumMyBoostsBase> {
            public static readonly byte[] Identifier = [74,123,231,11,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Stats {
        public sealed class StatsGetMessagePublicForwards : TlFunction<StatsPublicForwardsBase> {
            public static readonly byte[] Identifier = [68,1,21,95,];
            public required InputChannelBase Channel {get;set;}
            public int MsgId {get;set;}
            public required string Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StatsGetMessageStats : TlFunction<StatsMessageStatsBase> {
            public static readonly byte[] Identifier = [245,163,224,182,];
            public bool Dark {get;set;}
            public required InputChannelBase Channel {get;set;}
            public int MsgId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(MsgId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StatsGetStoryStats : TlFunction<StatsStoryStatsBase> {
            public static readonly byte[] Identifier = [64,239,79,55,];
            public bool Dark {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StatsGetStoryPublicForwards : TlFunction<StatsPublicForwardsBase> {
            public static readonly byte[] Identifier = [246,126,67,166,];
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public required string Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StatsGetBroadcastStats : TlFunction<StatsBroadcastStatsBase> {
            public static readonly byte[] Identifier = [26,68,66,171,];
            public bool Dark {get;set;}
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StatsLoadAsyncGraph : TlFunction<StatsGraphBase> {
            public static readonly byte[] Identifier = [160,95,29,98,];
            public required string Token {get;set;}
            public long? X {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (X is not null ? 1 : 0) ).TlSerialize());
                bytes.AddRange(Token.TlSerialize());
                if(X is not null) bytes.AddRange(X.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StatsGetMegagroupStats : TlFunction<StatsMegagroupStatsBase> {
            public static readonly byte[] Identifier = [7,134,223,220,];
            public bool Dark {get;set;}
            public required InputChannelBase Channel {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                return bytes.ToArray();
            }
        }
}
namespace Stickers {
        public sealed class StickersCreateStickerSet : TlFunction<MessagesStickerSetBase> {
            public static readonly byte[] Identifier = [103,171,33,144,];
            public bool Masks {get;set;}
            public bool Animated {get;set;}
            public bool Videos {get;set;}
            public bool Emojis {get;set;}
            public bool TextColor {get;set;}
            public required InputUserBase UserId {get;set;}
            public required string Title {get;set;}
            public required string ShortName {get;set;}
            public InputDocumentBase? Thumb {get;set;}
            public required List<InputStickerSetItemBase> Stickers {get;set;}
            public string? Software {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Thumb is not null ? 4 : 0) | (Software is not null ? 8 : 0) ).TlSerialize());
                bytes.AddRange(UserId.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                bytes.AddRange(ShortName.TlSerialize());
                if(Thumb is not null) bytes.AddRange(Thumb.TlSerialize());
                bytes.AddRange(Stickers.TlSerialize());
                if(Software is not null) bytes.AddRange(Software.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersChangeSticker : TlFunction<MessagesStickerSetBase> {
            public static readonly byte[] Identifier = [188,126,83,245,];
            public required InputDocumentBase Sticker {get;set;}
            public string? Emoji {get;set;}
            public MaskCoordsBase? MaskCoords {get;set;}
            public string? Keywords {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Emoji is not null ? 1 : 0) | (MaskCoords is not null ? 2 : 0) | (Keywords is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Sticker.TlSerialize());
                if(Emoji is not null) bytes.AddRange(Emoji.TlSerialize());
                if(MaskCoords is not null) bytes.AddRange(MaskCoords.TlSerialize());
                if(Keywords is not null) bytes.AddRange(Keywords.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersSetStickerSetThumb : TlFunction<MessagesStickerSetBase> {
            public static readonly byte[] Identifier = [146,83,106,167,];
            public required InputStickerSetBase Stickerset {get;set;}
            public InputDocumentBase? Thumb {get;set;}
            public long? ThumbDocumentId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Thumb is not null ? 1 : 0) | (ThumbDocumentId is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Stickerset.TlSerialize());
                if(Thumb is not null) bytes.AddRange(Thumb.TlSerialize());
                if(ThumbDocumentId is not null) bytes.AddRange(ThumbDocumentId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersChangeStickerPosition : TlFunction<MessagesStickerSetBase> {
            public static readonly byte[] Identifier = [202,212,182,255,];
            public required InputDocumentBase Sticker {get;set;}
            public int Position {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Sticker.TlSerialize());
                bytes.AddRange(Position.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersAddStickerToSet : TlFunction<MessagesStickerSetBase> {
            public static readonly byte[] Identifier = [190,254,83,134,];
            public required InputStickerSetBase Stickerset {get;set;}
            public required InputStickerSetItemBase Sticker {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Stickerset.TlSerialize());
                bytes.AddRange(Sticker.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersRenameStickerSet : TlFunction<MessagesStickerSetBase> {
            public static readonly byte[] Identifier = [0,28,75,18,];
            public required InputStickerSetBase Stickerset {get;set;}
            public required string Title {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Stickerset.TlSerialize());
                bytes.AddRange(Title.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersRemoveStickerFromSet : TlFunction<MessagesStickerSetBase> {
            public static readonly byte[] Identifier = [81,15,118,247,];
            public required InputDocumentBase Sticker {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Sticker.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersCheckShortName : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [57,54,75,40,];
            public required string ShortName {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(ShortName.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersSuggestShortName : TlFunction<StickersSuggestedShortNameBase> {
            public static readonly byte[] Identifier = [3,197,175,77,];
            public required string Title {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Title.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StickersDeleteStickerSet : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [148,67,112,135,];
            public required InputStickerSetBase Stickerset {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Stickerset.TlSerialize());
                return bytes.ToArray();
            }
        }
}
namespace Stories {
        public sealed class StoriesSendStory : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [75,105,230,228,];
            public bool Pinned {get;set;}
            public bool Noforwards {get;set;}
            public bool FwdModified {get;set;}
            public required InputPeerBase Peer {get;set;}
            public required InputMediaBase Media {get;set;}
            public List<MediaAreaBase>? MediaAreas {get;set;}
            public string? Caption {get;set;}
            public List<MessageEntityBase>? Entities {get;set;}
            public required List<InputPrivacyRuleBase> PrivacyRules {get;set;}
            public long RandomId {get;set;}
            public int? Period {get;set;}
            public InputPeerBase? FwdFromId {get;set;}
            public int? FwdFromStory {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (MediaAreas is not null ? 32 : 0) | (Caption is not null ? 1 : 0) | (Entities is not null ? 2 : 0) | (Period is not null ? 8 : 0) | (FwdFromId is not null ? 64 : 0) | (FwdFromStory is not null ? 64 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Media.TlSerialize());
                if(MediaAreas is not null) bytes.AddRange(MediaAreas.TlSerialize());
                if(Caption is not null) bytes.AddRange(Caption.TlSerialize());
                if(Entities is not null) bytes.AddRange(Entities.TlSerialize());
                bytes.AddRange(PrivacyRules.TlSerialize());
                bytes.AddRange(RandomId.TlSerialize());
                if(Period is not null) bytes.AddRange(Period.TlSerialize());
                if(FwdFromId is not null) bytes.AddRange(FwdFromId.TlSerialize());
                if(FwdFromStory is not null) bytes.AddRange(FwdFromStory.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetStoryViewsList : TlFunction<StoriesStoryViewsListBase> {
            public static readonly byte[] Identifier = [87,60,210,126,];
            public bool JustContacts {get;set;}
            public bool ReactionsFirst {get;set;}
            public bool ForwardsFirst {get;set;}
            public required InputPeerBase Peer {get;set;}
            public string? Q {get;set;}
            public int Id {get;set;}
            public required string Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Q is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                if(Q is not null) bytes.AddRange(Q.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesEditStory : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [70,186,131,181,];
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public InputMediaBase? Media {get;set;}
            public List<MediaAreaBase>? MediaAreas {get;set;}
            public string? Caption {get;set;}
            public List<MessageEntityBase>? Entities {get;set;}
            public List<InputPrivacyRuleBase>? PrivacyRules {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Media is not null ? 1 : 0) | (MediaAreas is not null ? 8 : 0) | (Caption is not null ? 2 : 0) | (Entities is not null ? 2 : 0) | (PrivacyRules is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                if(Media is not null) bytes.AddRange(Media.TlSerialize());
                if(MediaAreas is not null) bytes.AddRange(MediaAreas.TlSerialize());
                if(Caption is not null) bytes.AddRange(Caption.TlSerialize());
                if(Entities is not null) bytes.AddRange(Entities.TlSerialize());
                if(PrivacyRules is not null) bytes.AddRange(PrivacyRules.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetStoryReactionsList : TlFunction<StoriesStoryReactionsListBase> {
            public static readonly byte[] Identifier = [31,136,178,185,];
            public bool ForwardsFirst {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public ReactionBase? Reaction {get;set;}
            public string? Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (Reaction is not null ? 1 : 0) | (Offset is not null ? 2 : 0) ).TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                if(Reaction is not null) bytes.AddRange(Reaction.TlSerialize());
                if(Offset is not null) bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesSendReaction : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [178,54,215,127,];
            public bool AddToRecent {get;set;}
            public required InputPeerBase Peer {get;set;}
            public int StoryId {get;set;}
            public required ReactionBase Reaction {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(StoryId.TlSerialize());
                bytes.AddRange(Reaction.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetAllStories : TlFunction<StoriesAllStoriesBase> {
            public static readonly byte[] Identifier = [37,214,176,238,];
            public bool Next {get;set;}
            public bool Hidden {get;set;}
            public string? State {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (State is not null ? 1 : 0) ).TlSerialize());
                if(State is not null) bytes.AddRange(State.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesReport : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [140,250,35,25,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public required ReportReasonBase Reason {get;set;}
            public required string Message {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(Reason.TlSerialize());
                bytes.AddRange(Message.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesTogglePinned : TlFunction<TlList<TlInt>> {
            public static readonly byte[] Identifier = [239,161,117,154,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public bool Pinned {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetPinnedStories : TlFunction<StoriesStoriesBase> {
            public static readonly byte[] Identifier = [220,165,33,88,];
            public required InputPeerBase Peer {get;set;}
            public int OffsetId {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetStoriesArchive : TlFunction<StoriesStoriesBase> {
            public static readonly byte[] Identifier = [22,32,53,180,];
            public required InputPeerBase Peer {get;set;}
            public int OffsetId {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(OffsetId.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesActivateStealthMode : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [102,209,187,87,];
            public bool Past {get;set;}
            public bool Future {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesDeleteStories : TlFunction<TlList<TlInt>> {
            public static readonly byte[] Identifier = [95,219,89,174,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetStoriesByID : TlFunction<StoriesStoriesBase> {
            public static readonly byte[] Identifier = [116,202,116,87,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesReadStories : TlFunction<TlList<TlInt>> {
            public static readonly byte[] Identifier = [200,218,86,165,];
            public required InputPeerBase Peer {get;set;}
            public int MaxId {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(MaxId.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesIncrementStoryViews : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [251,138,2,178,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetStoriesViews : TlFunction<StoriesStoryViewsBase> {
            public static readonly byte[] Identifier = [200,108,225,40,];
            public required InputPeerBase Peer {get;set;}
            public required List<int> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesExportStoryLink : TlFunction<ExportedStoryLinkBase> {
            public static readonly byte[] Identifier = [32,239,141,123,];
            public required InputPeerBase Peer {get;set;}
            public int Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesTogglePeerStoriesHidden : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [196,21,4,189,];
            public required InputPeerBase Peer {get;set;}
            public bool Hidden {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesCanSendStory : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [221,223,223,199,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesToggleAllStoriesHidden : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [196,87,37,124,];
            public bool Hidden {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetPeerStories : TlFunction<StoriesPeerStoriesBase> {
            public static readonly byte[] Identifier = [80,218,74,44,];
            public required InputPeerBase Peer {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Peer.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetPeerMaxIDs : TlFunction<TlList<TlInt>> {
            public static readonly byte[] Identifier = [195,131,89,83,];
            public required List<InputPeerBase> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetAllReadPeerStories : TlFunction<UpdatesBase> {
            public static readonly byte[] Identifier = [249,231,90,155,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
        public sealed class StoriesGetChatsToSend : TlFunction<MessagesChatsBase> {
            public static readonly byte[] Identifier = [96,139,106,165,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Updates {
        public sealed class UpdatesGetDifference : TlFunction<UpdatesDifferenceBase> {
            public static readonly byte[] Identifier = [99,247,194,25,];
            public int Pts {get;set;}
            public int? PtsLimit {get;set;}
            public int? PtsTotalLimit {get;set;}
            public int Date {get;set;}
            public int Qts {get;set;}
            public int? QtsLimit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange((0 | (PtsLimit is not null ? 2 : 0) | (PtsTotalLimit is not null ? 1 : 0) | (QtsLimit is not null ? 4 : 0) ).TlSerialize());
                bytes.AddRange(Pts.TlSerialize());
                if(PtsLimit is not null) bytes.AddRange(PtsLimit.TlSerialize());
                if(PtsTotalLimit is not null) bytes.AddRange(PtsTotalLimit.TlSerialize());
                bytes.AddRange(Date.TlSerialize());
                bytes.AddRange(Qts.TlSerialize());
                if(QtsLimit is not null) bytes.AddRange(QtsLimit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UpdatesGetChannelDifference : TlFunction<UpdatesChannelDifferenceBase> {
            public static readonly byte[] Identifier = [120,61,23,3,];
            public bool Force {get;set;}
            public required InputChannelBase Channel {get;set;}
            public required ChannelMessagesFilterBase Filter {get;set;}
            public int Pts {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Channel.TlSerialize());
                bytes.AddRange(Filter.TlSerialize());
                bytes.AddRange(Pts.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UpdatesGetState : TlFunction<UpdatesStateBase> {
            public static readonly byte[] Identifier = [42,136,212,237,];
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                return bytes.ToArray();
            }
        }
}
namespace Upload {
        public sealed class UploadGetFile : TlFunction<UploadFileBase> {
            public static readonly byte[] Identifier = [190,53,83,190,];
            public bool Precise {get;set;}
            public bool CdnSupported {get;set;}
            public required InputFileLocationBase Location {get;set;}
            public long Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(0.TlSerialize());
                bytes.AddRange(Location.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UploadSaveBigFilePart : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [61,103,123,222,];
            public long FileId {get;set;}
            public int FilePart {get;set;}
            public int FileTotalParts {get;set;}
            public required byte[] Bytes {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(FileId.TlSerialize());
                bytes.AddRange(FilePart.TlSerialize());
                bytes.AddRange(FileTotalParts.TlSerialize());
                bytes.AddRange(Bytes.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UploadSaveFilePart : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [33,166,4,179,];
            public long FileId {get;set;}
            public int FilePart {get;set;}
            public required byte[] Bytes {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(FileId.TlSerialize());
                bytes.AddRange(FilePart.TlSerialize());
                bytes.AddRange(Bytes.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UploadGetWebFile : TlFunction<UploadWebFileBase> {
            public static readonly byte[] Identifier = [141,129,230,36,];
            public required InputWebFileLocationBase Location {get;set;}
            public int Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Location.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UploadGetCdnFile : TlFunction<UploadCdnFileBase> {
            public static readonly byte[] Identifier = [218,105,95,57,];
            public required byte[] FileToken {get;set;}
            public long Offset {get;set;}
            public int Limit {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(FileToken.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                bytes.AddRange(Limit.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UploadReuploadCdnFile : TlFunction<TlList<FileHashBase>> {
            public static readonly byte[] Identifier = [168,84,39,155,];
            public required byte[] FileToken {get;set;}
            public required byte[] RequestToken {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(FileToken.TlSerialize());
                bytes.AddRange(RequestToken.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UploadGetCdnFileHashes : TlFunction<TlList<FileHashBase>> {
            public static readonly byte[] Identifier = [49,63,220,145,];
            public required byte[] FileToken {get;set;}
            public long Offset {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(FileToken.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UploadGetFileHashes : TlFunction<TlList<FileHashBase>> {
            public static readonly byte[] Identifier = [42,152,86,145,];
            public required InputFileLocationBase Location {get;set;}
            public long Offset {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Location.TlSerialize());
                bytes.AddRange(Offset.TlSerialize());
                return bytes.ToArray();
            }
        }
}
namespace Users {
        public sealed class UsersSetSecureValueErrors : TlFunction<TlBool> {
            public static readonly byte[] Identifier = [181,148,200,144,];
            public required InputUserBase Id {get;set;}
            public required List<SecureValueErrorBase> Errors {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                bytes.AddRange(Errors.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UsersGetUsers : TlFunction<TlList<UserBase>> {
            public static readonly byte[] Identifier = [72,165,145,13,];
            public required List<InputUserBase> Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
        public sealed class UsersGetFullUser : TlFunction<UsersUserFullBase> {
            public static readonly byte[] Identifier = [24,89,15,182,];
            public required InputUserBase Id {get;set;}
            public override byte[] TlSerialize() {
                List<byte> bytes = [];
                bytes.AddRange(Identifier);
                bytes.AddRange(Id.TlSerialize());
                return bytes.ToArray();
            }
        }
}
}
