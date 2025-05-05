
import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CdbCalculationResult } from './models/cdb-calculation-result';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'] 
})
export class AppComponent {
  valorInicial = 0;
  prazoMeses = 2;
  resultado: CdbCalculationResult | null = null;
  alertaValor = '';
  alertaPrazo = '';

  constructor(private readonly http: HttpClient) { }
  calcular() {
    this.alertaValor = '';
    this.alertaPrazo = '';

    if (!this.valorInicial || this.valorInicial <= 0) {
      this.alertaValor = 'O valor inicial deve ser maior que 0.';
    }

    if (!this.prazoMeses || this.prazoMeses <= 1) {
      this.alertaPrazo = 'O prazo deve ser maior que 1.';
    }

    if (this.alertaValor || this.alertaPrazo) {
      return;
    }

    const data = {
      valorInicial: this.valorInicial,
      prazoMeses: this.prazoMeses
    };
    this.http.post<CdbCalculationResult>('/calculocdb', data)
      .subscribe({
        next: res => this.resultado = res,
        error: err => console.error('Erro ao calcular:', err),
        complete: () => console.log('Requisição finalizada')
      });
    
    
  }
  limpar() {
    this.valorInicial = 0;
    this.prazoMeses = 2;
    this.resultado = null;
    this.alertaValor = '';
    this.alertaPrazo = '';
  }

}
