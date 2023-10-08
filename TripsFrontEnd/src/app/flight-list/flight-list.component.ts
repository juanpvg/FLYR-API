import { Component, Input,  OnInit } from '@angular/core';

@Component({
  selector: 'app-flight-list',
  templateUrl: './flight-list.component.html',
  styleUrls: ['./flight-list.component.css'],
})
export class FlightListComponent implements OnInit {
  @Input() data : any;

  
  flight = {
    flightId: 0,
    origin: '',
    destination: '',
    price: 0
  };

  journey = {
    flightId: 0,
    origin: '',
    destination: '',
    price: 0,
    flights: []
  };


  constructor() {}

  ngOnInit(): void {}
}