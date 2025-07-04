import { Component } from '@angular/core';

@Component({
  selector: 'pet-display',
  imports: [],
  templateUrl: './pet-display.html',
  styleUrl: './pet-display.css'
})
export class PetDisplay {
ourPetInfo : PetInfo[] = []

constructor(thePetData : PetService){

  this.ourPetInfo = thePetData.getPetData();
  }
}
