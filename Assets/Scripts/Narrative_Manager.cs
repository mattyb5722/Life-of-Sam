using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Narrative_Manager : MonoBehaviour {
    /// <summary>
    /// This Script is used to keep track and change the current narative node.
    /// To do this this script keeps track of the current narative node and the
    /// possible transitions from the current narative node. After a transition
    /// this script updates the title, time, description, and button UI Text objects.
    /// </summary>

    [Header("Text")]
    public Text title;              // Title UI Text
    public Text time;               // Time UI Text
    public Text description;        // Description UI Text
    [Header("Buttons Text")]
    public Text option1;            // Button 1
    public Text option2;            // Button 2
    public Text option3;            // Button 3
    public Text option4;            // Button 4
    private Node node;              // Current Narative Node

    // Use this for initialization
    void Start () {
        node = new Node(title, time, description, option1, option2, option3, option4);
                                    // Creates a Blank Narative Node
        node.Update(1);             // Sets node to Title Menu
    }

    public void Button1()           // Changes node if Button 1 is pressed
    {
        if (node.nodeNum == -1) { node.Update(0); }
        else if (node.nodeNum == 0){ node.Update(1); }
        else if (node.nodeNum == 1){ node.Update(2); }
        else if (node.nodeNum == 2){ node.Update(-1); }
        else if (node.nodeNum == 3){ node.Update(4); }
        else if (node.nodeNum == 4){ node.Update(-1); }
        else if (node.nodeNum == 5){ node.Update(-1); }
        else if (node.nodeNum == 6){ node.Update(-1); }
        else if (node.nodeNum == 7){ node.Update(-1); }
        else if (node.nodeNum == 8){ node.Update(-1); }
        else if (node.nodeNum == 9){ node.Update(-1); }
        else if (node.nodeNum == 10) { node.Update(11); }
        else if (node.nodeNum == 11) { node.Update(-1); }
        else if (node.nodeNum == 12) { node.Update(-1); }
        else if (node.nodeNum == 13) { node.Update(14); }
        else if (node.nodeNum == 14) { node.Update(15); }
        else if (node.nodeNum == 15) { node.Update(14); }
        else if (node.nodeNum == 16) { node.Update(14); }
        else if (node.nodeNum == 17) { node.Update(-1); }
        else if (node.nodeNum == 18) { node.Update(-1); }
        else if (node.nodeNum == 19) { node.Update(-1); }
        else if (node.nodeNum == 20) { node.Update(21); }
        else if (node.nodeNum == 21) { node.Update(0); }
        else if (node.nodeNum == 22) { node.Update(0); }
        else if (node.nodeNum == 23) { node.Update(-1); }
    }

    public void Button2()           // Changes node if Button 2 is pressed
    {
        if (node.nodeNum == 0) { }
        else if (node.nodeNum == 1) {}
        else if (node.nodeNum == 2) { node.Update(3); }
        else if (node.nodeNum == 3) { node.Update(5); }
        else if (node.nodeNum == 4) { node.Update(6); }
        else if (node.nodeNum == 5) { node.Update(6); }
        else if (node.nodeNum == 6) { node.Update(7); }
        else if (node.nodeNum == 7) { node.Update(8); }
        else if (node.nodeNum == 8) { node.Update(9); }
        else if (node.nodeNum == 9) { node.Update(10); }
        else if (node.nodeNum == 10) { node.Update(12); }
        else if (node.nodeNum == 11) { node.Update(13); }
        else if (node.nodeNum == 12) { node.Update(13); }
        else if (node.nodeNum == 13) { node.Update(15); }
        else if (node.nodeNum == 14) { node.Update(16); }
        else if (node.nodeNum == 15) { node.Update(16); }
        else if (node.nodeNum == 16) { node.Update(15); }
        else if (node.nodeNum == 17) { node.Update(18); }
        else if (node.nodeNum == 18) { node.Update(13); }
        else if (node.nodeNum == 19) { node.Update(13); }
        else if (node.nodeNum == 20) { }
        else if (node.nodeNum == 21) { }
        else if (node.nodeNum == 23) { node.Update(8); }
    }

    public void Button3()           // Changes node if Button 3 is pressed
    {
        if (node.nodeNum == 0) { }
        else if (node.nodeNum == 1) { }
        else if (node.nodeNum == 2) { }
        else if (node.nodeNum == 3) { }
        else if (node.nodeNum == 4) { node.Update(7); }
        else if (node.nodeNum == 5) { node.Update(7); }
        else if (node.nodeNum == 6) { }
        else if (node.nodeNum == 7) { node.Update(23); }
        else if (node.nodeNum == 8) { node.Update(10); }
        else if (node.nodeNum == 9) { }
        else if (node.nodeNum == 10) { }
        else if (node.nodeNum == 11) { node.Update(18); }
        else if (node.nodeNum == 12) { node.Update(18); }
        else if (node.nodeNum == 13) { node.Update(16); }
        else if (node.nodeNum == 14) { node.Update(17); }
        else if (node.nodeNum == 15) { node.Update(17); }
        else if (node.nodeNum == 16) { node.Update(17); }
        else if (node.nodeNum == 17) { node.Update(19); }
        else if (node.nodeNum == 18) { node.Update(19); }
        else if (node.nodeNum == 19) { node.Update(18); }
        else if (node.nodeNum == 20) { }
        else if (node.nodeNum == 21) { }
    }

    public void Button4()           // Changes node if Button 4 is pressed
    {
        if (node.nodeNum == 0) {}
        else if (node.nodeNum == 1) {}
        else if (node.nodeNum == 2) {}
        else if (node.nodeNum == 3) {}
        else if (node.nodeNum == 4) {}
        else if (node.nodeNum == 5) {}
        else if (node.nodeNum == 6) {}
        else if (node.nodeNum == 7) {}
        else if (node.nodeNum == 8) { }
        else if (node.nodeNum == 9) { }
        else if (node.nodeNum == 10) { }
        else if (node.nodeNum == 11) { node.Update(19); }
        else if (node.nodeNum == 12) { node.Update(19); }
        else if (node.nodeNum == 13) { node.Update(17); }
        else if (node.nodeNum == 14) { }
        else if (node.nodeNum == 15) { }
        else if (node.nodeNum == 16) { }
        else if (node.nodeNum == 17) { node.Update(20); }
        else if (node.nodeNum == 18) { node.Update(20); }
        else if (node.nodeNum == 19) { node.Update(20); }
        else if (node.nodeNum == 20) { }
        else if (node.nodeNum == 21) { }
    }
}
public class Node
{
    public int nodeNum = 0;        // Current Narative node number
    private Text title;             // Title UI Text
    private Text time;              // Time UI Text
    private Text description;       // Description UI Text
    private Text option1;           // Button 1
    private Text option2;           // Button 2
    private Text option3;           // Button 3
    private Text option4;           // Button 4
    private int points = 0;         // Player's current points
    private int highScore = -100;  // Highest score from past playthrough
    private int timeNum = 0;       // Time to event
    private string timeTo = "Start"; // Event that is coming up
    private List<int> achievements = new List<int>() { 0, 0, 0, 0};
                                    // Achievement flags

