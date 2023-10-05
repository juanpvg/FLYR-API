import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { list } from 'postcss';

@Component({
  selector: 'app-flight-form',
  templateUrl: './flight-form.component.html',
  styleUrls: ['./flight-form.component.css'],
})
export class FlightFormComponent {
  newData = [];

  searchFlight = {
    origin: '',
    destination: '',
  };

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



  data: any;

  onSubmit() {
    console.log(this.searchFlight);
    const response = this.searchFlights(this.searchFlight.origin, this.searchFlight.destination);
    this.data = response;
    console.log("response:");
    console.log(response);
  }

    
  searchFlights(origin:string,  destination:string){
    const fetchData = async (origin:string, destination:string) => {
      try {
          const res = await fetch(`https://localhost:7135/api/Journey?origin=${origin}&destination=${destination}`)
          const data = await res.json();
          console.log("información:");
          console.log(data);
          this.newData = data;
          console.log(this.newData);
          return data;
      } catch (error) {
        console.log("error:");
        console.log(error);
          return(error);
      }
    }
    return fetchData(origin,destination);
  }

}


/*
function searchFlights(origin:string,  destination:string){
  const fetchData = async (origin:string, destination:string) => {
    try {
        const res = await fetch(`https://localhost:7135/api/Journey?origin=${origin}&destination=${destination}`)
        const data = await res.json();
        console.log("información:");
        console.log(data);
        return data;
    } catch (error) {
      console.log("error:");
      console.log(error);
        return(error);
    }
  }
  return fetchData(origin,destination);
}
*/
