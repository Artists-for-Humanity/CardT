public class Item {
    private static int capacity=3;
    private int size;
    private string itemName;
    public Item(string name, int s){
        itemName = name;
        size = s;
    }
    public void useItem(){
        switch (itemName){
            case "Bottled Miracle":
                //add to a variable like "stun" so that the enemy is stunned for a turn if it is above 1
                break;
            case "Divine Smite":
                //whatever is clicked upon -6 to hp stat
                break;
            case "Medkit":
                //pull up deck and revive card clicked upon
                break;
            case "Band-aid":
                //heal clicked upon card by 5
                break;
            case "Third Eye":
                break;
            case "Strange Potion":
                break;
            case "Broken Pocketwatch":
                break;
        }
    }
    public static void Main(string[] args){
        ArrayList items = new ArrayList();
        items.Add("Bottled Miracle", 2);
        items.Add("Divine Smite", 1);
        items.Add("Medkit", 1);
        items.Add("Band-aid", 1);
        items.Add("Third Eye", 2);
        items.Add("Strange Potion",1);
        items.Add("Broken Pocketwatch",3);
    }
}