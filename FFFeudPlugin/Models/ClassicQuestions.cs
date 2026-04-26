using System.Collections.Generic;
namespace FFFeudPlugin.Models;

public static class ClassicQuestions
{
    public static Category GetClassicCategory()
    {
        var category = new Category { Name = "Classic Family Feud" };
        {
            var q = new Question { Title = "Name something that gets passed around." };
            q.Id = "CL-001";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "A joint", Points = 41 });
            q.Answers.Add(new Answer { Text = "A cold", Points = 27 });
            q.Answers.Add(new Answer { Text = "A collection plate", Points = 14 });
            q.Answers.Add(new Answer { Text = "A rumor", Points = 11 });
            q.Answers.Add(new Answer { Text = "A baby", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people swap." };
            q.Id = "CL-002";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Clothes/Shoes", Points = 24 });
            q.Answers.Add(new Answer { Text = "Phone Numbers", Points = 21 });
            q.Answers.Add(new Answer { Text = "Stories/Gossip", Points = 20 });
            q.Answers.Add(new Answer { Text = "Spit/Germs", Points = 15 });
            q.Answers.Add(new Answer { Text = "Books", Points = 12 });
            q.Answers.Add(new Answer { Text = "Recipes", Points = 8 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that might ripple." };
            q.Id = "CL-003";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Water/Stream", Points = 63 });
            q.Answers.Add(new Answer { Text = "Body/Muscles", Points = 30 });
            q.Answers.Add(new Answer { Text = "Potato Chips", Points = 4 });
            q.Answers.Add(new Answer { Text = "Pants", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that can be inflated or deflated." };
            q.Id = "CL-004";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Balloon", Points = 49 });
            q.Answers.Add(new Answer { Text = "Tire", Points = 27 });
            q.Answers.Add(new Answer { Text = "Beach ball", Points = 11 });
            q.Answers.Add(new Answer { Text = "Ego", Points = 8 });
            q.Answers.Add(new Answer { Text = "Raft", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a place you stop going to when you're broke." };
            q.Id = "CL-005";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Restaurants", Points = 33 });
            q.Answers.Add(new Answer { Text = "Store/mall", Points = 17 });
            q.Answers.Add(new Answer { Text = "Bar/nightclub", Points = 17 });
            q.Answers.Add(new Answer { Text = "Casino", Points = 16 });
            q.Answers.Add(new Answer { Text = "The movies", Points = 8 });
            q.Answers.Add(new Answer { Text = "The bank", Points = 4 });
            q.Answers.Add(new Answer { Text = "Ball game", Points = 2 });
            q.Answers.Add(new Answer { Text = "Racetrack", Points = 3 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that a doctor might pull out of a person." };
            q.Id = "CL-006";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "A gerbil", Points = 38 });
            q.Answers.Add(new Answer { Text = "A baby", Points = 27 });
            q.Answers.Add(new Answer { Text = "A tumor", Points = 17 });
            q.Answers.Add(new Answer { Text = "A tooth", Points = 10 });
            q.Answers.Add(new Answer { Text = "A bullet", Points = 8 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something snowmen might have nightmares about." };
            q.Id = "CL-007";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Sun/Beach Weather", Points = 70 });
            q.Answers.Add(new Answer { Text = "Fire/Flame Throwers", Points = 15 });
            q.Answers.Add(new Answer { Text = "Blow Dryers", Points = 3 });
            q.Answers.Add(new Answer { Text = "Rain", Points = 3 });
            q.Answers.Add(new Answer { Text = "Snowplow/Shovel", Points = 3 });
            q.Answers.Add(new Answer { Text = "Drought", Points = 2 });
            q.Answers.Add(new Answer { Text = "Snowballs", Points = 2 });
            q.Answers.Add(new Answer { Text = "Peeing Dogs/Pee", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that might be full of holes." };
            q.Id = "CL-008";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Swiss Cheese", Points = 43 });
            q.Answers.Add(new Answer { Text = "Clothes/Socks", Points = 17 });
            q.Answers.Add(new Answer { Text = "Alibi/Story", Points = 15 });
            q.Answers.Add(new Answer { Text = "Net/Fishing Net", Points = 10 });
            q.Answers.Add(new Answer { Text = "Colander/Strainer", Points = 9 });
            q.Answers.Add(new Answer { Text = "Golf Course", Points = 2 });
            q.Answers.Add(new Answer { Text = "Screen", Points = 2 });
            q.Answers.Add(new Answer { Text = "Road/Street", Points = 2 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that starts with the word “chow”." };
            q.Id = "CL-009";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Chow Mein", Points = 60 });
            q.Answers.Add(new Answer { Text = "Chowder", Points = 12 });
            q.Answers.Add(new Answer { Text = "Chowhound", Points = 8 });
            q.Answers.Add(new Answer { Text = "Chow Chow", Points = 8 });
            q.Answers.Add(new Answer { Text = "Chow Down", Points = 6 });
            q.Answers.Add(new Answer { Text = "Chowtime", Points = 6 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you don’t want people to ask you for." };
            q.Id = "CL-010";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Money/Donations", Points = 93 });
            q.Answers.Add(new Answer { Text = "Age", Points = 3 });
            q.Answers.Add(new Answer { Text = "Weight", Points = 2 });
            q.Answers.Add(new Answer { Text = "Advice", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a house you never want to be in." };
            q.Id = "CL-011";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Haunted house", Points = 49 });
            q.Answers.Add(new Answer { Text = "House of horrors", Points = 27 });
            q.Answers.Add(new Answer { Text = "House of mirrors", Points = 11 });
            q.Answers.Add(new Answer { Text = "House of cards", Points = 8 });
            q.Answers.Add(new Answer { Text = "House of straw", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that you might find in a bathtub." };
            q.Id = "CL-012";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Water", Points = 49 });
            q.Answers.Add(new Answer { Text = "Soap", Points = 27 });
            q.Answers.Add(new Answer { Text = "Rubber duck", Points = 11 });
            q.Answers.Add(new Answer { Text = "Shampoo", Points = 8 });
            q.Answers.Add(new Answer { Text = "Bubbles", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Other than feet, name something that runs." };
            q.Id = "CL-013";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Water/Toilet", Points = 41 });
            q.Answers.Add(new Answer { Text = "Engine/Car", Points = 27 });
            q.Answers.Add(new Answer { Text = "Refrigerator", Points = 11 });
            q.Answers.Add(new Answer { Text = "Nose", Points = 9 });
            q.Answers.Add(new Answer { Text = "Pantyhose", Points = 9 });
            q.Answers.Add(new Answer { Text = "Clock", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something associated with vampires." };
            q.Id = "CL-014";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Fangs", Points = 49 });
            q.Answers.Add(new Answer { Text = "Cape", Points = 27 });
            q.Answers.Add(new Answer { Text = "Garlic", Points = 11 });
            q.Answers.Add(new Answer { Text = "Cross", Points = 8 });
            q.Answers.Add(new Answer { Text = "Stake", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you see outside that would make you want to stay inside." };
            q.Id = "CL-015";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Bad Weather/Tornado", Points = 77 });
            q.Answers.Add(new Answer { Text = "Bear/Animal", Points = 14 });
            q.Answers.Add(new Answer { Text = "Zombies", Points = 3 });
            q.Answers.Add(new Answer { Text = "Apocalypse", Points = 2 });
            q.Answers.Add(new Answer { Text = "Fire/Smoke", Points = 2 });
            q.Answers.Add(new Answer { Text = "Bad Celebrities", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something in a bakery a baker might call his wife." };
            q.Id = "CL-016";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Dough", Points = 49 });
            q.Answers.Add(new Answer { Text = "Batter", Points = 27 });
            q.Answers.Add(new Answer { Text = "Cake", Points = 11 });
            q.Answers.Add(new Answer { Text = "Pastry", Points = 8 });
            q.Answers.Add(new Answer { Text = "Bread", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a reason a person might wake up at 2:00 in the morning." };
            q.Id = "CL-017";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Nature''s call", Points = 49 });
            q.Answers.Add(new Answer { Text = "Thirsty", Points = 27 });
            q.Answers.Add(new Answer { Text = "Hungry", Points = 11 });
            q.Answers.Add(new Answer { Text = "Nightmare", Points = 8 });
            q.Answers.Add(new Answer { Text = "Restless", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Fill in the blank: hold the ____." };
            q.Id = "CL-018";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Phone", Points = 40 });
            q.Answers.Add(new Answer { Text = "Door", Points = 22 });
            q.Answers.Add(new Answer { Text = "Mayo", Points = 15 });
            q.Answers.Add(new Answer { Text = "Elevator", Points = 14 });
            q.Answers.Add(new Answer { Text = "Line", Points = 9 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "When you hear a noise coming from your basement, what do you pray that it isn’t?" };
            q.Id = "CL-019";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Another Person", Points = 43 });
            q.Answers.Add(new Answer { Text = "Ghost/Monster", Points = 26 });
            q.Answers.Add(new Answer { Text = "Animals/Rats", Points = 21 });
            q.Answers.Add(new Answer { Text = "Flood/Water Heater", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something with teeth." };
            q.Id = "CL-020";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "A Comb", Points = 8 });
            q.Answers.Add(new Answer { Text = "A Saw", Points = 2 });
            q.Answers.Add(new Answer { Text = "A Zipper", Points = 4 });
            q.Answers.Add(new Answer { Text = "Animals", Points = 67 });
            q.Answers.Add(new Answer { Text = "People", Points = 19 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that might come out of your nose when you laugh." };
            q.Id = "CL-021";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Snot", Points = 53 });
            q.Answers.Add(new Answer { Text = "Milk", Points = 35 });
            q.Answers.Add(new Answer { Text = "Water", Points = 5 });
            q.Answers.Add(new Answer { Text = "Soda", Points = 4 });
            q.Answers.Add(new Answer { Text = "Breath", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name an occasion for which you might wear your lucky underwear." };
            q.Id = "CL-022";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Hot Date", Points = 34 });
            q.Answers.Add(new Answer { Text = "Job Interview", Points = 19 });
            q.Answers.Add(new Answer { Text = "Casino/Gambling", Points = 13 });
            q.Answers.Add(new Answer { Text = "Sporting Event", Points = 10 });
            q.Answers.Add(new Answer { Text = "Wedding/Night", Points = 8 });
            q.Answers.Add(new Answer { Text = "Anniversary", Points = 6 });
            q.Answers.Add(new Answer { Text = "Valentine’s Day", Points = 5 });
            q.Answers.Add(new Answer { Text = "Exam/Finals", Points = 5 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Fill in the blank: You're in deep ____." };
            q.Id = "CL-023";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Doo-doo", Points = 53 });
            q.Answers.Add(new Answer { Text = "Trouble", Points = 22 });
            q.Answers.Add(new Answer { Text = "Water", Points = 21 });
            q.Answers.Add(new Answer { Text = "Sleep", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a place that's filled with people who don't want to be there." };
            q.Id = "CL-024";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Jail/prison", Points = 50 });
            q.Answers.Add(new Answer { Text = "Hell", Points = 14 });
            q.Answers.Add(new Answer { Text = "Work/meetings", Points = 14 });
            q.Answers.Add(new Answer { Text = "Cemetery", Points = 11 });
            q.Answers.Add(new Answer { Text = "Church", Points = 11 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name an animal that's easy to imitate in charades." };
            q.Id = "CL-025";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Monkey/ape", Points = 34 });
            q.Answers.Add(new Answer { Text = "Dog", Points = 22 });
            q.Answers.Add(new Answer { Text = "Cat", Points = 17 });
            q.Answers.Add(new Answer { Text = "Bird", Points = 15 });
            q.Answers.Add(new Answer { Text = "Elephant", Points = 4 });
            q.Answers.Add(new Answer { Text = "Kangaroo", Points = 4 });
            q.Answers.Add(new Answer { Text = "Rabbit", Points = 4 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Tell me something of yours that you swear is possessed." };
            q.Id = "CL-026";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Children", Points = 21 });
            q.Answers.Add(new Answer { Text = "Car", Points = 18 });
            q.Answers.Add(new Answer { Text = "House", Points = 13 });
            q.Answers.Add(new Answer { Text = "Pet", Points = 13 });
            q.Answers.Add(new Answer { Text = "Computer", Points = 12 });
            q.Answers.Add(new Answer { Text = "Myself", Points = 11 });
            q.Answers.Add(new Answer { Text = "Cellphone", Points = 7 });
            q.Answers.Add(new Answer { Text = "Spouse", Points = 5 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What would it be hard to do if you accidentally put on superglue instead of lipstick?" };
            q.Id = "CL-027";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Eat", Points = 33 });
            q.Answers.Add(new Answer { Text = "Talk", Points = 32 });
            q.Answers.Add(new Answer { Text = "Kiss", Points = 25 });
            q.Answers.Add(new Answer { Text = "Breathe", Points = 8 });
            q.Answers.Add(new Answer { Text = "Take it off", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you'd hate to have happen while you're taking a bath." };
            q.Id = "CL-028";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Phone rings", Points = 41 });
            q.Answers.Add(new Answer { Text = "No hot water", Points = 28 });
            q.Answers.Add(new Answer { Text = "Doorbell rings", Points = 9 });
            q.Answers.Add(new Answer { Text = "Get electrocuted", Points = 7 });
            q.Answers.Add(new Answer { Text = "Power outage", Points = 5 });
            q.Answers.Add(new Answer { Text = "Slip/fall", Points = 5 });
            q.Answers.Add(new Answer { Text = "Someone comes in", Points = 5 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "After finally moving the couch for the first time in ten years, name something you might find underneath it." };
            q.Id = "CL-029";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Money/Change", Points = 54 });
            q.Answers.Add(new Answer { Text = "Dust", Points = 26 });
            q.Answers.Add(new Answer { Text = "Food", Points = 7 });
            q.Answers.Add(new Answer { Text = "Toys", Points = 5 });
            q.Answers.Add(new Answer { Text = "Remote", Points = 4 });
            q.Answers.Add(new Answer { Text = "Clothes/Shoes", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people change on a regular basis." };
            q.Id = "CL-030";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Clothes", Points = 87 });
            q.Answers.Add(new Answer { Text = "TV Channel", Points = 6 });
            q.Answers.Add(new Answer { Text = "Their Minds", Points = 4 });
            q.Answers.Add(new Answer { Text = "Hair", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you do to your nose." };
            q.Id = "CL-031";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Blow", Points = 56 });
            q.Answers.Add(new Answer { Text = "Pick", Points = 28 });
            q.Answers.Add(new Answer { Text = "Scratch/Rub", Points = 9 });
            q.Answers.Add(new Answer { Text = "Wipe", Points = 5 });
            q.Answers.Add(new Answer { Text = "Pierce", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that breaks out." };
            q.Id = "CL-032";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Face/Skin Blemish", Points = 84 });
            q.Answers.Add(new Answer { Text = "Convict", Points = 11 });
            q.Answers.Add(new Answer { Text = "Pet/Animal", Points = 3 });
            q.Answers.Add(new Answer { Text = "Flu/Epidemic", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Like it or not, name a place people have to go." };
            q.Id = "CL-033";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Bathroom", Points = 55 });
            q.Answers.Add(new Answer { Text = "Work", Points = 22 });
            q.Answers.Add(new Answer { Text = "Hospital/Dentist", Points = 10 });
            q.Answers.Add(new Answer { Text = "Grocery Store", Points = 5 });
            q.Answers.Add(new Answer { Text = "Court/Jury Duty", Points = 4 });
            q.Answers.Add(new Answer { Text = "DMV", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a place people go in the pursuit of happiness." };
            q.Id = "CL-034";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Vacation", Points = 62 });
            q.Answers.Add(new Answer { Text = "Church", Points = 23 });
            q.Answers.Add(new Answer { Text = "Bar/Night Club", Points = 8 });
            q.Answers.Add(new Answer { Text = "Spa", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name the worst place to accidentally fall asleep." };
            q.Id = "CL-035";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Car/Behind Wheel", Points = 61 });
            q.Answers.Add(new Answer { Text = "Work/Meeting", Points = 17 });
            q.Answers.Add(new Answer { Text = "Bus/Train", Points = 11 });
            q.Answers.Add(new Answer { Text = "Church", Points = 11 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that makes people sneeze." };
            q.Id = "CL-036";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Pepper", Points = 57 });
            q.Answers.Add(new Answer { Text = "Pollen", Points = 32 });
            q.Answers.Add(new Answer { Text = "Dust", Points = 6 });
            q.Answers.Add(new Answer { Text = "Ragweed", Points = 3 });
            q.Answers.Add(new Answer { Text = "Colds", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people kick." };
            q.Id = "CL-037";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Balls", Points = 69 });
            q.Answers.Add(new Answer { Text = "Tires", Points = 10 });
            q.Answers.Add(new Answer { Text = "Dogs", Points = 8 });
            q.Answers.Add(new Answer { Text = "Cans", Points = 7 });
            q.Answers.Add(new Answer { Text = "Buckets", Points = 6 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a reason someone might pretend to be asleep." };
            q.Id = "CL-038";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "To avoid doing the dishes", Points = 30 });
            q.Answers.Add(new Answer { Text = "Dodging a phone call", Points = 25 });
            q.Answers.Add(new Answer { Text = "Escaping a conversation", Points = 20 });
            q.Answers.Add(new Answer { Text = "Evading household chores", Points = 15 });
            q.Answers.Add(new Answer { Text = "Faking it during a boring meeting", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a place you would never want to hear someone say, \"Oops!\"" };
            q.Id = "CL-039";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Operating room", Points = 37 });
            q.Answers.Add(new Answer { Text = "On an airplane", Points = 26 });
            q.Answers.Add(new Answer { Text = "Nuclear power plant", Points = 21 });
            q.Answers.Add(new Answer { Text = "In a library", Points = 11 });
            q.Answers.Add(new Answer { Text = "During a job interview", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "If your refrigerator could talk, what complaint would it have about you?" };
            q.Id = "CL-040";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Too much expired food", Points = 30 });
            q.Answers.Add(new Answer { Text = "Opening it too often", Points = 25 });
            q.Answers.Add(new Answer { Text = "Not cleaning spills promptly", Points = 20 });
            q.Answers.Add(new Answer { Text = "Ignoring the vegetables", Points = 15 });
            q.Answers.Add(new Answer { Text = "Stocking it with weird leftovers", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you wouldn't want to find in your cereal box." };
            q.Id = "CL-041";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "A live insect", Points = 30 });
            q.Answers.Add(new Answer { Text = "A pair of socks", Points = 25 });
            q.Answers.Add(new Answer { Text = "A love letter from the milk carton", Points = 20 });
            q.Answers.Add(new Answer { Text = "A GPS tracker", Points = 15 });
            q.Answers.Add(new Answer { Text = "Another smaller cereal box", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people do in elevators when they think no one is watching." };
            q.Id = "CL-042";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Dance like nobody''s watching", Points = 46 });
            q.Answers.Add(new Answer { Text = "Check themselves out in the mirror", Points = 27 });
            q.Answers.Add(new Answer { Text = "Practice their acceptance speech", Points = 20 });
            q.Answers.Add(new Answer { Text = "Have a silent staring contest with the elevator buttons", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name the lumpiest part of your body." };
            q.Id = "CL-043";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Belly", Points = 51 });
            q.Answers.Add(new Answer { Text = "Rump", Points = 18 });
            q.Answers.Add(new Answer { Text = "Thigh", Points = 11 });
            q.Answers.Add(new Answer { Text = "Chest", Points = 7 });
            q.Answers.Add(new Answer { Text = "Arms", Points = 7 });
            q.Answers.Add(new Answer { Text = "Hips", Points = 6 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people do in the bathroom that they wouldn't admit to." };
            q.Id = "CL-044";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Singing loudly", Points = 30 });
            q.Answers.Add(new Answer { Text = "Talking to themselves", Points = 25 });
            q.Answers.Add(new Answer { Text = "Checking social media", Points = 20 });
            q.Answers.Add(new Answer { Text = "Trying out dance moves", Points = 15 });
            q.Answers.Add(new Answer { Text = "Reading shampoo bottle labels", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Besides the weasel, name something that goes \"pop\"." };
            q.Id = "CL-045";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Popcorns", Points = 40 });
            q.Answers.Add(new Answer { Text = "Ricekrispies", Points = 28 });
            q.Answers.Add(new Answer { Text = "Balloons", Points = 17 });
            q.Answers.Add(new Answer { Text = "Pringles", Points = 8 });
            q.Answers.Add(new Answer { Text = "Bubbles", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you might accidentally shrink in the wash." };
            q.Id = "CL-046";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Favorite sweater", Points = 30 });
            q.Answers.Add(new Answer { Text = "Lucky socks", Points = 25 });
            q.Answers.Add(new Answer { Text = "Towels", Points = 20 });
            q.Answers.Add(new Answer { Text = "Jeans", Points = 15 });
            q.Answers.Add(new Answer { Text = "Your hopes and dreams", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you'd find in a superhero's laundry basket." };
            q.Id = "CL-047";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Cape with dry cleaning tag", Points = 30 });
            q.Answers.Add(new Answer { Text = "Spandex costume", Points = 25 });
            q.Answers.Add(new Answer { Text = "Utility belt", Points = 20 });
            q.Answers.Add(new Answer { Text = "Mask with eye holes cut out", Points = 15 });
            q.Answers.Add(new Answer { Text = "Invisible socks", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something a person might get caught in." };
            q.Id = "CL-048";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Rain", Points = 34 });
            q.Answers.Add(new Answer { Text = "Lie", Points = 31 });
            q.Answers.Add(new Answer { Text = "Trap", Points = 14 });
            q.Answers.Add(new Answer { Text = "Traffic", Points = 14 });
            q.Answers.Add(new Answer { Text = "Net", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What can you have layers of?" };
            q.Id = "CL-049";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Clothing", Points = 38 });
            q.Answers.Add(new Answer { Text = "Skin", Points = 21 });
            q.Answers.Add(new Answer { Text = "Cake", Points = 18 });
            q.Answers.Add(new Answer { Text = "Fat", Points = 15 });
            q.Answers.Add(new Answer { Text = "Hair", Points = 5 });
            q.Answers.Add(new Answer { Text = "Blanket", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "There is a dead body in the house. What do you do with it?" };
            q.Id = "CL-050";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Bury it", Points = 31 });
            q.Answers.Add(new Answer { Text = "Hide it in the fridge", Points = 20 });
            q.Answers.Add(new Answer { Text = "Call cops anyway", Points = 12 });
            q.Answers.Add(new Answer { Text = "Leave it/don’t touch", Points = 11 });
            q.Answers.Add(new Answer { Text = "Burn it", Points = 8 });
            q.Answers.Add(new Answer { Text = "Take to neighbor’s", Points = 8 });
            q.Answers.Add(new Answer { Text = "Toss in lake", Points = 5 });
            q.Answers.Add(new Answer { Text = "Trash/dumpster", Points = 5 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a reason that men give for going bald." };
            q.Id = "CL-051";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Stress", Points = 35 });
            q.Answers.Add(new Answer { Text = "Virility", Points = 20 });
            q.Answers.Add(new Answer { Text = "Hereditary", Points = 16 });
            q.Answers.Add(new Answer { Text = "Old Age", Points = 13 });
            q.Answers.Add(new Answer { Text = "Intelligence", Points = 9 });
            q.Answers.Add(new Answer { Text = "Wife", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name an occupation in which you'd worry about leaks." };
            q.Id = "CL-052";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Plumber", Points = 75 });
            q.Answers.Add(new Answer { Text = "Politicians/Government", Points = 18 });
            q.Answers.Add(new Answer { Text = "Boat captain", Points = 4 });
            q.Answers.Add(new Answer { Text = "Gas worker", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you'd wish grew on trees." };
            q.Id = "CL-053";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Money", Points = 37 });
            q.Answers.Add(new Answer { Text = "Pizza", Points = 26 });
            q.Answers.Add(new Answer { Text = "Chocolate", Points = 21 });
            q.Answers.Add(new Answer { Text = "Clean laundry", Points = 11 });
            q.Answers.Add(new Answer { Text = "Wi-Fi signals", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you'd find in a pirate's junk drawer." };
            q.Id = "CL-054";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Eyepatch collection", Points = 30 });
            q.Answers.Add(new Answer { Text = "Map to buried treasure", Points = 25 });
            q.Answers.Add(new Answer { Text = "Parrot feathers", Points = 20 });
            q.Answers.Add(new Answer { Text = "Hook maintenance kit", Points = 15 });
            q.Answers.Add(new Answer { Text = "Peg leg accessories", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something a really lazy person might get their dog to fetch for them." };
            q.Id = "CL-055";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Paper", Points = 50 });
            q.Answers.Add(new Answer { Text = "Slippers", Points = 27 });
            q.Answers.Add(new Answer { Text = "Remote", Points = 11 });
            q.Answers.Add(new Answer { Text = "Beer", Points = 7 });
            q.Answers.Add(new Answer { Text = "Shoes", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a place in the newspaper you wouldn't want to see your name." };
            q.Id = "CL-056";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Obituary", Points = 78 });
            q.Answers.Add(new Answer { Text = "Wanted list", Points = 10 });
            q.Answers.Add(new Answer { Text = "Front page", Points = 9 });
            q.Answers.Add(new Answer { Text = "Personals", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a popular wedding gift." };
            q.Id = "CL-057";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Toaster", Points = 29 });
            q.Answers.Add(new Answer { Text = "Money", Points = 27 });
            q.Answers.Add(new Answer { Text = "Chinaware", Points = 21 });
            q.Answers.Add(new Answer { Text = "Silverware", Points = 10 });
            q.Answers.Add(new Answer { Text = "Crystal", Points = 7 });
            q.Answers.Add(new Answer { Text = "Blender", Points = 4 });
            q.Answers.Add(new Answer { Text = "Candle", Points = 2 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that people get removed from their body." };
            q.Id = "CL-058";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Mole", Points = 38 });
            q.Answers.Add(new Answer { Text = "Tattoos", Points = 21 });
            q.Answers.Add(new Answer { Text = "Teeth", Points = 9 });
            q.Answers.Add(new Answer { Text = "Tonsils", Points = 9 });
            q.Answers.Add(new Answer { Text = "Warts", Points = 8 });
            q.Answers.Add(new Answer { Text = "Hair", Points = 6 });
            q.Answers.Add(new Answer { Text = "Appendix", Points = 5 });
            q.Answers.Add(new Answer { Text = "Gall Bladder", Points = 4 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that can be engaged." };
            q.Id = "CL-059";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "People", Points = 40 });
            q.Answers.Add(new Answer { Text = "Phone", Points = 35 });
            q.Answers.Add(new Answer { Text = "Toilet", Points = 19 });
            q.Answers.Add(new Answer { Text = "Gear", Points = 6 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you'd never sell even if you were flat broke." };
            q.Id = "CL-060";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Ring/Jewellery", Points = 35 });
            q.Answers.Add(new Answer { Text = "My body", Points = 18 });
            q.Answers.Add(new Answer { Text = "Drugs", Points = 17 });
            q.Answers.Add(new Answer { Text = "My house", Points = 10 });
            q.Answers.Add(new Answer { Text = "My car", Points = 8 });
            q.Answers.Add(new Answer { Text = "My immortal soul", Points = 6 });
            q.Answers.Add(new Answer { Text = "My children", Points = 6 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something a woman needs to have before she gets married." };
            q.Id = "CL-061";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "A ring", Points = 38 });
            q.Answers.Add(new Answer { Text = "A guy", Points = 26 });
            q.Answers.Add(new Answer { Text = "A dress", Points = 11 });
            q.Answers.Add(new Answer { Text = "A job", Points = 9 });
            q.Answers.Add(new Answer { Text = "Money/Bank Account", Points = 6 });
            q.Answers.Add(new Answer { Text = "A blood test", Points = 5 });
            q.Answers.Add(new Answer { Text = "A hope chest", Points = 5 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that has the word \"super\" in it." };
            q.Id = "CL-062";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Superman", Points = 54 });
            q.Answers.Add(new Answer { Text = "Super bowl", Points = 10 });
            q.Answers.Add(new Answer { Text = "Supermarket", Points = 10 });
            q.Answers.Add(new Answer { Text = "Super glue", Points = 7 });
            q.Answers.Add(new Answer { Text = "Superintendent", Points = 7 });
            q.Answers.Add(new Answer { Text = "Supersize", Points = 6 });
            q.Answers.Add(new Answer { Text = "Superstar", Points = 6 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "If your cell phone rings while you're at church, who had better be calling?" };
            q.Id = "CL-063";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "The Lord", Points = 65 });
            q.Answers.Add(new Answer { Text = "My kids", Points = 11 });
            q.Answers.Add(new Answer { Text = "My mother", Points = 11 });
            q.Answers.Add(new Answer { Text = "My sibling", Points = 4 });
            q.Answers.Add(new Answer { Text = "My spouse", Points = 3 });
            q.Answers.Add(new Answer { Text = "My boss", Points = 3 });
            q.Answers.Add(new Answer { Text = "The doctor", Points = 3 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you go outside in your bathrobe to do." };
            q.Id = "CL-064";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Get newspaper", Points = 63 });
            q.Answers.Add(new Answer { Text = "Take out trash", Points = 14 });
            q.Answers.Add(new Answer { Text = "Get the mail", Points = 8 });
            q.Answers.Add(new Answer { Text = "Water the lawn", Points = 6 });
            q.Answers.Add(new Answer { Text = "Walk/Tend to dog", Points = 3 });
            q.Answers.Add(new Answer { Text = "Talk to neighbor", Points = 3 });
            q.Answers.Add(new Answer { Text = "Get kids lunch", Points = 3 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you'd hate to discover had expired." };
            q.Id = "CL-065";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Driver’s license", Points = 44 });
            q.Answers.Add(new Answer { Text = "Milk", Points = 22 });
            q.Answers.Add(new Answer { Text = "Credit card", Points = 15 });
            q.Answers.Add(new Answer { Text = "Insurance", Points = 9 });
            q.Answers.Add(new Answer { Text = "Car registration", Points = 6 });
            q.Answers.Add(new Answer { Text = "My own life", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What would be the worst thing to be allergic to?" };
            q.Id = "CL-066";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Food", Points = 43 });
            q.Answers.Add(new Answer { Text = "People", Points = 23 });
            q.Answers.Add(new Answer { Text = "Water", Points = 16 });
            q.Answers.Add(new Answer { Text = "Animals", Points = 9 });
            q.Answers.Add(new Answer { Text = "Money", Points = 9 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people have less of as they get older." };
            q.Id = "CL-067";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Hair", Points = 51 });
            q.Answers.Add(new Answer { Text = "Energy/Vitality", Points = 16 });
            q.Answers.Add(new Answer { Text = "Teeth", Points = 12 });
            q.Answers.Add(new Answer { Text = "Appetite", Points = 12 });
            q.Answers.Add(new Answer { Text = "Patience", Points = 9 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something the laziest person in the world might put next to their bed so they can roll over and use it." };
            q.Id = "CL-068";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Remote control/TV", Points = 41 });
            q.Answers.Add(new Answer { Text = "Toilet", Points = 35 });
            q.Answers.Add(new Answer { Text = "Refrigerator", Points = 11 });
            q.Answers.Add(new Answer { Text = "Telephone", Points = 9 });
            q.Answers.Add(new Answer { Text = "Microwave", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a food that's sloppy to eat." };
            q.Id = "CL-069";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Sloppy Joes", Points = 53 });
            q.Answers.Add(new Answer { Text = "Spaghetti", Points = 27 });
            q.Answers.Add(new Answer { Text = "Soup/Chili", Points = 7 });
            q.Answers.Add(new Answer { Text = "Ribs", Points = 7 });
            q.Answers.Add(new Answer { Text = "Pizza", Points = 6 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that's good about living alone." };
            q.Id = "CL-070";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Freedom", Points = 29 });
            q.Answers.Add(new Answer { Text = "Peace", Points = 27 });
            q.Answers.Add(new Answer { Text = "Privacy", Points = 19 });
            q.Answers.Add(new Answer { Text = "Less To Clean", Points = 14 });
            q.Answers.Add(new Answer { Text = "Control Of Food", Points = 7 });
            q.Answers.Add(new Answer { Text = "Control Of Remote", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What would you do if you saw a ghost?" };
            q.Id = "CL-071";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Scream", Points = 45 });
            q.Answers.Add(new Answer { Text = "Talk To It", Points = 26 });
            q.Answers.Add(new Answer { Text = "Run", Points = 19 });
            q.Answers.Add(new Answer { Text = "Pray", Points = 4 });
            q.Answers.Add(new Answer { Text = "Faint", Points = 3 });
            q.Answers.Add(new Answer { Text = "Pinch Myself", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Fill in the blank: It's hard to find a good ______." };
            q.Id = "CL-072";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Man", Points = 61 });
            q.Answers.Add(new Answer { Text = "Woman", Points = 14 });
            q.Answers.Add(new Answer { Text = "Job", Points = 11 });
            q.Answers.Add(new Answer { Text = "Haircut", Points = 7 });
            q.Answers.Add(new Answer { Text = "Maid", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What's the shabbiest thing you own." };
            q.Id = "CL-073";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Clothes", Points = 71 });
            q.Answers.Add(new Answer { Text = "Car", Points = 13 });
            q.Answers.Add(new Answer { Text = "Furniture", Points = 8 });
            q.Answers.Add(new Answer { Text = "Family Member", Points = 3 });
            q.Answers.Add(new Answer { Text = "Room", Points = 3 });
            q.Answers.Add(new Answer { Text = "Curtains", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a complaint people have about hospitals." };
            q.Id = "CL-074";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Food", Points = 34 });
            q.Answers.Add(new Answer { Text = "Wait", Points = 19 });
            q.Answers.Add(new Answer { Text = "Cost", Points = 16 });
            q.Answers.Add(new Answer { Text = "Smell", Points = 14 });
            q.Answers.Add(new Answer { Text = "Service", Points = 12 });
            q.Answers.Add(new Answer { Text = "Nurses", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What's the weirdest thing you've found at the bottom of your bag?" };
            q.Id = "CL-075";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "A forgotten sandwich from last summer", Points = 37 });
            q.Answers.Add(new Answer { Text = "A sock that went missing three years ago", Points = 29 });
            q.Answers.Add(new Answer { Text = "A love letter to a fictional character", Points = 26 });
            q.Answers.Add(new Answer { Text = "A portal to an alternate dimension", Points = 8 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that's really, really hairy." };
            q.Id = "CL-076";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Ape", Points = 41 });
            q.Answers.Add(new Answer { Text = "Dog", Points = 28 });
            q.Answers.Add(new Answer { Text = "Human", Points = 16 });
            q.Answers.Add(new Answer { Text = "Cat", Points = 7 });
            q.Answers.Add(new Answer { Text = "Bear", Points = 5 });
            q.Answers.Add(new Answer { Text = "Skunk", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that can ruin dinner." };
            q.Id = "CL-077";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Burnt food", Points = 51 });
            q.Answers.Add(new Answer { Text = "Phone call", Points = 15 });
            q.Answers.Add(new Answer { Text = "Fight", Points = 12 });
            q.Answers.Add(new Answer { Text = "Snacking before", Points = 9 });
            q.Answers.Add(new Answer { Text = "Hair in food", Points = 8 });
            q.Answers.Add(new Answer { Text = "Guest is late", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something your husband tries to fix but often just makes it worse." };
            q.Id = "CL-078";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Plumbing", Points = 52 });
            q.Answers.Add(new Answer { Text = "Car", Points = 17 });
            q.Answers.Add(new Answer { Text = "TV", Points = 12 });
            q.Answers.Add(new Answer { Text = "Relationship", Points = 8 });
            q.Answers.Add(new Answer { Text = "Fight", Points = 6 });
            q.Answers.Add(new Answer { Text = "Dinner", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a noise that people can't prevent themselves from making." };
            q.Id = "CL-079";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Burp", Points = 33 });
            q.Answers.Add(new Answer { Text = "Sneeze", Points = 30 });
            q.Answers.Add(new Answer { Text = "Snore", Points = 11 });
            q.Answers.Add(new Answer { Text = "Passing Gas", Points = 11 });
            q.Answers.Add(new Answer { Text = "Hiccup", Points = 10 });
            q.Answers.Add(new Answer { Text = "Cough", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What's the most embarrassing thing to happen during a job interview?" };
            q.Id = "CL-080";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Accidentally calling the interviewer \"Mom\"", Points = 44 });
            q.Answers.Add(new Answer { Text = "Forgetting the company’s name/interviewer’s name", Points = 37 });
            q.Answers.Add(new Answer { Text = "Tripped and fell", Points = 15 });
            q.Answers.Add(new Answer { Text = "Wearing mismatched socks", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that \"ties you down\"." };
            q.Id = "CL-081";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Having baby", Points = 33 });
            q.Answers.Add(new Answer { Text = "Work", Points = 21 });
            q.Answers.Add(new Answer { Text = "Significant other", Points = 17 });
            q.Answers.Add(new Answer { Text = "Rope", Points = 16 });
            q.Answers.Add(new Answer { Text = "Bills", Points = 10 });
            q.Answers.Add(new Answer { Text = "Pet", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people try to get out of." };
            q.Id = "CL-082";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Jury duty", Points = 40 });
            q.Answers.Add(new Answer { Text = "Work", Points = 25 });
            q.Answers.Add(new Answer { Text = "Bills", Points = 10 });
            q.Answers.Add(new Answer { Text = "Bad relationships", Points = 10 });
            q.Answers.Add(new Answer { Text = "Traffic tickets", Points = 8 });
            q.Answers.Add(new Answer { Text = "Debt", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Tell me something that can be frustrating to use for the very first time." };
            q.Id = "CL-083";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Computer/Internet", Points = 34 });
            q.Answers.Add(new Answer { Text = "DVD Player/VCR", Points = 20 });
            q.Answers.Add(new Answer { Text = "Car", Points = 17 });
            q.Answers.Add(new Answer { Text = "Tools", Points = 11 });
            q.Answers.Add(new Answer { Text = "Video game", Points = 9 });
            q.Answers.Add(new Answer { Text = "Can opener", Points = 9 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name an activity that many people do while half asleep." };
            q.Id = "CL-084";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Watch TV", Points = 34 });
            q.Answers.Add(new Answer { Text = "Snore", Points = 27 });
            q.Answers.Add(new Answer { Text = "Talk", Points = 19 });
            q.Answers.Add(new Answer { Text = "Walk", Points = 11 });
            q.Answers.Add(new Answer { Text = "Read", Points = 9 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you might catch up on." };
            q.Id = "CL-085";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Reading", Points = 35 });
            q.Answers.Add(new Answer { Text = "Sleep", Points = 33 });
            q.Answers.Add(new Answer { Text = "Bills", Points = 10 });
            q.Answers.Add(new Answer { Text = "Housework/Chores", Points = 9 });
            q.Answers.Add(new Answer { Text = "Soap Opera/TV", Points = 7 });
            q.Answers.Add(new Answer { Text = "Work", Points = 6 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people fall out of." };
            q.Id = "CL-086";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Love", Points = 31 });
            q.Answers.Add(new Answer { Text = "Bed", Points = 27 });
            q.Answers.Add(new Answer { Text = "Chair/Seat", Points = 21 });
            q.Answers.Add(new Answer { Text = "Airplane", Points = 10 });
            q.Answers.Add(new Answer { Text = "Car", Points = 7 });
            q.Answers.Add(new Answer { Text = "Boat", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Something people always run out of when having a party." };
            q.Id = "CL-087";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Drinks/Alcohol", Points = 48 });
            q.Answers.Add(new Answer { Text = "Ice", Points = 33 });
            q.Answers.Add(new Answer { Text = "Food", Points = 9 });
            q.Answers.Add(new Answer { Text = "Cups/Glasses", Points = 4 });
            q.Answers.Add(new Answer { Text = "Toilet paper", Points = 3 });
            q.Answers.Add(new Answer { Text = "Napkins", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a place you'd hate to be when you receive a call from your cell phone." };
            q.Id = "CL-088";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Bathroom", Points = 30 });
            q.Answers.Add(new Answer { Text = "Church", Points = 27 });
            q.Answers.Add(new Answer { Text = "Car/Driving", Points = 23 });
            q.Answers.Add(new Answer { Text = "Movie/Theatre", Points = 12 });
            q.Answers.Add(new Answer { Text = "Work", Points = 8 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that people stretch." };
            q.Id = "CL-089";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Legs/Bodies", Points = 47 });
            q.Answers.Add(new Answer { Text = "Rubber band", Points = 23 });
            q.Answers.Add(new Answer { Text = "Budget/Money", Points = 12 });
            q.Answers.Add(new Answer { Text = "Clothes/Shoes", Points = 11 });
            q.Answers.Add(new Answer { Text = "The truth", Points = 7 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name an excuse people give for being late that's too ridiculous to be true." };
            q.Id = "CL-090";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Got stuck in a time warp", Points = 53 });
            q.Answers.Add(new Answer { Text = "Alien abduction", Points = 21 });
            q.Answers.Add(new Answer { Text = "Chased by a swarm of bees", Points = 16 });
            q.Answers.Add(new Answer { Text = "Accidentally joined a parade", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Tell me something that looks terrible when it's wet." };
            q.Id = "CL-091";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Dogs/Pets", Points = 45 });
            q.Answers.Add(new Answer { Text = "Hair", Points = 37 });
            q.Answers.Add(new Answer { Text = "Clothes/Shoes", Points = 12 });
            q.Answers.Add(new Answer { Text = "Bread", Points = 4 });
            q.Answers.Add(new Answer { Text = "Newspaper", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that shakes." };
            q.Id = "CL-092";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Jello", Points = 39 });
            q.Answers.Add(new Answer { Text = "Person/Dancer", Points = 29 });
            q.Answers.Add(new Answer { Text = "Earth/Earthquake", Points = 10 });
            q.Answers.Add(new Answer { Text = "Baby''s rattle", Points = 8 });
            q.Answers.Add(new Answer { Text = "Leaves/Tree", Points = 6 });
            q.Answers.Add(new Answer { Text = "Dog", Points = 4 });
            q.Answers.Add(new Answer { Text = "Old Car", Points = 4 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people take out." };
            q.Id = "CL-093";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Trash", Points = 42 });
            q.Answers.Add(new Answer { Text = "Food", Points = 32 });
            q.Answers.Add(new Answer { Text = "Money/Loan", Points = 9 });
            q.Answers.Add(new Answer { Text = "Dog/Pet", Points = 8 });
            q.Answers.Add(new Answer { Text = "Spouse/Mate", Points = 5 });
            q.Answers.Add(new Answer { Text = "Library books", Points = 2 });
            q.Answers.Add(new Answer { Text = "Life insurance", Points = 2 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name things you never want your kid to bring home." };
            q.Id = "CL-094";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Lice", Points = 30 });
            q.Answers.Add(new Answer { Text = "Cat/Dog", Points = 25 });
            q.Answers.Add(new Answer { Text = "Bad report card/failing grade", Points = 20 });
            q.Answers.Add(new Answer { Text = "Germs", Points = 14 });
            q.Answers.Add(new Answer { Text = "Cops", Points = 8 });
            q.Answers.Add(new Answer { Text = "Boyfriend/girlfriend", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you have that you wish worked better." };
            q.Id = "CL-095";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Car", Points = 34 });
            q.Answers.Add(new Answer { Text = "Computer", Points = 19 });
            q.Answers.Add(new Answer { Text = "TV/Remote", Points = 15 });
            q.Answers.Add(new Answer { Text = "My Body", Points = 14 });
            q.Answers.Add(new Answer { Text = "Washer", Points = 10 });
            q.Answers.Add(new Answer { Text = "Cell Phone/Phone", Points = 8 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Tell me something that often doesn't start when it's supposed to." };
            q.Id = "CL-096";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Car", Points = 62 });
            q.Answers.Add(new Answer { Text = "Movie", Points = 9 });
            q.Answers.Add(new Answer { Text = "Wedding", Points = 9 });
            q.Answers.Add(new Answer { Text = "Lawn mower", Points = 9 });
            q.Answers.Add(new Answer { Text = "Meeting", Points = 6 });
            q.Answers.Add(new Answer { Text = "Sporting event", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that ties you down." };
            q.Id = "CL-097";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Having babies/Kids", Points = 33 });
            q.Answers.Add(new Answer { Text = "Work/Job", Points = 21 });
            q.Answers.Add(new Answer { Text = "Significant other", Points = 17 });
            q.Answers.Add(new Answer { Text = "Rope/String", Points = 16 });
            q.Answers.Add(new Answer { Text = "Bills/Debt", Points = 10 });
            q.Answers.Add(new Answer { Text = "Pet", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something men hate losing." };
            q.Id = "CL-098";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Money/Wallet", Points = 32 });
            q.Answers.Add(new Answer { Text = "Hair", Points = 30 });
            q.Answers.Add(new Answer { Text = "Keys", Points = 16 });
            q.Answers.Add(new Answer { Text = "Women", Points = 11 });
            q.Answers.Add(new Answer { Text = "Jobs", Points = 6 });
            q.Answers.Add(new Answer { Text = "Arguments", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that people spread." };
            q.Id = "CL-099";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Germs/Diseases", Points = 33 });
            q.Answers.Add(new Answer { Text = "Butter", Points = 27 });
            q.Answers.Add(new Answer { Text = "Rumors/Gossip", Points = 19 });
            q.Answers.Add(new Answer { Text = "Peanut Butter", Points = 10 });
            q.Answers.Add(new Answer { Text = "Jelly", Points = 6 });
            q.Answers.Add(new Answer { Text = "Mayonnaise", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you'd skip if you were late for work." };
            q.Id = "CL-100";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Breakfast/Coffee", Points = 84 });
            q.Answers.Add(new Answer { Text = "Taking shower", Points = 6 });
            q.Answers.Add(new Answer { Text = "Answering phone", Points = 3 });
            q.Answers.Add(new Answer { Text = "Brushing teeth", Points = 3 });
            q.Answers.Add(new Answer { Text = "News/Newspaper", Points = 2 });
            q.Answers.Add(new Answer { Text = "Putting on makeup", Points = 2 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people let pile up." };
            q.Id = "CL-101";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Laundry/Ironing", Points = 61 });
            q.Answers.Add(new Answer { Text = "Dishes", Points = 15 });
            q.Answers.Add(new Answer { Text = "Mail/Correspond", Points = 12 });
            q.Answers.Add(new Answer { Text = "Bills", Points = 12 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that is hard to do with your eyes open." };
            q.Id = "CL-102";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Sleep", Points = 51 });
            q.Answers.Add(new Answer { Text = "Sneeze", Points = 31 });
            q.Answers.Add(new Answer { Text = "Kissing", Points = 14 });
            q.Answers.Add(new Answer { Text = "Swimming", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something parents say is too short." };
            q.Id = "CL-103";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Childhood", Points = 29 });
            q.Answers.Add(new Answer { Text = "Daughter’s skirt", Points = 28 });
            q.Answers.Add(new Answer { Text = "Summer", Points = 17 });
            q.Answers.Add(new Answer { Text = "Money", Points = 11 });
            q.Answers.Add(new Answer { Text = "Life", Points = 10 });
            q.Answers.Add(new Answer { Text = "Temper", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people lose on a roller coaster." };
            q.Id = "CL-104";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Money", Points = 32 });
            q.Answers.Add(new Answer { Text = "Their lunch", Points = 20 });
            q.Answers.Add(new Answer { Text = "Hat", Points = 13 });
            q.Answers.Add(new Answer { Text = "Sunglasses", Points = 11 });
            q.Answers.Add(new Answer { Text = "Keys", Points = 11 });
            q.Answers.Add(new Answer { Text = "Shoe", Points = 7 });
            q.Answers.Add(new Answer { Text = "Jewelry", Points = 6 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that comes in sevens." };
            q.Id = "CL-105";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Dwarfs", Points = 30 });
            q.Answers.Add(new Answer { Text = "Deadly sins", Points = 24 });
            q.Answers.Add(new Answer { Text = "World wonders", Points = 16 });
            q.Answers.Add(new Answer { Text = "Days per week", Points = 15 });
            q.Answers.Add(new Answer { Text = "Seas", Points = 10 });
            q.Answers.Add(new Answer { Text = "Continents", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something men probably lie about most." };
            q.Id = "CL-106";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Age", Points = 43 });
            q.Answers.Add(new Answer { Text = "Being Single", Points = 21 });
            q.Answers.Add(new Answer { Text = "Income", Points = 20 });
            q.Answers.Add(new Answer { Text = "Success With Women", Points = 6 });
            q.Answers.Add(new Answer { Text = "Job Title", Points = 5 });
            q.Answers.Add(new Answer { Text = "Weight", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people postpone doing for as long as possible." };
            q.Id = "CL-107";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Bills", Points = 42 });
            q.Answers.Add(new Answer { Text = "Cleaning", Points = 32 });
            q.Answers.Add(new Answer { Text = "Getting Married", Points = 10 });
            q.Answers.Add(new Answer { Text = "Going To Dentist", Points = 10 });
            q.Answers.Add(new Answer { Text = "Going To Doctor", Points = 6 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you get on from time to time." };
            q.Id = "CL-108";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Airplane", Points = 23 });
            q.Answers.Add(new Answer { Text = "Bus", Points = 21 });
            q.Answers.Add(new Answer { Text = "Bicycle", Points = 17 });
            q.Answers.Add(new Answer { Text = "Scale", Points = 10 });
            q.Answers.Add(new Answer { Text = "High Horse", Points = 8 });
            q.Answers.Add(new Answer { Text = "Subway", Points = 7 });
            q.Answers.Add(new Answer { Text = "Diet", Points = 7 });
            q.Answers.Add(new Answer { Text = "Computer", Points = 7 });
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you only want to do once." };
            q.Id = "CL-109";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Die", Points = 32 });
            q.Answers.Add(new Answer { Text = "Get married", Points = 23 });
            q.Answers.Add(new Answer { Text = "Skydive", Points = 20 });
            q.Answers.Add(new Answer { Text = "Go on trip", Points = 11 });
            q.Answers.Add(new Answer { Text = "Surgery", Points = 6 });
            q.Answers.Add(new Answer { Text = "Go to jail", Points = 4 });
            q.Answers.Add(new Answer { Text = "Bungee jump", Points = 4 });
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a reason it might hurt to smile." };
            q.Id = "CL-110";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Dental work", Points = 52 });
            q.Answers.Add(new Answer { Text = "Chapped lips", Points = 15 });
            q.Answers.Add(new Answer { Text = "Hurt", Points = 12 });
            q.Answers.Add(new Answer { Text = "Canker", Points = 10 });
            q.Answers.Add(new Answer { Text = "Feeling sad", Points = 6 });
            q.Answers.Add(new Answer { Text = "Sunburn", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a bizarre use for a rubber chicken." };
            q.Id = "CL-111";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Professional doorstop", Points = 31 });
            q.Answers.Add(new Answer { Text = "Stand-up comedy partner", Points = 23 });
            q.Answers.Add(new Answer { Text = "Substitute for a car horn", Points = 19 });
            q.Answers.Add(new Answer { Text = "Martial arts training dummy", Points = 15 });
            q.Answers.Add(new Answer { Text = "A conversation starter at job interviews", Points = 12 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "If you could have a remote control for life, what's the first button you''d add?" };
            q.Id = "CL-112";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Pause button for awkward moments", Points = 30 });
            q.Answers.Add(new Answer { Text = "Fast-forward through traffic button", Points = 23 });
            q.Answers.Add(new Answer { Text = "Instant pizza delivery button", Points = 20 });
            q.Answers.Add(new Answer { Text = "Rewind to relive great memories button", Points = 16 });
            q.Answers.Add(new Answer { Text = "Mute annoying people button", Points = 11 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a specific chore kids do in order to get an allowance." };
            q.Id = "CL-113";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Wash dishes", Points = 46 });
            q.Answers.Add(new Answer { Text = "Take out trash", Points = 27 });
            q.Answers.Add(new Answer { Text = "Clean room", Points = 16 });
            q.Answers.Add(new Answer { Text = "Mow lawn", Points = 11 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "If einstein failed a subject in school, what might it have been?" };
            q.Id = "CL-114";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "English/language", Points = 43 });
            q.Answers.Add(new Answer { Text = "Physical ed", Points = 35 });
            q.Answers.Add(new Answer { Text = "Art", Points = 13 });
            q.Answers.Add(new Answer { Text = "History", Points = 9 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that can be stuffed." };
            q.Id = "CL-115";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Turkey", Points = 48 });
            q.Answers.Add(new Answer { Text = "Animals", Points = 43 });
            q.Answers.Add(new Answer { Text = "Pillows", Points = 5 });
            q.Answers.Add(new Answer { Text = "Eggs", Points = 4 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people catch." };
            q.Id = "CL-116";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Illness", Points = 43 });
            q.Answers.Add(new Answer { Text = "Fish", Points = 38 });
            q.Answers.Add(new Answer { Text = "Balls", Points = 16 });
            q.Answers.Add(new Answer { Text = "Bouquet", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a synonym for marriage that doesn’t make it sound fun." };
            q.Id = "CL-117";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Ball and chain", Points = 60 });
            q.Answers.Add(new Answer { Text = "Tie the knot", Points = 24 });
            q.Answers.Add(new Answer { Text = "Hitched", Points = 13 });
            q.Answers.Add(new Answer { Text = "Tied down", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something a child says when they do something wrong" };
            q.Id = "CL-118";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "I’m Sorry", Points = 57 });
            q.Answers.Add(new Answer { Text = "Whoops", Points = 23 });
            q.Answers.Add(new Answer { Text = "Uh Oh", Points = 12 });
            q.Answers.Add(new Answer { Text = "I Didn’t Do It", Points = 8 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something a kid might bury in the backyard." };
            q.Id = "CL-119";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Toy", Points = 62 });
            q.Answers.Add(new Answer { Text = "Pet", Points = 18 });
            q.Answers.Add(new Answer { Text = "Money", Points = 17 });
            q.Answers.Add(new Answer { Text = "Time capsule", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Complete this sentence. The key to a successful marriage is ____ing together." };
            q.Id = "CL-120";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Sleep", Points = 61 });
            q.Answers.Add(new Answer { Text = "Work", Points = 16 });
            q.Answers.Add(new Answer { Text = "Talk", Points = 14 });
            q.Answers.Add(new Answer { Text = "Laugh", Points = 9 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "What Might You Do For A Gift If You’re Short On Cash?" };
            q.Id = "CL-121";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Homemade gift", Points = 50 });
            q.Answers.Add(new Answer { Text = "Give a card", Points = 38 });
            q.Answers.Add(new Answer { Text = "Charge it", Points = 7 });
            q.Answers.Add(new Answer { Text = "Re gift", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something people let soak overnight" };
            q.Id = "CL-122";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Clothes", Points = 49 });
            q.Answers.Add(new Answer { Text = "Food", Points = 24 });
            q.Answers.Add(new Answer { Text = "Dishes", Points = 17 });
            q.Answers.Add(new Answer { Text = "Dentist", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "If an auctioneer had a baby, what might be her first words?" };
            q.Id = "CL-123";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Sold", Points = 49 });
            q.Answers.Add(new Answer { Text = "Going once … gone", Points = 33 });
            q.Answers.Add(new Answer { Text = "Bid", Points = 12 });
            q.Answers.Add(new Answer { Text = "Do I hear", Points = 6 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something that people try to squeeze themselves into." };
            q.Id = "CL-124";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Jeans", Points = 50 });
            q.Answers.Add(new Answer { Text = "Dress", Points = 21 });
            q.Answers.Add(new Answer { Text = "Car", Points = 17 });
            q.Answers.Add(new Answer { Text = "Elevator", Points = 5 });
            q.Answers.Add(new Answer { Text = "Bus/Public transit", Points = 4 });
            q.Answers.Add(new Answer { Text = "Swimsuit", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "How can you tell immediately that an email is spam?" };
            q.Id = "CL-125";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Unknown sender", Points = 38 });
            q.Answers.Add(new Answer { Text = "No subject", Points = 26 });
            q.Answers.Add(new Answer { Text = "Goes to junk", Points = 20 });
            q.Answers.Add(new Answer { Text = "Virus alert", Points = 16 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something humans wear, but cats look silly in" };
            q.Id = "CL-126";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Hats", Points = 46 });
            q.Answers.Add(new Answer { Text = "Shoes", Points = 32 });
            q.Answers.Add(new Answer { Text = "Glasses", Points = 12 });
            q.Answers.Add(new Answer { Text = "Sweater", Points = 10 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name something you might climb a tree to get" };
            q.Id = "CL-127";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Cat", Points = 44 });
            q.Answers.Add(new Answer { Text = "Fruit", Points = 24 });
            q.Answers.Add(new Answer { Text = "Ball", Points = 21 });
            q.Answers.Add(new Answer { Text = "Kite", Points = 11 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a crime that most cops have probably committed themselves." };
            q.Id = "CL-128";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Speeding", Points = 59 });
            q.Answers.Add(new Answer { Text = "Stealing", Points = 35 });
            q.Answers.Add(new Answer { Text = "Jaywalking", Points = 3 });
            q.Answers.Add(new Answer { Text = "Littering", Points = 3 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Name a kind of tree that would look silly to have as a Christmas tree." };
            q.Id = "CL-129";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Oak Tree", Points = 49 });
            q.Answers.Add(new Answer { Text = "Palm Tree", Points = 33 });
            q.Answers.Add(new Answer { Text = "Maple Tree", Points = 13 });
            q.Answers.Add(new Answer { Text = "Fruit Tree", Points = 5 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Which phrase from their wedding vows do people have the hardest time following?" };
            q.Id = "CL-130";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Honor And Obey", Points = 42 });
            q.Answers.Add(new Answer { Text = "Til Death Do Us Part", Points = 30 });
            q.Answers.Add(new Answer { Text = "For Richer Or Poorer", Points = 19 });
            q.Answers.Add(new Answer { Text = "Sickness And Health", Points = 9 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        {
            var q = new Question { Title = "Which places do politicians often say are “overcrowded”?" };
            q.Id = "CL-131";
            q.Answers.Clear();
            q.Answers.Add(new Answer { Text = "Prisons", Points = 48 });
            q.Answers.Add(new Answer { Text = "Classrooms", Points = 41 });
            q.Answers.Add(new Answer { Text = "Hospitals/ER", Points = 11 });
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            q.Answers.Add(new Answer());
            category.Questions.Add(q);
        }
        return category;
    }
}
