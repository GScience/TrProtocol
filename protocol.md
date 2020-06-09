## Terraria protocol
### Message [000]UNKNOWN

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
### Message [001]ConnectRequest

| arg | type | description |
| ----- | ----- | ----- |
| version | [string](#Type-string) | Terraria version |

Using default serialization method
### Message [002]Disconnect

| arg | type | description |
| ----- | ----- | ----- |
| kickMsg | [NetworkText](#Type-NetworkText) | Kick message |

Using default serialization method
### Message [003]SetUserSlot

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#Type-byte) | Remote player ID |

Using default serialization method
### Message [004]PlayerInfo

| arg | type | description |
| ----- | ----- | ----- |
| remoteClient | [byte](#Type-byte) | Remote client ID |
| skinVariant | [byte](#Type-byte) | Skin Variant |
| hair | [byte](#Type-byte) | Hair |
| name | [string](#Type-string) | Name |
| hairDye | [byte](#Type-byte) | Hair Dye |
| hideVisibleAccessory1 | [BitsByte](#Type-BitsByte) | Hide visible accessory part 1 |
| hideVisibleAccessory2 | [BitsByte](#Type-BitsByte) | Hide visible accessory part 2 |
| hideMisc | [byte](#Type-byte) | Hide Misc |
| hairColor | [Color](#Type-Color) | Hair Color |
| skinColor | [Color](#Type-Color) | Skin Color |
| eyeColor | [Color](#Type-Color) | Eye Color |
| shirtColor | [Color](#Type-Color) | Shirt Color |
| underShirtColor | [Color](#Type-Color) | Under Shirt Color |
| pantsColor | [Color](#Type-Color) | Pants Color |
| shoeColor | [Color](#Type-Color) | Shoe Color |
| difficulty | [BitsByte](#Type-BitsByte) | Difficulty |
| gameType | [BitsByte](#Type-BitsByte) | - |
| others | [BitsByte](#Type-BitsByte) | - |

Using default serialization method
### Message [005]PlayerInventorySlot

| arg | type | description |
| ----- | ----- | ----- |
| remoteClient | [byte](#Type-byte) | Remote client ID |
| slotId | [byte](#Type-byte) | Slot ID |
| stack | [short](#Type-short) | Stack |
| prefix | [byte](#Type-byte) | Prefix |
| netId | [short](#Type-short) | Net ID |

Using default serialization method
### Message [006]RequireWorldData

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
### Message [007]WorldInfo

| arg | type | description |
| ----- | ----- | ----- |
| time | [int](#Type-int) | Time |
| worldTime | [BitsByte](#Type-BitsByte) | Day time, blood moon and eclipse |
| moonPhase | [byte](#Type-byte) | Moon Phase |
| maxTilesX | [short](#Type-short) | Max tiles x |
| maxTilesY | [short](#Type-short) | Max tiles y |
| spawnTilesX | [short](#Type-short) | Spawn tiles x |
| spawnTilesY | [short](#Type-short) | Spawn tiles y |
| worldSurface | [short](#Type-short) | World surface |
| rockLayer | [short](#Type-short) | Rock Layer |
| worldId | [int](#Type-int) | World ID |
| worldName | [string](#Type-string) | World Name |
| gameMode | [byte](#Type-byte) | Game Mode |
| uuid | [byte[16]](#Type-byte[16]) | UUID |
| worldGeneratorVersion | [long](#Type-long) | World Generator Version |
| moonType | [byte](#Type-byte) | Moon Type |
| treeBG1 | [byte](#Type-byte) | Tree BG1 |
| treeBG2 | [byte](#Type-byte) | Tree BG2 |
| treeBG3 | [byte](#Type-byte) | Tree BG3 |
| treeBG4 | [byte](#Type-byte) | Tree BG4 |
| corruptBG | [byte](#Type-byte) | Corrupt BG |
| jungleBG | [byte](#Type-byte) | Jungle BG |
| snowBG | [byte](#Type-byte) | Snow BG |
| hallowBG | [byte](#Type-byte) | Hallow BG |
| crimsonBG | [byte](#Type-byte) | Crimson BG |
| desertBG | [byte](#Type-byte) | Desert BG |
| oceanBG | [byte](#Type-byte) | Ocean BG |
| mushroomBG | [byte](#Type-byte) | Mushroom BG |
| underworldBG | [byte](#Type-byte) | Underworld BG |
| iceBackStyle | [byte](#Type-byte) | Ice back style |
| jungleBackStyle | [byte](#Type-byte) | Jungle back style |
| hellBackStyle | [byte](#Type-byte) | Hell back style |
| windSpeedTarget | [float](#Type-float) | Wind speed target |
| numClouds | [byte](#Type-byte) | Clouds amount |
| numClouds | [byte](#Type-byte) | Clouds amount |
| treeX | [int[3]](#Type-int[3]) | Tree x |
| treeStyle | [int[4]](#Type-int[4]) | Tree style |
| caveBackX | [int[3]](#Type-int[3]) | Cave back x |
| caveBackStyle | [int[4]](#Type-int[4]) | Cave back style |
| treeTopsVariations | [int[13]](#Type-int[13]) | Tree tops variations |
| maxRaining | [float](#Type-float) | Max Raining |
| worldState1 | [BitsByte](#Type-BitsByte) | World state part 1 |
| worldState2 | [BitsByte](#Type-BitsByte) | World state part 2 |
| worldState3 | [BitsByte](#Type-BitsByte) | World state part 3 |
| worldState4 | [BitsByte](#Type-BitsByte) | World state part 4 |
| worldState5 | [BitsByte](#Type-BitsByte) | World state part 5 |
| worldState6 | [BitsByte](#Type-BitsByte) | World state part 6 |
| worldState7 | [BitsByte](#Type-BitsByte) | World state part 7 |
| savedOreTiersCopper | [short](#Type-short) | Saved ore tiers copper |
| savedOreTiersIron | [short](#Type-short) | Saved ore tiers Iron |
| savedOreTiersSilver | [short](#Type-short) | Saved ore tiers silver |
| savedOreTiersGold | [short](#Type-short) | Saved ore tiers gold |
| savedOreTiersCobalt | [short](#Type-short) | Saved ore tiers cobalt |
| savedOreTiersMythril | [short](#Type-short) | Saved ore tiers mythril |
| savedOreTiersAdamantite | [short](#Type-short) | Saved ore tiers adamantite |
| invasionType | [sbyte](#Type-sbyte) | Invasion Type |
| lobbyId | [long](#Type-long) | Lobby ID |
| sandstormIntendedSeverity | [float](#Type-float) | Sandstorm Intended Severity |

Using default serialization method
### Message [008]RequestEssentialTiles

| arg | type | description |
| ----- | ----- | ----- |
| x | [int](#Type-int) | Player spawn x |
| y | [int](#Type-int) | Player spawn y |

Using default serialization method
### Message [009]Status

| arg | type | description |
| ----- | ----- | ----- |
| statusMax | [int](#Type-int) | Status only increases |
| statusMax | [NetworkText](#Type-NetworkText) | Status only increases |

Using default serialization method
### Message [010]SendSection

| arg | type | description |
| ----- | ----- | ----- |
| compressed | [bool](#Type-bool) | Terraria version |
| xStart | [int](#Type-int) | - |
| yStart | [int](#Type-int) | - |
| width | [short](#Type-short) | - |
| height | [short](#Type-short) | - |
| tiles | [WorldTile](#Type-WorldTile) | - |
| chestCount | [short](#Type-short) | - |
| chests | [](#Type-) | - |
| signCount | [short](#Type-short) | - |
| signs | [](#Type-) | - |
| tileEntityCount | [short](#Type-short) | - |
| tileEntities | [](#Type-) | - |

Using default serialization method
### Type BitsByte

| field | type | description |
| ----- | ----- | ----- |
| data | [byte](#Type-byte) | Data |

Using default serialization method
### Type Color

| field | type | description |
| ----- | ----- | ----- |
| r | [byte](#Type-byte) | Red |
| g | [byte](#Type-byte) | Red |
| b | [byte](#Type-byte) | Red |

Using default serialization method
### Type NetworkText

| field | type | description |
| ----- | ----- | ----- |
| mode | [byte](#Type-byte) | - |
| text | [string](#Type-string) | - |

Using default serialization method
### Type Tile

| field | type | description |
| ----- | ----- | ----- |
| type | [ushort](#Type-ushort) | - |
| wall | [ushort](#Type-ushort) | - |
| liquid | [byte](#Type-byte) | - |
| sTileHeader | [short](#Type-short) | - |
| bTileHeader | [byte](#Type-byte) | - |
| bTileHeader2 | [byte](#Type-byte) | - |
| bTileHeader3 | [byte](#Type-byte) | - |
| frameX | [short](#Type-short) | - |
| frameY | [short](#Type-short) | - |

Using default serialization method
### Type WorldTile

| field | type | description |
| ----- | ----- | ----- |
| tile | [Tile](#Type-Tile) | - |

Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


----
Generate at 2020/6/9 21:02:46