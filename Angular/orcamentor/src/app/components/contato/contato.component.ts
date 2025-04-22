import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-contato',
  standalone: true,
  imports: [],
  templateUrl: './contato.component.html',
  styleUrl: './contato.component.css'
})
export class ContatoComponent {
  @Input() id:number = 0;
  @Input() nome:string = '';
  @Input() email:string = '';
  @Input() numero:string = '';
  @Input() checked:boolean = false;
}
