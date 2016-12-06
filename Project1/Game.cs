using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Game
    {
        
        public string NextScene = "";

       
        public bool TakeWand = false;
        public bool TakeKey = false;
        public bool CarKey = false;
        public bool FoundQui = false;
        public bool Arp = false;
        public bool Herm = false;
        public bool Map = false;
        public bool room1 = false;

        
        public void Play()
        {
            while (NextScene != "GameOver")
            {
                if (NextScene == "Bedroom")
                {
                    Bedroom();
                }
                else if (NextScene == "TrophiesRoom")
                {
                    TrophiesRoom();
                }
                else if (NextScene == "Kitchen")
                {
                    Kitchen();
                }
                else if (NextScene == "DoorsRoom")
                {
                    DoorsRoom();
                }
                else if (NextScene == "OutsideHouse")
                {
                    OutsideHouse();
                }
                else if (NextScene == "BackYard")
                {
                    BackYard();
                }
                else if (NextScene == "LivingRoom")
                {
                        LivingRoom();
                }
                else if (NextScene == "Cave")
                {
                    Cave();
                }
                else if (NextScene == "EmptyRoom")
                {
                    EmptyRoom();
                }
                else if (NextScene == "Bridge")
                {
                    Bridge();
                }
                else if (NextScene == "SmallHouse")
                {
                    SmallHouse();
                }
                else if (NextScene == "PotionsClass")
                {
                    PotionsClass();
                }
                else if (NextScene == "Library")
                {
                    Library();
                }
                 else if (NextScene == "TheEnd")
                {
                    TheEnd();
                }
                else
                {
                    Console.WriteLine("ERROR: ROOM NOT FOUND!!!");
                    NextScene = "GameOver";
                }
            }
        }

       
        private string getChoice(params string[] validChoices)
        {
            string choice;
            bool isValid = false;
            do
            {
                string choiceString = String.Join(" | ", validChoices);
                Console.WriteLine("What would you like to do? ({0})", choiceString);
                choice = Console.ReadLine();
                choice = choice.ToLower();
                foreach (string validChoice in validChoices)
                {
                    if (choice == validChoice.ToLower())
                    {
                        isValid = true;
                        break;
                    }
                }
            } while (!isValid);
            return choice;
        }

        
        
        private void Bedroom()
        {
            Console.WriteLine("BEDROOM:");
            Console.WriteLine("You are in the magic world of the wizards. You are Harry Potter.");
            Console.WriteLine("You are in your bedroom, you just woke up. There is a closet on the");
            Console.WriteLine("left side, and a trash can right next to it. There is also a window");
            Console.WriteLine("and a door."); 

            Console.WriteLine("You can check the closet(C), the trash(T), the bed(B), the window(W) or the door(D)");
            string choice = getChoice("c","t","b","w","d");

            if (choice == "c")
            {
                Console.WriteLine("Oh c'mon Harry, I don't think its time to care about your outfit!");
                
            }
            else if (choice == "t")
            {
                if (TakeWand == false)
                {
                    Console.WriteLine("Nice! You just found your wand!");
                    TakeWand = true;
                }
                else
                {
                    Console.WriteLine("The trash is empty.");
                }
            }
            
            else if (choice == "b")
            {
                Console.WriteLine("Seriously? Do you want to go back to sleep?");
                Console.WriteLine("Remember that you just woke up!");
                
            }
             else if (choice == "w")
            {
                if (TakeKey == false)
                {
                    Console.WriteLine("Your owl Hedwig is here! He has a message and a key for you!");
                    Console.WriteLine("MESSAGE: 'Find the way out. You are in danger. You might");
                    Console.WriteLine("find those you love on the way out, but you might also find those");
                    Console.WriteLine("who want you dead. Take this key, you are gonna need it. Be Safe. Dumbledor.'");
                    Console.WriteLine("You take the key.");
                    TakeKey = true;
                }
                else
                {
                    Console.WriteLine("Hedwig already gave you the message and the key!");
                }
                
            }
             else if (choice == "d")
            {
                  if (TakeKey == true)
                  {
                      Console.WriteLine("You unlock the door!");
                      NextScene = "TrophiesRoom";
                  }
                  else
                  {
                      Console.WriteLine("Sorry, the door is locked!");
                  }
            }
        }

         private void TrophiesRoom()
        {
            Console.WriteLine("TROPHIES ROOM:");
            Console.WriteLine("You are in a room with two trophies(gold and silver), one on each side, ");
            Console.WriteLine("and three doors, one in front of the other one. The first door takes you to");
            Console.WriteLine("the east. The second door takes you to the west. The third one takes you to the norht.");
            

            Console.WriteLine("You can go east(E), west(W), north(N), check the silver trophy(S), or the gold one(G)");
            string choice = getChoice("e","w","s","g", "n");

            if (choice == "e")
            {
                Console.WriteLine("You step into a room...");
                NextScene = "Kitchen";
                
            }
            else if (choice == "w")
            {
                Console.WriteLine("You step into a room...");
                NextScene = "DoorsRoom";
                
            }
            else if (choice == "g")
            {
                Console.WriteLine("The trophy trakes you to another place...");
                NextScene = "OutsideHouse";
                
            }
             else if (choice == "s")
            {
               Console.WriteLine("The trophy trakes you to another place...");
               NextScene = "Cave";
            }
            else if (choice == "n")
            {
                Console.WriteLine("You step into the first room...");
                NextScene = "Bedroom";
                
            }
        }
        private void Kitchen()
        {
            
           string choice; 
            if (CarKey == false)
            {
                Console.WriteLine("KITCHEN:");
                Console.WriteLine("You are in a kitchen, there is not a lot of furniture. Only the basic stuffs");
                Console.WriteLine("to cook. There is some food on the table, but it looks like it has been there");
                Console.WriteLine("for years. There is a key right next to the food, it looks like a car key.");
                Console.WriteLine("The only way to exit the room is by using the door that you just came in.");
                
                Console.WriteLine("You can take the key(K), eat the food(F), or leave the room(L).");
                choice = getChoice("k", "f", "l");
            }
            else
            {
                Console.WriteLine("KITCHEN:");
                Console.WriteLine("You are in a kitchen, there is not a lot of furniture. Only the basic stuffs");
                Console.WriteLine("to cook. There is some food on the table, but it looks like it has been there");
                Console.WriteLine("for years. The only way to exit the room is by using the door that you just came in.");
                               
                Console.WriteLine("You can eat the food(F), or leave the room(L).");
                choice = getChoice("f", "l");
            }
            

            if (choice == "k")
            {
                CarKey = true;                
            }
            else if (choice == "f")
            {
                Console.WriteLine("How can you think about food right now?????");
                Console.WriteLine("Let's go!! you need to get out of here as soon as possible!!");
               
            }
            else if (choice == "l")
            {
               NextScene = "TrophiesRoom";
            }
        }
         private void OutsideHouse()
        {
            Console.WriteLine("OUTSIDE WEASLEY'S HOUSE:");
            Console.WriteLine("You are outside of the Weasley's House. It is in the middle of nowhere.");
            Console.WriteLine("There is beautiful yard with flowers, and perfect cut green grass. Also,");
            Console.WriteLine("there is a blue car parked right on the other side of the house. There is also");
            Console.WriteLine("a door which looks like the entrance of the house.");
            

            Console.WriteLine("You can use the car(C), the door(D), or touch the trophy(T)");
            string choice = getChoice("c","d","t");

            if (choice == "c")
            {
                if (CarKey == true)
                {
                    Console.WriteLine("You use the car key, you run the car, and it takes you to...");
                    NextScene = "SmallHouse";
                }
                else
                {
                    Console.WriteLine("Sorry, the car is locked. Try something else.");
                }
                
                
            }
            else if (choice == "d")
            {
                Console.WriteLine("You step into a room...");
                NextScene = "LivingRoom";
                
            }
            else if (choice == "t")
            {
                Console.WriteLine("The trophy takes you to another place...");
                NextScene = "TrophiesRoom";
                
            }
            
        }

        private void LivingRoom()
        {
            Console.WriteLine("WEASLEY'S LIVING ROOM:");
            Console.WriteLine("You are inside of the Weasley's House. You are in their living room. No one");
            Console.WriteLine("is at home. You are in your friends house by yourselve. There is a couch with ");
            Console.WriteLine("a TV in front of it. Also, there is a table with chairs around it and two doors.");
            Console.WriteLine("One door takes you to the yard, and the other one takes you outside the house.");
            

            Console.WriteLine("You can check the table(T), sit on the couch(C), watch the TV(V), go to the yard(Y), or outside(O)");
            string choice = getChoice("t","c","v","y","o");

            if (choice == "t")
            {
                 Console.WriteLine("Sorry, there is nothing here!");
                 Console.WriteLine("Try something else.");
                                     
            }
            else if (choice == "c")
            {
                Console.WriteLine("REALLY?? You will have time to rest when you are completely safe!");
                Console.WriteLine("Try something else.");
                                
            }
            else if (choice == "v")
            {
                Console.WriteLine("NO WAY YOU WANT TO DO THAT RIGHT NOW!!!");
                Console.WriteLine("You need to get out of here, there is not time for that!!");
               
                
            }
            else if (choice == "y")
            {
                Console.WriteLine("The door takes you to the yard...");
                NextScene = "BackYard";
                
            }
            else if (choice == "o")
            {
                Console.WriteLine("The door takes you outside the house...");
                NextScene = "OutsideHouse";

            }
            
        }

        private void BackYard()
        {
            Console.WriteLine("WEASLEY'S BACKYARD:");
            Console.WriteLine("You are outside of the Weasley's House. You are in their back yard.");
            Console.WriteLine("This yard doesn't look as good as the front one. It seems like no one");
            Console.WriteLine("haven't taken care of it in a long time. There is something in the");
            Console.WriteLine("middle of the yard, but is hard to tell what it is.");

            string choice;
            if (FoundQui == false)
            {
                Console.WriteLine("You can get closer to that object(C), or go back inside the house(H)");
                choice = getChoice("c", "h");
            }
            else
            {
                Console.WriteLine("You can only go back inside the house(H)");
                choice = getChoice("h");
            }

            if (choice == "c")
            {
               
                    Console.WriteLine("You just found your quidditch broom!!");
                    Console.WriteLine("You must take it with you. You are probably gonna need it.");
                    FoundQui = true;
                     
                                     
            }
            else if (choice == "h")
            {
                Console.WriteLine("The door takes you back inside the house...");
                NextScene = "LivingRoom";
                                
            }
            
            
        }
        
        private void SmallHouse()
        {
            Console.WriteLine("SMALL HOUSE:");
            Console.WriteLine("You are right next to a small house where you can see Hogwarts from the far.");
            Console.WriteLine("There is someone with a dog right next to the house. He is a really tall and big man.");
            Console.WriteLine("The dog is staring at him because the man is playing an arp.");
            

            Console.WriteLine("You can go talk to that man(T), or go back to the car(C)");
            string choice = getChoice("t","c");

            if (choice == "t")
            {
                if (Arp == false)
                {
                Console.WriteLine("While you are getting close to this man, you recognize him.");
                Console.WriteLine("He is Hagrid!! You get really excited to see him. He sees you and");
                Console.WriteLine("he says: 'Hey Harry! I was waiting for you! You need to get out of here");
                Console.WriteLine("as soon as possible! Take this with you, it might be helpful.'");
                Console.WriteLine("Hagrid gives you the arp that he was playing.");
                Console.WriteLine("You try to talk to him, but he says:");
                Console.WriteLine("'Harry, there is no time for that! You need to go, Voldemort is looking for you!'");
                Arp = true;
                }
                else
                {
                    Console.WriteLine("Harry, get the hell out of here!!!");
                }
                 
                                     
            }
            else if (choice == "c")
            {
                Console.WriteLine("The car takes you to Weasley's House...");
                NextScene = "OutsideHouse";
                                
            }
            
            
        }

        private void Cave()
        {
            string choice;

            if (room1 == false)
            {
                Console.WriteLine("CAVE:");
                Console.WriteLine("You are inside of a cave. Suddenly, you hear a noise. You turn around and you see a dragon!!");
                Console.WriteLine("The only way out is by using the door, or the trophy that is right next to you.");
                Console.WriteLine("The dragon is getting closer... You need to do something!");

                if ((Arp == true) && (TakeWand == true) && (FoundQui == true))
                {
                    Console.WriteLine("You can go to the door(D), use your wand(W), use the arp(A), use your quidditch broom(Q), or touch the trophy(T)");
                    choice = getChoice("d", "w", "a", "q", "t");
                }
                else if ((Arp == true) && (TakeWand == true) && (FoundQui == false))
                {
                    Console.WriteLine("You can go to the door(D), use your wand(W), use the arp(A), or touch the trophy(T)");
                    choice = getChoice("d", "w", "a", "t");
                }
                else if ((Arp == true) && (FoundQui == true) && (TakeWand == false))
                {
                    Console.WriteLine("You can go to the door(D), use the arp(A), use your quidditch broom(Q), or touch the trophy(T)");
                    choice = getChoice("d", "a", "q", "t");
                }
                else if ((Arp == true) && (FoundQui == false) && (TakeWand == false))
                {
                    Console.WriteLine("You can go to the door(D), use the arp(A), or touch the trophy(T)");
                    choice = getChoice("d", "a", "t");
                }
                else if ((FoundQui == true) && (Arp == false) && (TakeWand == false))
                {
                    Console.WriteLine("You can go to the door(D), use you quidditch broom(Q), or touch the trophy(T)");
                    choice = getChoice("d", "q", "t");
                }
                else if ((TakeWand == true) && (FoundQui == false) && (Arp == false))
                {
                    Console.WriteLine("You can go to the door(D), use the wand(W), or touch the trophy(T)");
                    choice = getChoice("d", "w", "t");
                }
                else
                {
                    Console.WriteLine("You can go to the door(D), or touch the trophy(T)");
                    choice = getChoice("d", "t");
                }
            }

            else
            {
                Console.WriteLine("CAVE:");
                Console.WriteLine("You are inside of a cave. The arp is still working, so the dragon is sleeping. You are not in danger.");
                Console.WriteLine("The only way out is by using the door that takes you to the empty room, or touching the trophy.");
                
                Console.WriteLine("You can go to the empty room(R), or touch the trophy(T)");
                choice = getChoice("r", "t");
               

            }

            if (choice == "d")
            {
                Console.WriteLine("You run to the door but the dragon gets you...");
                Console.WriteLine("You are dead.");
                Console.WriteLine("Game over!!!!");
               NextScene = "GameOver";
                
              
                                     
            }
            else if (choice == "w")
            {
                Console.WriteLine("Magic doesn't work with this dragon...");
                Console.WriteLine("The dragon gets you...");
                Console.WriteLine("Game over!!!!");
                 NextScene = "GameOver";
                                
            }
            else if (choice == "a")
            {
                Console.WriteLine("You play the arp and it looks like the dragon is falling asleep... ");
                Console.WriteLine("It worked! he is sleeping now. It's time to go! You run to the door and you step into another room... ");
                NextScene = "EmptyRoom";
                                
            }
             else if (choice == "q")
            {
                Console.WriteLine("Remember you are in a cave. The dragon gets you because there is not enough space to fly and escape.");
                Console.WriteLine("Game over!!!!");
                NextScene = "GameOver";
                                
            }
             else if (choice == "t")
            {
                Console.WriteLine("The trophy takes you to another place...");
                NextScene = "TrophiesRoom";
                                
            }
            else if (choice == "r")
            {
                Console.WriteLine("The door takes you back to the empty room...");
                NextScene = "EmptyRoom";

            }
            
            
        }

         private void EmptyRoom()
        {
            Console.WriteLine("EMPTY ROOM:");
            Console.WriteLine("You are in a room with no furniture or any decoration at all. There is only four white walls and ");
            Console.WriteLine("three doors in the room.");
                        

            Console.WriteLine("You can go north(N), west(w), or east(E)");
            string choice = getChoice("n","w","e");

            if (choice == "n")
            {
                Console.WriteLine("The door takes you to another room...");
                NextScene = "Bridge";
                 
                                     
            }
            else if (choice == "w")
            {
                Console.WriteLine("The door takes you to another room...");
                NextScene = "Cave";
                room1 = true;
                                
            }
            else if (choice == "e")
            {
                if (TakeWand == true)
                {
                    Console.WriteLine("You use your wand to unlock the door.");
                    Console.WriteLine("The door takes you to another room...");
                    NextScene = "Library";
                }
                else
                {
                    Console.WriteLine("Sorry, the door is locked!");
                }
            }
            
            
        }

        private void Bridge()
        {
            Console.WriteLine("BRIDGE:");
            Console.WriteLine("You are right next to a river, in the middle of the woods. It looks like there is a door");
            Console.WriteLine("on the other side of the river. There is a bridge that takes you to the other side,");
            Console.WriteLine("but it doesn't look safe.");

            string choice;
            if ((FoundQui == true) && (TakeWand == true) && (Herm == false))
            {
                Console.WriteLine("You can use the bridge(B), use your quidditch broom(Q), or use the wand(W), or use the door that you just came in(D)");
                choice = getChoice("b", "q", "w", "d");
            }
            else if ((FoundQui == true) && (TakeWand == false) && (Herm == false))
            {
                Console.WriteLine("You can use the bridge(B), use your quidditch broom(Q), or use the door that you just came in(D)");
                choice = getChoice("b", "q", "d");
            }
            else if ((FoundQui == false) && (TakeWand == true) && (Herm == false))
            {
                Console.WriteLine("You can use the bridge(B), use the wand(W), or use the door that you just came in(D)");
                choice = getChoice("b", "w", "d");
            }
           
            else if (Herm == true)
            {
                Console.WriteLine("You can use your quidditch broom to make it to the next door(D), or use the bridge(B)");
                choice = getChoice("d", "b");
            }
            else
            {
                Console.WriteLine("You can use the bridge(B), or use the door that you just came in(D)");
                choice = getChoice("b", "d");
            }
            
            
            if (choice == "b")
            {
                Console.WriteLine("Sorry, the bridge is not safe! It ends up breaking.");
                Console.WriteLine("Game over!!!");
                NextScene = "GameOver";

            }
            else if (choice == "q")
            {
                Console.WriteLine("Good choice! You cross the river and you take the door which takes you to another room...");
                NextScene = "PotionsClass";

            }
            else if (choice == "w")
            {
                Console.WriteLine("Sorry, the wand doesn't work in this room! There is nothing you can do to fix the bridge.");
                Console.WriteLine("Try something else!");

            }

            else if (choice == "d")
            {
                Console.WriteLine("the door takes you to... ");
                NextScene = "EmptyRoom";

            }
        }
                 
            
       
         private void PotionsClass()
        {
            Console.WriteLine("POTIONS CLASS:");
            Console.WriteLine("You made it to the potions class. Hermione is here!!");
            Console.WriteLine("HERMIONE: 'Harry, we need to get out of here as soon as possible! It is too dangerous to stay here. Let's go!'");
            Console.WriteLine("You (Hermione and Harry) are together now, it will be easier to find the way out.");
            Console.WriteLine("There is no other way out of the room. You can only use the door that you just came in.");
            
            

            Console.WriteLine("You can use the door(D)");
            string choice = getChoice("d");

            if (choice == "d")
            {
               Console.WriteLine("The door takes you back to the bridge...");
                NextScene = "Bridge";
                Herm = true; 
                                     
            }
            
            
            
        }
         private void Library()
        {
            Console.WriteLine("LIBRARY:");
            Console.WriteLine("You are in the Library. It is kinda dark but you see someone at the end of the room. He is freaking out.");
            Console.WriteLine("RON: 'Who is there?'");
            Console.WriteLine("It is Ron!!");
            Console.WriteLine("RON: I'm so glad to see you here! I don't know for how long I've been in this room but we need to leave!");
            Console.WriteLine("By the way, Dumbledor gave me this map. He said that I might need it. But I guess it doesn't matter now. Let's go!'");

            Console.WriteLine("You can only use the door to go back to the empty room(D)");
            string choice = getChoice("d");


            if (choice == "d")
            {
                Console.WriteLine("The door takes you back to the empty room...");
                NextScene = "EmptyRoom";
                Map = true;                
            }
            
            
        }


        private void DoorsRoom()
        {
            Console.WriteLine("DOORS ROOM:");
            Console.WriteLine("You are in a room with a lot of doors. 25 doors at least. You need to figure it out which one is the right door to get out of the game.");
            Console.WriteLine("You only have one chance. If you don't pick the right door, the game will be over. It's time to pick one door. ");
            Console.WriteLine("Remember that you only have one chance.");
            
            string choice;
            if (Map == false)
            {
           
            Console.WriteLine("You can pick one door randomly(D), or go back to the trophies room(T)");
            choice = getChoice("t","d");
            }
            else
            {
            Console.WriteLine("You can pick one door randomly(D), use the map(M), or go back to the trophies room(T)");
            choice = getChoice("t","d","m");
            }

             if (choice == "d")
            {
                Console.WriteLine("Sorry, you didn't pick the right door.");
                Console.WriteLine("Game Over!!!");
                 NextScene = "GameOver";
                
                                     
            }
            else if (choice == "t")
            {
                Console.WriteLine("The door takes you back to the trophies room...");
                NextScene = "TrophiesRoom";
                                
            }
             else if (choice == "m")
            {
                Console.WriteLine("The map shows you which one is the right door and you take it...");
                NextScene = "TheEnd";
                                
            }
           
        }

        private void TheEnd()
        {
            Console.WriteLine("THE END:");
            Console.WriteLine("You made it! You escape from Voldemort and the dark ones. You and your friends are safe now!!");
            Console.WriteLine("Thanks for playing!!");
            NextScene = "GameOver";
        }
    }
}

   



