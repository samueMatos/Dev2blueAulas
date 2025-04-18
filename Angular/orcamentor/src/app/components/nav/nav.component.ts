import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router,RouterModule } from '@angular/router';
import { environment } from '../../../environments/environment';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-nav',
  standalone: true,
  imports: [RouterModule,CommonModule,FormsModule,NavComponent],
  templateUrl: './nav.component.html',
  styleUrl: './nav.component.css'
})
export class NavComponent {
  
  nomeProjeto = environment.nomeProjeto

  route = new Router;
  logout(){
    this.route.navigate(['/login']);
  }
}
