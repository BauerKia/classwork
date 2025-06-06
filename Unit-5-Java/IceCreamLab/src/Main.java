import java.util.*;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        //Cannot be primitive
        Map<String, Integer> voteCount = new TreeMap<String, Integer>();
        List<String> famNames = new ArrayList<>();
        famNames.add("Elizabeth");
        famNames.add("Charles");
        famNames.add("Anne");
        famNames.add("Andrew");
        famNames.add("Edward");

        Scanner theKey = new Scanner(System.in);

        System.out.println("Please give me some ice cream flavor options formated as such: flavor1, flavor1, ...");
        String userF = theKey.nextLine().toLowerCase();
        String[] flavParts = userF.split(",");
        List<String> flavList = Arrays.asList(flavParts);
        Set<String> flavors = new TreeSet<String>(flavList);


        //Loop through famNames
        //Ask each member to print out name
        //Ask which flavor they would vote for
        //Validate the flavor is in the Set flavors
        //If it is not, keep asking until they print a flavor that does.
        for(String n : famNames){
            boolean realFlav = false;
            int count = 0;
            do {
                System.out.println(String.format("Let's vote on ice cream flavors. Here are your options: \n%s", flavors));
                System.out.println(String.format("Which flavor do you want to vote for %s", n));

                String famFlavor = theKey.nextLine().toLowerCase();
                    if(flavors.contains(famFlavor)){
                        if(voteCount.containsKey(famFlavor)) {
                            //This "gets" the value of a key which is the flavor
                            count = voteCount.get(famFlavor) + 1;
                            //Setting the new count
                            voteCount.put(famFlavor, count);
                        }else{
                            //This is creating the new vote
                            voteCount.put(famFlavor, 1);
                        }
                        realFlav = true;
                    } else{
                        System.out.println("This is not a valid flavor. Please try again.");
                    }

            }while (realFlav);
            System.out.println(String.format("Thank you for your vote %s!", n));
        }





    }
/*
* Determine the highest vote count from the map values.
* Then loop through the map
* print the names of the flavors that had that vote count.
* (Note: Allowing for ties, there may be multiple flavors that have the same top vote count.)
 */
//    public String getHighestVote(TreeMap m){
//        String lastF = "";
//        String oldF = "";
//        for(TreeMap<String, Integer> f : m.entrySet()){
//            String currentF = f;
//            if (oldF == 0 || currentF < oldF){
//                oldF = currentF;
//                lastF = c;
//            } else if( currentF == oldF){
//                System.out.println(String.format("The flavors with the most are: \n%s", lastF));
//            }
//
//        }
//        return lastF;
//    }
}