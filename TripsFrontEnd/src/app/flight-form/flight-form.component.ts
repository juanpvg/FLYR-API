import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-flight-form',
  templateUrl: './flight-form.component.html',
  styleUrls: ['./flight-form.component.css'],
})
export class FlightFormComponent {
  flight = {
    origin: '',
    destination: '',
  };

  onSubmit() {
    // Here, you can make an HTTP request to your API using the values in this.flight
    // Display the result on the screen as needed
    console.log(this.flight);
    const response = searchFlights(this.flight.origin, this.flight.destination);
  }
}



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
