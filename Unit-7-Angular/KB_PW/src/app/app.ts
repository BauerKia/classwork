import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Header } from './components/header/header';
import { Projects } from './components/projects/projects';
import { Portfolio } from './components/portfolio/portfolio';
import { Home } from './components/home/home';
import { Experience } from './components/experience/experience';
import { Skills } from './components/skills/skills';
import { SideBar } from './components/side-bar/side-bar'


@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Skills, Header, Projects , Portfolio, Home, Experience, SideBar],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected title = 'KB_PW';
}
