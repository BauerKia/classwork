//First thing you do to create a new class is define
// to create inside of the class

package Pet;

import java.util.Objects;

/*
* This class will represent Pet information for a Pets
* Data: Type of Pet (Dog, Cat, Gerbil, Lizard, Bird etc)
*       Gender
*       Weight (lbs)
*       Is it spayed or neutered?
*
* Behaviors (methods):
*       1. you should always have at least one constructor to initialize the class
*               a default ctor (in case Jave needs it; Jave uses the default ctor for some of the processing
*                                                                           behind the scenes, if needed)
*               at least one ctor that takes arguments used to intialize the object
*
*       2. Getters and Setters to allow controlled access to private data members (Encapsulation)
*
*       3. Object method overrides to get the behaviour you want fromt the methods:
*               toString() - Represent the class data as a String rather than show location@Package.Class
*               equals() - to determine a hash code based on the content of the location in memory
*               hashCode() - To generate a hash code based on the content of the object not
*                               it's location in memory
*                       The same data member used in equals should be used hashCode() sp
*                       objects that are equal have equal hash code.
*
*       4. Additional Method to support the class (i.e. display method)
 *
 *      A class that has data and methods in items 1 through 3 is known as a POJO
 *      (Plain Old Java Object)
 * */
public class Pet {

    /****************************
     * Member Data - Should be always private to support Encapsulation
     ****************************/

    private String petName;
    private String petType;
    private char petGender;
    private int petWeight;
    private boolean isSpayed; // boolean varaibles are usaually started with "is"

    /****************************
     * Constructors - Initialize objects instantiated for a class
     ****************************/

    // Default ctor - define an empty object (we don't knpw default pet info)

    public Pet(){} // ctor that takes no arguments and doesn't do anything
    //Ctor that initializes using arguments passed to the constructor


    public Pet( String petName, String petType, char petGender, int petWeight, boolean isSpayed) {

        //Why is this. used in these statements?
        // BECAUSE the parameter names are the same as the data member names
        //      this. is used to reference the data member and not the parameter

        // Doing: Taking data passed in assigning to private
        this.petName = petName; // Copy the petName parameter to the petName data member
        this.petType = petType;
        this.petGender = petGender;
        this.petWeight = petWeight;
        this.isSpayed = isSpayed;
    }

    /****************************
     * Standard getters and setters to allow controlled access to private data members (Encapsulation)

    Standard  names: getters - getVariableName  setters - setVariableName

     ****************************/
    public String getPetName() {
        return petName;
    }

    public void setPetName(String petName) {
        this.petName = petName;
    }

    public String getPetType() {
        return petType;
    }

    public void setPetType(String petType) {
        this.petType = petType;
    }

    public char getPetGender() {
        return petGender;
    }

    public void setPetGender(char petGender) {
        this.petGender = petGender;
    }

    public int getPetWeight() {
        return petWeight;
    }

    public void setPetWeight(int petWeight) {
        this.petWeight = petWeight;
    }

    public boolean isSpayed() {
        return isSpayed;
    }

    public void setSpayed(boolean spayed) {
        isSpayed = spayed;
    }


    /****************************
     * Object method overrides to get the behaviour you want fromt the methods:
     * *               toString() - Represent the class data as a String rather than show location@Package.Class
     * *               equals() - to determine a hash code based on the content of the location in memory
     * *               hashCode() - To generate a hash code based on the content of the object not
     * *                               it's location in memory
     * *                       The same data member used in equals should be used hashCode() sp
     * *                       objects that are equal have equal hash code.
     ****************************/

    @Override
    public String toString() {
        return "Pet{" +
                "petName='" + petName + '\'' +
                ", petType='" + petType + '\'' +
                ", petGender=" + petGender +
                ", petWeight=" + petWeight +
                ", isSpayed=" + isSpayed +
                '}';
    }

    @Override
    // equals receives a generic Object - NOT an object of the class
    //We have to check or cast the generic object to an object of the class
    public boolean equals(Object o) {
        if (!(o instanceof Pet pet)) return false;
        return getPetGender() == pet.getPetGender() && getPetWeight() == pet.getPetWeight() && isSpayed() == pet.isSpayed() && Objects.equals(getPetName(), pet.getPetName()) && Objects.equals(getPetType(), pet.getPetType());
    }

    @Override

    public int hashCode() {
        return Objects.hash(getPetName(), getPetType(), getPetGender(), getPetWeight(), isSpayed());
    }

    /****************************
     * Addtional methods to support the class
     ****************************/
    public void displayPet(){
        System.out.println(this); // Display the object used to invoke the method (implied: uses the toString())
    }

}
