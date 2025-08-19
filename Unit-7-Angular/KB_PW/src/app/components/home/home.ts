import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Header } from '../header/header';

@Component({
  selector: 'home',
  imports: [RouterOutlet, Header],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {

}
