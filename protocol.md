# Terraria protocol
- Message [000]UNKNOWN

| arg | type | description |
| ----- | ----- | ----- |

- Message [001]Version

| arg | type | description |
| ----- | ----- | ----- |
| version | string | Terraria version |
- Message [002]Kick

| arg | type | description |
| ----- | ----- | ----- |
| kickMsg | NetworkText | Kick message |
- Message [003]RemoveClient

| arg | type | description |
| ----- | ----- | ----- |
| remoteClient | byte | Remote client ID |
- Message [004]PlayerInfo

| arg | type | description |
| ----- | ----- | ----- |
| remoteClient | byte | Remote client ID |
| skinVariant | byte | Skin Variant |
| hair | byte | Hair |
| name | string | Name |
| hairDye | byte | Hair Dye |
| hideVisibleAccessory1 | BitsByte | Hide visible accessory part 1 |
| hideVisibleAccessory2 | BitsByte | Hide visible accessory part 2 |
| hideMisc | byte | Hide Misc |
| hairColor | Color | Hair Color |
| skinColor | Color | Skin Color |
| eyeColor | Color | Eye Color |
| shirtColor | Color | Shirt Color |
| underShirtColor | Color | Under Shirt Color |
| pantsColor | Color | Pants Color |
| shoeColor | Color | Shoe Color |
| difficulty | BitsByte | Difficulty |
| gameType | BitsByte |  |
| others | BitsByte |  |
- Message [005]SetInventory

| arg | type | description |
| ----- | ----- | ----- |
| remoteClient | byte | Remote client ID |
| slotId | byte | Slot ID |
| stack | short | Stack |
| prefix | byte | Prefix |
| netId | short | Net ID |
- Message [006]RequireWorldInfo

| arg | type | description |
| ----- | ----- | ----- |

- Message [007]WorldInfo

| arg | type | description |
| ----- | ----- | ----- |
| time | int | Time |
| worldTime | BitsByte | Day time, blood moon and eclipse |
| moonPhase | byte | Moon Phase |
| maxTilesX | short | Max tiles x |
| maxTilesY | short | Max tiles y |
| spawnTilesX | short | Spawn tiles x |
| spawnTilesY | short | Spawn tiles y |
| worldSurface | short | World surface |
| rockLayer | short | Rock Layer |
| worldId | int | World ID |
| worldName | string | World Name |
| gameMode | byte | Game Mode |
| uuid | byte[16] | UUID |
| worldGeneratorVersion | long | World Generator Version |
| moonType | byte | Moon Type |
| treeBG1 | byte | Tree BG1 |
| treeBG2 | byte | Tree BG2 |
| treeBG3 | byte | Tree BG3 |
| treeBG4 | byte | Tree BG4 |
| corruptBG | byte | Corrupt BG |
| jungleBG | byte | Jungle BG |
| snowBG | byte | Snow BG |
| hallowBG | byte | Hallow BG |
| crimsonBG | byte | Crimson BG |
| desertBG | byte | Desert BG |
| oceanBG | byte | Ocean BG |
| mushroomBG | byte | Mushroom BG |
| underworldBG | byte | Underworld BG |
| iceBackStyle | byte | Ice back style |
| jungleBackStyle | byte | Jungle back style |
| hellBackStyle | byte | Hell back style |
| windSpeedTarget | float | Wind speed target |
| numClouds | byte | Clouds amount |
| numClouds | byte | Clouds amount |
| treeX | int[3] | Tree x |
| treeStyle | int[4] | Tree style |
| caveBackX | int[3] | Cave back x |
| caveBackStyle | int[4] | Cave back style |
| treeTopsVariations | int[13] | Tree tops variations |
| maxRaining | float | Max Raining |
| worldState1 | BitsByte | World state part 1 |
| worldState2 | BitsByte | World state part 2 |
| worldState3 | BitsByte | World state part 3 |
| worldState4 | BitsByte | World state part 4 |
| worldState5 | BitsByte | World state part 5 |
| worldState6 | BitsByte | World state part 6 |
| worldState7 | BitsByte | World state part 7 |
| savedOreTiersCopper | short | Saved ore tiers copper |
| savedOreTiersIron | short | Saved ore tiers Iron |
| savedOreTiersSilver | short | Saved ore tiers silver |
| savedOreTiersGold | short | Saved ore tiers gold |
| savedOreTiersCobalt | short | Saved ore tiers cobalt |
| savedOreTiersMythril | short | Saved ore tiers mythril |
| savedOreTiersAdamantite | short | Saved ore tiers adamantite |
| invasionType | sbyte | Invasion Type |
| lobbyId | long | Lobby ID |
| sandstormIntendedSeverity | float | Sandstorm Intended Severity |
- Type BitsByte

| field | type | description |
| ----- | ----- | ----- |
| data | byte | Data |
- Type Color

| field | type | description |
| ----- | ----- | ----- |
| r | byte | Red |
| g | byte | Red |
| b | byte | Red |
----
Generate at 2020/6/9 18:24:08