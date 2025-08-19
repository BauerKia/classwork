import { Component } from '@angular/core';
import { AfterViewInit } from '@angular/core';
import { ElementRef } from '@angular/core';
import { QueryList } from '@angular/core';
import { ViewChildren } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'side-bar',
  imports: [RouterOutlet, CommonModule],
  templateUrl: './side-bar.html',
  styleUrl: './side-bar.css'
})
export class SideBar implements AfterViewInit {
 isClosed = true;

   @ViewChildren('menuItem') menuItemEls!: QueryList<ElementRef<HTMLElement>>;

   ngAfterViewInit(): void {
     const items = this.menuItemEls.toArray();

     items.forEach((elRef, i) => {
       const el = elRef.nativeElement;
       el.style.setProperty('--delay-in', `${i * 0.1}s`);
       el.style.setProperty('--delay-out', `${(items.length - i) * 0.1}s`);
     });

   setTimeout(() => {
     this.toggleMenu();
     setTimeout(() => this.toggleMenu(), 4000);
   }, 1000);
   }

   toggleMenu(): void {
     this.isClosed = !this.isClosed;
   }

}
