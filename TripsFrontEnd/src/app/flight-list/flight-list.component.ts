import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-flight-list',
  templateUrl: './flight-list.component.html',
  styleUrls: ['./flight-list.component.css'],
})
export class FlightListComponent  {
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


}