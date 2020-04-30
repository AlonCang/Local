Template:    [Condition] Transition / Items -> TargetState

- [Any]
  - Leave -> quit
  
- Room
  - [{"~Person": 0, "~KilledPerson": 0}] "Speak with person" / {"Person": 0} -> Person
  - [{"~Look": 0}] "Look around room" / {"Look": 0} -> Look
  - [{"PersonKilled": 0, "Antimatter": 0}] "Take Antimatter" / {"Antimatter": 1}

- Look
  - [{"~Crown": 0, "Look": 0}] "Look at thing 1" / {"Thing 1": 0}
  - [{"~Chainsaw": 0, "Look": 0}] "Look at thing 2" / {"Thing 2": 0}
  - [{"Chainsaw": 1, "Crown": 1}] "Look at thing 3" / {"Thing 3": 0}
  - [{"~Person": 0, "~KilledPerson": 0}] "Speak with person" / {"Person": 0} -> Person

- Person
  - [{"~Crown": 0, "Person": 0, "Thing 1": 0}] "Speak about thing 1" / {"Crown": 0} 
  - [{"~CrownGet": 0, "Crown": 0}] "Speak about Crown" / {"CrownGet": 0} 
  - [{"~CrownRefused": 0, "CrownGet": 0}] "Ask For Crown" / {"CrownRefused": 0}
  
  - [{"~Chainsaw": 0, "Person": 0, "Thing 2": 0}] "Speak about thing 2" / {"Chainsaw": 0} 
  - [{"~ChainsawGet": 0, "Chainsaw": 0}] "Speak about Chainsaw" / {"ChainsawGet": 0} 
  - [{"~Chainsaw": 1, "ChainsawGet": 0}] "Ask For Chainsaw" / {"Chainsaw": 1} 
  
  - [{"~Antimatter": 0, "Person": 0, "Thing 3": 0}] "Speak about thing 3" / {"Antimatter": 0} 
  - [{"~AntimatterSpeakRefused": 0, "Antimatter": 0}] "Speak about Antimatter" / {"AntimatterSpeakRefused": 0} 
  - [{"~AntimatterSpeakRefused1": 0, "AntimatterSpeakRefused": 0}] "Demand to speak about Antimatter" / {"AntimatterSpeakRefused1": 0} 
  - [{"~AntimatterRefused": 0, "AntimatterSpeakRefused": 0}] "Demand Antimatter" / {"AntimatterRefused": 0} 
  - [{"PersonKilled": 0, "Antimatter": 0}] "Take Antimatter" / {"Antimatter": 1}
  - [{"Antimatter": 0}] "Take Antimatter" -> PersonEnemy
  
  - [{"~Crown":1, "Crown":0, "Chainsaw": 1}] "Use Chainsaw and demand Crown" / {"Crown": 1} 
  - [{"Crown":1, "Chainsaw": 1}] "Kill Person" / {"Person": -1, "KilledPerson":0} -> Room
  - [{"~Look": 0}] "Look around room" / {"Look": 0} -> Look

- PersonEnemy
  - "Kill Person" / {"Person": -1, "KilledPerson":0} -> Room
  - "Run Away" -> quit