    public Node(Text title, Text time, Text description, Text option1, Text option2, Text option3, Text option4)
    {
        this.title = title;         // Initialize Title UI
        this.time = time;           // Initialize Time UI
        this.description = description; // Initialize description UI
        this.option1 = option1;     // Initialize Button 1
        this.option2 = option2;     // Initialize Button 2
        this.option3 = option3;     // Initialize Button 3
        this.option4 = option4;     // Initialize Button 4
    }
    public void Update(int aNode_num) { // Updates Narative node
        this.nodeNum = aNode_num;  // Sets new Narrative node number
        if (timeNum < -60 && timeTo == "Frisbee Practice")
        {                           // Forgot to go to practice
            nodeNum = 22;
        }
        if (nodeNum == 1)
        {
            timeNum = 0;
            timeTo = "Start";
            title.text = "A Normal day in the life of Sam";
            description.text = "This game is based around my roommate Sam. The only thing you need to know about him " +
"is that he really likes to sleep. Like a lot. Also while playing this game you will realize that " +
"I like to heckle Sam. This is completely sarcastic and is done in the most loving way possible. \nThis is a choose your own " +
"adventure game. That means that at all narative node you will have 1-4 options to continue the story. It will be up to the " +
"player to decide the story they want to pursue.";
            option1.text = "Wake Up";
            option2.text = "";
            option3.text = "";
            option4.text = "";
        }
        else if (nodeNum == 2)
        {
            timeNum = 30;
            timeTo = "Organic Chemistry Lecture";
            title.text = "Waking up";
            description.text = "BEEB, BEEB, BEEB. You slowly open your eyes. Right next to you you hear your alarm going off. " +
"It’s a monday morning and you are exhausted. You ended up staying up too late last night watching random netflix shows. But " +
"that’s besides the point. Back to the alarm. For some reason you’ve decided to turn the your volume to the loudest possible. " +
"On top of that you have decided to set your alarm for a half an hour before your first class. Knowing that you can get ready and " +
"get to class in 15 minutes what do you do?";
            option1.text = "Fall back asleep";
            option2.text = "Get out of bed";
            option3.text = "";
            option4.text = "";
        }
        else if (nodeNum == 3)
        {
            title.text = "Getting out of bed";
            description.text = "You roll over and turn off your alarm. Sitting up in bed you notice that your roommate Matt is " +
"still in his bed. Knowing that Matt won’t have to wake up for another 2 hours how loud are you going to be?";
            option1.text = "Very Loud";
            option2.text = "Quiet";
            option3.text = "";
            option4.text = "";
        }
        else if (nodeNum == 4)
        {
            points -= 10;
            timeNum -= 15;
            title.text = "Getting out of Bed Loudly";
            description.text = "Not caring about Matt you get out of bed loudly. You walk into the bathroom. You turn on the bathroom lights " +
"and start brushing your teeth. You hear Matt say something about closing the door, but you don’t care. After getting ready you have " + timeNum + 
" minutes before class. What are you going to do with that time?";
            option1.text = "Go back to bed";
            option2.text = "Eat breakfast";
            option3.text = "Go to class";
            option4.text = "";
        }
        else if (nodeNum == 5)
        {
            points += 10;
            timeNum -= 15;
            title.text = "Getting out of Bed Quietly";
            description.text = "Because Matt has been a great roommate you quietly get out of bed. You tiptoe your way to the " +
"bathroom and quietly close the door behind you. After getting ready you have " + timeNum + " minutes before Organic Chemistry " +
"Lecture. What are you going to do with that time?";
            option1.text = "Go back to bed";
            option2.text = "Eat breakfast";
            option3.text = "Go to Organic Chemistry Lecture";
            option4.text = "";
        }
        else if (nodeNum == 6)
        {
            points += 5;
            timeNum -= 15;
            achievements[3] += 1;
            title.text = "Breakfast";
            description.text = "You put on your shoes and head out to the dining hall. Because you live in quad it is a short " +
"walk. Once there you realize that there is little food out. (Thanks Sodexo) You end up eating a bagel. After eating you have " 
+ timeNum + " minutes before Organic Chemistry Lecture. What are you going to do with that time?";
            option1.text = "Go back to bed";
            option2.text = "Go to Organic Chemistry Lecture";
            option3.text = "";
            option4.text = "";
        }
        else if (nodeNum == 7)
        {
            points += 5;
            timeNum -= 5;
            if (timeNum >= 0){achievements[1] += 1;}
            title.text = "Organic Chemistry Lecture";
            description.text = "It's a 5 minute walk to class. You end up getting there with " + timeNum + " minutes to spare. " +
"Because you’re smart you don’t really have to pay attention in class. Class lasts way too long, but in the end you get 100 on the " +
"quiz and you’re bored out of your mind. Class ends early and you have 15 minutes before your next class. What do you want to do?";
            timeNum = 15;
            timeTo = "Data Structures";
            option1.text = "Go to bed";
            option2.text = "Go to Data Structures";
            option3.text = "Talk to Teacher";
            option4.text = "";
        }
        else if (nodeNum == 23)
        {
            points += 5;
            timeNum -= 15;
            title.text = "Talk to Organic Chemistry Teacher";
            description.text = "You decided to go talk to your teacher about advanced Bio Chem. Your teacher is impressed, but annoyed. " +
"Having to wait in line took 15 minutes. You have " + timeNum + " minutes before your next class. What do you want to do?";
            option1.text = "Go to bed";
            option2.text = "Go to Data Structures";
            option3.text = "";
            option4.text = "";
        }
        else if (nodeNum == 8)
        {
            points += 5;
            timeNum -= 5;
            if (timeNum >= 0) {achievements[1] += 1;}
            title.text = "Data Structures";
            description.text = "Because your a bioinformatics major you get to take the 2 hardest classes back to back. " +
"Begrudgingly you go to Data Structures. You try hard to pay attention in class, but end up getting confused 15 minutes " +
"into the boring lecture. You think to yourself that you’ll never use this stuff. Class finally ends. You end up gonig to " +
"ask the teacher a question which just confuses you more. You have 30 minutes before your next class. What do you want to do?";
            option1.text = "Go to bed";
            option2.text = "Eat Lunch";
            option3.text = "Go to Organic Chemistry Recitation";
            option4.text = "";

            timeNum = 30;
            timeTo = "Organic Chemistry Recitation";
        }
        else if (nodeNum == 9)
        {
            points += 5;
            timeNum -= 30;
            achievements[3] += 1;
            title.text = "Lunch";
            description.text = "You make the walk back to the dining hall to find that it is completely full. This is made " +
"worse by your dietary restrictions. You end up eating 2 pieces of pizza and some fries. You know this is going to make you " +
"feel bad later, but maybe some sleep will help you out. Because of the lines in the dining hall you end up taking 30 minutes " +
"to eat. You're going to be late for your Orgo Recitation. What are you going to do?";
            option1.text = "Go to bed";
            option2.text = "Go to Organic Chemistry Recitation";
            option3.text = "";
            option4.text = "";
        }
        else if (nodeNum == 10)
        {
            points += 5;
            timeNum -= 5;
            if (timeNum >= 0) { achievements[1] += 1; }
            title.text = "Organic Chemistry Recitation";
            description.text = "You get to Orgo Recitation with " + timeNum + " minutes to spare. Because you're so smart you " +
"breeze through the class. You finish the work way before anyone else. Looking around you notice that the people around you are " +
"struggling. You can either leave or help them. What do you want to do?";
            option1.text = "Help them";
            option2.text = "Leave";
            option3.text = "";
            option4.text = "";

            timeNum = 0;
        }
        else if (nodeNum == 11)
        {
            points += 10;
            achievements[1] += 1;
            title.text = "Helping Classmates";
            description.text = "You decide to help out the people around you. Even though they’re super confused you work though " +
"it all with them. Eventually the class come to an end. You have frisbee practice in a couple hours. What are you going to do until then?";
            option1.text = "Go to Bed";
            option2.text = "Do Homework";
            option3.text = "Go Workout";
            option4.text = "Eat Dinner";

            timeNum = 150;
            timeTo = "Frisbee Practice";
        }
        else if (nodeNum == 12)
        {
            points -= 10;
            title.text = "Leave";
            description.text = "You decide to leave. You have frisbee practice in a couple hours. What are you going to do until then?";
            option1.text = "Go to Bed";
            option2.text = "Do Homework";
            option3.text = "Go Workout";
            option4.text = "Eat Dinner";

            timeNum = 180;
            timeTo = "Frisbee Practice";
        }
        else if (nodeNum == 13)
        {
            title.text = "Doing Homework";
            description.text = "You go to the library to make sure you get all your work done. What class would you like to work on?";
            option1.text = "Organic Chemistry";
            option2.text = "Data Structures";
            option3.text = "Economics";
            option4.text = "Stop Studying";
        }
        else if (nodeNum == 14)
        {
            timeNum -= 30;
            points += 5;
            achievements[0] += 1;
            title.text = "Working on Organic Chemistry";
            description.text = "After working on Organic Chemistry for 30 minutes you have " + timeNum + " minutes until practice. " +
"Do you want to keep studying? If so what do you want to work on?";
            option1.text = "Data Structures";
            option2.text = "Economics";
            option3.text = "No";
            option4.text = "";
        }
        else if (nodeNum == 15)
        {
            timeNum -= 45;
            points += 10;
            achievements[0] += 1;
            title.text = "Working on Data Structures";
            description.text = "After working on Data Structures for 45 minutes you are still super confused. " +
"You now have " + timeNum + " minutes until practice. Do you want to keep studying? If so what do you want to work on?";
            option1.text = "Organic Chemistry";
            option2.text = "Economics";
            option3.text = "No";
            option4.text = "";
        }
        else if (nodeNum == 16)
        {
            timeNum -= 15;
            points += 5;
            achievements[0] += 1;
            title.text = "Working on Economics";
            description.text = "After working on Economics for 15 minutes you are done with all your work. " +
"You now have " + timeNum + " minutes until practice. Do you want to keep studying? If so what do you want to work on?";
            option1.text = "Organic Chemistry";
            option2.text = "Data Structures";
            option3.text = "No";
            option4.text = "";
        }
        else if (nodeNum == 17)
        {
            title.text = "Done Studying";
            description.text = "You have " + timeNum + " minutes until practice. What would you like to do now?";
            option1.text = "Go to Bed";
            option2.text = "Go Workout";
            option3.text = "Eat Dinner";
            option4.text = "Go to Practice";
        }
        else if (nodeNum == 18)
        {
            points += 15;
            timeNum -= 90;
            achievements[2] += 1;
            title.text = "Go Workout";
            description.text = "After going to your room to change into your work out clothes you walk to the gym. " +
"Because you don't want to be out done by your friend Linus you push yourself to your limit. You end up lifting for " +
"over an hour. You then finish your workout off with a core work out. In total you spend an hour and a half " +
"working out. You have " + timeNum + " minutes until practice. What would you like to do now?";
            option1.text = "Go to Bed";
            option2.text = "Study";
            option3.text = "Eat Dinner";
            option4.text = "Go to Practice";
            
        }
        else if (nodeNum == 19)
        {
            achievements[3] += 1;
            title.text = "Eating Dinner";
            description.text = "You text your roommates and get Matt to come eat dinner with you. You head off to the " +
"dinning hall. Expecting to be disapointed by the food both of you are not surprised at all at the food available. " +
"You both decided to eat some salid and call that dinner. In total you spend 30 minutes eating. You have " + timeNum + 
" minutes until practice. What would you like to do now?";
            option1.text = "Go to Bed";
            option2.text = "Study";
            option3.text = "Go Workout";
            option4.text = "Go to Practice";
        }
        else if (nodeNum == 20)
        {
            title.text = "Practice";
            if (timeNum > 60)
            {
                points += 10;
                achievements[2] += 1;
                description.text = "Because you have so much extra time before practice you end up procrastinating " +
"until practice. About 45 minutes before practice Matt comes into the room and asks you if you want to throw before " +
"practice. You decide why not and join him.";
            }else if (timeNum > 0)
            {
                points += 10;
                achievements[2] += 1;
                description.text = "You head back to your room to get your frisbee gear. As your getting ready Matt " +
"comes into the room and asks you if you want to throw before practice. You decide why not and join him.";
            }
            else
            {
                description.text = "You rush back to your room and grab your frisbee gear. Running to the fields you " +
"get there after they've started. You quickly run a warm up and join practice.";
            }

            option1.text = "End of Practice";
            option2.text = "";
            option3.text = "";
            option4.text = "";

            timeNum = 0;
        }
        else if (nodeNum == 21)
        {
            timeTo = "End";
            timeNum = 0;
            title.text = "End of Practice";
            description.text = "Practice lasts 2 hours and you play alright. After practice is over you head back to " +
"your room with your roommates. You take a shower and lay on your bed. Not wanting to do any more work you end up watching " +
"some random netflix show. You do this until 1am and finally fall asleep.";
            option1.text = "End of day";
            option2.text = "";
            option3.text = "";
            option4.text = "";
        }
        else if (nodeNum == 22)
        {
            timeTo = "End";
            timeNum = 0;
            points -= 20;
            title.text = "Missed Practice";
            description.text = "Looking down at your phone you realize that you missed practice. You decide to go back to your room. " +
"Not wanting to do any more work you end up watching some random netflix show. You do this until 1am and finally fall asleep.";
            option1.text = "End of day";
            option2.text = "";
            option3.text = "";
            option4.text = "";
        }
        time.text = timeNum + " Minutes to " + timeTo;
        if (nodeNum == -1)
        {
            title.text = "Sleeping";
            time.text = "";
            description.text = "You wake up. You turn over to your phone. It's midnight. You've slept through the rest " +
"of the day. Roling over you fall back alseep.";
            option1.text = "End";
            option2.text = "";
            option3.text = "";
            option4.text = "";
        }
        else if (nodeNum == 0)
        {
            
            title.text = "End of the Game";
            description.text = "";
            if (achievements[0] == 3 && achievements[1] == 4)
            {
                description.text += "Great Student (+30)\n";
                points += 30;
            }
            if (achievements[1] == 4)
            {
                description.text += "Good Student: (+15)\n";
                points += 15;
            }
            if (achievements[2] == 2)
            {
                description.text += "Super Strong (+15)\n";
                points += 15;
            }
            if (achievements[3] == 3)
            {
                description.text += "Healthy Eater (+15)\n";
                points += 15;
            }
            if (achievements[3] == 0)
            {
                description.text += "Poor Eater: (-30)\n";
                points -= 30;
            }
            if (achievements[1] == 0)
            {
                description.text += "Terrible Student: (-15)\n";
                points -= 15;
            }
            
            description.text += "Total Points: " + points;
            highScore = Mathf.Max(highScore, points);
            time.text = "High Score: " + highScore;

            option1.text = "Title Screen";
            option2.text = "";
            option3.text = "";
            option4.text = "";
            points = 0;
            achievements = new List<int>() { 0, 0, 0, 0 };
        }

    }
}
