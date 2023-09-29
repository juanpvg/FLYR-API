import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-flight-list',
  templateUrl: './flight-list.component.html',
  styleUrls: ['./flight-list.component.css'],
})
export class FlightListComponent implements OnInit {
  data = [
    {
      origin: 'MZL',
      destination: 'CAN',
      price: 700,
      flights: [
        {
          origin: 'MZL',
          destination: 'MDE',
          price: 200,
          transport: {
            flightCarrier: 'CO',
            flightNumber: '8001',
          },
        },
        // Add more flight details as needed
      ],
    },
    {
      origin: 'MZL',
      destination: 'CAN',
      price: 700,
      flights: [
        {
          origin: 'MZL',
          destination: 'MDE',
          price: 200,
          transport: {
            flightCarrier: 'CO',
            flightNumber: '8001',
          },
        },
        // Add more flight details as needed
      ],
    },
    // Add more flight data objects as needed
  ];

  constructor() {}

  ngOnInit(): void {}
}