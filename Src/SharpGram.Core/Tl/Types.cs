using SharpGram.Core.Conversions;using SharpGram.Core.Contracts;
using Tel = SharpGram.Tl.Constructors;
// ReSharper disable IdentifierTypo PartialTypeWithSinglePart InconsistentNaming CheckNamespace MemberCanBePrivate.Global ClassNeverInstantiated.Global PropertyCanBeMadeInitOnly.Global UnusedAutoPropertyAccessor.Global CollectionNeverUpdated.Global

namespace SharpGram.Tl.Types;
/// derived Types: InputPeerEmpty, InputPeerSelf, InputPeerChat, InputPeerUser, InputPeerChannel, InputPeerUserFromMessage, InputPeerChannelFromMessage,
    public abstract class InputPeerBase : ITlSerializable, ITlDeserializable<InputPeerBase> {
        public static InputPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputPeerNs.InputPeerEmpty.Identifier))
                return Tel.InputPeerNs.InputPeerEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPeerNs.InputPeerSelf.Identifier))
                return Tel.InputPeerNs.InputPeerSelf.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPeerNs.InputPeerChat.Identifier))
                return Tel.InputPeerNs.InputPeerChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPeerNs.InputPeerUser.Identifier))
                return Tel.InputPeerNs.InputPeerUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPeerNs.InputPeerChannel.Identifier))
                return Tel.InputPeerNs.InputPeerChannel.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPeerNs.InputPeerUserFromMessage.Identifier))
                return Tel.InputPeerNs.InputPeerUserFromMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPeerNs.InputPeerChannelFromMessage.Identifier))
                return Tel.InputPeerNs.InputPeerChannelFromMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputPeerNs.InputPeerEmpty InputPeerEmpty2134579434 => InputPeerEmpty2134579434.TlSerialize(),
            Tel.InputPeerNs.InputPeerSelf InputPeerSelf2107670217 => InputPeerSelf2107670217.TlSerialize(),
            Tel.InputPeerNs.InputPeerChat InputPeerChat900291769 => InputPeerChat900291769.TlSerialize(),
            Tel.InputPeerNs.InputPeerUser InputPeerUser571955892 => InputPeerUser571955892.TlSerialize(),
            Tel.InputPeerNs.InputPeerChannel InputPeerChannel666680316 => InputPeerChannel666680316.TlSerialize(),
            Tel.InputPeerNs.InputPeerUserFromMessage InputPeerUserFromMessage1468331492 => InputPeerUserFromMessage1468331492.TlSerialize(),
            Tel.InputPeerNs.InputPeerChannelFromMessage InputPeerChannelFromMessage1121318848 => InputPeerChannelFromMessage1121318848.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputUserEmpty, InputUserSelf, InputUser, InputUserFromMessage,
    public abstract class InputUserBase : ITlSerializable, ITlDeserializable<InputUserBase> {
        public static InputUserBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputUserNs.InputUserEmpty.Identifier))
                return Tel.InputUserNs.InputUserEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputUserNs.InputUserSelf.Identifier))
                return Tel.InputUserNs.InputUserSelf.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputUserNs.InputUser.Identifier))
                return Tel.InputUserNs.InputUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputUserNs.InputUserFromMessage.Identifier))
                return Tel.InputUserNs.InputUserFromMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputUserNs.InputUserEmpty InputUserEmpty1182234929 => InputUserEmpty1182234929.TlSerialize(),
            Tel.InputUserNs.InputUserSelf InputUserSelf138301121 => InputUserSelf138301121.TlSerialize(),
            Tel.InputUserNs.InputUser InputUser233744186 => InputUser233744186.TlSerialize(),
            Tel.InputUserNs.InputUserFromMessage InputUserFromMessage497305826 => InputUserFromMessage497305826.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputPhoneContact,
    public abstract class InputContactBase : ITlSerializable, ITlDeserializable<InputContactBase> {
        public static InputContactBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputContactNs.InputPhoneContact.Identifier))
                return Tel.InputContactNs.InputPhoneContact.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputContactNs.InputPhoneContact InputPhoneContact208488460 => InputPhoneContact208488460.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputFile, InputFileBig,
    public abstract class InputFileBase : ITlSerializable, ITlDeserializable<InputFileBase> {
        public long Id {get;set;} = default!;
        public int Parts {get;set;} = default!;
        public string Name {get;set;} = default!;
        public static InputFileBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputFileNs.InputFile.Identifier))
                return Tel.InputFileNs.InputFile.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileNs.InputFileBig.Identifier))
                return Tel.InputFileNs.InputFileBig.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputFileNs.InputFile InputFile181407105 => InputFile181407105.TlSerialize(),
            Tel.InputFileNs.InputFileBig InputFileBig95482955 => InputFileBig95482955.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputMediaEmpty, InputMediaUploadedPhoto, InputMediaPhoto, InputMediaGeoPoint, InputMediaContact, InputMediaUploadedDocument, InputMediaDocument, InputMediaVenue, InputMediaPhotoExternal, InputMediaDocumentExternal, InputMediaGame, InputMediaInvoice, InputMediaGeoLive, InputMediaPoll, InputMediaDice, InputMediaStory, InputMediaWebPage, InputMediaPaidMedia,
    public abstract class InputMediaBase : ITlSerializable, ITlDeserializable<InputMediaBase> {
        public static InputMediaBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaEmpty.Identifier))
                return Tel.InputMediaNs.InputMediaEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaUploadedPhoto.Identifier))
                return Tel.InputMediaNs.InputMediaUploadedPhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaPhoto.Identifier))
                return Tel.InputMediaNs.InputMediaPhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaGeoPoint.Identifier))
                return Tel.InputMediaNs.InputMediaGeoPoint.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaContact.Identifier))
                return Tel.InputMediaNs.InputMediaContact.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaUploadedDocument.Identifier))
                return Tel.InputMediaNs.InputMediaUploadedDocument.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaDocument.Identifier))
                return Tel.InputMediaNs.InputMediaDocument.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaVenue.Identifier))
                return Tel.InputMediaNs.InputMediaVenue.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaPhotoExternal.Identifier))
                return Tel.InputMediaNs.InputMediaPhotoExternal.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaDocumentExternal.Identifier))
                return Tel.InputMediaNs.InputMediaDocumentExternal.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaGame.Identifier))
                return Tel.InputMediaNs.InputMediaGame.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaInvoice.Identifier))
                return Tel.InputMediaNs.InputMediaInvoice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaGeoLive.Identifier))
                return Tel.InputMediaNs.InputMediaGeoLive.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaPoll.Identifier))
                return Tel.InputMediaNs.InputMediaPoll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaDice.Identifier))
                return Tel.InputMediaNs.InputMediaDice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaStory.Identifier))
                return Tel.InputMediaNs.InputMediaStory.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaWebPage.Identifier))
                return Tel.InputMediaNs.InputMediaWebPage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMediaNs.InputMediaPaidMedia.Identifier))
                return Tel.InputMediaNs.InputMediaPaidMedia.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputMediaNs.InputMediaEmpty InputMediaEmpty1771768449 => InputMediaEmpty1771768449.TlSerialize(),
            Tel.InputMediaNs.InputMediaUploadedPhoto InputMediaUploadedPhoto505969924 => InputMediaUploadedPhoto505969924.TlSerialize(),
            Tel.InputMediaNs.InputMediaPhoto InputMediaPhoto1279654347 => InputMediaPhoto1279654347.TlSerialize(),
            Tel.InputMediaNs.InputMediaGeoPoint InputMediaGeoPoint104578748 => InputMediaGeoPoint104578748.TlSerialize(),
            Tel.InputMediaNs.InputMediaContact InputMediaContact122978821 => InputMediaContact122978821.TlSerialize(),
            Tel.InputMediaNs.InputMediaUploadedDocument InputMediaUploadedDocument1530447553 => InputMediaUploadedDocument1530447553.TlSerialize(),
            Tel.InputMediaNs.InputMediaDocument InputMediaDocument860303448 => InputMediaDocument860303448.TlSerialize(),
            Tel.InputMediaNs.InputMediaVenue InputMediaVenue1052959727 => InputMediaVenue1052959727.TlSerialize(),
            Tel.InputMediaNs.InputMediaPhotoExternal InputMediaPhotoExternal440664550 => InputMediaPhotoExternal440664550.TlSerialize(),
            Tel.InputMediaNs.InputMediaDocumentExternal InputMediaDocumentExternal78455655 => InputMediaDocumentExternal78455655.TlSerialize(),
            Tel.InputMediaNs.InputMediaGame InputMediaGame750828557 => InputMediaGame750828557.TlSerialize(),
            Tel.InputMediaNs.InputMediaInvoice InputMediaInvoice1080028941 => InputMediaInvoice1080028941.TlSerialize(),
            Tel.InputMediaNs.InputMediaGeoLive InputMediaGeoLive1759532989 => InputMediaGeoLive1759532989.TlSerialize(),
            Tel.InputMediaNs.InputMediaPoll InputMediaPoll261416433 => InputMediaPoll261416433.TlSerialize(),
            Tel.InputMediaNs.InputMediaDice InputMediaDice428884101 => InputMediaDice428884101.TlSerialize(),
            Tel.InputMediaNs.InputMediaStory InputMediaStory1979852936 => InputMediaStory1979852936.TlSerialize(),
            Tel.InputMediaNs.InputMediaWebPage InputMediaWebPage1038383031 => InputMediaWebPage1038383031.TlSerialize(),
            Tel.InputMediaNs.InputMediaPaidMedia InputMediaPaidMedia1436147773 => InputMediaPaidMedia1436147773.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputChatPhotoEmpty, InputChatUploadedPhoto, InputChatPhoto,
    public abstract class InputChatPhotoBase : ITlSerializable, ITlDeserializable<InputChatPhotoBase> {
        public static InputChatPhotoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputChatPhotoNs.InputChatPhotoEmpty.Identifier))
                return Tel.InputChatPhotoNs.InputChatPhotoEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputChatPhotoNs.InputChatUploadedPhoto.Identifier))
                return Tel.InputChatPhotoNs.InputChatUploadedPhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputChatPhotoNs.InputChatPhoto.Identifier))
                return Tel.InputChatPhotoNs.InputChatPhoto.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputChatPhotoNs.InputChatPhotoEmpty InputChatPhotoEmpty480546647 => InputChatPhotoEmpty480546647.TlSerialize(),
            Tel.InputChatPhotoNs.InputChatUploadedPhoto InputChatUploadedPhoto1110593856 => InputChatUploadedPhoto1110593856.TlSerialize(),
            Tel.InputChatPhotoNs.InputChatPhoto InputChatPhoto1991004873 => InputChatPhoto1991004873.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputGeoPointEmpty, InputGeoPoint,
    public abstract class InputGeoPointBase : ITlSerializable, ITlDeserializable<InputGeoPointBase> {
        public static InputGeoPointBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputGeoPointNs.InputGeoPointEmpty.Identifier))
                return Tel.InputGeoPointNs.InputGeoPointEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputGeoPointNs.InputGeoPoint.Identifier))
                return Tel.InputGeoPointNs.InputGeoPoint.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputGeoPointNs.InputGeoPointEmpty InputGeoPointEmpty457104426 => InputGeoPointEmpty457104426.TlSerialize(),
            Tel.InputGeoPointNs.InputGeoPoint InputGeoPoint1210199983 => InputGeoPoint1210199983.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputPhotoEmpty, InputPhoto,
    public abstract class InputPhotoBase : ITlSerializable, ITlDeserializable<InputPhotoBase> {
        public static InputPhotoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputPhotoNs.InputPhotoEmpty.Identifier))
                return Tel.InputPhotoNs.InputPhotoEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPhotoNs.InputPhoto.Identifier))
                return Tel.InputPhotoNs.InputPhoto.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputPhotoNs.InputPhotoEmpty InputPhotoEmpty483901197 => InputPhotoEmpty483901197.TlSerialize(),
            Tel.InputPhotoNs.InputPhoto InputPhoto1001634122 => InputPhoto1001634122.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputFileLocation, InputEncryptedFileLocation, InputDocumentFileLocation, InputSecureFileLocation, InputTakeoutFileLocation, InputPhotoFileLocation, InputPhotoLegacyFileLocation, InputPeerPhotoFileLocation, InputStickerSetThumb, InputGroupCallStream,
    public abstract class InputFileLocationBase : ITlSerializable, ITlDeserializable<InputFileLocationBase> {
        public static InputFileLocationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputFileLocationNs.InputFileLocation.Identifier))
                return Tel.InputFileLocationNs.InputFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputEncryptedFileLocation.Identifier))
                return Tel.InputFileLocationNs.InputEncryptedFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputDocumentFileLocation.Identifier))
                return Tel.InputFileLocationNs.InputDocumentFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputSecureFileLocation.Identifier))
                return Tel.InputFileLocationNs.InputSecureFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputTakeoutFileLocation.Identifier))
                return Tel.InputFileLocationNs.InputTakeoutFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputPhotoFileLocation.Identifier))
                return Tel.InputFileLocationNs.InputPhotoFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputPhotoLegacyFileLocation.Identifier))
                return Tel.InputFileLocationNs.InputPhotoLegacyFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputPeerPhotoFileLocation.Identifier))
                return Tel.InputFileLocationNs.InputPeerPhotoFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputStickerSetThumb.Identifier))
                return Tel.InputFileLocationNs.InputStickerSetThumb.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputFileLocationNs.InputGroupCallStream.Identifier))
                return Tel.InputFileLocationNs.InputGroupCallStream.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputFileLocationNs.InputFileLocation InputFileLocation539317279 => InputFileLocation539317279.TlSerialize(),
            Tel.InputFileLocationNs.InputEncryptedFileLocation InputEncryptedFileLocation182231723 => InputEncryptedFileLocation182231723.TlSerialize(),
            Tel.InputFileLocationNs.InputDocumentFileLocation InputDocumentFileLocation1160743548 => InputDocumentFileLocation1160743548.TlSerialize(),
            Tel.InputFileLocationNs.InputSecureFileLocation InputSecureFileLocation876089816 => InputSecureFileLocation876089816.TlSerialize(),
            Tel.InputFileLocationNs.InputTakeoutFileLocation InputTakeoutFileLocation700340377 => InputTakeoutFileLocation700340377.TlSerialize(),
            Tel.InputFileLocationNs.InputPhotoFileLocation InputPhotoFileLocation1075322878 => InputPhotoFileLocation1075322878.TlSerialize(),
            Tel.InputFileLocationNs.InputPhotoLegacyFileLocation InputPhotoLegacyFileLocation667654413 => InputPhotoLegacyFileLocation667654413.TlSerialize(),
            Tel.InputFileLocationNs.InputPeerPhotoFileLocation InputPeerPhotoFileLocation925204121 => InputPeerPhotoFileLocation925204121.TlSerialize(),
            Tel.InputFileLocationNs.InputStickerSetThumb InputStickerSetThumb1652231205 => InputStickerSetThumb1652231205.TlSerialize(),
            Tel.InputFileLocationNs.InputGroupCallStream InputGroupCallStream93890858 => InputGroupCallStream93890858.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PeerUser, PeerChat, PeerChannel,
    public abstract class PeerBase : ITlSerializable, ITlDeserializable<PeerBase> {
        public static PeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PeerNs.PeerUser.Identifier))
                return Tel.PeerNs.PeerUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PeerNs.PeerChat.Identifier))
                return Tel.PeerNs.PeerChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PeerNs.PeerChannel.Identifier))
                return Tel.PeerNs.PeerChannel.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PeerNs.PeerUser PeerUser1498486562 => PeerUser1498486562.TlSerialize(),
            Tel.PeerNs.PeerChat PeerChat918946202 => PeerChat918946202.TlSerialize(),
            Tel.PeerNs.PeerChannel PeerChannel1566230754 => PeerChannel1566230754.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StorageFileUnknown, StorageFilePartial, StorageFileJpeg, StorageFileGif, StorageFilePng, StorageFilePdf, StorageFileMp3, StorageFileMov, StorageFileMp4, StorageFileWebp,
    public abstract class StorageFileTypeBase : ITlSerializable, ITlDeserializable<StorageFileTypeBase> {
        public static StorageFileTypeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFileUnknown.Identifier))
                return Tel.StorageFileTypeNs.StorageFileUnknown.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFilePartial.Identifier))
                return Tel.StorageFileTypeNs.StorageFilePartial.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFileJpeg.Identifier))
                return Tel.StorageFileTypeNs.StorageFileJpeg.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFileGif.Identifier))
                return Tel.StorageFileTypeNs.StorageFileGif.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFilePng.Identifier))
                return Tel.StorageFileTypeNs.StorageFilePng.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFilePdf.Identifier))
                return Tel.StorageFileTypeNs.StorageFilePdf.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFileMp3.Identifier))
                return Tel.StorageFileTypeNs.StorageFileMp3.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFileMov.Identifier))
                return Tel.StorageFileTypeNs.StorageFileMov.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFileMp4.Identifier))
                return Tel.StorageFileTypeNs.StorageFileMp4.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StorageFileTypeNs.StorageFileWebp.Identifier))
                return Tel.StorageFileTypeNs.StorageFileWebp.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StorageFileTypeNs.StorageFileUnknown StorageFileUnknown1432995067 => StorageFileUnknown1432995067.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFilePartial StorageFilePartial1086091090 => StorageFilePartial1086091090.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFileJpeg StorageFileJpeg8322574 => StorageFileJpeg8322574.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFileGif StorageFileGif891180321 => StorageFileGif891180321.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFilePng StorageFilePng172975040 => StorageFilePng172975040.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFilePdf StorageFilePdf1373745011 => StorageFilePdf1373745011.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFileMp3 StorageFileMp31384777335 => StorageFileMp31384777335.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFileMov StorageFileMov1258941372 => StorageFileMov1258941372.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFileMp4 StorageFileMp41278304028 => StorageFileMp41278304028.TlSerialize(),
            Tel.StorageFileTypeNs.StorageFileWebp StorageFileWebp276907596 => StorageFileWebp276907596.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UserEmpty, User,
    public abstract class UserBase : ITlSerializable, ITlDeserializable<UserBase> {
        public long Id {get;set;} = default!;
        public static UserBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UserNs.UserEmpty.Identifier))
                return Tel.UserNs.UserEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UserNs.User.Identifier))
                return Tel.UserNs.User.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UserNs.UserEmpty UserEmpty742634630 => UserEmpty742634630.TlSerialize(),
            Tel.UserNs.User User559694904 => User559694904.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UserProfilePhotoEmpty, UserProfilePhoto,
    public abstract class UserProfilePhotoBase : ITlSerializable, ITlDeserializable<UserProfilePhotoBase> {
        public static UserProfilePhotoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UserProfilePhotoNs.UserProfilePhotoEmpty.Identifier))
                return Tel.UserProfilePhotoNs.UserProfilePhotoEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UserProfilePhotoNs.UserProfilePhoto.Identifier))
                return Tel.UserProfilePhotoNs.UserProfilePhoto.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UserProfilePhotoNs.UserProfilePhotoEmpty UserProfilePhotoEmpty1326562017 => UserProfilePhotoEmpty1326562017.TlSerialize(),
            Tel.UserProfilePhotoNs.UserProfilePhoto UserProfilePhoto2100168954 => UserProfilePhoto2100168954.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UserStatusEmpty, UserStatusOnline, UserStatusOffline, UserStatusRecently, UserStatusLastWeek, UserStatusLastMonth,
    public abstract class UserStatusBase : ITlSerializable, ITlDeserializable<UserStatusBase> {
        public static UserStatusBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UserStatusNs.UserStatusEmpty.Identifier))
                return Tel.UserStatusNs.UserStatusEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UserStatusNs.UserStatusOnline.Identifier))
                return Tel.UserStatusNs.UserStatusOnline.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UserStatusNs.UserStatusOffline.Identifier))
                return Tel.UserStatusNs.UserStatusOffline.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UserStatusNs.UserStatusRecently.Identifier))
                return Tel.UserStatusNs.UserStatusRecently.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UserStatusNs.UserStatusLastWeek.Identifier))
                return Tel.UserStatusNs.UserStatusLastWeek.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UserStatusNs.UserStatusLastMonth.Identifier))
                return Tel.UserStatusNs.UserStatusLastMonth.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UserStatusNs.UserStatusEmpty UserStatusEmpty164646985 => UserStatusEmpty164646985.TlSerialize(),
            Tel.UserStatusNs.UserStatusOnline UserStatusOnline306628279 => UserStatusOnline306628279.TlSerialize(),
            Tel.UserStatusNs.UserStatusOffline UserStatusOffline9203775 => UserStatusOffline9203775.TlSerialize(),
            Tel.UserStatusNs.UserStatusRecently UserStatusRecently2065268168 => UserStatusRecently2065268168.TlSerialize(),
            Tel.UserStatusNs.UserStatusLastWeek UserStatusLastWeek1410997530 => UserStatusLastWeek1410997530.TlSerialize(),
            Tel.UserStatusNs.UserStatusLastMonth UserStatusLastMonth1703516023 => UserStatusLastMonth1703516023.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatEmpty, Chat, ChatForbidden, Channel, ChannelForbidden,
    public abstract class ChatBase : ITlSerializable, ITlDeserializable<ChatBase> {
        public long Id {get;set;} = default!;
        public static ChatBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatNs.ChatEmpty.Identifier))
                return Tel.ChatNs.ChatEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatNs.Chat.Identifier))
                return Tel.ChatNs.Chat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatNs.ChatForbidden.Identifier))
                return Tel.ChatNs.ChatForbidden.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatNs.Channel.Identifier))
                return Tel.ChatNs.Channel.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatNs.ChannelForbidden.Identifier))
                return Tel.ChatNs.ChannelForbidden.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatNs.ChatEmpty ChatEmpty693512293 => ChatEmpty693512293.TlSerialize(),
            Tel.ChatNs.Chat Chat1103884886 => Chat1103884886.TlSerialize(),
            Tel.ChatNs.ChatForbidden ChatForbidden1704108455 => ChatForbidden1704108455.TlSerialize(),
            Tel.ChatNs.Channel Channel179174543 => Channel179174543.TlSerialize(),
            Tel.ChatNs.ChannelForbidden ChannelForbidden399807445 => ChannelForbidden399807445.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatFull, ChannelFull,
    public abstract class ChatFullBase : ITlSerializable, ITlDeserializable<ChatFullBase> {
        public int Flags {get;set;} = default!;
        public bool CanSetUsername {get;set;} = default!;
        public bool HasScheduled {get;set;} = default!;
        public bool TranslationsDisabled {get;set;} = default!;
        public long Id {get;set;} = default!;
        public string About {get;set;} = default!;
        public PeerNotifySettingsBase NotifySettings {get;set;} = default!;
        public ExportedChatInviteBase? ExportedInvite {get;set;} = default!;
        public int? PinnedMsgId {get;set;} = default!;
        public int? FolderId {get;set;} = default!;
        public InputGroupCallBase? Call {get;set;} = default!;
        public int? TtlPeriod {get;set;} = default!;
        public PeerBase? GroupcallDefaultJoinAs {get;set;} = default!;
        public string? ThemeEmoticon {get;set;} = default!;
        public int? RequestsPending {get;set;} = default!;
        public List<long>? RecentRequesters {get;set;} = default!;
        public ChatReactionsBase? AvailableReactions {get;set;} = default!;
        public int? ReactionsLimit {get;set;} = default!;
        public static ChatFullBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatFullNs.ChatFull.Identifier))
                return Tel.ChatFullNs.ChatFull.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatFullNs.ChannelFull.Identifier))
                return Tel.ChatFullNs.ChannelFull.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatFullNs.ChatFull ChatFull640893467 => ChatFull640893467.TlSerialize(),
            Tel.ChatFullNs.ChannelFull ChannelFull1146407795 => ChannelFull1146407795.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatParticipant, ChatParticipantCreator, ChatParticipantAdmin,
    public abstract class ChatParticipantBase : ITlSerializable, ITlDeserializable<ChatParticipantBase> {
        public long UserId {get;set;} = default!;
        public static ChatParticipantBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatParticipantNs.ChatParticipant.Identifier))
                return Tel.ChatParticipantNs.ChatParticipant.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatParticipantNs.ChatParticipantCreator.Identifier))
                return Tel.ChatParticipantNs.ChatParticipantCreator.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatParticipantNs.ChatParticipantAdmin.Identifier))
                return Tel.ChatParticipantNs.ChatParticipantAdmin.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatParticipantNs.ChatParticipant ChatParticipant1070776313 => ChatParticipant1070776313.TlSerialize(),
            Tel.ChatParticipantNs.ChatParticipantCreator ChatParticipantCreator462696732 => ChatParticipantCreator462696732.TlSerialize(),
            Tel.ChatParticipantNs.ChatParticipantAdmin ChatParticipantAdmin1600962725 => ChatParticipantAdmin1600962725.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatParticipantsForbidden, ChatParticipants,
    public abstract class ChatParticipantsBase : ITlSerializable, ITlDeserializable<ChatParticipantsBase> {
        public long ChatId {get;set;} = default!;
        public static ChatParticipantsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatParticipantsNs.ChatParticipantsForbidden.Identifier))
                return Tel.ChatParticipantsNs.ChatParticipantsForbidden.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatParticipantsNs.ChatParticipants.Identifier))
                return Tel.ChatParticipantsNs.ChatParticipants.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatParticipantsNs.ChatParticipantsForbidden ChatParticipantsForbidden2023500831 => ChatParticipantsForbidden2023500831.TlSerialize(),
            Tel.ChatParticipantsNs.ChatParticipants ChatParticipants1018991608 => ChatParticipants1018991608.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatPhotoEmpty, ChatPhoto,
    public abstract class ChatPhotoBase : ITlSerializable, ITlDeserializable<ChatPhotoBase> {
        public static ChatPhotoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatPhotoNs.ChatPhotoEmpty.Identifier))
                return Tel.ChatPhotoNs.ChatPhotoEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatPhotoNs.ChatPhoto.Identifier))
                return Tel.ChatPhotoNs.ChatPhoto.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatPhotoNs.ChatPhotoEmpty ChatPhotoEmpty935395612 => ChatPhotoEmpty935395612.TlSerialize(),
            Tel.ChatPhotoNs.ChatPhoto ChatPhoto476978193 => ChatPhoto476978193.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageEmpty, Message, MessageService,
    public abstract class MessageBase : ITlSerializable, ITlDeserializable<MessageBase> {
        public int Flags {get;set;} = default!;
        public int Id {get;set;} = default!;
        public static MessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageNs.MessageEmpty.Identifier))
                return Tel.MessageNs.MessageEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageNs.Message.Identifier))
                return Tel.MessageNs.Message.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageNs.MessageService.Identifier))
                return Tel.MessageNs.MessageService.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageNs.MessageEmpty MessageEmpty1868117372 => MessageEmpty1868117372.TlSerialize(),
            Tel.MessageNs.Message Message1808510398 => Message1808510398.TlSerialize(),
            Tel.MessageNs.MessageService MessageService721967202 => MessageService721967202.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageMediaEmpty, MessageMediaPhoto, MessageMediaGeo, MessageMediaContact, MessageMediaUnsupported, MessageMediaDocument, MessageMediaWebPage, MessageMediaVenue, MessageMediaGame, MessageMediaInvoice, MessageMediaGeoLive, MessageMediaPoll, MessageMediaDice, MessageMediaStory, MessageMediaGiveaway, MessageMediaGiveawayResults, MessageMediaPaidMedia,
    public abstract class MessageMediaBase : ITlSerializable, ITlDeserializable<MessageMediaBase> {
        public static MessageMediaBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaEmpty.Identifier))
                return Tel.MessageMediaNs.MessageMediaEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaPhoto.Identifier))
                return Tel.MessageMediaNs.MessageMediaPhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaGeo.Identifier))
                return Tel.MessageMediaNs.MessageMediaGeo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaContact.Identifier))
                return Tel.MessageMediaNs.MessageMediaContact.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaUnsupported.Identifier))
                return Tel.MessageMediaNs.MessageMediaUnsupported.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaDocument.Identifier))
                return Tel.MessageMediaNs.MessageMediaDocument.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaWebPage.Identifier))
                return Tel.MessageMediaNs.MessageMediaWebPage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaVenue.Identifier))
                return Tel.MessageMediaNs.MessageMediaVenue.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaGame.Identifier))
                return Tel.MessageMediaNs.MessageMediaGame.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaInvoice.Identifier))
                return Tel.MessageMediaNs.MessageMediaInvoice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaGeoLive.Identifier))
                return Tel.MessageMediaNs.MessageMediaGeoLive.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaPoll.Identifier))
                return Tel.MessageMediaNs.MessageMediaPoll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaDice.Identifier))
                return Tel.MessageMediaNs.MessageMediaDice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaStory.Identifier))
                return Tel.MessageMediaNs.MessageMediaStory.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaGiveaway.Identifier))
                return Tel.MessageMediaNs.MessageMediaGiveaway.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaGiveawayResults.Identifier))
                return Tel.MessageMediaNs.MessageMediaGiveawayResults.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageMediaNs.MessageMediaPaidMedia.Identifier))
                return Tel.MessageMediaNs.MessageMediaPaidMedia.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageMediaNs.MessageMediaEmpty MessageMediaEmpty1038967584 => MessageMediaEmpty1038967584.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaPhoto MessageMediaPhoto1766936791 => MessageMediaPhoto1766936791.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaGeo MessageMediaGeo1457575028 => MessageMediaGeo1457575028.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaContact MessageMediaContact1882335561 => MessageMediaContact1882335561.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaUnsupported MessageMediaUnsupported1618676578 => MessageMediaUnsupported1618676578.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaDocument MessageMediaDocument1291114285 => MessageMediaDocument1291114285.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaWebPage MessageMediaWebPage571405253 => MessageMediaWebPage571405253.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaVenue MessageMediaVenue784356159 => MessageMediaVenue784356159.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaGame MessageMediaGame38694904 => MessageMediaGame38694904.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaInvoice MessageMediaInvoice156940077 => MessageMediaInvoice156940077.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaGeoLive MessageMediaGeoLive1186937242 => MessageMediaGeoLive1186937242.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaPoll MessageMediaPoll1272375192 => MessageMediaPoll1272375192.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaDice MessageMediaDice1065280907 => MessageMediaDice1065280907.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaStory MessageMediaStory1758159491 => MessageMediaStory1758159491.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaGiveaway MessageMediaGiveaway626162256 => MessageMediaGiveaway626162256.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaGiveawayResults MessageMediaGiveawayResults963047320 => MessageMediaGiveawayResults963047320.TlSerialize(),
            Tel.MessageMediaNs.MessageMediaPaidMedia MessageMediaPaidMedia1467669359 => MessageMediaPaidMedia1467669359.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageActionEmpty, MessageActionChatCreate, MessageActionChatEditTitle, MessageActionChatEditPhoto, MessageActionChatDeletePhoto, MessageActionChatAddUser, MessageActionChatDeleteUser, MessageActionChatJoinedByLink, MessageActionChannelCreate, MessageActionChatMigrateTo, MessageActionChannelMigrateFrom, MessageActionPinMessage, MessageActionHistoryClear, MessageActionGameScore, MessageActionPaymentSentMe, MessageActionPaymentSent, MessageActionPhoneCall, MessageActionScreenshotTaken, MessageActionCustomAction, MessageActionBotAllowed, MessageActionSecureValuesSentMe, MessageActionSecureValuesSent, MessageActionContactSignUp, MessageActionGeoProximityReached, MessageActionGroupCall, MessageActionInviteToGroupCall, MessageActionSetMessagesTTL, MessageActionGroupCallScheduled, MessageActionSetChatTheme, MessageActionChatJoinedByRequest, MessageActionWebViewDataSentMe, MessageActionWebViewDataSent, MessageActionGiftPremium, MessageActionTopicCreate, MessageActionTopicEdit, MessageActionSuggestProfilePhoto, MessageActionRequestedPeer, MessageActionSetChatWallPaper, MessageActionGiftCode, MessageActionGiveawayLaunch, MessageActionGiveawayResults, MessageActionBoostApply, MessageActionRequestedPeerSentMe, MessageActionPaymentRefunded,
    public abstract class MessageActionBase : ITlSerializable, ITlDeserializable<MessageActionBase> {
        public static MessageActionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionEmpty.Identifier))
                return Tel.MessageActionNs.MessageActionEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatCreate.Identifier))
                return Tel.MessageActionNs.MessageActionChatCreate.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatEditTitle.Identifier))
                return Tel.MessageActionNs.MessageActionChatEditTitle.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatEditPhoto.Identifier))
                return Tel.MessageActionNs.MessageActionChatEditPhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatDeletePhoto.Identifier))
                return Tel.MessageActionNs.MessageActionChatDeletePhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatAddUser.Identifier))
                return Tel.MessageActionNs.MessageActionChatAddUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatDeleteUser.Identifier))
                return Tel.MessageActionNs.MessageActionChatDeleteUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatJoinedByLink.Identifier))
                return Tel.MessageActionNs.MessageActionChatJoinedByLink.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChannelCreate.Identifier))
                return Tel.MessageActionNs.MessageActionChannelCreate.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatMigrateTo.Identifier))
                return Tel.MessageActionNs.MessageActionChatMigrateTo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChannelMigrateFrom.Identifier))
                return Tel.MessageActionNs.MessageActionChannelMigrateFrom.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionPinMessage.Identifier))
                return Tel.MessageActionNs.MessageActionPinMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionHistoryClear.Identifier))
                return Tel.MessageActionNs.MessageActionHistoryClear.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionGameScore.Identifier))
                return Tel.MessageActionNs.MessageActionGameScore.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionPaymentSentMe.Identifier))
                return Tel.MessageActionNs.MessageActionPaymentSentMe.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionPaymentSent.Identifier))
                return Tel.MessageActionNs.MessageActionPaymentSent.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionPhoneCall.Identifier))
                return Tel.MessageActionNs.MessageActionPhoneCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionScreenshotTaken.Identifier))
                return Tel.MessageActionNs.MessageActionScreenshotTaken.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionCustomAction.Identifier))
                return Tel.MessageActionNs.MessageActionCustomAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionBotAllowed.Identifier))
                return Tel.MessageActionNs.MessageActionBotAllowed.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionSecureValuesSentMe.Identifier))
                return Tel.MessageActionNs.MessageActionSecureValuesSentMe.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionSecureValuesSent.Identifier))
                return Tel.MessageActionNs.MessageActionSecureValuesSent.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionContactSignUp.Identifier))
                return Tel.MessageActionNs.MessageActionContactSignUp.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionGeoProximityReached.Identifier))
                return Tel.MessageActionNs.MessageActionGeoProximityReached.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionGroupCall.Identifier))
                return Tel.MessageActionNs.MessageActionGroupCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionInviteToGroupCall.Identifier))
                return Tel.MessageActionNs.MessageActionInviteToGroupCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionSetMessagesTTL.Identifier))
                return Tel.MessageActionNs.MessageActionSetMessagesTTL.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionGroupCallScheduled.Identifier))
                return Tel.MessageActionNs.MessageActionGroupCallScheduled.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionSetChatTheme.Identifier))
                return Tel.MessageActionNs.MessageActionSetChatTheme.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionChatJoinedByRequest.Identifier))
                return Tel.MessageActionNs.MessageActionChatJoinedByRequest.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionWebViewDataSentMe.Identifier))
                return Tel.MessageActionNs.MessageActionWebViewDataSentMe.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionWebViewDataSent.Identifier))
                return Tel.MessageActionNs.MessageActionWebViewDataSent.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionGiftPremium.Identifier))
                return Tel.MessageActionNs.MessageActionGiftPremium.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionTopicCreate.Identifier))
                return Tel.MessageActionNs.MessageActionTopicCreate.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionTopicEdit.Identifier))
                return Tel.MessageActionNs.MessageActionTopicEdit.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionSuggestProfilePhoto.Identifier))
                return Tel.MessageActionNs.MessageActionSuggestProfilePhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionRequestedPeer.Identifier))
                return Tel.MessageActionNs.MessageActionRequestedPeer.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionSetChatWallPaper.Identifier))
                return Tel.MessageActionNs.MessageActionSetChatWallPaper.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionGiftCode.Identifier))
                return Tel.MessageActionNs.MessageActionGiftCode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionGiveawayLaunch.Identifier))
                return Tel.MessageActionNs.MessageActionGiveawayLaunch.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionGiveawayResults.Identifier))
                return Tel.MessageActionNs.MessageActionGiveawayResults.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionBoostApply.Identifier))
                return Tel.MessageActionNs.MessageActionBoostApply.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionRequestedPeerSentMe.Identifier))
                return Tel.MessageActionNs.MessageActionRequestedPeerSentMe.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageActionNs.MessageActionPaymentRefunded.Identifier))
                return Tel.MessageActionNs.MessageActionPaymentRefunded.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageActionNs.MessageActionEmpty MessageActionEmpty1230047312 => MessageActionEmpty1230047312.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatCreate MessageActionChatCreate1119368275 => MessageActionChatCreate1119368275.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatEditTitle MessageActionChatEditTitle1247687078 => MessageActionChatEditTitle1247687078.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatEditPhoto MessageActionChatEditPhoto2144015272 => MessageActionChatEditPhoto2144015272.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatDeletePhoto MessageActionChatDeletePhoto1780220945 => MessageActionChatDeletePhoto1780220945.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatAddUser MessageActionChatAddUser365886720 => MessageActionChatAddUser365886720.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatDeleteUser MessageActionChatDeleteUser1539362612 => MessageActionChatDeleteUser1539362612.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatJoinedByLink MessageActionChatJoinedByLink51520707 => MessageActionChatJoinedByLink51520707.TlSerialize(),
            Tel.MessageActionNs.MessageActionChannelCreate MessageActionChannelCreate1781355374 => MessageActionChannelCreate1781355374.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatMigrateTo MessageActionChatMigrateTo519864430 => MessageActionChatMigrateTo519864430.TlSerialize(),
            Tel.MessageActionNs.MessageActionChannelMigrateFrom MessageActionChannelMigrateFrom365344535 => MessageActionChannelMigrateFrom365344535.TlSerialize(),
            Tel.MessageActionNs.MessageActionPinMessage MessageActionPinMessage1799538451 => MessageActionPinMessage1799538451.TlSerialize(),
            Tel.MessageActionNs.MessageActionHistoryClear MessageActionHistoryClear1615153660 => MessageActionHistoryClear1615153660.TlSerialize(),
            Tel.MessageActionNs.MessageActionGameScore MessageActionGameScore1834538890 => MessageActionGameScore1834538890.TlSerialize(),
            Tel.MessageActionNs.MessageActionPaymentSentMe MessageActionPaymentSentMe1892568281 => MessageActionPaymentSentMe1892568281.TlSerialize(),
            Tel.MessageActionNs.MessageActionPaymentSent MessageActionPaymentSent1776926890 => MessageActionPaymentSent1776926890.TlSerialize(),
            Tel.MessageActionNs.MessageActionPhoneCall MessageActionPhoneCall2132731265 => MessageActionPhoneCall2132731265.TlSerialize(),
            Tel.MessageActionNs.MessageActionScreenshotTaken MessageActionScreenshotTaken1200788123 => MessageActionScreenshotTaken1200788123.TlSerialize(),
            Tel.MessageActionNs.MessageActionCustomAction MessageActionCustomAction85549226 => MessageActionCustomAction85549226.TlSerialize(),
            Tel.MessageActionNs.MessageActionBotAllowed MessageActionBotAllowed988359047 => MessageActionBotAllowed988359047.TlSerialize(),
            Tel.MessageActionNs.MessageActionSecureValuesSentMe MessageActionSecureValuesSentMe455635795 => MessageActionSecureValuesSentMe455635795.TlSerialize(),
            Tel.MessageActionNs.MessageActionSecureValuesSent MessageActionSecureValuesSent648257196 => MessageActionSecureValuesSent648257196.TlSerialize(),
            Tel.MessageActionNs.MessageActionContactSignUp MessageActionContactSignUp202219658 => MessageActionContactSignUp202219658.TlSerialize(),
            Tel.MessageActionNs.MessageActionGeoProximityReached MessageActionGeoProximityReached1730095465 => MessageActionGeoProximityReached1730095465.TlSerialize(),
            Tel.MessageActionNs.MessageActionGroupCall MessageActionGroupCall2047704898 => MessageActionGroupCall2047704898.TlSerialize(),
            Tel.MessageActionNs.MessageActionInviteToGroupCall MessageActionInviteToGroupCall1345295095 => MessageActionInviteToGroupCall1345295095.TlSerialize(),
            Tel.MessageActionNs.MessageActionSetMessagesTTL MessageActionSetMessagesTTL1007897979 => MessageActionSetMessagesTTL1007897979.TlSerialize(),
            Tel.MessageActionNs.MessageActionGroupCallScheduled MessageActionGroupCallScheduled1281329567 => MessageActionGroupCallScheduled1281329567.TlSerialize(),
            Tel.MessageActionNs.MessageActionSetChatTheme MessageActionSetChatTheme1434950843 => MessageActionSetChatTheme1434950843.TlSerialize(),
            Tel.MessageActionNs.MessageActionChatJoinedByRequest MessageActionChatJoinedByRequest339958837 => MessageActionChatJoinedByRequest339958837.TlSerialize(),
            Tel.MessageActionNs.MessageActionWebViewDataSentMe MessageActionWebViewDataSentMe1205698681 => MessageActionWebViewDataSentMe1205698681.TlSerialize(),
            Tel.MessageActionNs.MessageActionWebViewDataSent MessageActionWebViewDataSent1262252875 => MessageActionWebViewDataSent1262252875.TlSerialize(),
            Tel.MessageActionNs.MessageActionGiftPremium MessageActionGiftPremium935499028 => MessageActionGiftPremium935499028.TlSerialize(),
            Tel.MessageActionNs.MessageActionTopicCreate MessageActionTopicCreate228168278 => MessageActionTopicCreate228168278.TlSerialize(),
            Tel.MessageActionNs.MessageActionTopicEdit MessageActionTopicEdit1064024032 => MessageActionTopicEdit1064024032.TlSerialize(),
            Tel.MessageActionNs.MessageActionSuggestProfilePhoto MessageActionSuggestProfilePhoto1474192222 => MessageActionSuggestProfilePhoto1474192222.TlSerialize(),
            Tel.MessageActionNs.MessageActionRequestedPeer MessageActionRequestedPeer827428507 => MessageActionRequestedPeer827428507.TlSerialize(),
            Tel.MessageActionNs.MessageActionSetChatWallPaper MessageActionSetChatWallPaper1348510708 => MessageActionSetChatWallPaper1348510708.TlSerialize(),
            Tel.MessageActionNs.MessageActionGiftCode MessageActionGiftCode1737240073 => MessageActionGiftCode1737240073.TlSerialize(),
            Tel.MessageActionNs.MessageActionGiveawayLaunch MessageActionGiveawayLaunch858499565 => MessageActionGiveawayLaunch858499565.TlSerialize(),
            Tel.MessageActionNs.MessageActionGiveawayResults MessageActionGiveawayResults715107781 => MessageActionGiveawayResults715107781.TlSerialize(),
            Tel.MessageActionNs.MessageActionBoostApply MessageActionBoostApply872240531 => MessageActionBoostApply872240531.TlSerialize(),
            Tel.MessageActionNs.MessageActionRequestedPeerSentMe MessageActionRequestedPeerSentMe1816979384 => MessageActionRequestedPeerSentMe1816979384.TlSerialize(),
            Tel.MessageActionNs.MessageActionPaymentRefunded MessageActionPaymentRefunded1102307842 => MessageActionPaymentRefunded1102307842.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Dialog, DialogFolder,
    public abstract class DialogBase : ITlSerializable, ITlDeserializable<DialogBase> {
        public int Flags {get;set;} = default!;
        public bool Pinned {get;set;} = default!;
        public PeerBase Peer {get;set;} = default!;
        public int TopMessage {get;set;} = default!;
        public static DialogBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DialogNs.Dialog.Identifier))
                return Tel.DialogNs.Dialog.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DialogNs.DialogFolder.Identifier))
                return Tel.DialogNs.DialogFolder.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DialogNs.Dialog Dialog712374074 => Dialog712374074.TlSerialize(),
            Tel.DialogNs.DialogFolder DialogFolder1908216652 => DialogFolder1908216652.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhotoEmpty, Photo,
    public abstract class PhotoBase : ITlSerializable, ITlDeserializable<PhotoBase> {
        public long Id {get;set;} = default!;
        public static PhotoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhotoNs.PhotoEmpty.Identifier))
                return Tel.PhotoNs.PhotoEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhotoNs.Photo.Identifier))
                return Tel.PhotoNs.Photo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhotoNs.PhotoEmpty PhotoEmpty590459437 => PhotoEmpty590459437.TlSerialize(),
            Tel.PhotoNs.Photo Photo82216347 => Photo82216347.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhotoSizeEmpty, PhotoSize, PhotoCachedSize, PhotoStrippedSize, PhotoSizeProgressive, PhotoPathSize,
    public abstract class PhotoSizeBase : ITlSerializable, ITlDeserializable<PhotoSizeBase> {
        public string Type {get;set;} = default!;
        public static PhotoSizeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhotoSizeNs.PhotoSizeEmpty.Identifier))
                return Tel.PhotoSizeNs.PhotoSizeEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhotoSizeNs.PhotoSize.Identifier))
                return Tel.PhotoSizeNs.PhotoSize.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhotoSizeNs.PhotoCachedSize.Identifier))
                return Tel.PhotoSizeNs.PhotoCachedSize.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhotoSizeNs.PhotoStrippedSize.Identifier))
                return Tel.PhotoSizeNs.PhotoStrippedSize.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhotoSizeNs.PhotoSizeProgressive.Identifier))
                return Tel.PhotoSizeNs.PhotoSizeProgressive.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhotoSizeNs.PhotoPathSize.Identifier))
                return Tel.PhotoSizeNs.PhotoPathSize.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhotoSizeNs.PhotoSizeEmpty PhotoSizeEmpty236446268 => PhotoSizeEmpty236446268.TlSerialize(),
            Tel.PhotoSizeNs.PhotoSize PhotoSize1976012384 => PhotoSize1976012384.TlSerialize(),
            Tel.PhotoSizeNs.PhotoCachedSize PhotoCachedSize35527382 => PhotoCachedSize35527382.TlSerialize(),
            Tel.PhotoSizeNs.PhotoStrippedSize PhotoStrippedSize525288402 => PhotoStrippedSize525288402.TlSerialize(),
            Tel.PhotoSizeNs.PhotoSizeProgressive PhotoSizeProgressive96535659 => PhotoSizeProgressive96535659.TlSerialize(),
            Tel.PhotoSizeNs.PhotoPathSize PhotoPathSize668906175 => PhotoPathSize668906175.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: GeoPointEmpty, GeoPoint,
    public abstract class GeoPointBase : ITlSerializable, ITlDeserializable<GeoPointBase> {
        public static GeoPointBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GeoPointNs.GeoPointEmpty.Identifier))
                return Tel.GeoPointNs.GeoPointEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.GeoPointNs.GeoPoint.Identifier))
                return Tel.GeoPointNs.GeoPoint.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GeoPointNs.GeoPointEmpty GeoPointEmpty286776671 => GeoPointEmpty286776671.TlSerialize(),
            Tel.GeoPointNs.GeoPoint GeoPoint1297942941 => GeoPoint1297942941.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AuthSentCode, AuthSentCodeSuccess,
    public abstract class AuthSentCodeBase : ITlSerializable, ITlDeserializable<AuthSentCodeBase> {
        public static AuthSentCodeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthSentCodeNs.AuthSentCode.Identifier))
                return Tel.AuthSentCodeNs.AuthSentCode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeNs.AuthSentCodeSuccess.Identifier))
                return Tel.AuthSentCodeNs.AuthSentCodeSuccess.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthSentCodeNs.AuthSentCode AuthSentCode1577067778 => AuthSentCode1577067778.TlSerialize(),
            Tel.AuthSentCodeNs.AuthSentCodeSuccess AuthSentCodeSuccess596704836 => AuthSentCodeSuccess596704836.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AuthAuthorization, AuthAuthorizationSignUpRequired,
    public abstract class AuthAuthorizationBase : ITlSerializable, ITlDeserializable<AuthAuthorizationBase> {
        public int Flags {get;set;} = default!;
        public static AuthAuthorizationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthAuthorizationNs.AuthAuthorization.Identifier))
                return Tel.AuthAuthorizationNs.AuthAuthorization.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthAuthorizationNs.AuthAuthorizationSignUpRequired.Identifier))
                return Tel.AuthAuthorizationNs.AuthAuthorizationSignUpRequired.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthAuthorizationNs.AuthAuthorization AuthAuthorization782418132 => AuthAuthorization782418132.TlSerialize(),
            Tel.AuthAuthorizationNs.AuthAuthorizationSignUpRequired AuthAuthorizationSignUpRequired1148485274 => AuthAuthorizationSignUpRequired1148485274.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AuthExportedAuthorization,
    public abstract class AuthExportedAuthorizationBase : ITlSerializable, ITlDeserializable<AuthExportedAuthorizationBase> {
        public static AuthExportedAuthorizationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthExportedAuthorizationNs.AuthExportedAuthorization.Identifier))
                return Tel.AuthExportedAuthorizationNs.AuthExportedAuthorization.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthExportedAuthorizationNs.AuthExportedAuthorization AuthExportedAuthorization1271602504 => AuthExportedAuthorization1271602504.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputNotifyPeer, InputNotifyUsers, InputNotifyChats, InputNotifyBroadcasts, InputNotifyForumTopic,
    public abstract class InputNotifyPeerBase : ITlSerializable, ITlDeserializable<InputNotifyPeerBase> {
        public static InputNotifyPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputNotifyPeerNs.InputNotifyPeer.Identifier))
                return Tel.InputNotifyPeerNs.InputNotifyPeer.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputNotifyPeerNs.InputNotifyUsers.Identifier))
                return Tel.InputNotifyPeerNs.InputNotifyUsers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputNotifyPeerNs.InputNotifyChats.Identifier))
                return Tel.InputNotifyPeerNs.InputNotifyChats.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputNotifyPeerNs.InputNotifyBroadcasts.Identifier))
                return Tel.InputNotifyPeerNs.InputNotifyBroadcasts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputNotifyPeerNs.InputNotifyForumTopic.Identifier))
                return Tel.InputNotifyPeerNs.InputNotifyForumTopic.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputNotifyPeerNs.InputNotifyPeer InputNotifyPeer1195615476 => InputNotifyPeer1195615476.TlSerialize(),
            Tel.InputNotifyPeerNs.InputNotifyUsers InputNotifyUsers423314455 => InputNotifyUsers423314455.TlSerialize(),
            Tel.InputNotifyPeerNs.InputNotifyChats InputNotifyChats1251338318 => InputNotifyChats1251338318.TlSerialize(),
            Tel.InputNotifyPeerNs.InputNotifyBroadcasts InputNotifyBroadcasts1311015810 => InputNotifyBroadcasts1311015810.TlSerialize(),
            Tel.InputNotifyPeerNs.InputNotifyForumTopic InputNotifyForumTopic1548122514 => InputNotifyForumTopic1548122514.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputPeerNotifySettings,
    public abstract class InputPeerNotifySettingsBase : ITlSerializable, ITlDeserializable<InputPeerNotifySettingsBase> {
        public static InputPeerNotifySettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputPeerNotifySettingsNs.InputPeerNotifySettings.Identifier))
                return Tel.InputPeerNotifySettingsNs.InputPeerNotifySettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputPeerNotifySettingsNs.InputPeerNotifySettings InputPeerNotifySettings892638494 => InputPeerNotifySettings892638494.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PeerNotifySettings,
    public abstract class PeerNotifySettingsBase : ITlSerializable, ITlDeserializable<PeerNotifySettingsBase> {
        public static PeerNotifySettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PeerNotifySettingsNs.PeerNotifySettings.Identifier))
                return Tel.PeerNotifySettingsNs.PeerNotifySettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PeerNotifySettingsNs.PeerNotifySettings PeerNotifySettings1721619444 => PeerNotifySettings1721619444.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PeerSettings,
    public abstract class PeerSettingsBase : ITlSerializable, ITlDeserializable<PeerSettingsBase> {
        public static PeerSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PeerSettingsNs.PeerSettings.Identifier))
                return Tel.PeerSettingsNs.PeerSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PeerSettingsNs.PeerSettings PeerSettings1395233698 => PeerSettings1395233698.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: WallPaper, WallPaperNoFile,
    public abstract class WallPaperBase : ITlSerializable, ITlDeserializable<WallPaperBase> {
        public long Id {get;set;} = default!;
        public int Flags {get;set;} = default!;
        public bool Default {get;set;} = default!;
        public bool Dark {get;set;} = default!;
        public WallPaperSettingsBase? Settings {get;set;} = default!;
        public static WallPaperBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.WallPaperNs.WallPaper.Identifier))
                return Tel.WallPaperNs.WallPaper.TlDeserialize(des);
            if (id.SequenceEqual(Tel.WallPaperNs.WallPaperNoFile.Identifier))
                return Tel.WallPaperNs.WallPaperNoFile.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.WallPaperNs.WallPaper WallPaper1539849235 => WallPaper1539849235.TlSerialize(),
            Tel.WallPaperNs.WallPaperNoFile WallPaperNoFile528465642 => WallPaperNoFile528465642.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputReportReasonSpam, InputReportReasonViolence, InputReportReasonPornography, InputReportReasonChildAbuse, InputReportReasonOther, InputReportReasonCopyright, InputReportReasonGeoIrrelevant, InputReportReasonFake, InputReportReasonIllegalDrugs, InputReportReasonPersonalDetails,
    public abstract class ReportReasonBase : ITlSerializable, ITlDeserializable<ReportReasonBase> {
        public static ReportReasonBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonSpam.Identifier))
                return Tel.ReportReasonNs.InputReportReasonSpam.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonViolence.Identifier))
                return Tel.ReportReasonNs.InputReportReasonViolence.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonPornography.Identifier))
                return Tel.ReportReasonNs.InputReportReasonPornography.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonChildAbuse.Identifier))
                return Tel.ReportReasonNs.InputReportReasonChildAbuse.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonOther.Identifier))
                return Tel.ReportReasonNs.InputReportReasonOther.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonCopyright.Identifier))
                return Tel.ReportReasonNs.InputReportReasonCopyright.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonGeoIrrelevant.Identifier))
                return Tel.ReportReasonNs.InputReportReasonGeoIrrelevant.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonFake.Identifier))
                return Tel.ReportReasonNs.InputReportReasonFake.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonIllegalDrugs.Identifier))
                return Tel.ReportReasonNs.InputReportReasonIllegalDrugs.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReportReasonNs.InputReportReasonPersonalDetails.Identifier))
                return Tel.ReportReasonNs.InputReportReasonPersonalDetails.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ReportReasonNs.InputReportReasonSpam InputReportReasonSpam1490799288 => InputReportReasonSpam1490799288.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonViolence InputReportReasonViolence505595789 => InputReportReasonViolence505595789.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonPornography InputReportReasonPornography777640226 => InputReportReasonPornography777640226.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonChildAbuse InputReportReasonChildAbuse1376497949 => InputReportReasonChildAbuse1376497949.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonOther InputReportReasonOther1041980751 => InputReportReasonOther1041980751.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonCopyright InputReportReasonCopyright1685456582 => InputReportReasonCopyright1685456582.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonGeoIrrelevant InputReportReasonGeoIrrelevant606798099 => InputReportReasonGeoIrrelevant606798099.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonFake InputReportReasonFake170010905 => InputReportReasonFake170010905.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonIllegalDrugs InputReportReasonIllegalDrugs177124030 => InputReportReasonIllegalDrugs177124030.TlSerialize(),
            Tel.ReportReasonNs.InputReportReasonPersonalDetails InputReportReasonPersonalDetails1631091139 => InputReportReasonPersonalDetails1631091139.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UserFull,
    public abstract class UserFullBase : ITlSerializable, ITlDeserializable<UserFullBase> {
        public static UserFullBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UserFullNs.UserFull.Identifier))
                return Tel.UserFullNs.UserFull.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UserFullNs.UserFull UserFull862357728 => UserFull862357728.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Contact,
    public abstract class ContactBase : ITlSerializable, ITlDeserializable<ContactBase> {
        public static ContactBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactNs.Contact.Identifier))
                return Tel.ContactNs.Contact.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactNs.Contact Contact341499403 => Contact341499403.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ImportedContact,
    public abstract class ImportedContactBase : ITlSerializable, ITlDeserializable<ImportedContactBase> {
        public static ImportedContactBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ImportedContactNs.ImportedContact.Identifier))
                return Tel.ImportedContactNs.ImportedContact.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ImportedContactNs.ImportedContact ImportedContact1052885936 => ImportedContact1052885936.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactStatus,
    public abstract class ContactStatusBase : ITlSerializable, ITlDeserializable<ContactStatusBase> {
        public static ContactStatusBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactStatusNs.ContactStatus.Identifier))
                return Tel.ContactStatusNs.ContactStatus.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactStatusNs.ContactStatus ContactStatus383348795 => ContactStatus383348795.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactsContactsNotModified, ContactsContacts,
    public abstract class ContactsContactsBase : ITlSerializable, ITlDeserializable<ContactsContactsBase> {
        public static ContactsContactsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactsContactsNs.ContactsContactsNotModified.Identifier))
                return Tel.ContactsContactsNs.ContactsContactsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ContactsContactsNs.ContactsContacts.Identifier))
                return Tel.ContactsContactsNs.ContactsContacts.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactsContactsNs.ContactsContactsNotModified ContactsContactsNotModified1219778094 => ContactsContactsNotModified1219778094.TlSerialize(),
            Tel.ContactsContactsNs.ContactsContacts ContactsContacts353862078 => ContactsContacts353862078.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactsImportedContacts,
    public abstract class ContactsImportedContactsBase : ITlSerializable, ITlDeserializable<ContactsImportedContactsBase> {
        public static ContactsImportedContactsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactsImportedContactsNs.ContactsImportedContacts.Identifier))
                return Tel.ContactsImportedContactsNs.ContactsImportedContacts.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactsImportedContactsNs.ContactsImportedContacts ContactsImportedContacts2010127419 => ContactsImportedContacts2010127419.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactsBlocked, ContactsBlockedSlice,
    public abstract class ContactsBlockedBase : ITlSerializable, ITlDeserializable<ContactsBlockedBase> {
        public List<PeerBlockedBase> Blocked {get;set;} = default!;
        public List<ChatBase> Chats {get;set;} = default!;
        public List<UserBase> Users {get;set;} = default!;
        public static ContactsBlockedBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactsBlockedNs.ContactsBlocked.Identifier))
                return Tel.ContactsBlockedNs.ContactsBlocked.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ContactsBlockedNs.ContactsBlockedSlice.Identifier))
                return Tel.ContactsBlockedNs.ContactsBlockedSlice.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactsBlockedNs.ContactsBlocked ContactsBlocked182326673 => ContactsBlocked182326673.TlSerialize(),
            Tel.ContactsBlockedNs.ContactsBlockedSlice ContactsBlockedSlice513392236 => ContactsBlockedSlice513392236.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesDialogs, MessagesDialogsSlice, MessagesDialogsNotModified,
    public abstract class MessagesDialogsBase : ITlSerializable, ITlDeserializable<MessagesDialogsBase> {
        public static MessagesDialogsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesDialogsNs.MessagesDialogs.Identifier))
                return Tel.MessagesDialogsNs.MessagesDialogs.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesDialogsNs.MessagesDialogsSlice.Identifier))
                return Tel.MessagesDialogsNs.MessagesDialogsSlice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesDialogsNs.MessagesDialogsNotModified.Identifier))
                return Tel.MessagesDialogsNs.MessagesDialogsNotModified.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesDialogsNs.MessagesDialogs MessagesDialogs364538944 => MessagesDialogs364538944.TlSerialize(),
            Tel.MessagesDialogsNs.MessagesDialogsSlice MessagesDialogsSlice1910543603 => MessagesDialogsSlice1910543603.TlSerialize(),
            Tel.MessagesDialogsNs.MessagesDialogsNotModified MessagesDialogsNotModified253500010 => MessagesDialogsNotModified253500010.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesMessages, MessagesMessagesSlice, MessagesChannelMessages, MessagesMessagesNotModified,
    public abstract class MessagesMessagesBase : ITlSerializable, ITlDeserializable<MessagesMessagesBase> {
        public static MessagesMessagesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesMessagesNs.MessagesMessages.Identifier))
                return Tel.MessagesMessagesNs.MessagesMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesMessagesNs.MessagesMessagesSlice.Identifier))
                return Tel.MessagesMessagesNs.MessagesMessagesSlice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesMessagesNs.MessagesChannelMessages.Identifier))
                return Tel.MessagesMessagesNs.MessagesChannelMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesMessagesNs.MessagesMessagesNotModified.Identifier))
                return Tel.MessagesMessagesNs.MessagesMessagesNotModified.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesMessagesNs.MessagesMessages MessagesMessages1938715001 => MessagesMessages1938715001.TlSerialize(),
            Tel.MessagesMessagesNs.MessagesMessagesSlice MessagesMessagesSlice978610270 => MessagesMessagesSlice978610270.TlSerialize(),
            Tel.MessagesMessagesNs.MessagesChannelMessages MessagesChannelMessages948520370 => MessagesChannelMessages948520370.TlSerialize(),
            Tel.MessagesMessagesNs.MessagesMessagesNotModified MessagesMessagesNotModified1951620897 => MessagesMessagesNotModified1951620897.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesChats, MessagesChatsSlice,
    public abstract class MessagesChatsBase : ITlSerializable, ITlDeserializable<MessagesChatsBase> {
        public List<ChatBase> Chats {get;set;} = default!;
        public static MessagesChatsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesChatsNs.MessagesChats.Identifier))
                return Tel.MessagesChatsNs.MessagesChats.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesChatsNs.MessagesChatsSlice.Identifier))
                return Tel.MessagesChatsNs.MessagesChatsSlice.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesChatsNs.MessagesChats MessagesChats1694474197 => MessagesChats1694474197.TlSerialize(),
            Tel.MessagesChatsNs.MessagesChatsSlice MessagesChatsSlice1663561404 => MessagesChatsSlice1663561404.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesChatFull,
    public abstract class MessagesChatFullBase : ITlSerializable, ITlDeserializable<MessagesChatFullBase> {
        public static MessagesChatFullBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesChatFullNs.MessagesChatFull.Identifier))
                return Tel.MessagesChatFullNs.MessagesChatFull.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesChatFullNs.MessagesChatFull MessagesChatFull438840932 => MessagesChatFull438840932.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesAffectedHistory,
    public abstract class MessagesAffectedHistoryBase : ITlSerializable, ITlDeserializable<MessagesAffectedHistoryBase> {
        public static MessagesAffectedHistoryBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesAffectedHistoryNs.MessagesAffectedHistory.Identifier))
                return Tel.MessagesAffectedHistoryNs.MessagesAffectedHistory.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesAffectedHistoryNs.MessagesAffectedHistory MessagesAffectedHistory1269012015 => MessagesAffectedHistory1269012015.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputMessagesFilterEmpty, InputMessagesFilterPhotos, InputMessagesFilterVideo, InputMessagesFilterPhotoVideo, InputMessagesFilterDocument, InputMessagesFilterUrl, InputMessagesFilterGif, InputMessagesFilterVoice, InputMessagesFilterMusic, InputMessagesFilterChatPhotos, InputMessagesFilterPhoneCalls, InputMessagesFilterRoundVoice, InputMessagesFilterRoundVideo, InputMessagesFilterMyMentions, InputMessagesFilterGeo, InputMessagesFilterContacts, InputMessagesFilterPinned,
    public abstract class MessagesFilterBase : ITlSerializable, ITlDeserializable<MessagesFilterBase> {
        public static MessagesFilterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterEmpty.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterPhotos.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterPhotos.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterVideo.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterVideo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterPhotoVideo.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterPhotoVideo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterDocument.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterDocument.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterUrl.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterUrl.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterGif.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterGif.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterVoice.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterVoice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterMusic.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterMusic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterChatPhotos.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterChatPhotos.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterPhoneCalls.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterPhoneCalls.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterRoundVoice.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterRoundVoice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterRoundVideo.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterRoundVideo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterMyMentions.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterMyMentions.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterGeo.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterGeo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterContacts.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterContacts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFilterNs.InputMessagesFilterPinned.Identifier))
                return Tel.MessagesFilterNs.InputMessagesFilterPinned.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesFilterNs.InputMessagesFilterEmpty InputMessagesFilterEmpty1474492012 => InputMessagesFilterEmpty1474492012.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterPhotos InputMessagesFilterPhotos1777752804 => InputMessagesFilterPhotos1777752804.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterVideo InputMessagesFilterVideo1614803355 => InputMessagesFilterVideo1614803355.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterPhotoVideo InputMessagesFilterPhotoVideo1458172132 => InputMessagesFilterPhotoVideo1458172132.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterDocument InputMessagesFilterDocument1629621880 => InputMessagesFilterDocument1629621880.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterUrl InputMessagesFilterUrl2129714567 => InputMessagesFilterUrl2129714567.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterGif InputMessagesFilterGif3644025 => InputMessagesFilterGif3644025.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterVoice InputMessagesFilterVoice1358283666 => InputMessagesFilterVoice1358283666.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterMusic InputMessagesFilterMusic928101534 => InputMessagesFilterMusic928101534.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterChatPhotos InputMessagesFilterChatPhotos975236280 => InputMessagesFilterChatPhotos975236280.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterPhoneCalls InputMessagesFilterPhoneCalls2134272152 => InputMessagesFilterPhoneCalls2134272152.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterRoundVoice InputMessagesFilterRoundVoice2054952868 => InputMessagesFilterRoundVoice2054952868.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterRoundVideo InputMessagesFilterRoundVideo1253451181 => InputMessagesFilterRoundVideo1253451181.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterMyMentions InputMessagesFilterMyMentions1040652646 => InputMessagesFilterMyMentions1040652646.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterGeo InputMessagesFilterGeo419271411 => InputMessagesFilterGeo419271411.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterContacts InputMessagesFilterContacts530392189 => InputMessagesFilterContacts530392189.TlSerialize(),
            Tel.MessagesFilterNs.InputMessagesFilterPinned InputMessagesFilterPinned464520273 => InputMessagesFilterPinned464520273.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UpdateNewMessage, UpdateMessageID, UpdateDeleteMessages, UpdateUserTyping, UpdateChatUserTyping, UpdateChatParticipants, UpdateUserStatus, UpdateUserName, UpdateNewAuthorization, UpdateNewEncryptedMessage, UpdateEncryptedChatTyping, UpdateEncryption, UpdateEncryptedMessagesRead, UpdateChatParticipantAdd, UpdateChatParticipantDelete, UpdateDcOptions, UpdateNotifySettings, UpdateServiceNotification, UpdatePrivacy, UpdateUserPhone, UpdateReadHistoryInbox, UpdateReadHistoryOutbox, UpdateWebPage, UpdateReadMessagesContents, UpdateChannelTooLong, UpdateChannel, UpdateNewChannelMessage, UpdateReadChannelInbox, UpdateDeleteChannelMessages, UpdateChannelMessageViews, UpdateChatParticipantAdmin, UpdateNewStickerSet, UpdateStickerSetsOrder, UpdateStickerSets, UpdateSavedGifs, UpdateBotInlineQuery, UpdateBotInlineSend, UpdateEditChannelMessage, UpdateBotCallbackQuery, UpdateEditMessage, UpdateInlineBotCallbackQuery, UpdateReadChannelOutbox, UpdateDraftMessage, UpdateReadFeaturedStickers, UpdateRecentStickers, UpdateConfig, UpdatePtsChanged, UpdateChannelWebPage, UpdateDialogPinned, UpdatePinnedDialogs, UpdateBotWebhookJSON, UpdateBotWebhookJSONQuery, UpdateBotShippingQuery, UpdateBotPrecheckoutQuery, UpdatePhoneCall, UpdateLangPackTooLong, UpdateLangPack, UpdateFavedStickers, UpdateChannelReadMessagesContents, UpdateContactsReset, UpdateChannelAvailableMessages, UpdateDialogUnreadMark, UpdateMessagePoll, UpdateChatDefaultBannedRights, UpdateFolderPeers, UpdatePeerSettings, UpdatePeerLocated, UpdateNewScheduledMessage, UpdateDeleteScheduledMessages, UpdateTheme, UpdateGeoLiveViewed, UpdateLoginToken, UpdateMessagePollVote, UpdateDialogFilter, UpdateDialogFilterOrder, UpdateDialogFilters, UpdatePhoneCallSignalingData, UpdateChannelMessageForwards, UpdateReadChannelDiscussionInbox, UpdateReadChannelDiscussionOutbox, UpdatePeerBlocked, UpdateChannelUserTyping, UpdatePinnedMessages, UpdatePinnedChannelMessages, UpdateChat, UpdateGroupCallParticipants, UpdateGroupCall, UpdatePeerHistoryTTL, UpdateChatParticipant, UpdateChannelParticipant, UpdateBotStopped, UpdateGroupCallConnection, UpdateBotCommands, UpdatePendingJoinRequests, UpdateBotChatInviteRequester, UpdateMessageReactions, UpdateAttachMenuBots, UpdateWebViewResultSent, UpdateBotMenuButton, UpdateSavedRingtones, UpdateTranscribedAudio, UpdateReadFeaturedEmojiStickers, UpdateUserEmojiStatus, UpdateRecentEmojiStatuses, UpdateRecentReactions, UpdateMoveStickerSetToTop, UpdateMessageExtendedMedia, UpdateChannelPinnedTopic, UpdateChannelPinnedTopics, UpdateUser, UpdateAutoSaveSettings, UpdateStory, UpdateReadStories, UpdateStoryID, UpdateStoriesStealthMode, UpdateSentStoryReaction, UpdateBotChatBoost, UpdateChannelViewForumAsMessages, UpdatePeerWallpaper, UpdateBotMessageReaction, UpdateBotMessageReactions, UpdateSavedDialogPinned, UpdatePinnedSavedDialogs, UpdateSavedReactionTags, UpdateSmsJob, UpdateQuickReplies, UpdateNewQuickReply, UpdateDeleteQuickReply, UpdateQuickReplyMessage, UpdateDeleteQuickReplyMessages, UpdateBotBusinessConnect, UpdateBotNewBusinessMessage, UpdateBotEditBusinessMessage, UpdateBotDeleteBusinessMessage, UpdateNewStoryReaction, UpdateBroadcastRevenueTransactions, UpdateStarsBalance, UpdateBusinessBotCallbackQuery, UpdateStarsRevenueStatus,
    public abstract class UpdateBase : ITlSerializable, ITlDeserializable<UpdateBase> {
        public static UpdateBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UpdateNs.UpdateNewMessage.Identifier))
                return Tel.UpdateNs.UpdateNewMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateMessageID.Identifier))
                return Tel.UpdateNs.UpdateMessageID.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDeleteMessages.Identifier))
                return Tel.UpdateNs.UpdateDeleteMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateUserTyping.Identifier))
                return Tel.UpdateNs.UpdateUserTyping.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChatUserTyping.Identifier))
                return Tel.UpdateNs.UpdateChatUserTyping.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChatParticipants.Identifier))
                return Tel.UpdateNs.UpdateChatParticipants.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateUserStatus.Identifier))
                return Tel.UpdateNs.UpdateUserStatus.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateUserName.Identifier))
                return Tel.UpdateNs.UpdateUserName.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateNewAuthorization.Identifier))
                return Tel.UpdateNs.UpdateNewAuthorization.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateNewEncryptedMessage.Identifier))
                return Tel.UpdateNs.UpdateNewEncryptedMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateEncryptedChatTyping.Identifier))
                return Tel.UpdateNs.UpdateEncryptedChatTyping.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateEncryption.Identifier))
                return Tel.UpdateNs.UpdateEncryption.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateEncryptedMessagesRead.Identifier))
                return Tel.UpdateNs.UpdateEncryptedMessagesRead.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChatParticipantAdd.Identifier))
                return Tel.UpdateNs.UpdateChatParticipantAdd.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChatParticipantDelete.Identifier))
                return Tel.UpdateNs.UpdateChatParticipantDelete.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDcOptions.Identifier))
                return Tel.UpdateNs.UpdateDcOptions.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateNotifySettings.Identifier))
                return Tel.UpdateNs.UpdateNotifySettings.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateServiceNotification.Identifier))
                return Tel.UpdateNs.UpdateServiceNotification.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePrivacy.Identifier))
                return Tel.UpdateNs.UpdatePrivacy.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateUserPhone.Identifier))
                return Tel.UpdateNs.UpdateUserPhone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadHistoryInbox.Identifier))
                return Tel.UpdateNs.UpdateReadHistoryInbox.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadHistoryOutbox.Identifier))
                return Tel.UpdateNs.UpdateReadHistoryOutbox.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateWebPage.Identifier))
                return Tel.UpdateNs.UpdateWebPage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadMessagesContents.Identifier))
                return Tel.UpdateNs.UpdateReadMessagesContents.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelTooLong.Identifier))
                return Tel.UpdateNs.UpdateChannelTooLong.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannel.Identifier))
                return Tel.UpdateNs.UpdateChannel.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateNewChannelMessage.Identifier))
                return Tel.UpdateNs.UpdateNewChannelMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadChannelInbox.Identifier))
                return Tel.UpdateNs.UpdateReadChannelInbox.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDeleteChannelMessages.Identifier))
                return Tel.UpdateNs.UpdateDeleteChannelMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelMessageViews.Identifier))
                return Tel.UpdateNs.UpdateChannelMessageViews.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChatParticipantAdmin.Identifier))
                return Tel.UpdateNs.UpdateChatParticipantAdmin.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateNewStickerSet.Identifier))
                return Tel.UpdateNs.UpdateNewStickerSet.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateStickerSetsOrder.Identifier))
                return Tel.UpdateNs.UpdateStickerSetsOrder.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateStickerSets.Identifier))
                return Tel.UpdateNs.UpdateStickerSets.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateSavedGifs.Identifier))
                return Tel.UpdateNs.UpdateSavedGifs.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotInlineQuery.Identifier))
                return Tel.UpdateNs.UpdateBotInlineQuery.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotInlineSend.Identifier))
                return Tel.UpdateNs.UpdateBotInlineSend.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateEditChannelMessage.Identifier))
                return Tel.UpdateNs.UpdateEditChannelMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotCallbackQuery.Identifier))
                return Tel.UpdateNs.UpdateBotCallbackQuery.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateEditMessage.Identifier))
                return Tel.UpdateNs.UpdateEditMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateInlineBotCallbackQuery.Identifier))
                return Tel.UpdateNs.UpdateInlineBotCallbackQuery.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadChannelOutbox.Identifier))
                return Tel.UpdateNs.UpdateReadChannelOutbox.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDraftMessage.Identifier))
                return Tel.UpdateNs.UpdateDraftMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadFeaturedStickers.Identifier))
                return Tel.UpdateNs.UpdateReadFeaturedStickers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateRecentStickers.Identifier))
                return Tel.UpdateNs.UpdateRecentStickers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateConfig.Identifier))
                return Tel.UpdateNs.UpdateConfig.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePtsChanged.Identifier))
                return Tel.UpdateNs.UpdatePtsChanged.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelWebPage.Identifier))
                return Tel.UpdateNs.UpdateChannelWebPage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDialogPinned.Identifier))
                return Tel.UpdateNs.UpdateDialogPinned.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePinnedDialogs.Identifier))
                return Tel.UpdateNs.UpdatePinnedDialogs.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotWebhookJSON.Identifier))
                return Tel.UpdateNs.UpdateBotWebhookJSON.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotWebhookJSONQuery.Identifier))
                return Tel.UpdateNs.UpdateBotWebhookJSONQuery.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotShippingQuery.Identifier))
                return Tel.UpdateNs.UpdateBotShippingQuery.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotPrecheckoutQuery.Identifier))
                return Tel.UpdateNs.UpdateBotPrecheckoutQuery.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePhoneCall.Identifier))
                return Tel.UpdateNs.UpdatePhoneCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateLangPackTooLong.Identifier))
                return Tel.UpdateNs.UpdateLangPackTooLong.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateLangPack.Identifier))
                return Tel.UpdateNs.UpdateLangPack.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateFavedStickers.Identifier))
                return Tel.UpdateNs.UpdateFavedStickers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelReadMessagesContents.Identifier))
                return Tel.UpdateNs.UpdateChannelReadMessagesContents.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateContactsReset.Identifier))
                return Tel.UpdateNs.UpdateContactsReset.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelAvailableMessages.Identifier))
                return Tel.UpdateNs.UpdateChannelAvailableMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDialogUnreadMark.Identifier))
                return Tel.UpdateNs.UpdateDialogUnreadMark.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateMessagePoll.Identifier))
                return Tel.UpdateNs.UpdateMessagePoll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChatDefaultBannedRights.Identifier))
                return Tel.UpdateNs.UpdateChatDefaultBannedRights.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateFolderPeers.Identifier))
                return Tel.UpdateNs.UpdateFolderPeers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePeerSettings.Identifier))
                return Tel.UpdateNs.UpdatePeerSettings.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePeerLocated.Identifier))
                return Tel.UpdateNs.UpdatePeerLocated.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateNewScheduledMessage.Identifier))
                return Tel.UpdateNs.UpdateNewScheduledMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDeleteScheduledMessages.Identifier))
                return Tel.UpdateNs.UpdateDeleteScheduledMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateTheme.Identifier))
                return Tel.UpdateNs.UpdateTheme.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateGeoLiveViewed.Identifier))
                return Tel.UpdateNs.UpdateGeoLiveViewed.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateLoginToken.Identifier))
                return Tel.UpdateNs.UpdateLoginToken.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateMessagePollVote.Identifier))
                return Tel.UpdateNs.UpdateMessagePollVote.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDialogFilter.Identifier))
                return Tel.UpdateNs.UpdateDialogFilter.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDialogFilterOrder.Identifier))
                return Tel.UpdateNs.UpdateDialogFilterOrder.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDialogFilters.Identifier))
                return Tel.UpdateNs.UpdateDialogFilters.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePhoneCallSignalingData.Identifier))
                return Tel.UpdateNs.UpdatePhoneCallSignalingData.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelMessageForwards.Identifier))
                return Tel.UpdateNs.UpdateChannelMessageForwards.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadChannelDiscussionInbox.Identifier))
                return Tel.UpdateNs.UpdateReadChannelDiscussionInbox.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadChannelDiscussionOutbox.Identifier))
                return Tel.UpdateNs.UpdateReadChannelDiscussionOutbox.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePeerBlocked.Identifier))
                return Tel.UpdateNs.UpdatePeerBlocked.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelUserTyping.Identifier))
                return Tel.UpdateNs.UpdateChannelUserTyping.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePinnedMessages.Identifier))
                return Tel.UpdateNs.UpdatePinnedMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePinnedChannelMessages.Identifier))
                return Tel.UpdateNs.UpdatePinnedChannelMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChat.Identifier))
                return Tel.UpdateNs.UpdateChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateGroupCallParticipants.Identifier))
                return Tel.UpdateNs.UpdateGroupCallParticipants.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateGroupCall.Identifier))
                return Tel.UpdateNs.UpdateGroupCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePeerHistoryTTL.Identifier))
                return Tel.UpdateNs.UpdatePeerHistoryTTL.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChatParticipant.Identifier))
                return Tel.UpdateNs.UpdateChatParticipant.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelParticipant.Identifier))
                return Tel.UpdateNs.UpdateChannelParticipant.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotStopped.Identifier))
                return Tel.UpdateNs.UpdateBotStopped.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateGroupCallConnection.Identifier))
                return Tel.UpdateNs.UpdateGroupCallConnection.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotCommands.Identifier))
                return Tel.UpdateNs.UpdateBotCommands.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePendingJoinRequests.Identifier))
                return Tel.UpdateNs.UpdatePendingJoinRequests.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotChatInviteRequester.Identifier))
                return Tel.UpdateNs.UpdateBotChatInviteRequester.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateMessageReactions.Identifier))
                return Tel.UpdateNs.UpdateMessageReactions.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateAttachMenuBots.Identifier))
                return Tel.UpdateNs.UpdateAttachMenuBots.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateWebViewResultSent.Identifier))
                return Tel.UpdateNs.UpdateWebViewResultSent.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotMenuButton.Identifier))
                return Tel.UpdateNs.UpdateBotMenuButton.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateSavedRingtones.Identifier))
                return Tel.UpdateNs.UpdateSavedRingtones.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateTranscribedAudio.Identifier))
                return Tel.UpdateNs.UpdateTranscribedAudio.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadFeaturedEmojiStickers.Identifier))
                return Tel.UpdateNs.UpdateReadFeaturedEmojiStickers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateUserEmojiStatus.Identifier))
                return Tel.UpdateNs.UpdateUserEmojiStatus.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateRecentEmojiStatuses.Identifier))
                return Tel.UpdateNs.UpdateRecentEmojiStatuses.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateRecentReactions.Identifier))
                return Tel.UpdateNs.UpdateRecentReactions.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateMoveStickerSetToTop.Identifier))
                return Tel.UpdateNs.UpdateMoveStickerSetToTop.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateMessageExtendedMedia.Identifier))
                return Tel.UpdateNs.UpdateMessageExtendedMedia.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelPinnedTopic.Identifier))
                return Tel.UpdateNs.UpdateChannelPinnedTopic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelPinnedTopics.Identifier))
                return Tel.UpdateNs.UpdateChannelPinnedTopics.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateUser.Identifier))
                return Tel.UpdateNs.UpdateUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateAutoSaveSettings.Identifier))
                return Tel.UpdateNs.UpdateAutoSaveSettings.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateStory.Identifier))
                return Tel.UpdateNs.UpdateStory.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateReadStories.Identifier))
                return Tel.UpdateNs.UpdateReadStories.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateStoryID.Identifier))
                return Tel.UpdateNs.UpdateStoryID.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateStoriesStealthMode.Identifier))
                return Tel.UpdateNs.UpdateStoriesStealthMode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateSentStoryReaction.Identifier))
                return Tel.UpdateNs.UpdateSentStoryReaction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotChatBoost.Identifier))
                return Tel.UpdateNs.UpdateBotChatBoost.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateChannelViewForumAsMessages.Identifier))
                return Tel.UpdateNs.UpdateChannelViewForumAsMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePeerWallpaper.Identifier))
                return Tel.UpdateNs.UpdatePeerWallpaper.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotMessageReaction.Identifier))
                return Tel.UpdateNs.UpdateBotMessageReaction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotMessageReactions.Identifier))
                return Tel.UpdateNs.UpdateBotMessageReactions.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateSavedDialogPinned.Identifier))
                return Tel.UpdateNs.UpdateSavedDialogPinned.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdatePinnedSavedDialogs.Identifier))
                return Tel.UpdateNs.UpdatePinnedSavedDialogs.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateSavedReactionTags.Identifier))
                return Tel.UpdateNs.UpdateSavedReactionTags.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateSmsJob.Identifier))
                return Tel.UpdateNs.UpdateSmsJob.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateQuickReplies.Identifier))
                return Tel.UpdateNs.UpdateQuickReplies.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateNewQuickReply.Identifier))
                return Tel.UpdateNs.UpdateNewQuickReply.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDeleteQuickReply.Identifier))
                return Tel.UpdateNs.UpdateDeleteQuickReply.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateQuickReplyMessage.Identifier))
                return Tel.UpdateNs.UpdateQuickReplyMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateDeleteQuickReplyMessages.Identifier))
                return Tel.UpdateNs.UpdateDeleteQuickReplyMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotBusinessConnect.Identifier))
                return Tel.UpdateNs.UpdateBotBusinessConnect.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotNewBusinessMessage.Identifier))
                return Tel.UpdateNs.UpdateBotNewBusinessMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotEditBusinessMessage.Identifier))
                return Tel.UpdateNs.UpdateBotEditBusinessMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBotDeleteBusinessMessage.Identifier))
                return Tel.UpdateNs.UpdateBotDeleteBusinessMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateNewStoryReaction.Identifier))
                return Tel.UpdateNs.UpdateNewStoryReaction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBroadcastRevenueTransactions.Identifier))
                return Tel.UpdateNs.UpdateBroadcastRevenueTransactions.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateStarsBalance.Identifier))
                return Tel.UpdateNs.UpdateStarsBalance.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateBusinessBotCallbackQuery.Identifier))
                return Tel.UpdateNs.UpdateBusinessBotCallbackQuery.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdateNs.UpdateStarsRevenueStatus.Identifier))
                return Tel.UpdateNs.UpdateStarsRevenueStatus.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UpdateNs.UpdateNewMessage UpdateNewMessage522914557 => UpdateNewMessage522914557.TlSerialize(),
            Tel.UpdateNs.UpdateMessageID UpdateMessageID1318109142 => UpdateMessageID1318109142.TlSerialize(),
            Tel.UpdateNs.UpdateDeleteMessages UpdateDeleteMessages1576161051 => UpdateDeleteMessages1576161051.TlSerialize(),
            Tel.UpdateNs.UpdateUserTyping UpdateUserTyping1071741569 => UpdateUserTyping1071741569.TlSerialize(),
            Tel.UpdateNs.UpdateChatUserTyping UpdateChatUserTyping2092401936 => UpdateChatUserTyping2092401936.TlSerialize(),
            Tel.UpdateNs.UpdateChatParticipants UpdateChatParticipants125178264 => UpdateChatParticipants125178264.TlSerialize(),
            Tel.UpdateNs.UpdateUserStatus UpdateUserStatus440534818 => UpdateUserStatus440534818.TlSerialize(),
            Tel.UpdateNs.UpdateUserName UpdateUserName1484486364 => UpdateUserName1484486364.TlSerialize(),
            Tel.UpdateNs.UpdateNewAuthorization UpdateNewAuthorization1991136273 => UpdateNewAuthorization1991136273.TlSerialize(),
            Tel.UpdateNs.UpdateNewEncryptedMessage UpdateNewEncryptedMessage314359194 => UpdateNewEncryptedMessage314359194.TlSerialize(),
            Tel.UpdateNs.UpdateEncryptedChatTyping UpdateEncryptedChatTyping386986326 => UpdateEncryptedChatTyping386986326.TlSerialize(),
            Tel.UpdateNs.UpdateEncryption UpdateEncryption1264392051 => UpdateEncryption1264392051.TlSerialize(),
            Tel.UpdateNs.UpdateEncryptedMessagesRead UpdateEncryptedMessagesRead956179895 => UpdateEncryptedMessagesRead956179895.TlSerialize(),
            Tel.UpdateNs.UpdateChatParticipantAdd UpdateChatParticipantAdd1037718609 => UpdateChatParticipantAdd1037718609.TlSerialize(),
            Tel.UpdateNs.UpdateChatParticipantDelete UpdateChatParticipantDelete483443337 => UpdateChatParticipantDelete483443337.TlSerialize(),
            Tel.UpdateNs.UpdateDcOptions UpdateDcOptions1906403213 => UpdateDcOptions1906403213.TlSerialize(),
            Tel.UpdateNs.UpdateNotifySettings UpdateNotifySettings1094555409 => UpdateNotifySettings1094555409.TlSerialize(),
            Tel.UpdateNs.UpdateServiceNotification UpdateServiceNotification337352679 => UpdateServiceNotification337352679.TlSerialize(),
            Tel.UpdateNs.UpdatePrivacy UpdatePrivacy298113238 => UpdatePrivacy298113238.TlSerialize(),
            Tel.UpdateNs.UpdateUserPhone UpdateUserPhone88680979 => UpdateUserPhone88680979.TlSerialize(),
            Tel.UpdateNs.UpdateReadHistoryInbox UpdateReadHistoryInbox1667805217 => UpdateReadHistoryInbox1667805217.TlSerialize(),
            Tel.UpdateNs.UpdateReadHistoryOutbox UpdateReadHistoryOutbox791617983 => UpdateReadHistoryOutbox791617983.TlSerialize(),
            Tel.UpdateNs.UpdateWebPage UpdateWebPage2139689491 => UpdateWebPage2139689491.TlSerialize(),
            Tel.UpdateNs.UpdateReadMessagesContents UpdateReadMessagesContents131960447 => UpdateReadMessagesContents131960447.TlSerialize(),
            Tel.UpdateNs.UpdateChannelTooLong UpdateChannelTooLong277713951 => UpdateChannelTooLong277713951.TlSerialize(),
            Tel.UpdateNs.UpdateChannel UpdateChannel1666927625 => UpdateChannel1666927625.TlSerialize(),
            Tel.UpdateNs.UpdateNewChannelMessage UpdateNewChannelMessage1656358105 => UpdateNewChannelMessage1656358105.TlSerialize(),
            Tel.UpdateNs.UpdateReadChannelInbox UpdateReadChannelInbox1842450928 => UpdateReadChannelInbox1842450928.TlSerialize(),
            Tel.UpdateNs.UpdateDeleteChannelMessages UpdateDeleteChannelMessages1020437742 => UpdateDeleteChannelMessages1020437742.TlSerialize(),
            Tel.UpdateNs.UpdateChannelMessageViews UpdateChannelMessageViews232346616 => UpdateChannelMessageViews232346616.TlSerialize(),
            Tel.UpdateNs.UpdateChatParticipantAdmin UpdateChatParticipantAdmin674602590 => UpdateChatParticipantAdmin674602590.TlSerialize(),
            Tel.UpdateNs.UpdateNewStickerSet UpdateNewStickerSet1753886890 => UpdateNewStickerSet1753886890.TlSerialize(),
            Tel.UpdateNs.UpdateStickerSetsOrder UpdateStickerSetsOrder196268545 => UpdateStickerSetsOrder196268545.TlSerialize(),
            Tel.UpdateNs.UpdateStickerSets UpdateStickerSets834816008 => UpdateStickerSets834816008.TlSerialize(),
            Tel.UpdateNs.UpdateSavedGifs UpdateSavedGifs1821035490 => UpdateSavedGifs1821035490.TlSerialize(),
            Tel.UpdateNs.UpdateBotInlineQuery UpdateBotInlineQuery1232025500 => UpdateBotInlineQuery1232025500.TlSerialize(),
            Tel.UpdateNs.UpdateBotInlineSend UpdateBotInlineSend317794823 => UpdateBotInlineSend317794823.TlSerialize(),
            Tel.UpdateNs.UpdateEditChannelMessage UpdateEditChannelMessage457133559 => UpdateEditChannelMessage457133559.TlSerialize(),
            Tel.UpdateNs.UpdateBotCallbackQuery UpdateBotCallbackQuery1177566067 => UpdateBotCallbackQuery1177566067.TlSerialize(),
            Tel.UpdateNs.UpdateEditMessage UpdateEditMessage469536605 => UpdateEditMessage469536605.TlSerialize(),
            Tel.UpdateNs.UpdateInlineBotCallbackQuery UpdateInlineBotCallbackQuery1763610706 => UpdateInlineBotCallbackQuery1763610706.TlSerialize(),
            Tel.UpdateNs.UpdateReadChannelOutbox UpdateReadChannelOutbox1218471511 => UpdateReadChannelOutbox1218471511.TlSerialize(),
            Tel.UpdateNs.UpdateDraftMessage UpdateDraftMessage457829485 => UpdateDraftMessage457829485.TlSerialize(),
            Tel.UpdateNs.UpdateReadFeaturedStickers UpdateReadFeaturedStickers1461528386 => UpdateReadFeaturedStickers1461528386.TlSerialize(),
            Tel.UpdateNs.UpdateRecentStickers UpdateRecentStickers1706939360 => UpdateRecentStickers1706939360.TlSerialize(),
            Tel.UpdateNs.UpdateConfig UpdateConfig1574314746 => UpdateConfig1574314746.TlSerialize(),
            Tel.UpdateNs.UpdatePtsChanged UpdatePtsChanged861169551 => UpdatePtsChanged861169551.TlSerialize(),
            Tel.UpdateNs.UpdateChannelWebPage UpdateChannelWebPage791390623 => UpdateChannelWebPage791390623.TlSerialize(),
            Tel.UpdateNs.UpdateDialogPinned UpdateDialogPinned1852826908 => UpdateDialogPinned1852826908.TlSerialize(),
            Tel.UpdateNs.UpdatePinnedDialogs UpdatePinnedDialogs99664734 => UpdatePinnedDialogs99664734.TlSerialize(),
            Tel.UpdateNs.UpdateBotWebhookJSON UpdateBotWebhookJSON2095595325 => UpdateBotWebhookJSON2095595325.TlSerialize(),
            Tel.UpdateNs.UpdateBotWebhookJSONQuery UpdateBotWebhookJSONQuery1684914010 => UpdateBotWebhookJSONQuery1684914010.TlSerialize(),
            Tel.UpdateNs.UpdateBotShippingQuery UpdateBotShippingQuery1246823043 => UpdateBotShippingQuery1246823043.TlSerialize(),
            Tel.UpdateNs.UpdateBotPrecheckoutQuery UpdateBotPrecheckoutQuery1934976362 => UpdateBotPrecheckoutQuery1934976362.TlSerialize(),
            Tel.UpdateNs.UpdatePhoneCall UpdatePhoneCall1425052898 => UpdatePhoneCall1425052898.TlSerialize(),
            Tel.UpdateNs.UpdateLangPackTooLong UpdateLangPackTooLong1180041828 => UpdateLangPackTooLong1180041828.TlSerialize(),
            Tel.UpdateNs.UpdateLangPack UpdateLangPack1442983757 => UpdateLangPack1442983757.TlSerialize(),
            Tel.UpdateNs.UpdateFavedStickers UpdateFavedStickers451831443 => UpdateFavedStickers451831443.TlSerialize(),
            Tel.UpdateNs.UpdateChannelReadMessagesContents UpdateChannelReadMessagesContents366410403 => UpdateChannelReadMessagesContents366410403.TlSerialize(),
            Tel.UpdateNs.UpdateContactsReset UpdateContactsReset1887741886 => UpdateContactsReset1887741886.TlSerialize(),
            Tel.UpdateNs.UpdateChannelAvailableMessages UpdateChannelAvailableMessages1304443240 => UpdateChannelAvailableMessages1304443240.TlSerialize(),
            Tel.UpdateNs.UpdateDialogUnreadMark UpdateDialogUnreadMark513517117 => UpdateDialogUnreadMark513517117.TlSerialize(),
            Tel.UpdateNs.UpdateMessagePoll UpdateMessagePoll1398708869 => UpdateMessagePoll1398708869.TlSerialize(),
            Tel.UpdateNs.UpdateChatDefaultBannedRights UpdateChatDefaultBannedRights1421875280 => UpdateChatDefaultBannedRights1421875280.TlSerialize(),
            Tel.UpdateNs.UpdateFolderPeers UpdateFolderPeers422972864 => UpdateFolderPeers422972864.TlSerialize(),
            Tel.UpdateNs.UpdatePeerSettings UpdatePeerSettings1786671974 => UpdatePeerSettings1786671974.TlSerialize(),
            Tel.UpdateNs.UpdatePeerLocated UpdatePeerLocated1263546448 => UpdatePeerLocated1263546448.TlSerialize(),
            Tel.UpdateNs.UpdateNewScheduledMessage UpdateNewScheduledMessage967122427 => UpdateNewScheduledMessage967122427.TlSerialize(),
            Tel.UpdateNs.UpdateDeleteScheduledMessages UpdateDeleteScheduledMessages1870238482 => UpdateDeleteScheduledMessages1870238482.TlSerialize(),
            Tel.UpdateNs.UpdateTheme UpdateTheme2112423005 => UpdateTheme2112423005.TlSerialize(),
            Tel.UpdateNs.UpdateGeoLiveViewed UpdateGeoLiveViewed2027964103 => UpdateGeoLiveViewed2027964103.TlSerialize(),
            Tel.UpdateNs.UpdateLoginToken UpdateLoginToken1448076945 => UpdateLoginToken1448076945.TlSerialize(),
            Tel.UpdateNs.UpdateMessagePollVote UpdateMessagePollVote619974263 => UpdateMessagePollVote619974263.TlSerialize(),
            Tel.UpdateNs.UpdateDialogFilter UpdateDialogFilter654302845 => UpdateDialogFilter654302845.TlSerialize(),
            Tel.UpdateNs.UpdateDialogFilterOrder UpdateDialogFilterOrder1512627963 => UpdateDialogFilterOrder1512627963.TlSerialize(),
            Tel.UpdateNs.UpdateDialogFilters UpdateDialogFilters889491791 => UpdateDialogFilters889491791.TlSerialize(),
            Tel.UpdateNs.UpdatePhoneCallSignalingData UpdatePhoneCallSignalingData643940105 => UpdatePhoneCallSignalingData643940105.TlSerialize(),
            Tel.UpdateNs.UpdateChannelMessageForwards UpdateChannelMessageForwards761649164 => UpdateChannelMessageForwards761649164.TlSerialize(),
            Tel.UpdateNs.UpdateReadChannelDiscussionInbox UpdateReadChannelDiscussionInbox693004986 => UpdateReadChannelDiscussionInbox693004986.TlSerialize(),
            Tel.UpdateNs.UpdateReadChannelDiscussionOutbox UpdateReadChannelDiscussionOutbox1767677564 => UpdateReadChannelDiscussionOutbox1767677564.TlSerialize(),
            Tel.UpdateNs.UpdatePeerBlocked UpdatePeerBlocked337610926 => UpdatePeerBlocked337610926.TlSerialize(),
            Tel.UpdateNs.UpdateChannelUserTyping UpdateChannelUserTyping1937192669 => UpdateChannelUserTyping1937192669.TlSerialize(),
            Tel.UpdateNs.UpdatePinnedMessages UpdatePinnedMessages309990731 => UpdatePinnedMessages309990731.TlSerialize(),
            Tel.UpdateNs.UpdatePinnedChannelMessages UpdatePinnedChannelMessages1538885128 => UpdatePinnedChannelMessages1538885128.TlSerialize(),
            Tel.UpdateNs.UpdateChat UpdateChat124097970 => UpdateChat124097970.TlSerialize(),
            Tel.UpdateNs.UpdateGroupCallParticipants UpdateGroupCallParticipants219423922 => UpdateGroupCallParticipants219423922.TlSerialize(),
            Tel.UpdateNs.UpdateGroupCall UpdateGroupCall347227392 => UpdateGroupCall347227392.TlSerialize(),
            Tel.UpdateNs.UpdatePeerHistoryTTL UpdatePeerHistoryTTL1147422299 => UpdatePeerHistoryTTL1147422299.TlSerialize(),
            Tel.UpdateNs.UpdateChatParticipant UpdateChatParticipant796432838 => UpdateChatParticipant796432838.TlSerialize(),
            Tel.UpdateNs.UpdateChannelParticipant UpdateChannelParticipant1738720581 => UpdateChannelParticipant1738720581.TlSerialize(),
            Tel.UpdateNs.UpdateBotStopped UpdateBotStopped997782967 => UpdateBotStopped997782967.TlSerialize(),
            Tel.UpdateNs.UpdateGroupCallConnection UpdateGroupCallConnection192428418 => UpdateGroupCallConnection192428418.TlSerialize(),
            Tel.UpdateNs.UpdateBotCommands UpdateBotCommands1299263278 => UpdateBotCommands1299263278.TlSerialize(),
            Tel.UpdateNs.UpdatePendingJoinRequests UpdatePendingJoinRequests1885586395 => UpdatePendingJoinRequests1885586395.TlSerialize(),
            Tel.UpdateNs.UpdateBotChatInviteRequester UpdateBotChatInviteRequester299870598 => UpdateBotChatInviteRequester299870598.TlSerialize(),
            Tel.UpdateNs.UpdateMessageReactions UpdateMessageReactions1578843320 => UpdateMessageReactions1578843320.TlSerialize(),
            Tel.UpdateNs.UpdateAttachMenuBots UpdateAttachMenuBots397910539 => UpdateAttachMenuBots397910539.TlSerialize(),
            Tel.UpdateNs.UpdateWebViewResultSent UpdateWebViewResultSent361936797 => UpdateWebViewResultSent361936797.TlSerialize(),
            Tel.UpdateNs.UpdateBotMenuButton UpdateBotMenuButton347625491 => UpdateBotMenuButton347625491.TlSerialize(),
            Tel.UpdateNs.UpdateSavedRingtones UpdateSavedRingtones1960361625 => UpdateSavedRingtones1960361625.TlSerialize(),
            Tel.UpdateNs.UpdateTranscribedAudio UpdateTranscribedAudio8703322 => UpdateTranscribedAudio8703322.TlSerialize(),
            Tel.UpdateNs.UpdateReadFeaturedEmojiStickers UpdateReadFeaturedEmojiStickers78886548 => UpdateReadFeaturedEmojiStickers78886548.TlSerialize(),
            Tel.UpdateNs.UpdateUserEmojiStatus UpdateUserEmojiStatus674706841 => UpdateUserEmojiStatus674706841.TlSerialize(),
            Tel.UpdateNs.UpdateRecentEmojiStatuses UpdateRecentEmojiStatuses821314523 => UpdateRecentEmojiStatuses821314523.TlSerialize(),
            Tel.UpdateNs.UpdateRecentReactions UpdateRecentReactions1870160884 => UpdateRecentReactions1870160884.TlSerialize(),
            Tel.UpdateNs.UpdateMoveStickerSetToTop UpdateMoveStickerSetToTop2030252155 => UpdateMoveStickerSetToTop2030252155.TlSerialize(),
            Tel.UpdateNs.UpdateMessageExtendedMedia UpdateMessageExtendedMedia710666460 => UpdateMessageExtendedMedia710666460.TlSerialize(),
            Tel.UpdateNs.UpdateChannelPinnedTopic UpdateChannelPinnedTopic422509539 => UpdateChannelPinnedTopic422509539.TlSerialize(),
            Tel.UpdateNs.UpdateChannelPinnedTopics UpdateChannelPinnedTopics31881726 => UpdateChannelPinnedTopics31881726.TlSerialize(),
            Tel.UpdateNs.UpdateUser UpdateUser542282808 => UpdateUser542282808.TlSerialize(),
            Tel.UpdateNs.UpdateAutoSaveSettings UpdateAutoSaveSettings335171433 => UpdateAutoSaveSettings335171433.TlSerialize(),
            Tel.UpdateNs.UpdateStory UpdateStory1974712216 => UpdateStory1974712216.TlSerialize(),
            Tel.UpdateNs.UpdateReadStories UpdateReadStories145845461 => UpdateReadStories145845461.TlSerialize(),
            Tel.UpdateNs.UpdateStoryID UpdateStoryID468923833 => UpdateStoryID468923833.TlSerialize(),
            Tel.UpdateNs.UpdateStoriesStealthMode UpdateStoriesStealthMode738741697 => UpdateStoriesStealthMode738741697.TlSerialize(),
            Tel.UpdateNs.UpdateSentStoryReaction UpdateSentStoryReaction2103604867 => UpdateSentStoryReaction2103604867.TlSerialize(),
            Tel.UpdateNs.UpdateBotChatBoost UpdateBotChatBoost1873947492 => UpdateBotChatBoost1873947492.TlSerialize(),
            Tel.UpdateNs.UpdateChannelViewForumAsMessages UpdateChannelViewForumAsMessages129403168 => UpdateChannelViewForumAsMessages129403168.TlSerialize(),
            Tel.UpdateNs.UpdatePeerWallpaper UpdatePeerWallpaper1371598819 => UpdatePeerWallpaper1371598819.TlSerialize(),
            Tel.UpdateNs.UpdateBotMessageReaction UpdateBotMessageReaction1407069234 => UpdateBotMessageReaction1407069234.TlSerialize(),
            Tel.UpdateNs.UpdateBotMessageReactions UpdateBotMessageReactions164329305 => UpdateBotMessageReactions164329305.TlSerialize(),
            Tel.UpdateNs.UpdateSavedDialogPinned UpdateSavedDialogPinned1364222348 => UpdateSavedDialogPinned1364222348.TlSerialize(),
            Tel.UpdateNs.UpdatePinnedSavedDialogs UpdatePinnedSavedDialogs1751942566 => UpdatePinnedSavedDialogs1751942566.TlSerialize(),
            Tel.UpdateNs.UpdateSavedReactionTags UpdateSavedReactionTags969307186 => UpdateSavedReactionTags969307186.TlSerialize(),
            Tel.UpdateNs.UpdateSmsJob UpdateSmsJob245208620 => UpdateSmsJob245208620.TlSerialize(),
            Tel.UpdateNs.UpdateQuickReplies UpdateQuickReplies112784718 => UpdateQuickReplies112784718.TlSerialize(),
            Tel.UpdateNs.UpdateNewQuickReply UpdateNewQuickReply180508905 => UpdateNewQuickReply180508905.TlSerialize(),
            Tel.UpdateNs.UpdateDeleteQuickReply UpdateDeleteQuickReply1407644140 => UpdateDeleteQuickReply1407644140.TlSerialize(),
            Tel.UpdateNs.UpdateQuickReplyMessage UpdateQuickReplyMessage1040518415 => UpdateQuickReplyMessage1040518415.TlSerialize(),
            Tel.UpdateNs.UpdateDeleteQuickReplyMessages UpdateDeleteQuickReplyMessages1450174413 => UpdateDeleteQuickReplyMessages1450174413.TlSerialize(),
            Tel.UpdateNs.UpdateBotBusinessConnect UpdateBotBusinessConnect1964652166 => UpdateBotBusinessConnect1964652166.TlSerialize(),
            Tel.UpdateNs.UpdateBotNewBusinessMessage UpdateBotNewBusinessMessage1646578564 => UpdateBotNewBusinessMessage1646578564.TlSerialize(),
            Tel.UpdateNs.UpdateBotEditBusinessMessage UpdateBotEditBusinessMessage132077692 => UpdateBotEditBusinessMessage132077692.TlSerialize(),
            Tel.UpdateNs.UpdateBotDeleteBusinessMessage UpdateBotDeleteBusinessMessage1607821266 => UpdateBotDeleteBusinessMessage1607821266.TlSerialize(),
            Tel.UpdateNs.UpdateNewStoryReaction UpdateNewStoryReaction405070859 => UpdateNewStoryReaction405070859.TlSerialize(),
            Tel.UpdateNs.UpdateBroadcastRevenueTransactions UpdateBroadcastRevenueTransactions539401739 => UpdateBroadcastRevenueTransactions539401739.TlSerialize(),
            Tel.UpdateNs.UpdateStarsBalance UpdateStarsBalance263737752 => UpdateStarsBalance263737752.TlSerialize(),
            Tel.UpdateNs.UpdateBusinessBotCallbackQuery UpdateBusinessBotCallbackQuery513998247 => UpdateBusinessBotCallbackQuery513998247.TlSerialize(),
            Tel.UpdateNs.UpdateStarsRevenueStatus UpdateStarsRevenueStatus1518030823 => UpdateStarsRevenueStatus1518030823.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UpdatesState,
    public abstract class UpdatesStateBase : ITlSerializable, ITlDeserializable<UpdatesStateBase> {
        public static UpdatesStateBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UpdatesStateNs.UpdatesState.Identifier))
                return Tel.UpdatesStateNs.UpdatesState.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UpdatesStateNs.UpdatesState UpdatesState1519637954 => UpdatesState1519637954.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UpdatesDifferenceEmpty, UpdatesDifference, UpdatesDifferenceSlice, UpdatesDifferenceTooLong,
    public abstract class UpdatesDifferenceBase : ITlSerializable, ITlDeserializable<UpdatesDifferenceBase> {
        public static UpdatesDifferenceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UpdatesDifferenceNs.UpdatesDifferenceEmpty.Identifier))
                return Tel.UpdatesDifferenceNs.UpdatesDifferenceEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesDifferenceNs.UpdatesDifference.Identifier))
                return Tel.UpdatesDifferenceNs.UpdatesDifference.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesDifferenceNs.UpdatesDifferenceSlice.Identifier))
                return Tel.UpdatesDifferenceNs.UpdatesDifferenceSlice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesDifferenceNs.UpdatesDifferenceTooLong.Identifier))
                return Tel.UpdatesDifferenceNs.UpdatesDifferenceTooLong.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UpdatesDifferenceNs.UpdatesDifferenceEmpty UpdatesDifferenceEmpty1567990072 => UpdatesDifferenceEmpty1567990072.TlSerialize(),
            Tel.UpdatesDifferenceNs.UpdatesDifference UpdatesDifference16030880 => UpdatesDifference16030880.TlSerialize(),
            Tel.UpdatesDifferenceNs.UpdatesDifferenceSlice UpdatesDifferenceSlice1459938943 => UpdatesDifferenceSlice1459938943.TlSerialize(),
            Tel.UpdatesDifferenceNs.UpdatesDifferenceTooLong UpdatesDifferenceTooLong1258196845 => UpdatesDifferenceTooLong1258196845.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UpdatesTooLong, UpdateShortMessage, UpdateShortChatMessage, UpdateShort, UpdatesCombined, Updates, UpdateShortSentMessage,
    public abstract class UpdatesBase : ITlSerializable, ITlDeserializable<UpdatesBase> {
        public static UpdatesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UpdatesNs.UpdatesTooLong.Identifier))
                return Tel.UpdatesNs.UpdatesTooLong.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesNs.UpdateShortMessage.Identifier))
                return Tel.UpdatesNs.UpdateShortMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesNs.UpdateShortChatMessage.Identifier))
                return Tel.UpdatesNs.UpdateShortChatMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesNs.UpdateShort.Identifier))
                return Tel.UpdatesNs.UpdateShort.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesNs.UpdatesCombined.Identifier))
                return Tel.UpdatesNs.UpdatesCombined.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesNs.Updates.Identifier))
                return Tel.UpdatesNs.Updates.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesNs.UpdateShortSentMessage.Identifier))
                return Tel.UpdatesNs.UpdateShortSentMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UpdatesNs.UpdatesTooLong UpdatesTooLong484987010 => UpdatesTooLong484987010.TlSerialize(),
            Tel.UpdatesNs.UpdateShortMessage UpdateShortMessage826001400 => UpdateShortMessage826001400.TlSerialize(),
            Tel.UpdatesNs.UpdateShortChatMessage UpdateShortChatMessage1299050149 => UpdateShortChatMessage1299050149.TlSerialize(),
            Tel.UpdatesNs.UpdateShort UpdateShort2027216577 => UpdateShort2027216577.TlSerialize(),
            Tel.UpdatesNs.UpdatesCombined UpdatesCombined1918567619 => UpdatesCombined1918567619.TlSerialize(),
            Tel.UpdatesNs.Updates Updates1957577280 => Updates1957577280.TlSerialize(),
            Tel.UpdatesNs.UpdateShortSentMessage UpdateShortSentMessage1877614335 => UpdateShortSentMessage1877614335.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhotosPhotos, PhotosPhotosSlice,
    public abstract class PhotosPhotosBase : ITlSerializable, ITlDeserializable<PhotosPhotosBase> {
        public List<PhotoBase> Photos {get;set;} = default!;
        public List<UserBase> Users {get;set;} = default!;
        public static PhotosPhotosBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhotosPhotosNs.PhotosPhotos.Identifier))
                return Tel.PhotosPhotosNs.PhotosPhotos.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhotosPhotosNs.PhotosPhotosSlice.Identifier))
                return Tel.PhotosPhotosNs.PhotosPhotosSlice.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhotosPhotosNs.PhotosPhotos PhotosPhotos1916114267 => PhotosPhotos1916114267.TlSerialize(),
            Tel.PhotosPhotosNs.PhotosPhotosSlice PhotosPhotosSlice352657236 => PhotosPhotosSlice352657236.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhotosPhoto,
    public abstract class PhotosPhotoBase : ITlSerializable, ITlDeserializable<PhotosPhotoBase> {
        public static PhotosPhotoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhotosPhotoNs.PhotosPhoto.Identifier))
                return Tel.PhotosPhotoNs.PhotosPhoto.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhotosPhotoNs.PhotosPhoto PhotosPhoto539045032 => PhotosPhoto539045032.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UploadFile, UploadFileCdnRedirect,
    public abstract class UploadFileBase : ITlSerializable, ITlDeserializable<UploadFileBase> {
        public static UploadFileBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UploadFileNs.UploadFile.Identifier))
                return Tel.UploadFileNs.UploadFile.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UploadFileNs.UploadFileCdnRedirect.Identifier))
                return Tel.UploadFileNs.UploadFileCdnRedirect.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UploadFileNs.UploadFile UploadFile157948117 => UploadFile157948117.TlSerialize(),
            Tel.UploadFileNs.UploadFileCdnRedirect UploadFileCdnRedirect242427324 => UploadFileCdnRedirect242427324.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DcOption,
    public abstract class DcOptionBase : ITlSerializable, ITlDeserializable<DcOptionBase> {
        public static DcOptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DcOptionNs.DcOption.Identifier))
                return Tel.DcOptionNs.DcOption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DcOptionNs.DcOption DcOption414687501 => DcOption414687501.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Config,
    public abstract class ConfigBase : ITlSerializable, ITlDeserializable<ConfigBase> {
        public static ConfigBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ConfigNs.Config.Identifier))
                return Tel.ConfigNs.Config.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ConfigNs.Config Config870702050 => Config870702050.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: NearestDc,
    public abstract class NearestDcBase : ITlSerializable, ITlDeserializable<NearestDcBase> {
        public static NearestDcBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.NearestDcNs.NearestDc.Identifier))
                return Tel.NearestDcNs.NearestDc.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.NearestDcNs.NearestDc NearestDc1910892683 => NearestDc1910892683.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpAppUpdate, HelpNoAppUpdate,
    public abstract class HelpAppUpdateBase : ITlSerializable, ITlDeserializable<HelpAppUpdateBase> {
        public static HelpAppUpdateBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpAppUpdateNs.HelpAppUpdate.Identifier))
                return Tel.HelpAppUpdateNs.HelpAppUpdate.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpAppUpdateNs.HelpNoAppUpdate.Identifier))
                return Tel.HelpAppUpdateNs.HelpNoAppUpdate.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpAppUpdateNs.HelpAppUpdate HelpAppUpdate860107216 => HelpAppUpdate860107216.TlSerialize(),
            Tel.HelpAppUpdateNs.HelpNoAppUpdate HelpNoAppUpdate1000708810 => HelpNoAppUpdate1000708810.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpInviteText,
    public abstract class HelpInviteTextBase : ITlSerializable, ITlDeserializable<HelpInviteTextBase> {
        public static HelpInviteTextBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpInviteTextNs.HelpInviteText.Identifier))
                return Tel.HelpInviteTextNs.HelpInviteText.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpInviteTextNs.HelpInviteText HelpInviteText415997816 => HelpInviteText415997816.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EncryptedChatEmpty, EncryptedChatWaiting, EncryptedChatRequested, EncryptedChat, EncryptedChatDiscarded,
    public abstract class EncryptedChatBase : ITlSerializable, ITlDeserializable<EncryptedChatBase> {
        public int Id {get;set;} = default!;
        public static EncryptedChatBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EncryptedChatNs.EncryptedChatEmpty.Identifier))
                return Tel.EncryptedChatNs.EncryptedChatEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EncryptedChatNs.EncryptedChatWaiting.Identifier))
                return Tel.EncryptedChatNs.EncryptedChatWaiting.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EncryptedChatNs.EncryptedChatRequested.Identifier))
                return Tel.EncryptedChatNs.EncryptedChatRequested.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EncryptedChatNs.EncryptedChat.Identifier))
                return Tel.EncryptedChatNs.EncryptedChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EncryptedChatNs.EncryptedChatDiscarded.Identifier))
                return Tel.EncryptedChatNs.EncryptedChatDiscarded.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EncryptedChatNs.EncryptedChatEmpty EncryptedChatEmpty1417756512 => EncryptedChatEmpty1417756512.TlSerialize(),
            Tel.EncryptedChatNs.EncryptedChatWaiting EncryptedChatWaiting1722964307 => EncryptedChatWaiting1722964307.TlSerialize(),
            Tel.EncryptedChatNs.EncryptedChatRequested EncryptedChatRequested1223809356 => EncryptedChatRequested1223809356.TlSerialize(),
            Tel.EncryptedChatNs.EncryptedChat EncryptedChat1643173063 => EncryptedChat1643173063.TlSerialize(),
            Tel.EncryptedChatNs.EncryptedChatDiscarded EncryptedChatDiscarded505183301 => EncryptedChatDiscarded505183301.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputEncryptedChat,
    public abstract class InputEncryptedChatBase : ITlSerializable, ITlDeserializable<InputEncryptedChatBase> {
        public static InputEncryptedChatBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputEncryptedChatNs.InputEncryptedChat.Identifier))
                return Tel.InputEncryptedChatNs.InputEncryptedChat.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputEncryptedChatNs.InputEncryptedChat InputEncryptedChat247351839 => InputEncryptedChat247351839.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EncryptedFileEmpty, EncryptedFile,
    public abstract class EncryptedFileBase : ITlSerializable, ITlDeserializable<EncryptedFileBase> {
        public static EncryptedFileBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EncryptedFileNs.EncryptedFileEmpty.Identifier))
                return Tel.EncryptedFileNs.EncryptedFileEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EncryptedFileNs.EncryptedFile.Identifier))
                return Tel.EncryptedFileNs.EncryptedFile.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EncryptedFileNs.EncryptedFileEmpty EncryptedFileEmpty1038136962 => EncryptedFileEmpty1038136962.TlSerialize(),
            Tel.EncryptedFileNs.EncryptedFile EncryptedFile1476358952 => EncryptedFile1476358952.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputEncryptedFileEmpty, InputEncryptedFileUploaded, InputEncryptedFile, InputEncryptedFileBigUploaded,
    public abstract class InputEncryptedFileBase : ITlSerializable, ITlDeserializable<InputEncryptedFileBase> {
        public static InputEncryptedFileBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputEncryptedFileNs.InputEncryptedFileEmpty.Identifier))
                return Tel.InputEncryptedFileNs.InputEncryptedFileEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputEncryptedFileNs.InputEncryptedFileUploaded.Identifier))
                return Tel.InputEncryptedFileNs.InputEncryptedFileUploaded.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputEncryptedFileNs.InputEncryptedFile.Identifier))
                return Tel.InputEncryptedFileNs.InputEncryptedFile.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputEncryptedFileNs.InputEncryptedFileBigUploaded.Identifier))
                return Tel.InputEncryptedFileNs.InputEncryptedFileBigUploaded.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputEncryptedFileNs.InputEncryptedFileEmpty InputEncryptedFileEmpty406307684 => InputEncryptedFileEmpty406307684.TlSerialize(),
            Tel.InputEncryptedFileNs.InputEncryptedFileUploaded InputEncryptedFileUploaded1690108678 => InputEncryptedFileUploaded1690108678.TlSerialize(),
            Tel.InputEncryptedFileNs.InputEncryptedFile InputEncryptedFile1511503333 => InputEncryptedFile1511503333.TlSerialize(),
            Tel.InputEncryptedFileNs.InputEncryptedFileBigUploaded InputEncryptedFileBigUploaded767652808 => InputEncryptedFileBigUploaded767652808.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EncryptedMessage, EncryptedMessageService,
    public abstract class EncryptedMessageBase : ITlSerializable, ITlDeserializable<EncryptedMessageBase> {
        public long RandomId {get;set;} = default!;
        public int ChatId {get;set;} = default!;
        public int Date {get;set;} = default!;
        public byte[] Bytes {get;set;} = default!;
        public static EncryptedMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EncryptedMessageNs.EncryptedMessage.Identifier))
                return Tel.EncryptedMessageNs.EncryptedMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EncryptedMessageNs.EncryptedMessageService.Identifier))
                return Tel.EncryptedMessageNs.EncryptedMessageService.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EncryptedMessageNs.EncryptedMessage EncryptedMessage317144808 => EncryptedMessage317144808.TlSerialize(),
            Tel.EncryptedMessageNs.EncryptedMessageService EncryptedMessageService594758406 => EncryptedMessageService594758406.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesDhConfigNotModified, MessagesDhConfig,
    public abstract class MessagesDhConfigBase : ITlSerializable, ITlDeserializable<MessagesDhConfigBase> {
        public byte[] Random {get;set;} = default!;
        public static MessagesDhConfigBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesDhConfigNs.MessagesDhConfigNotModified.Identifier))
                return Tel.MessagesDhConfigNs.MessagesDhConfigNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesDhConfigNs.MessagesDhConfig.Identifier))
                return Tel.MessagesDhConfigNs.MessagesDhConfig.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesDhConfigNs.MessagesDhConfigNotModified MessagesDhConfigNotModified1058912715 => MessagesDhConfigNotModified1058912715.TlSerialize(),
            Tel.MessagesDhConfigNs.MessagesDhConfig MessagesDhConfig740433629 => MessagesDhConfig740433629.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesSentEncryptedMessage, MessagesSentEncryptedFile,
    public abstract class MessagesSentEncryptedMessageBase : ITlSerializable, ITlDeserializable<MessagesSentEncryptedMessageBase> {
        public int Date {get;set;} = default!;
        public static MessagesSentEncryptedMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesSentEncryptedMessageNs.MessagesSentEncryptedMessage.Identifier))
                return Tel.MessagesSentEncryptedMessageNs.MessagesSentEncryptedMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesSentEncryptedMessageNs.MessagesSentEncryptedFile.Identifier))
                return Tel.MessagesSentEncryptedMessageNs.MessagesSentEncryptedFile.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesSentEncryptedMessageNs.MessagesSentEncryptedMessage MessagesSentEncryptedMessage1443858741 => MessagesSentEncryptedMessage1443858741.TlSerialize(),
            Tel.MessagesSentEncryptedMessageNs.MessagesSentEncryptedFile MessagesSentEncryptedFile1802240206 => MessagesSentEncryptedFile1802240206.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputDocumentEmpty, InputDocument,
    public abstract class InputDocumentBase : ITlSerializable, ITlDeserializable<InputDocumentBase> {
        public static InputDocumentBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputDocumentNs.InputDocumentEmpty.Identifier))
                return Tel.InputDocumentNs.InputDocumentEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputDocumentNs.InputDocument.Identifier))
                return Tel.InputDocumentNs.InputDocument.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputDocumentNs.InputDocumentEmpty InputDocumentEmpty1928391342 => InputDocumentEmpty1928391342.TlSerialize(),
            Tel.InputDocumentNs.InputDocument InputDocument448771445 => InputDocument448771445.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DocumentEmpty, Document,
    public abstract class DocumentBase : ITlSerializable, ITlDeserializable<DocumentBase> {
        public long Id {get;set;} = default!;
        public static DocumentBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DocumentNs.DocumentEmpty.Identifier))
                return Tel.DocumentNs.DocumentEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DocumentNs.Document.Identifier))
                return Tel.DocumentNs.Document.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DocumentNs.DocumentEmpty DocumentEmpty922273905 => DocumentEmpty922273905.TlSerialize(),
            Tel.DocumentNs.Document Document1881881384 => Document1881881384.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpSupport,
    public abstract class HelpSupportBase : ITlSerializable, ITlDeserializable<HelpSupportBase> {
        public static HelpSupportBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpSupportNs.HelpSupport.Identifier))
                return Tel.HelpSupportNs.HelpSupport.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpSupportNs.HelpSupport HelpSupport398898678 => HelpSupport398898678.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: NotifyPeer, NotifyUsers, NotifyChats, NotifyBroadcasts, NotifyForumTopic,
    public abstract class NotifyPeerBase : ITlSerializable, ITlDeserializable<NotifyPeerBase> {
        public static NotifyPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.NotifyPeerNs.NotifyPeer.Identifier))
                return Tel.NotifyPeerNs.NotifyPeer.TlDeserialize(des);
            if (id.SequenceEqual(Tel.NotifyPeerNs.NotifyUsers.Identifier))
                return Tel.NotifyPeerNs.NotifyUsers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.NotifyPeerNs.NotifyChats.Identifier))
                return Tel.NotifyPeerNs.NotifyChats.TlDeserialize(des);
            if (id.SequenceEqual(Tel.NotifyPeerNs.NotifyBroadcasts.Identifier))
                return Tel.NotifyPeerNs.NotifyBroadcasts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.NotifyPeerNs.NotifyForumTopic.Identifier))
                return Tel.NotifyPeerNs.NotifyForumTopic.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.NotifyPeerNs.NotifyPeer NotifyPeer1613493288 => NotifyPeer1613493288.TlSerialize(),
            Tel.NotifyPeerNs.NotifyUsers NotifyUsers1261946036 => NotifyUsers1261946036.TlSerialize(),
            Tel.NotifyPeerNs.NotifyChats NotifyChats1073230141 => NotifyChats1073230141.TlSerialize(),
            Tel.NotifyPeerNs.NotifyBroadcasts NotifyBroadcasts703403793 => NotifyBroadcasts703403793.TlSerialize(),
            Tel.NotifyPeerNs.NotifyForumTopic NotifyForumTopic577659656 => NotifyForumTopic577659656.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SendMessageTypingAction, SendMessageCancelAction, SendMessageRecordVideoAction, SendMessageUploadVideoAction, SendMessageRecordAudioAction, SendMessageUploadAudioAction, SendMessageUploadPhotoAction, SendMessageUploadDocumentAction, SendMessageGeoLocationAction, SendMessageChooseContactAction, SendMessageGamePlayAction, SendMessageRecordRoundAction, SendMessageUploadRoundAction, SpeakingInGroupCallAction, SendMessageHistoryImportAction, SendMessageChooseStickerAction, SendMessageEmojiInteraction, SendMessageEmojiInteractionSeen,
    public abstract class SendMessageActionBase : ITlSerializable, ITlDeserializable<SendMessageActionBase> {
        public static SendMessageActionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageTypingAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageTypingAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageCancelAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageCancelAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageRecordVideoAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageRecordVideoAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageUploadVideoAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageUploadVideoAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageRecordAudioAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageRecordAudioAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageUploadAudioAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageUploadAudioAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageUploadPhotoAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageUploadPhotoAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageUploadDocumentAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageUploadDocumentAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageGeoLocationAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageGeoLocationAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageChooseContactAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageChooseContactAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageGamePlayAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageGamePlayAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageRecordRoundAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageRecordRoundAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageUploadRoundAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageUploadRoundAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SpeakingInGroupCallAction.Identifier))
                return Tel.SendMessageActionNs.SpeakingInGroupCallAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageHistoryImportAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageHistoryImportAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageChooseStickerAction.Identifier))
                return Tel.SendMessageActionNs.SendMessageChooseStickerAction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageEmojiInteraction.Identifier))
                return Tel.SendMessageActionNs.SendMessageEmojiInteraction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SendMessageActionNs.SendMessageEmojiInteractionSeen.Identifier))
                return Tel.SendMessageActionNs.SendMessageEmojiInteractionSeen.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SendMessageActionNs.SendMessageTypingAction SendMessageTypingAction381645902 => SendMessageTypingAction381645902.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageCancelAction SendMessageCancelAction44119819 => SendMessageCancelAction44119819.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageRecordVideoAction SendMessageRecordVideoAction1584933265 => SendMessageRecordVideoAction1584933265.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageUploadVideoAction SendMessageUploadVideoAction378127636 => SendMessageUploadVideoAction378127636.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageRecordAudioAction SendMessageRecordAudioAction718310409 => SendMessageRecordAudioAction718310409.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageUploadAudioAction SendMessageUploadAudioAction212740181 => SendMessageUploadAudioAction212740181.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageUploadPhotoAction SendMessageUploadPhotoAction774682074 => SendMessageUploadPhotoAction774682074.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageUploadDocumentAction SendMessageUploadDocumentAction1441998364 => SendMessageUploadDocumentAction1441998364.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageGeoLocationAction SendMessageGeoLocationAction393186209 => SendMessageGeoLocationAction393186209.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageChooseContactAction SendMessageChooseContactAction1653390447 => SendMessageChooseContactAction1653390447.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageGamePlayAction SendMessageGamePlayAction580219064 => SendMessageGamePlayAction580219064.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageRecordRoundAction SendMessageRecordRoundAction1997373508 => SendMessageRecordRoundAction1997373508.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageUploadRoundAction SendMessageUploadRoundAction608050278 => SendMessageUploadRoundAction608050278.TlSerialize(),
            Tel.SendMessageActionNs.SpeakingInGroupCallAction SpeakingInGroupCallAction651419003 => SpeakingInGroupCallAction651419003.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageHistoryImportAction SendMessageHistoryImportAction606432698 => SendMessageHistoryImportAction606432698.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageChooseStickerAction SendMessageChooseStickerAction1336228175 => SendMessageChooseStickerAction1336228175.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageEmojiInteraction SendMessageEmojiInteraction630664139 => SendMessageEmojiInteraction630664139.TlSerialize(),
            Tel.SendMessageActionNs.SendMessageEmojiInteractionSeen SendMessageEmojiInteractionSeen1234857938 => SendMessageEmojiInteractionSeen1234857938.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactsFound,
    public abstract class ContactsFoundBase : ITlSerializable, ITlDeserializable<ContactsFoundBase> {
        public static ContactsFoundBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactsFoundNs.ContactsFound.Identifier))
                return Tel.ContactsFoundNs.ContactsFound.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactsFoundNs.ContactsFound ContactsFound1290580579 => ContactsFound1290580579.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputPrivacyKeyStatusTimestamp, InputPrivacyKeyChatInvite, InputPrivacyKeyPhoneCall, InputPrivacyKeyPhoneP2P, InputPrivacyKeyForwards, InputPrivacyKeyProfilePhoto, InputPrivacyKeyPhoneNumber, InputPrivacyKeyAddedByPhone, InputPrivacyKeyVoiceMessages, InputPrivacyKeyAbout, InputPrivacyKeyBirthday,
    public abstract class InputPrivacyKeyBase : ITlSerializable, ITlDeserializable<InputPrivacyKeyBase> {
        public static InputPrivacyKeyBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyStatusTimestamp.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyStatusTimestamp.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyChatInvite.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyChatInvite.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneCall.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneP2P.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneP2P.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyForwards.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyForwards.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyProfilePhoto.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyProfilePhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneNumber.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneNumber.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyAddedByPhone.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyAddedByPhone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyVoiceMessages.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyVoiceMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyAbout.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyAbout.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyKeyNs.InputPrivacyKeyBirthday.Identifier))
                return Tel.InputPrivacyKeyNs.InputPrivacyKeyBirthday.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputPrivacyKeyNs.InputPrivacyKeyStatusTimestamp InputPrivacyKeyStatusTimestamp1335282456 => InputPrivacyKeyStatusTimestamp1335282456.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyChatInvite InputPrivacyKeyChatInvite1107622874 => InputPrivacyKeyChatInvite1107622874.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneCall InputPrivacyKeyPhoneCall88417185 => InputPrivacyKeyPhoneCall88417185.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneP2P InputPrivacyKeyPhoneP2P610373422 => InputPrivacyKeyPhoneP2P610373422.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyForwards InputPrivacyKeyForwards1529000952 => InputPrivacyKeyForwards1529000952.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyProfilePhoto InputPrivacyKeyProfilePhoto1461304012 => InputPrivacyKeyProfilePhoto1461304012.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyPhoneNumber InputPrivacyKeyPhoneNumber55761658 => InputPrivacyKeyPhoneNumber55761658.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyAddedByPhone InputPrivacyKeyAddedByPhone786326563 => InputPrivacyKeyAddedByPhone786326563.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyVoiceMessages InputPrivacyKeyVoiceMessages1360618136 => InputPrivacyKeyVoiceMessages1360618136.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyAbout InputPrivacyKeyAbout941870144 => InputPrivacyKeyAbout941870144.TlSerialize(),
            Tel.InputPrivacyKeyNs.InputPrivacyKeyBirthday InputPrivacyKeyBirthday698740276 => InputPrivacyKeyBirthday698740276.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PrivacyKeyStatusTimestamp, PrivacyKeyChatInvite, PrivacyKeyPhoneCall, PrivacyKeyPhoneP2P, PrivacyKeyForwards, PrivacyKeyProfilePhoto, PrivacyKeyPhoneNumber, PrivacyKeyAddedByPhone, PrivacyKeyVoiceMessages, PrivacyKeyAbout, PrivacyKeyBirthday,
    public abstract class PrivacyKeyBase : ITlSerializable, ITlDeserializable<PrivacyKeyBase> {
        public static PrivacyKeyBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyStatusTimestamp.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyStatusTimestamp.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyChatInvite.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyChatInvite.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyPhoneCall.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyPhoneCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyPhoneP2P.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyPhoneP2P.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyForwards.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyForwards.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyProfilePhoto.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyProfilePhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyPhoneNumber.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyPhoneNumber.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyAddedByPhone.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyAddedByPhone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyVoiceMessages.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyVoiceMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyAbout.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyAbout.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyKeyNs.PrivacyKeyBirthday.Identifier))
                return Tel.PrivacyKeyNs.PrivacyKeyBirthday.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PrivacyKeyNs.PrivacyKeyStatusTimestamp PrivacyKeyStatusTimestamp1137792208 => PrivacyKeyStatusTimestamp1137792208.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyChatInvite PrivacyKeyChatInvite1343122938 => PrivacyKeyChatInvite1343122938.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyPhoneCall PrivacyKeyPhoneCall1030105979 => PrivacyKeyPhoneCall1030105979.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyPhoneP2P PrivacyKeyPhoneP2P961092808 => PrivacyKeyPhoneP2P961092808.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyForwards PrivacyKeyForwards1777096355 => PrivacyKeyForwards1777096355.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyProfilePhoto PrivacyKeyProfilePhoto1777000467 => PrivacyKeyProfilePhoto1777000467.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyPhoneNumber PrivacyKeyPhoneNumber778378131 => PrivacyKeyPhoneNumber778378131.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyAddedByPhone PrivacyKeyAddedByPhone1124062251 => PrivacyKeyAddedByPhone1124062251.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyVoiceMessages PrivacyKeyVoiceMessages110621716 => PrivacyKeyVoiceMessages110621716.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyAbout PrivacyKeyAbout1534675103 => PrivacyKeyAbout1534675103.TlSerialize(),
            Tel.PrivacyKeyNs.PrivacyKeyBirthday PrivacyKeyBirthday536913176 => PrivacyKeyBirthday536913176.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputPrivacyValueAllowContacts, InputPrivacyValueAllowAll, InputPrivacyValueAllowUsers, InputPrivacyValueDisallowContacts, InputPrivacyValueDisallowAll, InputPrivacyValueDisallowUsers, InputPrivacyValueAllowChatParticipants, InputPrivacyValueDisallowChatParticipants, InputPrivacyValueAllowCloseFriends, InputPrivacyValueAllowPremium,
    public abstract class InputPrivacyRuleBase : ITlSerializable, ITlDeserializable<InputPrivacyRuleBase> {
        public static InputPrivacyRuleBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueAllowContacts.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueAllowContacts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueAllowAll.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueAllowAll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueAllowUsers.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueAllowUsers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowContacts.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowContacts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowAll.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowAll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowUsers.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowUsers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueAllowChatParticipants.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueAllowChatParticipants.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowChatParticipants.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowChatParticipants.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueAllowCloseFriends.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueAllowCloseFriends.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPrivacyRuleNs.InputPrivacyValueAllowPremium.Identifier))
                return Tel.InputPrivacyRuleNs.InputPrivacyValueAllowPremium.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputPrivacyRuleNs.InputPrivacyValueAllowContacts InputPrivacyValueAllowContacts218751099 => InputPrivacyValueAllowContacts218751099.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueAllowAll InputPrivacyValueAllowAll407582158 => InputPrivacyValueAllowAll407582158.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueAllowUsers InputPrivacyValueAllowUsers320652927 => InputPrivacyValueAllowUsers320652927.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowContacts InputPrivacyValueDisallowContacts195371015 => InputPrivacyValueDisallowContacts195371015.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowAll InputPrivacyValueDisallowAll697604407 => InputPrivacyValueDisallowAll697604407.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowUsers InputPrivacyValueDisallowUsers1877932953 => InputPrivacyValueDisallowUsers1877932953.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueAllowChatParticipants InputPrivacyValueAllowChatParticipants2079962673 => InputPrivacyValueAllowChatParticipants2079962673.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueDisallowChatParticipants InputPrivacyValueDisallowChatParticipants380694650 => InputPrivacyValueDisallowChatParticipants380694650.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueAllowCloseFriends InputPrivacyValueAllowCloseFriends793067081 => InputPrivacyValueAllowCloseFriends793067081.TlSerialize(),
            Tel.InputPrivacyRuleNs.InputPrivacyValueAllowPremium InputPrivacyValueAllowPremium2009975281 => InputPrivacyValueAllowPremium2009975281.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PrivacyValueAllowContacts, PrivacyValueAllowAll, PrivacyValueAllowUsers, PrivacyValueDisallowContacts, PrivacyValueDisallowAll, PrivacyValueDisallowUsers, PrivacyValueAllowChatParticipants, PrivacyValueDisallowChatParticipants, PrivacyValueAllowCloseFriends, PrivacyValueAllowPremium,
    public abstract class PrivacyRuleBase : ITlSerializable, ITlDeserializable<PrivacyRuleBase> {
        public static PrivacyRuleBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueAllowContacts.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueAllowContacts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueAllowAll.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueAllowAll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueAllowUsers.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueAllowUsers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueDisallowContacts.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueDisallowContacts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueDisallowAll.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueDisallowAll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueDisallowUsers.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueDisallowUsers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueAllowChatParticipants.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueAllowChatParticipants.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueDisallowChatParticipants.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueDisallowChatParticipants.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueAllowCloseFriends.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueAllowCloseFriends.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PrivacyRuleNs.PrivacyValueAllowPremium.Identifier))
                return Tel.PrivacyRuleNs.PrivacyValueAllowPremium.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PrivacyRuleNs.PrivacyValueAllowContacts PrivacyValueAllowContacts123988 => PrivacyValueAllowContacts123988.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueAllowAll PrivacyValueAllowAll1698855810 => PrivacyValueAllowAll1698855810.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueAllowUsers PrivacyValueAllowUsers1198497870 => PrivacyValueAllowUsers1198497870.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueDisallowContacts PrivacyValueDisallowContacts125240806 => PrivacyValueDisallowContacts125240806.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueDisallowAll PrivacyValueDisallowAll1955338397 => PrivacyValueDisallowAll1955338397.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueDisallowUsers PrivacyValueDisallowUsers463335103 => PrivacyValueDisallowUsers463335103.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueAllowChatParticipants PrivacyValueAllowChatParticipants1796427406 => PrivacyValueAllowChatParticipants1796427406.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueDisallowChatParticipants PrivacyValueDisallowChatParticipants1103656293 => PrivacyValueDisallowChatParticipants1103656293.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueAllowCloseFriends PrivacyValueAllowCloseFriends135735141 => PrivacyValueAllowCloseFriends135735141.TlSerialize(),
            Tel.PrivacyRuleNs.PrivacyValueAllowPremium PrivacyValueAllowPremium320241333 => PrivacyValueAllowPremium320241333.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountPrivacyRules,
    public abstract class AccountPrivacyRulesBase : ITlSerializable, ITlDeserializable<AccountPrivacyRulesBase> {
        public static AccountPrivacyRulesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountPrivacyRulesNs.AccountPrivacyRules.Identifier))
                return Tel.AccountPrivacyRulesNs.AccountPrivacyRules.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountPrivacyRulesNs.AccountPrivacyRules AccountPrivacyRules1352683077 => AccountPrivacyRules1352683077.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountDaysTTL,
    public abstract class AccountDaysTTLBase : ITlSerializable, ITlDeserializable<AccountDaysTTLBase> {
        public static AccountDaysTTLBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountDaysTTLNs.AccountDaysTTL.Identifier))
                return Tel.AccountDaysTTLNs.AccountDaysTTL.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountDaysTTLNs.AccountDaysTTL AccountDaysTTL1194283041 => AccountDaysTTL1194283041.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DocumentAttributeImageSize, DocumentAttributeAnimated, DocumentAttributeSticker, DocumentAttributeVideo, DocumentAttributeAudio, DocumentAttributeFilename, DocumentAttributeHasStickers, DocumentAttributeCustomEmoji,
    public abstract class DocumentAttributeBase : ITlSerializable, ITlDeserializable<DocumentAttributeBase> {
        public static DocumentAttributeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DocumentAttributeNs.DocumentAttributeImageSize.Identifier))
                return Tel.DocumentAttributeNs.DocumentAttributeImageSize.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DocumentAttributeNs.DocumentAttributeAnimated.Identifier))
                return Tel.DocumentAttributeNs.DocumentAttributeAnimated.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DocumentAttributeNs.DocumentAttributeSticker.Identifier))
                return Tel.DocumentAttributeNs.DocumentAttributeSticker.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DocumentAttributeNs.DocumentAttributeVideo.Identifier))
                return Tel.DocumentAttributeNs.DocumentAttributeVideo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DocumentAttributeNs.DocumentAttributeAudio.Identifier))
                return Tel.DocumentAttributeNs.DocumentAttributeAudio.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DocumentAttributeNs.DocumentAttributeFilename.Identifier))
                return Tel.DocumentAttributeNs.DocumentAttributeFilename.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DocumentAttributeNs.DocumentAttributeHasStickers.Identifier))
                return Tel.DocumentAttributeNs.DocumentAttributeHasStickers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DocumentAttributeNs.DocumentAttributeCustomEmoji.Identifier))
                return Tel.DocumentAttributeNs.DocumentAttributeCustomEmoji.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DocumentAttributeNs.DocumentAttributeImageSize DocumentAttributeImageSize1815593308 => DocumentAttributeImageSize1815593308.TlSerialize(),
            Tel.DocumentAttributeNs.DocumentAttributeAnimated DocumentAttributeAnimated297109817 => DocumentAttributeAnimated297109817.TlSerialize(),
            Tel.DocumentAttributeNs.DocumentAttributeSticker DocumentAttributeSticker1662637586 => DocumentAttributeSticker1662637586.TlSerialize(),
            Tel.DocumentAttributeNs.DocumentAttributeVideo DocumentAttributeVideo745541182 => DocumentAttributeVideo745541182.TlSerialize(),
            Tel.DocumentAttributeNs.DocumentAttributeAudio DocumentAttributeAudio1739392570 => DocumentAttributeAudio1739392570.TlSerialize(),
            Tel.DocumentAttributeNs.DocumentAttributeFilename DocumentAttributeFilename358154344 => DocumentAttributeFilename358154344.TlSerialize(),
            Tel.DocumentAttributeNs.DocumentAttributeHasStickers DocumentAttributeHasStickers1744710921 => DocumentAttributeHasStickers1744710921.TlSerialize(),
            Tel.DocumentAttributeNs.DocumentAttributeCustomEmoji DocumentAttributeCustomEmoji48981863 => DocumentAttributeCustomEmoji48981863.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesStickersNotModified, MessagesStickers,
    public abstract class MessagesStickersBase : ITlSerializable, ITlDeserializable<MessagesStickersBase> {
        public static MessagesStickersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesStickersNs.MessagesStickersNotModified.Identifier))
                return Tel.MessagesStickersNs.MessagesStickersNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesStickersNs.MessagesStickers.Identifier))
                return Tel.MessagesStickersNs.MessagesStickers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesStickersNs.MessagesStickersNotModified MessagesStickersNotModified244016606 => MessagesStickersNotModified244016606.TlSerialize(),
            Tel.MessagesStickersNs.MessagesStickers MessagesStickers816245886 => MessagesStickers816245886.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StickerPack,
    public abstract class StickerPackBase : ITlSerializable, ITlDeserializable<StickerPackBase> {
        public static StickerPackBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StickerPackNs.StickerPack.Identifier))
                return Tel.StickerPackNs.StickerPack.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StickerPackNs.StickerPack StickerPack313694676 => StickerPack313694676.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesAllStickersNotModified, MessagesAllStickers,
    public abstract class MessagesAllStickersBase : ITlSerializable, ITlDeserializable<MessagesAllStickersBase> {
        public static MessagesAllStickersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesAllStickersNs.MessagesAllStickersNotModified.Identifier))
                return Tel.MessagesAllStickersNs.MessagesAllStickersNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesAllStickersNs.MessagesAllStickers.Identifier))
                return Tel.MessagesAllStickersNs.MessagesAllStickers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesAllStickersNs.MessagesAllStickersNotModified MessagesAllStickersNotModified395967805 => MessagesAllStickersNotModified395967805.TlSerialize(),
            Tel.MessagesAllStickersNs.MessagesAllStickers MessagesAllStickers843329861 => MessagesAllStickers843329861.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesAffectedMessages,
    public abstract class MessagesAffectedMessagesBase : ITlSerializable, ITlDeserializable<MessagesAffectedMessagesBase> {
        public static MessagesAffectedMessagesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesAffectedMessagesNs.MessagesAffectedMessages.Identifier))
                return Tel.MessagesAffectedMessagesNs.MessagesAffectedMessages.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesAffectedMessagesNs.MessagesAffectedMessages MessagesAffectedMessages2066640507 => MessagesAffectedMessages2066640507.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: WebPageEmpty, WebPagePending, WebPage, WebPageNotModified,
    public abstract class WebPageBase : ITlSerializable, ITlDeserializable<WebPageBase> {
        public int Flags {get;set;} = default!;
        public static WebPageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.WebPageNs.WebPageEmpty.Identifier))
                return Tel.WebPageNs.WebPageEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.WebPageNs.WebPagePending.Identifier))
                return Tel.WebPageNs.WebPagePending.TlDeserialize(des);
            if (id.SequenceEqual(Tel.WebPageNs.WebPage.Identifier))
                return Tel.WebPageNs.WebPage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.WebPageNs.WebPageNotModified.Identifier))
                return Tel.WebPageNs.WebPageNotModified.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.WebPageNs.WebPageEmpty WebPageEmpty555358088 => WebPageEmpty555358088.TlSerialize(),
            Tel.WebPageNs.WebPagePending WebPagePending1328464313 => WebPagePending1328464313.TlSerialize(),
            Tel.WebPageNs.WebPage WebPage392411726 => WebPage392411726.TlSerialize(),
            Tel.WebPageNs.WebPageNotModified WebPageNotModified1930545681 => WebPageNotModified1930545681.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Authorization,
    public abstract class AuthorizationBase : ITlSerializable, ITlDeserializable<AuthorizationBase> {
        public static AuthorizationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthorizationNs.Authorization.Identifier))
                return Tel.AuthorizationNs.Authorization.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthorizationNs.Authorization Authorization1392388579 => Authorization1392388579.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountAuthorizations,
    public abstract class AccountAuthorizationsBase : ITlSerializable, ITlDeserializable<AccountAuthorizationsBase> {
        public static AccountAuthorizationsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountAuthorizationsNs.AccountAuthorizations.Identifier))
                return Tel.AccountAuthorizationsNs.AccountAuthorizations.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountAuthorizationsNs.AccountAuthorizations AccountAuthorizations1275039392 => AccountAuthorizations1275039392.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountPassword,
    public abstract class AccountPasswordBase : ITlSerializable, ITlDeserializable<AccountPasswordBase> {
        public static AccountPasswordBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountPasswordNs.AccountPassword.Identifier))
                return Tel.AccountPasswordNs.AccountPassword.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountPasswordNs.AccountPassword AccountPassword1787080453 => AccountPassword1787080453.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountPasswordSettings,
    public abstract class AccountPasswordSettingsBase : ITlSerializable, ITlDeserializable<AccountPasswordSettingsBase> {
        public static AccountPasswordSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountPasswordSettingsNs.AccountPasswordSettings.Identifier))
                return Tel.AccountPasswordSettingsNs.AccountPasswordSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountPasswordSettingsNs.AccountPasswordSettings AccountPasswordSettings1705233435 => AccountPasswordSettings1705233435.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountPasswordInputSettings,
    public abstract class AccountPasswordInputSettingsBase : ITlSerializable, ITlDeserializable<AccountPasswordInputSettingsBase> {
        public static AccountPasswordInputSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountPasswordInputSettingsNs.AccountPasswordInputSettings.Identifier))
                return Tel.AccountPasswordInputSettingsNs.AccountPasswordInputSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountPasswordInputSettingsNs.AccountPasswordInputSettings AccountPasswordInputSettings1036572727 => AccountPasswordInputSettings1036572727.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AuthPasswordRecovery,
    public abstract class AuthPasswordRecoveryBase : ITlSerializable, ITlDeserializable<AuthPasswordRecoveryBase> {
        public static AuthPasswordRecoveryBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthPasswordRecoveryNs.AuthPasswordRecovery.Identifier))
                return Tel.AuthPasswordRecoveryNs.AuthPasswordRecovery.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthPasswordRecoveryNs.AuthPasswordRecovery AuthPasswordRecovery326715557 => AuthPasswordRecovery326715557.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ReceivedNotifyMessage,
    public abstract class ReceivedNotifyMessageBase : ITlSerializable, ITlDeserializable<ReceivedNotifyMessageBase> {
        public static ReceivedNotifyMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ReceivedNotifyMessageNs.ReceivedNotifyMessage.Identifier))
                return Tel.ReceivedNotifyMessageNs.ReceivedNotifyMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ReceivedNotifyMessageNs.ReceivedNotifyMessage ReceivedNotifyMessage1551583367 => ReceivedNotifyMessage1551583367.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatInviteExported, ChatInvitePublicJoinRequests,
    public abstract class ExportedChatInviteBase : ITlSerializable, ITlDeserializable<ExportedChatInviteBase> {
        public static ExportedChatInviteBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ExportedChatInviteNs.ChatInviteExported.Identifier))
                return Tel.ExportedChatInviteNs.ChatInviteExported.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ExportedChatInviteNs.ChatInvitePublicJoinRequests.Identifier))
                return Tel.ExportedChatInviteNs.ChatInvitePublicJoinRequests.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ExportedChatInviteNs.ChatInviteExported ChatInviteExported179611673 => ChatInviteExported179611673.TlSerialize(),
            Tel.ExportedChatInviteNs.ChatInvitePublicJoinRequests ChatInvitePublicJoinRequests317687113 => ChatInvitePublicJoinRequests317687113.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatInviteAlready, ChatInvite, ChatInvitePeek,
    public abstract class ChatInviteBase : ITlSerializable, ITlDeserializable<ChatInviteBase> {
        public static ChatInviteBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatInviteNs.ChatInviteAlready.Identifier))
                return Tel.ChatInviteNs.ChatInviteAlready.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatInviteNs.ChatInvite.Identifier))
                return Tel.ChatInviteNs.ChatInvite.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatInviteNs.ChatInvitePeek.Identifier))
                return Tel.ChatInviteNs.ChatInvitePeek.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatInviteNs.ChatInviteAlready ChatInviteAlready1516793212 => ChatInviteAlready1516793212.TlSerialize(),
            Tel.ChatInviteNs.ChatInvite ChatInvite840897472 => ChatInvite840897472.TlSerialize(),
            Tel.ChatInviteNs.ChatInvitePeek ChatInvitePeek1634294960 => ChatInvitePeek1634294960.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputStickerSetEmpty, InputStickerSetID, InputStickerSetShortName, InputStickerSetAnimatedEmoji, InputStickerSetDice, InputStickerSetAnimatedEmojiAnimations, InputStickerSetPremiumGifts, InputStickerSetEmojiGenericAnimations, InputStickerSetEmojiDefaultStatuses, InputStickerSetEmojiDefaultTopicIcons, InputStickerSetEmojiChannelDefaultStatuses,
    public abstract class InputStickerSetBase : ITlSerializable, ITlDeserializable<InputStickerSetBase> {
        public static InputStickerSetBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetEmpty.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetID.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetID.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetShortName.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetShortName.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetAnimatedEmoji.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetAnimatedEmoji.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetDice.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetDice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetAnimatedEmojiAnimations.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetAnimatedEmojiAnimations.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetPremiumGifts.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetPremiumGifts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetEmojiGenericAnimations.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetEmojiGenericAnimations.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetEmojiDefaultStatuses.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetEmojiDefaultStatuses.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetEmojiDefaultTopicIcons.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetEmojiDefaultTopicIcons.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickerSetNs.InputStickerSetEmojiChannelDefaultStatuses.Identifier))
                return Tel.InputStickerSetNs.InputStickerSetEmojiChannelDefaultStatuses.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputStickerSetNs.InputStickerSetEmpty InputStickerSetEmpty4838507 => InputStickerSetEmpty4838507.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetID InputStickerSetID1645763991 => InputStickerSetID1645763991.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetShortName InputStickerSetShortName2044933984 => InputStickerSetShortName2044933984.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetAnimatedEmoji InputStickerSetAnimatedEmoji42402760 => InputStickerSetAnimatedEmoji42402760.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetDice InputStickerSetDice427863538 => InputStickerSetDice427863538.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetAnimatedEmojiAnimations InputStickerSetAnimatedEmojiAnimations215889721 => InputStickerSetAnimatedEmojiAnimations215889721.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetPremiumGifts InputStickerSetPremiumGifts930399486 => InputStickerSetPremiumGifts930399486.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetEmojiGenericAnimations InputStickerSetEmojiGenericAnimations80008398 => InputStickerSetEmojiGenericAnimations80008398.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetEmojiDefaultStatuses InputStickerSetEmojiDefaultStatuses701560302 => InputStickerSetEmojiDefaultStatuses701560302.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetEmojiDefaultTopicIcons InputStickerSetEmojiDefaultTopicIcons1153562857 => InputStickerSetEmojiDefaultTopicIcons1153562857.TlSerialize(),
            Tel.InputStickerSetNs.InputStickerSetEmojiChannelDefaultStatuses InputStickerSetEmojiChannelDefaultStatuses1232373075 => InputStickerSetEmojiChannelDefaultStatuses1232373075.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StickerSet,
    public abstract class StickerSetBase : ITlSerializable, ITlDeserializable<StickerSetBase> {
        public static StickerSetBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StickerSetNs.StickerSet.Identifier))
                return Tel.StickerSetNs.StickerSet.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StickerSetNs.StickerSet StickerSet768691932 => StickerSet768691932.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesStickerSet, MessagesStickerSetNotModified,
    public abstract class MessagesStickerSetBase : ITlSerializable, ITlDeserializable<MessagesStickerSetBase> {
        public static MessagesStickerSetBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesStickerSetNs.MessagesStickerSet.Identifier))
                return Tel.MessagesStickerSetNs.MessagesStickerSet.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesStickerSetNs.MessagesStickerSetNotModified.Identifier))
                return Tel.MessagesStickerSetNs.MessagesStickerSetNotModified.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesStickerSetNs.MessagesStickerSet MessagesStickerSet1846886166 => MessagesStickerSet1846886166.TlSerialize(),
            Tel.MessagesStickerSetNs.MessagesStickerSetNotModified MessagesStickerSetNotModified738646805 => MessagesStickerSetNotModified738646805.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotCommand,
    public abstract class BotCommandBase : ITlSerializable, ITlDeserializable<BotCommandBase> {
        public static BotCommandBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotCommandNs.BotCommand.Identifier))
                return Tel.BotCommandNs.BotCommand.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotCommandNs.BotCommand BotCommand1032140601 => BotCommand1032140601.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotInfo,
    public abstract class BotInfoBase : ITlSerializable, ITlDeserializable<BotInfoBase> {
        public static BotInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotInfoNs.BotInfo.Identifier))
                return Tel.BotInfoNs.BotInfo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotInfoNs.BotInfo BotInfo1892676777 => BotInfo1892676777.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: KeyboardButton, KeyboardButtonUrl, KeyboardButtonCallback, KeyboardButtonRequestPhone, KeyboardButtonRequestGeoLocation, KeyboardButtonSwitchInline, KeyboardButtonGame, KeyboardButtonBuy, KeyboardButtonUrlAuth, InputKeyboardButtonUrlAuth, KeyboardButtonRequestPoll, InputKeyboardButtonUserProfile, KeyboardButtonUserProfile, KeyboardButtonWebView, KeyboardButtonSimpleWebView, KeyboardButtonRequestPeer, InputKeyboardButtonRequestPeer,
    public abstract class KeyboardButtonBase : ITlSerializable, ITlDeserializable<KeyboardButtonBase> {
        public string Text {get;set;} = default!;
        public static KeyboardButtonBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButton.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButton.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonUrl.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonUrl.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonCallback.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonCallback.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonRequestPhone.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonRequestPhone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonRequestGeoLocation.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonRequestGeoLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonSwitchInline.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonSwitchInline.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonGame.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonGame.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonBuy.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonBuy.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonUrlAuth.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonUrlAuth.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.InputKeyboardButtonUrlAuth.Identifier))
                return Tel.KeyboardButtonNs.InputKeyboardButtonUrlAuth.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonRequestPoll.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonRequestPoll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.InputKeyboardButtonUserProfile.Identifier))
                return Tel.KeyboardButtonNs.InputKeyboardButtonUserProfile.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonUserProfile.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonUserProfile.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonWebView.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonWebView.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonSimpleWebView.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonSimpleWebView.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.KeyboardButtonRequestPeer.Identifier))
                return Tel.KeyboardButtonNs.KeyboardButtonRequestPeer.TlDeserialize(des);
            if (id.SequenceEqual(Tel.KeyboardButtonNs.InputKeyboardButtonRequestPeer.Identifier))
                return Tel.KeyboardButtonNs.InputKeyboardButtonRequestPeer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.KeyboardButtonNs.KeyboardButton KeyboardButton1560655744 => KeyboardButton1560655744.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonUrl KeyboardButtonUrl629866245 => KeyboardButtonUrl629866245.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonCallback KeyboardButtonCallback901503851 => KeyboardButtonCallback901503851.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonRequestPhone KeyboardButtonRequestPhone1318425559 => KeyboardButtonRequestPhone1318425559.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonRequestGeoLocation KeyboardButtonRequestGeoLocation59151553 => KeyboardButtonRequestGeoLocation59151553.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonSwitchInline KeyboardButtonSwitchInline1816527947 => KeyboardButtonSwitchInline1816527947.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonGame KeyboardButtonGame1358175439 => KeyboardButtonGame1358175439.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonBuy KeyboardButtonBuy1344716869 => KeyboardButtonBuy1344716869.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonUrlAuth KeyboardButtonUrlAuth280464681 => KeyboardButtonUrlAuth280464681.TlSerialize(),
            Tel.KeyboardButtonNs.InputKeyboardButtonUrlAuth InputKeyboardButtonUrlAuth802258988 => InputKeyboardButtonUrlAuth802258988.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonRequestPoll KeyboardButtonRequestPoll1144565411 => KeyboardButtonRequestPoll1144565411.TlSerialize(),
            Tel.KeyboardButtonNs.InputKeyboardButtonUserProfile InputKeyboardButtonUserProfile376962181 => InputKeyboardButtonUserProfile376962181.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonUserProfile KeyboardButtonUserProfile814112961 => KeyboardButtonUserProfile814112961.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonWebView KeyboardButtonWebView326529584 => KeyboardButtonWebView326529584.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonSimpleWebView KeyboardButtonSimpleWebView1598009252 => KeyboardButtonSimpleWebView1598009252.TlSerialize(),
            Tel.KeyboardButtonNs.KeyboardButtonRequestPeer KeyboardButtonRequestPeer1406648280 => KeyboardButtonRequestPeer1406648280.TlSerialize(),
            Tel.KeyboardButtonNs.InputKeyboardButtonRequestPeer InputKeyboardButtonRequestPeer916050683 => InputKeyboardButtonRequestPeer916050683.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: KeyboardButtonRow,
    public abstract class KeyboardButtonRowBase : ITlSerializable, ITlDeserializable<KeyboardButtonRowBase> {
        public static KeyboardButtonRowBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.KeyboardButtonRowNs.KeyboardButtonRow.Identifier))
                return Tel.KeyboardButtonRowNs.KeyboardButtonRow.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.KeyboardButtonRowNs.KeyboardButtonRow KeyboardButtonRow2002815875 => KeyboardButtonRow2002815875.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ReplyKeyboardHide, ReplyKeyboardForceReply, ReplyKeyboardMarkup, ReplyInlineMarkup,
    public abstract class ReplyMarkupBase : ITlSerializable, ITlDeserializable<ReplyMarkupBase> {
        public static ReplyMarkupBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ReplyMarkupNs.ReplyKeyboardHide.Identifier))
                return Tel.ReplyMarkupNs.ReplyKeyboardHide.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReplyMarkupNs.ReplyKeyboardForceReply.Identifier))
                return Tel.ReplyMarkupNs.ReplyKeyboardForceReply.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReplyMarkupNs.ReplyKeyboardMarkup.Identifier))
                return Tel.ReplyMarkupNs.ReplyKeyboardMarkup.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReplyMarkupNs.ReplyInlineMarkup.Identifier))
                return Tel.ReplyMarkupNs.ReplyInlineMarkup.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ReplyMarkupNs.ReplyKeyboardHide ReplyKeyboardHide1606526075 => ReplyKeyboardHide1606526075.TlSerialize(),
            Tel.ReplyMarkupNs.ReplyKeyboardForceReply ReplyKeyboardForceReply2035021048 => ReplyKeyboardForceReply2035021048.TlSerialize(),
            Tel.ReplyMarkupNs.ReplyKeyboardMarkup ReplyKeyboardMarkup2049074735 => ReplyKeyboardMarkup2049074735.TlSerialize(),
            Tel.ReplyMarkupNs.ReplyInlineMarkup ReplyInlineMarkup1218642516 => ReplyInlineMarkup1218642516.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageEntityUnknown, MessageEntityMention, MessageEntityHashtag, MessageEntityBotCommand, MessageEntityUrl, MessageEntityEmail, MessageEntityBold, MessageEntityItalic, MessageEntityCode, MessageEntityPre, MessageEntityTextUrl, MessageEntityMentionName, InputMessageEntityMentionName, MessageEntityPhone, MessageEntityCashtag, MessageEntityUnderline, MessageEntityStrike, MessageEntityBankCard, MessageEntitySpoiler, MessageEntityCustomEmoji, MessageEntityBlockquote,
    public abstract class MessageEntityBase : ITlSerializable, ITlDeserializable<MessageEntityBase> {
        public int Offset {get;set;} = default!;
        public int Length {get;set;} = default!;
        public static MessageEntityBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityUnknown.Identifier))
                return Tel.MessageEntityNs.MessageEntityUnknown.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityMention.Identifier))
                return Tel.MessageEntityNs.MessageEntityMention.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityHashtag.Identifier))
                return Tel.MessageEntityNs.MessageEntityHashtag.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityBotCommand.Identifier))
                return Tel.MessageEntityNs.MessageEntityBotCommand.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityUrl.Identifier))
                return Tel.MessageEntityNs.MessageEntityUrl.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityEmail.Identifier))
                return Tel.MessageEntityNs.MessageEntityEmail.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityBold.Identifier))
                return Tel.MessageEntityNs.MessageEntityBold.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityItalic.Identifier))
                return Tel.MessageEntityNs.MessageEntityItalic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityCode.Identifier))
                return Tel.MessageEntityNs.MessageEntityCode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityPre.Identifier))
                return Tel.MessageEntityNs.MessageEntityPre.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityTextUrl.Identifier))
                return Tel.MessageEntityNs.MessageEntityTextUrl.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityMentionName.Identifier))
                return Tel.MessageEntityNs.MessageEntityMentionName.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.InputMessageEntityMentionName.Identifier))
                return Tel.MessageEntityNs.InputMessageEntityMentionName.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityPhone.Identifier))
                return Tel.MessageEntityNs.MessageEntityPhone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityCashtag.Identifier))
                return Tel.MessageEntityNs.MessageEntityCashtag.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityUnderline.Identifier))
                return Tel.MessageEntityNs.MessageEntityUnderline.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityStrike.Identifier))
                return Tel.MessageEntityNs.MessageEntityStrike.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityBankCard.Identifier))
                return Tel.MessageEntityNs.MessageEntityBankCard.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntitySpoiler.Identifier))
                return Tel.MessageEntityNs.MessageEntitySpoiler.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityCustomEmoji.Identifier))
                return Tel.MessageEntityNs.MessageEntityCustomEmoji.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageEntityNs.MessageEntityBlockquote.Identifier))
                return Tel.MessageEntityNs.MessageEntityBlockquote.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageEntityNs.MessageEntityUnknown MessageEntityUnknown1148011883 => MessageEntityUnknown1148011883.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityMention MessageEntityMention100378723 => MessageEntityMention100378723.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityHashtag MessageEntityHashtag1868782349 => MessageEntityHashtag1868782349.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityBotCommand MessageEntityBotCommand1827637959 => MessageEntityBotCommand1827637959.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityUrl MessageEntityUrl1859134776 => MessageEntityUrl1859134776.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityEmail MessageEntityEmail1692693954 => MessageEntityEmail1692693954.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityBold MessageEntityBold1117713463 => MessageEntityBold1117713463.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityItalic MessageEntityItalic2106619040 => MessageEntityItalic2106619040.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityCode MessageEntityCode681706865 => MessageEntityCode681706865.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityPre MessageEntityPre1938967520 => MessageEntityPre1938967520.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityTextUrl MessageEntityTextUrl1990644519 => MessageEntityTextUrl1990644519.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityMentionName MessageEntityMentionName595914432 => MessageEntityMentionName595914432.TlSerialize(),
            Tel.MessageEntityNs.InputMessageEntityMentionName InputMessageEntityMentionName546203849 => InputMessageEntityMentionName546203849.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityPhone MessageEntityPhone1687559349 => MessageEntityPhone1687559349.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityCashtag MessageEntityCashtag1280209983 => MessageEntityCashtag1280209983.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityUnderline MessageEntityUnderline1672577397 => MessageEntityUnderline1672577397.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityStrike MessageEntityStrike1090087980 => MessageEntityStrike1090087980.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityBankCard MessageEntityBankCard1981704948 => MessageEntityBankCard1981704948.TlSerialize(),
            Tel.MessageEntityNs.MessageEntitySpoiler MessageEntitySpoiler852137487 => MessageEntitySpoiler852137487.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityCustomEmoji MessageEntityCustomEmoji925956616 => MessageEntityCustomEmoji925956616.TlSerialize(),
            Tel.MessageEntityNs.MessageEntityBlockquote MessageEntityBlockquote238245204 => MessageEntityBlockquote238245204.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputChannelEmpty, InputChannel, InputChannelFromMessage,
    public abstract class InputChannelBase : ITlSerializable, ITlDeserializable<InputChannelBase> {
        public static InputChannelBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputChannelNs.InputChannelEmpty.Identifier))
                return Tel.InputChannelNs.InputChannelEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputChannelNs.InputChannel.Identifier))
                return Tel.InputChannelNs.InputChannel.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputChannelNs.InputChannelFromMessage.Identifier))
                return Tel.InputChannelNs.InputChannelFromMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputChannelNs.InputChannelEmpty InputChannelEmpty292807034 => InputChannelEmpty292807034.TlSerialize(),
            Tel.InputChannelNs.InputChannel InputChannel212145112 => InputChannel212145112.TlSerialize(),
            Tel.InputChannelNs.InputChannelFromMessage InputChannelFromMessage1536380829 => InputChannelFromMessage1536380829.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactsResolvedPeer,
    public abstract class ContactsResolvedPeerBase : ITlSerializable, ITlDeserializable<ContactsResolvedPeerBase> {
        public static ContactsResolvedPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactsResolvedPeerNs.ContactsResolvedPeer.Identifier))
                return Tel.ContactsResolvedPeerNs.ContactsResolvedPeer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactsResolvedPeerNs.ContactsResolvedPeer ContactsResolvedPeer2131196633 => ContactsResolvedPeer2131196633.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageRange,
    public abstract class MessageRangeBase : ITlSerializable, ITlDeserializable<MessageRangeBase> {
        public static MessageRangeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageRangeNs.MessageRange.Identifier))
                return Tel.MessageRangeNs.MessageRange.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageRangeNs.MessageRange MessageRange182649427 => MessageRange182649427.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UpdatesChannelDifferenceEmpty, UpdatesChannelDifferenceTooLong, UpdatesChannelDifference,
    public abstract class UpdatesChannelDifferenceBase : ITlSerializable, ITlDeserializable<UpdatesChannelDifferenceBase> {
        public int Flags {get;set;} = default!;
        public bool Final {get;set;} = default!;
        public int? Timeout {get;set;} = default!;
        public static UpdatesChannelDifferenceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifferenceEmpty.Identifier))
                return Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifferenceEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifferenceTooLong.Identifier))
                return Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifferenceTooLong.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifference.Identifier))
                return Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifference.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifferenceEmpty UpdatesChannelDifferenceEmpty1041346555 => UpdatesChannelDifferenceEmpty1041346555.TlSerialize(),
            Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifferenceTooLong UpdatesChannelDifferenceTooLong1531132162 => UpdatesChannelDifferenceTooLong1531132162.TlSerialize(),
            Tel.UpdatesChannelDifferenceNs.UpdatesChannelDifference UpdatesChannelDifference543450958 => UpdatesChannelDifference543450958.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelMessagesFilterEmpty, ChannelMessagesFilter,
    public abstract class ChannelMessagesFilterBase : ITlSerializable, ITlDeserializable<ChannelMessagesFilterBase> {
        public static ChannelMessagesFilterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelMessagesFilterNs.ChannelMessagesFilterEmpty.Identifier))
                return Tel.ChannelMessagesFilterNs.ChannelMessagesFilterEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelMessagesFilterNs.ChannelMessagesFilter.Identifier))
                return Tel.ChannelMessagesFilterNs.ChannelMessagesFilter.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelMessagesFilterNs.ChannelMessagesFilterEmpty ChannelMessagesFilterEmpty1798033689 => ChannelMessagesFilterEmpty1798033689.TlSerialize(),
            Tel.ChannelMessagesFilterNs.ChannelMessagesFilter ChannelMessagesFilter847783593 => ChannelMessagesFilter847783593.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelParticipant, ChannelParticipantSelf, ChannelParticipantCreator, ChannelParticipantAdmin, ChannelParticipantBanned, ChannelParticipantLeft,
    public abstract class ChannelParticipantBase : ITlSerializable, ITlDeserializable<ChannelParticipantBase> {
        public static ChannelParticipantBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelParticipantNs.ChannelParticipant.Identifier))
                return Tel.ChannelParticipantNs.ChannelParticipant.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantNs.ChannelParticipantSelf.Identifier))
                return Tel.ChannelParticipantNs.ChannelParticipantSelf.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantNs.ChannelParticipantCreator.Identifier))
                return Tel.ChannelParticipantNs.ChannelParticipantCreator.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantNs.ChannelParticipantAdmin.Identifier))
                return Tel.ChannelParticipantNs.ChannelParticipantAdmin.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantNs.ChannelParticipantBanned.Identifier))
                return Tel.ChannelParticipantNs.ChannelParticipantBanned.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantNs.ChannelParticipantLeft.Identifier))
                return Tel.ChannelParticipantNs.ChannelParticipantLeft.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelParticipantNs.ChannelParticipant ChannelParticipant1072953408 => ChannelParticipant1072953408.TlSerialize(),
            Tel.ChannelParticipantNs.ChannelParticipantSelf ChannelParticipantSelf900251559 => ChannelParticipantSelf900251559.TlSerialize(),
            Tel.ChannelParticipantNs.ChannelParticipantCreator ChannelParticipantCreator803602899 => ChannelParticipantCreator803602899.TlSerialize(),
            Tel.ChannelParticipantNs.ChannelParticipantAdmin ChannelParticipantAdmin885242707 => ChannelParticipantAdmin885242707.TlSerialize(),
            Tel.ChannelParticipantNs.ChannelParticipantBanned ChannelParticipantBanned1844969806 => ChannelParticipantBanned1844969806.TlSerialize(),
            Tel.ChannelParticipantNs.ChannelParticipantLeft ChannelParticipantLeft453242886 => ChannelParticipantLeft453242886.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelParticipantsRecent, ChannelParticipantsAdmins, ChannelParticipantsKicked, ChannelParticipantsBots, ChannelParticipantsBanned, ChannelParticipantsSearch, ChannelParticipantsContacts, ChannelParticipantsMentions,
    public abstract class ChannelParticipantsFilterBase : ITlSerializable, ITlDeserializable<ChannelParticipantsFilterBase> {
        public static ChannelParticipantsFilterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelParticipantsFilterNs.ChannelParticipantsRecent.Identifier))
                return Tel.ChannelParticipantsFilterNs.ChannelParticipantsRecent.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantsFilterNs.ChannelParticipantsAdmins.Identifier))
                return Tel.ChannelParticipantsFilterNs.ChannelParticipantsAdmins.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantsFilterNs.ChannelParticipantsKicked.Identifier))
                return Tel.ChannelParticipantsFilterNs.ChannelParticipantsKicked.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantsFilterNs.ChannelParticipantsBots.Identifier))
                return Tel.ChannelParticipantsFilterNs.ChannelParticipantsBots.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantsFilterNs.ChannelParticipantsBanned.Identifier))
                return Tel.ChannelParticipantsFilterNs.ChannelParticipantsBanned.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantsFilterNs.ChannelParticipantsSearch.Identifier))
                return Tel.ChannelParticipantsFilterNs.ChannelParticipantsSearch.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantsFilterNs.ChannelParticipantsContacts.Identifier))
                return Tel.ChannelParticipantsFilterNs.ChannelParticipantsContacts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelParticipantsFilterNs.ChannelParticipantsMentions.Identifier))
                return Tel.ChannelParticipantsFilterNs.ChannelParticipantsMentions.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelParticipantsFilterNs.ChannelParticipantsRecent ChannelParticipantsRecent566281095 => ChannelParticipantsRecent566281095.TlSerialize(),
            Tel.ChannelParticipantsFilterNs.ChannelParticipantsAdmins ChannelParticipantsAdmins1268741783 => ChannelParticipantsAdmins1268741783.TlSerialize(),
            Tel.ChannelParticipantsFilterNs.ChannelParticipantsKicked ChannelParticipantsKicked1548400251 => ChannelParticipantsKicked1548400251.TlSerialize(),
            Tel.ChannelParticipantsFilterNs.ChannelParticipantsBots ChannelParticipantsBots1328445861 => ChannelParticipantsBots1328445861.TlSerialize(),
            Tel.ChannelParticipantsFilterNs.ChannelParticipantsBanned ChannelParticipantsBanned338142689 => ChannelParticipantsBanned338142689.TlSerialize(),
            Tel.ChannelParticipantsFilterNs.ChannelParticipantsSearch ChannelParticipantsSearch106343499 => ChannelParticipantsSearch106343499.TlSerialize(),
            Tel.ChannelParticipantsFilterNs.ChannelParticipantsContacts ChannelParticipantsContacts1150621555 => ChannelParticipantsContacts1150621555.TlSerialize(),
            Tel.ChannelParticipantsFilterNs.ChannelParticipantsMentions ChannelParticipantsMentions531931925 => ChannelParticipantsMentions531931925.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelsChannelParticipants, ChannelsChannelParticipantsNotModified,
    public abstract class ChannelsChannelParticipantsBase : ITlSerializable, ITlDeserializable<ChannelsChannelParticipantsBase> {
        public static ChannelsChannelParticipantsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelsChannelParticipantsNs.ChannelsChannelParticipants.Identifier))
                return Tel.ChannelsChannelParticipantsNs.ChannelsChannelParticipants.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelsChannelParticipantsNs.ChannelsChannelParticipantsNotModified.Identifier))
                return Tel.ChannelsChannelParticipantsNs.ChannelsChannelParticipantsNotModified.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelsChannelParticipantsNs.ChannelsChannelParticipants ChannelsChannelParticipants1699676497 => ChannelsChannelParticipants1699676497.TlSerialize(),
            Tel.ChannelsChannelParticipantsNs.ChannelsChannelParticipantsNotModified ChannelsChannelParticipantsNotModified266911767 => ChannelsChannelParticipantsNotModified266911767.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelsChannelParticipant,
    public abstract class ChannelsChannelParticipantBase : ITlSerializable, ITlDeserializable<ChannelsChannelParticipantBase> {
        public static ChannelsChannelParticipantBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelsChannelParticipantNs.ChannelsChannelParticipant.Identifier))
                return Tel.ChannelsChannelParticipantNs.ChannelsChannelParticipant.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelsChannelParticipantNs.ChannelsChannelParticipant ChannelsChannelParticipant541588713 => ChannelsChannelParticipant541588713.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpTermsOfService,
    public abstract class HelpTermsOfServiceBase : ITlSerializable, ITlDeserializable<HelpTermsOfServiceBase> {
        public static HelpTermsOfServiceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpTermsOfServiceNs.HelpTermsOfService.Identifier))
                return Tel.HelpTermsOfServiceNs.HelpTermsOfService.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpTermsOfServiceNs.HelpTermsOfService HelpTermsOfService2013922064 => HelpTermsOfService2013922064.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesSavedGifsNotModified, MessagesSavedGifs,
    public abstract class MessagesSavedGifsBase : ITlSerializable, ITlDeserializable<MessagesSavedGifsBase> {
        public static MessagesSavedGifsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesSavedGifsNs.MessagesSavedGifsNotModified.Identifier))
                return Tel.MessagesSavedGifsNs.MessagesSavedGifsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesSavedGifsNs.MessagesSavedGifs.Identifier))
                return Tel.MessagesSavedGifsNs.MessagesSavedGifs.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesSavedGifsNs.MessagesSavedGifsNotModified MessagesSavedGifsNotModified402498398 => MessagesSavedGifsNotModified402498398.TlSerialize(),
            Tel.MessagesSavedGifsNs.MessagesSavedGifs MessagesSavedGifs2069878259 => MessagesSavedGifs2069878259.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBotInlineMessageMediaAuto, InputBotInlineMessageText, InputBotInlineMessageMediaGeo, InputBotInlineMessageMediaVenue, InputBotInlineMessageMediaContact, InputBotInlineMessageGame, InputBotInlineMessageMediaInvoice, InputBotInlineMessageMediaWebPage,
    public abstract class InputBotInlineMessageBase : ITlSerializable, ITlDeserializable<InputBotInlineMessageBase> {
        public int Flags {get;set;} = default!;
        public ReplyMarkupBase? ReplyMarkup {get;set;} = default!;
        public static InputBotInlineMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaAuto.Identifier))
                return Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaAuto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineMessageNs.InputBotInlineMessageText.Identifier))
                return Tel.InputBotInlineMessageNs.InputBotInlineMessageText.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaGeo.Identifier))
                return Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaGeo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaVenue.Identifier))
                return Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaVenue.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaContact.Identifier))
                return Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaContact.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineMessageNs.InputBotInlineMessageGame.Identifier))
                return Tel.InputBotInlineMessageNs.InputBotInlineMessageGame.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaInvoice.Identifier))
                return Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaInvoice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaWebPage.Identifier))
                return Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaWebPage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaAuto InputBotInlineMessageMediaAuto864077702 => InputBotInlineMessageMediaAuto864077702.TlSerialize(),
            Tel.InputBotInlineMessageNs.InputBotInlineMessageText InputBotInlineMessageText1036876423 => InputBotInlineMessageText1036876423.TlSerialize(),
            Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaGeo InputBotInlineMessageMediaGeo1768777083 => InputBotInlineMessageMediaGeo1768777083.TlSerialize(),
            Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaVenue InputBotInlineMessageMediaVenue1098628881 => InputBotInlineMessageMediaVenue1098628881.TlSerialize(),
            Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaContact InputBotInlineMessageMediaContact1494368259 => InputBotInlineMessageMediaContact1494368259.TlSerialize(),
            Tel.InputBotInlineMessageNs.InputBotInlineMessageGame InputBotInlineMessageGame1262639204 => InputBotInlineMessageGame1262639204.TlSerialize(),
            Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaInvoice InputBotInlineMessageMediaInvoice672693723 => InputBotInlineMessageMediaInvoice672693723.TlSerialize(),
            Tel.InputBotInlineMessageNs.InputBotInlineMessageMediaWebPage InputBotInlineMessageMediaWebPage1109605104 => InputBotInlineMessageMediaWebPage1109605104.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBotInlineResult, InputBotInlineResultPhoto, InputBotInlineResultDocument, InputBotInlineResultGame,
    public abstract class InputBotInlineResultBase : ITlSerializable, ITlDeserializable<InputBotInlineResultBase> {
        public string Id {get;set;} = default!;
        public InputBotInlineMessageBase SendMessage {get;set;} = default!;
        public static InputBotInlineResultBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBotInlineResultNs.InputBotInlineResult.Identifier))
                return Tel.InputBotInlineResultNs.InputBotInlineResult.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineResultNs.InputBotInlineResultPhoto.Identifier))
                return Tel.InputBotInlineResultNs.InputBotInlineResultPhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineResultNs.InputBotInlineResultDocument.Identifier))
                return Tel.InputBotInlineResultNs.InputBotInlineResultDocument.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineResultNs.InputBotInlineResultGame.Identifier))
                return Tel.InputBotInlineResultNs.InputBotInlineResultGame.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBotInlineResultNs.InputBotInlineResult InputBotInlineResult2000710887 => InputBotInlineResult2000710887.TlSerialize(),
            Tel.InputBotInlineResultNs.InputBotInlineResultPhoto InputBotInlineResultPhoto1462213465 => InputBotInlineResultPhoto1462213465.TlSerialize(),
            Tel.InputBotInlineResultNs.InputBotInlineResultDocument InputBotInlineResultDocument459324 => InputBotInlineResultDocument459324.TlSerialize(),
            Tel.InputBotInlineResultNs.InputBotInlineResultGame InputBotInlineResultGame1336154098 => InputBotInlineResultGame1336154098.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotInlineMessageMediaAuto, BotInlineMessageText, BotInlineMessageMediaGeo, BotInlineMessageMediaVenue, BotInlineMessageMediaContact, BotInlineMessageMediaInvoice, BotInlineMessageMediaWebPage,
    public abstract class BotInlineMessageBase : ITlSerializable, ITlDeserializable<BotInlineMessageBase> {
        public int Flags {get;set;} = default!;
        public ReplyMarkupBase? ReplyMarkup {get;set;} = default!;
        public static BotInlineMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotInlineMessageNs.BotInlineMessageMediaAuto.Identifier))
                return Tel.BotInlineMessageNs.BotInlineMessageMediaAuto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotInlineMessageNs.BotInlineMessageText.Identifier))
                return Tel.BotInlineMessageNs.BotInlineMessageText.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotInlineMessageNs.BotInlineMessageMediaGeo.Identifier))
                return Tel.BotInlineMessageNs.BotInlineMessageMediaGeo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotInlineMessageNs.BotInlineMessageMediaVenue.Identifier))
                return Tel.BotInlineMessageNs.BotInlineMessageMediaVenue.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotInlineMessageNs.BotInlineMessageMediaContact.Identifier))
                return Tel.BotInlineMessageNs.BotInlineMessageMediaContact.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotInlineMessageNs.BotInlineMessageMediaInvoice.Identifier))
                return Tel.BotInlineMessageNs.BotInlineMessageMediaInvoice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotInlineMessageNs.BotInlineMessageMediaWebPage.Identifier))
                return Tel.BotInlineMessageNs.BotInlineMessageMediaWebPage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotInlineMessageNs.BotInlineMessageMediaAuto BotInlineMessageMediaAuto1984755728 => BotInlineMessageMediaAuto1984755728.TlSerialize(),
            Tel.BotInlineMessageNs.BotInlineMessageText BotInlineMessageText1937807902 => BotInlineMessageText1937807902.TlSerialize(),
            Tel.BotInlineMessageNs.BotInlineMessageMediaGeo BotInlineMessageMediaGeo85477117 => BotInlineMessageMediaGeo85477117.TlSerialize(),
            Tel.BotInlineMessageNs.BotInlineMessageMediaVenue BotInlineMessageMediaVenue1970903652 => BotInlineMessageMediaVenue1970903652.TlSerialize(),
            Tel.BotInlineMessageNs.BotInlineMessageMediaContact BotInlineMessageMediaContact416402882 => BotInlineMessageMediaContact416402882.TlSerialize(),
            Tel.BotInlineMessageNs.BotInlineMessageMediaInvoice BotInlineMessageMediaInvoice894081801 => BotInlineMessageMediaInvoice894081801.TlSerialize(),
            Tel.BotInlineMessageNs.BotInlineMessageMediaWebPage BotInlineMessageMediaWebPage2137335386 => BotInlineMessageMediaWebPage2137335386.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotInlineResult, BotInlineMediaResult,
    public abstract class BotInlineResultBase : ITlSerializable, ITlDeserializable<BotInlineResultBase> {
        public int Flags {get;set;} = default!;
        public string Id {get;set;} = default!;
        public string Type {get;set;} = default!;
        public string? Title {get;set;} = default!;
        public string? Description {get;set;} = default!;
        public BotInlineMessageBase SendMessage {get;set;} = default!;
        public static BotInlineResultBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotInlineResultNs.BotInlineResult.Identifier))
                return Tel.BotInlineResultNs.BotInlineResult.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotInlineResultNs.BotInlineMediaResult.Identifier))
                return Tel.BotInlineResultNs.BotInlineMediaResult.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotInlineResultNs.BotInlineResult BotInlineResult295067450 => BotInlineResult295067450.TlSerialize(),
            Tel.BotInlineResultNs.BotInlineMediaResult BotInlineMediaResult400266251 => BotInlineMediaResult400266251.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesBotResults,
    public abstract class MessagesBotResultsBase : ITlSerializable, ITlDeserializable<MessagesBotResultsBase> {
        public static MessagesBotResultsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesBotResultsNs.MessagesBotResults.Identifier))
                return Tel.MessagesBotResultsNs.MessagesBotResults.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesBotResultsNs.MessagesBotResults MessagesBotResults534646026 => MessagesBotResults534646026.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ExportedMessageLink,
    public abstract class ExportedMessageLinkBase : ITlSerializable, ITlDeserializable<ExportedMessageLinkBase> {
        public static ExportedMessageLinkBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ExportedMessageLinkNs.ExportedMessageLink.Identifier))
                return Tel.ExportedMessageLinkNs.ExportedMessageLink.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ExportedMessageLinkNs.ExportedMessageLink ExportedMessageLink1571494644 => ExportedMessageLink1571494644.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageFwdHeader,
    public abstract class MessageFwdHeaderBase : ITlSerializable, ITlDeserializable<MessageFwdHeaderBase> {
        public static MessageFwdHeaderBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageFwdHeaderNs.MessageFwdHeader.Identifier))
                return Tel.MessageFwdHeaderNs.MessageFwdHeader.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageFwdHeaderNs.MessageFwdHeader MessageFwdHeader1313731771 => MessageFwdHeader1313731771.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AuthCodeTypeSms, AuthCodeTypeCall, AuthCodeTypeFlashCall, AuthCodeTypeMissedCall, AuthCodeTypeFragmentSms,
    public abstract class AuthCodeTypeBase : ITlSerializable, ITlDeserializable<AuthCodeTypeBase> {
        public static AuthCodeTypeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthCodeTypeNs.AuthCodeTypeSms.Identifier))
                return Tel.AuthCodeTypeNs.AuthCodeTypeSms.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthCodeTypeNs.AuthCodeTypeCall.Identifier))
                return Tel.AuthCodeTypeNs.AuthCodeTypeCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthCodeTypeNs.AuthCodeTypeFlashCall.Identifier))
                return Tel.AuthCodeTypeNs.AuthCodeTypeFlashCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthCodeTypeNs.AuthCodeTypeMissedCall.Identifier))
                return Tel.AuthCodeTypeNs.AuthCodeTypeMissedCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthCodeTypeNs.AuthCodeTypeFragmentSms.Identifier))
                return Tel.AuthCodeTypeNs.AuthCodeTypeFragmentSms.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthCodeTypeNs.AuthCodeTypeSms AuthCodeTypeSms1923290508 => AuthCodeTypeSms1923290508.TlSerialize(),
            Tel.AuthCodeTypeNs.AuthCodeTypeCall AuthCodeTypeCall1948046307 => AuthCodeTypeCall1948046307.TlSerialize(),
            Tel.AuthCodeTypeNs.AuthCodeTypeFlashCall AuthCodeTypeFlashCall577556219 => AuthCodeTypeFlashCall577556219.TlSerialize(),
            Tel.AuthCodeTypeNs.AuthCodeTypeMissedCall AuthCodeTypeMissedCall702884114 => AuthCodeTypeMissedCall702884114.TlSerialize(),
            Tel.AuthCodeTypeNs.AuthCodeTypeFragmentSms AuthCodeTypeFragmentSms116234636 => AuthCodeTypeFragmentSms116234636.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AuthSentCodeTypeApp, AuthSentCodeTypeSms, AuthSentCodeTypeCall, AuthSentCodeTypeFlashCall, AuthSentCodeTypeMissedCall, AuthSentCodeTypeEmailCode, AuthSentCodeTypeSetUpEmailRequired, AuthSentCodeTypeFragmentSms, AuthSentCodeTypeFirebaseSms, AuthSentCodeTypeSmsWord, AuthSentCodeTypeSmsPhrase,
    public abstract class AuthSentCodeTypeBase : ITlSerializable, ITlDeserializable<AuthSentCodeTypeBase> {
        public static AuthSentCodeTypeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeApp.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeApp.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSms.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSms.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeCall.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFlashCall.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFlashCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeMissedCall.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeMissedCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeEmailCode.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeEmailCode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSetUpEmailRequired.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSetUpEmailRequired.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFragmentSms.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFragmentSms.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFirebaseSms.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFirebaseSms.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSmsWord.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSmsWord.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSmsPhrase.Identifier))
                return Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSmsPhrase.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeApp AuthSentCodeTypeApp1035688326 => AuthSentCodeTypeApp1035688326.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSms AuthSentCodeTypeSms1073693790 => AuthSentCodeTypeSms1073693790.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeCall AuthSentCodeTypeCall1398007207 => AuthSentCodeTypeCall1398007207.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFlashCall AuthSentCodeTypeFlashCall1425815847 => AuthSentCodeTypeFlashCall1425815847.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeMissedCall AuthSentCodeTypeMissedCall2113903484 => AuthSentCodeTypeMissedCall2113903484.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeEmailCode AuthSentCodeTypeEmailCode196020837 => AuthSentCodeTypeEmailCode196020837.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSetUpEmailRequired AuthSentCodeTypeSetUpEmailRequired1521934870 => AuthSentCodeTypeSetUpEmailRequired1521934870.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFragmentSms AuthSentCodeTypeFragmentSms648651719 => AuthSentCodeTypeFragmentSms648651719.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeFirebaseSms AuthSentCodeTypeFirebaseSms10475318 => AuthSentCodeTypeFirebaseSms10475318.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSmsWord AuthSentCodeTypeSmsWord1542017919 => AuthSentCodeTypeSmsWord1542017919.TlSerialize(),
            Tel.AuthSentCodeTypeNs.AuthSentCodeTypeSmsPhrase AuthSentCodeTypeSmsPhrase1284008785 => AuthSentCodeTypeSmsPhrase1284008785.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesBotCallbackAnswer,
    public abstract class MessagesBotCallbackAnswerBase : ITlSerializable, ITlDeserializable<MessagesBotCallbackAnswerBase> {
        public static MessagesBotCallbackAnswerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesBotCallbackAnswerNs.MessagesBotCallbackAnswer.Identifier))
                return Tel.MessagesBotCallbackAnswerNs.MessagesBotCallbackAnswer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesBotCallbackAnswerNs.MessagesBotCallbackAnswer MessagesBotCallbackAnswer911761060 => MessagesBotCallbackAnswer911761060.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesMessageEditData,
    public abstract class MessagesMessageEditDataBase : ITlSerializable, ITlDeserializable<MessagesMessageEditDataBase> {
        public static MessagesMessageEditDataBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesMessageEditDataNs.MessagesMessageEditData.Identifier))
                return Tel.MessagesMessageEditDataNs.MessagesMessageEditData.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesMessageEditDataNs.MessagesMessageEditData MessagesMessageEditData649453030 => MessagesMessageEditData649453030.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBotInlineMessageID, InputBotInlineMessageID64,
    public abstract class InputBotInlineMessageIDBase : ITlSerializable, ITlDeserializable<InputBotInlineMessageIDBase> {
        public int DcId {get;set;} = default!;
        public long AccessHash {get;set;} = default!;
        public static InputBotInlineMessageIDBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBotInlineMessageIDNs.InputBotInlineMessageID.Identifier))
                return Tel.InputBotInlineMessageIDNs.InputBotInlineMessageID.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotInlineMessageIDNs.InputBotInlineMessageID64.Identifier))
                return Tel.InputBotInlineMessageIDNs.InputBotInlineMessageID64.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBotInlineMessageIDNs.InputBotInlineMessageID InputBotInlineMessageID1995686519 => InputBotInlineMessageID1995686519.TlSerialize(),
            Tel.InputBotInlineMessageIDNs.InputBotInlineMessageID64 InputBotInlineMessageID641227287081 => InputBotInlineMessageID641227287081.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InlineBotSwitchPM,
    public abstract class InlineBotSwitchPMBase : ITlSerializable, ITlDeserializable<InlineBotSwitchPMBase> {
        public static InlineBotSwitchPMBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InlineBotSwitchPMNs.InlineBotSwitchPM.Identifier))
                return Tel.InlineBotSwitchPMNs.InlineBotSwitchPM.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InlineBotSwitchPMNs.InlineBotSwitchPM InlineBotSwitchPM1008755359 => InlineBotSwitchPM1008755359.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesPeerDialogs,
    public abstract class MessagesPeerDialogsBase : ITlSerializable, ITlDeserializable<MessagesPeerDialogsBase> {
        public static MessagesPeerDialogsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesPeerDialogsNs.MessagesPeerDialogs.Identifier))
                return Tel.MessagesPeerDialogsNs.MessagesPeerDialogs.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesPeerDialogsNs.MessagesPeerDialogs MessagesPeerDialogs863093588 => MessagesPeerDialogs863093588.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: TopPeer,
    public abstract class TopPeerBase : ITlSerializable, ITlDeserializable<TopPeerBase> {
        public static TopPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.TopPeerNs.TopPeer.Identifier))
                return Tel.TopPeerNs.TopPeer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.TopPeerNs.TopPeer TopPeer305282981 => TopPeer305282981.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: TopPeerCategoryBotsPM, TopPeerCategoryBotsInline, TopPeerCategoryCorrespondents, TopPeerCategoryGroups, TopPeerCategoryChannels, TopPeerCategoryPhoneCalls, TopPeerCategoryForwardUsers, TopPeerCategoryForwardChats,
    public abstract class TopPeerCategoryBase : ITlSerializable, ITlDeserializable<TopPeerCategoryBase> {
        public static TopPeerCategoryBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.TopPeerCategoryNs.TopPeerCategoryBotsPM.Identifier))
                return Tel.TopPeerCategoryNs.TopPeerCategoryBotsPM.TlDeserialize(des);
            if (id.SequenceEqual(Tel.TopPeerCategoryNs.TopPeerCategoryBotsInline.Identifier))
                return Tel.TopPeerCategoryNs.TopPeerCategoryBotsInline.TlDeserialize(des);
            if (id.SequenceEqual(Tel.TopPeerCategoryNs.TopPeerCategoryCorrespondents.Identifier))
                return Tel.TopPeerCategoryNs.TopPeerCategoryCorrespondents.TlDeserialize(des);
            if (id.SequenceEqual(Tel.TopPeerCategoryNs.TopPeerCategoryGroups.Identifier))
                return Tel.TopPeerCategoryNs.TopPeerCategoryGroups.TlDeserialize(des);
            if (id.SequenceEqual(Tel.TopPeerCategoryNs.TopPeerCategoryChannels.Identifier))
                return Tel.TopPeerCategoryNs.TopPeerCategoryChannels.TlDeserialize(des);
            if (id.SequenceEqual(Tel.TopPeerCategoryNs.TopPeerCategoryPhoneCalls.Identifier))
                return Tel.TopPeerCategoryNs.TopPeerCategoryPhoneCalls.TlDeserialize(des);
            if (id.SequenceEqual(Tel.TopPeerCategoryNs.TopPeerCategoryForwardUsers.Identifier))
                return Tel.TopPeerCategoryNs.TopPeerCategoryForwardUsers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.TopPeerCategoryNs.TopPeerCategoryForwardChats.Identifier))
                return Tel.TopPeerCategoryNs.TopPeerCategoryForwardChats.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.TopPeerCategoryNs.TopPeerCategoryBotsPM TopPeerCategoryBotsPM1419371685 => TopPeerCategoryBotsPM1419371685.TlSerialize(),
            Tel.TopPeerCategoryNs.TopPeerCategoryBotsInline TopPeerCategoryBotsInline344356834 => TopPeerCategoryBotsInline344356834.TlSerialize(),
            Tel.TopPeerCategoryNs.TopPeerCategoryCorrespondents TopPeerCategoryCorrespondents104314861 => TopPeerCategoryCorrespondents104314861.TlSerialize(),
            Tel.TopPeerCategoryNs.TopPeerCategoryGroups TopPeerCategoryGroups1122524854 => TopPeerCategoryGroups1122524854.TlSerialize(),
            Tel.TopPeerCategoryNs.TopPeerCategoryChannels TopPeerCategoryChannels371037736 => TopPeerCategoryChannels371037736.TlSerialize(),
            Tel.TopPeerCategoryNs.TopPeerCategoryPhoneCalls TopPeerCategoryPhoneCalls511092620 => TopPeerCategoryPhoneCalls511092620.TlSerialize(),
            Tel.TopPeerCategoryNs.TopPeerCategoryForwardUsers TopPeerCategoryForwardUsers1472172887 => TopPeerCategoryForwardUsers1472172887.TlSerialize(),
            Tel.TopPeerCategoryNs.TopPeerCategoryForwardChats TopPeerCategoryForwardChats68239120 => TopPeerCategoryForwardChats68239120.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: TopPeerCategoryPeers,
    public abstract class TopPeerCategoryPeersBase : ITlSerializable, ITlDeserializable<TopPeerCategoryPeersBase> {
        public static TopPeerCategoryPeersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.TopPeerCategoryPeersNs.TopPeerCategoryPeers.Identifier))
                return Tel.TopPeerCategoryPeersNs.TopPeerCategoryPeers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.TopPeerCategoryPeersNs.TopPeerCategoryPeers TopPeerCategoryPeers75283823 => TopPeerCategoryPeers75283823.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactsTopPeersNotModified, ContactsTopPeers, ContactsTopPeersDisabled,
    public abstract class ContactsTopPeersBase : ITlSerializable, ITlDeserializable<ContactsTopPeersBase> {
        public static ContactsTopPeersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactsTopPeersNs.ContactsTopPeersNotModified.Identifier))
                return Tel.ContactsTopPeersNs.ContactsTopPeersNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ContactsTopPeersNs.ContactsTopPeers.Identifier))
                return Tel.ContactsTopPeersNs.ContactsTopPeers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ContactsTopPeersNs.ContactsTopPeersDisabled.Identifier))
                return Tel.ContactsTopPeersNs.ContactsTopPeersDisabled.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactsTopPeersNs.ContactsTopPeersNotModified ContactsTopPeersNotModified567906571 => ContactsTopPeersNotModified567906571.TlSerialize(),
            Tel.ContactsTopPeersNs.ContactsTopPeers ContactsTopPeers1891070632 => ContactsTopPeers1891070632.TlSerialize(),
            Tel.ContactsTopPeersNs.ContactsTopPeersDisabled ContactsTopPeersDisabled1255369827 => ContactsTopPeersDisabled1255369827.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DraftMessageEmpty, DraftMessage,
    public abstract class DraftMessageBase : ITlSerializable, ITlDeserializable<DraftMessageBase> {
        public int Flags {get;set;} = default!;
        public static DraftMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DraftMessageNs.DraftMessageEmpty.Identifier))
                return Tel.DraftMessageNs.DraftMessageEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DraftMessageNs.DraftMessage.Identifier))
                return Tel.DraftMessageNs.DraftMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DraftMessageNs.DraftMessageEmpty DraftMessageEmpty453805082 => DraftMessageEmpty453805082.TlSerialize(),
            Tel.DraftMessageNs.DraftMessage DraftMessage761606687 => DraftMessage761606687.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesFeaturedStickersNotModified, MessagesFeaturedStickers,
    public abstract class MessagesFeaturedStickersBase : ITlSerializable, ITlDeserializable<MessagesFeaturedStickersBase> {
        public int Count {get;set;} = default!;
        public static MessagesFeaturedStickersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesFeaturedStickersNs.MessagesFeaturedStickersNotModified.Identifier))
                return Tel.MessagesFeaturedStickersNs.MessagesFeaturedStickersNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFeaturedStickersNs.MessagesFeaturedStickers.Identifier))
                return Tel.MessagesFeaturedStickersNs.MessagesFeaturedStickers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesFeaturedStickersNs.MessagesFeaturedStickersNotModified MessagesFeaturedStickersNotModified958657434 => MessagesFeaturedStickersNotModified958657434.TlSerialize(),
            Tel.MessagesFeaturedStickersNs.MessagesFeaturedStickers MessagesFeaturedStickers1103615738 => MessagesFeaturedStickers1103615738.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesRecentStickersNotModified, MessagesRecentStickers,
    public abstract class MessagesRecentStickersBase : ITlSerializable, ITlDeserializable<MessagesRecentStickersBase> {
        public static MessagesRecentStickersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesRecentStickersNs.MessagesRecentStickersNotModified.Identifier))
                return Tel.MessagesRecentStickersNs.MessagesRecentStickersNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesRecentStickersNs.MessagesRecentStickers.Identifier))
                return Tel.MessagesRecentStickersNs.MessagesRecentStickers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesRecentStickersNs.MessagesRecentStickersNotModified MessagesRecentStickersNotModified186120336 => MessagesRecentStickersNotModified186120336.TlSerialize(),
            Tel.MessagesRecentStickersNs.MessagesRecentStickers MessagesRecentStickers1999405994 => MessagesRecentStickers1999405994.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesArchivedStickers,
    public abstract class MessagesArchivedStickersBase : ITlSerializable, ITlDeserializable<MessagesArchivedStickersBase> {
        public static MessagesArchivedStickersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesArchivedStickersNs.MessagesArchivedStickers.Identifier))
                return Tel.MessagesArchivedStickersNs.MessagesArchivedStickers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesArchivedStickersNs.MessagesArchivedStickers MessagesArchivedStickers1338747336 => MessagesArchivedStickers1338747336.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesStickerSetInstallResultSuccess, MessagesStickerSetInstallResultArchive,
    public abstract class MessagesStickerSetInstallResultBase : ITlSerializable, ITlDeserializable<MessagesStickerSetInstallResultBase> {
        public static MessagesStickerSetInstallResultBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesStickerSetInstallResultNs.MessagesStickerSetInstallResultSuccess.Identifier))
                return Tel.MessagesStickerSetInstallResultNs.MessagesStickerSetInstallResultSuccess.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesStickerSetInstallResultNs.MessagesStickerSetInstallResultArchive.Identifier))
                return Tel.MessagesStickerSetInstallResultNs.MessagesStickerSetInstallResultArchive.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesStickerSetInstallResultNs.MessagesStickerSetInstallResultSuccess MessagesStickerSetInstallResultSuccess946083368 => MessagesStickerSetInstallResultSuccess946083368.TlSerialize(),
            Tel.MessagesStickerSetInstallResultNs.MessagesStickerSetInstallResultArchive MessagesStickerSetInstallResultArchive904138920 => MessagesStickerSetInstallResultArchive904138920.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StickerSetCovered, StickerSetMultiCovered, StickerSetFullCovered, StickerSetNoCovered,
    public abstract class StickerSetCoveredBase : ITlSerializable, ITlDeserializable<StickerSetCoveredBase> {
        public StickerSetBase Set {get;set;} = default!;
        public static StickerSetCoveredBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StickerSetCoveredNs.StickerSetCovered.Identifier))
                return Tel.StickerSetCoveredNs.StickerSetCovered.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StickerSetCoveredNs.StickerSetMultiCovered.Identifier))
                return Tel.StickerSetCoveredNs.StickerSetMultiCovered.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StickerSetCoveredNs.StickerSetFullCovered.Identifier))
                return Tel.StickerSetCoveredNs.StickerSetFullCovered.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StickerSetCoveredNs.StickerSetNoCovered.Identifier))
                return Tel.StickerSetCoveredNs.StickerSetNoCovered.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StickerSetCoveredNs.StickerSetCovered StickerSetCovered1678812626 => StickerSetCovered1678812626.TlSerialize(),
            Tel.StickerSetCoveredNs.StickerSetMultiCovered StickerSetMultiCovered872932635 => StickerSetMultiCovered872932635.TlSerialize(),
            Tel.StickerSetCoveredNs.StickerSetFullCovered StickerSetFullCovered1087454222 => StickerSetFullCovered1087454222.TlSerialize(),
            Tel.StickerSetCoveredNs.StickerSetNoCovered StickerSetNoCovered2008112412 => StickerSetNoCovered2008112412.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MaskCoords,
    public abstract class MaskCoordsBase : ITlSerializable, ITlDeserializable<MaskCoordsBase> {
        public static MaskCoordsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MaskCoordsNs.MaskCoords.Identifier))
                return Tel.MaskCoordsNs.MaskCoords.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MaskCoordsNs.MaskCoords MaskCoords1361650766 => MaskCoords1361650766.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputStickeredMediaPhoto, InputStickeredMediaDocument,
    public abstract class InputStickeredMediaBase : ITlSerializable, ITlDeserializable<InputStickeredMediaBase> {
        public static InputStickeredMediaBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputStickeredMediaNs.InputStickeredMediaPhoto.Identifier))
                return Tel.InputStickeredMediaNs.InputStickeredMediaPhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStickeredMediaNs.InputStickeredMediaDocument.Identifier))
                return Tel.InputStickeredMediaNs.InputStickeredMediaDocument.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputStickeredMediaNs.InputStickeredMediaPhoto InputStickeredMediaPhoto1251549527 => InputStickeredMediaPhoto1251549527.TlSerialize(),
            Tel.InputStickeredMediaNs.InputStickeredMediaDocument InputStickeredMediaDocument70813275 => InputStickeredMediaDocument70813275.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Game,
    public abstract class GameBase : ITlSerializable, ITlDeserializable<GameBase> {
        public static GameBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GameNs.Game.Identifier))
                return Tel.GameNs.Game.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GameNs.Game Game1107729093 => Game1107729093.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputGameID, InputGameShortName,
    public abstract class InputGameBase : ITlSerializable, ITlDeserializable<InputGameBase> {
        public static InputGameBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputGameNs.InputGameID.Identifier))
                return Tel.InputGameNs.InputGameID.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputGameNs.InputGameShortName.Identifier))
                return Tel.InputGameNs.InputGameShortName.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputGameNs.InputGameID InputGameID53231223 => InputGameID53231223.TlSerialize(),
            Tel.InputGameNs.InputGameShortName InputGameShortName1020139510 => InputGameShortName1020139510.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HighScore,
    public abstract class HighScoreBase : ITlSerializable, ITlDeserializable<HighScoreBase> {
        public static HighScoreBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HighScoreNs.HighScore.Identifier))
                return Tel.HighScoreNs.HighScore.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HighScoreNs.HighScore HighScore1940093419 => HighScore1940093419.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesHighScores,
    public abstract class MessagesHighScoresBase : ITlSerializable, ITlDeserializable<MessagesHighScoresBase> {
        public static MessagesHighScoresBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesHighScoresNs.MessagesHighScores.Identifier))
                return Tel.MessagesHighScoresNs.MessagesHighScores.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesHighScoresNs.MessagesHighScores MessagesHighScores1707344487 => MessagesHighScores1707344487.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: TextEmpty, TextPlain, TextBold, TextItalic, TextUnderline, TextStrike, TextFixed, TextUrl, TextEmail, TextConcat, TextSubscript, TextSuperscript, TextMarked, TextPhone, TextImage, TextAnchor,
    public abstract class RichTextBase : ITlSerializable, ITlDeserializable<RichTextBase> {
        public static RichTextBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.RichTextNs.TextEmpty.Identifier))
                return Tel.RichTextNs.TextEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextPlain.Identifier))
                return Tel.RichTextNs.TextPlain.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextBold.Identifier))
                return Tel.RichTextNs.TextBold.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextItalic.Identifier))
                return Tel.RichTextNs.TextItalic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextUnderline.Identifier))
                return Tel.RichTextNs.TextUnderline.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextStrike.Identifier))
                return Tel.RichTextNs.TextStrike.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextFixed.Identifier))
                return Tel.RichTextNs.TextFixed.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextUrl.Identifier))
                return Tel.RichTextNs.TextUrl.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextEmail.Identifier))
                return Tel.RichTextNs.TextEmail.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextConcat.Identifier))
                return Tel.RichTextNs.TextConcat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextSubscript.Identifier))
                return Tel.RichTextNs.TextSubscript.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextSuperscript.Identifier))
                return Tel.RichTextNs.TextSuperscript.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextMarked.Identifier))
                return Tel.RichTextNs.TextMarked.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextPhone.Identifier))
                return Tel.RichTextNs.TextPhone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextImage.Identifier))
                return Tel.RichTextNs.TextImage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RichTextNs.TextAnchor.Identifier))
                return Tel.RichTextNs.TextAnchor.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.RichTextNs.TextEmpty TextEmpty599948721 => TextEmpty599948721.TlSerialize(),
            Tel.RichTextNs.TextPlain TextPlain1950782688 => TextPlain1950782688.TlSerialize(),
            Tel.RichTextNs.TextBold TextBold1730456516 => TextBold1730456516.TlSerialize(),
            Tel.RichTextNs.TextItalic TextItalic653089380 => TextItalic653089380.TlSerialize(),
            Tel.RichTextNs.TextUnderline TextUnderline1054465340 => TextUnderline1054465340.TlSerialize(),
            Tel.RichTextNs.TextStrike TextStrike1678197867 => TextStrike1678197867.TlSerialize(),
            Tel.RichTextNs.TextFixed TextFixed1816074681 => TextFixed1816074681.TlSerialize(),
            Tel.RichTextNs.TextUrl TextUrl1009288385 => TextUrl1009288385.TlSerialize(),
            Tel.RichTextNs.TextEmail TextEmail564523562 => TextEmail564523562.TlSerialize(),
            Tel.RichTextNs.TextConcat TextConcat2120376535 => TextConcat2120376535.TlSerialize(),
            Tel.RichTextNs.TextSubscript TextSubscript311786236 => TextSubscript311786236.TlSerialize(),
            Tel.RichTextNs.TextSuperscript TextSuperscript939827711 => TextSuperscript939827711.TlSerialize(),
            Tel.RichTextNs.TextMarked TextMarked55281185 => TextMarked55281185.TlSerialize(),
            Tel.RichTextNs.TextPhone TextPhone483104362 => TextPhone483104362.TlSerialize(),
            Tel.RichTextNs.TextImage TextImage136105807 => TextImage136105807.TlSerialize(),
            Tel.RichTextNs.TextAnchor TextAnchor894777186 => TextAnchor894777186.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PageBlockUnsupported, PageBlockTitle, PageBlockSubtitle, PageBlockAuthorDate, PageBlockHeader, PageBlockSubheader, PageBlockParagraph, PageBlockPreformatted, PageBlockFooter, PageBlockDivider, PageBlockAnchor, PageBlockList, PageBlockBlockquote, PageBlockPullquote, PageBlockPhoto, PageBlockVideo, PageBlockCover, PageBlockEmbed, PageBlockEmbedPost, PageBlockCollage, PageBlockSlideshow, PageBlockChannel, PageBlockAudio, PageBlockKicker, PageBlockTable, PageBlockOrderedList, PageBlockDetails, PageBlockRelatedArticles, PageBlockMap,
    public abstract class PageBlockBase : ITlSerializable, ITlDeserializable<PageBlockBase> {
        public static PageBlockBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockUnsupported.Identifier))
                return Tel.PageBlockNs.PageBlockUnsupported.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockTitle.Identifier))
                return Tel.PageBlockNs.PageBlockTitle.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockSubtitle.Identifier))
                return Tel.PageBlockNs.PageBlockSubtitle.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockAuthorDate.Identifier))
                return Tel.PageBlockNs.PageBlockAuthorDate.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockHeader.Identifier))
                return Tel.PageBlockNs.PageBlockHeader.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockSubheader.Identifier))
                return Tel.PageBlockNs.PageBlockSubheader.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockParagraph.Identifier))
                return Tel.PageBlockNs.PageBlockParagraph.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockPreformatted.Identifier))
                return Tel.PageBlockNs.PageBlockPreformatted.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockFooter.Identifier))
                return Tel.PageBlockNs.PageBlockFooter.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockDivider.Identifier))
                return Tel.PageBlockNs.PageBlockDivider.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockAnchor.Identifier))
                return Tel.PageBlockNs.PageBlockAnchor.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockList.Identifier))
                return Tel.PageBlockNs.PageBlockList.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockBlockquote.Identifier))
                return Tel.PageBlockNs.PageBlockBlockquote.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockPullquote.Identifier))
                return Tel.PageBlockNs.PageBlockPullquote.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockPhoto.Identifier))
                return Tel.PageBlockNs.PageBlockPhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockVideo.Identifier))
                return Tel.PageBlockNs.PageBlockVideo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockCover.Identifier))
                return Tel.PageBlockNs.PageBlockCover.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockEmbed.Identifier))
                return Tel.PageBlockNs.PageBlockEmbed.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockEmbedPost.Identifier))
                return Tel.PageBlockNs.PageBlockEmbedPost.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockCollage.Identifier))
                return Tel.PageBlockNs.PageBlockCollage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockSlideshow.Identifier))
                return Tel.PageBlockNs.PageBlockSlideshow.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockChannel.Identifier))
                return Tel.PageBlockNs.PageBlockChannel.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockAudio.Identifier))
                return Tel.PageBlockNs.PageBlockAudio.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockKicker.Identifier))
                return Tel.PageBlockNs.PageBlockKicker.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockTable.Identifier))
                return Tel.PageBlockNs.PageBlockTable.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockOrderedList.Identifier))
                return Tel.PageBlockNs.PageBlockOrderedList.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockDetails.Identifier))
                return Tel.PageBlockNs.PageBlockDetails.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockRelatedArticles.Identifier))
                return Tel.PageBlockNs.PageBlockRelatedArticles.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageBlockNs.PageBlockMap.Identifier))
                return Tel.PageBlockNs.PageBlockMap.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PageBlockNs.PageBlockUnsupported PageBlockUnsupported324435594 => PageBlockUnsupported324435594.TlSerialize(),
            Tel.PageBlockNs.PageBlockTitle PageBlockTitle1890305021 => PageBlockTitle1890305021.TlSerialize(),
            Tel.PageBlockNs.PageBlockSubtitle PageBlockSubtitle1879401953 => PageBlockSubtitle1879401953.TlSerialize(),
            Tel.PageBlockNs.PageBlockAuthorDate PageBlockAuthorDate1162877472 => PageBlockAuthorDate1162877472.TlSerialize(),
            Tel.PageBlockNs.PageBlockHeader PageBlockHeader1076861716 => PageBlockHeader1076861716.TlSerialize(),
            Tel.PageBlockNs.PageBlockSubheader PageBlockSubheader248793375 => PageBlockSubheader248793375.TlSerialize(),
            Tel.PageBlockNs.PageBlockParagraph PageBlockParagraph1182402406 => PageBlockParagraph1182402406.TlSerialize(),
            Tel.PageBlockNs.PageBlockPreformatted PageBlockPreformatted1066346178 => PageBlockPreformatted1066346178.TlSerialize(),
            Tel.PageBlockNs.PageBlockFooter PageBlockFooter1216809369 => PageBlockFooter1216809369.TlSerialize(),
            Tel.PageBlockNs.PageBlockDivider PageBlockDivider618614392 => PageBlockDivider618614392.TlSerialize(),
            Tel.PageBlockNs.PageBlockAnchor PageBlockAnchor837994576 => PageBlockAnchor837994576.TlSerialize(),
            Tel.PageBlockNs.PageBlockList PageBlockList454524911 => PageBlockList454524911.TlSerialize(),
            Tel.PageBlockNs.PageBlockBlockquote PageBlockBlockquote641563686 => PageBlockBlockquote641563686.TlSerialize(),
            Tel.PageBlockNs.PageBlockPullquote PageBlockPullquote1329878739 => PageBlockPullquote1329878739.TlSerialize(),
            Tel.PageBlockNs.PageBlockPhoto PageBlockPhoto391759200 => PageBlockPhoto391759200.TlSerialize(),
            Tel.PageBlockNs.PageBlockVideo PageBlockVideo2089805750 => PageBlockVideo2089805750.TlSerialize(),
            Tel.PageBlockNs.PageBlockCover PageBlockCover972174080 => PageBlockCover972174080.TlSerialize(),
            Tel.PageBlockNs.PageBlockEmbed PageBlockEmbed1468953147 => PageBlockEmbed1468953147.TlSerialize(),
            Tel.PageBlockNs.PageBlockEmbedPost PageBlockEmbedPost229005301 => PageBlockEmbedPost229005301.TlSerialize(),
            Tel.PageBlockNs.PageBlockCollage PageBlockCollage1705048653 => PageBlockCollage1705048653.TlSerialize(),
            Tel.PageBlockNs.PageBlockSlideshow PageBlockSlideshow52401552 => PageBlockSlideshow52401552.TlSerialize(),
            Tel.PageBlockNs.PageBlockChannel PageBlockChannel283684427 => PageBlockChannel283684427.TlSerialize(),
            Tel.PageBlockNs.PageBlockAudio PageBlockAudio2143067670 => PageBlockAudio2143067670.TlSerialize(),
            Tel.PageBlockNs.PageBlockKicker PageBlockKicker504660880 => PageBlockKicker504660880.TlSerialize(),
            Tel.PageBlockNs.PageBlockTable PageBlockTable1085412734 => PageBlockTable1085412734.TlSerialize(),
            Tel.PageBlockNs.PageBlockOrderedList PageBlockOrderedList1702174239 => PageBlockOrderedList1702174239.TlSerialize(),
            Tel.PageBlockNs.PageBlockDetails PageBlockDetails1987480557 => PageBlockDetails1987480557.TlSerialize(),
            Tel.PageBlockNs.PageBlockRelatedArticles PageBlockRelatedArticles370236054 => PageBlockRelatedArticles370236054.TlSerialize(),
            Tel.PageBlockNs.PageBlockMap PageBlockMap1538310410 => PageBlockMap1538310410.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneCallDiscardReasonMissed, PhoneCallDiscardReasonDisconnect, PhoneCallDiscardReasonHangup, PhoneCallDiscardReasonBusy,
    public abstract class PhoneCallDiscardReasonBase : ITlSerializable, ITlDeserializable<PhoneCallDiscardReasonBase> {
        public static PhoneCallDiscardReasonBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonMissed.Identifier))
                return Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonMissed.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonDisconnect.Identifier))
                return Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonDisconnect.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonHangup.Identifier))
                return Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonHangup.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonBusy.Identifier))
                return Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonBusy.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonMissed PhoneCallDiscardReasonMissed2048646399 => PhoneCallDiscardReasonMissed2048646399.TlSerialize(),
            Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonDisconnect PhoneCallDiscardReasonDisconnect527056480 => PhoneCallDiscardReasonDisconnect527056480.TlSerialize(),
            Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonHangup PhoneCallDiscardReasonHangup1471006352 => PhoneCallDiscardReasonHangup1471006352.TlSerialize(),
            Tel.PhoneCallDiscardReasonNs.PhoneCallDiscardReasonBusy PhoneCallDiscardReasonBusy84416311 => PhoneCallDiscardReasonBusy84416311.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DataJSON,
    public abstract class DataJSONBase : ITlSerializable, ITlDeserializable<DataJSONBase> {
        public static DataJSONBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DataJSONNs.DataJSON.Identifier))
                return Tel.DataJSONNs.DataJSON.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DataJSONNs.DataJSON DataJSON2104790276 => DataJSON2104790276.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: LabeledPrice,
    public abstract class LabeledPriceBase : ITlSerializable, ITlDeserializable<LabeledPriceBase> {
        public static LabeledPriceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.LabeledPriceNs.LabeledPrice.Identifier))
                return Tel.LabeledPriceNs.LabeledPrice.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.LabeledPriceNs.LabeledPrice LabeledPrice886477832 => LabeledPrice886477832.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Invoice,
    public abstract class InvoiceBase : ITlSerializable, ITlDeserializable<InvoiceBase> {
        public static InvoiceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InvoiceNs.Invoice.Identifier))
                return Tel.InvoiceNs.Invoice.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InvoiceNs.Invoice Invoice1572428309 => Invoice1572428309.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentCharge,
    public abstract class PaymentChargeBase : ITlSerializable, ITlDeserializable<PaymentChargeBase> {
        public static PaymentChargeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentChargeNs.PaymentCharge.Identifier))
                return Tel.PaymentChargeNs.PaymentCharge.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentChargeNs.PaymentCharge PaymentCharge368917890 => PaymentCharge368917890.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PostAddress,
    public abstract class PostAddressBase : ITlSerializable, ITlDeserializable<PostAddressBase> {
        public static PostAddressBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PostAddressNs.PostAddress.Identifier))
                return Tel.PostAddressNs.PostAddress.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PostAddressNs.PostAddress PostAddress512535275 => PostAddress512535275.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentRequestedInfo,
    public abstract class PaymentRequestedInfoBase : ITlSerializable, ITlDeserializable<PaymentRequestedInfoBase> {
        public static PaymentRequestedInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentRequestedInfoNs.PaymentRequestedInfo.Identifier))
                return Tel.PaymentRequestedInfoNs.PaymentRequestedInfo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentRequestedInfoNs.PaymentRequestedInfo PaymentRequestedInfo1868808300 => PaymentRequestedInfo1868808300.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentSavedCredentialsCard,
    public abstract class PaymentSavedCredentialsBase : ITlSerializable, ITlDeserializable<PaymentSavedCredentialsBase> {
        public static PaymentSavedCredentialsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentSavedCredentialsNs.PaymentSavedCredentialsCard.Identifier))
                return Tel.PaymentSavedCredentialsNs.PaymentSavedCredentialsCard.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentSavedCredentialsNs.PaymentSavedCredentialsCard PaymentSavedCredentialsCard842892769 => PaymentSavedCredentialsCard842892769.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: WebDocument, WebDocumentNoProxy,
    public abstract class WebDocumentBase : ITlSerializable, ITlDeserializable<WebDocumentBase> {
        public string Url {get;set;} = default!;
        public int Size {get;set;} = default!;
        public string MimeType {get;set;} = default!;
        public List<DocumentAttributeBase> Attributes {get;set;} = default!;
        public static WebDocumentBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.WebDocumentNs.WebDocument.Identifier))
                return Tel.WebDocumentNs.WebDocument.TlDeserialize(des);
            if (id.SequenceEqual(Tel.WebDocumentNs.WebDocumentNoProxy.Identifier))
                return Tel.WebDocumentNs.WebDocumentNoProxy.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.WebDocumentNs.WebDocument WebDocument475467473 => WebDocument475467473.TlSerialize(),
            Tel.WebDocumentNs.WebDocumentNoProxy WebDocumentNoProxy104284986 => WebDocumentNoProxy104284986.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputWebDocument,
    public abstract class InputWebDocumentBase : ITlSerializable, ITlDeserializable<InputWebDocumentBase> {
        public static InputWebDocumentBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputWebDocumentNs.InputWebDocument.Identifier))
                return Tel.InputWebDocumentNs.InputWebDocument.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputWebDocumentNs.InputWebDocument InputWebDocument1678949555 => InputWebDocument1678949555.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputWebFileLocation, InputWebFileGeoPointLocation, InputWebFileAudioAlbumThumbLocation,
    public abstract class InputWebFileLocationBase : ITlSerializable, ITlDeserializable<InputWebFileLocationBase> {
        public static InputWebFileLocationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputWebFileLocationNs.InputWebFileLocation.Identifier))
                return Tel.InputWebFileLocationNs.InputWebFileLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputWebFileLocationNs.InputWebFileGeoPointLocation.Identifier))
                return Tel.InputWebFileLocationNs.InputWebFileGeoPointLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputWebFileLocationNs.InputWebFileAudioAlbumThumbLocation.Identifier))
                return Tel.InputWebFileLocationNs.InputWebFileAudioAlbumThumbLocation.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputWebFileLocationNs.InputWebFileLocation InputWebFileLocation1036396922 => InputWebFileLocation1036396922.TlSerialize(),
            Tel.InputWebFileLocationNs.InputWebFileGeoPointLocation InputWebFileGeoPointLocation1625153079 => InputWebFileGeoPointLocation1625153079.TlSerialize(),
            Tel.InputWebFileLocationNs.InputWebFileAudioAlbumThumbLocation InputWebFileAudioAlbumThumbLocation193992412 => InputWebFileAudioAlbumThumbLocation193992412.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UploadWebFile,
    public abstract class UploadWebFileBase : ITlSerializable, ITlDeserializable<UploadWebFileBase> {
        public static UploadWebFileBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UploadWebFileNs.UploadWebFile.Identifier))
                return Tel.UploadWebFileNs.UploadWebFile.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UploadWebFileNs.UploadWebFile UploadWebFile568808380 => UploadWebFile568808380.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsPaymentForm, PaymentsPaymentFormStars,
    public abstract class PaymentsPaymentFormBase : ITlSerializable, ITlDeserializable<PaymentsPaymentFormBase> {
        public int Flags {get;set;} = default!;
        public long FormId {get;set;} = default!;
        public long BotId {get;set;} = default!;
        public string Title {get;set;} = default!;
        public string Description {get;set;} = default!;
        public WebDocumentBase? Photo {get;set;} = default!;
        public InvoiceBase Invoice {get;set;} = default!;
        public List<UserBase> Users {get;set;} = default!;
        public static PaymentsPaymentFormBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsPaymentFormNs.PaymentsPaymentForm.Identifier))
                return Tel.PaymentsPaymentFormNs.PaymentsPaymentForm.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PaymentsPaymentFormNs.PaymentsPaymentFormStars.Identifier))
                return Tel.PaymentsPaymentFormNs.PaymentsPaymentFormStars.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsPaymentFormNs.PaymentsPaymentForm PaymentsPaymentForm1610250415 => PaymentsPaymentForm1610250415.TlSerialize(),
            Tel.PaymentsPaymentFormNs.PaymentsPaymentFormStars PaymentsPaymentFormStars2079764828 => PaymentsPaymentFormStars2079764828.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsValidatedRequestedInfo,
    public abstract class PaymentsValidatedRequestedInfoBase : ITlSerializable, ITlDeserializable<PaymentsValidatedRequestedInfoBase> {
        public static PaymentsValidatedRequestedInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsValidatedRequestedInfoNs.PaymentsValidatedRequestedInfo.Identifier))
                return Tel.PaymentsValidatedRequestedInfoNs.PaymentsValidatedRequestedInfo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsValidatedRequestedInfoNs.PaymentsValidatedRequestedInfo PaymentsValidatedRequestedInfo784000893 => PaymentsValidatedRequestedInfo784000893.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsPaymentResult, PaymentsPaymentVerificationNeeded,
    public abstract class PaymentsPaymentResultBase : ITlSerializable, ITlDeserializable<PaymentsPaymentResultBase> {
        public static PaymentsPaymentResultBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsPaymentResultNs.PaymentsPaymentResult.Identifier))
                return Tel.PaymentsPaymentResultNs.PaymentsPaymentResult.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PaymentsPaymentResultNs.PaymentsPaymentVerificationNeeded.Identifier))
                return Tel.PaymentsPaymentResultNs.PaymentsPaymentVerificationNeeded.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsPaymentResultNs.PaymentsPaymentResult PaymentsPaymentResult1314881805 => PaymentsPaymentResult1314881805.TlSerialize(),
            Tel.PaymentsPaymentResultNs.PaymentsPaymentVerificationNeeded PaymentsPaymentVerificationNeeded666824391 => PaymentsPaymentVerificationNeeded666824391.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsPaymentReceipt, PaymentsPaymentReceiptStars,
    public abstract class PaymentsPaymentReceiptBase : ITlSerializable, ITlDeserializable<PaymentsPaymentReceiptBase> {
        public int Flags {get;set;} = default!;
        public int Date {get;set;} = default!;
        public long BotId {get;set;} = default!;
        public string Title {get;set;} = default!;
        public string Description {get;set;} = default!;
        public WebDocumentBase? Photo {get;set;} = default!;
        public InvoiceBase Invoice {get;set;} = default!;
        public string Currency {get;set;} = default!;
        public long TotalAmount {get;set;} = default!;
        public List<UserBase> Users {get;set;} = default!;
        public static PaymentsPaymentReceiptBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsPaymentReceiptNs.PaymentsPaymentReceipt.Identifier))
                return Tel.PaymentsPaymentReceiptNs.PaymentsPaymentReceipt.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PaymentsPaymentReceiptNs.PaymentsPaymentReceiptStars.Identifier))
                return Tel.PaymentsPaymentReceiptNs.PaymentsPaymentReceiptStars.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsPaymentReceiptNs.PaymentsPaymentReceipt PaymentsPaymentReceipt1891958275 => PaymentsPaymentReceipt1891958275.TlSerialize(),
            Tel.PaymentsPaymentReceiptNs.PaymentsPaymentReceiptStars PaymentsPaymentReceiptStars625215430 => PaymentsPaymentReceiptStars625215430.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsSavedInfo,
    public abstract class PaymentsSavedInfoBase : ITlSerializable, ITlDeserializable<PaymentsSavedInfoBase> {
        public static PaymentsSavedInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsSavedInfoNs.PaymentsSavedInfo.Identifier))
                return Tel.PaymentsSavedInfoNs.PaymentsSavedInfo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsSavedInfoNs.PaymentsSavedInfo PaymentsSavedInfo74456004 => PaymentsSavedInfo74456004.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputPaymentCredentialsSaved, InputPaymentCredentials, InputPaymentCredentialsApplePay, InputPaymentCredentialsGooglePay,
    public abstract class InputPaymentCredentialsBase : ITlSerializable, ITlDeserializable<InputPaymentCredentialsBase> {
        public static InputPaymentCredentialsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputPaymentCredentialsNs.InputPaymentCredentialsSaved.Identifier))
                return Tel.InputPaymentCredentialsNs.InputPaymentCredentialsSaved.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPaymentCredentialsNs.InputPaymentCredentials.Identifier))
                return Tel.InputPaymentCredentialsNs.InputPaymentCredentials.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPaymentCredentialsNs.InputPaymentCredentialsApplePay.Identifier))
                return Tel.InputPaymentCredentialsNs.InputPaymentCredentialsApplePay.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputPaymentCredentialsNs.InputPaymentCredentialsGooglePay.Identifier))
                return Tel.InputPaymentCredentialsNs.InputPaymentCredentialsGooglePay.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputPaymentCredentialsNs.InputPaymentCredentialsSaved InputPaymentCredentialsSaved1056001329 => InputPaymentCredentialsSaved1056001329.TlSerialize(),
            Tel.InputPaymentCredentialsNs.InputPaymentCredentials InputPaymentCredentials873977640 => InputPaymentCredentials873977640.TlSerialize(),
            Tel.InputPaymentCredentialsNs.InputPaymentCredentialsApplePay InputPaymentCredentialsApplePay178373535 => InputPaymentCredentialsApplePay178373535.TlSerialize(),
            Tel.InputPaymentCredentialsNs.InputPaymentCredentialsGooglePay InputPaymentCredentialsGooglePay1966921727 => InputPaymentCredentialsGooglePay1966921727.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountTmpPassword,
    public abstract class AccountTmpPasswordBase : ITlSerializable, ITlDeserializable<AccountTmpPasswordBase> {
        public static AccountTmpPasswordBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountTmpPasswordNs.AccountTmpPassword.Identifier))
                return Tel.AccountTmpPasswordNs.AccountTmpPassword.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountTmpPasswordNs.AccountTmpPassword AccountTmpPassword614138572 => AccountTmpPassword614138572.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ShippingOption,
    public abstract class ShippingOptionBase : ITlSerializable, ITlDeserializable<ShippingOptionBase> {
        public static ShippingOptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ShippingOptionNs.ShippingOption.Identifier))
                return Tel.ShippingOptionNs.ShippingOption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ShippingOptionNs.ShippingOption ShippingOption1239335713 => ShippingOption1239335713.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputStickerSetItem,
    public abstract class InputStickerSetItemBase : ITlSerializable, ITlDeserializable<InputStickerSetItemBase> {
        public static InputStickerSetItemBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputStickerSetItemNs.InputStickerSetItem.Identifier))
                return Tel.InputStickerSetItemNs.InputStickerSetItem.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputStickerSetItemNs.InputStickerSetItem InputStickerSetItem853188252 => InputStickerSetItem853188252.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputPhoneCall,
    public abstract class InputPhoneCallBase : ITlSerializable, ITlDeserializable<InputPhoneCallBase> {
        public static InputPhoneCallBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputPhoneCallNs.InputPhoneCall.Identifier))
                return Tel.InputPhoneCallNs.InputPhoneCall.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputPhoneCallNs.InputPhoneCall InputPhoneCall506920429 => InputPhoneCall506920429.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneCallEmpty, PhoneCallWaiting, PhoneCallRequested, PhoneCallAccepted, PhoneCall, PhoneCallDiscarded,
    public abstract class PhoneCallBase : ITlSerializable, ITlDeserializable<PhoneCallBase> {
        public long Id {get;set;} = default!;
        public static PhoneCallBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneCallNs.PhoneCallEmpty.Identifier))
                return Tel.PhoneCallNs.PhoneCallEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneCallNs.PhoneCallWaiting.Identifier))
                return Tel.PhoneCallNs.PhoneCallWaiting.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneCallNs.PhoneCallRequested.Identifier))
                return Tel.PhoneCallNs.PhoneCallRequested.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneCallNs.PhoneCallAccepted.Identifier))
                return Tel.PhoneCallNs.PhoneCallAccepted.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneCallNs.PhoneCall.Identifier))
                return Tel.PhoneCallNs.PhoneCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneCallNs.PhoneCallDiscarded.Identifier))
                return Tel.PhoneCallNs.PhoneCallDiscarded.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneCallNs.PhoneCallEmpty PhoneCallEmpty1399245077 => PhoneCallEmpty1399245077.TlSerialize(),
            Tel.PhoneCallNs.PhoneCallWaiting PhoneCallWaiting987599081 => PhoneCallWaiting987599081.TlSerialize(),
            Tel.PhoneCallNs.PhoneCallRequested PhoneCallRequested347139340 => PhoneCallRequested347139340.TlSerialize(),
            Tel.PhoneCallNs.PhoneCallAccepted PhoneCallAccepted912311057 => PhoneCallAccepted912311057.TlSerialize(),
            Tel.PhoneCallNs.PhoneCall PhoneCall810769141 => PhoneCall810769141.TlSerialize(),
            Tel.PhoneCallNs.PhoneCallDiscarded PhoneCallDiscarded1355435489 => PhoneCallDiscarded1355435489.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneConnection, PhoneConnectionWebrtc,
    public abstract class PhoneConnectionBase : ITlSerializable, ITlDeserializable<PhoneConnectionBase> {
        public int Flags {get;set;} = default!;
        public long Id {get;set;} = default!;
        public string Ip {get;set;} = default!;
        public string Ipv6 {get;set;} = default!;
        public int Port {get;set;} = default!;
        public static PhoneConnectionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneConnectionNs.PhoneConnection.Identifier))
                return Tel.PhoneConnectionNs.PhoneConnection.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PhoneConnectionNs.PhoneConnectionWebrtc.Identifier))
                return Tel.PhoneConnectionNs.PhoneConnectionWebrtc.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneConnectionNs.PhoneConnection PhoneConnection1665063993 => PhoneConnection1665063993.TlSerialize(),
            Tel.PhoneConnectionNs.PhoneConnectionWebrtc PhoneConnectionWebrtc1667228533 => PhoneConnectionWebrtc1667228533.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneCallProtocol,
    public abstract class PhoneCallProtocolBase : ITlSerializable, ITlDeserializable<PhoneCallProtocolBase> {
        public static PhoneCallProtocolBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneCallProtocolNs.PhoneCallProtocol.Identifier))
                return Tel.PhoneCallProtocolNs.PhoneCallProtocol.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneCallProtocolNs.PhoneCallProtocol PhoneCallProtocol58224696 => PhoneCallProtocol58224696.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhonePhoneCall,
    public abstract class PhonePhoneCallBase : ITlSerializable, ITlDeserializable<PhonePhoneCallBase> {
        public static PhonePhoneCallBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhonePhoneCallNs.PhonePhoneCall.Identifier))
                return Tel.PhonePhoneCallNs.PhonePhoneCall.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhonePhoneCallNs.PhonePhoneCall PhonePhoneCall326966976 => PhonePhoneCall326966976.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UploadCdnFileReuploadNeeded, UploadCdnFile,
    public abstract class UploadCdnFileBase : ITlSerializable, ITlDeserializable<UploadCdnFileBase> {
        public static UploadCdnFileBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UploadCdnFileNs.UploadCdnFileReuploadNeeded.Identifier))
                return Tel.UploadCdnFileNs.UploadCdnFileReuploadNeeded.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UploadCdnFileNs.UploadCdnFile.Identifier))
                return Tel.UploadCdnFileNs.UploadCdnFile.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UploadCdnFileNs.UploadCdnFileReuploadNeeded UploadCdnFileReuploadNeeded290921362 => UploadCdnFileReuploadNeeded290921362.TlSerialize(),
            Tel.UploadCdnFileNs.UploadCdnFile UploadCdnFile1449145777 => UploadCdnFile1449145777.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: CdnPublicKey,
    public abstract class CdnPublicKeyBase : ITlSerializable, ITlDeserializable<CdnPublicKeyBase> {
        public static CdnPublicKeyBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.CdnPublicKeyNs.CdnPublicKey.Identifier))
                return Tel.CdnPublicKeyNs.CdnPublicKey.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.CdnPublicKeyNs.CdnPublicKey CdnPublicKey914167110 => CdnPublicKey914167110.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: CdnConfig,
    public abstract class CdnConfigBase : ITlSerializable, ITlDeserializable<CdnConfigBase> {
        public static CdnConfigBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.CdnConfigNs.CdnConfig.Identifier))
                return Tel.CdnConfigNs.CdnConfig.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.CdnConfigNs.CdnConfig CdnConfig1462101002 => CdnConfig1462101002.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: LangPackString, LangPackStringPluralized, LangPackStringDeleted,
    public abstract class LangPackStringBase : ITlSerializable, ITlDeserializable<LangPackStringBase> {
        public string Key {get;set;} = default!;
        public static LangPackStringBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.LangPackStringNs.LangPackString.Identifier))
                return Tel.LangPackStringNs.LangPackString.TlDeserialize(des);
            if (id.SequenceEqual(Tel.LangPackStringNs.LangPackStringPluralized.Identifier))
                return Tel.LangPackStringNs.LangPackStringPluralized.TlDeserialize(des);
            if (id.SequenceEqual(Tel.LangPackStringNs.LangPackStringDeleted.Identifier))
                return Tel.LangPackStringNs.LangPackStringDeleted.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.LangPackStringNs.LangPackString LangPackString892239370 => LangPackString892239370.TlSerialize(),
            Tel.LangPackStringNs.LangPackStringPluralized LangPackStringPluralized1816636575 => LangPackStringPluralized1816636575.TlSerialize(),
            Tel.LangPackStringNs.LangPackStringDeleted LangPackStringDeleted695856818 => LangPackStringDeleted695856818.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: LangPackDifference,
    public abstract class LangPackDifferenceBase : ITlSerializable, ITlDeserializable<LangPackDifferenceBase> {
        public static LangPackDifferenceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.LangPackDifferenceNs.LangPackDifference.Identifier))
                return Tel.LangPackDifferenceNs.LangPackDifference.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.LangPackDifferenceNs.LangPackDifference LangPackDifference209337866 => LangPackDifference209337866.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: LangPackLanguage,
    public abstract class LangPackLanguageBase : ITlSerializable, ITlDeserializable<LangPackLanguageBase> {
        public static LangPackLanguageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.LangPackLanguageNs.LangPackLanguage.Identifier))
                return Tel.LangPackLanguageNs.LangPackLanguage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.LangPackLanguageNs.LangPackLanguage LangPackLanguage288727837 => LangPackLanguage288727837.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelAdminLogEventActionChangeTitle, ChannelAdminLogEventActionChangeAbout, ChannelAdminLogEventActionChangeUsername, ChannelAdminLogEventActionChangePhoto, ChannelAdminLogEventActionToggleInvites, ChannelAdminLogEventActionToggleSignatures, ChannelAdminLogEventActionUpdatePinned, ChannelAdminLogEventActionEditMessage, ChannelAdminLogEventActionDeleteMessage, ChannelAdminLogEventActionParticipantJoin, ChannelAdminLogEventActionParticipantLeave, ChannelAdminLogEventActionParticipantInvite, ChannelAdminLogEventActionParticipantToggleBan, ChannelAdminLogEventActionParticipantToggleAdmin, ChannelAdminLogEventActionChangeStickerSet, ChannelAdminLogEventActionTogglePreHistoryHidden, ChannelAdminLogEventActionDefaultBannedRights, ChannelAdminLogEventActionStopPoll, ChannelAdminLogEventActionChangeLinkedChat, ChannelAdminLogEventActionChangeLocation, ChannelAdminLogEventActionToggleSlowMode, ChannelAdminLogEventActionStartGroupCall, ChannelAdminLogEventActionDiscardGroupCall, ChannelAdminLogEventActionParticipantMute, ChannelAdminLogEventActionParticipantUnmute, ChannelAdminLogEventActionToggleGroupCallSetting, ChannelAdminLogEventActionParticipantJoinByInvite, ChannelAdminLogEventActionExportedInviteDelete, ChannelAdminLogEventActionExportedInviteRevoke, ChannelAdminLogEventActionExportedInviteEdit, ChannelAdminLogEventActionParticipantVolume, ChannelAdminLogEventActionChangeHistoryTTL, ChannelAdminLogEventActionParticipantJoinByRequest, ChannelAdminLogEventActionToggleNoForwards, ChannelAdminLogEventActionSendMessage, ChannelAdminLogEventActionChangeAvailableReactions, ChannelAdminLogEventActionChangeUsernames, ChannelAdminLogEventActionToggleForum, ChannelAdminLogEventActionCreateTopic, ChannelAdminLogEventActionEditTopic, ChannelAdminLogEventActionDeleteTopic, ChannelAdminLogEventActionPinTopic, ChannelAdminLogEventActionToggleAntiSpam, ChannelAdminLogEventActionChangePeerColor, ChannelAdminLogEventActionChangeProfilePeerColor, ChannelAdminLogEventActionChangeWallpaper, ChannelAdminLogEventActionChangeEmojiStatus, ChannelAdminLogEventActionChangeEmojiStickerSet,
    public abstract class ChannelAdminLogEventActionBase : ITlSerializable, ITlDeserializable<ChannelAdminLogEventActionBase> {
        public static ChannelAdminLogEventActionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeTitle.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeTitle.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeAbout.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeAbout.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeUsername.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeUsername.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangePhoto.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangePhoto.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleInvites.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleInvites.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleSignatures.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleSignatures.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionUpdatePinned.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionUpdatePinned.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionEditMessage.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionEditMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDeleteMessage.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDeleteMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoin.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoin.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantLeave.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantLeave.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantInvite.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantInvite.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantToggleBan.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantToggleBan.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantToggleAdmin.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantToggleAdmin.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeStickerSet.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeStickerSet.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionTogglePreHistoryHidden.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionTogglePreHistoryHidden.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDefaultBannedRights.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDefaultBannedRights.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionStopPoll.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionStopPoll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeLinkedChat.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeLinkedChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeLocation.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeLocation.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleSlowMode.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleSlowMode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionStartGroupCall.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionStartGroupCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDiscardGroupCall.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDiscardGroupCall.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantMute.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantMute.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantUnmute.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantUnmute.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleGroupCallSetting.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleGroupCallSetting.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoinByInvite.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoinByInvite.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteDelete.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteDelete.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteRevoke.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteRevoke.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteEdit.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteEdit.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantVolume.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantVolume.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeHistoryTTL.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeHistoryTTL.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoinByRequest.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoinByRequest.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleNoForwards.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleNoForwards.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionSendMessage.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionSendMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeAvailableReactions.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeAvailableReactions.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeUsernames.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeUsernames.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleForum.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleForum.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionCreateTopic.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionCreateTopic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionEditTopic.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionEditTopic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDeleteTopic.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDeleteTopic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionPinTopic.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionPinTopic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleAntiSpam.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleAntiSpam.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangePeerColor.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangePeerColor.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeProfilePeerColor.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeProfilePeerColor.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeWallpaper.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeWallpaper.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeEmojiStatus.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeEmojiStatus.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeEmojiStickerSet.Identifier))
                return Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeEmojiStickerSet.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeTitle ChannelAdminLogEventActionChangeTitle421545947 => ChannelAdminLogEventActionChangeTitle421545947.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeAbout ChannelAdminLogEventActionChangeAbout1427671598 => ChannelAdminLogEventActionChangeAbout1427671598.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeUsername ChannelAdminLogEventActionChangeUsername1783299128 => ChannelAdminLogEventActionChangeUsername1783299128.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangePhoto ChannelAdminLogEventActionChangePhoto1129042607 => ChannelAdminLogEventActionChangePhoto1129042607.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleInvites ChannelAdminLogEventActionToggleInvites460916654 => ChannelAdminLogEventActionToggleInvites460916654.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleSignatures ChannelAdminLogEventActionToggleSignatures648939889 => ChannelAdminLogEventActionToggleSignatures648939889.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionUpdatePinned ChannelAdminLogEventActionUpdatePinned370660328 => ChannelAdminLogEventActionUpdatePinned370660328.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionEditMessage ChannelAdminLogEventActionEditMessage1889215493 => ChannelAdminLogEventActionEditMessage1889215493.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDeleteMessage ChannelAdminLogEventActionDeleteMessage1121994683 => ChannelAdminLogEventActionDeleteMessage1121994683.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoin ChannelAdminLogEventActionParticipantJoin405815507 => ChannelAdminLogEventActionParticipantJoin405815507.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantLeave ChannelAdminLogEventActionParticipantLeave124291086 => ChannelAdminLogEventActionParticipantLeave124291086.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantInvite ChannelAdminLogEventActionParticipantInvite484690728 => ChannelAdminLogEventActionParticipantInvite484690728.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantToggleBan ChannelAdminLogEventActionParticipantToggleBan422036098 => ChannelAdminLogEventActionParticipantToggleBan422036098.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantToggleAdmin ChannelAdminLogEventActionParticipantToggleAdmin714643696 => ChannelAdminLogEventActionParticipantToggleAdmin714643696.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeStickerSet ChannelAdminLogEventActionChangeStickerSet1312568665 => ChannelAdminLogEventActionChangeStickerSet1312568665.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionTogglePreHistoryHidden ChannelAdminLogEventActionTogglePreHistoryHidden1599903217 => ChannelAdminLogEventActionTogglePreHistoryHidden1599903217.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDefaultBannedRights ChannelAdminLogEventActionDefaultBannedRights771095562 => ChannelAdminLogEventActionDefaultBannedRights771095562.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionStopPoll ChannelAdminLogEventActionStopPoll1895328189 => ChannelAdminLogEventActionStopPoll1895328189.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeLinkedChat ChannelAdminLogEventActionChangeLinkedChat84703944 => ChannelAdminLogEventActionChangeLinkedChat84703944.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeLocation ChannelAdminLogEventActionChangeLocation241923758 => ChannelAdminLogEventActionChangeLocation241923758.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleSlowMode ChannelAdminLogEventActionToggleSlowMode1401984889 => ChannelAdminLogEventActionToggleSlowMode1401984889.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionStartGroupCall ChannelAdminLogEventActionStartGroupCall589338437 => ChannelAdminLogEventActionStartGroupCall589338437.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDiscardGroupCall ChannelAdminLogEventActionDiscardGroupCall610299584 => ChannelAdminLogEventActionDiscardGroupCall610299584.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantMute ChannelAdminLogEventActionParticipantMute115071790 => ChannelAdminLogEventActionParticipantMute115071790.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantUnmute ChannelAdminLogEventActionParticipantUnmute431740480 => ChannelAdminLogEventActionParticipantUnmute431740480.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleGroupCallSetting ChannelAdminLogEventActionToggleGroupCallSetting1456906823 => ChannelAdminLogEventActionToggleGroupCallSetting1456906823.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoinByInvite ChannelAdminLogEventActionParticipantJoinByInvite23084712 => ChannelAdminLogEventActionParticipantJoinByInvite23084712.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteDelete ChannelAdminLogEventActionExportedInviteDelete1515256996 => ChannelAdminLogEventActionExportedInviteDelete1515256996.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteRevoke ChannelAdminLogEventActionExportedInviteRevoke1091179342 => ChannelAdminLogEventActionExportedInviteRevoke1091179342.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionExportedInviteEdit ChannelAdminLogEventActionExportedInviteEdit384910503 => ChannelAdminLogEventActionExportedInviteEdit384910503.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantVolume ChannelAdminLogEventActionParticipantVolume1048537159 => ChannelAdminLogEventActionParticipantVolume1048537159.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeHistoryTTL ChannelAdminLogEventActionChangeHistoryTTL1855199800 => ChannelAdminLogEventActionChangeHistoryTTL1855199800.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionParticipantJoinByRequest ChannelAdminLogEventActionParticipantJoinByRequest1347021750 => ChannelAdminLogEventActionParticipantJoinByRequest1347021750.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleNoForwards ChannelAdminLogEventActionToggleNoForwards886388890 => ChannelAdminLogEventActionToggleNoForwards886388890.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionSendMessage ChannelAdminLogEventActionSendMessage663693416 => ChannelAdminLogEventActionSendMessage663693416.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeAvailableReactions ChannelAdminLogEventActionChangeAvailableReactions1102180616 => ChannelAdminLogEventActionChangeAvailableReactions1102180616.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeUsernames ChannelAdminLogEventActionChangeUsernames263212119 => ChannelAdminLogEventActionChangeUsernames263212119.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleForum ChannelAdminLogEventActionToggleForum46949251 => ChannelAdminLogEventActionToggleForum46949251.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionCreateTopic ChannelAdminLogEventActionCreateTopic1483767080 => ChannelAdminLogEventActionCreateTopic1483767080.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionEditTopic ChannelAdminLogEventActionEditTopic261103096 => ChannelAdminLogEventActionEditTopic261103096.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionDeleteTopic ChannelAdminLogEventActionDeleteTopic1374254839 => ChannelAdminLogEventActionDeleteTopic1374254839.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionPinTopic ChannelAdminLogEventActionPinTopic1569535291 => ChannelAdminLogEventActionPinTopic1569535291.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionToggleAntiSpam ChannelAdminLogEventActionToggleAntiSpam1693675004 => ChannelAdminLogEventActionToggleAntiSpam1693675004.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangePeerColor ChannelAdminLogEventActionChangePeerColor1469507456 => ChannelAdminLogEventActionChangePeerColor1469507456.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeProfilePeerColor ChannelAdminLogEventActionChangeProfilePeerColor1581742885 => ChannelAdminLogEventActionChangeProfilePeerColor1581742885.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeWallpaper ChannelAdminLogEventActionChangeWallpaper834362706 => ChannelAdminLogEventActionChangeWallpaper834362706.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeEmojiStatus ChannelAdminLogEventActionChangeEmojiStatus1051328177 => ChannelAdminLogEventActionChangeEmojiStatus1051328177.TlSerialize(),
            Tel.ChannelAdminLogEventActionNs.ChannelAdminLogEventActionChangeEmojiStickerSet ChannelAdminLogEventActionChangeEmojiStickerSet1188577451 => ChannelAdminLogEventActionChangeEmojiStickerSet1188577451.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelAdminLogEvent,
    public abstract class ChannelAdminLogEventBase : ITlSerializable, ITlDeserializable<ChannelAdminLogEventBase> {
        public static ChannelAdminLogEventBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelAdminLogEventNs.ChannelAdminLogEvent.Identifier))
                return Tel.ChannelAdminLogEventNs.ChannelAdminLogEvent.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelAdminLogEventNs.ChannelAdminLogEvent ChannelAdminLogEvent531458253 => ChannelAdminLogEvent531458253.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelsAdminLogResults,
    public abstract class ChannelsAdminLogResultsBase : ITlSerializable, ITlDeserializable<ChannelsAdminLogResultsBase> {
        public static ChannelsAdminLogResultsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelsAdminLogResultsNs.ChannelsAdminLogResults.Identifier))
                return Tel.ChannelsAdminLogResultsNs.ChannelsAdminLogResults.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelsAdminLogResultsNs.ChannelsAdminLogResults ChannelsAdminLogResults309659827 => ChannelsAdminLogResults309659827.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelAdminLogEventsFilter,
    public abstract class ChannelAdminLogEventsFilterBase : ITlSerializable, ITlDeserializable<ChannelAdminLogEventsFilterBase> {
        public static ChannelAdminLogEventsFilterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelAdminLogEventsFilterNs.ChannelAdminLogEventsFilter.Identifier))
                return Tel.ChannelAdminLogEventsFilterNs.ChannelAdminLogEventsFilter.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelAdminLogEventsFilterNs.ChannelAdminLogEventsFilter ChannelAdminLogEventsFilter368018716 => ChannelAdminLogEventsFilter368018716.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PopularContact,
    public abstract class PopularContactBase : ITlSerializable, ITlDeserializable<PopularContactBase> {
        public static PopularContactBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PopularContactNs.PopularContact.Identifier))
                return Tel.PopularContactNs.PopularContact.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PopularContactNs.PopularContact PopularContact1558266229 => PopularContact1558266229.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesFavedStickersNotModified, MessagesFavedStickers,
    public abstract class MessagesFavedStickersBase : ITlSerializable, ITlDeserializable<MessagesFavedStickersBase> {
        public static MessagesFavedStickersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesFavedStickersNs.MessagesFavedStickersNotModified.Identifier))
                return Tel.MessagesFavedStickersNs.MessagesFavedStickersNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFavedStickersNs.MessagesFavedStickers.Identifier))
                return Tel.MessagesFavedStickersNs.MessagesFavedStickers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesFavedStickersNs.MessagesFavedStickersNotModified MessagesFavedStickersNotModified1634752813 => MessagesFavedStickersNotModified1634752813.TlSerialize(),
            Tel.MessagesFavedStickersNs.MessagesFavedStickers MessagesFavedStickers750063767 => MessagesFavedStickers750063767.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: RecentMeUrlUnknown, RecentMeUrlUser, RecentMeUrlChat, RecentMeUrlChatInvite, RecentMeUrlStickerSet,
    public abstract class RecentMeUrlBase : ITlSerializable, ITlDeserializable<RecentMeUrlBase> {
        public string Url {get;set;} = default!;
        public static RecentMeUrlBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.RecentMeUrlNs.RecentMeUrlUnknown.Identifier))
                return Tel.RecentMeUrlNs.RecentMeUrlUnknown.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RecentMeUrlNs.RecentMeUrlUser.Identifier))
                return Tel.RecentMeUrlNs.RecentMeUrlUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RecentMeUrlNs.RecentMeUrlChat.Identifier))
                return Tel.RecentMeUrlNs.RecentMeUrlChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RecentMeUrlNs.RecentMeUrlChatInvite.Identifier))
                return Tel.RecentMeUrlNs.RecentMeUrlChatInvite.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RecentMeUrlNs.RecentMeUrlStickerSet.Identifier))
                return Tel.RecentMeUrlNs.RecentMeUrlStickerSet.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.RecentMeUrlNs.RecentMeUrlUnknown RecentMeUrlUnknown1189204285 => RecentMeUrlUnknown1189204285.TlSerialize(),
            Tel.RecentMeUrlNs.RecentMeUrlUser RecentMeUrlUser1188296222 => RecentMeUrlUser1188296222.TlSerialize(),
            Tel.RecentMeUrlNs.RecentMeUrlChat RecentMeUrlChat1294306862 => RecentMeUrlChat1294306862.TlSerialize(),
            Tel.RecentMeUrlNs.RecentMeUrlChatInvite RecentMeUrlChatInvite347535331 => RecentMeUrlChatInvite347535331.TlSerialize(),
            Tel.RecentMeUrlNs.RecentMeUrlStickerSet RecentMeUrlStickerSet1140172836 => RecentMeUrlStickerSet1140172836.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpRecentMeUrls,
    public abstract class HelpRecentMeUrlsBase : ITlSerializable, ITlDeserializable<HelpRecentMeUrlsBase> {
        public static HelpRecentMeUrlsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpRecentMeUrlsNs.HelpRecentMeUrls.Identifier))
                return Tel.HelpRecentMeUrlsNs.HelpRecentMeUrls.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpRecentMeUrlsNs.HelpRecentMeUrls HelpRecentMeUrls235081943 => HelpRecentMeUrls235081943.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputSingleMedia,
    public abstract class InputSingleMediaBase : ITlSerializable, ITlDeserializable<InputSingleMediaBase> {
        public static InputSingleMediaBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputSingleMediaNs.InputSingleMedia.Identifier))
                return Tel.InputSingleMediaNs.InputSingleMedia.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputSingleMediaNs.InputSingleMedia InputSingleMedia482797855 => InputSingleMedia482797855.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: WebAuthorization,
    public abstract class WebAuthorizationBase : ITlSerializable, ITlDeserializable<WebAuthorizationBase> {
        public static WebAuthorizationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.WebAuthorizationNs.WebAuthorization.Identifier))
                return Tel.WebAuthorizationNs.WebAuthorization.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.WebAuthorizationNs.WebAuthorization WebAuthorization1493633966 => WebAuthorization1493633966.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountWebAuthorizations,
    public abstract class AccountWebAuthorizationsBase : ITlSerializable, ITlDeserializable<AccountWebAuthorizationsBase> {
        public static AccountWebAuthorizationsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountWebAuthorizationsNs.AccountWebAuthorizations.Identifier))
                return Tel.AccountWebAuthorizationsNs.AccountWebAuthorizations.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountWebAuthorizationsNs.AccountWebAuthorizations AccountWebAuthorizations313079300 => AccountWebAuthorizations313079300.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputMessageID, InputMessageReplyTo, InputMessagePinned, InputMessageCallbackQuery,
    public abstract class InputMessageBase : ITlSerializable, ITlDeserializable<InputMessageBase> {
        public static InputMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputMessageNs.InputMessageID.Identifier))
                return Tel.InputMessageNs.InputMessageID.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMessageNs.InputMessageReplyTo.Identifier))
                return Tel.InputMessageNs.InputMessageReplyTo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMessageNs.InputMessagePinned.Identifier))
                return Tel.InputMessageNs.InputMessagePinned.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputMessageNs.InputMessageCallbackQuery.Identifier))
                return Tel.InputMessageNs.InputMessageCallbackQuery.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputMessageNs.InputMessageID InputMessageID1502174430 => InputMessageID1502174430.TlSerialize(),
            Tel.InputMessageNs.InputMessageReplyTo InputMessageReplyTo1160215659 => InputMessageReplyTo1160215659.TlSerialize(),
            Tel.InputMessageNs.InputMessagePinned InputMessagePinned2037963464 => InputMessagePinned2037963464.TlSerialize(),
            Tel.InputMessageNs.InputMessageCallbackQuery InputMessageCallbackQuery1392895362 => InputMessageCallbackQuery1392895362.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputDialogPeer, InputDialogPeerFolder,
    public abstract class InputDialogPeerBase : ITlSerializable, ITlDeserializable<InputDialogPeerBase> {
        public static InputDialogPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputDialogPeerNs.InputDialogPeer.Identifier))
                return Tel.InputDialogPeerNs.InputDialogPeer.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputDialogPeerNs.InputDialogPeerFolder.Identifier))
                return Tel.InputDialogPeerNs.InputDialogPeerFolder.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputDialogPeerNs.InputDialogPeer InputDialogPeer55902537 => InputDialogPeer55902537.TlSerialize(),
            Tel.InputDialogPeerNs.InputDialogPeerFolder InputDialogPeerFolder1684014375 => InputDialogPeerFolder1684014375.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DialogPeer, DialogPeerFolder,
    public abstract class DialogPeerBase : ITlSerializable, ITlDeserializable<DialogPeerBase> {
        public static DialogPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DialogPeerNs.DialogPeer.Identifier))
                return Tel.DialogPeerNs.DialogPeer.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DialogPeerNs.DialogPeerFolder.Identifier))
                return Tel.DialogPeerNs.DialogPeerFolder.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DialogPeerNs.DialogPeer DialogPeer445792507 => DialogPeer445792507.TlSerialize(),
            Tel.DialogPeerNs.DialogPeerFolder DialogPeerFolder1363483106 => DialogPeerFolder1363483106.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesFoundStickerSetsNotModified, MessagesFoundStickerSets,
    public abstract class MessagesFoundStickerSetsBase : ITlSerializable, ITlDeserializable<MessagesFoundStickerSetsBase> {
        public static MessagesFoundStickerSetsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesFoundStickerSetsNs.MessagesFoundStickerSetsNotModified.Identifier))
                return Tel.MessagesFoundStickerSetsNs.MessagesFoundStickerSetsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesFoundStickerSetsNs.MessagesFoundStickerSets.Identifier))
                return Tel.MessagesFoundStickerSetsNs.MessagesFoundStickerSets.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesFoundStickerSetsNs.MessagesFoundStickerSetsNotModified MessagesFoundStickerSetsNotModified223655517 => MessagesFoundStickerSetsNotModified223655517.TlSerialize(),
            Tel.MessagesFoundStickerSetsNs.MessagesFoundStickerSets MessagesFoundStickerSets1963942446 => MessagesFoundStickerSets1963942446.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: FileHash,
    public abstract class FileHashBase : ITlSerializable, ITlDeserializable<FileHashBase> {
        public static FileHashBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.FileHashNs.FileHash.Identifier))
                return Tel.FileHashNs.FileHash.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.FileHashNs.FileHash FileHash207944868 => FileHash207944868.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputClientProxy,
    public abstract class InputClientProxyBase : ITlSerializable, ITlDeserializable<InputClientProxyBase> {
        public static InputClientProxyBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputClientProxyNs.InputClientProxy.Identifier))
                return Tel.InputClientProxyNs.InputClientProxy.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputClientProxyNs.InputClientProxy InputClientProxy1968737087 => InputClientProxy1968737087.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpTermsOfServiceUpdateEmpty, HelpTermsOfServiceUpdate,
    public abstract class HelpTermsOfServiceUpdateBase : ITlSerializable, ITlDeserializable<HelpTermsOfServiceUpdateBase> {
        public int Expires {get;set;} = default!;
        public static HelpTermsOfServiceUpdateBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpTermsOfServiceUpdateNs.HelpTermsOfServiceUpdateEmpty.Identifier))
                return Tel.HelpTermsOfServiceUpdateNs.HelpTermsOfServiceUpdateEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpTermsOfServiceUpdateNs.HelpTermsOfServiceUpdate.Identifier))
                return Tel.HelpTermsOfServiceUpdateNs.HelpTermsOfServiceUpdate.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpTermsOfServiceUpdateNs.HelpTermsOfServiceUpdateEmpty HelpTermsOfServiceUpdateEmpty483352705 => HelpTermsOfServiceUpdateEmpty483352705.TlSerialize(),
            Tel.HelpTermsOfServiceUpdateNs.HelpTermsOfServiceUpdate HelpTermsOfServiceUpdate686618977 => HelpTermsOfServiceUpdate686618977.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputSecureFileUploaded, InputSecureFile,
    public abstract class InputSecureFileBase : ITlSerializable, ITlDeserializable<InputSecureFileBase> {
        public long Id {get;set;} = default!;
        public static InputSecureFileBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputSecureFileNs.InputSecureFileUploaded.Identifier))
                return Tel.InputSecureFileNs.InputSecureFileUploaded.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputSecureFileNs.InputSecureFile.Identifier))
                return Tel.InputSecureFileNs.InputSecureFile.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputSecureFileNs.InputSecureFileUploaded InputSecureFileUploaded859091184 => InputSecureFileUploaded859091184.TlSerialize(),
            Tel.InputSecureFileNs.InputSecureFile InputSecureFile1399317950 => InputSecureFile1399317950.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureFileEmpty, SecureFile,
    public abstract class SecureFileBase : ITlSerializable, ITlDeserializable<SecureFileBase> {
        public static SecureFileBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureFileNs.SecureFileEmpty.Identifier))
                return Tel.SecureFileNs.SecureFileEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureFileNs.SecureFile.Identifier))
                return Tel.SecureFileNs.SecureFile.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureFileNs.SecureFileEmpty SecureFileEmpty1679398724 => SecureFileEmpty1679398724.TlSerialize(),
            Tel.SecureFileNs.SecureFile SecureFile2097791614 => SecureFile2097791614.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureData,
    public abstract class SecureDataBase : ITlSerializable, ITlDeserializable<SecureDataBase> {
        public static SecureDataBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureDataNs.SecureData.Identifier))
                return Tel.SecureDataNs.SecureData.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureDataNs.SecureData SecureData1964327229 => SecureData1964327229.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecurePlainPhone, SecurePlainEmail,
    public abstract class SecurePlainDataBase : ITlSerializable, ITlDeserializable<SecurePlainDataBase> {
        public static SecurePlainDataBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecurePlainDataNs.SecurePlainPhone.Identifier))
                return Tel.SecurePlainDataNs.SecurePlainPhone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecurePlainDataNs.SecurePlainEmail.Identifier))
                return Tel.SecurePlainDataNs.SecurePlainEmail.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecurePlainDataNs.SecurePlainPhone SecurePlainPhone2103482845 => SecurePlainPhone2103482845.TlSerialize(),
            Tel.SecurePlainDataNs.SecurePlainEmail SecurePlainEmail569137759 => SecurePlainEmail569137759.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureValueTypePersonalDetails, SecureValueTypePassport, SecureValueTypeDriverLicense, SecureValueTypeIdentityCard, SecureValueTypeInternalPassport, SecureValueTypeAddress, SecureValueTypeUtilityBill, SecureValueTypeBankStatement, SecureValueTypeRentalAgreement, SecureValueTypePassportRegistration, SecureValueTypeTemporaryRegistration, SecureValueTypePhone, SecureValueTypeEmail,
    public abstract class SecureValueTypeBase : ITlSerializable, ITlDeserializable<SecureValueTypeBase> {
        public static SecureValueTypeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypePersonalDetails.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypePersonalDetails.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypePassport.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypePassport.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeDriverLicense.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeDriverLicense.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeIdentityCard.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeIdentityCard.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeInternalPassport.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeInternalPassport.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeAddress.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeAddress.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeUtilityBill.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeUtilityBill.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeBankStatement.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeBankStatement.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeRentalAgreement.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeRentalAgreement.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypePassportRegistration.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypePassportRegistration.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeTemporaryRegistration.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeTemporaryRegistration.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypePhone.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypePhone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueTypeNs.SecureValueTypeEmail.Identifier))
                return Tel.SecureValueTypeNs.SecureValueTypeEmail.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureValueTypeNs.SecureValueTypePersonalDetails SecureValueTypePersonalDetails1658158621 => SecureValueTypePersonalDetails1658158621.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypePassport SecureValueTypePassport1034709504 => SecureValueTypePassport1034709504.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeDriverLicense SecureValueTypeDriverLicense115615172 => SecureValueTypeDriverLicense115615172.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeIdentityCard SecureValueTypeIdentityCard1596951477 => SecureValueTypeIdentityCard1596951477.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeInternalPassport SecureValueTypeInternalPassport1717268701 => SecureValueTypeInternalPassport1717268701.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeAddress SecureValueTypeAddress874308058 => SecureValueTypeAddress874308058.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeUtilityBill SecureValueTypeUtilityBill63531698 => SecureValueTypeUtilityBill63531698.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeBankStatement SecureValueTypeBankStatement1995211763 => SecureValueTypeBankStatement1995211763.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeRentalAgreement SecureValueTypeRentalAgreement1954007928 => SecureValueTypeRentalAgreement1954007928.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypePassportRegistration SecureValueTypePassportRegistration1713143702 => SecureValueTypePassportRegistration1713143702.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeTemporaryRegistration SecureValueTypeTemporaryRegistration368907213 => SecureValueTypeTemporaryRegistration368907213.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypePhone SecureValueTypePhone1289704741 => SecureValueTypePhone1289704741.TlSerialize(),
            Tel.SecureValueTypeNs.SecureValueTypeEmail SecureValueTypeEmail1908627474 => SecureValueTypeEmail1908627474.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureValue,
    public abstract class SecureValueBase : ITlSerializable, ITlDeserializable<SecureValueBase> {
        public static SecureValueBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureValueNs.SecureValue.Identifier))
                return Tel.SecureValueNs.SecureValue.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureValueNs.SecureValue SecureValue411017418 => SecureValue411017418.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputSecureValue,
    public abstract class InputSecureValueBase : ITlSerializable, ITlDeserializable<InputSecureValueBase> {
        public static InputSecureValueBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputSecureValueNs.InputSecureValue.Identifier))
                return Tel.InputSecureValueNs.InputSecureValue.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputSecureValueNs.InputSecureValue InputSecureValue618540889 => InputSecureValue618540889.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureValueHash,
    public abstract class SecureValueHashBase : ITlSerializable, ITlDeserializable<SecureValueHashBase> {
        public static SecureValueHashBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureValueHashNs.SecureValueHash.Identifier))
                return Tel.SecureValueHashNs.SecureValueHash.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureValueHashNs.SecureValueHash SecureValueHash316748368 => SecureValueHash316748368.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureValueErrorData, SecureValueErrorFrontSide, SecureValueErrorReverseSide, SecureValueErrorSelfie, SecureValueErrorFile, SecureValueErrorFiles, SecureValueError, SecureValueErrorTranslationFile, SecureValueErrorTranslationFiles,
    public abstract class SecureValueErrorBase : ITlSerializable, ITlDeserializable<SecureValueErrorBase> {
        public SecureValueTypeBase Type {get;set;} = default!;
        public string Text {get;set;} = default!;
        public static SecureValueErrorBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueErrorData.Identifier))
                return Tel.SecureValueErrorNs.SecureValueErrorData.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueErrorFrontSide.Identifier))
                return Tel.SecureValueErrorNs.SecureValueErrorFrontSide.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueErrorReverseSide.Identifier))
                return Tel.SecureValueErrorNs.SecureValueErrorReverseSide.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueErrorSelfie.Identifier))
                return Tel.SecureValueErrorNs.SecureValueErrorSelfie.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueErrorFile.Identifier))
                return Tel.SecureValueErrorNs.SecureValueErrorFile.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueErrorFiles.Identifier))
                return Tel.SecureValueErrorNs.SecureValueErrorFiles.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueError.Identifier))
                return Tel.SecureValueErrorNs.SecureValueError.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueErrorTranslationFile.Identifier))
                return Tel.SecureValueErrorNs.SecureValueErrorTranslationFile.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureValueErrorNs.SecureValueErrorTranslationFiles.Identifier))
                return Tel.SecureValueErrorNs.SecureValueErrorTranslationFiles.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureValueErrorNs.SecureValueErrorData SecureValueErrorData391902247 => SecureValueErrorData391902247.TlSerialize(),
            Tel.SecureValueErrorNs.SecureValueErrorFrontSide SecureValueErrorFrontSide12467706 => SecureValueErrorFrontSide12467706.TlSerialize(),
            Tel.SecureValueErrorNs.SecureValueErrorReverseSide SecureValueErrorReverseSide2037765467 => SecureValueErrorReverseSide2037765467.TlSerialize(),
            Tel.SecureValueErrorNs.SecureValueErrorSelfie SecureValueErrorSelfie449327402 => SecureValueErrorSelfie449327402.TlSerialize(),
            Tel.SecureValueErrorNs.SecureValueErrorFile SecureValueErrorFile2054162547 => SecureValueErrorFile2054162547.TlSerialize(),
            Tel.SecureValueErrorNs.SecureValueErrorFiles SecureValueErrorFiles1717706985 => SecureValueErrorFiles1717706985.TlSerialize(),
            Tel.SecureValueErrorNs.SecureValueError SecureValueError2036501105 => SecureValueError2036501105.TlSerialize(),
            Tel.SecureValueErrorNs.SecureValueErrorTranslationFile SecureValueErrorTranslationFile1592506512 => SecureValueErrorTranslationFile1592506512.TlSerialize(),
            Tel.SecureValueErrorNs.SecureValueErrorTranslationFiles SecureValueErrorTranslationFiles878931416 => SecureValueErrorTranslationFiles878931416.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureCredentialsEncrypted,
    public abstract class SecureCredentialsEncryptedBase : ITlSerializable, ITlDeserializable<SecureCredentialsEncryptedBase> {
        public static SecureCredentialsEncryptedBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureCredentialsEncryptedNs.SecureCredentialsEncrypted.Identifier))
                return Tel.SecureCredentialsEncryptedNs.SecureCredentialsEncrypted.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureCredentialsEncryptedNs.SecureCredentialsEncrypted SecureCredentialsEncrypted871426631 => SecureCredentialsEncrypted871426631.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountAuthorizationForm,
    public abstract class AccountAuthorizationFormBase : ITlSerializable, ITlDeserializable<AccountAuthorizationFormBase> {
        public static AccountAuthorizationFormBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountAuthorizationFormNs.AccountAuthorizationForm.Identifier))
                return Tel.AccountAuthorizationFormNs.AccountAuthorizationForm.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountAuthorizationFormNs.AccountAuthorizationForm AccountAuthorizationForm1389486888 => AccountAuthorizationForm1389486888.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountSentEmailCode,
    public abstract class AccountSentEmailCodeBase : ITlSerializable, ITlDeserializable<AccountSentEmailCodeBase> {
        public static AccountSentEmailCodeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountSentEmailCodeNs.AccountSentEmailCode.Identifier))
                return Tel.AccountSentEmailCodeNs.AccountSentEmailCode.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountSentEmailCodeNs.AccountSentEmailCode AccountSentEmailCode2128640689 => AccountSentEmailCode2128640689.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpDeepLinkInfoEmpty, HelpDeepLinkInfo,
    public abstract class HelpDeepLinkInfoBase : ITlSerializable, ITlDeserializable<HelpDeepLinkInfoBase> {
        public static HelpDeepLinkInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpDeepLinkInfoNs.HelpDeepLinkInfoEmpty.Identifier))
                return Tel.HelpDeepLinkInfoNs.HelpDeepLinkInfoEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpDeepLinkInfoNs.HelpDeepLinkInfo.Identifier))
                return Tel.HelpDeepLinkInfoNs.HelpDeepLinkInfo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpDeepLinkInfoNs.HelpDeepLinkInfoEmpty HelpDeepLinkInfoEmpty1722786150 => HelpDeepLinkInfoEmpty1722786150.TlSerialize(),
            Tel.HelpDeepLinkInfoNs.HelpDeepLinkInfo HelpDeepLinkInfo1783556146 => HelpDeepLinkInfo1783556146.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SavedPhoneContact,
    public abstract class SavedContactBase : ITlSerializable, ITlDeserializable<SavedContactBase> {
        public static SavedContactBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SavedContactNs.SavedPhoneContact.Identifier))
                return Tel.SavedContactNs.SavedPhoneContact.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SavedContactNs.SavedPhoneContact SavedPhoneContact289586518 => SavedPhoneContact289586518.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountTakeout,
    public abstract class AccountTakeoutBase : ITlSerializable, ITlDeserializable<AccountTakeoutBase> {
        public static AccountTakeoutBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountTakeoutNs.AccountTakeout.Identifier))
                return Tel.AccountTakeoutNs.AccountTakeout.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountTakeoutNs.AccountTakeout AccountTakeout1304052993 => AccountTakeout1304052993.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PasswordKdfAlgoUnknown, PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow,
    public abstract class PasswordKdfAlgoBase : ITlSerializable, ITlDeserializable<PasswordKdfAlgoBase> {
        public static PasswordKdfAlgoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PasswordKdfAlgoNs.PasswordKdfAlgoUnknown.Identifier))
                return Tel.PasswordKdfAlgoNs.PasswordKdfAlgoUnknown.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PasswordKdfAlgoNs.PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow.Identifier))
                return Tel.PasswordKdfAlgoNs.PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PasswordKdfAlgoNs.PasswordKdfAlgoUnknown PasswordKdfAlgoUnknown732254058 => PasswordKdfAlgoUnknown732254058.TlSerialize(),
            Tel.PasswordKdfAlgoNs.PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow982592842 => PasswordKdfAlgoSHA256SHA256PBKDF2HMACSHA512iter100000SHA256ModPow982592842.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecurePasswordKdfAlgoUnknown, SecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000, SecurePasswordKdfAlgoSHA512,
    public abstract class SecurePasswordKdfAlgoBase : ITlSerializable, ITlDeserializable<SecurePasswordKdfAlgoBase> {
        public static SecurePasswordKdfAlgoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoUnknown.Identifier))
                return Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoUnknown.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000.Identifier))
                return Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoSHA512.Identifier))
                return Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoSHA512.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoUnknown SecurePasswordKdfAlgoUnknown4883767 => SecurePasswordKdfAlgoUnknown4883767.TlSerialize(),
            Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoPBKDF2HMACSHA512iter100000 SecurePasswordKdfAlgoPBKDF2HMACSHA512iter1000001141711456 => SecurePasswordKdfAlgoPBKDF2HMACSHA512iter1000001141711456.TlSerialize(),
            Tel.SecurePasswordKdfAlgoNs.SecurePasswordKdfAlgoSHA512 SecurePasswordKdfAlgoSHA5122042159726 => SecurePasswordKdfAlgoSHA5122042159726.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureSecretSettings,
    public abstract class SecureSecretSettingsBase : ITlSerializable, ITlDeserializable<SecureSecretSettingsBase> {
        public static SecureSecretSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureSecretSettingsNs.SecureSecretSettings.Identifier))
                return Tel.SecureSecretSettingsNs.SecureSecretSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureSecretSettingsNs.SecureSecretSettings SecureSecretSettings354925740 => SecureSecretSettings354925740.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputCheckPasswordEmpty, InputCheckPasswordSRP,
    public abstract class InputCheckPasswordSRPBase : ITlSerializable, ITlDeserializable<InputCheckPasswordSRPBase> {
        public static InputCheckPasswordSRPBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputCheckPasswordSRPNs.InputCheckPasswordEmpty.Identifier))
                return Tel.InputCheckPasswordSRPNs.InputCheckPasswordEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputCheckPasswordSRPNs.InputCheckPasswordSRP.Identifier))
                return Tel.InputCheckPasswordSRPNs.InputCheckPasswordSRP.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputCheckPasswordSRPNs.InputCheckPasswordEmpty InputCheckPasswordEmpty1736378792 => InputCheckPasswordEmpty1736378792.TlSerialize(),
            Tel.InputCheckPasswordSRPNs.InputCheckPasswordSRP InputCheckPasswordSRP763367294 => InputCheckPasswordSRP763367294.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SecureRequiredType, SecureRequiredTypeOneOf,
    public abstract class SecureRequiredTypeBase : ITlSerializable, ITlDeserializable<SecureRequiredTypeBase> {
        public static SecureRequiredTypeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SecureRequiredTypeNs.SecureRequiredType.Identifier))
                return Tel.SecureRequiredTypeNs.SecureRequiredType.TlDeserialize(des);
            if (id.SequenceEqual(Tel.SecureRequiredTypeNs.SecureRequiredTypeOneOf.Identifier))
                return Tel.SecureRequiredTypeNs.SecureRequiredTypeOneOf.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SecureRequiredTypeNs.SecureRequiredType SecureRequiredType2103600678 => SecureRequiredType2103600678.TlSerialize(),
            Tel.SecureRequiredTypeNs.SecureRequiredTypeOneOf SecureRequiredTypeOneOf41187252 => SecureRequiredTypeOneOf41187252.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpPassportConfigNotModified, HelpPassportConfig,
    public abstract class HelpPassportConfigBase : ITlSerializable, ITlDeserializable<HelpPassportConfigBase> {
        public static HelpPassportConfigBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpPassportConfigNs.HelpPassportConfigNotModified.Identifier))
                return Tel.HelpPassportConfigNs.HelpPassportConfigNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpPassportConfigNs.HelpPassportConfig.Identifier))
                return Tel.HelpPassportConfigNs.HelpPassportConfig.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpPassportConfigNs.HelpPassportConfigNotModified HelpPassportConfigNotModified1078332329 => HelpPassportConfigNotModified1078332329.TlSerialize(),
            Tel.HelpPassportConfigNs.HelpPassportConfig HelpPassportConfig1600596305 => HelpPassportConfig1600596305.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputAppEvent,
    public abstract class InputAppEventBase : ITlSerializable, ITlDeserializable<InputAppEventBase> {
        public static InputAppEventBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputAppEventNs.InputAppEvent.Identifier))
                return Tel.InputAppEventNs.InputAppEvent.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputAppEventNs.InputAppEvent InputAppEvent488313413 => InputAppEvent488313413.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: JsonObjectValue,
    public abstract class JSONObjectValueBase : ITlSerializable, ITlDeserializable<JSONObjectValueBase> {
        public static JSONObjectValueBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.JSONObjectValueNs.JsonObjectValue.Identifier))
                return Tel.JSONObjectValueNs.JsonObjectValue.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.JSONObjectValueNs.JsonObjectValue JsonObjectValue1059185703 => JsonObjectValue1059185703.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: JsonNull, JsonBool, JsonNumber, JsonString, JsonArray, JsonObject,
    public abstract class JSONValueBase : ITlSerializable, ITlDeserializable<JSONValueBase> {
        public static JSONValueBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.JSONValueNs.JsonNull.Identifier))
                return Tel.JSONValueNs.JsonNull.TlDeserialize(des);
            if (id.SequenceEqual(Tel.JSONValueNs.JsonBool.Identifier))
                return Tel.JSONValueNs.JsonBool.TlDeserialize(des);
            if (id.SequenceEqual(Tel.JSONValueNs.JsonNumber.Identifier))
                return Tel.JSONValueNs.JsonNumber.TlDeserialize(des);
            if (id.SequenceEqual(Tel.JSONValueNs.JsonString.Identifier))
                return Tel.JSONValueNs.JsonString.TlDeserialize(des);
            if (id.SequenceEqual(Tel.JSONValueNs.JsonArray.Identifier))
                return Tel.JSONValueNs.JsonArray.TlDeserialize(des);
            if (id.SequenceEqual(Tel.JSONValueNs.JsonObject.Identifier))
                return Tel.JSONValueNs.JsonObject.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.JSONValueNs.JsonNull JsonNull1064139624 => JsonNull1064139624.TlSerialize(),
            Tel.JSONValueNs.JsonBool JsonBool952869270 => JsonBool952869270.TlSerialize(),
            Tel.JSONValueNs.JsonNumber JsonNumber736157604 => JsonNumber736157604.TlSerialize(),
            Tel.JSONValueNs.JsonString JsonString1222740358 => JsonString1222740358.TlSerialize(),
            Tel.JSONValueNs.JsonArray JsonArray146520221 => JsonArray146520221.TlSerialize(),
            Tel.JSONValueNs.JsonObject JsonObject1715350371 => JsonObject1715350371.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PageTableCell,
    public abstract class PageTableCellBase : ITlSerializable, ITlDeserializable<PageTableCellBase> {
        public static PageTableCellBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PageTableCellNs.PageTableCell.Identifier))
                return Tel.PageTableCellNs.PageTableCell.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PageTableCellNs.PageTableCell PageTableCell878078826 => PageTableCell878078826.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PageTableRow,
    public abstract class PageTableRowBase : ITlSerializable, ITlDeserializable<PageTableRowBase> {
        public static PageTableRowBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PageTableRowNs.PageTableRow.Identifier))
                return Tel.PageTableRowNs.PageTableRow.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PageTableRowNs.PageTableRow PageTableRow524237339 => PageTableRow524237339.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PageCaption,
    public abstract class PageCaptionBase : ITlSerializable, ITlDeserializable<PageCaptionBase> {
        public static PageCaptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PageCaptionNs.PageCaption.Identifier))
                return Tel.PageCaptionNs.PageCaption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PageCaptionNs.PageCaption PageCaption1869903447 => PageCaption1869903447.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PageListItemText, PageListItemBlocks,
    public abstract class PageListItemBase : ITlSerializable, ITlDeserializable<PageListItemBase> {
        public static PageListItemBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PageListItemNs.PageListItemText.Identifier))
                return Tel.PageListItemNs.PageListItemText.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageListItemNs.PageListItemBlocks.Identifier))
                return Tel.PageListItemNs.PageListItemBlocks.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PageListItemNs.PageListItemText PageListItemText1188055347 => PageListItemText1188055347.TlSerialize(),
            Tel.PageListItemNs.PageListItemBlocks PageListItemBlocks635466748 => PageListItemBlocks635466748.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PageListOrderedItemText, PageListOrderedItemBlocks,
    public abstract class PageListOrderedItemBase : ITlSerializable, ITlDeserializable<PageListOrderedItemBase> {
        public string Num {get;set;} = default!;
        public static PageListOrderedItemBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PageListOrderedItemNs.PageListOrderedItemText.Identifier))
                return Tel.PageListOrderedItemNs.PageListOrderedItemText.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PageListOrderedItemNs.PageListOrderedItemBlocks.Identifier))
                return Tel.PageListOrderedItemNs.PageListOrderedItemBlocks.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PageListOrderedItemNs.PageListOrderedItemText PageListOrderedItemText1577484359 => PageListOrderedItemText1577484359.TlSerialize(),
            Tel.PageListOrderedItemNs.PageListOrderedItemBlocks PageListOrderedItemBlocks1730311882 => PageListOrderedItemBlocks1730311882.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PageRelatedArticle,
    public abstract class PageRelatedArticleBase : ITlSerializable, ITlDeserializable<PageRelatedArticleBase> {
        public static PageRelatedArticleBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PageRelatedArticleNs.PageRelatedArticle.Identifier))
                return Tel.PageRelatedArticleNs.PageRelatedArticle.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PageRelatedArticleNs.PageRelatedArticle PageRelatedArticle1282352120 => PageRelatedArticle1282352120.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Page,
    public abstract class PageBase : ITlSerializable, ITlDeserializable<PageBase> {
        public static PageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PageNs.Page.Identifier))
                return Tel.PageNs.Page.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PageNs.Page Page1738178803 => Page1738178803.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpSupportName,
    public abstract class HelpSupportNameBase : ITlSerializable, ITlDeserializable<HelpSupportNameBase> {
        public static HelpSupportNameBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpSupportNameNs.HelpSupportName.Identifier))
                return Tel.HelpSupportNameNs.HelpSupportName.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpSupportNameNs.HelpSupportName HelpSupportName1945767479 => HelpSupportName1945767479.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpUserInfoEmpty, HelpUserInfo,
    public abstract class HelpUserInfoBase : ITlSerializable, ITlDeserializable<HelpUserInfoBase> {
        public static HelpUserInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpUserInfoNs.HelpUserInfoEmpty.Identifier))
                return Tel.HelpUserInfoNs.HelpUserInfoEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpUserInfoNs.HelpUserInfo.Identifier))
                return Tel.HelpUserInfoNs.HelpUserInfo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpUserInfoNs.HelpUserInfoEmpty HelpUserInfoEmpty206688531 => HelpUserInfoEmpty206688531.TlSerialize(),
            Tel.HelpUserInfoNs.HelpUserInfo HelpUserInfo32192344 => HelpUserInfo32192344.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PollAnswer,
    public abstract class PollAnswerBase : ITlSerializable, ITlDeserializable<PollAnswerBase> {
        public static PollAnswerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PollAnswerNs.PollAnswer.Identifier))
                return Tel.PollAnswerNs.PollAnswer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PollAnswerNs.PollAnswer PollAnswer15277366 => PollAnswer15277366.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Poll,
    public abstract class PollBase : ITlSerializable, ITlDeserializable<PollBase> {
        public static PollBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PollNs.Poll.Identifier))
                return Tel.PollNs.Poll.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PollNs.Poll Poll1484026161 => Poll1484026161.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PollAnswerVoters,
    public abstract class PollAnswerVotersBase : ITlSerializable, ITlDeserializable<PollAnswerVotersBase> {
        public static PollAnswerVotersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PollAnswerVotersNs.PollAnswerVoters.Identifier))
                return Tel.PollAnswerVotersNs.PollAnswerVoters.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PollAnswerVotersNs.PollAnswerVoters PollAnswerVoters997055186 => PollAnswerVoters997055186.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PollResults,
    public abstract class PollResultsBase : ITlSerializable, ITlDeserializable<PollResultsBase> {
        public static PollResultsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PollResultsNs.PollResults.Identifier))
                return Tel.PollResultsNs.PollResults.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PollResultsNs.PollResults PollResults2061444128 => PollResults2061444128.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatOnlines,
    public abstract class ChatOnlinesBase : ITlSerializable, ITlDeserializable<ChatOnlinesBase> {
        public static ChatOnlinesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatOnlinesNs.ChatOnlines.Identifier))
                return Tel.ChatOnlinesNs.ChatOnlines.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatOnlinesNs.ChatOnlines ChatOnlines264117680 => ChatOnlines264117680.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsURL,
    public abstract class StatsURLBase : ITlSerializable, ITlDeserializable<StatsURLBase> {
        public static StatsURLBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsURLNs.StatsURL.Identifier))
                return Tel.StatsURLNs.StatsURL.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsURLNs.StatsURL StatsURL1202287072 => StatsURL1202287072.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatAdminRights,
    public abstract class ChatAdminRightsBase : ITlSerializable, ITlDeserializable<ChatAdminRightsBase> {
        public static ChatAdminRightsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatAdminRightsNs.ChatAdminRights.Identifier))
                return Tel.ChatAdminRightsNs.ChatAdminRights.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatAdminRightsNs.ChatAdminRights ChatAdminRights1605510357 => ChatAdminRights1605510357.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatBannedRights,
    public abstract class ChatBannedRightsBase : ITlSerializable, ITlDeserializable<ChatBannedRightsBase> {
        public static ChatBannedRightsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatBannedRightsNs.ChatBannedRights.Identifier))
                return Tel.ChatBannedRightsNs.ChatBannedRights.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatBannedRightsNs.ChatBannedRights ChatBannedRights1626209256 => ChatBannedRights1626209256.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputWallPaper, InputWallPaperSlug, InputWallPaperNoFile,
    public abstract class InputWallPaperBase : ITlSerializable, ITlDeserializable<InputWallPaperBase> {
        public static InputWallPaperBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputWallPaperNs.InputWallPaper.Identifier))
                return Tel.InputWallPaperNs.InputWallPaper.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputWallPaperNs.InputWallPaperSlug.Identifier))
                return Tel.InputWallPaperNs.InputWallPaperSlug.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputWallPaperNs.InputWallPaperNoFile.Identifier))
                return Tel.InputWallPaperNs.InputWallPaperNoFile.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputWallPaperNs.InputWallPaper InputWallPaper433014407 => InputWallPaper433014407.TlSerialize(),
            Tel.InputWallPaperNs.InputWallPaperSlug InputWallPaperSlug1913199744 => InputWallPaperSlug1913199744.TlSerialize(),
            Tel.InputWallPaperNs.InputWallPaperNoFile InputWallPaperNoFile1770371538 => InputWallPaperNoFile1770371538.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountWallPapersNotModified, AccountWallPapers,
    public abstract class AccountWallPapersBase : ITlSerializable, ITlDeserializable<AccountWallPapersBase> {
        public static AccountWallPapersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountWallPapersNs.AccountWallPapersNotModified.Identifier))
                return Tel.AccountWallPapersNs.AccountWallPapersNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AccountWallPapersNs.AccountWallPapers.Identifier))
                return Tel.AccountWallPapersNs.AccountWallPapers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountWallPapersNs.AccountWallPapersNotModified AccountWallPapersNotModified471437699 => AccountWallPapersNotModified471437699.TlSerialize(),
            Tel.AccountWallPapersNs.AccountWallPapers AccountWallPapers842824308 => AccountWallPapers842824308.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: CodeSettings,
    public abstract class CodeSettingsBase : ITlSerializable, ITlDeserializable<CodeSettingsBase> {
        public static CodeSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.CodeSettingsNs.CodeSettings.Identifier))
                return Tel.CodeSettingsNs.CodeSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.CodeSettingsNs.CodeSettings CodeSettings1390068360 => CodeSettings1390068360.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: WallPaperSettings,
    public abstract class WallPaperSettingsBase : ITlSerializable, ITlDeserializable<WallPaperSettingsBase> {
        public static WallPaperSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.WallPaperSettingsNs.WallPaperSettings.Identifier))
                return Tel.WallPaperSettingsNs.WallPaperSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.WallPaperSettingsNs.WallPaperSettings WallPaperSettings925826256 => WallPaperSettings925826256.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AutoDownloadSettings,
    public abstract class AutoDownloadSettingsBase : ITlSerializable, ITlDeserializable<AutoDownloadSettingsBase> {
        public static AutoDownloadSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AutoDownloadSettingsNs.AutoDownloadSettings.Identifier))
                return Tel.AutoDownloadSettingsNs.AutoDownloadSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AutoDownloadSettingsNs.AutoDownloadSettings AutoDownloadSettings1163561432 => AutoDownloadSettings1163561432.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountAutoDownloadSettings,
    public abstract class AccountAutoDownloadSettingsBase : ITlSerializable, ITlDeserializable<AccountAutoDownloadSettingsBase> {
        public static AccountAutoDownloadSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountAutoDownloadSettingsNs.AccountAutoDownloadSettings.Identifier))
                return Tel.AccountAutoDownloadSettingsNs.AccountAutoDownloadSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountAutoDownloadSettingsNs.AccountAutoDownloadSettings AccountAutoDownloadSettings1674235686 => AccountAutoDownloadSettings1674235686.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmojiKeyword, EmojiKeywordDeleted,
    public abstract class EmojiKeywordBase : ITlSerializable, ITlDeserializable<EmojiKeywordBase> {
        public string Keyword {get;set;} = default!;
        public List<string> Emoticons {get;set;} = default!;
        public static EmojiKeywordBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmojiKeywordNs.EmojiKeyword.Identifier))
                return Tel.EmojiKeywordNs.EmojiKeyword.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmojiKeywordNs.EmojiKeywordDeleted.Identifier))
                return Tel.EmojiKeywordNs.EmojiKeywordDeleted.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmojiKeywordNs.EmojiKeyword EmojiKeyword709641735 => EmojiKeyword709641735.TlSerialize(),
            Tel.EmojiKeywordNs.EmojiKeywordDeleted EmojiKeywordDeleted594408994 => EmojiKeywordDeleted594408994.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmojiKeywordsDifference,
    public abstract class EmojiKeywordsDifferenceBase : ITlSerializable, ITlDeserializable<EmojiKeywordsDifferenceBase> {
        public static EmojiKeywordsDifferenceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmojiKeywordsDifferenceNs.EmojiKeywordsDifference.Identifier))
                return Tel.EmojiKeywordsDifferenceNs.EmojiKeywordsDifference.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmojiKeywordsDifferenceNs.EmojiKeywordsDifference EmojiKeywordsDifference1556570557 => EmojiKeywordsDifference1556570557.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmojiURL,
    public abstract class EmojiURLBase : ITlSerializable, ITlDeserializable<EmojiURLBase> {
        public static EmojiURLBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmojiURLNs.EmojiURL.Identifier))
                return Tel.EmojiURLNs.EmojiURL.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmojiURLNs.EmojiURL EmojiURL1519029347 => EmojiURL1519029347.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmojiLanguage,
    public abstract class EmojiLanguageBase : ITlSerializable, ITlDeserializable<EmojiLanguageBase> {
        public static EmojiLanguageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmojiLanguageNs.EmojiLanguage.Identifier))
                return Tel.EmojiLanguageNs.EmojiLanguage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmojiLanguageNs.EmojiLanguage EmojiLanguage1275374751 => EmojiLanguage1275374751.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Folder,
    public abstract class FolderBase : ITlSerializable, ITlDeserializable<FolderBase> {
        public static FolderBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.FolderNs.Folder.Identifier))
                return Tel.FolderNs.Folder.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.FolderNs.Folder Folder11252123 => Folder11252123.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputFolderPeer,
    public abstract class InputFolderPeerBase : ITlSerializable, ITlDeserializable<InputFolderPeerBase> {
        public static InputFolderPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputFolderPeerNs.InputFolderPeer.Identifier))
                return Tel.InputFolderPeerNs.InputFolderPeer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputFolderPeerNs.InputFolderPeer InputFolderPeer70073706 => InputFolderPeer70073706.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: FolderPeer,
    public abstract class FolderPeerBase : ITlSerializable, ITlDeserializable<FolderPeerBase> {
        public static FolderPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.FolderPeerNs.FolderPeer.Identifier))
                return Tel.FolderPeerNs.FolderPeer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.FolderPeerNs.FolderPeer FolderPeer373643672 => FolderPeer373643672.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesSearchCounter,
    public abstract class MessagesSearchCounterBase : ITlSerializable, ITlDeserializable<MessagesSearchCounterBase> {
        public static MessagesSearchCounterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesSearchCounterNs.MessagesSearchCounter.Identifier))
                return Tel.MessagesSearchCounterNs.MessagesSearchCounter.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesSearchCounterNs.MessagesSearchCounter MessagesSearchCounter398136321 => MessagesSearchCounter398136321.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UrlAuthResultRequest, UrlAuthResultAccepted, UrlAuthResultDefault,
    public abstract class UrlAuthResultBase : ITlSerializable, ITlDeserializable<UrlAuthResultBase> {
        public static UrlAuthResultBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UrlAuthResultNs.UrlAuthResultRequest.Identifier))
                return Tel.UrlAuthResultNs.UrlAuthResultRequest.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UrlAuthResultNs.UrlAuthResultAccepted.Identifier))
                return Tel.UrlAuthResultNs.UrlAuthResultAccepted.TlDeserialize(des);
            if (id.SequenceEqual(Tel.UrlAuthResultNs.UrlAuthResultDefault.Identifier))
                return Tel.UrlAuthResultNs.UrlAuthResultDefault.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UrlAuthResultNs.UrlAuthResultRequest UrlAuthResultRequest1831650802 => UrlAuthResultRequest1831650802.TlSerialize(),
            Tel.UrlAuthResultNs.UrlAuthResultAccepted UrlAuthResultAccepted1886646706 => UrlAuthResultAccepted1886646706.TlSerialize(),
            Tel.UrlAuthResultNs.UrlAuthResultDefault UrlAuthResultDefault1445536993 => UrlAuthResultDefault1445536993.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelLocationEmpty, ChannelLocation,
    public abstract class ChannelLocationBase : ITlSerializable, ITlDeserializable<ChannelLocationBase> {
        public static ChannelLocationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelLocationNs.ChannelLocationEmpty.Identifier))
                return Tel.ChannelLocationNs.ChannelLocationEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelLocationNs.ChannelLocation.Identifier))
                return Tel.ChannelLocationNs.ChannelLocation.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelLocationNs.ChannelLocationEmpty ChannelLocationEmpty1078612597 => ChannelLocationEmpty1078612597.TlSerialize(),
            Tel.ChannelLocationNs.ChannelLocation ChannelLocation547062491 => ChannelLocation547062491.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PeerLocated, PeerSelfLocated,
    public abstract class PeerLocatedBase : ITlSerializable, ITlDeserializable<PeerLocatedBase> {
        public int Expires {get;set;} = default!;
        public static PeerLocatedBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PeerLocatedNs.PeerLocated.Identifier))
                return Tel.PeerLocatedNs.PeerLocated.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PeerLocatedNs.PeerSelfLocated.Identifier))
                return Tel.PeerLocatedNs.PeerSelfLocated.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PeerLocatedNs.PeerLocated PeerLocated901375139 => PeerLocated901375139.TlSerialize(),
            Tel.PeerLocatedNs.PeerSelfLocated PeerSelfLocated118740917 => PeerSelfLocated118740917.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: RestrictionReason,
    public abstract class RestrictionReasonBase : ITlSerializable, ITlDeserializable<RestrictionReasonBase> {
        public static RestrictionReasonBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.RestrictionReasonNs.RestrictionReason.Identifier))
                return Tel.RestrictionReasonNs.RestrictionReason.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.RestrictionReasonNs.RestrictionReason RestrictionReason797791052 => RestrictionReason797791052.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputTheme, InputThemeSlug,
    public abstract class InputThemeBase : ITlSerializable, ITlDeserializable<InputThemeBase> {
        public static InputThemeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputThemeNs.InputTheme.Identifier))
                return Tel.InputThemeNs.InputTheme.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputThemeNs.InputThemeSlug.Identifier))
                return Tel.InputThemeNs.InputThemeSlug.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputThemeNs.InputTheme InputTheme1012306921 => InputTheme1012306921.TlSerialize(),
            Tel.InputThemeNs.InputThemeSlug InputThemeSlug175567375 => InputThemeSlug175567375.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Theme,
    public abstract class ThemeBase : ITlSerializable, ITlDeserializable<ThemeBase> {
        public static ThemeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ThemeNs.Theme.Identifier))
                return Tel.ThemeNs.Theme.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ThemeNs.Theme Theme1609668650 => Theme1609668650.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountThemesNotModified, AccountThemes,
    public abstract class AccountThemesBase : ITlSerializable, ITlDeserializable<AccountThemesBase> {
        public static AccountThemesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountThemesNs.AccountThemesNotModified.Identifier))
                return Tel.AccountThemesNs.AccountThemesNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AccountThemesNs.AccountThemes.Identifier))
                return Tel.AccountThemesNs.AccountThemes.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountThemesNs.AccountThemesNotModified AccountThemesNotModified199313886 => AccountThemesNotModified199313886.TlSerialize(),
            Tel.AccountThemesNs.AccountThemes AccountThemes1707242387 => AccountThemes1707242387.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AuthLoginToken, AuthLoginTokenMigrateTo, AuthLoginTokenSuccess,
    public abstract class AuthLoginTokenBase : ITlSerializable, ITlDeserializable<AuthLoginTokenBase> {
        public static AuthLoginTokenBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthLoginTokenNs.AuthLoginToken.Identifier))
                return Tel.AuthLoginTokenNs.AuthLoginToken.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthLoginTokenNs.AuthLoginTokenMigrateTo.Identifier))
                return Tel.AuthLoginTokenNs.AuthLoginTokenMigrateTo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AuthLoginTokenNs.AuthLoginTokenSuccess.Identifier))
                return Tel.AuthLoginTokenNs.AuthLoginTokenSuccess.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthLoginTokenNs.AuthLoginToken AuthLoginToken1654593920 => AuthLoginToken1654593920.TlSerialize(),
            Tel.AuthLoginTokenNs.AuthLoginTokenMigrateTo AuthLoginTokenMigrateTo110008598 => AuthLoginTokenMigrateTo110008598.TlSerialize(),
            Tel.AuthLoginTokenNs.AuthLoginTokenSuccess AuthLoginTokenSuccess957176926 => AuthLoginTokenSuccess957176926.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountContentSettings,
    public abstract class AccountContentSettingsBase : ITlSerializable, ITlDeserializable<AccountContentSettingsBase> {
        public static AccountContentSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountContentSettingsNs.AccountContentSettings.Identifier))
                return Tel.AccountContentSettingsNs.AccountContentSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountContentSettingsNs.AccountContentSettings AccountContentSettings1474462241 => AccountContentSettings1474462241.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesInactiveChats,
    public abstract class MessagesInactiveChatsBase : ITlSerializable, ITlDeserializable<MessagesInactiveChatsBase> {
        public static MessagesInactiveChatsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesInactiveChatsNs.MessagesInactiveChats.Identifier))
                return Tel.MessagesInactiveChatsNs.MessagesInactiveChats.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesInactiveChatsNs.MessagesInactiveChats MessagesInactiveChats1456996667 => MessagesInactiveChats1456996667.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BaseThemeClassic, BaseThemeDay, BaseThemeNight, BaseThemeTinted, BaseThemeArctic,
    public abstract class BaseThemeBase : ITlSerializable, ITlDeserializable<BaseThemeBase> {
        public static BaseThemeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BaseThemeNs.BaseThemeClassic.Identifier))
                return Tel.BaseThemeNs.BaseThemeClassic.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BaseThemeNs.BaseThemeDay.Identifier))
                return Tel.BaseThemeNs.BaseThemeDay.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BaseThemeNs.BaseThemeNight.Identifier))
                return Tel.BaseThemeNs.BaseThemeNight.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BaseThemeNs.BaseThemeTinted.Identifier))
                return Tel.BaseThemeNs.BaseThemeTinted.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BaseThemeNs.BaseThemeArctic.Identifier))
                return Tel.BaseThemeNs.BaseThemeArctic.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BaseThemeNs.BaseThemeClassic BaseThemeClassic1012849566 => BaseThemeClassic1012849566.TlSerialize(),
            Tel.BaseThemeNs.BaseThemeDay BaseThemeDay69724536 => BaseThemeDay69724536.TlSerialize(),
            Tel.BaseThemeNs.BaseThemeNight BaseThemeNight1212997976 => BaseThemeNight1212997976.TlSerialize(),
            Tel.BaseThemeNs.BaseThemeTinted BaseThemeTinted1834973166 => BaseThemeTinted1834973166.TlSerialize(),
            Tel.BaseThemeNs.BaseThemeArctic BaseThemeArctic1527845466 => BaseThemeArctic1527845466.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputThemeSettings,
    public abstract class InputThemeSettingsBase : ITlSerializable, ITlDeserializable<InputThemeSettingsBase> {
        public static InputThemeSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputThemeSettingsNs.InputThemeSettings.Identifier))
                return Tel.InputThemeSettingsNs.InputThemeSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputThemeSettingsNs.InputThemeSettings InputThemeSettings1881255857 => InputThemeSettings1881255857.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ThemeSettings,
    public abstract class ThemeSettingsBase : ITlSerializable, ITlDeserializable<ThemeSettingsBase> {
        public static ThemeSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ThemeSettingsNs.ThemeSettings.Identifier))
                return Tel.ThemeSettingsNs.ThemeSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ThemeSettingsNs.ThemeSettings ThemeSettings94849324 => ThemeSettings94849324.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: WebPageAttributeTheme, WebPageAttributeStory, WebPageAttributeStickerSet,
    public abstract class WebPageAttributeBase : ITlSerializable, ITlDeserializable<WebPageAttributeBase> {
        public int Flags {get;set;} = default!;
        public static WebPageAttributeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.WebPageAttributeNs.WebPageAttributeTheme.Identifier))
                return Tel.WebPageAttributeNs.WebPageAttributeTheme.TlDeserialize(des);
            if (id.SequenceEqual(Tel.WebPageAttributeNs.WebPageAttributeStory.Identifier))
                return Tel.WebPageAttributeNs.WebPageAttributeStory.TlDeserialize(des);
            if (id.SequenceEqual(Tel.WebPageAttributeNs.WebPageAttributeStickerSet.Identifier))
                return Tel.WebPageAttributeNs.WebPageAttributeStickerSet.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.WebPageAttributeNs.WebPageAttributeTheme WebPageAttributeTheme1421174295 => WebPageAttributeTheme1421174295.TlSerialize(),
            Tel.WebPageAttributeNs.WebPageAttributeStory WebPageAttributeStory781501415 => WebPageAttributeStory781501415.TlSerialize(),
            Tel.WebPageAttributeNs.WebPageAttributeStickerSet WebPageAttributeStickerSet1355547603 => WebPageAttributeStickerSet1355547603.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesVotesList,
    public abstract class MessagesVotesListBase : ITlSerializable, ITlDeserializable<MessagesVotesListBase> {
        public static MessagesVotesListBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesVotesListNs.MessagesVotesList.Identifier))
                return Tel.MessagesVotesListNs.MessagesVotesList.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesVotesListNs.MessagesVotesList MessagesVotesList1218005070 => MessagesVotesList1218005070.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BankCardOpenUrl,
    public abstract class BankCardOpenUrlBase : ITlSerializable, ITlDeserializable<BankCardOpenUrlBase> {
        public static BankCardOpenUrlBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BankCardOpenUrlNs.BankCardOpenUrl.Identifier))
                return Tel.BankCardOpenUrlNs.BankCardOpenUrl.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BankCardOpenUrlNs.BankCardOpenUrl BankCardOpenUrl177732982 => BankCardOpenUrl177732982.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsBankCardData,
    public abstract class PaymentsBankCardDataBase : ITlSerializable, ITlDeserializable<PaymentsBankCardDataBase> {
        public static PaymentsBankCardDataBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsBankCardDataNs.PaymentsBankCardData.Identifier))
                return Tel.PaymentsBankCardDataNs.PaymentsBankCardData.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsBankCardDataNs.PaymentsBankCardData PaymentsBankCardData1042605427 => PaymentsBankCardData1042605427.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DialogFilter, DialogFilterDefault, DialogFilterChatlist,
    public abstract class DialogFilterBase : ITlSerializable, ITlDeserializable<DialogFilterBase> {
        public static DialogFilterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DialogFilterNs.DialogFilter.Identifier))
                return Tel.DialogFilterNs.DialogFilter.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DialogFilterNs.DialogFilterDefault.Identifier))
                return Tel.DialogFilterNs.DialogFilterDefault.TlDeserialize(des);
            if (id.SequenceEqual(Tel.DialogFilterNs.DialogFilterChatlist.Identifier))
                return Tel.DialogFilterNs.DialogFilterChatlist.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DialogFilterNs.DialogFilter DialogFilter1605718587 => DialogFilter1605718587.TlSerialize(),
            Tel.DialogFilterNs.DialogFilterDefault DialogFilterDefault909284270 => DialogFilterDefault909284270.TlSerialize(),
            Tel.DialogFilterNs.DialogFilterChatlist DialogFilterChatlist1612542300 => DialogFilterChatlist1612542300.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DialogFilterSuggested,
    public abstract class DialogFilterSuggestedBase : ITlSerializable, ITlDeserializable<DialogFilterSuggestedBase> {
        public static DialogFilterSuggestedBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DialogFilterSuggestedNs.DialogFilterSuggested.Identifier))
                return Tel.DialogFilterSuggestedNs.DialogFilterSuggested.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DialogFilterSuggestedNs.DialogFilterSuggested DialogFilterSuggested2004110666 => DialogFilterSuggested2004110666.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsDateRangeDays,
    public abstract class StatsDateRangeDaysBase : ITlSerializable, ITlDeserializable<StatsDateRangeDaysBase> {
        public static StatsDateRangeDaysBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsDateRangeDaysNs.StatsDateRangeDays.Identifier))
                return Tel.StatsDateRangeDaysNs.StatsDateRangeDays.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsDateRangeDaysNs.StatsDateRangeDays StatsDateRangeDays1237848657 => StatsDateRangeDays1237848657.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsAbsValueAndPrev,
    public abstract class StatsAbsValueAndPrevBase : ITlSerializable, ITlDeserializable<StatsAbsValueAndPrevBase> {
        public static StatsAbsValueAndPrevBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsAbsValueAndPrevNs.StatsAbsValueAndPrev.Identifier))
                return Tel.StatsAbsValueAndPrevNs.StatsAbsValueAndPrev.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsAbsValueAndPrevNs.StatsAbsValueAndPrev StatsAbsValueAndPrev884757282 => StatsAbsValueAndPrev884757282.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsPercentValue,
    public abstract class StatsPercentValueBase : ITlSerializable, ITlDeserializable<StatsPercentValueBase> {
        public static StatsPercentValueBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsPercentValueNs.StatsPercentValue.Identifier))
                return Tel.StatsPercentValueNs.StatsPercentValue.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsPercentValueNs.StatsPercentValue StatsPercentValue875679776 => StatsPercentValue875679776.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsGraphAsync, StatsGraphError, StatsGraph,
    public abstract class StatsGraphBase : ITlSerializable, ITlDeserializable<StatsGraphBase> {
        public static StatsGraphBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsGraphNs.StatsGraphAsync.Identifier))
                return Tel.StatsGraphNs.StatsGraphAsync.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StatsGraphNs.StatsGraphError.Identifier))
                return Tel.StatsGraphNs.StatsGraphError.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StatsGraphNs.StatsGraph.Identifier))
                return Tel.StatsGraphNs.StatsGraph.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsGraphNs.StatsGraphAsync StatsGraphAsync1244130093 => StatsGraphAsync1244130093.TlSerialize(),
            Tel.StatsGraphNs.StatsGraphError StatsGraphError1092839390 => StatsGraphError1092839390.TlSerialize(),
            Tel.StatsGraphNs.StatsGraph StatsGraph1901828938 => StatsGraph1901828938.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsBroadcastStats,
    public abstract class StatsBroadcastStatsBase : ITlSerializable, ITlDeserializable<StatsBroadcastStatsBase> {
        public static StatsBroadcastStatsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsBroadcastStatsNs.StatsBroadcastStats.Identifier))
                return Tel.StatsBroadcastStatsNs.StatsBroadcastStats.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsBroadcastStatsNs.StatsBroadcastStats StatsBroadcastStats963421692 => StatsBroadcastStats963421692.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpPromoDataEmpty, HelpPromoData,
    public abstract class HelpPromoDataBase : ITlSerializable, ITlDeserializable<HelpPromoDataBase> {
        public int Expires {get;set;} = default!;
        public static HelpPromoDataBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpPromoDataNs.HelpPromoDataEmpty.Identifier))
                return Tel.HelpPromoDataNs.HelpPromoDataEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpPromoDataNs.HelpPromoData.Identifier))
                return Tel.HelpPromoDataNs.HelpPromoData.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpPromoDataNs.HelpPromoDataEmpty HelpPromoDataEmpty1728664459 => HelpPromoDataEmpty1728664459.TlSerialize(),
            Tel.HelpPromoDataNs.HelpPromoData HelpPromoData1942390465 => HelpPromoData1942390465.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: VideoSize, VideoSizeEmojiMarkup, VideoSizeStickerMarkup,
    public abstract class VideoSizeBase : ITlSerializable, ITlDeserializable<VideoSizeBase> {
        public static VideoSizeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.VideoSizeNs.VideoSize.Identifier))
                return Tel.VideoSizeNs.VideoSize.TlDeserialize(des);
            if (id.SequenceEqual(Tel.VideoSizeNs.VideoSizeEmojiMarkup.Identifier))
                return Tel.VideoSizeNs.VideoSizeEmojiMarkup.TlDeserialize(des);
            if (id.SequenceEqual(Tel.VideoSizeNs.VideoSizeStickerMarkup.Identifier))
                return Tel.VideoSizeNs.VideoSizeStickerMarkup.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.VideoSizeNs.VideoSize VideoSize567037804 => VideoSize567037804.TlSerialize(),
            Tel.VideoSizeNs.VideoSizeEmojiMarkup VideoSizeEmojiMarkup128171716 => VideoSizeEmojiMarkup128171716.TlSerialize(),
            Tel.VideoSizeNs.VideoSizeStickerMarkup VideoSizeStickerMarkup228623102 => VideoSizeStickerMarkup228623102.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsGroupTopPoster,
    public abstract class StatsGroupTopPosterBase : ITlSerializable, ITlDeserializable<StatsGroupTopPosterBase> {
        public static StatsGroupTopPosterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsGroupTopPosterNs.StatsGroupTopPoster.Identifier))
                return Tel.StatsGroupTopPosterNs.StatsGroupTopPoster.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsGroupTopPosterNs.StatsGroupTopPoster StatsGroupTopPoster1660637285 => StatsGroupTopPoster1660637285.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsGroupTopAdmin,
    public abstract class StatsGroupTopAdminBase : ITlSerializable, ITlDeserializable<StatsGroupTopAdminBase> {
        public static StatsGroupTopAdminBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsGroupTopAdminNs.StatsGroupTopAdmin.Identifier))
                return Tel.StatsGroupTopAdminNs.StatsGroupTopAdmin.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsGroupTopAdminNs.StatsGroupTopAdmin StatsGroupTopAdmin682079097 => StatsGroupTopAdmin682079097.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsGroupTopInviter,
    public abstract class StatsGroupTopInviterBase : ITlSerializable, ITlDeserializable<StatsGroupTopInviterBase> {
        public static StatsGroupTopInviterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsGroupTopInviterNs.StatsGroupTopInviter.Identifier))
                return Tel.StatsGroupTopInviterNs.StatsGroupTopInviter.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsGroupTopInviterNs.StatsGroupTopInviter StatsGroupTopInviter1398765469 => StatsGroupTopInviter1398765469.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsMegagroupStats,
    public abstract class StatsMegagroupStatsBase : ITlSerializable, ITlDeserializable<StatsMegagroupStatsBase> {
        public static StatsMegagroupStatsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsMegagroupStatsNs.StatsMegagroupStats.Identifier))
                return Tel.StatsMegagroupStatsNs.StatsMegagroupStats.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsMegagroupStatsNs.StatsMegagroupStats StatsMegagroupStats276825834 => StatsMegagroupStats276825834.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: GlobalPrivacySettings,
    public abstract class GlobalPrivacySettingsBase : ITlSerializable, ITlDeserializable<GlobalPrivacySettingsBase> {
        public static GlobalPrivacySettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GlobalPrivacySettingsNs.GlobalPrivacySettings.Identifier))
                return Tel.GlobalPrivacySettingsNs.GlobalPrivacySettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GlobalPrivacySettingsNs.GlobalPrivacySettings GlobalPrivacySettings1934380235 => GlobalPrivacySettings1934380235.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpCountryCode,
    public abstract class HelpCountryCodeBase : ITlSerializable, ITlDeserializable<HelpCountryCodeBase> {
        public static HelpCountryCodeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpCountryCodeNs.HelpCountryCode.Identifier))
                return Tel.HelpCountryCodeNs.HelpCountryCode.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpCountryCodeNs.HelpCountryCode HelpCountryCode1107543535 => HelpCountryCode1107543535.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpCountry,
    public abstract class HelpCountryBase : ITlSerializable, ITlDeserializable<HelpCountryBase> {
        public static HelpCountryBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpCountryNs.HelpCountry.Identifier))
                return Tel.HelpCountryNs.HelpCountry.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpCountryNs.HelpCountry HelpCountry1014526429 => HelpCountry1014526429.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpCountriesListNotModified, HelpCountriesList,
    public abstract class HelpCountriesListBase : ITlSerializable, ITlDeserializable<HelpCountriesListBase> {
        public static HelpCountriesListBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpCountriesListNs.HelpCountriesListNotModified.Identifier))
                return Tel.HelpCountriesListNs.HelpCountriesListNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpCountriesListNs.HelpCountriesList.Identifier))
                return Tel.HelpCountriesListNs.HelpCountriesList.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpCountriesListNs.HelpCountriesListNotModified HelpCountriesListNotModified1815339214 => HelpCountriesListNotModified1815339214.TlSerialize(),
            Tel.HelpCountriesListNs.HelpCountriesList HelpCountriesList2016381538 => HelpCountriesList2016381538.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageViews,
    public abstract class MessageViewsBase : ITlSerializable, ITlDeserializable<MessageViewsBase> {
        public static MessageViewsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageViewsNs.MessageViews.Identifier))
                return Tel.MessageViewsNs.MessageViews.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageViewsNs.MessageViews MessageViews1163625789 => MessageViews1163625789.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesMessageViews,
    public abstract class MessagesMessageViewsBase : ITlSerializable, ITlDeserializable<MessagesMessageViewsBase> {
        public static MessagesMessageViewsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesMessageViewsNs.MessagesMessageViews.Identifier))
                return Tel.MessagesMessageViewsNs.MessagesMessageViews.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesMessageViewsNs.MessagesMessageViews MessagesMessageViews1228606141 => MessagesMessageViews1228606141.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesDiscussionMessage,
    public abstract class MessagesDiscussionMessageBase : ITlSerializable, ITlDeserializable<MessagesDiscussionMessageBase> {
        public static MessagesDiscussionMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesDiscussionMessageNs.MessagesDiscussionMessage.Identifier))
                return Tel.MessagesDiscussionMessageNs.MessagesDiscussionMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesDiscussionMessageNs.MessagesDiscussionMessage MessagesDiscussionMessage1506535550 => MessagesDiscussionMessage1506535550.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageReplyHeader, MessageReplyStoryHeader,
    public abstract class MessageReplyHeaderBase : ITlSerializable, ITlDeserializable<MessageReplyHeaderBase> {
        public static MessageReplyHeaderBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageReplyHeaderNs.MessageReplyHeader.Identifier))
                return Tel.MessageReplyHeaderNs.MessageReplyHeader.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageReplyHeaderNs.MessageReplyStoryHeader.Identifier))
                return Tel.MessageReplyHeaderNs.MessageReplyStoryHeader.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageReplyHeaderNs.MessageReplyHeader MessageReplyHeader1346631205 => MessageReplyHeader1346631205.TlSerialize(),
            Tel.MessageReplyHeaderNs.MessageReplyStoryHeader MessageReplyStoryHeader240843065 => MessageReplyStoryHeader240843065.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageReplies,
    public abstract class MessageRepliesBase : ITlSerializable, ITlDeserializable<MessageRepliesBase> {
        public static MessageRepliesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageRepliesNs.MessageReplies.Identifier))
                return Tel.MessageRepliesNs.MessageReplies.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageRepliesNs.MessageReplies MessageReplies2083123262 => MessageReplies2083123262.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PeerBlocked,
    public abstract class PeerBlockedBase : ITlSerializable, ITlDeserializable<PeerBlockedBase> {
        public static PeerBlockedBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PeerBlockedNs.PeerBlocked.Identifier))
                return Tel.PeerBlockedNs.PeerBlocked.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PeerBlockedNs.PeerBlocked PeerBlocked386039788 => PeerBlocked386039788.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsMessageStats,
    public abstract class StatsMessageStatsBase : ITlSerializable, ITlDeserializable<StatsMessageStatsBase> {
        public static StatsMessageStatsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsMessageStatsNs.StatsMessageStats.Identifier))
                return Tel.StatsMessageStatsNs.StatsMessageStats.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsMessageStatsNs.StatsMessageStats StatsMessageStats2145983508 => StatsMessageStats2145983508.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: GroupCallDiscarded, GroupCall,
    public abstract class GroupCallBase : ITlSerializable, ITlDeserializable<GroupCallBase> {
        public long Id {get;set;} = default!;
        public long AccessHash {get;set;} = default!;
        public static GroupCallBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GroupCallNs.GroupCallDiscarded.Identifier))
                return Tel.GroupCallNs.GroupCallDiscarded.TlDeserialize(des);
            if (id.SequenceEqual(Tel.GroupCallNs.GroupCall.Identifier))
                return Tel.GroupCallNs.GroupCall.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GroupCallNs.GroupCallDiscarded GroupCallDiscarded2004925620 => GroupCallDiscarded2004925620.TlSerialize(),
            Tel.GroupCallNs.GroupCall GroupCall711498484 => GroupCall711498484.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputGroupCall,
    public abstract class InputGroupCallBase : ITlSerializable, ITlDeserializable<InputGroupCallBase> {
        public static InputGroupCallBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputGroupCallNs.InputGroupCall.Identifier))
                return Tel.InputGroupCallNs.InputGroupCall.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputGroupCallNs.InputGroupCall InputGroupCall659913713 => InputGroupCall659913713.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: GroupCallParticipant,
    public abstract class GroupCallParticipantBase : ITlSerializable, ITlDeserializable<GroupCallParticipantBase> {
        public static GroupCallParticipantBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GroupCallParticipantNs.GroupCallParticipant.Identifier))
                return Tel.GroupCallParticipantNs.GroupCallParticipant.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GroupCallParticipantNs.GroupCallParticipant GroupCallParticipant341428482 => GroupCallParticipant341428482.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneGroupCall,
    public abstract class PhoneGroupCallBase : ITlSerializable, ITlDeserializable<PhoneGroupCallBase> {
        public static PhoneGroupCallBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneGroupCallNs.PhoneGroupCall.Identifier))
                return Tel.PhoneGroupCallNs.PhoneGroupCall.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneGroupCallNs.PhoneGroupCall PhoneGroupCall1636664659 => PhoneGroupCall1636664659.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneGroupParticipants,
    public abstract class PhoneGroupParticipantsBase : ITlSerializable, ITlDeserializable<PhoneGroupParticipantsBase> {
        public static PhoneGroupParticipantsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneGroupParticipantsNs.PhoneGroupParticipants.Identifier))
                return Tel.PhoneGroupParticipantsNs.PhoneGroupParticipants.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneGroupParticipantsNs.PhoneGroupParticipants PhoneGroupParticipants193506890 => PhoneGroupParticipants193506890.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InlineQueryPeerTypeSameBotPM, InlineQueryPeerTypePM, InlineQueryPeerTypeChat, InlineQueryPeerTypeMegagroup, InlineQueryPeerTypeBroadcast, InlineQueryPeerTypeBotPM,
    public abstract class InlineQueryPeerTypeBase : ITlSerializable, ITlDeserializable<InlineQueryPeerTypeBase> {
        public static InlineQueryPeerTypeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeSameBotPM.Identifier))
                return Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeSameBotPM.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypePM.Identifier))
                return Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypePM.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeChat.Identifier))
                return Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeMegagroup.Identifier))
                return Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeMegagroup.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeBroadcast.Identifier))
                return Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeBroadcast.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeBotPM.Identifier))
                return Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeBotPM.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeSameBotPM InlineQueryPeerTypeSameBotPM813821341 => InlineQueryPeerTypeSameBotPM813821341.TlSerialize(),
            Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypePM InlineQueryPeerTypePM2093215828 => InlineQueryPeerTypePM2093215828.TlSerialize(),
            Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeChat InlineQueryPeerTypeChat681130742 => InlineQueryPeerTypeChat681130742.TlSerialize(),
            Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeMegagroup InlineQueryPeerTypeMegagroup1589952067 => InlineQueryPeerTypeMegagroup1589952067.TlSerialize(),
            Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeBroadcast InlineQueryPeerTypeBroadcast1664413338 => InlineQueryPeerTypeBroadcast1664413338.TlSerialize(),
            Tel.InlineQueryPeerTypeNs.InlineQueryPeerTypeBotPM InlineQueryPeerTypeBotPM238759180 => InlineQueryPeerTypeBotPM238759180.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesHistoryImport,
    public abstract class MessagesHistoryImportBase : ITlSerializable, ITlDeserializable<MessagesHistoryImportBase> {
        public static MessagesHistoryImportBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesHistoryImportNs.MessagesHistoryImport.Identifier))
                return Tel.MessagesHistoryImportNs.MessagesHistoryImport.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesHistoryImportNs.MessagesHistoryImport MessagesHistoryImport375566091 => MessagesHistoryImport375566091.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesHistoryImportParsed,
    public abstract class MessagesHistoryImportParsedBase : ITlSerializable, ITlDeserializable<MessagesHistoryImportParsedBase> {
        public static MessagesHistoryImportParsedBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesHistoryImportParsedNs.MessagesHistoryImportParsed.Identifier))
                return Tel.MessagesHistoryImportParsedNs.MessagesHistoryImportParsed.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesHistoryImportParsedNs.MessagesHistoryImportParsed MessagesHistoryImportParsed1578088377 => MessagesHistoryImportParsed1578088377.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesAffectedFoundMessages,
    public abstract class MessagesAffectedFoundMessagesBase : ITlSerializable, ITlDeserializable<MessagesAffectedFoundMessagesBase> {
        public static MessagesAffectedFoundMessagesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesAffectedFoundMessagesNs.MessagesAffectedFoundMessages.Identifier))
                return Tel.MessagesAffectedFoundMessagesNs.MessagesAffectedFoundMessages.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesAffectedFoundMessagesNs.MessagesAffectedFoundMessages MessagesAffectedFoundMessages275956116 => MessagesAffectedFoundMessages275956116.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatInviteImporter,
    public abstract class ChatInviteImporterBase : ITlSerializable, ITlDeserializable<ChatInviteImporterBase> {
        public static ChatInviteImporterBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatInviteImporterNs.ChatInviteImporter.Identifier))
                return Tel.ChatInviteImporterNs.ChatInviteImporter.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatInviteImporterNs.ChatInviteImporter ChatInviteImporter1940201511 => ChatInviteImporter1940201511.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesExportedChatInvites,
    public abstract class MessagesExportedChatInvitesBase : ITlSerializable, ITlDeserializable<MessagesExportedChatInvitesBase> {
        public static MessagesExportedChatInvitesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesExportedChatInvitesNs.MessagesExportedChatInvites.Identifier))
                return Tel.MessagesExportedChatInvitesNs.MessagesExportedChatInvites.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesExportedChatInvitesNs.MessagesExportedChatInvites MessagesExportedChatInvites1111085620 => MessagesExportedChatInvites1111085620.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesExportedChatInvite, MessagesExportedChatInviteReplaced,
    public abstract class MessagesExportedChatInviteBase : ITlSerializable, ITlDeserializable<MessagesExportedChatInviteBase> {
        public ExportedChatInviteBase Invite {get;set;} = default!;
        public List<UserBase> Users {get;set;} = default!;
        public static MessagesExportedChatInviteBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesExportedChatInviteNs.MessagesExportedChatInvite.Identifier))
                return Tel.MessagesExportedChatInviteNs.MessagesExportedChatInvite.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesExportedChatInviteNs.MessagesExportedChatInviteReplaced.Identifier))
                return Tel.MessagesExportedChatInviteNs.MessagesExportedChatInviteReplaced.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesExportedChatInviteNs.MessagesExportedChatInvite MessagesExportedChatInvite410107472 => MessagesExportedChatInvite410107472.TlSerialize(),
            Tel.MessagesExportedChatInviteNs.MessagesExportedChatInviteReplaced MessagesExportedChatInviteReplaced572915951 => MessagesExportedChatInviteReplaced572915951.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesChatInviteImporters,
    public abstract class MessagesChatInviteImportersBase : ITlSerializable, ITlDeserializable<MessagesChatInviteImportersBase> {
        public static MessagesChatInviteImportersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesChatInviteImportersNs.MessagesChatInviteImporters.Identifier))
                return Tel.MessagesChatInviteImportersNs.MessagesChatInviteImporters.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesChatInviteImportersNs.MessagesChatInviteImporters MessagesChatInviteImporters2118733814 => MessagesChatInviteImporters2118733814.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatAdminWithInvites,
    public abstract class ChatAdminWithInvitesBase : ITlSerializable, ITlDeserializable<ChatAdminWithInvitesBase> {
        public static ChatAdminWithInvitesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatAdminWithInvitesNs.ChatAdminWithInvites.Identifier))
                return Tel.ChatAdminWithInvitesNs.ChatAdminWithInvites.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatAdminWithInvitesNs.ChatAdminWithInvites ChatAdminWithInvites219353309 => ChatAdminWithInvites219353309.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesChatAdminsWithInvites,
    public abstract class MessagesChatAdminsWithInvitesBase : ITlSerializable, ITlDeserializable<MessagesChatAdminsWithInvitesBase> {
        public static MessagesChatAdminsWithInvitesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesChatAdminsWithInvitesNs.MessagesChatAdminsWithInvites.Identifier))
                return Tel.MessagesChatAdminsWithInvitesNs.MessagesChatAdminsWithInvites.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesChatAdminsWithInvitesNs.MessagesChatAdminsWithInvites MessagesChatAdminsWithInvites1231326505 => MessagesChatAdminsWithInvites1231326505.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesCheckedHistoryImportPeer,
    public abstract class MessagesCheckedHistoryImportPeerBase : ITlSerializable, ITlDeserializable<MessagesCheckedHistoryImportPeerBase> {
        public static MessagesCheckedHistoryImportPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesCheckedHistoryImportPeerNs.MessagesCheckedHistoryImportPeer.Identifier))
                return Tel.MessagesCheckedHistoryImportPeerNs.MessagesCheckedHistoryImportPeer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesCheckedHistoryImportPeerNs.MessagesCheckedHistoryImportPeer MessagesCheckedHistoryImportPeer1571952873 => MessagesCheckedHistoryImportPeer1571952873.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneJoinAsPeers,
    public abstract class PhoneJoinAsPeersBase : ITlSerializable, ITlDeserializable<PhoneJoinAsPeersBase> {
        public static PhoneJoinAsPeersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneJoinAsPeersNs.PhoneJoinAsPeers.Identifier))
                return Tel.PhoneJoinAsPeersNs.PhoneJoinAsPeers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneJoinAsPeersNs.PhoneJoinAsPeers PhoneJoinAsPeers1343921601 => PhoneJoinAsPeers1343921601.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneExportedGroupCallInvite,
    public abstract class PhoneExportedGroupCallInviteBase : ITlSerializable, ITlDeserializable<PhoneExportedGroupCallInviteBase> {
        public static PhoneExportedGroupCallInviteBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneExportedGroupCallInviteNs.PhoneExportedGroupCallInvite.Identifier))
                return Tel.PhoneExportedGroupCallInviteNs.PhoneExportedGroupCallInvite.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneExportedGroupCallInviteNs.PhoneExportedGroupCallInvite PhoneExportedGroupCallInvite541839704 => PhoneExportedGroupCallInvite541839704.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: GroupCallParticipantVideoSourceGroup,
    public abstract class GroupCallParticipantVideoSourceGroupBase : ITlSerializable, ITlDeserializable<GroupCallParticipantVideoSourceGroupBase> {
        public static GroupCallParticipantVideoSourceGroupBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GroupCallParticipantVideoSourceGroupNs.GroupCallParticipantVideoSourceGroup.Identifier))
                return Tel.GroupCallParticipantVideoSourceGroupNs.GroupCallParticipantVideoSourceGroup.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GroupCallParticipantVideoSourceGroupNs.GroupCallParticipantVideoSourceGroup GroupCallParticipantVideoSourceGroup592373577 => GroupCallParticipantVideoSourceGroup592373577.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: GroupCallParticipantVideo,
    public abstract class GroupCallParticipantVideoBase : ITlSerializable, ITlDeserializable<GroupCallParticipantVideoBase> {
        public static GroupCallParticipantVideoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GroupCallParticipantVideoNs.GroupCallParticipantVideo.Identifier))
                return Tel.GroupCallParticipantVideoNs.GroupCallParticipantVideo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GroupCallParticipantVideoNs.GroupCallParticipantVideo GroupCallParticipantVideo1735736008 => GroupCallParticipantVideo1735736008.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StickersSuggestedShortName,
    public abstract class StickersSuggestedShortNameBase : ITlSerializable, ITlDeserializable<StickersSuggestedShortNameBase> {
        public static StickersSuggestedShortNameBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StickersSuggestedShortNameNs.StickersSuggestedShortName.Identifier))
                return Tel.StickersSuggestedShortNameNs.StickersSuggestedShortName.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StickersSuggestedShortNameNs.StickersSuggestedShortName StickersSuggestedShortName2046910401 => StickersSuggestedShortName2046910401.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotCommandScopeDefault, BotCommandScopeUsers, BotCommandScopeChats, BotCommandScopeChatAdmins, BotCommandScopePeer, BotCommandScopePeerAdmins, BotCommandScopePeerUser,
    public abstract class BotCommandScopeBase : ITlSerializable, ITlDeserializable<BotCommandScopeBase> {
        public static BotCommandScopeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotCommandScopeNs.BotCommandScopeDefault.Identifier))
                return Tel.BotCommandScopeNs.BotCommandScopeDefault.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotCommandScopeNs.BotCommandScopeUsers.Identifier))
                return Tel.BotCommandScopeNs.BotCommandScopeUsers.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotCommandScopeNs.BotCommandScopeChats.Identifier))
                return Tel.BotCommandScopeNs.BotCommandScopeChats.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotCommandScopeNs.BotCommandScopeChatAdmins.Identifier))
                return Tel.BotCommandScopeNs.BotCommandScopeChatAdmins.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotCommandScopeNs.BotCommandScopePeer.Identifier))
                return Tel.BotCommandScopeNs.BotCommandScopePeer.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotCommandScopeNs.BotCommandScopePeerAdmins.Identifier))
                return Tel.BotCommandScopeNs.BotCommandScopePeerAdmins.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotCommandScopeNs.BotCommandScopePeerUser.Identifier))
                return Tel.BotCommandScopeNs.BotCommandScopePeerUser.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotCommandScopeNs.BotCommandScopeDefault BotCommandScopeDefault795652779 => BotCommandScopeDefault795652779.TlSerialize(),
            Tel.BotCommandScopeNs.BotCommandScopeUsers BotCommandScopeUsers1011811544 => BotCommandScopeUsers1011811544.TlSerialize(),
            Tel.BotCommandScopeNs.BotCommandScopeChats BotCommandScopeChats1877059713 => BotCommandScopeChats1877059713.TlSerialize(),
            Tel.BotCommandScopeNs.BotCommandScopeChatAdmins BotCommandScopeChatAdmins1180016534 => BotCommandScopeChatAdmins1180016534.TlSerialize(),
            Tel.BotCommandScopeNs.BotCommandScopePeer BotCommandScopePeer610432643 => BotCommandScopePeer610432643.TlSerialize(),
            Tel.BotCommandScopeNs.BotCommandScopePeerAdmins BotCommandScopePeerAdmins1071145937 => BotCommandScopePeerAdmins1071145937.TlSerialize(),
            Tel.BotCommandScopeNs.BotCommandScopePeerUser BotCommandScopePeerUser169026035 => BotCommandScopePeerUser169026035.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountResetPasswordFailedWait, AccountResetPasswordRequestedWait, AccountResetPasswordOk,
    public abstract class AccountResetPasswordResultBase : ITlSerializable, ITlDeserializable<AccountResetPasswordResultBase> {
        public static AccountResetPasswordResultBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountResetPasswordResultNs.AccountResetPasswordFailedWait.Identifier))
                return Tel.AccountResetPasswordResultNs.AccountResetPasswordFailedWait.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AccountResetPasswordResultNs.AccountResetPasswordRequestedWait.Identifier))
                return Tel.AccountResetPasswordResultNs.AccountResetPasswordRequestedWait.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AccountResetPasswordResultNs.AccountResetPasswordOk.Identifier))
                return Tel.AccountResetPasswordResultNs.AccountResetPasswordOk.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountResetPasswordResultNs.AccountResetPasswordFailedWait AccountResetPasswordFailedWait478701471 => AccountResetPasswordFailedWait478701471.TlSerialize(),
            Tel.AccountResetPasswordResultNs.AccountResetPasswordRequestedWait AccountResetPasswordRequestedWait370148227 => AccountResetPasswordRequestedWait370148227.TlSerialize(),
            Tel.AccountResetPasswordResultNs.AccountResetPasswordOk AccountResetPasswordOk383330754 => AccountResetPasswordOk383330754.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SponsoredMessage,
    public abstract class SponsoredMessageBase : ITlSerializable, ITlDeserializable<SponsoredMessageBase> {
        public static SponsoredMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SponsoredMessageNs.SponsoredMessage.Identifier))
                return Tel.SponsoredMessageNs.SponsoredMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SponsoredMessageNs.SponsoredMessage SponsoredMessage1108478618 => SponsoredMessage1108478618.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesSponsoredMessages, MessagesSponsoredMessagesEmpty,
    public abstract class MessagesSponsoredMessagesBase : ITlSerializable, ITlDeserializable<MessagesSponsoredMessagesBase> {
        public static MessagesSponsoredMessagesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesSponsoredMessagesNs.MessagesSponsoredMessages.Identifier))
                return Tel.MessagesSponsoredMessagesNs.MessagesSponsoredMessages.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesSponsoredMessagesNs.MessagesSponsoredMessagesEmpty.Identifier))
                return Tel.MessagesSponsoredMessagesNs.MessagesSponsoredMessagesEmpty.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesSponsoredMessagesNs.MessagesSponsoredMessages MessagesSponsoredMessages907141753 => MessagesSponsoredMessages907141753.TlSerialize(),
            Tel.MessagesSponsoredMessagesNs.MessagesSponsoredMessagesEmpty MessagesSponsoredMessagesEmpty406407439 => MessagesSponsoredMessagesEmpty406407439.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SearchResultsCalendarPeriod,
    public abstract class SearchResultsCalendarPeriodBase : ITlSerializable, ITlDeserializable<SearchResultsCalendarPeriodBase> {
        public static SearchResultsCalendarPeriodBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SearchResultsCalendarPeriodNs.SearchResultsCalendarPeriod.Identifier))
                return Tel.SearchResultsCalendarPeriodNs.SearchResultsCalendarPeriod.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SearchResultsCalendarPeriodNs.SearchResultsCalendarPeriod SearchResultsCalendarPeriod911191137 => SearchResultsCalendarPeriod911191137.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesSearchResultsCalendar,
    public abstract class MessagesSearchResultsCalendarBase : ITlSerializable, ITlDeserializable<MessagesSearchResultsCalendarBase> {
        public static MessagesSearchResultsCalendarBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesSearchResultsCalendarNs.MessagesSearchResultsCalendar.Identifier))
                return Tel.MessagesSearchResultsCalendarNs.MessagesSearchResultsCalendar.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesSearchResultsCalendarNs.MessagesSearchResultsCalendar MessagesSearchResultsCalendar343859772 => MessagesSearchResultsCalendar343859772.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SearchResultPosition,
    public abstract class SearchResultsPositionBase : ITlSerializable, ITlDeserializable<SearchResultsPositionBase> {
        public static SearchResultsPositionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SearchResultsPositionNs.SearchResultPosition.Identifier))
                return Tel.SearchResultsPositionNs.SearchResultPosition.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SearchResultsPositionNs.SearchResultPosition SearchResultPosition2137295719 => SearchResultPosition2137295719.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesSearchResultsPositions,
    public abstract class MessagesSearchResultsPositionsBase : ITlSerializable, ITlDeserializable<MessagesSearchResultsPositionsBase> {
        public static MessagesSearchResultsPositionsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesSearchResultsPositionsNs.MessagesSearchResultsPositions.Identifier))
                return Tel.MessagesSearchResultsPositionsNs.MessagesSearchResultsPositions.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesSearchResultsPositionsNs.MessagesSearchResultsPositions MessagesSearchResultsPositions1404185519 => MessagesSearchResultsPositions1404185519.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelsSendAsPeers,
    public abstract class ChannelsSendAsPeersBase : ITlSerializable, ITlDeserializable<ChannelsSendAsPeersBase> {
        public static ChannelsSendAsPeersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelsSendAsPeersNs.ChannelsSendAsPeers.Identifier))
                return Tel.ChannelsSendAsPeersNs.ChannelsSendAsPeers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelsSendAsPeersNs.ChannelsSendAsPeers ChannelsSendAsPeers191450938 => ChannelsSendAsPeers191450938.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: UsersUserFull,
    public abstract class UsersUserFullBase : ITlSerializable, ITlDeserializable<UsersUserFullBase> {
        public static UsersUserFullBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UsersUserFullNs.UsersUserFull.Identifier))
                return Tel.UsersUserFullNs.UsersUserFull.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UsersUserFullNs.UsersUserFull UsersUserFull997004590 => UsersUserFull997004590.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesPeerSettings,
    public abstract class MessagesPeerSettingsBase : ITlSerializable, ITlDeserializable<MessagesPeerSettingsBase> {
        public static MessagesPeerSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesPeerSettingsNs.MessagesPeerSettings.Identifier))
                return Tel.MessagesPeerSettingsNs.MessagesPeerSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesPeerSettingsNs.MessagesPeerSettings MessagesPeerSettings1753266509 => MessagesPeerSettings1753266509.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AuthLoggedOut,
    public abstract class AuthLoggedOutBase : ITlSerializable, ITlDeserializable<AuthLoggedOutBase> {
        public static AuthLoggedOutBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AuthLoggedOutNs.AuthLoggedOut.Identifier))
                return Tel.AuthLoggedOutNs.AuthLoggedOut.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AuthLoggedOutNs.AuthLoggedOut AuthLoggedOut1012759713 => AuthLoggedOut1012759713.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ReactionCount,
    public abstract class ReactionCountBase : ITlSerializable, ITlDeserializable<ReactionCountBase> {
        public static ReactionCountBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ReactionCountNs.ReactionCount.Identifier))
                return Tel.ReactionCountNs.ReactionCount.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ReactionCountNs.ReactionCount ReactionCount1546531968 => ReactionCount1546531968.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageReactions,
    public abstract class MessageReactionsBase : ITlSerializable, ITlDeserializable<MessageReactionsBase> {
        public static MessageReactionsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageReactionsNs.MessageReactions.Identifier))
                return Tel.MessageReactionsNs.MessageReactions.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageReactionsNs.MessageReactions MessageReactions1328256121 => MessageReactions1328256121.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesMessageReactionsList,
    public abstract class MessagesMessageReactionsListBase : ITlSerializable, ITlDeserializable<MessagesMessageReactionsListBase> {
        public static MessagesMessageReactionsListBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesMessageReactionsListNs.MessagesMessageReactionsList.Identifier))
                return Tel.MessagesMessageReactionsListNs.MessagesMessageReactionsList.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesMessageReactionsListNs.MessagesMessageReactionsList MessagesMessageReactionsList834488621 => MessagesMessageReactionsList834488621.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AvailableReaction,
    public abstract class AvailableReactionBase : ITlSerializable, ITlDeserializable<AvailableReactionBase> {
        public static AvailableReactionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AvailableReactionNs.AvailableReaction.Identifier))
                return Tel.AvailableReactionNs.AvailableReaction.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AvailableReactionNs.AvailableReaction AvailableReaction1065882623 => AvailableReaction1065882623.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesAvailableReactionsNotModified, MessagesAvailableReactions,
    public abstract class MessagesAvailableReactionsBase : ITlSerializable, ITlDeserializable<MessagesAvailableReactionsBase> {
        public static MessagesAvailableReactionsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesAvailableReactionsNs.MessagesAvailableReactionsNotModified.Identifier))
                return Tel.MessagesAvailableReactionsNs.MessagesAvailableReactionsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesAvailableReactionsNs.MessagesAvailableReactions.Identifier))
                return Tel.MessagesAvailableReactionsNs.MessagesAvailableReactions.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesAvailableReactionsNs.MessagesAvailableReactionsNotModified MessagesAvailableReactionsNotModified1626924713 => MessagesAvailableReactionsNotModified1626924713.TlSerialize(),
            Tel.MessagesAvailableReactionsNs.MessagesAvailableReactions MessagesAvailableReactions1989032621 => MessagesAvailableReactions1989032621.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagePeerReaction,
    public abstract class MessagePeerReactionBase : ITlSerializable, ITlDeserializable<MessagePeerReactionBase> {
        public static MessagePeerReactionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagePeerReactionNs.MessagePeerReaction.Identifier))
                return Tel.MessagePeerReactionNs.MessagePeerReaction.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagePeerReactionNs.MessagePeerReaction MessagePeerReaction1938180548 => MessagePeerReaction1938180548.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: GroupCallStreamChannel,
    public abstract class GroupCallStreamChannelBase : ITlSerializable, ITlDeserializable<GroupCallStreamChannelBase> {
        public static GroupCallStreamChannelBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GroupCallStreamChannelNs.GroupCallStreamChannel.Identifier))
                return Tel.GroupCallStreamChannelNs.GroupCallStreamChannel.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GroupCallStreamChannelNs.GroupCallStreamChannel GroupCallStreamChannel2132064081 => GroupCallStreamChannel2132064081.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneGroupCallStreamChannels,
    public abstract class PhoneGroupCallStreamChannelsBase : ITlSerializable, ITlDeserializable<PhoneGroupCallStreamChannelsBase> {
        public static PhoneGroupCallStreamChannelsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneGroupCallStreamChannelsNs.PhoneGroupCallStreamChannels.Identifier))
                return Tel.PhoneGroupCallStreamChannelsNs.PhoneGroupCallStreamChannels.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneGroupCallStreamChannelsNs.PhoneGroupCallStreamChannels PhoneGroupCallStreamChannels790330702 => PhoneGroupCallStreamChannels790330702.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PhoneGroupCallStreamRtmpUrl,
    public abstract class PhoneGroupCallStreamRtmpUrlBase : ITlSerializable, ITlDeserializable<PhoneGroupCallStreamRtmpUrlBase> {
        public static PhoneGroupCallStreamRtmpUrlBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PhoneGroupCallStreamRtmpUrlNs.PhoneGroupCallStreamRtmpUrl.Identifier))
                return Tel.PhoneGroupCallStreamRtmpUrlNs.PhoneGroupCallStreamRtmpUrl.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PhoneGroupCallStreamRtmpUrlNs.PhoneGroupCallStreamRtmpUrl PhoneGroupCallStreamRtmpUrl767505458 => PhoneGroupCallStreamRtmpUrl767505458.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AttachMenuBotIconColor,
    public abstract class AttachMenuBotIconColorBase : ITlSerializable, ITlDeserializable<AttachMenuBotIconColorBase> {
        public static AttachMenuBotIconColorBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AttachMenuBotIconColorNs.AttachMenuBotIconColor.Identifier))
                return Tel.AttachMenuBotIconColorNs.AttachMenuBotIconColor.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AttachMenuBotIconColorNs.AttachMenuBotIconColor AttachMenuBotIconColor1165423600 => AttachMenuBotIconColor1165423600.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AttachMenuBotIcon,
    public abstract class AttachMenuBotIconBase : ITlSerializable, ITlDeserializable<AttachMenuBotIconBase> {
        public static AttachMenuBotIconBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AttachMenuBotIconNs.AttachMenuBotIcon.Identifier))
                return Tel.AttachMenuBotIconNs.AttachMenuBotIcon.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AttachMenuBotIconNs.AttachMenuBotIcon AttachMenuBotIcon1297663893 => AttachMenuBotIcon1297663893.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AttachMenuBot,
    public abstract class AttachMenuBotBase : ITlSerializable, ITlDeserializable<AttachMenuBotBase> {
        public static AttachMenuBotBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AttachMenuBotNs.AttachMenuBot.Identifier))
                return Tel.AttachMenuBotNs.AttachMenuBot.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AttachMenuBotNs.AttachMenuBot AttachMenuBot653423106 => AttachMenuBot653423106.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AttachMenuBotsNotModified, AttachMenuBots,
    public abstract class AttachMenuBotsBase : ITlSerializable, ITlDeserializable<AttachMenuBotsBase> {
        public static AttachMenuBotsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AttachMenuBotsNs.AttachMenuBotsNotModified.Identifier))
                return Tel.AttachMenuBotsNs.AttachMenuBotsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AttachMenuBotsNs.AttachMenuBots.Identifier))
                return Tel.AttachMenuBotsNs.AttachMenuBots.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AttachMenuBotsNs.AttachMenuBotsNotModified AttachMenuBotsNotModified237467044 => AttachMenuBotsNotModified237467044.TlSerialize(),
            Tel.AttachMenuBotsNs.AttachMenuBots AttachMenuBots1011024320 => AttachMenuBots1011024320.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AttachMenuBotsBot,
    public abstract class AttachMenuBotsBotBase : ITlSerializable, ITlDeserializable<AttachMenuBotsBotBase> {
        public static AttachMenuBotsBotBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AttachMenuBotsBotNs.AttachMenuBotsBot.Identifier))
                return Tel.AttachMenuBotsBotNs.AttachMenuBotsBot.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AttachMenuBotsBotNs.AttachMenuBotsBot AttachMenuBotsBot1816172929 => AttachMenuBotsBot1816172929.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: WebViewResultUrl,
    public abstract class WebViewResultBase : ITlSerializable, ITlDeserializable<WebViewResultBase> {
        public static WebViewResultBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.WebViewResultNs.WebViewResultUrl.Identifier))
                return Tel.WebViewResultNs.WebViewResultUrl.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.WebViewResultNs.WebViewResultUrl WebViewResultUrl1294139288 => WebViewResultUrl1294139288.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: WebViewMessageSent,
    public abstract class WebViewMessageSentBase : ITlSerializable, ITlDeserializable<WebViewMessageSentBase> {
        public static WebViewMessageSentBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.WebViewMessageSentNs.WebViewMessageSent.Identifier))
                return Tel.WebViewMessageSentNs.WebViewMessageSent.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.WebViewMessageSentNs.WebViewMessageSent WebViewMessageSent211046684 => WebViewMessageSent211046684.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotMenuButtonDefault, BotMenuButtonCommands, BotMenuButton,
    public abstract class BotMenuButtonBase : ITlSerializable, ITlDeserializable<BotMenuButtonBase> {
        public static BotMenuButtonBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotMenuButtonNs.BotMenuButtonDefault.Identifier))
                return Tel.BotMenuButtonNs.BotMenuButtonDefault.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotMenuButtonNs.BotMenuButtonCommands.Identifier))
                return Tel.BotMenuButtonNs.BotMenuButtonCommands.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotMenuButtonNs.BotMenuButton.Identifier))
                return Tel.BotMenuButtonNs.BotMenuButton.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotMenuButtonNs.BotMenuButtonDefault BotMenuButtonDefault1966318984 => BotMenuButtonDefault1966318984.TlSerialize(),
            Tel.BotMenuButtonNs.BotMenuButtonCommands BotMenuButtonCommands1113113093 => BotMenuButtonCommands1113113093.TlSerialize(),
            Tel.BotMenuButtonNs.BotMenuButton BotMenuButton944407322 => BotMenuButton944407322.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountSavedRingtonesNotModified, AccountSavedRingtones,
    public abstract class AccountSavedRingtonesBase : ITlSerializable, ITlDeserializable<AccountSavedRingtonesBase> {
        public static AccountSavedRingtonesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountSavedRingtonesNs.AccountSavedRingtonesNotModified.Identifier))
                return Tel.AccountSavedRingtonesNs.AccountSavedRingtonesNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AccountSavedRingtonesNs.AccountSavedRingtones.Identifier))
                return Tel.AccountSavedRingtonesNs.AccountSavedRingtones.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountSavedRingtonesNs.AccountSavedRingtonesNotModified AccountSavedRingtonesNotModified67704655 => AccountSavedRingtonesNotModified67704655.TlSerialize(),
            Tel.AccountSavedRingtonesNs.AccountSavedRingtones AccountSavedRingtones1041683259 => AccountSavedRingtones1041683259.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: NotificationSoundDefault, NotificationSoundNone, NotificationSoundLocal, NotificationSoundRingtone,
    public abstract class NotificationSoundBase : ITlSerializable, ITlDeserializable<NotificationSoundBase> {
        public static NotificationSoundBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.NotificationSoundNs.NotificationSoundDefault.Identifier))
                return Tel.NotificationSoundNs.NotificationSoundDefault.TlDeserialize(des);
            if (id.SequenceEqual(Tel.NotificationSoundNs.NotificationSoundNone.Identifier))
                return Tel.NotificationSoundNs.NotificationSoundNone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.NotificationSoundNs.NotificationSoundLocal.Identifier))
                return Tel.NotificationSoundNs.NotificationSoundLocal.TlDeserialize(des);
            if (id.SequenceEqual(Tel.NotificationSoundNs.NotificationSoundRingtone.Identifier))
                return Tel.NotificationSoundNs.NotificationSoundRingtone.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.NotificationSoundNs.NotificationSoundDefault NotificationSoundDefault1746354498 => NotificationSoundDefault1746354498.TlSerialize(),
            Tel.NotificationSoundNs.NotificationSoundNone NotificationSoundNone1863070943 => NotificationSoundNone1863070943.TlSerialize(),
            Tel.NotificationSoundNs.NotificationSoundLocal NotificationSoundLocal2096391452 => NotificationSoundLocal2096391452.TlSerialize(),
            Tel.NotificationSoundNs.NotificationSoundRingtone NotificationSoundRingtone9666487 => NotificationSoundRingtone9666487.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountSavedRingtone, AccountSavedRingtoneConverted,
    public abstract class AccountSavedRingtoneBase : ITlSerializable, ITlDeserializable<AccountSavedRingtoneBase> {
        public static AccountSavedRingtoneBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountSavedRingtoneNs.AccountSavedRingtone.Identifier))
                return Tel.AccountSavedRingtoneNs.AccountSavedRingtone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AccountSavedRingtoneNs.AccountSavedRingtoneConverted.Identifier))
                return Tel.AccountSavedRingtoneNs.AccountSavedRingtoneConverted.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountSavedRingtoneNs.AccountSavedRingtone AccountSavedRingtone1222230163 => AccountSavedRingtone1222230163.TlSerialize(),
            Tel.AccountSavedRingtoneNs.AccountSavedRingtoneConverted AccountSavedRingtoneConverted523271863 => AccountSavedRingtoneConverted523271863.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AttachMenuPeerTypeSameBotPM, AttachMenuPeerTypeBotPM, AttachMenuPeerTypePM, AttachMenuPeerTypeChat, AttachMenuPeerTypeBroadcast,
    public abstract class AttachMenuPeerTypeBase : ITlSerializable, ITlDeserializable<AttachMenuPeerTypeBase> {
        public static AttachMenuPeerTypeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeSameBotPM.Identifier))
                return Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeSameBotPM.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeBotPM.Identifier))
                return Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeBotPM.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypePM.Identifier))
                return Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypePM.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeChat.Identifier))
                return Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeBroadcast.Identifier))
                return Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeBroadcast.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeSameBotPM AttachMenuPeerTypeSameBotPM2104224014 => AttachMenuPeerTypeSameBotPM2104224014.TlSerialize(),
            Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeBotPM AttachMenuPeerTypeBotPM1020528102 => AttachMenuPeerTypeBotPM1020528102.TlSerialize(),
            Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypePM AttachMenuPeerTypePM247016673 => AttachMenuPeerTypePM247016673.TlSerialize(),
            Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeChat AttachMenuPeerTypeChat84480319 => AttachMenuPeerTypeChat84480319.TlSerialize(),
            Tel.AttachMenuPeerTypeNs.AttachMenuPeerTypeBroadcast AttachMenuPeerTypeBroadcast2080104188 => AttachMenuPeerTypeBroadcast2080104188.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputInvoiceMessage, InputInvoiceSlug, InputInvoicePremiumGiftCode, InputInvoiceStars,
    public abstract class InputInvoiceBase : ITlSerializable, ITlDeserializable<InputInvoiceBase> {
        public static InputInvoiceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputInvoiceNs.InputInvoiceMessage.Identifier))
                return Tel.InputInvoiceNs.InputInvoiceMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputInvoiceNs.InputInvoiceSlug.Identifier))
                return Tel.InputInvoiceNs.InputInvoiceSlug.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputInvoiceNs.InputInvoicePremiumGiftCode.Identifier))
                return Tel.InputInvoiceNs.InputInvoicePremiumGiftCode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputInvoiceNs.InputInvoiceStars.Identifier))
                return Tel.InputInvoiceNs.InputInvoiceStars.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputInvoiceNs.InputInvoiceMessage InputInvoiceMessage977967015 => InputInvoiceMessage977967015.TlSerialize(),
            Tel.InputInvoiceNs.InputInvoiceSlug InputInvoiceSlug1020867857 => InputInvoiceSlug1020867857.TlSerialize(),
            Tel.InputInvoiceNs.InputInvoicePremiumGiftCode InputInvoicePremiumGiftCode1734841331 => InputInvoicePremiumGiftCode1734841331.TlSerialize(),
            Tel.InputInvoiceNs.InputInvoiceStars InputInvoiceStars497236696 => InputInvoiceStars497236696.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsExportedInvoice,
    public abstract class PaymentsExportedInvoiceBase : ITlSerializable, ITlDeserializable<PaymentsExportedInvoiceBase> {
        public static PaymentsExportedInvoiceBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsExportedInvoiceNs.PaymentsExportedInvoice.Identifier))
                return Tel.PaymentsExportedInvoiceNs.PaymentsExportedInvoice.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsExportedInvoiceNs.PaymentsExportedInvoice PaymentsExportedInvoice1362048039 => PaymentsExportedInvoice1362048039.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesTranscribedAudio,
    public abstract class MessagesTranscribedAudioBase : ITlSerializable, ITlDeserializable<MessagesTranscribedAudioBase> {
        public static MessagesTranscribedAudioBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesTranscribedAudioNs.MessagesTranscribedAudio.Identifier))
                return Tel.MessagesTranscribedAudioNs.MessagesTranscribedAudio.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesTranscribedAudioNs.MessagesTranscribedAudio MessagesTranscribedAudio809903785 => MessagesTranscribedAudio809903785.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpPremiumPromo,
    public abstract class HelpPremiumPromoBase : ITlSerializable, ITlDeserializable<HelpPremiumPromoBase> {
        public static HelpPremiumPromoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpPremiumPromoNs.HelpPremiumPromo.Identifier))
                return Tel.HelpPremiumPromoNs.HelpPremiumPromo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpPremiumPromoNs.HelpPremiumPromo HelpPremiumPromo1395946908 => HelpPremiumPromo1395946908.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputStorePaymentPremiumSubscription, InputStorePaymentGiftPremium, InputStorePaymentPremiumGiftCode, InputStorePaymentPremiumGiveaway, InputStorePaymentStars,
    public abstract class InputStorePaymentPurposeBase : ITlSerializable, ITlDeserializable<InputStorePaymentPurposeBase> {
        public static InputStorePaymentPurposeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumSubscription.Identifier))
                return Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumSubscription.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStorePaymentPurposeNs.InputStorePaymentGiftPremium.Identifier))
                return Tel.InputStorePaymentPurposeNs.InputStorePaymentGiftPremium.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumGiftCode.Identifier))
                return Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumGiftCode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumGiveaway.Identifier))
                return Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumGiveaway.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputStorePaymentPurposeNs.InputStorePaymentStars.Identifier))
                return Tel.InputStorePaymentPurposeNs.InputStorePaymentStars.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumSubscription InputStorePaymentPremiumSubscription1502273946 => InputStorePaymentPremiumSubscription1502273946.TlSerialize(),
            Tel.InputStorePaymentPurposeNs.InputStorePaymentGiftPremium InputStorePaymentGiftPremium1634697192 => InputStorePaymentGiftPremium1634697192.TlSerialize(),
            Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumGiftCode InputStorePaymentPremiumGiftCode1551868097 => InputStorePaymentPremiumGiftCode1551868097.TlSerialize(),
            Tel.InputStorePaymentPurposeNs.InputStorePaymentPremiumGiveaway InputStorePaymentPremiumGiveaway369444042 => InputStorePaymentPremiumGiveaway369444042.TlSerialize(),
            Tel.InputStorePaymentPurposeNs.InputStorePaymentStars InputStorePaymentStars1326377183 => InputStorePaymentStars1326377183.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PremiumGiftOption,
    public abstract class PremiumGiftOptionBase : ITlSerializable, ITlDeserializable<PremiumGiftOptionBase> {
        public static PremiumGiftOptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PremiumGiftOptionNs.PremiumGiftOption.Identifier))
                return Tel.PremiumGiftOptionNs.PremiumGiftOption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PremiumGiftOptionNs.PremiumGiftOption PremiumGiftOption1958953753 => PremiumGiftOption1958953753.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentFormMethod,
    public abstract class PaymentFormMethodBase : ITlSerializable, ITlDeserializable<PaymentFormMethodBase> {
        public static PaymentFormMethodBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentFormMethodNs.PaymentFormMethod.Identifier))
                return Tel.PaymentFormMethodNs.PaymentFormMethod.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentFormMethodNs.PaymentFormMethod PaymentFormMethod1996951013 => PaymentFormMethod1996951013.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmojiStatusEmpty, EmojiStatus, EmojiStatusUntil,
    public abstract class EmojiStatusBase : ITlSerializable, ITlDeserializable<EmojiStatusBase> {
        public static EmojiStatusBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmojiStatusNs.EmojiStatusEmpty.Identifier))
                return Tel.EmojiStatusNs.EmojiStatusEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmojiStatusNs.EmojiStatus.Identifier))
                return Tel.EmojiStatusNs.EmojiStatus.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmojiStatusNs.EmojiStatusUntil.Identifier))
                return Tel.EmojiStatusNs.EmojiStatusUntil.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmojiStatusNs.EmojiStatusEmpty EmojiStatusEmpty769727150 => EmojiStatusEmpty769727150.TlSerialize(),
            Tel.EmojiStatusNs.EmojiStatus EmojiStatus1835310691 => EmojiStatus1835310691.TlSerialize(),
            Tel.EmojiStatusNs.EmojiStatusUntil EmojiStatusUntil97474361 => EmojiStatusUntil97474361.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountEmojiStatusesNotModified, AccountEmojiStatuses,
    public abstract class AccountEmojiStatusesBase : ITlSerializable, ITlDeserializable<AccountEmojiStatusesBase> {
        public static AccountEmojiStatusesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountEmojiStatusesNs.AccountEmojiStatusesNotModified.Identifier))
                return Tel.AccountEmojiStatusesNs.AccountEmojiStatusesNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AccountEmojiStatusesNs.AccountEmojiStatuses.Identifier))
                return Tel.AccountEmojiStatusesNs.AccountEmojiStatuses.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountEmojiStatusesNs.AccountEmojiStatusesNotModified AccountEmojiStatusesNotModified796072379 => AccountEmojiStatusesNotModified796072379.TlSerialize(),
            Tel.AccountEmojiStatusesNs.AccountEmojiStatuses AccountEmojiStatuses1866176559 => AccountEmojiStatuses1866176559.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ReactionEmpty, ReactionEmoji, ReactionCustomEmoji,
    public abstract class ReactionBase : ITlSerializable, ITlDeserializable<ReactionBase> {
        public static ReactionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ReactionNs.ReactionEmpty.Identifier))
                return Tel.ReactionNs.ReactionEmpty.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReactionNs.ReactionEmoji.Identifier))
                return Tel.ReactionNs.ReactionEmoji.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReactionNs.ReactionCustomEmoji.Identifier))
                return Tel.ReactionNs.ReactionCustomEmoji.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ReactionNs.ReactionEmpty ReactionEmpty2046153753 => ReactionEmpty2046153753.TlSerialize(),
            Tel.ReactionNs.ReactionEmoji ReactionEmoji455247544 => ReactionEmoji455247544.TlSerialize(),
            Tel.ReactionNs.ReactionCustomEmoji ReactionCustomEmoji1992950669 => ReactionCustomEmoji1992950669.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatReactionsNone, ChatReactionsAll, ChatReactionsSome,
    public abstract class ChatReactionsBase : ITlSerializable, ITlDeserializable<ChatReactionsBase> {
        public static ChatReactionsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatReactionsNs.ChatReactionsNone.Identifier))
                return Tel.ChatReactionsNs.ChatReactionsNone.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatReactionsNs.ChatReactionsAll.Identifier))
                return Tel.ChatReactionsNs.ChatReactionsAll.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatReactionsNs.ChatReactionsSome.Identifier))
                return Tel.ChatReactionsNs.ChatReactionsSome.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatReactionsNs.ChatReactionsNone ChatReactionsNone352570692 => ChatReactionsNone352570692.TlSerialize(),
            Tel.ChatReactionsNs.ChatReactionsAll ChatReactionsAll1385335754 => ChatReactionsAll1385335754.TlSerialize(),
            Tel.ChatReactionsNs.ChatReactionsSome ChatReactionsSome1713193015 => ChatReactionsSome1713193015.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesReactionsNotModified, MessagesReactions,
    public abstract class MessagesReactionsBase : ITlSerializable, ITlDeserializable<MessagesReactionsBase> {
        public static MessagesReactionsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesReactionsNs.MessagesReactionsNotModified.Identifier))
                return Tel.MessagesReactionsNs.MessagesReactionsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesReactionsNs.MessagesReactions.Identifier))
                return Tel.MessagesReactionsNs.MessagesReactions.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesReactionsNs.MessagesReactionsNotModified MessagesReactionsNotModified1334846497 => MessagesReactionsNotModified1334846497.TlSerialize(),
            Tel.MessagesReactionsNs.MessagesReactions MessagesReactions352454890 => MessagesReactions352454890.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmailVerifyPurposeLoginSetup, EmailVerifyPurposeLoginChange, EmailVerifyPurposePassport,
    public abstract class EmailVerifyPurposeBase : ITlSerializable, ITlDeserializable<EmailVerifyPurposeBase> {
        public static EmailVerifyPurposeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmailVerifyPurposeNs.EmailVerifyPurposeLoginSetup.Identifier))
                return Tel.EmailVerifyPurposeNs.EmailVerifyPurposeLoginSetup.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmailVerifyPurposeNs.EmailVerifyPurposeLoginChange.Identifier))
                return Tel.EmailVerifyPurposeNs.EmailVerifyPurposeLoginChange.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmailVerifyPurposeNs.EmailVerifyPurposePassport.Identifier))
                return Tel.EmailVerifyPurposeNs.EmailVerifyPurposePassport.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmailVerifyPurposeNs.EmailVerifyPurposeLoginSetup EmailVerifyPurposeLoginSetup1128644211 => EmailVerifyPurposeLoginSetup1128644211.TlSerialize(),
            Tel.EmailVerifyPurposeNs.EmailVerifyPurposeLoginChange EmailVerifyPurposeLoginChange1383932651 => EmailVerifyPurposeLoginChange1383932651.TlSerialize(),
            Tel.EmailVerifyPurposeNs.EmailVerifyPurposePassport EmailVerifyPurposePassport1141565819 => EmailVerifyPurposePassport1141565819.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmailVerificationCode, EmailVerificationGoogle, EmailVerificationApple,
    public abstract class EmailVerificationBase : ITlSerializable, ITlDeserializable<EmailVerificationBase> {
        public static EmailVerificationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmailVerificationNs.EmailVerificationCode.Identifier))
                return Tel.EmailVerificationNs.EmailVerificationCode.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmailVerificationNs.EmailVerificationGoogle.Identifier))
                return Tel.EmailVerificationNs.EmailVerificationGoogle.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmailVerificationNs.EmailVerificationApple.Identifier))
                return Tel.EmailVerificationNs.EmailVerificationApple.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmailVerificationNs.EmailVerificationCode EmailVerificationCode1842457175 => EmailVerificationCode1842457175.TlSerialize(),
            Tel.EmailVerificationNs.EmailVerificationGoogle EmailVerificationGoogle611279166 => EmailVerificationGoogle611279166.TlSerialize(),
            Tel.EmailVerificationNs.EmailVerificationApple EmailVerificationApple1764723459 => EmailVerificationApple1764723459.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountEmailVerified, AccountEmailVerifiedLogin,
    public abstract class AccountEmailVerifiedBase : ITlSerializable, ITlDeserializable<AccountEmailVerifiedBase> {
        public string Email {get;set;} = default!;
        public static AccountEmailVerifiedBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountEmailVerifiedNs.AccountEmailVerified.Identifier))
                return Tel.AccountEmailVerifiedNs.AccountEmailVerified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.AccountEmailVerifiedNs.AccountEmailVerifiedLogin.Identifier))
                return Tel.AccountEmailVerifiedNs.AccountEmailVerifiedLogin.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountEmailVerifiedNs.AccountEmailVerified AccountEmailVerified731303195 => AccountEmailVerified731303195.TlSerialize(),
            Tel.AccountEmailVerifiedNs.AccountEmailVerifiedLogin AccountEmailVerifiedLogin507835039 => AccountEmailVerifiedLogin507835039.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PremiumSubscriptionOption,
    public abstract class PremiumSubscriptionOptionBase : ITlSerializable, ITlDeserializable<PremiumSubscriptionOptionBase> {
        public static PremiumSubscriptionOptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PremiumSubscriptionOptionNs.PremiumSubscriptionOption.Identifier))
                return Tel.PremiumSubscriptionOptionNs.PremiumSubscriptionOption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PremiumSubscriptionOptionNs.PremiumSubscriptionOption PremiumSubscriptionOption1596792306 => PremiumSubscriptionOption1596792306.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SendAsPeer,
    public abstract class SendAsPeerBase : ITlSerializable, ITlDeserializable<SendAsPeerBase> {
        public static SendAsPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SendAsPeerNs.SendAsPeer.Identifier))
                return Tel.SendAsPeerNs.SendAsPeer.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SendAsPeerNs.SendAsPeer SendAsPeer1206095820 => SendAsPeer1206095820.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessageExtendedMediaPreview, MessageExtendedMedia,
    public abstract class MessageExtendedMediaBase : ITlSerializable, ITlDeserializable<MessageExtendedMediaBase> {
        public static MessageExtendedMediaBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessageExtendedMediaNs.MessageExtendedMediaPreview.Identifier))
                return Tel.MessageExtendedMediaNs.MessageExtendedMediaPreview.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessageExtendedMediaNs.MessageExtendedMedia.Identifier))
                return Tel.MessageExtendedMediaNs.MessageExtendedMedia.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessageExtendedMediaNs.MessageExtendedMediaPreview MessageExtendedMediaPreview1386050360 => MessageExtendedMediaPreview1386050360.TlSerialize(),
            Tel.MessageExtendedMediaNs.MessageExtendedMedia MessageExtendedMedia297296796 => MessageExtendedMedia297296796.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StickerKeyword,
    public abstract class StickerKeywordBase : ITlSerializable, ITlDeserializable<StickerKeywordBase> {
        public static StickerKeywordBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StickerKeywordNs.StickerKeyword.Identifier))
                return Tel.StickerKeywordNs.StickerKeyword.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StickerKeywordNs.StickerKeyword StickerKeyword50416996 => StickerKeyword50416996.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Username,
    public abstract class UsernameBase : ITlSerializable, ITlDeserializable<UsernameBase> {
        public static UsernameBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.UsernameNs.Username.Identifier))
                return Tel.UsernameNs.Username.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.UsernameNs.Username Username1274595769 => Username1274595769.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ForumTopicDeleted, ForumTopic,
    public abstract class ForumTopicBase : ITlSerializable, ITlDeserializable<ForumTopicBase> {
        public int Id {get;set;} = default!;
        public static ForumTopicBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ForumTopicNs.ForumTopicDeleted.Identifier))
                return Tel.ForumTopicNs.ForumTopicDeleted.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ForumTopicNs.ForumTopic.Identifier))
                return Tel.ForumTopicNs.ForumTopic.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ForumTopicNs.ForumTopicDeleted ForumTopicDeleted37687451 => ForumTopicDeleted37687451.TlSerialize(),
            Tel.ForumTopicNs.ForumTopic ForumTopic1903173033 => ForumTopic1903173033.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesForumTopics,
    public abstract class MessagesForumTopicsBase : ITlSerializable, ITlDeserializable<MessagesForumTopicsBase> {
        public static MessagesForumTopicsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesForumTopicsNs.MessagesForumTopics.Identifier))
                return Tel.MessagesForumTopicsNs.MessagesForumTopics.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesForumTopicsNs.MessagesForumTopics MessagesForumTopics913709011 => MessagesForumTopics913709011.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: DefaultHistoryTTL,
    public abstract class DefaultHistoryTTLBase : ITlSerializable, ITlDeserializable<DefaultHistoryTTLBase> {
        public static DefaultHistoryTTLBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.DefaultHistoryTTLNs.DefaultHistoryTTL.Identifier))
                return Tel.DefaultHistoryTTLNs.DefaultHistoryTTL.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.DefaultHistoryTTLNs.DefaultHistoryTTL DefaultHistoryTTL1135897376 => DefaultHistoryTTL1135897376.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ExportedContactToken,
    public abstract class ExportedContactTokenBase : ITlSerializable, ITlDeserializable<ExportedContactTokenBase> {
        public static ExportedContactTokenBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ExportedContactTokenNs.ExportedContactToken.Identifier))
                return Tel.ExportedContactTokenNs.ExportedContactToken.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ExportedContactTokenNs.ExportedContactToken ExportedContactToken1103040667 => ExportedContactToken1103040667.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: RequestPeerTypeUser, RequestPeerTypeChat, RequestPeerTypeBroadcast,
    public abstract class RequestPeerTypeBase : ITlSerializable, ITlDeserializable<RequestPeerTypeBase> {
        public int Flags {get;set;} = default!;
        public static RequestPeerTypeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.RequestPeerTypeNs.RequestPeerTypeUser.Identifier))
                return Tel.RequestPeerTypeNs.RequestPeerTypeUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RequestPeerTypeNs.RequestPeerTypeChat.Identifier))
                return Tel.RequestPeerTypeNs.RequestPeerTypeChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RequestPeerTypeNs.RequestPeerTypeBroadcast.Identifier))
                return Tel.RequestPeerTypeNs.RequestPeerTypeBroadcast.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.RequestPeerTypeNs.RequestPeerTypeUser RequestPeerTypeUser1597737472 => RequestPeerTypeUser1597737472.TlSerialize(),
            Tel.RequestPeerTypeNs.RequestPeerTypeChat RequestPeerTypeChat906990053 => RequestPeerTypeChat906990053.TlSerialize(),
            Tel.RequestPeerTypeNs.RequestPeerTypeBroadcast RequestPeerTypeBroadcast865857388 => RequestPeerTypeBroadcast865857388.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmojiListNotModified, EmojiList,
    public abstract class EmojiListBase : ITlSerializable, ITlDeserializable<EmojiListBase> {
        public static EmojiListBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmojiListNs.EmojiListNotModified.Identifier))
                return Tel.EmojiListNs.EmojiListNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmojiListNs.EmojiList.Identifier))
                return Tel.EmojiListNs.EmojiList.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmojiListNs.EmojiListNotModified EmojiListNotModified1209970170 => EmojiListNotModified1209970170.TlSerialize(),
            Tel.EmojiListNs.EmojiList EmojiList2048790993 => EmojiList2048790993.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: EmojiGroup, EmojiGroupGreeting, EmojiGroupPremium,
    public abstract class EmojiGroupBase : ITlSerializable, ITlDeserializable<EmojiGroupBase> {
        public string Title {get;set;} = default!;
        public long IconEmojiId {get;set;} = default!;
        public static EmojiGroupBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.EmojiGroupNs.EmojiGroup.Identifier))
                return Tel.EmojiGroupNs.EmojiGroup.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmojiGroupNs.EmojiGroupGreeting.Identifier))
                return Tel.EmojiGroupNs.EmojiGroupGreeting.TlDeserialize(des);
            if (id.SequenceEqual(Tel.EmojiGroupNs.EmojiGroupPremium.Identifier))
                return Tel.EmojiGroupNs.EmojiGroupPremium.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.EmojiGroupNs.EmojiGroup EmojiGroup2056961449 => EmojiGroup2056961449.TlSerialize(),
            Tel.EmojiGroupNs.EmojiGroupGreeting EmojiGroupGreeting2133693241 => EmojiGroupGreeting2133693241.TlSerialize(),
            Tel.EmojiGroupNs.EmojiGroupPremium EmojiGroupPremium154914612 => EmojiGroupPremium154914612.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesEmojiGroupsNotModified, MessagesEmojiGroups,
    public abstract class MessagesEmojiGroupsBase : ITlSerializable, ITlDeserializable<MessagesEmojiGroupsBase> {
        public static MessagesEmojiGroupsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesEmojiGroupsNs.MessagesEmojiGroupsNotModified.Identifier))
                return Tel.MessagesEmojiGroupsNs.MessagesEmojiGroupsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesEmojiGroupsNs.MessagesEmojiGroups.Identifier))
                return Tel.MessagesEmojiGroupsNs.MessagesEmojiGroups.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesEmojiGroupsNs.MessagesEmojiGroupsNotModified MessagesEmojiGroupsNotModified1874111879 => MessagesEmojiGroupsNotModified1874111879.TlSerialize(),
            Tel.MessagesEmojiGroupsNs.MessagesEmojiGroups MessagesEmojiGroups2011186869 => MessagesEmojiGroups2011186869.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: TextWithEntities,
    public abstract class TextWithEntitiesBase : ITlSerializable, ITlDeserializable<TextWithEntitiesBase> {
        public static TextWithEntitiesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.TextWithEntitiesNs.TextWithEntities.Identifier))
                return Tel.TextWithEntitiesNs.TextWithEntities.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.TextWithEntitiesNs.TextWithEntities TextWithEntities1964978502 => TextWithEntities1964978502.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesTranslateResult,
    public abstract class MessagesTranslatedTextBase : ITlSerializable, ITlDeserializable<MessagesTranslatedTextBase> {
        public static MessagesTranslatedTextBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesTranslatedTextNs.MessagesTranslateResult.Identifier))
                return Tel.MessagesTranslatedTextNs.MessagesTranslateResult.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesTranslatedTextNs.MessagesTranslateResult MessagesTranslateResult870003448 => MessagesTranslateResult870003448.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AutoSaveSettings,
    public abstract class AutoSaveSettingsBase : ITlSerializable, ITlDeserializable<AutoSaveSettingsBase> {
        public static AutoSaveSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AutoSaveSettingsNs.AutoSaveSettings.Identifier))
                return Tel.AutoSaveSettingsNs.AutoSaveSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AutoSaveSettingsNs.AutoSaveSettings AutoSaveSettings934791986 => AutoSaveSettings934791986.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AutoSaveException,
    public abstract class AutoSaveExceptionBase : ITlSerializable, ITlDeserializable<AutoSaveExceptionBase> {
        public static AutoSaveExceptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AutoSaveExceptionNs.AutoSaveException.Identifier))
                return Tel.AutoSaveExceptionNs.AutoSaveException.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AutoSaveExceptionNs.AutoSaveException AutoSaveException2124403385 => AutoSaveException2124403385.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountAutoSaveSettings,
    public abstract class AccountAutoSaveSettingsBase : ITlSerializable, ITlDeserializable<AccountAutoSaveSettingsBase> {
        public static AccountAutoSaveSettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountAutoSaveSettingsNs.AccountAutoSaveSettings.Identifier))
                return Tel.AccountAutoSaveSettingsNs.AccountAutoSaveSettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountAutoSaveSettingsNs.AccountAutoSaveSettings AccountAutoSaveSettings1279133341 => AccountAutoSaveSettings1279133341.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpAppConfigNotModified, HelpAppConfig,
    public abstract class HelpAppConfigBase : ITlSerializable, ITlDeserializable<HelpAppConfigBase> {
        public static HelpAppConfigBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpAppConfigNs.HelpAppConfigNotModified.Identifier))
                return Tel.HelpAppConfigNs.HelpAppConfigNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpAppConfigNs.HelpAppConfig.Identifier))
                return Tel.HelpAppConfigNs.HelpAppConfig.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpAppConfigNs.HelpAppConfigNotModified HelpAppConfigNotModified2094949405 => HelpAppConfigNotModified2094949405.TlSerialize(),
            Tel.HelpAppConfigNs.HelpAppConfig HelpAppConfig585598930 => HelpAppConfig585598930.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBotAppID, InputBotAppShortName,
    public abstract class InputBotAppBase : ITlSerializable, ITlDeserializable<InputBotAppBase> {
        public static InputBotAppBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBotAppNs.InputBotAppID.Identifier))
                return Tel.InputBotAppNs.InputBotAppID.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputBotAppNs.InputBotAppShortName.Identifier))
                return Tel.InputBotAppNs.InputBotAppShortName.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBotAppNs.InputBotAppID InputBotAppID1457472134 => InputBotAppID1457472134.TlSerialize(),
            Tel.InputBotAppNs.InputBotAppShortName InputBotAppShortName1869872121 => InputBotAppShortName1869872121.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotAppNotModified, BotApp,
    public abstract class BotAppBase : ITlSerializable, ITlDeserializable<BotAppBase> {
        public static BotAppBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotAppNs.BotAppNotModified.Identifier))
                return Tel.BotAppNs.BotAppNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BotAppNs.BotApp.Identifier))
                return Tel.BotAppNs.BotApp.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotAppNs.BotAppNotModified BotAppNotModified1571189943 => BotAppNotModified1571189943.TlSerialize(),
            Tel.BotAppNs.BotApp BotApp1778593322 => BotApp1778593322.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesBotApp,
    public abstract class MessagesBotAppBase : ITlSerializable, ITlDeserializable<MessagesBotAppBase> {
        public static MessagesBotAppBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesBotAppNs.MessagesBotApp.Identifier))
                return Tel.MessagesBotAppNs.MessagesBotApp.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesBotAppNs.MessagesBotApp MessagesBotApp347034123 => MessagesBotApp347034123.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InlineBotWebView,
    public abstract class InlineBotWebViewBase : ITlSerializable, ITlDeserializable<InlineBotWebViewBase> {
        public static InlineBotWebViewBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InlineBotWebViewNs.InlineBotWebView.Identifier))
                return Tel.InlineBotWebViewNs.InlineBotWebView.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InlineBotWebViewNs.InlineBotWebView InlineBotWebView1250781739 => InlineBotWebView1250781739.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ReadParticipantDate,
    public abstract class ReadParticipantDateBase : ITlSerializable, ITlDeserializable<ReadParticipantDateBase> {
        public static ReadParticipantDateBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ReadParticipantDateNs.ReadParticipantDate.Identifier))
                return Tel.ReadParticipantDateNs.ReadParticipantDate.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ReadParticipantDateNs.ReadParticipantDate ReadParticipantDate1246753138 => ReadParticipantDate1246753138.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputChatlistDialogFilter,
    public abstract class InputChatlistBase : ITlSerializable, ITlDeserializable<InputChatlistBase> {
        public static InputChatlistBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputChatlistNs.InputChatlistDialogFilter.Identifier))
                return Tel.InputChatlistNs.InputChatlistDialogFilter.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputChatlistNs.InputChatlistDialogFilter InputChatlistDialogFilter203367885 => InputChatlistDialogFilter203367885.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ExportedChatlistInvite,
    public abstract class ExportedChatlistInviteBase : ITlSerializable, ITlDeserializable<ExportedChatlistInviteBase> {
        public static ExportedChatlistInviteBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ExportedChatlistInviteNs.ExportedChatlistInvite.Identifier))
                return Tel.ExportedChatlistInviteNs.ExportedChatlistInvite.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ExportedChatlistInviteNs.ExportedChatlistInvite ExportedChatlistInvite206668204 => ExportedChatlistInvite206668204.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatlistsExportedChatlistInvite,
    public abstract class ChatlistsExportedChatlistInviteBase : ITlSerializable, ITlDeserializable<ChatlistsExportedChatlistInviteBase> {
        public static ChatlistsExportedChatlistInviteBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatlistsExportedChatlistInviteNs.ChatlistsExportedChatlistInvite.Identifier))
                return Tel.ChatlistsExportedChatlistInviteNs.ChatlistsExportedChatlistInvite.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatlistsExportedChatlistInviteNs.ChatlistsExportedChatlistInvite ChatlistsExportedChatlistInvite283567014 => ChatlistsExportedChatlistInvite283567014.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatlistsExportedInvites,
    public abstract class ChatlistsExportedInvitesBase : ITlSerializable, ITlDeserializable<ChatlistsExportedInvitesBase> {
        public static ChatlistsExportedInvitesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatlistsExportedInvitesNs.ChatlistsExportedInvites.Identifier))
                return Tel.ChatlistsExportedInvitesNs.ChatlistsExportedInvites.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatlistsExportedInvitesNs.ChatlistsExportedInvites ChatlistsExportedInvites279670215 => ChatlistsExportedInvites279670215.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatlistsChatlistInviteAlready, ChatlistsChatlistInvite,
    public abstract class ChatlistsChatlistInviteBase : ITlSerializable, ITlDeserializable<ChatlistsChatlistInviteBase> {
        public List<ChatBase> Chats {get;set;} = default!;
        public List<UserBase> Users {get;set;} = default!;
        public static ChatlistsChatlistInviteBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatlistsChatlistInviteNs.ChatlistsChatlistInviteAlready.Identifier))
                return Tel.ChatlistsChatlistInviteNs.ChatlistsChatlistInviteAlready.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChatlistsChatlistInviteNs.ChatlistsChatlistInvite.Identifier))
                return Tel.ChatlistsChatlistInviteNs.ChatlistsChatlistInvite.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatlistsChatlistInviteNs.ChatlistsChatlistInviteAlready ChatlistsChatlistInviteAlready91752871 => ChatlistsChatlistInviteAlready91752871.TlSerialize(),
            Tel.ChatlistsChatlistInviteNs.ChatlistsChatlistInvite ChatlistsChatlistInvite500007837 => ChatlistsChatlistInvite500007837.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChatlistsChatlistUpdates,
    public abstract class ChatlistsChatlistUpdatesBase : ITlSerializable, ITlDeserializable<ChatlistsChatlistUpdatesBase> {
        public static ChatlistsChatlistUpdatesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChatlistsChatlistUpdatesNs.ChatlistsChatlistUpdates.Identifier))
                return Tel.ChatlistsChatlistUpdatesNs.ChatlistsChatlistUpdates.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChatlistsChatlistUpdatesNs.ChatlistsChatlistUpdates ChatlistsChatlistUpdates1816295539 => ChatlistsChatlistUpdates1816295539.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotsBotInfo,
    public abstract class BotsBotInfoBase : ITlSerializable, ITlDeserializable<BotsBotInfoBase> {
        public static BotsBotInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotsBotInfoNs.BotsBotInfo.Identifier))
                return Tel.BotsBotInfoNs.BotsBotInfo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotsBotInfoNs.BotsBotInfo BotsBotInfo391678544 => BotsBotInfo391678544.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagePeerVote, MessagePeerVoteInputOption, MessagePeerVoteMultiple,
    public abstract class MessagePeerVoteBase : ITlSerializable, ITlDeserializable<MessagePeerVoteBase> {
        public PeerBase Peer {get;set;} = default!;
        public int Date {get;set;} = default!;
        public static MessagePeerVoteBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagePeerVoteNs.MessagePeerVote.Identifier))
                return Tel.MessagePeerVoteNs.MessagePeerVote.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagePeerVoteNs.MessagePeerVoteInputOption.Identifier))
                return Tel.MessagePeerVoteNs.MessagePeerVoteInputOption.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagePeerVoteNs.MessagePeerVoteMultiple.Identifier))
                return Tel.MessagePeerVoteNs.MessagePeerVoteMultiple.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagePeerVoteNs.MessagePeerVote MessagePeerVote1228133028 => MessagePeerVote1228133028.TlSerialize(),
            Tel.MessagePeerVoteNs.MessagePeerVoteInputOption MessagePeerVoteInputOption1959634180 => MessagePeerVoteInputOption1959634180.TlSerialize(),
            Tel.MessagePeerVoteNs.MessagePeerVoteMultiple MessagePeerVoteMultiple1177089766 => MessagePeerVoteMultiple1177089766.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoryViews,
    public abstract class StoryViewsBase : ITlSerializable, ITlDeserializable<StoryViewsBase> {
        public static StoryViewsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoryViewsNs.StoryViews.Identifier))
                return Tel.StoryViewsNs.StoryViews.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoryViewsNs.StoryViews StoryViews1923523370 => StoryViews1923523370.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoryItemDeleted, StoryItemSkipped, StoryItem,
    public abstract class StoryItemBase : ITlSerializable, ITlDeserializable<StoryItemBase> {
        public int Id {get;set;} = default!;
        public static StoryItemBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoryItemNs.StoryItemDeleted.Identifier))
                return Tel.StoryItemNs.StoryItemDeleted.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StoryItemNs.StoryItemSkipped.Identifier))
                return Tel.StoryItemNs.StoryItemSkipped.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StoryItemNs.StoryItem.Identifier))
                return Tel.StoryItemNs.StoryItem.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoryItemNs.StoryItemDeleted StoryItemDeleted1374088783 => StoryItemDeleted1374088783.TlSerialize(),
            Tel.StoryItemNs.StoryItemSkipped StoryItemSkipped5388013 => StoryItemSkipped5388013.TlSerialize(),
            Tel.StoryItemNs.StoryItem StoryItem2041735716 => StoryItem2041735716.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoriesAllStoriesNotModified, StoriesAllStories,
    public abstract class StoriesAllStoriesBase : ITlSerializable, ITlDeserializable<StoriesAllStoriesBase> {
        public int Flags {get;set;} = default!;
        public string State {get;set;} = default!;
        public StoriesStealthModeBase StealthMode {get;set;} = default!;
        public static StoriesAllStoriesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoriesAllStoriesNs.StoriesAllStoriesNotModified.Identifier))
                return Tel.StoriesAllStoriesNs.StoriesAllStoriesNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StoriesAllStoriesNs.StoriesAllStories.Identifier))
                return Tel.StoriesAllStoriesNs.StoriesAllStories.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoriesAllStoriesNs.StoriesAllStoriesNotModified StoriesAllStoriesNotModified291044926 => StoriesAllStoriesNotModified291044926.TlSerialize(),
            Tel.StoriesAllStoriesNs.StoriesAllStories StoriesAllStories1862033025 => StoriesAllStories1862033025.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoriesStories,
    public abstract class StoriesStoriesBase : ITlSerializable, ITlDeserializable<StoriesStoriesBase> {
        public static StoriesStoriesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoriesStoriesNs.StoriesStories.Identifier))
                return Tel.StoriesStoriesNs.StoriesStories.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoriesStoriesNs.StoriesStories StoriesStories1673780490 => StoriesStories1673780490.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoryView, StoryViewPublicForward, StoryViewPublicRepost,
    public abstract class StoryViewBase : ITlSerializable, ITlDeserializable<StoryViewBase> {
        public int Flags {get;set;} = default!;
        public bool Blocked {get;set;} = default!;
        public bool BlockedMyStoriesFrom {get;set;} = default!;
        public static StoryViewBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoryViewNs.StoryView.Identifier))
                return Tel.StoryViewNs.StoryView.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StoryViewNs.StoryViewPublicForward.Identifier))
                return Tel.StoryViewNs.StoryViewPublicForward.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StoryViewNs.StoryViewPublicRepost.Identifier))
                return Tel.StoryViewNs.StoryViewPublicRepost.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoryViewNs.StoryView StoryView1329730875 => StoryView1329730875.TlSerialize(),
            Tel.StoryViewNs.StoryViewPublicForward StoryViewPublicForward1870436597 => StoryViewPublicForward1870436597.TlSerialize(),
            Tel.StoryViewNs.StoryViewPublicRepost StoryViewPublicRepost1116418231 => StoryViewPublicRepost1116418231.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoriesStoryViewsList,
    public abstract class StoriesStoryViewsListBase : ITlSerializable, ITlDeserializable<StoriesStoryViewsListBase> {
        public static StoriesStoryViewsListBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoriesStoryViewsListNs.StoriesStoryViewsList.Identifier))
                return Tel.StoriesStoryViewsListNs.StoriesStoryViewsList.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoriesStoryViewsListNs.StoriesStoryViewsList StoriesStoryViewsList1507299269 => StoriesStoryViewsList1507299269.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoriesStoryViews,
    public abstract class StoriesStoryViewsBase : ITlSerializable, ITlDeserializable<StoriesStoryViewsBase> {
        public static StoriesStoryViewsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoriesStoryViewsNs.StoriesStoryViews.Identifier))
                return Tel.StoriesStoryViewsNs.StoriesStoryViews.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoriesStoryViewsNs.StoriesStoryViews StoriesStoryViews560009955 => StoriesStoryViews560009955.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputReplyToMessage, InputReplyToStory,
    public abstract class InputReplyToBase : ITlSerializable, ITlDeserializable<InputReplyToBase> {
        public static InputReplyToBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputReplyToNs.InputReplyToMessage.Identifier))
                return Tel.InputReplyToNs.InputReplyToMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputReplyToNs.InputReplyToStory.Identifier))
                return Tel.InputReplyToNs.InputReplyToStory.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputReplyToNs.InputReplyToMessage InputReplyToMessage583071445 => InputReplyToMessage583071445.TlSerialize(),
            Tel.InputReplyToNs.InputReplyToStory InputReplyToStory1484862010 => InputReplyToStory1484862010.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ExportedStoryLink,
    public abstract class ExportedStoryLinkBase : ITlSerializable, ITlDeserializable<ExportedStoryLinkBase> {
        public static ExportedStoryLinkBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ExportedStoryLinkNs.ExportedStoryLink.Identifier))
                return Tel.ExportedStoryLinkNs.ExportedStoryLink.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ExportedStoryLinkNs.ExportedStoryLink ExportedStoryLink1070138683 => ExportedStoryLink1070138683.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoriesStealthMode,
    public abstract class StoriesStealthModeBase : ITlSerializable, ITlDeserializable<StoriesStealthModeBase> {
        public static StoriesStealthModeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoriesStealthModeNs.StoriesStealthMode.Identifier))
                return Tel.StoriesStealthModeNs.StoriesStealthMode.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoriesStealthModeNs.StoriesStealthMode StoriesStealthMode1898850301 => StoriesStealthMode1898850301.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MediaAreaCoordinates,
    public abstract class MediaAreaCoordinatesBase : ITlSerializable, ITlDeserializable<MediaAreaCoordinatesBase> {
        public static MediaAreaCoordinatesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MediaAreaCoordinatesNs.MediaAreaCoordinates.Identifier))
                return Tel.MediaAreaCoordinatesNs.MediaAreaCoordinates.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MediaAreaCoordinatesNs.MediaAreaCoordinates MediaAreaCoordinates808853502 => MediaAreaCoordinates808853502.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MediaAreaVenue, InputMediaAreaVenue, MediaAreaGeoPoint, MediaAreaSuggestedReaction, MediaAreaChannelPost, InputMediaAreaChannelPost, MediaAreaUrl,
    public abstract class MediaAreaBase : ITlSerializable, ITlDeserializable<MediaAreaBase> {
        public MediaAreaCoordinatesBase Coordinates {get;set;} = default!;
        public static MediaAreaBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MediaAreaNs.MediaAreaVenue.Identifier))
                return Tel.MediaAreaNs.MediaAreaVenue.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MediaAreaNs.InputMediaAreaVenue.Identifier))
                return Tel.MediaAreaNs.InputMediaAreaVenue.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MediaAreaNs.MediaAreaGeoPoint.Identifier))
                return Tel.MediaAreaNs.MediaAreaGeoPoint.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MediaAreaNs.MediaAreaSuggestedReaction.Identifier))
                return Tel.MediaAreaNs.MediaAreaSuggestedReaction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MediaAreaNs.MediaAreaChannelPost.Identifier))
                return Tel.MediaAreaNs.MediaAreaChannelPost.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MediaAreaNs.InputMediaAreaChannelPost.Identifier))
                return Tel.MediaAreaNs.InputMediaAreaChannelPost.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MediaAreaNs.MediaAreaUrl.Identifier))
                return Tel.MediaAreaNs.MediaAreaUrl.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MediaAreaNs.MediaAreaVenue MediaAreaVenue1098720356 => MediaAreaVenue1098720356.TlSerialize(),
            Tel.MediaAreaNs.InputMediaAreaVenue InputMediaAreaVenue1300094593 => InputMediaAreaVenue1300094593.TlSerialize(),
            Tel.MediaAreaNs.MediaAreaGeoPoint MediaAreaGeoPoint891992787 => MediaAreaGeoPoint891992787.TlSerialize(),
            Tel.MediaAreaNs.MediaAreaSuggestedReaction MediaAreaSuggestedReaction340088945 => MediaAreaSuggestedReaction340088945.TlSerialize(),
            Tel.MediaAreaNs.MediaAreaChannelPost MediaAreaChannelPost1996756655 => MediaAreaChannelPost1996756655.TlSerialize(),
            Tel.MediaAreaNs.InputMediaAreaChannelPost InputMediaAreaChannelPost577893055 => InputMediaAreaChannelPost577893055.TlSerialize(),
            Tel.MediaAreaNs.MediaAreaUrl MediaAreaUrl926421125 => MediaAreaUrl926421125.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PeerStories,
    public abstract class PeerStoriesBase : ITlSerializable, ITlDeserializable<PeerStoriesBase> {
        public static PeerStoriesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PeerStoriesNs.PeerStories.Identifier))
                return Tel.PeerStoriesNs.PeerStories.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PeerStoriesNs.PeerStories PeerStories1707742823 => PeerStories1707742823.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoriesPeerStories,
    public abstract class StoriesPeerStoriesBase : ITlSerializable, ITlDeserializable<StoriesPeerStoriesBase> {
        public static StoriesPeerStoriesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoriesPeerStoriesNs.StoriesPeerStories.Identifier))
                return Tel.StoriesPeerStoriesNs.StoriesPeerStories.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoriesPeerStoriesNs.StoriesPeerStories StoriesPeerStories890861720 => StoriesPeerStories890861720.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesWebPage,
    public abstract class MessagesWebPageBase : ITlSerializable, ITlDeserializable<MessagesWebPageBase> {
        public static MessagesWebPageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesWebPageNs.MessagesWebPage.Identifier))
                return Tel.MessagesWebPageNs.MessagesWebPage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesWebPageNs.MessagesWebPage MessagesWebPage44166467 => MessagesWebPage44166467.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PremiumGiftCodeOption,
    public abstract class PremiumGiftCodeOptionBase : ITlSerializable, ITlDeserializable<PremiumGiftCodeOptionBase> {
        public static PremiumGiftCodeOptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PremiumGiftCodeOptionNs.PremiumGiftCodeOption.Identifier))
                return Tel.PremiumGiftCodeOptionNs.PremiumGiftCodeOption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PremiumGiftCodeOptionNs.PremiumGiftCodeOption PremiumGiftCodeOption629052971 => PremiumGiftCodeOption629052971.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsCheckedGiftCode,
    public abstract class PaymentsCheckedGiftCodeBase : ITlSerializable, ITlDeserializable<PaymentsCheckedGiftCodeBase> {
        public static PaymentsCheckedGiftCodeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsCheckedGiftCodeNs.PaymentsCheckedGiftCode.Identifier))
                return Tel.PaymentsCheckedGiftCodeNs.PaymentsCheckedGiftCode.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsCheckedGiftCodeNs.PaymentsCheckedGiftCode PaymentsCheckedGiftCode675942550 => PaymentsCheckedGiftCode675942550.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsGiveawayInfo, PaymentsGiveawayInfoResults,
    public abstract class PaymentsGiveawayInfoBase : ITlSerializable, ITlDeserializable<PaymentsGiveawayInfoBase> {
        public int Flags {get;set;} = default!;
        public int StartDate {get;set;} = default!;
        public static PaymentsGiveawayInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsGiveawayInfoNs.PaymentsGiveawayInfo.Identifier))
                return Tel.PaymentsGiveawayInfoNs.PaymentsGiveawayInfo.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PaymentsGiveawayInfoNs.PaymentsGiveawayInfoResults.Identifier))
                return Tel.PaymentsGiveawayInfoNs.PaymentsGiveawayInfoResults.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsGiveawayInfoNs.PaymentsGiveawayInfo PaymentsGiveawayInfo1130879648 => PaymentsGiveawayInfo1130879648.TlSerialize(),
            Tel.PaymentsGiveawayInfoNs.PaymentsGiveawayInfoResults PaymentsGiveawayInfoResults13456752 => PaymentsGiveawayInfoResults13456752.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PrepaidGiveaway,
    public abstract class PrepaidGiveawayBase : ITlSerializable, ITlDeserializable<PrepaidGiveawayBase> {
        public static PrepaidGiveawayBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PrepaidGiveawayNs.PrepaidGiveaway.Identifier))
                return Tel.PrepaidGiveawayNs.PrepaidGiveaway.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PrepaidGiveawayNs.PrepaidGiveaway PrepaidGiveaway1303143084 => PrepaidGiveaway1303143084.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Boost,
    public abstract class BoostBase : ITlSerializable, ITlDeserializable<BoostBase> {
        public static BoostBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BoostNs.Boost.Identifier))
                return Tel.BoostNs.Boost.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BoostNs.Boost Boost706514033 => Boost706514033.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PremiumBoostsList,
    public abstract class PremiumBoostsListBase : ITlSerializable, ITlDeserializable<PremiumBoostsListBase> {
        public static PremiumBoostsListBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PremiumBoostsListNs.PremiumBoostsList.Identifier))
                return Tel.PremiumBoostsListNs.PremiumBoostsList.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PremiumBoostsListNs.PremiumBoostsList PremiumBoostsList2030542532 => PremiumBoostsList2030542532.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MyBoost,
    public abstract class MyBoostBase : ITlSerializable, ITlDeserializable<MyBoostBase> {
        public static MyBoostBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MyBoostNs.MyBoost.Identifier))
                return Tel.MyBoostNs.MyBoost.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MyBoostNs.MyBoost MyBoost1001897636 => MyBoost1001897636.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PremiumMyBoosts,
    public abstract class PremiumMyBoostsBase : ITlSerializable, ITlDeserializable<PremiumMyBoostsBase> {
        public static PremiumMyBoostsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PremiumMyBoostsNs.PremiumMyBoosts.Identifier))
                return Tel.PremiumMyBoostsNs.PremiumMyBoosts.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PremiumMyBoostsNs.PremiumMyBoosts PremiumMyBoosts1696454430 => PremiumMyBoosts1696454430.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PremiumBoostsStatus,
    public abstract class PremiumBoostsStatusBase : ITlSerializable, ITlDeserializable<PremiumBoostsStatusBase> {
        public static PremiumBoostsStatusBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PremiumBoostsStatusNs.PremiumBoostsStatus.Identifier))
                return Tel.PremiumBoostsStatusNs.PremiumBoostsStatus.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PremiumBoostsStatusNs.PremiumBoostsStatus PremiumBoostsStatus1230586490 => PremiumBoostsStatus1230586490.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoryFwdHeader,
    public abstract class StoryFwdHeaderBase : ITlSerializable, ITlDeserializable<StoryFwdHeaderBase> {
        public static StoryFwdHeaderBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoryFwdHeaderNs.StoryFwdHeader.Identifier))
                return Tel.StoryFwdHeaderNs.StoryFwdHeader.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoryFwdHeaderNs.StoryFwdHeader StoryFwdHeader1205411504 => StoryFwdHeader1205411504.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PostInteractionCountersMessage, PostInteractionCountersStory,
    public abstract class PostInteractionCountersBase : ITlSerializable, ITlDeserializable<PostInteractionCountersBase> {
        public int Views {get;set;} = default!;
        public int Forwards {get;set;} = default!;
        public int Reactions {get;set;} = default!;
        public static PostInteractionCountersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PostInteractionCountersNs.PostInteractionCountersMessage.Identifier))
                return Tel.PostInteractionCountersNs.PostInteractionCountersMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PostInteractionCountersNs.PostInteractionCountersStory.Identifier))
                return Tel.PostInteractionCountersNs.PostInteractionCountersStory.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PostInteractionCountersNs.PostInteractionCountersMessage PostInteractionCountersMessage419066241 => PostInteractionCountersMessage419066241.TlSerialize(),
            Tel.PostInteractionCountersNs.PostInteractionCountersStory PostInteractionCountersStory1974989273 => PostInteractionCountersStory1974989273.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsStoryStats,
    public abstract class StatsStoryStatsBase : ITlSerializable, ITlDeserializable<StatsStoryStatsBase> {
        public static StatsStoryStatsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsStoryStatsNs.StatsStoryStats.Identifier))
                return Tel.StatsStoryStatsNs.StatsStoryStats.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsStoryStatsNs.StatsStoryStats StatsStoryStats1355613820 => StatsStoryStats1355613820.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PublicForwardMessage, PublicForwardStory,
    public abstract class PublicForwardBase : ITlSerializable, ITlDeserializable<PublicForwardBase> {
        public static PublicForwardBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PublicForwardNs.PublicForwardMessage.Identifier))
                return Tel.PublicForwardNs.PublicForwardMessage.TlDeserialize(des);
            if (id.SequenceEqual(Tel.PublicForwardNs.PublicForwardStory.Identifier))
                return Tel.PublicForwardNs.PublicForwardStory.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PublicForwardNs.PublicForwardMessage PublicForwardMessage32685898 => PublicForwardMessage32685898.TlSerialize(),
            Tel.PublicForwardNs.PublicForwardStory PublicForwardStory302797360 => PublicForwardStory302797360.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsPublicForwards,
    public abstract class StatsPublicForwardsBase : ITlSerializable, ITlDeserializable<StatsPublicForwardsBase> {
        public static StatsPublicForwardsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsPublicForwardsNs.StatsPublicForwards.Identifier))
                return Tel.StatsPublicForwardsNs.StatsPublicForwards.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsPublicForwardsNs.StatsPublicForwards StatsPublicForwards1828487648 => StatsPublicForwards1828487648.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PeerColor,
    public abstract class PeerColorBase : ITlSerializable, ITlDeserializable<PeerColorBase> {
        public static PeerColorBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PeerColorNs.PeerColor.Identifier))
                return Tel.PeerColorNs.PeerColor.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PeerColorNs.PeerColor PeerColor1253352753 => PeerColor1253352753.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpPeerColorSet, HelpPeerColorProfileSet,
    public abstract class HelpPeerColorSetBase : ITlSerializable, ITlDeserializable<HelpPeerColorSetBase> {
        public static HelpPeerColorSetBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpPeerColorSetNs.HelpPeerColorSet.Identifier))
                return Tel.HelpPeerColorSetNs.HelpPeerColorSet.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpPeerColorSetNs.HelpPeerColorProfileSet.Identifier))
                return Tel.HelpPeerColorSetNs.HelpPeerColorProfileSet.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpPeerColorSetNs.HelpPeerColorSet HelpPeerColorSet639736408 => HelpPeerColorSet639736408.TlSerialize(),
            Tel.HelpPeerColorSetNs.HelpPeerColorProfileSet HelpPeerColorProfileSet1987928555 => HelpPeerColorProfileSet1987928555.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpPeerColorOption,
    public abstract class HelpPeerColorOptionBase : ITlSerializable, ITlDeserializable<HelpPeerColorOptionBase> {
        public static HelpPeerColorOptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpPeerColorOptionNs.HelpPeerColorOption.Identifier))
                return Tel.HelpPeerColorOptionNs.HelpPeerColorOption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpPeerColorOptionNs.HelpPeerColorOption HelpPeerColorOption1377014082 => HelpPeerColorOption1377014082.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpPeerColorsNotModified, HelpPeerColors,
    public abstract class HelpPeerColorsBase : ITlSerializable, ITlDeserializable<HelpPeerColorsBase> {
        public static HelpPeerColorsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpPeerColorsNs.HelpPeerColorsNotModified.Identifier))
                return Tel.HelpPeerColorsNs.HelpPeerColorsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpPeerColorsNs.HelpPeerColors.Identifier))
                return Tel.HelpPeerColorsNs.HelpPeerColors.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpPeerColorsNs.HelpPeerColorsNotModified HelpPeerColorsNotModified732034510 => HelpPeerColorsNotModified732034510.TlSerialize(),
            Tel.HelpPeerColorsNs.HelpPeerColors HelpPeerColors16313608 => HelpPeerColors16313608.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoryReaction, StoryReactionPublicForward, StoryReactionPublicRepost,
    public abstract class StoryReactionBase : ITlSerializable, ITlDeserializable<StoryReactionBase> {
        public static StoryReactionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoryReactionNs.StoryReaction.Identifier))
                return Tel.StoryReactionNs.StoryReaction.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StoryReactionNs.StoryReactionPublicForward.Identifier))
                return Tel.StoryReactionNs.StoryReactionPublicForward.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StoryReactionNs.StoryReactionPublicRepost.Identifier))
                return Tel.StoryReactionNs.StoryReactionPublicRepost.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoryReactionNs.StoryReaction StoryReaction1620104917 => StoryReaction1620104917.TlSerialize(),
            Tel.StoryReactionNs.StoryReactionPublicForward StoryReactionPublicForward1146411453 => StoryReactionPublicForward1146411453.TlSerialize(),
            Tel.StoryReactionNs.StoryReactionPublicRepost StoryReactionPublicRepost808644845 => StoryReactionPublicRepost808644845.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoriesStoryReactionsList,
    public abstract class StoriesStoryReactionsListBase : ITlSerializable, ITlDeserializable<StoriesStoryReactionsListBase> {
        public static StoriesStoryReactionsListBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoriesStoryReactionsListNs.StoriesStoryReactionsList.Identifier))
                return Tel.StoriesStoryReactionsListNs.StoriesStoryReactionsList.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoriesStoryReactionsListNs.StoriesStoryReactionsList StoriesStoryReactionsList1436583780 => StoriesStoryReactionsList1436583780.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SavedDialog,
    public abstract class SavedDialogBase : ITlSerializable, ITlDeserializable<SavedDialogBase> {
        public static SavedDialogBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SavedDialogNs.SavedDialog.Identifier))
                return Tel.SavedDialogNs.SavedDialog.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SavedDialogNs.SavedDialog SavedDialog1115174036 => SavedDialog1115174036.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesSavedDialogs, MessagesSavedDialogsSlice, MessagesSavedDialogsNotModified,
    public abstract class MessagesSavedDialogsBase : ITlSerializable, ITlDeserializable<MessagesSavedDialogsBase> {
        public static MessagesSavedDialogsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesSavedDialogsNs.MessagesSavedDialogs.Identifier))
                return Tel.MessagesSavedDialogsNs.MessagesSavedDialogs.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesSavedDialogsNs.MessagesSavedDialogsSlice.Identifier))
                return Tel.MessagesSavedDialogsNs.MessagesSavedDialogsSlice.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesSavedDialogsNs.MessagesSavedDialogsNotModified.Identifier))
                return Tel.MessagesSavedDialogsNs.MessagesSavedDialogsNotModified.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesSavedDialogsNs.MessagesSavedDialogs MessagesSavedDialogs130358751 => MessagesSavedDialogs130358751.TlSerialize(),
            Tel.MessagesSavedDialogsNs.MessagesSavedDialogsSlice MessagesSavedDialogsSlice1153080793 => MessagesSavedDialogsSlice1153080793.TlSerialize(),
            Tel.MessagesSavedDialogsNs.MessagesSavedDialogsNotModified MessagesSavedDialogsNotModified1071681560 => MessagesSavedDialogsNotModified1071681560.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SavedReactionTag,
    public abstract class SavedReactionTagBase : ITlSerializable, ITlDeserializable<SavedReactionTagBase> {
        public static SavedReactionTagBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SavedReactionTagNs.SavedReactionTag.Identifier))
                return Tel.SavedReactionTagNs.SavedReactionTag.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SavedReactionTagNs.SavedReactionTag SavedReactionTag881854424 => SavedReactionTag881854424.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesSavedReactionTagsNotModified, MessagesSavedReactionTags,
    public abstract class MessagesSavedReactionTagsBase : ITlSerializable, ITlDeserializable<MessagesSavedReactionTagsBase> {
        public static MessagesSavedReactionTagsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesSavedReactionTagsNs.MessagesSavedReactionTagsNotModified.Identifier))
                return Tel.MessagesSavedReactionTagsNs.MessagesSavedReactionTagsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesSavedReactionTagsNs.MessagesSavedReactionTags.Identifier))
                return Tel.MessagesSavedReactionTagsNs.MessagesSavedReactionTags.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesSavedReactionTagsNs.MessagesSavedReactionTagsNotModified MessagesSavedReactionTagsNotModified2003084817 => MessagesSavedReactionTagsNotModified2003084817.TlSerialize(),
            Tel.MessagesSavedReactionTagsNs.MessagesSavedReactionTags MessagesSavedReactionTags844731658 => MessagesSavedReactionTags844731658.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: OutboxReadDate,
    public abstract class OutboxReadDateBase : ITlSerializable, ITlDeserializable<OutboxReadDateBase> {
        public static OutboxReadDateBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.OutboxReadDateNs.OutboxReadDate.Identifier))
                return Tel.OutboxReadDateNs.OutboxReadDate.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.OutboxReadDateNs.OutboxReadDate OutboxReadDate1001931436 => OutboxReadDate1001931436.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SmsjobsEligibleToJoin,
    public abstract class SmsjobsEligibilityToJoinBase : ITlSerializable, ITlDeserializable<SmsjobsEligibilityToJoinBase> {
        public static SmsjobsEligibilityToJoinBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SmsjobsEligibilityToJoinNs.SmsjobsEligibleToJoin.Identifier))
                return Tel.SmsjobsEligibilityToJoinNs.SmsjobsEligibleToJoin.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SmsjobsEligibilityToJoinNs.SmsjobsEligibleToJoin SmsjobsEligibleToJoin594852657 => SmsjobsEligibleToJoin594852657.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SmsjobsStatus,
    public abstract class SmsjobsStatusBase : ITlSerializable, ITlDeserializable<SmsjobsStatusBase> {
        public static SmsjobsStatusBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SmsjobsStatusNs.SmsjobsStatus.Identifier))
                return Tel.SmsjobsStatusNs.SmsjobsStatus.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SmsjobsStatusNs.SmsjobsStatus SmsjobsStatus720277905 => SmsjobsStatus720277905.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SmsJob,
    public abstract class SmsJobBase : ITlSerializable, ITlDeserializable<SmsJobBase> {
        public static SmsJobBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SmsJobNs.SmsJob.Identifier))
                return Tel.SmsJobNs.SmsJob.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SmsJobNs.SmsJob SmsJob425595208 => SmsJob425595208.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessWeeklyOpen,
    public abstract class BusinessWeeklyOpenBase : ITlSerializable, ITlDeserializable<BusinessWeeklyOpenBase> {
        public static BusinessWeeklyOpenBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessWeeklyOpenNs.BusinessWeeklyOpen.Identifier))
                return Tel.BusinessWeeklyOpenNs.BusinessWeeklyOpen.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessWeeklyOpenNs.BusinessWeeklyOpen BusinessWeeklyOpen302717625 => BusinessWeeklyOpen302717625.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessWorkHours,
    public abstract class BusinessWorkHoursBase : ITlSerializable, ITlDeserializable<BusinessWorkHoursBase> {
        public static BusinessWorkHoursBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessWorkHoursNs.BusinessWorkHours.Identifier))
                return Tel.BusinessWorkHoursNs.BusinessWorkHours.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessWorkHoursNs.BusinessWorkHours BusinessWorkHours1936543592 => BusinessWorkHours1936543592.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessLocation,
    public abstract class BusinessLocationBase : ITlSerializable, ITlDeserializable<BusinessLocationBase> {
        public static BusinessLocationBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessLocationNs.BusinessLocation.Identifier))
                return Tel.BusinessLocationNs.BusinessLocation.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessLocationNs.BusinessLocation BusinessLocation1403249929 => BusinessLocation1403249929.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBusinessRecipients,
    public abstract class InputBusinessRecipientsBase : ITlSerializable, ITlDeserializable<InputBusinessRecipientsBase> {
        public static InputBusinessRecipientsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBusinessRecipientsNs.InputBusinessRecipients.Identifier))
                return Tel.InputBusinessRecipientsNs.InputBusinessRecipients.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBusinessRecipientsNs.InputBusinessRecipients InputBusinessRecipients1871393450 => InputBusinessRecipients1871393450.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessRecipients,
    public abstract class BusinessRecipientsBase : ITlSerializable, ITlDeserializable<BusinessRecipientsBase> {
        public static BusinessRecipientsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessRecipientsNs.BusinessRecipients.Identifier))
                return Tel.BusinessRecipientsNs.BusinessRecipients.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessRecipientsNs.BusinessRecipients BusinessRecipients554733559 => BusinessRecipients554733559.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessAwayMessageScheduleAlways, BusinessAwayMessageScheduleOutsideWorkHours, BusinessAwayMessageScheduleCustom,
    public abstract class BusinessAwayMessageScheduleBase : ITlSerializable, ITlDeserializable<BusinessAwayMessageScheduleBase> {
        public static BusinessAwayMessageScheduleBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleAlways.Identifier))
                return Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleAlways.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleOutsideWorkHours.Identifier))
                return Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleOutsideWorkHours.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleCustom.Identifier))
                return Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleCustom.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleAlways BusinessAwayMessageScheduleAlways910564679 => BusinessAwayMessageScheduleAlways910564679.TlSerialize(),
            Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleOutsideWorkHours BusinessAwayMessageScheduleOutsideWorkHours1007487743 => BusinessAwayMessageScheduleOutsideWorkHours1007487743.TlSerialize(),
            Tel.BusinessAwayMessageScheduleNs.BusinessAwayMessageScheduleCustom BusinessAwayMessageScheduleCustom867328308 => BusinessAwayMessageScheduleCustom867328308.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBusinessGreetingMessage,
    public abstract class InputBusinessGreetingMessageBase : ITlSerializable, ITlDeserializable<InputBusinessGreetingMessageBase> {
        public static InputBusinessGreetingMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBusinessGreetingMessageNs.InputBusinessGreetingMessage.Identifier))
                return Tel.InputBusinessGreetingMessageNs.InputBusinessGreetingMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBusinessGreetingMessageNs.InputBusinessGreetingMessage InputBusinessGreetingMessage26528571 => InputBusinessGreetingMessage26528571.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessGreetingMessage,
    public abstract class BusinessGreetingMessageBase : ITlSerializable, ITlDeserializable<BusinessGreetingMessageBase> {
        public static BusinessGreetingMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessGreetingMessageNs.BusinessGreetingMessage.Identifier))
                return Tel.BusinessGreetingMessageNs.BusinessGreetingMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessGreetingMessageNs.BusinessGreetingMessage BusinessGreetingMessage451302485 => BusinessGreetingMessage451302485.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBusinessAwayMessage,
    public abstract class InputBusinessAwayMessageBase : ITlSerializable, ITlDeserializable<InputBusinessAwayMessageBase> {
        public static InputBusinessAwayMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBusinessAwayMessageNs.InputBusinessAwayMessage.Identifier))
                return Tel.InputBusinessAwayMessageNs.InputBusinessAwayMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBusinessAwayMessageNs.InputBusinessAwayMessage InputBusinessAwayMessage2094959136 => InputBusinessAwayMessage2094959136.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessAwayMessage,
    public abstract class BusinessAwayMessageBase : ITlSerializable, ITlDeserializable<BusinessAwayMessageBase> {
        public static BusinessAwayMessageBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessAwayMessageNs.BusinessAwayMessage.Identifier))
                return Tel.BusinessAwayMessageNs.BusinessAwayMessage.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessAwayMessageNs.BusinessAwayMessage BusinessAwayMessage283809188 => BusinessAwayMessage283809188.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Timezone,
    public abstract class TimezoneBase : ITlSerializable, ITlDeserializable<TimezoneBase> {
        public static TimezoneBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.TimezoneNs.Timezone.Identifier))
                return Tel.TimezoneNs.Timezone.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.TimezoneNs.Timezone Timezone7173643 => Timezone7173643.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: HelpTimezonesListNotModified, HelpTimezonesList,
    public abstract class HelpTimezonesListBase : ITlSerializable, ITlDeserializable<HelpTimezonesListBase> {
        public static HelpTimezonesListBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.HelpTimezonesListNs.HelpTimezonesListNotModified.Identifier))
                return Tel.HelpTimezonesListNs.HelpTimezonesListNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.HelpTimezonesListNs.HelpTimezonesList.Identifier))
                return Tel.HelpTimezonesListNs.HelpTimezonesList.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.HelpTimezonesListNs.HelpTimezonesListNotModified HelpTimezonesListNotModified1761146676 => HelpTimezonesListNotModified1761146676.TlSerialize(),
            Tel.HelpTimezonesListNs.HelpTimezonesList HelpTimezonesList2071260529 => HelpTimezonesList2071260529.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: QuickReply,
    public abstract class QuickReplyBase : ITlSerializable, ITlDeserializable<QuickReplyBase> {
        public static QuickReplyBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.QuickReplyNs.QuickReply.Identifier))
                return Tel.QuickReplyNs.QuickReply.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.QuickReplyNs.QuickReply QuickReply110563371 => QuickReply110563371.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputQuickReplyShortcut, InputQuickReplyShortcutId,
    public abstract class InputQuickReplyShortcutBase : ITlSerializable, ITlDeserializable<InputQuickReplyShortcutBase> {
        public static InputQuickReplyShortcutBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputQuickReplyShortcutNs.InputQuickReplyShortcut.Identifier))
                return Tel.InputQuickReplyShortcutNs.InputQuickReplyShortcut.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputQuickReplyShortcutNs.InputQuickReplyShortcutId.Identifier))
                return Tel.InputQuickReplyShortcutNs.InputQuickReplyShortcutId.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputQuickReplyShortcutNs.InputQuickReplyShortcut InputQuickReplyShortcut609840449 => InputQuickReplyShortcut609840449.TlSerialize(),
            Tel.InputQuickReplyShortcutNs.InputQuickReplyShortcutId InputQuickReplyShortcutId18418929 => InputQuickReplyShortcutId18418929.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesQuickReplies, MessagesQuickRepliesNotModified,
    public abstract class MessagesQuickRepliesBase : ITlSerializable, ITlDeserializable<MessagesQuickRepliesBase> {
        public static MessagesQuickRepliesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesQuickRepliesNs.MessagesQuickReplies.Identifier))
                return Tel.MessagesQuickRepliesNs.MessagesQuickReplies.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesQuickRepliesNs.MessagesQuickRepliesNotModified.Identifier))
                return Tel.MessagesQuickRepliesNs.MessagesQuickRepliesNotModified.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesQuickRepliesNs.MessagesQuickReplies MessagesQuickReplies963811691 => MessagesQuickReplies963811691.TlSerialize(),
            Tel.MessagesQuickRepliesNs.MessagesQuickRepliesNotModified MessagesQuickRepliesNotModified1603398491 => MessagesQuickRepliesNotModified1603398491.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ConnectedBot,
    public abstract class ConnectedBotBase : ITlSerializable, ITlDeserializable<ConnectedBotBase> {
        public static ConnectedBotBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ConnectedBotNs.ConnectedBot.Identifier))
                return Tel.ConnectedBotNs.ConnectedBot.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ConnectedBotNs.ConnectedBot ConnectedBot1123645951 => ConnectedBot1123645951.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountConnectedBots,
    public abstract class AccountConnectedBotsBase : ITlSerializable, ITlDeserializable<AccountConnectedBotsBase> {
        public static AccountConnectedBotsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountConnectedBotsNs.AccountConnectedBots.Identifier))
                return Tel.AccountConnectedBotsNs.AccountConnectedBots.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountConnectedBotsNs.AccountConnectedBots AccountConnectedBots400029819 => AccountConnectedBots400029819.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesDialogFilters,
    public abstract class MessagesDialogFiltersBase : ITlSerializable, ITlDeserializable<MessagesDialogFiltersBase> {
        public static MessagesDialogFiltersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesDialogFiltersNs.MessagesDialogFilters.Identifier))
                return Tel.MessagesDialogFiltersNs.MessagesDialogFilters.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesDialogFiltersNs.MessagesDialogFilters MessagesDialogFilters718878489 => MessagesDialogFilters718878489.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: Birthday,
    public abstract class BirthdayBase : ITlSerializable, ITlDeserializable<BirthdayBase> {
        public static BirthdayBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BirthdayNs.Birthday.Identifier))
                return Tel.BirthdayNs.Birthday.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BirthdayNs.Birthday Birthday1821253126 => Birthday1821253126.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BotBusinessConnection,
    public abstract class BotBusinessConnectionBase : ITlSerializable, ITlDeserializable<BotBusinessConnectionBase> {
        public static BotBusinessConnectionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BotBusinessConnectionNs.BotBusinessConnection.Identifier))
                return Tel.BotBusinessConnectionNs.BotBusinessConnection.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BotBusinessConnectionNs.BotBusinessConnection BotBusinessConnection1989921868 => BotBusinessConnection1989921868.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBusinessIntro,
    public abstract class InputBusinessIntroBase : ITlSerializable, ITlDeserializable<InputBusinessIntroBase> {
        public static InputBusinessIntroBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBusinessIntroNs.InputBusinessIntro.Identifier))
                return Tel.InputBusinessIntroNs.InputBusinessIntro.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBusinessIntroNs.InputBusinessIntro InputBusinessIntro163867085 => InputBusinessIntro163867085.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessIntro,
    public abstract class BusinessIntroBase : ITlSerializable, ITlDeserializable<BusinessIntroBase> {
        public static BusinessIntroBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessIntroNs.BusinessIntro.Identifier))
                return Tel.BusinessIntroNs.BusinessIntro.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessIntroNs.BusinessIntro BusinessIntro1510606445 => BusinessIntro1510606445.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesMyStickers,
    public abstract class MessagesMyStickersBase : ITlSerializable, ITlDeserializable<MessagesMyStickersBase> {
        public static MessagesMyStickersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesMyStickersNs.MessagesMyStickers.Identifier))
                return Tel.MessagesMyStickersNs.MessagesMyStickers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesMyStickersNs.MessagesMyStickers MessagesMyStickers83926371 => MessagesMyStickers83926371.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputCollectibleUsername, InputCollectiblePhone,
    public abstract class InputCollectibleBase : ITlSerializable, ITlDeserializable<InputCollectibleBase> {
        public static InputCollectibleBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputCollectibleNs.InputCollectibleUsername.Identifier))
                return Tel.InputCollectibleNs.InputCollectibleUsername.TlDeserialize(des);
            if (id.SequenceEqual(Tel.InputCollectibleNs.InputCollectiblePhone.Identifier))
                return Tel.InputCollectibleNs.InputCollectiblePhone.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputCollectibleNs.InputCollectibleUsername InputCollectibleUsername476815191 => InputCollectibleUsername476815191.TlSerialize(),
            Tel.InputCollectibleNs.InputCollectiblePhone InputCollectiblePhone1562241884 => InputCollectiblePhone1562241884.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: FragmentCollectibleInfo,
    public abstract class FragmentCollectibleInfoBase : ITlSerializable, ITlDeserializable<FragmentCollectibleInfoBase> {
        public static FragmentCollectibleInfoBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.FragmentCollectibleInfoNs.FragmentCollectibleInfo.Identifier))
                return Tel.FragmentCollectibleInfoNs.FragmentCollectibleInfo.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.FragmentCollectibleInfoNs.FragmentCollectibleInfo FragmentCollectibleInfo1857945489 => FragmentCollectibleInfo1857945489.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBusinessBotRecipients,
    public abstract class InputBusinessBotRecipientsBase : ITlSerializable, ITlDeserializable<InputBusinessBotRecipientsBase> {
        public static InputBusinessBotRecipientsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBusinessBotRecipientsNs.InputBusinessBotRecipients.Identifier))
                return Tel.InputBusinessBotRecipientsNs.InputBusinessBotRecipients.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBusinessBotRecipientsNs.InputBusinessBotRecipients InputBusinessBotRecipients991587810 => InputBusinessBotRecipients991587810.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessBotRecipients,
    public abstract class BusinessBotRecipientsBase : ITlSerializable, ITlDeserializable<BusinessBotRecipientsBase> {
        public static BusinessBotRecipientsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessBotRecipientsNs.BusinessBotRecipients.Identifier))
                return Tel.BusinessBotRecipientsNs.BusinessBotRecipients.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessBotRecipientsNs.BusinessBotRecipients BusinessBotRecipients1198722189 => BusinessBotRecipients1198722189.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactBirthday,
    public abstract class ContactBirthdayBase : ITlSerializable, ITlDeserializable<ContactBirthdayBase> {
        public static ContactBirthdayBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactBirthdayNs.ContactBirthday.Identifier))
                return Tel.ContactBirthdayNs.ContactBirthday.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactBirthdayNs.ContactBirthday ContactBirthday496600883 => ContactBirthday496600883.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ContactsContactBirthdays,
    public abstract class ContactsContactBirthdaysBase : ITlSerializable, ITlDeserializable<ContactsContactBirthdaysBase> {
        public static ContactsContactBirthdaysBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ContactsContactBirthdaysNs.ContactsContactBirthdays.Identifier))
                return Tel.ContactsContactBirthdaysNs.ContactsContactBirthdays.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ContactsContactBirthdaysNs.ContactsContactBirthdays ContactsContactBirthdays290452237 => ContactsContactBirthdays290452237.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MissingInvitee,
    public abstract class MissingInviteeBase : ITlSerializable, ITlDeserializable<MissingInviteeBase> {
        public static MissingInviteeBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MissingInviteeNs.MissingInvitee.Identifier))
                return Tel.MissingInviteeNs.MissingInvitee.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MissingInviteeNs.MissingInvitee MissingInvitee1653379620 => MissingInvitee1653379620.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesInvitedUsers,
    public abstract class MessagesInvitedUsersBase : ITlSerializable, ITlDeserializable<MessagesInvitedUsersBase> {
        public static MessagesInvitedUsersBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesInvitedUsersNs.MessagesInvitedUsers.Identifier))
                return Tel.MessagesInvitedUsersNs.MessagesInvitedUsers.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesInvitedUsersNs.MessagesInvitedUsers MessagesInvitedUsers2136862630 => MessagesInvitedUsers2136862630.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputBusinessChatLink,
    public abstract class InputBusinessChatLinkBase : ITlSerializable, ITlDeserializable<InputBusinessChatLinkBase> {
        public static InputBusinessChatLinkBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputBusinessChatLinkNs.InputBusinessChatLink.Identifier))
                return Tel.InputBusinessChatLinkNs.InputBusinessChatLink.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputBusinessChatLinkNs.InputBusinessChatLink InputBusinessChatLink292003751 => InputBusinessChatLink292003751.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BusinessChatLink,
    public abstract class BusinessChatLinkBase : ITlSerializable, ITlDeserializable<BusinessChatLinkBase> {
        public static BusinessChatLinkBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BusinessChatLinkNs.BusinessChatLink.Identifier))
                return Tel.BusinessChatLinkNs.BusinessChatLink.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BusinessChatLinkNs.BusinessChatLink BusinessChatLink1263638929 => BusinessChatLink1263638929.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountBusinessChatLinks,
    public abstract class AccountBusinessChatLinksBase : ITlSerializable, ITlDeserializable<AccountBusinessChatLinksBase> {
        public static AccountBusinessChatLinksBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountBusinessChatLinksNs.AccountBusinessChatLinks.Identifier))
                return Tel.AccountBusinessChatLinksNs.AccountBusinessChatLinks.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountBusinessChatLinksNs.AccountBusinessChatLinks AccountBusinessChatLinks331111727 => AccountBusinessChatLinks331111727.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AccountResolvedBusinessChatLinks,
    public abstract class AccountResolvedBusinessChatLinksBase : ITlSerializable, ITlDeserializable<AccountResolvedBusinessChatLinksBase> {
        public static AccountResolvedBusinessChatLinksBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AccountResolvedBusinessChatLinksNs.AccountResolvedBusinessChatLinks.Identifier))
                return Tel.AccountResolvedBusinessChatLinksNs.AccountResolvedBusinessChatLinks.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AccountResolvedBusinessChatLinksNs.AccountResolvedBusinessChatLinks AccountResolvedBusinessChatLinks1708937439 => AccountResolvedBusinessChatLinks1708937439.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: RequestedPeerUser, RequestedPeerChat, RequestedPeerChannel,
    public abstract class RequestedPeerBase : ITlSerializable, ITlDeserializable<RequestedPeerBase> {
        public int Flags {get;set;} = default!;
        public PhotoBase? Photo {get;set;} = default!;
        public static RequestedPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.RequestedPeerNs.RequestedPeerUser.Identifier))
                return Tel.RequestedPeerNs.RequestedPeerUser.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RequestedPeerNs.RequestedPeerChat.Identifier))
                return Tel.RequestedPeerNs.RequestedPeerChat.TlDeserialize(des);
            if (id.SequenceEqual(Tel.RequestedPeerNs.RequestedPeerChannel.Identifier))
                return Tel.RequestedPeerNs.RequestedPeerChannel.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.RequestedPeerNs.RequestedPeerUser RequestedPeerUser701500310 => RequestedPeerUser701500310.TlSerialize(),
            Tel.RequestedPeerNs.RequestedPeerChat RequestedPeerChat1929860175 => RequestedPeerChat1929860175.TlSerialize(),
            Tel.RequestedPeerNs.RequestedPeerChannel RequestedPeerChannel1952185372 => RequestedPeerChannel1952185372.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: SponsoredMessageReportOption,
    public abstract class SponsoredMessageReportOptionBase : ITlSerializable, ITlDeserializable<SponsoredMessageReportOptionBase> {
        public static SponsoredMessageReportOptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.SponsoredMessageReportOptionNs.SponsoredMessageReportOption.Identifier))
                return Tel.SponsoredMessageReportOptionNs.SponsoredMessageReportOption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.SponsoredMessageReportOptionNs.SponsoredMessageReportOption SponsoredMessageReportOption1124938064 => SponsoredMessageReportOption1124938064.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ChannelsSponsoredMessageReportResultChooseOption, ChannelsSponsoredMessageReportResultAdsHidden, ChannelsSponsoredMessageReportResultReported,
    public abstract class ChannelsSponsoredMessageReportResultBase : ITlSerializable, ITlDeserializable<ChannelsSponsoredMessageReportResultBase> {
        public static ChannelsSponsoredMessageReportResultBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultChooseOption.Identifier))
                return Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultChooseOption.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultAdsHidden.Identifier))
                return Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultAdsHidden.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultReported.Identifier))
                return Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultReported.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultChooseOption ChannelsSponsoredMessageReportResultChooseOption2073059774 => ChannelsSponsoredMessageReportResultChooseOption2073059774.TlSerialize(),
            Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultAdsHidden ChannelsSponsoredMessageReportResultAdsHidden1044107055 => ChannelsSponsoredMessageReportResultAdsHidden1044107055.TlSerialize(),
            Tel.ChannelsSponsoredMessageReportResultNs.ChannelsSponsoredMessageReportResultReported ChannelsSponsoredMessageReportResultReported1384544183 => ChannelsSponsoredMessageReportResultReported1384544183.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsBroadcastRevenueStats,
    public abstract class StatsBroadcastRevenueStatsBase : ITlSerializable, ITlDeserializable<StatsBroadcastRevenueStatsBase> {
        public static StatsBroadcastRevenueStatsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsBroadcastRevenueStatsNs.StatsBroadcastRevenueStats.Identifier))
                return Tel.StatsBroadcastRevenueStatsNs.StatsBroadcastRevenueStats.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsBroadcastRevenueStatsNs.StatsBroadcastRevenueStats StatsBroadcastRevenueStats1409802903 => StatsBroadcastRevenueStats1409802903.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsBroadcastRevenueWithdrawalUrl,
    public abstract class StatsBroadcastRevenueWithdrawalUrlBase : ITlSerializable, ITlDeserializable<StatsBroadcastRevenueWithdrawalUrlBase> {
        public static StatsBroadcastRevenueWithdrawalUrlBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsBroadcastRevenueWithdrawalUrlNs.StatsBroadcastRevenueWithdrawalUrl.Identifier))
                return Tel.StatsBroadcastRevenueWithdrawalUrlNs.StatsBroadcastRevenueWithdrawalUrl.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsBroadcastRevenueWithdrawalUrlNs.StatsBroadcastRevenueWithdrawalUrl StatsBroadcastRevenueWithdrawalUrl328886473 => StatsBroadcastRevenueWithdrawalUrl328886473.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BroadcastRevenueTransactionProceeds, BroadcastRevenueTransactionWithdrawal, BroadcastRevenueTransactionRefund,
    public abstract class BroadcastRevenueTransactionBase : ITlSerializable, ITlDeserializable<BroadcastRevenueTransactionBase> {
        public long Amount {get;set;} = default!;
        public static BroadcastRevenueTransactionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionProceeds.Identifier))
                return Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionProceeds.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionWithdrawal.Identifier))
                return Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionWithdrawal.TlDeserialize(des);
            if (id.SequenceEqual(Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionRefund.Identifier))
                return Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionRefund.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionProceeds BroadcastRevenueTransactionProceeds1434332356 => BroadcastRevenueTransactionProceeds1434332356.TlSerialize(),
            Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionWithdrawal BroadcastRevenueTransactionWithdrawal1515784568 => BroadcastRevenueTransactionWithdrawal1515784568.TlSerialize(),
            Tel.BroadcastRevenueTransactionNs.BroadcastRevenueTransactionRefund BroadcastRevenueTransactionRefund1121127726 => BroadcastRevenueTransactionRefund1121127726.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StatsBroadcastRevenueTransactions,
    public abstract class StatsBroadcastRevenueTransactionsBase : ITlSerializable, ITlDeserializable<StatsBroadcastRevenueTransactionsBase> {
        public static StatsBroadcastRevenueTransactionsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StatsBroadcastRevenueTransactionsNs.StatsBroadcastRevenueTransactions.Identifier))
                return Tel.StatsBroadcastRevenueTransactionsNs.StatsBroadcastRevenueTransactions.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StatsBroadcastRevenueTransactionsNs.StatsBroadcastRevenueTransactions StatsBroadcastRevenueTransactions2028632986 => StatsBroadcastRevenueTransactions2028632986.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ReactionNotificationsFromContacts, ReactionNotificationsFromAll,
    public abstract class ReactionNotificationsFromBase : ITlSerializable, ITlDeserializable<ReactionNotificationsFromBase> {
        public static ReactionNotificationsFromBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ReactionNotificationsFromNs.ReactionNotificationsFromContacts.Identifier))
                return Tel.ReactionNotificationsFromNs.ReactionNotificationsFromContacts.TlDeserialize(des);
            if (id.SequenceEqual(Tel.ReactionNotificationsFromNs.ReactionNotificationsFromAll.Identifier))
                return Tel.ReactionNotificationsFromNs.ReactionNotificationsFromAll.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ReactionNotificationsFromNs.ReactionNotificationsFromContacts ReactionNotificationsFromContacts1161583078 => ReactionNotificationsFromContacts1161583078.TlSerialize(),
            Tel.ReactionNotificationsFromNs.ReactionNotificationsFromAll ReactionNotificationsFromAll1268654752 => ReactionNotificationsFromAll1268654752.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: ReactionsNotifySettings,
    public abstract class ReactionsNotifySettingsBase : ITlSerializable, ITlDeserializable<ReactionsNotifySettingsBase> {
        public static ReactionsNotifySettingsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.ReactionsNotifySettingsNs.ReactionsNotifySettings.Identifier))
                return Tel.ReactionsNotifySettingsNs.ReactionsNotifySettings.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.ReactionsNotifySettingsNs.ReactionsNotifySettings ReactionsNotifySettings1457736048 => ReactionsNotifySettings1457736048.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: BroadcastRevenueBalances,
    public abstract class BroadcastRevenueBalancesBase : ITlSerializable, ITlDeserializable<BroadcastRevenueBalancesBase> {
        public static BroadcastRevenueBalancesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.BroadcastRevenueBalancesNs.BroadcastRevenueBalances.Identifier))
                return Tel.BroadcastRevenueBalancesNs.BroadcastRevenueBalances.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.BroadcastRevenueBalancesNs.BroadcastRevenueBalances BroadcastRevenueBalances2076642874 => BroadcastRevenueBalances2076642874.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: AvailableEffect,
    public abstract class AvailableEffectBase : ITlSerializable, ITlDeserializable<AvailableEffectBase> {
        public static AvailableEffectBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.AvailableEffectNs.AvailableEffect.Identifier))
                return Tel.AvailableEffectNs.AvailableEffect.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.AvailableEffectNs.AvailableEffect AvailableEffect1815879042 => AvailableEffect1815879042.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: MessagesAvailableEffectsNotModified, MessagesAvailableEffects,
    public abstract class MessagesAvailableEffectsBase : ITlSerializable, ITlDeserializable<MessagesAvailableEffectsBase> {
        public static MessagesAvailableEffectsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.MessagesAvailableEffectsNs.MessagesAvailableEffectsNotModified.Identifier))
                return Tel.MessagesAvailableEffectsNs.MessagesAvailableEffectsNotModified.TlDeserialize(des);
            if (id.SequenceEqual(Tel.MessagesAvailableEffectsNs.MessagesAvailableEffects.Identifier))
                return Tel.MessagesAvailableEffectsNs.MessagesAvailableEffects.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.MessagesAvailableEffectsNs.MessagesAvailableEffectsNotModified MessagesAvailableEffectsNotModified772957605 => MessagesAvailableEffectsNotModified772957605.TlSerialize(),
            Tel.MessagesAvailableEffectsNs.MessagesAvailableEffects MessagesAvailableEffects1109696146 => MessagesAvailableEffects1109696146.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: FactCheck,
    public abstract class FactCheckBase : ITlSerializable, ITlDeserializable<FactCheckBase> {
        public static FactCheckBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.FactCheckNs.FactCheck.Identifier))
                return Tel.FactCheckNs.FactCheck.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.FactCheckNs.FactCheck FactCheck1197736753 => FactCheck1197736753.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StarsTransactionPeerUnsupported, StarsTransactionPeerAppStore, StarsTransactionPeerPlayMarket, StarsTransactionPeerPremiumBot, StarsTransactionPeerFragment, StarsTransactionPeer, StarsTransactionPeerAds,
    public abstract class StarsTransactionPeerBase : ITlSerializable, ITlDeserializable<StarsTransactionPeerBase> {
        public static StarsTransactionPeerBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StarsTransactionPeerNs.StarsTransactionPeerUnsupported.Identifier))
                return Tel.StarsTransactionPeerNs.StarsTransactionPeerUnsupported.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StarsTransactionPeerNs.StarsTransactionPeerAppStore.Identifier))
                return Tel.StarsTransactionPeerNs.StarsTransactionPeerAppStore.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StarsTransactionPeerNs.StarsTransactionPeerPlayMarket.Identifier))
                return Tel.StarsTransactionPeerNs.StarsTransactionPeerPlayMarket.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StarsTransactionPeerNs.StarsTransactionPeerPremiumBot.Identifier))
                return Tel.StarsTransactionPeerNs.StarsTransactionPeerPremiumBot.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StarsTransactionPeerNs.StarsTransactionPeerFragment.Identifier))
                return Tel.StarsTransactionPeerNs.StarsTransactionPeerFragment.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StarsTransactionPeerNs.StarsTransactionPeer.Identifier))
                return Tel.StarsTransactionPeerNs.StarsTransactionPeer.TlDeserialize(des);
            if (id.SequenceEqual(Tel.StarsTransactionPeerNs.StarsTransactionPeerAds.Identifier))
                return Tel.StarsTransactionPeerNs.StarsTransactionPeerAds.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StarsTransactionPeerNs.StarsTransactionPeerUnsupported StarsTransactionPeerUnsupported1779253276 => StarsTransactionPeerUnsupported1779253276.TlSerialize(),
            Tel.StarsTransactionPeerNs.StarsTransactionPeerAppStore StarsTransactionPeerAppStore1269320843 => StarsTransactionPeerAppStore1269320843.TlSerialize(),
            Tel.StarsTransactionPeerNs.StarsTransactionPeerPlayMarket StarsTransactionPeerPlayMarket2069236235 => StarsTransactionPeerPlayMarket2069236235.TlSerialize(),
            Tel.StarsTransactionPeerNs.StarsTransactionPeerPremiumBot StarsTransactionPeerPremiumBot621656824 => StarsTransactionPeerPremiumBot621656824.TlSerialize(),
            Tel.StarsTransactionPeerNs.StarsTransactionPeerFragment StarsTransactionPeerFragment382740222 => StarsTransactionPeerFragment382740222.TlSerialize(),
            Tel.StarsTransactionPeerNs.StarsTransactionPeer StarsTransactionPeer670195363 => StarsTransactionPeer670195363.TlSerialize(),
            Tel.StarsTransactionPeerNs.StarsTransactionPeerAds StarsTransactionPeerAds1617438738 => StarsTransactionPeerAds1617438738.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StarsTopupOption,
    public abstract class StarsTopupOptionBase : ITlSerializable, ITlDeserializable<StarsTopupOptionBase> {
        public static StarsTopupOptionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StarsTopupOptionNs.StarsTopupOption.Identifier))
                return Tel.StarsTopupOptionNs.StarsTopupOption.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StarsTopupOptionNs.StarsTopupOption StarsTopupOption198776256 => StarsTopupOption198776256.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StarsTransaction,
    public abstract class StarsTransactionBase : ITlSerializable, ITlDeserializable<StarsTransactionBase> {
        public static StarsTransactionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StarsTransactionNs.StarsTransaction.Identifier))
                return Tel.StarsTransactionNs.StarsTransaction.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StarsTransactionNs.StarsTransaction StarsTransaction766853519 => StarsTransaction766853519.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsStarsStatus,
    public abstract class PaymentsStarsStatusBase : ITlSerializable, ITlDeserializable<PaymentsStarsStatusBase> {
        public static PaymentsStarsStatusBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsStarsStatusNs.PaymentsStarsStatus.Identifier))
                return Tel.PaymentsStarsStatusNs.PaymentsStarsStatus.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsStarsStatusNs.PaymentsStarsStatus PaymentsStarsStatus1930105248 => PaymentsStarsStatus1930105248.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: FoundStory,
    public abstract class FoundStoryBase : ITlSerializable, ITlDeserializable<FoundStoryBase> {
        public static FoundStoryBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.FoundStoryNs.FoundStory.Identifier))
                return Tel.FoundStoryNs.FoundStory.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.FoundStoryNs.FoundStory FoundStory394605632 => FoundStory394605632.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StoriesFoundStories,
    public abstract class StoriesFoundStoriesBase : ITlSerializable, ITlDeserializable<StoriesFoundStoriesBase> {
        public static StoriesFoundStoriesBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StoriesFoundStoriesNs.StoriesFoundStories.Identifier))
                return Tel.StoriesFoundStoriesNs.StoriesFoundStories.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StoriesFoundStoriesNs.StoriesFoundStories StoriesFoundStories488736969 => StoriesFoundStories488736969.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: GeoPointAddress,
    public abstract class GeoPointAddressBase : ITlSerializable, ITlDeserializable<GeoPointAddressBase> {
        public static GeoPointAddressBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.GeoPointAddressNs.GeoPointAddress.Identifier))
                return Tel.GeoPointAddressNs.GeoPointAddress.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.GeoPointAddressNs.GeoPointAddress GeoPointAddress565420653 => GeoPointAddress565420653.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: StarsRevenueStatus,
    public abstract class StarsRevenueStatusBase : ITlSerializable, ITlDeserializable<StarsRevenueStatusBase> {
        public static StarsRevenueStatusBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.StarsRevenueStatusNs.StarsRevenueStatus.Identifier))
                return Tel.StarsRevenueStatusNs.StarsRevenueStatus.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.StarsRevenueStatusNs.StarsRevenueStatus StarsRevenueStatus2033461574 => StarsRevenueStatus2033461574.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsStarsRevenueStats,
    public abstract class PaymentsStarsRevenueStatsBase : ITlSerializable, ITlDeserializable<PaymentsStarsRevenueStatsBase> {
        public static PaymentsStarsRevenueStatsBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsStarsRevenueStatsNs.PaymentsStarsRevenueStats.Identifier))
                return Tel.PaymentsStarsRevenueStatsNs.PaymentsStarsRevenueStats.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsStarsRevenueStatsNs.PaymentsStarsRevenueStats PaymentsStarsRevenueStats919881925 => PaymentsStarsRevenueStats919881925.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsStarsRevenueWithdrawalUrl,
    public abstract class PaymentsStarsRevenueWithdrawalUrlBase : ITlSerializable, ITlDeserializable<PaymentsStarsRevenueWithdrawalUrlBase> {
        public static PaymentsStarsRevenueWithdrawalUrlBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsStarsRevenueWithdrawalUrlNs.PaymentsStarsRevenueWithdrawalUrl.Identifier))
                return Tel.PaymentsStarsRevenueWithdrawalUrlNs.PaymentsStarsRevenueWithdrawalUrl.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsStarsRevenueWithdrawalUrlNs.PaymentsStarsRevenueWithdrawalUrl PaymentsStarsRevenueWithdrawalUrl497778871 => PaymentsStarsRevenueWithdrawalUrl497778871.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: PaymentsStarsRevenueAdsAccountUrl,
    public abstract class PaymentsStarsRevenueAdsAccountUrlBase : ITlSerializable, ITlDeserializable<PaymentsStarsRevenueAdsAccountUrlBase> {
        public static PaymentsStarsRevenueAdsAccountUrlBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.PaymentsStarsRevenueAdsAccountUrlNs.PaymentsStarsRevenueAdsAccountUrl.Identifier))
                return Tel.PaymentsStarsRevenueAdsAccountUrlNs.PaymentsStarsRevenueAdsAccountUrl.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.PaymentsStarsRevenueAdsAccountUrlNs.PaymentsStarsRevenueAdsAccountUrl PaymentsStarsRevenueAdsAccountUrl961445665 => PaymentsStarsRevenueAdsAccountUrl961445665.TlSerialize(),
            _=> [],
        };
    }
/// derived Types: InputStarsTransaction,
    public abstract class InputStarsTransactionBase : ITlSerializable, ITlDeserializable<InputStarsTransactionBase> {
        public static InputStarsTransactionBase TlDeserialize(Deserializer des) {
            var id = des.ReadId();

            if (id.SequenceEqual(Tel.InputStarsTransactionNs.InputStarsTransaction.Identifier))
                return Tel.InputStarsTransactionNs.InputStarsTransaction.TlDeserialize(des);
            throw Core.Models.Errors.DeserializationException.InvalidCtor;
        }
        public byte[] TlSerialize() => this switch {
            Tel.InputStarsTransactionNs.InputStarsTransaction InputStarsTransaction543876817 => InputStarsTransaction543876817.TlSerialize(),
            _=> [],
        };
    }
