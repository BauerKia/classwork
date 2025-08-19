import { Routes } from '@angular/router';
import { Header } from './components/header/header';
import { Projects } from './components/projects/projects';
import { Portfolio } from './components/portfolio/portfolio';
import { Home } from './components/home/home';
import { Experience } from './components/experience/experience';
import { Skills } from './components/skills/skills';
import { SideBar } from './components/side-bar/side-bar'

export const routes: Routes = [
{path: 'home',     component: Home},
{path: 'skills',     component: Skills},
{path: 'projects',     component: Projects},
{path: 'portfolio',     component: Portfolio},
{path: 'experience',     component: Experience},
  {path: 'header',     component: Header},
  {path: 'sidebar',      component: SideBar}
  ];
