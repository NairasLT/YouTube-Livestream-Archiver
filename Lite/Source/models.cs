﻿using YoutubeExplode.Videos;

public class Channel
{
    public Channel(string channelId, int minutesTimeOut, Platform platform)
    {
        ChannelId = channelId;
        MinutesTimeOut = minutesTimeOut;
        Platform = platform;
    }

    public string ChannelId { get; set; }
    public int MinutesTimeOut { get; set; }
    public Platform Platform { get; set; }
}

public enum Platform
{
    YouTube = 0,
    Trovo = 1,
    TrovoDeprecated = -1
}

class ConfigFile
{
    public ChannelGroup[] ChannelGroups { get; set; }

    public ConfigFile(ChannelGroup[] channelGroups)
    {
        ChannelGroups = channelGroups;
    }
}




