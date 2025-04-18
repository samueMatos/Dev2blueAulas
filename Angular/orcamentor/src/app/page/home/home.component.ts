import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

  constructor(private route: ActivatedRoute) {
  }
  ngOnInit() {
    this.route.params.subscribe(params => {
      if (params['id'] !== undefined) {
        alert('id: ' + params['id']);
      }
    });

  }

}
