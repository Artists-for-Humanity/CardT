namespace game{
    public class Card{ 
        public string name, ability;
        public int attack, hp, cost;
        Card(string name, int atk, int hp, int cost, string ability){ 
            this.name = name;
            attack = atk;
            this.hp = hp;
            this.cost = cost;
            this.ability = ability;
        }
        public int attack{
            get { return : attack}
            set {
                if (value >= 0){
                    attack = value;
                } else {
                    attack = 0; 
                }
            }
        }
        public int hp{
            get{ return: hp}
            set {
                if ((value) >= 0){
                    hp = value;
                } else {
                    hp = 0; 
                }
            }
        }
        public static void Main(string[] args){
            ArrayList cardList = new ArrayList();
            cardList.Add(new Card("Loyal Squirrel", 1, 2, 1, "Perfect Pawn"));
            cardList.Add(new Card("Crazy Crow", 2, 3, 2, "Restless"));
            cardList.Add(new Card("Lazy Lion", 4, 7, 3, "Sloth"));
            cardList.Add(new Card("Hyena", 1, 4, 2, "Pack Mentality"));
            cardList.Add(new Card("Flying Manatee", 1, 4, 2, "Defense Expert"));
            cardList.Add(new Card("Tortoise",2,6,3,"Stance Change"));
            cardList.Add(new Card("Walrus",1,1,2,"Thick Blubber"));
            cardList.Add(new Card("Peaceful Elephant",0,8,3,"Vengeful"));
            cardList.Add(new Card("Cute Badger",1,3,1,"Tough Skin"));
            cardList.Add(new Card("Raccoon",2,4,4,"Master Thief"));
            cardList.Add(new Card("Praying Mantis",2,3,2,"Attack Expert"));
            cardList.Add(new Card("Chipmunk",0,2,0,"Painfully Average"));
            cardList.Add(new Card("Sacrificial Lamb",0,1,1,"Perfect Sacrifice"));
            cardList.Add(new Card("Quokka",0,3,1,"Inspiring"));
            cardList.Add(new Card("Praire Dog",1,4,2,"Sweet Sound"));
            cardList.Add(new Card("Skunk",1,3,1,"Potent Stench"));
            cardList.Add(new Card("Lowly Mole",0,3,0,"Painfully Average"));
            cardList.Add(new Card("Hamster",1,2,0,"Painfully Average"));
            cardList.Add(new Card("Pig",1,6,4,"Blood For The Blood God"));
            cardList.Add(new Card("Cow",1,5,3,"Distraction"));
            cardList.Add(new Card("Sloth",0,5,2,"Slow Influence"));
            cardList.Add(new Card("Rabbit",1,3,2,"Family"));
            cardList.Add(new Card("Axolotl",3,3,2,"Doctor Knows Best"));
            cardList.Add(new Card("Giving Camo",0,2,1,"Giving Camo"));
            cardList.Add(new Card("Kangaroo",4,3,3,"Boxer"));
            cardList.Add(new Card("Tiger",3,4,3,"Mimicry"));
            cardList.Add(new Card("Hippopotamus",2,5,3,"Berserker"));
            cardList.Add(new Card("Baby Jaguar",0,2,1,"Baby"));
        }
        
    }
}