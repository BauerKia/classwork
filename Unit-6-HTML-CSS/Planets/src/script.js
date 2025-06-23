


//Object - We are initializing these by defining them
let planets = [];
function objects(){

const planet1 = {
name: "Mercury", inner: true, diameter: 3031.9, color: "#696969"
};

const planet2 = {
name: "Venus", inner: true, diameter: 7520.8, color: "#b89165"
};

const planet3 = {
name: "Earth", inner: true, diameter: 7917.5, color: "#5a5b86"
};

const planet4 = {
name: "Mars", inner: true, diameter: 4212.3, color: "#df8c4e"
};

const planet5 = {
name: "Jupiter", inner: false, diameter: 86881, color: "#f6a049"
};

const planet6 = {
name: "Saturn", inner: false, diameter: 72367, color: "#dcd3a1"
};

const planet7 = {
name: "Uranus", inner: false, diameter: 31518, color: "#b4d9df"
};

const planet8 = {
name: "Neptune", inner: false, diameter: 30599, color: "#456eff"
};
planets = [planet1, planet2, planet3, planet4, planet5,planet6, planet7, planet8];

}
//planets array does not work without this initializing
//Find another way to do this becuase there has to be one
objects();

//Functions

function pNames(param1){
let planetNames = [];
for(let i=0; i < param1.length; i++) {
//getting the name from the planets array key:value for each index
planetNames.push(param1[i].name);
  }
  return planetNames;
}

//Is this even needed?
//console.log(pNames(planets));

function avgDia(param1){
let avg = 0;
for(let i=0; i < param1.length; i++) {
avg = avg + param1[i].diameter;
  }
return avg / param1.length;
}

console.log(avgDia(planets));


let index = 0;


function update() {

// Phase 3
//Stop it from going into the negatives or too high
if( index < 0) index = 0;
if(index >= planets.length) index = planets.length - 1;

document.getElementById("name").textContent = planets[index].name;
document.getElementById("inner").textContent = planets[index].inner;
const circle = document.getElementById("visual").textContent;
circle.style.backgroundColor = planets[index].color;

const size = planets[index].diameter / 100;
circle.style.width = size + "px";
circle.style.height = size + "px";

document.getElementById("index").textContent = index;

document.getElementById("previous").disabled = (index === 0);
document.getElementById("next").textContent = (index === planets.length - 1);




}
//phase 2
function subtractOne() {
          index--;
          update();
}
function addOne() {
          index++;
          update();
}



