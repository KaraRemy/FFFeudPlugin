using System.Collections.Generic;
namespace FFFeudPlugin.Models;

public static class DefaultQuestions
{
    public static Category GetDefaultCategory()
    {
        var category = new Category { Name = "FF Feud Questions" };
        {
            var q = new Question { Title = "The hardest job to play is ..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Black Mage", Description = "", Points = 28 });
        q.Answers.Add(new Answer { Text = "Ninja", Description = "", Points = 19 });
        q.Answers.Add(new Answer { Text = "Astrologian", Description = "", Points = 14 });
        q.Answers.Add(new Answer { Text = "Scholar", Description = "", Points = 13 });
        q.Answers.Add(new Answer { Text = "Monk", Description = "", Points = 12 });
        q.Answers.Add(new Answer { Text = "Sage", Description = "", Points = 5 });
        q.Answers.Add(new Answer { Text = "Bard", Description = "", Points = 5 });
        q.Answers.Add(new Answer { Text = "Fisher", Description = "", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What would make you quit a duty instantly?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Where the jobstone at?", Description = "No jobstone", Points = 21 });
        q.Answers.Add(new Answer { Text = "That's just mean!", Description = "Intense toxicity, harassment", Points = 20 });
        q.Answers.Add(new Answer { Text = "Did you visit the Novice Hall?", Description = "Bad players, missing gear", Points = 12 });
        q.Answers.Add(new Answer { Text = "I fight to the end!", Description = "I would never quit instantly,", Points = 11 });
        q.Answers.Add(new Answer { Text = "ARR Alli Raid? Again?", Description = "Unwanted & Repetitive Content", Points = 11 });
        q.Answers.Add(new Answer { Text = "YPYT", Description = "you pull, you tank", Points = 10 });
        q.Answers.Add(new Answer { Text = "Someone left", Description = "DC, someone gone", Points = 9 });
        q.Answers.Add(new Answer { Text = "I think my house burns", Description = "Anything IRL related (doorbell, phone, toilet, etc.)", Points = 6 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something healers have nightmares about!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "The tank suuuucks", Description = "Bad Tank, no MITS", Points = 38 });
        q.Answers.Add(new Answer { Text = "Oh! Another Vuln Stack :3", Description = "Players collecting Vuln Stacks (Black Mage & Dragoon)", Points = 18 });
        q.Answers.Add(new Answer { Text = "It's a Yan, Run!", Description = "A Specific Duty or Mechanic", Points = 13 });
        q.Answers.Add(new Answer { Text = "Living Dead!!", Description = "The Tank using their invulnerability skill", Points = 9 });
        q.Answers.Add(new Answer { Text = "Sorry, heals are sold out", Description = "Not being able to heal (Mana, Cooldowns, Out of Range)", Points = 8 });
        q.Answers.Add(new Answer { Text = "Why are you naked, bro?", Description = "Undergeared Party members, wrong or no gear", Points = 7 });
        q.Answers.Add(new Answer { Text = "Ooopsie", Description = "Making Mistakes (Rescue, Switftcast double, etc.)", Points = 4 });
        q.Answers.Add(new Answer { Text = "Am I solo healing this?", Description = "Bad Co-Healer, Cohealer not doing their job", Points = 3 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the worst thing to happen during a difficult duty?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Someone gets Pokeballed", Description = "DC / Crash", Points = 36 });
        q.Answers.Add(new Answer { Text = "NO YOU SUCK!!!!", Description = "Fighting & Toxicity in chat, Bad Vibe In Chat", Points = 21 });
        q.Answers.Add(new Answer { Text = "Hackerman strikes again", Description = "DDOS / Lag", Points = 13 });
        q.Answers.Add(new Answer { Text = "Kill party? Yeah, right.", Description = "People leaving quickly, especially after mistakes & bad pulls", Points = 7 });
        q.Answers.Add(new Answer { Text = "A Close Wipe", Description = "Wipe at less than 1%, 0.1 Enrage Wipe", Points = 7 });
        q.Answers.Add(new Answer { Text = "I forgot my 24 Totems on my main", Description = "people lie about progression", Points = 6 });
        q.Answers.Add(new Answer { Text = "Where them healers at?", Description = "All healers died / dead healers", Points = 5 });
        q.Answers.Add(new Answer { Text = "There is a bee in my room!", Description = "Any IRL Problem (Toilet, Bee, Fire, Doorbell, etc.)", Points = 5 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "The expansion I liked the most is ..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Shadowbringers", Description = "", Points = 50 });
        q.Answers.Add(new Answer { Text = "Endwalker", Description = "", Points = 32 });
        q.Answers.Add(new Answer { Text = "Stormblood", Description = "", Points = 8 });
        q.Answers.Add(new Answer { Text = "Heavensward", Description = "", Points = 6 });
        q.Answers.Add(new Answer { Text = "Dawntrail", Description = "", Points = 3 });
        q.Answers.Add(new Answer { Text = "ARR", Description = "", Points = 1 });
        q.Answers.Add(new Answer());
        q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the most common complaint about the game?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "It's so boring, what do I do?", Description = "Lack of content / boring", Points = 32 });
        q.Answers.Add(new Answer { Text = "Jobs feel too similar", Description = "", Points = 17 });
        q.Answers.Add(new Answer { Text = "The story sucked", Description = "", Points = 15 });
        q.Answers.Add(new Answer { Text = "Community", Description = "", Points = 10 });
        q.Answers.Add(new Answer { Text = "That's all I get?", Description = "Lackluster Rewards, Reward Structure", Points = 7 });
        q.Answers.Add(new Answer { Text = "Woke Lmao", Description = "Wuk Lamat / Dawntrail", Points = 7 });
        q.Answers.Add(new Answer { Text = "Technical Stuff / DDOS", Description = "", Points = 7 });
        q.Answers.Add(new Answer { Text = "I need a bigger Glam Chest", Description = "Glamour System & Glamour Plates", Points = 5 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name the most annoying grind you did!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Relic Weapons / Tools", Description = "ARR Relic, Bozja relic weapons in 2026, Occult Crescent relic", Points = 58 });
        q.Answers.Add(new Answer { Text = "Field Operation", Description = "Bozja, Eureka, Occult Crescent", Points = 11 });
        q.Answers.Add(new Answer { Text = "The Sugar Glider", Description = "Any Mount", Points = 9 });
        q.Answers.Add(new Answer { Text = "Ishgardian Restoration / Cosmic Exploration", Description = "Not the Relics from cosmic, missions, titles, etc.", Points = 6 });
        q.Answers.Add(new Answer { Text = "In your FATE", Description = "Shared FATE, Fate Farming", Points = 5 });
        q.Answers.Add(new Answer { Text = "Casting my Rod", Description = "Anything fishing realted", Points = 4 });
        q.Answers.Add(new Answer { Text = "My armor!", Description = "Glam / Gear collecting, Nier glams", Points = 4 });
        q.Answers.Add(new Answer { Text = "ARR was so loooong", Description = "MSQ / Quests, Crafting quests, Levequests, MSQ", Points = 3 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "It is very hard to find a good..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Tank / Healer / DPS", Description = "Specific Role or Job", Points = 29 });
        q.Answers.Add(new Answer { Text = "Static", Description = "P  F Group, Static, Random group for Ultimates, DF group", Points = 26 });
        q.Answers.Add(new Answer { Text = "FC", Description = "", Points = 14 });
        q.Answers.Add(new Answer { Text = "Friend(group) to play with", Description = "Friends, groups, communities", Points = 13 });
        q.Answers.Add(new Answer { Text = "Outfit", Description = "Glam / Look", Points = 10 });
        q.Answers.Add(new Answer { Text = "Roll on the shinies", Description = "Roll on loot, loot", Points = 5 });
        q.Answers.Add(new Answer { Text = "Housing Plot", Description = "Open housing spot, Housing lottery", Points = 2 });
        q.Answers.Add(new Answer { Text = "Adventure Plate or Portrait", Description = "Adventure plate, Portrait", Points = 1 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the most annoying story character?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Laaamaaatschiiii", Description = "Wuk Lamat", Points = 29 });
        q.Answers.Add(new Answer { Text = "(early) Alphinaud", Description = "", Points = 15 });
        q.Answers.Add(new Answer { Text = "Asahi", Description = "", Points = 14 });
        q.Answers.Add(new Answer { Text = "Zenos", Description = "", Points = 14 });
        q.Answers.Add(new Answer { Text = "Lyse", Description = "Yda", Points = 11 });
        q.Answers.Add(new Answer { Text = "Fandaniel", Description = "", Points = 6 });
        q.Answers.Add(new Answer { Text = "Urianger", Description = "", Points = 6 });
        q.Answers.Add(new Answer { Text = "Minfilia", Description = "", Points = 5 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "My favourite (scion) companion is..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "G'raha Tia", Description = "", Points = 21 });
        q.Answers.Add(new Answer { Text = "Alisae", Description = "", Points = 20 });
        q.Answers.Add(new Answer { Text = "Y'shtola", Description = "", Points = 14 });
        q.Answers.Add(new Answer { Text = "Estinien", Description = "", Points = 14 });
        q.Answers.Add(new Answer { Text = "Thancred", Description = "", Points = 12 });
        q.Answers.Add(new Answer { Text = "Urianger", Description = "", Points = 9 });
        q.Answers.Add(new Answer { Text = "Alphinaud", Description = "", Points = 6 });
        q.Answers.Add(new Answer { Text = "Tataru", Description = "", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name the best gift to receive or give!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "A golden Beaver", Description = "Minions", Points = 21 });
        q.Answers.Add(new Answer { Text = "*Coin noises*", Description = "Gil", Points = 20 });
        q.Answers.Add(new Answer { Text = "The bling bling Namazu Wagon", Description = "Any Mount", Points = 15 });
        q.Answers.Add(new Answer { Text = "Glam or Dyes", Description = "Dyes, Glamour Pieces, Gear", Points = 14 });
        q.Answers.Add(new Answer { Text = "Boiled Eggs", Description = "Food, Potions", Points = 12 });
        q.Answers.Add(new Answer { Text = "Love, Friendship & Help!", Description = "", Points = 8 });
        q.Answers.Add(new Answer { Text = "Something for $$$", Description = "Mogry Kiosk Item / Emote", Points = 6 });
        q.Answers.Add(new Answer { Text = "Purified Coke", Description = "Funny items, a hooker, catnip", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the most used or a must have emote?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "♥", Description = "Dote / Loveheart", Points = 30 });
        q.Answers.Add(new Answer { Text = "Just Dance!", Description = "Bee's Knees, Manderville Mambo, any Dancing", Points = 22 });
        q.Answers.Add(new Answer { Text = "Im Dead!", Description = "playdead", Points = 20 });
        q.Answers.Add(new Answer { Text = "The one with the glowsticks!", Description = "any cheer emote, glowsticks", Points = 8 });
        q.Answers.Add(new Answer { Text = "Lali-ho!", Description = "", Points = 7 });
        q.Answers.Add(new Answer { Text = "Broooooooooooom", Description = "sweep", Points = 5 });
        q.Answers.Add(new Answer { Text = "*smirk*", Description = "Smile / Grin / Laugh", Points = 4 });
        q.Answers.Add(new Answer { Text = "Pet", Description = "", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "The item I constantly have to throw away is..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Materia", Description = "", Points = 22 });
        q.Answers.Add(new Answer { Text = "Those Gordian Lenses", Description = "Unwanted Trial / Raid token", Points = 18 });
        q.Answers.Add(new Answer { Text = "Meat and Leather", Description = "Overworld Mob Drops / Crafting Materials, trash material from mobs", Points = 16 });
        q.Answers.Add(new Answer { Text = "Sandy & fishy Bottoms!", Description = "Fine Sand, Fish, fishing related items", Points = 15 });
        q.Answers.Add(new Answer { Text = "Confetti", Description = "Magicked Prisms, SFX Items", Points = 13 });
        q.Answers.Add(new Answer { Text = "Stuffed Alpha", Description = "Stuffed Alpha / BomBoko / Furniture", Points = 7 });
        q.Answers.Add(new Answer { Text = "It's time for a d-d-d-duel!", Description = "Triple Triad Cards", Points = 5 });
        q.Answers.Add(new Answer { Text = "Gems from Submarine Ventures", Description = "Or other Venture Trash", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the best or worst item to buy at the Mogry Kiosk (cash shop)?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Vroom Vroom Bike", Description = "Mounts", Points = 21 });
        q.Answers.Add(new Answer { Text = "Pot of paint", Description = "Dyes", Points = 18 });
        q.Answers.Add(new Answer { Text = "I'm a catgirl now, nya!", Description = "Fantasia", Points = 17 });
        q.Answers.Add(new Answer { Text = "That one outfit with the bunny ears", Description = "Any Glams & Outfits", Points = 14 });
        q.Answers.Add(new Answer { Text = "I'm too poor to answer this", Description = "Anything about how expensive it is or not using the shop.", Points = 11 });
        q.Answers.Add(new Answer { Text = "Dotes on you!", Description = "Any Emotes", Points = 8 });
        q.Answers.Add(new Answer { Text = "What story?", Description = "Job / Story Skip", Points = 8 });
        q.Answers.Add(new Answer { Text = "My big love chair", Description = "Any Furniture & Housing Items", Points = 3 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a category of items on the marketboard you feel is way too expensive!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "This full set of gear I just bought *sniff*", Description = "Gear / Glam", Points = 21 });
        q.Answers.Add(new Answer { Text = "Dressed in Black", Description = "Dyes", Points = 20 });
        q.Answers.Add(new Answer { Text = "Pimp my Chocobo", Description = "Mounts, Chocobo bardings", Points = 16 });
        q.Answers.Add(new Answer { Text = "Love potions, I mean uh Draughts", Description = "Potions, Foods, Consumables", Points = 11 });
        q.Answers.Add(new Answer { Text = "The music aisle", Description = "Orchestion Rolls", Points = 10 });
        q.Answers.Add(new Answer { Text = "IKEA", Description = "Furnitures", Points = 8 });
        q.Answers.Add(new Answer { Text = "Crystal & Coke", Description = "Crafting Materials / Shards", Points = 8 });
        q.Answers.Add(new Answer { Text = "Materia", Description = "", Points = 6 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "My favourite place to afk or chill is ..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Home Sweet Home", Description = "My house / FC House", Points = 55 });
        q.Answers.Add(new Answer { Text = "Limsaland", Description = "Limsa", Points = 11 });
        q.Answers.Add(new Answer { Text = "Arcadion-City", Description = "Solution 9", Points = 8 });
        q.Answers.Add(new Answer { Text = "Gridania", Description = "", Points = 7 });
        q.Answers.Add(new Answer { Text = "Old Sharlayan", Description = "", Points = 7 });
        q.Answers.Add(new Answer { Text = "An Inn Room", Description = "", Points = 5 });
        q.Answers.Add(new Answer { Text = "Quicksand :3", Description = "Ul'dah", Points = 4 });
        q.Answers.Add(new Answer { Text = "The Moon", Description = "Mare Lamentorum, Cosmic Exploration", Points = 3 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name the best spot for a secret (e-)rp date!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "My Secret ERP Dungeon", Description = "My House / Room / Island", Points = 38 });
        q.Answers.Add(new Answer { Text = "ERP? I don't do that!", Description = "IDK, not telling, I dont do that", Points = 17 });
        q.Answers.Add(new Answer { Text = "In the far eastern capital!", Description = "Kugane Tower, Kugane Hot Springs", Points = 11 });
        q.Answers.Add(new Answer { Text = "The secret beach in Shirogane", Description = "Shirogane", Points = 10 });
        q.Answers.Add(new Answer { Text = "In the Fairy land!", Description = "Il Mheg", Points = 7 });
        q.Answers.Add(new Answer { Text = "Gross, go touch grass.", Description = "Insulting the author of the poll, fuck you", Points = 6 });
        q.Answers.Add(new Answer { Text = "Electrope has many uses!", Description = "Solution 9", Points = 6 });
        q.Answers.Add(new Answer { Text = "Where it smells fishy", Description = "Limsa", Points = 5 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name the biggest red flag another player can show!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Hey cutie, you here often? :3", Description = "Being weird in a sexual way / Creep", Points = 24 });
        q.Answers.Add(new Answer { Text = "L2P idiot", Description = "Different standards on how to play & Complaining about it", Points = 22 });
        q.Answers.Add(new Answer { Text = "Drama Drama Baby", Description = "Being Rude / Arrogant / Toxic / Stirring Drama for no Reason", Points = 20 });
        q.Answers.Add(new Answer { Text = "YPYT", Description = "", Points = 11 });
        q.Answers.Add(new Answer { Text = "LALAFELL", Description = "Playing a Race considered to be \"bad\"", Points = 7 });
        q.Answers.Add(new Answer { Text = "You had 5s of downtime in that 10min fight", Description = "Parse Junkie, Toxic about parses, Asking you for logs/parse, parse brain", Points = 6 });
        q.Answers.Add(new Answer { Text = "Mentor Crown", Description = "", Points = 6 });
        q.Answers.Add(new Answer { Text = "I'm gonna rezz you now, nya! ♥", Description = "Macro Spam, Cringe raising macro)", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is something you hate to see in chat?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "18+ only!!! Join our Club now!", Description = "Ads vor venues / rmt / events", Points = 48 });
        q.Answers.Add(new Answer { Text = "Fuck you!", Description = "Toxicity", Points = 21 });
        q.Answers.Add(new Answer { Text = "Annoying Macros", Description = "", Points = 14 });
        q.Answers.Add(new Answer { Text = "And then he thrusts his heavy Greatsword...", Description = "ERP", Points = 6 });
        q.Answers.Add(new Answer { Text = "Bigotry", Description = "Any kind of bigotry or ganging up", Points = 5 });
        q.Answers.Add(new Answer { Text = "Jimapelle Baguette", Description = "French", Points = 2 });
        q.Answers.Add(new Answer { Text = "Meowdy", Description = "Meowdy, UwU Talk", Points = 2 });
        q.Answers.Add(new Answer { Text = "And then [REDACTED] died", Description = "Spoilers", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "I think the worst thing about venues is..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Their fucking ads!", Description = "ADS, spam, pf spam", Points = 54 });
        q.Answers.Add(new Answer { Text = "That's a nice little everything you have there", Description = "The Weirdos & creeps", Points = 12 });
        q.Answers.Add(new Answer { Text = "So many people, but it feels empty and boring.", Description = "Lots of afk people, not much talking", Points = 12 });
        q.Answers.Add(new Answer { Text = "Wanna see my Mod Cave?", Description = "All the 3rd party stuff", Points = 7 });
        q.Answers.Add(new Answer { Text = "Everything", Description = "", Points = 5 });
        q.Answers.Add(new Answer { Text = "No idea! I never go there", Description = "", Points = 4 });
        q.Answers.Add(new Answer { Text = "MAYA HI MAYA HOO", Description = "Bad music,twich music, Bad DJs", Points = 4 });
        q.Answers.Add(new Answer { Text = "Where did my Gil go?", Description = "Gambling", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What do you think is most lied about ingame?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "I killed M11S with one hand behind my back", Description = "Their Skill / Progress", Points = 49 });
        q.Answers.Add(new Answer { Text = "I'm Ashley, 21 :3", Description = "Gender / Age", Points = 16 });
        q.Answers.Add(new Answer { Text = "The community is really great!", Description = "Toxic community, Mentally unstable, ", Points = 9 });
        q.Answers.Add(new Answer { Text = "I loved ARR so much!", Description = "Peoples opinion on the Story, The quality of endwalker", Points = 8 });
        q.Answers.Add(new Answer { Text = "Plugins? For FFXIV?", Description = "Use of 3rd party tools", Points = 7 });
        q.Answers.Add(new Answer { Text = "Erp? Noooo, we don't do that here", Description = "ERP related answers", Points = 6 });
        q.Answers.Add(new Answer { Text = "*Hides Submarine Fleet*", Description = "How much gil people really have, rich", Points = 4 });
        q.Answers.Add(new Answer { Text = "BRB *toilet flush*", Description = "Reasons for afk lol", Points = 1 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you definitely don't want to see on an Adventurer's Plate!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "An almost naked catgirl!", Description = "Lewd, profane or nude portraits", Points = 38 });
        q.Answers.Add(new Answer { Text = "F+, WU/T ERP", Description = "ERP preferences & Details", Points = 16 });
        q.Answers.Add(new Answer { Text = "It's .... empty?!? Default Portrait?", Description = "Default pose, Default Portrait, DMV (default) portrait", Points = 11 });
        q.Answers.Add(new Answer { Text = "Lalafell", Description = "", Points = 9 });
        q.Answers.Add(new Answer { Text = "miqosinheat.carrd.co", Description = "A link or ad, Twitter link, Link to heavy modded photos, Links anywhere", Points = 9 });
        q.Answers.Add(new Answer { Text = "I hate BLM", Description = "Bigotry & Toxic vibes,Barely disguised bigotry, Toxic Vibe, Bigotry", Points = 8 });
        q.Answers.Add(new Answer { Text = "\\< Mare Lamentorum \\>", Description = "Public display of 3rd party tools,'moon magic'", Points = 7 });
        q.Answers.Add(new Answer { Text = "Animal Suit Potrait", Description = "", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the funniest or weirdest thing you have seen a Lalafell do?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Mia, did you tend to the customer in room 3 already?", Description = "Weird Roleplaying (Pimp, Child, etc.), act childlike", Points = 24 });
        q.Answers.Add(new Answer { Text = "Die! (Play Dead)", Description = "Any answer implying lalas disappear, die, etc.", Points = 19 });
        q.Answers.Add(new Answer { Text = "Wearing a funny outfit!", Description = "animal-outfits, clown outfit, cosplay, etc.", Points = 16 });
        q.Answers.Add(new Answer { Text = "No Actions required", Description = "Simply existing as a Lalafell", Points = 13 });
        q.Answers.Add(new Answer { Text = "WAAAAAAAAAAAH!", Description = "", Points = 10 });
        q.Answers.Add(new Answer { Text = "Want some coke or catnip?", Description = "Hand out Coke / Pizza / etc.", Points = 8 });
        q.Answers.Add(new Answer { Text = "Where did the Lala go?", Description = "Hide somewhere,Hide under my skirts, Hide inside boxes, Hide in a pot unseen", Points = 6 });
        q.Answers.Add(new Answer { Text = "I CAN'T REACH THE HANDLES!!", Description = "Being too small for a mount", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "The most unhinged party finder entry i saw was about ..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Ruby, I need another feet pic!", Description = "Feet Pic Trading,IRL Feet HQ, Rose selling feet pics on Discord, feet", Points = 26 });
        q.Answers.Add(new Answer { Text = "M Bunny looking for cute AuRa gf", Description = "Playing PF-Tinder, anything where someone looks for an (irl) partner", Points = 24 });
        q.Answers.Add(new Answer { Text = "\\<inside rear\\> \\<Please\\>", Description = "ERP Hookups, ERP, People looking for ERP partners", Points = 17 });
        q.Answers.Add(new Answer { Text = "Old unsynch MINE Raids", Description = "Complete a duty with handicap", Points = 12 });
        q.Answers.Add(new Answer { Text = "Selling themselves for ... services", Description = "Anything where Gil is offered for services/help", Points = 9 });
        q.Answers.Add(new Answer { Text = "PF Drama & Saltiness", Description = "Personal drama", Points = 6 });
        q.Answers.Add(new Answer { Text = "Strategy discussions", Description = "", Points = 4 });
        q.Answers.Add(new Answer { Text = "Your Mom", Description = "Shitposting / Memes", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name the most suspicious title a player can have on display!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Domitrix", Description = "", Points = 34 });
        q.Answers.Add(new Answer { Text = "Any Legend Title", Description = "Ultimate & Legend titles", Points = 21 });
        q.Answers.Add(new Answer { Text = "Deep Canal Raider", Description = "", Points = 19 });
        q.Answers.Add(new Answer { Text = "Curse Curator / Hoard", Description = "Deep Dungeon Hoard title", Points = 7 });
        q.Answers.Add(new Answer { Text = "Goddess of the Hand", Description = "or God", Points = 6 });
        q.Answers.Add(new Answer { Text = "Heart of the Party", Description = "", Points = 6 });
        q.Answers.Add(new Answer { Text = "Of the Holy Body", Description = "", Points = 4 });
        q.Answers.Add(new Answer { Text = "Confederate", Description = "", Points = 3 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the worst thing to happen during an (e-)rp session?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Get right with Halone, sinner!", Description = "(I don't rp), idk", Points = 19 });
        q.Answers.Add(new Answer { Text = "Crossing boundaries & consent issues", Description = "", Points = 18 });
        q.Answers.Add(new Answer { Text = "Wrong Chaaaat! Sorry!", Description = "Wrong chat channel, Wrong Chat, accidentally typing to the wrong person", Points = 16 });
        q.Answers.Add(new Answer { Text = "Someone walks in on us!", Description = "", Points = 15 });
        q.Answers.Add(new Answer { Text = "DC, DDOS or Crashes", Description = "", Points = 14 });
        q.Answers.Add(new Answer { Text = "Slow & boring responses", Description = "", Points = 8 });
        q.Answers.Add(new Answer { Text = "I'm so nervous, what if I can't get it up?", Description = "Cant get it up / Finish too early", Points = 5 });
        q.Answers.Add(new Answer { Text = "Admin pulls you into gaol", Description = "", Points = 5 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people wouldn't admit they did ingame!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "The Lewding!", Description = "any erp related answer, taking lewd screenshots, etc", Points = 46 });
        q.Answers.Add(new Answer { Text = "Mare La-what now?", Description = "Use 3rd Party Tools", Points = 20 });
        q.Answers.Add(new Answer { Text = "Buying a Clear or ... other services", Description = "", Points = 9 });
        q.Answers.Add(new Answer { Text = "Bought Gil", Description = "", Points = 9 });
        q.Answers.Add(new Answer { Text = "I'm not toxic, asshole!", Description = "Being Toxic / A Bad person", Points = 5 });
        q.Answers.Add(new Answer { Text = "I've cleared this a hundret times!", Description = "Lie about prog", Points = 4 });
        q.Answers.Add(new Answer { Text = "Whoopsie, Lag!", Description = "Making a Gameplay Mistake", Points = 4 });
        q.Answers.Add(new Answer { Text = "Buying something from the Mogry Kiosk", Description = "", Points = 3 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Something I don't want to see when entering my house or apartment is ..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Strangers doing the dirty", Description = "any answer with erp", Points = 32 });
        q.Answers.Add(new Answer { Text = "Someone else. Leave me alone.", Description = "Anyone, Wanting to be left alone - angle", Points = 20 });
        q.Answers.Add(new Answer { Text = "Who is that person? What are they doing in my house?", Description = "only people you don't know", Points = 18 });
        q.Answers.Add(new Answer { Text = "Where is my house?", Description = "Demolished house or lost furniture", Points = 15 });
        q.Answers.Add(new Answer { Text = "A Lalafell", Description = "", Points = 6 });
        q.Answers.Add(new Answer { Text = "A 7 foot tall Ehmet Selch statue with candles", Description = "An NPC shrine, Character shrines", Points = 5 });
        q.Answers.Add(new Answer { Text = "My ex. UUUGH!", Description = "", Points = 2 });
        q.Answers.Add(new Answer { Text = "Don't look at it, I can't decorate!", Description = "My cheap or bad furnishing skills", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is a common reason an ingame marriage breaks?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "My spouse stopped playing...", Description = "One of spouse is quit without telling the other, Not Playing Anymore, Partner stops playing", Points = 31 });
        q.Answers.Add(new Answer { Text = "They broke up Irl :(", Description = "IRL breakup", Points = 18 });
        q.Answers.Add(new Answer { Text = "Unfaithfulness? In Eorzea?", Description = "", Points = 18 });
        q.Answers.Add(new Answer { Text = "They fight! Drama, Baby!", Description = "Drama, fights", Points = 15 });
        q.Answers.Add(new Answer { Text = "Now send me your home address so I can visit", Description = "Partner turns out to be a total creep", Points = 5 });
        q.Answers.Add(new Answer { Text = "You aren't a 8 foot tall Bun Boy in irl?", Description = "Lying about gender & age", Points = 5 });
        q.Answers.Add(new Answer { Text = "We only married for the glam & mount, okay?", Description = "", Points = 4 });
        q.Answers.Add(new Answer { Text = "I want someone else!", Description = "A better partner turned up", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "I am most likely to report someone if they ..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "Is toxic in chat", Description = "Is toxic in chat, bad vibes", Points = 31 });
        q.Answers.Add(new Answer { Text = "Are racist, sexist, homophobic or a bigot", Description = "", Points = 19 });
        q.Answers.Add(new Answer { Text = "You pull, you tank!", Description = "Are griefing / YPYT", Points = 17 });
        q.Answers.Add(new Answer { Text = "BUY GIL NOW! ONLY 10$!", Description = "rmt related reports", Points = 17 });
        q.Answers.Add(new Answer { Text = "You are just a dick", Description = "simply being an asshole", Points = 6 });
        q.Answers.Add(new Answer { Text = "Boss fight: BRB", Description = "Afk during content or dont do anything", Points = 4 });
        q.Answers.Add(new Answer { Text = "7penumbra", Description = "Use 3rd party tools / bots / cheats", Points = 4 });
        q.Answers.Add(new Answer { Text = "Spam the chat", Description = "", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name the most Limsa thing a person can do or say!" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "The AFK Guard", Description = "Dance randomly while afk, The suspicious pile of three people sitting on top of one another, Admiral Merlwybb is the best", Points = 31 });
        q.Answers.Add(new Answer { Text = "Looking Lewd & Dancing, Emoting alot", Description = "", Points = 23 });
        q.Answers.Add(new Answer { Text = "PISS CHAT? ARE YOU THERE?", Description = "Being super vocal in chat (spam/rmt/shout/pisschat).", Points = 20 });
        q.Answers.Add(new Answer { Text = "Meowdy! Nya!", Description = "Uwu Talk, cat noises", Points = 10 });
        q.Answers.Add(new Answer { Text = "Hey, wanna have a tour of my house?", Description = "Hitting on people", Points = 6 });
        q.Answers.Add(new Answer { Text = "I'm a pirate, Arrrr!", Description = "Actual Lore answers, pirates, etc.", Points = 5 });
        q.Answers.Add(new Answer { Text = "Bench Wars", Description = "fights about hangout spots", Points = 4 });
        q.Answers.Add(new Answer { Text = "Bard Performances", Description = "Bard perfomances, Bands", Points = 1 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the most obvious giveaway someone is a hardcore erp'er?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "2B bottoms & Hempen Camise", Description = "Lewd Outfits", Points = 30 });
        q.Answers.Add(new Answer { Text = "ERP GER/ENG WU/T F+M♥", Description = "Stuff in their search tags (WU/T / Mare / ERP)", Points = 21 });
        q.Answers.Add(new Answer { Text = "Their Adventure Plate", Description = "especially portrait/looks, not search tags", Points = 16 });
        q.Answers.Add(new Answer { Text = "Quicksands regular", Description = "They are in a particular place alot (Balmung, Limsa, Houses)", Points = 10 });
        q.Answers.Add(new Answer { Text = "Their weird vibe", Description = "How they type", Points = 8 });
        q.Answers.Add(new Answer { Text = "Have you seen the newest RUEXB+ Outfit?", Description = "Talking about or using Mods, Plugins, etc.", Points = 7 });
        q.Answers.Add(new Answer { Text = "Fem Aura standing close to Male Aura", Description = "How they act! (Standing close to someone, rp walking)", Points = 6 });
        q.Answers.Add(new Answer { Text = "$$$", Description = "They are somehow super rich", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "The most annoying macro you have seen was..." };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "I know I died, thank you!", Description = "Rez Macros", Points = 26 });
        q.Answers.Add(new Answer { Text = "WHY IS THERE SOUND AAAH", Description = "Any macro with sound effects", Points = 21 });
        q.Answers.Add(new Answer { Text = "Dwon't yuwu give uwup!", Description = "UWU Rez Macros, anything uwu", Points = 15 });
        q.Answers.Add(new Answer { Text = "Huge Emoji and \"Art\" Macros", Description = "", Points = 10 });
        q.Answers.Add(new Answer { Text = "I am placing Ley Lines NOW....", Description = "", Points = 9 });
        q.Answers.Add(new Answer { Text = "One strike. One kill. *LB3*", Description = "Combat-RP Macros (Announcing attacks, Limitbreaks, etc.)", Points = 9 });
        q.Answers.Add(new Answer { Text = "Casting Living Dead!!!", Description = "Tank Macros, invuln, or Frontline engage", Points = 8 });
        q.Answers.Add(new Answer { Text = "Hello, Hi, Whuzzup, Hey, Hiiii", Description = "Saying hello alot", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What is the most unhinged mod you have seen for FF?" };
            q.Answers.Clear();
        q.Answers.Add(new Answer { Text = "*inflation noises*", Description = "Balloon Proportions", Points = 22 });
        q.Answers.Add(new Answer { Text = "All the lewd & sexy ones", Description = "", Points = 18 });
        q.Answers.Add(new Answer { Text = "What are mods? I dont have that.", Description = "", Points = 17 });
        q.Answers.Add(new Answer { Text = "I didn't know Alexander was that ... big.", Description = "Attaching genitals to bosses, mounts, etc.", Points = 11 });
        q.Answers.Add(new Answer { Text = "Thomas the tank Engine!", Description = "Meme Mods", Points = 9 });
        q.Answers.Add(new Answer { Text = "Outright Cheating & Doing forbidden stuff", Description = "", Points = 8 });
        q.Answers.Add(new Answer { Text = " giant pregnant vore monster in limsa", Description = "Bestiality / Vore, Bestialit", Points = 8 });
        q.Answers.Add(new Answer { Text = "Lalas shouldn't look like that!", Description = "", Points = 7 });
            category.Questions.Add(q);
        }
        return category;
    }
}