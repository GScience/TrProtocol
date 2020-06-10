## Terraria protocol
#### [000]UNKNOWN

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
#### [001]ConnectRequest

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| version | [string](#string) | Terraria version |

Using default serialization method

Methods: 
#### [002]Disconnect

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| kickMsg | [NetworkText](#NetworkText) | Kick message |

Using default serialization method

Methods: 
#### [003]SetUserSlot

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |

Using default serialization method

Methods: 
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

Methods: 
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

Methods: 
#### [006]RequireWorldData

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
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

Methods: 
#### [008]RequestEssentialTiles

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [int](#int) | Player spawn x |
| y | [int](#int) | Player spawn y |

Using default serialization method

Methods: 
#### [009]Status

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| statusMax | [int](#int) | Status only increases |
| statusText | [NetworkText](#NetworkText) | - |
| statusTextFlags | [byte](#byte) | - |

Using default serialization method

Methods: 
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



Methods: 
#### [011]SectionTileFrame

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| startX | [short](#short) | - |
| startY | [short](#short) | - |
| endX | [short](#short) | - |
| endY | [short](#short) | - |

Using default serialization method

Methods: 
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

Methods: 
#### [013]UpdatePlayer

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| control | [byte](#byte) | - |
| pulley | [BitsByte](#BitsByte) | - |
| misc | [BitsByte](#BitsByte) | - |
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
pulley.OnSerialize(writer);
misc.OnSerialize(writer);
writer.Write(sleepingInfo);
writer.Write(selectedItem);
writer.Write(positionX);
writer.Write(positionY);

if (pulley[2])
{
    writer.Write(velocityX);
    writer.Write(velocityY);
}

if (misc[6])
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
pulley.OnDeserialize(reader);
misc.OnDeserialize(reader);
sleepingInfo = reader.ReadByte();
selectedItem = reader.ReadByte();
positionX = reader.ReadSingle();
positionY = reader.ReadSingle();

if (pulley[2])
{
    velocityX = reader.ReadSingle();
    velocityY = reader.ReadSingle();
}

if (misc[6])
{
    originalPositionX = reader.ReadSingle();
    originalPositionY = reader.ReadSingle();
    homePositionX = reader.ReadSingle();
    homePositionY = reader.ReadSingle();
}
```



Methods: 
#### [014]PlayerActive

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| active | [bool](#bool) | - |

Using default serialization method

Methods: 
#### [015]NULL

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
#### [016]PlayerHP

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | Remote player ID |
| hp | [short](#short) | - |
| maxHp | [short](#short) | - |

Using default serialization method

Methods: 
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

Methods: 
#### [018]Time

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| dayTime | [bool](#bool) | - |
| timeValue | [int](#int) | - |
| sunModY | [short](#short) | - |
| moonModY | [short](#short) | - |

Using default serialization method

Methods: 
#### [019]DoorToggle

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| action | [DoorToggleAction:byte](#DoorToggleAction) | - |
| tileX | [short](#short) | - |
| tileY | [short](#short) | - |
| direction | [byte](#byte) | - |

Using default serialization method

Methods: 
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

Methods: 
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

Methods: 
#### [022]UpdateItemOwner

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| itemId | [short](#short) | - |
| playerId | [byte](#byte) | Remote player ID |

Using default serialization method

Methods: 
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
| npcFlags1 | [BitsByte](#BitsByte) | - |
| npcFlags2 | [BitsByte](#BitsByte) | - |
| ai | [float[4]](#float) | - |
| npcNetID | [short](#short) | - |
| playerCountForMultiplayerDifficultyOverride | [byte](#byte) | - |
| strengthMultiplier | [float](#float) | - |
| lifeBytes | [byte](#byte) | - |
| life | [int](#int) | - |
| releaseOwner | [byte](#byte) | - |
| catchable | [bool](#bool) | - |

Serialization: 
```csharp
writer.Write(npcId);
writer.Write(positionX);
writer.Write(positionY);
writer.Write(velocityX);
writer.Write(velocityY);
writer.Write(target);
npcFlags1.OnSerialize(writer);
npcFlags2.OnSerialize(writer);
for (var i = 0; i < 4; ++i)
    if (npcFlags1[i + 2])
        writer.Write(ai[i]);
writer.Write(npcNetID);
if (npcFlags2[0])
    writer.Write(playerCountForMultiplayerDifficultyOverride);
if (npcFlags2[2])
    writer.Write(strengthMultiplier);
if (!npcFlags1[7])
{
    writer.Write(lifeBytes);
    switch (lifeBytes)
    {
        case 2:
            writer.Write((short)life);
            break;
        case 4:
            writer.Write(life);
            break;
        default:
            writer.Write((sbyte)life);
            break;
    }
}
if (catchable)
    writer.Write(releaseOwner);
```
Deserialization: 
```csharp
npcId = reader.ReadInt16();
positionX = reader.ReadSingle();
positionY = reader.ReadSingle();
velocityX = reader.ReadSingle();
velocityY = reader.ReadSingle();
target = reader.ReadUInt16();
npcFlags1.OnDeserialize(reader);
npcFlags2.OnDeserialize(reader);
for (var i = 0; i < 4; ++i)
    if (npcFlags1[i + 2])
        ai[i] = reader.ReadSingle();
npcNetID = reader.ReadInt16();
if (npcFlags2[0])
    playerCountForMultiplayerDifficultyOverride = reader.ReadByte();
if (npcFlags2[2])
    strengthMultiplier = reader.ReadSingle();
if (!npcFlags1[7])
{
    lifeBytes = reader.ReadByte();
    switch (lifeBytes)
    {
        case 2:
            life = reader.ReadInt16();
            break;
        case 4:
            life = reader.ReadInt32();
            break;
        default:
            life = reader.ReadSByte();
            break;
    }
}
try
{
    releaseOwner = reader.ReadByte();
    catchable = true;
}
catch (EndOfStreamException)
{
    catchable = false;
}
```



Methods: 
#### [024]StrikeNPCWithHeldItem

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
|  npcId | [short](#short) | - |
|  playerId | [byte](#byte) | - |

Using default serialization method

Methods: 
#### [025]NULL

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
#### [026]NULL

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
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
writer.Write(projectileId);
writer.Write(positionX);
writer.Write(positionY);
writer.Write(velocityX);
writer.Write(velocityY);
writer.Write(owner);
writer.Write(type);
projFlags.OnSerialize(writer);
if (projFlags[0])
    writer.Write(AI0);
if (projFlags[1])
    writer.Write(AI1);
if (projFlags[4])
    writer.Write(Damage);
if (projFlags[5])
    writer.Write(knockback);
if (projFlags[6])
    writer.Write(originalDamage);
if (projFlags[7])
    writer.Write(projUUID);
```
Deserialization: 
```csharp
projectileId = reader.ReadInt16();
positionX = reader.ReadSingle();
positionY = reader.ReadSingle();
velocityX = reader.ReadSingle();
velocityY = reader.ReadSingle();
owner = reader.ReadByte();
type = reader.ReadInt16();
projFlags.OnDeserialize(reader);
if (projFlags[0])
    AI0 = reader.ReadSingle();
if (projFlags[1])
    AI1 = reader.ReadSingle();
if (projFlags[4])
    Damage = reader.ReadInt16();
if (projFlags[5])
    knockback = reader.ReadSingle();
if (projFlags[6])
    originalDamage = reader.ReadInt16();
if (projFlags[7])
    projUUID = reader.ReadInt16();
```



Methods: 
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

Methods: 
#### [029]DestroyProjectile

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| projectileId | [short](#short) | - |
| owner | [byte](#byte) | Player ID |

Using default serialization method

Methods: 
#### [030]TogglePVP

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| owner | [short](#short) | Player ID |
| pvpEnabled | [bool](#bool) | - |

Using default serialization method

Methods: 
#### [031]OpenChest

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| tileX | [short](#short) | - |
| tileY | [short](#short) | - |

Using default serialization method

Methods: 
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

Methods: 
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

Methods: 
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

Methods: 
#### [035]HealEffect

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| healAmount | [short](#short) | - |

Using default serialization method

Methods: 
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

Methods: 
#### [037]RequestPassword

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
#### [038]SendPassword

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| password | [string](#string) | - |

Using default serialization method

Methods: 
#### [039]RemoveItemOwner

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| itemIndex | [short](#short) | - |

Using default serialization method

Methods: 
#### [040]SetActiveNPC

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| npcTalkTarget | [short](#short) | - |

Using default serialization method

Methods: 
#### [041]PlayerItemAnimation

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| itemRotation | [float](#float) | - |
| itemAnimation | [short](#short) | - |

Using default serialization method

Methods: 
#### [042]PlayerMana

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| mana | [short](#short) | - |
| maxMana | [short](#short) | - |

Using default serialization method

Methods: 
#### [043]ManaEffect

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| manaAmount | [short](#short) | - |

Using default serialization method

Methods: 
#### [044]NULL

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
#### [045]PlayerTeam

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| team | [byte](#byte) | - |

Using default serialization method

Methods: 
#### [046]RequestSign

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |

Using default serialization method

Methods: 
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

Methods: 
#### [048]SetLiquid

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |
| liquid | [byte](#byte) | - |
| liquidType | [byte](#byte) | - |

Using default serialization method

Methods: 
#### [049]CompleteConnectionAndSpawn

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
#### [050]UpdatePlayerBuff

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| buffType | [ushort[22]](#ushort) | - |

Using default serialization method

Methods: 
#### [051]SpecialNPCEffect

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| type | [SpecialNPCEffectType:byte](#SpecialNPCEffectType) | - |

Using default serialization method

Methods: 
#### [052]Unlock

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| type | [UnlockType:byte](#UnlockType) | - |
| x | [short](#short) | - |
| y | [short](#short) | - |

Using default serialization method

Methods: 
#### [053]AddNPCBuff

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| buff | [ushort](#ushort) | - |
| time | [short](#short) | - |

Using default serialization method

Methods: 
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

Methods: 
#### [055]AddPlayerBuff

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| buff | [ushort](#ushort) | - |
| time | [int](#int) | - |

Using default serialization method

Methods: 
#### [056]UpdateNPCName

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| name | [string](#string) | - |
| townNpcVariationIndex | [int](#int) | - |

Serialization: 
```csharp
writer.Write(npcId);
if (Side == Side.Client)
{
}
else if (Side == Side.Server)
{
    writer.Write(name);
    writer.Write(townNpcVariationIndex);
}
else
{
    throw new Exception("Unknown side");
}
```
Deserialization: 
```csharp
npcId = reader.ReadInt16();
if (Side == Side.Client)
{
}
else if (Side == Side.Server)
{
    name = reader.ReadString();
    townNpcVariationIndex = reader.ReadInt32();
}
else
{
    throw new Exception("Unknown side");
}
```



Methods: 
#### [057]UpdateGoodEvil

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| good | [byte](#byte) | - |
| evil | [byte](#byte) | - |
| crimson | [byte](#byte) | - |

Using default serialization method

Methods: 
#### [058]PlayMusicItem

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| note | [float](#float) | - |

Using default serialization method

Methods: 
#### [059]HitSwitch

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |

Using default serialization method

Methods: 
#### [060]NPCHomeUpdate

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| homeTileX | [short](#short) | - |
| homeTileY | [short](#short) | - |
| homeless | [byte](#byte) | - |

Using default serialization method

Methods: 
#### [061]SpawnBoxxInvasion

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [short](#short) | - |
| type | [SpawnBossInvasionType:short](#SpawnBossInvasionType) | - |

Using default serialization method

Methods: 
#### [062]PlayerDodge

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| flag | [byte](#byte) | - |

Using default serialization method

Methods: 
#### [063]PaintTile

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |
| color | [byte](#byte) | - |

Using default serialization method

Methods: 
#### [064]PaintWall

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [short](#short) | - |
| y | [short](#short) | - |
| color | [byte](#byte) | - |

Using default serialization method

Methods: 
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



Methods: 
#### [066]HealOtherPlayer

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| healAmount | [short](#short) | - |

Using default serialization method

Methods: 
#### [067]Placeholder

##### Server  *  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
#### [068]ClientUUID

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| uuid | [string](#string) | - |

Using default serialization method

Methods: 
#### [069]GetChestName

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| chestId | [short](#short) | - |
| chestX | [short](#short) | - |
| chestY | [short](#short) | - |
| name | [string](#string) | - |

Using default serialization method

Methods: 
#### [070]CatchNPC

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| npcId | [short](#short) | - |
| playerId | [byte](#byte) | - |

Using default serialization method

Methods: 
#### [071]ReleaseNPC

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| x | [int](#int) | - |
| y | [int](#int) | - |
| npcType | [short](#short) | - |
| style | [byte](#byte) | Sent to NPC AI[2] |

Using default serialization method

Methods: 
#### [072]TravellingMerchantInventory

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| items | [short[40]](#short) | Each short related to an item type NetID. |

Using default serialization method

Methods: 
#### [073]TeleportationPotion

##### Server <-> Client

| arg | type | description |
| ----- | ----- | ----- |
| type | [TeleportationPotionType:byte](#TeleportationPotionType) | - |

Using default serialization method

Methods: 
#### [074]AnglerQuest

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| quest | [byte](#byte) | - |
| completed | [bool](#bool) | - |

Using default serialization method

Methods: 
#### [075]CompleteAnglerQuestToday

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |


Using default serialization method

Methods: 
#### [076]NumberOfAnglerQuestsCompleted

##### Server <-  Client

| arg | type | description |
| ----- | ----- | ----- |
| playerId | [byte](#byte) | - |
| anglerQuestsCompleted | [int](#int) | - |
| golferScore | [int](#int) | - |

Using default serialization method

Methods: 
#### [077]CreateTemporaryAnimation

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| animationType | [short](#short) | - |
| tileType | [ushort](#ushort) | - |
| x | [short](#short) | - |
| y | [short](#short) | - |

Using default serialization method

Methods: 
#### [078]ReportInvasionProgress

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| progress | [int](#int) | - |
| maxProgress | [int](#int) | - |
| icon | [sbyte](#sbyte) | - |
| wave | [sbyte](#sbyte) | - |

Using default serialization method

Methods: 
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

Methods: 
#### [080]SyncPlayerChestIndex

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| player | [byte](#byte) | - |
| chest | [short](#short) | - |

Using default serialization method

Methods: 
#### [082]NetModule

##### Server  -> Client

| arg | type | description |
| ----- | ----- | ----- |
| moduleId | [short](#short) | - |
| moduleValue | [Dictionary<string, object>](#Dictionary<string, object>) | - |

Serialization: 
```csharp
writer.Write(moduleId);
switch (moduleId)
{
    case 0:
        WriteLiquidModule(writer);
        break;
    case 1:
        WriteTextModule(writer);
        break;
    case 2:
        WritePingModule(writer);
        break;
    case 3:
        WriteAmbienceModule(writer);
        break;
    case 4:
        WriteBestiaryModule(writer);
        break;
    case 5:
    case 6:
    case 7:
        throw new NotImplementedException();
    case 8:
        WriteTeleportPylonModule(writer);
        break;
    case 9:
        WriteParticlesModule(writer);
        break;
    case 10:
        throw new NotImplementedException();
}
```
Deserialization: 
```csharp
moduleId = reader.ReadInt16();
switch (moduleId)
{
    case 0:
        ReadLiquidModule(reader);
        break;
    case 1:
        ReadTextModule(reader);
        break;
    case 2:
        ReadPingModule(reader);
        break;
    case 3:
        ReadAmbienceModule(reader);
        break;
    case 4:
        ReadBestiaryModule(reader);
        break;
    case 5:
    case 6:
    case 7:
        throw new NotImplementedException();
    case 8:
        ReadTeleportPylonModule(reader);
        break;
    case 9:
        ReadParticlesModule(reader);
        break;
    case 10:
        throw new NotImplementedException();
}
```



Methods: 
```csharp
private void ReadAmbienceModule(BinaryReader reader)
{
    moduleValue.Clear();
    moduleValue["playerId"] = reader.ReadByte();
    moduleValue["random"] = reader.ReadInt32();
    moduleValue["type"] = reader.ReadByte();
}
```

```csharp
private void WriteAmbienceModule(BinaryWriter writer)
{
    writer.Write((byte)moduleValue["playerId"]);
    writer.Write((int)moduleValue["random"]);
    writer.Write((byte)moduleValue["type"]);
}
```

```csharp
private void ReadBestiaryModule(BinaryReader reader)
{
    moduleValue.Clear();
    var type = reader.ReadByte();
    moduleValue["type"] = type;
    switch (type)
    {
        case 0:
            moduleValue["npcId"] = reader.ReadInt16();
            moduleValue["killCount"] = reader.ReadUInt16();
            break;
        case 1:
            moduleValue["wasSeen"] = reader.ReadInt16();
            break;
        case 2:
            moduleValue["wasChatWith"] = reader.ReadInt16();
            break;
    }
}
```

```csharp
private void WriteBestiaryModule(BinaryWriter writer)
{
    var type = (byte)moduleValue["type"];
    writer.Write(type);
    switch (type)
    {
        case 0:
            writer.Write((short)moduleValue["npcId"]);
            writer.Write((ushort)moduleValue["killCount"]);
            break;
        case 1:
            writer.Write((short)moduleValue["wasSeen"]);
            break;
        case 2:
            writer.Write((short)moduleValue["wasChatWith"]);
            break;
    }
}
```

```csharp
private void ReadCreativePowerPermissionsModule(BinaryReader reader)
{
    moduleValue.Clear();
    moduleValue["type"] = reader.ReadByte();
    moduleValue["powerId"] = reader.ReadUInt16();
    moduleValue["level"] = reader.ReadByte();
}
```

```csharp
private void WriteCreativePowerPermissionsModule(BinaryWriter writer)
{
    writer.Write((byte)moduleValue["type"]);
    writer.Write((ushort)moduleValue["powerId"]);
    writer.Write((byte)moduleValue["level"]);
}
```

```csharp
private void ReadLiquidModule(BinaryReader reader)
{
    var count = reader.ReadUInt16();
    var changes = new List<Tuple<int, ushort, ushort>>(); 
    for (var i = 0; i < count; ++i)
    {
        var change = reader.ReadInt32();
        var liquid = reader.ReadUInt16();
        var liquidType = reader.ReadUInt16();
        changes.Add(new Tuple<int, ushort, ushort>(change, liquid, liquidType));
    }
    moduleValue["changes"] = changes;
}
```

```csharp
private void WriteLiquidModule(BinaryWriter writer)
{
    var changes = (List<Tuple<int, ushort, ushort>>)moduleValue["changes"];
    writer.Write((ushort)changes.Count);
    foreach (var change in changes)
    {
        writer.Write(change.Item1);
        writer.Write(change.Item2);
        writer.Write(change.Item3);
    }
}
```

```csharp
private void ReadParticlesModule(BinaryReader reader)
{
    moduleValue.Clear();
    moduleValue["particleType"] = reader.ReadByte();
    moduleValue["positionInWorldX"] = reader.ReadSingle();
    moduleValue["positionInWorldY"] = reader.ReadSingle();
    moduleValue["movementVectorX"] = reader.ReadSingle();
    moduleValue["movementVectorY"] = reader.ReadSingle();
    moduleValue["packedShaderIndex"] = reader.ReadInt32();
    moduleValue["indexOfPlayerWhoInvokedThis"] = reader.ReadByte();
}
```

```csharp
private void WriteParticlesModule(BinaryWriter writer)
{
    writer.Write((byte)moduleValue["particleType"]);
    writer.Write((float)moduleValue["positionInWorldX"]);
    writer.Write((float)moduleValue["positionInWorldY"]);
    writer.Write((float)moduleValue["movementVectorX"]);
    writer.Write((float)moduleValue["movementVectorY"]);
    writer.Write((int)moduleValue["packedShaderIndex"]);
    writer.Write((byte)moduleValue["indexOfPlayerWhoInvokedThis"]);
}
```

```csharp
private void ReadPingModule(BinaryReader reader)
{
    moduleValue.Clear();
    moduleValue["positionX"] = reader.ReadSingle();
    moduleValue["positionY"] = reader.ReadSingle();
}
```

```csharp
private void WritePingModule(BinaryWriter writer)
{
    writer.Write((float)moduleValue["positionX"]);
    writer.Write((float)moduleValue["positionY"]);
}
```

```csharp
private void ReadTeleportPylonModule(BinaryReader reader)
{
    moduleValue.Clear();
    moduleValue["packetType"] = reader.ReadByte();
    moduleValue["positionInTilesX"] = reader.ReadInt16();
    moduleValue["positionInTilesY"] = reader.ReadInt16();
    moduleValue["typeOfPylon"] = reader.ReadByte();
}
```

```csharp
private void WriteTeleportPylonModule(BinaryWriter writer)
{
    writer.Write((byte)moduleValue["packetType"]);
    writer.Write((short)moduleValue["positionInTilesX"]);
    writer.Write((short)moduleValue["positionInTilesY"]);
    writer.Write((byte)moduleValue["typeOfPylon"]);
}
```

```csharp
private void ReadTextModule(BinaryReader reader)
{
    moduleValue.Clear();
    if (Side == Side.Server)
    {
        moduleValue["authorId"] = reader.ReadByte();
        var text = new NetworkText();
        text.OnDeserialize(reader);
        moduleValue["text"] = text;
        var color = new Color();
        color.OnDeserialize(reader);
        moduleValue["color"] = color;
    }
    else if (Side == Side.Client)
    {
        var cmdId = reader.ReadString();
        moduleValue["cmdId"] = cmdId;
        var text = reader.ReadString();
        moduleValue["text"] = text;
    }
}
```

```csharp
private void WriteTextModule(BinaryWriter writer)
{
    if (Side == Side.Server)
    {
        writer.Write((byte)moduleValue["authorId"]);
        ((NetworkText)moduleValue["text"]).OnSerialize(writer);
        ((Color)moduleValue["color"]).OnSerialize(writer);
    }
    else if (Side == Side.Client)
    {
        writer.Write((string)moduleValue["cmdId"]);
        writer.Write((string)moduleValue["text"]);
    }
}
```

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

Methods: 
### Inner enum definations
#### DoorToggleAction

| value | description |
| ----- | ----- |
| OpenDoor | - |
| CloseDoor | - |
| OpenTrapdoor | - |
| CloseTrapdoor | - |
| OpenTallGate | - |
| CloseTallGate | - |

#### ModifyTileAction

| value | description |
| ----- | ----- |
| KillTile | - |
| PlaceTile | - |
| KillWall | - |
| PlaceWall | - |
| KillTileNoItem | - |
| PlaceWire | - |
| KillWire | - |
| PoundTile | - |
| PlaceActuator | - |
| KillActuator | - |
| PlaceWire2 | - |
| KillWire2 | - |
| PlaceWire3 | - |
| KillWire3 | - |
| SlopeTile | - |
| FrameTrack | - |
| PlaceWire4 | - |
| KillWire4 | - |
| PokeLogicGate | - |
| Actuate | - |
| KillTile2 | - |
| ReplaceTile | - |
| ReplaceWall | - |
| SlopePoundTile | - |

#### NetworkTextMode

| value | description |
| ----- | ----- |
| Literal | - |
| Formattable | - |
| LocalizationKey | - |

#### PlaceChestAction

| value | description |
| ----- | ----- |
| PlaceChest | - |
| KillChest | - |
| PlaceDresser | - |
| KillDresser | - |
| PlaceContainers2 | - |
| Killontainers2 | - |

#### PlayerSpawnContext

| value | description |
| ----- | ----- |
| ReviveFromDeath | - |
| SpawningIntoWorld | - |
| RecallFromItem | - |

#### SpawnBossInvasionType

| value | description |
| ----- | ----- |
| GoblinInvasion  | - |
| FrostInvasion  | - |
| PirateInvasion  | - |
| PumpkinMoon  | - |
| SnowMoon  | - |
| Eclipse  | - |
| MartianMoon  | - |
| ImpendingDoom  | - |
| BloodMoon  | - |
| CombatBookUsed  | - |
| BoughtCat  | - |
| BoughtDog  | - |
| BoughtBunny  | - |

#### SpecialNPCEffectType

| value | description |
| ----- | ----- |
| SpawnSkeletron | - |
| CauseSoundAtPlayer | - |
| StartSundialing | - |
| BigMimcSpawnSmoke | - |

#### TeleportationPotionType

| value | description |
| ----- | ----- |
| TeleportationPotion | - |
| MagicConch | - |
| DemonConch | - |

#### UnlockType

| value | description |
| ----- | ----- |
| ChestUnlock | - |
| DoorUnlock | - |

### Inner type definations
#### BitsByte

| field | type | description |
| ----- | ----- | ----- |
| data | [byte](#byte) | Data |

Using default serialization method

Methods: 
```csharp
public bool this[int key]
{
    get
    {
        return ((uint)data & (uint)(1 << key)) > 0U;
    }
    set
    {
        if (value)
            data |= (byte)(1 << key);
        else
            data &= (byte)~(1 << key);
    }
}
```

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



Methods: 
#### Color

| field | type | description |
| ----- | ----- | ----- |
| r | [byte](#byte) | Red |
| g | [byte](#byte) | Red |
| b | [byte](#byte) | Red |

Using default serialization method

Methods: 
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



Methods: 
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



Methods: 
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



Methods: 
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

Methods: 
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



Methods: 


----
Generate at 2020/6/10 16:12:39