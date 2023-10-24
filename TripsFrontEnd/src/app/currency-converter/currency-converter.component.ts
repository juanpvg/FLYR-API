import { Component } from '@angular/core';

@Component({
  selector: 'app-currency-converter',
  templateUrl: './currency-converter.component.html',
  styleUrls: ['./currency-converter.component.css']
})
export class CurrencyConverterComponent {
  conversionData = {}
  API_KEY = '04a37249a8b66ddafd965beac5c41866';
  API_CURRENCIES = 'EUR,GBP,CAD,PLN'
  API_BASE = 'USD'
  
  loadConversionData(){
    const fetchData = async () => {
      try {
          //const res = await fetch(`http://apilayer.net/api/live?access_key=04a37249a8b66ddafd965beac5c41866&currencies=EUR,GBP,CAD,PLN&source=USD`)
          const res = await fetch(`http://apilayer.net/api/live?access_key=${this.API_KEY}&currencies=${this.API_CURRENCIES}&source=${this.API_BASE}`)
          const data = await res.json();
          this.conversionData = data;
          return data;
      } catch (error) {
          return(error);
      }
    }
    return fetchData();
  }

}
