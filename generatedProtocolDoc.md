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
| torchFlags | [BitsByte](#BitsByte) | - |

Using default serialization method
#### [005]PlayerInventorySlot

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| slotId | [short](#short) | Slot ID |
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
| worldGeneratorVersion | [ulong](#ulong) | World Generator Version |
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
| treeX | [int[3]](#int) | Tree x |
| treeStyle | [byte[4]](#byte) | Tree style |
| caveBackX | [int[3]](#int) | Cave back x |
| caveBackStyle | [byte[4]](#byte) | Cave back style |
| treeTopsVariations | [byte[13]](#byte) | Tree tops variations |
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
| lobbyId | [ulong](#ulong) | Lobby ID |
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
| statusText | [NetworkText](#NetworkText) | - |
| statusTextFlags | [byte](#byte) | - |

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
| chests | [Chest](#Chest) | - |
| signCount | [short](#short) | - |
| signs | [Sign](#Sign) | - |
| tileEntityCount | [short](#short) | - |
| tileEntities | [Entity](#Entity) | - |

Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


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

Serialization: 
```csharp
writer.Write(playerId);
writer.Write(control);
writer.Write(pulley);
writer.Write(misc);
writer.Write(sleepingInfo);
writer.Write(selectedItem);
writer.Write(positionX);
writer.Write(positionY);

if (((uint)pulley & (1 << 2)) > 0U)
{
    writer.Write(velocityX);
    writer.Write(velocityY);
}

if (((uint)misc & (1 << 6)) > 0U)
{
    writer.Write(originalPositionX);
    writer.Write(originalPositionY);
    writer.Write(homePositionX);
    writer.Write(homePositionY);
}
```
Deserialization: 
```csharp
playerId = reader.ReadByte();
control = reader.ReadByte();
pulley = reader.ReadByte();
misc = reader.ReadByte();
sleepingInfo = reader.ReadByte();
selectedItem = reader.ReadByte();
positionX = reader.ReadSingle();
positionY = reader.ReadSingle();

if (((uint)pulley & (1 << 2)) > 0U)
{
    velocityX = reader.ReadSingle();
    velocityY = reader.ReadSingle();
}

if (((uint)misc & (1 << 6)) > 0U)
{
    originalPositionX = reader.ReadSingle();
    originalPositionY = reader.ReadSingle();
    homePositionX = reader.ReadSingle();
    homePositionY = reader.ReadSingle();
}
```


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
| tileX | [short](#short) | - |
| tileY | [short](#short) | - |
| flags1 | [short](#short) | - |
| flags2 | [byte](#byte) | - |

Using default serialization method
#### [018]Time

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| dayTime | [bool](#bool) | - |
| timeValue | [int](#int) | - |
| sunModY | [short](#short) | - |
| moonModY | [short](#short) | - |

Using default serialization method
#### [019]DoorToggle

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| action | [DoorToggleAction:byte](#DoorToggleAction) | - |
| tileX | [short](#short) | - |
| tileY | [short](#short) | - |
| direction | [byte](#byte) | - |

Using default serialization method
#### [020]SendTileSquare

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| size | [ushort](#ushort) | - |
| tileChangeType | [byte](#byte) | - |
| tileX | [short](#short) | - |
| tileY | [short](#short) | - |
| tiles | [WorldTile](#WorldTile) | - |

Using default serialization method
#### [021]UpdateItemDrop

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| itemId | [short](#short) | If below 400 and NetID 0 Then Set NullIf ItemID is 400 Then New Item |
| positionX | [float](#float) | - |
| positionY | [float](#float) | - |
| velocityX | [float](#float) | - |
| velocityY | [float](#float) | - |
| stackSize | [short](#short) | - |
| prefix | [byte](#byte) | - |
| noDelay | [byte](#byte) | If 0 then ownIgnore = 0 and ownTime = 100 |
| itemNetId | [short](#short) | - |

Using default serialization method
#### [022]UpdateItemOwner

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| itemId | [short](#short) | - |
| playerId | [byte](#byte) | Remote player ID |

Using default serialization method
#### [023]NPCUpdate

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| positionX | [float](#float) | - |
| positionY | [float](#float) | - |
| velocityX | [float](#float) | - |
| velocityY | [float](#float) | - |
| target | [ushort](#ushort) | Player ID |
| npcFlags1 | [byte](#byte) | - |
| npcFlags2 | [byte](#byte) | - |
| ai | [AI](#AI) | - |
| npcNetID | [short](#short) | - |
| playerCountForMultiplayerDifficultyOverride | [byte](#byte) | - |
| strengthMultiplier | [float](#float) | - |
| lifeBytes | [byte](#byte) | - |
| life | [Variable](#Variable) | - |
| releaseOwner | [Byte](#Byte) | - |

Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


#### [024]StrikeNPCWithHeldItem

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
|  npcId | [short](#short) | - |
|  playerId | [byte](#byte) | - |

Using default serialization method
#### [025]NULL

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [026]NULL

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [027]ProjectileUpdate

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| projectileId | [short](#short) | - |
| positionX | [float](#float) | - |
| positionY | [float](#float) | - |
| velocityX | [float](#float) | - |
| velocityY | [float](#float) | - |
| owner | [byte](#byte) | Player ID |
| type | [short](#short) | - |
| projFlags | [BitsByte](#BitsByte) | - |
| AI0 | [float](#float) | Only sent if AI[0] flag is true |
| AI1 | [float](#float) | Only sent if AI[1] flag is true |
| Damage | [short](#short) | Only sent if Damage flag is true |
| knockback | [float](#float) | Only sent if Knockback flag is true |
| originalDamage | [short](#short) | Only sent if OriginalDamage flag is true |
| projUUID | [short](#short) | Only sent if ProjUUID flag is true |

Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


#### [028]NPCStrike

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| damage | [short](#short) | -1 = Kill |
| knockback | [float](#float) | - |
| hitDirection | [byte](#byte) | - |
| cirt | [bool](#bool) | - |

Using default serialization method
#### [029]DestroyProjectile

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| projectileId | [short](#short) | - |
| owner | [short](#short) | Player ID |

Using default serialization method
#### [030]TogglePVP

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| owner | [short](#short) | Player ID |
| pvpEnabled | [bool](#bool) | - |

Using default serialization method
#### [031]OpenChest

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| tileX | [short](#short) | - |
| tileY | [short](#short) | - |

Using default serialization method
#### [032]UpdateChestItem

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| chestId | [short](#short) | - |
| itemSlot | [byte](#byte) | - |
| stack | [short](#short) | - |
| prefix | [byte](#byte) | - |
| itemNetId | [short](#short) | - |

Using default serialization method
#### [033]SyncActiveChest

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| chestId | [short](#short) | - |
| chestX | [short](#short) | - |
| chestY | [short](#short) | - |
| nameLength | [byte](#byte) | - |
| chestName | [string](#string) | - |

Using default serialization method
#### [034]PlaceChest

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| action | [PlaceChestAction:byte](#PlaceChestAction) | - |
| tileX | [short](#short) | - |
| tileY | [short](#short) | - |
| style | [short](#short) | - |
| chestIdToDestroy | [short](#short) | - |

Using default serialization method
#### [035]HealEffect

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| healAmount | [short](#short) | - |

Using default serialization method
#### [036]PlayerZone

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| zoneFlags1 | [byte](#byte) | - |
| zoneFlags2 | [byte](#byte) | - |
| zoneFlags3 | [byte](#byte) | - |
| zoneFlags4 | [byte](#byte) | - |

Using default serialization method
#### [037]RequestPassword

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [038]SendPassword

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| password | [string](#string) | - |

Using default serialization method
#### [039]RemoveItemOwner

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| itemIndex | [short](#short) | - |

Using default serialization method
#### [040]SetActiveNPC

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| npcTalkTarget | [short](#short) | - |

Using default serialization method
#### [041]PlayerItemAnimation

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| itemRotation | [float](#float) | - |
| itemAnimation | [short](#short) | - |

Using default serialization method
#### [042]PlayerMana

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| mana | [short](#short) | - |
| maxMana | [short](#short) | - |

Using default serialization method
#### [043]ManaEffect

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| manaAmount | [short](#short) | - |

Using default serialization method
#### [044]NULL

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [045]PlayerTeam

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| team | [byte](#byte) | - |

Using default serialization method
#### [046]RequestSign

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |

Using default serialization method
#### [047]UpdateSign

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| signId | [short](#short) | - |
| x | [short](#short) | - |
| y | [short](#short) | - |
| text | [string](#string) | - |
| playerId | [byte](#byte) | - |
| signFlags | [byte](#byte) | - |

Using default serialization method
#### [048]SetLiquid

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |
| liquid | [byte](#byte) | - |
| liquidType | [byte](#byte) | - |

Using default serialization method
#### [049]CompleteConnectionAndSpawn

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [050]UpdatePlayerBuff

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| buffType | [ushort[22]](#ushort) | - |

Using default serialization method
#### [051]SpecialNPCEffect

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| type | [SpecialNPCEffectType:byte](#SpecialNPCEffectType) | - |

Using default serialization method
#### [052]Unlock

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| type | [UnlockType:byte](#UnlockType) | - |
| x | [short](#short) | - |
| y | [short](#short) | - |

Using default serialization method
#### [053]AddNPCBuff

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| buff | [ushort](#ushort) | - |
| time | [short](#short) | - |

Using default serialization method
#### [054]UpdateNPCBuff

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| buffId1 | [ushort](#ushort) | - |
| time1 | [short](#short) | - |
| buffId2 | [ushort](#ushort) | - |
| time2 | [short](#short) | - |
| buffId3 | [ushort](#ushort) | - |
| time3 | [short](#short) | - |
| buffId4 | [ushort](#ushort) | - |
| time4 | [short](#short) | - |
| buffId5 | [ushort](#ushort) | - |
| time5 | [short](#short) | - |

Using default serialization method
#### [055]AddPlayerBuff

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| buff | [ushort](#ushort) | - |
| time | [int](#int) | - |

Using default serialization method
#### [056]UpdateNPCName

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| name | [string](#string) | - |
| townNpcVariationIndex | [int](#int) | - |

Using default serialization method
#### [057]UpdateGoodEvil

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| good | [byte](#byte) | - |
| evil | [byte](#byte) | - |
| crimson | [byte](#byte) | - |

Using default serialization method
#### [058]PlayMusicItem

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| note | [float](#float) | - |

Using default serialization method
#### [059]HitSwitch

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |

Using default serialization method
#### [060]NPCHomeUpdate

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| homeTileX | [short](#short) | - |
| homeTileY | [short](#short) | - |
| homeless | [byte](#byte) | - |

Using default serialization method
#### [061]SpawnBoxxInvasion

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [short](#short) | - |
| type | [SpawnBossInvasionType:short](#SpawnBossInvasionType) | - |

Using default serialization method
#### [062]PlayerDodge

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| flag | [byte](#byte) | - |

Using default serialization method
#### [063]PaintTile

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |
| color | [byte](#byte) | - |

Using default serialization method
#### [064]PaintWall

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |
| color | [byte](#byte) | - |

Using default serialization method
#### [065]PlayerNPCTeleport

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| flags | [BitsByte](#BitsByte) | - |
| targetId | [short](#short) | - |
| x | [float](#float) | - |
| y | [float](#float) | - |
| style | [byte](#byte) | - |
| extraInfo | [int](#int) | - |

Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


#### [066]HealOtherPlayer

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| healAmount | [short](#short) | - |

Using default serialization method
#### [067]Placeholder

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [068]ClientUUID

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| uuid | [string](#string) | - |

Using default serialization method
#### [069]GetChestName

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| chestId | [short](#short) | - |
| chestX | [short](#short) | - |
| chestY | [short](#short) | - |
| name | [string](#string) | - |

Using default serialization method
#### [070]CatchNPC

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| playerId | [byte](#byte) | - |

Using default serialization method
#### [071]ReleaseNPC

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [int](#int) | - |
| y | [int](#int) | - |
| npcType | [short](#short) | - |
| style | [byte](#byte) | Sent to NPC AI[2] |

Using default serialization method
#### [072]TravellingMerchantInventory

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| items | [short[40]](#short) | Each short related to an item type NetID. |

Using default serialization method
#### [073]TeleportationPotion

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| type | [TeleportationPotionType:byte](#TeleportationPotionType) | - |

Using default serialization method
#### [074]AnglerQuest

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| quest | [byte](#byte) | - |
| completed | [bool](#bool) | - |

Using default serialization method
#### [075]CompleteAnglerQuestToday

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method
#### [076]NumberOfAnglerQuestsCompleted

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| anglerQuestsCompleted | [int](#int) | - |
| golferScore | [int](#int) | - |

Using default serialization method
#### [077]CreateTemporaryAnimation

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| animationType | [short](#short) | - |
| tileType | [ushort](#ushort) | - |
| x | [short](#short) | - |
| y | [short](#short) | - |

Using default serialization method
#### [078]ReportInvasionProgress

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| progress | [int](#int) | - |
| maxProgress | [int](#int) | - |
| icon | [sbyte](#sbyte) | - |
| wave | [sbyte](#sbyte) | - |

Using default serialization method
#### [079]PlaceObject

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |
| type | [short](#short) | - |
| style | [short](#short) | - |
| random | [sbyte](#sbyte) | - |
| direction | [bool](#bool) | - |

Using default serialization method
#### [080]SyncPlayerChestIndex

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| player | [byte](#byte) | - |
| chest | [short](#short) | - |

Using default serialization method
#### [090]UpdateItemDrop2

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| itemId | [short](#short) | If below 400 and NetID 0 Then Set NullIf ItemID is 400 Then New Item |
| positionX | [float](#float) | - |
| positionY | [float](#float) | - |
| velocityX | [float](#float) | - |
| velocityY | [float](#float) | - |
| stackSize | [short](#short) | - |
| prefix | [byte](#byte) | - |
| noDelay | [byte](#byte) | If 0 then ownIgnore = 0 and ownTime = 100 |
| itemNetId | [short](#short) | - |

Using default serialization method
### Inner enum definations
#### DoorToggleAction

| value | description |
| ----- | ----- |
| [OpenDoor](#OpenDoor) | - |
| [CloseDoor](#CloseDoor) | - |
| [OpenTrapdoor](#OpenTrapdoor) | - |
| [CloseTrapdoor](#CloseTrapdoor) | - |
| [OpenTallGate](#OpenTallGate) | - |
| [CloseTallGate](#CloseTallGate) | - |

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
| [KillTile2](#KillTile2) | - |
| [ReplaceTile](#ReplaceTile) | - |
| [ReplaceWall](#ReplaceWall) | - |
| [SlopePoundTile](#SlopePoundTile) | - |

#### NetworkTextMode

| value | description |
| ----- | ----- |
| [Literal](#Literal) | - |
| [Formattable](#Formattable) | - |
| [LocalizationKey](#LocalizationKey) | - |

#### PlaceChestAction

| value | description |
| ----- | ----- |
| [PlaceChest](#PlaceChest) | - |
| [KillChest](#KillChest) | - |
| [PlaceDresser](#PlaceDresser) | - |
| [KillDresser](#KillDresser) | - |
| [PlaceContainers2](#PlaceContainers2) | - |
| [Killontainers2](#Killontainers2) | - |

#### PlayerSpawnContext

| value | description |
| ----- | ----- |
| [ReviveFromDeath](#ReviveFromDeath) | - |
| [SpawningIntoWorld](#SpawningIntoWorld) | - |
| [RecallFromItem](#RecallFromItem) | - |

#### SpawnBossInvasionType

| value | description |
| ----- | ----- |
| [GoblinInvasion = -1](#GoblinInvasion = -1) | - |
| [FrostInvasion = -2](#FrostInvasion = -2) | - |
| [PirateInvasion = -3](#PirateInvasion = -3) | - |
| [PumpkinMoon = -4](#PumpkinMoon = -4) | - |
| [SnowMoon = -5](#SnowMoon = -5) | - |
| [Eclipse = -6](#Eclipse = -6) | - |
| [MartianMoon = -7](#MartianMoon = -7) | - |
| [ImpendingDoom = -8](#ImpendingDoom = -8) | - |
| [BloodMoon = -10](#BloodMoon = -10) | - |
| [CombatBookUsed = -11](#CombatBookUsed = -11) | - |
| [BoughtCat = -12](#BoughtCat = -12) | - |
| [BoughtDog = -13](#BoughtDog = -13) | - |
| [BoughtBunny = -14](#BoughtBunny = -14) | - |

#### SpecialNPCEffectType

| value | description |
| ----- | ----- |
| [SpawnSkeletron](#SpawnSkeletron) | - |
| [CauseSoundAtPlayer](#CauseSoundAtPlayer) | - |
| [StartSundialing](#StartSundialing) | - |
| [BigMimcSpawnSmoke](#BigMimcSpawnSmoke) | - |

#### TeleportationPotionType

| value | description |
| ----- | ----- |
| [TeleportationPotion](#TeleportationPotion) | - |
| [MagicConch](#MagicConch) | - |
| [DemonConch](#DemonConch) | - |

#### UnlockType

| value | description |
| ----- | ----- |
| [ChestUnlock](#ChestUnlock) | - |
| [DoorUnlock](#DoorUnlock) | - |

### Inner type definations
#### AI

| field | type | description |
| ----- | ----- | ----- |


Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


#### BitsByte

| field | type | description |
| ----- | ----- | ----- |
| data | [byte](#byte) | Data |

Using default serialization method
#### Chest

| field | type | description |
| ----- | ----- | ----- |


Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


#### Color

| field | type | description |
| ----- | ----- | ----- |
| r | [byte](#byte) | Red |
| g | [byte](#byte) | Red |
| b | [byte](#byte) | Red |

Using default serialization method
#### Entity

| field | type | description |
| ----- | ----- | ----- |


Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


#### NetworkText

| field | type | description |
| ----- | ----- | ----- |
| mode | [NetworkTextMode:byte](#NetworkTextMode) | - |
| text | [string](#string) | - |
| substitution | [NetworkText[0]](#NetworkText) | - |

Serialization: 
```csharp
writer.Write((byte)mode);
writer.Write(text);
if (mode == NetworkTextMode.Literal)
    return;
writer.Write((byte)substitution.Length);
for (int index = 0; index < (substitution.Length & byte.MaxValue); ++index)
    substitution[index].OnSerialize(writer);
```
Deserialization: 
```csharp
mode = (NetworkTextMode)reader.ReadByte();
text = reader.ReadString();
if (mode == NetworkTextMode.Literal)
    return;
substitution = new NetworkText[reader.ReadByte()];
for (int index = 0; index < substitution.Length; ++index)
{
    substitution[index] = new NetworkText();
    substitution[index].OnDeserialize(reader);
}
```


#### Sign

| field | type | description |
| ----- | ----- | ----- |


Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


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
#### Variable

| field | type | description |
| ----- | ----- | ----- |


Serialization: 
```csharp
throw new NotImplementedException();
```
Deserialization: 
```csharp
throw new NotImplementedException();
```


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
Generate at 2020/6/10 1:16:33