// This starts the Angular Applications
//When you do ng serve it looks for main.ts to start app
// This is where you define the coponent representing the home page

import { bootstrapApplication } from '@angular/platform-browser'; //Starts the Angular app
import { appConfig } from './app/app.config'; // Angulare app configuration information


//Specify the folder containing the home page and its name

//import {name-used-in-this-code} from 'path-to-the-component-file'
// The component path contains the folder and the high-level name of the component
// THe component path is relative to the src folder
// ./app/app
// . = the folder you are in (src folder)
// /app = the app folder named app in the folder you are in
// /app = all files related to the component will start with 'app'
//        .component is assumed
//**** */The name of the import must match an export class in a Typescript file *****
import { App } from './app/app'; //Get the Angular component stuff from './app/app'
/*
* Alternative: Clearer coding technique
* import { App } from './app/app.component';
*/



// bootstrapApplication function is what the Angular server calls to start the app
// Give it: (name-of-import-for-component, configuration)
bootstrapApplication(App, appConfig)
  .catch((err) => console.error(err));
