# Caught in 4K
Allows you to customize the resolution the video camera records in.
You can even set it to non-standard aspect ratios (e. g. 16:9 with 1024x576 resolution). This will look stretched/squished ingame but the final video file looks normal.

*Don't actually set it to 4K as that will extremely likely crash your game.*

Resolution can be configured in the config file. Big revelation, I know.

### Send bug reports to [the GitHub repo](https://github.com/SlenLen/CW-CaughtIn4K/issues) or send me a DM on Discord (@slenlen).

I recommend using [Flashcard](https://thunderstore.io/c/content-warning/p/loaforc/Flashcard/) alongside this mod because the increased resolution probably won't be noticable without a higher bitrate. Also a great way to make your video file sizes way too big.

# Important Information
All bugs which I currently know of and (which probably won't be fixed) arise from players using different configs from one another or players in the lobby not having the mod installed at all.

Some of the bugs include (but aren't limited to):
- Not being able to save the video
- the resolution depends on the player holding the camera, so if someone without the mods holds the camera after someone *with* the mod held it, the resulting video will have lower resolution during that time. This also causes

`tl;dr everyone in the lobby should have this mod installed and should have the same config to guarantee stability`

# Technical Information
All this mod really does, is change the resolution of the RenderTexture the video camera is created with. This value is hardcoded to 420x420 in vanilla and this mod just replaces the hardcoded value with the set resolution.

By default the resolution is doubled (to 840x840), which might be a bit to high for some, so maybe lower it.

Luckily this is all the mod has to do, since most other stuff in the game already account for any RenderTarget resolution even though it normally can't be changed.
