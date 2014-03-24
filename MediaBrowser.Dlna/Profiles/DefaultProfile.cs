﻿using MediaBrowser.Controller.Dlna;

namespace MediaBrowser.Dlna.Profiles
{
    public class DefaultProfile : DeviceProfile
    {
        public DefaultProfile()
        {
            ProtocolInfo = "DLNA";

            ClientType = "DLNA";
            Manufacturer = "Media Browser";
            ModelDescription = "Media Browser";
            ModelName = "Media Browser";
            ModelNumber = "Media Browser";
            ModelUrl = "http://mediabrowser3.com/";
            ManufacturerUrl = "http://mediabrowser3.com/";

            TranscodingProfiles = new[]
            {
                new TranscodingProfile
                {
                    Container = "mp3",
                    AudioCodec = "mp3",
                    Type = DlnaProfileType.Audio
                },

                new TranscodingProfile
                {
                    Container = "ts",
                    Type = DlnaProfileType.Video,
                    AudioCodec = "aac",
                    VideoCodec = "h264",

                    Settings = new []
                    {
                        new TranscodingSetting {Name = TranscodingSettingType.VideoLevel, Value = "3"},
                        new TranscodingSetting {Name = TranscodingSettingType.VideoProfile, Value = "baseline"}
                    }
                }
            };

            DirectPlayProfiles = new[]
            {
                new DirectPlayProfile
                {
                    Container = "mp3,wma",
                    Type = DlnaProfileType.Audio
                },

                new DirectPlayProfile
                {
                    Container = "avi,mp4",
                    Type = DlnaProfileType.Video
                }
            };
        }
    }
}
