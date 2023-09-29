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
  }
}


/*import { Component } from '@angular/core';

@Component({
  selector: 'app-flight-form',
  templateUrl: './flight-form.component.html',
  styleUrls: ['./flight-form.component.css']
})
export class FlightFormComponent {

}
*/