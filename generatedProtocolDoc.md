## Terraria protocol
#### [000]UNKNOWN

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [001]ConnectRequest

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| version | [string](#string) | Terraria version |

Using default serialization method
#### [002]Disconnect

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| kickMsg | [NetworkText](#NetworkText) | Kick message |

Using default serialization method
#### [003]SetUserSlot

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |

Using default serialization method
#### [004]PlayerInfo

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| skinVariant | [byte](#byte) | Skin Variant |
| hair | [byte](#byte) | Hair |
| name | [string](#string) | Name |
| hairDye | [byte](#byte) | Hair Dye |
| hideVisibleAccessory1 | [BitsByte](#BitsByte) | Hide visible accessory part 1 |
| hideVisibleAccessory2 | [BitsByte](#BitsByte) | Hide visible accessory part 2 |
| hideMisc | [byte](#byte) | Hide Misc |
| hairColor | [Color](#Color) | Hair Color |
| skinColor | [Color](#Color) | Skin Color |
| eyeColor | [Color](#Color) | Eye Color |
| shirtColor | [Color](#Color) | Shirt Color |
| underShirtColor | [Color](#Color) | Under Shirt Color |
| pantsColor | [Color](#Color) | Pants Color |
| shoeColor | [Color](#Color) | Shoe Color |
| difficulty | [BitsByte](#BitsByte) | Difficulty |
| gameType | [BitsByte](#BitsByte) | - |
| others | [BitsByte](#BitsByte) | - |

Using default serialization method
#### [005]PlayerInventorySlot

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| slotId | [byte](#byte) | Slot ID |
| stack | [short](#short) | Stack |
| prefix | [byte](#byte) | Prefix |
| netId | [short](#short) | Net ID |

Using default serialization method
#### [006]RequireWorldData

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [007]WorldInfo

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| time | [int](#int) | Time |
| worldTime | [BitsByte](#BitsByte) | Day time, blood moon and eclipse |
| moonPhase | [byte](#byte) | Moon Phase |
| maxTilesX | [short](#short) | Max tiles x |
| maxTilesY | [short](#short) | Max tiles y |
| spawnTilesX | [short](#short) | Spawn tiles x |
| spawnTilesY | [short](#short) | Spawn tiles y |
| worldSurface | [short](#short) | World surface |
| rockLayer | [short](#short) | Rock Layer |
| worldId | [int](#int) | World ID |
| worldName | [string](#string) | World Name |
| gameMode | [byte](#byte) | Game Mode |
| uuid | [byte[16]](#byte) | UUID |
| worldGeneratorVersion | [long](#long) | World Generator Version |
| moonType | [byte](#byte) | Moon Type |
| treeBG1 | [byte](#byte) | Tree BG1 |
| treeBG2 | [byte](#byte) | Tree BG2 |
| treeBG3 | [byte](#byte) | Tree BG3 |
| treeBG4 | [byte](#byte) | Tree BG4 |
| corruptBG | [byte](#byte) | Corrupt BG |
| jungleBG | [byte](#byte) | Jungle BG |
| snowBG | [byte](#byte) | Snow BG |
| hallowBG | [byte](#byte) | Hallow BG |
| crimsonBG | [byte](#byte) | Crimson BG |
| desertBG | [byte](#byte) | Desert BG |
| oceanBG | [byte](#byte) | Ocean BG |
| mushroomBG | [byte](#byte) | Mushroom BG |
| underworldBG | [byte](#byte) | Underworld BG |
| iceBackStyle | [byte](#byte) | Ice back style |
| jungleBackStyle | [byte](#byte) | Jungle back style |
| hellBackStyle | [byte](#byte) | Hell back style |
| windSpeedTarget | [float](#float) | Wind speed target |
| numClouds | [byte](#byte) | Clouds amount |
| numClouds | [byte](#byte) | Clouds amount |
| treeX | [int[3]](#int) | Tree x |
| treeStyle | [int[4]](#int) | Tree style |
| caveBackX | [int[3]](#int) | Cave back x |
| caveBackStyle | [int[4]](#int) | Cave back style |
| treeTopsVariations | [int[13]](#int) | Tree tops variations |
| maxRaining | [float](#float) | Max Raining |
| worldState1 | [BitsByte](#BitsByte) | World state part 1 |
| worldState2 | [BitsByte](#BitsByte) | World state part 2 |
| worldState3 | [BitsByte](#BitsByte) | World state part 3 |
| worldState4 | [BitsByte](#BitsByte) | World state part 4 |
| worldState5 | [BitsByte](#BitsByte) | World state part 5 |
| worldState6 | [BitsByte](#BitsByte) | World state part 6 |
| worldState7 | [BitsByte](#BitsByte) | World state part 7 |
| savedOreTiersCopper | [short](#short) | Saved ore tiers copper |
| savedOreTiersIron | [short](#short) | Saved ore tiers Iron |
| savedOreTiersSilver | [short](#short) | Saved ore tiers silver |
| savedOreTiersGold | [short](#short) | Saved ore tiers gold |
| savedOreTiersCobalt | [short](#short) | Saved ore tiers cobalt |
| savedOreTiersMythril | [short](#short) | Saved ore tiers mythril |
| savedOreTiersAdamantite | [short](#short) | Saved ore tiers adamantite |
| invasionType | [sbyte](#sbyte) | Invasion Type |
| lobbyId | [long](#long) | Lobby ID |
| sandstormIntendedSeverity | [float](#float) | Sandstorm Intended Severity |

Using default serialization method
#### [008]RequestEssentialTiles

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [int](#int) | Player spawn x |
| y | [int](#int) | Player spawn y |

Using default serialization method
#### [009]Status

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| statusMax | [int](#int) | Status only increases |
| statusMax | [NetworkText](#NetworkText) | Status only increases |

Using default serialization method
#### [010]SendSection

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| compressed | [bool](#bool) | Terraria version |
| xStart | [int](#int) | - |
| yStart | [int](#int) | - |
| width | [short](#short) | - |
| height | [short](#short) | - |
| tiles | [WorldTile](#WorldTile) | - |
| chestCount | [short](#short) | - |
| chests | [](#) | - |
| signCount | [short](#short) | - |
| signs | [](#) | - |
| tileEntityCount | [short](#short) | - |
| tileEntities | [](#) | - |

Using default serialization method
#### [011]SectionTileFrame

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| startX | [short](#short) | - |
| startY | [short](#short) | - |
| endX | [short](#short) | - |
| endY | [short](#short) | - |

Using default serialization method
#### [012]SpawnPlayer

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| spawnX | [short](#short) | - |
| spawnY | [short](#short) | - |
| respawnTimeRemain | [int](#int) | - |
| playerSpawnContext | [PlayerSpawnContext:byte](#PlayerSpawnContext) | - |

Using default serialization method
#### [013]UpdatePlayer

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| control | [byte](#byte) | - |
| pulley | [byte](#byte) | - |
| misc | [byte](#byte) | - |
| sleepingInfo | [byte](#byte) | - |
| selectedItem | [byte](#byte) | - |
| positionX | [float](#float) | - |
| positionY | [float](#float) | - |
| velocityX | [float](#float) | - |
| velocityY | [float](#float) | - |
| originalPositionX | [float](#float) | - |
| originalPositionY | [float](#float) | - |
| homePositionX | [float](#float) | - |
| homePositionY | [float](#float) | - |

Using default serialization method
#### [014]PlayerActive

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| active | [bool](#bool) | - |

Using default serialization method
#### [015]NULL

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [016]PlayerHP

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| hp | [short](#short) | - |
| maxHp | [short](#short) | - |

Using default serialization method
#### [017]ModifyTile

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| action | [ModifyTileAction:byte](#ModifyTileAction) | - |
| hp | [short](#short) | - |
| maxHp | [short](#short) | - |

Using default serialization method
### Inner enum definations
#### ModifyTileAction

| value | description |
| ----- | ----- |
| [KillTile](#KillTile) | - |
| [PlaceTile](#PlaceTile) | - |
| [KillWall](#KillWall) | - |
| [PlaceWall](#PlaceWall) | - |
| [KillTileNoItem](#KillTileNoItem) | - |
| [PlaceWire](#PlaceWire) | - |
| [KillWire](#KillWire) | - |
| [PoundTile](#PoundTile) | - |
| [PlaceActuator](#PlaceActuator) | - |
| [KillActuator](#KillActuator) | - |
| [PlaceWire2](#PlaceWire2) | - |
| [KillWire2](#KillWire2) | - |
| [PlaceWire3](#PlaceWire3) | - |
| [KillWire3](#KillWire3) | - |
| [SlopeTile](#SlopeTile) | - |
| [FrameTrack](#FrameTrack) | - |
| [PlaceWire4](#PlaceWire4) | - |
| [KillWire4](#KillWire4) | - |
| [PokeLogicGate](#PokeLogicGate) | - |
| [Actuate](#Actuate) | - |
| [KillTile](#KillTile) | - |
| [ReplaceTile](#ReplaceTile) | - |
| [ReplaceWall](#ReplaceWall) | - |
| [SlopePoundTile](#SlopePoundTile) | - |

#### PlayerSpawnContext

| value | description |
| ----- | ----- |
| [ReviveFromDeath](#ReviveFromDeath) | - |
| [SpawningIntoWorld](#SpawningIntoWorld) | - |
| [RecallFromItem](#RecallFromItem) | - |

### Inner type definations
#### BitsByte

| field | type | description |
| ----- | ----- | ----- |
| data | [byte](#byte) | Data |

Using default serialization method
#### Color

| field | type | description |
| ----- | ----- | ----- |
| r | [byte](#byte) | Red |
| g | [byte](#byte) | Red |
| b | [byte](#byte) | Red |

Using default serialization method
#### NetworkText

| field | type | description |
| ----- | ----- | ----- |
| mode | [byte](#byte) | - |
| text | [string](#string) | - |

Using default serialization method
#### Tile

| field | type | description |
| ----- | ----- | ----- |
| type | [ushort](#ushort) | - |
| wall | [ushort](#ushort) | - |
| liquid | [byte](#byte) | - |
| sTileHeader | [short](#short) | - |
| bTileHeader | [byte](#byte) | - |
| bTileHeader2 | [byte](#byte) | - |
| bTileHeader3 | [byte](#byte) | - |
| frameX | [short](#short) | - |
| frameY | [short](#short) | - |

Using default serialization method
#### WorldTile

| field | type | description |
| ----- | ----- | ----- |
| tile | [Tile](#Tile) | - |

Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


----
Generate at 2020/6/9 22:05:41