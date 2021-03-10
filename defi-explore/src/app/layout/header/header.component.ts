import { Component, OnInit } from '@angular/core';
import { TabView } from './tab';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
  public tabTitles: TabView[] = [
    {
      title : "Market",
      icon : "",
    },
    {
      title : "AI analysis",
      icon : "",
    },
    {
      title : "Portfolio",
      icon : "",
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }
}
