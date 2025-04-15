using System;
using System.Collections.Generic;

public static class Database
{
    public static string[] Entries = _DATA.Split("\n");

   private const string _DATA = """
    0001 1d10 of casteris fingers turn to stone
    0002 1d100 bees swarm harmlessly around the caster for several weeks
    0003 1d100 sparkling motes dance about the casteris head until dawn
    0004 1d100% of casteris body turns to iron for that many rounds
    0005 1d12 ducklings identify the caster as their mother
    0006 1d4 of casteris fingers move from his left hand to his right hand
    0007 1d4 of casteris limbs are as durable as steel
    0008 1d4 of casteris limbs are covered in fish scales
    0009 1d4 of casteris limbs are invisible
    0010 1d8 of casteris primary orifices seal shut
    0011 3d10 harmless lumps as big as walnuts cover the casteris body
    0012 3d10 quarts of olive oil pour from casteris ears
    0013 4d6 non-functioning eyes appear on the casteris face and head
    0014 A 100 yard radius around casteris home is stripped of vegetation
    0015 A 2d6 foot radius around caster sinks as many feet into the earth
    0016 A basementis been installed in casteris home while heis been away
    0017 A close friend of the caster is an assassin hired to kill him
    0018 A distant but powerful army declares war on the caster
    0019 A drop of the casteris blood can purify 1d4 gallons of water
    0020 A family of skunks has taken up residence in the casteris home
    0021 A fast-growing oak sprouts beneath the casteris home
    0022 A foot-long steel bar runs completely through the casteris thigh
    0023 A geyser temporarily erupts from one of the casteris pockets
    0024 A glowing orb hovers over casteris head while heis invisible
    0025 A great wind blows the caster 1d100 yards in a random direction
    0026 A group of necromancers take an interest in the casteris skeleton
    0027 A group of scholars think the casteris a visitor from the future
    0028 A henis egg tumbles out of each of the casteris ears
    0029 A huge balloon shaped like the caster drifts past overhead
    0030 A kill-on-sight order has been issued for the caster kingdom-wide
    0031 A large haystack falls from the sky onto caster
    0032 A large oak sprouts from one of the casteris pockets
    0033 A length of chain now runs completely through the casteris torso
    0034 A life-sized statue of caster appears nearby, made of cheese
    0035 A magical blast detonates at casteris location, but heis unharmed
    0036 A mound of snow falls onto caster and buries him up to his chest
    0037 A page falls out of casteris spellbook each time itis opened
    0038 A skeleton mimics caster, exactly duplicating his movements
    0039 A small fountain wells up in the casteris home
    0040 A strong net falls from the sky and entangles the caster
    0041 A swirl of rainbows accompanies any spell cast by caster
    0042 A tornado picks caster up and deposits him atop the nearest house
    0043 After a horrifying tragedy, caster squanders the worldis goodwill
    0044 After each spell, a lighted cigar appears in casteris mouth
    0045 After each spell, a pebble falls from each of casteris ears
    0046 After each spell, ants seem to course from the casteris eyes
    0047 After each spell, caster accuses someone nearby of impropriety
    0048 After each spell, caster appears astonishingly ugly for 1d4 turns
    0049 After each spell, caster appears to be decomposing
    0050 After each spell, caster appears to be made of pure ice
    0051 After each spell, caster appears to be utterly insane
    0052 After each spell, caster applauds himself
    0053 After each spell, caster begs someone nearby not to kill him
    0054 After each spell, caster berates someone standing nearby
    0055 After each spell, caster briefly appears to be a rotting corpse
    0056 After each spell, caster briefly appears to be on fire
    0057 After each spell, caster briefly appears to bleed from his eyes
    0058 After each spell, caster briefly looks like a photo negative
    0059 After each spell, caster briefly seems to be of the opposite sex
    0060 After each spell, caster briefly sees fire all around him
    0061 After each spell, caster briefly thinks that heis choking
    0062 After each spell, caster can sense secret doors for 1d4 rounds
    0063 After each spell, caster canit be magically healed for one hour
    0064 After each spell, caster canit traverse a doorway for 1d10 rounds
    0065 After each spell, caster dances like a honeybee
    0066 After each spell, caster experiences a burning sensation
    0067 After each spell, caster feels ants crawling all over him
    0068 After each spell, caster feels compelled to wash his hands
    0069 After each spell, caster feels completely alone and isolated
    0070 After each spell, caster feels distractingly hungry
    0071 After each spell, caster feels overwhelmingly dizzy
    0072 After each spell, caster feels transcendent euphoria
    0073 After each spell, caster forgets everyoneis name for one hour
    0074 After each spell, caster forgets his name for one hour
    0075 After each spell, caster glows with infernal radiance
    0076 After each spell, caster growls like a rabid dog
    0077 After each spell, caster has a brief vision of some distant land
    0078 After each spell, caster has a strong craving for twigs and bark
    0079 After each spell, caster is 5% likely to be stricken mute
    0080 After each spell, caster is 25% likely to turn briefly invisible
    0081 After each spell, caster is 30% likely to lose his balance
    0082 After each spell, caster is 60% likely to flap his arms
    0083 After each spell, caster is afraid of his own name
    0084 After each spell, caster is as hairy as an ape for one hour
    0085 After each spell, caster is base AC zero for 1d4 rounds
    0086 After each spell, caster is bathed in an otherworldly green light
    0087 After each spell, caster is blind in one eye for one hour
    0088 After each spell, caster is grief-stricken for 1d10 rounds
    0089 After each spell, caster is hopelessly drunk for 1d4 rounds
    0090 After each spell, caster is immune to bludgeons for 1d4 rounds
    0091 After each spell, caster is immune to missile fire for one round
    0092 After each spell, caster is intensely magnetic for 1d8 rounds
    0093 After each spell, caster is matte black for 1d4 rounds
    0094 After each spell, caster is suddenly facing True North
    0095 After each spell, caster is wracked by existential horror
    0096 After each spell, caster looks like a cadaver for 1d4 rounds
    0097 After each spell, caster makes short, barking cries
    0098 After each spell, caster oozes sweet-smelling oil for 1d4 rounds
    0099 After each spell, caster polymorphs very briefly
    0100 After each spell, caster reeks of alcohol for 2d6 rounds
    0101 After each spell, caster salivates copiously
    0102 After each spell, caster seems withdrawn and despondent
    0103 After each spell, caster shakes like a rag doll for 2d4 seconds
    0104 After each spell, caster shivers uncontrollably for 1d4 rounds
    0105 After each spell, caster shrinks by 10d10% for 1d4 rounds
    0106 After each spell, caster shrinks by 50%
    0107 After each spell, caster smells strongly of turpentine
    0108 After each spell, caster suffers brief visions of carnage
    0109 After each spell, caster suffers disorienting vertigo
    0110 After each spell, caster thinks that heis drowning
    0111 After each spell, caster thinks that his clothes are on fire
    0112 After each spell, caster trumpets like an elephant
    0113 After each spell, caster vanishes very briefly vanishes
    0114 After each spell, casteris clothes age 1d100 years 
    0115 After each spell, casteris clothes billow with green smoke
    0116 After each spell, casteris eyes briefly double in size
    0117 After each spell, casteris face looks 50 years older
    0118 After each spell, casteris feet are covered with ash
    0119 After each spell, casteris hair grows two inches
    0120 After each spell, casteris hands display classic stigmata
    0121 After each spell, casteris hands steam wildly
    0122 After each spell, casteris head turns 360° at the neck, unharmed
    0123 After each spell, casteris head turns invisible for 1d4 rounds
    0124 After each spell, casteris heart pounds audibly
    0125 After each spell, casteris left arm turns to stone for one hour
    0126 After each spell, casteris spellbook throbs with deep red light
    0127 After each spell, casteris Strength is halved for one hour
    0128 After each spell, gravity briefly doubles for the caster
    0129 After each spell, he giggles for 1d4-1 rounds
    0130 After each spell, light shines from casteris mouth for 1d6 rounds
    0131 After each spell, small lumps of ice fall from casteris nostrils
    0132 After each spell, smoke hangs in the air about the caster
    0133 After each spell, stones near the caster glisten with slime
    0134 After each spell, sunlight is painful to caster for 1d4 rounds
    0135 Alcohol has no effect upon the caster, but cheese is intoxicating
    0136 All holy symbols within 100 yards bear the casteris image
    0137 All of casteris clothing is colored safety orange
    0138 All of casteris clothing is permanently moist
    0139 All of casteris enemies with 100 yards vanish until dawn
    0140 All of casteris fingers are as long as his middle finger
    0141 All of casteris fingers are clear like glass
    0142 All of casteris fingers double in thickness
    0143 All of casteris fingers migrate to one hand
    0144 All of casteris monetary wealth appears atop the nearest mountain
    0145 All of casteris monetary wealth is revealed to be counterfeit
    0146 All of casteris possessions age 1d1000 years
    0147 All of casteris possessions are thrown 4d6 hours into the future
    0148 All of casteris possessions have been seized by the government
    0149 All trees within 100 yards form into a tight circle around caster
    0150 All undead within 1d4 miles blame the caster for their undeath
    0151 All undead within 1d4 miles race to the casteris current location
    0152 All vegetation now within 10 miles is highly toxic to caster
    0153 All vegetation now within 100 yards is invisible to caster
    0154 All who meet caster are 50% likely to think he smells like manure
    0155 All who meet caster are 60% likely to think heis a lycanthrope
    0156 All who meet caster are 60% likely to think heis undead
    0157 All within 10 yards of caster are sprayed with viscous ectoplasm
    0158 All within 10 yards of caster attack him for 1d4 rounds
    0159 Alternating pages of casteris spellbook are indestructible
    0160 An accurate illusion of caster copies his movements one mile away
    0161 An illusory statue of the caster stands at this spot for one year
    0162 An image of casteris beating heart hovers in the nearest doorway
    0163 An image of the casteris head hovers over his actual head
    0164 An image the of casteris beating heart hovers over his head
    0165 Any Abjurations currently affecting the caster are Dispelled
    0166 Any armor that the caster is wearing right now shrinks by 80%
    0167 Any armor that the caster is wearing right now vanishes forever
    0168 Any arrow striking the caster disintegrates in 1d4 rounds
    0169 Any arrow striking the caster inflicts equal damage on its archer
    0170 Any attack-based spell cast by caster is 10% likely to affect him
    0171 Any attack-based spell cast by caster is delayed 1d4 rounds
    0172 Any attempt to change shape locks the caster into that new shape
    0173 Any attempt to change shape makes the caster forget his true form
    0174 Any attempt to change shape will age the caster 1d10 years
    0175 Any attempt to change shape will be only partially successful
    0176 Any attempt to change shape will cause the caster to take root
    0177 Any attempt to change shape will leave his feet unchanged
    0178 Any attempt to change shape will make the caster bald forever
    0179 Any attempt to change shape will render the caster genderless
    0180 Any attempt to change shape will shrink the caster by 2d10%
    0181 Any attempt to change shape will teleport the caster 1d1000 miles
    0182 Any attempt to change shape will teleport the caster to this spot
    0183 Any attempt to change shape will turn him into 2d12 ducklings
    0184 Any attempt to change shape will turn the caster inside-out
    0185 Any attempt to change shape will turn the caster into a geranium
    0186 Any attempt to change shape will turn the caster into a monkey
    0187 Any attempt to change shape will turn the caster into a pelican
    0188 Any attempt to change shape will turn the caster into a penguin
    0189 Any attempt to change shape will turn the caster into a rabbit
    0190 Any attempt to change shape will turn the caster into a shrubbery
    0191 Any attempt to change shape will turn the caster into a snowman
    0192 Any attempt to change shape will turn the caster into a toddler
    0193 Any attempt to change shape will turn the caster into a troll
    0194 Any attempt to change shape will turn the caster into a wax dummy
    0195 Any attempt to read casteris mind reveals a homicidal maniac
    0196 Any attempt to read casteris mind reveals an absolute void
    0197 Any attempt to use rope inspires the caster to hang himself
    0198 Any attempt to use rope leaves caster hopelessly entangled
    0199 Any attempt to use rope leaves hideous welts on the casteris body
    0200 Any blade that has drawn the casteris blood is invisible to him
    0201 Any bread that caster bakes remains warm until itis eaten
    0202 Any building that the caster enters appears to catch fire
    0203 Any building that the caster enters ejects him forcefully
    0204 Any clothing worn by caster is invisible to him while he wears it
    0205 Any clothing worn by caster smells like carrion while he wears it
    0206 Any coins in casteris possession are gold-plated
    0207 Any coins in casteris possession become copper pieces
    0208 Any coins now carried by caster are water-soluble for 1d4 weeks
    0209 Any coins now carried by caster ignite and burn like tinder
    0210 Any creature Summoned by caster emerges from his mouth
    0211 Any creatures Summoned near caster are invisible to him
    0212 Any creatures Summoned near caster immediately befriend him
    0213 Any damage against caster is rolled twice, using the higher roll
    0214 Any damage against caster is rolled twice, using the lower roll
    0215 Any electricity-based magic used by caster discharges on him
    0216 Any electricity-based magic used by caster reeks of ozone
    0217 Any fire extinguished by caster rekindles itself 1d4 turns later
    0218 Any fire-based spell used by caster has only 25% of normal range
    0219 Any fires set by caster are invisible for 2d6 hours
    0220 Any fires set by caster attract undead like moths to a candle
    0221 Any fires set by caster jingle like wind chimes while they burn
    0222 Any fires set by caster make those near it appear to be undead
    0223 Any fires set by caster produce no heat
    0224 Any fires set by caster produce no smoke
    0225 Any fires set by caster whisper vague threats against him
    0226 Any food now carried by caster combusts
    0227 Any food now carried by caster is 10X as nutritious
    0228 Any food now carried by caster is fused into glass
    0229 Any food now carried by caster is sealed in airtight tin cans
    0230 Any food now carried by caster is toxic to Dwarves
    0231 Any food now carried by caster smells like carrion
    0232 Any food now carried by caster turns to ice
    0233 Any food now carried by caster turns to iron
    0234 Any food now carried by caster turns to spun sugar
    0235 Any gems in casteris possession are replaced by lumps of gelatin
    0236 Any hammer thrown by caster returns to his hand one round later
    0237 Any horse ridden by caster suffers no fatigue while he rides it
    0238 Any intelligent weapons now carried by caster hate him forever
    0239 Any intelligent weapons seen by caster look vaguely familiar
    0240 Any magic currently affecting the caster is Dispelled
    0241 Any magic currently affecting the caster is suppressed until dawn
    0242 Any magic items owned by caster appear in a heap nearby
    0243 Any magic items owned by caster are non-functional for 1d10 days
    0244 Any magical scrolls now carried by caster are fireproof 
    0245 Any magical scrolls now carried by caster are forgeries
    0246 Any magical scrolls now carried by caster are subtly tainted
    0247 Any magical scrolls now carried by caster discharge spontaneously
    0248 Any magical scrolls now carried by caster turn to steel
    0249 Any metal object carried by caster is 90% transparent
    0250 Any metal object carried by caster seems 10x its normal weight
    0251 Any metal that caster is carrying turns to liquid like mercury
    0252 Any missile fired at caster is 10% likely to explode when it hits
    0253 Any missile fired at caster is at a -3 penalty to hit him
    0254 Any missile fired by caster is 10% likely to vanish in flight
    0255 Any missile shot by caster is destroyed by lightning mid-flight
    0256 Any missile striking caster is 10% likely to be just an illusion
    0257 Any mountain more than one mile from caster is invisible to him
    0258 Any ranged spell used by caster seems to issue from his eyes
    0259 Any ranged spell used by caster seems to issue from someone else
    0260 Any rope currently carried by caster doubles in length
    0261 Any rope currently carried by caster turns to braided gold wire
    0262 Any rope that caster is now carrying becomes frictionless
    0263 Any rope that caster is now carrying is soaked with lamp oil
    0264 Any shield held by caster appears to be made of Swiss cheese
    0265 Any shield held by caster appears to weigh 100 pounds
    0266 Any shield held by caster gains a +1 bonus while he holds it
    0267 Any shield held by caster is ethereal in the presence of weapons
    0268 Any shield held by caster is impervious to magical fire
    0269 Any spells cast by caster are accompanied by twinkling lights
    0270 Any spells cast by caster upon himself have an undesirable effect
    0271 Any spells cast by caster upon himself lapse after one round
    0272 Any spells cast by caster within the last hour are negated
    0273 Any spells caster now has memorized will fail when he casts them
    0274 Any undead in the area attack the caster but ignore everyone else
    0275 Any undead in the area flee from the caster for 2d10 rounds
    0276 Any wood within 25 yards flies toward the caster for 1d10 rounds
    0277 Any writing implement used by caster breaks, runs dry, etc.
    0278 Anyone attempting to rob caster must tell him about it beforehand
    0279 Anyone drinking a potion near caster looks like him until sunset
    0280 Anyone drinking a potion shrinks by 50% for its duration
    0281 Anyone in casteris presence canit employ Direction Sense
    0282 Anyone in casteris presence thinks that he represents True North
    0283 Anyone related to caster by blood is invisible to him
    0284 Anyone slain by caster becomes invisible upon death
    0285 Anyone trying to pick casteris pocket shrinks by 50%
    0286 Anyone trying to scry the casteris whereabouts sees this location
    0287 Anyone voluntarily struck by casteris magic resents him for it
    0288 Anyone who knows casteris name gives him an offensive nickname
    0289 Anyone who looks deep into casteris mouth risks insanity
    0290 Anything caster drinks is 50% likely to fall from his mouth
    0291 Anything written by caster appears as gibberish to everyone else
    0292 Artifacts react unpredictably when caster attempts to use them
    0293 Before each spell, caster must address someone who isnit there
    0294 Before each spell, caster must anoint his head with water
    0295 Before each spell, caster must bark like a dog for 2d6 seconds
    0296 Before each spell, caster must bite a gold coin
    0297 Before each spell, caster must blaspheme some god of chaos
    0298 Before each spell, caster must claim that his shoes are too tight
    0299 Before each spell, caster must claim to be invincible
    0300 Before each spell, caster must clear his throat loudly
    0301 Before each spell, caster must confess an embarrassing secret
    0302 Before each spell, caster must confess that heis a charlatan
    0303 Before each spell, caster must crack his knuckles
    0304 Before each spell, caster must drop a gold coin to the ground
    0305 Before each spell, caster must give himself permission to cast it
    0306 Before each spell, caster must hold his breath for 1d10 seconds
    0307 Before each spell, caster must ingest a pinch of dust
    0308 Before each spell, caster must insult a close friend
    0309 Before each spell, caster must invoke some monstrous entity
    0310 Before each spell, caster must issue what sounds like a prophecy
    0311 Before each spell, caster must light a small candle
    0312 Before each spell, caster must make a new and improbable vow
    0313 Before each spell, caster must make an embarrassing admission
    0314 Before each spell, caster must pat himself on the head
    0315 Before each spell, caster must pluck 1d6 hairs from his head
    0316 Before each spell, caster must predict that heill die by sunset
    0317 Before each spell, caster must prick his finger with a rusty pin
    0318 Before each spell, caster must profess a thirst for human blood
    0319 Before each spell, caster must profess love for someone nearby
    0320 Before each spell, caster must promise to change his name
    0321 Before each spell, caster must remove one article of clothing
    0322 Before each spell, caster must say "Magic is my business."
    0323 Before each spell, caster must say "My God, itis full of stars."
    0324 Before each spell, caster must say "The prophecy is fulfilled."
    0325 Before each spell, caster must say "This probably wonit work."
    0326 Before each spell, caster must shed at least 1d4 tears
    0327 Before each spell, caster must shout a different prime number
    0328 Before each spell, caster must snap a twig or the like
    0329 Before each spell, caster must speak a new and original rhyme
    0330 Before each spell, caster must speak a new and relevant pun
    0331 Before each spell, caster must speak ill of a good friend
    0332 Before each spell, caster must tear one article of clothing
    0333 Before each spell, caster must tie a knot in a piece of string
    0334 Before each spell, caster must touch his eyes, ears, and nose
    0335 Before each spell, caster must touch liquid water
    0336 Before each spell, caster must trace a circle in the air
    0337 Before each spell, caster must vow that this is his final spell
    0338 Beneficial magic potions have an opposite effect upon the caster
    0339 Bits of flesh fall from casteris body until heis a bare skeleton
    0340 Blades seem extraordinarily dull while caster wields them
    0341 Caster accidentally creates a virulent plague in his workshop
    0342 Caster accuses his nearest ally of murdering him
    0343 Caster acquires an exact copy of every non-magical thing he owns
    0344 Caster acquires lycanthropy, but only in his left leg
    0345 Caster acquires proficiency in some weapon that will never exist
    0346 Caster addresses everyone he knows by his own name
    0347 Caster adopts a habit of nightly self-flagellation
    0348 Caster adopts a universally obscene gesture as his trademark
    0349 Caster adopts bizarre rituals concerning the preparation of food
    0350 Caster adopts fastidious standards of hygiene
    0351 Caster adopts some unlikely animal as a kind of spirit totem
    0352 Caster adopts some unlikely object as a kind of holy symbol
    0353 Caster adopts the next religion he encounters for the first time
    0354 Caster ages 1d10 years per hour until sunset tonight
    0355 Caster ages 1d10 years/round for 2 turns, then reverts to normal
    0356 Caster ages backwards 2d4 years over that many rounds
    0357 Caster ages normally but forever retains his current appearance
    0358 Caster ages one year per day spent on open water
    0359 Caster ages one year per mile that he travels away from this spot
    0360 Caster always appears healthy and wealthy
    0361 Caster always appears sickly and destitute
    0362 Caster always feels as if the temperature is what it is right now
    0363 Caster always pays 10% more than the asking price
    0364 Caster always sees his surroundings as misty and fog-shrouded
    0365 Caster always thinks itis fifty degrees colder than it really is
    0366 Caster always thinks that thereis one more step in the staircase
    0367 Caster and everyone else forgets and canit discern his age
    0368 Caster and nearest intelligent weapon exchange personalities
    0369 Caster and one nearby ally teleport to the casteris home
    0370 Caster annoys everyone by insisting that heis ambidextrous
    0371 Caster appears increasingly decrepit as the day wears on
    0372 Caster appears to be a bare skeleton from the waist down
    0373 Caster appears to be a bare skeleton from the waist up
    0374 Caster appears to be at full health, no matter how badly injured 
    0375 Caster appears to be bleeding profusely whenever heis indoors
    0376 Caster appears to be composed of translucent quartz
    0377 Caster appears to be covered in ugly scales for one day each week
    0378 Caster appears to be made of countless flesh-colored pebbles
    0379 Caster appears to be made out of bricks until sunset tomorrow
    0380 Caster appears to be of a different species while sleeping
    0381 Caster appears to be of opposite sex while brandishing a shield
    0382 Caster appears to be on fire while his spellbook is open
    0383 Caster appears to be operating his body from a remote location
    0384 Caster appears to be undead for one hour after each meal
    0385 Caster appears to be undead while in the presence of undead
    0386 Caster appears to be weathered like an ancient statue
    0387 Caster appears to have a railroad spike jutting from his forehead
    0388 Caster appears to have been carved from wood with an axe
    0389 Caster appears to have been crafted out of clay by children
    0390 Caster appears to have been torn apart and hastily reassembled
    0391 Caster appears to shrivel like a raisin after each casting
    0392 Caster appears translucent to anyone of the opposite sex
    0393 Caster asks Elves if they can supply him with fudge cookies
    0394 Caster ate the last of the rations that his party was carrying
    0395 Caster ate two or three pounds of apple seeds this morning
    0396 Caster attempts to drink every potion he sees
    0397 Caster attracts undead in any town he enters
    0398 Caster attracts zealous sycophants wherever he goes
    0399 Caster automatically believes that his own illusions are real
    0400 Caster awakens to find that the last 1d8 hours were only a dream
    0401 Caster bears the birthmark of the lineage of powerful kings
    0402 Caster becomes disturbingly frenetic until sunset
    0403 Caster becomes flat as a sheet of parchment for 2d6 rounds
    0404 Caster becomes increasingly simian as the days wear on
    0405 Caster becomes invisible to anyone who successfully Charms him
    0406 Caster becomes lost if he enters a cave by himself
    0407 Caster becomes lost if he enters a forest by himself
    0408 Caster becomes powerfully addicted to necromantic magic
    0409 Caster becomes powerfully addicted to Chaos Bursts
    0410 Caster becomes tightly stuck to the next chair in which he sits
    0411 Caster becomes unconscious when he becomes invisible
    0412 Caster becomes violently ill if he eats near a fire
    0413 Caster becomes visibly anxious at the sight of holy water
    0414 Caster begins aging backwards, one year per round
    0415 Caster begins growing one inch per week
    0416 Caster begins his conversations with an insulting comment
    0417 Caster begins to resemble the next person who touches him
    0418 Caster begins worshipping his spellbook with burnt offerings
    0419 Caster believes that a nearby sheep is his polymorphed true love
    0420 Caster briefly turns translucent after casting a spell
    0421 Caster burns with homicidal rage whenever heis struck by magic
    0422 Caster can alter his weight by up to 50% at will
    0423 Caster can always sense his location relative to this location
    0424 Caster can appear to be 50% fatter at will
    0425 Caster can appraise gems by tasting them
    0426 Caster can ask three questions of the next tree he touches
    0427 Caster can assess the purity of any metal by tasting it
    0428 Caster can be accurately described as "frumious"
    0429 Caster can be injured but not killed by any bludgeoning weapon
    0430 Caster can be injured but not killed by any female creature
    0431 Caster can be injured but not killed by any male creature
    0432 Caster can be injured by fire, but it canit kill him
    0433 Caster can be injured by metal weapons, but they canit kill him
    0434 Caster can be injured normally but can only be slain by fire
    0435 Caster can be injured normally but can only be slain by magic
    0436 Caster can become invisible at will while heis knee-deep in snow
    0437 Caster can become invisible while standing neck-deep in water
    0438 Caster can breathe underwater, but he always smells like a fish
    0439 Caster can carry any weight of books but only in his bare hands
    0440 Caster can cause one creature near him to turn to iron
    0441 Caster can cause one nearby person to age 1d10 years
    0442 Caster can change the size of his ears at will
    0443 Caster can conjure apples out of thin air, one at a time
    0444 Caster can control any undead skeletons now within 100 yards
    0445 Caster can detach either of his hands at will
    0446 Caster can detach his head easily but dies if he does so
    0447 Caster can detect non-magical fire within 500 yards
    0448 Caster can detect the nearest potable water at will
    0449 Caster can detect the presence of elementals within 100 yards
    0450 Caster can detect True East at will
    0451 Caster can discern a personis age by touching him
    0452 Caster can discern a treeis age by touching it
    0453 Caster can discern whether people are really unconscious
    0454 Caster can discern which spells a magic user has memorized
    0455 Caster can disgorge a pound of sawdust once per day
    0456 Caster can double his spellsi range if heis carrying no metal
    0457 Caster can double his weight for up to 1d4 rounds per day
    0458 Caster can drink only from a golden bowl worth 100 gold pieces
    0459 Caster can easily walk on ice while barefoot
    0460 Caster can echolocate like a dolphin while naked and underwater
    0461 Caster can endure normal fire one round per point of Constitution
    0462 Caster can extend his legs to 150% of their normal length at will
    0463 Caster can extend his legs to 2X their normal length at will
    0464 Caster can handle red-hot metal with his bare hands
    0465 Caster can hear what occurs at this location from up to 10 miles
    0466 Caster can hear whatis going on in his home, wherever he is
    0467 Caster can hold his breath for 3X his Wisdom score in rounds
    0468 Caster can hurl a baseball-sized object beyond the horizon
    0469 Caster can identify any kind of fungus on sight
    0470 Caster can ignite twigs by sticking them in his mouth
    0471 Caster can ignore any spell cast on him but is 80% likely to die
    0472 Caster can induce ravenous hunger in others
    0473 Caster can inflate his left hand like a balloon
    0474 Caster can instantly count quantities of fewer than 1,000 items
    0475 Caster can judge visible distances with amazing accuracy
    0476 Caster can light candles simply by touching their wicks
    0477 Caster can magically create edible but non-nourishing food
    0478 Caster can make his ears resemble noses at will
    0479 Caster can memorize spells 4x faster than is normally required
    0480 Caster can move easily through running water less than waist-deep
    0481 Caster can move in total silence for his Wisdom score in rounds
    0482 Caster can move silently while holding a thumb in each nostril
    0483 Caster can never again come within one mile of his home
    0484 Caster can no longer use charged magic items
    0485 Caster can only digest food that is spoiled or rotting
    0486 Caster can only use electrical magic while standing in water
    0487 Caster can only wear one shoe at a time
    0488 Caster can open his mouth as wide as he is tall
    0489 Caster can pass his right arm through up to six inches of wood
    0490 Caster can reattach his own limbs if theyire severed
    0491 Caster can recall his own birth with perfect clarity
    0492 Caster can remove his tongue and replace it at will
    0493 Caster can remove one eye and replace it at will
    0494 Caster can remove or negate one curse
    0495 Caster can resemble a decaying zombie at will
    0496 Caster can retract his feet into his ankles at will
    0497 Caster can retract his fingers into his palms at will
    0498 Caster can retract his nose into his face at will
    0499 Caster can scale walls like a monkey while unencumbered
    0500 Caster can see in total darkness if he has a banana in his pocket
    0501 Caster can see secret doors easily but canit see normal doors
    0502 Caster can see through fire
    0503 Caster can see through his eyelids for up to 1d6 rounds at a time
    0504 Caster can see through stone if he has a pebble in his mouth 
    0505 Caster can see underwater clearly while naked and wielding an axe
    0506 Caster can seem to be infected with a particular disease at will
    0507 Caster can seen in total darkness for 1d4 days
    0508 Caster can sense intelligent weapons within 10 yards
    0509 Caster can sense people whoive been affected by Chaos Bursts
    0510 Caster can speak but canit engage in actual conversations
    0511 Caster can speak in a whisper to anyone in his line of sight
    0512 Caster can speak in any of 2d4 voices at will
    0513 Caster can speak with ants but can only ask yes/no questions
    0514 Caster can speak with carrion birds, but he smells like a corpse
    0515 Caster can speak with carrion birds, but heis permanently bald
    0516 Caster can speak with domestic fowl, but he crows at sunrise
    0517 Caster can speak with domestic fowl, but they tend to lie to him
    0518 Caster can speak with honeybees while dancing like one of them
    0519 Caster can speak with oysters while holding a pearl in his mouth
    0520 Caster can speak with small fish, but only while underwater
    0521 Caster can spot the strongest member of any group of five or more
    0522 Caster can stretch his left arm 2X the length of his body
    0523 Caster can subsist on bark for up to 1d4 days at a time
    0524 Caster can Summon 1d10 rabbits, once per level per week
    0525 Caster can Summon a powerful entity to answer one question
    0526 Caster can Summon a powerful entity who will then try to kill him
    0527 Caster can Summon but not control a powerful, malevolent entity
    0528 Caster can Summon up to 1d10 pigeons per month
    0529 Caster can survive at the bottom of the sea for 1d4 minutes
    0530 Caster can survive in the depths of space, if he can get there
    0531 Caster can survive one fall of up to twenty miles
    0532 Caster can taste foods simply by touching them
    0533 Caster can teleport 10 feet straight up, once per day
    0534 Caster can teleport 10 times at will but loses a finger each time
    0535 Caster can teleport at will but ages 1d100 years each time
    0536 Caster can teleport at will but arrives unconscious for one hour
    0537 Caster can teleport at will but canit pick the destination
    0538 Caster can teleport at will but doesnit arrive for 1d12 months
    0539 Caster can teleport at will but is 10% likely to arrive dead
    0540 Caster can teleport at will but is paralyzed from the neck down
    0541 Caster can teleport at will but loses 1d100 hit points each time
    0542 Caster can teleport at will but only while naked and unencumbered
    0543 Caster can teleport at will but shrinks by 50% per mile traveled
    0544 Caster can teleport at will to this exact spot 2d6 times
    0545 Caster can teleport into the nearest hollow tree, once
    0546 Caster can teleport up to fifty feet once per day
    0547 Caster can throw one baseball-sized item 2d6 days into the future
    0548 Caster can throw one nearby person 1d10 rounds into the future
    0549 Caster can throw one nearby person 1d4 days into the future
    0550 Caster can transmute magically-created metal into wood
    0551 Caster can travel in time but ages 1d10 years per round traveled
    0552 Caster can turn 360° at the waist without harm
    0553 Caster can turn ethereal at will but canit revert for 3d8 days
    0554 Caster can turn his arms to wood for up to 1d6 rounds per day
    0555 Caster can turn his bones invisible at will
    0556 Caster can turn his hands invisible at will 1d8 times per day
    0557 Caster can turn his head completely around once per day
    0558 Caster can turn into a cat but canit resume his true form
    0559 Caster can turn into a falcon but is only 30% likely to turn back
    0560 Caster can turn into a small tree while heis indoors
    0561 Caster can turn into any kind of fish if no water is nearby
    0562 Caster can turn invisible while he holds his breath
    0563 Caster can turn invisible while naked and motionless
    0564 Caster can walk on inclines of 45° or less as if they were flat
    0565 Caster can withstand ocean depths while holding a bar of sodium
    0566 Caster can, at will, appear to be the next person he touches
    0567 Caster canit attack anyone more than 20 feet away from him
    0568 Caster canit be beheaded
    0569 Caster canit be blinded or dazzled by sunlight
    0570 Caster canit be burned by magical fire for 1d4 hours
    0571 Caster canit be burned by steam or scalding water
    0572 Caster canit be Charmed by anyone of the opposite sex
    0573 Caster canit be crushed by any weight of stone
    0574 Caster canit be cut by any blade until he casts his next spell
    0575 Caster canit be cut by glass
    0576 Caster canit be cut by non-magical blades for 1d4 days
    0577 Caster canit be harmed by any member of the royal family
    0578 Caster canit be harmed by loud, non-magical sound
    0579 Caster canit be harmed by refined metals for 1d4 hours
    0580 Caster canit be harmed while he stands where he is right now
    0581 Caster canit be killed by anyone of his own race
    0582 Caster canit be overwhelmed by foul odors
    0583 Caster canit be seen through glass or ice
    0584 Caster canit be strangled
    0585 Caster canit breathe for 4d6 rounds
    0586 Caster canit bring his left hand within 18 inches of his head
    0587 Caster canit carry anything larger than his own head
    0588 Caster canit carry anything made entirely of metal
    0589 Caster canit carry refined metal in a wooded environment
    0590 Caster canit cast any spells he now has memorized for 1d8 days
    0591 Caster canit cast fire-based magic while in the rain
    0592 Caster canit cast fire-based spells in a wooded environment
    0593 Caster canit cast force-based spells (Wall of Force, etc.)
    0594 Caster canit cast magic on anyone not wearing armor
    0595 Caster canit cast magic on anyone while theyire eating
    0596 Caster canit cast magic unless heis within sight of a tree
    0597 Caster canit cast magic upon himself for 1d4 weeks
    0598 Caster canit create magical walls or barriers
    0599 Caster canit create normal or magical fire for 1d4 days
    0600 Caster canit create permanent magical objects or effects
    0601 Caster canit cross moving water while brandishing a weapon
    0602 Caster canit cross moving water while carrying his spellbook
    0603 Caster canit cross moving water while wearing clothes
    0604 Caster canit cross moving water while wearing magical rings
    0605 Caster canit cross moving water without assistance
    0606 Caster canit determine when heis hungry or thirsty
    0607 Caster canit eat any cooked meat
    0608 Caster canit eat any food that doesnit contain a handful of soil
    0609 Caster canit eat any food that he himself didnit prepare
    0610 Caster canit eat any salted or cured meat
    0611 Caster canit eat while at full hit points
    0612 Caster canit employ magical means of improving his Armor Class
    0613 Caster canit enter any artificial structure for 2d4 weeks
    0614 Caster canit enter any building in which Dwarves are present
    0615 Caster canit go more than 10i from this location for 24 hours
    0616 Caster canit harm or be harmed by elementals for 4d10 months
    0617 Caster canit inflict injury upon himself with any metal weapon
    0618 Caster canit learn any new spells until heis been resurrected
    0619 Caster canit learn any new spells within 1d10 miles of here
    0620 Caster canit lift both feet from the ground at the same time
    0621 Caster canit move his arms for 1d4 turns
    0622 Caster canit move his left arm or right leg for 1d4 turns
    0623 Caster canit move more than 10 feet from the next tree he touches
    0624 Caster canit open any door constructed primarily of wood
    0625 Caster canit open any door that has a hinge made of metal
    0626 Caster canit open any door that opens toward him
    0627 Caster canit open any door unless his hair is wet
    0628 Caster canit open any door while anyone is watching
    0629 Caster canit quite be certain that he really exists
    0630 Caster canit remember the last 2d12+12 hours
    0631 Caster canit remove any magical armor that heis now wearing
    0632 Caster canit remove his hands from his pockets
    0633 Caster canit run while his eyes are open
    0634 Caster canit see any extra-planar creatures for one year 
    0635 Caster canit see through glass, ice, diamond, or the like
    0636 Caster canit sleep indoors while itis raining
    0637 Caster canit sleep more than 1d4 hours at a time
    0638 Caster canit sleep until he shaves his head bald
    0639 Caster canit sleep until heis walked at least 4d8 miles from here
    0640 Caster canit speak for one hour and can only croak like a frog
    0641 Caster canit speak for one hour if heis wearing clothes
    0642 Caster canit speak in anything less than a full shout
    0643 Caster canit speak in sentences longer than 10 syllables
    0644 Caster canit speak to anyone holding a blood-stained weapon
    0645 Caster canit speak to anyone whom heis not currently touching
    0646 Caster canit speak unless he first turns in a circle
    0647 Caster canit speak unless heis brandishing a weapon
    0648 Caster canit speak unless heis carrying at least one gold coin
    0649 Caster canit speak unless his thumbs are touching
    0650 Caster canit speak until heis removed 1d10 articles of clothing
    0651 Caster canit speak while holding a weapon
    0652 Caster canit stand with both feet on the ground at the same time
    0653 Caster canit stop talking for 6d12 hours
    0654 Caster canit tolerate the presence of wet ink
    0655 Caster canit touch food with his hands
    0656 Caster canit use any blade longer than his forearm
    0657 Caster canit use any magic until someone cuts him with a blade
    0658 Caster canit use magic between sunrise and noon
    0659 Caster canit use magic for 1d4 rounds after being wounded
    0660 Caster canit use magic for 1d6 rounds after being struck by magic
    0661 Caster canit use magic for six hours after ingesting meat
    0662 Caster canit use magic items for one turn after casting a spell
    0663 Caster canit use magic items that contain gold
    0664 Caster canit use magic items until sunrise
    0665 Caster canit use magic items while at full hit points
    0666 Caster canit use magic unless he swallows a gold coin each day
    0667 Caster canit use magic unless heis holding a buzzardis feather
    0668 Caster canit use magic until he eats a pound of feathers
    0669 Caster canit use magic until sunset tomorrow
    0670 Caster canit use magic while sitting
    0671 Caster canit use magic within 1d4 miles of this spot for 5d6 days
    0672 Caster canit use missile weapons for one week
    0673 Caster canit use non-magical blades for 1d6 days
    0674 Caster canit use the spell Dispel Magic
    0675 Caster canit use the spell that triggered this Burst for one year
    0676 Caster canit use weapons that contain wood
    0677 Caster canit wake without assistance
    0678 Caster canit walk (run, etc.) while wearing a magic ring
    0679 Caster canit wear magical rings
    0680 Caster canit wield any weapon longer than his arm
    0681 Caster changes his name to its reverse: "Tom" becomes "Mot"
    0682 Caster claims that heis doing the work of some god or other
    0683 Caster claims to be able to command dragons to do his bidding
    0684 Caster claims to be immune to inorganic poisons
    0685 Caster claims to be the offspring of a god and a mortal
    0686 Caster claims to have begotten a child with a god
    0687 Caster claims to have committed logically impossible acts
    0688 Caster claims to have created the universe
    0689 Caster claims to have invented the Fireball spell
    0690 Caster combusts instantly if heis stabbed by a silver dagger
    0691 Caster comes into possession of 1d100 acres of swampland
    0692 Caster comes into possession of a bag full of mismatched teeth
    0693 Caster comes into possession of a black velvet painting of Elves
    0694 Caster comes into possession of a foul, decomposing skull
    0695 Caster comes into possession of a golden vial of silver fluid
    0696 Caster comes into possession of a ring that canit be removed
    0697 Caster comes into possession of a three-legged pony
    0698 Caster comes into possession of an apparently magical lamp
    0699 Caster comes into possession of his great-grandfatheris jawbone
    0700 Caster completely blends into his surroundings while heis asleep
    0701 Caster completely blends into his surroundings while upside down
    0702 Caster compulsively hordes some kind of small, worthless item
    0703 Caster confesses to every crime he hears about
    0704 Caster confesses to improbable crimes (e.g. "I stole the moonO")
    0705 Caster consistently overestimates his martial and magical prowess
    0706 Caster continues to age normally but canit die of old age
    0707 Caster coughs violently in the presence of undead
    0708 Caster craves moss
    0709 Caster craves wood like a termite
    0710 Caster cries like a baby whenever heis hungry or canit sleep
    0711 Caster cries like a baby whenever heis struck by magic
    0712 Caster dances like a belly-dancer for 2d6 rounds
    0713 Caster declares himself to be the center of the universe
    0714 Caster declares that Dwarves are indistinguishable from orcs
    0715 Caster declares that he can redeem the damned
    0716 Caster declares that he has the power to absolve sins
    0717 Caster declares that he is the judge of all mankind
    0718 Caster declares that these pretzels are making him thirsty
    0719 Caster deeply resents anyone who asks him to use magic
    0720 Caster deeply resents anyone who doesnit praise his magical skill
    0721 Caster deeply resents anyone who eats meat in his presence
    0722 Caster deeply resents anyone who uses magic in his presence
    0723 Caster demands that employers pay him in wood instead of gold
    0724 Caster demands that his allies adopt fastidious hygiene standards
    0725 Caster demands that his allies treat him as though heis invisible
    0726 Caster demands that people call him Ishmael
    0727 Caster demands that people call him Legion, for he is many
    0728 Caster demands that people call him The Spell-Meister
    0729 Caster derives no nourishment from food cooked over a fire
    0730 Caster derives no nourishment from food eaten after sunset
    0731 Caster derives no nourishment from food eaten near a lake
    0732 Caster develops a stutter while in the presence of undead
    0733 Caster develops an intense hunger for leather strapping
    0734 Caster develops an intense hunger for the pages of his spellbook
    0735 Caster didnit actually exist prior to this Chaos Burst
    0736 Caster dies if he slays a zombie in the next 1d6 days
    0737 Caster dies instantly if his blood is spilled by a god
    0738 Caster dies instantly if his blood is spilled by mistletoe
    0739 Caster dies painfully but arises at dawn having gained one level
    0740 Caster discovers a whole pantheon of hitherto overlooked deities
    0741 Caster discovers that one of his limbs belongs to someone else
    0742 Caster discovers that one of his limbs is a clockwork replica
    0743 Caster disgorges 10d10 feet of rubber tubing
    0744 Caster disgorges 1d100 gold pieces
    0745 Caster disgorges 1d100 pounds of wet, coarse sand
    0746 Caster disgorges 1d4 apples per hour for the next 3d8 hours
    0747 Caster disgorges 1d4 gallons of foul, necrotic mush
    0748 Caster disgorges 1d6 gallons of rusty sludge
    0749 Caster disgorges 2d10 pounds of carrots
    0750 Caster disgorges 2d4 full-sized wool blankets
    0751 Caster disgorges a 100 foot length of fine silver wire
    0752 Caster disgorges a ball of solid bone nine inches in diameter
    0753 Caster disgorges a bar of copper four feet in length
    0754 Caster disgorges a bar of soap as large as his spellbook
    0755 Caster disgorges a bolt of finely embroidered silk
    0756 Caster disgorges a book about gastrointestinal anomalies
    0757 Caster disgorges a book of carpet samples
    0758 Caster disgorges a box of rare botanical samples
    0759 Caster disgorges a bushel of ripe peaches
    0760 Caster disgorges a coffin large enough to accommodate his corpse
    0761 Caster disgorges a four-course meal for three
    0762 Caster disgorges a full-grown cactus
    0763 Caster disgorges a full-sized barrel
    0764 Caster disgorges a glass cube four inches on a side 
    0765 Caster disgorges a glass vial containing a mysterious potion
    0766 Caster disgorges a golden birdcage
    0767 Caster disgorges a kingis long-lost signet ring
    0768 Caster disgorges a large bunch of bananas
    0769 Caster disgorges a large chair
    0770 Caster disgorges a large pane of glass
    0771 Caster disgorges a length of heavy chain
    0772 Caster disgorges a life-sized ice sculpture of a horse
    0773 Caster disgorges a long hunk of driftwood
    0774 Caster disgorges a lump of brass the size of his torso
    0775 Caster disgorges a medium-sized astrolabe
    0776 Caster disgorges a mop and a wooden bucket full of suds
    0777 Caster disgorges a mysterious and important-looking key
    0778 Caster disgorges a pair of deer antlers
    0779 Caster disgorges a pair of smithis fire tongs
    0780 Caster disgorges a pouch full of rare and ancient coins
    0781 Caster disgorges a pound of mercury
    0782 Caster disgorges a pound of molten lead
    0783 Caster disgorges a ring full of keys that donit fit any lock
    0784 Caster disgorges a shipis anchor
    0785 Caster disgorges a small brazier full of burning coals
    0786 Caster disgorges a sort of bowl-shaped porcelain chair
    0787 Caster disgorges a weapon that he misplaced 1d12 months ago
    0788 Caster disgorges a whole pumpkin
    0789 Caster disgorges a wrought-iron staircase banister
    0790 Caster disgorges an airtight canister filled with nitrogen gas
    0791 Caster disgorges an elephantis femur
    0792 Caster disgorges an entire beehive
    0793 Caster disgorges an exact copy of the head of someone nearby
    0794 Caster disgorges an oil painting of this scene
    0795 Caster disgorges an ostrich egg
    0796 Caster disgorges enough snow to blanket an area ten feet square
    0797 Caster disgorges half of a canoe
    0798 Caster disgorges the carcass of a strange and colorful bird
    0799 Caster disgorges the emblem of some diabolical religious cult
    0800 Caster disgorges the entire, intact skin of a giraffe
    0801 Caster disgorges the entire, intact skin of someone nearby
    0802 Caster disgorges what appears to be his entire nervous system
    0803 Caster disgorges what appears to be his own still-beating heart
    0804 Caster displays all the signs of full demonic possession
    0805 Caster distrusts anyone displaying a cut gem or jewel
    0806 Caster distrusts anyone taller than he is
    0807 Caster distrusts anyone who doesnit know the casteris name
    0808 Caster distrusts anyone who doesnit resemble him
    0809 Caster distrusts anyone who wonit let him examine their teeth
    0810 Caster distrusts anyone whois wearing armor
    0811 Caster distrusts other members of his race
    0812 Caster distrusts other spellcasters
    0813 Caster doesnit need to drink fluids for the next 1d100 weeks
    0814 Caster doesnit need to eat during the new moon
    0815 Caster doesnit need to eat for the next 1d100 weeks
    0816 Caster doesnit remember anyone now within 10 miles
    0817 Caster donates all of his money to some unlikely charity
    0818 Caster dreams each night of a powerful and malevolent artifact
    0819 Caster dreams each night of being painfully turned inside out
    0820 Caster dreams each night of being worshipped by gods
    0821 Caster dreams of being stalked by an invisible hunter from space
    0822 Caster dreams of unicorns and wonders if heis an automaton
    0823 Caster drinks any potions heis now carrying
    0824 Caster eat food for 1d12 hours after using a magic item
    0825 Caster embraces someone nearby and is reluctant to let go
    0826 Caster embraces the nearest tree and refuses to let go
    0827 Caster ends his conversations with an annoying catch phrase
    0828 Caster engages in a long, heated debate with the nearest tree
    0829 Caster enjoys the taste of fire
    0830 Caster enjoys the taste of lamp oil
    0831 Caster erases one randomly-chosen spell from his spellbook
    0832 Caster experiences pain if he handles jewels or precious gems
    0833 Caster experiences pain when he spends money
    0834 Caster experiences violent, full-body spasms for 2d4 rounds
    0835 Caster faces True North and is stuck that way for one turn
    0836 Caster falls down the next flight of steps he encounters
    0837 Caster falls from the nearest tree
    0838 Caster falls madly in love with someone heis never heard of
    0839 Caster falls madly in love with someone whois never existed
    0840 Caster fears densely wooded areas
    0841 Caster fears non-magical, non-humanoid mammals
    0842 Caster fears that heill be damned forever whenever he uses magic
    0843 Caster fears that heill cease to exist if he causes another Burst
    0844 Caster fears that his allies are vanishing one by one
    0845 Caster fears that his limbs are vanishing one by one
    0846 Caster fears that spiders have lain countless eggs in his brain
    0847 Caster fears the reaper
    0848 Caster feels a psychic bond to someone unknown but nearby
    0849 Caster feels as if heis always walking on a slope
    0850 Caster feels as though heis trudging through knee-deep snow
    0851 Caster feels as though heis trudging uphill
    0852 Caster feels constant, overwhelming hunger while in his home
    0853 Caster feels countless small snakes crawling all over his body
    0854 Caster feels incredible hostility toward non-magic users
    0855 Caster feels incredible hostility toward other magic users
    0856 Caster feels inexplicable anxiety when he hears his name
    0857 Caster feels inexplicable anxiety while at full hit points
    0858 Caster feels inexplicable nostalgia when he meets new people
    0859 Caster feels intense but unfocused hatred for 1d6 hours
    0860 Caster feels intense discomfort when people smile at him
    0861 Caster feels more comfortable among the undead than the living
    0862 Caster feels overpowering fear in the presence of steam
    0863 Caster feels overpowering hatred for the next magic item he sees
    0864 Caster feels powerless unless everyone knows heis a magic user
    0865 Caster feels powerless unless heis wearing boots on his hands
    0866 Caster feels strangely calm while in the presence of dragons
    0867 Caster feels thorny roots growing slowly through his flesh
    0868 Caster fiercely covets the next magical ring he sees
    0869 Caster finds 1d100 cans containing pink, processed meat in jelly
    0870 Caster finds 1d4 extra spells in his spellbook
    0871 Caster finds 1d4 small rodents living in his spellbook
    0872 Caster finds 2d6 white pills, each of which heals 1d20 hit points
    0873 Caster finds 2d8 real-looking but useless spells in his spellbook
    0874 Caster finds a barrel full of rancid mayonnaise
    0875 Caster finds a book describing the methods for self-dissection
    0876 Caster finds a book that will shatter his sanity if he reads it
    0877 Caster finds a compelling but incomprehensible magical tome
    0878 Caster finds a copy of Aristotleis long-lost Poetics of Comedy
    0879 Caster finds a copy of his own ghost-written autobiography
    0880 Caster finds a crystal containing a tiny image of himself
    0881 Caster finds a cube of frozen human blood, one foot on a side
    0882 Caster finds a four-valve trumpet that can raise the dead
    0883 Caster finds a handful of mysterious pills in his pocket
    0884 Caster finds a handful of rainbow-colored powder in his pocket
    0885 Caster finds a hideous carved idol of a cephalopoid god-monster
    0886 Caster finds a key that explodes when inserted into any lock
    0887 Caster finds a large, cursed diamond in the next hole he digs
    0888 Caster finds a large, gold box containing nothing but sand
    0889 Caster finds a large, metal disc engraved with his image
    0890 Caster finds a list of assassination targets; his name is next
    0891 Caster finds a magic wand but for some reason is afraid to use it
    0892 Caster finds a minor artifact in the next hole he digs
    0893 Caster finds a mirror that grants false visions of the future
    0894 Caster finds a mirror that reflects everyone but him 
    0895 Caster finds a mirror that reflects only vampires
    0896 Caster finds a notebook detailing the way he was built in a lab
    0897 Caster finds a number that divides evenly into all prime numbers
    0898 Caster finds a pair of gloves that devour any hands inside them
    0899 Caster finds a pair of gloves that turn to steel when worn
    0900 Caster finds a pair of stone tablets engraved with quaint laws
    0901 Caster finds a possibly inaccurate chronology of his entire life
    0902 Caster finds a potion 90% likely to heal and 10% likely to kill
    0903 Caster finds a potion that can instantly cause his death
    0904 Caster finds a potion that can instill zealous religious fervor
    0905 Caster finds a potion that can turn him into an invisible cat
    0906 Caster finds a potion that induces permanent madness in horses
    0907 Caster finds a potion that makes the drinker even more visible
    0908 Caster finds a pouch full of 1d100 totally identical teeth
    0909 Caster finds a pouch full of highly flammable black dust
    0910 Caster finds a powder that burns trolls as if it were strong acid
    0911 Caster finds a powder that can dissolve up to one pound of gold
    0912 Caster finds a powder that can eliminate any poison from food
    0913 Caster finds a powder that can render the invisible visible
    0914 Caster finds a powder that can turn a zombie into an inert corpse
    0915 Caster finds a powder that can turn an inert corpse into a zombie
    0916 Caster finds a powder that combusts in the presence of orcs
    0917 Caster finds a powder that induces addictive euphoria if inhaled
    0918 Caster finds a powder that induces extreme covetousness
    0919 Caster finds a powder that is highly toxic to everyone but him
    0920 Caster finds a powder that is highly toxic to him but no one else
    0921 Caster finds a powder that is highly toxic to large-sized insects
    0922 Caster finds a powder that quickly seals open wounds
    0923 Caster finds a powder that repels elementals
    0924 Caster finds a sack full of his own crematory remains
    0925 Caster finds a satchel containing his weight in gold pieces
    0926 Caster finds a scroll describing exactly how & when heill die
    0927 Caster finds a secret passage in the next room he enters
    0928 Caster finds a set of high-quality watchmakeris tools
    0929 Caster finds a small iron box containing 4d8 of his own teeth
    0930 Caster finds a treasure map in the next animal he butchers
    0931 Caster finds a treasure map that others will kill to possess
    0932 Caster finds a trumpet that, if blown, may herald the End Times
    0933 Caster finds a weapon that can kill a god
    0934 Caster finds a wooden box whose interior canit be illuminated
    0935 Caster finds an amulet that repels Summoned creatures
    0936 Caster finds black meat like a tainted cheese
    0937 Caster finds blueprints for building some anachronistic device
    0938 Caster finds convincing evidence that heis just a clone
    0939 Caster finds foul odors pleasant and pleasant scents repulsive
    0940 Caster finds his own decaying corpse in the next hole he digs
    0941 Caster finds proof that a dangerous secret society runs the world
    0942 Caster finds strong evidence that the apocalypse is nigh
    0943 Caster finds strong evidence that the planet is artificial
    0944 Caster finds the ruins of a vast magical library
    0945 Caster finds the sight of cooked meat to be highly offensive
    0946 Caster finds the whole idea of "names" to be silly and pointless
    0947 Caster finds the wreckage of a seagoing vessel in a nearby forest
    0948 Caster finds two of the three keys needed to unlock the world
    0949 Caster flees this spot and canit return for at least one year
    0950 Caster flees, panic-stricken, at top speed in a random direction
    0951 Caster flickers like a guttering candle for 1d6 turns
    0952 Caster flies into a fury when he removes his shoes
    0953 Caster flies into a murderous rage and attacks his nearest ally
    0954 Caster forgets any fire that he lights
    0955 Caster forgets any first-level spell he now has memorized
    0956 Caster forgets everyoneis name
    0957 Caster forgets everything he knows about etiquette
    0958 Caster forgets how to open his spellbook
    0959 Caster forgets how to use knives and blades of all kinds
    0960 Caster forgets how to use magic for 1d4 days
    0961 Caster forgets how to walk for 1d12 hours
    0962 Caster forgets that his name is a vile expletive in Dwarfish
    0963 Caster gains 1d4 points of Strength; loses one point per day
    0964 Caster gains experience at 2X normal rate until he gains a level
    0965 Caster gains minor access to a formerly forbidden school of magic
    0966 Caster gains no benefit from magical healing during daylight
    0967 Caster gains no benefit from wearing gloves or gauntlets
    0968 Caster gains one pound per level of spells he casts
    0969 Caster gains one pound per round for the next 1d100 rounds
    0970 Caster generally seems to be lying when talking about magic
    0971 Caster gets a splinter every time he wields a wooden weapon
    0972 Caster gives his party two weeksi notice before resigning
    0973 Caster glows as bright as daylight while heis asleep
    0974 Caster goes berserk and attacks the next undead creature he sees
    0975 Caster goes berserk in the presence of royalty
    0976 Caster goes berserk whenever he receives magical healing
    0977 Caster goes on and on about his misunderstood genius
    0978 Caster goes out of his way to appear humble and unassuming
    0979 Caster goes out of his way to avoid using magic in combat
    0980 Caster goes out of his way to be offensive to royalty
    0981 Caster goes out of his way to draw attention to himself in battle
    0982 Caster gradually becomes more and more angular
    0983 Caster gradually becomes more and more turtle-like
    0984 Caster growls in his sleep like a tiger
    0985 Caster grows 1d10 new and mysterious organs in his abdomen
    0986 Caster grows an additional finger each week
    0987 Caster grows one inch per day for the next 2d4-1 days
    0988 Caster hallucinates wildly the next time he drinks water
    0989 Caster hallucinates wildly until he drinks a quart of water
    0990 Caster has 5 Intelligence for 1d6 turns
    0991 Caster has 5 Strength for 1d4 turns
    0992 Caster has 1d100 real-looking but useless copies of his spellbook
    0993 Caster has a +10 bonus on each of his next 1d4 dice rolls
    0994 Caster has a 10% chance to control any Summoned entity he sees
    0995 Caster has a 10% chance to pick any mechanical lock
    0996 Caster has a 25% chance to go blind in each of the next 4 rounds
    0997 Caster has a blood-sworn enemy in every town within 500 miles
    0998 Caster has a clear memory of building himself from scratch
    0999 Caster has a close relative in every town within 500 miles
    1000 Caster has a crystal cube that enables him to see through wood
    1001 Caster has a cumulative 1% chance daily to be eaten by a dragon
    1002 Caster has a cumulative 1% chance daily to turn to stone
    1003 Caster has a flat 10% chance to know any new language he hears
    1004 Caster has a habit of issuing idle but poorly-considered threats
    1005 Caster has a large but harmless hole at the top of his head
    1006 Caster has a parrot on his shoulder and a peg leg
    1007 Caster has a powerful craving for charcoal, sulfur, and saltpeter
    1008 Caster has a powerful craving for the bark of the hemlock tree
    1009 Caster has a reputation, perhaps undeserved, for wild debauchery
    1010 Caster has a scar as if his head were severed and reattached
    1011 Caster has a small keyhole in the palm of his right hand
    1012 Caster has a star-shaped dent at the back of his head
    1013 Caster has a violent argument with the next soldier he meets
    1014 Caster has an almost paralyzing fear of death and the dead
    1015 Caster has an answer for everything
    1016 Caster has an extraordinary sense of balance
    1017 Caster has an identical face on the back of his head
    1018 Caster has an inexplicable but overwhelming fear of sunrise
    1019 Caster has an out-of-body experience and canit find his way back
    1020 Caster has an overpowering hatred of artificial light sources
    1021 Caster has an ugly mole just like a nose
    1022 Caster has an ugly nose just like a mole
    1023 Caster has been carrying a sack full of manure for 1d4 days
    1024 Caster has blasphemous tattoos over most of his body 
    1025 Caster has dreadful dreams of a foul, ancient, and tentacled god
    1026 Caster has faulty direction sense while carrying his spellbook
    1027 Caster has misgivings about those mushrooms he ate yesterday
    1028 Caster has no internal organs; heis a homogenous mush inside
    1029 Caster has no scent whatsoever
    1030 Caster has ramis horns growing from his hips
    1031 Caster has rings on his fingers and bells on his toes
    1032 Caster has scars as if his skeleton had been torn out of his body
    1033 Caster has silly and pornographic tattoos over most of his body
    1034 Caster has ten thumbs in his mouth
    1035 Caster has ten thumbs instead of fingers
    1036 Caster has ten thumbs somewhere on his body
    1037 Caster has tiny mathematical formulae tattooed all over his body
    1038 Caster has vivid but false memories of a past life
    1039 Caster has vivid but false memories of the last 24 hours
    1040 Caster has vivid dreams of his own death each night
    1041 Caster hasnit eaten during the past 1d100 days
    1042 Caster hatches numerous schemes for destroying the world
    1043 Caster hears a heavenly choir singing his praises for 1d4 hours
    1044 Caster hears crickets chirping loudly from now on
    1045 Caster hears malevolent voices nearby whispering about his doom
    1046 Caster hears normally except for voices, which seem subtly muted
    1047 Caster hears the echo of his own voice whenever he speaks
    1048 Caster hears the footfalls of a hungry predator nearby
    1049 Caster hears waves crashing on a beach no matter where he is
    1050 Caster henceforth casts this spell as if heis two levels higher
    1051 Caster henceforth gains an additional hit point at each level
    1052 Caster henceforth has a bonus 10% chance to learn new spells
    1053 Caster henceforth needs only one-third the normal amount of food
    1054 Caster hurls his spellbook as far as he can
    1055 Caster informs people of what he judges his greatest weakness
    1056 Caster insists that heis proficient in some obscure martial art
    1057 Caster invokes dubiously relevant entities in times of stress
    1058 Caster is 1% likely to be killed by a meteor on any given day
    1059 Caster is 5% likely to become a god if he drowns himself
    1060 Caster is 5% likely to become a god if he kills himself by fire
    1061 Caster is 10% likely never to have existed at all
    1062 Caster is 10% likely to be immune to any single dose of poison
    1063 Caster is 10% likely to be invisible to any female that he meets
    1064 Caster is 10% likely to be invisible to any male that he meets
    1065 Caster is 10% likely to be resurrected if his corpse is set afire
    1066 Caster is 10% likely to be totally immune to any single attack
    1067 Caster is 10% likely to believe even the most outrageous of lies
    1068 Caster is 10% likely to have been sired by a powerful demon
    1069 Caster is 10% likely to sympathize with any enemy he injures
    1070 Caster is 15% likely to have read any book he sees
    1071 Caster is 20% likely to faint outright at the sight of blood
    1072 Caster is 20% likely to sneeze and disrupt any spell he casts
    1073 Caster is 20% likely to turn to stone while swimming
    1074 Caster is 2X as old as the oldest person within 100 yards
    1075 Caster is 50% likely to drown in any water deeper than he is tall
    1076 Caster is 60% likely to misplace any money he receives
    1077 Caster is able to see his own eyes
    1078 Caster is absolutely convinced that heis a zombie
    1079 Caster is afflicted with severe frostbite in 1d4 limbs
    1080 Caster is afflicted with vampirism, but only during the day
    1081 Caster is always and easily recognizable as a spellcaster
    1082 Caster is an untamed youth, thatis the truth, with a cloak full of eagles
    1083 Caster is attacked by a shark when he next enters a river
    1084 Caster is attacked by countless stinging earthworms
    1085 Caster is attacked by goats the next time he crosses a bridge
    1086 Caster is attacked by vengeful imps that resemble small children
    1087 Caster is attended by numerous grooming birds, like a crocodile
    1088 Caster is blind unless heis carrying at least 4d10 gold coins
    1089 Caster is blind while heis invisible
    1090 Caster is blind while his spellbook is open
    1091 Caster is blind while within any artificial structure
    1092 Caster is blinded for 2d8 rounds by a swirl of tiny feathers
    1093 Caster is bricked up in an underground cell with a cask of wine
    1094 Caster is briefly obscured by a dense cloud of sawdust
    1095 Caster is briefly paralyzed at the sight of his own blood
    1096 Caster is briefly stunned by a shower of hard beans
    1097 Caster is brutally punched in the stomach by an unseen hand
    1098 Caster is carrying 1d4+1 waterskins filled with human blood
    1099 Caster is carrying a bowl full of water that he must not spill
    1100 Caster is certain that a horrible monster is living inside him
    1101 Caster is certain that every meal he eats contains strong poison
    1102 Caster is certain that he can breathe underwater
    1103 Caster is certain that he has just killed his guardian angel
    1104 Caster is certain that he used to have four arms
    1105 Caster is certain that heill become immortal if heis beheaded
    1106 Caster is certain that heill die in the next 1d4 rounds
    1107 Caster is certain that heis recently returned from the future
    1108 Caster is certain that heis transforming into a horrible monster
    1109 Caster is certain that his soul is buried under the nearest tree
    1110 Caster is chained to a desk in some high-rise office building
    1111 Caster is chained to an anvil
    1112 Caster is clad in funerary wraps as if heis about to be interred
    1113 Caster is completely invulnerable to all harm for 1d4 rounds
    1114 Caster is convinced that he once ate an entire person
    1115 Caster is convinced that he only exists as numbers on paper
    1116 Caster is convinced that his allies plan to kill and eat him
    1117 Caster is covered in a shell of frozen slime
    1118 Caster is covered in barnacles
    1119 Caster is covered in indelible, jet-black handprints
    1120 Caster is covered in ketchup
    1121 Caster is covered in peanut butter
    1122 Caster is covered in sucker marks as though hugged by an octopus
    1123 Caster is deaf and blind until sunrise tomorrow
    1124 Caster is determined to destroy his staff or spellbook
    1125 Caster is determined to rid himself of his nails, teeth, and hair
    1126 Caster is distracted by something stuck between his teeth
    1127 Caster is drawn forcefully toward the spellis target point
    1128 Caster is dressed like a high-class burlesque performer
    1129 Caster is eager to find out just how fireproof he really is
    1130 Caster is eager to find out just how much blood he can lose
    1131 Caster is encased from the waist down in a block of cheese
    1132 Caster is encased up to his neck in a shell of concrete
    1133 Caster is enclosed in a large paper bag
    1134 Caster is entirely immune to magic for 1d8 rounds
    1135 Caster is feared and respected by Hill Giants
    1136 Caster is fiercely addicted to some astonishingly rare substance
    1137 Caster is filled with Righteous Indignation
    1138 Caster is forcibly barred from the next town he attempts to enter
    1139 Caster is full oi the milk of human kindness
    1140 Caster is half the age of the youngest person within 100 yards
    1141 Caster is Healed each time he triggers a Chaos Burst
    1142 Caster is held responsible for the massacre of innocent townsfolk
    1143 Caster is held without counsel in a secure location for 1d4 days
    1144 Caster is horribly afraid to use magic weapons in daylight
    1145 Caster is horribly afraid to use metal weapons
    1146 Caster is hurled from here into the nearest lake
    1147 Caster is immune to all attempts at telepathy or mind-reading
    1148 Caster is immune to all harm until he attacks or uses magic
    1149 Caster is immune to all poisons, but normal ice is deadly to him
    1150 Caster is immune to any bludgeon not forged on this world
    1151 Caster is immune to any poison administered via blade or needle
    1152 Caster is immune to any poison ingested with food or drink
    1153 Caster is immune to beneficial clerical magic for 1d6 days
    1154 Caster is immune to beneficial enchantments for 1d8 days 
    1155 Caster is immune to cold-based attacks while blindfolded
    1156 Caster is immune to cold-based attacks while heis on fire
    1157 Caster is immune to electrical attacks while heis barefoot
    1158 Caster is immune to electrical magic at night while itis snowing
    1159 Caster is immune to fear while holding a spider in his mouth
    1160 Caster is immune to fire from the waist down
    1161 Caster is immune to fire while holding a wrenis egg in his mouth
    1162 Caster is immune to gaze attacks while holding his open spellbook
    1163 Caster is immune to gaze attacks while singing
    1164 Caster is immune to liquid-based poisons for one year
    1165 Caster is immune to magic for 1d8 days but canit use magic either
    1166 Caster is immune to magic until he imbibes any liquid
    1167 Caster is immune to missile-based spells while naked
    1168 Caster is immune to natural cold while naked and unencumbered
    1169 Caster is immune to necromantic magic while standing on his head
    1170 Caster is immune to necromantic magic while wearing silk mittens
    1171 Caster is immune to non-magical charm-based effects
    1172 Caster is immune to non-magical disease while holding a chicken
    1173 Caster is immune to non-magical missiles for 1d8 hours
    1174 Caster is immune to non-magical venom
    1175 Caster is immune to non-magical, non-gaseous poisons
    1176 Caster is immune to oil-based fire for 1d12 months
    1177 Caster is immune to poison gas while his feet are wet
    1178 Caster is immune to sarcasm
    1179 Caster is immune to the effects of dehydration
    1180 Caster is immune to the effects of illusory sound
    1181 Caster is immune to the effects of smoke inhalation
    1182 Caster is immune to the effects of the Wish spell
    1183 Caster is immune to the next 1d100 hit points of fire damage
    1184 Caster is inappropriately frank about his bodily functions
    1185 Caster is inclined to attack any who offer him magical healing
    1186 Caster is inclined to attack anyone representing the crown
    1187 Caster is increasingly convinced that he just might be a deity
    1188 Caster is intensely curious about the limits of his own mortality
    1189 Caster is intensely curious about the taste of certain poisons
    1190 Caster is invisible from his hips to his sternum
    1191 Caster is invisible to 1d4 people nearby
    1192 Caster is invisible to dragons for one year
    1193 Caster is invisible to dragons while in direct sunlight
    1194 Caster is invisible to female herbivores
    1195 Caster is invisible to females for 2d6 turns
    1196 Caster is invisible to Hill Giants
    1197 Caster is invisible to himself for 1d4 weeks
    1198 Caster is invisible to himself from the waist down
    1199 Caster is invisible to horses
    1200 Caster is invisible to infravision
    1201 Caster is invisible to inherently invisible creatures
    1202 Caster is invisible to males for 2d6 turns
    1203 Caster is invisible to members of his immediate family
    1204 Caster is invisible to non-magical reptiles
    1205 Caster is invisible to non-magical reptiles for 1d4 hours
    1206 Caster is invisible to the person who most recently wounded him
    1207 Caster is invisible while underwater
    1208 Caster is invited to join a colony of cannibals for dinner
    1209 Caster is known to have had illicit dealings with the undead
    1210 Caster is known to have predicated in scandalous fertility rites
    1211 Caster is naturally camouflaged for stealth in a snowy setting
    1212 Caster is nearly paralyzed by fear while his spellbook is open
    1213 Caster is on the verge of starvation, no matter how much he eats
    1214 Caster is owed a favor by the local magistrate
    1215 Caster is paralyzed from the neck up for 1d6 rounds
    1216 Caster is partially immune to magical cold while holding an apple
    1217 Caster is permanently disfigured by the next fire he sets
    1218 Caster is permanently invisible to the next person to injure him
    1219 Caster is pinned beneath a large tombstone bearing his name
    1220 Caster is poisoned and has 6d6 days to find its only antidote
    1221 Caster is punctured as if heid spent the night in an iron maiden
    1222 Caster is ravenously hungry after each battle
    1223 Caster is reduced to first level for 4d6 hours
    1224 Caster is reduced to one hit point when he next triggers a Burst
    1225 Caster is related by blood to no one who has ever lived
    1226 Caster is reluctant to bring his spellbook indoors
    1227 Caster is reluctant to carry any weapons after sunset
    1228 Caster is reluctant to cast any spell that he now has memorized
    1229 Caster is reluctant to enter any building heis previously entered
    1230 Caster is reluctant to get blood on any of his weapons
    1231 Caster is reluctant to wield any weapon that hasnit drawn blood
    1232 Caster is rumored to be an artificial, creature without a soul
    1233 Caster is rumored to be plotting a political assassination
    1234 Caster is rumored to be protected by a mighty dragon
    1235 Caster is rumored to be the reincarnation of a despised tyrant
    1236 Caster is rumored to drink orcis blood by the quart
    1237 Caster is rumored to have been replaced by an infernal impostor
    1238 Caster is rumored to have killed the last person to ask his name
    1239 Caster is rumored to have murdered hundreds of innocent people
    1240 Caster is rumored to have orcis blood flowing through his veins
    1241 Caster is rumored to have paid orcs to perform unseemly services
    1242 Caster is rumored to have participated in dreadful funerary rites
    1243 Caster is rumored to have participated in genocide against Elves
    1244 Caster is rumored to have participated in the murder of a deity
    1245 Caster is rumored to have performed horrid rituals on Dwarves
    1246 Caster is rumored to have placed a huge bounty on his own head
    1247 Caster is rumored to have sold his family into slavery
    1248 Caster is rumored to have the heart of a goblin
    1249 Caster is rumored to have wronged a member of the royal family
    1250 Caster is rumored to use clairvoyance for purposes of voyeurism
    1251 Caster is scarred as if heid been burned over 80% of his body
    1252 Caster is scrupulously honest in all financial dealings
    1253 Caster is sealed in a huge but otherwise normal chicken egg
    1254 Caster is sealed in a pine coffin
    1255 Caster is sealed in an oak barrel
    1256 Caster is seated on a platform high atop a tall, narrow pole
    1257 Caster is skilled in a new weapon but canit use it in daylight
    1258 Caster is Slowed when he becomes invisible
    1259 Caster is smeared from head to toe with molasses
    1260 Caster is soaked each time he casts a water-based spell
    1261 Caster is somewhere around Barstow, on the edge of the desert
    1262 Caster is soon jailed for public lewdness and profanity
    1263 Caster is soon jailed for suspicion of murder
    1264 Caster is soon jailed for unlawful use of magical knowledge
    1265 Caster is sought by a band of militant vivisectionists
    1266 Caster is sparsely flecked with salt like a pretzel
    1267 Caster is standing in an open field, west of a white house
    1268 Caster is stricken mute until heis cut by a magic weapon
    1269 Caster is stripped of monetary wealth except what heis carrying
    1270 Caster is suddenly alone at the center of a vast field of slag
    1271 Caster is suddenly carrying a twenty-pound sack full of straw
    1272 Caster is suddenly in the throes of advanced labor
    1273 Caster is suddenly on the other side of the nearest locked door
    1274 Caster is suddenly seated on a throne formed of apple cores
    1275 Caster is suddenly sitting in an elegant bathtub
    1276 Caster is suddenly standing at the base of the nearest waterfall
    1277 Caster is suddenly standing atop a single stilt
    1278 Caster is suddenly standing atop a very tall ladder
    1279 Caster is suddenly standing atop the nearest boulder
    1280 Caster is suddenly standing atop the nearest horse
    1281 Caster is suddenly standing in a bucket of butter
    1282 Caster is suddenly standing in a canoe on a rushing river
    1283 Caster is suddenly standing in the middle of a snow-covered field
    1284 Caster is suddenly standing in the nearest blacksmithis smithy 
    1285 Caster is suddenly standing in the nearest brothel
    1286 Caster is suddenly standing in the nearest holy water font
    1287 Caster is suddenly standing in the nearest pig sty
    1288 Caster is suddenly standing knee-deep in manure
    1289 Caster is suddenly standing on a two-foot cube of solid aluminum
    1290 Caster is suddenly surrounded by a quartet of skunks
    1291 Caster is suddenly unsure that he really wants to be a magic user
    1292 Caster is suddenly wearing a full suit of Elven chain armor
    1293 Caster is surrounded by eight-foot-tall slabs of concrete
    1294 Caster is suspected of plotting the destruction of the world
    1295 Caster is terrible at estimating quantities, distance, and time
    1296 Caster is terrified of hourglasses and time-keeping devices
    1297 Caster is the victim of a vast, well-coordinated conspiracy
    1298 Caster is the victim of a well-coordinated propaganda assault
    1299 Caster is the worst liar in the history of intelligent discourse
    1300 Caster is thickly shrouded in cobwebs
    1301 Caster is thoroughly entangled in the tentacles of a man-of-war
    1302 Caster is thoroughly smeared in bacon grease
    1303 Caster is thoroughly soaked with egg whites
    1304 Caster is thought to have a huge bounty on his head
    1305 Caster is thrown 1d4x1000 years into the future for 1d4 rounds
    1306 Caster is thrown 4d6 feet into the air
    1307 Caster is thrown 4d6 hours into the future
    1308 Caster is thrown violently backward from the spellis target point
    1309 Caster is tightly bound in strong wire
    1310 Caster is tightly wrapped in a straightjacket
    1311 Caster is trampled by a boar
    1312 Caster is trapped in a column of brackish water for 1d4 rounds
    1313 Caster is unable to ask questions
    1314 Caster is unable to cross any bridge that spans flowing water
    1315 Caster is unable to enter into infernal pacts
    1316 Caster is unaffected by magical wind for 1d4 months
    1317 Caster is unaffected by magically-created metal
    1318 Caster is unaffected by natural wind
    1319 Caster is unaffected by the spell Remove Curse
    1320 Caster is unharmed by extremes of sound
    1321 Caster is unharmed by moldy or rotten food
    1322 Caster is universally treated like a hated criminal for 1d8 days
    1323 Caster is unknowingly inducted into a secret society
    1324 Caster is utterly unable to assess his own injuries
    1325 Caster is utterly unable to disguise himself by magic
    1326 Caster is vaguely aware of any deliberate threat upon his life
    1327 Caster is very susceptible to peer pressure in matters of alcohol
    1328 Caster is violently ejected from the next building he enters
    1329 Caster is wearing a deep-sea diving costume with copper helmet
    1330 Caster is wearing a welderis mask and canit remove it until dawn
    1331 Caster is wearing an ornate mask made of the most delicate glass
    1332 Caster is wearing blood-soaked surgical gloves
    1333 Caster is wearing boxing gloves and canit remove them until dawn
    1334 Caster is wearing bunny fur
    1335 Caster is wearing clothes that are 10d10 centuries out of date
    1336 Caster is wearing enough clothing for 3d4 people
    1337 Caster is wearing extraordinarily glamorous false eyelashes
    1338 Caster is wearing golf shoes
    1339 Caster is wearing his motheris wedding gown
    1340 Caster is wearing horseshoes
    1341 Caster is wearing ice skates
    1342 Caster is wearing nothing but a thin loincloth
    1343 Caster is wearing roller skates
    1344 Caster is wearing snowshoes and canit remove them until it snows
    1345 Caster is wearing the clothes that heill be wearing when he dies
    1346 Caster is wearing the leathered skin of a recently dead king
    1347 Caster is wearing what appears to be his heart on his sleeve
    1348 Caster is widely known to be a reprehensible hedonist
    1349 Caster is worshipped as a god by some degenerate, isolated tribe
    1350 Caster is wracked by searing pain every time he asks a question
    1351 Caster is wracked by searing pain when he draws anotheris blood
    1352 Caster is wracked by searing pain when he touches the undead
    1353 Caster isnit quite certain that heis not the spawn of a demon
    1354 Caster jams both thumbs deep into his nostrils for 1d6 rounds
    1355 Caster just barely passes for a member of his race
    1356 Caster keeps smelling burnt toast
    1357 Caster keeps talking despite everyoneis utter lack of interest
    1358 Caster knows a method by which gold can be tempered like steel
    1359 Caster knows a new language for 1d4 weeks
    1360 Caster knows a spell that will slay him instantly
    1361 Caster knows that heill go mad if he says his name aloud
    1362 Caster knows the location of every mammal now within one mile
    1363 Caster knows the secret language of frogs and toads
    1364 Caster laughs heartily when he sees his allies injured
    1365 Caster leaps from the next bridge that he crosses
    1366 Caster learns a damaging secret about one of his allies
    1367 Caster learns that heis been assigned to some government position
    1368 Caster learns that his arranged marriage is due to occur tomorrow
    1369 Caster learns that his parents were undead on the day he was born
    1370 Caster leaves no footprints in snow
    1371 Caster likes to tell everyone that he has an eidetic memory
    1372 Caster looks as if heis been submerged in a bog for six months
    1373 Caster loses 10d1000 gold pieces in a wacky investment scheme
    1374 Caster loses 1d10 hit points if a nearby cleric Turns Undead
    1375 Caster loses 1d10 points of Strength; regains one point per day
    1376 Caster loses 1d4 hit points each round that heis invisible
    1377 Caster loses 1d4 hit points every time he speaks a pun
    1378 Caster loses 1d4 hit points per hour until sunset tonight
    1379 Caster loses 3d8 hit points any time he uses the spell Read Magic
    1380 Caster loses access to a single school of magic for 1d4 weeks
    1381 Caster loses access to all but one school of magic for 2d6 days
    1382 Caster loses all comprehension of the concept of money
    1383 Caster loses all hair on the left side of his body
    1384 Caster loses one hit point each time he calls someone by name
    1385 Caster loses one hit point per level of spells cast in sunlight
    1386 Caster loses one point of Charisma for each hit point he loses
    1387 Caster loses one point of Charisma per day for 3d6 weeks
    1388 Caster loses one pound per level of spell he casts
    1389 Caster loses only 1 hit point from the next 3d8 attacks upon him
    1390 Caster makes outrageous bets about the most unlikely events
    1391 Caster mentions a wish to join a secret society called The Tres
    1392 Caster mispronounces everyoneis name, offensively if possible
    1393 Caster must carry at least one pound of raw meat at all times
    1394 Caster must carry his spellbook in hand, not in a bag or pouch
    1395 Caster must drink his weight in water by sunset
    1396 Caster must drink salt water instead of fresh water
    1397 Caster must eat at least one pound of salt each week
    1398 Caster must include a vile expletive in every sentence he speaks
    1399 Caster must insult any figure of authority at least 1d4 times
    1400 Caster must Save or his arms start decomposing as if heis dead
    1401 Caster must Save or turn into an anthropomorphic weasel
    1402 Caster must Save vs Fortitude or food turns to iron in his mouth
    1403 Caster must Save vs Fortitude or his lungs turn to gold
    1404 Caster must Save vs Fortitude, or his weight doubles
    1405 Caster must Save vs Will or attempt to disembowel himself
    1406 Caster must Save vs Will or begin aging twenty years per round
    1407 Caster must Save vs Will, or he becomes permanently illiterate
    1408 Caster must state his name to anyone who asks it
    1409 Caster no longer able to share with others
    1410 Caster no longer believes that magic really exists
    1411 Caster no longer needs to eat but canit heal injuries naturally
    1412 Caster no longer perspires
    1413 Caster no longer produces saliva
    1414 Caster now breathes nitrogen instead of oxygen 
    1415 Caster obsessively pursues his goal of acquiring a second head
    1416 Caster offers to sell his spellbook to the lowest bidder
    1417 Caster only needs to eat during alternating weeks
    1418 Caster owes 10d100 gold pieces to the next person he touches
    1419 Caster owes 1d4 gold pieces to everyone within 100 yards
    1420 Caster owes a colossal sum of money to a local lender
    1421 Caster owes his life to someone who wonit be born for centuries
    1422 Caster perceives an assassin hiding behind every tree and rock
    1423 Caster perceives marbles to be rolling around inside his skull
    1424 Caster perceives mysterious ships to be flying in the air nearby
    1425 Caster permanently gains 1d4-1 hit points
    1426 Caster permanently gains an additional 1d4 hit points
    1427 Caster permanently loses 1d4-1 hit points
    1428 Caster permanently loses the sense of taste
    1429 Caster prefers not to cast magic indoors
    1430 Caster prefers not to cast magic unless itis raining
    1431 Caster prefers not to cast magic while anyone is watching him
    1432 Caster prefers not to cast magic while itis raining
    1433 Caster projects an air of competence even when itis unwarranted
    1434 Caster prophesies that heill die by drowning in melted butter
    1435 Caster publicly curses a member of the royal family
    1436 Caster pursues a disastrous fiscal policy despite public outcry
    1437 Caster quickly rusts if someone elseis blood touches him
    1438 Caster randomly teleports 1d100 yards when he becomes invisible
    1439 Caster raves like a lunatic whenever he witnesses a spellcasting
    1440 Caster reacts to hospitality with shocking boorishness
    1441 Caster reacts violently to any perceived insults
    1442 Caster reacts violently to anyone bearing a coat-of-arms
    1443 Caster reacts violently to anyone he hears using improper grammar
    1444 Caster reacts violently to anyone who asks his name
    1445 Caster reacts violently to conspicuous rhymes in speech
    1446 Caster reacts violently to offers of food or water
    1447 Caster reacts violently to religious symbols displayed in battle
    1448 Caster reacts violently to the scent of baking bread
    1449 Caster realizes heis an escaped slave whose owner is tracking him
    1450 Caster realizes that chickens and ducks are plotting a mutiny
    1451 Caster realizes that heis his left arm isnit actually attached
    1452 Caster realizes that heis lived this day repeatedly for years
    1453 Caster realizes that heis skilled in the use of the bola
    1454 Caster realizes that heis standing on a trapdoor over a deep pit
    1455 Caster realizes that heis very close to fulfilling his destiny
    1456 Caster realizes that his name is a synonym for manure
    1457 Caster recalls enduring hideous torture but doesnit know when
    1458 Caster recalls every insult with remarkable clarity
    1459 Caster receives a divine vision of some dreadfully mundane event
    1460 Caster receives no Save against the next spell cast against him
    1461 Caster recently drank a poison or a potion; he canit recall which
    1462 Caster recently found a powerful artifact but doesnit realize it
    1463 Caster recently took an inviolable vow but can quite remember it
    1464 Caster recites a long list of grievances against his allies
    1465 Caster recites that bit from Macbeth whenever he holds a dagger
    1466 Caster refers to his allies by cute nicknames
    1467 Caster refers to his spellbook as his "Booky-Wooky"
    1468 Caster refuses to carry any gems or jewels
    1469 Caster refuses to eat in the presence of Dwarves
    1470 Caster refuses to enter any town that isnit encircled by a wall
    1471 Caster refuses to handle any blade that hasnit drawn blood
    1472 Caster refuses to rage, rage against the dying of the light
    1473 Caster refuses to speak to anyone while his spellbook is open
    1474 Caster refuses to speak to anyone who addresses him by name
    1475 Caster refuses to speak with one particular ally
    1476 Caster refuses to wield any weapon not engraved with his name
    1477 Caster refuses to wield any weapon that has ever drawn blood
    1478 Caster repeats the next round 1d100 times
    1479 Caster requires only 1d8 hours of sleep per week
    1480 Caster reveals that he enjoys the taste of roasted Dwarf
    1481 Caster reveals that heis a doppelganger
    1482 Caster routinely forgets magical command words
    1483 Caster routinely forgets that he canit breathe underwater
    1484 Caster routinely forgets that poisons are harmful when ingested
    1485 Caster routinely forgets the reason he stood up, sat down, etc.
    1486 Caster routinely forgets to douse campfires, cooking fires, etc.
    1487 Caster routinely forgets to draw a weapon before attacking
    1488 Caster routinely forgets to eat, even when heis famished
    1489 Caster routinely forgets to lie down before sleeping
    1490 Caster routinely forgets to put his clothes on after bathing
    1491 Caster routinely forgets to remove his clothes before bathing
    1492 Caster routinely forgets where he is and where heis going
    1493 Caster routinely forgets where he left his spellbook
    1494 Caster routinely forgets whether or not heis wearing armor
    1495 Caster routinely forgets which spells he has memorized
    1496 Caster routinely loses his train of thought mid-sentence
    1497 Caster runs to and attempts to uproot the nearest tree
    1498 Caster runs to the nearest abattoir
    1499 Caster seeks sanctuary in the nearest brothel
    1500 Caster sees as if everything is cloaked in perpetual twilight
    1501 Caster sees as if his eyes were hovering one foot to the left
    1502 Caster sees as if his eyes were in the back of his head
    1503 Caster sees as if his eyes were where his ears are
    1504 Caster sees colorful ribbons swirling in the air around him
    1505 Caster sees cryptic messages in the patterns of plant growth
    1506 Caster sees everything as if heis deep underwater
    1507 Caster sees everything as through a glass, darkly
    1508 Caster sees geysers of flaming pitch erupting all around him
    1509 Caster sees ghostly courtesans all around him
    1510 Caster sees huge bats and manta rays whirling all around him
    1511 Caster sees in daylight as if itis night, and vice versa
    1512 Caster sees menacing, shadowy figures everywhere he goes
    1513 Caster sees the spellis target point as a place of great holiness
    1514 Caster selected todayis attire with insufficient forethought
    1515 Caster seriously considers abandoning magic for all time
    1516 Caster seriously considers entering the clergy
    1517 Caster shatters like glass if he falls more than 2X his height
    1518 Caster shivers uncontrollably in the presence of fire
    1519 Caster shows all signs of plague but is actually quite healthy
    1520 Caster shows everyone his wounds and asks if they look infected
    1521 Caster shrieks like a fire alarm in the presence of fire
    1522 Caster shrinks by 50% upon losing 50% of his hit points
    1523 Caster shuns the company of other magic users
    1524 Caster shuns the use of magic items as being "amateurish"
    1525 Caster shuns the use of weapons that contain ferrous metal
    1526 Caster sinks like a stone in water but cannot drown
    1527 Caster smells faintly of cabbage
    1528 Caster smells strongly burnt toast
    1529 Caster smells strongly of alcohol
    1530 Caster smells strongly of blood while heis wet
    1531 Caster smells strongly of boiling tar
    1532 Caster smells strongly of exotic perfumes
    1533 Caster smells strongly of fuel oil
    1534 Caster smells strongly of fungus while heis near a campfire
    1535 Caster smells strongly of garlic
    1536 Caster smells strongly of peppermint
    1537 Caster smells strongly of rose petals
    1538 Caster sneezes 1d20 times in each of the next 1d20 rounds
    1539 Caster sneezes repeatedly when he becomes invisible
    1540 Caster sparkles as though dusted with glitter from now on
    1541 Caster speaks in an obviously fake and irritating Cockney accent
    1542 Caster spends 1d4 rounds attacking the nearest tree
    1543 Caster spends 1d4 rounds attempting to ignite his shoes
    1544 Caster spends 1d4 rounds trying to cast this same spell 
    1545 Caster spends 1d4 rounds trying to strangle himself with his hair
    1546 Caster spends 2d10 rounds racing toward the nearest coastline
    1547 Caster spends 2d10 rounds trying to look into his own ears
    1548 Caster spends all of his money on the next thing he buys
    1549 Caster spews philosophical gobbledygook about one-hand-clapping
    1550 Caster spouts water like a gargoyle for 1d4 rounds
    1551 Caster spreads vicious and embarrassing rumors about himself
    1552 Caster sprouts a dorsal fin
    1553 Caster sprouts a ghastly tentacle from the center of his chest
    1554 Caster sprouts a large, spongy mass between his shoulder blades
    1555 Caster sprouts a mane like a lionis
    1556 Caster sprouts a new ear on the back of one hand
    1557 Caster sprouts a pretty flower from his chin
    1558 Caster sprouts a prominent brow ridge
    1559 Caster sprouts a retractable metal antenna from his forehead
    1560 Caster sprouts a small, flaming wick atop of his head
    1561 Caster sprouts a tiny horn from the tip of his nose
    1562 Caster sprouts a zipper along the length of his spine
    1563 Caster sprouts an additional ear behind each of his normal ears
    1564 Caster sprouts an eye at the exact top of his head
    1565 Caster sprouts an ugly protuberance from his forearm
    1566 Caster sprouts sharp blades along the edges of his forearms
    1567 Caster sprouts tiny, useless wings from the bridge of his nose
    1568 Caster sprouts wild-looking feathers on his cheeks
    1569 Caster sprouts wires and rubber tubing from his flesh
    1570 Caster stands in uffish thought for 3d4 rounds
    1571 Caster stares at the spellis target point for 1d10 rounds
    1572 Caster starts billing his allies for each spell he casts
    1573 Caster starts dancing and canit stop until heis struck by magic
    1574 Caster starts running and thinks heill explode if he stops
    1575 Caster steps into a snare and is hoisted high into a tree
    1576 Caster steps onto a loose stone and tumbles down the nearest hill
    1577 Caster sticks to the next metal item he touches for 1d6 turns
    1578 Caster stumbles into the next campfire that he passes
    1579 Caster suddenly has 2d4+2 toes jutting from his face
    1580 Caster suddenly has feet like an elephant
    1581 Caster suddenly has misgivings about his skill as a magic user
    1582 Caster suddenly has ten toes on each foot
    1583 Caster suddenly has ten toes on one foot and none on the other
    1584 Caster suddenly realizes that heis been naked for 2d8 days
    1585 Caster suddenly realizes that his clothing is made of human skin
    1586 Caster suddenly starts hemorrhaging honey and molasses
    1587 Caster suffers 10X normal damage from falls of more than 20 feet
    1588 Caster suffers 2x the damage from the next 1d4 attacks on him
    1589 Caster suffers acute paranoia whenever he hears his name
    1590 Caster suffers an intense, debilitating fever for 1d4 days
    1591 Caster suffers bouts of rampant xenophobia
    1592 Caster suffers brief pain every time he closes a book
    1593 Caster suffers cramps if he uses magic within an hour of eating
    1594 Caster suffers crippling arthritis pain
    1595 Caster suffers delusions about the efficacy of the Free Market
    1596 Caster suffers fools gladly
    1597 Caster suffers incredible fear the next time he crosses a bridge
    1598 Caster suffers intense pain during attempts at magical healing
    1599 Caster suffers intense pain in his eyes whenever he sees undead
    1600 Caster suffers intense pain whenever he changes shape
    1601 Caster suffers intense pain whenever he eats cooked meat
    1602 Caster suffers intense pain whenever he enters a temple or church
    1603 Caster suffers intense pain whenever he passes through a doorway
    1604 Caster suffers intense pain whenever he treads upon grass
    1605 Caster suffers intense pain whenever he tries to sing
    1606 Caster suffers intense pain whenever he uses Divination magic
    1607 Caster suffers intense pain whenever he wields a magical blade
    1608 Caster suffers maximum damage from the next 1d4 attacks upon him
    1609 Caster suffers the bends as if he surfaced too quickly
    1610 Caster suffers the tortures of the damned for 1d4 hours
    1611 Caster suspects that all foliage nearby is hostile to him
    1612 Caster suspects that everyone nearby is trying to rob him
    1613 Caster suspects that his allies have all joined a dangerous cult
    1614 Caster suspects that his use of magic is entirely delusional
    1615 Caster suspects that someone nearby has taken over his mind
    1616 Caster suspects that someone nearby is a mechanical automaton
    1617 Caster takes a big bite out of his spellbook
    1618 Caster takes a big bite out of the nearest statue
    1619 Caster takes a big bite out of the nearest tree
    1620 Caster takes a vow of absolute pacifism for 2d4-1 days
    1621 Caster teleports one mile the next time he crosses a river
    1622 Caster teleports to exactly where he was standing an hour ago
    1623 Caster teleports to the planetis moon for 1d4 hours
    1624 Caster teleports to the site of another casteris Chaos Burst
    1625 Caster teleports to the site of the most recent state execution
    1626 Caster teleports to the spot where he last ate
    1627 Caster tells everyone that he has an eidetic memory
    1628 Caster tells everyone that his bones are made of diamond
    1629 Caster tells malicious lies about his employer or benefactor
    1630 Caster tells malicious lies in the presence of clergy
    1631 Caster tends to be marked as the strongest member of his party
    1632 Caster tends to become briefly invisible at inconvenient times
    1633 Caster tends to dribble heavily when drinking from a mug or cup
    1634 Caster thinks that "high-ho, high-ho" is a proper Dwarf greeting
    1635 Caster thinks that a distant mountain is made of gold
    1636 Caster thinks that a huge fire is blazing all around him
    1637 Caster thinks that a magic candle is burning in his stomach
    1638 Caster thinks that a nearby ally is sapping his magical energies
    1639 Caster thinks that a past life is intruding upon his current one
    1640 Caster thinks that a snake runs the length of his digestive tract
    1641 Caster thinks that a violent hailstorm is going on
    1642 Caster thinks that all fire is an illusion
    1643 Caster thinks that all of his suspicions are justified
    1644 Caster thinks that all other magic users are out to get him
    1645 Caster thinks that all royalty is hopelessly corrupt
    1646 Caster thinks that an ally will kill him before sunset tomorrow
    1647 Caster thinks that any wound he receives is much, much worse
    1648 Caster thinks that elementals pose no threat to him
    1649 Caster thinks that every herbivore in the world hates him
    1650 Caster thinks that every scratch will infect him with lycanthropy
    1651 Caster thinks that everyone he knows is an impostor
    1652 Caster thinks that everyone is jealous of his magical prowess
    1653 Caster thinks that everyone thinks that he is an impostor
    1654 Caster thinks that everything he owns has been replaced by a copy
    1655 Caster thinks that everything he owns is powerfully enchanted
    1656 Caster thinks that evil beings will kill to possess his spellbook
    1657 Caster thinks that food prepared by others is poisonous to him
    1658 Caster thinks that gold will burn him if placed against his skin
    1659 Caster thinks that he came into existence just 1d4 days ago
    1660 Caster thinks that he can become invisible to undead at will
    1661 Caster thinks that he can command dragons to do his bidding
    1662 Caster thinks that he can communicate with ants
    1663 Caster thinks that he can communicate with cats
    1664 Caster thinks that he can fly by leaping off of tall buildings
    1665 Caster thinks that he can handle red-hot metal without harm
    1666 Caster thinks that he can neutralize poisons by swallowing them
    1667 Caster thinks that he can restore the undead to true life
    1668 Caster thinks that he can speak directly to his deity
    1669 Caster thinks that he can speak with birds
    1670 Caster thinks that he can survive many hammer blows to the skull
    1671 Caster thinks that he died during his youth
    1672 Caster thinks that he has a weakness to green rock
    1673 Caster thinks that he has diplomatic immunity
    1674 Caster thinks that he has the power to speak prophecy 
    1675 Caster thinks that he is attended by invisible undead retainers
    1676 Caster thinks that he just died and is now a zombie
    1677 Caster thinks that he knows the location of a vast horde of gold
    1678 Caster thinks that he looks totally different after each sunrise
    1679 Caster thinks that he must eat a pound of soil by midnight
    1680 Caster thinks that he must hold an awkward item to cast magic
    1681 Caster thinks that he must learn a new spell before sunset
    1682 Caster thinks that he must protect the target at all costs
    1683 Caster thinks that he must quickly remove and burn his clothes
    1684 Caster thinks that he must undertake some bizarre quest
    1685 Caster thinks that he owes thousands of gold pieces to the king
    1686 Caster thinks that he owns everything now in his line of sight
    1687 Caster thinks that he smells strongly of manure
    1688 Caster thinks that heill be a god if he removes all of his skin
    1689 Caster thinks that heill be canonized immediately after his death
    1690 Caster thinks that heill be eaten by zombies if he falls asleep
    1691 Caster thinks that heill be executed for treason at dawn tomorrow
    1692 Caster thinks that heill be executed for treason if he uses magic
    1693 Caster thinks that heill be immolated if he uses magical fire
    1694 Caster thinks that heill be killed in his sleep one night soon
    1695 Caster thinks that heill catch a disease if he uses magic items
    1696 Caster thinks that heill combust if he gets wet
    1697 Caster thinks that heill combust if he tells a lie
    1698 Caster thinks that heill combust unless he wears a garland of ivy
    1699 Caster thinks that heill contract every disease he encounters
    1700 Caster thinks that heill die if a particular person nearby dies
    1701 Caster thinks that heill die unless he eats a magical scroll
    1702 Caster thinks that heill drown in the next water he crosses
    1703 Caster thinks that heill excrete diamonds if he ingests coal
    1704 Caster thinks that heill melt if he gets too close to a fire
    1705 Caster thinks that heis a master thief
    1706 Caster thinks that heis a priest of a foul, tentacled monstrosity
    1707 Caster thinks that heis actually 10X older than he appears to be
    1708 Caster thinks that heis aging at a rate of one year per hour
    1709 Caster thinks that heis been declared The Protector Of The Forest
    1710 Caster thinks that heis been spared for some infernal purpose
    1711 Caster thinks that heis being attacked by piranha
    1712 Caster thinks that heis being attacked by the nearest boulder
    1713 Caster thinks that heis being consumed by invisible worms
    1714 Caster thinks that heis being held against his will
    1715 Caster thinks that heis being savaged by rabid dogs
    1716 Caster thinks that heis being squeezed by a large python
    1717 Caster thinks that heis dead and hopes his allies donit find out
    1718 Caster thinks that heis destined to be hanged at midnight tonight
    1719 Caster thinks that heis destined to die in a comical fashion
    1720 Caster thinks that heis died and gone to heaven
    1721 Caster thinks that heis fireproof while heis naked
    1722 Caster thinks that heis guilty of sedition and treason
    1723 Caster thinks that heis highly combustible
    1724 Caster thinks that heis immune to lycanthropy
    1725 Caster thinks that heis immune to necromantic magic
    1726 Caster thinks that heis immune to non-magical diseases
    1727 Caster thinks that heis indentured to some nearby landowner
    1728 Caster thinks that heis invincible while heis talking
    1729 Caster thinks that heis invulnerable to magical weapons
    1730 Caster thinks that heis invulnerable to missile weapons
    1731 Caster thinks that heis invulnerable while heis invisible
    1732 Caster thinks that heis invulnerable while wearing a hat
    1733 Caster thinks that heis just escaped from rogue vivisectionists
    1734 Caster thinks that heis next in line for the throne of hell
    1735 Caster thinks that heis on fire and begs people to extinguish him
    1736 Caster thinks that heis raised himself from the dead
    1737 Caster thinks that heis seeing through someone elseis eye
    1738 Caster thinks that heis slowly transforming into a dragon
    1739 Caster thinks that heis sold his soul to several different demons
    1740 Caster thinks that heis sold his soul to that guy at the market
    1741 Caster thinks that heis soon to be bronze-plated
    1742 Caster thinks that heis standing at the edge of a cliff
    1743 Caster thinks that heis standing in a chest-high heap of manure
    1744 Caster thinks that heis standing in waist-deep water
    1745 Caster thinks that heis standing on a tall, narrow staircase
    1746 Caster thinks that heis stolen this body from its rightful owner
    1747 Caster thinks that heis the child of some unlikely person nearby
    1748 Caster thinks that heis the lizard king and can do anything
    1749 Caster thinks that heis the man in the moon
    1750 Caster thinks that heis the victim of an elaborate practical joke
    1751 Caster thinks that heis the victim of circumstance
    1752 Caster thinks that heis water soluble
    1753 Caster thinks that his actions are fulfilling ancient prophecy
    1754 Caster thinks that his allies will all be dead before morning
    1755 Caster thinks that his alliesi wounds are much more serious
    1756 Caster thinks that his ancestors are speaking through his allies
    1757 Caster thinks that his ancestors came from a distant world
    1758 Caster thinks that his brain will pop if he learns one more spell
    1759 Caster thinks that his clothing is drenched in strong acid
    1760 Caster thinks that his current alignment isnit his true alignment
    1761 Caster thinks that his death will bring about the apocalypse
    1762 Caster thinks that his death will open the gates of heaven
    1763 Caster thinks that his death will open the gates of hell
    1764 Caster thinks that his deity has commanded him to kill his allies
    1765 Caster thinks that his destiny awaits him in the nearest cave
    1766 Caster thinks that his face is far too hideous to look at
    1767 Caster thinks that his face is just a mask he wears on his skull
    1768 Caster thinks that his hands will disintegrate if he touches gold
    1769 Caster thinks that his head is a parasitic organism
    1770 Caster thinks that his head is an extraneous, vestigial appendage
    1771 Caster thinks that his head was sewn onto this body only recently
    1772 Caster thinks that his head will fall off if he removes his hat
    1773 Caster thinks that his head will shatter if he wears a hat
    1774 Caster thinks that his magic items are about to explode
    1775 Caster thinks that his magic items are plotting against him
    1776 Caster thinks that his soul is controlling his body from far away
    1777 Caster thinks that his soul was forced into this current body
    1778 Caster thinks that his spellbook belongs to someone else
    1779 Caster thinks that his spellbook is a living entity
    1780 Caster thinks that his spellbook is incredibly flammable
    1781 Caster thinks that his spellbook is trying to consume his soul
    1782 Caster thinks that his spellbook is trying to kill him
    1783 Caster thinks that his teeth will explode if chews meat
    1784 Caster thinks that horses are conspiring against him
    1785 Caster thinks that imps and demons harass him while he sleeps
    1786 Caster thinks that itis cute when he speaks in baby-talk
    1787 Caster thinks that life is a simulation and heis soaking in a vat
    1788 Caster thinks that many of his memories were falsely implanted
    1789 Caster thinks that mighty deities are vying for his soul
    1790 Caster thinks that must hold one hand to his head at all times
    1791 Caster thinks that no non-magical animal can harm him
    1792 Caster thinks that no one really trusts him
    1793 Caster thinks that no one really understands what heis saying
    1794 Caster thinks that one his allies will kill him while he sleeps
    1795 Caster thinks that people are just using him for his money
    1796 Caster thinks that people think heis some kind of deity
    1797 Caster thinks that rhyming words have mystical significance
    1798 Caster thinks that some item heis carrying is about to explode
    1799 Caster thinks that some item heis carrying will soon explode
    1800 Caster thinks that some nearby person killed him yesterday
    1801 Caster thinks that someone else can see through his eyes
    1802 Caster thinks that something valuableis been stolen from him
    1803 Caster thinks that the king owes him a big favor
    1804 Caster thinks that the stars are speaking to him 
    1805 Caster thinks that the target is the only one who can save him
    1806 Caster thinks that the targetis death will cause the apocalypse
    1807 Caster thinks that the top of his head should be flattened
    1808 Caster thinks that the universe will cease to exist when he dies
    1809 Caster thinks that the worldis rotation will hurl him into space
    1810 Caster thinks that this date will live in infamy
    1811 Caster thinks that this is all just a big misunderstanding
    1812 Caster thinks that Chaos Bursts are proof that heis nearly a deity
    1813 Caster threatens to kill and eat anyone who insults him
    1814 Caster tries to commit hara-kiri with some sort of cudgel
    1815 Caster tries to pop his head by squeezing it with both hands
    1816 Caster tries to swallow any writing instrument that heis carrying
    1817 Caster tries very hard to peel his face from his skull
    1818 Caster tries very hard to twist his nose upside down
    1819 Caster turns bright blue while heis bleeding
    1820 Caster turns into a clothing store mannequin for 1d6 rounds
    1821 Caster turns into a small, pot-bellied pig
    1822 Caster turns into an elemental of equal hit dice for 1d4 rounds
    1823 Caster turns invisible to himself but not to anyone else
    1824 Caster turns to stone but is fully restored at dawn tomorrow
    1825 Caster unleashes a torrent of shocking profanity for 2d4 rounds
    1826 Caster uses fire-based magic in preference to other magic
    1827 Caster utters shocking blasphemies in the presence of clergy
    1828 Caster utters shocking profanities at inappropriate times
    1829 Caster vanishes; has a 1% cumulative chance per round to return
    1830 Caster vanishes; in 1d8 rounds he appears at the target point
    1831 Caster volunteers for the most dangerous task he can find
    1832 Caster vows not to rest until heis found the real killers
    1833 Caster vows to commit deicide before the end of the year
    1834 Caster vows to make a little birdhouse in his soul
    1835 Caster vows to slay the next person to use magic on him
    1836 Caster vows to slay the next person who addresses him by name
    1837 Caster wagers all of his money on an improbable contest
    1838 Caster walks with a profound limp except while naked
    1839 Caster wants to join the next flock of birds he sees
    1840 Caster was born in the universe that existed before this one
    1841 Caster wears eyeglasses and has an odd birthmark on his forehead
    1842 Caster weeps powerfully adhesive tears for 1d6 rounds
    1843 Caster weeps tears of blood whenever someone says his name
    1844 Caster will appear to be his current age for the rest of his life
    1845 Caster will combust unless he immerses himself within an hour
    1846 Caster will die if struck by a wooden club in the next 1d4 rounds
    1847 Caster wins a magical lamp shaped like a womanis leg
    1848 Caster wishes to divest himself of all worldly goods
    1849 Caster wonit age for 100 years if he cuts off his thumbs
    1850 Caster wonit remember the next 4d6 hours
    1851 Caster, his gear, and clothes are translucent for 2d4-1 days
    1852 Casteris age is doubled until sunrise tomorrow
    1853 Casteris allies completely ignore him for 1d6 hours
    1854 Casteris allies have never quite trusted him
    1855 Casteris allies suspect that he isnit quite housebroken
    1856 Casteris allies suspect that he secretly eats mice and rats
    1857 Casteris allies treat him like a child for 2d12 hours
    1858 Casteris allies worship him as a god for 1d4 days
    1859 Casteris Armor Class is improved by 1d4 until dawn
    1860 Casteris Armor Class is worsened by 1d6 until sunset tomorrow
    1861 Casteris arms and legs are bound in shackles of gold
    1862 Casteris arms and legs look like chickenis legs
    1863 Casteris arms are covered by scars from ritual burns
    1864 Casteris arms are covered in hideous welts and bruises
    1865 Casteris arms are tied together in a tight knot
    1866 Casteris arms from shoulder to wrist are unharmed by acid
    1867 Casteris arms vanish for the duration of the intended spell
    1868 Casteris attacks are 20% likely to inflict no damage on undead
    1869 Casteris attempts at scrying yield sanity-damaging visions
    1870 Casteris attempts at scrying yield visions of a sunken city
    1871 Casteris attempts at scrying yield visions of astonishing boredom
    1872 Casteris attempts at scrying yield visions of his own home
    1873 Casteris attempts at scrying yield visions of horrific carnage
    1874 Casteris attempts at scrying yield visions of impossible events
    1875 Casteris attempts at scrying yield visions of incredible beauty
    1876 Casteris attempts at scrying yield visions of nonexistent places
    1877 Casteris attempts at scrying yield visions of raucous debauchery
    1878 Casteris attempts at scrying yield visions of sugarplums
    1879 Casteris attempts at scrying yield visions of the caster himself
    1880 Casteris attempts at scrying yield visions of the distant future
    1881 Casteris attempts at scrying yield visions of the distant past
    1882 Casteris attempts at scrying yield visions of this location
    1883 Casteris attempts at scrying yield visions of utter desolation
    1884 Casteris attempts at scrying yield wildly inaccurate visions
    1885 Casteris attempts to change shape always fail spectacularly
    1886 Casteris back is scarred in a checkerboard pattern of burns
    1887 Casteris back is scarred with the imprint of a dragonis foot
    1888 Casteris base Armor Class is 8
    1889 Casteris base Armor Class is 12
    1890 Casteris big toes become opposable like thumbs
    1891 Casteris blood causes metal to become invisible
    1892 Casteris blood combusts violently within his body
    1893 Casteris blood is a sickly green and smells like manure
    1894 Casteris blood is poisonous to vampires and were-beasts
    1895 Casteris blood is sought as a panacea by Dwarves and Gnomes
    1896 Casteris blood is strongly adhesive after it leaves his body
    1897 Casteris blood is toxic to him, if ingested
    1898 Casteris blood is weightless
    1899 Casteris blood is worth more than gold, in the proper market
    1900 Casteris blood leaves indelible stains on rock and stone
    1901 Casteris blood radiates intense magic
    1902 Casteris body appears to have been shredded and reassembled
    1903 Casteris body can act independently if separated from his head
    1904 Casteris body is 40% fireproof
    1905 Casteris body is an artificial construct
    1906 Casteris body is covered in festering scabs
    1907 Casteris body is covered in ugly, livid bruises
    1908 Casteris body is reset to a 48-hour cycle rather than 24
    1909 Casteris body is rumored to contain countless diamonds
    1910 Casteris body is scarred as if heis undergone an autopsy
    1911 Casteris body is scarred with innumerable cryptic runes
    1912 Casteris body swivels 180° at the waist and stays that way
    1913 Casteris bones are as fragile as glass for 1d4 rounds
    1914 Casteris bones canit be broken but are highly combustible
    1915 Casteris bones canit be broken unless heis barefoot
    1916 Casteris bones will be powerfully explosive after his death
    1917 Casteris boots adhere strongly to stone while heis wearing them
    1918 Casteris boots are worth 10d100 gold pieces
    1919 Casteris boots can never move more than ten feet from this spot
    1920 Casteris boots have been kidnapped and held for a high ransom
    1921 Casteris boots weigh 100 pounds when wet
    1922 Casteris casting times are shortened by 50% for 2d4-1 days
    1923 Casteris center of gravity changes daily
    1924 Casteris center of gravity is 1d4 feet to his left
    1925 Casteris center of gravity is at the level of his eyes
    1926 Casteris center of gravity is at the level of his feet
    1927 Casteris closest blood relative ascends to godhood
    1928 Casteris closest blood relative has been abducted by a vile cult
    1929 Casteris closest blood relative is slated for execution tomorrow
    1930 Casteris closest blood relative vows to slay him
    1931 Casteris clothes are 25% likely to be invisible to each viewer
    1932 Casteris clothes are burned to cinders, but he is unharmed
    1933 Casteris clothes are caked with salt
    1934 Casteris clothes are drenched with goatis milk 
    1935 Casteris clothes are impervious to Alteration magic
    1936 Casteris clothes are impervious to fire when itis not being worn
    1937 Casteris clothes are invisible by firelight
    1938 Casteris clothes are invisible in the presence of royalty
    1939 Casteris clothes are soaked with lambsi blood
    1940 Casteris clothes are soaked with lamp oil
    1941 Casteris clothes are soaked with molasses
    1942 Casteris clothes are stripped of any and all enchantments
    1943 Casteris clothes are water soluble
    1944 Casteris clothes clatter like metal when he moves
    1945 Casteris clothes donit leave much to the imagination
    1946 Casteris clothes heat by 1° per minute for the next 1d10 hours
    1947 Casteris clothes maintain a constant temperature of 70°
    1948 Casteris clothes radiate intense magic
    1949 Casteris clothes turn to copper
    1950 Casteris clothes turn to densely-woven spideris web
    1951 Casteris clothes turn to living human flesh
    1952 Casteris clothing inflates to the size of a house
    1953 Casteris cranium enlarges by 25%
    1954 Casteris cranium reforms into a tall, blunt cone
    1955 Casteris death is ordered due to a Burst he triggered previously
    1956 Casteris death is prophesied to precede centuries of prosperity
    1957 Casteris death will inspire weeks of riots and revolution
    1958 Casteris debt increases at a rate of 30% per month
    1959 Casteris digestive system becomes independently sentient
    1960 Casteris dominant hand becomes as clumsy as his other hand
    1961 Casteris ears are burned from his head
    1962 Casteris ears are on the same side of his head
    1963 Casteris ears are unaffected by polymorph magic
    1964 Casteris ears bleed harmlessly but copiously for 10d10 rounds
    1965 Casteris ears canit be cut by any metal blade
    1966 Casteris ears fall off and regrow every few days
    1967 Casteris ears grow to the size of dinner plates
    1968 Casteris ears resemble butterflyis wings
    1969 Casteris elbows canit bend more than 90°
    1970 Casteris entire head looks like a huge nose
    1971 Casteris every attempt at music yields the same annoying tune
    1972 Casteris eyelids look like lips
    1973 Casteris eyes appear crystalline like diamonds
    1974 Casteris eyes are artificial and were installed by demons
    1975 Casteris eyes are invulnerable to heat and fire
    1976 Casteris eyes are replaced by new ones every 1d4 days
    1977 Casteris eyes can be safely removed for up to 1d4 hours
    1978 Casteris eyes canit be harmed by any physical force or object
    1979 Casteris eyes do not move, but he can see normally
    1980 Casteris eyes glow red when he tries to make a good impression
    1981 Casteris eyes merge into a single eye at the bridge of his nose
    1982 Casteris eyes migrate to his cheekbones
    1983 Casteris eyes migrate two inches higher on his forehead
    1984 Casteris eyes sink 1d4 inches into his skull
    1985 Casteris eyes swell shut for 2d12 hours
    1986 Casteris eyeteeth grow into tusks like those of a walrus
    1987 Casteris face and head are covered by a tight shell of fetid wax
    1988 Casteris face and head resemble a snowmanis
    1989 Casteris face appears melted like wax
    1990 Casteris face appears to age backwards at 2X the normal rate
    1991 Casteris face appears to be made of chrome
    1992 Casteris face appears to be made of hammered aluminum
    1993 Casteris face appears to be upside-down
    1994 Casteris face appears to float 1d4 inches in front of his skull
    1995 Casteris face appears to have been sculpted from cold wax
    1996 Casteris face doesnit move when he speaks; -2 to reaction rolls
    1997 Casteris face elongates into a short snout with prominent teeth
    1998 Casteris face falls off, leaving a bare skull until sunrise
    1999 Casteris face is a mask
    2000 Casteris face is an illusion and can be dispelled as such
    2001 Casteris face is concave
    2002 Casteris face is covered with cactus spines
    2003 Casteris face is fireproof
    2004 Casteris face is glazed in a thick layer of ice
    2005 Casteris face is pliant like rubber
    2006 Casteris face is printed with intricate, dark blue tattoos
    2007 Casteris face is scarred as though slashed by an eagleis talons
    2008 Casteris face swells enough to be unrecognizable
    2009 Casteris face tingles in the presence of magical animals
    2010 Casteris face turns to wood
    2011 Casteris feet are burned as if heis waded through ankle-deep acid
    2012 Casteris feet are encased in brick
    2013 Casteris feet canit be burned by magical fire
    2014 Casteris feet inflate to 2X normal size while he wades in water
    2015 Casteris feet shrink by 80% while heis wearing shoes or boots
    2016 Casteris feet smolder gently for 1d6 hours without harming him
    2017 Casteris feet vanish, but he can walk comfortably on his ankles
    2018 Casteris fingernails are poisonous to him
    2019 Casteris fingernails display otherworldly scenes
    2020 Casteris fingernails each grow 1d20 inches
    2021 Casteris fingernails exude a pungent green fluid
    2022 Casteris fingernails grow 1d4 inches per day
    2023 Casteris fingers appear to be made of delicate crystal
    2024 Casteris fingers are as flexible as tentacles
    2025 Casteris fingers are as rigid as steel while theyire wet
    2026 Casteris fingers are threaded like bolts
    2027 Casteris fingers canit be severed from his hands
    2028 Casteris fingers glow faintly in the presence of humans
    2029 Casteris fingers randomly shuffle their positions
    2030 Casteris fingers seem ice cold to anyone other than the caster
    2031 Casteris fist fuses into an clumsy stub
    2032 Casteris fist jams itself into his mouth
    2033 Casteris footprints glow with sickly green light for 5d6 rounds
    2034 Casteris footprints seem to shimmer and waver in sunlight
    2035 Casteris footprints shine brightly while heis invisible
    2036 Casteris hair and clothes become horribly entangled
    2037 Casteris hair and clothes constantly stir as if blown by wind
    2038 Casteris hair becomes tangled in any hat or helmet he wears
    2039 Casteris hair becomes thick and coarse like that of a boar
    2040 Casteris hair can never become invisible
    2041 Casteris hair falls out each evening and regrows by morning
    2042 Casteris hair freezes solid
    2043 Casteris hair is clear like glass
    2044 Casteris hair is discovered to be a bad toupee
    2045 Casteris hair is fireproof
    2046 Casteris hair is perpetually soaked with sea water
    2047 Casteris hair is striped like a tigeris coat
    2048 Casteris hair reeks of sulfur when heis near a campfire
    2049 Casteris hair stands straight up for the next 1d4 weeks
    2050 Casteris hand adheres to the next bludgeoning weapon he grips
    2051 Casteris hand adheres to the next tree he touches
    2052 Casteris hands and arms are covered with cactus needles
    2053 Casteris hands and feet are invisible for 1d4 weeks
    2054 Casteris hands appear to be crude wooden replicas
    2055 Casteris hands appear to be made of solid gold
    2056 Casteris hands appear to have been badly gnawed by rodents
    2057 Casteris hands are blasted to a crisp but heal in 1d4+1 weeks
    2058 Casteris hands are completely insulated against electricity
    2059 Casteris hands are impervious to all harm for one week
    2060 Casteris hands are invisible while he clasps them
    2061 Casteris hands are totally numb for 10d10 rounds
    2062 Casteris hands are translucent like smoky quartz
    2063 Casteris hands canit come within 12 inches of each other
    2064 Casteris hands canit come within 12 inches of his face 
    2065 Casteris hands detach the next time he puts them in his pockets
    2066 Casteris hands explode but grow back by morning
    2067 Casteris hands feel just like two balloons
    2068 Casteris hands reform into lobster-like pincers
    2069 Casteris hands shine like a beacon visible only to goblins
    2070 Casteris hands shrink by 50%
    2071 Casteris hands shrink or grow to fit any gloves he wears
    2072 Casteris hands sprout coarse scales
    2073 Casteris hands sprout luxuriant feathers
    2074 Casteris head appears to hang loosely above his shoulders
    2075 Casteris head appears translucent when backlit by firelight
    2076 Casteris head deforms like a rubber ball when bludgeoned
    2077 Casteris head explodes as a 20HD fireball if cut from his body
    2078 Casteris head is demanded as tribute by some insane despot
    2079 Casteris head is discovered to be a mechanical construct
    2080 Casteris head is impervious to non-magical missile fire
    2081 Casteris head is now shaped like a bell
    2082 Casteris head is perfectly cylindrical until sunset tomorrow
    2083 Casteris head is permanently surrounded by dense fog
    2084 Casteris head is rendered permanently invisible
    2085 Casteris head is sealed in a block of ice with breathing holes
    2086 Casteris head is split down the middle but he is unharmed
    2087 Casteris head once belonged to a great military leader
    2088 Casteris head shines like a beacon visible only to orcs
    2089 Casteris head turns into a pumpkin for 1d6 hours
    2090 Casteris heart is mechanical and not subject to necromancy
    2091 Casteris heart is widely rumored to be the Philosopheris Stone
    2092 Casteris home and everything in it are invisible to him
    2093 Casteris home appears to be shockingly evil to everyone but him
    2094 Casteris home appears to have been abandoned for centuries
    2095 Casteris home canit be entered through the front door
    2096 Casteris home drops from the sky to land heavily nearby
    2097 Casteris home fills with some kind of thick blue liquid
    2098 Casteris home has a secret entrance accessible only to trolls
    2099 Casteris home has a secret room that heis never noticed before
    2100 Casteris home has served as a brothel while heis been away
    2101 Casteris home has served as a cafeteria while heis been away
    2102 Casteris home has served as a crematorium while heis been away
    2103 Casteris home has served as a grain silo while heis been away
    2104 Casteris home has served as a monastery while heis been away
    2105 Casteris home has served as a mortuary while heis been away
    2106 Casteris home has served as a pig sty while heis been away
    2107 Casteris home has served as a prison while heis been away
    2108 Casteris home has served as a public latrine while heis been away
    2109 Casteris home has served as a stable while heis been away
    2110 Casteris home has served as an abattoir while heis been away
    2111 Casteris home has served as an armory while heis been away
    2112 Casteris home has served as an unholy altar while heis been away
    2113 Casteris home has served as barracks while heis been away
    2114 Casteris home is a triumph of postmodern architecture
    2115 Casteris home is at the center of a huge territorial squabble
    2116 Casteris home is buried in compost
    2117 Casteris home is destroyed by a huge magical explosion
    2118 Casteris home is fireproof but water soluble
    2119 Casteris home is flattened by a mysterious magical explosion
    2120 Casteris home is infested with bubonic rats
    2121 Casteris home is leveraged in a speculative financial scheme
    2122 Casteris home is made of gingerbread
    2123 Casteris home is packed completely full of manure
    2124 Casteris home is packed completely full of pigsi ears
    2125 Casteris home is packed completely full of salt
    2126 Casteris home is packed completely full of snow
    2127 Casteris home is seized through an act of Imminent Domain
    2128 Casteris home is suddenly at the bottom of a deep, dark valley
    2129 Casteris home is suddenly at the top of a forbidding mountain
    2130 Casteris home levitates 1d10 yards in the air for that many days
    2131 Casteris home resembles a large toadstool
    2132 Casteris home sinks into the ground 1d10 inches per day
    2133 Casteris home stands on a kobold burial mound
    2134 Casteris home throbs and pulses like a gigantic heart
    2135 Casteris home will cease to exist in 1d4 days
    2136 Casteris image appears on every shield within 100 yards
    2137 Casteris index finger is shaped like a key
    2138 Casteris Intelligence is equal to his level for 2d12 hours
    2139 Casteris Intelligence is reduced by 1d4 for a like number of days
    2140 Casteris internal monologue becomes audible to others
    2141 Casteris is unable to digest uncooked foods
    2142 Casteris kidneys vanish
    2143 Casteris knees can bend forward and backward with equal ease
    2144 Casteris left arm appears to carry a powerful enchantment
    2145 Casteris left arm appears to have been made from twine and glue
    2146 Casteris left arm doubles in length 1d4 times
    2147 Casteris left arm doubles in length; right arm shrinks by 50%
    2148 Casteris left arm stretches to 2X the length of his body
    2149 Casteris left hand and 10d10% of his arm turn to brass
    2150 Casteris left hand canit be cut by any non-magical blade
    2151 Casteris left hand is affected as by the spell Haste
    2152 Casteris left hand is hideously warped and mangled
    2153 Casteris left hand strongly resents his right hand
    2154 Casteris left leg detaches and starts kicking him really hard
    2155 Casteris left leg is covered by bark
    2156 Casteris legs are both encased in a single thick, steel pipe
    2157 Casteris legs are now exactly as long as his arms
    2158 Casteris legs canit support his weight for 10d10 rounds
    2159 Casteris legs double in length, and his arms shorten by 50%
    2160 Casteris legs weigh as much as iron while heis wading
    2161 Casteris limbs are rendered permanently invisible
    2162 Casteris limbs each belong to a different species
    2163 Casteris lungs are visible through his flesh and clothing
    2164 Casteris lungs begin to function at 2X normal efficiency
    2165 Casteris lungs begin to function at half normal efficiency
    2166 Casteris lungs sound like bagpipes when he exerts himself
    2167 Casteris lungs stop working for 1d10 rounds
    2168 Casteris magic does not affect females for 1d4 days
    2169 Casteris magic does not affect males for 1d4 days
    2170 Casteris magic doesnit work if heis ankle-deep in water
    2171 Casteris magic is detected by Detect Magic only 20% of the time
    2172 Casteris magic is somewhat resistant to the spell Dispel Magic
    2173 Casteris magic leaves a filmy residue on precious metals
    2174 Casteris mass increases by a factor of 10 while heis on a boat
    2175 Casteris missile-based spells seem to issue from his eyes
    2176 Casteris missile-based spells seem to issue from his mouth
    2177 Casteris missile-based spells seem to issue from the ground
    2178 Casteris most powerful foe always knows casteris precise location
    2179 Casteris motion is impeded by a strong wind that affects only him
    2180 Casteris nearest ally attacks him for 1d6 rounds
    2181 Casteris nearest ally is invisible to him for 1d4 days
    2182 Casteris neck doubles in length
    2183 Casteris neck is invisible
    2184 Casteris next 1d8 attacks inflict only illusionary damage
    2185 Casteris next attack causes equal damage to him and his target
    2186 Casteris next attack heals its target of all damage and disease
    2187 Casteris next spell affects only half of its intended targets
    2188 Casteris next spell causes its target to become invisible
    2189 Casteris next spell fills the air with the sound of buzzing bees
    2190 Casteris next spell functions as a Disintegrate spell instead
    2191 Casteris next spell functions but has an invisible effect
    2192 Casteris next spell functions but knocks him unconscious
    2193 Casteris next spell persists until heis injured
    2194 Casteris next spell turns its target bright blue for its duration 
    2195 Casteris next Summoning calls up something he can not put down
    2196 Casteris next Summoning turns him into the Summoned creature
    2197 Casteris next Summoning yields 1d10 decapitated human heads
    2198 Casteris next Summoning yields 1d1000 fluffy white rabbits
    2199 Casteris next Summoning yields 1d4 chrome-plated ostriches
    2200 Casteris next Summoning yields 1d8 tiny blue imps with white hats
    2201 Casteris next Summoning yields 4d10 bushels of rotten apples
    2202 Casteris next Summoning yields a 16HD Earth Elemental
    2203 Casteris next Summoning yields a bucket of brine-soaked plums
    2204 Casteris next Summoning yields a coil of rope one mile in length
    2205 Casteris next Summoning yields a creature that attacks him
    2206 Casteris next Summoning yields a creature that dies instantly
    2207 Casteris next Summoning yields a horrifyingly loathsome monster
    2208 Casteris next Summoning yields a mockery of the intended effect
    2209 Casteris next Summoning yields a puddle of highly unstable goo
    2210 Casteris next Summoning yields an ice sculpture
    2211 Casteris next Summoning yields an illusion of the intended effect
    2212 Casteris next Summoning yields something wildly inappropriate
    2213 Casteris next Summoning yields the last thing that he expects
    2214 Casteris next Summoning yields two of whatever heis Summoning
    2215 Casteris nose looks like a noose
    2216 Casteris nose looks like an ear
    2217 Casteris nostrils are stuffed full of pimentos
    2218 Casteris palms turn to stone
    2219 Casteris pockets are filled with confectioneris sugar
    2220 Casteris pockets are filled with glue
    2221 Casteris pockets are filled with greasy candle stubs
    2222 Casteris pockets are filled with live minnows
    2223 Casteris pockets are filled with offal
    2224 Casteris pockets are filled with stringy pasta
    2225 Casteris pockets are filled with weeks-old goat cheese
    2226 Casteris pockets are fireproof
    2227 Casteris pockets are inaccessible for 1d6 days
    2228 Casteris pockets are lined with chain mail
    2229 Casteris pockets are lined with sharp, jagged teeth
    2230 Casteris pockets vanish along with anything inside them
    2231 Casteris presence causes all food to taste like liver
    2232 Casteris presence causes birds in nearby trees to fall silent
    2233 Casteris presence causes bowstrings to be abnormally elastic
    2234 Casteris presence causes clockwork devices to malfunction
    2235 Casteris presence causes food to be drained of all flavor
    2236 Casteris presence causes holy symbols to seem unusually hot
    2237 Casteris presence causes magical animals to be oddly intractable
    2238 Casteris presence causes magical weapons to glow a dim red
    2239 Casteris presence causes musical instruments to go out of tune
    2240 Casteris presence causes people to sing wildly off-key
    2241 Casteris presence causes the clanking of metal to be muted
    2242 Casteris presence causes timekeeping devices to combust
    2243 Casteris presence causes timekeeping devices to malfunction
    2244 Casteris presence causes undead skeletons to sneeze
    2245 Casteris presence causes worked stone to sweat
    2246 Casteris presence induces lightheartedness in Dwarves
    2247 Casteris presence makes it hard to discern the value of things
    2248 Casteris principal weapon bends until the ends are touching
    2249 Casteris principal weapon can indicate True North once per turn
    2250 Casteris principal weapon canit be damaged by non-magical heat
    2251 Casteris principal weapon canit exist on this plane for 4d8 days
    2252 Casteris principal weapon canit kill anyone now within 10 miles
    2253 Casteris principal weapon canit kill anyone of Elfin stock
    2254 Casteris principal weapon disintegrates if it draws his blood
    2255 Casteris principal weapon glows as though itis red hot
    2256 Casteris principal weapon is as shiny as mirror for 1d12 months
    2257 Casteris principal weapon is extremely sticky to the touch
    2258 Casteris principal weapon is matte black between sunset and dawn
    2259 Casteris principal weapon is older than the whole universe
    2260 Casteris principal weapon is reclaimed by its former owner
    2261 Casteris principal weapon is translucent like smoked glass
    2262 Casteris principal weapon shrinks by 5d10+45%
    2263 Casteris principal weapon sprouts luxuriant tresses
    2264 Casteris reflection appears upside down
    2265 Casteris reflection chants dire prophecies about him
    2266 Casteris reflection commits suicide when he next sees it
    2267 Casteris reflection harbors a deep and obvious resentment of him
    2268 Casteris reflection is not mirror-reversed
    2269 Casteris reflection shows him as battered corpse
    2270 Casteris reflection shows him as he was 10 years ago
    2271 Casteris reflection shows him beaten nearly to death
    2272 Casteris right arm is encased in a cylinder of solid crystal
    2273 Casteris right arm is just like his left arm, facing backwards
    2274 Casteris right arm resembles a horseis foreleg
    2275 Casteris right hand is a perfect sphere at the end of his wrist
    2276 Casteris right hand struggles to grip his right elbow
    2277 Casteris right leg increases in thickness by a factor of 1d4
    2278 Casteris right thigh is as long as his entire left leg
    2279 Casteris skin appears cracked like an old oil painting
    2280 Casteris skin appears pitted like Swiss cheese
    2281 Casteris skin appears to have been boiled
    2282 Casteris skin appears to have been riveted to his body in sheets
    2283 Casteris skin appears to have been woven of flesh-colored thread
    2284 Casteris skin canit be punctured by any mammalis teeth
    2285 Casteris skin is blood red for 2d4-1 days
    2286 Casteris skin is completely free of moles, scars, and blemishes
    2287 Casteris skin is covered by human bite-marks
    2288 Casteris skin is fireproof but tarnishes quickly in sunlight
    2289 Casteris skin is infused with countless tiny glass nuggets
    2290 Casteris skin is permanently stained by his blood
    2291 Casteris skin is plaid from now on
    2292 Casteris skin is suddenly the color of his hair
    2293 Casteris skin ripples like a rain-spattered pond from now on
    2294 Casteris skin varies in opacity from hour to hour
    2295 Casteris skull becomes intensely magnetic
    2296 Casteris speech doesnit match the movement of his lips
    2297 Casteris speech is clearly audible to all within 50 yards
    2298 Casteris speech is utterly unintelligible for 1d4 hours
    2299 Casteris speech is utterly unintelligible to him
    2300 Casteris spellbook absorbs moisture like a sponge
    2301 Casteris spellbook acquires a saucy and antagonistic personality
    2302 Casteris spellbook and any ink within it are waterproof
    2303 Casteris spellbook appears to be in a language unknown to him
    2304 Casteris spellbook appears to be on fire while itis open
    2305 Casteris spellbook belongs to someone else who wants it back
    2306 Casteris spellbook can be folded to the size of a deck of cards
    2307 Casteris spellbook can be judged by its cover
    2308 Casteris spellbook can be unfolded to function as a small boat
    2309 Casteris spellbook can be unfolded to function as a small tent
    2310 Casteris spellbook can be unfolded to serve as a table for six
    2311 Casteris spellbook can be used as an anvil but weighs as much
    2312 Casteris spellbook can dispense 1d4 gallons of pure water per day
    2313 Casteris spellbook can hold 100 pounds like a Bag of Holding
    2314 Casteris spellbook can hold 4x the usual number of spells
    2315 Casteris spellbook can only be read by females
    2316 Casteris spellbook can only be read by males
    2317 Casteris spellbook can only be read in near-total darkness
    2318 Casteris spellbook can withstand 100 hit points of fire damage
    2319 Casteris spellbook canit be harmed or altered by any mortal means
    2320 Casteris spellbook contains 1d8 spells heis never seen before
    2321 Casteris spellbook contains a mysterious key
    2322 Casteris spellbook contains nothing but gibberish for 1d4 days
    2323 Casteris spellbook contains pages and pages of court transcripts
    2324 Casteris spellbook contains pages and pages of idle gossip 
    2325 Casteris spellbook contains pages and pages of inaccurate maps
    2326 Casteris spellbook contains pages and pages of New Age garbage
    2327 Casteris spellbook contains pages and pages of ribald limericks
    2328 Casteris spellbook contains pages and pages of risquE woodcuts
    2329 Casteris spellbook contains pages and pages of shocking profanity
    2330 Casteris spellbook contains pages and pages of tasty recipes
    2331 Casteris spellbook contains pages and pages of trite haikus
    2332 Casteris spellbook contains pages and pages of uplifting slogans
    2333 Casteris spellbook contains pages and pages of utter gibberish
    2334 Casteris spellbook giggles in the presence of other books
    2335 Casteris spellbook giggles loudly when its pages are turned
    2336 Casteris spellbook gives faulty warnings about his impending doom
    2337 Casteris spellbook glows in the dark
    2338 Casteris spellbook growls ominously when anyone else touches it
    2339 Casteris spellbook has 60% Magic Resistance
    2340 Casteris spellbook has a handle and can be used as a shield +1
    2341 Casteris spellbook has a hideous face embossed on its cover
    2342 Casteris spellbook has a secret, flask-shaped compartment
    2343 Casteris spellbook has a surprise ending
    2344 Casteris spellbook has no clear beginning or end
    2345 Casteris spellbook has straps and can be worn as a backpack
    2346 Casteris spellbook induces madness in those of Lawful alignment
    2347 Casteris spellbook induces nausea in anyone else who touches it
    2348 Casteris spellbook induces ravenous hunger in any who read it
    2349 Casteris spellbook is 30% likely to be invisible on any given day
    2350 Casteris spellbook is as fragile as glass until sunset
    2351 Casteris spellbook is bound in a sheathe of human skin
    2352 Casteris spellbook is bound tightly shut in barbed wire
    2353 Casteris spellbook is breaded and deep-fried
    2354 Casteris spellbook is chrome-plated
    2355 Casteris spellbook is covered in a thin shell of clay
    2356 Casteris spellbook is coveted by a fire elemental
    2357 Casteris spellbook is coveted by the undead
    2358 Casteris spellbook is discovered to be a forgery
    2359 Casteris spellbook is distributed as a mass-market paperback
    2360 Casteris spellbook is drenched in goatis milk
    2361 Casteris spellbook is ethereal to everyone except him
    2362 Casteris spellbook is fiercely coveted by all who pass near it
    2363 Casteris spellbook is filled with ways to dispose of corpses
    2364 Casteris spellbook is found to be just one part of a trilogy
    2365 Casteris spellbook is glazed like a doughnut
    2366 Casteris spellbook is gritty like sandpaper
    2367 Casteris spellbook is impervious to acid
    2368 Casteris spellbook is impervious to cold
    2369 Casteris spellbook is indestructible but appears to be decaying
    2370 Casteris spellbook is invisible for one hour each day
    2371 Casteris spellbook is invisible to everyone except magic users
    2372 Casteris spellbook is invisible to him unless his hair is wet
    2373 Casteris spellbook is invisible when wet
    2374 Casteris spellbook is laminated
    2375 Casteris spellbook is long overdue at the library
    2376 Casteris spellbook is perfectly spherical for 1d12 hours
    2377 Casteris spellbook is permanently water-soaked but undamaged
    2378 Casteris spellbook is rewritten in a language known only to him
    2379 Casteris spellbook is rewritten in a language unknown to him
    2380 Casteris spellbook is riddled with holes like Swiss cheese
    2381 Casteris spellbook is rumored to contain several lost spells
    2382 Casteris spellbook is rumored to have been penned by heretics
    2383 Casteris spellbook is sealed in a heavy wooden crate
    2384 Casteris spellbook is sealed with a combination lock
    2385 Casteris spellbook is sheathed in flame but doesnit burn
    2386 Casteris spellbook is sought by power-crazed conjurers
    2387 Casteris spellbook is stolen by someone on his way to the latrine
    2388 Casteris spellbook is tightly wrapped in cellophane
    2389 Casteris spellbook is transparent while closed
    2390 Casteris spellbook is unintelligible for 1d100 hours
    2391 Casteris spellbook is waterproof
    2392 Casteris spellbook is weightless while itis open
    2393 Casteris spellbook is wrapped in festive paper and ribbons
    2394 Casteris spellbook is written entirely in purple crayon
    2395 Casteris spellbook leaves a trail of ash wherever itis carried
    2396 Casteris spellbook randomly shuffles its pages
    2397 Casteris spellbook reeks as though drenched in perfume
    2398 Casteris spellbook reeks indelibly of mold and mildew
    2399 Casteris spellbook reeks of manure while itis open
    2400 Casteris spellbook reeks of rotting, mildewed cloth
    2401 Casteris spellbook seems badly scorched but is undamaged
    2402 Casteris spellbook shines as bright as the sun for 4d6 hours
    2403 Casteris spellbook shrinks to the size of a coin for 1d4 days
    2404 Casteris spellbook sprays skunk-musk each time itis opened
    2405 Casteris spellbook tastes like chicken between sunset and dawn
    2406 Casteris spellbook teleports 10d20 yards straight up
    2407 Casteris spellbook teleports 1d4 feet straight down
    2408 Casteris spellbook tends to slam shut on his hand (1d2-1 damage)
    2409 Casteris spellbook turns into a cat when he says a command word
    2410 Casteris spellbook vanishes; he finds it in a nearby well
    2411 Casteris spellbook vanishes; in 1d4 days he disgorges it
    2412 Casteris spellbook warms a five foot radius to a comfy 70°
    2413 Casteris spellbook was here just a minute ago
    2414 Casteris spellbook was instrumental in the downfall of an empire
    2415 Casteris spellbook was stolen from a secret monastery
    2416 Casteris spellbook was stolen from a traveler from the future
    2417 Casteris spellbook weighs 1d100+100 pounds
    2418 Casteris spellbook weighs as much as he does
    2419 Casteris spellbook will combust if he opens it before dawn
    2420 Casteris spells function as though cast by someone half his level
    2421 Casteris spells no longer work on some particular person nearby
    2422 Casteris Strength increases by 1d6 for a like number of days
    2423 Casteris Strength is halved
    2424 Casteris Strength is halved until heis struck by fire-based magic
    2425 Casteris Strength is rerolled hourly for the next 24 hours
    2426 Casteris teeth appear shiny and black like obsidian
    2427 Casteris teeth appear to drip blood for one week
    2428 Casteris teeth become serrated and triangular like a sharkis
    2429 Casteris teeth can be broken by any physical force or object
    2430 Casteris teeth can never become invisible
    2431 Casteris teeth grow continuously, like a rodentis
    2432 Casteris teeth shatter on contact with unrefined iron
    2433 Casteris tongue is bifurcated along half of its length
    2434 Casteris tongue is invisible during daylight hours
    2435 Casteris tongue is removable
    2436 Casteris voice becomes increasingly loud
    2437 Casteris voice cracks like a teenage boyis voice
    2438 Casteris voice inspires rage in dogs and wolves
    2439 Casteris voice is hoarse and strained for 1d4 weeks
    2440 Casteris voice issues from his right hand instead of his mouth
    2441 Casteris voice makes people feel hostile and aggressive
    2442 Casteris voice resonates in any gems nearby
    2443 Casteris voice seems poorly matched to his age and sex
    2444 Casteris voice seems to issue from 1d4 people around him
    2445 Casteris voice seems to issue from his pockets
    2446 Casteris voice seems to issue from some item heis now carrying
    2447 Casteris voice sounds as if itis coming from a distant megaphone
    2448 Casteris voice sounds as if itis coming through a metal tube
    2449 Casteris voice sounds like heis 1d100 years older
    2450 Casteris voice sounds like that of each person to whom he speaks
    2451 Casteris voice sounds like the braying of donkeys
    2452 Casteris voice sounds like the buzzing of metal bees
    2453 Casteris voice sounds like the honking of geese
    2454 Casteris voice sounds like the sputtering of a clogged drain 
    2455 Casteris waterskin is filled with mashed potatoes
    2456 Casteris waterskin makes its contents taste brackish and foul
    2457 Casteris weight increases tenfold while on a ladder
    2458 Casteris weight increases tenfold while walking across ice
    2459 Cooked meat is mildly poisonous to the caster
    2460 Countless pine needles adhere tightly to the casteris skin
    2461 Countless tiny wood chips swirl about the caster for 2d10 rounds
    2462 Countless tiny worms cascade from casteris ears
    2463 Crawling insects pour from casteris nostrils for 1d4 rounds
    2464 Cryptic messages are embossed on the casteris chest and back
    2465 Cryptic runes cover the casteris arms and hands
    2466 Cryptic symbols flash constantly across casteris forehead
    2467 Damage from casteris next 1d8 attacks appears 1d8 rounds later
    2468 Damage inflicted upon caster can only be healed near firelight
    2469 Damage inflicted upon caster is 10% likely to be just an illusion
    2470 Damage inflicted upon caster is 10% likely to harm someone else
    2471 Damage inflicted upon caster leaves unusually severe scars
    2472 Domestic cats react to caster with astonishing ferocity
    2473 Each day at noon, casteris age is reduced by 50%
    2474 Each day at noon, casteris weapon heats to 2d100°
    2475 Each day at sunset, caster suffers intense pain for 1d4 rounds
    2476 Each day for 2d6 days, caster must reroll his attributes
    2477 Each day, caster adds a cumbersome new title to his name
    2478 Each day, caster attempts to prove that heis impervious to blades
    2479 Each day, caster bores his allies with tales of his own heroism
    2480 Each day, caster can add +1 (or +5%) to any one dice roll
    2481 Each day, caster can cause one foe to miss one attack
    2482 Each day, caster can detach his head for up to one hour
    2483 Each day, caster can digest up to half a pound of stone
    2484 Each day, caster can magically cause 1d6 people to hate him
    2485 Each day, caster can roar like a dragon one time
    2486 Each day, caster can see through one door as if it were glass
    2487 Each day, caster can Summon 1d10 minnows up to 1d4 times
    2488 Each day, caster decides to worship a different deity
    2489 Each day, caster demands to be called by a different name
    2490 Each day, caster displays a new phobia that disappears by sunset
    2491 Each day, caster finds 1d10 human eyeballs in his pocket
    2492 Each day, caster finds 1d4 gold pieces in his pocket
    2493 Each day, caster finds a severed body part in his pocket
    2494 Each day, caster has no idea who he is for 1d10 minutes
    2495 Each day, caster increasingly obsesses about his waning lifespan
    2496 Each day, caster insists on being called by a different name
    2497 Each day, caster is 1% likely to be destroyed by a meteor strike
    2498 Each day, caster is 5% likely to teleport to this target point
    2499 Each day, caster is 10% likely to change sex until sunset
    2500 Each day, caster is 40% likely to crave garlic intensely
    2501 Each day, caster is 50% likely to leave no footprints
    2502 Each day, caster is accosted by a man with a real estate scheme
    2503 Each day, caster is attacked but not injured by a huge, ugly bird
    2504 Each day, caster is immune to 1d6 hit points of damage
    2505 Each day, caster loses 1d4 gold pieces
    2506 Each day, caster must cast at least one spell upon himself
    2507 Each day, caster must drink at least four gallons of water
    2508 Each day, caster must eat a pound of tree bark, or heill starve
    2509 Each day, caster must eat at least one lighted candle
    2510 Each day, caster must pluck at least one rose or be stricken mute
    2511 Each day, caster must recite a new limerick, or heill go insane
    2512 Each day, caster must Save or be unable to count until sunset
    2513 Each day, caster must Save or lose half of his hit points
    2514 Each day, caster must Save vs Will or his home explodes
    2515 Each day, caster must tell at least one outrageous lie
    2516 Each day, caster recalls a new but entirely fictional past life
    2517 Each day, caster reveals a new and offensive truth about himself
    2518 Each day, caster sees great meaning in the first words he hears
    2519 Each day, caster suffers violent withdrawal unless he uses magic
    2520 Each day, caster tells the same stupid joke about gnomes
    2521 Each day, caster threatens to murder someone nearby
    2522 Each day, caster wakes because a small pebble hits his forehead
    2523 Each day, caster wakes beneath a brine-soaked tangle of vines
    2524 Each day, caster wakes beneath a layer of fine white sand
    2525 Each day, caster wakes certain that heill die before sunset
    2526 Each day, caster wakes certain that the world will end by sunset
    2527 Each day, caster wakes completely deaf until he drinks something
    2528 Each day, caster wakes dressed in a mummyis filthy rags
    2529 Each day, caster wakes exhausted as if he just ran a marathon
    2530 Each day, caster wakes in a pile of dry leaves
    2531 Each day, caster wakes looking as if heis been beaten with clubs
    2532 Each day, caster wakes nearly out of his mind with rage
    2533 Each day, caster wakes thinking that 1d100 days have passed
    2534 Each day, caster wakes thinking that heis under attack
    2535 Each day, caster wakes to find a loaf of warm bread on his chest
    2536 Each day, caster wakes unable to see his allies for 1d4 turns
    2537 Each day, caster wakes wearing a heavily powdered wig
    2538 Each day, caster wakes wearing a straw hat
    2539 Each day, caster wakes with a daisy sprouting from his mouth
    2540 Each day, caster wakes with a gold coin in his mouth
    2541 Each day, caster wakes with a hospital bracelet on his wrist
    2542 Each day, caster wakes with his mouth packed full of flour
    2543 Each day, caster wakes with no idea of how he got there
    2544 Each day, caster wakes with several new and disturbing scars
    2545 Each day, casteris face is unbearably hideous for 1d10 minutes
    2546 Each day, casteris hair grows 10% longer
    2547 Each day, casteris height fluctuates plus or minus 1d100%
    2548 Each day, casteris height fluctuates plus or minus 1d6 inches
    2549 Each day, casteris home shrinks by 1%
    2550 Each day, casteris nostrils appear at a new place on his head
    2551 Each day, one of casteris spells (random) has its effect reversed
    2552 Each day, some part of casteris body falls off and regrows
    2553 Each day, someone accuses the caster of grand theft
    2554 Each day, someone accuses the caster of high treason
    2555 Each day, someone accuses the caster of unwholesome practices
    2556 Each day, someone accuses the caster or regicide
    2557 Each day, the caster is praised for some act of amazing heroism
    2558 Each hour, 1d4 small pine cones fall from the casteris ears
    2559 Each morning, caster must Save or be rendered mute for that day
    2560 Each morning, caster must Save or be sprayed by a skunk
    2561 Each morning, caster must Save or contract a non-magical illness
    2562 Each morning, caster must Save or earn the enmity of a monarch
    2563 Each morning, caster must Save or he ages 1d4 days
    2564 Each morning, caster must Save or heill be arrested before sunset
    2565 Each morning, caster must Save or his clothes dissolve by sunset
    2566 Each night as caster sleeps, every blade he owns is sharpened
    2567 Each night as caster sleeps, heis 5% likely to trigger a Burst
    2568 Each night as caster sleeps, his ankles are bound by silk cord
    2569 Each night as caster sleeps, his lips move as though heis talking
    2570 Each of casteris big toes is now as long as the rest of his foot
    2571 Each of casteris big toes is now as wide as the rest of his foot
    2572 Each of casteris teeth is now a different and contrasting color
    2573 Each of casteris teeth screams each time he opens his mouth
    2574 Each of casteris toes is 5% likely to explode right now
    2575 Eerie moans fill the air when caster touches holy water
    2576 Efforts to become invisible make the caster much more visible
    2577 Efforts to become invisible temporarily age the caster 1d10 years
    2578 Elementals Summoned in casteris presence are 20% larger
    2579 Elementals Summoned in casteris presence are at -2 to hit him
    2580 Elementals Summoned in casteris presence are completely silent
    2581 Elementals Summoned in casteris presence are horrible to look at
    2582 Elementals Summoned in casteris presence are invisible to him
    2583 Elementals Summoned in casteris presence are invulnerable to him
    2584 Elementals Summoned in casteris presence are Slowed 
    2585 Elementals Summoned in casteris presence are terrified of him
    2586 Elementals Summoned in casteris presence assume comical forms
    2587 Elementals Summoned in casteris presence attack him outright
    2588 Elementals Summoned in casteris presence attack their summoner
    2589 Elementals Summoned in casteris presence canit be controlled
    2590 Elementals Summoned in casteris presence crave decaying meat
    2591 Elementals Summoned in casteris presence explode instantly
    2592 Elementals Summoned in casteris presence flee the area at once
    2593 Elementals Summoned in casteris presence look familiar to him
    2594 Elementals Summoned in casteris presence mock him endlessly
    2595 Elementals Summoned in casteris presence seem far more fierce
    2596 Elementals Summoned in casteris presence totally ignore him
    2597 Elementals Summoned in casteris presence vaguely resemble him
    2598 Elementals Summoned in casteris presence weep until dismissed
    2599 Elementals Summoned in casteris presence will not attack him
    2600 Embarrassing rumors about the caster circulate far and wide
    2601 Embarrassing sounds issue from the caster at inopportune times
    2602 Even in darkness, caster is visible as though in full daylight
    2603 Every third tooth falls from casteris mouth
    2604 Everyone knows the casteris most embarrassing secret
    2605 Everyone now harboring ill will toward caster forgets who he is
    2606 Everyone now harboring ill will toward caster knows where he is
    2607 Everyone thinks that the caster is using a false name
    2608 Everyone thinks that the casteris use of magic is reckless
    2609 Everyone thinks the caster to be vaguely unreliable
    2610 Everyone who knows the caster suspects that heis really undead
    2611 Everyone who knows the caster thinks that he owes them money
    2612 Everyone within 100 miles hates the caster until at least sunset
    2613 Everyone within 100 miles knows that the caster is a magic user
    2614 Everyone within one mile appears as a skeleton to the caster
    2615 Everything caster eats for 1d12 months tastes strongly of blood
    2616 Fine gold wire is visibly threaded through the casteris flesh
    2617 Fire-based magic is invisible to the caster
    2618 Fires canit be sustained within three feet of casteris spellbook
    2619 Flames shoot from casteris ears at least once per hour until dawn
    2620 Foliage grows to entangle casteris feet if he stands still
    2621 Food turns ethereal while the caster touches it
    2622 For 1d4 days, caster can neutralize poisons by touch
    2623 For 1d4 days, caster is certain that his saliva is poisonous
    2624 For 1d4 rounds, casteris left foot is fused to the ground
    2625 For 1d4 rounds, normal water can burn the caster like strong acid
    2626 For 1d4 weeks, casteris eyelids glow brightly in the dark
    2627 For 1d4 weeks, casteris nose hovers 1d4 inches before his face
    2628 For 2d4-1 horrible days, caster works in a huge corporate office
    2629 For 3d10 days caster is immune to magic cast by one person
    2630 For 6d10 rounds, caster is the only person on the entire planet
    2631 For one day, caster is so monstrously ugly that people attack him
    2632 For one day, caster knows the location of all gold within 5 miles
    2633 For several days, caster strongly resembles a drowned corpse
    2634 Foul-smelling steam issues from the casteris nostrils
    2635 Half of casteris body is as hairy as an ape
    2636 Half of casteris body is immune to polymorph magic
    2637 Half of casteris hair is replaced by very fine silver wire
    2638 Holy symbols inspire dread in the caster
    2639 Holy water boils on contact with casteris skin
    2640 Honey flows through casteris veins instead of blood
    2641 Horrific screams issue from the casteris spellbook
    2642 Huge volumes of ectoplasm ooze from the casteris nostrils
    2643 Icy winds buffet the caster for 2d8-1 days
    2644 If alive, caster is totally healed in each of the next 1d6 hours
    2645 If asked for identification, caster offers a funny self-portrait
    2646 If caster attempts a Summoning, he vanishes for its duration
    2647 If caster attempts to create or control undead, they attack him
    2648 If caster casts a spell in the next turn, he thinks heis drowning
    2649 If caster casts a spell in the next turn, his clothing vanishes
    2650 If caster comes within one mile of a dragon, his hair falls out
    2651 If caster comes within one mile of an ocean, he begins to drown
    2652 If caster damages a statue, he suffers an equivalent injury
    2653 If caster dies and is resurrected, heis 85% likely to change sex
    2654 If caster draws a weapon before sunset, he goes berserk
    2655 If caster draws a weapon before sunset, that weapon vanishes
    2656 If caster falls more than twenty yards, he teleports to this spot
    2657 If caster has a beard, it vanishes; if he doesnit, he grows one
    2658 If caster has a missile weapon, heis attacked by small animals
    2659 If caster has drawn blood recently, he vanishes until sunrise
    2660 If caster has eaten in the past hour, he falls unconscious
    2661 If caster has eaten in the past hour, he loses 2d10 hit points
    2662 If caster has eaten in the past hour, he never has to eat again
    2663 If caster has eaten in the past hour, he vanishes until lunchtime
    2664 If caster has eaten meat in the past hour, it was human flesh
    2665 If caster has eaten meat in the past hour, it wasnit really meat
    2666 If caster has ever been resurrected, he loses 1d100 hit points
    2667 If caster has ever been resurrected, he now gains one level
    2668 If caster has ever been resurrected, he now loses one level
    2669 If caster has ever been resurrected, he teleports to that spot
    2670 If caster has slain anyone in cold blood, heis wracked by remorse
    2671 If caster has slain anyone in cold blood, that person haunts him
    2672 If caster ingests poison, he becomes powerfully addicted to it
    2673 If caster ingests poison, he briefly gains 1d4 points of Wisdom
    2674 If caster ingests poison, he canit be harmed by fire for 1d4 days
    2675 If caster ingests poison, he combusts in 1d6 turns
    2676 If caster ingests poison, he develops an intense, unusual phobia
    2677 If caster ingests poison, he develops hundreds of ugly blisters
    2678 If caster ingests poison, he forgets his name and how to speak
    2679 If caster ingests poison, he hallucinates wildly for 2d20 hours
    2680 If caster ingests poison, he is instantly aware of it
    2681 If caster ingests poison, he smells like carrion for 1d4 weeks
    2682 If caster ingests poison, he tries to cut it out of his body
    2683 If caster ingests poison, heis 20% likely to change sex
    2684 If caster ingests poison, his age is reduced by 1d20 years
    2685 If caster ingests poison, his blood is corrosive to metal
    2686 If caster ingests poison, his body shrinks by 1d100%
    2687 If caster ingests poison, his fingers vanish
    2688 If caster ingests poison, his teeth fall out
    2689 If caster ingests poison, its onset is delayed by 1d4 days
    2690 If caster ingests poison, non-magical antidotes are toxic to him
    2691 If caster ingests poison, someone nearby also suffers its effect
    2692 If caster is carrying a dagger, it grows as large as a greatsword
    2693 If caster is carrying a pouch, he attempts to climb into it
    2694 If caster is carrying a pouch, he likes to wear it as a hat
    2695 If caster is carrying a pouch, he uses it as a hand-puppet
    2696 If caster is carrying a weapon, it attempts to strike him
    2697 If caster is carrying a weapon, it turns into an umbrella
    2698 If caster is carrying any blades, he throws them in a nearby lake
    2699 If caster is carrying any blades, theyire now incredibly sharp
    2700 If caster is carrying any bread, it animates and attacks him
    2701 If caster is carrying any coins, each weighs as much as he does
    2702 If caster is carrying any coins, he develops an allergy to gold
    2703 If caster is carrying any keys, theyire all suddenly identical
    2704 If caster is carrying any kind of key, it explodes violently
    2705 If caster is carrying any metal, he canit cast magic until dawn
    2706 If caster is carrying any metal, he thinks that heis rusting
    2707 If caster is carrying any wood, he tries to eat it like a termite
    2708 If caster is carrying any wood, heis attacked by termites
    2709 If caster is carrying food, he becomes violently ill for an hour
    2710 If caster is carrying food, he eats all of it as fast as he can
    2711 If caster is carrying food, heis attacked by hungry hungry hippos
    2712 If caster is carrying food, itis 4X as nutritious as normal food
    2713 If caster is carrying his spellbook, he teleports 2d4 miles
    2714 If caster is carrying his spellbook, he teleports to his home 
    2715 If caster is carrying his spellbook, heis illiterate for one week
    2716 If caster is carrying his spellbook, heis reluctant to open it
    2717 If caster is carrying his spellbook, it teleports to his home
    2718 If caster is carrying his spellbook, it vanishes until dawn
    2719 If caster is hit by a bludgeon, his head resembles a watermelon
    2720 If caster is hit by a bludgeon, his head rings like a bronze gong
    2721 If caster is now at full hit points, he vanishes for 1d12 hours
    2722 If caster is now bleeding, he ages 10d10 years
    2723 If caster is now bleeding, he attacks his nearest ally
    2724 If caster is now bleeding, he can never use invisibility magic
    2725 If caster is now bleeding, he canit be healed before midnight
    2726 If caster is now bleeding, he canit use magic for 1d4 days
    2727 If caster is now bleeding, he canit use magic for 2d12 hours
    2728 If caster is now bleeding, he changes sex for 1d6 days
    2729 If caster is now bleeding, he declares war on an imagined enemy
    2730 If caster is now bleeding, he flees at top speed in a panic
    2731 If caster is now bleeding, he gains 10,000 Experience Points
    2732 If caster is now bleeding, he gains one level
    2733 If caster is now bleeding, he loses another 4d10 hit points
    2734 If caster is now bleeding, he races to the nearest coastline
    2735 If caster is now bleeding, he teleports to his home
    2736 If caster is now bleeding, he thinks that heis somebody else
    2737 If caster is now bleeding, heis attacked by a shark
    2738 If caster is now bleeding, heis forever immune to healing magic
    2739 If caster is now bleeding, heis immune to fire magic until sunset
    2740 If caster is now bleeding, heis permanently invisible to goblins
    2741 If caster is now bleeding, heis reduced to just one hit point
    2742 If caster is now bleeding, heis restored to full Health
    2743 If caster is now bleeding, heis stricken mute until heis healed
    2744 If caster is now bleeding, his blood glows in the dark
    2745 If caster is now bleeding, his blood is flammable for 2d12 hours
    2746 If caster is now bleeding, his hair grows 8d12 inches
    2747 If caster is now bleeding, his weapon is +4 ToHit for 2d12 hours
    2748 If caster is now bleeding, his weapons vanish until dawn
    2749 If caster is now bleeding, is base AC is zero for 1d10 hours
    2750 If caster is now carrying a waterskin, it can hold 10d10 gallons
    2751 If caster is now carrying a waterskin, it turns into bagpipes
    2752 If caster is slain by a metal weapon, he canit be resurrected
    2753 If caster is slain by a metal weapon, heill rises as a zombie
    2754 If caster is slain, he awakens the next day fully healed (once)
    2755 If caster is slain, his killer is 20% likely to take his own life
    2756 If caster is slain, his killer is universally hailed as a hero
    2757 If caster is slain, his killer receives 100,000 gold pieces
    2758 If caster is standing near open flame, he tries to extinguish it
    2759 If caster is standing near open flame, he tries to ignite himself
    2760 If caster is struck by an axe, he disgorges a pound of sawdust
    2761 If caster is struck by an axe, he yells "timber" and falls over
    2762 If caster is usually shy, he becomes very assertive, & vice versa
    2763 If caster is wearing a magic ring, brackish slime oozes from it
    2764 If caster is wearing a magic ring, everyone one nearby hates him
    2765 If caster is wearing a magic ring, he acquires a new language
    2766 If caster is wearing a magic ring, he acquires an unusual phobia
    2767 If caster is wearing a magic ring, he ages 1d100 years until dawn
    2768 If caster is wearing a magic ring, he ages one year per round
    2769 If caster is wearing a magic ring, he becomes loudly belligerent
    2770 If caster is wearing a magic ring, he becomes nocturnal
    2771 If caster is wearing a magic ring, he can breathe underwater
    2772 If caster is wearing a magic ring, he canit be harmed by ice
    2773 If caster is wearing a magic ring, he canit Detect Magic
    2774 If caster is wearing a magic ring, he canit discern True North
    2775 If caster is wearing a magic ring, he canit eat while wearing it
    2776 If caster is wearing a magic ring, he canit leave this spot
    2777 If caster is wearing a magic ring, he canit remove it by himself
    2778 If caster is wearing a magic ring, he canit sit until sunrise
    2779 If caster is wearing a magic ring, he canit sleep for 2d10 days
    2780 If caster is wearing a magic ring, he canit speak above a whisper
    2781 If caster is wearing a magic ring, he canit use it for 1d4 days
    2782 If caster is wearing a magic ring, he canit wear any other rings
    2783 If caster is wearing a magic ring, he claims to be an impostor
    2784 If caster is wearing a magic ring, he claims to be enslaved to it
    2785 If caster is wearing a magic ring, he claims to be indestructible
    2786 If caster is wearing a magic ring, he claims to despise it
    2787 If caster is wearing a magic ring, he claims to have created it
    2788 If caster is wearing a magic ring, he claims to have stolen it
    2789 If caster is wearing a magic ring, he decides that heis a god
    2790 If caster is wearing a magic ring, he disgorges a large bell
    2791 If caster is wearing a magic ring, he disgorges one just like it
    2792 If caster is wearing a magic ring, he feels 1d100° colder
    2793 If caster is wearing a magic ring, he finds an enormous diamond
    2794 If caster is wearing a magic ring, he finds another just like it
    2795 If caster is wearing a magic ring, he forgets how to use it
    2796 If caster is wearing a magic ring, he founds a bizarre cult
    2797 If caster is wearing a magic ring, he goes insane for 1d4 days
    2798 If caster is wearing a magic ring, he grows suspicious of Elves
    2799 If caster is wearing a magic ring, he hasnit eaten in weeks
    2800 If caster is wearing a magic ring, he hates to use it indoors
    2801 If caster is wearing a magic ring, he hates to use it outdoors
    2802 If caster is wearing a magic ring, he joins a bizarre cult
    2803 If caster is wearing a magic ring, he misplaces it
    2804 If caster is wearing a magic ring, he refuses to speak to Dwarves
    2805 If caster is wearing a magic ring, he regains 2d6 hit points
    2806 If caster is wearing a magic ring, he rings like a bell
    2807 If caster is wearing a magic ring, he shrinks by 50% until dawn
    2808 If caster is wearing a magic ring, he suffers cannibalistic urges
    2809 If caster is wearing a magic ring, he suspects that itis a fake
    2810 If caster is wearing a magic ring, he thinks his allies covet it
    2811 If caster is wearing a magic ring, he thinks itis consuming him
    2812 If caster is wearing a magic ring, he thinks itis controlling him
    2813 If caster is wearing a magic ring, he thinks that itis on fire
    2814 If caster is wearing a magic ring, he throws it 4d6 feet from him
    2815 If caster is wearing a magic ring, he tries to destroy it
    2816 If caster is wearing a magic ring, he tries to sever that finger
    2817 If caster is wearing a magic ring, he uses it whenever possible
    2818 If caster is wearing a magic ring, he wants to swallow it
    2819 If caster is wearing a magic ring, he weeps tears of honey
    2820 If caster is wearing a magic ring, heill die if he removes it
    2821 If caster is wearing a magic ring, heis accused of sedition
    2822 If caster is wearing a magic ring, heis allergic to it
    2823 If caster is wearing a magic ring, heis attacked by crows
    2824 If caster is wearing a magic ring, heis attacked by scarabs
    2825 If caster is wearing a magic ring, heis blind until he removes it
    2826 If caster is wearing a magic ring, heis declared guilty of heresy
    2827 If caster is wearing a magic ring, heis eager to behead himself
    2828 If caster is wearing a magic ring, heis imprisoned far away
    2829 If caster is wearing a magic ring, heis known to have stolen it
    2830 If caster is wearing a magic ring, heis placed under arrest
    2831 If caster is wearing a magic ring, heis related to the king
    2832 If caster is wearing a magic ring, heis reluctant to use it
    2833 If caster is wearing a magic ring, heis struck by lightning
    2834 If caster is wearing a magic ring, heis swarmed by vermin
    2835 If caster is wearing a magic ring, heis terrified of its power
    2836 If caster is wearing a magic ring, heis wearing a copy in his nose
    2837 If caster is wearing a magic ring, his Charisma is 3 until dawn
    2838 If caster is wearing a magic ring, his Charisma is 18 until dawn
    2839 If caster is wearing a magic ring, his clothes turn invisible
    2840 If caster is wearing a magic ring, his clothes turn to lead
    2841 If caster is wearing a magic ring, his ears and nose fall off
    2842 If caster is wearing a magic ring, his eyes turn invisible
    2843 If caster is wearing a magic ring, his fingernails grow 1d4 feet
    2844 If caster is wearing a magic ring, his hands look like a corpseis 
    2845 If caster is wearing a magic ring, his hands switch wrists
    2846 If caster is wearing a magic ring, his head turns invisible
    2847 If caster is wearing a magic ring, his teeth turn to gold
    2848 If caster is wearing a magic ring, holy water burns his skin
    2849 If caster is wearing a magic ring, it acquires an odd new ability
    2850 If caster is wearing a magic ring, it becomes clear like glass
    2851 If caster is wearing a magic ring, it becomes part of his body
    2852 If caster is wearing a magic ring, it canit cross moving water
    2853 If caster is wearing a magic ring, it canit pass through doorways
    2854 If caster is wearing a magic ring, it derides his magical prowess
    2855 If caster is wearing a magic ring, it disintegrates upon removal
    2856 If caster is wearing a magic ring, it explodes upon removal
    2857 If caster is wearing a magic ring, it has 2X as many charges
    2858 If caster is wearing a magic ring, it heats to 1,000°
    2859 If caster is wearing a magic ring, it shines like the sun
    2860 If caster is wearing a magic ring, it shrinks by 50%
    2861 If caster is wearing a magic ring, it sprouts dozens of needles
    2862 If caster is wearing a magic ring, it turns permanently invisible
    2863 If caster is wearing a magic ring, it turns to lead
    2864 If caster is wearing a magic ring, it weighs more than he does
    2865 If caster is wearing a magic ring, it works only 75% of the time
    2866 If caster is wearing a magic ring, itis as brittle as glass
    2867 If caster is wearing a magic ring, itis on someone elseis finger
    2868 If caster is wearing a magic ring, itis suddenly in his stomach
    2869 If caster is wearing a magic ring, its effect is reversed
    2870 If caster is wearing a magic ring, its main function is altered
    2871 If caster is wearing a magic ring, no one takes him seriously
    2872 If caster is wearing a magic ring, smoke pours from his nostrils
    2873 If caster is wearing a magic ring, that finger doubles in length
    2874 If caster is wearing a magic ring, that finger turns into a thumb
    2875 If caster is wearing a magic ring, that finger turns invisible
    2876 If caster is wearing a magic ring, that hand ages 1d100 years
    2877 If caster is wearing a magic ring, that hand attacks the other
    2878 If caster is wearing a magic ring, that hand becomes gangrenous
    2879 If caster is wearing a magic ring, that hand doubles in size
    2880 If caster is wearing a magic ring, that hand has Dexterity 18
    2881 If caster is wearing a magic ring, that hand has Strength 18/00
    2882 If caster is wearing a magic ring, that hand is burned to a crisp
    2883 If caster is wearing a magic ring, that hand is gnarled like wood
    2884 If caster is wearing a magic ring, that hand is stricken numb
    2885 If caster is wearing a magic ring, that hand looks like a claw
    2886 If caster is wearing a magic ring, that hand looks like bare bone
    2887 If caster is wearing a magic ring, that hand sprouts feathers
    2888 If caster is wearing a magic ring, that hand turns into a foot
    2889 If caster is wearing a magic ring, that hand turns to gold
    2890 If caster is wearing a magic ring, that hand turns to stone
    2891 If caster is wearing a magic ring, that handis thumb vanishes
    2892 If caster is wearing a magic ring, the bones in that hand vanish
    2893 If caster is wearing a magic ring, water is poisonous to him
    2894 If caster is wearing any armor, he attacks someone nearby
    2895 If caster is wearing any armor, he removes it as fast as possible
    2896 If caster is wearing any armor, he teleports to his home
    2897 If caster is wearing any armor, it teleports to his home
    2898 If caster is wearing any leather, he moos like a cow until sunset
    2899 If caster is wearing any leather, he reeks of manure until sunset
    2900 If caster is wearing gloves, he canit remove them
    2901 If caster is wearing gloves, he requires no sleep for 1d4 weeks
    2902 If caster is wearing gloves, they turn into fluffy wool mittens
    2903 If caster is wearing gloves, they turn into rigid steel
    2904 If caster kills anyone in the next turn, he also perishes
    2905 If caster kills anyone in the next turn, heis declared a hero
    2906 If caster rides a horse in the next 24 hours, it tries to eat him
    2907 If caster sleeps in his boots, he can never again remove them
    2908 If caster sleeps in his boots, they begin devouring him tonight
    2909 If caster stands on a riverbank, heis attacked by crustaceans
    2910 If caster stands on a riverbank, the bank crumbles beneath him
    2911 If caster swallows a hot coal, heis 5% likely to turn to diamond
    2912 If caster swallows a hot coal, itis 10% likely to turn to diamond
    2913 If caster tells a lie, he giggles
    2914 If caster tells a lie, heis 40% likely to declare it outright
    2915 If caster uses Detect Magic, he loses 1d6 hit points
    2916 If caster uses Detect Magic, heis blinded for 1d10 rounds
    2917 If casteris carrying a dagger, he throws it at someone nearby
    2918 If casteris carrying a dagger, he tries to stab himself with it
    2919 If cut open, caster is found to be a mechanical construct
    2920 If cut open, caster is found to be completely hollow
    2921 If cut open, caster is found to be filled with gold coins
    2922 If cut open, caster is found to be filled with thick red foam
    2923 If cut open, caster is found to be made of soap
    2924 If cut open, caster is found to be packed with gunpowder
    2925 If cut open, caster is found to be stuffed with goose down
    2926 If cut open, caster is found to be teeming with filthy worms
    2927 If cut open, caster is found to contain 1d1000 feet of intestine
    2928 If cut open, caster is found to contain countless glass beads
    2929 If cut open, caster is found to contain only mildewed straw
    2930 If cut open, caster is found to contain thousands of bees
    2931 If cut open, caster is found to contain tiny replicas of himself
    2932 If cut open, caster is found to house paper-wrapped candies
    2933 If hit by a bludgeon on a natural 20, caster abandons magic use
    2934 If hit by a bludgeon on a natural 20, caster ages 1d100 years
    2935 If hit by a bludgeon on a natural 20, caster becomes a werewolf
    2936 If hit by a bludgeon on a natural 20, caster becomes undead
    2937 If hit by a bludgeon on a natural 20, caster bursts into flame
    2938 If hit by a bludgeon on a natural 20, caster causes a Chaos Burst
    2939 If hit by a bludgeon on a natural 20, caster changes sex
    2940 If hit by a bludgeon on a natural 20, caster doubles in height
    2941 If hit by a bludgeon on a natural 20, caster falls 1d100 feet
    2942 If hit by a bludgeon on a natural 20, caster finds a magical ring
    2943 If hit by a bludgeon on a natural 20, caster gains a new language
    2944 If hit by a bludgeon on a natural 20, caster gains one level
    2945 If hit by a bludgeon on a natural 20, caster gets hopelessly lost
    2946 If hit by a bludgeon on a natural 20, caster goes berserk
    2947 If hit by a bludgeon on a natural 20, caster grows 1d4 extra arms
    2948 If hit by a bludgeon on a natural 20, caster grows another head
    2949 If hit by a bludgeon on a natural 20, caster has a divine vision
    2950 If hit by a bludgeon on a natural 20, caster hears ghostly voices
    2951 If hit by a bludgeon on a natural 20, caster is badly sunburned
    2952 If hit by a bludgeon on a natural 20, caster is blind until dawn
    2953 If hit by a bludgeon on a natural 20, caster is briefly paralyzed
    2954 If hit by a bludgeon on a natural 20, caster is cloned
    2955 If hit by a bludgeon on a natural 20, caster is completely healed
    2956 If hit by a bludgeon on a natural 20, caster is named a heretic
    2957 If hit by a bludgeon on a natural 20, caster is paralyzed by fear
    2958 If hit by a bludgeon on a natural 20, caster is thrown 1d100 feet
    2959 If hit by a bludgeon on a natural 20, caster loses 1d8 teeth
    2960 If hit by a bludgeon on a natural 20, caster loses all fear
    2961 If hit by a bludgeon on a natural 20, caster loses all inhibition
    2962 If hit by a bludgeon on a natural 20, caster loses his spellbook
    2963 If hit by a bludgeon on a natural 20, caster loses one level
    2964 If hit by a bludgeon on a natural 20, caster no longer needs food
    2965 If hit by a bludgeon on a natural 20, caster returns to this spot
    2966 If hit by a bludgeon on a natural 20, caster shatters like glass
    2967 If hit by a bludgeon on a natural 20, caster suffers no damage
    2968 If hit by a bludgeon on a natural 20, caster teleports 2d6 miles
    2969 If hit by a bludgeon on a natural 20, caster wins 500 gold pieces
    2970 If hit by a bludgeon on a natural 20, casteris head explodes
    2971 If hit by a bludgeon on a natural 20, casteris Strength is halved
    2972 If hit by a bludgeon on a natural 20, casteris teeth turn to gold
    2973 If slain before sunset, caster dissolves into a putrid slush
    2974 Illusions cast by caster make him 2X as heavy for their duration 
    2975 In matters of barter, caster offers his spellbook first
    2976 In the next few days, caster unearths a statue of himself
    2977 Iridescent plumage sprouts from casteris shoulder blades
    2978 Lightning flashes about the casteris head during battle
    2979 Lightning is 3% likely to strike the caster on any given day
    2980 Luxuriant, leafy foliage sprouts from the casteris head
    2981 Magic items are 10% likely to fail when caster uses them
    2982 Magic items use charges at 50% normal rate if caster uses them
    2983 Magical animals seem to mock the caster while heis not looking
    2984 Magical armor bonuses are 50% likely to fail for the caster
    2985 Magical armor bonuses no longer work at all for the caster
    2986 Magical blades that hit the caster apply no magical damage bonus
    2987 Magical creatures and fantastical animals are invisible to caster
    2988 Magical creatures ignore and are impervious to the caster
    2989 Merchants charge the caster 2X as much for their wares
    2990 Merchants readily identify the caster as a notorious thief
    2991 Merchants readily identify the caster as a trustworthy customer
    2992 Meteoritic iron is powerfully toxic to the caster
    2993 Mocking, spectral voices taunt the caster incessantly
    2994 Money paid by caster appears to be obviously counterfeit
    2995 Money paid by caster rapidly depreciates in value
    2996 Mysterious runes are visible on the casteris skin in moonlight
    2997 Nearest angry mob identifies caster as its leader
    2998 Nearest angry mob identifies caster as the cause of its outrage
    2999 Nearest ant colony begins worshipping the caster as its god
    3000 Nearest colony of bees identifies the caster as an enemy
    3001 Nearest colony of bees identifies the caster as its queen
    3002 Nearest dragon has a vendetta against the caster
    3003 Nearest dragon urgently desires an audience with the caster
    3004 Nearest horse has been plotting against the caster for years
    3005 Nearest horse is ravenously hungry for the casteris flesh
    3006 Nearest statue animates and begins stalking the caster
    3007 Nearest tree falls on caster but doesnit make a sound
    3008 Nearest tree falls on caster, pinning him but not harming him
    3009 Nearest wizard decides that the caster owes him a favor
    3010 Nearest wizard thinks that the caster is plotting against him
    3011 Next 1d4 attacks on caster automatically inflict maximum damage
    3012 Next 1d4 attacks on caster automatically inflict minimum damage
    3013 Next 1d4 attacks on caster automatically leave hideous scars
    3014 Next 1d4 attacks on caster equally affect the attackers
    3015 Next attack on caster causes him to hallucinate for 1d4 hours
    3016 Next attack on caster has a +10 ToHit bonus
    3017 Next attack on caster kills him, but he resurrects at dawn
    3018 Next attack on caster literally knocks the smile off of his face
    3019 Next blade to cut the caster vanishes until that wound is healed
    3020 Next blade to cut the caster will never rust or go dull
    3021 Next bridge that caster crosses turns to chocolate
    3022 Next creature slain by caster infects him with a strange disease
    3023 Next creature slain by caster is avenged by 10d10 kobolds
    3024 Next creature slain by caster is consumed by flames in 1d8 rounds
    3025 Next creature slain by caster is resurrected in 1d10 turns
    3026 Next creature slain by caster places a Geas on him as it dies
    3027 Next creature slain by caster pursues him as a vengeful undead
    3028 Next door opened by caster becomes sentient and animated
    3029 Next door opened by caster can never be closed again
    3030 Next door opened by caster can never be opened by him again
    3031 Next door opened by caster causes a pit to open beneath his feet
    3032 Next door opened by caster causes all of his spells to discharge
    3033 Next door opened by caster dispels any magic then affecting him
    3034 Next door opened by caster explodes as a 1d10HD fireball
    3035 Next door opened by caster explodes in a swarm of searing embers
    3036 Next door opened by caster falls on him heavily
    3037 Next door opened by caster floods the room on the opposite side
    3038 Next door opened by caster gives him a useful bit of information
    3039 Next door opened by caster hurls him out of the nearest window
    3040 Next door opened by caster ignites the room on the opposite side
    3041 Next door opened by caster is thereafter as clear as glass
    3042 Next door opened by caster knocks him unconscious
    3043 Next door opened by caster leads directly out of the universe
    3044 Next door opened by caster leads to a confessional booth
    3045 Next door opened by caster leads to a courtyard with no doors
    3046 Next door opened by caster leads to a distant crypt
    3047 Next door opened by caster leads to a distant mountaintop
    3048 Next door opened by caster leads to a distant ship on the ocean
    3049 Next door opened by caster leads to a dragonis nest
    3050 Next door opened by caster leads to a dragonis treasure horde
    3051 Next door opened by caster leads to a fabulous ballroom
    3052 Next door opened by caster leads to a featureless desert
    3053 Next door opened by caster leads to a filthy and fetid stable
    3054 Next door opened by caster leads to a hidden oubliette
    3055 Next door opened by caster leads to a huge monsteris stomach
    3056 Next door opened by caster leads to a long-forgotten vault
    3057 Next door opened by caster leads to a magical armory
    3058 Next door opened by caster leads to a meat locker
    3059 Next door opened by caster leads to a modern bathroom
    3060 Next door opened by caster leads to a mysterious control room
    3061 Next door opened by caster leads to a room full of hourglasses
    3062 Next door opened by caster leads to a sacrificial altar
    3063 Next door opened by caster leads to a terrible misunderstanding
    3064 Next door opened by caster leads to a treasury of fabulous wealth
    3065 Next door opened by caster leads to a vast cornfield
    3066 Next door opened by caster leads to a vast magical library
    3067 Next door opened by caster leads to a vast, snow-swept plain
    3068 Next door opened by caster leads to a vault deep in a coal mine
    3069 Next door opened by caster leads to a warehouse full of candy
    3070 Next door opened by caster leads to all manner of confusion
    3071 Next door opened by caster leads to an enormous wine cellar
    3072 Next door opened by caster leads to an overflowing sewer
    3073 Next door opened by caster leads to another plane of existence
    3074 Next door opened by caster leads to deep within a blazing forest
    3075 Next door opened by caster leads to goblin barracks
    3076 Next door opened by caster leads to his home
    3077 Next door opened by caster leads to interstellar space
    3078 Next door opened by caster leads to the basement of a brothel
    3079 Next door opened by caster leads to the bottom of the sea
    3080 Next door opened by caster leads to the center of a labyrinth
    3081 Next door opened by caster leads to the center of the universe
    3082 Next door opened by caster leads to the kingis linen closet
    3083 Next door opened by caster leads to the last door he opened
    3084 Next door opened by caster leads to the middle of a battlefield
    3085 Next door opened by caster leads to the mind of a famous actor
    3086 Next door opened by caster leads to the queenis bedchamber
    3087 Next door opened by caster leads to the roof of that building
    3088 Next door opened by caster leads to the room that he just left
    3089 Next door opened by caster leads to the royal treasury
    3090 Next door opened by caster leads to the top of a distant volcano
    3091 Next door opened by caster leads to this location
    3092 Next door opened by caster leads to tomorrow but not back
    3093 Next door opened by caster leads to war between 1d4 nations
    3094 Next door opened by caster locks shut behind him
    3095 Next door opened by caster opens upon a sanity-damaging vista
    3096 Next door opened by caster plunges that room into total darkness
    3097 Next door opened by caster releases a cloud of choking smoke
    3098 Next door opened by caster restores him to full hit points
    3099 Next door opened by caster reveals a caterpillar smoking a hookah
    3100 Next door opened by caster reveals a scene of horrid debauchery
    3101 Next door opened by caster reveals an unutterably foul monster
    3102 Next door opened by caster reveals Death on the opposite side
    3103 Next door opened by caster triggers a Chaos Burst
    3104 Next door opened by caster turns into a vault door of heavy steel 
    3105 Next enemy to wound caster also Charms him
    3106 Next enemy to wound caster begins to resemble him
    3107 Next enemy to wound caster canit harm him for 1d4 days thereafter
    3108 Next enemy to wound caster disarms himself and runs away
    3109 Next enemy to wound caster gains one level or hit die
    3110 Next enemy to wound caster heroically defends him for 1d4 turns
    3111 Next enemy to wound caster is attacked by vermin
    3112 Next enemy to wound caster is healed of any current damage
    3113 Next enemy to wound caster is heavily smeared with bacon grease
    3114 Next enemy to wound caster is himself restored to full hit points
    3115 Next enemy to wound caster is teleported to casteris home
    3116 Next enemy to wound caster is teleported to his own home
    3117 Next enemy to wound caster is thrown 4d6 hours into the future
    3118 Next enemy to wound caster sinks into the ground to his knees
    3119 Next enemy to wound caster suffers an equivalent injury
    3120 Next enemy to wound caster then attacks his own allies
    3121 Next enemy wounded by caster becomes an ally for 1d6 rounds
    3122 Next enemy wounded by caster becomes ethereal for 4d6 hours
    3123 Next enemy wounded by caster becomes immune to fire
    3124 Next enemy wounded by caster becomes invisible to caster
    3125 Next enemy wounded by caster becomes king
    3126 Next enemy wounded by caster begins to age one year per round
    3127 Next enemy wounded by caster can no longer see the caster
    3128 Next enemy wounded by caster contracts some magical disease
    3129 Next enemy wounded by caster erupts into a cloud of angry wasps
    3130 Next enemy wounded by caster is attacked by feral cats
    3131 Next enemy wounded by caster is Healed
    3132 Next enemy wounded by caster is immune to magic for 2d4 rounds
    3133 Next enemy wounded by caster is invisible to him, and vice versa
    3134 Next enemy wounded by caster is suddenly fabulously wealthy
    3135 Next enemy wounded by caster loses an additional 1d100 hit points
    3136 Next enemy wounded by caster must Save or change alignment
    3137 Next enemy wounded by caster must Save or Disintegrate
    3138 Next enemy wounded by caster teleports 1d100 miles
    3139 Next enemy wounded by caster teleports to a safe location nearby
    3140 Next enemy wounded by caster teleports to casteris home
    3141 Next enemy wounded by caster turns into a two-headed dragon
    3142 Next enemy wounded by caster turns to stone over 1d10 rounds
    3143 Next enemy wounded by caster was never born
    3144 Next enemy wounded by caster will resurrect 24 hours after death
    3145 Next horse ridden by caster acquires lycanthropy
    3146 Next horse ridden by caster develops an intense hatred of humans
    3147 Next horse ridden by caster gains Intelligence equal to his own
    3148 Next horse ridden by caster is blasted to ashes beneath him
    3149 Next horse ridden by caster is reconfigured into humanoid shape
    3150 Next horse ridden by caster runs to the nearest pit and jumps in
    3151 Next horse ridden by caster sprouts another head facing backwards
    3152 Next horse ridden by caster sprouts horns like a bull
    3153 Next horse ridden by caster sprouts two additional pairs of legs
    3154 Next horse ridden by caster turns hollow and made of wood
    3155 Next horse ridden by caster turns into a cow
    3156 Next lycanthrope to attack caster is cured of lycanthropy
    3157 Next meal prepared by caster canit be digested by mortals
    3158 Next meal prepared by caster dissolves into a stinking mush
    3159 Next meal prepared by caster functions as a potion of healing
    3160 Next meal prepared by caster harms the sanity of any who eat it
    3161 Next meal prepared by caster has strong anesthetic properties
    3162 Next meal prepared by caster induces hallucinations in Dwarves
    3163 Next meal prepared by caster induces insanity for 1d4 hours
    3164 Next meal prepared by caster induces megalomania in Halflings
    3165 Next meal prepared by caster induces pyromania in Elves
    3166 Next meal prepared by caster induces raving paranoia in humans
    3167 Next meal prepared by caster induces uncontrollable debauchery
    3168 Next meal prepared by caster induces xenophobia in Gnomes
    3169 Next meal prepared by caster is lethally toxic to him
    3170 Next meal prepared by caster is the best meal in all of history
    3171 Next meal prepared by caster is unpalatable in sunlight
    3172 Next meal prepared by caster shines as brightly as the sun
    3173 Next meal prepared by caster tastes strongly of manure
    3174 Next meal prepared by caster tastes strongly of soap
    3175 Next missile shot at caster passes in one ear and out the other
    3176 Next missile shot at caster turns to gold and falls to the ground
    3177 Next permanent spell cast by caster fails in 1d4 rounds
    3178 Next permanent spell cast by caster functions only intermittently
    3179 Next person struck by casteris magic becomes hopelessly drunk
    3180 Next person struck by casteris magic goes insane for 2d4-1 days
    3181 Next person struck by casteris magic is stricken blind and deaf
    3182 Next person to see casteris reflection attacks him immediately
    3183 Next person to touch the caster acquires illusory leprosy
    3184 Next person to touch the caster canit speak to him until sunset
    3185 Next person to touch the caster is dressed just like him
    3186 Next person to touch the caster is invisible to him for 1d4 days
    3187 Next person to touch the caster is stricken permanently bald
    3188 Next person to touch the caster then attacks him for one round
    3189 Next person to whom caster speaks acquires a phony language
    3190 Next person to whom caster speaks adopts the casteris voice
    3191 Next person to whom caster speaks attacks him for 1d6 rounds
    3192 Next person to whom caster speaks can Command him 1d4 times
    3193 Next person to whom caster speaks demands 10d10 gold pieces
    3194 Next person to whom caster speaks develops a stutter until sunset
    3195 Next person to whom caster speaks disappears until sunset
    3196 Next person to whom caster speaks forgets who the caster is
    3197 Next person to whom caster speaks hasnit slept for 2d10 days
    3198 Next person to whom caster speaks hates him for 1d4 hours
    3199 Next person to whom caster speaks ignores him for 2d4 hours
    3200 Next person to whom caster speaks is destined to kill him someday
    3201 Next person to whom caster speaks is dressed just like him
    3202 Next person to whom caster speaks is invisible to him until dawn
    3203 Next person to whom caster speaks is overcome by awful boredom
    3204 Next person to whom caster speaks is overcome by hunger
    3205 Next person to whom caster speaks is soaked with icy brine
    3206 Next person to whom caster speaks is stricken deaf for 2d4 rounds
    3207 Next person to whom caster speaks is stricken mute until sunset
    3208 Next person to whom caster speaks is teleported 10d10 feet
    3209 Next person to whom caster speaks is unable to eat for 1d4 days
    3210 Next person to whom caster speaks looks just like him until dawn
    3211 Next person to whom caster speaks mocks him outrageously
    3212 Next person to whom caster speaks must give him 8d8 gold pieces
    3213 Next person to whom caster speaks races away at top speed
    3214 Next person to whom caster speaks regains 1d4 hit points
    3215 Next person to whom caster speaks shrinks by 25% for 1d4 days
    3216 Next person to whom caster speaks suspects the caster of heresy
    3217 Next potion imbibed by caster alerts everyone to his whereabouts
    3218 Next potion imbibed by caster burns his home to the ground
    3219 Next potion imbibed by caster cancels any resurrections heis had
    3220 Next potion imbibed by caster causes him to be Slowed
    3221 Next potion imbibed by caster causes him to spit out wood chips
    3222 Next potion imbibed by caster causes him to sprout feathers
    3223 Next potion imbibed by caster causes him to sprout tentacles
    3224 Next potion imbibed by caster causes his clothing to disintegrate
    3225 Next potion imbibed by caster causes his voice to echo ominously
    3226 Next potion imbibed by caster changes his alignment for 2d8 hours
    3227 Next potion imbibed by caster changes his sex for its duration
    3228 Next potion imbibed by caster cures him of any current diseases
    3229 Next potion imbibed by caster doubles in volume 1d20 times
    3230 Next potion imbibed by caster enables him to breathe underwater
    3231 Next potion imbibed by caster enlarges his hands by 50%
    3232 Next potion imbibed by caster freezes him solid until sunset
    3233 Next potion imbibed by caster gives him chimp-like proportions
    3234 Next potion imbibed by caster glues his mouth shut 
    3235 Next potion imbibed by caster has no effect whatsoever
    3236 Next potion imbibed by caster has only half its normal potency
    3237 Next potion imbibed by caster has the same effect as the last one
    3238 Next potion imbibed by caster hurls him 5d10 yards
    3239 Next potion imbibed by caster induces a fit of spastic coughing
    3240 Next potion imbibed by caster induces crazed religious fervor
    3241 Next potion imbibed by caster induces intense vertigo
    3242 Next potion imbibed by caster induces lycanthropy for 1d4 months
    3243 Next potion imbibed by caster induces pacifism
    3244 Next potion imbibed by caster induces phenomenal hallucinations
    3245 Next potion imbibed by caster induces temporary homicidal rage
    3246 Next potion imbibed by caster induces uncharacteristic generosity
    3247 Next potion imbibed by caster inflicts an embarrassing ailment
    3248 Next potion imbibed by caster is 5% likely to kill him outright
    3249 Next potion imbibed by caster is 10% likely to last 1d10 years
    3250 Next potion imbibed by caster is actually a living thing
    3251 Next potion imbibed by caster is incredibly addictive
    3252 Next potion imbibed by caster is powerfully emetic
    3253 Next potion imbibed by caster is pure human blood
    3254 Next potion imbibed by caster lasts only until he speaks
    3255 Next potion imbibed by caster makes foliage sprout from his head
    3256 Next potion imbibed by caster makes gold invisible to him
    3257 Next potion imbibed by caster makes him -4 to Save vs Fortitude
    3258 Next potion imbibed by caster makes him a terrific dancer
    3259 Next potion imbibed by caster makes him age one year per round
    3260 Next potion imbibed by caster makes him ambidextrous
    3261 Next potion imbibed by caster makes him blink like a neon sign
    3262 Next potion imbibed by caster makes him crave raw meat
    3263 Next potion imbibed by caster makes him forget his name
    3264 Next potion imbibed by caster makes him forget the past 24 hours
    3265 Next potion imbibed by caster makes him hate magic for 1d4 days
    3266 Next potion imbibed by caster makes him hate to answer questions
    3267 Next potion imbibed by caster makes him horrifyingly ugly
    3268 Next potion imbibed by caster makes him illiterate for 1d10 days
    3269 Next potion imbibed by caster makes him invisible for 1d6 turns
    3270 Next potion imbibed by caster makes him invisible to undead
    3271 Next potion imbibed by caster makes him levitate 1d10 yards
    3272 Next potion imbibed by caster makes him look 5d10 years older
    3273 Next potion imbibed by caster makes him look like an infant
    3274 Next potion imbibed by caster makes him lose 1d100 pounds
    3275 Next potion imbibed by caster makes him overwhelmingly beautiful
    3276 Next potion imbibed by caster makes him profoundly drunk
    3277 Next potion imbibed by caster makes him see fire all around him
    3278 Next potion imbibed by caster makes him seem far more charming
    3279 Next potion imbibed by caster makes him spin rapidly 1d100 times
    3280 Next potion imbibed by caster makes him sweat blood
    3281 Next potion imbibed by caster makes him think he doesnit exist
    3282 Next potion imbibed by caster makes him think that heis dead
    3283 Next potion imbibed by caster makes him think that heis drowning
    3284 Next potion imbibed by caster makes him think that heis invisible
    3285 Next potion imbibed by caster makes him think that itis poison
    3286 Next potion imbibed by caster makes his arms and legs invisible
    3287 Next potion imbibed by caster makes his face invisible
    3288 Next potion imbibed by caster makes his flesh invisible
    3289 Next potion imbibed by caster makes his hands and feet invisible
    3290 Next potion imbibed by caster makes immune to charm-like magic
    3291 Next potion imbibed by caster makes ink invisible to him
    3292 Next potion imbibed by caster makes undead invisible to him
    3293 Next potion imbibed by caster paralyzes his hands until sunset
    3294 Next potion imbibed by caster reduces him to one hit point
    3295 Next potion imbibed by caster restores him to full hit points
    3296 Next potion imbibed by caster reveals any secret doors nearby
    3297 Next potion imbibed by caster rotates his feet 180°
    3298 Next potion imbibed by caster sets his hair ablaze
    3299 Next potion imbibed by caster shrinks his hands by 50%
    3300 Next potion imbibed by caster snuffs all fires within one mile
    3301 Next potion imbibed by caster solidifies in his stomach
    3302 Next potion imbibed by caster strikes him bald for one year
    3303 Next potion imbibed by caster tastes like lamp oil
    3304 Next potion imbibed by caster teleports him to his home
    3305 Next potion imbibed by caster throws him 1d4 days into the future
    3306 Next potion imbibed by caster triggers a Chaos Burst
    3307 Next potion imbibed by caster turns him into 1d100 frogs
    3308 Next potion imbibed by caster turns him into a zombie until dawn
    3309 Next potion imbibed by caster turns him to vapor for 1d10 rounds
    3310 Next potion imbibed by caster turns his hands into feet
    3311 Next potion imbibed by caster turns his head to a cube
    3312 Next potion imbibed by caster turns his lips and tongue to steel
    3313 Next potion imbibed by caster turns his skeleton to steel
    3314 Next potion imbibed by caster turns his skin permanently orange
    3315 Next potion imbibed by caster turns his speech to gibberish
    3316 Next potion imbibed by caster works only during every other round
    3317 Next puddle stepped in by caster drains 1d10 hit points
    3318 Next puddle stepped in by caster freezes solid around his feet
    3319 Next puddle stepped in by caster ignites like gasoline
    3320 Next puddle stepped in by caster is charged with electricity
    3321 Next puddle stepped in by caster is full of piranha
    3322 Next puddle stepped in by caster is, to him, 10d10 feet deep
    3323 Next puddle stepped in by caster makes him think heis drowning
    3324 Next puddle stepped in by caster renders him briefly invulnerable
    3325 Next puddle stepped in by caster restores 1d10 hit points
    3326 Next puddle stepped in by caster soaks him from head to toe
    3327 Next puddle stepped in by caster teleports him to a puddle nearby
    3328 Next puddle stepped in by caster throws him 1d20 yards
    3329 Next puddle stepped in by caster turns to blood
    3330 Next spell caster casts on himself also affects someone nearby
    3331 Next spell caster casts on himself flares out of control
    3332 Next spell caster casts on himself has the opposite effect
    3333 Next spell caster casts on himself persists for 1d4 days
    3334 Next spell caster casts on himself takes effect 1d4 days later
    3335 Next spell caster casts on himself works at 2X normal potency
    3336 Next spell to hit the caster also renders his head invisible
    3337 Next spell to hit the caster causes him to glow brightly
    3338 Next spell to hit the caster leaves him hideously scarred
    3339 Next spell to hit the caster likewise affects whoever cast it
    3340 Next spell to hit the caster renders him blind for its duration
    3341 Next spell to hit the caster takes effect 4d6 hours later
    3342 Next successful attack upon caster hits a bystander instead
    3343 Next successful attack upon caster knocks him unconscious
    3344 Next sword that wounds caster acquires a permanent +2 bonus
    3345 Next sword that wounds caster heals him for 1d10 hit points
    3346 Next sword that wounds caster heats to 10d100 degrees
    3347 Next sword that wounds caster is totally rusted by dawn tomorrow
    3348 Next sword that wounds caster likewise wounds its wielder
    3349 Next sword that wounds caster mimics his personality thereafter
    3350 Next sword that wounds caster must Save or disintegrate
    3351 Next sword that wounds caster then ignites and burns like paper
    3352 Next sword that wounds caster turns to gold
    3353 Next sword that wounds caster vanishes for 1d8 days
    3354 Next sword that wounds caster was coated with deadly venom
    3355 Next sword touched by caster gains a +1 ToHit bonus for 4d6 days
    3356 Next sword touched by caster turns into a crescent wrench
    3357 Next time casteris restored to full hit points, he shrinks by 50%
    3358 Next tree touched by caster animates and attacks everyone nearby
    3359 Next tree touched by caster crumbles to ash in minutes
    3360 Next wound inflicted by caster canit heal without magic
    3361 Next wound inflicted upon caster canit be healed magically
    3362 No animal will allow the caster to ride it
    3363 No matter how far the caster travels today, he winds up here
    3364 No more than 60% of casteris body can become invisible at a time 
    3365 No one now within 10 yards of caster can harm him until dawn
    3366 No one within 100 miles trusts caster enough to lend him money
    3367 Non-humanoid mammals are invisible to caster
    3368 Non-humanoid mammals react badly to the caster for 1d10 days
    3369 Non-magical blades inflict bludgeoning damage upon caster
    3370 Non-magical rodents are invisible to the caster
    3371 Objects are more resistant to fire while caster carries them
    3372 Objects handled by caster canit be made invisible for one year
    3373 Objects placed in casteris pockets freeze solid in minutes
    3374 On a successful attack roll, caster must Save or drop his weapon
    3375 On any given day, casteris left foot is 50% likely to be ethereal
    3376 On any successful attack roll, caster is still 10% likely to fail
    3377 Once per day, caster can cause himself to age 1d10 years
    3378 Once per day, caster can cause his shoes or boots to vanish
    3379 Once per day, caster can cause his spellbook to ignite
    3380 Once per day, caster can cause one flash of lightning overhead
    3381 Once per day, caster can cause one person to lie to him
    3382 Once per day, caster can cause ten pounds of ice to melt rapidly
    3383 Once per day, caster can create one loosely-packed snowball
    3384 Once per day, caster can create up to one pound of cheese
    3385 Once per day, caster can discern True North with 100% accuracy
    3386 Once per day, caster can dry a soaking wet, shirt-sized garment
    3387 Once per day, caster can eliminate rust from one sword or helmet
    3388 Once per day, caster can locate the most valuable jewel nearby
    3389 Once per day, caster can locate the nearest holy symbol
    3390 Once per day, caster can locate the nearest locked door
    3391 Once per day, caster can locate the nearest potable alcohol
    3392 Once per day, caster can locate the nearest unrefined iron ore
    3393 Once per day, caster can make his clothes vanish for 1d10 rounds
    3394 Once per day, caster can make someone briefly forget his name
    3395 Once per day, caster can pull a big, ripe turnip from the ground
    3396 Once per day, caster can purify up to one gallon of water
    3397 Once per day, caster can read a new language for 1d4 rounds
    3398 Once per day, caster can read any written language for 1d4 rounds
    3399 Once per day, caster can render glass opaque for 1d4 hours
    3400 Once per day, caster can stab himself with a dagger without harm
    3401 Once per day, caster can teleport up to one foot per level
    3402 Once per day, caster can totally ignore one attack against him
    3403 Once per day, caster can turn his hands ethereal for 1d6 rounds
    3404 Once per day, caster can turn his hands invisible for 1d10 rounds
    3405 Once per day, caster can turn his head 360° at the neck, unharmed
    3406 Once per day, caster can turn his teeth invisible for 10 minutes
    3407 Once per day, caster can turn invisible for up to three minutes
    3408 Once per week, caster can appear to be a foot taller for one hour
    3409 Once per week, caster can appear to be half his age for two hours
    3410 Once per week, caster can cause all nearby to forget his name
    3411 Once per week, caster can cause his hair to grow 1d4 inches
    3412 Once per week, caster can create 1d20 gallons of salt water
    3413 Once per week, caster can disgorge an ice cube one foot on a side
    3414 Once per week, caster can freeze up to one gallon of water
    3415 Once per week, caster can hold his breath for a full hour
    3416 Once per week, caster can ignore one fire-based spell cast at him
    3417 Once per week, caster can instantly snuff one campfire
    3418 Once per week, caster can join any two pieces of non-living wood
    3419 Once per week, caster can kill all small insects within 10 feet
    3420 Once per week, caster can levitate for 1d4 rounds
    3421 Once per week, caster can locate any artifacts within one mile
    3422 Once per week, caster can locate the nearest magical animal
    3423 Once per week, caster can locate the nearest magical blade
    3424 Once per week, caster can magically create a tasty meal for four
    3425 Once per week, caster can negate magical bonuses for 1d4 rounds
    3426 Once per week, caster can open any non-magical lock by touch
    3427 Once per week, caster can open one locked door by sneezing at it
    3428 Once per week, caster can render one cooked meal uncooked
    3429 Once per week, caster can shed and regrow 1d10 fingernails
    3430 Once per week, caster can speak only in rhyme for one hour
    3431 Once per week, caster can speak with horses for up to 1d10 rounds
    3432 Once per week, caster can strip one tree of all leaves
    3433 Once per week, caster can summon 1d20 cockroaches
    3434 Once per week, caster can summon 1d4 pigeons or sparrows
    3435 Once per week, caster can teleport his spellbook up to 1d4 miles
    3436 Once per week, caster can teleport up to 10 feet per level
    3437 Once per week, caster can turn one nearby magical blade invisible
    3438 Once per week, caster can untie one knot without touching it
    3439 Once per week, caster can walk on water, up to 5 yards per level
    3440 Once per week, caster must cast one damaging spell on himself
    3441 Once per week, caster throws a tantrum lasting 1d4 rounds
    3442 One of casteris arms acquires malevolent intelligence
    3443 One of casteris arms adopts the color and texture of brick
    3444 One of casteris arms appears to be stripped of all flesh
    3445 One of casteris arms becomes as limber as a snake
    3446 One of casteris arms becomes undead
    3447 One of casteris arms can be removed for up to 1d4 turns per day
    3448 One of casteris arms canit be cut by magical blades
    3449 One of casteris arms disappears until sunset tomorrow
    3450 One of casteris arms ignites
    3451 One of casteris arms is as pale as an albinois
    3452 One of casteris arms is encased in a tight steel sheath
    3453 One of casteris arms is impervious to magical cold
    3454 One of casteris arms is only an illusion
    3455 One of casteris arms is scarred as though badly burned by acid
    3456 One of casteris arms now juts from the center of his chest
    3457 One of casteris arms oozes fetid slime
    3458 One of casteris arms resembles a small, gnarled branch
    3459 One of casteris arms shrivels to a dry husk
    3460 One of casteris arms sprouts dozens of tiny, ugly feelers
    3461 One of casteris arms turns to solid silver
    3462 One of casteris eyes bulges like a fish eye
    3463 One of casteris eyes doubles in size
    3464 One of casteris eyes doubles in size; the other shrinks by 50%
    3465 One of casteris eyes glows with infernal radiance
    3466 One of casteris feet disintegrates
    3467 One of casteris feet is replaced by an off-balance wheel
    3468 One of casteris feet reforms into a perfect sphere
    3469 One of casteris feet refuses to come anywhere near the other
    3470 One of casteris hands doubles in size; the other shrinks by 50%
    3471 One of casteris hands is as durable as steel
    3472 One of casteris hands is green and scaly like a lizardis claw
    3473 One of casteris hands is susceptible to rust
    3474 One of casteris hands turns into an eagleis talon
    3475 One of casteris knees locks whenever nimble footwork is required
    3476 One of casteris pockets accesses a small box in his home
    3477 One side of casteris body adopts a mirror-bright sheen
    3478 One side of casteris body ages 2X as fast as the other
    3479 One side of casteris body appears to be naked by firelight
    3480 One side of casteris body changes color each hour
    3481 One side of casteris body is as hairy as an ape
    3482 One side of casteris body is blurred as if seen through ice
    3483 One side of casteris body is immune to magic cast by him
    3484 One side of casteris body is immune to normal missiles
    3485 One side of casteris body is invulnerable to fire
    3486 One side of casteris body is paralyzed for 1d4 rounds
    3487 One side of casteris body is rendered invisible for 1d4 weeks
    3488 One side of casteris body looks like a photo negative
    3489 One side of casteris body shrinks by 10%
    3490 People journey for miles to beseech the caster for healing
    3491 People journey for miles to study magic under the caster
    3492 People journey for miles to touch the hem of casteris garment
    3493 People journey for miles to voice grievances against the caster
    3494 People not in the casteris presence tend to forget about him 
    3495 Powerful jets of air blow from the casteris ears
    3496 Predators react to the caster as if he were a small rabbit
    3497 Railroad tracks run straight from here to the casteris home
    3498 Rapturous shrieks fill the air when caster removes a hat
    3499 Raw meat is invisible to the caster
    3500 Right now, caster can teleport up to 1d10 miles one time
    3501 Rocks and boulders express a vague fondness for the caster
    3502 Rope breaks 2X as readily while the caster is using it
    3503 Rope is 2X as strong while the caster is using it
    3504 Scavengers and carrion birds react to caster as if he were dead
    3505 Short, bony spikes sprout from casteris knuckles
    3506 Small objects carried by caster seem 10X as heavy to him
    3507 Smoke billows from the casteris head as from a coal chimney
    3508 Some deity has a personal vendetta against the caster
    3509 Some deity takes a personal interest in the casteris life
    3510 Some subterranean race annexes casteris home
    3511 Some subterranean race declares a holy war against the caster
    3512 Some subterranean race declares that the caster is one of them
    3513 Some subterranean race declares the caster its patron saint
    3514 Some unseen entity wipes the smile off of the casteris face
    3515 Someone nearby vanishes; in 2d6 rounds the caster disgorges him
    3516 Someone very dear to the caster doesnit really exist
    3517 Someone very dear to the caster is discovered to be undead
    3518 Something about the caster makes people suspect that heis dying
    3519 Something about the caster makes people unlikely to trust him
    3520 Sometime in the next turn, the caster punches an ally in the nose
    3521 Sometime in the next turn, the caster races into a nearby forest
    3522 Spell works normally, but caster loses 1d4 spells from memory
    3523 Spell works normally; next casting automatically causes a Burst
    3524 The bones of casteris arms and legs canit be broken
    3525 The clothes caster is wearing makes him dangerous overconfident
    3526 The clothes caster is wearing makes him feel intensely cold
    3527 The Fireball spell wonit function within 100 yards of caster
    3528 The ground beneath casteris feet flows like water for 1d4 rounds
    3529 The ground beneath casteris feet is alive for 1d4 hours
    3530 The ground beneath casteris feet sinks a depth 2X his height
    3531 The ground beneath casteris feet swirls like a whirlpool
    3532 The ground beneath casteris feet turns to living human flesh
    3533 The left and right sides of casteris body hate each other
    3534 The next spell used against caster automatically fails
    3535 The pages of casteris spellbook are indestructible
    3536 The pages of casteris spellbook are invisible; ink on them is not
    3537 The pages of casteris spellbook are replaced with gold leaf
    3538 The pages of casteris spellbook flap as though in a strong breeze
    3539 The pages of casteris spellbook turn to thin sheets of bacon
    3540 The pages of casteris spellbook turn to thin sheets of steel
    3541 The presence of undead causes caster to giggle like a fool
    3542 The rear half of casteris body appears to be made of glass
    3543 The rear half of casteris body is invisible
    3544 The spell cast most recently upon caster is retroactively undone
    3545 The wreckage of a sunken warship appears in casteris home
    3546 The wreckage of casteris home is strewn across the countryside
    3547 Thick clouds of acrid steam issue from the ground near the caster
    3548 Thick clouds of steam constantly billow from the casteris skin
    3549 Thunder rumbles overhead whenever casteris blood is spilled
    3550 To the caster, everyone appears to be sweating profusely
    3551 To the caster, everyone looks and sounds exactly like him
    3552 To the caster, everyone looks and sounds exactly like him
    3553 To the caster, everyone smells like a rotting corpse
    3554 To the caster, the weather always appears overcast and gloomy
    3555 To the caster, the weather always appears to be the same
    3556 Tomorrow, caster can speak all languages until noon
    3557 Tomorrow, caster can speak only a bizarre, esoteric language
    3558 Tomorrow, caster canit be injured by magical weapons until sunset
    3559 Tomorrow, caster finds 1d100 statues of himself in hideous poses
    3560 Tomorrow, caster finds a book detailing his complete dissection
    3561 Tomorrow, caster finds a jar containing 1d20 tiny elephants
    3562 Tomorrow, caster finds a key to a lock that doesnit yet exist
    3563 Tomorrow, caster finds a key to that mysterious door in his home
    3564 Tomorrow, caster finds a lab holding many lifeless clones of him
    3565 Tomorrow, caster finds a legendary sword & loses it the next day
    3566 Tomorrow, caster finds a piece of anachronistic technology
    3567 Tomorrow, caster finds a ruby as large as his head
    3568 Tomorrow, caster finds a secret Gate to the Astral Plane
    3569 Tomorrow, caster finds a small pouch full of counterfeit rubies
    3570 Tomorrow, caster finds a small pouch full of diamonds
    3571 Tomorrow, caster finds a small pouch full of scorpions
    3572 Tomorrow, caster finds a small pouch full of strong acid
    3573 Tomorrow, caster finds a small pouch full of teeth
    3574 Tomorrow, caster finds a tunnel that leads to his home
    3575 Tomorrow, caster finds a vial containing a viscous salve
    3576 Tomorrow, caster finds his own badly-decomposed corpse
    3577 Tomorrow, caster finds what looks like his own severed head
    3578 Tomorrow, caster forms an alliance with a long-hated enemy
    3579 Tomorrow, caster has absolutely no desire to use magic
    3580 Tomorrow, caster is unable to cast magic before noon
    3581 Tomorrow, caster meets a priest who places a Geas upon him
    3582 Tomorrow, caster meets an immortal desperate and unable to die
    3583 Tomorrow, caster meets and insults the avatar of some deity
    3584 Tomorrow, caster meets his long-lost and malevolent twin
    3585 Tomorrow, caster meets his mentor, who expresses disapproval
    3586 Tomorrow, caster meets someone claiming to have sold the world
    3587 Tomorrow, caster meets someone claiming to own the casteris soul
    3588 Tomorrow, caster meets someone convinced that he doesnit exist
    3589 Tomorrow, caster meets someone desperate to be his bodyguard
    3590 Tomorrow, caster meets someone desperate to become the caster
    3591 Tomorrow, caster meets someone on the verge of becoming a god
    3592 Tomorrow, caster meets someone who calls humans a delicacy
    3593 Tomorrow, caster meets someone who can command demons
    3594 Tomorrow, caster meets someone who can remove his own heart
    3595 Tomorrow, caster meets someone who can remove his skin at will
    3596 Tomorrow, caster meets someone who claims the caster killed him
    3597 Tomorrow, caster meets someone who claims to be haunting him
    3598 Tomorrow, caster meets someone who claims to be him
    3599 Tomorrow, caster meets someone who claims to be his father
    3600 Tomorrow, caster meets someone who claims to be his grandchild
    3601 Tomorrow, caster meets someone who foretells a bleak fate for him
    3602 Tomorrow, caster meets someone who has vowed to murder him
    3603 Tomorrow, caster meets someone who names the caster his heir
    3604 Tomorrow, caster meets someone who offers him his firstborn son
    3605 Tomorrow, caster meets someone who offers to sell him an artifact
    3606 Tomorrow, caster meets someone who owes him a lot of money
    3607 Tomorrow, caster meets someone who tries to eat his eyes
    3608 Tomorrow, caster meets someone who wants to buy his pancreas
    3609 Tomorrow, caster meets someone whois 100% immune to magic
    3610 Tomorrow, caster meets someone whois plotting to kill the king
    3611 Tomorrow, caster meets someone whom caster knows to be dead
    3612 Tomorrow, caster meets someone whom he owes a lot of money
    3613 Tomorrow, caster meets someone whose existence is impossible
    3614 Tomorrow, caster meets someone with the secret of immortality
    3615 Tomorrow, caster meets the alchemist who created him
    3616 Tomorrow, caster must Save vs Will once per hour or combust
    3617 Tomorrow, caster saves the life of a notorious villain
    3618 Tomorrow, caster saves the life of someone important
    3619 Tomorrow, caster saves the life whom fate has decreed must die
    3620 Tomorrow, caster thinks heis awakened from a centuries-long sleep
    3621 Tomorrow, caster thinks that magic no longer functions
    3622 Tomorrow, caster uncovers a well-funded plot against his life
    3623 Tomorrow, caster unknowingly snubs a powerful spellcaster
    3624 Tomorrow, caster vanishes at dawn and reappears at sunset 
    3625 Tomorrow, caster wakes 2d10 miles from where he fell asleep
    3626 Tomorrow, caster wakes and gives apparently divine prophecy
    3627 Tomorrow, caster wakes as if heis spent a month in the desert
    3628 Tomorrow, caster wakes at this location
    3629 Tomorrow, caster wakes convinced that all of his allies are dead
    3630 Tomorrow, caster wakes convinced that he must return to his home
    3631 Tomorrow, caster wakes convinced that heis just been created
    3632 Tomorrow, caster wakes convinced that heis just been resurrected
    3633 Tomorrow, caster wakes convinced that heis murdered his allies
    3634 Tomorrow, caster wakes convinced that heis slept for 2d10 years
    3635 Tomorrow, caster wakes convinced that his limbs are mechanical
    3636 Tomorrow, caster wakes covered in pungent, glowing moss
    3637 Tomorrow, caster wakes early and races back to this location
    3638 Tomorrow, caster wakes embarrassingly drunk
    3639 Tomorrow, caster wakes in a coil of dried and sinuous vines
    3640 Tomorrow, caster wakes in a full-length body cast
    3641 Tomorrow, caster wakes in the branches of a tall tree
    3642 Tomorrow, caster wakes on the bank of the River Styx
    3643 Tomorrow, caster wakes reeking of garlic and raw meat
    3644 Tomorrow, caster wakes seated in the throne of the nearest king
    3645 Tomorrow, caster wakes standing atop a tall pole
    3646 Tomorrow, caster wakes standing in a barrel of chum
    3647 Tomorrow, caster wakes to find that 1d4 days have passed
    3648 Tomorrow, caster wakes unable to stand until he casts a spell
    3649 Tomorrow, caster wakes where he awoke this morning
    3650 Tomorrow, caster wakes with a mouthful of mud from a cemetery
    3651 Tomorrow, caster wakes with mysterious tattoos all over his body
    3652 Tomorrow, caster wakes with no memory of the previous day
    3653 Tomorrow, caster wakes wrapped in disease-ridden blankets
    3654 Trees and bushes express open hostility toward the caster
    3655 Ugly thorns sprout from the casteris cheekbones
    3656 Undead have commandeered casteris home while heis been away
    3657 Undead skeletons react to caster as if he were one of them
    3658 Undead tend to ignore the caster until he acts against them
    3659 Undead tend to laugh in the casteris presence
    3660 Vile tentacles sprout from the casteris face
    3661 Viscous pus oozes from the casteris orifices until sunset
    3662 Water feels like acid to the caster but doesnit actually harm him
    3663 Water splashes from casteris footfalls for the next 1d12 hours
    3664 Water trickles from casteris elbows for 1d4 hours
    3665 Weight-affecting spells make the caster weigh 2X as much as iron
    3666 Well-funded liars slander casteris conduct in a war decades past
    3667 Whatever caster is wearing is a synthetic copy of the real thing
    3668 When caster dies, 10d10 voles burst from his corpse
    3669 When caster dies, a small religious cult starts worshipping him
    3670 When caster dies, a Chaos Burst occurs: roll again at that time
    3671 When caster dies, he canit be resurrected for 1d12 months
    3672 When caster dies, heis discovered to have died centuries ago
    3673 When caster dies, heis found to have been remotely controlled
    3674 When caster dies, heis quickly impersonated by a doppelganger
    3675 When caster dies, his allies deny that they ever knew him
    3676 When caster dies, his corpse appears riddled by gunfire
    3677 When caster dies, his corpse attacks the nearest Elf
    3678 When caster dies, his corpse disgorges 10d1000 gallons of water
    3679 When caster dies, his corpse giggles maniacally for 1d4 hours
    3680 When caster dies, his corpse is dismembered and scattered
    3681 When caster dies, his corpse is dragged away by goblins
    3682 When caster dies, his corpse is elected to public office
    3683 When caster dies, his corpse melts like a snowman
    3684 When caster dies, his corpse runs shrieking through a nearby town
    3685 When caster dies, his corpse shatters into countless fragments
    3686 When caster dies, his corpse swells to 1d6 times normal size
    3687 When caster dies, his corpse turns to densely packed salt
    3688 When caster dies, his corpse turns to solid bronze
    3689 When caster dies, his corpse weighs as much as lead
    3690 When caster dies, his heart assumes a life of its own
    3691 When caster dies, his killer is thrown 1d20 days into the future
    3692 When caster dies, his last word is "Rosebud"
    3693 When caster dies, his name becomes synonymous with treachery
    3694 When caster dies, his skeleton turns to glass
    3695 When caster dies, his skull turns to wood
    3696 When caster dies, his spellbook burns to cinders in 1d4 rounds
    3697 When caster dies, his veins are discovered to be filled with gold
    3698 When caster dies, some random person nearby dies as well
    3699 When caster dies, the first person to touch his corpse also dies
    3700 When caster dies, the nearest town is evacuated
    3701 When caster dies, the nearest tree falls on his corpse
    3702 When caster dies, the sky turns blood red for 2d4-1 days
    3703 When caster dies, violent riots break out in the nearest town
    3704 When caster is angry, a small snake slithers out of his ear
    3705 When caster is angry, he foams at the mouth like a rabid dog
    3706 When caster is angry, he turns bright green
    3707 When caster is angry, his face appears scarred and deformed
    3708 When caster is angry, his face appears to glisten with slime
    3709 When caster is angry, his head appears to be a bare skull
    3710 When caster is angry, insects appear to swarm over his face
    3711 When caster is angry, steam billows from his nostrils
    3712 When caster is surprised, he randomly teleports 1d4 yards
    3713 When caster is surprised, his head briefly doubles in size
    3714 When caster is surprised, his head spins 360°
    3715 When caster next casts this spell, he becomes hopelessly lost
    3716 When caster next casts this spell, he feels overwhelming deja vu
    3717 When caster next casts this spell, he teleports to this spot
    3718 When caster next casts this spell, heis attacked by squirrels
    3719 When caster next casts this spell, heis paralyzed until sunset
    3720 When caster next casts this spell, heis stricken with Confusion
    3721 When caster next casts this spell, his age temporarily doubles
    3722 When caster next casts this spell, his clothing attacks him
    3723 When caster next casts this spell, his clothing freezes solid
    3724 When caster next casts this spell, his clothing turns to cheese
    3725 When caster next casts this spell, the winter solstice occurs
    3726 When caster next draws blood, a large pit opens beneath him
    3727 When caster next draws blood, he disgorges 1d10 gallons of blood
    3728 When caster next draws blood, he laughs like a demon
    3729 When caster next draws blood, he leaps 4d6 hours into the future
    3730 When caster next draws blood, he loses 2d10 hit points
    3731 When caster next draws blood, he must Save or fall unconscious
    3732 When caster next draws blood, he regains 1d10 hit points
    3733 When caster next draws blood, he suffers an equivalent wound
    3734 When caster next draws blood, he teleports 1d100 yards
    3735 When caster next draws blood, heis addicted to the taste of blood
    3736 When caster next draws blood, heis attacked by rabid bats
    3737 When caster next draws blood, heis restored to full hit points
    3738 When caster next draws blood, heis stricken mute until sunrise
    3739 When caster next draws blood, his eyes blaze with flame
    3740 When caster next draws blood, his weapon turns to steam
    3741 When caster next draws blood, rain immediately begins to fall
    3742 When caster next draws blood, thunder rumbles in the distance
    3743 When caster next enters a building, he teleports onto its roof
    3744 When caster next enters a building, his clothes catch fire
    3745 When caster next enters a lake, any boats nearby turn invisible
    3746 When caster next enters a lake, he blasphemes some ocean god
    3747 When caster next enters a lake, he decides to become amphibious
    3748 When caster next enters a lake, he discovers a small island
    3749 When caster next enters a lake, he emerges draped with seaweed
    3750 When caster next enters a lake, he encounters a lady with a sword
    3751 When caster next enters a lake, he encounters a tentacled monster
    3752 When caster next enters a lake, he finds 1d4 valuable pearls
    3753 When caster next enters a lake, he has visions of a sunken city
    3754 When caster next enters a lake, he spouts water like a whale 
    3755 When caster next enters a lake, he suffers severe hypothermia
    3756 When caster next enters a lake, he teleports to a different lake
    3757 When caster next enters a lake, heis 30% likely to become a fish
    3758 When caster next enters a lake, heis attacked by sharks
    3759 When caster next enters a lake, heis attacked by turtles
    3760 When caster next enters a lake, heis befriended by otters
    3761 When caster next enters a lake, heis caught in a fishermanis net
    3762 When caster next enters a lake, heis covered with barnacles
    3763 When caster next enters a lake, heis hit by 2d8 harpoons
    3764 When caster next enters a lake, heis mistaken for a sea monster
    3765 When caster next enters a lake, heis sucked up into a waterspout
    3766 When caster next enters a lake, heis swept toward the sea
    3767 When caster next enters a lake, heis thrown to the opposite shore
    3768 When caster next enters a lake, his clothing inflates
    3769 When caster next enters a lake, his clothing vanishes
    3770 When caster next enters a lake, his feet turn into duckis feet
    3771 When caster next enters a lake, his hands and feet grow webbing
    3772 When caster next enters a lake, his home is completely flooded
    3773 When caster next enters a lake, his pockets fill with sodium
    3774 When caster next enters a lake, it becomes 2X as deep
    3775 When caster next enters a lake, it drains dry in 1d4 rounds
    3776 When caster next enters a lake, it turns from fresh to salt-water
    3777 When caster next enters a lake, itis covered by two inches of ice
    3778 When caster next enters a lake, itis heavily stocked with trout
    3779 When caster next enters a lake, night falls immediately
    3780 When caster next enters a lake, someone nearby starts to drown
    3781 When caster next enters a town, a huge festival takes place
    3782 When caster next enters a town, he finds a magical scroll
    3783 When caster next enters a town, he violates community standards
    3784 When caster next enters a town, heis imprisoned for murder
    3785 When caster next enters a town, heis named as its patron saint
    3786 When caster next enters a town, heis quickly arrested for heresy
    3787 When caster next enters a town, heis quickly elected mayor
    3788 When caster next enters a town, heis recognized as a vampire
    3789 When caster next enters a town, heis sold into slavery
    3790 When caster next enters a town, his spellbook is confiscated
    3791 When caster next enters a town, it secedes from the kingdom
    3792 When caster next enters a town, itis attacked by goblins
    3793 When caster next enters a town, itis besieged by orcs
    3794 When caster next enters a town, itis overrun by feral dogs
    3795 When caster next enters a town, itis renamed after him
    3796 When caster next enters a town, its population doubles
    3797 When caster next enters a town, martial law is declared
    3798 When caster next enters a town, the king orders it destroyed
    3799 When caster next enters a town, violent riots break out
    3800 When caster next enters his home, 1d4 exterior walls vanish
    3801 When caster next enters his home, 1d4 weeks pass in 1d4 rounds
    3802 When caster next enters his home, a small hill rises beneath it
    3803 When caster next enters his home, any curses upon him are lifted
    3804 When caster next enters his home, he ages 1d10 years
    3805 When caster next enters his home, he ages 1d10 years
    3806 When caster next enters his home, he doubts heis ever lived there
    3807 When caster next enters his home, he falls unconscious
    3808 When caster next enters his home, he finds 1d100+100 gold pieces
    3809 When caster next enters his home, he finds a secret trapdoor
    3810 When caster next enters his home, he finds a troll in residence
    3811 When caster next enters his home, he finds another spellbook
    3812 When caster next enters his home, he finds his clone in residence
    3813 When caster next enters his home, he finds it completely empty
    3814 When caster next enters his home, he forgets how to exit again
    3815 When caster next enters his home, he gains one level
    3816 When caster next enters his home, he is healed of all damage
    3817 When caster next enters his home, he loses a point of Wisdom
    3818 When caster next enters his home, he loses any memorized spells
    3819 When caster next enters his home, he must evict 2d10 squatters
    3820 When caster next enters his home, he realizes itis made of coral
    3821 When caster next enters his home, he recognizes nothing within it
    3822 When caster next enters his home, he teleports to this location
    3823 When caster next enters his home, heis attacked by kobolds
    3824 When caster next enters his home, heis blinded for 4d12 hours
    3825 When caster next enters his home, heis convinced it isnit his
    3826 When caster next enters his home, heis drafted into the military
    3827 When caster next enters his home, heis visited by solicitors
    3828 When caster next enters his home, heis visited by three ghosts
    3829 When caster next enters his home, his age is reduced by 3d4 years
    3830 When caster next enters his home, his bed combusts violently
    3831 When caster next enters his home, his clothes burst into flame
    3832 When caster next enters his home, his clothes turn to stone
    3833 When caster next enters his home, it becomes indestructible
    3834 When caster next enters his home, it becomes steamy like a sauna
    3835 When caster next enters his home, it doubles its current size
    3836 When caster next enters his home, it drifts slowly out to sea
    3837 When caster next enters his home, it falls into a heap of sawdust
    3838 When caster next enters his home, it gains an additional level
    3839 When caster next enters his home, it migrates 1d20 miles
    3840 When caster next enters his home, it sinks into the ground
    3841 When caster next enters his home, it turns invisible from within
    3842 When caster next enters his home, it turns to glass
    3843 When caster next enters his home, itis been thoroughly cleaned
    3844 When caster next enters his home, itis buried by an avalanche
    3845 When caster next enters his home, itis buried by volcanic ash
    3846 When caster next enters his home, itis encircled by a deep moat
    3847 When caster next enters his home, itis flattened by a meteor
    3848 When caster next enters his home, itis infested with vermin
    3849 When caster next enters his home, itis swept away by a tidal wave
    3850 When caster next enters his home, itis totally refurbished
    3851 When caster next enters his home, its doors and windows vanish
    3852 When caster next enters his home, monsters reside under the bed
    3853 When caster next enters his home, someoneis eaten his porridge
    3854 When caster next enters his home, the doors & windows fuse shut
    3855 When caster next enters his home, the floor vanishes
    3856 When caster next enters his home, the magistrate condemns it
    3857 When caster next enters his home, the roof ignites
    3858 When caster next kills someone, he appears in that personis home
    3859 When caster next kills someone, he must Save vs Fortitude or die
    3860 When caster next kills someone, that person quickly resurrects
    3861 When caster next opens his spellbook, heis attacked by a shark
    3862 When caster next says his name, 2d6 fish leap from his mouth
    3863 When caster next says his name, a bird flies into his mouth
    3864 When caster next says his name, he learns itis not his real name
    3865 When caster next says his name, he promptly forgets his name
    3866 When caster next says his name, his mouth is sealed shut
    3867 When caster next teleports, he arrives bound and gagged
    3868 When caster next teleports, he arrives fully Healed
    3869 When caster next touches money, he triggers a Chaos Burst
    3870 When caster next triggers a Burst, he teleports to this location
    3871 When caster next triggers a Burst, its effect is irreversible
    3872 When caster next uses magic, 2d4 zombies appear and attack him
    3873 When caster next uses magic, all vegetation within 10 yards dies
    3874 When caster next uses magic, all within one mile know about it
    3875 When caster next uses magic, an ice statue of him appears nearby
    3876 When caster next uses magic, any gold heis carrying vanishes
    3877 When caster next uses magic, cold water sprays from his ears
    3878 When caster next uses magic, he and his allies are drenched
    3879 When caster next uses magic, he becomes drunk for 1d4 hours
    3880 When caster next uses magic, he becomes invisible to his allies
    3881 When caster next uses magic, he disgorges 2d6 large clay bricks
    3882 When caster next uses magic, he loses 3d4 hit points
    3883 When caster next uses magic, he must Save or fall unconscious
    3884 When caster next uses magic, he reeks of sulfur for 1d10 hours 
    3885 When caster next uses magic, he teleports 10d10 yards randomly
    3886 When caster next uses magic, he teleports into a nearby building
    3887 When caster next uses magic, he thinks that heis at deathis door
    3888 When caster next uses magic, heis 5% likely to lose one level
    3889 When caster next uses magic, heis 10% likely to die outright
    3890 When caster next uses magic, heis shunned by other magic users
    3891 When caster next uses magic, heis thrown back to this moment
    3892 When caster next uses magic, his clone appears nearby
    3893 When caster next uses magic, his clone teleports to his home
    3894 When caster next uses magic, his clothes turn to paper
    3895 When caster next uses magic, his hands double in size
    3896 When caster next uses magic, his hands freeze solid
    3897 When caster next uses magic, his nearest ally falls unconscious
    3898 When caster next wears a hat, heis targeted for assassination
    3899 When caster opens his spellbook, heis shrouded by darkness
    3900 When caster opens his spellbook, thunder rumbles overhead
    3901 When caster teleports, he arrives 1d4 miles from the destination
    3902 When caster teleports, he arrives 2d4 hours later than expected
    3903 When caster teleports, he arrives blinded for 1d6 rounds
    3904 When caster teleports, he arrives in an embarrassing posture
    3905 When caster teleports, he arrives invisible
    3906 When caster teleports, he arrives ravenously hungry
    3907 When caster teleports, he arrives upside down
    3908 When caster teleports, he arrives with half of his gear missing
    3909 When caster teleports, only 95% + 1d10% of his body is teleported
    3910 When caster tells a falsehood, he confesses it to everyone nearby
    3911 When caster uses Mirror Image, 10X the number of Images appear
    3912 When caster uses Mirror Image, he canit tell which image is real
    3913 When caster uses Mirror Image, the Images look like demons
    3914 When caster uses Mirror Image, the Images look like infants
    3915 When caster uses Mirror Image, the Images look like skeletons
    3916 When caster uses Mirror Image, the Images look like the target
    3917 When caster uses Mirror Image, the Images look nothing like him
    3918 When casteris blood is next spilled, he ages 5d10 years
    3919 When casteris blood is next spilled, he canit speak for 1d4 turns
    3920 When casteris blood is next spilled, heis blinded for 1d4 rounds
    3921 When next struck by magic, caster becomes spotted like a leopard
    3922 When next struck by magic, caster disgorges 1d4 pounds of gravel
    3923 When next struck by magic, caster falls 6d10 feet
    3924 When next struck by magic, caster is carried aloft by a pigeons
    3925 When next struck by magic, caster sprouts wool from his arms
    3926 When next struck by magic, caster triggers a Chaos Burst
    3927 When reduced to one hit point, caster ages 2d10 years
    3928 When reduced to one hit point, caster can see invisible objects
    3929 When reduced to one hit point, caster flees, panic-stricken
    3930 When reduced to one hit point, caster flies into a berserk fury
    3931 When reduced to one hit point, caster is stricken mute
    3932 When reduced to one hit point, caster suffers wild hallucinations
    3933 When reduced to one hit point, caster teleports 2d20 yards
    3934 When reduced to one hit point, caster teleports to his home
    3935 When reduced to one hit point, caster turns invisible until dawn
    3936 When reduced to one hit point, caster turns to iron until sunset
    3937 When seen from behind, caster appears to be bleeding profusely
    3938 When seen from behind, caster appears to be on fire
    3939 When seen from behind, casteris torso is riddled with large holes
    3940 When struck by magic, caster briefly appears to be made of chrome
    3941 When struck by magic, caster briefly appears to be made of wood
    3942 When struck by magic, caster feels the urge to reveal a secret
    3943 When struck by magic, caster flies into a berserker rage
    3944 When struck by magic, caster is 10% likely to be caked in grime
    3945 When struck by magic, caster is covered by ashes and soot
    3946 When struck by magic, caster sings raucous songs for 1d4 rounds
    3947 When struck by magic, caster temporarily inflates like a balloon
    3948 Whenever caster casts a spell, a spotlight illuminates him
    3949 Whenever caster casts a spell, an invisible bronze gong is rung
    3950 Whenever caster casts a spell, electricity crackles in his hair
    3951 Whenever caster casts a spell, ghostly laughter echoes in the air
    3952 Whenever caster casts a spell, he appears to explode
    3953 Whenever caster casts a spell, he becomes light as a feather
    3954 Whenever caster casts a spell, he experiences profound remorse
    3955 Whenever caster casts a spell, he feels overwhelming euphoria
    3956 Whenever caster casts a spell, he hears glass breaking everywhere
    3957 Whenever caster casts a spell, he hears loud, discordant music
    3958 Whenever caster casts a spell, he hears the laments of the damned
    3959 Whenever caster casts a spell, he must Save or be knocked down
    3960 Whenever caster casts a spell, he must Save or shrink by 20%
    3961 Whenever caster casts a spell, he suffers crippling stage fright
    3962 Whenever caster casts a spell, he thinks that he ages 1d10 years
    3963 Whenever caster casts a spell, he whistles like a teapot
    3964 Whenever caster casts a spell, heis 10% likely to pass out
    3965 Whenever caster casts a spell, heis haunted by cryptic warnings
    3966 Whenever caster casts a spell, his bones glow visibly in his body
    3967 Whenever caster casts a spell, his clothes are glazed with frost
    3968 Whenever caster casts a spell, his ears shine like the sun
    3969 Whenever caster casts a spell, his feet swell by 10%
    3970 Whenever caster casts a spell, his spellbook must Save or combust
    3971 Whenever caster casts a spell, one of his hands grows by 25%
    3972 Whenever caster casts a spell, someone far away vows to kill him
    3973 Wherever caster walks, he sounds like heis on a squeaky floor
    3974 While caster is invisible, a faint outline can still be seen
    3975 While caster sleeps, he appears to be a perfect cube
    3976 While caster sleeps, he appears to melt like a wax dummy
    3977 While caster sleeps, he freezes solid but thaws before waking
    3978 While caster sleeps, his allies must Save or forget who he is
    3979 While caster sleeps, his arms and legs retract into his torso
    3980 While caster sleeps, his body is translucent
    3981 While caster sleeps, his body retracts into his head
    3982 While caster sleeps, his clothing and gear are invisible
    3983 While caster sleeps, his head appears detached from his body
    3984 While caster sleeps, his head retracts into his body
    3985 While caster sleeps, his whole body contracts into a small ball
    3986 While caster sleeps, luminous moths flutter over his body
    3987 While caster sleeps, mysterious runes hover over his head
    3988 While caster sleeps, rodents bring him sacrificial offerings
    3989 While caster sleeps, thousands of insects swarm over his body
    3990 While indoors, caster appears to be 5% larger
    3991 While indoors, caster feels as if heis dragging heavy chains
    3992 While indoors, caster feels as if heis in a blazing desert
    3993 While indoors, caster feels as if heis on a shipis deck
    3994 While indoors, caster feels as if heis on windswept tundra
    3995 While standing on a riverbank, caster is invisible to amphibians
    3996 While walking, caster sounds as if heis wearing full plate armor
    3997 Woodland creatures openly mock the caster and call him a coward
    3998 Woodland creatures react to the caster as if heis one of them
    3999 Woodland creatures react violently to the casteris presence
    4000 Zombies canit come within 10 feet of the caster for 1d4 days
    4001 1d8 of targetis fingers reappear elsewhere on his body
    4002 A handful of small glass marbles tumble from the targetis nose
    4003 A heavy chain runs the entire length of targetis alimentary canal
    4004 A nearby but invisible heckler pummels the target with tomatoes
    4005 A nearby tree animates and swears allegiance to the target
    4006 A nearby tree becomes ravenously carnivorous and attacks target
    4007 A nearby tree bends down and hurls the target like a catapult
    4008 A nearby tree sprays its bark at the target, briefly blinding him
    4009 A second, identical skeleton appears in the targetis body
    4010 A small fire blazes harmlessly in the targetis mouth
    4011 A tall picket fence encircles the target
    4012 A tentacle slithers from a nearby cave to grasp the target
    4013 A vital organ is ripped from targetis body for 1d100 damage
    4014 All of targetis belongings are compressed into a tiny cube nearby 
    4015 All of targetis belongings are seized by the local magistrate
    4016 All of targetis belongings are transported beyond the horizon
    4017 All of targetis belongings were stolen by a vengeful wizard
    4018 All of targetis belongings were stolen from a vengeful wizard
    4019 All that the target has ever done was really done by someone else
    4020 All voices sound alike to the target for 5d6 days
    4021 All within 100 yards with a missile weapon fire it at the target
    4022 Ambient temperature always feels 50° colder to target
    4023 Ambient temperature rises 10° when target is angry
    4024 An earthen duplicate of the target rises up and attacks him
    4025 An earthen duplicate of the target wants to take his place
    4026 An evergreen sprouts from targetis chest while he sleeps tonight
    4027 An item carried by target discharges a Chaos Burst when next used
    4028 An item carried by target explodes for 3d10 hit points of damage
    4029 An item carried by target is widely sought for its healing powers
    4030 An item carried by target releases narcotic vapors when next used
    4031 Any attack on target appears not to injure him, even if it does
    4032 Any blade hitting target for maximum damage acquires intelligence
    4033 Any blade hitting target for maximum damage acquires intelligence
    4034 Any blade hitting target for maximum damage also injects a poison
    4035 Any blade hitting target for maximum damage disappears forever
    4036 Any blade hitting target for maximum damage gains a +1 bonus
    4037 Any blade hitting target for maximum damage gets stuck in him
    4038 Any blade hitting target for maximum damage is briefly weightless
    4039 Any blade hitting target for maximum damage must Save or shatter
    4040 Any blade hitting target for maximum damage rapidly corrodes
    4041 Any blade hitting target for maximum damage turns clear as glass
    4042 Any blade hitting target for maximum damage turns to gold
    4043 Any blade hitting target for maximum damage vanishes until sunset
    4044 Any bludgeon that hits the target is 10% likely to shatter
    4045 Any bludgeon that hits the target is thereafter +4 ToHit him
    4046 Any bludgeon that hits the target sprays water like a fountain
    4047 Any bludgeon that hits the target turns to sponge as it does so
    4048 Any clothing or armor now worn by target ages 100 years per round
    4049 Any clothing or armor now worn by target is fireproof until dawn
    4050 Any clothing or armor now worn by target is soaked with tree sap
    4051 Any clothing or armor now worn by target shrinks by 30%
    4052 Any coins that target is now carrying double in value
    4053 Any coins that target is now carrying shrink by 50%
    4054 Any coins that target is now carrying turn to cheese
    4055 Any coins that target is now carrying weigh 100 pounds each
    4056 Any fire damage suffered by target equally affects someone nearby
    4057 Any fire damage suffered by target inflicts 2X normal damage
    4058 Any fire damage suffered by target is delayed for 3d4 rounds
    4059 Any fire damage suffered by target leaves cryptic scars
    4060 Any gems now carried by target are cursed against him
    4061 Any gold now carried by target belongs to a dragon
    4062 Any gold now carried by target combusts like tinder
    4063 Any jewelry that target is wearing heats to 500°
    4064 Any magic items carried by the target glow like embers until dawn
    4065 Any metal now in targetis possession becomes intensely magnetic
    4066 Any metal now in targetis possession heats to its melting point
    4067 Any metal now in targetis possession is as fragile as glass
    4068 Any metal now in targetis possession is highly flammable
    4069 Any metal now in targetis possession is transparent like glass
    4070 Any metal now in targetis possession is water soluble until dawn
    4071 Any metal now in targetis possession turns to lead
    4072 Any metal now in targetis possession turns to mercury
    4073 Any metal target is now carrying reverts to raw ore
    4074 Any metal weapons that wound the target are dulled for 1d4 rounds
    4075 Any metal weapons that wound the target are hurled 1d8 yards away
    4076 Any metal weapons that wound the target vanish for 1d4 rounds
    4077 Any missile weapon hitting the target inflicts triple damage
    4078 Any missile weapon hitting the target instantly combusts
    4079 Any missile weapon hitting the target is 10% likely to take root
    4080 Any missile weapon hitting the target suddenly triples in weight
    4081 Any missile weapons now carried by target are badly warped
    4082 Any missile weapons now carried by target have 10X normal range
    4083 Any missile weapons now carried by target have a +1 ToHit bonus
    4084 Any missile weapons now carried by target have his name on them
    4085 Any missiles fired at target are affected by Reverse Gravity
    4086 Any missiles fired at target are blown off course by high winds
    4087 Any missiles fired at target instantly sprout wings and fly away
    4088 Any missiles fired at target leave colorful trails in the air
    4089 Any missiles fired at target sound like thunder when they hit
    4090 Any missiles fired at target turn invisible if they hit him
    4091 Any missiles fired near target orbit him like satellites
    4092 Any missiles fired near target shriek as they fly through the air
    4093 Any nearby undead attack the target exclusively for 1d10 rounds
    4094 Any nearby undead defend the target to the best of their ability
    4095 Any nearby undead howl wildly and race toward the target
    4096 Any nearby undead now look disturbingly like the target
    4097 Any nearby undead obey the target for 1d8 rounds
    4098 Any open wounds the target now has are welded closed like metal
    4099 Any packs, pouches, or bags carried by target are full of blood
    4100 Any packs, pouches, or bags carried by target are interconnected
    4101 Any packs, pouches, or bags carried by target double in volume
    4102 Any packs, pouches, or bags carried by target dump their contents
    4103 Any paper, parchment, etc. now carried by target combusts
    4104 Any paper, parchment, etc. now carried by target is fireproof
    4105 Any paper, parchment, etc. now carried by target is rain-soaked
    4106 Any paper, parchment, etc. now carried by target turns to steel
    4107 Any part of target not covered by clothing appears to be skeletal
    4108 Any part of target not covered by clothing is badly sunburned
    4109 Any part of target not covered by clothing is forever invisible
    4110 Any part of target not covered by clothing turns bright orange
    4111 Any part of target now covered by clothing is covered in blisters
    4112 Any part of target now covered by clothing is fireproof
    4113 Any part of target now covered by clothing is forever invisible
    4114 Any part of target now covered by clothing is hideously scarred
    4115 Any spells cast in targetis presence seem to originate from him
    4116 Any successful attack on target is 2% likely to kill him
    4117 Any successful attack on target is 10% likely to fail outright
    4118 Any successful attack on target will leave hideous scars
    4119 Any undead now within 10 yards of target attack him until slain
    4120 Any undead now within 10 yards of target combust
    4121 Any undead now within 10 yards of target gain an extra hit die
    4122 Any undead now within 10 yards of target vanish or are destroyed
    4123 Any water elemental touching or touched by target freezes solid
    4124 Any water elemental touching or touched by target heats to 200°
    4125 Any water elemental touching or touched by target is set ablaze
    4126 Any water elemental touching or touched by target splits in two
    4127 Any water now in contact with targetis body freezes solid
    4128 Any water now in contact with targetis body is poisonous to him
    4129 Any water now in contact with targetis body turns to glue
    4130 Any water now in contact with targetis body turns to lamp oil
    4131 Any water now in contact with targetis body turns to mud
    4132 Any water now in contact with targetis body turns to stone
    4133 Any wooden weapons that wound the target are invisible until dawn
    4134 Any wooden weapons that wound the target become heavy as lead
    4135 Any wooden weapons that wound the target burst into flame
    4136 Any wooden weapons that wound the target must Save or shatter
    4137 Any wooden weapons that wound the target turn to steel until dawn
    4138 Any wooden weapons that wound the target vanish until heis dead
    4139 Anyone cutting target with a blade ages 1d10 years until sunset
    4140 Anyone cutting target with a blade briefly turns orange
    4141 Anyone cutting target with a blade canit sleep for 1d4 days
    4142 Anyone cutting target with a blade canit speak to him until dawn
    4143 Anyone cutting target with a blade feels heartwarming glee
    4144 Anyone cutting target with a blade feels incredible hunger 
    4145 Anyone cutting target with a blade feels momentarily dizzy
    4146 Anyone cutting target with a blade feels overwhelming dread
    4147 Anyone cutting target with a blade feels the same amount of pain
    4148 Anyone cutting target with a blade feels unsettling dEj‡ vu
    4149 Anyone cutting target with a blade gets an electric shock
    4150 Anyone cutting target with a blade has awful dreams for one week
    4151 Anyone cutting target with a blade immediately apologizes for it
    4152 Anyone cutting target with a blade is briefly blinded
    4153 Anyone cutting target with a blade is briefly invisible
    4154 Anyone cutting target with a blade is briefly rendered mute
    4155 Anyone cutting target with a blade is paralyzed for 1d4 rounds
    4156 Anyone cutting target with a blade is soaked with goatis milk
    4157 Anyone cutting target with a blade is soaked with his own blood
    4158 Anyone cutting target with a blade loses one hit point
    4159 Anyone cutting target with a blade suffers visions of damnation
    4160 Anyone cutting target with a blade teleports 1d6 feet
    4161 Anyone cutting target with a blade thinks heis an ally
    4162 Anyone cutting target with a blade thinks the target is immortal
    4163 Anyone cutting target with a blade vanishes for 1d4 rounds
    4164 Anyone looking into the targetis ear has visions of debauchery
    4165 Anyone looking into the targetis ear has visions of his own death
    4166 Anyone looking into the targetis ear has visions of the hereafter
    4167 Anyone looking into the targetis ear suffers intense vertigo
    4168 Anyone nearby when target is wounded applauds for 1d4 rounds
    4169 Anyone nearby when target is wounded must Save or begin weeping
    4170 Anyone nearby when target is wounded must Save or flee in panic
    4171 Anyone nearby when target is wounded must Save or pass out
    4172 Anyone nearby wielding a wooden weapon hits the target with it
    4173 Anyone nearby wielding a wooden weapon is invisible to the target
    4174 Anyone nearby wielding a wooden weapon offers it to the target
    4175 Anyone nearby wielding a wooden weapon throws it at the target
    4176 Anyone nearby with a drawn blade attacks target for 1d4 rounds
    4177 Anyone nearby with a drawn blade canit use it against the target
    4178 Anyone nearby with a drawn blade races away from the target
    4179 Anyone nearby with a drawn blade shouts the targetis name
    4180 Anyone slain by targetis weapon can never be resurrected
    4181 Anyone touching the target in the next turn adopts his name
    4182 Anyone touching the target in the next turn is briefly paralyzed
    4183 Anyone touching the target in the next turn loses 1d10 hit points
    4184 Anyone touching the target in the next turn suffers severe burns
    4185 Anyone who wounds the target is 5% likely to kill him outright
    4186 Anyone who wounds the target must Save or age 1d10 years
    4187 Anyone who wounds the target must Save or be equally wounded
    4188 Anyone who wounds the target must Save or disarm themselves
    4189 Anyone who wounds the target must Save or fall unconscious
    4190 Anyone who wounds the target must Save or sink into the ground
    4191 Anyone who wounds the target must Save or teleport 1d4 miles
    4192 Anyone who wounds the target must Save or temporarily shrink 25%
    4193 Armor is always invisible while worn by the target
    4194 As target is wounded more severely, heis less likely to sense it
    4195 At any crossroads, target feels utterly lost
    4196 At any crossroads, target is inclined to turn back
    4197 At any crossroads, target is inclined to turn left
    4198 At any crossroads, target is stricken with indecision
    4199 At dawn tomorrow, all record and memory of target is lost
    4200 At dawn tomorrow, demonic hordes mount a quest against the target
    4201 At dawn tomorrow, target is abducted by an undead horde
    4202 At dawn tomorrow, target must Save or age 1d1000 years
    4203 At each sunset, target is 20% likely to age 1d20 years instantly
    4204 At some point in every battle, target wholly disarms himself
    4205 Beacon-bright light shines from targetis palms during combat
    4206 Beacon-bright light shines from the soles of the targetis feet
    4207 Beacon-bright light shines from the targetis principal weapon
    4208 Beacon-bright light shines from the top of the targetis head
    4209 Bits of gristle tumble from the targetis mouth while he speaks
    4210 Bits of hardened resin tumble constantly from targetis ears
    4211 Blades are magically blunted while the target wields them
    4212 Blades are unbreakable while the target wields them
    4213 Blades seem cumbersome and awkward while the target wields them
    4214 Blades seem to have basic intelligence while target wields them
    4215 Both of targetis arms are now on the same side of his body
    4216 Both of targetis arms jut from the same shoulder
    4217 Bright flames consume the targetis clothing for 1d10 rounds
    4218 Bright flames dance harmlessly over targetis body for 1d10 rounds
    4219 Bright flames ripple harmlessly along targetis limbs for 1d4 days
    4220 Bright flames surround the target harmlessly for 2d10 rounds
    4221 Colored streamers shoot from targetis ears for 2d6 rounds
    4222 Colored streamers shoot from targetis nostrils
    4223 Colorful smoke spews from targetis every orifice for 2d10 rounds
    4224 Condensation endlessly forms upon and drips from target
    4225 Countless glass shards slash at the target for 1d6 rounds
    4226 Countless glass shards whirl around the target for 1d6 rounds
    4227 Countless tiny moths flutter about the targetis head
    4228 Countless tiny, colorful orbs swirl harmlessly around the target
    4229 Creatures Summoned in targetis presence are abominations
    4230 Creatures Summoned in targetis presence are clear like glass
    4231 Creatures Summoned in targetis presence are immune to fire
    4232 Creatures Summoned in targetis presence are old and decrepit
    4233 Creatures Summoned in targetis presence beg him for mercy
    4234 Creatures Summoned in targetis presence have only 1 hit point
    4235 Creatures Summoned in targetis presence obey him unswervingly
    4236 Creatures Summoned in targetis presence refuse to attack him
    4237 Creatures Summoned in targetis presence seem to be made of stone
    4238 Creatures Summoned in targetis presence strongly resemble him
    4239 Creatures Summoned in targetis presence worship him as a god
    4240 Dew and condensation inspire fear in the target
    4241 Dozens of tiny glass slivers fall harmlessly from targetis mouth
    4242 During any combat round, target is 3% likely to die outright
    4243 During any combat round, target is 5% likely to flee in panic
    4244 During any combat round, target is 10% likely to be invisible
    4245 During any combat round, target is 50% likely to be very drunk
    4246 During battle, target experiences distracting hallucinations
    4247 During battle, target hears overpoweringly loud calliope music
    4248 During battle, target perceives thick, acrid smoke all around him
    4249 During battle, target quacks like an enormous duck
    4250 During battle, target repeatedly chants a naughty limerick
    4251 During battle, targetis allies are invisible to him
    4252 During battle, targetis allies canit speak to him
    4253 During battle, targetis allies donit recognize him
    4254 During battle, targetis clothes and gear are invisible
    4255 During battle, targetis clothes appear to burst into flame
    4256 During battle, targetis clothes billow with foul smoke
    4257 During battle, targetis clothes moan like ghosts
    4258 During battle, targetis ears flap like a birdis wings
    4259 During battle, targetis flesh, hair, and gear turn white as snow
    4260 During battle, targetis hands appear to be shrouded in flame
    4261 During battle, targetis head is henceforth invisible
    4262 During battle, targetis heartbeat is audible to all nearby
    4263 Each day, target can become an illusion for 1d4 rounds
    4264 Each day, target can command 1d4 non-magical bears
    4265 Each day, target can see through the casteris eyes for 1d4 turns
    4266 Each day, target can turn his skin invisible for up to one hour
    4267 Each day, target can turn into a horse for up to 1d4 hours
    4268 Each day, target can walk on water up to 100 yards
    4269 Each day, target is 10% likely to lose one finger or toe
    4270 Each day, target is immune to one electrical attack
    4271 Each day, target is struck by lightning but is basically unharmed
    4272 Each day, target must eat at least one medium-sized candle
    4273 Each day, target must eat at least one sheet of parchment
    4274 Each day, targetis body varies from 10% to 80% transparency 
    4275 Each day, targetis skin is a different vibrant color
    4276 Each of targetis feet acquires argumentative intelligence
    4277 Each of targetis feet is chained to his neck
    4278 Each of targetis feet tries to race away in a different direction
    4279 Each of targetis feet weighs as much as the rest of his body
    4280 Each of targetis hands fuses to the opposite elbow
    4281 Each time target is injured, a gold coin appears in his mouth
    4282 Each time target is injured, he must Save or fall unconscious
    4283 Each time target is injured, he must Save or go blind
    4284 Each time target is injured, howls like a wolf
    4285 Each time target opens his mouth, a small toad leaps out of it
    4286 Each time target opens his mouth, another tooth turns invisible
    4287 Each time target opens his mouth, he hears eerie music nearby
    4288 Each time target opens his mouth, nearby birds fall silent
    4289 Electricity crackles in targetis clothing when heis angry
    4290 Electricity crackles in targetis skin as he makes an attack
    4291 Electricity crackles in the air around the target for 1d4 days
    4292 Electricity crackles in the ground wherever the target steps
    4293 Electricity crackles in the targetis hair for 1d8 hours
    4294 Electricity crackles in the targetis hair when he uses magic
    4295 Electricity crackles through the targetis body for 1d8 rounds
    4296 Electricity crackles visibly along targetis weapon during combat
    4297 Every few rounds a spider crawls from targetis mouth
    4298 Every other day, the target is 20% likely to shrink by 10%
    4299 Every other day, the target is 30% likely to be mute
    4300 Every other day, the target is 5d10 years older than his true age
    4301 Every other day, the target radiates strongly of alteration magic
    4302 Every rat in the kingdom follows the target for 2d6 days
    4303 Every spell cast nearby in the next 1d6 rounds strikes the target
    4304 Every spell cast nearby is immediately obvious to the target
    4305 Everyone knows that the target has no real martial prowess
    4306 Everyone knows that the target is a powerful demon in disguise
    4307 Everyone knows that the targetis head is completely hollow
    4308 Everyone knows that the targetis skeleton is made of gold
    4309 Everyone now within 10 yards of target attacks him for 1d4 rounds
    4310 Everyone now within 10 yards of target ignores him for 1d4 hours
    4311 Everyone now within 10 yards of target is disarmed
    4312 Everyone now within 10 yards of target is invisible to him
    4313 Everyone now within 10 yards of target is knocked down
    4314 Everyone now within 10 yards of target is stricken bald
    4315 Everyone now within 10 yards of target must Save or pass out
    4316 Everyone now within 10 yards of target shouts his name
    4317 Everyone who knows the targetis name fears him for 3d10 rounds
    4318 Everyone who knows the targetis name forgets what he looks like
    4319 Everyone who knows the targetis name owes him 1d4 gold pieces
    4320 Everyone who knows the targetis name thinks his name is Twinkles
    4321 Everyone whom target owes money demands repayment in full, now
    4322 Everyone within 100 yards adopts the targetis name
    4323 Everyone within 100 yards feels intense hatred toward the target
    4324 Everyone within 100 yards gives a gold piece to the target
    4325 Everyone within 100 yards is invisible to the target until sunset
    4326 Everyone within 100 yards races toward the target at top speed
    4327 Everyone within 100 yards teleports 10d10 yards away from target
    4328 Everyone within 100 yards teleports to the targetis home
    4329 Everyone within 100 yards thinks the target is about to explode
    4330 Everyone within 100 yards thinks the target is undead
    4331 Everything now worn or carried by target becomes sickly green
    4332 Everything now worn or carried by target is strewn about the area
    4333 Everything that target is now carrying is imperfectly duplicated
    4334 Exertion makes target exhale black smoke like a steam engine
    4335 Fire is intensely beautiful and attractive to the target
    4336 Fire is invisible to the target
    4337 Foliage grows wildly beneath the targetis feet, entangling him
    4338 For 1d10 rounds, magic doesnit work within 100 yards of target
    4339 For 1d10 rounds, ordinary wood smoke is highly toxic to target
    4340 For 1d10 rounds, target canit be affected by any magic items
    4341 For 1d4 days, target canit speak to anyone now within 10 yards
    4342 For 1d4 days, target canit speak to anyone who knows his name
    4343 For one week, target canit be healed by any magical means
    4344 For one week, target canit be injured by members of his species
    4345 Glowing coals appear to be moving within the targetis skin
    4346 Half of targetis body begins aging backwards, one year per day
    4347 Half of targetis body is affected by Reverse Gravity
    4348 Half of targetis body is badly burned, the other half frostbitten
    4349 Half of targetis body is indestructible for 2d4 days
    4350 Half of targetis body is infected with lycanthropy
    4351 Half of targetis body polymorphs into some kind of animal
    4352 Half of targetis body resembles half of the casteris body
    4353 Half of targetis body shrinks by 25%
    4354 Half of targetis body suffers from advanced leprosy
    4355 Half of targetis body turns invisible while in direct sunlight
    4356 Half of targetis fingers are permanently invisible
    4357 Half of targetis head appears to be made of crystal
    4358 Half of targetis head appears to be made of metal
    4359 Half of targetis head appears to be stripped of flesh
    4360 Half of targetis head explodes, killing him messily
    4361 Half of targetis head is covered in fine gold scales
    4362 Half of targetis head is covered in fragrant blue moss
    4363 Half of targetis head vanishes, but heis basically unharmed
    4364 Half of targetis limbs become donkeyis limbs
    4365 Hundreds of blood-red worms course from the targetis nostrils
    4366 Hundreds of small ice chips tumble from targetis ears
    4367 Hundreds of wasps swarm the target whenever he draws a weapon
    4368 If an ally kills target today, heill resurrect at dawn tomorrow
    4369 If an ally kills target today, target explodes as a 50HD fireball
    4370 If an arrow hits the target in the next 1d3 rounds, he explodes
    4371 If an arrow hits the target in the next round, he doubles in size
    4372 If an arrow hits the target in the next round, he turns to glass
    4373 If an arrow hits the target in the next round, heis fully healed
    4374 If next attack on target causes maximum damage, he dies
    4375 If next attack on target causes maximum damage, his attacker dies
    4376 If next attack on target causes maximum damage, the moon vanishes
    4377 If next attack on target causes maximum damage, winter begins now
    4378 If reduced to exactly zero hit points, target becomes an undead
    4379 If reduced to exactly zero hit points, target combusts violently
    4380 If reduced to exactly zero hit points, target is fully healed
    4381 If reduced to exactly zero hit points, target melts like butter
    4382 If reduced to exactly zero hit points, target shatters like glass
    4383 If reduced to exactly zero hit points, target shrinks by 75%
    4384 If reduced to exactly zero hit points, target turns invisible
    4385 If reduced to exactly zero hit points, target turns to steam
    4386 If reduced to five or fewer hit points, target attacks himself
    4387 If reduced to five or fewer hit points, target goes berserk
    4388 If reduced to one hit point, target becomes a lich
    4389 If reduced to one hit point, target is Healed but loses one level
    4390 If struck by Dispel Magic, target ceases to exist for 1d10 rounds
    4391 If struck by Dispel Magic, target is rendered squeaky clean
    4392 If struck by Dispel Magic, target loses 1d100 hit points
    4393 If struck by Dispel Magic, targetis skeleton disintegrates
    4394 If target attempts to teleport, his nervous system stays behind
    4395 If target disembowels himself, heis 10% likely to become a god
    4396 If target draws a weapon, he canit sheathe it again for 4d6 hours
    4397 If target draws a weapon, he canit sheathe it until heis wounded
    4398 If target draws a weapon, he canit use it for 1d4 rounds
    4399 If target draws a weapon, itis 5% likely to shatter outright
    4400 If target eats raw meat, he bleeds from the ears for 4d4 rounds
    4401 If target eats raw meat, he has visions of a possible future
    4402 If target eats raw meat, he has visions of his own death
    4403 If target eats raw meat, he succumbs to voracious bloodlust
    4404 If target eats raw meat, heis thrown into the nearest river 
    4405 If target eats raw meat, it increases in volume by a factor of 10
    4406 If target eats raw meat, it turns to hot ashes in his stomach
    4407 If target has a shield, it becomes fused to his arm
    4408 If target has a shield, it claps shut on his arm like a clamshell
    4409 If target has a shield, it now weighs 500 pounds
    4410 If target has a shield, it vanishes, taking his arm with it
    4411 If target has any charged magic items, they discharge on him
    4412 If target has any charged magic items, they turn to wood
    4413 If target has any charged magic items, theyire fully recharged
    4414 If target has any charged magic items, theyire inert until dawn
    4415 If target has any leather, he sprouts horns like a bull
    4416 If target has any leather, heis soaked with lamp oil
    4417 If target has any leather, it rots over 1d10 rounds
    4418 If target has any leather, the cows that yielded it seek revenge
    4419 If target has slain anyone recently, he goes insane until dawn
    4420 If target has slain anyone recently, heis attacked by vultures
    4421 If target is aware of any poison nearby, he begins shrieking
    4422 If target is aware of any poison nearby, he thinks itis delicious
    4423 If target is aware of any poison nearby, he tries to ingest it
    4424 If target is aware of any poison nearby, heis immune to it
    4425 If target is beheaded, a spectacular lightshow ensues
    4426 If target is beheaded, a winged horse springs from his neck-stump
    4427 If target is beheaded, anyone nearby is stricken blind for 1 turn
    4428 If target is beheaded, he grows a new head facing backwards
    4429 If target is beheaded, he grows a new head just like the casteris
    4430 If target is beheaded, heis 10% likely to possess his slayer
    4431 If target is beheaded, heis 40% likely to grow a new head
    4432 If target is beheaded, his blood turns to very strong acid
    4433 If target is beheaded, his body combusts and races to the horizon
    4434 If target is beheaded, his body defends his slayer for 2d10 turns
    4435 If target is beheaded, his body deflates like a balloon
    4436 If target is beheaded, his body seeks political office
    4437 If target is beheaded, his body still lives a long and happy life
    4438 If target is beheaded, his body tries to behead his slayer
    4439 If target is beheaded, his head becomes undead
    4440 If target is beheaded, his head bounces away like a rubber ball
    4441 If target is beheaded, his head explodes as a 10HD fireball
    4442 If target is beheaded, his head floats away like a balloon
    4443 If target is beheaded, his head rolls to the highest mountaintop
    4444 If target is beheaded, his head speaks prophecy for 1d4 rounds
    4445 If target is beheaded, his head turns to solid gold
    4446 If target is beheaded, his slayer disgorges 1d6 gallons of blood
    4447 If target is beheaded, his slayer is Stunned for 1d4 hours
    4448 If target is beheaded, his slayer must Save vs Will or go insane
    4449 If target is beheaded, his slayer receives 10d1000 gold pieces
    4450 If target is beheaded, his slayer then tries to behead himself
    4451 If target is beheaded, lightning bolts discharge from his neck
    4452 If target is beheaded, no one now nearby can ever be resurrected
    4453 If target is beheaded, two identical heads sprout from his neck
    4454 If target is carrying a magical weapon, he loses 1d8 hit points
    4455 If target is carrying a magical weapon, he regains 1d8 hit points
    4456 If target is carrying a magical weapon, it is burned to slag
    4457 If target is carrying a magical weapon, it mimics his personality
    4458 If target is carrying a pouch, he tries to climb into it
    4459 If target is carrying a pouch, it becomes a small Bag of Holding
    4460 If target is carrying a pouch, it contains 1d100 gold pieces
    4461 If target is carrying a pouch, it inflates like a hot air balloon
    4462 If target is carrying any food, he turns into a werewolf
    4463 If target is carrying any gold, he can hurl one 10HD fireball
    4464 If target is carrying any gold, he changes alignment until sunset
    4465 If target is carrying any gold, heis struck by lightning
    4466 If target is carrying any water, it becomes toxic to him
    4467 If target is carrying any wood, he attempts to devour it
    4468 If target is carrying any wood, it explodes into fiery splinters
    4469 If target is carrying any wood, it smolders until sunset
    4470 If target is carrying any wood, it turns to sawdust
    4471 If target is carrying rope, he ties himself to a nearby tree
    4472 If target is carrying rope, he winds it tightly about his neck
    4473 If target is carrying rope, it canit be cut by non-magical means
    4474 If target is carrying rope, it threads itself through his flesh
    4475 If target is currently injured he begins aging one year per round
    4476 If target is cut by a metal weapon, he loses 2d10 gold pieces
    4477 If target is cut by a metal weapon, he wonit heal naturally
    4478 If target is cut by a metal weapon, his limbs turn invisible
    4479 If target is cut by a metal weapon, it sizzles violently
    4480 If target is cut by a metal weapon, that injury quickly rusts
    4481 If target is cut by a metal weapon, that weapon quickly rusts
    4482 If target is now bleeding, fire canit harm him for 2d4 days
    4483 If target is now bleeding, he begins to drown as though submerged
    4484 If target is now bleeding, heis hereafter susceptible to rust
    4485 If target is now bleeding, his weapon is +4 for 2d4 hours
    4486 If target is now bleeding, the ground at his feet heats to 500°
    4487 If target is now carrying any food, he contracts advanced leprosy
    4488 If target is now carrying any food, he loses 1d100 hit points
    4489 If target is now carrying any food, he teleports 2d10 miles
    4490 If target is now standing, he canit sit or lie down for 8d6 hours
    4491 If target is now standing, he levitates helplessly for 2d8 rounds
    4492 If target is now standing, heis now standing on tall stilts
    4493 If target is now standing, his legs double in length
    4494 If target is now wet, he suffers sudden heat exhaustion
    4495 If target is slain by a blade, he can never be resurrected
    4496 If target is slain by fire, he explodes as a 20HD fireball
    4497 If target is slain by fire, he resurrects in 1d4 days
    4498 If target is slain by fire, his ashes are scattered over the sea
    4499 If target is slain by fire, the nearest forest is also set ablaze
    4500 If target is slain in the next 24 hours, he becomes a god
    4501 If target is slain in the next 24 hours, he canit be resurrected
    4502 If target is slain in the next 24 hours, he resurrects at sunrise
    4503 If target is slain in the next 24 hours, winter begins at once
    4504 If target is slain, a spring bubbles up from beneath his corpse
    4505 If target is slain, a virulent plague breaks out in a nearby city
    4506 If target is slain, all trees within 10 miles vanish
    4507 If target is slain, all within 10 miles are overcome by grief
    4508 If target is slain, he becomes an undead servant for his slayer
    4509 If target is slain, he forever haunts the dreams of his slayer
    4510 If target is slain, his allies all attack his slayer
    4511 If target is slain, his allies quickly forget him and move on
    4512 If target is slain, his corpse completely decays in 1d4 rounds
    4513 If target is slain, his corpse embraces his slayer and combusts
    4514 If target is slain, his corpse turns to wax within 1d10 rounds
    4515 If target is slain, his slayer must Save or die along with him
    4516 If target is slain, his soul canit leave his body
    4517 If target is slain, his soul is sent to the wrong plane
    4518 If target is slain, the caster is under a Geas to resurrect him
    4519 If target is slain, the caster must inform his next of kin
    4520 If target is wearing animal hide, he becomes an animal until dawn
    4521 If target is wearing animal hide, he hides like an animal
    4522 If target is wearing animal hide, he thinks that heis that animal
    4523 If target is wearing animal hide, he tries to eat it
    4524 If target is wearing animal hide, it animates and attacks him
    4525 If target is wearing any rings, he has a spiritual revelation
    4526 If target is wearing any rings, heis immune to magic until sunset
    4527 If target is wearing any rings, his hands retract into his wrists
    4528 If target is wearing any rings, they ignite on his fingers
    4529 If target is wearing armor, he is unable to remove it
    4530 If target is wearing armor, he teleports into the nearest town
    4531 If target is wearing armor, he thinks itis part of his body
    4532 If target is wearing armor, heis attacked by 1d4 alligators
    4533 If target is wearing armor, heis blinded until he removes it
    4534 If target is wearing armor, heis hurled into the nearest river 
    4535 If target is wearing armor, heis soaked with lamp oil
    4536 If target is wearing armor, heis struck by lightning
    4537 If target is wearing armor, it clatters noisily in the dark
    4538 If target is wearing armor, it constricts painfully about him
    4539 If target is wearing armor, it has a +2 AC bonus until sunrise
    4540 If target is wearing armor, it heats to 500°
    4541 If target is wearing armor, it rattles violently for 1d10 hours
    4542 If target is wearing armor, it teleports 2d6 yards
    4543 If target is wearing armor, it turns invisible
    4544 If target is wearing armor, it vanishes for 1d10 rounds
    4545 If target is wearing armor, itis as supple as silk until sunset
    4546 If target is wearing armor, itis restored to brand-new condition
    4547 If target is wearing armor, rain falls heavily for 1d10 days
    4548 If target is wearing armor, the ground beneath him gives way
    4549 If target is wearing shoes, his feet become chickenis feet
    4550 If target is wielding a weapon, he suffers severe frostbite
    4551 If target kills an ally within one turn, heill be fully Healed
    4552 If target kills anyone in the next hour, he vanishes for 2d4 days
    4553 If target lights a fire, he feels an urge to put his hands in it
    4554 If target lights a fire, he is overwhelmingly afraid of it
    4555 If target lights a fire, he perceives omens in its burning embers
    4556 If target lights a fire, his clothing ignites
    4557 If target loses a finger, he deliberately cuts off another one
    4558 If target loses a finger, that hand shrivels and dies
    4559 If target moves more than 10 yards from this spot, he dies
    4560 If target now has fewer than 1d100 hit points, heis fully Healed
    4561 If target now has more than 20 hit points, he loses 1d100
    4562 If target sees an open pit, he tries to bury himself in it
    4563 If target sees an open pit, heis attacked by something in it
    4564 If target sits or lies down, he canit stand again for 8d6 hours
    4565 If target sits or lies down, he teleports 1d100 yards
    4566 If target sits or lies down, heis attacked by glowing beetles
    4567 If target sits or lies down, heis covered by a light frost
    4568 If target sleeps more than eight hours, heis struck by lightning
    4569 If target teleports, he arrives holding two buckets of paint
    4570 If target teleports, his skeleton teleports to this spot
    4571 If target uses a doorway in the next hour, he turns to stone
    4572 If target wields an axe, he thinks heis the archetypal Dwarf
    4573 If target wields an axe, he tries to decapitate himself with it
    4574 If target wields an axe, heis attacked by the nearest tree
    4575 If target worships a deity, he claims to speak for the deity
    4576 If target worships a deity, he forsakes that deity for another
    4577 If target worships a deity, he thinks heis that deityis avatar
    4578 If target worships a deity, he thinks the deity is talking to him
    4579 If targetis hands touch, they adhere to each other until dawn
    4580 If targetis weapon is metal, his hand turns to similar metal
    4581 If targetis weapon is metal, it turns to glass for 1d4 rounds
    4582 If targetis weapon is metal, it turns to wood and vice versa
    4583 If targetis weapon is metal, itis now indestructible
    4584 Innumerable bats flutter around the target each day at twilight
    4585 Insects constantly swarm around the target from now on
    4586 Magic items are unreliable for the target for 2d4-1 days
    4587 Magic items function at 50% power when target uses them
    4588 Meat turns to gravel as it moves through targetis digestive tract
    4589 Melancholy chants issue from the targetis weapon during battle
    4590 Metal weapons are immune to magic while target wields them
    4591 Metal weapons are invisible to target while he wields them
    4592 Metal weapons chime pleasantly when they strike the caster
    4593 Metal weapons do not conduct electricity while target wields them
    4594 Metal weapons seem 10X heavier to target while he wields them
    4595 Metal weapons seem to hum with power when target wields them
    4596 Metal weapons seem weightless to target during combat
    4597 Metal weapons strike sparks against targetis body like flint
    4598 Music causes the target to weep tears of blood
    4599 Music inspires savage bloodlust in the target
    4600 Nearest horse adopts the targetis personality
    4601 Nearest horse brutally attacks the target until one is dead
    4602 Nearest pine tree crushes the targetis home, wherever it is
    4603 Nearest pine tree pelts the target with jagged pine cones
    4604 Nearest pine tree sounds like the target when the wind blows
    4605 Nearest pine tree sprays the target with boiling, caustic sap
    4606 Nearest zombie appears in the area under the targetis command
    4607 Nearest zombie attacks the target until one is destroyed
    4608 Nearest zombie follows the target everywhere
    4609 Nearest zombie steals something precious to target, then flees
    4610 Next 1d10 attacks upon target have a +4 bonus to damage
    4611 Next 1d10 attacks upon target heal rather than inflict damage
    4612 Next 1d10 attacks upon target inflict burning damage like fire
    4613 Next 1d10 attacks upon target inflict only illusionary damage
    4614 Next 1d10 attacks upon target inflict only minimum damage
    4615 Next 1d10 attacks upon target leave him breathless and exhausted
    4616 Next 1d10 attacks upon target leave him soaked with brine
    4617 Next 1d10 attacks upon target wound a nearby tree instead
    4618 Next 1d4 creatures slain by target combust immediately
    4619 Next 1d4 creatures slain by target immediately rise as undead
    4620 Next 1d4 creatures slain by target turn invisible upon death
    4621 Next 1d4 creatures slain by target very rapidly decompose
    4622 Next 1d4 hours seem like a dream to the target
    4623 Next 1d4 rounds seem to last a full day to the target
    4624 Next 2d4 spells cast at target are invisible in effect
    4625 Next 2d4 spells cast at target function as the current spell
    4626 Next 2d4 spells cast at target function at 2X normal power
    4627 Next 2d4 spells cast at target strike random targets nearby
    4628 Next horse touched by target becomes ravenously carnivorous
    4629 Next horse touched by target can never again be ridden by mortals
    4630 Next horse touched by target shrinks by 75%
    4631 Next horse touched by target turns into a small dinosaur
    4632 Next magic item handled by target appears as supple as clay
    4633 Next magic item handled by target can again never be used by him
    4634 Next magic item handled by target canit be used by anyone else
    4635 Next magic item handled by target drains 1d10 hit points from him
    4636 Next magic item handled by target expresses deep hatred for him
    4637 Next magic item handled by target expresses deep love for him
    4638 Next magic item handled by target is etched with his fingerprints
    4639 Next magic item handled by target is invisible while he uses it
    4640 Next magic item handled by target leaves colorful trails of light
    4641 Next magic item handled by target leaves weird scars on his hands
    4642 Next magic item handled by target makes him think heis drowning
    4643 Next magic item handled by target makes his hands go numb
    4644 Next magic item handled by target restores 1d10 hit points
    4645 Next magic item handled by target seems to him to be 1,000°
    4646 Next magic item handled by target seems to him to be 10X heavier
    4647 Next magic item handled by target shines like a beacon to undead
    4648 Next magic item handled by target smells like manure for 3d8 days
    4649 Next magic item handled by target tries to control his mind
    4650 Next magic item handled by target works at 2X normal power
    4651 Next magic item handled by target works contrary to his wishes
    4652 Next person to wound the target absorbs half of the damage
    4653 Next person to wound the target can harm no one else until sunset
    4654 Next person to wound the target hallucinates wildly for one turn
    4655 Next person to wound the target inflicts maximum damage
    4656 Next person to wound the target is attacked by vermin
    4657 Next person to wound the target is immediately chained to him
    4658 Next person to wound the target is paralyzed for 1d10 rounds
    4659 Next person to wound the target is splattered with fish guts
    4660 Next person to wound the target is stricken blind until sunset
    4661 Next person to wound the target is swarmed by aggressive bees
    4662 Next person to wound the target is thrown into the nearest well
    4663 Next person to wound the target is worshipped by vermin
    4664 Next person to wound the target must Save or fall unconscious 
    4665 Next person to wound the target races to the nearest graveyard
    4666 Next person to wound the target resembles him for 1d20 hours
    4667 Next person to wound the target sees fires blazing all around him
    4668 Next person to wound the target suffers 2X the damage inflicted
    4669 Next person to wound the target suffers equal damage
    4670 Next person to wound the target suffers overpowering vertigo
    4671 Next person to wound the target suffers the damage instead
    4672 Next person to wound the target teleports 1d4 miles away
    4673 Next person to wound the target teleports 4d8 yards straight up
    4674 Next person to wound the target then attacks the caster
    4675 Next person to wound the target then flees to the nearest forest
    4676 Next person to wound the target thinks heill die before nightfall
    4677 Next person to wound the target thinks heis drowning for one turn
    4678 Next person to wound the target thinks that heis slain the target
    4679 Next person to wound the target totally disarms himself
    4680 Next person to wound the target will soon be abducted by undead
    4681 Next person wounded by target must Save or age 1d6 years
    4682 Next person wounded by target must Save or be attacked by vermin
    4683 Next person wounded by target must Save or be Charmed by him
    4684 Next person wounded by target must Save or be poisoned
    4685 Next person wounded by target must Save or be stricken mute
    4686 Next person wounded by target must Save or contract leprosy
    4687 Next person wounded by target must Save or drop to one hit point
    4688 Next person wounded by target must Save or flee panic-stricken
    4689 Next person wounded by target must Save or shrink by 5d10%
    4690 Next person wounded by target must Save or teleport 1d4 miles
    4691 Next puddle stepped in by target absolves him of sin
    4692 Next puddle stepped in by target causes him to hallucinate
    4693 Next puddle stepped in by target changes his alignment until dawn
    4694 Next puddle stepped in by target contains a small sea monster
    4695 Next puddle stepped in by target drenches him from head to toe
    4696 Next puddle stepped in by target explodes as a 6HD fireball
    4697 Next puddle stepped in by target hardens like cement
    4698 Next puddle stepped in by target inspires him to megalomania
    4699 Next puddle stepped in by target is a 16HD water elemental
    4700 Next puddle stepped in by target is highly concentrated acid
    4701 Next puddle stepped in by target sends him to Elemental Water
    4702 Next puddle stepped in by target teleports him to a nearby lake
    4703 Next puddle stepped in by target throws him 3d10 yards in the air
    4704 Next puddle stepped in by target turns to glass
    4705 Next time target touches a tree, he must Save or turn to wood
    4706 Next time target touches a tree, heis attacked by 1d100 squirrels
    4707 Next time target touches a tree, heis buried in a heap of sawdust
    4708 Next time target touches a tree, heis overgrown with stiff bark
    4709 Next weapon to wound target absorbs water like a sponge
    4710 Next weapon to wound target afflicts its wielder with narcolepsy
    4711 Next weapon to wound target appears as porous as a sponge
    4712 Next weapon to wound target appears to be made of diamond
    4713 Next weapon to wound target becomes as black as coal forever
    4714 Next weapon to wound target begins aging 1d100 years per round
    4715 Next weapon to wound target burns like magnesium for 1d10 rounds
    4716 Next weapon to wound target can never wound him again thereafter
    4717 Next weapon to wound target canit harm him for 1d8 days
    4718 Next weapon to wound target disintegrates if it wounds him again
    4719 Next weapon to wound target embeds itself in a nearby tree
    4720 Next weapon to wound target exudes acrid steam for 1d4 weeks
    4721 Next weapon to wound target heals him if it wounds him again
    4722 Next weapon to wound target heals its wielder by an equal amount
    4723 Next weapon to wound target identifies him as its rightful owner
    4724 Next weapon to wound target inflicts 10X the rolled damage
    4725 Next weapon to wound target is 5% likely to change his sex
    4726 Next weapon to wound target is +1 until heis wounded again
    4727 Next weapon to wound target is 10% likely to change his alignment
    4728 Next weapon to wound target is 10% likely to destroy his soul
    4729 Next weapon to wound target is 60% likely to shatter
    4730 Next weapon to wound target is believed to be a mighty artifact
    4731 Next weapon to wound target is crushed into a small cube
    4732 Next weapon to wound target is engraved with his name
    4733 Next weapon to wound target is forever after -1 ToHit
    4734 Next weapon to wound target is frozen in a large block of ice
    4735 Next weapon to wound target is intensely magnetic
    4736 Next weapon to wound target is invisible to him forever after
    4737 Next weapon to wound target is jealously sought by collectors
    4738 Next weapon to wound target is older than the entire universe
    4739 Next weapon to wound target is pinned beneath a nearby boulder
    4740 Next weapon to wound target is replaced by a nearly exact replica
    4741 Next weapon to wound target is soon confiscated by demons
    4742 Next weapon to wound target is thereafter +1 to hit him
    4743 Next weapon to wound target is thereafter +4 ToHit him
    4744 Next weapon to wound target is thereafter indestructible
    4745 Next weapon to wound target is thereafter terribly afraid of him
    4746 Next weapon to wound target leaps 1d100 rounds into the future
    4747 Next weapon to wound target likewise wounds his attacker
    4748 Next weapon to wound target makes him suffer apocalyptic visions
    4749 Next weapon to wound target must Save or melt like a candle
    4750 Next weapon to wound target must Save or shrink by 5d10 + 45%
    4751 Next weapon to wound target penalizes its wielderis AC by 5
    4752 Next weapon to wound target turns out to be a mighty artifact
    4753 Next weapon to wound target turns to stone
    4754 Next weapon to wound target vanishes for 1d10 rounds
    4755 Next weapon to wound target was forged from his own bones
    4756 Next weapon to wound target was forged on a distant world
    4757 No one speaks to target for 2d4-1 days
    4758 No one speaks to target until he spills his own blood
    4759 Non-magical animals react to the target as if he were a salt lick
    4760 Non-magical animals react to the target as if he were food
    4761 Non-magical animals react to the target as if he were one of them
    4762 Non-magical animals react to the target as if he were undead
    4763 Normal voices seem deafeningly loud to the target
    4764 Normal voices seem ghostly and haunting to the target
    4765 Normal voices seem to echo imperiously to the target
    4766 Normal voices seem to resonate in the targetis bones
    4767 On targetis back is a button that, if pushed, lights up his head
    4768 On targetis back is a button that, if pushed, makes him giggle
    4769 On targetis back is a button that, if pushed, makes him glow blue
    4770 On targetis back is a button that, if pushed, makes him sweat
    4771 Once per day, target can make a sound like a cannon
    4772 Once per day, target can turn all wheels nearby invisible
    4773 One of targetis allies thinks that target is an avatar of his god
    4774 One of targetis arms becomes as supple as rope during combat
    4775 One of targetis arms can bend in 1d4 additional places
    4776 One of targetis arms is as durable as steel, but only when wet
    4777 One of targetis arms is bent like a corkscrew
    4778 One of targetis arms is bent like a shepherdis crook
    4779 One of targetis arms is replaced by a duplicate of his head
    4780 One of targetis arms is stripped to the bone but works normally
    4781 One of targetis arms loses all bone but functions like a tentacle
    4782 One of targetis arms turns into a small replica of his leg
    4783 One of targetis arms turns to a lionis foreleg
    4784 One of targetis eyes migrates to the back of his head
    4785 One of targetis feet is fused into an anvil
    4786 One of targetis feet rotates 180° at the ankle
    4787 One of targetis hands appears to have been flattened by a hammer
    4788 One of targetis hands becomes hideously contorted and deformed
    4789 One of targetis hands can pass through solid steel
    4790 One of targetis hands can pass through stone
    4791 One of targetis hands canit be cut by non-magical metal
    4792 One of targetis hands dissolves in water like a sand castle
    4793 One of targetis hands figures prominently in the apocalypse
    4794 One of targetis hands glows brightly in the presence of magic 
    4795 One of targetis hands is fireproof, but he never knows which one
    4796 One of targetis hands is fireproof; the other hand vanishes
    4797 One of targetis hands is immune to bludgeoning weapons
    4798 One of targetis hands is impervious to beam-based magic spells
    4799 One of targetis hands is impervious to magical cold
    4800 One of targetis hands is invisible to undead
    4801 One of targetis hands is shaped like an orangutanis hand
    4802 One of targetis hands migrates to the top of his head
    4803 One of targetis hands oozes a viscous liquid like sap
    4804 One of targetis hands shines like a beacon if clenched in a fist
    4805 One of targetis hands turns into a hoof
    4806 One of targetis hands turns into a perfect cube of granite
    4807 One of targetis hands turns into a replica of a rabbitis head
    4808 One of targetis hands turns into sponge
    4809 One of targetis hands, when clenched, looks like a small head
    4810 One of targetis legs and one of his arms become as clear as glass
    4811 One of targetis legs and one of his arms seem to be made of wood
    4812 One of targetis legs and one of his arms shrink by 50%
    4813 One of targetis legs and one of his arms turn invisible
    4814 One of targetis limbs acquires intelligence hostile to him
    4815 One of targetis limbs always seems to be soaked with milk
    4816 One of targetis limbs appears to be made of diamond
    4817 One of targetis limbs becomes wildly disobedient during combat
    4818 One of targetis limbs can appear identical to his other limbs
    4819 One of targetis limbs can be Dispelled as an illusion
    4820 One of targetis limbs can never be rendered invisible
    4821 One of targetis limbs canit be armored in combat
    4822 One of targetis limbs develops an intense hatred for the others
    4823 One of targetis limbs falls off and tries to escape
    4824 One of targetis limbs glows bright blue in the dark
    4825 One of targetis limbs is affected as by the spell Slow
    4826 One of targetis limbs is as hard as steel during combat
    4827 One of targetis limbs is clearly artificial
    4828 One of targetis limbs is controlled by caster for 1d10 rounds
    4829 One of targetis limbs is covered in feathers
    4830 One of targetis limbs is entirely indestructible
    4831 One of targetis limbs is impervious to blades during combat
    4832 One of targetis limbs is impervious to polymorph magic
    4833 One of targetis limbs is made of porcelain but functions normally
    4834 One of targetis limbs is paralyzed for 1d6 days
    4835 One of targetis limbs is replaced by a hideous tentacle
    4836 One of targetis limbs is responsible for genocide
    4837 One of targetis limbs is wanted for murder
    4838 One of targetis limbs now juts from the center of his back
    4839 One of targetis limbs regenerates in 1d4 rounds if severed
    4840 One of targetis limbs retracts into his torso when not in use
    4841 One of targetis limbs seems to belong to a different species
    4842 One of targetis limbs shrinks by 1d4% per day
    4843 One of targetis limbs suffers intense pain if he uses magic
    4844 One of targetis limbs turns as green as grass
    4845 One of targetis limbs turns to a tree limb
    4846 One of targetis limbs turns to solid gold
    4847 One or more of targetis allies is plotting to kill him
    4848 One or more of targetis allies thinks that target is a traitor
    4849 Ordinary water has a powerful emetic effect upon the target
    4850 Ordinary water induces aggressive incontinence in the target
    4851 Ordinary water is as intoxicating to target as distilled spirits
    4852 Ordinary water is incredibly impressive to the target
    4853 People often mistake the target for a hated enemy
    4854 People often mistake the target for a statue of the caster
    4855 People often mistake the target for an undead monstrosity
    4856 People often mistake the target for someone who gives a damn
    4857 People who meet target for the first time accuse him of drowning
    4858 People who meet target for the first time accuse him of treason
    4859 People who meet target for the first time are intimidated by him
    4860 People who meet target for the first time are intimidating to him
    4861 People who meet target for the first time become violently ill
    4862 People who meet target for the first time feel insulted by him
    4863 People who meet target for the first time ignore him if he speaks
    4864 People who meet target for the first time laugh at him derisively
    4865 People who meet target for the first time lose 1d4 gold pieces
    4866 People who meet target for the first time mistake him for royalty
    4867 People who meet target for the first time mock his fashion sense
    4868 People who meet target for the first time point at him and laugh
    4869 People who meet target for the first time promptly forget him
    4870 People who meet target for the first time refuse to speak to him
    4871 People who meet target for the first time tend to trust him
    4872 People who meet target for the first time think heis a corpse
    4873 People who meet target for the first time think heis a murderer
    4874 People who meet target for the first time think heis a thief
    4875 People who meet target for the first time think heis mocking them
    4876 People who meet target for the first time think heis on fire
    4877 People who meet target for the first time think heis stupid
    4878 People who meet target for the first time think that heis a demon
    4879 People who meet target for the first time think that heis hideous
    4880 People who meet target for the first time threaten to kill him
    4881 Phosphorescent beetles teem over targetis skin for 2d12 hours
    4882 Printed text appears hopelessly garbled while target is nearby
    4883 Rope hisses like a snake while target uses it
    4884 Rope tends to become hopelessly tangled when target uses it
    4885 Seltzer water sprays from the targetis nose for 1d10 rounds
    4886 Shimmering lights play over the targetis skin during combat
    4887 Smoke issues from the ground near the target when heis angry
    4888 Smoke makes the target think that heis being suffocated
    4889 Smoke pours from targetis eyes when he uses or is struck by magic
    4890 Smoke pours from targetis skin as though his bones are ablaze
    4891 Some common non-magical species adopts the target as its enemy
    4892 Some common non-magical species is forever invisible to target
    4893 Some distant creature has been hired to assassinate the target
    4894 Something from the bottom of a nearby lake attacks the target
    4895 Sparks fly from targetis ears as from a grindstone
    4896 Sparks fly from targetis eyes when he draws a weapon
    4897 Sparks fly from targetis fingertips when heis angry
    4898 Sparks fly from targetis nostrils as he speaks
    4899 Spectral voices echo everything that the target says
    4900 Suddenly 1d4 people appear and attack the target
    4901 Suddenly 1d4 people appear and offer trinkets to the target
    4902 Suddenly 1d4 people appear and try to lasso the target
    4903 Suddenly 1d4 people appear and worship the target
    4904 Suddenly 1d4 people nearby resemble the target
    4905 Suddenly 1d4 people nearby wish to assassinate the target
    4906 Sulfurous mud oozes from targetis clothes for 1d8 hours
    4907 Summoned creatures are at +2 ToHit the target
    4908 Summoned creatures are Hasted in the targetis presence
    4909 Summoned creatures are invisible to the target
    4910 Summoned creatures are Slowed in the targetis presence
    4911 Summoned creatures can make no sound in the targetis presence
    4912 Summoned creatures covet the targetis possessions
    4913 Summoned creatures ignore and are unaffected by the target
    4914 Summoned creatures ignore the target unless he attacks them
    4915 Summoned creatures ignore the target unless he has a weapon drawn
    4916 Swords canit come within ten feet of the target for 1d4 rounds
    4917 Swords in targetis presence drip with his blood
    4918 Swords pass harmlessly through the targetis body for 1d4 turns
    4919 Target acquires a new language and refuses to speak any other
    4920 Target acquires an exact copy of the casteris spellbook
    4921 Target acquires scars to match any wounds he inflicts on others
    4922 Target acts as though he doesnit really exist
    4923 Target acts as though heis the only person who really exists
    4924 Target acts as though his fingers are readily replaceable 
    4925 Target acts as though his head and body are two separate beings
    4926 Target acts generally like a jerk toward his friends and allies
    4927 Target acts like a child for 10d10 rounds
    4928 Target acts like a horse for 1d4 turns
    4929 Target adds 1d4 to each attribute score for 2d12 hours
    4930 Target affects an air of ostentatious wealth even if heis poor
    4931 Target ages 1d10 years per day for the next 1d4 weeks
    4932 Target ages 1d1000 years; if he lives, heis not subject to aging
    4933 Target ages 1d4 years each time he says his name
    4934 Target ages 1d4 years each time heis cut by a claw or fang
    4935 Target ages 1d4 years each time heis cut by a metal blade
    4936 Target ages 1d4 years each time his weapon injures someone
    4937 Target ages at 2X normal rate unless he has a coin in his mouth
    4938 Target ages at 2X normal rate while not in direct sunlight
    4939 Target ages one year for each hit point of fire damage he suffers
    4940 Target ages one year per round spent in the casteris presence
    4941 Target ages plus or minus 1d10 years each hour
    4942 Target always attacks the foe heis least likely to defeat
    4943 Target always fails to consider the consequences
    4944 Target always knows the location of the nearest giraffe
    4945 Target and his possessions are stripped of any enchantments
    4946 Target and nearest zombie are chained together nearby
    4947 Target and nearest zombie are often mistaken for each other
    4948 Target and nearest zombie exchange bodies
    4949 Target and nearest zombie form an unholy alliance
    4950 Target and the nearest horse exchange bodies
    4951 Target and the nearest horse exchange clothing
    4952 Target and the next person he attacks are invisible to each other
    4953 Target and the next person he attacks are soaked with icy brine
    4954 Target and the next person he attacks both shrink by 5d10%
    4955 Target and the next person he attacks each lose 2d8 hit points
    4956 Target and the next person he attacks fall unconscious until dawn
    4957 Target and the next person he attacks freeze solid
    4958 Target and the next person he attacks teleport 1d4 miles away
    4959 Target and the next person he attacks vanish for 10d10 rounds
    4960 Target appears to be 1d100 years older than he really is
    4961 Target appears to be 1d20 inches taller than he really is
    4962 Target appears to be a hideous corpse until dawn tomorrow
    4963 Target appears to be far more menacing than he really is
    4964 Target appears to be in the middle of a terrible rainstorm
    4965 Target appears to be made of chocolate until dawn tomorrow
    4966 Target appears to be soaked in his own blood until dawn tomorrow
    4967 Target appears to be wearing a cloak of shimmering fire
    4968 Target appears to have been assembled out of bamboo
    4969 Target appears to have been burned beyond recognition
    4970 Target appears to have been turned inside-out and then restored
    4971 Target asserts that a great catastrophe is about to occur
    4972 Target asserts that a nearby ally is really an illusion
    4973 Target asserts that a nearby ally is trying to Charm him
    4974 Target asserts that a vast conspiracy is out to get him
    4975 Target asserts that all contracts are null and void
    4976 Target asserts that all gold within 10 miles is counterfeit
    4977 Target asserts that anyone who bleeds in his presence is a coward
    4978 Target asserts that anyone who drinks his blood will live forever
    4979 Target asserts that dangerous organisms live within his flesh
    4980 Target asserts that death no longer has any power over him
    4981 Target asserts that fire-based magic has no effect upon him
    4982 Target asserts that he and the caster have been allies for years
    4983 Target asserts that he can command undead
    4984 Target asserts that he can cure disease and cast out demons
    4985 Target asserts that he can divine the future, for the right price
    4986 Target asserts that he can identify poisons by tasting them
    4987 Target asserts that he can issue divine edicts
    4988 Target asserts that he can place powerful curses on people
    4989 Target asserts that he can produce pearls if he eats sand
    4990 Target asserts that he can summon Earth Elementals by eating dirt
    4991 Target asserts that he can summon ghosts and phantoms at will
    4992 Target asserts that he can take the shape of a doppelganger
    4993 Target asserts that he can talk to Air Elementals at will
    4994 Target asserts that he can throw lightning bolts at will
    4995 Target asserts that he can travel between planes at will
    4996 Target asserts that he can travel freely through time
    4997 Target asserts that he can turn diamonds into coal by eating them
    4998 Target asserts that he died 1d4 rounds ago
    4999 Target asserts that he died 1d4 years ago
    5000 Target asserts that he has a key that unlocks his skull
    5001 Target asserts that he has any number of non-verifiable maladies
    5002 Target asserts that he has only 1d4 hours to live
    5003 Target asserts that he has the power to bestow godhood
    5004 Target asserts that he has the power to create and destroy souls
    5005 Target asserts that he heals quickly and has a metal skeleton
    5006 Target asserts that he intends to raze the nearest city
    5007 Target asserts that he is descended from mighty kings
    5008 Target asserts that he is the casteris father
    5009 Target asserts that he knows exactly who is destined to kill him
    5010 Target asserts that he knows the location of a secret holy book
    5011 Target asserts that he knows the location of a vast treasure
    5012 Target asserts that he knows when, where, and how heill die
    5013 Target asserts that he must choose which of his allies must die
    5014 Target asserts that he was bitten by a werewolf one month ago
    5015 Target asserts that he will become omnipotent upon death
    5016 Target asserts that he will go insane unless he eats 1d4 apples
    5017 Target asserts that he worked as a torturer for the king
    5018 Target asserts that heill combust if anyone says his name
    5019 Target asserts that heill combust if he draws his weapon too fast
    5020 Target asserts that heill combust if he gets wet
    5021 Target asserts that heill combust if he reads a map
    5022 Target asserts that heill combust if heis outdoors at sunset
    5023 Target asserts that heill combust if his blood is spilled
    5024 Target asserts that heill die before he sees another winter
    5025 Target asserts that heill die during the next rainstorm
    5026 Target asserts that heill die if anyone harms the caster
    5027 Target asserts that heill die if anyone nearby dies violently
    5028 Target asserts that heill die if anyone nearby is related to him
    5029 Target asserts that heill die if anyone nearby speaks his name
    5030 Target asserts that heill die if anyone nearby uses magic
    5031 Target asserts that heill die if he changes or cleans his clothes
    5032 Target asserts that heill die if he closes his eyes or blinks
    5033 Target asserts that heill die if he crosses moving water
    5034 Target asserts that heill die if he doesnit receive a pony
    5035 Target asserts that heill die if he draws a weapon in anger
    5036 Target asserts that heill die if he draws/sheathes his weapon
    5037 Target asserts that heill die if he eats during the next 4d6 days
    5038 Target asserts that heill die if he fires any missile weapon
    5039 Target asserts that heill die if he opens his eyes
    5040 Target asserts that heill die if he sees a rainbow
    5041 Target asserts that heill die if he sees his own blood
    5042 Target asserts that heill die if he speaks his native language
    5043 Target asserts that heill die if he spends any money
    5044 Target asserts that heill die if he stops dancing
    5045 Target asserts that heill die if he stops talking
    5046 Target asserts that heill die if he touches anyone elseis blood
    5047 Target asserts that heill die if he touches gold
    5048 Target asserts that heill die if he touches ice
    5049 Target asserts that heill die if he touches metal
    5050 Target asserts that heill die if he uses any magic items
    5051 Target asserts that heill die if he uses the word "the"
    5052 Target asserts that heill die if heis cut by a magical blade
    5053 Target asserts that heill die if someone tells him to die
    5054 Target asserts that heill die in 1d4 rounds 
    5055 Target asserts that heill die of biliousness
    5056 Target asserts that heill die the next time he eats
    5057 Target asserts that heill die the next time he receives first aid
    5058 Target asserts that heill die the next time he sleeps
    5059 Target asserts that heill die unless he burns all of his clothing
    5060 Target asserts that heill die unless he cuts his own throat
    5061 Target asserts that heill die unless he cuts off his own hand
    5062 Target asserts that heill die unless he destroys his magic items
    5063 Target asserts that heill die unless he destroys his weapon
    5064 Target asserts that heill die unless he drains all of his blood
    5065 Target asserts that heill die unless he drinks strong poison
    5066 Target asserts that heill die unless he eats a special mushroom
    5067 Target asserts that heill die unless he kills the caster
    5068 Target asserts that heill die unless he receives 500 gold pieces
    5069 Target asserts that heill die unless he receives 500 gold pieces
    5070 Target asserts that heill die unless he stays awake for 2d6 weeks
    5071 Target asserts that heill die unless he swallows a magic ring
    5072 Target asserts that heill die unless he takes a vow of pacifism
    5073 Target asserts that heill die unless his demands are met
    5074 Target asserts that heill die unless someone beheads him
    5075 Target asserts that heill die unless the caster kills himself
    5076 Target asserts that heill die when the caster casts another spell
    5077 Target asserts that heill drown in a picture of a lake
    5078 Target asserts that heill drown in a small puddle nearby
    5079 Target asserts that heill explode if anyone eats food near him
    5080 Target asserts that heill go mad if anyone touches him
    5081 Target asserts that heill turn into a werewolf if he eats meat
    5082 Target asserts that heill turn to diamond when slain
    5083 Target asserts that heill vanish forever if he falls asleep
    5084 Target asserts that heill vanish forever if he leaves this area
    5085 Target asserts that heill vanish into the ground at dawn tomorrow
    5086 Target asserts that heill vanish into the sky if heis wounded
    5087 Target asserts that heis a ghost and must haunt this area
    5088 Target asserts that heis a highly qualified thoracic surgeon
    5089 Target asserts that heis a mighty warrior despite the evidence
    5090 Target asserts that heis a Summoned creature about to be banished
    5091 Target asserts that heis a traveler from an antique land
    5092 Target asserts that heis an assassin from the distant future
    5093 Target asserts that heis an avatar of the casteris deity
    5094 Target asserts that heis been fatally wounded
    5095 Target asserts that heis been repeatedly destroyed and rebuilt
    5096 Target asserts that heis been replaced by a doppelganger
    5097 Target asserts that heis brother to dragons and companion to owls
    5098 Target asserts that heis come to deliver his people from bondage
    5099 Target asserts that heis eager to exterminate his species
    5100 Target asserts that heis found a plot to wipe out his species
    5101 Target asserts that heis hunting a monster from the distant past
    5102 Target asserts that heis immune to magic
    5103 Target asserts that heis on a quest to destroy a mighty artifact
    5104 Target asserts that heis on a rock outcrop surrounded by lava
    5105 Target asserts that heis on the verge of exterminating his race
    5106 Target asserts that heis one of many clones of the real target
    5107 Target asserts that heis protected by an unholy host of demons
    5108 Target asserts that heis rapidly bleeding to death
    5109 Target asserts that heis responsible for many thousands of deaths
    5110 Target asserts that heis standing at the bottom of a deep well
    5111 Target asserts that heis standing on a ledge over an infinite pit
    5112 Target asserts that heis supernaturally beautiful
    5113 Target asserts that heis the embodiment of a mighty artifact
    5114 Target asserts that heis the mightiest warrior in the world
    5115 Target asserts that heis the worldis most powerful magic user
    5116 Target asserts that heis transforming into some kind of beast
    5117 Target asserts that heis unspeakably ugly
    5118 Target asserts that heis water soluble
    5119 Target asserts that his actions are in accordance with prophecy
    5120 Target asserts that his actions shape the destiny of the world
    5121 Target asserts that his allies have forsaken him
    5122 Target asserts that his birth occurred under odd circumstances
    5123 Target asserts that his blood is worth more than gold
    5124 Target asserts that his body and head are two symbiotic organisms
    5125 Target asserts that his clothes are writhing with snakes
    5126 Target asserts that his clothing is trying to kill him
    5127 Target asserts that his current form isnit his true form
    5128 Target asserts that his death will be avenged one thousand times
    5129 Target asserts that his flesh is harder than iron
    5130 Target asserts that his god owes him a big favor
    5131 Target asserts that his internal organs are made of pure gold
    5132 Target asserts that his plans will all culminate at dawn tomorrow
    5133 Target asserts that his soul will be destroyed if heis injured
    5134 Target asserts that his touch can induce madness
    5135 Target asserts that his worst injuries are just a flesh wound
    5136 Target asserts that no one nearby really exists
    5137 Target asserts that one of his allies will betray him in a garden
    5138 Target asserts that poultices of manure can heal any wound
    5139 Target asserts that puns and rhymes are painful to him
    5140 Target asserts that secret entities are plotting his downfall
    5141 Target asserts that someone nearby is the avatar of his god
    5142 Target asserts that that all food within 10 miles is poisonous
    5143 Target asserts that the answer to every riddle is "time"
    5144 Target asserts that the caster is a fraud and a charlatan
    5145 Target asserts that the caster is an avatar of his deity
    5146 Target asserts that the casteris spell functioned as intended
    5147 Target asserts that the king owes him a huge favor
    5148 Target asserts that the wages of sin arenit really death
    5149 Target asserts that the world will end the moment that he dies
    5150 Target asserts that time is an illusion, lunchtime doubly so
    5151 Target asserts that whoever kills him will become a god
    5152 Target asserts that whoever slays him will win incredible riches
    5153 Target attacks anyone he sees using a magic item
    5154 Target attacks anyone who attacks the caster
    5155 Target attacks anyone who sees him using a magic item
    5156 Target attacks anyone who speaks ill of the caster
    5157 Target attacks anyone who uses magic upon the caster
    5158 Target attacks the nearest herd animal until he or it is dead
    5159 Target attacks the next person nearby who says his own name
    5160 Target attacks the next person nearby who spends money
    5161 Target attacks the next person who address him by name
    5162 Target attacks the next person who draws a weapon nearby
    5163 Target attacks the toughest, most dangerous creature he can see
    5164 Target attempts to acquire the casteris spellbook
    5165 Target attempts to disembowel himself with his bare hands
    5166 Target attempts to ingest any ink he sees
    5167 Target attempts to mimic the casteris every more
    5168 Target attempts to strangle all trees within 100 yards
    5169 Target attempts to strangle himself with his bare hands
    5170 Target attracts all manner of mutants and abominations
    5171 Target attracts leeches, maggots, slugs, and snails
    5172 Target babbles incoherently for 2d10 rounds
    5173 Target barks like a dog when he thinks he sees magic
    5174 Target becomes a devoted acolyte of some fringe religion
    5175 Target becomes an albino
    5176 Target becomes ethereal if wounded by a weapon made of gold
    5177 Target becomes giddy and mirthful when heis next hit by a weapon
    5178 Target becomes intensely covetous of any magic item he sees
    5179 Target becomes intensely hungry following each battle
    5180 Target becomes nearly insane with rage whenever he says his name
    5181 Target becomes the casteris most trusted and faithful friend
    5182 Target becomes violently ill if he eats while in daylight
    5183 Target becomes violently ill if he eats while sitting
    5184 Target becomes wildly drunk when heis next hit by a weapon 
    5185 Target befouls any food or water that he and his allies now carry
    5186 Target befriends a statue and carries it with him everywhere
    5187 Target befriends a statue and thinks it gives him good advice
    5188 Target befriends one of the casteris allies
    5189 Target befriends the toughest, most dangerous creature he can see
    5190 Target begs someone to bite off 1d10 of his fingers
    5191 Target begs someone to set him ablaze
    5192 Target believes anything the caster says to him
    5193 Target believes everything that he says
    5194 Target believes no factual statement he hears uttered in sunlight
    5195 Target believes that 1d10 of his fingers are intensely magical
    5196 Target believes that he canit be harmed by a fall from any height
    5197 Target believes that he canit be slain by metal weapons
    5198 Target believes that his allies are conspiring to rob him
    5199 Target believes that nearly everyone is lying to him
    5200 Target believes that whatever he last ate gave him eternal life
    5201 Target believes that whatever he last ate is still alive
    5202 Target believes that whatever he last ate was a powerful toxin
    5203 Target believes that whatever he last ate was hallucinogenic
    5204 Target believes that whatever he last ate was his last meal
    5205 Target believes that whatever he last ate was worth a fortune
    5206 Target belongs to a cult that requires him to perform horrid acts
    5207 Target belongs to a cult that will remove his heart within a week
    5208 Target bleeds from every orifice for 1d6 rounds but is unharmed
    5209 Target bleeds profusely during combat, even if not wounded
    5210 Target blows bright blue until heis wounded by a magical weapon
    5211 Target briefly appears to be undead to anyone who wounds him
    5212 Target briefly becomes invisible to anyone who wounds him
    5213 Target briefly resembles anyone who wounds him
    5214 Target briefly resembles the target each time heis wounded
    5215 Target bursts into flame the next time heis totally submerged
    5216 Target can appear to be covered in moss and lichens at will
    5217 Target can appear to be twice his true age at will
    5218 Target can appear totally nondescript and unremarkable at will
    5219 Target can be commanded by the nearest dragon at will
    5220 Target can be injured by arrows, but they canit kill him
    5221 Target can be injured by bludgeons, but they canit kill him
    5222 Target can be injured by electricity, but it canit kill him
    5223 Target can be injured by magical cold, but it canit kill him
    5224 Target can be injured by magical fire, but it canit kill him
    5225 Target can be injured by magical weapons, but they canit kill him
    5226 Target can be injured by water, but it canit kill him
    5227 Target can be Summoned by the nearest dragon at will
    5228 Target can become invisible at will but is 15% likely to die
    5229 Target can become invisible at will if he plucks out his eyes
    5230 Target can become invisible by drinking a quart of Elfis blood
    5231 Target can bend his spine 120° midway along its length
    5232 Target can brachiate like an ape but adopts an apeis proportions
    5233 Target can Call Lightning daily but itis 70% likely to strike him
    5234 Target can cast one Wish spell but permanently dies as a result
    5235 Target can cause one nearby tree to become invisible for 2d6 days
    5236 Target can cause one nearby tree to topple as though chopped down
    5237 Target can cause someone nearby to resemble someone else nearby
    5238 Target can change the color of his face 2d4 times per day
    5239 Target can climb like a monkey
    5240 Target can climb like a monkey but is 40% likely to become one
    5241 Target can comfortably lift and carry twice his weight in manure
    5242 Target can Command one nearby humanoid for 1d6 hours
    5243 Target can Command one person nearby to defend him to the death
    5244 Target can Command one person now nearby to attack
    5245 Target can Command one person now nearby to tell the truth
    5246 Target can Command the nearest dragon, just once
    5247 Target can control caster like an undead skeleton for 1d6 rounds
    5248 Target can delay his voice by 1d4 rounds, 1d4 times per day
    5249 Target can detect counterfeit gems by tasting them
    5250 Target can digest soil as readily as meat
    5251 Target can discern magic items by bleeding on them
    5252 Target can discern magic items by tasting them
    5253 Target can dismiss a total of 20HD worth of elementals
    5254 Target can divine the casteris exact location 1d4 times per day
    5255 Target can do nothing but scream for 1d8 rounds
    5256 Target can easily be persuaded to disarm himself
    5257 Target can erect a four foot high wall of snow once per week
    5258 Target can exhale fire but is 10% likely to combust and die
    5259 Target can exhale fire but suffers as much damage as he inflicts
    5260 Target can fall one yard per point of Wisdom without harm
    5261 Target can Heal himself at will but ages 1d6 years per hit point
    5262 Target can Heal himself but his closest ally will die as a result
    5263 Target can Heal himself but is 5% likely to die each time
    5264 Target can Heal himself but is 80% likely to drown each time
    5265 Target can Heal himself but is blinded for 1d20 days each time
    5266 Target can Heal himself but it costs him 1,000,000 gold pieces
    5267 Target can Heal himself but only at night if he has one hit point
    5268 Target can Heal himself four times but loses a limb each time
    5269 Target can Heal himself if he sacrifices a point of CON each time
    5270 Target can Heal himself ten times but loses a finger each time
    5271 Target can hide his weapon inside his body for 2d4 hours per day
    5272 Target can ingest and digest small quantities of bone
    5273 Target can ingest and digest small quantities of coral
    5274 Target can ingest and digest small quantities of glass
    5275 Target can ingest and digest small quantities of gold
    5276 Target can ingest and digest small quantities of iron
    5277 Target can ingest and digest small quantities of lamp oil
    5278 Target can ingest and digest small quantities of lead
    5279 Target can ingest and digest small quantities of poison
    5280 Target can ingest and digest small quantities of stone
    5281 Target can ingest and digest small quantities of wood
    5282 Target can issue Commands but is 20% likely to die each time
    5283 Target can kill the caster outright but will also permanently die
    5284 Target can kill the caster outright but will never have existed
    5285 Target can leap one yard straight up per point of Charisma
    5286 Target can locate any bear within one mile
    5287 Target can magically Summon a distant relative who despises him
    5288 Target can magically Summon his own clone once for 1d10 rounds
    5289 Target can magically Summon the caster 1d4 times for 1d10 rounds
    5290 Target can magically Summon the corpse some person he killed
    5291 Target can make his voice issue from any object within 10 feet
    5292 Target can make his voice issue from any person within 5 feet
    5293 Target can make his voice seem to be 1d4 octaves higher or lower
    5294 Target can make his voice seem to be that of someone much older
    5295 Target can make his whisper heard by anyone in his line of sight
    5296 Target can make his whisper heard through one foot of stone
    5297 Target can make one of his arms as supple as rope at will
    5298 Target can make one of his hands double in size at will
    5299 Target can mask his scent at will
    5300 Target can never again address anyone by name
    5301 Target can never again speak or write his own name
    5302 Target can never again wear the clothes or armor heis wearing now
    5303 Target can never again wield the specific weapon he now wields
    5304 Target can never be harmed by any weapon now within 10 yards
    5305 Target can never be harmed by the specific weapon he now wields
    5306 Target can never be slain if he cuts off both of legs right now
    5307 Target can never become invisible to anyone now within 100 miles
    5308 Target can never become invisible to anyone who has wounded him
    5309 Target can never become invisible to anyone who knows his name
    5310 Target can never become invisible without dying
    5311 Target can no longer conceal his astonishing halitosis
    5312 Target can no longer conceal his disdain for magic users
    5313 Target can no longer conceal his fear of combat
    5314 Target can no longer conceal his hatred of Dwarves 
    5315 Target can no longer conceal his insatiable cannibalism
    5316 Target can no longer conceal his plans for world domination
    5317 Target can no longer conceal the fact that heis artificial
    5318 Target can no longer conceal the secret of his birth
    5319 Target can only be killed by a magical weapon that he has wielded
    5320 Target can only be killed by a weapon forged from his own bones
    5321 Target can only eat food that he himself has prepared
    5322 Target can polymorph at will but ages 1d100 years each time
    5323 Target can polymorph at will but is 10% likely to die each time
    5324 Target can polymorph at will but is blind in any form but his own
    5325 Target can read but not speak or write 1d6 additional languages
    5326 Target can read handwritten text at a distance of 10d10 yards
    5327 Target can readily be convinced that he doesnit really exist
    5328 Target can recognize faces only 10% of the time
    5329 Target can regenerate 1 hit point per round for the next week
    5330 Target can remove his head for up to 1d4 rounds without harm
    5331 Target can remove his heart for up to 1d6 rounds without harm
    5332 Target can retract his ears into his skull at will
    5333 Target can retract one of his limbs into his body at will
    5334 Target can see no farther than 20 yards unless heis barefoot
    5335 Target can see no farther than 20 yards while in sunlight
    5336 Target can see secret doors but canit see normal ones
    5337 Target can see secret doors if he drinks concentrated poison
    5338 Target can see secret doors if he sacrifices 1d6 hit points
    5339 Target can see secret doors while yelling and hopping on one foot
    5340 Target can shine heatless torchlight from his palm at will
    5341 Target can shine heatless torchlight from the soles of his feet
    5342 Target can speak only in a full shout while his weapon is drawn
    5343 Target can speak only in grunts while his weapon is drawn
    5344 Target can speak only in rhyme while his weapon is drawn
    5345 Target can speak only in whale song for 1d4 hours
    5346 Target can speak the language of bears, but they donit listen
    5347 Target can speak with flies and gnats
    5348 Target can speak with livestock but henceforth smells like manure
    5349 Target can speak with monkeys and apes
    5350 Target can speak with one corpse per week, but it lies to him
    5351 Target can speak with one tree per week
    5352 Target can speak with worms and slugs
    5353 Target can stride unimpeded in knee-deep snow
    5354 Target can stride unimpeded through thigh-deep water
    5355 Target can subsist on leaves and grass for up to 1d4 weeks
    5356 Target can subsist on mud, but it tastes incredibly foul to him
    5357 Target can subsist on mud, but itis highly addictive to him
    5358 Target can subsist on mud, but regular food is poisonous to him
    5359 Target can subsist on only 10% of the normal amount of food
    5360 Target can subsist on water alone while heis at full hit points
    5361 Target can subsist on water but must drink ten gallons per day
    5362 Target can Summon and Command an 8HD Earth Elemental 1d6 times
    5363 Target can teleport 1d4 miles per day but ages 8d8 years per mile
    5364 Target can teleport 1d4 miles randomly, once per day
    5365 Target can teleport at will but arrives 1d20 days later
    5366 Target can teleport at will but arrives with only one hit point
    5367 Target can teleport at will but is 50% likely to die on arrival
    5368 Target can teleport half of his body at will
    5369 Target can teleport one person nearby to the targetis home
    5370 Target can teleport to the casteris location once per month
    5371 Target can teleport to this location once per month
    5372 Target can track the caster with astonishing accuracy
    5373 Target can turn his head completely around without harm
    5374 Target can understand every language spoken within 10 miles
    5375 Target can wield his weapon only in his non-dominant hand
    5376 Target can Wish the death of someone nearby, but target also dies
    5377 Target can write but not speak or read 1d6 additional languages
    5378 Target canit attack anyone for 2d4 rounds
    5379 Target canit attack anyone until he wounds himself
    5380 Target canit attack anyone who doesnit know targetis name
    5381 Target canit attack or be attacked for 2d8 rounds
    5382 Target canit attack or be attacked until he moves from this spot
    5383 Target canit attack the caster until at least sunset
    5384 Target canit attack the caster with any weapons containing metal
    5385 Target canit attack the caster with any weapons containing wood
    5386 Target canit attack until he drops his weapons, gear, and clothes
    5387 Target canit be affected by the casteris magic for 1d6 turns
    5388 Target canit be affected by the intended spell for 1d4 years
    5389 Target canit be attacked by anyone or anything for 1d4 rounds
    5390 Target canit be burned by acid if he cuts off both of his thumbs
    5391 Target canit be burned by molten metal
    5392 Target canit be burned by steam between sunset and dawn
    5393 Target canit be burned by steam or boiling water while naked
    5394 Target canit be burned by steam while heis wearing boots or shoes
    5395 Target canit be choked, strangled, or suffocated
    5396 Target canit be cut by any blade unless itis already bloodstained
    5397 Target canit be cut by manufactured stone blades
    5398 Target canit be detected by invisible creatures
    5399 Target canit be detected by magical attempts at scrying
    5400 Target canit be detected by magical scrying while naked in a tree
    5401 Target canit be harmed by bludgeons between dawn and noon
    5402 Target canit be harmed by bludgeons for 2d10 rounds
    5403 Target canit be harmed by boiling oil or pitch
    5404 Target canit be harmed by invisible creatures at night
    5405 Target canit be harmed by magical fire while brandishing a weapon
    5406 Target canit be harmed by magical fire while indoors
    5407 Target canit be harmed by magical fire while standing in a bucket
    5408 Target canit be harmed by magical fire while underwater
    5409 Target canit be harmed by natural lightning
    5410 Target canit be injured by wooden weapons while naked
    5411 Target canit be injured by wooden weapons while sleeping
    5412 Target canit be injured by wooden weapons while standing in fire
    5413 Target canit be injured by wooden weapons while standing in snow
    5414 Target canit be killed by any female creature for 1d4 weeks
    5415 Target canit be killed by any male creature for 1d4 weeks
    5416 Target canit be killed during the next 2d12 hours
    5417 Target canit be knocked off balance by any less than 1d4 people
    5418 Target canit be knocked off balance by any physical force
    5419 Target canit be magically detected by anyone not of his race
    5420 Target canit be magically detected by anyone of the same sex
    5421 Target canit be slain except while sleeping
    5422 Target canit be slain if he remains within 10 yards of this spot
    5423 Target canit be slain while sleeping
    5424 Target canit be stunned by any blow to the head
    5425 Target canit be surprised if he has a snowball in each hand
    5426 Target canit be surprised if he has an eyeball in his mouth
    5427 Target canit be surprised if heis wearing a carnation
    5428 Target canit be surprised while at full hit points
    5429 Target canit be wounded by metal weapons until sunset tonight
    5430 Target canit be wounded by metal weapons while barefoot
    5431 Target canit breathe for 2d10 rounds
    5432 Target canit breathe until he removes his boots or shoes
    5433 Target canit breathe while touching more than one person
    5434 Target canit breathe while wearing, touching, or carrying metal
    5435 Target canit come within 10 feet of any fire now burning
    5436 Target canit come within 10 yards of the caster
    5437 Target canit come within one mile of his home
    5438 Target canit come within one mile of the caster
    5439 Target canit come within ten feet of any tree thicker than he is
    5440 Target canit create or use magical fire except while indoors
    5441 Target canit create or use magical fire for 1d4 years
    5442 Target canit die for at least 1d4 days, but he can be injured
    5443 Target canit digest any food that he eats in direct sunlight
    5444 Target canit digest any food unless he prepares it himself 
    5445 Target canit digest anything thatis been dead longer than a day
    5446 Target canit digest cooked meat
    5447 Target canit digest meat from any animal killed in daylight
    5448 Target canit draw his weapon if anyone else is within 10 yards
    5449 Target canit draw his weapon or sheathe it if itis now drawn
    5450 Target canit draw his weapon unless he asks permission to do so
    5451 Target canit draw his weapon within 100 yards of this spot
    5452 Target canit hear echoes
    5453 Target canit hear his own voice
    5454 Target canit hear his own voice except while his eyes are closed
    5455 Target canit hear the voice of any female member of his race
    5456 Target canit hear the voice of any male member of his race
    5457 Target canit hear the voice of anyone whois recently injured him
    5458 Target canit hear the voice of anyone within 10 feet of him
    5459 Target canit hear voices for 2d4-1 days
    5460 Target canit ignite any fire unless his hair is soaking wet
    5461 Target canit ignite any fire unless itis snowing
    5462 Target canit ignite any fire while underground
    5463 Target canit ignite any fire while wearing clothes
    5464 Target canit leave this spot until he wounds himself
    5465 Target canit lie, equivocate, or tell half-truths
    5466 Target canit move more than 10 yards from the caster
    5467 Target canit pass through doorways while at full hit points
    5468 Target canit say anyoneis name
    5469 Target canit see artificial light while at full hit points
    5470 Target canit see light other than sunlight or reflected sunlight
    5471 Target canit see or hear any of his allies for 4d6 hours
    5472 Target canit see or hear his 1d4 of his allies for 1d4 days
    5473 Target canit see or hear living creatures for 2d6 rounds
    5474 Target canit see or hear magical creatures for 2d6 days
    5475 Target canit see or hear metal objects for 3d8 hours
    5476 Target canit see sunlight or reflected sunlight
    5477 Target canit sleep unless he first eats a handful of soil
    5478 Target canit sleep unless he has his weapon in hand
    5479 Target canit sleep unless heis standing up
    5480 Target canit sleep until he fells the tallest tree in the kingdom
    5481 Target canit sleep until he gives away all of his armor
    5482 Target canit sleep within 10 feet of another sleeping person
    5483 Target canit speak except while barefoot
    5484 Target canit speak except while brandishing a weapon
    5485 Target canit speak for 1d20 turns
    5486 Target canit speak to anyone more than 20 feet from him
    5487 Target canit speak to anyone who addresses him by name
    5488 Target canit speak unless he wears a cloth over his face
    5489 Target canit speak unless heis brandishing a weapon
    5490 Target canit speak unless his hair is wet
    5491 Target canit speak until after he has eaten his next full meal
    5492 Target canit speak until his blood is next drawn
    5493 Target canit speak until the caster says his own name
    5494 Target canit speak while at full hit points
    5495 Target canit speak while at full hit points
    5496 Target canit speak while wielding a weapon
    5497 Target canit use any form of rope or chain longer than he is tall
    5498 Target canit use any items containing metal for 2d4-1 days
    5499 Target canit use any magic items containing wood for 2d4-1 days
    5500 Target canit use any magic items for 1d4 days
    5501 Target canit use any magic items older than he is
    5502 Target canit use his hands or any utensils while eating
    5503 Target canit voluntarily pass through doorways unless naked
    5504 Target canit walk until the caster says his own name
    5505 Target canit walk while carrying gold
    5506 Target canit wield any weapon containing metal for 1d4 days
    5507 Target canit wield any weapon in his dominant hand
    5508 Target canit wield any weapon that hasnit drawn his blood
    5509 Target canit wield any weapon within 1d4 miles of this spot
    5510 Target canit wound anyone who hasnit wounded him
    5511 Target carves a tiny notch in every tree he passes
    5512 Target challenges his closest ally to single combat to the death
    5513 Target chants nonsensically for 2d10 rounds
    5514 Target clatters when he walks like a barrel full of pots and pans
    5515 Target collapses into a fetal position for 1 turn
    5516 Target combusts if he uses magic within the next 1d4 turns
    5517 Target combusts if his weapon is thrown into a river
    5518 Target comes into possession of a world-shaking artifact
    5519 Target concludes every battle thoroughly soaked by his own blood
    5520 Target confesses to a list of crimes, none of which has happened
    5521 Target confesses to crimes he couldnit possibly have committed
    5522 Target confesses to genocide but can produce no evidence of it
    5523 Target confesses to rampant kleptomania
    5524 Target constantly boasts about his prowess in all things
    5525 Target constantly exudes fragrant soap suds
    5526 Target continuously speaks to an imaginary ally
    5527 Target coughs incessantly, but his actions are unimpaired
    5528 Target craves hay and has a long tail like a horse
    5529 Target craves twigs and bark after every battle
    5530 Target creates a phony language and refuses to speak any other
    5531 Target crouches and begins eating dirt, twigs, gravel, etc.
    5532 Target crows like a rooster whenever he sees a magic item used
    5533 Target dares 1d4 of his allies to try to behead him
    5534 Target declares this area to be a sacred shrine to his deity
    5535 Target degenerates into an abomination hated by sentient beings
    5536 Target demands that his friends and allies pay him tribute
    5537 Target develops a pronounced stutter
    5538 Target disappears and is completely forgotten for 2d4-1 days
    5539 Target discovers that one of his limbs is a separate entity
    5540 Target discovers that one of his limbs is made of living wood
    5541 Target discovers that one of his limbs is trying to kill him
    5542 Target discovers that one of his limbs isnit attached to his body
    5543 Target disgorges 1d10 acorns in each of the next 1d10+10 rounds
    5544 Target disgorges 1d10 cubic feet of damp, sticky rice
    5545 Target disgorges 1d10 pounds of feathers
    5546 Target disgorges 1d10 pounds of hallucinogenic mushrooms
    5547 Target disgorges 1d100 gold coins, half of which are counterfeit
    5548 Target disgorges 1d1000 dragonflies
    5549 Target disgorges 1d1000 tiny, phosphorescent worms
    5550 Target disgorges 1d4 cubic yards of humus
    5551 Target disgorges 1d4 gallons of boiling pitch
    5552 Target disgorges 1d6 filthy carrion birds
    5553 Target disgorges 2d10 pounds of slag
    5554 Target disgorges 3d100 feet of hemp rope
    5555 Target disgorges 5d10 sheets of pristine parchment
    5556 Target disgorges 5d10 sheets of rotting parchment
    5557 Target disgorges a 50 pound sack of potatoes
    5558 Target disgorges a boulder larger than any within 1d10 miles
    5559 Target disgorges a box that he believes to contain his soul
    5560 Target disgorges a brick of solid chlorine
    5561 Target disgorges a bucket filled with eyeballs
    5562 Target disgorges a bushel of razor-sharp shards of glass
    5563 Target disgorges a bushel of rotten apples
    5564 Target disgorges a corked bottle containing a mysterious note
    5565 Target disgorges a corked bottle containing a powerless genie
    5566 Target disgorges a dragonis egg
    5567 Target disgorges a full-sized statue of a nearby ally
    5568 Target disgorges a gelatinous mass writhing with tentacles
    5569 Target disgorges a healthy specimen of some extinct species
    5570 Target disgorges a homunculus
    5571 Target disgorges a huge quantity of raisins, dates, and figs
    5572 Target disgorges a large hourglass nearly empty of sand
    5573 Target disgorges a large slab of marble
    5574 Target disgorges a map to his home 
    5575 Target disgorges a one-half-size clone of the caster
    5576 Target disgorges a pair eyeglasses granting the wearer True Sight
    5577 Target disgorges a slimy slug as long and thick as his arm
    5578 Target disgorges a small and long-lost artifact of great power
    5579 Target disgorges a small but detailed replica of a nearby castle
    5580 Target disgorges a small trampoline
    5581 Target disgorges a stone that explodes on contact with ice
    5582 Target disgorges a stone that will kill him if he touches it
    5583 Target disgorges a ten foot column of aluminum one foot thick
    5584 Target disgorges a two-foot square pane of glass
    5585 Target disgorges a vial containing a powerful but unknown potion
    5586 Target disgorges a vial containing the antidote to every poison
    5587 Target disgorges an egg that can freeze 1,000 cubic feet of water
    5588 Target disgorges an egg that, if broken, turns into a small boat
    5589 Target disgorges an entire trombone, minus the mouthpiece
    5590 Target disgorges an exact copy of the clothes heis now wearing
    5591 Target disgorges an intricate but badly rusted clockwork device
    5592 Target disgorges his own full-grown clone, which then attacks him
    5593 Target disgorges several gallons of house paint
    5594 Target disgorges several gallons of viscous, highly adhesive goo
    5595 Target disgorges the crown of the nearest king
    5596 Target disgorges the front door of his home
    5597 Target doesnit age until he next speaks
    5598 Target doesnit age while bald
    5599 Target doesnit age while holding a gold coin in his mouth
    5600 Target doesnit age while in the casteris presence
    5601 Target doesnit age while naked
    5602 Target doesnit age while wearing a wet hat
    5603 Target doesnit age while weeping
    5604 Target doesnit need to eat, drink, or breathe for 2d4-1 days
    5605 Target doesnit need to sleep for 4d20 days
    5606 Target donates 2d10 hit points to the caster
    5607 Target drowns for 1d6 rounds but is fine afterward
    5608 Target earns 50 gold pieces when his attacks cause maximum damage
    5609 Target embraces a wacky cult founded by a hack writer
    5610 Target endeavors to buy a controlling interest in the kingdom
    5611 Target endlessly frets that heill die in 1d10 rounds
    5612 Target endlessly frets that heis doomed to be eaten by a dragon
    5613 Target experiences bone-chilling cold when his head is touched
    5614 Target experiences clairvoyance when he is burned
    5615 Target experiences heart-rending grief whenever he uses magic
    5616 Target experiences intense vertigo when he draws a weapon
    5617 Target experiences searing pain when his skin is touched
    5618 Target experiences soul-wrenching pain if he stands upright
    5619 Target experiences transcendent euphoria when his blood is drawn
    5620 Target experiences vague nostalgia whenever heis wounded
    5621 Target exudes a scent 50% likely disgust any given person
    5622 Target exudes a scent like something dredged from the ocean floor
    5623 Target exudes a scent reminiscent of decaying skunks
    5624 Target exudes a scent reminiscent of the bottom of the ocean
    5625 Target exudes a scent that attracts carnivores
    5626 Target exudes a scent that causes conifers to shed their needles
    5627 Target exudes a scent that causes fires to burn pale green
    5628 Target exudes a scent that causes food to spoil quickly
    5629 Target exudes a scent that easily can be tracked for miles
    5630 Target exudes a scent that induces sleep in birds
    5631 Target exudes a scent that inspires attracts bats
    5632 Target exudes a scent that inspires fear in earth elementals
    5633 Target exudes a scent that inspires intense bloodlust
    5634 Target exudes a scent that inspires loyalty in wolves
    5635 Target exudes a scent that inspires rage in hoofed animals
    5636 Target exudes a scent that is strongly enticing to undead
    5637 Target exudes a scent that is strongly offensive to undead
    5638 Target exudes a scent that makes Dwarvesi eyes water
    5639 Target exudes a scent that makes other peopleis hair fall out
    5640 Target exudes a scent that makes people ignore him
    5641 Target exudes a scent that obscures infravision
    5642 Target exudes a scent that protects metal from natural rust
    5643 Target exudes a scent that repels gnomes
    5644 Target exudes an offensive stench but refuses to believe it
    5645 Target fails at his next attempt at fine manual dexterity
    5646 Target falls asleep for one hour per hit point he currently lacks
    5647 Target fanatically defends the caster for 1d10 rounds
    5648 Target fears any subsequent magic used by the caster
    5649 Target fears that all of his efforts are for naught
    5650 Target feels as if heis walking on a high tightrope
    5651 Target feels as if heis wearing an enormous hat made of lead
    5652 Target feels as if his clothes are trying to digest him
    5653 Target feels as if his clothes have turned to steel
    5654 Target feels as if someone else is wearing his clothes right now
    5655 Target feels as if thorns have sprouted in his clothes
    5656 Target feels as though a huge rodent is gnawing on his spine
    5657 Target feels as though he just ate three pounds of butter
    5658 Target feels as though he just ate three pounds of cement
    5659 Target feels as though he just ate three pounds of flour
    5660 Target feels as though he just ate three pounds of parchment
    5661 Target feels as though he just swallowed a python
    5662 Target feels as though heis been splashed with boiling water
    5663 Target feels as though heis being swallowed by a python
    5664 Target feels as though heis having a baby
    5665 Target feels as though heis having a heart attack
    5666 Target feels as though heis having teeth extracted
    5667 Target feels as though his allies have abandoned him
    5668 Target feels as though his internal organs are melting
    5669 Target feels as though his teeth are spinning in his mouth
    5670 Target feels as though his wounds have been completely healed
    5671 Target feels as though one of his arms is being amputated
    5672 Target feels compelled to abandon whatever faith he now follows
    5673 Target feels compelled to attain godhood by the end of the week
    5674 Target feels compelled to burn all of his clothing
    5675 Target feels compelled to desecrate a shrine to his deity
    5676 Target feels compelled to find a faith that contradicts his own
    5677 Target feels compelled to martyr himself for someone elseis deity
    5678 Target feels compelled to mummify himself as soon as possible
    5679 Target feels compelled to warn anyone heis about to attack
    5680 Target feels his bones shake like a bundle of sticks
    5681 Target feels his bones slowly disintegrating
    5682 Target feels icy water dripping on him during every battle
    5683 Target feels like heis having the time of his life
    5684 Target feels that the direction of gravity has skewed by 10°
    5685 Target feels the ground shake as during a powerful earthquake
    5686 Target finds a blade that canit be broken by any physical force
    5687 Target finds a book describing the methods of brain surgery
    5688 Target finds a box that damages the sanity of any who look in it
    5689 Target finds a canopic jar containing his own vital organs
    5690 Target finds a cursed vault containing 1d100 bars of gold
    5691 Target finds a foot-long bar of indestructible glass
    5692 Target finds a glass vial containing a highly volatile liquid
    5693 Target finds a huge cache of real but worthless currency
    5694 Target finds a huge leech attached somewhere on his body
    5695 Target finds a large diamond and guards it obsessively
    5696 Target finds a large sack filled with powdered bone
    5697 Target finds a list of command words but doesnit know for what
    5698 Target finds a magical ring enabling him to command amphibians
    5699 Target finds a mysterious and compelling piece of sculpture
    5700 Target finds a new, functioning limb that he didnit know he had
    5701 Target finds a potion affects the person nearest its imbiber
    5702 Target finds a potion that either resurrects or destroys a corpse
    5703 Target finds a pouch containing 1d10 super-intelligent mice
    5704 Target finds a pouch containing curds and whey 
    5705 Target finds a pouch containing exact copies of his hands
    5706 Target finds a recipe for creating human life in a jar
    5707 Target finds a shield +4 that only he can lift
    5708 Target finds a text personally written by his deity
    5709 Target finds a text that he wrote but doesnit remember writing
    5710 Target finds an arsenal stocked with simulated weapons
    5711 Target finds himself imprisoned in a mausoleum far from here
    5712 Target finds the sight of blood intoxicating
    5713 Target finds the sight of male magic users to be enormously funny
    5714 Target finds the sound of his own voice to be horrifying
    5715 Target finds the thought of his own death strangely comforting
    5716 Target finds two doses of a Potion of Resurrection
    5717 Target flees from anyone who addresses him by name
    5718 Target flees into the forest if struck by magic in the next turn
    5719 Target flies into a panic if anyone sees him eating
    5720 Target flies into a panic if he sees other people eating
    5721 Target flies into a rage and attacks the person nearest to him
    5722 Target flies into a rage whenever he draws blood
    5723 Target forgets 1d4 of his allies
    5724 Target forgets everything said to him in the past 1d6 hours
    5725 Target forgets his family and where he lives
    5726 Target forgets his name and doesnit believe that he ever had one
    5727 Target forgets how to ascend stairs and ladders
    5728 Target forgets how to feed himself
    5729 Target forgets how to sleep
    5730 Target forgets how to use any magic item heis now carrying
    5731 Target forgets how to use any weapon containing metal
    5732 Target forgets how to use doors
    5733 Target forgets how to walk but not how to run
    5734 Target forgets that his allies know who he is
    5735 Target forgets the last 1d12 hours
    5736 Target forgets the last 1d4 years
    5737 Target forgets whatever mission or quest he is now undertaking
    5738 Target formally changes his name to "Target"
    5739 Target freezes solid if heis injured while standing in snow
    5740 Target freezes solid the next time he enters an underground lake
    5741 Target gains 1d10 permanent hit points but must Save or die
    5742 Target gains 1d100 hit points that then vanish, one per round
    5743 Target gains 1d100 pounds over that many rounds
    5744 Target gains 1d100 temporary hit points that last until sunset
    5745 Target gains 1d20 hit points and immediately loses another 1d20
    5746 Target gains a level and is restored to full hit points
    5747 Target gains a level but is stricken blind for 1d4 months
    5748 Target gains a level but loses all but 1d4 of his hit points
    5749 Target gains a level but one of his arms turns to steam forever
    5750 Target gains a level if he permanently severs his dominant hand
    5751 Target gains a level the next time heis cut by a magical blade
    5752 Target gains a permanent 1d4-1 bonus to his Armor Class
    5753 Target gains a point of Strength but loses 1d100 hit points
    5754 Target gains a point of Wisdom but loses two points of Strength
    5755 Target gains a powerful magical ally whose motives are unknown
    5756 Target gains a profound insight the next time he touches gold
    5757 Target gains a title based on his actions in the next 1d6 rounds
    5758 Target gains access to an elite secret society
    5759 Target gains benefit from food only if eaten while heis naked
    5760 Target gains no hit points from his next advancement in level
    5761 Target gains one level but can never gain another
    5762 Target gains only a single hit point from any magical healing
    5763 Target gains proficiency in the use of some unlikely weapon
    5764 Target gains the respect of a man soon to be executed for treason
    5765 Target gains the respect of kobolds, who long to be just like him
    5766 Target gains two levels if he kills and eats a human before dawn
    5767 Target gains valuable insight into the nature of ventriloquism
    5768 Target gets 1,000 gold pieces if he cuts off his foot right now
    5769 Target gets 100 gold pieces for each finger he cuts from his hand
    5770 Target gives his most prized possession to the caster
    5771 Target gives his weapon to the person standing nearest to him
    5772 Target glows bright blue until heis burned by magical fire
    5773 Target glows bright blue until heis struck by magic
    5774 Target glows bright blue until heis wounded by his own weapon
    5775 Target glows bright blue while under any magical effect
    5776 Target glows with a bright, rainbow aura while moving stealthily
    5777 Target glows with angelic light whenever he uses a magic item
    5778 Target goes berserk if any of his allies injure him
    5779 Target goes berserk if he eats meat in the next 24 hours
    5780 Target goes berserk if he sees anyone burned by fire
    5781 Target goes berserk if he sees anyone eating meat
    5782 Target goes berserk if he touches gold in the next 1d6 rounds
    5783 Target goes berserk if heis currently carrying any magic items
    5784 Target goes into a homicidal rage for 1d8 rounds, then passes out
    5785 Target goes into a homicidal rage for 1d8 rounds, then vanishes
    5786 Target goes into a homicidal rage whenever he removes his shoes
    5787 Target goes into a homicidal rage whenever he sheathes his weapon
    5788 Target goes totally and dangerously insane until sunset
    5789 Target grows an additional 1d8 fingers
    5790 Target grows an additional pair of ears atop his head
    5791 Target grows an additional pair of eyes somewhere on his face
    5792 Target has 1d100 tiny steel spheres embedded in his skin
    5793 Target has 25 Intelligence for 1d4 turns
    5794 Target has 25 Strength for 1d4 rounds
    5795 Target has a +1 Armor Class bonus while itis raining
    5796 Target has a +2 Armor Class bonus while barefoot
    5797 Target has a +5 Armor Class bonus until sunset tomorrow
    5798 Target has a -1 Armor Class penalty while wielding a weapon
    5799 Target has a -2 Armor Class penalty while itis raining
    5800 Target has a blowhole in the back of his neck
    5801 Target has a colony of bees living in his skull
    5802 Target has a compartment in his torso able to carry small items
    5803 Target has a complete but false memory of the past 24 hours
    5804 Target has a doppelganger slave that looks just like the caster
    5805 Target has a flawless sense of direction
    5806 Target has a flawless sense of direction 50% of the time
    5807 Target has a flawless sense of direction while naked
    5808 Target has a hole in his forehead as large as his fist
    5809 Target has a hole in his torso big enough to accommodate his head
    5810 Target has a key that attracts lightning
    5811 Target has a key that can make non-magical locks invisible
    5812 Target has a key that can permanently fuse one non-magical lock
    5813 Target has a key that locks something that doesnit have a lock
    5814 Target has a key that prevents nearby keys from working properly
    5815 Target has a key that turns one lock to pure, solid gold
    5816 Target has a key that unlocks 99% of all non-magical locks
    5817 Target has a key that unlocks a secret door to another universe
    5818 Target has a key that works only once but will open any one lock
    5819 Target has a large and heavy padlock around his neck
    5820 Target has a large apple stuck in his mouth for 1d4 days
    5821 Target has a legitimate grievance against the caster
    5822 Target has a mane like a lion
    5823 Target has a permanent +4 ToHit and +4 Damage bonus vs the caster
    5824 Target has a permanent -4 ToHit penalty versus others of his race
    5825 Target has a raised, square protuberance jutting from his chest
    5826 Target has a relief of the casteris face embossed on his back
    5827 Target has a scar on his forehead as though clumsily lobotomized
    5828 Target has a secret name that, if spoken, causes him to race home
    5829 Target has a secret name that, if spoken, teleports him 2d8 miles
    5830 Target has a secret name that, if spoken, will change his sex
    5831 Target has a secret name that, if spoken, will kill him outright
    5832 Target has a seizure lasting 1d6 hours when he uses a magic item
    5833 Target has a seizure lasting 8d8 rounds, after which he is Healed
    5834 Target has a seizure lasting until heis struck by magic 
    5835 Target has a small lamp in his forehead like a mineris helmet
    5836 Target has a small lump on his forehead like a horseshoe
    5837 Target has a small steel ring jutting from each shoulder blade
    5838 Target has a star-shaped hole running completely through his head
    5839 Target has a steel band around his ankle like tagged wildlife
    5840 Target has a steel bolt running completely through his head
    5841 Target has a strange tattoo that, if touched, causes him to weep
    5842 Target has a sword that he thinks can command an undead army
    5843 Target has a sword that he thinks can make him invisible to Elves
    5844 Target has a sword that he thinks can slay dragons easily
    5845 Target has a sword that he thinks makes him a charismatic leader
    5846 Target has a tiny compartment beneath one of his fingernails
    5847 Target has a violent coughing fit that persists until sunrise
    5848 Target has a violent coughing fit whenever he uses a magic item
    5849 Target has a virus that will kill him in 4d6 hours unless cured
    5850 Target has a wooden bucket firmly affixed to his head
    5851 Target has an exact copy of everything now carried by the caster
    5852 Target has an immediate 50/50 chance to die or be totally healed
    5853 Target has an immediate 50/50 chance to die or become a demigod
    5854 Target has an immobilizing steel brace on one of his legs
    5855 Target has an overpowering fear of other members of his race
    5856 Target has an overpowering fear of shoes and other footwear
    5857 Target has been controlled for years by a powerful, unseen entity
    5858 Target has been controlled for years by a secret committee
    5859 target has been controlled for years by agents of the king
    5860 Target has been controlled for years by an orbiting satellite
    5861 Target has been targeted for sacrifice by some monstrous cult
    5862 Target has committed unspeakable acts in his deityis name
    5863 Target has committed unspeakable acts in his deityis temple
    5864 Target has committed unspeakable acts involving livestock
    5865 Target has committed unspeakable acts involving orcs and Dwarves
    5866 Target has committed unspeakable acts involving the kingis horse
    5867 Target has his name tattooed all over his body
    5868 Target has in his possession an item that is literally impossible
    5869 Target has in his possession something precious to the caster
    5870 Target has innumerable feathers stuck to his skin
    5871 Target has inspiring hallucinations about his future career
    5872 Target has inspiring hallucinations about his life after death
    5873 Target has ironclad proof that all of this is an illusion
    5874 Target has ironclad proof that everyone he knows doesnit exist
    5875 Target has ironclad proof that heis a prophesied savior
    5876 Target has ironclad proof that heis dead
    5877 Target has ironclad proof that heis really the caster
    5878 Target has ironclad proof that heis the casteris father and son
    5879 Target has ironclad proof that the apocalypse will be tomorrow
    5880 Target has ironclad proof that the caster doesnit exist
    5881 Target has no idea of where he is or what heis doing
    5882 Target has no natural visible form; his appearance is an illusion
    5883 Target has numerous stigmata and attracts countless disciples
    5884 Target has numerous stigmata and fears that the end is nigh
    5885 Target has numerous stigmata and is persecuted as a heretic
    5886 Target has numerous stigmata, as foretold by prophesy
    5887 Target has only one hit point per level for the next 1d4 days
    5888 Target has only one hit point per point of Wisdom for 2d8 days
    5889 Target has owed the caster 1d10 gold pieces for 2d10 years
    5890 Target has prominent mandibles like an ant
    5891 Target has six eyes spaced evenly around his skull
    5892 Target has stolen large sums of money from each of his allies
    5893 Target has terrifying hallucinations about his own birth
    5894 Target has terrifying hallucinations about his own death
    5895 Target has the casteris name tattooed all over his body
    5896 Target has the head and right arm of a common housefly
    5897 Target has three identical faces spaced evenly around his skull
    5898 Target has ugly, thorny projections along both of his arms
    5899 Target has visions depicting the true nature of magic
    5900 Target has visions of a future full of incomprehensible wonders
    5901 Target has visions of a future in which heis worshipped as a god
    5902 Target has visions of a past that seems more real than his own
    5903 Target has visions of a transcendently beautiful city in the sky
    5904 Target has visions of his slow and torturous dismemberment
    5905 Target has visions of the future involving no one he recognizes
    5906 Target has visions of waiting in line for eternity
    5907 Target has waited years for a custom-designed breastplate
    5908 Target hasnit slept in 1d100 days
    5909 Target hasnit slept since he last spoke with royalty
    5910 Target hates his nearest ally as much as his most bitter enemy
    5911 Target hears cheers and applause whenever his blood is drawn
    5912 Target hears his own voice betraying his secrets to everyone
    5913 Target hears his own voice castigating him for his many failures
    5914 Target hears his own voice endlessly chanting his own name
    5915 Target hears his own voice screaming in his ears until sunrise
    5916 Target hears his own voice whispering words of comfort to him
    5917 Target hears malevolent voices all around him
    5918 Target hears the clattering of swords at all times
    5919 Target hears the clattering of swords while his weapon is drawn
    5920 Target hears the crash of cymbals whenever he uses a magic item
    5921 Target hears the noisy buzzing of countless bees at all times
    5922 Target hears thunder booming all around him, but no one else does
    5923 Target hoots like a foghorn when struck by magic after sunset
    5924 Target increases in size and mass by 10%
    5925 Target inflicts superficial wounds upon himself whenever possible
    5926 Target inherits a collection of festive commemorative spoons
    5927 Target insists on wearing a bucket on his head for 1d4 weeks
    5928 Target insists that his body is real and spectacular
    5929 Target inspires homicidal rage in some common non-magical species
    5930 Target is 5% likely to vanish forever each time he says his name
    5931 Target is 10% likely to attack anyone who says his name
    5932 Target is 10% likely to be dragged into orbit around the planet
    5933 Target is 10% likely to change sex when burned by magical fire
    5934 Target is 10% likely to contract leprosy when injured by magic
    5935 Target is 10% likely to lose 1d4 hit points in any given hour
    5936 Target is 10% likely to see any invisible creature or object
    5937 Target is 10% likely to strangle himself whenever he uses rope
    5938 Target is 10% likely to turn to a wooden statue when he sleeps
    5939 Target is 15% likely to be attacked by any horse he passes
    5940 Target is 15% likely to die when he next sees an illusion
    5941 Target is 20% likely to be healed by any poison he drinks
    5942 Target is 20% likely to be healed instead of injured by fire
    5943 Target is 20% likely to disbelieve any illusion he sees
    5944 Target is 20% likely to drown when burned by magical fire
    5945 Target is 20% likely to explode when burned by magical fire
    5946 Target is 20% likely to gain a level when next struck by magic
    5947 Target is 20% likely to take no damage if cut by a blade
    5948 Target is 20% likely to think that heis undead if undead are near
    5949 Target is 20% likely to turn invisible when injured by fire
    5950 Target is 30% likely to be able to summarize any book he kisses
    5951 Target is 40% likely to attack any priest who approaches him
    5952 Target is 80% likely to die if Remove Curse is cast upon him
    5953 Target is a carrier of some magical disease
    5954 Target is at the heart of a thunderstorm, but no one else sees it
    5955 Target is actually a remotely-operated simulacrum
    5956 Target is acutely hungry for 5d6 days, no matter how much he eats
    5957 Target is affected by Reverse Gravity for 1d4 weeks
    5958 Target is afflicted with leprosy for one month, then heis healed
    5959 Target is afflicted with lycanthropy until the next full moon
    5960 Target is an immortal simply masquerading in this current form
    5961 Target is arrested for smuggling some illegal substance
    5962 Target is attacked by 1d1000 tiny skeletal bats
    5963 Target is attacked by 6d12 housecats
    5964 Target is attacked by a monster that no one else can see or hear 
    5965 Target is attacked by dozens of cows
    5966 Target is attacked by dozens of crows
    5967 Target is attacked by everyone within 50 yards
    5968 Target is attacked by moths as if he were made of wool
    5969 Target is attacked by teeming vermin visible only to him
    5970 Target is attacked by the nearest boulder
    5971 Target is blind until he wets his hair
    5972 Target is blind while his hair is wet
    5973 Target is blown back 3d10 yards and loses that many hit points
    5974 Target is bound by fine but very durable silver chains
    5975 Target is briefly blinded by a dense cloud of powdered sugar
    5976 Target is briefly blinded by countless flies swarming around him
    5977 Target is buffeted by mighty winds that affect no one else
    5978 Target is buried by a heap of mildewed potato peelings
    5979 Target is buried by a sudden avalanche; no one else is affected
    5980 Target is buried up to his knees in burning coals
    5981 Target is buried up to his knees in shiny new gold coins
    5982 Target is captured for use in laboratory testing of cosmetics
    5983 Target is carried high into the air by a flock of magpies
    5984 Target is carrying a bucket of chum and must carry it until dawn
    5985 Target is carrying a huge sack full of moldy rabbit pelts
    5986 Target is caught in a violent hailstorm; no one else is affected
    5987 Target is certain that a powerful entity is stalking him
    5988 Target is certain that a vile monster is hiding in a nearby cave
    5989 Target is certain that all of his allies have betrayed him
    5990 Target is certain that he has the patronage of a powerful entity
    5991 Target is certain that he was constructed in a laboratory
    5992 Target is certain that heill become a god if he dies in combat
    5993 Target is certain that heill die by sunset
    5994 Target is certain that heis a plant-based creature
    5995 Target is certain that heis about to become king
    5996 Target is certain that heis as fragile as glass
    5997 Target is certain that heis bleeding profusely
    5998 Target is certain that heis immortal
    5999 Target is certain that heis invulnerable until sunset
    6000 Target is certain that heis standing at the center of a huge fire
    6001 Target is chained into the highest branches of a tall tree nearby
    6002 Target is coated in a delicious honey glaze like a ham
    6003 Target is coated in boiling pitch and takes damage accordingly
    6004 Target is completely enclosed by a layer of living flesh
    6005 Target is constricted as though squeezed by an invisible python
    6006 Target is covered by a suit of field plate armor, made of glass
    6007 Target is covered by a thick shawl of fetid vulture feathers
    6008 Target is covered by coarse and musky wool like a yak
    6009 Target is covered by dozens of slugs and snails
    6010 Target is covered by thick, ugly scales for an AC bonus of 1
    6011 Target is discovered to be a remotely operated machine
    6012 Target is discovered to be an agent of the king
    6013 Target is discovered to be the real heir to the throne
    6014 Target is discovered to be the true owner of casteris home
    6015 Target is discovered to engage in decadent cannibalistic rituals
    6016 Target is dragged along the ground into the nearest open grave
    6017 Target is dragged halfway to the shore of the nearest river
    6018 Target is draped in a gossamer shawl impervious to fire
    6019 Target is draped in filthy funerary dressing
    6020 Target is draped in foul-smelling seaweed
    6021 Target is draped in threads that can only be cut under moonlight
    6022 Target is dreadfully afraid of the spellis target point
    6023 Target is dreadfully homesick for some place heis never been
    6024 Target is dressed like a court jester
    6025 Target is dressed like a crazed anchorite
    6026 Target is dressed like a pig at a luau
    6027 Target is dressed like one of the royal family
    6028 Target is driven halfway through the nearest tree
    6029 Target is driven like a thumbtack into the ground up to his neck
    6030 Target is encased in a glass box quickly filling with water
    6031 Target is encased in a large, hollow sphere of ice
    6032 Target is encased in a marble sarcophagus
    6033 Target is encased in a sealed wicker basket
    6034 Target is encased in a skin-tight plaster cast
    6035 Target is encased in an airtight steel capsule
    6036 Target is encircled by a chest-high wall of packed snow
    6037 Target is encircled by a waist-high, electrified iron fence
    6038 Target is encircled by a zone of intense cold
    6039 Target is encircled by a zone of pure vacuum
    6040 Target is encircled by an electrified fence
    6041 Target is encircled by an illusory wall of chattering skulls
    6042 Target is encircled by tall icicles, each as thick as his leg
    6043 Target is enclosed for one hour in an impenetrable 10-foot sphere
    6044 Target is enclosed in a shrinking steel cage
    6045 Target is enraged beyond all rational control
    6046 Target is ensconced in velvet
    6047 Target is ensnared by some distant spellcasteris Summoning spell
    6048 Target is especially receptive to Commands for the next 24 hours
    6049 Target is fearless as long as he wears the shoes heis wearing now
    6050 Target is forever immune to all non-magical disease
    6051 Target is forever immune to heatstroke
    6052 Target is forever immune to hypothermia
    6053 Target is forever immune to lycanthropy
    6054 Target is found to be a persecuted victim needing casteris help
    6055 Target is fully healed if heis slain while standing in snow
    6056 Target is harassed by skeletal crows
    6057 Target is haunted by the endless screams of damned souls
    6058 Target is healed of all damage, but his clothes and gear vanish
    6059 Target is held personally responsible for some distant atrocity
    6060 Target is held personally responsible for the decay of society
    6061 Target is highly magical and dies if Dispel Magic is cast on him
    6062 Target is highly magical and is quickly recognized by magic users
    6063 Target is holding an anvil and canit put it down for 2d8 rounds
    6064 Target is holding an egg in each hand and must not break them!
    6065 Target is hopelessly lost for 2d10 rounds
    6066 Target is horribly afraid of cooked or salted meat
    6067 Target is horribly scarred, as though shredded and reassembled
    6068 Target is horrified by the sight of female magic users
    6069 Target is horrified by the sound of clattering bones
    6070 Target is identified as the leader of some bizarre cult
    6071 Target is immortal and unaging until he next speaks
    6072 Target is immortal, but heis sentenced to lifelong imprisonment
    6073 Target is immortal, but his arms and legs vanish forever
    6074 Target is immune to air-based magic for 1d4 days
    6075 Target is immune to all attacks by non-magical birds
    6076 Target is immune to all injury until he next speaks
    6077 Target is immune to all swords now within one mile
    6078 Target is immune to any wounds inflicted by humans for 4d6 hours
    6079 Target is immune to area-effect magic for 1d4 days
    6080 Target is immune to beneficial magic for 2d4 days
    6081 Target is immune to charm-based spells or attacks for 1d4 weeks
    6082 Target is immune to Charms and Enchantments for 1d4 weeks
    6083 Target is immune to electrical attacks while carrying metal
    6084 Target is immune to his alliesi magic
    6085 Target is immune to his alliesi magic for 10d10 rounds
    6086 Target is immune to his own magic and attacks for 1d4 hours
    6087 Target is immune to hostile magic for 1d4 days
    6088 Target is immune to illusions until dawn tomorrow
    6089 Target is immune to injuries inflicted by wood in daylight
    6090 Target is immune to inorganic poisons for 1d4 months
    6091 Target is immune to light-based magic until sunset tomorrow
    6092 Target is immune to lightning
    6093 Target is immune to magical cold while naked
    6094 Target is immune to magical diseases for one week 
    6095 Target is immune to magical fire while naked
    6096 Target is immune to magical healing
    6097 Target is immune to missile weapons for 6d8 hours
    6098 Target is immune to necromantic magic until he uses a magic item
    6099 Target is immune to non-magical diseases
    6100 Target is immune to non-magical extremes of weather
    6101 Target is immune to normal fire while wearing these clothes
    6102 Target is immune to piercing weapons, such as stilettos, etc.
    6103 Target is immune to poisons, but meat is highly toxic to him
    6104 Target is immune to polymorph magic
    6105 Target is immune to smoke inhalation for the rest of his life
    6106 Target is immune to the burning effects of acid for 2d4 days
    6107 Target is immune to the casteris magic for 10d10 rounds
    6108 Target is immune to the crushing pressure of very deep water
    6109 Target is immune to the next 1d10 attacks against him
    6110 Target is immune to the next magical disease he encounters
    6111 Target is implicated in numerous treasonous scandals
    6112 Target is in the middle of a typhoon, but no one else is
    6113 Target is infected with plague
    6114 Target is instantly consumed by vermin if he dies within 24 hours
    6115 Target is intensely drunk for 1d4 rounds after every combat
    6116 Target is invisible to lycanthropes while heis bleeding
    6117 Target is invisible to lycanthropes while theyire indoors
    6118 Target is invisible while carrying 1d4 burning torches
    6119 Target is invisible while completely submerged
    6120 Target is invisible while he has an apple in each hand
    6121 Target is invisible while shouting
    6122 Target is invulnerable and invisible until he speaks or moves
    6123 Target is invulnerable to 80% of normal weapons
    6124 Target is invulnerable to any weapon that has already wounded him
    6125 Target is invulnerable to normal weapons and canit wield them
    6126 Target is invulnerable to normal weapons for 1d6 turns
    6127 Target is invulnerable to normal weapons until he inflicts damage
    6128 Target is invulnerable to normal weapons until he wields one
    6129 Target is invulnerable to weapon that he himself forged
    6130 Target is kidnapped to be used as a sacrifice by a religious cult
    6131 Target is kidnapped to be used as in medical experiments
    6132 Target is killed outright if he ever triggers a Chaos Burst
    6133 Target is killed outright if he kills any member of his species
    6134 Target is killed outright if he wounds himself with a sword
    6135 Target is killed outright if struck by a blood relative
    6136 Target is limned by golden light until dawn tomorrow
    6137 Target is liquefied and emerges from a nearby lake fully healed
    6138 Target is liquefied but reforms at full hit points in 1d20 rounds
    6139 Target is liquefied but reforms in a slightly warped shape
    6140 Target is liquefied but returns fully healed during the next rain
    6141 Target is lost in the shuffle
    6142 Target is mesmerized by the sight of lighted candles
    6143 Target is mesmerized by the sound of clinking metal
    6144 Target is nearly paralyzed with terror under the full moon
    6145 Target is now standing 8d10 yards behind the spellis target point
    6146 Target is now standing atop the tallest mountain within 100 miles
    6147 Target is numb to all physical sensation for 3d8 rounds
    6148 Target is obsessed with ridding himself of all skin and hair
    6149 Target is obsessed with ridding himself of all worldly property
    6150 Target is obsessed with ridding himself of his allies
    6151 Target is obsessed with ridding himself of his shadow
    6152 Target is obsessively covetous of some item that he can now see
    6153 Target is obsessively jealous of someone now standing nearby
    6154 Target is obsessively protective of someone now standing nearby
    6155 Target is obsessively protective someone heis never met
    6156 Target is overwhelmingly drunk for 1d4 rounds, then totally sober
    6157 Target is paralyzed by dread when he witnesses magical effects
    6158 Target is pelted by hundreds of acorns
    6159 Target is pelted by snowballs for 1d6 rounds
    6160 Target is pelted by tiny, red hot coals for 1d4 rounds
    6161 Target is pelted like a mink, otter, or beaver
    6162 Target is permanently bloodstained
    6163 Target is permanently invisible to caster but canit attack him
    6164 Target is permanently invisible to himself between dusk and dawn
    6165 Target is permanently rendered 1d100% transparent
    6166 Target is physically exhausted
    6167 Target is poisoned if he touches a book in the next 1d4 days
    6168 Target is pursued by predatory moneylenders
    6169 Target is pursued by ravenous wolves
    6170 Target is pursued by rogue shadows that resemble his own
    6171 Target is pushed through the planet and out to the opposite side
    6172 Target is quarantined by the local Minister of Health
    6173 Target is real but can be disbelieved as if he were an illusion
    6174 Target is real but can be Dispelled as if he were an illusion
    6175 Target is recognized as an escaped slave wherever he goes
    6176 Target is reluctant to engage in combat between sunrise and noon
    6177 Target is reluctant to speak between noon and sunset
    6178 Target is reluctant to wield any weapon with inorganic components
    6179 Target is rendered deaf and blind for 2d10 rounds
    6180 Target is rendered inert for 1d10 turns
    6181 Target is rendered like a cow in an abattoir
    6182 Target is rendered mute for 1d100 rounds
    6183 Target is scarred as though he were pressed against a hot screen
    6184 Target is scarred as though his digestive tract has been removed
    6185 Target is sheathed in a large, living sponge
    6186 Target is sheathed in a plant like a huge pea pod
    6187 Target is sheathed in blood-soaked strips of leather
    6188 Target is sheathed in wax
    6189 Target is shoved to the ground in each of the next 1d10 rounds
    6190 Target is showered by sawdust for 1d10 rounds
    6191 Target is showered by shaved ice for the next 1d10 rounds
    6192 Target is shunned by all other members of his species
    6193 Target is shunned by all that is holy
    6194 Target is shunned by anyone carrying a magic item
    6195 Target is shunned by anyone nearby who is now wounded
    6196 Target is shunned by polite society
    6197 Target is smeared in a coordinated campaign of personal attacks
    6198 Target is smeared in a fluid that suppresses his natural scent
    6199 Target is smeared in lard
    6200 Target is smeared in some kind of fireproof jelly
    6201 Target is so badly disfigured that people flee from him in horror
    6202 Target is sought for arrest because he stole a loaf of bread
    6203 Target is standing knee-deep in a basket full of cobras
    6204 Target is standing knee-deep in a bucket full of manure
    6205 Target is stricken completely hairless
    6206 Target is stricken deaf, blind, and mute for 1d6 rounds
    6207 Target is stricken from any documents that mention him by name
    6208 Target is stricken mute under every full moon
    6209 Target is stricken mute while horses are nearby
    6210 Target is stricken mute while under any magical effect
    6211 Target is struck by lightning for 1d100 hit points of damage
    6212 Target is struck by lightning the next time an ally is wounded
    6213 Target is struck by lightning the next time he draws a weapon
    6214 Target is struck by lightning the next time he enters water
    6215 Target is struck by lightning the next time he speaks
    6216 Target is struck by lightning the next time he uses a magic item
    6217 Target is struck by lightning unless heis currently atop a horse
    6218 Target is stung by a bee as large as an ox
    6219 Target is stung by a bee every time he makes a successful attack
    6220 Target is suddenly acutely aware of any injuries he now has
    6221 Target is suddenly attacked by ruffians
    6222 Target is suddenly holding 1d4 anvils
    6223 Target is suddenly holding a box full of his own bones
    6224 Target is suddenly holding a pair of alligator suitcases 
    6225 Target is suddenly holding a pair of magic rings
    6226 Target is suddenly holding an enormous bouquet of roses
    6227 Target is suddenly holding the kingis severed head
    6228 Target is suddenly holding the nearest corpse in his arms
    6229 Target is suddenly lying in a four-poster canopy bed
    6230 Target is suddenly lying in his own bed
    6231 Target is suddenly lying on a funeral pyre
    6232 Target is suddenly married to 1d8 additional spouses
    6233 Target is suddenly morbidly obese
    6234 Target is suddenly naked except for a fig leaf
    6235 Target is suddenly on the verge of an important breakthrough
    6236 Target is suddenly on the verge of going berserk
    6237 Target is suddenly on the verge of utter dehydration
    6238 Target is suddenly on the verge of utter exhaustion
    6239 Target is suddenly on the verge of utter panic
    6240 Target is suddenly on the verge of utter starvation
    6241 Target is suddenly packaged in a large cardboard box
    6242 Target is suddenly recognized as everyoneis long-lost brother
    6243 Target is suddenly sitting at the base of a nearby waterfall
    6244 Target is suddenly sitting atop someone elseis horse
    6245 Target is suddenly sitting atop the tallest waterfall in the land
    6246 Target is suddenly sitting in a bucket full of ice water
    6247 Target is suddenly sitting in a large wooden crate
    6248 Target is suddenly sitting in the bucket of the nearest catapult
    6249 Target is suddenly sitting in the queenis boudoir
    6250 Target is suddenly sitting on an anthill, smeared with honey
    6251 Target is suddenly sitting on the corpse of a fallen ally
    6252 Target is suddenly standing atop a heap of shattered masonry
    6253 Target is suddenly standing atop a rickety and very tall fence
    6254 Target is suddenly standing atop a tall ladder
    6255 Target is suddenly standing atop the nearest corpse
    6256 Target is suddenly standing atop the nearest lookout tower
    6257 Target is suddenly standing atop the nearest sand dune
    6258 Target is suddenly standing in a fetid swamp miles from here
    6259 Target is suddenly standing in the nearest boat
    6260 Target is suddenly standing in the nearest locked treasure vault
    6261 Target is suddenly standing knee-deep in the nearest ocean
    6262 Target is suddenly standing next to his most powerful enemy
    6263 Target is suddenly standing on a trapdoor over a very deep pit
    6264 Target is suddenly standing on the shoulders of a nearby ally
    6265 Target is suddenly standing outside his own front door
    6266 Target is suddenly standing under the nearest bridge
    6267 Target is suddenly standing upon what appears to be his own grave
    6268 Target is suddenly standing wherever he awoke this morning
    6269 Target is suddenly suffering from overpowering agoraphobia
    6270 Target is suddenly wearing a cast-iron straightjacket
    6271 Target is suddenly wearing a provocative leather ensemble
    6272 Target is suddenly wearing a skin-tight suit of chain mail
    6273 Target is suddenly wearing an anachronistic bathing costume
    6274 Target is suddenly wearing an ornate saddle of very high quality
    6275 Target is suddenly wearing fireproof clothing
    6276 Target is suddenly wearing whatever the king wore yesterday
    6277 Target is surrounded by pandering sycophants
    6278 Target is surrounded by rabid wolves
    6279 Target is surrounded by servitors who want to assassinate him
    6280 Target is surrounded by vermin and small pests
    6281 Target is susceptible to rust while carrying gold
    6282 Target is suspected of having trafficked with demons in a church
    6283 Target is suspected of having wrought a plague upon this nation
    6284 Target is suspected of holding the secret of all existence
    6285 Target is suspected of plotting to exterminate his entire species
    6286 Target is suspended above the tallest tree nearby
    6287 Target is suspended over a flaming pit until sunset
    6288 Target is swarmed by countless flies, but they donit bother him
    6289 Target is swarmed by undead whenever he uses a magic item
    6290 Target is swept 3d100 yards by a wave of molasses
    6291 Target is the most unrepentant coward in the entire world
    6292 Target is the subject of a distant beingis use of the Wish spell
    6293 Target is thought to be a malefic figure as foretold by prophecy
    6294 Target is thrown 1d4 rounds into the past
    6295 Target is thrown 8d6 hours into the future
    6296 Target is thrown 8d6 yards into the air
    6297 Target is thrown down the nearest flight of stairs
    6298 Target is thrown into a coma for 1d6 days
    6299 Target is thrown into the nearest briar patch
    6300 Target is tied between two trees like a hammock
    6301 Target is tied to the ground with rope made of his own hair
    6302 Target is tightly bound by strips of adhesive cloth
    6303 Target is tightly chained to the nearest tree
    6304 Target is tightly swaddled in a coarse wool blanket
    6305 Target is tightly wrapped in blood-soaked bandages
    6306 Target is tightly wrapped in strips of raw and greasy bacon
    6307 Target is tormented by countless demonic voices
    6308 Target is tormented by false but realistic echoes of a past life
    6309 Target is tormented by illusory ants crawling all over him
    6310 Target is tormented by invisible barbs that catch in his flesh
    6311 Target is tormented by shrill and discordant music
    6312 Target is tormented by the awareness of his mortality
    6313 Target is tormented by visions of his own damnation
    6314 Target is tormented by visions of his own descent into madness
    6315 Target is tormented by visions of the damned
    6316 Target is tormented by visions of the torture of his allies
    6317 Target is tormented by voices telling him to kill his allies
    6318 Target is tormented by voices telling him to kill the king
    6319 Target is unable to look directly at the caster
    6320 Target is unaffected by natural winds
    6321 Target is unexpectedly thrust into a position of political power
    6322 Target is unusually clumsy for 1d4 hours after he says his name
    6323 Target is utterly fearless until sunset tomorrow
    6324 Target is violently allergic to some common non-magical species
    6325 Target is violently compressed to the size of a grain of rice
    6326 Target is violently pushed 1d10 yards, stunned for as many rounds
    6327 Target is wearing a diveris mask, snorkel, and swim fins
    6328 Target is wearing a formal suit made entirely of lettuce
    6329 Target is wearing a formal suit made entirely of smoked meats
    6330 Target is wearing a necklace of severed human ears
    6331 Target is wearing nothing but strategically-placed coconut shells
    6332 Target is wearing the entire skin from an orc or goblin
    6333 Target is wearing the leathered skin from his own corpse
    6334 Target is wholly invulnerable for 1d4 rounds
    6335 Target is widely famed for his prowess with the scissors
    6336 Target is widely recognized as a traitor to his race and species
    6337 Target is, by his very nature, impossible
    6338 Target jingles like sleigh bells while trying to move stealthily
    6339 Target kills himself at sunset tonight but is resurrected at dawn
    6340 Target knows a secret that damages the sanity of any who learn it
    6341 Target knows an economical way to extract aluminum from bauxite
    6342 Target knows but wonit tell the location of an important artifact
    6343 Target knows everything there is to know about the caster
    6344 Target knows exactly what will happen in the next 2d6 rounds
    6345 Target knows the current location of every Dwarf within 10 miles
    6346 Target knows the location of every lock within one mile
    6347 Target labors to conceal a humiliating secret from his allies
    6348 Target lacks any concept of personal property
    6349 Target laughs like a braying donkey when he injures someone
    6350 Target laughs outrageously at the sight of his alliesi blood
    6351 Target learns that a deranged cult worships him as a god
    6352 Target leaves no scent for 1d4 weeks
    6353 Target leeches 2d10 hit points from the caster
    6354 Target levitates 10d10 yards into the air for that many rounds 
    6355 Target levitates 1d10 feet in each of the next 1d6 rounds
    6356 Target literally laughs at danger, so much so that itis annoying
    6357 Target looks as though half of his body has been severely burned
    6358 Target looks as though half of his body is made of pumice
    6359 Target looks as though half of his body is made of wood
    6360 Target looks as though heis made entirely of clay
    6361 Target looks exactly like the caster for 1d4 days
    6362 Target looks like a photo-negative for 1d4 days
    6363 Target looks like a photo-negative while wielding a weapon
    6364 Target looks vaguely demonic whenever he uses a magic item
    6365 Target loses 1d100 hit points if he speaks his name before sunset
    6366 Target loses 1d100 hit points unless he eats 3lbs of gold by dawn
    6367 Target loses 1d100% of his mass
    6368 Target loses 1d4 hit points every time he draws a weapon
    6369 Target loses 1d4 levels/hit dice
    6370 Target loses a point of Intelligence for each hit point he loses
    6371 Target loses all but one hit point, then regains one per round
    6372 Target loses all hit points gained due to high Constitution
    6373 Target loses all sense of decency and restraint
    6374 Target loses half of his remaining hit points
    6375 Target loses one hit point each day for the next 1d100 days
    6376 Target loses one hit point per hour until dawn tomorrow
    6377 Target loses one hit point per person now within a 10 yard radius
    6378 Target loses one hit point per round until he eats some raw meat
    6379 Target loses one hit point per round until he strips naked
    6380 Target loses one hit point per round until he swallows a coin
    6381 Target loses one hit point per round until heis struck by magic
    6382 Target loses the sense of object permanence
    6383 Target makes a spirited effort to detach one of his legs
    6384 Target makes a spirited effort to disarm his allies
    6385 Target makes a spirited effort to eat his own foot
    6386 Target makes a spirited effort to extract his own heart
    6387 Target makes a spirited effort to pull out his own tongue
    6388 Target makes a spirited effort to remove his lower jaw
    6389 Target makes a spirited effort to scour the flesh from his hands
    6390 Target makes a spirited effort to swallow his weapon
    6391 Target makes a spirited effort to tear off his ears
    6392 Target makes outrageous claims about his martial skill
    6393 Target makes outrageous claims about his wealth and property
    6394 Target mimics the actions of one of his allies for 2d6 rounds
    6395 Target mimics the casteris actions for 1d10 rounds
    6396 Target mistakes himself for someone else
    6397 Target moos like a cow each time he draws a weapon
    6398 Target must carry a blade at all times that has never drawn blood
    6399 Target must carry a burning candle at all times
    6400 Target must carry a fifty pound wheel of cheese until sunset
    6401 Target must carry a small stone from this spot at all times
    6402 Target must carry a wooden staff taller than he is at all times
    6403 Target must carry at least 30 feet of rope at all times
    6404 Target must carry at least 4d6 gold coins at all times
    6405 Target must carry at least five pounds of wood at all times
    6406 Target must carry at least one pound of feathers at all times
    6407 Target must climb a tall tree during the next thunderstorm
    6408 Target must disrobe before entering any cave or mine
    6409 Target must douse himself with 2d6 gallons of water or combust
    6410 Target must draw his weapon every time he says his name
    6411 Target must drink 2d4 gallons of water before sunset
    6412 Target must eat 3d6 pounds of food before dawn tomorrow
    6413 Target must eat a pound of grass or leaves before dawn
    6414 Target must eat a pound of ice by sunset tonight
    6415 Target must give his name whenever heis asked for it
    6416 Target must lie whenever heis asked his name
    6417 Target must re-roll any attribute scores that are higher than 15
    6418 Target must re-roll any attribute scores that are lower than 12
    6419 Target must return to this location at least once each month
    6420 Target must Save at each sunset or forget what happened that day
    6421 Target must Save each morning or be ethereal until dusk
    6422 Target must Save each morning or shrink by 10%
    6423 Target must Save each morning, or he canit use his arms that day
    6424 Target must Save each morning, or his left leg bursts into flame
    6425 Target must Save each night or else sleep for 6d8+24 hours
    6426 Target must Save or 1d100 of his bones explode
    6427 Target must Save or 1d100 of his bones turn to glass
    6428 Target must Save or 1d100 of his bones turn to steel
    6429 Target must Save or be dragged to the bottom of the nearest lake
    6430 Target must Save or be struck dead by a meteor
    6431 Target must Save or each of his bones teleports 1d4 miles
    6432 Target must Save or forfeit ownership of all of his possessions
    6433 Target must Save or he beheads himself with his next attack
    6434 Target must Save or he will never have existed
    6435 Target must Save or his hands and weapons vanish until sunset
    6436 Target must Save or his temperature rises 1° per round
    6437 Target must Save or lose 1d4 from each attribute score
    6438 Target must Save when heis hit by a bludgeon or shatter
    6439 Target must Save when heis hit by a bludgeon or shriek in panic
    6440 Target must Save when heis hit by a bludgeon or turn inside out
    6441 Target must Save when heis hit by a bludgeon or turn to butter
    6442 Target must say his name every time he draws a weapon
    6443 Target must scale the tallest mountain within 100 miles
    6444 Target must take 1d10 steps backward each time he draws a weapon
    6445 Target now has 1d12 x 10% of his full hit points
    6446 Target now has an odd number of limbs
    6447 Target now has three legs spaced evenly around his pelvis
    6448 Target obsessively cleans and polishes any magical items he owns
    6449 Target obsessively pursues a man who turns into a green monster
    6450 Target obsessively pursues an immortal beast with glass eyes
    6451 Target obsessively pursues some crazy get-rich-quick scheme
    6452 Target obsessively pursues the one-armed man who killed his wife
    6453 Target offered his legs as collateral on a high-interest loan
    6454 Target only needs to blink once every 4d6 hours
    6455 Target only needs to eat one normal-sized meal per week
    6456 Target opens a chain of big-box retail stores
    6457 Target owes a big favor to a powerful and malevolent entity
    6458 Target owes a big favor to someone to whom heis morally opposed
    6459 Target perceives a vast army to be just beyond the nearest ridge
    6460 Target perceives aggressive creditors to be hunting him endlessly
    6461 Target perceives all foliage to be ablaze
    6462 Target perceives constant rainfall from now on
    6463 Target perceives everyone nearby to be sheathed in golden flame
    6464 Target perceives everyone nearby to be sprouting peacock feathers
    6465 Target perceives everyone nearby to look just like him
    6466 Target perceives everything except himself to be 50% larger
    6467 Target perceives everything nearby to be aligned against him
    6468 Target perceives everything nearby to made of gold
    6469 Target perceives everything to be blighted and drained of color
    6470 Target perceives himself to be bathed in silver light
    6471 Target perceives himself to be the wealthiest person in the world
    6472 Target perceives hints of prophecy in any music he hears
    6473 Target perceives menacing waterfowl all around him
    6474 Target perceives profound secrets in everyday conversation
    6475 Target perceives shocking insults in everyday conversation
    6476 Target perceives weather conditions to be six months out of sync
    6477 Target perceives worms to be wriggling from his every orifice
    6478 Target permanently abandons his principal weapon
    6479 Target permanently ages one year for each hit point he loses
    6480 Target permanently gains 1d4 hit points
    6481 Target permanently loses 1d10 toes
    6482 Target permanently loses 1d4 hit points
    6483 Target permanently loses half his current hit points
    6484 Target poses and spits water like a fountain for one turn 
    6485 Target presents a long list of grievances to the caster
    6486 Target pretends that he has a personal relationship with his god
    6487 Target pretends that heis been Charmed by the caster
    6488 Target punches his jaw repeatedly until he knocks himself out
    6489 Target quickly regenerates any lost fingers or toes
    6490 Target races away in a random direction and canit stop until dawn
    6491 Target races headlong toward any magic user he encounters
    6492 Target races to the nearest cave and hides there
    6493 Target races to the nearest cave entrance
    6494 Target races to the nearest library and tries to burn it down
    6495 Target races to the nearest temple and messily desecrates it
    6496 Target races toward his home at top speed
    6497 Target races toward the caster and begs to be killed
    6498 Target races toward the caster, embraces him, & vanishes with him
    6499 Target races toward the nearest lake and jumps into it
    6500 Target races toward the nearest monarch and attacks him
    6501 Target races toward the nearest ocean and wades out 1d4 miles
    6502 Target races toward the nearest open fire and jumps into it
    6503 Target races toward the nearest open pit and jumps into it
    6504 Target rattles like a bucket of stones while moving with stealth
    6505 Target reacts violently to any representative of the king
    6506 Target reacts violently to anyone bearing a scar on his face
    6507 Target reacts violently to anyone bearing a tattoo
    6508 Target reacts violently to anyone displaying a holy symbol
    6509 Target reacts violently to anyone he sees who is now injured
    6510 Target reacts violently to anyone he thinks is able to kill him
    6511 Target reacts violently to anyone nearby when he awakens
    6512 Target reacts violently to anyone not of his race
    6513 Target reacts violently to anyone not wearing a hat
    6514 Target reacts violently to anyone refusing to address him as sire
    6515 Target reacts violently to anyone representing a deity
    6516 Target reacts violently to anyone taller than he is
    6517 Target reacts violently to anyone wearing a cloak
    6518 Target reacts violently to anyone wearing a gold ring
    6519 Target reacts violently to anyone wearing a hat or helmet
    6520 Target reacts violently to anyone wearing leather
    6521 Target reacts violently to anyone who addresses him by name
    6522 Target reacts violently to anyone who addresses the caster
    6523 Target reacts violently to anyone who asks his name
    6524 Target reacts violently to anyone who attacks the caster
    6525 Target reacts violently to anyone who carries an axe
    6526 Target reacts violently to anyone who displays fear or pity
    6527 Target reacts violently to anyone who displays the color red
    6528 Target reacts violently to anyone who doesnit offer him money
    6529 Target reacts violently to anyone who doesnit recognize him
    6530 Target reacts violently to anyone who draws a weapon near him
    6531 Target reacts violently to anyone who eats in front of him
    6532 Target reacts violently to anyone who eats meat in his presence
    6533 Target reacts violently to anyone who gives him an order
    6534 Target reacts violently to anyone who has a beard
    6535 Target reacts violently to anyone who has long hair
    6536 Target reacts violently to anyone who has no beard
    6537 Target reacts violently to anyone who lights a fire near him
    6538 Target reacts violently to anyone who mentions a deity by name
    6539 Target reacts violently to anyone who mentions his martial skill
    6540 Target reacts violently to anyone who offers him aid in battle
    6541 Target reacts violently to anyone who offers him food or water
    6542 Target reacts violently to anyone who offers him hospitality
    6543 Target reacts violently to anyone who offers him money
    6544 Target reacts violently to anyone who questions his bravery
    6545 Target reacts violently to anyone who receives magical healing
    6546 Target reacts violently to anyone who refuses to give him money
    6547 Target reacts violently to anyone who refuses to worship him
    6548 Target reacts violently to anyone who says a magic word near him
    6549 Target reacts violently to anyone who seems to have a magic item
    6550 Target reacts violently to anyone who sees him get injured
    6551 Target reacts violently to anyone who shows him common courtesy
    6552 Target reacts violently to anyone who speaks while on horseback
    6553 Target reacts violently to anyone who speaks with an accent
    6554 Target reacts violently to anyone who spends money on armor
    6555 Target reacts violently to anyone who suggests that heis mortal
    6556 Target reacts violently to anyone who touches him
    6557 Target reacts violently to anyone who uses magic
    6558 Target reacts violently to anyone who wears jewelry
    6559 Target reacts violently to anyone who wields a magical weapon
    6560 Target reacts violently to anyone whom he perceives to be ill
    6561 Target reacts violently to anyone wielding a bloodstained weapon
    6562 Target reacts violently to anyone wielding a wooden bludgeon
    6563 Target reacts violently to anyone with bloodstained clothes
    6564 Target reacts violently to Elves who learn his name
    6565 Target reacts violently to the next person to draw blood near him
    6566 Target realizes that has an extra eye in the back of his head
    6567 Target realizes that he murdered 1d10 people closest to him
    6568 Target realizes that heis a mechanical simulacrum
    6569 Target realizes that heis always been a ravenous cannibal
    6570 Target realizes that heis been chewing on gravel for several days
    6571 Target realizes that heis being controlled by invisible entities
    6572 Target realizes that heis had an arrow in his thigh for days
    6573 Target realizes that heis lost and doesnit know anyone nearby
    6574 Target realizes that the back of his head is removable
    6575 Target receives a massive shock the next time he touches metal
    6576 Target receives a sign that he should abandon all worldly goods
    6577 Target receives a sign that he should devote himself to magic
    6578 Target receives a sign that he should reject all magic
    6579 Target receives a sign that his murder is imminent
    6580 Target reeks of carrion when heis angry
    6581 Target reeks of cheap perfume between sunset and dawn
    6582 Target reeks of chlorine while he speaks
    6583 Target reeks of gasoline for the rest of his life
    6584 Target reeks of manure while in polite company
    6585 Target reflection appears in every mirror within 10 miles
    6586 Target refuses any offers of first aid or magical healing
    6587 Target refuses to believe that metal weapons can harm him
    6588 Target refuses to believe that poisons are poisonous
    6589 Target refuses to believe that the caster exists
    6590 Target refuses to eat any cooked meat
    6591 Target refuses to eat or sleep for 2d4-1 days
    6592 Target refuses to eat until his magical sword is returned
    6593 Target refuses to eat within 6d10 miles of this spot
    6594 Target refuses to give medical aid to his allies
    6595 Target refuses to share food or water with his allies
    6596 Target refuses to speak his native tongue while outdoors
    6597 Target refuses to speak to anyone at all for 1d8 days
    6598 Target refuses to speak to anyone not of his race
    6599 Target refuses to speak to anyone of his race
    6600 Target refuses to speak to anyone who addresses him by name
    6601 Target refuses to speak to anyone who is looking at him
    6602 Target refuses to speak to anyone who shares his native tongue
    6603 Target refuses to speak to anyone whom he knows to employ magic
    6604 Target regains his full hit points in each of the next 1d8 rounds
    6605 Target regenerates one hit point for each pint of blood he drinks
    6606 Target regresses to infancy but quickly grows to his correct age
    6607 Target re-rolls 1d4 of his attribute scores, using 2d10
    6608 Target re-rolls his hit points
    6609 Target retains a perfect memory of the next 4d12 hours
    6610 Target rightly believes that everyone is trying to kill him
    6611 Target roars like a lion whenever he sees food
    6612 Target runs 1d4 miles at top speed in a random direction
    6613 Target runs completely around the nearest lake
    6614 Target salivates heavily during battle 
    6615 Target screams as though in agony for 1d4 hours
    6616 Target secretes 10 gallons of foul brine over the next 1d8 turns
    6617 Target secretes a sticky pus from his eyes, nose, and ears
    6618 Target sees anything more than 20 yards away as dull gray
    6619 Target sees spectacular lightning overhead, but no one else does
    6620 Target shakes violently when attempting to use magic items
    6621 Target shakes violently while touching magic items
    6622 Target shimmers like a desert mirage, making him -1 ToHit
    6623 Target shrinks by 25% during each of the next 1d10 days
    6624 Target shrinks by 8d10% when he next attacks the caster
    6625 Target single-mindedly attacks the tallest person he can see
    6626 Target single-mindedly tries to kill the caster until one is dead
    6627 Target sinks halfway to the center of the world
    6628 Target smells like 1,000 roses whenever he uses a magic item
    6629 Target smells like 10 corpses whenever he uses a magic item
    6630 Target smells like fungus for 1d4 hours after every battle
    6631 Target smells like roses for one hour after every battle
    6632 Target smells rotting flesh everywhere for 1d4 weeks
    6633 Target smells strongly of blood whenever he uses a magic item
    6634 Target smells strongly of cabbage until his next birthday
    6635 Target smells strongly of sauerkraut for the rest of his life
    6636 Target smells strongly of sour milk until next wounded in battle
    6637 Target smells strongly of vanilla for 2d4 days
    6638 Target sneezes and 10d10 angry wasps spew from his nose
    6639 Target sneezes and blows 1d4 pounds of iron filings from his nose
    6640 Target sneezes and blows all of his teeth from his mouth
    6641 Target snorts like a pig before and after he says his name
    6642 Target sounds as though heis shouting through a distant megaphone
    6643 Target speaks only in an archaic dialect of his native language
    6644 Target spends 1d4 rounds obsessing over the impact of his actions
    6645 Target spends 1d4 turns trying to fell a tree with his bare hands
    6646 Target spends 2d4 rounds trying to remove one of his vital organs
    6647 Target spends 2d8 rounds praising the caster for his magic skills
    6648 Target spends a few rounds trying to convince himself heis dead
    6649 Target spends a few rounds trying to unscrew his own head
    6650 Target spends all of his money to buy something totally worthless
    6651 Target spins a cocoon & emerges in 1d4 days with butterfly wings
    6652 Target spins like a top for 1d8 rounds
    6653 Target spits out small lumps of coal after any melee
    6654 Target sprays a gallon of milk from his nose
    6655 Target sprays a huge gout of jet-black ink from his nose
    6656 Target sprouts 1d10 additional noses all over his body
    6657 Target sprouts 1d10 fingers from his cheeks
    6658 Target sprouts 1d10 pairs of delicate antennae
    6659 Target sprouts 1d100 additional ears on his body
    6660 Target sprouts 1d6 additional noses somewhere on his body
    6661 Target sprouts 3d10 tufts of coarse, ugly hair on his body
    6662 Target sprouts a bunch of flexible metal tines on his face
    6663 Target sprouts a clumsy elephantis trunk at the back of his head
    6664 Target sprouts a collar of holly from the skin of his neck
    6665 Target sprouts a horseis tail from the center of his chest
    6666 Target sprouts a long, prehensile tail from his chest
    6667 Target sprouts a non-functional face between his shoulder blades
    6668 Target sprouts a non-functioning hand from the top of his head
    6669 Target sprouts a pair of compound eyes from his cheekbones
    6670 Target sprouts a pair of loathsome tentacles from his forehead
    6671 Target sprouts a pair of retractable fangs in each palm
    6672 Target sprouts a pigis tail from between his eyes
    6673 Target sprouts a small foot from the top of his head
    6674 Target sprouts a torch sconce between his shoulder blades
    6675 Target sprouts a vultureis wing between his shoulder blades
    6676 Target sprouts an additional foot from each knee
    6677 Target sprouts an additional foot from each shoulder
    6678 Target sprouts an additional forearm and hand from one elbow
    6679 Target sprouts an additional hand from each shoulder
    6680 Target sprouts an additional hand from one of his arms
    6681 Target sprouts an additional hand from the palm of one hand
    6682 Target sprouts an additional head beside the existing one
    6683 Target sprouts an additional limb
    6684 Target sprouts an additional mouth next to his original one
    6685 Target sprouts an additional pair of eyes on his forehead
    6686 Target sprouts an additional pair of nostrils on his forehead
    6687 Target sprouts an additional pair of thumbs on his forehead
    6688 Target sprouts an additional thumb from the back of each hand
    6689 Target sprouts an iguanais tail from his chin
    6690 Target sprouts an intelligent fungus atop his head
    6691 Target sprouts an ox horn from his chin
    6692 Target sprouts an ox horn from one side of his head
    6693 Target sprouts countless leaves, each bearing a mysterious rune
    6694 Target sprouts deer antlers from his shoulder blades
    6695 Target sprouts enormous fangs from his lower jaw
    6696 Target sprouts harmless but acrid blue mold all over his body
    6697 Target sprouts retractable iron claws from his fingers
    6698 Target sprouts small, flashing lights along his spine
    6699 Target sprouts wool like a sheep
    6700 Target stalks the caster, always at least one mile distant
    6701 Target steals credit for writing a list of 7,000 random effects
    6702 Target stretches into an upright "X" for 1d10 rounds
    6703 Target struggles with some trite philosophical conundrum
    6704 Target suddenly has 2d10 carpenteris nails in his mouth
    6705 Target suddenly has a horseshoe in his mouth
    6706 Target suddenly owns a book describing how to build a spacecraft
    6707 Target suddenly owns a large pouch made of his own leathered skin
    6708 Target suddenly owns an exact replica of his own skeleton
    6709 Target suddenly owns an exact replica of some person nearby
    6710 Target suddenly owns an exact replica of the casteris skeleton
    6711 Target suddenly realizes that fire can harm him
    6712 Target suddenly realizes that he doesnit know how to use weapons
    6713 Target suddenly realizes that he has a conjoined twin
    6714 Target suddenly realizes that heis terrified of spiders
    6715 Target suddenly realizes that heis undead
    6716 Target suddenly realizes that magic doesnit really exist
    6717 Target suddenly realizes that magical illusions canit hurt him
    6718 Target suddenly realizes that the caster is only an illusion
    6719 Target suddenly senses that his identity is a fictional construct
    6720 Target suffers a fit of crippling paranoia for 1d4 turns
    6721 Target suffers a seizure lasting 1d10 rounds
    6722 Target suffers burns if he touches water hotter than 80°
    6723 Target suffers double damage from injuries while heis wet
    6724 Target suffers extreme hypothermia
    6725 Target suffers from a disfiguring pox, but his teeth are radiant
    6726 Target suffers from hysterical pregnancy
    6727 Target suffers half damage from metal weapons while itis snowing
    6728 Target suffers immense pain while in close proximity to fire
    6729 Target suffers intense dread when he tries to use a magic item
    6730 Target suffers no damage from dragonsi breath for 1d4 weeks
    6731 Target suffers no damage from falls of less than 1d100 feet
    6732 Target suffers no damage from magical blades for 2d4 days
    6733 Target suffers no damage from wounds inflicted by orcs
    6734 Target suffers only half damage from acid for 1d4 days
    6735 Target suffers only half damage from fire for 1d8 days
    6736 Target suffers only half damage from now until midnight
    6737 Target suffers only half damage from wounds received in daylight
    6738 Target suffers severe burns if cut by a magical blade
    6739 Target suffers severe burns the next time he removes his clothes
    6740 Target suffers severe convulsions in the presence of kobolds
    6741 Target suffers severe frostbite the next time he touches metal
    6742 Target suffers splitting headaches after using magic items
    6743 Target swallowed a tiny but powerful artifact yesterday
    6744 Target swaps places with himself from 1d10+10 rounds ago 
    6745 Target swears undying loyalty to the next person to say his name
    6746 Target sweats viscous and fragrant oil
    6747 Target teleports 100 yards north in each of the next 1d10 rounds
    6748 Target teleports 6d6 miles & back in each of the next 2d6 rounds
    6749 Target teleports 8d10 miles when he next attacks the caster
    6750 Target teleports into the nearest convent
    6751 Target teleports into the nearest grain silo
    6752 Target teleports into the nearest leper colony
    6753 Target teleports into the nearest monastery
    6754 Target teleports into the nearest oubliette
    6755 Target teleports into the nearest unoccupied sarcophagus
    6756 Target teleports one mile upon his next successful attack
    6757 Target teleports to a barren, arctic wasteland for 1d4+1 hours
    6758 Target teleports to a point 1d100 feet above the nearest lake
    6759 Target teleports to a tiny and distant island for 1d4 days
    6760 Target teleports to an impenetrable forest for 4d6 hours
    6761 Target teleports to the base of the largest tree within 100 miles
    6762 Target teleports to the casteris location in exactly 24 hours
    6763 Target teleports to the centerpoint of the nearest lakeis surface
    6764 Target teleports to the exact place where he awoke this morning
    6765 Target teleports to the exact place where he last ate a full meal
    6766 Target teleports to the exact place where he met the caster
    6767 Target teleports to the exact place where he was born
    6768 Target teleports to the exact place where heill be in 24 hours
    6769 Target teleports to the exact place where the caster was born
    6770 Target teleports to the location of the nearest anvil
    6771 Target teleports to the place where he last paid for a meal
    6772 Target teleports to the place where his blood was last spilled
    6773 Target teleports to this spot at both dawn and sunset tomorrow
    6774 Target teleports to this spot on the first day of each month
    6775 Target teleports to this spot upon losing 50% of his hit points
    6776 Target teleports to this spot when his blood is next spilled
    6777 Target teleports well beyond the casteris line of sight
    6778 Target tells embarrassing lies about himself at every opportunity
    6779 Target thinks heill die if he climbs a tree taller than he is
    6780 Target thinks heill die if he sees a shooting star
    6781 Target thinks heill die if he wields a magical weapon
    6782 Target thinks heill die if struck again by the casteris magic
    6783 Target thinks heill die unless the caster saves him
    6784 Target thinks heis an elephant until heis next injured
    6785 Target thinks that 1d100 years have passed
    6786 Target thinks that a mighty artifact is hidden in a nearby lake
    6787 Target thinks that he can control the caster for 1d6 rounds
    6788 Target thinks that heis thoroughly soaked with lamp oil
    6789 Target thinks that heis under the casteris control until sunset
    6790 Target thinks that his attacks heal rather than inflict damage
    6791 Target thinks that his clothing is on fire for 1d10 rounds
    6792 Target thinks that his enemies are only illusions
    6793 Target thinks that his left arm has turned to stone
    6794 Target thinks that his skin is trying to suffocate him
    6795 Target thinks that his sweat is flammable
    6796 Target thinks that his weapon is intelligent and powerful
    6797 Target thinks that his weapon will explode on contact with metal
    6798 Target thinks that non-magical fire is a manifestation of his god
    6799 Target thinks that non-magical fire is an offense against his god
    6800 Target thinks that one of his limbs is as fragile as glass
    6801 Target thinks that the nearest fire is an avatar of his god
    6802 Target thinks that the nearest statue is his close relative
    6803 Target thinks that the nearest statue was once his close friend
    6804 Target throws all of his belongings into the next fire he sees
    6805 Target throws his weapon into the next chasm he passes
    6806 Target tries to bite off 1d10 of his fingers, one try per finger
    6807 Target trips and falls over in each of the next 1d6 rounds
    6808 Target trips over what he realizes is his own grave marker
    6809 Target trumpets like an elephant when he draws a weapon
    6810 Target trusts everyone unquestioningly, no matter how unworthy
    6811 Target trusts no one whois visibly carrying a weapon
    6812 Target trusts the caster absolutely and unquestioningly
    6813 Target trusts the caster implicitly until the caster next speaks
    6814 Target turns in a circle every time he passes through a doorway
    6815 Target turns into a pumpkin at midnight tonight; reverts at dawn
    6816 Target turns into a tree at each sunset but reverts at dawn
    6817 Target understands 3d6 languages but can speak and write only one
    6818 Target vanishes for 1d4 days, then reappears unaware of the lapse
    6819 Target vanishes until 1d4 different people say his name
    6820 Target vanishes until the caster dies or gains a level
    6821 Target vanishes until two different people say his name
    6822 Target volunteers for any task, the more dangerous, the better
    6823 Target vows not to eat meat unless it comes from primates
    6824 Target vows to adopt a life of asceticism and poverty
    6825 Target vows to eat an entire person before the end of next month
    6826 Target vows to eat only raw meat starting tomorrow
    6827 Target vows to eat only rotting meat starting tomorrow
    6828 Target vows to forego all magical healing for one full year
    6829 Target vows to return to this exact spot once per week
    6830 Target vows to slay anyone who uses magic on him
    6831 Target vows to slay every necromancer he meets
    6832 Target vows to smite those who take his name in vain
    6833 Target vows to tithe 90% of his income
    6834 Target wails inconsolably for 1d10 rounds
    6835 Target wakes each day bald, but his hair regrows by noon
    6836 Target wakes each day certain that heis been buried for weeks
    6837 Target wakes each day certain that heis been tortured for weeks
    6838 Target wakes each day certain that heis gone blind
    6839 Target wakes each day certain that heis immortal
    6840 Target wakes each day certain that heis spent a month in the snow
    6841 Target wakes each day certain that heis still dreaming
    6842 Target wakes each day certain that heis the king
    6843 Target wakes each day certain that his heart has been removed
    6844 Target wakes each day covered in dirt as though recently buried
    6845 Target wakes each day covered in finely-powdered rust
    6846 Target wakes each day with his pockets full of twigs and gravel
    6847 Target wakes tomorrow certain that itis yesterday
    6848 Target wakes tomorrow floating in the middle of the nearest lake
    6849 Target wakes tomorrow within 1d10 yards of the caster
    6850 Target was assembled from portions of corpses
    6851 Target was just released after decades of solitary confinement
    6852 Target was the caster in a past life
    6853 Target was Wished into existence by a delusional necromancer
    6854 Target wastes many hours writing a list of 10,000 random effects
    6855 Target whistles like a teapot when struck by magic
    6856 Target will be devoured by a dragon within 24 hours
    6857 Target will befriend a dragon within 24 hours
    6858 Target will betray himself at the most inopportune time
    6859 Target will betray his closest ally in his time of greatest need
    6860 Target will combust in 1d10 rounds unless he eats 2d10 gold coins
    6861 Target will combust violently in 2d10 rounds
    6862 Target will die unless he spends 100 gold pieces each day
    6863 Target will either die or become a god at the next solstice
    6864 Target will gouge out his eyes unless heis retrained or attacked
    6865 Target will rescue his closest ally but it will cost his own life
    6866 Target will soon be arrested for bearing forged letters of marque
    6867 Target will soon be arrested for running an illegal orphanage
    6868 Target will soon be mistaken for a mighty figure out of legend
    6869 Target will spend any amount necessary to buy a handful of smoke
    6870 Target wobbles and clangs like a buoy while walking in fog
    6871 Target wonit be able to sleep in the next 1d100 days
    6872 Target wrongly believes that everyone is trying to kill him
    6873 Targetis AC is re-rolled on 1d10 in each of the next 2d10 rounds
    6874 Targetis age doubles twice 
    6875 Targetis age fluctuates 5d10 years each round for 10 rounds
    6876 Targetis age is now 3d20, with all related bonuses and penalties
    6877 Targetis age is re-rolled on 10d10 each morning
    6878 Targetis age varies by 1d10 years each time heis wounded
    6879 Targetis allies all attack him for 1d4 rounds
    6880 Targetis allies all sound just like him
    6881 Targetis allies are all healed, but heis reduced to one hit point
    6882 Targetis allies are all standing within armis reach of him
    6883 Targetis allies are condescending and patronizing to him
    6884 Targetis allies are immune to the targetis weapons for 1d12 hours
    6885 Targetis allies are stricken blind until the target says his name
    6886 Targetis allies are teleported at least 1d4 miles away from him
    6887 Targetis allies arrange to sell him for a substantial profit
    6888 Targetis allies assembled him from artificial parts
    6889 Targetis allies attempt to steal and sell all of his belongings
    6890 Targetis allies betrayed him terribly within the last 1d4 days
    6891 Targetis allies can come within 10 yards of him during melee
    6892 Targetis allies canit communicate with him until he spills blood
    6893 Targetis allies canit defend him in a fight
    6894 Targetis allies canit digest any food that he prepares
    6895 Targetis allies canit distinguish the target from the caster
    6896 Targetis allies canit draw weapons within 10 yards of him
    6897 Targetis allies canit look directly at him for 1d4 days
    6898 Targetis allies canit see him while heis at full hit point
    6899 Targetis allies canit speak to him while he has a weapon drawn
    6900 Targetis allies conspire to sell him into slavery
    6901 Targetis allies conspire to sell his soul to a demon
    6902 Targetis allies each carry a small vial filled with his blood
    6903 Targetis allies each find 1d10 gold pieces
    6904 Targetis allies each give him 1d100 gold pieces
    6905 Targetis allies fear that heis about to go on a homicidal rampage
    6906 Targetis allies go berserk if he is slain
    6907 Targetis allies have never liked or respected him
    6908 Targetis allies look just like him for 4d6 hours
    6909 Targetis allies look just like him until sunset
    6910 Targetis allies mock and ridicule him mercilessly until sunset
    6911 Targetis allies speak no language he can understand for 2d8 days
    6912 Targetis allies spread vicious and humiliating rumors about
    6913 Targetis allies suspect that he belongs to a divine lineage
    6914 Targetis allies suspect that heis a mechanical impostor
    6915 Targetis allies suspect that heis hiding vast wealth from them
    6916 Targetis allies suspect that heis joined a violent cult
    6917 Targetis allies suspect that heis plotting to betray them
    6918 Targetis allies suspect that heis really the caster
    6919 Targetis allies swear a blood oath against whoever slays him
    6920 Targetis allies think that he can resurrect the dead
    6921 Targetis allies think that he fulfills an ancient prophecy
    6922 Targetis allies think that he has some terribly virulent disease
    6923 Targetis allies think that he plans to sacrifice them to his god
    6924 Targetis allies think that heis ablaze
    6925 Targetis allies think that heis at deathis door
    6926 Targetis allies think that heis being controlled by unseen forces
    6927 Targetis allies think that heis damned beyond hope of redemption
    6928 Targetis allies think that heis dead, and they try to bury him
    6929 Targetis allies think that heis drowning
    6930 Targetis allies think that heis far more powerful than he lets on
    6931 Targetis allies think that heis guilty of many unspeakable crimes
    6932 Targetis allies think that heis ingested a powerful toxin
    6933 Targetis allies think that heis possessed by a powerful demon
    6934 Targetis allies think that heis under the casteris control
    6935 Targetis allies think that his name is "Fungus"
    6936 Targetis allies think that his touch is poisonous to them
    6937 Targetis allies trust him implicitly
    6938 Targetis allies utterly terrify him for 1d8 hours
    6939 Targetis allies worship him as a god for 1d8 days
    6940 Targetis ankle is tightly chained to his neck
    6941 Targetis ankles are bound by a large and heavy padlock
    6942 Targetis apparent physical age fluctuates by 1d100 years daily
    6943 Targetis arms appear to be stricken with advanced leprosy
    6944 Targetis arms are as limp as rope for 4d6 rounds
    6945 Targetis arms are encased in straight, tight-fitting steel tubes
    6946 Targetis arms are henceforth as limber as snakes
    6947 Targetis arms are replaced by inert duplicates of his head
    6948 Targetis arms canit be bound by cloth, rope, or vines
    6949 Targetis arms canit be broken by any natural means
    6950 Targetis arms canit be harmed by claws or teeth
    6951 Targetis arms canit be harmed by non-magical weapons
    6952 Targetis arms flap like a hummingbirdis wings for 3d6 rounds
    6953 Targetis arms have been repeatedly severed and reattached
    6954 Targetis arms reflect light like a mirror
    6955 Targetis arms shrink to the size of an infantis arms
    6956 Targetis arms spin like propellers until heis hit by magic
    6957 Targetis arms vanish, but he sprouts a trunk like an elephant
    6958 Targetis arms wheeze like hydraulics when he moves them
    6959 Targetis arms wriggle like angry snakes
    6960 Targetis attacks are 5% likely to inflict 5X normal damage
    6961 Targetis attacks are 5% likely to inflict equal damage upon him
    6962 Targetis attacks are 10% likely to inflict no damage at all
    6963 Targetis attacks are 10% likely to inflict only illusory damage
    6964 Targetis attacks are accompanied by eerie, disembodied chanting
    6965 Targetis attacks are accompanied by mocking, disembodied laughter
    6966 Targetis attacks are accompanied by the sound of breaking glass
    6967 Targetis attacks cause maximum damage, but he takes equal damage
    6968 Targetis attempts at tracking invariably lead to his own trail
    6969 Targetis blood burn as bright as magnesium
    6970 Targetis blood can eat through steel and iron like acid
    6971 Targetis blood hold the secret to eternal life
    6972 Targetis blood induces wild hallucinations in any who spill it
    6973 Targetis blood is highly flammable for 2d10 rounds
    6974 Targetis blood is invisible
    6975 Targetis blood is widely believed to be a panacea
    6976 Targetis blood smells powerfully of sulfur
    6977 Targetis body appears to be full of holes like Swiss cheese
    6978 Targetis body appears to be made entirely of cork
    6979 Targetis body appears to be made of porous wax
    6980 Targetis body can absorb twice its weight in water
    6981 Targetis body climbs into a tree each night as he sleeps
    6982 Targetis body inflates to twice its normal volume
    6983 Targetis body is covered with sores and blisters
    6984 Targetis body is infested with an enormous colony of termites
    6985 Targetis body is scarred as if heid been pushed through a screen
    6986 Targetis body is scoured with steel wool
    6987 Targetis body rings like an enormous church bell 1d12 times
    6988 Targetis body slowly absorbs any clothing he wears
    6989 Targetis body, clothing, and gear are uniformly bright orange
    6990 Targetis bones are as brittle as chalk until sunset tomorrow
    6991 Targetis bones are discovered to have been stolen
    6992 Targetis bones are intensely magnetic
    6993 Targetis bones are sought by poachers
    6994 Targetis bones are visible through his skin while he sleeps
    6995 Targetis bones are visible through his skin while heis wet
    6996 Targetis bones are weightless
    6997 Targetis bones can never be rendered invisible
    6998 Targetis bones canit be broken by any natural physical force
    6999 Targetis bones chime like bells when heis struck
    7000 Targetis bones clatter inside his body like a bare skeleton
    7001 Targetis bones combust if exposed to direct sunlight
    7002 Targetis bones fuse into a single, inflexible mass
    7003 Targetis bones turn to ice
    7004 Targetis bones turn to muscle 
    7005 Targetis boots are discovered to be living organisms
    7006 Targetis boots can never sink underwater while he wears them
    7007 Targetis boots fuse to the ground where heis now standing
    7008 Targetis boots turn to glass
    7009 Targetis Charisma is raised to 25 for 1d6 rounds
    7010 Targetis closest ally attacks him for 1d10 rounds
    7011 Targetis closest ally is permanently invisible to him
    7012 Targetis closest ally turns out to be his clone
    7013 Targetis closest ally will betray him in his hour of need
    7014 Targetis clothes always appear to be filthy
    7015 Targetis clothes always resemble the clothes heis now wearing
    7016 Targetis clothes and gear are affected by Reverse Gravity
    7017 Targetis clothes and gear are highly flammable
    7018 Targetis clothes and gear are insulated against electricity
    7019 Targetis clothes appear 10d10 centuries out of date
    7020 Targetis clothes appear to be made of ice
    7021 Targetis clothes are 90% transparent while in mixed company
    7022 Targetis clothes are as delicate as cobweb
    7023 Targetis clothes are as rigid as boiled leather
    7024 Targetis clothes are as susceptible to rust as iron
    7025 Targetis clothes are chilled nearly to absolute zero
    7026 Targetis clothes are consumed by fire, but he is unharmed
    7027 Targetis clothes are devoured by vermin over the next 4d6 rounds
    7028 Targetis clothes are extraordinarily elastic
    7029 Targetis clothes are seized by the local authorities
    7030 Targetis clothes are soaked with a fetid and viscous slime
    7031 Targetis clothes are soaked with a powerful acid
    7032 Targetis clothes are soaked with beer
    7033 Targetis clothes are soaked with butterscotch pudding
    7034 Targetis clothes are soaked with deer musk
    7035 Targetis clothes are soaked with icy water once every 1d12 hours
    7036 Targetis clothes are soaked with strong perfume
    7037 Targetis clothes are stuffed full of snow
    7038 Targetis clothes attract wasps, hornets, and bees
    7039 Targetis clothes billow with foul smoke when he uses a magic item
    7040 Targetis clothes billow with foul smoke when he wields a weapon
    7041 Targetis clothes billow with foul smoke when heis underground
    7042 Targetis clothes billow with scalding steam
    7043 Targetis clothes canit be moved more than 10 yards from this spot
    7044 Targetis clothes canit be pierced by wooden weapons
    7045 Targetis clothes clatter like a suit of armor while he walks
    7046 Targetis clothes combust if worn while crossing moving water
    7047 Targetis clothes defy community standards of decency
    7048 Targetis clothes double in size in each of the next 1d8 rounds
    7049 Targetis clothes double in weight in each of the next 1d8 rounds
    7050 Targetis clothes exactly match the casteris clothes
    7051 Targetis clothes exude fragrant smoke for 1d4 weeks
    7052 Targetis clothes glow in the dark
    7053 Targetis clothes have been buried for weeks in a midden
    7054 Targetis clothes heat to 500°
    7055 Targetis clothes ignite each time he uses a magic item
    7056 Targetis clothes inflate to the size of a house
    7057 Targetis clothes make him appear to suffer from leprosy
    7058 Targetis clothes mock him with whispers that only he can hear
    7059 Targetis clothes protect him against extremes of natural weather
    7060 Targetis clothes shrink by one percent per round
    7061 Targetis clothes smolder from now until dawn, but he is unharmed
    7062 Targetis clothes teleport 1d10 yards
    7063 Targetis clothes totally unravel over the next 3d10 rounds
    7064 Targetis clothes turn invisible each time he uses a magic item
    7065 Targetis clothes writhe like a living creature for 24 hours
    7066 Targetis corpse will never decay by natural processes
    7067 Targetis current hit point total is his maximum hit point total
    7068 Targetis deadliest foe appears in the area, armed to the teeth
    7069 Targetis deadliest foe will rescue him in his hour of need
    7070 Targetis death is expected to yield vast riches for his slayer
    7071 Targetis death is one of the final precursors to the apocalypse
    7072 Targetis death will awaken a nightmarish, slumbering deity
    7073 Targetis death will be horrible enough to inspire legends
    7074 Targetis death will bring swift retaliation from the authorities
    7075 Targetis death will herald the coming of an age of horrors
    7076 Targetis death will inflict a plague upon the surrounding area
    7077 Targetis death will lead to mass rioting
    7078 Targetis death will reveal him to be a horrific, demonic entity
    7079 Targetis ears are indestructible
    7080 Targetis ears are prehensile
    7081 Targetis ears are the size of dinner plates
    7082 Targetis ears explode if removed
    7083 Targetis ears melt like wax
    7084 Targetis ears migrate about his head as the days wear on
    7085 Targetis ears migrate to his shoulders
    7086 Targetis ears shrivel and fall off over the next 1d8 days
    7087 Targetis ears turn slowly counter-clockwise
    7088 Targetis ears, nose, and lips are invisible for 1d4 days
    7089 Targetis ears, nose, and lips double in size
    7090 Targetis ears, nose, and lips fall off
    7091 Targetis ears, nose, and lips turn bright blue
    7092 Targetis entire family is arrested by royal decree
    7093 Targetis explodes if any attempt is made at resurrection
    7094 Targetis expression is permanently locked into a manic smile
    7095 Targetis eyes appear to be bundles of writhing worms
    7096 Targetis eyes appear to be tiny fireballs
    7097 Targetis eyes automatically filter out harmfully bright light
    7098 Targetis eyes bulge from the top of his head like a frogis eyes
    7099 Targetis eyes bulge to the size of henis eggs
    7100 Targetis eyes burst, blinding him, but they grow back in 1d4 days
    7101 Targetis eyes can move independently, like a chameleonis
    7102 Targetis eyes each have 1d4 irises and pupils
    7103 Targetis eyes glow with malevolent fire when he faces true north
    7104 Targetis eyes merge into a single eye somewhere on his face
    7105 Targetis eyes migrate to just above his ears
    7106 Targetis eyes see normally but appear lifeless like a dollis eyes
    7107 Targetis eyes steam and hiss like quenching metal
    7108 Targetis face appears to have been roughly chiseled out of coal
    7109 Targetis face appears to have been welded to his skull
    7110 Targetis face begins to look more and more bat-like
    7111 Targetis face canit be harmed by acid
    7112 Targetis face glows pale green when he tells a lie
    7113 Targetis face is badly sunburned in a checkerboard pattern
    7114 Targetis face is flattened to his skull
    7115 Targetis face is scarred as by acid or flame
    7116 Targetis face is scarred as though horribly slashed years ago
    7117 Targetis face is tattooed with cryptic runes and sigils
    7118 Targetis face looks as though heis been pounded with hammers
    7119 Targetis face looks as though something exploded in his nose
    7120 Targetis face looks like badly melted wax
    7121 Targetis face migrates to the top of his head
    7122 Targetis family disowns him and places a bounty on his head
    7123 Targetis family includes at least one demonic abomination
    7124 Targetis family relocates to a distant land without telling him
    7125 Targetis feet appear to be made of clay
    7126 Targetis feet are fused to the ground beneath him
    7127 Targetis feet are henceforth clear like glass
    7128 Targetis feet are now prehensile, but his hands are not
    7129 Targetis feet can rotate 360° at the ankle without harming him
    7130 Targetis feet canit come within one yard of each other
    7131 Targetis feet explode if he ventures more than one mile from here
    7132 Targetis feet shriek incessantly while he wears shoes or boots
    7133 Targetis fingernails are hard as steel and susceptible to rust
    7134 Targetis fingernails begin to grow 1d4 inches per round 
    7135 Targetis fingernails glow like burning coals
    7136 Targetis fingernails pulse with an unholy glow under moonlight
    7137 Targetis fingernails react to water like pure sodium
    7138 Targetis fingers and thumbs are intertwined like tangled rope
    7139 Targetis fingers and thumbs connect directly to his wrists
    7140 Targetis fingers and thumbs shuffle positions
    7141 Targetis fingers merge into a single digit like a mitten
    7142 Targetis fists are attracted to each other like strong magnets
    7143 Targetis fists are each as large as his head
    7144 Targetis fists canit come within five feet of the ground
    7145 Targetis fists retract into his forearms when not in use
    7146 Targetis flesh is utterly transparent to artificial light
    7147 Targetis footfalls strike sparks on the ground
    7148 Targetis footprints are perfectly rectangular
    7149 Targetis footprints completely vanish after 1d10 rounds
    7150 Targetis footprints look like arrows pointing which way he went
    7151 Targetis footprints look like heis executing complex dance steps
    7152 Targetis forearms are invisible
    7153 Targetis hair canit be cut by non-magical metal
    7154 Targetis hair falls out and is replaced by lush feathers
    7155 Targetis hair falls out and is replaced by thick grass
    7156 Targetis hair falls out and tiny spikes sprout all over his head
    7157 Targetis hair floats as though underwater
    7158 Targetis hair grows 1d12 inches each time heis struck by magic
    7159 Targetis hair is severely tangled in the nearest tree or bush
    7160 Targetis hair is styled into a tall bouffant
    7161 Targetis hair moves from his head to somewhere else on his body
    7162 Targetis hair noticeably changes color every six hours
    7163 Targetis hands and feet are abnormally spongy
    7164 Targetis hands and feet are scarred with arcane symbols
    7165 Targetis hands and feet are tightly wrapped in adhesive cloth
    7166 Targetis hands and feet can never be rendered magically invisible
    7167 Targetis hands and feet give off unsettling vapors
    7168 Targetis hands and feet reform into perfect cubes
    7169 Targetis hands and feet shuffle their locations
    7170 Targetis hands and feet turn to pigis hooves for 1d4 days
    7171 Targetis hands applaud despite his wishes for 3d10 rounds
    7172 Targetis hands are bound in adamantite shackles
    7173 Targetis hands are encased in thick blobs of candle wax
    7174 Targetis hands are invisible while he wields a weapon
    7175 Targetis hands are magically slicked with butter for 1d4 hours
    7176 Targetis hands are nailed to the nearest tree
    7177 Targetis hands are shaped like those of a bat, minus the wings
    7178 Targetis hands are utterly paralyzed until heis struck by magic
    7179 Targetis hands attempt to strangle him for 3d10 rounds
    7180 Targetis hands become ethereal while he wields a weapon
    7181 Targetis hands can never be severed from his arms
    7182 Targetis hands canit be burned by acid, fire, or electricity
    7183 Targetis hands canit be burned by magical fire
    7184 Targetis hands canit be cut by any blade forged by a mortal
    7185 Targetis hands canit be cut by non-magical blades
    7186 Targetis hands canit come within 18 inches of his mouth
    7187 Targetis hands change color each hour
    7188 Targetis hands combust if he tries to wear gloves
    7189 Targetis hands combust if they come into contact with each other
    7190 Targetis hands flap like birdsi wings for 1d10 rounds
    7191 Targetis hands freeze to the next wooden object he touches
    7192 Targetis hands fuse to the next metal object he handles
    7193 Targetis hands fuse together behind his back
    7194 Targetis hands itch slightly when he touches a magic item
    7195 Targetis hands look black and necrotic after handling magic items
    7196 Targetis hands melt like wax if exposed to magical fire
    7197 Targetis hands rotate 180° at the wrists
    7198 Targetis hands shrink by 50%
    7199 Targetis hands steam vigorously when heis struck by magic
    7200 Targetis hands try to grab his ankles while heis walking
    7201 Targetis hands turn to metal but otherwise function normally
    7202 Targetis hands vanish while he sleeps but return before he wakes
    7203 Targetis hat animates and attempts to eat his head
    7204 Targetis hat bleeds profusely until sunset tomorrow
    7205 Targetis hat is replaced by a spittoon or chamber pot
    7206 Targetis hat is replaced by half of a hollowed-out coconut
    7207 Targetis head always appear to face true north
    7208 Targetis head appears as a photo-negative
    7209 Targetis head appears to age at a rate of one year per day
    7210 Targetis head appears to be a naked brain
    7211 Targetis head appears to be made of delicate porcelain
    7212 Targetis head appears to be made of fire
    7213 Targetis head appears to be made of ice
    7214 Targetis head appears to be made of pure gold
    7215 Targetis head appears to be made of sand
    7216 Targetis head appears to be made of the finest crystal
    7217 Targetis head appears to be made of wood
    7218 Targetis head appears to be severely cracked like an egg
    7219 Targetis head blazes with illusory fire for 1d4 months
    7220 Targetis head can survive away from his body for 3d8 hours
    7221 Targetis head canit be harmed by magical electricity
    7222 Targetis head considers itself separate from his body
    7223 Targetis head deflates like a balloon while he sleeps
    7224 Targetis head explodes but regrows over the next 1d10 rounds
    7225 Targetis head explodes if heis decapitated
    7226 Targetis head glows like a jack-o-lantern
    7227 Targetis head goes on a murderous rampage if heis decapitated
    7228 Targetis head has a chunk missing as though hacked by an axe
    7229 Targetis head has a large hole through it like a doughnut
    7230 Targetis head has an arrow running harmlessly through it
    7231 Targetis head increases in size by a factor of 1d4+1
    7232 Targetis head is artificial
    7233 Targetis head is claimed as a sacred relic by orcs or goblins
    7234 Targetis head is clear like glass for 1d4 weeks
    7235 Targetis head is covered in coarse and ugly scales
    7236 Targetis head is covered with numerous disc-shaped scars
    7237 Targetis head is encased in a durable, transparent globe
    7238 Targetis head is enclosed in an indestructible helmet
    7239 Targetis head is enwrapped in delicate gold filigree
    7240 Targetis head is flattened on top like a pounded wooden stake
    7241 Targetis head is immune to extremes of pressure
    7242 Targetis head is impervious to magical fire
    7243 Targetis head is impervious to missile weapons
    7244 Targetis head is impervious to non-magical bludgeons
    7245 Targetis head is impervious to polymorph magic
    7246 Targetis head is invisible from the chin to the ears
    7247 Targetis head is of no particular physiological importance
    7248 Targetis head is prehensile
    7249 Targetis head is protected as though heis wearing a steel helmet
    7250 Targetis head is scarred as though split down the middle
    7251 Targetis head is shaped like a light bulb
    7252 Targetis head is Slowed for 1d4 hours
    7253 Targetis head is stuck in a huge conch shell
    7254 Targetis head is vestigial
    7255 Targetis head no longer ages
    7256 Targetis head seems on the verge of bursting
    7257 Targetis head shrinks to the size of his closed fist
    7258 Targetis head spins rapidly at the neck for 2d10 rounds
    7259 Targetis head splits in half, revealing his real head inside
    7260 Targetis head strongly resembles a foot
    7261 Targetis head throbs visibly when heis angry
    7262 Targetis head vanishes and his face appears on his chest
    7263 Targetis head was stolen from a necromanceris workshop
    7264 Targetis head will be claimed by warring factions after he dies 
    7265 Targetis heart is safe in a silver urn buried in the forest
    7266 Targetis heart turns to solid gold, potentially killing him
    7267 Targetis highest attribute score drops to 3 for 2d12 hours
    7268 Targetis highest attribute score is halved for 1d4 days
    7269 Targetis highest attribute score is re-rolled daily
    7270 Targetis hindquarters resemble those of a donkey
    7271 Targetis hit points are doubled for the next 24 hours
    7272 Targetis huge likeness appears on the side of a nearby mountain
    7273 Targetis image appears on every flag and banner within 10 miles
    7274 Targetis internal organs have been culled from various animals
    7275 Targetis internal organs murmur and chant inside him
    7276 Targetis internal organs shuffle positions
    7277 Targetis internal organs turn into infernal oranges
    7278 Targetis intestines are more intelligent than he is
    7279 Targetis intestines are replaced by a length of noisy chain
    7280 Targetis jawbone becomes that of an ass
    7281 Targetis knees and elbows become ball-joints like his shoulders
    7282 Targetis knees and elbows canit straighten to more than 120°
    7283 Targetis knees and elbows creak like rusty metal
    7284 Targetis knees and elbows vanish
    7285 Targetis large intestine explodes
    7286 Targetis left arm has Strength 18/00
    7287 Targetis left arm is fused into a nearby boulder
    7288 Targetis left arm is permanently invisible
    7289 Targetis left arm moves to his right shoulder
    7290 Targetis left foot appears to be that of a large duck
    7291 Targetis left foot can never again tolerate a shoe or boot
    7292 Targetis left foot henceforth appears to be badly mangled
    7293 Targetis left foot is wholly invulnerable to all harm
    7294 Targetis left foot sinks six inches into the ground at each step
    7295 Targetis left foot sprouts a pair of thumbs
    7296 Targetis left foot takes root
    7297 Targetis legs are covered in bark
    7298 Targetis legs are fireproof
    7299 Targetis legs are invisible in direct sunlight
    7300 Targetis legs are shaped like springs and twang when he walks
    7301 Targetis legs canit be cut by non-magical weapons
    7302 Targetis legs exactly resemble his arms
    7303 Targetis legs exchange positions
    7304 Targetis legs fuse together, and his arms fuse to his sides
    7305 Targetis legs shrink by 1d10 x 10% for 1d12 hours
    7306 Targetis level is halved
    7307 Targetis limbs change proportion to match those of an infant
    7308 Targetis limbs shrink to the size of an infantis limbs
    7309 Targetis lips are sewn shut with fine gold wire
    7310 Targetis lips move constantly as though heis singing to himself
    7311 Targetis lips vanish
    7312 Targetis loses 1d10 levels but regains one per day
    7313 Targetis maximum natural lifespan doubles
    7314 Targetis maximum natural lifespan increases by 1d100 years
    7315 Targetis maximum natural lifespan is 1d10 years more than his age
    7316 Targetis maximum natural lifespan is reduced by 50%
    7317 Targetis memories of the last 1d12 hours are full of butterflies
    7318 Targetis memories of the last 1d12 hours are vivid but incorrect
    7319 Targetis most valuable possession animates and attacks him
    7320 Targetis most valuable possession becomes brittle as glass
    7321 Targetis most valuable possession bursts into flame
    7322 Targetis most valuable possession canit be affected by magic
    7323 Targetis most valuable possession doubles in size
    7324 Targetis most valuable possession flies toward him at great speed
    7325 Targetis most valuable possession is affected by reverse gravity
    7326 Targetis most valuable possession is an illusion
    7327 Targetis most valuable possession is coveted by all who see it
    7328 Targetis most valuable possession is encased in glass
    7329 Targetis most valuable possession is indestructible
    7330 Targetis most valuable possession is sold for 1d100 gold pieces
    7331 Targetis most valuable possession is stolen by the king
    7332 Targetis most valuable possession now belongs to someone else
    7333 Targetis most valuable possession turns permanently invisible
    7334 Targetis most valuable possession turns to lead
    7335 Targetis mouth and each nostril is plugged by a cork
    7336 Targetis mouth and one of his eyes exchange places
    7337 Targetis mouth appears to be full of angry hornets
    7338 Targetis mouth can speak with a mind of its own
    7339 Targetis mouth canit be opened while heis wearing a hat
    7340 Targetis mouth glows as though heis eating fireflies
    7341 Targetis mouth glows like a forge
    7342 Targetis mouth is full of moths
    7343 Targetis mouth is now located on the back of his head
    7344 Targetis mouth is packed completely full of leaves
    7345 Targetis mouth is replaced by a duckis bill
    7346 Targetis mouth is replaced by a hideous scolex
    7347 Targetis mouth is replaced by a toucanis beak
    7348 Targetis mouth opens to a span of 4d4 inches
    7349 Targetis mouth vanishes for 1d6 hours
    7350 Targetis neck and head shift 1d4+4 inches to the left
    7351 Targetis neck attempts to devour his head
    7352 Targetis neck can extend an additional 1d4 feet at will
    7353 Targetis neck can retract into his torso like a turtleis
    7354 Targetis neck canit be broken
    7355 Targetis neck doubles in length
    7356 Targetis neck flares like a lizardis frill when heis angry
    7357 Targetis neck has a frill like a triceratops
    7358 Targetis neck is as thin as a spear-shaft
    7359 Targetis neck is encircled by a tight steel collar
    7360 Targetis neck is impervious to blades
    7361 Targetis neck is scarred and twisted as if he survived a hanging
    7362 Targetis next 1d10 attacks affect him as well
    7363 Targetis next 1d10 attacks donit take effect for 1d10 rounds
    7364 Targetis next 1d10 attacks have a damage bonus of 1d6 hit points
    7365 Targetis next 1d10 attacks inflict only illusionary damage
    7366 Targetis next attack inflicts damage that only a Wish can heal
    7367 Targetis next missile attack automatically strikes him instead
    7368 Targetis next missile attack causes whoever is hit to combust
    7369 Targetis next missile attack equally injures an extra 1d6 people
    7370 Targetis next missile attack Heals its victim to full hit points
    7371 Targetis next missile attack inflicts 1d10 times normal damage
    7372 Targetis next missile attack strikes a nearby tree and ignites it
    7373 Targetis next missile attack teleports whoever it hits 1d4 miles
    7374 Targetis next missile attack turns its victim invisible
    7375 Targetis nose looks like a small, clenched fist
    7376 Targetis nose turns into a wolfis snout under the full moon
    7377 Targetis nose turns to flint
    7378 Targetis nostrils are each as large as his mouth
    7379 Targetis nostrils glow with an unholy radiance
    7380 Targetis nostrils migrate to the top of his head
    7381 Targetis own corpse appears from the future as a powerful undead
    7382 Targetis physical age is now 1d100
    7383 Targetis pockets and mouth are full of sand
    7384 Targetis possessions are hidden beneath a nearby boulder
    7385 Targetis possessions are possessed by a powerful demon
    7386 Targetis possessions turn to solid aluminum
    7387 Targetis possessions, if enchanted, acquire hostile intelligence
    7388 Targetis possessions, if enchanted, swap their enchantments
    7389 Targetis presence causes birds to fall silent
    7390 Targetis presence causes birds to sing ominous songs
    7391 Targetis presence causes insects to exhibit strange behaviors
    7392 Targetis presence causes magical metal to appear badly tarnished
    7393 Targetis presence causes metal to yield disturbing reflections
    7394 Targetis presence causes priests and clerics to blaspheme openly 
    7395 Targetis presence causes Summoned creatures to be Slowed
    7396 Targetis presence causes undead to appear to smolder gently
    7397 Targetis presence is 20% likely to make Summoned creatures vanish
    7398 Targetis presence makes cooked meat taste blood-raw
    7399 Targetis presence makes fires burn in a festive blue-green hue
    7400 Targetis presence makes foliage appear sickly and blighted
    7401 Targetis presence makes hoofed animals nervous
    7402 Targetis presence makes impassable trails seem passable
    7403 Targetis presence makes merchants hostile to bargaining
    7404 Targetis presence makes mind-reading impossible
    7405 Targetis presence makes missile weapons leave rainbow trails
    7406 Targetis presence makes secret doors twice as easy to find
    7407 Targetis presence makes secret doors twice as hard to find
    7408 Targetis presence makes smoke assume disturbing, ghostly shapes
    7409 Targetis presence renders clockwork devices temporarily inert
    7410 Targetis presence renders magical weapons temporarily invisible
    7411 Targetis presence renders maps temporarily illegible
    7412 Targetis principal weapon sprouts 10d10 roses
    7413 Targetis scent causes hallucinations in animals used to track him
    7414 Targetis shadow appears to flicker like a shadowy flame
    7415 Targetis shadow can travel up to 1d4 miles away from him
    7416 Targetis shadow races around him in a tight circle
    7417 Targetis shadow rises up and tries to strangle him
    7418 Targetis skin acquires 1d100 blasphemous tattoos
    7419 Targetis skin ages 10X as fast as the rest of his body
    7420 Targetis skin appears permanently stained with blood
    7421 Targetis skin appears slightly inflated after each battle
    7422 Targetis skin appears to be the texture of pumice
    7423 Targetis skin appears to be the texture of sandstone
    7424 Targetis skin appears to have been gnawed by countless rodents
    7425 Targetis skin appears to have been roughly stitched together
    7426 Targetis skin appears to have been torn off and reattached
    7427 Targetis skin appears to have been turned inside-out
    7428 Targetis skin appears uniformly smooth and waxy
    7429 Targetis skin appears weathered like an ancient statue
    7430 Targetis skin attracts scavengers as if it were carrion
    7431 Targetis skin canit be burned, but fire still causes him pain
    7432 Targetis skin canit be cut
    7433 Targetis skin canit be cut by magical weapons under moonlight
    7434 Targetis skin canit be cut, and his mouth and nose seal shut
    7435 Targetis skin canit be pierced by carved wood
    7436 Targetis skin canit be pierced by stone weapons
    7437 Targetis skin canit be pierced by teeth or claws
    7438 Targetis skin cracks painfully like a dried-up riverbed
    7439 Targetis skin develops an intricate patchwork of scars
    7440 Targetis skin displays a series of concentric rings like a target
    7441 Targetis skin displays cryptic and constantly-changing runes
    7442 Targetis skin doubles in size
    7443 Targetis skin erupts into countless weeping boils
    7444 Targetis skin erupts with 3d10 acrid fungal outgrowths
    7445 Targetis skin freezes to his weapon each time he wields it
    7446 Targetis skin gives him a natural AC of 3, but only while naked
    7447 Targetis skin glistens as though soaked with lamp oil
    7448 Targetis skin glows cherry red during melee
    7449 Targetis skin glows pale green in moonlight
    7450 Targetis skin has the texture of rough bark
    7451 Targetis skin is 10% likely to be fireproof during any given day
    7452 Targetis skin is a widely coveted delicacy
    7453 Targetis skin is actually an intricate pattern of tiny tiles
    7454 Targetis skin is as combustible as paper
    7455 Targetis skin is as hard as bronze
    7456 Targetis skin is as white as snow until the next vernal equinox
    7457 Targetis skin is charred and blackened, but he is unharmed
    7458 Targetis skin is covered in scales like a fish
    7459 Targetis skin is flayed from his limbs, but it regrows by dawn
    7460 Targetis skin is forever the color of the next stone he touches
    7461 Targetis skin is invisible by firelight
    7462 Targetis skin is invisible in the presence of undead
    7463 Targetis skin is invisible while heis standing in water
    7464 Targetis skin is magically delicious
    7465 Targetis skin is mildly magnetic while wet
    7466 Targetis skin is patterned like a checkerboard
    7467 Targetis skin is patterned like a Holstein
    7468 Targetis skin is patterned like modern camouflage gear
    7469 Targetis skin is permanently and disturbingly moist
    7470 Targetis skin is permanently crisscrossed with fine lines
    7471 Targetis skin is repeatedly tattooed with casteris name
    7472 Targetis skin is repeatedly tattooed with his own name
    7473 Targetis skin is repeatedly tattooed with slurs against the king
    7474 Targetis skin is rumored to produce the worldis finest leather
    7475 Targetis skin reeks of mold and mildew
    7476 Targetis skin reflects torchlight perfectly, but not sunlight
    7477 Targetis skin ripples in the wind like a cloth sheet
    7478 Targetis skin rotates 180°
    7479 Targetis skin shimmers like mother-of-pearl from now on
    7480 Targetis skin sizzles harmlessly on contact with water
    7481 Targetis skin smolders during combat
    7482 Targetis skin turns as black as pitch while in sunlight
    7483 Targetis skin will melt if he gets too close to a campfire
    7484 Targetis skin writhes and pulses while heis eating
    7485 Targetis skull is inscribed with a mysterious rune of power
    7486 Targetis skull sprouts numerous knobby projections
    7487 Targetis speech is intelligible to anyone, regardless of language
    7488 Targetis speech is reversed while his weapon is drawn
    7489 Targetis speech seems unaccountably rude and aggressive
    7490 Targetis speech sounds like the buzzing of innumerable bees
    7491 Targetis spine bends 90° halfway along its length
    7492 Targetis spine can twist 360° without harming him
    7493 Targetis spine doubles in length
    7494 Targetis spine is fused into a single bone for 1d8 hours
    7495 Targetis spine is indestructible
    7496 Targetis spine is reconfigured like a quadrupedis
    7497 Targetis spine juts from his flesh along his entire back
    7498 Targetis spine sprouts needle-sharp projections
    7499 Targetis spine twists like a corkscrew
    7500 Targetis sternum sprouts 2d4 inch-long spikes
    7501 Targetis sternum turns to glass
    7502 Targetis sternum turns to steel
    7503 Targetis sternum vanishes
    7504 Targetis sweat is brightly phosphorescent by firelight
    7505 Targetis teeth and tongue fall out when he next opens his mouth
    7506 Targetis teeth and tongue turn invisible
    7507 Targetis teeth are etched with cryptic runes
    7508 Targetis teeth are perfectly reflective of natural light
    7509 Targetis teeth are so beautiful that theyire painful to look at
    7510 Targetis teeth can never be rendered invisible
    7511 Targetis teeth glow brightly while his mouth is open
    7512 Targetis teeth glow like coals in a forge
    7513 Targetis teeth glow like torches when heis struck by magic
    7514 Targetis teeth resonate in his jaw when he uses a magic item
    7515 Targetis teeth shoot from his mouth like bullets
    7516 Targetis teeth teleport into the mouth of someone nearby
    7517 Targetis teeth turn as black as coal
    7518 Targetis teeth turn to diamonds 1d4 hours after being extracted
    7519 Targetis teeth turn to soap
    7520 Targetis teeth turn to steel
    7521 Targetis teeth were cut from diamonds by a Gnome master lapidary
    7522 Targetis toes are each as large as his big toe
    7523 Targetis toes become gangrenous
    7524 Targetis toes constantly exude a fragrant steam 
    7525 Targetis toes each grow 1d12 inches, rolling for each separately
    7526 Targetis torso and arms are encased in tight-fitting steel plate
    7527 Targetis torso and arms are invisible for 1d4 months
    7528 Targetis torso does not age and will not decay upon death
    7529 Targetis torso inspires fear and dread in all who touch it
    7530 Targetis torso is artificial
    7531 Targetis torso is hollow and can store up to 2d4 cubic feet
    7532 Targetis torso is pierced by 4d10 long needles
    7533 Targetis torso is reproduced as a marble sculpture nearby
    7534 Targetis torso is sought by wizards for its alchemical properties
    7535 Targetis torso regenerates his limbs and head as needed
    7536 Targetis torso shines like a beacon for 1d4 days
    7537 Targetis torso shines like a beacon when he uses a magic item
    7538 Targetis torso shrinks by 50%
    7539 Targetis torso sprouts a face with malign intelligence and power
    7540 Targetis torso teleports 1d4 feet to the left
    7541 Targetis torso unzips and dumps out all of his organs
    7542 Targetis vertebrae are replaced by titanium replicas
    7543 Targetis vision is unimpaired by non-magical rain
    7544 Targetis voice causes metal to resonate lightly
    7545 Targetis voice crackles with static until sunrise tomorrow
    7546 Targetis voice induces fear in herbivores
    7547 Targetis voice inspires confidence in others of his species
    7548 Targetis voice inspires dread in anyone of the opposite sex
    7549 Targetis voice is inaudible to others of his species
    7550 Targetis voice is nearly unintelligible when he wields his weapon
    7551 Targetis voice issues from his navel
    7552 Targetis voice issues from his weapon for the next few weeks
    7553 Targetis voice issues from the nearest wooden object
    7554 Targetis voice issues from this spot for 2d10 days
    7555 Targetis voice seems to issue from whomever heis addressing
    7556 Targetis voice sounds as though heis shouting from a distance
    7557 Targetis voice sounds like a muted trumpet
    7558 Targetis voice sounds like someone of the opposite sex
    7559 Targetis voice sounds like the barking of feral dogs
    7560 Targetis voice sounds like the braying of donkeys
    7561 Targetis voice sounds like the chirping of crickets for 3d8 hours
    7562 Targetis voice sounds like the honking of geese
    7563 Targetis voice sounds oddly artificial and disturbing
    7564 Targetis waterskin is filled with his own blood
    7565 Targetis waterskin is filled with hot pepper sauce
    7566 Targetis waterskin is filled with liquid soap
    7567 Targetis waterskin is filled with mercury
    7568 Targetis waterskin is filled with molten gold
    7569 Targetis waterskin is filled with water from the River Styx
    7570 Targetis weapon adheres to the next creature whose blood it draws
    7571 Targetis weapon adheres to the next person to touch it
    7572 Targetis weapon appears to be an umbrella while not in use
    7573 Targetis weapon appears to be made of cheese for 1d6 days
    7574 Targetis weapon appears to be made of diamond
    7575 Targetis weapon appears to be made of ice
    7576 Targetis weapon appears to be made of solid water
    7577 Targetis weapon appears to be of much higher quality than it is
    7578 Targetis weapon appears to be very hot to anyone else wielding it
    7579 Targetis weapon appears to be worth 50X its real value
    7580 Targetis weapon attacks him the next time heis wounded in battle
    7581 Targetis weapon attracts the attention of the authorities
    7582 Targetis weapon attracts undead while itis drawn
    7583 Targetis weapon blazes with illusionary flame while itis drawn
    7584 Targetis weapon burns anyone who wields it, other than the target
    7585 Targetis weapon burns like an oil-soaked wick but isnit consumed
    7586 Targetis weapon burns targetis hand the next time he wields it
    7587 Targetis weapon can be disassembled into 1d20 tiny pieces
    7588 Targetis weapon can freeze 10 cubic feet of water, once per week
    7589 Targetis weapon can hurl 2d6 magic missiles, then it disappears
    7590 Targetis weapon can inflict no damage for 1d10 rounds
    7591 Targetis weapon can injure anyone now within 1d10 feet of it
    7592 Targetis weapon can injure but not kill anyone
    7593 Targetis weapon can return polymorphed beings to their true forms
    7594 Targetis weapon can spray enough octopus ink to blind one foe
    7595 Targetis weapon canit be altered by any non-magical means
    7596 Targetis weapon canit be harmed by magical fire
    7597 Targetis weapon canit be teleported
    7598 Targetis weapon canit be wielded unless the wielder is naked
    7599 Targetis weapon canit cut flesh for 1d12 hours
    7600 Targetis weapon canit harm non-humanoid mammals
    7601 Targetis weapon canit harm undead
    7602 Targetis weapon canit injure anyone of his sex
    7603 Targetis weapon canit injure anyone of the opposite sex
    7604 Targetis weapon canit pass through doorways
    7605 Targetis weapon causes fire to be invisible while itis drawn
    7606 Targetis weapon causes him to issue ridiculous threats
    7607 Targetis weapon causes its wielder to be Slowed during melee
    7608 Targetis weapon clangs like a bell when used in melee
    7609 Targetis weapon coils about his arm for 1d4 rounds
    7610 Targetis weapon delivers an electrical shock with every strike
    7611 Targetis weapon develops an intense and obvious dislike of him
    7612 Targetis weapon dims light in a 10-yard radius while itis drawn
    7613 Targetis weapon disintegrates if ever it wounds him
    7614 Targetis weapon disintegrates if itis hit by magic
    7615 Targetis weapon disrupts infravision within a 100 yard radius
    7616 Targetis weapon dissolves its wielderis clothes during battle
    7617 Targetis weapon doubles in weight after each failed strike
    7618 Targetis weapon doubles in weight each time it draws blood
    7619 Targetis weapon draws lightning bolts down from the sky
    7620 Targetis weapon drips with blood until it next draws blood
    7621 Targetis weapon drips with molasses during battle
    7622 Targetis weapon enables him to breathe underwater for 3d8 rounds
    7623 Targetis weapon explodes if ever it inflicts maximum damage
    7624 Targetis weapon floats on water as readily as wood
    7625 Targetis weapon giggles menacingly upon contact with blood
    7626 Targetis weapon glows as bright as the sun, but only to him
    7627 Targetis weapon glows blue except in the presence of orcs
    7628 Targetis weapon glows blue in his presence
    7629 Targetis weapon glows blue in the presence of orcs or birds
    7630 Targetis weapon glows blue in the presence of swords
    7631 Targetis weapon glows blue whenever he tries to remain hidden
    7632 Targetis weapon glows brightly when his blood has been spilled
    7633 Targetis weapon glows like a firefly when wielded underground
    7634 Targetis weapon glows red hot during battle but doesnit harm him
    7635 Targetis weapon grows to 10x its normal size
    7636 Targetis weapon has a +10 ToHit and Damage bonus for 1d4 rounds
    7637 Targetis weapon has a +4 bonus when used against him
    7638 Targetis weapon has a +4 bonus when used against his allies
    7639 Targetis weapon has a +4 bonus when used against the caster
    7640 Targetis weapon has a +4 bonus while heis standing in water
    7641 Targetis weapon has a -4 ToHit penalty while in direct sunlight
    7642 Targetis weapon has a constant sheath of frost
    7643 Targetis weapon has been broken and reforged many times
    7644 Targetis weapon has been prophesied to kill the king
    7645 Targetis weapon has never been tempered or hardened
    7646 Targetis weapon heats to 1,000° the next time it draws blood
    7647 Targetis weapon hisses during battle like quenched steel
    7648 Targetis weapon hums audibly during battle
    7649 Targetis weapon induces a fear of magic in anyone wounded by it
    7650 Targetis weapon induces pessimism in his allies during melee
    7651 Targetis weapon induces racial hatred in Dwarves and Elves
    7652 Targetis weapon induces vertigo in anyone wielding it
    7653 Targetis weapon induces vertigo in anyone wounded by it
    7654 Targetis weapon inflates like a balloon 
    7655 Targetis weapon inspires him to embark on a murderous rampage
    7656 Targetis weapon instills Fear in any whoive been wounded by it
    7657 Targetis weapon instills Fear in goblins and kobolds
    7658 Targetis weapon instills Fear in him after each battle
    7659 Targetis weapon instills Fear in his allies during battle
    7660 Targetis weapon instills Fear in its wielder during melee
    7661 Targetis weapon is 5% likely to explode when it inflicts damage
    7662 Targetis weapon is 5% likely to kill whomever it next injures
    7663 Targetis weapon is 5% likely to melt when immersed in water
    7664 Targetis weapon is 5% likely to sever its wielderis hand
    7665 Targetis weapon is 5% likely to start a war when it draws blood
    7666 Targetis weapon is 5% likely to turn to glass in each battle
    7667 Targetis weapon is +4 against anyone with an intelligent weapon
    7668 Targetis weapon is 10% likely to inflict tetanus upon its wielder
    7669 Targetis weapon is 20% likely to droop like a noodle in battle
    7670 Targetis weapon is 20% likely to poison him when it draws blood
    7671 Targetis weapon is 20% likely to turn ethereal during battle
    7672 Targetis weapon is 20% likely to vanish each time he draws it
    7673 Targetis weapon is a holy relic for a decadent tribe of kobolds
    7674 Targetis weapon is a legendary item straight out of myth
    7675 Targetis weapon is a mighty but hitherto unknown artifact
    7676 Targetis weapon is a prized relic stolen from the Royal Armory
    7677 Targetis weapon is as pliant as soft clay for 1d4 rounds
    7678 Targetis weapon is as supple as silk for 1d4 turns
    7679 Targetis weapon is bent into a torc around his neck
    7680 Targetis weapon is bent into the shape of a paperclip
    7681 Targetis weapon is chained by its hilt to a collar about his neck
    7682 Targetis weapon is chained by its hilt to the nearest boulder
    7683 Targetis weapon is clear like glass but is all but unbreakable
    7684 Targetis weapon is cloned
    7685 Targetis weapon is edible, but only to him
    7686 Targetis weapon is embarrassed to be seen with him
    7687 Targetis weapon is etched with his likeness
    7688 Targetis weapon is guilty of numerous capital crimes
    7689 Targetis weapon is highly elastic along its long axis until dawn
    7690 Targetis weapon is immune to rust and the passage of time
    7691 Targetis weapon is intensely coveted by demonic hordes
    7692 Targetis weapon is intensely coveted by pacifistic monks
    7693 Targetis weapon is invisible to everyone else during battle
    7694 Targetis weapon is invisible to him in daylight
    7695 Targetis weapon is invisible to him until it draws his blood
    7696 Targetis weapon is nearly indestructible but dissolves in water
    7697 Targetis weapon is part of a set sought by a wealthy collector
    7698 Targetis weapon is perfectly balanced for a non-magical +2 ToHit
    7699 Targetis weapon is permanently -2 ToHit
    7700 Targetis weapon is refurbished to better-than-new condition
    7701 Targetis weapon is replaced by a vastly inferior replica
    7702 Targetis weapon is replaced by an indestructible replica
    7703 Targetis weapon is riddled with holes but functions normally
    7704 Targetis weapon is sheathed in a scab-like shell
    7705 Targetis weapon is sheathed in a shell of chocolate
    7706 Targetis weapon is sheathed in a soft wool tube
    7707 Targetis weapon is stuck high in the branches of a nearby tree
    7708 Targetis weapon is suddenly 10d100 years older
    7709 Targetis weapon is thrown 1d1000 years into the past
    7710 Targetis weapon is tied to both of the targetis hands
    7711 Targetis weapon is translucent like smoked glass
    7712 Targetis weapon is twisted like a corkscrew
    7713 Targetis weapon is vulnerable to magical fire while he wields it
    7714 Targetis weapon is weightless when not in use
    7715 Targetis weapon kills him outright if used against him
    7716 Targetis weapon makes him 1d20 years older while itis drawn
    7717 Targetis weapon makes him appear somehow less imposing
    7718 Targetis weapon makes him highly susceptible illusion magic
    7719 Targetis weapon melts if ever itis immersed in sea water
    7720 Targetis weapon melts like a candle
    7721 Targetis weapon must be fed one mouse or rat per day, or it dies
    7722 Targetis weapon passes through armor unimpeded
    7723 Targetis weapon passes through flesh unimpeded
    7724 Targetis weapon practically reeks of malevolent hatred
    7725 Targetis weapon puts forth huge plumes of smoke while itis drawn
    7726 Targetis weapon renders him mute for 1d8 hours after each battle
    7727 Targetis weapon repels his allies while itis drawn
    7728 Targetis weapon repels non-magical vermin
    7729 Targetis weapon repels normal flame to a distance of one foot
    7730 Targetis weapon repels oxygen while itis drawn
    7731 Targetis weapon ridicules him in front of his allies
    7732 Targetis weapon rings like a bell to mark the hours
    7733 Targetis weapon shatters the next time heis burned by fire
    7734 Targetis weapon shatters the next time it strikes metal
    7735 Targetis weapon shrieks until sunset tomorrow
    7736 Targetis weapon shrinks by 75% upon contact with blood
    7737 Targetis weapon shrinks to 10% of its normal size
    7738 Targetis weapon spins rapidly around its axis for 10d10 rounds
    7739 Targetis weapon sprouts 1d100 teeth along its length
    7740 Targetis weapon sprouts leaves
    7741 Targetis weapon starts bleeding profusely
    7742 Targetis weapon teleports exactly 1d10 yards due north
    7743 Targetis weapon teleports to the casteris home
    7744 Targetis weapon teleports to the target, 1d4 weeks in the future
    7745 Targetis weapon thinks that heis its mother
    7746 Targetis weapon turns ethereal in the presence of other weapons
    7747 Targetis weapon turns inside-out
    7748 Targetis weapon turns into a rattan simulation
    7749 Targetis weapon turns into a replica of the casteris weapon
    7750 Targetis weapon turns into a shield for 1d4 days
    7751 Targetis weapon turns into a small glass replica when not in use
    7752 Targetis weapon turns into a two-by-four eight feet in length
    7753 Targetis weapon turns into an umbrella under each full moon
    7754 Targetis weapon turns to lightweight plastic
    7755 Targetis weapon turns to sodium during the next rainstorm
    7756 Targetis weapon urges him to leap from the nearest bridge
    7757 Targetis weapon vanishes until he dies
    7758 Targetis weapon vanishes when he dies
    7759 Targetis weapon was forged by his descendent years in the future
    7760 Targetis weapon was forged by someone who has never existed
    7761 Targetis weapon was forged from the bones of a slain god
    7762 Targetis weapon was forged in a volcano by demonic weaponsmiths
    7763 Targetis weapon was forged on the western slope of Heaven
    7764 Targetis weapon was lost in a tragic shipwreck decades ago
    7765 Targetis weapon was shrinks him by 5% each time it draws blood
    7766 Targetis weapon was stolen from the gods, and they want it back
    7767 Targetis weapon weighs as much as he does
    7768 Targetis weapon whispers terrible secrets to any who wield it
    7769 Targetis weapon will be instrumental in the worldis destruction
    7770 Targetis weapon will be irretrievably lost by this time tomorrow
    7771 Targetis weapons and gear teleport 10d10 yards into the air
    7772 Targetis weight quadruples while heis swimming or wading
    7773 Targetis weight temporarily doubles with each step upon a bridge
    7774 Teleportation is impossible within 10 yards of target
    7775 The bones of targetis hand and feet turn to high-grade steel
    7776 The buzzing of bees fills the air whenever target draws a weapon
    7777 The flesh of targetis face pulses as though full of maggots
    7778 The ground beneath targetis feet briefly acts as a trampoline
    7779 The ground beneath targetis feet briefly shines like the sun
    7780 The ground beneath targetis feet collapses into a cave below
    7781 The ground beneath targetis feet contains an unquiet spirit
    7782 The ground now at targetis feet acquires sentience
    7783 The ground now at targetis feet appears in the casteris home
    7784 The ground now at targetis feet breaks off and drifts out to sea 
    7785 The ground now at targetis feet collapses into a cavern below
    7786 The ground now at targetis feet conceals a sacred cairn
    7787 The ground now at targetis feet explodes for 10d10 hit points
    7788 The ground now at targetis feet exudes noxious and fetid vapors
    7789 The ground now at targetis feet heats to 10 x 1d100 degrees
    7790 The ground now at targetis feet hides the gate to a buried city
    7791 The ground now at targetis feet hurls him 1d4 miles away
    7792 The ground now at targetis feet is a blanket over a deep pit
    7793 The ground now at targetis feet is a portal to some nether plane
    7794 The ground now at targetis feet is an illusion
    7795 The ground now at targetis feet is charred black as by a bonfire
    7796 The ground now at targetis feet is dangerously slick with ice
    7797 The ground now at targetis feet is edible
    7798 The ground now at targetis feet is forever barren of vegetation
    7799 The ground now at targetis feet is fused into glass
    7800 The ground now at targetis feet is intensely magnetic
    7801 The ground now at targetis feet is invisible to him
    7802 The ground now at targetis feet is obviously artificial
    7803 The ground now at targetis feet is powerfully toxic to him
    7804 The ground now at targetis feet is soaked with blood
    7805 The ground now at targetis feet is strewn with shards of metal
    7806 The ground now at targetis feet is strongly adhesive
    7807 The ground now at targetis feet is the back of a huge turtle
    7808 The ground now at targetis feet is the top of a buried column
    7809 The ground now at targetis feet is yanked from under him
    7810 The ground now at targetis feet rises 10d10 yards into the air
    7811 The ground now at targetis feet seems to move like a shipis deck
    7812 The ground now at targetis feet shines as bright as the sun
    7813 The ground now at targetis feet sinks 1d10 yards into the ground
    7814 The ground now at targetis feet starts to digest him
    7815 The ground now at targetis feet suppresses magic within 10 yards
    7816 The ground now at targetis feet turns to cement and hardens
    7817 The ground now at targetis feet turns to cobblestone
    7818 The ground now at targetis feet turns to molten glass
    7819 The ground now at targetis feet turns to quicksand
    7820 The ground now at targetis feet turns to warm butter
    7821 The ground now at targetis feet whispers horrific threats to him
    7822 The left half of targetis skeleton rebels against the right
    7823 The left half of targetis skeleton vanishes
    7824 The right half of targetis head vanishes, but he is unharmed
    7825 The scent of the targetis blood induces Fear in others
    7826 The scent of the targetis blood induces paranoid delusions
    7827 The scent of the targetis blood induces profound calm in horses
    7828 The scent of the targetis blood inspires savage bloodlust
    7829 The sight of the targetis weapon affects undead like sunlight
    7830 The sight of the targetis weapon induces intense covetousness
    7831 The target is blamed for the worst thing that has ever happened
    7832 The target takes credit for all sorts of diplomatic successes
    7833 The top few inches of targetis head vanish, but he is unharmed
    7834 Thousands of nails are embedded harmlessly in targetis flesh
    7835 Thousands of snails rain down harmlessly upon the target
    7836 To the target, all liquids taste like acrid poison
    7837 To the target, all liquids taste like his own blood
    7838 To the target, all liquids taste like strong vinegar
    7839 To the target, all liquids taste like the sweetest nectar
    7840 To the target, everyone appears to be a hideously decayed corpse
    7841 To the target, everyone appears to be an artificial approximation
    7842 To the target, everyone appears to be plated in gold
    7843 To the target, the previous 1d4 rounds were only a dream
    7844 Undead are attracted to the target as though he can help them
    7845 Undead are invisible to the target
    7846 Undead canit speak in the targetis presence
    7847 Undead declare a coordinated war against the target
    7848 Undead ignore target and canit be harmed by him
    7849 Undead recognize the target as one of their own
    7850 Undead that attack the target are 40% likely to be Turned
    7851 Undead will not relent until the target is also undead
    7852 Until dawn, target resembles the person who last wounded him
    7853 Until sunset tonight, all within one mile want to kill the target
    7854 Vines bind the target tightly to a nearby tree
    7855 Vines sprout from any open wounds the target now has
    7856 Vines sprout from the ground at targetis feet and attack him
    7857 Vines sprout from the targetis weapon and bind his limbs
    7858 Viscous slime drips from the targetis mouth from now on
    7859 Water always feels 50° colder to the target
    7860 Water boils on contact with the targetis flesh
    7861 Water gives no benefit to target if imbibed while indoors
    7862 Water has no weight when carried by the target
    7863 Water induces amnesia in target if ingested between dawn and noon
    7864 Water is a deadly poison to target for 2d12 hours
    7865 Water is invisible while within 10 feet of the target
    7866 Water is toxic to target if ingested between noon and dusk
    7867 Water spews from targetis ears during battle
    7868 Waterfowl attack the target on sight
    7869 Waterfowl swear eternal loyalty to the target
    7870 Weapons are invisible to the target while he wields them
    7871 Whatever is now in targetis hand heats to 500°
    7872 Whatever is now in targetis hand is embossed with his name
    7873 Whatever is now in targetis hand is replaced by a sunflower
    7874 Whatever is now in targetis hand is worth 10X its normal value
    7875 Whatever is now in targetis hand now belongs to the caster
    7876 Whatever is now in targetis hand turns to gold
    7877 Whatever is now in targetis hand vanishes for 1d6 days
    7878 Whatever is now in targetis hand weighs more than he does
    7879 Whatever target does, he claims some bizarre, fantastical motive
    7880 Whatever target does, he claims to be fulfilling his deityis will
    7881 Whatever target is wearing is stuck to him like glue
    7882 When caster dies, target begins aging 1d10 years per round
    7883 When injured, target is 5% likely to fly into a berserker rage
    7884 When injured, target is 10% likely to attack his nearest ally
    7885 When injured, target must Save or go blind until the next round
    7886 When injured, target weeps like a baby for 1d10 rounds
    7887 When target dies, all within one mile are struck blind until dawn
    7888 When target dies, countless abhorrent deeds are attributed to him
    7889 When target dies, everyone who knew him forgets all about him
    7890 When target dies, he is posthumously crowned king
    7891 When target dies, he is rumored never to have existed
    7892 When target dies, heis immediately resurrected 10d100 miles away
    7893 When target dies, his corpse animates and races to this spot
    7894 When target dies, his corpse attacks the nearest person
    7895 When target dies, his corpse burns with green flame until sunset
    7896 When target dies, his corpse grows by a factor of 2d10
    7897 When target dies, his corpse immediately turns to granite
    7898 When target dies, his corpse metamorphoses into something awful
    7899 When target dies, his corpse runs wild through the nearest town
    7900 When target dies, his corpse teleports into the casteris home
    7901 When target dies, his killer is hailed as a national hero
    7902 When target dies, his killer is named his executor
    7903 When target dies, his skeleton animates as a free willed undead
    7904 When target dies, his soul commandeers the nearest undead body
    7905 When target dies, his soul is trapped in his weapon
    7906 When target draws a weapon, a nearby tree drops its leaves
    7907 When target draws a weapon, he canit put it down until sunset
    7908 When target draws a weapon, he feels that heill die in 1d6 rounds
    7909 When target draws a weapon, he must declare his name and title
    7910 When target draws a weapon, he must draw blood within 1d6 rounds
    7911 When target draws a weapon, he must pass a DEX check or drop it
    7912 When target draws a weapon, he must Save or lose 1d4-1 hit points
    7913 When target draws a weapon, heis randomly teleported 1d20 yards
    7914 When target draws a weapon, heis stricken with intense fear 
    7915 When target draws a weapon, heis stunned for 1d4 rounds
    7916 When target draws a weapon, his allies all shout his name
    7917 When target draws a weapon, his weapon arm glows like a firefly
    7918 When target draws a weapon, it costs him 1d4 gold pieces
    7919 When target draws a weapon, it turns invisible for 1d4 rounds
    7920 When target draws a weapon, me must Save or become wildly drunk
    7921 When target draws a weapon, someone nearby declares him a coward
    7922 When target draws a weapon, someone nearby laughs at him
    7923 When target draws a weapon, the scent of eggs fills the air
    7924 When target is next struck by magic, he becomes chaotic evil
    7925 When target is next struck by magic, he becomes powerfully drunk
    7926 When target is next struck by magic, he hates that spellis caster
    7927 When target is next struck by magic, he teleports 1d6 miles
    7928 When target next sleeps, a small tree sprouts from his chest
    7929 When target next sleeps, everyone nearby dreams of killing him
    7930 When target next sleeps, he sleeps for 2d20 days and nights
    7931 When target next spills blood, any coins heis holding are doubled
    7932 When target next spills blood, he finds 1d1000 gold pieces
    7933 When target next spills blood, he is excommunicated and condemned
    7934 When target next spills blood, he loses 1d10 hit points
    7935 When target next spills blood, he loses any wealth heis carrying
    7936 When target next spills blood, he regains 1d10 hit points
    7937 When target next spills blood, he suffers cannibalistic urges
    7938 When target next spills blood, he suffers dreadful hallucinations
    7939 When target next spills blood, he takes a vow of pacifism
    7940 When target next spills blood, he thinks heill die by nightfall
    7941 When target next spills blood, he vanishes for 1d4 days
    7942 When target next spills blood, heis thrown 4d8 yards into the air
    7943 When target next spills blood, his allies attack him
    7944 When target next spills blood, his clothes are soaked in it
    7945 When target next spills blood, his clothes burst into flame
    7946 When target next spills blood, his feet take root in the ground
    7947 When target next spills blood, his allies think heis dying
    7948 When target next spills blood, his skin and hair become blood-red
    7949 When target next spills blood, his Strength is halved until dawn
    7950 When target next spills blood, his victim grows obsessed with him
    7951 When target next spills blood, his waterskin fills with blood
    7952 When target next spills blood, his weapon attacks him
    7953 When target next spills blood, his weapon steams and hisses
    7954 When target next spills blood, his weapon vanishes for 1d4 days
    7955 When target next uses rope, he ties an insoluble knot
    7956 When target next uses rope, heis attacked by undead skeletons
    7957 When target next uses rope, it attacks him as if it were a snake
    7958 When target next uses rope, it hauls him high into the air
    7959 When target next uses rope, it shocks him like electrical wire
    7960 When target next uses rope, it winds around him and combusts
    7961 When target rolls a natural 20 ToHit, he wounds himself instead
    7962 When target rolls a natural 20 ToHit, his weapon explodes
    7963 When target says his name, he adds a wildly effusive honorific
    7964 When target says his name, he canit tell a lie for one hour
    7965 When target says his name, his age doubles
    7966 When target says his name, his clothes are soaked with brine
    7967 When target says his name, his clothes become amazingly clean
    7968 When target says his name, mocking laughter echoes in the sky
    7969 When target says his name, someone nearby adopts his name
    7970 When target says his name, someone nearby forgets his own name
    7971 When target says his name, someone nearby weeps openly
    7972 When target sees or is hit by magic, he giggles for 1d10 rounds
    7973 When target sees or is hit by magic, his head becomes invisible
    7974 When target sneezes, 1d4 nearby trees are rendered invisible
    7975 When target sneezes, bits of hot gravel spray from his nostrils
    7976 When target uses magic, he thinks heis spinning rapidly
    7977 While outdoors, target feels uncomfortable walking upright
    7978 While outdoors, target perceives everything to be shrouded in fog
    7979 While target sleeps, he dreams that heis in hell
    7980 While target sleeps, he dreams that heis undergoing surgery
    7981 While target sleeps, he is invisible and inaudible to his allies
    7982 While target sleeps, he sees and hears through the caster
    7983 While target sleeps, heis 40% likely to regain 1d10 hit points
    7984 While target sleeps, heis absolutely invulnerable to harm
    7985 While target sleeps, heis bound by countless spider webs
    7986 While target sleeps, his body races away in a random direction
    7987 While target sleeps, his clothes deteriorate to filthy rags
    7988 While target sleeps, someone writes obscene limericks on his skin
    7989 While target stands still, he rotates slowly counter-clockwise
    7990 While target stands still, pigeons treat him just like a statue
    7991 Yesterday, target ate 1d10 pounds of baked beans
    7992 Yesterday, target had dark premonitions of this exact moment
    7993 Yesterday, target ingested some powerful but slow-acting poison
    7994 Yesterday, target learned that he and caster are closely related
    7995 Yesterday, target learned that he had 36 hours left to live
    7996 Yesterday, target stole a magic ruby from a dragon
    7997 Yesterday, target took a sacred vow that he just now violated
    7998 Yesterday, target was sentenced to be executed at dawn tomorrow
    7999 Yesterday, targetis feet were burned to a crisp
    8000 Yesterday, targetis head was removed and shoddily reattached
    8001 1,000 cubic feet of dirt and rock rise as a 16HD earth elemental
    8002 1d10 nearby trees uproot and race to the nearest town square
    8003 1d10 nearby trees uproot and vanish into the sky
    8004 1d100 adorable but demonic puppies scamper through the area
    8005 1d100 skeletons rise from the ground and begin building a pyramid
    8006 1d100 stone spheres, one foot in diameter, appear in the area
    8007 1d100% of a major continent sinks beneath the sea
    8008 1d1000 clay bricks fall from the sky
    8009 1d1000 skeletons rise from the ground and march to the sea
    8010 1d20 skeletons rise from the ground and attack anyone nearby
    8011 1d4 creatures nearby are suddenly gold-plated
    8012 1d4 creatures nearby double in size
    8013 1d4 gallons of molten gold pour from the target point
    8014 1d4 magical golden apples appear nearby
    8015 1d6 aggressive, human-sized pigeons appear in the area
    8016 1d6 horses nearby are turned into carousel horses
    8017 1d6 people nearby adopt entirely new personalities
    8018 1d6 people nearby are 50% likely to gain a level or die outright
    8019 1d6 people nearby are chained together
    8020 1d6 people nearby are duplicated exactly
    8021 1d6 people nearby are hurled high into the air
    8022 1d6 people nearby are identified as harbingers of vile pestilence
    8023 1d6 people nearby are pulled into the target point and destroyed
    8024 1d6 people nearby are tarred and feathered
    8025 1d6 people nearby are teleported 1d4 miles
    8026 1d6 people nearby are unable to wield weapons for 1d8 hours
    8027 1d6 people nearby can breathe water as readily as air
    8028 1d6 people nearby feel like theyire drowning
    8029 1d6 people nearby flee from the area at top speed
    8030 1d6 people nearby grow feathers like peacocks
    8031 1d6 people nearby grow wool like sheep
    8032 1d6 people nearby join forces against all others nearby
    8033 1d6 people nearby look exactly alike
    8034 1d6 people nearby look like children for 1d4 years
    8035 1d6 people nearby must Save or be Disintegrated
    8036 1d6 people nearby shrink by 5d10+50%
    8037 1d6 people nearby will become zombies in 3d6 days
    8038 2d100 spectators appear in the area
    8039 2d100 wild bulls appear in the area
    8040 4d10 duplicates of someone nearby appear in the area
    8041 4d100 zombies appear in the area and race to the nearest town
    8042 4d100 zombies appear in the area and start attacking
    8043 A 100 yard radius is blanketed by a thick cloud of chlorine gas
    8044 A 100 yard radius is blanketed by snow to a depth of 2d4 feet 
    8045 A 100 yard radius is carpeted with small white pebbles
    8046 A 100 yard radius is covered by a dense growth of fragrant grass
    8047 A 100 yard radius is covered by ankle-deep fetid mud
    8048 A 100 yard radius is covered by ankle-deep white sand
    8049 A 100 yard radius is covered by slimy, decaying vegetable matter
    8050 A 100 yard radius is covered with acrid cinders and ash
    8051 A 100 yard radius is covered with nuggets of artificial stone
    8052 A 100 yard radius is discovered to be an ancient graveyard
    8053 A 100 yard radius is encircled by a dense curtain of smoke
    8054 A 100 yard radius is encircled by a moat of lava 20 feet across
    8055 A 100 yard radius is encircled by a ring of raised earth
    8056 A 100 yard radius is encircled by a wall of hay bales
    8057 A 100 yard radius is indistinguishable from the moonis surface
    8058 A 100 yard radius is rendered totally silent until dawn tomorrow
    8059 A 100 yard radius is shaken by a powerful earthquake for 1d4 days
    8060 A 100 yard radius is strewn with blood-soaked rags
    8061 A 100 yard radius is strewn with decaying marine life
    8062 A 100 yard radius is strewn with jagged metal and coils of wire
    8063 A 100 yard radius is strewn with seashells and driftwood
    8064 A 100 yard radius is stripped of vegetation, soil, and water
    8065 A 100 yard radius swirls with finely-milled flour for 1d6 turns
    8066 A 1d10 mile radius becomes a dense and temperate forest
    8067 A 1d10 mile radius becomes a pastoral idyll
    8068 A 1d10 mile radius becomes a peaceful lake
    8069 A 1d10 mile radius becomes an arid and desolate desert
    8070 A 5,000 pound iron slab appears 1d10 yards above the target point
    8071 A baby born in a nearby town is prophesied to destroy the kingdom
    8072 A baby born in a nearby town is the spawn of a powerful demon
    8073 A blasphemous tome appears at the target point
    8074 A charred human corpse bearing a magical sword appears nearby
    8075 A column of green light shines from the target point into the sky
    8076 A cube of dry ice 10 feet across appears at the target point
    8077 A cube of granite 10 feet across appears a the target point
    8078 A deafening cacophony blares from the target point until sunset
    8079 A deity has died, and someone nearby is blamed for his death
    8080 A dense tangle of thorny vines fills the area
    8081 A featureless black slab appears nearby measuring 1 x 4 x 9
    8082 A fissure runs from beneath the target point to the nearest lake
    8083 A flaming sword appears at the target point, turning every way
    8084 A flock of 5d20 human-sized geese lands in the area
    8085 A four-dimensional cube appears at the target point
    8086 A fully outfitted galleon appears nearby
    8087 A gargantuan, tentacled monstrosity rises from the nearest ocean
    8088 A giant sequoia quickly grows from beneath the target point
    8089 A heavy rope runs from the target point into the sky
    8090 A herd of animals not native to this area stampedes through it
    8091 A horrifyingly loathsome creature races through the area
    8092 A huge army appears to be approaching from the distance
    8093 A huge city is just barely visible on the surface of the moon
    8094 A huge earthen fist rises from the ground below the target point
    8095 A huge glacier forms at the target point over the next 1d4 days
    8096 A huge outcrop of beautiful crystals erupts under the target point
    8097 A huge vein of highly toxic metal runs directly under this area
    8098 A huge volume of confetti rains down in a 100 yard radius
    8099 A jug full of highly volatile liquid appears at the target point
    8100 A large pool of fetid slime appears beneath the target point
    8101 A large pool of liquid helium appears beneath the target point
    8102 A large pool of molten aluminum appears beneath the target point
    8103 A large, hay-packed wooden crate marked "FRAGILE" appears nearby
    8104 A leather briefcase containing something beautiful appears nearby
    8105 A local ruler declares any use of magic to be treasonous
    8106 A local ruler declares some crazy new taboo punishable by death
    8107 A local ruler has a mad plan to tax the poor instead of the rich
    8108 A local ruler has ordered the execution of 1d4 people nearby
    8109 A local ruler has quite obviously sold his soul to a demon
    8110 A local ruler invades a sovereign nation under false pretenses
    8111 A local ruler is known to kill and eat 1d4 people each week
    8112 A local ruler is revealed to be an illusion
    8113 A local ruler is under the control of infernal powers
    8114 A local ruler orders the execution of anyone causing a Chaos Burst
    8115 A local ruler shames his title with interpersonal indiscretions
    8116 A local ruler values empty rhetoric over valid policy
    8117 A lump of heavy and very toxic metal appears at the target point
    8118 A massive explosion flattens all stone structures within one mile
    8119 A mighty hailstorm pummels the area for 1d4 hours
    8120 A mysterious gold sarcophagus appears at the target point
    8121 A new, non-magical, and deadly virus issues from the target point
    8122 A one mile radius appears gloomy and blighted for 1d12 months
    8123 A one mile radius is illuminated by full daylight for 3d10 days
    8124 A one mile radius is rotates 360° every 24 hours
    8125 A one mile radius is shrouded by an eclipse for 2d8-1 days
    8126 A one mile radius looks like a desert wasteland for one year
    8127 A perfect 10 foot sphere of ice appears at the target point
    8128 A pitiable demon appears at the target point, begging sanctuary
    8129 A powerful and malign spirit emerges from the target point
    8130 A powerful and radical religious sect usurps the throne
    8131 A powerful demon takes up residence in a nearby house
    8132 A powerful earthquake shifts this whole area one mile north
    8133 A sandstorm sweeps through the area for 2d6 turns
    8134 A sculpted ice portrait appears for everyone within 50 yards
    8135 A small, mysterious island appears in the nearest river
    8136 A sphere of annihilation appears at the spellis target point
    8137 A steel tower 100 yards tall emerges form under the target point
    8138 A stolen dragon egg appears at the target point
    8139 A stone cube 25 yards across rises from beneath the target point
    8140 A terrible din fills the air like the clanging of pots and pans
    8141 A terrible fire occurred on this site 4d6 hours ago
    8142 A terrible fire will occur on this site 4d6 hours from now
    8143 A thin shaft of stone runs from the target point to the sea
    8144 A tornado arises at the target point and devastates the area
    8145 A torrent of thick, soapy foam sprays from the target point
    8146 A viscous corrosive fluid drips coats all exposed rock nearby
    8147 A volcano erupts at the center of the nearest town
    8148 A volley of 10d20 arrows rains down on the area
    8149 A widespread peasantsi revolt begins in 1d12 hours
    8150 A Chaos Burst occurs when each of the next 1d4 people speak nearby
    8151 Abnormally large locusts plague the area for 1d8 weeks
    8152 Acrid fungus sprouts under the target point and quickly spreads
    8153 Air in this area is 75% thinner than the surrounding atmosphere
    8154 All air within one mile is totally opaque but otherwise normal
    8155 All armor removed in this area shrinks by 25%
    8156 All armor within 50 yards becomes clear like glass
    8157 All armor within 50 yards is as heavy as lead
    8158 All armor within 50 yards is weightless for 1d12 months
    8159 All armor within one mile is ethereal until sunset
    8160 All artificial light sources within one mile are rendered inert
    8161 All artificial structures within 50 yards cease to exist
    8162 All attack rolls in the next 1d10 rounds must be made twice
    8163 All bags of holding within one mile are completely full of anvils
    8164 All birds within 50 yards explode, 1d6 hit points per bird
    8165 All birds within one mile are completely plucked
    8166 All bladed weapons within 50 yards are intensely magnetic
    8167 All blades within 50 yards are 10% likely to turn to gold
    8168 All blades within 50 yards are engraved with cryptic sigils
    8169 All blades within 50 yards are restored to pristine condition
    8170 All blades within 50 yards become clear like glass
    8171 All blades within 50 yards bend 90° halfway along their length
    8172 All blades within 50 yards must Save or crumble into rust
    8173 All blades within one mile are blunted until sunset
    8174 All blades within one mile glow cherry red until sunset tomorrow 
    8175 All bowstrings within 50 yards break the next time theyire drawn
    8176 All carved wood within 50 yards gains rudimentary intelligence
    8177 All chain mail within 50 yards appears moth-eaten and threadbare
    8178 All chain mail within 50 yards is highly attractive to lightning
    8179 All chain mail within 50 yards is slicked with ice
    8180 All chain mail within 50 yards is strongly magnetic
    8181 All cloth within 50 yards begins to digest itself
    8182 All cloth within 50 yards can never be rendered invisible
    8183 All cloth within 50 yards is as shiny and lustrous as gold
    8184 All cloth within 50 yards is rendered as brittle as eggshell
    8185 All cloth within 50 yards is rendered as stiff as wood
    8186 All cloth within 50 yards is scrubbed clean
    8187 All cloth within 50 yards is soaked with gasoline
    8188 All cloth within 50 yards seems unusually heavy
    8189 All cloth within 50 yards smolders and smokes until dawn
    8190 All cloth within 50 yards turns invisible upon exiting the area
    8191 All cloth within 50 yards turns to burlap until sunset tomorrow
    8192 All cloth within one mile is invisible until sunset tomorrow
    8193 All coins within 50 yards appear in a heap at the target point
    8194 All coins within 50 yards are engraved with cryptic runes
    8195 All coins within 50 yards are invisible under moonlight
    8196 All coins within 50 yards become flexible as rubber
    8197 All coins within 50 yards double in value
    8198 All coins within 50 yards explode, 1d4-1 hit points per coin
    8199 All coins within 50 yards heat to 1,000°
    8200 All coins within 50 yards turn to mercury
    8201 All coins within one mile are easily recognized as counterfeit
    8202 All curses now in effect within 100 yards are negated
    8203 All dragons within 1d10 miles are enraged beyond all reason
    8204 All dragons within 1d10 miles shrink by 10d10%
    8205 All Dwarves within 10 miles are secretly fond of orcs
    8206 All Dwarves within 10 miles are violently allergic to alcohol
    8207 All Dwarves within 10 miles are violently allergic to gold
    8208 All Dwarves within 10 miles become intensely claustrophobic
    8209 All Dwarves within 10 miles have orange skin and green hair
    8210 All Dwarves within 10 miles lose their infravision for 1d4 months
    8211 All Elves within 10 miles are carrying vials of Dwarf blood
    8212 All Elves within 10 miles develop a powerful fear of heights
    8213 All Elves within 10 miles forget how to speak Elvish
    8214 All Elves within 10 miles sprout jagged fangs
    8215 All Elves within 50 yards are allergic to wood
    8216 All ferrous metal within 50 yards doubles in weight
    8217 All ferrous metal within 50 yards is as shiny & lustrous as gold
    8218 All ferrous metal within 50 yards is invisible until it gets wet
    8219 All ferrous metal within 50 yards is magnetized
    8220 All ferrous metal within 50 yards is rustproof for one year
    8221 All ferrous metal within 50 yards is somewhat resistant to magic
    8222 All ferrous metal within 50 yards is strangely opalescent
    8223 All ferrous metal within 50 yards vanishes until sunset tomorrow
    8224 All fires lit in this area are waterproof for the next 1d6 weeks
    8225 All fires lit in this area flare up wildly for 1d4 rounds
    8226 All fires lit in this area reek of brimstone
    8227 All flesh within 50 yards is clear like glass until sunset
    8228 All foliage within 50 yards is poisonous to humans and demihumans
    8229 All foliage within 50 yards is replaced by plastic replicas
    8230 All food consumed within one mile is overpoweringly delicious
    8231 All food consumed within one mile is unpalatably bitter
    8232 All food within 50 yards completely spoils by sunset
    8233 All food within 50 yards freezes solid
    8234 All food within 50 yards is crawling with illusory maggots
    8235 All food within 50 yards is poisonous for the next 1d4 hours
    8236 All food within 50 yards is stripped of all nutritive value
    8237 All food within one mile turns to salt
    8238 All footprints within one mile fossilize by dawn tomorrow
    8239 All forged steel within 100 yards turns to aluminum
    8240 All forged steel within 100 yards turns to slate
    8241 All gems within 50 yards are duplicated exactly
    8242 All gems within 50 yards become spherical
    8243 All gems within 50 yards turn to sodium when placed in water
    8244 All gems within 50 yards vibrate in the presence of gold
    8245 All Gnomes within 10 miles develop a dislike of gems and jewels
    8246 All Gnomes within 10 miles grow 1d20 inches
    8247 All goblins within 10 miles appear in the immediate area
    8248 All goblins within 10 miles are afraid of the dark
    8249 All goblins within 10 miles are exterminated
    8250 All goblins within 10 miles are transformed into Elves
    8251 All goblins within 10 miles become vegetarian pacifists
    8252 All goblins within 10 miles swear allegiance to someone nearby
    8253 All goblins within 10 miles swear vengeance upon someone nearby
    8254 All gold within 50 yards always seems to be 200°
    8255 All gold within 50 yards becomes transparent when submerged
    8256 All gold within 50 yards begins to rust like damp steel
    8257 All gold within 50 yards induces extreme covetousness
    8258 All gold within 50 yards is 10% likely to turn to lead
    8259 All gold within 50 yards is 50% likely to be counterfeit
    8260 All gold within 50 yards is attracted to magnets like iron
    8261 All gold within 50 yards is drawn to the target point
    8262 All gold within 50 yards is indestructible for one year
    8263 All gold within 50 yards is irresistibly attractive to undead
    8264 All gold within 50 yards is severely tarnished
    8265 All gold within 50 yards is thrown 1d10 years into the future
    8266 All gold within 50 yards is weightless for 2d10 rounds
    8267 All gold within 50 yards sweats some kind of foul liquid
    8268 All ground within 10 miles is at exactly the same elevation
    8269 All Halflings within 10 miles develop a penchant for violence
    8270 All Halflings within 10 miles develop a strong wanderlust
    8271 All hats or helmets within 50 yards are drawn to the target point
    8272 All hats or hoods within 50 yards burst into flame
    8273 All herbivores within 100 yards are panic-stricken
    8274 All horses within 100 yards have built-in saddles
    8275 All horses within 100 yards shrink by 1% per round
    8276 All horses within one mile become bipedal for 1d4 weeks
    8277 All horses within one mile become clear like glass
    8278 All houses within one mile appear to be of much higher quality
    8279 All houses within one mile are fireproof for one year
    8280 All humans within 10 miles are suddenly wearing peculiar hats
    8281 All humans within 10 miles think that demihumans are subhuman
    8282 All inanimate matter nearby wobbles as though made of gelatin
    8283 All ink within 50 yards appears to be made from human blood
    8284 All ink within 50 yards is powerfully hallucinogenic
    8285 All ink within one mile is invisible for 2d4-1 days
    8286 All ink within one mile is invisible in sunlight
    8287 All inorganic matter within 10 miles appears blurry until sunset
    8288 All inorganic matter within 10 yards disappears
    8289 All inorganic matter within 10 yards turns to ice
    8290 All inorganic matter within 50 yards appears to be magical
    8291 All invisible matter within 100 yards becomes permanently visible
    8292 All invisible matter within one mile is clear like glass
    8293 All leather within 50 yards begins sweating profusely
    8294 All leather within 50 yards is as rigid as steel
    8295 All leather within 50 yards shatters like glass
    8296 All leather within 50 yards turns to silk
    8297 All living creatures nearby are driven away for 1d4 months
    8298 All living creatures nearby are enraged beyond reason
    8299 All lycanthropes within one mile are cured of their lycanthropy
    8300 All lycanthropes within one mile are locked in their current form
    8301 All lycanthropes within one mile develop a great fear of the dark
    8302 All lycanthropes within one mile have a new kind of lycanthropy
    8303 All magic items used nearby are 10% likely to burn out forever
    8304 All magic items within 50 yards appear to be blazing with fire 
    8305 All magic items within 50 yards are easily recognized as magical
    8306 All magic items within 50 yards disappear until sunset tomorrow
    8307 All magic items within 50 yards fail to function 20% of the time
    8308 All magic items within 50 yards hum softly for 1d4 days
    8309 All magic potions within 50 yards are 10X as powerful
    8310 All magic potions within 50 yards are powerfully toxic
    8311 All magic potions within 50 yards are rendered inert
    8312 All magic potions within 50 yards become Potions of Flying
    8313 All magic potions within 50 yards freeze solid when imbibed
    8314 All magic potions within 50 yards induce overwhelming thirst
    8315 All magic potions within 50 yards induce wild hallucinations
    8316 All magic potions within 50 yards yield the opposite effect
    8317 All magic rings within 50 yards appear at the target point
    8318 All magic rings within 50 yards are identical in appearance
    8319 All magic rings within 50 yards are inert for one week
    8320 All magic rings within 50 yards are now as large as hula hoops
    8321 All magic rings within 50 yards are unharmed by fire or heat
    8322 All magic rings within 50 yards attract lightning
    8323 All magic rings within 50 yards fuse to their wearersi fingers
    8324 All magic rings within 50 yards grant a +1 Armor Class bonus
    8325 All magic rings within 50 yards must Save or Disintegrate
    8326 All magic rings within 50 yards shine as brightly as the Sun
    8327 All magic rings within 50 yards shrink by 10% with each use
    8328 All magic rings within 50 yards turn to crystal
    8329 All magic rings within 50 yards turn to lead while not being worn
    8330 All magic rings within 50 yards whistle softly while in use
    8331 All magic weapons nearby are ethereal until sunset
    8332 All magic weapons nearby gain an additional +1 ToHit for 1d6 days
    8333 All magic weapons nearby glow like fireflies under the new moon
    8334 All magic weapons nearby lose their enchantments until dawn
    8335 All magic weapons within 100 yards are non-magical for 1d4 days
    8336 All magical animals nearby become their non-magical equivalents
    8337 All magical animals nearby desire to leave the area
    8338 All magical garments within one mile are filthy and foul-smelling
    8339 All magical garments within one mile burst into flame
    8340 All magical light sources within 100 yards are 2X as bright
    8341 All magical light sources within 100 yards dim by 50%
    8342 All magical light sources within one mile are extinguished
    8343 All magical light sources within one mile are hot as normal fire
    8344 All magical light sources within one mile attract magical moths
    8345 All magical light sources within one mile flash like strobes
    8346 All magical light sources within one mile hum loudly while in use
    8347 All magical light sources within one mile only work underground
    8348 All magical light sources within one mile produce blood-red light
    8349 All magical light sources within one mile yield darkness instead
    8350 All mechanical locks within one mile are fused shut
    8351 All mechanical locks within one mile are invisible for 1d12 months
    8352 All mechanical locks within one mile can only open under moonlight
    8353 All mechanical locks within one mile spring open
    8354 All members of a major race are discovered to be artificial
    8355 All members of a major race are rendered sterile
    8356 All metal armor nearby has been soaking in vinegar
    8357 All metal armor nearby is chilled to freezing
    8358 All metal gauntlets within 50 yards are non-removable until dawn
    8359 All metal gauntlets within 50 yards are rustproof
    8360 All metal gauntlets within 50 yards cause terrible chafing
    8361 All metal gauntlets within 50 yards close into fists
    8362 All metal gauntlets within 50 yards heat to 400°
    8363 All metal gauntlets within 50 yards insulate against electricity
    8364 All metal gauntlets within 50 yards shrink by 25%
    8365 All metal gauntlets within 50 yards turn to silk
    8366 All metal weapons wielded nearby seem to be 500°
    8367 All metal within 50 yards appears to be made of solid shadow
    8368 All metal within 50 yards induces frostbite while in daylight
    8369 All metal within 50 yards is entirely non-reflective
    8370 All metal within 50 yards is flammable for 2d10 rounds
    8371 All metal within 50 yards is indestructible until sunset tomorrow
    8372 All metal within 50 yards is invisible when anointed with blood
    8373 All metal within 50 yards is non-conductive of electricity
    8374 All metal within 50 yards is polished to mirror-brightness
    8375 All metal within 50 yards is twice as heavy when itis wet
    8376 All metal within 50 yards liquefies for 2d6 rounds, then reforms
    8377 All metal within 50 yards shimmers like mother of pearl
    8378 All missile weapons within 50 yards are inoperative until sunset
    8379 All missile weapons within 50 yards combust when theyire fired
    8380 All missile weapons within 50 yards have 2X normal maximum range
    8381 All missile weapons within 50 yards vanish when theyire fired
    8382 All nearby age 3d20 years but return to normal at sunset tomorrow
    8383 All nearby must eat their meat, or they canit have any pudding
    8384 All nearby whoive drawn blood in the past day are deaf until dawn
    8385 All nearby whoive drawn blood in the past day weep for 3d8 rounds
    8386 All nearby with more than 10 gold pieces age that many years
    8387 All nearby with more than 10 gold pieces give it all to charity
    8388 All nearby with more than 10 gold pieces heal as many hit points
    8389 All nearby with more than 10 gold pieces lose as many hit points
    8390 All nearby with more than 10 gold pieces pass out for 1d8 hours
    8391 All nearby with more than 10 gold pieces teleport that many yards
    8392 All nonliving wood within 50 yards is as brittle as a pretzel
    8393 All nonliving wood within 50 yards is as pliant as grass
    8394 All non-magical animals nearby are healed of all disease
    8395 All non-magical animals nearby are restored to full hit points
    8396 All non-magical animals nearby shrink by 40%
    8397 All non-magical books within 50 yards are duplicated
    8398 All non-magical books within 50 yards must Save or combust
    8399 All non-sentient animals nearby are 1d100 years
    8400 All non-sentient animals nearby are panic-stricken
    8401 All non-sentient animals within 50 yards become vaguely evil
    8402 All open wounds within 50 yards steam violently but harmlessly
    8403 All paper now nearby glows in the dark permanently
    8404 All paper now nearby is fireproof
    8405 All plant life within 10 miles is sky-blue from now on
    8406 All plant-based fabric within 50 yards becomes dull brown
    8407 All plant-based fabric within 50 yards combusts
    8408 All priestly magic within 500 yards is dispelled
    8409 All priestly magic within 500 yards is suppressed for 1d10 turns
    8410 All reflective surfaces in the area display imaginary scenes
    8411 All reflective surfaces in the area display scenes of carnage
    8412 All right arms within 50 yards are ethereal until sunset
    8413 All right arms within 50 yards are invulnerable for 1d10 hours
    8414 All right arms within 50 yards are paralyzed until dawn
    8415 All rope within 50 yards canit be cut or broken
    8416 All rope within 50 yards ignites along its entire length
    8417 All rope within 50 yards is as rigid as wood
    8418 All rope within 50 yards is as strong as steel wire
    8419 All rope within 50 yards is forever unable to hold a knot
    8420 All rope within 50 yards is permanently invisible
    8421 All rope within 50 yards shortens by 80%
    8422 All rope within 50 yards straightens and becomes hard as stone
    8423 All rope within 50 yards stretches like elastic
    8424 All rope within 50 yards turns to flesh
    8425 All saddles within 50 yards are as durable as tempered steel
    8426 All saddles within 50 yards disappear
    8427 All shields within 50 yards are fragile like glass for 1d4 rounds
    8428 All shields within 50 yards are impervious to fire
    8429 All shields within 50 yards are impervious to harm until sunset
    8430 All shields within 50 yards are imprinted with ugly faces
    8431 All shields within 50 yards gain a +1 bonus lasting 1d10 battles
    8432 All soil and rock within 100 yards vanishes
    8433 All soil within 50 yards is seeded with an aggressive vegetable
    8434 All soil within 50 yards turns invisible 
    8435 All spells cast in the last 1d4 rounds are retroactively negated
    8436 All spells cast in the last 1d4 rounds recur in 1d4 rounds
    8437 All spells cast in the next 2d6 rounds are invisible in effect
    8438 All spells cast in the next 2d6 rounds occur 2d6 rounds later
    8439 All spells cast in this area are accompanied by trumpet fanfare
    8440 All spells cast in this area are delayed by 2d10 rounds
    8441 All Summoned creatures within 10 miles are dismissed
    8442 All Summoned creatures within 10 miles vanish in 1d4 rounds
    8443 All swords within one mile are hopelessly blunted for 1d4 days
    8444 All swords within one mile turn to golf clubs until dawn tomorrow
    8445 All teeth within 50 yards are as black as coal for 1d4 weeks
    8446 All teeth within 50 yards are rendered invisible for 1d12 months
    8447 All tempered metal within 50 yards is reduced in weight by 50%
    8448 All tempered metal within 50 yards is soft as rubber until dawn
    8449 All thumbs within 50 yards are immune to polymorph magic
    8450 All thumbs within 50 yards vanish for 1d4 hours
    8451 All transparent matter within one mile is as fragile as glass
    8452 All transparent matter within one mile is rendered invisible
    8453 All trees within 10 miles drop their leaves until next spring
    8454 All trees within 50 yards are glazed with ice
    8455 All trees within 50 yards are impervious to saws and axes
    8456 All trees within 50 yards bear watermelons for 1d4 months
    8457 All trees within 50 yards become ambulatory
    8458 All trees within 50 yards become omnivorous
    8459 All trees within 50 yards chant dirges at every sunset
    8460 All trees within 50 yards gain a semblance of sentience
    8461 All trees within 50 yards turn permanently invisible
    8462 All trees within a one mile vanish
    8463 All trees within one mile are cut down and stacked as cordwood
    8464 All trees within one mile are hollow
    8465 All trees within one mile crumble to dust within 1d4 days
    8466 All trees within one mile double in height
    8467 All trees within one mile drip with blood
    8468 All trees within one mile uproot and move 10 miles to the north
    8469 All trolls within 10 miles adopt a kinder, gentler philosophy
    8470 All trolls within 10 miles lose their ability to regenerate
    8471 All undead skeletons within 10 miles turn to wood
    8472 All undead within 1d100 miles vanish until sunset tomorrow
    8473 All undead within 50 yards are restored to full hit points
    8474 All undead within 50 yards are teleported 1d4 miles
    8475 All undead within 50 yards attack one random person nearby
    8476 All undead within one mile can exhale clouds of fog at will
    8477 All undead within one mile combust and burn until sunset tomorrow
    8478 All undead within one mile require air just like living creatures
    8479 All undead within one mile think that theyire still alive
    8480 All vegetable matter within 50 yards, alive or dead, dissolves
    8481 All vegetation within 10 miles is 10X as nutritious for 1d4 weeks
    8482 All vegetation within 10 miles is incredibly toxic for 1d4 days
    8483 All vegetation within 10 miles tastes like manure when cooked
    8484 All vegetation within 50 yards becomes incredibly lush
    8485 All vegetation within 50 yards dies within 1d4 rounds
    8486 All vegetation within 50 yards grows 100X as fast for 2d4 days
    8487 All vegetation within 50 yards is frozen solid
    8488 All vegetation within 50 yards turns bone-white for 1d4 days
    8489 All visible trails or tracks within 10 miles vanish completely
    8490 All voices within 50 yards seem to issue from the same person
    8491 All voices within 50 yards sound identical
    8492 All water within 10 miles is chilled to just above freezing
    8493 All water within 50 yards becomes invisible
    8494 All water within 50 yards becomes thick like gelatin
    8495 All water within 50 yards does nothing to mitigate thirst
    8496 All water within 50 yards doubles in volume 1d6 times
    8497 All water within 50 yards holds its temperature for one year
    8498 All water within 50 yards looks foul but is fresh and sweet
    8499 All water within 50 yards remains liquid for at least 1d4 months
    8500 All water within 50 yards smells and tastes strongly of fish
    8501 All water within 50 yards turns to for over the next 1d4 rounds
    8502 All water within 50 yards turns to glass
    8503 All water within 50 yards turns to milk
    8504 All water within one mile vanishes
    8505 All weapons and armor within 50 yards seem to be 3X normal weight
    8506 All weapons nearby are bound to this area and will return to it
    8507 All weapons within 50 yards appear to be made of bone
    8508 All weapons within 50 yards are +1 ToHit until dawn tomorrow
    8509 All weapons within 50 yards are +10 ToHit for 1d4 rounds
    8510 All weapons within 50 yards are +2 ToHit for 2d12 hours
    8511 All weapons within 50 yards are +2 ToHit Summoned creatures
    8512 All weapons within 50 yards are +2 ToHit until their next hit
    8513 All weapons within 50 yards are +5 ToHit but -5 to damage
    8514 All weapons within 50 yards are -4 ToHit anyone currently nearby
    8515 All weapons within 50 yards are caked in sticky clay
    8516 All weapons within 50 yards are cleaned, polished, and sterilized
    8517 All weapons within 50 yards are edible
    8518 All weapons within 50 yards are etched with their ownersi names
    8519 All weapons within 50 yards are impervious to Alteration magic
    8520 All weapons within 50 yards are invulnerable to acid
    8521 All weapons within 50 yards are marked with demonic sigils
    8522 All weapons within 50 yards are piled at the target point
    8523 All weapons within 50 yards are repelled from the target point
    8524 All weapons within 50 yards are sealed in candle wax
    8525 All weapons within 50 yards are stuck in their sheathes
    8526 All weapons within 50 yards are terribly unwieldy for 4d6 rounds
    8527 All weapons within 50 yards are the property of some distant king
    8528 All weapons within 50 yards attract flies and gnats for one week
    8529 All weapons within 50 yards exude aromatic smoke for 1d6 hours
    8530 All weapons within 50 yards glow red as though theyire very hot
    8531 All weapons within 50 yards hum in the presence of spilled blood
    8532 All weapons within 50 yards must Save or be bent like corkscrews
    8533 All weapons within 50 yards steam violently on contact with water
    8534 All weapons within 50 yards were forged by an undead smith
    8535 All weapons within one mile vanish until dawn tomorrow
    8536 All wheeled vehicles within one mile burst into flame
    8537 All wheeled vehicles within one mile sink 1d4 feet into the mud
    8538 All wheels within one mile are chrome-plated
    8539 All wheels within one mile become perfectly square
    8540 All who saw this casting are 10% likely to be driven insane
    8541 All who saw this casting are healed for 1d4 hit points
    8542 All who saw this casting are soaked with cold gravy
    8543 All who saw this casting are stricken mute until sunset
    8544 All who saw this casting are stricken totally deaf for 1d12 hours
    8545 All who saw this casting are thrown 1d4 days into the future
    8546 All who saw this casting are unable to sleep for 2d10 days
    8547 All who saw this casting despise magic for until dawn tomorrow
    8548 All who saw this casting giggle like lunatics for 3d4 rounds
    8549 All who saw this casting hear an eerie moaning for 1d4 days
    8550 All who saw this casting howl at the moon for the next 1d8 nights
    8551 All who saw this casting lose 1d20 points of Wisdom until sunset
    8552 All who saw this casting lose 1d4 hit points
    8553 All who saw this casting stare at the target point until dawn
    8554 All who saw this casting think that its target has been slain
    8555 All who saw this casting undertake a pilgrimage to a distant town
    8556 All within 10 feet are wrapped like mummies
    8557 All within 10 feet feel like theyive just run a marathon
    8558 All within 10 feet must Save or be teleported 1d100 miles
    8559 All within 10 feet point loses 1d100 hit points
    8560 All within 10 miles are convinced that the apocalypse is nigh
    8561 All within 10 miles identify the target point as a holy site
    8562 All within 10 miles seek to worship someone near the target point
    8563 All within 10 yards divest themselves of all gems and jewels
    8564 All within 10 yards find a diamond worth 1,000 gold pieces 
    8565 All within 50 miles realize that thievesi cant is fictitious
    8566 All within 50 miles rise up against the king
    8567 All within 50 yards acquire a distinctive accent
    8568 All within 50 yards adopt new names and answer only to them
    8569 All within 50 yards age 1d12 months
    8570 All within 50 yards and in armor are paralyzed for 2d6 rounds
    8571 All within 50 yards appear blurry to each other for 1d12 hours
    8572 All within 50 yards appear to be 1d100 years older
    8573 All within 50 yards appear to be covered with festering sores
    8574 All within 50 yards appear to be indescribably ugly to each other
    8575 All within 50 yards appear to have advanced leprosy
    8576 All within 50 yards appear to have bubonic plague
    8577 All within 50 yards are 5% likely to be turned inside out
    8578 All within 50 yards are 5% likely to become amphibious
    8579 All within 50 yards are 5% likely to die at dawn tomorrow
    8580 All within 50 yards are 5% likely to freeze solid
    8581 All within 50 yards are 5% likely to inherit a small keep
    8582 All within 50 yards are 5% likely to suffer total amnesia
    8583 All within 50 yards are 10% likely to age 1d100 years
    8584 All within 50 yards are 10% likely to be closely related
    8585 All within 50 yards are 10% likely to be stricken bald forever
    8586 All within 50 yards are 10% likely to wake tomorrow as undead
    8587 All within 50 yards are -2 ToHit for 2d10 rounds
    8588 All within 50 yards are 20% likely to be knocked unconscious
    8589 All within 50 yards are 20% likely to be paralyzed for 1d4 hours
    8590 All within 50 yards are 20% likely to lose all but one hit point
    8591 All within 50 yards are 25% likely to be covered in chocolate
    8592 All within 50 yards are 30% likely to vanish for 1d6 rounds
    8593 All within 50 yards are 40% likely to regain full hit points
    8594 All within 50 yards are a peculiar shade of blue-gray
    8595 All within 50 yards are AC 0 (no modifiers) for 2d6 hours
    8596 All within 50 yards are arrested for sedition and treason
    8597 All within 50 yards are at risk of awakening a vengeful god
    8598 All within 50 yards are attacked by countless magpies
    8599 All within 50 yards are attacked by locusts
    8600 All within 50 yards are banded like protected wildlife
    8601 All within 50 yards are blamed for some recent catastrophe
    8602 All within 50 yards are blind while at full hit points
    8603 All within 50 yards are branded heretics and ordered slain
    8604 All within 50 yards are branded with the mark of some random god
    8605 All within 50 yards are carrying an additional 5d10 gold pieces
    8606 All within 50 yards are carrying an identical iron medallion
    8607 All within 50 yards are carrying ornate ceremonial daggers
    8608 All within 50 yards are carrying small discs of carved stone
    8609 All within 50 yards are charged with an arduous divine quest
    8610 All within 50 yards are claimed as slaves by the nearest tyrant
    8611 All within 50 yards are considered pariahs
    8612 All within 50 yards are covered in creosote
    8613 All within 50 yards are covered in powdered sugar like doughnuts
    8614 All within 50 yards are covered with honey and feathers
    8615 All within 50 yards are disarmed
    8616 All within 50 yards are discovered to be clones
    8617 All within 50 yards are doused with molasses
    8618 All within 50 yards are drafted into military service
    8619 All within 50 yards are draped in tough, fibrous filaments
    8620 All within 50 yards are draped with pungent floral garlands
    8621 All within 50 yards are drenched with cold, soapy water
    8622 All within 50 yards are drenched with olive oil
    8623 All within 50 yards are dressed and painted like clowns
    8624 All within 50 yards are dressed in black and have jet-black hair
    8625 All within 50 yards are dressed in high quality fur
    8626 All within 50 yards are dressed in illusory formal wear
    8627 All within 50 yards are dressed in illusory full plate armor
    8628 All within 50 yards are dressed in wildly inappropriate attire
    8629 All within 50 yards are dressed like pirates
    8630 All within 50 yards are enraged beyond thought or reason
    8631 All within 50 yards are extremely short-tempered for 1d12 hours
    8632 All within 50 yards are filthy as though theyive never bathed
    8633 All within 50 yards are glazed with yellow ice
    8634 All within 50 yards are Held for 6d10 rounds
    8635 All within 50 yards are holding tiny stone carvings of themselves
    8636 All within 50 yards are immune to all magic for 1d6 rounds
    8637 All within 50 yards are immune to disease for 1d6 months
    8638 All within 50 yards are immune to missile fire for 2d6 rounds
    8639 All within 50 yards are immune to poison for 1d4 days
    8640 All within 50 yards are immune to polymorph magic for one year
    8641 All within 50 yards are immune to reason for 1d4 days
    8642 All within 50 yards are implicated in a huge royal scandal
    8643 All within 50 yards are individually shrouded in fog
    8644 All within 50 yards are invisible for 1d4 rounds
    8645 All within 50 yards are invisible to a single person nearby
    8646 All within 50 yards are invisible to all others within 50 yards
    8647 All within 50 yards are invisible to birds
    8648 All within 50 yards are invisible to reptiles for 1d6 hours
    8649 All within 50 yards are invisible when seen from below
    8650 All within 50 yards are involved in a diplomatic nightmare
    8651 All within 50 yards are invulnerable to wood for 1d10 rounds
    8652 All within 50 yards are liberally sprayed with octopus ink
    8653 All within 50 yards are now standing in the nearest building
    8654 All within 50 yards are now wearing tap-shoes
    8655 All within 50 yards are offered for sale on the open market
    8656 All within 50 yards are overpoweringly thirsty
    8657 All within 50 yards are painted with woad
    8658 All within 50 yards are paralyzed by indecision for 1d4 rounds
    8659 All within 50 yards are pardoned for any outstanding crimes
    8660 All within 50 yards are permanently branded as escaped slaves
    8661 All within 50 yards are profoundly drunk for 1d10 rounds
    8662 All within 50 yards are pushed 1d10 yards from the target point
    8663 All within 50 yards are ravenously hungry
    8664 All within 50 yards are restored to full hit points
    8665 All within 50 yards are rumored to be undead
    8666 All within 50 yards are rumored to belong to some bizarre cult
    8667 All within 50 yards are showered in maggots
    8668 All within 50 yards are smeared with a foul-smelling gelatin
    8669 All within 50 yards are sprayed with skunk musk
    8670 All within 50 yards are standing on three-foot cast iron discs
    8671 All within 50 yards are sterile for 2d12 months
    8672 All within 50 yards are stricken mute for 1d6 rounds
    8673 All within 50 yards are strongly addicted to some kind of poison
    8674 All within 50 yards are suddenly arranged in a big circle
    8675 All within 50 yards are suddenly barefoot
    8676 All within 50 yards are suddenly extremely drunk
    8677 All within 50 yards are suddenly seated in the lotus position
    8678 All within 50 yards are tempted to dabble in cannibalism
    8679 All within 50 yards are thoroughly cleansed
    8680 All within 50 yards are thrown 1d4 days into the future
    8681 All within 50 yards are unable to breathe for 1d20 rounds
    8682 All within 50 yards are unable to move their feet for 2d10 rounds
    8683 All within 50 yards are unable to sleep for 2d20 days
    8684 All within 50 yards are unable to use magic for 1d8 hours
    8685 All within 50 yards are unable to wield weapons while in armor
    8686 All within 50 yards are unable to wield wooden weapons until dawn
    8687 All within 50 yards are wearing beekeepersi veils
    8688 All within 50 yards are wearing ostrich feathers in their hair
    8689 All within 50 yards are wearing wooden shoes
    8690 All within 50 yards become hopelessly lost for 1d4 hours
    8691 All within 50 yards believe that theyire dreaming
    8692 All within 50 yards can see just fine in normal darkness
    8693 All within 50 yards covet the possessions of one person nearby
    8694 All within 50 yards crackle with ozone for 6d6 rounds 
    8695 All within 50 yards dance lasciviously for 1d6 rounds
    8696 All within 50 yards develop an acute fear of wood
    8697 All within 50 yards die in a huge explosion but resurrect at dawn
    8698 All within 50 yards disarm themselves and race to a nearby river
    8699 All within 50 yards disarm themselves as quickly as they can
    8700 All within 50 yards exchange places with someone else nearby
    8701 All within 50 yards exhale steam as if the air were very cold
    8702 All within 50 yards feel a wildly different ambient temperature
    8703 All within 50 yards feel insects crawling over their skin
    8704 All within 50 yards feel intense hunger at the sight of blood
    8705 All within 50 yards feel overpowering fear for 2d6 rounds
    8706 All within 50 yards feel unfocused yet overwhelming disgust
    8707 All within 50 yards find obscene tattoos on their bodies
    8708 All within 50 yards find that their clothes are torn and bloody
    8709 All within 50 yards forget everyoneis name
    8710 All within 50 yards forget how to use weapons or magic until dawn
    8711 All within 50 yards gain 1d1000 Experience Points
    8712 All within 50 yards grow 1d4 inches
    8713 All within 50 yards have a copy of a mysterious brass key
    8714 All within 50 yards have a mark identifying them as pariahs
    8715 All within 50 yards have an additional, functioning kidney
    8716 All within 50 yards have clouded vision for 2d6 rounds
    8717 All within 50 yards have conflicting memories of the past day
    8718 All within 50 yards have five pounds of butter in their pockets
    8719 All within 50 yards have gone without sleep for 3d4 days
    8720 All within 50 yards have horrifying visions of future tragedy
    8721 All within 50 yards have just run 1d10 miles
    8722 All within 50 yards have the exact same voice
    8723 All within 50 yards laugh like lunatics for 4d6 rounds
    8724 All within 50 yards levitate 1d6 feet for 2d6 rounds
    8725 All within 50 yards look and smell as if theyive been in a fire
    8726 All within 50 yards look like cadavers when seen from behind
    8727 All within 50 yards lose 1 hit point per round spent in that area
    8728 All within 50 yards lose 1d6 levels until sunset tomorrow
    8729 All within 50 yards lose 1d8 hit points but gain 1d10 hit points
    8730 All within 50 yards mount an attack upon the nearest castle
    8731 All within 50 yards move as if theyire underwater
    8732 All within 50 yards must hibernate this winter
    8733 All within 50 yards must remain in this area until dawn tomorrow
    8734 All within 50 yards must remain within 10 yards of each other
    8735 All within 50 yards must repeat everything they say for 1d10 days
    8736 All within 50 yards must Save each morning or age 1d4 years
    8737 All within 50 yards must Save or be attacked by rats and mice
    8738 All within 50 yards must Save or be branded like cattle
    8739 All within 50 yards must Save or be burned for 1d10 hit points
    8740 All within 50 yards must Save or be Slowed
    8741 All within 50 yards must Save or be soaked with icy brine
    8742 All within 50 yards must Save or be stricken mute for 1d4 months
    8743 All within 50 yards must Save or be Teleported 2d10 miles
    8744 All within 50 yards must Save or be thrown into nearby trees
    8745 All within 50 yards must Save or be tightly bound in wire
    8746 All within 50 yards must Save or feel 1d100° colder
    8747 All within 50 yards must Save or feel 1d100° warmer
    8748 All within 50 yards must Save or flee in panic for 2d10 rounds
    8749 All within 50 yards must Save or sink 4d12 inches into the ground
    8750 All within 50 yards must Save or suffer blinding pain until dawn
    8751 All within 50 yards must Save or suffer frostbite in 1d10 fingers
    8752 All within 50 yards must Save or their clothes burst into flame
    8753 All within 50 yards must Save or their hair combusts
    8754 All within 50 yards must Save or their hands shrink by 50%
    8755 All within 50 yards must Save or they must re-roll their stats
    8756 All within 50 yards must Save vs Death or be shorn of all hair
    8757 All within 50 yards must Save, or their wounds will never heal
    8758 All within 50 yards now have bright blue hair
    8759 All within 50 yards preach a ridiculous "abstinence only" policy
    8760 All within 50 yards quickly devour any food that theyire carrying
    8761 All within 50 yards run at top speed toward the target point
    8762 All within 50 yards see illusory animals flitting about the area
    8763 All within 50 yards shrink 1d4 inches
    8764 All within 50 yards smell like carrion until sunset tomorrow
    8765 All within 50 yards smell strongly of alcohol
    8766 All within 50 yards smell strongly of brimstone until sunrise
    8767 All within 50 yards smell strongly of manure for 1d4 days
    8768 All within 50 yards suddenly have perfectly groomed hair
    8769 All within 50 yards talk like 1930is movie gangsters
    8770 All within 50 yards think that a deity is in their midst
    8771 All within 50 yards think that all others nearby are lying
    8772 All within 50 yards think that all others nearby are on fire
    8773 All within 50 yards think that fire is edible
    8774 All within 50 yards think that theyire being attacked by zombies
    8775 All within 50 yards think that theyire in a parallel universe
    8776 All within 50 yards think that theyire standing in knee-deep snow
    8777 All within 50 yards think that theyive suffered massive injuries
    8778 All within 50 yards think theyill die unless they remain standing
    8779 All within 50 yards think theyive shrunk by 90%
    8780 All within 50 yards throw their weapons as far as they can
    8781 All within 50 yards vanish for 3d10 rounds
    8782 All within 50 yards weep hysterically but can act normally
    8783 All within 50 yards who are injured smell strongly of peppermint
    8784 All within 50 yards who are not now bleeding fall unconscious
    8785 All within 50 yards who are now bleeding fall unconscious
    8786 All within 50 yards who breathe air suffocate for 2d10 rounds
    8787 All within 50 yards will be fully healed at the end of 3d8 rounds
    8788 All within 50 yards will become undead when they die
    8789 All within 50 yards will die if any one of them dies before dawn
    8790 All within 50 yards witness a miraculous manifestation of a deity
    8791 All wood within one mile is fireproof for 1d4 weeks
    8792 All worked stone within 50 yards absorbs water like a sponge
    8793 All worked stone within 50 yards begins eroding rapidly
    8794 All worked stone within 50 yards blazes with illusory flame
    8795 All worked stone within 50 yards clangs like bronze bells
    8796 All worked stone within 50 yards hums audibly in moonlight
    8797 All worked stone within 50 yards increases in size by 1d100%
    8798 All worked stone within 50 yards is as shiny as a mirror
    8799 All worked stone within 50 yards is briefly pliant as soft clay
    8800 All worked stone within 50 yards is clear like glass
    8801 All worked stone within 50 yards is etched with blasphemous runes
    8802 All worked stone within 50 yards is now 3d100° colder
    8803 All worked stone within 50 yards is water soluble
    8804 All worked stone within 50 yards oozes blood for 1d4 hours
    8805 All worked stone within 50 yards returns to its natural state
    8806 All worked stone within 50 yards turns to ice
    8807 All written text within 50 yards appears reversed in sunlight
    8808 All written text within 50 yards can only be read by moonlight
    8809 All written text within 50 yards hums audibly while being read
    8810 All written text within 50 yards is reversed
    8811 All written text within 50 yards shrinks by 50%
    8812 An ancient battle is endlessly reenacted on this site by ghosts
    8813 An animal species native to the area acquires sentience
    8814 An animal species native to the area actually controls the throne
    8815 An animal species native to the area is now immune to magic
    8816 An animal species native to the area quickly goes extinct
    8817 An arrogant, inarticulate twit achieves great political power
    8818 An asteroid 1d20 miles in diameter strikes the planet near here
    8819 An enormous black disc hovers over the area for 1d4 hours
    8820 An enormous cache of classified documents is found nearby
    8821 An enormous cache of D-Cell batteries is found nearby
    8822 An enormous castle formed entirely of ice appears nearby
    8823 An enormous fishing net settles over a 100 yard radius
    8824 An enormous head of sculpted stone bursts from the ground 
    8825 An enormous oak tree appears at the target point
    8826 An enormous sand castle appears at the target point
    8827 An enormous volume of acrid smoke spews from the target point
    8828 An exact copy of the moon appears 180° away from the original one
    8829 An experimental forge in a nearby town achieves critical mass
    8830 An incredibly dangerous and powerful artifact appears nearby
    8831 An incredibly dangerous toxin is released into a nearby river
    8832 An incredibly foul entity is summoned to the target point
    8833 An ingot of metallic hydrogen appears at the target point
    8834 An ingot of neutronium appears at the target point
    8835 An ingot of some impossible metal appears at the target point
    8836 An intoxicatingly delightful scent issues from the target point
    8837 An intricate maze of panels of ice sprouts in a 100 yard radius
    8838 An intricate maze of tall hedges sprouts in a 100 yard radius
    8839 An intricate sculpture of blown glass appears at the target point
    8840 An invisible, whistling octopus slithers through the area
    8841 An overpoweringly foul stench issues from the target point
    8842 An unusually virulent form of plague breaks out in a nearby town
    8843 Ants appear to swarm on all blades within 50 yards
    8844 Any active charms and enchantments nearby are negated until dawn
    8845 Any alcoholic beverages within 50 yards are now 10X as potent
    8846 Any alcoholic beverages within 50 yards become powerfully toxic
    8847 Any alcoholic beverages within 50 yards combust violently
    8848 Any alcoholic beverages within 50 yards induce temporary insanity
    8849 Any alcoholic beverages within 50 yards turn to mercury
    8850 Any artifacts within 50 miles become non-functional for 2d6 days
    8851 Any beneficial enchantments now in effect nearby are dispelled
    8852 Any blades currently sheathed nearby make their sheathes combust
    8853 Any blood spilled in this area combusts on contact with water
    8854 Any blood spilled in this area discolors the ground
    8855 Any charged magical items nearby are fully recharged
    8856 Any charged magical items nearby are triggered upon their owners
    8857 Any charged magical items nearby canit be used until tomorrow
    8858 Any charged magical items nearby lose 1d10 charges
    8859 Any exposed rock nearby is polished as smooth as glass
    8860 Any fireball cast nearby is 1% likely to scorch a one mile radius
    8861 Any fires now burning within 10 miles are extinguished
    8862 Any fires now burning within 10 miles exude hallucinogenic smoke
    8863 Any fires now burning within 10 miles provide no heat
    8864 Any fires now burning within 10 miles provide no light
    8865 Any fires now burning within 10 miles turn into pools of water
    8866 Any fires now burning within 50 yards quadruple in size
    8867 Any fires now burning within ten miles attract undead like moths
    8868 Any food now in this area tastes strongly of blood
    8869 Any food now within 50 yards induces bacchanalia when eaten
    8870 Any food now within 50 yards induces drowsiness when eaten
    8871 Any food now within 50 yards induces madness when eaten
    8872 Any food now within 50 yards turns to iron
    8873 Any food now within 50 yards will turn to lead when consumed
    8874 Any gold nearby is invisible in sunlight
    8875 Any gold within 50 yards liquefies
    8876 Any ice or snow within 10 miles canit melt for 1d12 months
    8877 Any ice or snow within 10 miles feels painfully hot to the touch
    8878 Any magical protections now in place nearby are negated
    8879 Any magical seals or locks within one mile are negated
    8880 Any magical seals or locks within one mile are permanently sealed
    8881 Any magical seals or locks within one mile shine like the sun
    8882 Any magical symbols, glyphs, or seals within 50 yards are negated
    8883 Any magical traps within one mile are triggered
    8884 Any meat eaten nearby in the last 24 hours was human flesh
    8885 Any nearby outcroppings of rock burst into flame
    8886 Any nearby water in a container becomes carbonated
    8887 Any nearby water in a container becomes heavily chlorinated
    8888 Any non-living wood within one mile becomes clear like glass
    8889 Any open wounds in the area heal into scars shaped like runes
    8890 Any open wounds in the area heal into ugly, purplish scars
    8891 Any outstanding campaign plot inconsistencies are hereby resolved
    8892 Any pack animals within one mile race away at top speed
    8893 Any priest nearby is 10% likely to think heis his god
    8894 Any ranged spells cast nearby are delayed for 3d10 rounds
    8895 Any ranged spells cast nearby have a range of zero
    8896 Any range-zero spells cast nearby affect someone else instead
    8897 Any range-zero spells cast nearby last only one round
    8898 Any scroll cases within 50 yards are sealed for 1d100 years
    8899 Any scroll cases within 50 yards digest their contents
    8900 Any spells currently in effect within 100 yards are negated
    8901 Any standing water within 50 yards boils violently
    8902 Any standing water within 50 yards can be used as a scrying pool
    8903 Any water now within 50 yards can never be frozen
    8904 Any Wishes thus far granted to any within 50 yards are negated
    8905 Any wood now within 50 yards provides no heat if burned
    8906 Any wooden structures within one mile turn to durable stone
    8907 Anyone bearing a holy symbol nearby is healed for 1d4 hit points
    8908 Anyone bearing a holy symbol nearby loses 1d10 hit points
    8909 Anyone carrying a blanket nearby is swarmed by thousands of moths
    8910 Anyone carrying a blanket nearby is thrown 1d100 yards
    8911 Anyone carrying a blanket nearby is tightly swaddled in it
    8912 Anyone carrying a blanket nearby is unable to sleep for 3d10 days
    8913 Anyone carrying food nearby is arrested for smuggling contraband
    8914 Anyone carrying food nearby is swarmed by countless wasps
    8915 Anyone currently bleeding nearby is stricken with plague
    8916 Anyone currently bleeding nearby wakes tomorrow in prison
    8917 Anyone currently wielding a weapon nearby is stricken mute
    8918 Anyone in armor within 10 yards canit breathe for 2d10 rounds
    8919 Anyone in armor within 10 yards canit remove it for 1d10 days
    8920 Anyone in armor within 10 yards is afraid of magic for 2d8 rounds
    8921 Anyone in armor within 10 yards is attacked by a magical wolf
    8922 Anyone in armor within 10 yards is immune to magic for 1d4 rounds
    8923 Anyone in armor within 10 yards is pelted by hail for 3d10 rounds
    8924 Anyone in armor within 10 yards is thrown 1d10 yards
    8925 Anyone in armor within 10 yards loses 1d4 hit points
    8926 Anyone in armor within 10 yards regains 1d6 hit points
    8927 Anyone in armor within 10 yards sneezes repeatedly for 3d6 rounds
    8928 Anyone leaving the area finds that 1d4 weeks have passed
    8929 Anyone nearby and facing the target point disappears until dawn
    8930 Anyone nearby and facing the target point is blinded until dawn
    8931 Anyone nearby and facing the target point is blown back 6d10 feet
    8932 Anyone nearby and facing the target point is covered by moss
    8933 Anyone nearby and facing the target point is covered in soot
    8934 Anyone nearby and facing the target point is dusted with flour
    8935 Anyone nearby and facing the target point is obsessed with magic
    8936 Anyone nearby and facing the target point is paralyzed until dawn
    8937 Anyone nearby and facing the target point is suddenly naked
    8938 Anyone nearby and facing the target point loses all hair
    8939 Anyone nearby and facing the target point runs to a nearby river
    8940 Anyone nearby and less than five feet tall grows 1d6 inches
    8941 Anyone nearby and less than five feet tall vanishes for 1d4 days
    8942 Anyone nearby and more than five feet tall runs 1d10 miles away
    8943 Anyone nearby and more than five feet tall shrinks to that height
    8944 Anyone nearby and not wearing armor is attacked by huge wasps
    8945 Anyone nearby and not wearing armor loses 1d4 hit points
    8946 Anyone nearby at full hit points is fined 1d100 gold pieces
    8947 Anyone nearby at full hit points is immune to poison gas
    8948 Anyone nearby at full hit points is reduced to 1d4 hit points
    8949 Anyone nearby bearing a flag or standard is struck by lightning
    8950 Anyone nearby bearing a flag or standard shrinks by 25%
    8951 Anyone nearby can never be teleported while wearing clothes
    8952 Anyone nearby can never drown while barefoot
    8953 Anyone nearby of racially mixed blood suffers agony for 1d4 turns
    8954 Anyone nearby who ate in the past 1d4 hours is ravenously hungry 
    8955 Anyone nearby who ate in the past 1d4 hours vanishes until dawn
    8956 Anyone nearby who attempts to teleport will wind up right here
    8957 Anyone nearby who spills blood by moonlight is stricken blind
    8958 Anyone nearby who tries to turn invisible glows brightly instead
    8959 Anyone nearby who tries to turn invisible loses 1d10 hit points
    8960 Anyone nearby who turns invisible is bright orange forever after
    8961 Anyone nearby who used magic in the past round falls unconscious
    8962 Anyone nearby who used magic in the past round is soaked in brine
    8963 Anyone nearby whois barefoot must Save or be shod like a horse
    8964 Anyone nearby whois barefoot must Save or their feet dissolve
    8965 Anyone nearby whois carrying an artifact is possessed by it
    8966 Anyone nearby whois carrying open flame is severely burned
    8967 Anyone nearby whois carrying open flame is stricken bald
    8968 Anyone nearby whois carrying open flame is terrified of fire
    8969 Anyone nearby whois carrying open flame is terrified of the dark
    8970 Anyone nearby whois carrying rope has a hanging scar on his neck
    8971 Anyone nearby whois carrying rope is thoroughly entangled in it
    8972 Anyone nearby whois carrying rope wakes tomorrow at this location
    8973 Anyone nearby whois slain by a zombie will become a zombie
    8974 Anyone nearby wielding a missile weapon is acutely near-sighted
    8975 Anyone nearby wielding a missile weapon is teleported 1d6 miles
    8976 Anyone nearby with a blade other than a sword canit locate it
    8977 Anyone nearby with a blade other than a sword falls unconscious
    8978 Anyone nearby with an axe is attacked by a nearby tree
    8979 Anyone nearby with an axe is desperate to fell the nearest tree
    8980 Anyone nearby with an axe is suddenly carrying a lute or guitar
    8981 Anyone nearby with an axe is totally invulnerable for 1d6 rounds
    8982 Anyone nearby with bloodstained clothes is revered as a prophet
    8983 Anyone nearby with bloodstained clothes smells like a corpse
    8984 Anyone nearby with formal military rank is ordered to the front
    8985 Anyone nearby with formal military rank is stripped of that rank
    8986 Anyone nearby with long hair is all but scalped
    8987 Anyone nearby with more than 50 gold pieces is terribly miserly
    8988 Anyone nearby with more than 50 gold pieces loses all wealth
    8989 Anyone now standing on bare earth nearby has +2 ToHit until dawn
    8990 Anyone now standing on bare earth nearby loses 1d10 hit points
    8991 Anyone now standing on bare earth nearby regains 1d10 hit points
    8992 Anyone now standing on bare earth nearby teleports 10d100 yards
    8993 Anyone now wielding a sword nearby is knocked to the ground
    8994 Anyone on a horse within 50 yards falls from it clumsily
    8995 Anyone on a horse within 50 yards has a craving for horsemeat
    8996 Anyone slain nearby completely decomposes in 1d4 rounds
    8997 Anyone slain nearby completely fossilizes in 1d4 rounds
    8998 Anyone slain nearby exudes flammable vapor for 1d4 days
    8999 Anyone slain nearby is resurrected with opposite alignment
    9000 Anyone slain nearby is revealed to be a doppelganger
    9001 Anyone slain nearby issues cryptic prophecy before dying
    9002 Anyone slain nearby turns instantly to stone
    9003 Anyone slain nearby turns to coal over 1d4 rounds
    9004 Anyone using magic nearby briefly appears to be made of wood
    9005 Anyone using magic nearby gives off a pungent and offensive odor
    9006 Anyone using magic nearby glows a pale green hue for 24 hours
    9007 Anyone using magic nearby is intensely attractive for 1d4 rounds
    9008 Anyone wielding a sword nearby is highly susceptible to poison
    9009 Anyone wielding a sword nearby loses 1d4 fingers for 1d4 weeks
    9010 Anyone within 50 yards who is of Elfish descent is arrested
    9011 Anyone within 50 yards who is of Elfish descent is blinded
    9012 Anyone within 50 yards with a tattoo loses 4d10 hit points
    9013 Anyone within 50 yards with a tattoo will be skinned after death
    9014 Arcane magic cast within 10 miles is heralded by horrid shrieking
    9015 Arcane magic is impossible within 10 miles for 1d4 hours
    9016 Blinding smoke issues from the ground when magic is cast nearby
    9017 Blinding smoke swirls about the area for 1d4 hours
    9018 Blood sprays from the target point like water from a hose
    9019 Celestial voices resonate in the air for 1d10 turns
    9020 Combustion can never occur within 10 yards of the target point
    9021 Combustion is not possible within 10 miles for 3d8 hours
    9022 Countless droplets of sticky black tar rain down on the area
    9023 Countless sharpened stakes jut from the ground in the area
    9024 Countless slugs and snails litter the ground
    9025 Countless small lumps of cheese rain down on the area
    9026 Countless tiny carvings of wooden ducks rain down on the area
    9027 Diabolical voices issue from the target point
    9028 Diaphanous jellyfish drift through the air high overhead
    9029 Displays of hostile emotion are impossible nearby for 6d10 rounds
    9030 Distances in this area are very difficult to judge accurately
    9031 Divination magic is impossible for 1d4 days
    9032 Divination magic is wildly unreliable for 1d4 days
    9033 Eerie and ominous susurrations issue from the air for one week
    9034 Enormous birds circle silently overhead for 1d12 hours
    9035 Events now happening nearby are actually happening 500 years ago
    9036 Events now happening nearby are in exact accordance with prophecy
    9037 Events now happening nearby give rise to a new religion
    9038 Every living creature in the world falls asleep for 6d10 minutes
    9039 Every living creature in the world hears the word "Xyzzy"
    9040 Every tree within one mile has an eerie face carved in its bark
    9041 Every tree within one mile has cryptic runes carved in its bark
    9042 Every tree within one mile hums sonorously
    9043 Everyone nearby gains a language known only to those in this area
    9044 Everyone within 10 yards is chained together
    9045 Everyone within 50 yards disgorges a large, hairy spider
    9046 Everyone within 50 yards has 1d100 gold pieces in his pocket
    9047 Everyone within 50 yards has 1d6 orcis teeth in his pocket
    9048 Everyone within 50 yards has a 1% chance to become a god
    9049 Everyone within 50 yards has a 2% chance to explode
    9050 Everyone within 50 yards has a big snowball in his pocket
    9051 Everyone within 50 yards has a henis egg in his pocket
    9052 Everyone within 50 yards has a lighted candle in his pocket
    9053 Everyone within 50 yards has a live cobra in his pocket
    9054 Everyone within 50 yards has a live salmon in his pocket
    9055 Everyone within 50 yards has a lump of quartz in his mouth
    9056 Everyone within 50 yards has a red hot coal in his pocket
    9057 Everyone within 50 yards has a signet ring in his pocket
    9058 Everyone within 50 yards has a small diamond in his pocket
    9059 Everyone within 50 yards has an iron ring around his wrist
    9060 Everyone within 50 yards has delicate glass globe in his pocket
    9061 Everyone within 50 yards has someoneis severed hand in his pocket
    9062 Everyone within 50 yards is fined 1d100 gold pieces
    9063 Everyone within 50 yards is holding a wooden cup full of wine
    9064 Everyone within 50 yards is holding an ice cream cone
    9065 Everyone within 50 yards is stamped with the kingis royal seal
    9066 Everyone within 50 yards is standing in a small bucket
    9067 Everyone within 50 yards is suddenly exhausted
    9068 Everyone within 50 yards is suddenly holding a block of dry ice
    9069 Everyone within 50 yards is suddenly holding a bucket of chum
    9070 Everyone within 50 yards is suddenly holding a chicken
    9071 Everyone within 50 yards is suddenly holding a helium balloon
    9072 Everyone within 50 yards is suddenly holding a small skull
    9073 Everyone within 50 yards is suddenly holding an ingot of lead
    9074 Everyone within 50 yards is suddenly indoors (or outdoors)
    9075 Everyone within 50 yards is tattooed with a sequential number
    9076 Everyone within 50 yards swaps his name with someone else nearby
    9077 Everyone within one mile identifies someone nearby as a deity
    9078 Everyone within one mile is stricken with intense apathy
    9079 Everything with one foot of the target point ceases to exist
    9080 Everything within 5 feet ceases to exist
    9081 Everything within 5 feet radiates strong magic for one year
    9082 Everything within 50 yards appears to be lit by blacklight
    9083 Everything within 50 yards appears to radiate intense evil
    9084 Everything within 50 yards is permanently drained of color 
    9085 Everything within 50 yards shakes violently for 3d10 rounds
    9086 Evidence is found of a massive, systematic policy of torture
    9087 Evidence is found of alien intervention in this worldis history
    9088 Farmland within one mile is amazingly fertile for 1d10+1 years
    9089 Farmland within one mile is barren for 1d10+1 years
    9090 Fast-drying concrete covers the area to a depth of 6d6 inches
    9091 Fire belches forth from the target point for 10d10 hours
    9092 Fires in this area are drawn toward the target point
    9093 Food eaten within one mile of this spot gives no nutrition
    9094 Food eaten within one mile provides twice the normal nutrition
    9095 For 1d10 rounds, air within 50 yards is as opaque as steel
    9096 For 1d10 rounds, all wood within 50 yards is water soluble
    9097 For 1d10 rounds, any spells cast nearby turn their casters yellow
    9098 For 1d10 rounds, water is highly toxic to all within 50 yards
    9099 For 1d4 days, fires lit nearby are hot enough to melt steel
    9100 For 1d4 days, fires lit nearby are visible through metal or stone
    9101 For 1d4 days, fires lit nearby arenit warm enough to melt ice
    9102 For 1d6 months, all flame in the world is blue
    9103 For 2d4 rounds, the ground within 50 yards flexes like elastic
    9104 For 2d4 rounds, the ground within 50 yards turns to quicksand
    9105 For one month the moon appears as bright as the Sun
    9106 For one month the moon appears to fill half of the night sky
    9107 For one month the Sun appears only as bright as the full moon
    9108 For one month the Sun is invisible though it still provides light
    9109 For one round, any nearby priest has 10% chance to summon his god
    9110 For one turn, the area is lit only by countless flashbulbs
    9111 For one turn, the area is lit only by flickering candlelight
    9112 For one year, flashing lights accompany spells cast in this area
    9113 For one year, spells cast in this area last only one round
    9114 From now on, all within 50 yards are left-handed
    9115 From now on, all within 50 yards look as wounded as they are now
    9116 Genocidal war breaks out between two or more major races
    9117 Gravity is skewed by 45° in this area until sunrise tomorrow
    9118 Gravity within 100 yards has no effect on wood
    9119 Half a ton of iron filings sprays from the target point
    9120 Half a ton of pureed carrots sprays from the target point
    9121 Half of the people nearby are half-invisible to the other half
    9122 Half of the people nearby are teleported 1d4 miles north
    9123 Half of the planet vanishes, but the remaining half is stable
    9124 Half the planet spins clockwise, the other half counter-clockwise
    9125 Hallucinogenic mist billows from the target point until sunset
    9126 Highly flammable gas sprays from the target point
    9127 Horrific, deafening laughter echoes through the area for one week
    9128 Horses tend to throw their riders while traveling in this area
    9129 Huge animal-shapes are traced in the soil in a one mile radius
    9130 Huge volumes of strongly emetic vapor spray from the target point
    9131 Huge, cryptic symbols appear on the side of a nearby mountain
    9132 Hundreds of highly venomous snakes emerge from the ground
    9133 Hundreds of hungry dogs appear in the vicinity
    9134 Hundreds of thousands of acorns fall from the sky
    9135 Hurricane-strength winds swirl around the target point
    9136 Ice cold water sprays from the ground beneath the target point
    9137 Ice suddenly covers the ground nearby to a depth of 1d6 inches
    9138 Icy mist issues from the target for 1d4 days
    9139 If indoors, all exits are sealed; if not, roll again
    9140 If indoors, the building is evacuated of air; if not, roll again
    9141 If indoors, the building shrinks by 50%; if not, roll again
    9142 If indoors, the building vanishes; if not, roll again
    9143 If the area is wooded, all nearby become lost; if not, roll again
    9144 In this area, moonlight causes sound to be stifled
    9145 In this area, non-magical metal is invisible under moonlight
    9146 In this area, sunlight seems 1d4 times as bright as normal
    9147 In this region, arcane magic is blamed for all kinds of disasters
    9148 In this region, Dwarves are considered a rare delicacy
    9149 In this region, Dwarves consider clothing to be unnecessary
    9150 In this region, gold is invulnerable to magic
    9151 In this region, hail has been falling for 2d4 days
    9152 In this region, itis been snowing for two weeks straight
    9153 In this region, missile weapons are considered cowardly
    9154 In this region, possession of gold is now a capital offense
    9155 In this region, the use of arcane magic is punishable by death
    9156 In this region, the use of magic items is heavily taxed
    9157 In this region, the use of priestly magic is strictly controlled
    9158 Innumerable glowing orbs emerge from the target point
    9159 Itis suddenly night, lasting until dawn would normally occur
    9160 Jagged rocks erupt from the ground in a 100 yard radius
    9161 Large poppies bloom in a 100 yard radius from the target point
    9162 Lightning bolts issue from the spellis target point
    9163 Loud thunder booms overhead whenever magic is used in this area
    9164 Magic users are persecuted throughout this country
    9165 Magical healing is not possible within 10 miles
    9166 Magical healing is unreliable during daylight within 10 miles
    9167 Magical illusions are impossible within 10 miles for 2d4-1 days
    9168 Magical invisibility is forever impossible within 50 miles
    9169 Many thousands of birds soon take up residence in this area
    9170 Missile attacks are futile within 50 yards of the target point
    9171 Missiles fired nearby all fly toward the same creature
    9172 Missiles fired nearby are 5% likely to induce True Love
    9173 Missiles fired nearby can induce paralysis on a successful hit
    9174 Missiles fired nearby crash like thunder when they hit
    9175 Missiles fired nearby disintegrate while in flight
    9176 Missiles fired nearby explode into embers after 1d4 rounds
    9177 Missiles fired nearby fly straight up into the sky and vanish
    9178 Missiles fired nearby have an absolute range limit of 10 yards
    9179 Missiles fired nearby hit the spellis target point
    9180 Missiles fired nearby inflict damage only on a ToHit roll of 20
    9181 Missiles fired nearby invariably miss their targets
    9182 Missiles fired nearby leave colorful trails of light
    9183 Missiles fired nearby travel an additional 1d10 miles
    9184 Moonlight in this area induces extreme covetousness
    9185 Moonlight in this area induces extreme melancholy in Elves
    9186 Moonlight in this area induces furious bloodlust
    9187 Moonlight in this area induces pain in lycanthropes
    9188 Moonlight in this area induces panic in those of INT 14 or above
    9189 Moonlight in this area induces unrestrained lecherousness
    9190 Moonlight in this area is blood red
    9191 Natural animals in this area can readily detect magic
    9192 Natural animals respond badly to anyone now within 50 yards
    9193 Nearest bridge appears in the immediate area
    9194 Nearest bridge appears to be a rainbow
    9195 Nearest bridge appears to be made of thick fog
    9196 Nearest bridge canit be crossed by anyone wearing footwear
    9197 Nearest bridge collapses after the next 1d6 people cross it
    9198 Nearest bridge is as pliant as rubber
    9199 Nearest bridge is burned
    9200 Nearest bridge is clear like glass
    9201 Nearest bridge is made of teeth
    9202 Nearest bridge is suddenly over troubled waters
    9203 Nearest bridge is takes 2d4 hours to cross
    9204 Nearest bridge opens like a drawbridge
    9205 Nearest bridge turns permanently invisible
    9206 Nearest building can only be entered by walking backwards
    9207 Nearest building is exactly duplicated at the target point
    9208 Nearest door appears at the target point
    9209 Nearest door is a jar
    9210 Nearest door is a portal to an ancient temple of a powerful deity
    9211 Nearest door opens to a point 1d10 days in the future
    9212 Nearest door opens to a point 1d10 miles in the air
    9213 Nearest door opens to the target point
    9214 Nearest doorway canit be traversed by anyone at full hit points 
    9215 Nearest doorway canit be traversed by anyone wearing armor
    9216 Nearest doorway causes all who pass through it to age 1d4 years
    9217 Nearest forest acquires malevolent sentience and intelligence
    9218 Nearest forest is set ablaze
    9219 Nearest government collapses amid rumors of infernal pacts
    9220 Nearest government switches to a manure-based economic system
    9221 Nearest horse becomes bipedal
    9222 Nearest horse sprouts two additional pairs of functional legs
    9223 Nearest lake becomes crystal clear but is highly toxic to humans
    9224 Nearest lake canit be safely traversed by any sort of watercraft
    9225 Nearest lake completely drains in a slow, clockwise spiral
    9226 Nearest lake completely evaporates over the next 1d4 rounds
    9227 Nearest lake conceals a sunken city containing incredible riches
    9228 Nearest lake contains a sunken armada from some long-lost navy
    9229 Nearest lake contains an ice berg
    9230 Nearest lake doubles its volume during each of the next 1d4 days
    9231 Nearest lake drains to reveal the corpse of a long-dead deity
    9232 Nearest lake freezes completely solid over the next 1d4 rounds
    9233 Nearest lake heats to 200° over the next 1d4 rounds
    9234 Nearest lake is covered by a tarp
    9235 Nearest lake is encircled by a moat of flaming pitch
    9236 Nearest lake is home to a colony of unaging amphibious humanoids
    9237 Nearest lake is perpetually fog-shrouded
    9238 Nearest lake rises as a huge water elemental and walks to the sea
    9239 Nearest lake suddenly appears at the center of the nearest town
    9240 Nearest lake suppresses magic within one mile of its shores
    9241 Nearest lake undergoes massive tidal surges for one week
    9242 Nearest monastery conceals a gate to hell
    9243 Nearest monastery holds the only copies of many priceless books
    9244 Nearest monastery often engages in dangerous and abhorrent rites
    9245 Nearest mountain slides 1d10 miles north
    9246 Nearest oak tree grows to 20X its current size
    9247 Nearest oak tree is older than the entire world
    9248 Nearest oak tree periodically shoots poisonous thorns
    9249 Nearest oak tree turns to bronze
    9250 Nearest oak tree turns to solid gold
    9251 Nearest oak tree uproots and goes on a rampage
    9252 Nearest priest becomes fearless in the face of death
    9253 Nearest priest believes heis been excommunicated
    9254 Nearest priest believes that cannibalism is a sacrament
    9255 Nearest priest believes that clothing is an abomination
    9256 Nearest priest believes that heis recently slain his deity
    9257 Nearest priest believes that his deity has abandoned him
    9258 Nearest priest believes that his deity has made him immortal
    9259 Nearest priest believes that his deity is at his beck and call
    9260 Nearest priest believes that his deity is standing nearby
    9261 Nearest priest believes that someone nearby is his deity
    9262 Nearest priest falls badly out of favor with his deity
    9263 Nearest priest finds a book of nice and accurate prophecies
    9264 Nearest priest has been stealing from the churchis coffers
    9265 Nearest priest has secretly engaged in commendable charity work
    9266 Nearest priest is implicated in a scandal involving livestock
    9267 Nearest priest is summoned by his deity
    9268 Nearest priest is wholly immune to arcane magic for 4d6 hours
    9269 Nearest priest realizes that heis worshipping the wrong deity
    9270 Nearest priest thinks heis being persecuted for his beliefs
    9271 Nearest river conceals the entrance to a great underground empire
    9272 Nearest river freezes solid over the next 1d10 rounds
    9273 Nearest river is dammed
    9274 Nearest river is damned
    9275 Nearest river is discovered to be artificial
    9276 Nearest river is now 1d4X as deep as it was this morning
    9277 Nearest river is permanently blood red but is otherwise unchanged
    9278 Nearest river now runs directly through the nearest town
    9279 Nearest river now runs directly through this area
    9280 Nearest stone structure undergoes explosive decompression
    9281 Nearest town breaks loose from the mainland and drifts out to sea
    9282 Nearest town descends into weeks of mindless debauchery
    9283 Nearest town erupts into riots and turf wars
    9284 Nearest town is actually hidden within a modern wildlife preserve
    9285 Nearest town is annexed by a warring neighbor nation
    9286 Nearest town is completely deserted
    9287 Nearest town is completely overrun by marauding orcs
    9288 Nearest town is inaccessible by land
    9289 Nearest town is populated entirely by a brutal and dangerous cult
    9290 Nearest town is populated entirely by anthropomorphic pigs
    9291 Nearest town is populated entirely by illusions
    9292 Nearest town is populated entirely by undead
    9293 Nearest town is razed
    9294 Nearest town is the site of an ancient magical battle
    9295 Nearest town is totally forgotten by the outside world
    9296 Nearest town secedes from the kingdom
    9297 Nearest town signs a secret pact with an invading horde of orcs
    9298 Nearest wizard breaks his staff and throws his books into the sea
    9299 Nearest wizard can only use magic in full daylight
    9300 Nearest wizard is beseeched by a girl, her dog, and three friends
    9301 Nearest wizard is challenged to a magical duel by a dragon
    9302 Nearest wizard is equally affected by magic he casts on others
    9303 Nearest wizard is exposed as a fraud and a charlatan
    9304 Nearest wizard is unable to cast magic upon himself
    9305 Nearest wizard suspects that heis a fraud and a charlatan
    9306 Next 1d4 people to draw weapons nearby fall unconscious
    9307 Next 1d4 people to draw weapons nearby forget how to use them
    9308 Next 1d4+1 spells cast in this area also trigger Chaos Bursts
    9309 Next area-effect magic used nearby affects only a single target
    9310 Next area-effect magic used nearby affects only males
    9311 Next area-effect magic used nearby centers on a point miles away
    9312 Next area-effect magic used nearby centers on its caster
    9313 Next fire-based magic used nearby causes panic in all who see it
    9314 Next fire-based magic used nearby detonates on its caster
    9315 Next fire-based magic used nearby produces cold instead of heat
    9316 Next fire-based magic used nearby produces impenetrable darkness
    9317 Next fire-based magic used nearby produces smoke but no fire
    9318 Next fire-based magic used nearby produces water instead of fire
    9319 Next person nearby to draw blood also loses that many hit points
    9320 Next person nearby to draw blood appears in the nearest prison
    9321 Next person nearby to draw blood becomes water soluble
    9322 Next person nearby to draw blood can use no weapon for 2d12 hours
    9323 Next person nearby to draw blood canit be blinded by smoke
    9324 Next person nearby to draw blood dies if heis wounded before dawn
    9325 Next person nearby to draw blood disgorges a large steel bowl
    9326 Next person nearby to draw blood gains that many hit points
    9327 Next person nearby to draw blood has a +4 ToHit bonus until dawn
    9328 Next person nearby to draw blood howls like a wolf under the moon
    9329 Next person nearby to draw blood is 10% likely to crumble to dust
    9330 Next person nearby to draw blood is 10% likely to explode
    9331 Next person nearby to draw blood is himself sprayed with blood
    9332 Next person nearby to draw blood is sought by the authorities
    9333 Next person nearby to draw blood is swarmed by innumerable bats
    9334 Next person nearby to draw blood is whisked away into the sky
    9335 Next person nearby to draw blood never needs to sleep again
    9336 Next person nearby to draw blood shrinks by 8d10%
    9337 Next person nearby to draw blood suffers extensive amnesia
    9338 Next person nearby to draw blood then tries to destroy his weapon
    9339 Next person nearby to draw blood thereafter thinks heis a vampire
    9340 Next person nearby to draw blood thinks that on fire
    9341 Next person nearby to draw blood vanishes for 1d4 days
    9342 Next person nearby to draw blood wakes tomorrow as a chimpanzee
    9343 Next person nearby to draw blood wakes tomorrow soaked in blood
    9344 Next person nearby to miss an attack canit attack for 4d6 hours 
    9345 Next person nearby to miss an attack collapses into a deep coma
    9346 Next person nearby to miss an attack cries like a baby until dawn
    9347 Next person nearby to miss an attack shrieks wildly for 4d6 hours
    9348 Next person nearby to say his name canit use magic for 1d10 days
    9349 Next person nearby to say his name goes berserk
    9350 Next person nearby to say his name is attacked by rabbits
    9351 Next person nearby to say his name is attacked by rodents
    9352 Next person nearby to say his name is healed for 2d6 hit points
    9353 Next person nearby to say his name is targeted for assassination
    9354 Next person nearby to say his name permanently forgets his name
    9355 Next person nearby to say his name teleports into a nearby cave
    9356 Next person nearby to say his name then runs away at top speed
    9357 Next person nearby to say his name wakes 5d10 miles away tomorrow
    9358 Next person nearby to speak finds that his mouth has vanished
    9359 Next person nearby to speak is bound in coils of steel wire
    9360 Next person nearby to speak is hurled 10d10 feet in the air
    9361 Next person nearby to speak is thrown into a deep well
    9362 Next person nearby to use magic becomes two dimensional
    9363 Next person nearby to use magic is 5% likely to be disemboweled
    9364 Next person nearby to use magic is enslaved to someone nearby
    9365 Next person nearby to use magic is restored to full hit points
    9366 Next person nearby to use magic is turned to wood
    9367 Next person nearby to use magic is wrapped in a cocoon
    9368 Next person nearby to use magic loses the ability to feel pain
    9369 Next person nearby to use magic rises one level
    9370 Next person nearby to use magic sees illusory giraffes everywhere
    9371 Next person nearby to use magic then shuns all magic for 1d4 weeks
    9372 Next person nearby to use magic turns bright pink for 1d4 weeks
    9373 Next person nearby to use magic turns into a frog or a dove
    9374 Next person nearby to use magic turns into a zombie for 1d8 days
    9375 Next person nearby to use magic turns invisible above his nose
    9376 Next person nearby to use profanity is fined 500,000 gold pieces
    9377 Next person nearby to use profanity is stricken mute for one week
    9378 Next person slain nearby crumbles into a heap of toxic ash
    9379 Next person slain nearby disappears without a trace
    9380 Next person slain nearby explodes messily
    9381 Next person slain nearby flies into the air and vanishes
    9382 Next person slain nearby has his skull and spine torn out
    9383 Next person slain nearby haunts the area for hundreds of years
    9384 Next person slain nearby is borne away by wonder-working dolphins
    9385 Next person slain nearby is found to contain hundreds of mice
    9386 Next person slain nearby is immediately breaded and deep-fried
    9387 Next person slain nearby is immediately butchered like a deer
    9388 Next person slain nearby is immediately plated in chrome
    9389 Next person slain nearby is resurrected with full hit points
    9390 Next person slain nearby is soon thereafter worshipped as a god
    9391 Next person slain nearby is welcomed into his deityis pantheon
    9392 Next person slain nearby never really existed
    9393 Next person slain nearby slowly transforms into solid gold
    9394 Next person slain nearby sputters about like a deflating balloon
    9395 Next person slain nearby turns into a large swine as he dies
    9396 Next person slain nearby was the offspring of a god
    9397 Next person struck by magic nearby thinks heis a toddler
    9398 Next person to be injured nearby is permanently crippled
    9399 Next person to be injured nearby is restored to full hit points
    9400 Next person to cross the nearest bridge turns into a troll
    9401 Next plant-based magic used nearby turns its user to a scarecrow
    9402 Next plant-based magic uses nearby turns its user to a vegetarian
    9403 Next polymorph magic used nearby affects 1d4 other targets nearby
    9404 Next polymorph magic used nearby affects a random target nearby
    9405 Next polymorph magic used nearby canit be undone
    9406 Next polymorph magic used nearby completely heals its caster
    9407 Next polymorph magic used nearby doubles its casteris height
    9408 Next polymorph magic used nearby is only 50% effective
    9409 Next polymorph magic used nearby knocks its caster unconscious
    9410 Next polymorph magic used nearby lapses after one round
    9411 Next polymorph magic used nearby lasts for 1d100 days
    9412 Next polymorph magic used nearby leaves its caster badly deformed
    9413 Next polymorph magic used nearby makes its caster a quadruped
    9414 Next polymorph magic used nearby splits its target in two
    9415 Next polymorph magic used nearby turns its caster into a rooster
    9416 Next polymorph magic used nearby turns its caster into its target
    9417 Next polymorph magic used nearby turns its target into a whale
    9418 Next polymorph magic used nearby turns its target to living metal
    9419 Next polymorph magic used nearby turns its target to stone
    9420 Next polymorph magic used nearby yields a random result
    9421 Next spell cast in this area equally affects all within 50 yards
    9422 Next spell cast in this area has a permanent duration
    9423 Next weapon drawn nearby attacks its wielder
    9424 Next weapon drawn nearby becomes twice as heavy as its wielder
    9425 Next weapon drawn nearby canit cross running water
    9426 Next weapon drawn nearby canit kill anyone while its owner lives
    9427 Next weapon drawn nearby causes its wielder to distrust magic
    9428 Next weapon drawn nearby chills to -200°
    9429 Next weapon drawn nearby damages the sanity of its wielder
    9430 Next weapon drawn nearby disintegrates if used to kill someone
    9431 Next weapon drawn nearby fills its wielder with crippling fear
    9432 Next weapon drawn nearby forces its wielder to attack his allies
    9433 Next weapon drawn nearby hurls itself into the sky
    9434 Next weapon drawn nearby ignites and burns like magnesium
    9435 Next weapon drawn nearby inflicts only illusory damage
    9436 Next weapon drawn nearby inflicts only minimum possible damage
    9437 Next weapon drawn nearby instantly quadruples in size
    9438 Next weapon drawn nearby is as soft as silk until sunset tomorrow
    9439 Next weapon drawn nearby is attracted to the spellis target point
    9440 Next weapon drawn nearby is instantly struck by lightning
    9441 Next weapon drawn nearby makes its useris foes invisible to him
    9442 Next weapon drawn nearby makes its wielder seem far more powerful
    9443 Next weapon drawn nearby makes its wielder think heis immortal
    9444 Next weapon drawn nearby makes its wielder think heis invisible
    9445 Next weapon drawn nearby mimics its wielderis personality
    9446 Next weapon drawn nearby pulses with strange lights and music
    9447 Next weapon drawn nearby quickly becomes as hot as the Sun
    9448 Next weapon drawn nearby seizes control of its wielderis body
    9449 Next weapon drawn nearby vanishes until the melee is over
    9450 Next weapon drawn nearby was stolen from the royal armory
    9451 Next weapon nearby to draw blood appears to be horribly evil
    9452 Next weapon nearby to draw blood attracts a demonis attention
    9453 Next weapon nearby to draw blood becomes invisible to its wielder
    9454 Next weapon nearby to draw blood becomes legendary
    9455 Next weapon nearby to draw blood can thereafter cut through steel
    9456 Next weapon nearby to draw blood canit draw blood for 1d4 weeks
    9457 Next weapon nearby to draw blood ceases to exist
    9458 Next weapon nearby to draw blood doubles in length until sunrise
    9459 Next weapon nearby to draw blood glows in the presence of humans
    9460 Next weapon nearby to draw blood has been used to murder a king
    9461 Next weapon nearby to draw blood heats to 800°
    9462 Next weapon nearby to draw blood imparts visions of perdition
    9463 Next weapon nearby to draw blood induces bloodlust in its wielder
    9464 Next weapon nearby to draw blood induces envy in its wielder
    9465 Next weapon nearby to draw blood induces lethargy in its wielder
    9466 Next weapon nearby to draw blood induces mad panic in its wielder
    9467 Next weapon nearby to draw blood induces pacifism in its wielder
    9468 Next weapon nearby to draw blood infects its wielder with leprosy
    9469 Next weapon nearby to draw blood is +1 ToHit for one week
    9470 Next weapon nearby to draw blood is 10% likely to disintegrate
    9471 Next weapon nearby to draw blood is 10% likely to explode
    9472 Next weapon nearby to draw blood is -2 ToHit for one month
    9473 Next weapon nearby to draw blood is 25% likely to turn to ice
    9474 Next weapon nearby to draw blood is coveted by dragons 
    9475 Next weapon nearby to draw blood is discovered to be a cheap copy
    9476 Next weapon nearby to draw blood is discovered to be an illusion
    9477 Next weapon nearby to draw blood is encased in a plaster cast
    9478 Next weapon nearby to draw blood is forever indestructible
    9479 Next weapon nearby to draw blood is found to be a mighty artifact
    9480 Next weapon nearby to draw blood is fused to its wielderis hand
    9481 Next weapon nearby to draw blood is replaced by an imperfect copy
    9482 Next weapon nearby to draw blood is slicked with butter
    9483 Next weapon nearby to draw blood is struck by lightning 1d6 times
    9484 Next weapon nearby to draw blood is suddenly as light as hydrogen
    9485 Next weapon nearby to draw blood is thereafter highly flammable
    9486 Next weapon nearby to draw blood is thereafter stolen by goblins
    9487 Next weapon nearby to draw blood is worth 100X its normal value
    9488 Next weapon nearby to draw blood knocks its wielder unconscious
    9489 Next weapon nearby to draw blood laughs malevolently until sunset
    9490 Next weapon nearby to draw blood leaps 1d4 months into the future
    9491 Next weapon nearby to draw blood makes its wielder smell horrible
    9492 Next weapon nearby to draw blood quickly ages 1d10000 years
    9493 Next weapon nearby to draw blood returns to its original owner
    9494 Next weapon nearby to draw blood returns to this spot in 6d6 days
    9495 Next weapon nearby to draw blood sinks 1d10 feet into the ground
    9496 Next weapon nearby to draw blood soaks its wielder in blood
    9497 Next weapon nearby to draw blood sprouts thorny projections
    9498 Next weapon nearby to draw blood suddenly weighs 1d4 tons
    9499 Next weapon nearby to draw blood suffers an inconvenient curse
    9500 Next weapon nearby to draw blood teleports to some dragonis horde
    9501 Next weapon nearby to draw blood thereafter craves blood
    9502 Next weapon nearby to draw blood thereby fulfills a prophecy
    9503 Next weapon nearby to draw blood vanishes if that victim dies
    9504 Next weapon nearby to draw blood was forged on another planet
    9505 Next weapon nearby to draw blood will vanish if itis cleaned
    9506 Next weapon nearby to draw blood winds up at the bottom of a well
    9507 Night falls in 1d4 rounds and lasts 2d4-1 days
    9508 No bipedal creatures can come within 10 yards of the target point
    9509 No bipedal creatures can speak within 100 yards of this place
    9510 No blade within one mile can be sharpened for 1d4 weeks
    9511 No blade within one mile can cut live flesh until noon tomorrow
    9512 No females within 50 yards can be injured by males for 6d8 hours
    9513 No females within one mile can speak until sunset tomorrow
    9514 No males within one mile can be injured for 1d4 rounds
    9515 No males within one mile can speak until sunset tomorrow
    9516 No memory, record, or evidence exists about the last 1d10 turns
    9517 No one currently wearing shoes nearby can speak until dawn
    9518 No one currently wearing shoes nearby can use magic for one week
    9519 No one in the world can die or be slain for 3d8 hours
    9520 No one in the world can sleep for 1d6 days
    9521 No one in the world can speak for 10d10 rounds
    9522 No one in the world can tell a lie for the next 24 hours
    9523 No one nearby can eat food for 1d8 days
    9524 No one nearby can teleport or be teleported for 1d4 years
    9525 No one nearby can use any form of scrying magic for one year
    9526 No one within 1,000 miles can successfully cast Dispel Magic
    9527 No one within 1,000 miles knows the spell Remove Curse
    9528 No one within 50 yards benefits from healing magic for 1d10 weeks
    9529 No one within 50 yards can cross running water for 1d4 days
    9530 No one within 50 yards can draw a weapon for 1d10 rounds
    9531 No one within 50 yards can leave the area for 4d6 hours
    9532 No one within 50 yards can see artificial light sources
    9533 No one within 50 yards can speak until dawn
    9534 No one within 50 yards can use rope or the like for 2d4 days
    9535 No one within 50 yards can wear armor for 1d6 days
    9536 No one within 50 yards ever again feels hunger
    9537 No one within 50 yards has eaten in 3d4 days
    9538 No one within 50 yards has slept in 4d6 days
    9539 No one within 50 yards is welcome in any city within 100 miles
    9540 No one within 50 yards needs to breathe until dawn tomorrow
    9541 No one within 50 yards needs to eat for the next month
    9542 No one within 50 yards trusts anyone else for 1d6 hours
    9543 No plants can ever grow again within 50 yards of the target point
    9544 No precipitation falls within 10 miles for 4d6 months
    9545 Non-magical gold is toxic to all within 50 yards
    9546 Non-sentient animals shun this area forever
    9547 Numerous fires erupt in the nearest town
    9548 One magic potion nearby is instantly lethal
    9549 One magic potion nearby will trigger a Chaos Burst when consumed
    9550 One random sword nearby is 40% likely to heal instead of wound
    9551 One random sword nearby is bent like a horseshoe
    9552 One random sword nearby is duplicated under every full moon
    9553 One random sword nearby is permanently blunted
    9554 One random sword nearby is razor-sharp and indestructible
    9555 One random sword nearby leaves faint rainbow streaks in the air
    9556 One random sword nearby opens like an umbrella
    9557 One random sword nearby protects its owner against natural acid
    9558 One random sword nearby protects its owner against natural cold
    9559 One random sword nearby protests loudly when wielded in combat
    9560 One random sword nearby turns into a flock of doves
    9561 One random sword nearby was forged in the fires of hell by demons
    9562 One random sword nearby will explode on contact with blood
    9563 One suit of armor nearby becomes free-willed and belligerent
    9564 One suit of armor nearby fuses into a single piece
    9565 One suit of armor nearby heats to 600° the next time itis struck
    9566 One suit of armor nearby is burned to slag
    9567 Plans for a perpetual motion device appear at the target point
    9568 Popular opinion nearby is sharply opposed to the use of magic
    9569 Poverty is rampant because employers hire cheap kobold laborers
    9570 Priestly magic is impossible within 10 miles for 1d4 hours
    9571 Racial bigotry flares up within a 100 mile radius for 1d4 weeks
    9572 Rats and similar vermin are drawn to this area in great numbers
    9573 Ruins discovered nearby hint at an ancient, advanced civilization
    9574 Scalding steam sprays violently from the spellis target point
    9575 Seawater is highly toxic to all within 50 yards
    9576 Several large saw blades whirl through the area for 2d6 rounds
    9577 Shadows in this area seem to conceal malicious, mischievous imps
    9578 Small pebbles pelt all within 50 yards who arenit wearing armor
    9579 Snow falls heavily in the area for 2d4-1 days and nights
    9580 Some dangerous anachronistic beast appears at the target point
    9581 Some magic item nearby absorbs its owner and becomes an artifact
    9582 Some magic item nearby gives off highly toxic light
    9583 Some major race dies out in the next 2d4 years
    9584 Some major race splits into two incompatible sub-species
    9585 Some non-magical animal nearby becomes immortal
    9586 Some non-magical animal nearby suddenly has 25 Intelligence
    9587 Someone nearby acquires 10% magic resistance
    9588 Someone nearby adopts a new mentor each day
    9589 Someone nearby always thinks that itis raining
    9590 Someone nearby attacks nobles on sight
    9591 Someone nearby attracts 2d10 followers who think heis a prophet
    9592 Someone nearby awakens tomorrow in a stone sepulcher
    9593 Someone nearby babbles about cone-shaped beings who took his mind
    9594 Someone nearby becomes intensely covetous of othersi magic items
    9595 Someone nearby briefly turns into a rooster at every sunrise
    9596 Someone nearby can become a zombie for 1d6 hours per week
    9597 Someone nearby can breathe only underwater for 4d6 hours
    9598 Someone nearby can leap across streams or rivers with ease
    9599 Someone nearby can never sit or lie down again
    9600 Someone nearby can now only be wounded by magic or silver weapons
    9601 Someone nearby can prove that all within 50 yards died years ago
    9602 Someone nearby can regenerate 1 hit point per hour for 1d4 weeks
    9603 Someone nearby can shrink to half his height at will
    9604 Someone nearby can speak only in a whisper 
    9605 Someone nearby can subsist on twigs and grasses
    9606 Someone nearby can survive 1d4 beheadings
    9607 Someone nearby can turn invisible by holding a toad in his mouth
    9608 Someone nearby canit approach within 10 yards of an open door
    9609 Someone nearby canit be harmed by any nonferrous metal
    9610 Someone nearby canit be harmed by smoke
    9611 Someone nearby canit be physically harmed by demons
    9612 Someone nearby canit be strangled by non-magical rope or cord
    9613 Someone nearby canit move his arms in daylight
    9614 Someone nearby claims to speak for the creator of the universe
    9615 Someone nearby dances like a marionette for 1d10 rounds
    9616 Someone nearby develops a radical new philosophy of magic
    9617 Someone nearby discovers solid proof that he doesnit really exist
    9618 Someone nearby discovers solid proof that no deities really exist
    9619 Someone nearby disgorges 1d6 large housecats
    9620 Someone nearby disgorges 1d6 severed hands
    9621 Someone nearby disgorges a tin bucket of hot coals
    9622 Someone nearby disgorges himself
    9623 Someone nearby doubles in weight in each of the next 1d8 rounds
    9624 Someone nearby engages in frenetic calisthenics for 1d12 hours
    9625 Someone nearby feels crushing humiliation while in sunlight
    9626 Someone nearby feels intensely cold in the presence of horses
    9627 Someone nearby finds a book detailing horrific summoning rites
    9628 Someone nearby finds a complete map of his own nervous system
    9629 Someone nearby finds a large cloth bearing a bearded manis image
    9630 Someone nearby finds a potion that causes its drinker to explode
    9631 Someone nearby finds a potion that changes its drinkeris sex
    9632 Someone nearby finds a potion that cures any non-magical disease
    9633 Someone nearby finds a potion that doubles its drinkeris age
    9634 Someone nearby finds a potion that halves its drinkeris age
    9635 Someone nearby finds a potion that turns its drinker into a gnome
    9636 Someone nearby finds a potion that turns its drinker into a tree
    9637 Someone nearby finds a potion that turns its drinker to sand
    9638 Someone nearby finds a tunnel running straight through the planet
    9639 Someone nearby finds an apparently simple wooden cup
    9640 Someone nearby finds his own severed head from some future time
    9641 Someone nearby flies into a terrible rage when he sees magic used
    9642 Someone nearby forever refuses to believe that magic truly exists
    9643 Someone nearby fosters rumors that heis a demigod
    9644 Someone nearby gains 10d100 experience points
    9645 Someone nearby glows from within as though heis swallowed a torch
    9646 Someone nearby goes berserk and is invulnerable for 1d10 rounds
    9647 Someone nearby habitually makes utterly improbable boasts
    9648 Someone nearby has a legitimate claim to the throne
    9649 Someone nearby has a potion that turns half of his body invisible
    9650 Someone nearby has a transcendent religious experience
    9651 Someone nearby has a treasure map carved into his back
    9652 Someone nearby has deeply offended the ruling family
    9653 Someone nearby has produced a child with a powerful demon
    9654 Someone nearby has two extra thumbs jutting from his forehead
    9655 Someone nearby hoots like an owl when he hears his name
    9656 Someone nearby inflates like a puffer fish whenever heis angry
    9657 Someone nearby inherits wealth equal to a small nationis treasury
    9658 Someone nearby is 3% likely to explode whenever he draws a weapon
    9659 Someone nearby is about to go totally insane
    9660 Someone nearby is accused of assassinating the king
    9661 Someone nearby is attended by 1d4 skeletal servants
    9662 Someone nearby is blamed for looting the nearest magical library
    9663 Someone nearby is blamed for some recent magical disaster
    9664 Someone nearby is blown all out of proportion
    9665 Someone nearby is bound in red-hot iron chains
    9666 Someone nearby is bound to this area and can never leave it
    9667 Someone nearby is carried away by a flock of vultures
    9668 Someone nearby is carrying a long-lost and forbidden manuscript
    9669 Someone nearby is carrying an artifact sacred to 1d4 races
    9670 Someone nearby is carrying an incredibly virulent plague
    9671 Someone nearby is certain that heis immune to poison
    9672 Someone nearby is chained high in the branches of a nearby tree
    9673 Someone nearby is completely fireproof for one year
    9674 Someone nearby is completely immune to non-magical poisons
    9675 Someone nearby is convinced that heill be eternally damned
    9676 Someone nearby is covered with countless hideous and fetid scabs
    9677 Someone nearby is crushed as though at the bottom of the ocean
    9678 Someone nearby is discovered to be a spy
    9679 Someone nearby is discovered to be dangerously sociopathic
    9680 Someone nearby is doomed to die in a horribly embarrassing manner
    9681 Someone nearby is dragged bodily to hell
    9682 Someone nearby is dragged into the sea by hideous fish-people
    9683 Someone nearby is drawn and quartered
    9684 Someone nearby is encased up to his chin in a large glass cube
    9685 Someone nearby is entangled in a massive snarl of ribbons
    9686 Someone nearby is exempt from all laws concerning public decency
    9687 Someone nearby is fatally compressed into a small cube
    9688 Someone nearby is hit by lightning in each of the next 1d4 rounds
    9689 Someone nearby is immobilized at the spellis target point
    9690 Someone nearby is immune to all priestly magic for 1d12 months
    9691 Someone nearby is immune to bludgeoning weapons for 1d8 hours
    9692 Someone nearby is immune to most poison, but meat is toxic to him
    9693 Someone nearby is immune to stabbing weapons for 1d4 days
    9694 Someone nearby is immune to the spell that triggered this Burst
    9695 Someone nearby is implicated in a scandal involving livestock
    9696 Someone nearby is infected with a malign, intelligent parasite
    9697 Someone nearby is known to have destroyed one hundred dragon eggs
    9698 Someone nearby is peeled like a banana
    9699 Someone nearby is possessed by 1d8 demons
    9700 Someone nearby is revealed to be a colony of intelligent insects
    9701 Someone nearby is revealed to be many centuries old
    9702 Someone nearby is revealed to be of demonic heritage
    9703 Someone nearby is said to be the last prophet of a dying religion
    9704 Someone nearby is savaged by vicious, invisible dogs
    9705 Someone nearby is sentenced to be executed for heresy
    9706 Someone nearby is sheathed in candle wax
    9707 Someone nearby is stung by 1d1000 bees
    9708 Someone nearby is suddenly dressed in provocative leather attire
    9709 Someone nearby is suddenly hideously deformed
    9710 Someone nearby is tattooed head to toe with graphic, lurid scenes
    9711 Someone nearby is the illegitimate child of some local ruler
    9712 Someone nearby is the subject of a vivisectionistis experiments
    9713 Someone nearby is torn asunder by dozens of feral children
    9714 Someone nearby is unable to bend his legs until sunrise
    9715 Someone nearby is unable to move from this area until sunrise
    9716 Someone nearby is wearing a suit of solid gold plate armor
    9717 Someone nearby is wearing a suit of the finest sheer silk
    9718 Someone nearby leaves footprints that smolder harmlessly
    9719 Someone nearby must be killed before he destroys us all!
    9720 Someone nearby must be restrained or heill cut off his own hands
    9721 Someone nearby must eat 2X as much food as normal to survive
    9722 Someone nearby must Save each day or grow slightly more frog-like
    9723 Someone nearby must Save each day or lose 5d100 experience points
    9724 Someone nearby must Save each day or permanently lose a hit point
    9725 Someone nearby must Save vs Death or air becomes poisonous to him
    9726 Someone nearby must Save vs Death or become a paper mache statue
    9727 Someone nearby must Save vs Death or freeze solid
    9728 Someone nearby must Save vs Death or grow supernaturally ugly
    9729 Someone nearby must Save vs Death or grow terrifyingly beautiful
    9730 Someone nearby must Save vs Death or his age doubles 2d6 times
    9731 Someone nearby must Save vs Death or his bones explode
    9732 Someone nearby must Save vs Death or his bones turn to soap
    9733 Someone nearby must Save vs Death or his clothing attacks him
    9734 Someone nearby must Save vs Death or his clothing turns to gold 
    9735 Someone nearby must Save vs Death or his head doubles in size
    9736 Someone nearby must Save vs Death or his skin burns from his body
    9737 Someone nearby must Save vs Death or his teeth turn to glass
    9738 Someone nearby no longer heals naturally
    9739 Someone nearby no longer needs to breathe
    9740 Someone nearby no longer needs to eat
    9741 Someone nearby now has a blowhole but no nose
    9742 Someone nearby now has baleen instead of conventional teeth
    9743 Someone nearby now has three legs spaced evenly around his pelvis
    9744 Someone nearby now has two feet jutting from each ankle
    9745 Someone nearby owns the deed to the soul of someone else nearby
    9746 Someone nearby pitches a wacky investment scheme to the king
    9747 Someone nearby realizes that heis a dragon in humanoid form
    9748 Someone nearby realizes that heis been dead for centuries
    9749 Someone nearby realizes that heis carrying a dangerous artifact
    9750 Someone nearby realizes that heis just a fictional character
    9751 Someone nearby realizes that heis the avatar of a deity
    9752 Someone nearby realizes that his hands are someone elseis hands
    9753 Someone nearby realizes that his skin is slowly dissolving
    9754 Someone nearby recalls being tortured by someone else nearby
    9755 Someone nearby refers to some noble as "Lord Manure of Excrement"
    9756 Someone nearby remembers 1d4 fictitious past lives
    9757 Someone nearby renounces all possessions and becomes an ascetic
    9758 Someone nearby rings like a bell whenever he sees magic used
    9759 Someone nearby sees the figure of Death standing beside him
    9760 Someone nearby sets fire to a tree and climbs into its branches
    9761 Someone nearby shows all the signs of late-term pregnancy
    9762 Someone nearby shrieks in horror until sunrise tomorrow
    9763 Someone nearby shrinks by 1d100%
    9764 Someone nearby shrinks by 50% from the waist up
    9765 Someone nearby smells like a corpse in the presence of magic
    9766 Someone nearby speculates about the virtues of dwarf-skin leather
    9767 Someone nearby spins and spits water like a garden sprinkler
    9768 Someone nearby sprays blood-red foam from his nose for 1d6 rounds
    9769 Someone nearby sprouts a trollis arm from the center of his chest
    9770 Someone nearby sprouts a turtleis shell atop his head
    9771 Someone nearby sprouts hideous, non-functional bat wings
    9772 Someone nearby sprouts inflatable sacs from his shoulder blades
    9773 Someone nearby sprouts ornate feathers from his tongue
    9774 Someone nearby sprouts plates from his back like a stegosaurus
    9775 Someone nearby suddenly has a neck like a giraffe
    9776 Someone nearby suddenly has eight eyes like a spider
    9777 Someone nearby suddenly has eight legs
    9778 Someone nearby suddenly has feet like a chicken
    9779 Someone nearby suffers cannibalistic mania while his allies sleep
    9780 Someone nearby suspects that heis trying to kill himself
    9781 Someone nearby swallowed a small explosive device this morning
    9782 Someone nearby teleports 1d10 yards in each of 1d10 rounds
    9783 Someone nearby thinks he can snuff fires by sitting in them
    9784 Someone nearby thinks heill die if he says his name in moonlight
    9785 Someone nearby thinks heis invisible in the presence of royalty
    9786 Someone nearby thinks heis the last survivor of an extinct race
    9787 Someone nearby thinks that he smells like a corpse
    9788 Someone nearby tries suicide with the next silver weapon he sees
    9789 Someone nearby tries to cut himself in half lengthwise
    9790 Someone nearby tries to eat his own hands
    9791 Someone nearby tries to kill every cow he sees
    9792 Someone nearby tries to scalp himself
    9793 Someone nearby tries to swallow his own arm, elbow first
    9794 Someone nearby triggers a Burst when he next crosses a bridge
    9795 Someone nearby triggers a Burst when he next traverses a doorway
    9796 Someone nearby truly believes that heis a prophesized redeemer
    9797 Someone nearby turns to a heap of gold dust
    9798 Someone nearby turns to a heap of moist sand
    9799 Someone nearby turns to salt over the next 1d8 days
    9800 Someone nearby turns to stone over the next 5d6 days
    9801 Someone nearby turns to water
    9802 Someone nearby turns to wood when he drops to one hit point
    9803 Someone nearby vanishes and is replaced by a handsome wax replica
    9804 Someone nearby wakes tomorrow in a rocis nest
    9805 Someone nearby wakes tomorrow in the kingis torture chamber
    9806 Someone nearby weeps tears of honey when he feels pain
    9807 Someone nearby who can read is rendered illiterate for 1d4 weeks
    9808 Someone nearby who canit read can suddenly read 1d6 languages
    9809 Someone nearby who has never before used magic finds an artifact
    9810 Someone nearby who is carrying a magic item tries to eat it
    9811 Someone nearby will be vital to a major truce between two races
    9812 Someone nearby will combust if he lights a fire by dawn tomorrow
    9813 Someone nearby will combust when he next crosses moving water
    9814 Someone nearby will die if he says his name backwards
    9815 Someone nearby will die if he travels more than a mile in one day
    9816 Someone nearby will explode if he draws blood by sunset today
    9817 Someone nearby will fall into a vat of molten cheese before dawn
    9818 Someone nearby will soon incite a war between two major races
    9819 Sparks dance along any blades that strike one another nearby
    9820 Suddenly itis raining harder than anyone has ever experienced
    9821 Suddenly the area is snowbound as from a year-long blizzard
    9822 Summonings are impossible within one mile of the target point
    9823 Temperature within 100 yards drops 1° per minute for 1d4 hours
    9824 Temperature within 100 yards rises 1° per minute for 1d4 hours
    9825 The arms of someone nearby turn into wings like those of a duck
    9826 The complete skeleton of a huge red dragon tumbles from the sky
    9827 The corpse of a forgotten deity is discovered in a nearby cave
    9828 The entire area begins sinking at a rate of one foot per week
    9829 The entire area enjoys full daylight for 1d10 years
    9830 The entire area gives an impression of peace and tranquility
    9831 The entire area gives off a powerful impression of evil
    9832 The entire area has been surrounded by an invading horde
    9833 The entire area hums as if vast machinery is buried in the ground
    9834 The entire area induces fear in those of four or fewer hit dice
    9835 The entire area induces sloth and lethargy in humans
    9836 The entire area is a dumping ground for dangerous magical waste
    9837 The entire area is a haven for zombies
    9838 The entire area is a massive shrine to an abominable god
    9839 The entire area is an illusion; itis actually barren and rocky
    9840 The entire area is as hot and steamy as a sauna for 2d12 hours
    9841 The entire area is blasted as if a huge conflagration has passed
    9842 The entire area is circled by a salt-water moat full of sharks
    9843 The entire area is claimed as a sacred goblin burial ground
    9844 The entire area is dark as midnight for 1d4 weeks
    9845 The entire area is directly over a gigantic vein of gold
    9846 The entire area is encircled by tall Corinthian columns of marble
    9847 The entire area is inimical to life for 4d12 months
    9848 The entire area is littered with hideously mutilated corpses
    9849 The entire area is located over a gargantuan termite colony
    9850 The entire area is located over the lair of an enormous dragon
    9851 The entire area is mirror-reversed
    9852 The entire area is shrouded in a thick and pungent fog
    9853 The entire area is strewn with jellyfish like a shore at low tide
    9854 The entire area is thickly shrouded by dust and cobwebs
    9855 The entire area is transported to a small island far out to sea
    9856 The entire area looks as if a huge battle took place yesterday
    9857 The entire area looks exactly as it did 1d10 centuries ago
    9858 The entire area looks exactly as it will 1d10 centuries from now
    9859 The entire area suffers an intense blizzard for 2d6 rounds
    9860 The entire area swirls with fine white powder
    9861 The entire area was at the bottom of the sea 1d4 weeks ago
    9862 The entire area will be the site of a monumental battle tomorrow
    9863 The entire planet experiences full daylight for 5d10+24 hours
    9864 The gates of hell open for 4d6 hours 
    9865 The ground beneath the target point collapses into a vast cavern
    9866 The ground beneath the target point heats to its combustion point
    9867 The ground beneath the target point is charged with electricity
    9868 The ground beneath the target point looks like the portal to hell
    9869 The ground is totally flat from here to the horizon for 4d6 hours
    9870 The ground nearby harbors enormous, carnivorous earthworms
    9871 The ground nearby is highly susceptible to erosion
    9872 The ground nearby splits open to a depth of 1d10 miles
    9873 The ground within 50 yards has never been trod by a human foot
    9874 The ground within 50 yards heaves like a bubble on a pond
    9875 The ground within 50 yards is carpeted
    9876 The ground within 50 yards is covered by terra cotta tile
    9877 The ground within 50 yards is found to be completely artificial
    9878 The ground within 50 yards is incredibly sticky
    9879 The ground within 50 yards is now perfectly smooth steel
    9880 The ground within 50 yards is permanently swampy and waterlogged
    9881 The ground within 50 yards is tangled with invisible vines
    9882 The ground within 50 yards is the sanctum of a temperamental god
    9883 The ground within 50 yards shows signs of a recent meteor strike
    9884 The ground within 50 yards sinks to a point like a funnel or cone
    9885 The ground within 50 yards slowly turns into a deep, calm lake
    9886 The ground within 50 yards swarms with biting insects
    9887 The ground within 50 yards yields only poisonous vegetation
    9888 The high priest of some deity appears at the target point
    9889 The largest creature nearby doubles in size
    9890 The largest creature nearby turns invisible for 4d6 hours
    9891 The moon appears to blaze with cool blue fire for 1d12 months
    9892 The moon came into existence only 1d4 days ago
    9893 The moon doubles in size
    9894 The moon explodes
    9895 The moon has a huge bite taken out of it
    9896 The moon has a large hole all the way through it
    9897 The moon is full every night for the next year
    9898 The moon is no moon; itis a space station
    9899 The moon is now a cube
    9900 The moon is now geostationary
    9901 The moon is now solid gold except for a thin cover of dust
    9902 The moon moves 50% closer to the Earth
    9903 The moon resembles the face of someone nearby
    9904 The moon revolves around the planet at 1d4X its current rate
    9905 The moon suddenly holds untold riches and unimaginable dangers
    9906 The moon vanishes for 1d12 months
    9907 The moon whirls wildly through the sky for 7d4 days
    9908 The most powerful wizard nearby vanishes for 3d8 hours
    9909 The most powerful wizard within 10 miles changes sex
    9910 The most powerful wizard within 10 miles goes on a rampage
    9911 The most powerful wizard within 10 miles is actually a demon
    9912 The most valuable item within 50 yards turns out to be a fake
    9913 The most valuable sword within 50 yards turns to mercury
    9914 The nearest townis entire population appears nearby
    9915 The nearest townis entire population is linked into a hive-mind
    9916 The past 1d10 rounds were only an illusion
    9917 The Philosopheris Stone appears at the target point
    9918 The planet breaks loose from the Sunis gravity
    9919 The planet no longer rotates
    9920 The planet now has a ring around it
    9921 The planet now rotates half as fast
    9922 The planet now rotates in the opposite direction
    9923 The planet now rotates north-to-south
    9924 The planet now rotates twice as fast
    9925 The planet splits into two stable hemispheres 10 yards apart
    9926 The planet tumbles into another ice age
    9927 The planetis atmosphere leaks into space over the next 1d6 months
    9928 The planetis average temperature rises 1° per week for 4d6 weeks
    9929 The planetis hemispheres rotate at slightly different rates
    9930 The planetis oceans are becalmed
    9931 The planetis orbital radius shrinks by 1d8 x 10,000 miles
    9932 The royal family appears in the vicinity
    9933 The scent of honey and roses permeates everything within 50 yards
    9934 The scent of rotten eggs permeates everything within 50 yards
    9935 The sky appears to be ablaze as far as the eye can see
    9936 The sky appears to teem with a vast host of angels
    9937 The sky overhead swirls with dark colors for 1d4 turns
    9938 The sky whirls with dazzling colors until sunset tomorrow
    9939 The sound of hundreds of barking dogs fills the air
    9940 The sound of mighty winds fills the air, but the air is calm
    9941 The spell discharges randomly in each of the next 4d4 rounds
    9942 The spell discharges upon the next person nearby to draw blood
    9943 The sun appears pale blue from now on
    9944 The sun splits into a stable binary pair
    9945 The Burst is delayed until blood is drawn nearby; roll for effect
    9946 The Burst only affects females; roll for the underlying effect
    9947 The Burst only affects males; roll for the underlying effect
    9948 The Burst only appears to occur; roll again for apparent effect
    9949 The tallest person in the area develops an acute fear of heights
    9950 The tallest person in the area grows by 50%
    9951 The tallest person in the area is attacked by beavers
    9952 The tallest person in the area shrinks by 50%
    9953 The tallest tree nearby burns to the ground in 1d4 rounds
    9954 The target point acquires intelligence and free will
    9955 The target point becomes a window for seeing into other worlds
    9956 The target point becomes an open gateway to hell
    9957 The target point is a conduit to interstellar space
    9958 The target point is a tiny gateway to some distant world
    9959 The target point is direct conduit to Elemental Air
    9960 The target point is encircled by bright red plastic cones
    9961 The target point is intensely magnetic for 4d6 hours
    9962 The target point is rumored to be a site of healing
    9963 The target point is sealed in a 10 foot globe of force
    9964 The target point is the center of a zone of anti-magic
    9965 The target point is the site of some powerful deityis murder
    9966 The target point makes a noise like an air raid siren
    9967 The target point radiates intense cold for 4d6 hours
    9968 The target point radiates intense heat for 4d6 hours
    9969 The target point scrambles any effort to teleport near it
    9970 The temperature within 50 yards drops 10d10 degrees for one hour
    9971 The temperature within 50 yards rises 10d10 degrees for one hour
    9972 This day hasnit happened; time is reset to midnight last night
    9973 Thousands of carpenteris nails fall from the sky
    9974 Thousands of teeth rain down from the sky
    9975 Thousands of tiny glass ovoids fall from the sky
    9976 Time no longer passes within 1d4 yards of the target point
    9977 Time passes 10X as fast within 1d4 yards of the target point
    9978 Tomorrowis high tide crests at the spellis target point
    9979 Townspeople nearby are easily cowed by a charismatic speaker
    9980 Triumphant fanfare fills the air for 1d6 turns
    9981 Undead lobby the local ruler for legislative representation
    9982 Very salty rain falls for 1d4 hours
    9983 Viscous pus oozes from all wounds suffered within 50 yards
    9984 Viscous yellow goo seeps from any bladed weapons nearby
    9985 Volcanic ash blankets the area to a depth of 1d4 inches
    9986 Walking in this area is as arduous as trudging through deep snow
    9987 Water consumed in this area induces delusions of amphibiousness
    9988 Water consumed in this area tastes like the finest wine
    9989 Water consumed in this area tastes strongly of manure
    9990 Water flows from the target point to fill a 100-yard hemisphere
    9991 Water in this area boils at 70° Fahrenheit
    9992 Water in this area freezes at 70° Fahrenheit
    9993 Weather in this area changes drastically each hour for one week
    9994 Weather in this area is supernaturally intense for 1d4 months 
    9995 While in this area, males are invisible to females, and vice versa
    9996 While in this area, no one can include nouns in their speech
    9997 While in this area, no one can inflict or suffer any injury
    9998 While in this area, no one can speak of anything outside the area
    9999 While in this area, no one can speak to anyone else in the area
    0000 The Stars Are Right!
    """; 
}