import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-data-list',
  templateUrl: './flight-list.component.html',
  styleUrls: ['./flight-list.component.css'],
})
export class FlightListComponent implements OnInit {
  data = [
    { Origin: 'MDE', Destination: 'BOG', price: 200 },
    { Origin: 'BOG', Destination: 'MIA', price: 300 },
    // Add more data objects as needed
  ];

  constructor() {}

  ngOnInit(): void {}
}


/*
import { Component } from '@angular/core';

@Component({
  selector: 'app-flight-list',
  templateUrl: './flight-list.component.html',
  styleUrls: ['./flight-list.component.css']
})
export class FlightListComponent {

}
*/
