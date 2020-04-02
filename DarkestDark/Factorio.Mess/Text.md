Game contents:

Resources:
- Coal
- Iron
- IronIngot

Buildings:
- CoalDrill
- IronDrill
- Smelter

Player Inventory:
- Resources
- Buildings






Resource will now only be a string.
for duplicates of the same resource there will also be an increment in an int.

"Player Inventory" will now be an inventory of <string, int>.

"Buildingcost" will be a dictionary of <string, int>.

"Player building roster" will be a dictionary of <string, int>.

Each building needs the folloing info: Name, buildingcost, input, output.

Recipe will be a class of input dictionary and out dictionary with a name. can be used for both resources and buildings.

dictionary<string, json> jsonobj

dictionary<Name, dictionary<string, string>